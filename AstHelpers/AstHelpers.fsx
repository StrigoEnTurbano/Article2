#load "RecordExts.fsx"
open RecordExts
#load "UnionExts.fsx"
open UnionExts

open Fantomas.FCS
open Fantomas.FCS.Syntax
open Fantomas.FCS.Xml
open Fantomas.FCS.Text
open Fantomas.FCS.Text.Range
open Fantomas.FCS.SyntaxTrivia

let inline (^) f x = f x

fsi.AddPrinter ^ fun (p : Range) -> 
    if p.StartLine = p.EndLine 
    then
        if p.StartColumn = p.EndColumn 
        then $"{p.StartLine},{p.StartColumn}"
        else $"{p.StartLine},{p.StartColumn}-{p.EndColumn}"
    else $"{p.StartLine},{p.StartColumn}-{p.EndLine},{p.EndColumn}"

fsi.AddPrinter ^ fun (p : PreXmlDoc) ->
    if p.IsEmpty then 
        "PreXmlDoc.Empty"
    else
        p.ToXmlDoc(false, None).UnprocessedLines
        |> String.concat "\\n"
        |> sprintf "PreXmlDoc %A"

fsi.AddPrinter ^ fun (SynLongIdent (p, _, _)) -> 
    p
    |> Seq.map ^ fun p -> p.idText
    |> String.concat "." 
    |> sprintf "SynLongIdent %A"
    
fsi.AddPrinter ^ fun (p : Ident) ->
    sprintf "Ident %A" p.idText

fsi.AddPrinter ^ fun (p : LongIdent) ->
    p
    |> Seq.map ^ fun p -> p.idText
    |> String.concat "."
    |> sprintf "LongIdent %A" 

module Ident =
    let parse str = Ident(str, Range.Zero)
    
    let parseLong str : LongIdent =
        (str : string).Split(".", System.StringSplitOptions.RemoveEmptyEntries)
        |> Seq.map parse
        |> List.ofSeq
    
    let parseSynLong str = 
        let parsed = parseLong str
        SynLongIdent(parsed, [for _ in parsed.Tail -> Range.Zero], [for _ in parsed -> None])

    let parseSynType str = SynType.LongIdent ^ parseSynLong str

    let parseSynExprLong str = SynExpr.LongIdent(false, parseSynLong str, None, Range.Zero)

    let parseSynIdent str = SynIdent(parse str, None)

module Code =
    let fromModules modules = 
        ParsedImplFileInput.CreateByDefault(
            "—юзанна.fs"
            , QualifiedNameOfFile.QualifiedNameOfFile ^ Ident.parse "—юзанна.fs"
            , (false, false)
            , ParsedImplFileInputTrivia.CreateByDefault()
            , contents = modules
        )
        |> ParsedInput.ImplFile
        |> Fantomas.Core.CodeFormatter.FormatASTAsync
        |> Async.RunSynchronously

    let fromDecls decls =
        fromModules [
            SynModuleOrNamespace.CreateByDefault(
                Ident.parseLong "—юзанна.fs"
                , SynModuleOrNamespaceKind.AnonModule
                , SynModuleOrNamespaceTrivia.CreateByDefault SyntaxTrivia.SynModuleOrNamespaceLeadingKeyword.None
                , decls = decls
            )
        ]

type SynExpr with
    static member app arg f =
        SynExpr.App(
            ExprAtomicFlag.NonAtomic
            , false
            , f
            , arg
            , Range.Zero
        )

    static member appInfix operator arg = 
        SynExpr.App(
            ExprAtomicFlag.NonAtomic
            , true
            , operator
            , arg
            , Range.Zero
        )

    static member pipeRight f arg = 
        arg
        |> SynExpr.appInfix ^ SynExpr.LongIdent (
            false
            , SynLongIdent.SynLongIdent(
                id = Ident.parseLong "op_PipeRight",
                dotRanges = [],
                trivia = [ Some(IdentTrivia.OriginalNotation("|>")) ]
            )
            , None
            , Range.Zero
        )
        |> SynExpr.app f

    static member paren content =
        SynExpr.Paren.CreateByDefault(
            content
            , rightParenRange = Some Range.Zero
        )

    static member tuple items =
        SynExpr.Tuple.CreateByDefault(
            exprs = items
            , commaRanges = [for _ in items.Tail -> Range.Zero]
        )

type SynValData with
    static member empty =
        SynArgInfo.CreateByDefault()
        |> SynValInfo.CreateByDefault
        |> SynValData.CreateByDefault