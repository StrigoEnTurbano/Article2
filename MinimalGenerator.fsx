#load "AstHelpers\AstHelpers.fsx"

open Fantomas.FCS
open Fantomas.FCS.Text
open Fantomas.FCS.Xml
open Fantomas.FCS.Syntax
open Fantomas.FCS.SyntaxTrivia
open FSharpx.Collections

open UnionExts
open RecordExts
open AstHelpers

Code.fromModules [
    SynModuleOrNamespace.CreateByDefault(
        Ident.parseLong "AssemblyCompilation"
        , SynModuleOrNamespaceKind.NamedModule
        , SynModuleOrNamespaceTrivia.CreateByDefault(
            SynModuleOrNamespaceLeadingKeyword.Module.CreateByDefault()
        )
        , decls = [
            let letBinding name body =
                SynModuleDecl.Let.CreateByDefault(
                    bindings = [
                        SynBinding.CreateByDefault(
                            SynValData.empty
                            , SynPat.Named.CreateByDefault(
                                Ident.parseSynIdent name
                            )
                            , body
                            , SynBindingTrivia.CreateByDefault(
                                SynLeadingKeyword.Let.CreateByDefault()
                                , equalsRange = Some Range.Zero
                            )
                        )
                    ]
                )

            SynConst.String.CreateByDefault System.Environment.MachineName
            |> SynExpr.Const.CreateByDefault
            |> letBinding "machineName" 

            Ident.parseSynExprLong "System.DateTime"
            |> SynExpr.app (
                let args = [
                    let now = System.DateTime.UtcNow
                    now.Year
                    now.Month
                    now.Day
                    now.Hour
                    now.Minute
                    now.Second
                ]

                SynExpr.tuple [
                    for arg in args do
                        SynConst.Int32 arg
                        |> SynExpr.Const.CreateByDefault
                    Ident.parseSynExprLong "System.DateTimeKind.Utc"
                ]
                |> SynExpr.paren
            ) 
            |> letBinding "timestamp"
        ]
    )
]
|> fun content ->
    System.IO.File.WriteAllText(
        System.IO.Path.Combine(
            __SOURCE_DIRECTORY__
            , "AssemblyCompilation.fs"
        )
        , content
    )