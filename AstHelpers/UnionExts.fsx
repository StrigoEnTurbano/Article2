#i "nuget: https://api.nuget.org/v3/index.json"
#r "nuget: Fantomas.Core, 6.2.1"
#r "nuget: FSharpx.Collections, 3.1.0"

open Fantomas.FCS
open Fantomas.FCS.Text
open Fantomas.FCS.Xml
open Fantomas.FCS.Syntax
open Fantomas.FCS.SyntaxTrivia
open FSharpx.Collections

module IdentTrivia =
    type OriginalNotation =
        static member CreateByDefault(text) = IdentTrivia.OriginalNotation(text)

    type OriginalNotationWithParen =
        static member CreateByDefault(text, ?leftParenRange, ?rightParenRange) =
            IdentTrivia.OriginalNotationWithParen(
                leftParenRange |> Option.defaultValue Range.Zero,
                text,
                rightParenRange |> Option.defaultValue Range.Zero
            )

    type HasParenthesis =
        static member CreateByDefault(?leftParenRange, ?rightParenRange) =
            IdentTrivia.HasParenthesis(
                leftParenRange |> Option.defaultValue Range.Zero,
                rightParenRange |> Option.defaultValue Range.Zero
            )

module ConditionalDirectiveTrivia =
    type If =
        static member CreateByDefault(expr, ?range) =
            ConditionalDirectiveTrivia.If(expr, range |> Option.defaultValue Range.Zero)

    type Else =
        static member CreateByDefault(?range) =
            ConditionalDirectiveTrivia.Else(range |> Option.defaultValue Range.Zero)

    type EndIf =
        static member CreateByDefault(?range) =
            ConditionalDirectiveTrivia.EndIf(range |> Option.defaultValue Range.Zero)

module IfDirectiveExpression =
    type And =
        static member CreateByDefault(item1, item2) = IfDirectiveExpression.And(item1, item2)

    type Or =
        static member CreateByDefault(item1, item2) = IfDirectiveExpression.Or(item1, item2)

    type Not =
        static member CreateByDefault(item) = IfDirectiveExpression.Not(item)

    type Ident =
        static member CreateByDefault(item) = IfDirectiveExpression.Ident(item)

module CommentTrivia =
    type LineComment =
        static member CreateByDefault(?range) =
            CommentTrivia.LineComment(range |> Option.defaultValue Range.Zero)

    type BlockComment =
        static member CreateByDefault(?range) =
            CommentTrivia.BlockComment(range |> Option.defaultValue Range.Zero)

module SynTypeDefnLeadingKeyword =
    type Type =
        static member CreateByDefault(?item) =
            SynTypeDefnLeadingKeyword.Type(item |> Option.defaultValue Range.Zero)

    type And =
        static member CreateByDefault(?item) =
            SynTypeDefnLeadingKeyword.And(item |> Option.defaultValue Range.Zero)

    type StaticType =
        static member CreateByDefault(?staticRange, ?typeRange) =
            SynTypeDefnLeadingKeyword.StaticType(
                staticRange |> Option.defaultValue Range.Zero,
                typeRange |> Option.defaultValue Range.Zero
            )

module SynLeadingKeyword =
    type Let =
        static member CreateByDefault(?letRange) =
            SynLeadingKeyword.Let(letRange |> Option.defaultValue Range.Zero)

    type LetRec =
        static member CreateByDefault(?letRange, ?recRange) =
            SynLeadingKeyword.LetRec(
                letRange |> Option.defaultValue Range.Zero,
                recRange |> Option.defaultValue Range.Zero
            )

    type And =
        static member CreateByDefault(?andRange) =
            SynLeadingKeyword.And(andRange |> Option.defaultValue Range.Zero)

    type Use =
        static member CreateByDefault(?useRange) =
            SynLeadingKeyword.Use(useRange |> Option.defaultValue Range.Zero)

    type UseRec =
        static member CreateByDefault(?useRange, ?recRange) =
            SynLeadingKeyword.UseRec(
                useRange |> Option.defaultValue Range.Zero,
                recRange |> Option.defaultValue Range.Zero
            )

    type Extern =
        static member CreateByDefault(?externRange) =
            SynLeadingKeyword.Extern(externRange |> Option.defaultValue Range.Zero)

    type Member =
        static member CreateByDefault(?memberRange) =
            SynLeadingKeyword.Member(memberRange |> Option.defaultValue Range.Zero)

    type MemberVal =
        static member CreateByDefault(?memberRange, ?valRange) =
            SynLeadingKeyword.MemberVal(
                memberRange |> Option.defaultValue Range.Zero,
                valRange |> Option.defaultValue Range.Zero
            )

    type Override =
        static member CreateByDefault(?overrideRange) =
            SynLeadingKeyword.Override(overrideRange |> Option.defaultValue Range.Zero)

    type OverrideVal =
        static member CreateByDefault(?overrideRange, ?valRange) =
            SynLeadingKeyword.OverrideVal(
                overrideRange |> Option.defaultValue Range.Zero,
                valRange |> Option.defaultValue Range.Zero
            )

    type Abstract =
        static member CreateByDefault(?abstractRange) =
            SynLeadingKeyword.Abstract(abstractRange |> Option.defaultValue Range.Zero)

    type AbstractMember =
        static member CreateByDefault(?abstractRange, ?memberRange) =
            SynLeadingKeyword.AbstractMember(
                abstractRange |> Option.defaultValue Range.Zero,
                memberRange |> Option.defaultValue Range.Zero
            )

    type Static =
        static member CreateByDefault(?staticRange) =
            SynLeadingKeyword.Static(staticRange |> Option.defaultValue Range.Zero)

    type StaticMember =
        static member CreateByDefault(?staticRange, ?memberRange) =
            SynLeadingKeyword.StaticMember(
                staticRange |> Option.defaultValue Range.Zero,
                memberRange |> Option.defaultValue Range.Zero
            )

    type StaticMemberVal =
        static member CreateByDefault(?staticRange, ?memberRange, ?valRange) =
            SynLeadingKeyword.StaticMemberVal(
                staticRange |> Option.defaultValue Range.Zero,
                memberRange |> Option.defaultValue Range.Zero,
                valRange |> Option.defaultValue Range.Zero
            )

    type StaticAbstract =
        static member CreateByDefault(?staticRange, ?abstractRange) =
            SynLeadingKeyword.StaticAbstract(
                staticRange |> Option.defaultValue Range.Zero,
                abstractRange |> Option.defaultValue Range.Zero
            )

    type StaticAbstractMember =
        static member CreateByDefault(?staticRange, ?abstractMember, ?memberRange) =
            SynLeadingKeyword.StaticAbstractMember(
                staticRange |> Option.defaultValue Range.Zero,
                abstractMember |> Option.defaultValue Range.Zero,
                memberRange |> Option.defaultValue Range.Zero
            )

    type StaticVal =
        static member CreateByDefault(?staticRange, ?valRange) =
            SynLeadingKeyword.StaticVal(
                staticRange |> Option.defaultValue Range.Zero,
                valRange |> Option.defaultValue Range.Zero
            )

    type StaticLet =
        static member CreateByDefault(?staticRange, ?letRange) =
            SynLeadingKeyword.StaticLet(
                staticRange |> Option.defaultValue Range.Zero,
                letRange |> Option.defaultValue Range.Zero
            )

    type StaticLetRec =
        static member CreateByDefault(?staticRange, ?letRange, ?recRange) =
            SynLeadingKeyword.StaticLetRec(
                staticRange |> Option.defaultValue Range.Zero,
                letRange |> Option.defaultValue Range.Zero,
                recRange |> Option.defaultValue Range.Zero
            )

    type StaticDo =
        static member CreateByDefault(?staticRange, ?doRange) =
            SynLeadingKeyword.StaticDo(
                staticRange |> Option.defaultValue Range.Zero,
                doRange |> Option.defaultValue Range.Zero
            )

    type Default =
        static member CreateByDefault(?defaultRange) =
            SynLeadingKeyword.Default(defaultRange |> Option.defaultValue Range.Zero)

    type DefaultVal =
        static member CreateByDefault(?defaultRange, ?valRange) =
            SynLeadingKeyword.DefaultVal(
                defaultRange |> Option.defaultValue Range.Zero,
                valRange |> Option.defaultValue Range.Zero
            )

    type Val =
        static member CreateByDefault(?valRange) =
            SynLeadingKeyword.Val(valRange |> Option.defaultValue Range.Zero)

    type New =
        static member CreateByDefault(?newRange) =
            SynLeadingKeyword.New(newRange |> Option.defaultValue Range.Zero)

    type Do =
        static member CreateByDefault(?doRange) =
            SynLeadingKeyword.Do(doRange |> Option.defaultValue Range.Zero)

module SynModuleOrNamespaceLeadingKeyword =
    type Module =
        static member CreateByDefault(?moduleRange) =
            SynModuleOrNamespaceLeadingKeyword.Module(moduleRange |> Option.defaultValue Range.Zero)

    type Namespace =
        static member CreateByDefault(?namespaceRange) =
            SynModuleOrNamespaceLeadingKeyword.Namespace(namespaceRange |> Option.defaultValue Range.Zero)

module GetSetKeywords =
    type Get =
        static member CreateByDefault(?item) =
            GetSetKeywords.Get(item |> Option.defaultValue Range.Zero)

    type Set =
        static member CreateByDefault(?item) =
            GetSetKeywords.Set(item |> Option.defaultValue Range.Zero)

    type GetSet =
        static member CreateByDefault(?get, ?set) =
            GetSetKeywords.GetSet(get |> Option.defaultValue Range.Zero, set |> Option.defaultValue Range.Zero)

type SynIdent with

    static member CreateByDefault(ident, ?trivia) =
        SynIdent.SynIdent(ident, trivia |> Option.defaultValue Option.None)

type SynLongIdent with

    static member CreateByDefault(id, ?dotRanges, ?trivia) =
        SynLongIdent.SynLongIdent(
            id,
            dotRanges |> Option.defaultValue List.empty,
            trivia |> Option.defaultValue List.empty
        )

type SynTypar with

    static member CreateByDefault(ident, staticReq, ?isCompGen) =
        SynTypar.SynTypar(ident, staticReq, isCompGen |> Option.defaultValue false)

module SynConst =
    type Bool =
        static member CreateByDefault(?item) =
            SynConst.Bool(item |> Option.defaultValue false)

    type SByte =
        static member CreateByDefault(item) = SynConst.SByte(item)

    type Byte =
        static member CreateByDefault(item) = SynConst.Byte(item)

    type Int16 =
        static member CreateByDefault(item) = SynConst.Int16(item)

    type UInt16 =
        static member CreateByDefault(item) = SynConst.UInt16(item)

    type Int32 =
        static member CreateByDefault(item) = SynConst.Int32(item)

    type UInt32 =
        static member CreateByDefault(item) = SynConst.UInt32(item)

    type Int64 =
        static member CreateByDefault(item) = SynConst.Int64(item)

    type UInt64 =
        static member CreateByDefault(item) = SynConst.UInt64(item)

    type IntPtr =
        static member CreateByDefault(item) = SynConst.IntPtr(item)

    type UIntPtr =
        static member CreateByDefault(item) = SynConst.UIntPtr(item)

    type Single =
        static member CreateByDefault(item) = SynConst.Single(item)

    type Double =
        static member CreateByDefault(item) = SynConst.Double(item)

    type Char =
        static member CreateByDefault(item) = SynConst.Char(item)

    type Decimal =
        static member CreateByDefault(item) = SynConst.Decimal(item)

    type UserNum =
        static member CreateByDefault(value, suffix) = SynConst.UserNum(value, suffix)

    type String =
        static member CreateByDefault(text, ?synStringKind, ?range) =
            SynConst.String(
                text,
                synStringKind |> Option.defaultValue SynStringKind.Regular,
                range |> Option.defaultValue Range.Zero
            )

    type Bytes =
        static member CreateByDefault(?bytes, ?synByteStringKind, ?range) =
            SynConst.Bytes(
                bytes |> Option.defaultValue Array.empty,
                synByteStringKind |> Option.defaultValue SynByteStringKind.Regular,
                range |> Option.defaultValue Range.Zero
            )

    type UInt16s =
        static member CreateByDefault(?item) =
            SynConst.UInt16s(item |> Option.defaultValue Array.empty)

    type Measure =
        static member CreateByDefault(constant, trivia, ?constantRange, ?synMeasure) =
            SynConst.Measure(
                constant,
                constantRange |> Option.defaultValue Range.Zero,
                synMeasure |> Option.defaultValue (SynMeasure.One Range.Zero),
                trivia
            )

    type SourceIdentifier =
        static member CreateByDefault(constant, value, ?range) =
            SynConst.SourceIdentifier(constant, value, range |> Option.defaultValue Range.Zero)

module SynMeasure =
    type Named =
        static member CreateByDefault(longId, ?range) =
            SynMeasure.Named(longId, range |> Option.defaultValue Range.Zero)

    type Product =
        static member CreateByDefault(?measure1, ?mAsterisk, ?measure2, ?range) =
            SynMeasure.Product(
                measure1 |> Option.defaultValue (SynMeasure.One Range.Zero),
                mAsterisk |> Option.defaultValue Range.Zero,
                measure2 |> Option.defaultValue (SynMeasure.One Range.Zero),
                range |> Option.defaultValue Range.Zero
            )

    type Seq =
        static member CreateByDefault(?measures, ?range) =
            SynMeasure.Seq(measures |> Option.defaultValue List.empty, range |> Option.defaultValue Range.Zero)

    type Divide =
        static member CreateByDefault(?measure1, ?mSlash, ?measure2, ?range) =
            SynMeasure.Divide(
                measure1 |> Option.defaultValue Option.None,
                mSlash |> Option.defaultValue Range.Zero,
                measure2 |> Option.defaultValue (SynMeasure.One Range.Zero),
                range |> Option.defaultValue Range.Zero
            )

    type Power =
        static member CreateByDefault(power, ?measure, ?caretRange, ?range) =
            SynMeasure.Power(
                measure |> Option.defaultValue (SynMeasure.One Range.Zero),
                caretRange |> Option.defaultValue Range.Zero,
                power,
                range |> Option.defaultValue Range.Zero
            )

    type One =
        static member CreateByDefault(?range) =
            SynMeasure.One(range |> Option.defaultValue Range.Zero)

    type Anon =
        static member CreateByDefault(?range) =
            SynMeasure.Anon(range |> Option.defaultValue Range.Zero)

    type Var =
        static member CreateByDefault(typar, ?range) =
            SynMeasure.Var(typar, range |> Option.defaultValue Range.Zero)

    type Paren =
        static member CreateByDefault(?measure, ?range) =
            SynMeasure.Paren(
                measure |> Option.defaultValue (SynMeasure.One Range.Zero),
                range |> Option.defaultValue Range.Zero
            )

module SynRationalConst =
    type Integer =
        static member CreateByDefault(value, ?range) =
            SynRationalConst.Integer(value, range |> Option.defaultValue Range.Zero)

    type Rational =
        static member CreateByDefault(numerator, denominator, ?numeratorRange, ?divRange, ?denominatorRange, ?range) =
            SynRationalConst.Rational(
                numerator,
                numeratorRange |> Option.defaultValue Range.Zero,
                divRange |> Option.defaultValue Range.Zero,
                denominator,
                denominatorRange |> Option.defaultValue Range.Zero,
                range |> Option.defaultValue Range.Zero
            )

    type Negate =
        static member CreateByDefault(rationalConst, ?range) =
            SynRationalConst.Negate(rationalConst, range |> Option.defaultValue Range.Zero)

    type Paren =
        static member CreateByDefault(rationalConst, ?range) =
            SynRationalConst.Paren(rationalConst, range |> Option.defaultValue Range.Zero)

module SynAccess =
    type Public =
        static member CreateByDefault(?range) =
            SynAccess.Public(range |> Option.defaultValue Range.Zero)

    type Internal =
        static member CreateByDefault(?range) =
            SynAccess.Internal(range |> Option.defaultValue Range.Zero)

    type Private =
        static member CreateByDefault(?range) =
            SynAccess.Private(range |> Option.defaultValue Range.Zero)

module DebugPointAtTry =
    type Yes =
        static member CreateByDefault(?range) =
            DebugPointAtTry.Yes(range |> Option.defaultValue Range.Zero)

module DebugPointAtLeafExpr =
    type Yes =
        static member CreateByDefault(?item) =
            DebugPointAtLeafExpr.Yes(item |> Option.defaultValue Range.Zero)

module DebugPointAtWith =
    type Yes =
        static member CreateByDefault(?range) =
            DebugPointAtWith.Yes(range |> Option.defaultValue Range.Zero)

module DebugPointAtFinally =
    type Yes =
        static member CreateByDefault(?range) =
            DebugPointAtFinally.Yes(range |> Option.defaultValue Range.Zero)

module DebugPointAtFor =
    type Yes =
        static member CreateByDefault(?range) =
            DebugPointAtFor.Yes(range |> Option.defaultValue Range.Zero)

module DebugPointAtInOrTo =
    type Yes =
        static member CreateByDefault(?range) =
            DebugPointAtInOrTo.Yes(range |> Option.defaultValue Range.Zero)

module DebugPointAtWhile =
    type Yes =
        static member CreateByDefault(?range) =
            DebugPointAtWhile.Yes(range |> Option.defaultValue Range.Zero)

module DebugPointAtBinding =
    type Yes =
        static member CreateByDefault(?range) =
            DebugPointAtBinding.Yes(range |> Option.defaultValue Range.Zero)

type SeqExprOnly with

    static member CreateByDefault(?item) =
        SeqExprOnly.SeqExprOnly(item |> Option.defaultValue false)

type SynTyparDecl with

    static member CreateByDefault(typar, trivia, ?attributes, ?intersectionConstraints) =
        SynTyparDecl.SynTyparDecl(
            attributes |> Option.defaultValue List.empty,
            typar,
            intersectionConstraints |> Option.defaultValue List.empty,
            trivia
        )

module SynTypeConstraint =
    type WhereTyparIsValueType =
        static member CreateByDefault(typar, ?range) =
            SynTypeConstraint.WhereTyparIsValueType(typar, range |> Option.defaultValue Range.Zero)

    type WhereTyparIsReferenceType =
        static member CreateByDefault(typar, ?range) =
            SynTypeConstraint.WhereTyparIsReferenceType(typar, range |> Option.defaultValue Range.Zero)

    type WhereTyparIsUnmanaged =
        static member CreateByDefault(typar, ?range) =
            SynTypeConstraint.WhereTyparIsUnmanaged(typar, range |> Option.defaultValue Range.Zero)

    type WhereTyparSupportsNull =
        static member CreateByDefault(typar, ?range) =
            SynTypeConstraint.WhereTyparSupportsNull(typar, range |> Option.defaultValue Range.Zero)

    type WhereTyparIsComparable =
        static member CreateByDefault(typar, ?range) =
            SynTypeConstraint.WhereTyparIsComparable(typar, range |> Option.defaultValue Range.Zero)

    type WhereTyparIsEquatable =
        static member CreateByDefault(typar, ?range) =
            SynTypeConstraint.WhereTyparIsEquatable(typar, range |> Option.defaultValue Range.Zero)

    type WhereTyparDefaultsToType =
        static member CreateByDefault(typar, typeName, ?range) =
            SynTypeConstraint.WhereTyparDefaultsToType(typar, typeName, range |> Option.defaultValue Range.Zero)

    type WhereTyparSubtypeOfType =
        static member CreateByDefault(typar, typeName, ?range) =
            SynTypeConstraint.WhereTyparSubtypeOfType(typar, typeName, range |> Option.defaultValue Range.Zero)

    type WhereTyparSupportsMember =
        static member CreateByDefault(typars, memberSig, ?range) =
            SynTypeConstraint.WhereTyparSupportsMember(typars, memberSig, range |> Option.defaultValue Range.Zero)

    type WhereTyparIsEnum =
        static member CreateByDefault(typar, ?typeArgs, ?range) =
            SynTypeConstraint.WhereTyparIsEnum(
                typar,
                typeArgs |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type WhereTyparIsDelegate =
        static member CreateByDefault(typar, ?typeArgs, ?range) =
            SynTypeConstraint.WhereTyparIsDelegate(
                typar,
                typeArgs |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type WhereSelfConstrained =
        static member CreateByDefault(selfConstraint, ?range) =
            SynTypeConstraint.WhereSelfConstrained(selfConstraint, range |> Option.defaultValue Range.Zero)

module SynTyparDecls =
    type PostfixList =
        static member CreateByDefault(?decls, ?constraints, ?range) =
            SynTyparDecls.PostfixList(
                decls |> Option.defaultValue List.empty,
                constraints |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type PrefixList =
        static member CreateByDefault(?decls, ?range) =
            SynTyparDecls.PrefixList(decls |> Option.defaultValue List.empty, range |> Option.defaultValue Range.Zero)

    type SinglePrefix =
        static member CreateByDefault(decl, ?range) =
            SynTyparDecls.SinglePrefix(decl, range |> Option.defaultValue Range.Zero)

module SynTupleTypeSegment =
    type Type =
        static member CreateByDefault(typeName) = SynTupleTypeSegment.Type(typeName)

    type Star =
        static member CreateByDefault(?range) =
            SynTupleTypeSegment.Star(range |> Option.defaultValue Range.Zero)

    type Slash =
        static member CreateByDefault(?range) =
            SynTupleTypeSegment.Slash(range |> Option.defaultValue Range.Zero)

module SynType =
    type LongIdent =
        static member CreateByDefault(longDotId) = SynType.LongIdent(longDotId)

    type App =
        static member CreateByDefault
            (
                typeName,
                ?lessRange,
                ?typeArgs,
                ?commaRanges,
                ?greaterRange,
                ?isPostfix,
                ?range
            ) =
            SynType.App(
                typeName,
                lessRange |> Option.defaultValue Option.None,
                typeArgs |> Option.defaultValue List.empty,
                commaRanges |> Option.defaultValue List.empty,
                greaterRange |> Option.defaultValue Option.None,
                isPostfix |> Option.defaultValue false,
                range |> Option.defaultValue Range.Zero
            )

    type LongIdentApp =
        static member CreateByDefault(typeName, longDotId, ?lessRange, ?typeArgs, ?commaRanges, ?greaterRange, ?range) =
            SynType.LongIdentApp(
                typeName,
                longDotId,
                lessRange |> Option.defaultValue Option.None,
                typeArgs |> Option.defaultValue List.empty,
                commaRanges |> Option.defaultValue List.empty,
                greaterRange |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero
            )

    type Tuple =
        static member CreateByDefault(?isStruct, ?path, ?range) =
            SynType.Tuple(
                isStruct |> Option.defaultValue false,
                path |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type AnonRecd =
        static member CreateByDefault(?isStruct, ?fields, ?range) =
            SynType.AnonRecd(
                isStruct |> Option.defaultValue false,
                fields |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type Array =
        static member CreateByDefault(rank, elementType, ?range) =
            SynType.Array(rank, elementType, range |> Option.defaultValue Range.Zero)

    type Fun =
        static member CreateByDefault(argType, returnType, trivia, ?range) =
            SynType.Fun(argType, returnType, range |> Option.defaultValue Range.Zero, trivia)

    type Var =
        static member CreateByDefault(typar, ?range) =
            SynType.Var(typar, range |> Option.defaultValue Range.Zero)

    type Anon =
        static member CreateByDefault(?range) =
            SynType.Anon(range |> Option.defaultValue Range.Zero)

    type WithGlobalConstraints =
        static member CreateByDefault(typeName, ?constraints, ?range) =
            SynType.WithGlobalConstraints(
                typeName,
                constraints |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type HashConstraint =
        static member CreateByDefault(innerType, ?range) =
            SynType.HashConstraint(innerType, range |> Option.defaultValue Range.Zero)

    type MeasurePower =
        static member CreateByDefault(baseMeasure, exponent, ?range) =
            SynType.MeasurePower(baseMeasure, exponent, range |> Option.defaultValue Range.Zero)

    type StaticConstant =
        static member CreateByDefault(constant, ?range) =
            SynType.StaticConstant(constant, range |> Option.defaultValue Range.Zero)

    type StaticConstantExpr =
        static member CreateByDefault(expr, ?range) =
            SynType.StaticConstantExpr(expr, range |> Option.defaultValue Range.Zero)

    type StaticConstantNamed =
        static member CreateByDefault(ident, value, ?range) =
            SynType.StaticConstantNamed(ident, value, range |> Option.defaultValue Range.Zero)

    type Paren =
        static member CreateByDefault(innerType, ?range) =
            SynType.Paren(innerType, range |> Option.defaultValue Range.Zero)

    type SignatureParameter =
        static member CreateByDefault(usedType, ?attributes, ?optional, ?id, ?range) =
            SynType.SignatureParameter(
                attributes |> Option.defaultValue List.empty,
                optional |> Option.defaultValue false,
                id |> Option.defaultValue Option.None,
                usedType,
                range |> Option.defaultValue Range.Zero
            )

    type Or =
        static member CreateByDefault(lhsType, rhsType, trivia, ?range) =
            SynType.Or(lhsType, rhsType, range |> Option.defaultValue Range.Zero, trivia)

    type FromParseError =
        static member CreateByDefault(?range) =
            SynType.FromParseError(range |> Option.defaultValue Range.Zero)

    type Intersection =
        static member CreateByDefault(trivia, ?typar, ?types, ?range) =
            SynType.Intersection(
                typar |> Option.defaultValue Option.None,
                types |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

module SynExpr =
    type Paren =
        static member CreateByDefault(expr, ?leftParenRange, ?rightParenRange, ?range) =
            SynExpr.Paren(
                expr,
                leftParenRange |> Option.defaultValue Range.Zero,
                rightParenRange |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero
            )

    type Quote =
        static member CreateByDefault(operator, quotedExpr, ?isRaw, ?isFromQueryExpression, ?range) =
            SynExpr.Quote(
                operator,
                isRaw |> Option.defaultValue false,
                quotedExpr,
                isFromQueryExpression |> Option.defaultValue false,
                range |> Option.defaultValue Range.Zero
            )

    type Const =
        static member CreateByDefault(constant, ?range) =
            SynExpr.Const(constant, range |> Option.defaultValue Range.Zero)

    type Typed =
        static member CreateByDefault(expr, targetType, ?range) =
            SynExpr.Typed(expr, targetType, range |> Option.defaultValue Range.Zero)

    type Tuple =
        static member CreateByDefault(?isStruct, ?exprs, ?commaRanges, ?range) =
            SynExpr.Tuple(
                isStruct |> Option.defaultValue false,
                exprs |> Option.defaultValue List.empty,
                commaRanges |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type AnonRecd =
        static member CreateByDefault(trivia, ?isStruct, ?copyInfo, ?recordFields, ?range) =
            SynExpr.AnonRecd(
                isStruct |> Option.defaultValue false,
                copyInfo |> Option.defaultValue Option.None,
                recordFields |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

    type ArrayOrList =
        static member CreateByDefault(?isArray, ?exprs, ?range) =
            SynExpr.ArrayOrList(
                isArray |> Option.defaultValue false,
                exprs |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type Record =
        static member CreateByDefault(?baseInfo, ?copyInfo, ?recordFields, ?range) =
            SynExpr.Record(
                baseInfo |> Option.defaultValue Option.None,
                copyInfo |> Option.defaultValue Option.None,
                recordFields |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type New =
        static member CreateByDefault(targetType, expr, ?isProtected, ?range) =
            SynExpr.New(
                isProtected |> Option.defaultValue false,
                targetType,
                expr,
                range |> Option.defaultValue Range.Zero
            )

    type ObjExpr =
        static member CreateByDefault
            (
                objType,
                ?argOptions,
                ?withKeyword,
                ?bindings,
                ?members,
                ?extraImpls,
                ?newExprRange,
                ?range
            ) =
            SynExpr.ObjExpr(
                objType,
                argOptions |> Option.defaultValue Option.None,
                withKeyword |> Option.defaultValue Option.None,
                bindings |> Option.defaultValue List.empty,
                members |> Option.defaultValue List.empty,
                extraImpls |> Option.defaultValue List.empty,
                newExprRange |> Option.defaultValue Range.Zero,
                range |> Option.defaultValue Range.Zero
            )

    type While =
        static member CreateByDefault(whileDebugPoint, whileExpr, doExpr, ?range) =
            SynExpr.While(whileDebugPoint, whileExpr, doExpr, range |> Option.defaultValue Range.Zero)

    type For =
        static member CreateByDefault
            (
                forDebugPoint,
                toDebugPoint,
                ident,
                identBody,
                toBody,
                doBody,
                ?equalsRange,
                ?direction,
                ?range
            ) =
            SynExpr.For(
                forDebugPoint,
                toDebugPoint,
                ident,
                equalsRange |> Option.defaultValue Option.None,
                identBody,
                direction |> Option.defaultValue false,
                toBody,
                doBody,
                range |> Option.defaultValue Range.Zero
            )

    type ForEach =
        static member CreateByDefault
            (
                forDebugPoint,
                inDebugPoint,
                seqExprOnly,
                pat,
                enumExpr,
                bodyExpr,
                ?isFromSource,
                ?range
            ) =
            SynExpr.ForEach(
                forDebugPoint,
                inDebugPoint,
                seqExprOnly,
                isFromSource |> Option.defaultValue false,
                pat,
                enumExpr,
                bodyExpr,
                range |> Option.defaultValue Range.Zero
            )

    type ArrayOrListComputed =
        static member CreateByDefault(expr, ?isArray, ?range) =
            SynExpr.ArrayOrListComputed(
                isArray |> Option.defaultValue false,
                expr,
                range |> Option.defaultValue Range.Zero
            )

    type IndexRange =
        static member CreateByDefault(?expr1, ?opm, ?expr2, ?range1, ?range2, ?range) =
            SynExpr.IndexRange(
                expr1 |> Option.defaultValue Option.None,
                opm |> Option.defaultValue Range.Zero,
                expr2 |> Option.defaultValue Option.None,
                range1 |> Option.defaultValue Range.Zero,
                range2 |> Option.defaultValue Range.Zero,
                range |> Option.defaultValue Range.Zero
            )

    type IndexFromEnd =
        static member CreateByDefault(expr, ?range) =
            SynExpr.IndexFromEnd(expr, range |> Option.defaultValue Range.Zero)

    type ComputationExpr =
        static member CreateByDefault(expr, ?hasSeqBuilder, ?range) =
            SynExpr.ComputationExpr(
                hasSeqBuilder |> Option.defaultValue false,
                expr,
                range |> Option.defaultValue Range.Zero
            )

    type Lambda =
        static member CreateByDefault(args, body, trivia, ?fromMethod, ?inLambdaSeq, ?parsedData, ?range) =
            SynExpr.Lambda(
                fromMethod |> Option.defaultValue false,
                inLambdaSeq |> Option.defaultValue false,
                args,
                body,
                parsedData |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

    type MatchLambda =
        static member CreateByDefault(?isExnMatch, ?keywordRange, ?matchClauses, ?matchDebugPoint, ?range) =
            SynExpr.MatchLambda(
                isExnMatch |> Option.defaultValue false,
                keywordRange |> Option.defaultValue Range.Zero,
                matchClauses |> Option.defaultValue List.empty,
                matchDebugPoint |> Option.defaultValue (DebugPointAtBinding.Yes Range.Zero),
                range |> Option.defaultValue Range.Zero
            )

    type Match =
        static member CreateByDefault(expr, trivia, ?matchDebugPoint, ?clauses, ?range) =
            SynExpr.Match(
                matchDebugPoint |> Option.defaultValue (DebugPointAtBinding.Yes Range.Zero),
                expr,
                clauses |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

    type Do =
        static member CreateByDefault(expr, ?range) =
            SynExpr.Do(expr, range |> Option.defaultValue Range.Zero)

    type Assert =
        static member CreateByDefault(expr, ?range) =
            SynExpr.Assert(expr, range |> Option.defaultValue Range.Zero)

    type App =
        static member CreateByDefault(funcExpr, argExpr, ?flag, ?isInfix, ?range) =
            SynExpr.App(
                flag |> Option.defaultValue ExprAtomicFlag.NonAtomic,
                isInfix |> Option.defaultValue false,
                funcExpr,
                argExpr,
                range |> Option.defaultValue Range.Zero
            )

    type TypeApp =
        static member CreateByDefault
            (
                expr,
                ?lessRange,
                ?typeArgs,
                ?commaRanges,
                ?greaterRange,
                ?typeArgsRange,
                ?range
            ) =
            SynExpr.TypeApp(
                expr,
                lessRange |> Option.defaultValue Range.Zero,
                typeArgs |> Option.defaultValue List.empty,
                commaRanges |> Option.defaultValue List.empty,
                greaterRange |> Option.defaultValue Option.None,
                typeArgsRange |> Option.defaultValue Range.Zero,
                range |> Option.defaultValue Range.Zero
            )

    type LetOrUse =
        static member CreateByDefault(body, trivia, ?isRecursive, ?isUse, ?bindings, ?range) =
            SynExpr.LetOrUse(
                isRecursive |> Option.defaultValue false,
                isUse |> Option.defaultValue false,
                bindings |> Option.defaultValue List.empty,
                body,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

    type TryWith =
        static member CreateByDefault(tryExpr, tryDebugPoint, withDebugPoint, trivia, ?withCases, ?range) =
            SynExpr.TryWith(
                tryExpr,
                withCases |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero,
                tryDebugPoint,
                withDebugPoint,
                trivia
            )

    type TryFinally =
        static member CreateByDefault(tryExpr, finallyExpr, tryDebugPoint, finallyDebugPoint, trivia, ?range) =
            SynExpr.TryFinally(
                tryExpr,
                finallyExpr,
                range |> Option.defaultValue Range.Zero,
                tryDebugPoint,
                finallyDebugPoint,
                trivia
            )

    type Lazy =
        static member CreateByDefault(expr, ?range) =
            SynExpr.Lazy(expr, range |> Option.defaultValue Range.Zero)

    type Sequential =
        static member CreateByDefault(debugPoint, expr1, expr2, ?isTrueSeq, ?range) =
            SynExpr.Sequential(
                debugPoint,
                isTrueSeq |> Option.defaultValue false,
                expr1,
                expr2,
                range |> Option.defaultValue Range.Zero
            )

    type IfThenElse =
        static member CreateByDefault(ifExpr, thenExpr, trivia, ?elseExpr, ?spIfToThen, ?isFromErrorRecovery, ?range) =
            SynExpr.IfThenElse(
                ifExpr,
                thenExpr,
                elseExpr |> Option.defaultValue Option.None,
                spIfToThen |> Option.defaultValue (DebugPointAtBinding.Yes Range.Zero),
                isFromErrorRecovery |> Option.defaultValue false,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

    type Typar =
        static member CreateByDefault(typar, ?range) =
            SynExpr.Typar(typar, range |> Option.defaultValue Range.Zero)

    type Ident =
        static member CreateByDefault(ident) = SynExpr.Ident(ident)

    type LongIdent =
        static member CreateByDefault(longDotId, ?isOptional, ?altNameRefCell, ?range) =
            SynExpr.LongIdent(
                isOptional |> Option.defaultValue false,
                longDotId,
                altNameRefCell |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero
            )

    type LongIdentSet =
        static member CreateByDefault(longDotId, expr, ?range) =
            SynExpr.LongIdentSet(longDotId, expr, range |> Option.defaultValue Range.Zero)

    type DotGet =
        static member CreateByDefault(expr, longDotId, ?rangeOfDot, ?range) =
            SynExpr.DotGet(
                expr,
                rangeOfDot |> Option.defaultValue Range.Zero,
                longDotId,
                range |> Option.defaultValue Range.Zero
            )

    type DotLambda =
        static member CreateByDefault(expr, trivia, ?range) =
            SynExpr.DotLambda(expr, range |> Option.defaultValue Range.Zero, trivia)

    type DotSet =
        static member CreateByDefault(targetExpr, longDotId, rhsExpr, ?range) =
            SynExpr.DotSet(targetExpr, longDotId, rhsExpr, range |> Option.defaultValue Range.Zero)

    type Set =
        static member CreateByDefault(targetExpr, rhsExpr, ?range) =
            SynExpr.Set(targetExpr, rhsExpr, range |> Option.defaultValue Range.Zero)

    type DotIndexedGet =
        static member CreateByDefault(objectExpr, indexArgs, ?dotRange, ?range) =
            SynExpr.DotIndexedGet(
                objectExpr,
                indexArgs,
                dotRange |> Option.defaultValue Range.Zero,
                range |> Option.defaultValue Range.Zero
            )

    type DotIndexedSet =
        static member CreateByDefault(objectExpr, indexArgs, valueExpr, ?leftOfSetRange, ?dotRange, ?range) =
            SynExpr.DotIndexedSet(
                objectExpr,
                indexArgs,
                valueExpr,
                leftOfSetRange |> Option.defaultValue Range.Zero,
                dotRange |> Option.defaultValue Range.Zero,
                range |> Option.defaultValue Range.Zero
            )

    type NamedIndexedPropertySet =
        static member CreateByDefault(longDotId, expr1, expr2, ?range) =
            SynExpr.NamedIndexedPropertySet(longDotId, expr1, expr2, range |> Option.defaultValue Range.Zero)

    type DotNamedIndexedPropertySet =
        static member CreateByDefault(targetExpr, longDotId, argExpr, rhsExpr, ?range) =
            SynExpr.DotNamedIndexedPropertySet(
                targetExpr,
                longDotId,
                argExpr,
                rhsExpr,
                range |> Option.defaultValue Range.Zero
            )

    type TypeTest =
        static member CreateByDefault(expr, targetType, ?range) =
            SynExpr.TypeTest(expr, targetType, range |> Option.defaultValue Range.Zero)

    type Upcast =
        static member CreateByDefault(expr, targetType, ?range) =
            SynExpr.Upcast(expr, targetType, range |> Option.defaultValue Range.Zero)

    type Downcast =
        static member CreateByDefault(expr, targetType, ?range) =
            SynExpr.Downcast(expr, targetType, range |> Option.defaultValue Range.Zero)

    type InferredUpcast =
        static member CreateByDefault(expr, ?range) =
            SynExpr.InferredUpcast(expr, range |> Option.defaultValue Range.Zero)

    type InferredDowncast =
        static member CreateByDefault(expr, ?range) =
            SynExpr.InferredDowncast(expr, range |> Option.defaultValue Range.Zero)

    type Null =
        static member CreateByDefault(?range) =
            SynExpr.Null(range |> Option.defaultValue Range.Zero)

    type AddressOf =
        static member CreateByDefault(expr, ?isByref, ?opRange, ?range) =
            SynExpr.AddressOf(
                isByref |> Option.defaultValue false,
                expr,
                opRange |> Option.defaultValue Range.Zero,
                range |> Option.defaultValue Range.Zero
            )

    type TraitCall =
        static member CreateByDefault(supportTys, traitSig, argExpr, ?range) =
            SynExpr.TraitCall(supportTys, traitSig, argExpr, range |> Option.defaultValue Range.Zero)

    type JoinIn =
        static member CreateByDefault(lhsExpr, rhsExpr, ?lhsRange, ?range) =
            SynExpr.JoinIn(
                lhsExpr,
                lhsRange |> Option.defaultValue Range.Zero,
                rhsExpr,
                range |> Option.defaultValue Range.Zero
            )

    type ImplicitZero =
        static member CreateByDefault(?range) =
            SynExpr.ImplicitZero(range |> Option.defaultValue Range.Zero)

    type SequentialOrImplicitYield =
        static member CreateByDefault(debugPoint, expr1, expr2, ifNotStmt, ?range) =
            SynExpr.SequentialOrImplicitYield(
                debugPoint,
                expr1,
                expr2,
                ifNotStmt,
                range |> Option.defaultValue Range.Zero
            )

    type YieldOrReturn =
        static member CreateByDefault(flags, expr, ?range) =
            SynExpr.YieldOrReturn(flags, expr, range |> Option.defaultValue Range.Zero)

    type YieldOrReturnFrom =
        static member CreateByDefault(flags, expr, ?range) =
            SynExpr.YieldOrReturnFrom(flags, expr, range |> Option.defaultValue Range.Zero)

    type LetOrUseBang =
        static member CreateByDefault
            (
                pat,
                rhs,
                body,
                trivia,
                ?bindDebugPoint,
                ?isUse,
                ?isFromSource,
                ?andBangs,
                ?range
            ) =
            SynExpr.LetOrUseBang(
                bindDebugPoint |> Option.defaultValue (DebugPointAtBinding.Yes Range.Zero),
                isUse |> Option.defaultValue false,
                isFromSource |> Option.defaultValue false,
                pat,
                rhs,
                andBangs |> Option.defaultValue List.empty,
                body,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

    type MatchBang =
        static member CreateByDefault(expr, trivia, ?matchDebugPoint, ?clauses, ?range) =
            SynExpr.MatchBang(
                matchDebugPoint |> Option.defaultValue (DebugPointAtBinding.Yes Range.Zero),
                expr,
                clauses |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

    type DoBang =
        static member CreateByDefault(expr, ?range) =
            SynExpr.DoBang(expr, range |> Option.defaultValue Range.Zero)

    type WhileBang =
        static member CreateByDefault(whileDebugPoint, whileExpr, doExpr, ?range) =
            SynExpr.WhileBang(whileDebugPoint, whileExpr, doExpr, range |> Option.defaultValue Range.Zero)

    type LibraryOnlyILAssembly =
        static member CreateByDefault(ilCode, ?typeArgs, ?args, ?retTy, ?range) =
            SynExpr.LibraryOnlyILAssembly(
                ilCode,
                typeArgs |> Option.defaultValue List.empty,
                args |> Option.defaultValue List.empty,
                retTy |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type LibraryOnlyStaticOptimization =
        static member CreateByDefault(expr, optimizedExpr, ?constraints, ?range) =
            SynExpr.LibraryOnlyStaticOptimization(
                constraints |> Option.defaultValue List.empty,
                expr,
                optimizedExpr,
                range |> Option.defaultValue Range.Zero
            )

    type LibraryOnlyUnionCaseFieldGet =
        static member CreateByDefault(expr, longId, fieldNum, ?range) =
            SynExpr.LibraryOnlyUnionCaseFieldGet(expr, longId, fieldNum, range |> Option.defaultValue Range.Zero)

    type LibraryOnlyUnionCaseFieldSet =
        static member CreateByDefault(expr, longId, fieldNum, rhsExpr, ?range) =
            SynExpr.LibraryOnlyUnionCaseFieldSet(
                expr,
                longId,
                fieldNum,
                rhsExpr,
                range |> Option.defaultValue Range.Zero
            )

    type ArbitraryAfterError =
        static member CreateByDefault(debugStr, ?range) =
            SynExpr.ArbitraryAfterError(debugStr, range |> Option.defaultValue Range.Zero)

    type FromParseError =
        static member CreateByDefault(expr, ?range) =
            SynExpr.FromParseError(expr, range |> Option.defaultValue Range.Zero)

    type DiscardAfterMissingQualificationAfterDot =
        static member CreateByDefault(expr, ?dotRange, ?range) =
            SynExpr.DiscardAfterMissingQualificationAfterDot(
                expr,
                dotRange |> Option.defaultValue Range.Zero,
                range |> Option.defaultValue Range.Zero
            )

    type Fixed =
        static member CreateByDefault(expr, ?range) =
            SynExpr.Fixed(expr, range |> Option.defaultValue Range.Zero)

    type InterpolatedString =
        static member CreateByDefault(?contents, ?synStringKind, ?range) =
            SynExpr.InterpolatedString(
                contents |> Option.defaultValue List.empty,
                synStringKind |> Option.defaultValue SynStringKind.Regular,
                range |> Option.defaultValue Range.Zero
            )

    type DebugPoint =
        static member CreateByDefault(debugPoint, innerExpr, ?isControlFlow) =
            SynExpr.DebugPoint(debugPoint, isControlFlow |> Option.defaultValue false, innerExpr)

    type Dynamic =
        static member CreateByDefault(funcExpr, argExpr, ?qmark, ?range) =
            SynExpr.Dynamic(
                funcExpr,
                qmark |> Option.defaultValue Range.Zero,
                argExpr,
                range |> Option.defaultValue Range.Zero
            )

type SynExprAndBang with

    static member CreateByDefault(pat, body, trivia, ?debugPoint, ?isUse, ?isFromSource, ?range) =
        SynExprAndBang.SynExprAndBang(
            debugPoint |> Option.defaultValue (DebugPointAtBinding.Yes Range.Zero),
            isUse |> Option.defaultValue false,
            isFromSource |> Option.defaultValue false,
            pat,
            body,
            range |> Option.defaultValue Range.Zero,
            trivia
        )

type SynExprRecordField with

    static member CreateByDefault(fieldName, ?equalsRange, ?expr, ?blockSeparator) =
        SynExprRecordField.SynExprRecordField(
            fieldName,
            equalsRange |> Option.defaultValue Option.None,
            expr |> Option.defaultValue Option.None,
            blockSeparator |> Option.defaultValue Option.None
        )

module SynInterpolatedStringPart =
    type String =
        static member CreateByDefault(value, ?range) =
            SynInterpolatedStringPart.String(value, range |> Option.defaultValue Range.Zero)

    type FillExpr =
        static member CreateByDefault(fillExpr, ?qualifiers) =
            SynInterpolatedStringPart.FillExpr(fillExpr, qualifiers |> Option.defaultValue Option.None)

module SynSimplePat =
    type Id =
        static member CreateByDefault(ident, ?altNameRefCell, ?isCompilerGenerated, ?isThisVal, ?isOptional, ?range) =
            SynSimplePat.Id(
                ident,
                altNameRefCell |> Option.defaultValue Option.None,
                isCompilerGenerated |> Option.defaultValue false,
                isThisVal |> Option.defaultValue false,
                isOptional |> Option.defaultValue false,
                range |> Option.defaultValue Range.Zero
            )

    type Typed =
        static member CreateByDefault(pat, targetType, ?range) =
            SynSimplePat.Typed(pat, targetType, range |> Option.defaultValue Range.Zero)

    type Attrib =
        static member CreateByDefault(pat, ?attributes, ?range) =
            SynSimplePat.Attrib(
                pat,
                attributes |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

module SynSimplePatAlternativeIdInfo =
    type Undecided =
        static member CreateByDefault(item) =
            SynSimplePatAlternativeIdInfo.Undecided(item)

    type Decided =
        static member CreateByDefault(item) =
            SynSimplePatAlternativeIdInfo.Decided(item)

module SynStaticOptimizationConstraint =
    type WhenTyparTyconEqualsTycon =
        static member CreateByDefault(typar, rhsType, ?range) =
            SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(
                typar,
                rhsType,
                range |> Option.defaultValue Range.Zero
            )

    type WhenTyparIsStruct =
        static member CreateByDefault(typar, ?range) =
            SynStaticOptimizationConstraint.WhenTyparIsStruct(typar, range |> Option.defaultValue Range.Zero)

module SynSimplePats =
    type SimplePats =
        static member CreateByDefault(?pats, ?commaRanges, ?range) =
            SynSimplePats.SimplePats(
                pats |> Option.defaultValue List.empty,
                commaRanges |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

module SynArgPats =
    type Pats =
        static member CreateByDefault(?pats) =
            SynArgPats.Pats(pats |> Option.defaultValue List.empty)

    type NamePatPairs =
        static member CreateByDefault(trivia, ?pats, ?range) =
            SynArgPats.NamePatPairs(
                pats |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

module SynPat =
    type Const =
        static member CreateByDefault(constant, ?range) =
            SynPat.Const(constant, range |> Option.defaultValue Range.Zero)

    type Wild =
        static member CreateByDefault(?range) =
            SynPat.Wild(range |> Option.defaultValue Range.Zero)

    type Named =
        static member CreateByDefault(ident, ?isThisVal, ?accessibility, ?range) =
            SynPat.Named(
                ident,
                isThisVal |> Option.defaultValue false,
                accessibility |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero
            )

    type Typed =
        static member CreateByDefault(pat, targetType, ?range) =
            SynPat.Typed(pat, targetType, range |> Option.defaultValue Range.Zero)

    type Attrib =
        static member CreateByDefault(pat, ?attributes, ?range) =
            SynPat.Attrib(pat, attributes |> Option.defaultValue List.empty, range |> Option.defaultValue Range.Zero)

    type Or =
        static member CreateByDefault(lhsPat, rhsPat, trivia, ?range) =
            SynPat.Or(lhsPat, rhsPat, range |> Option.defaultValue Range.Zero, trivia)

    type ListCons =
        static member CreateByDefault(lhsPat, rhsPat, trivia, ?range) =
            SynPat.ListCons(lhsPat, rhsPat, range |> Option.defaultValue Range.Zero, trivia)

    type Ands =
        static member CreateByDefault(?pats, ?range) =
            SynPat.Ands(pats |> Option.defaultValue List.empty, range |> Option.defaultValue Range.Zero)

    type As =
        static member CreateByDefault(lhsPat, rhsPat, ?range) =
            SynPat.As(lhsPat, rhsPat, range |> Option.defaultValue Range.Zero)

    type LongIdent =
        static member CreateByDefault(longDotId, argPats, ?extraId, ?typarDecls, ?accessibility, ?range) =
            SynPat.LongIdent(
                longDotId,
                extraId |> Option.defaultValue Option.None,
                typarDecls |> Option.defaultValue Option.None,
                argPats,
                accessibility |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero
            )

    type Tuple =
        static member CreateByDefault(?isStruct, ?elementPats, ?commaRanges, ?range) =
            SynPat.Tuple(
                isStruct |> Option.defaultValue false,
                elementPats |> Option.defaultValue List.empty,
                commaRanges |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type Paren =
        static member CreateByDefault(pat, ?range) =
            SynPat.Paren(pat, range |> Option.defaultValue Range.Zero)

    type ArrayOrList =
        static member CreateByDefault(?isArray, ?elementPats, ?range) =
            SynPat.ArrayOrList(
                isArray |> Option.defaultValue false,
                elementPats |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type Record =
        static member CreateByDefault(?fieldPats, ?range) =
            SynPat.Record(fieldPats |> Option.defaultValue List.empty, range |> Option.defaultValue Range.Zero)

    type Null =
        static member CreateByDefault(?range) =
            SynPat.Null(range |> Option.defaultValue Range.Zero)

    type OptionalVal =
        static member CreateByDefault(ident, ?range) =
            SynPat.OptionalVal(ident, range |> Option.defaultValue Range.Zero)

    type IsInst =
        static member CreateByDefault(pat, ?range) =
            SynPat.IsInst(pat, range |> Option.defaultValue Range.Zero)

    type QuoteExpr =
        static member CreateByDefault(expr, ?range) =
            SynPat.QuoteExpr(expr, range |> Option.defaultValue Range.Zero)

    type InstanceMember =
        static member CreateByDefault(thisId, memberId, ?toolingId, ?accessibility, ?range) =
            SynPat.InstanceMember(
                thisId,
                memberId,
                toolingId |> Option.defaultValue Option.None,
                accessibility |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero
            )

    type FromParseError =
        static member CreateByDefault(pat, ?range) =
            SynPat.FromParseError(pat, range |> Option.defaultValue Range.Zero)

type SynInterfaceImpl with

    static member CreateByDefault(interfaceTy, ?withKeyword, ?bindings, ?members, ?range) =
        SynInterfaceImpl.SynInterfaceImpl(
            interfaceTy,
            withKeyword |> Option.defaultValue Option.None,
            bindings |> Option.defaultValue List.empty,
            members |> Option.defaultValue List.empty,
            range |> Option.defaultValue Range.Zero
        )

type SynMatchClause with

    static member CreateByDefault(pat, resultExpr, trivia, ?whenExpr, ?range, ?debugPoint) =
        SynMatchClause.SynMatchClause(
            pat,
            whenExpr |> Option.defaultValue Option.None,
            resultExpr,
            range |> Option.defaultValue Range.Zero,
            debugPoint |> Option.defaultValue DebugPointAtTarget.Yes,
            trivia
        )

type SynValData with

    static member CreateByDefault(valInfo, ?memberFlags, ?thisIdOpt, ?transformedFromProperty) =
        SynValData.SynValData(
            memberFlags |> Option.defaultValue Option.None,
            valInfo,
            thisIdOpt |> Option.defaultValue Option.None,
            transformedFromProperty |> Option.defaultValue Option.None
        )

type SynBinding with

    static member CreateByDefault
        (
            valData,
            headPat,
            expr,
            trivia,
            ?accessibility,
            ?kind,
            ?isInline,
            ?isMutable,
            ?attributes,
            ?xmlDoc,
            ?returnInfo,
            ?range,
            ?debugPoint
        ) =
        SynBinding.SynBinding(
            accessibility |> Option.defaultValue Option.None,
            kind |> Option.defaultValue SynBindingKind.Normal,
            isInline |> Option.defaultValue false,
            isMutable |> Option.defaultValue false,
            attributes |> Option.defaultValue List.empty,
            xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
            valData,
            headPat,
            returnInfo |> Option.defaultValue Option.None,
            expr,
            range |> Option.defaultValue Range.Zero,
            debugPoint |> Option.defaultValue (DebugPointAtBinding.Yes Range.Zero),
            trivia
        )

type SynBindingReturnInfo with

    static member CreateByDefault(typeName, trivia, ?range, ?attributes) =
        SynBindingReturnInfo.SynBindingReturnInfo(
            typeName,
            range |> Option.defaultValue Range.Zero,
            attributes |> Option.defaultValue List.empty,
            trivia
        )

module SynMemberSig =
    type Member =
        static member CreateByDefault(memberSig, flags, trivia, ?range) =
            SynMemberSig.Member(memberSig, flags, range |> Option.defaultValue Range.Zero, trivia)

    type Interface =
        static member CreateByDefault(interfaceType, ?range) =
            SynMemberSig.Interface(interfaceType, range |> Option.defaultValue Range.Zero)

    type Inherit =
        static member CreateByDefault(inheritedType, ?range) =
            SynMemberSig.Inherit(inheritedType, range |> Option.defaultValue Range.Zero)

    type ValField =
        static member CreateByDefault(field, ?range) =
            SynMemberSig.ValField(field, range |> Option.defaultValue Range.Zero)

    type NestedType =
        static member CreateByDefault(nestedType, ?range) =
            SynMemberSig.NestedType(nestedType, range |> Option.defaultValue Range.Zero)

module SynTypeDefnKind =
    type Augmentation =
        static member CreateByDefault(?withKeyword) =
            SynTypeDefnKind.Augmentation(withKeyword |> Option.defaultValue Range.Zero)

    type Delegate =
        static member CreateByDefault(signature, signatureInfo) =
            SynTypeDefnKind.Delegate(signature, signatureInfo)

module SynTypeDefnSimpleRepr =
    type Union =
        static member CreateByDefault(?accessibility, ?unionCases, ?range) =
            SynTypeDefnSimpleRepr.Union(
                accessibility |> Option.defaultValue Option.None,
                unionCases |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type Enum =
        static member CreateByDefault(?cases, ?range) =
            SynTypeDefnSimpleRepr.Enum(cases |> Option.defaultValue List.empty, range |> Option.defaultValue Range.Zero)

    type Record =
        static member CreateByDefault(?accessibility, ?recordFields, ?range) =
            SynTypeDefnSimpleRepr.Record(
                accessibility |> Option.defaultValue Option.None,
                recordFields |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type General =
        static member CreateByDefault
            (
                ?kind,
                ?inherits,
                ?slotsigs,
                ?fields,
                ?isConcrete,
                ?isIncrClass,
                ?implicitCtorSynPats,
                ?range
            ) =
            SynTypeDefnSimpleRepr.General(
                kind |> Option.defaultValue SynTypeDefnKind.Unspecified,
                inherits |> Option.defaultValue List.empty,
                slotsigs |> Option.defaultValue List.empty,
                fields |> Option.defaultValue List.empty,
                isConcrete |> Option.defaultValue false,
                isIncrClass |> Option.defaultValue false,
                implicitCtorSynPats |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero
            )

    type LibraryOnlyILAssembly =
        static member CreateByDefault(ilType, ?range) =
            SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(ilType, range |> Option.defaultValue Range.Zero)

    type TypeAbbrev =
        static member CreateByDefault(detail, rhsType, ?range) =
            SynTypeDefnSimpleRepr.TypeAbbrev(detail, rhsType, range |> Option.defaultValue Range.Zero)

    type None =
        static member CreateByDefault(?range) =
            SynTypeDefnSimpleRepr.None(range |> Option.defaultValue Range.Zero)

    type Exception =
        static member CreateByDefault(exnRepr) =
            SynTypeDefnSimpleRepr.Exception(exnRepr)

type SynEnumCase with

    static member CreateByDefault(ident, valueExpr, trivia, ?attributes, ?xmlDoc, ?range) =
        SynEnumCase.SynEnumCase(
            attributes |> Option.defaultValue List.empty,
            ident,
            valueExpr,
            xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
            range |> Option.defaultValue Range.Zero,
            trivia
        )

type SynUnionCase with

    static member CreateByDefault(ident, caseType, trivia, ?attributes, ?xmlDoc, ?accessibility, ?range) =
        SynUnionCase.SynUnionCase(
            attributes |> Option.defaultValue List.empty,
            ident,
            caseType,
            xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
            accessibility |> Option.defaultValue Option.None,
            range |> Option.defaultValue Range.Zero,
            trivia
        )

module SynUnionCaseKind =
    type Fields =
        static member CreateByDefault(?cases) =
            SynUnionCaseKind.Fields(cases |> Option.defaultValue List.empty)

    type FullType =
        static member CreateByDefault(fullType, fullTypeInfo) =
            SynUnionCaseKind.FullType(fullType, fullTypeInfo)

module SynTypeDefnSigRepr =
    type ObjectModel =
        static member CreateByDefault(?kind, ?memberSigs, ?range) =
            SynTypeDefnSigRepr.ObjectModel(
                kind |> Option.defaultValue SynTypeDefnKind.Unspecified,
                memberSigs |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type Simple =
        static member CreateByDefault(?repr, ?range) =
            SynTypeDefnSigRepr.Simple(
                repr |> Option.defaultValue (SynTypeDefnSimpleRepr.None Range.Zero),
                range |> Option.defaultValue Range.Zero
            )

    type Exception =
        static member CreateByDefault(repr) = SynTypeDefnSigRepr.Exception(repr)

type SynTypeDefnSig with

    static member CreateByDefault(typeInfo, typeRepr, trivia, ?members, ?range) =
        SynTypeDefnSig.SynTypeDefnSig(
            typeInfo,
            typeRepr,
            members |> Option.defaultValue List.empty,
            range |> Option.defaultValue Range.Zero,
            trivia
        )

type SynField with

    static member CreateByDefault
        (
            fieldType,
            trivia,
            ?attributes,
            ?isStatic,
            ?idOpt,
            ?isMutable,
            ?xmlDoc,
            ?accessibility,
            ?range
        ) =
        SynField.SynField(
            attributes |> Option.defaultValue List.empty,
            isStatic |> Option.defaultValue false,
            idOpt |> Option.defaultValue Option.None,
            fieldType,
            isMutable |> Option.defaultValue false,
            xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
            accessibility |> Option.defaultValue Option.None,
            range |> Option.defaultValue Range.Zero,
            trivia
        )

type SynComponentInfo with

    static member CreateByDefault
        (
            longId,
            ?attributes,
            ?typeParams,
            ?constraints,
            ?xmlDoc,
            ?preferPostfix,
            ?accessibility,
            ?range
        ) =
        SynComponentInfo.SynComponentInfo(
            attributes |> Option.defaultValue List.empty,
            typeParams |> Option.defaultValue Option.None,
            constraints |> Option.defaultValue List.empty,
            longId,
            xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
            preferPostfix |> Option.defaultValue false,
            accessibility |> Option.defaultValue Option.None,
            range |> Option.defaultValue Range.Zero
        )

type SynValSig with

    static member CreateByDefault
        (
            ident,
            explicitTypeParams,
            synType,
            arity,
            trivia,
            ?attributes,
            ?isInline,
            ?isMutable,
            ?xmlDoc,
            ?accessibility,
            ?synExpr,
            ?range
        ) =
        SynValSig.SynValSig(
            attributes |> Option.defaultValue List.empty,
            ident,
            explicitTypeParams,
            synType,
            arity,
            isInline |> Option.defaultValue false,
            isMutable |> Option.defaultValue false,
            xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
            accessibility |> Option.defaultValue Option.None,
            synExpr |> Option.defaultValue Option.None,
            range |> Option.defaultValue Range.Zero,
            trivia
        )

type SynValInfo with

    static member CreateByDefault(returnInfo, ?curriedArgInfos) =
        SynValInfo.SynValInfo(curriedArgInfos |> Option.defaultValue List.empty, returnInfo)

type SynArgInfo with

    static member CreateByDefault(?attributes, ?optional, ?ident) =
        SynArgInfo.SynArgInfo(
            attributes |> Option.defaultValue List.empty,
            optional |> Option.defaultValue false,
            ident |> Option.defaultValue Option.None
        )

type SynValTyparDecls with

    static member CreateByDefault(?typars, ?canInfer) =
        SynValTyparDecls.SynValTyparDecls(
            typars |> Option.defaultValue Option.None,
            canInfer |> Option.defaultValue false
        )

type SynReturnInfo with

    static member CreateByDefault(returnType, ?range) =
        SynReturnInfo.SynReturnInfo(returnType, range |> Option.defaultValue Range.Zero)

type SynExceptionDefnRepr with

    static member CreateByDefault(caseName, ?attributes, ?longId, ?xmlDoc, ?accessibility, ?range) =
        SynExceptionDefnRepr.SynExceptionDefnRepr(
            attributes |> Option.defaultValue List.empty,
            caseName,
            longId |> Option.defaultValue Option.None,
            xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
            accessibility |> Option.defaultValue Option.None,
            range |> Option.defaultValue Range.Zero
        )

type SynExceptionDefn with

    static member CreateByDefault(exnRepr, ?withKeyword, ?members, ?range) =
        SynExceptionDefn.SynExceptionDefn(
            exnRepr,
            withKeyword |> Option.defaultValue Option.None,
            members |> Option.defaultValue List.empty,
            range |> Option.defaultValue Range.Zero
        )

module SynTypeDefnRepr =
    type ObjectModel =
        static member CreateByDefault(?kind, ?members, ?range) =
            SynTypeDefnRepr.ObjectModel(
                kind |> Option.defaultValue SynTypeDefnKind.Unspecified,
                members |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type Simple =
        static member CreateByDefault(?simpleRepr, ?range) =
            SynTypeDefnRepr.Simple(
                simpleRepr |> Option.defaultValue (SynTypeDefnSimpleRepr.None Range.Zero),
                range |> Option.defaultValue Range.Zero
            )

    type Exception =
        static member CreateByDefault(exnRepr) = SynTypeDefnRepr.Exception(exnRepr)

type SynTypeDefn with

    static member CreateByDefault(typeInfo, typeRepr, trivia, ?members, ?implicitConstructor, ?range) =
        SynTypeDefn.SynTypeDefn(
            typeInfo,
            typeRepr,
            members |> Option.defaultValue List.empty,
            implicitConstructor |> Option.defaultValue Option.None,
            range |> Option.defaultValue Range.Zero,
            trivia
        )

module SynMemberDefn =
    type Open =
        static member CreateByDefault(target, ?range) =
            SynMemberDefn.Open(target, range |> Option.defaultValue Range.Zero)

    type Member =
        static member CreateByDefault(memberDefn, ?range) =
            SynMemberDefn.Member(memberDefn, range |> Option.defaultValue Range.Zero)

    type GetSetMember =
        static member CreateByDefault(trivia, ?memberDefnForGet, ?memberDefnForSet, ?range) =
            SynMemberDefn.GetSetMember(
                memberDefnForGet |> Option.defaultValue Option.None,
                memberDefnForSet |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

    type ImplicitCtor =
        static member CreateByDefault(ctorArgs, trivia, ?accessibility, ?attributes, ?selfIdentifier, ?xmlDoc, ?range) =
            SynMemberDefn.ImplicitCtor(
                accessibility |> Option.defaultValue Option.None,
                attributes |> Option.defaultValue List.empty,
                ctorArgs,
                selfIdentifier |> Option.defaultValue Option.None,
                xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

    type ImplicitInherit =
        static member CreateByDefault(inheritType, inheritArgs, ?inheritAlias, ?range) =
            SynMemberDefn.ImplicitInherit(
                inheritType,
                inheritArgs,
                inheritAlias |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero
            )

    type LetBindings =
        static member CreateByDefault(?bindings, ?isStatic, ?isRecursive, ?range) =
            SynMemberDefn.LetBindings(
                bindings |> Option.defaultValue List.empty,
                isStatic |> Option.defaultValue false,
                isRecursive |> Option.defaultValue false,
                range |> Option.defaultValue Range.Zero
            )

    type AbstractSlot =
        static member CreateByDefault(slotSig, flags, trivia, ?range) =
            SynMemberDefn.AbstractSlot(slotSig, flags, range |> Option.defaultValue Range.Zero, trivia)

    type Interface =
        static member CreateByDefault(interfaceType, ?withKeyword, ?members, ?range) =
            SynMemberDefn.Interface(
                interfaceType,
                withKeyword |> Option.defaultValue Option.None,
                members |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero
            )

    type Inherit =
        static member CreateByDefault(baseType, ?asIdent, ?range) =
            SynMemberDefn.Inherit(
                baseType,
                asIdent |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero
            )

    type ValField =
        static member CreateByDefault(fieldInfo, ?range) =
            SynMemberDefn.ValField(fieldInfo, range |> Option.defaultValue Range.Zero)

    type NestedType =
        static member CreateByDefault(typeDefn, ?accessibility, ?range) =
            SynMemberDefn.NestedType(
                typeDefn,
                accessibility |> Option.defaultValue Option.None,
                range |> Option.defaultValue Range.Zero
            )

    type AutoProperty =
        static member CreateByDefault
            (
                ident,
                propKind,
                memberFlags,
                memberFlagsForSet,
                synExpr,
                trivia,
                ?attributes,
                ?isStatic,
                ?typeOpt,
                ?xmlDoc,
                ?accessibility,
                ?range
            ) =
            SynMemberDefn.AutoProperty(
                attributes |> Option.defaultValue List.empty,
                isStatic |> Option.defaultValue false,
                ident,
                typeOpt |> Option.defaultValue Option.None,
                propKind,
                memberFlags,
                memberFlagsForSet,
                xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
                accessibility |> Option.defaultValue Option.None,
                synExpr,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

module SynModuleDecl =
    type ModuleAbbrev =
        static member CreateByDefault(ident, longId, ?range) =
            SynModuleDecl.ModuleAbbrev(ident, longId, range |> Option.defaultValue Range.Zero)

    type NestedModule =
        static member CreateByDefault(moduleInfo, trivia, ?isRecursive, ?decls, ?isContinuing, ?range) =
            SynModuleDecl.NestedModule(
                moduleInfo,
                isRecursive |> Option.defaultValue false,
                decls |> Option.defaultValue List.empty,
                isContinuing |> Option.defaultValue false,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

    type Let =
        static member CreateByDefault(?isRecursive, ?bindings, ?range) =
            SynModuleDecl.Let(
                isRecursive |> Option.defaultValue false,
                bindings |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type Expr =
        static member CreateByDefault(expr, ?range) =
            SynModuleDecl.Expr(expr, range |> Option.defaultValue Range.Zero)

    type Types =
        static member CreateByDefault(?typeDefns, ?range) =
            SynModuleDecl.Types(typeDefns |> Option.defaultValue List.empty, range |> Option.defaultValue Range.Zero)

    type Exception =
        static member CreateByDefault(exnDefn, ?range) =
            SynModuleDecl.Exception(exnDefn, range |> Option.defaultValue Range.Zero)

    type Open =
        static member CreateByDefault(target, ?range) =
            SynModuleDecl.Open(target, range |> Option.defaultValue Range.Zero)

    type Attributes =
        static member CreateByDefault(?attributes, ?range) =
            SynModuleDecl.Attributes(
                attributes |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type HashDirective =
        static member CreateByDefault(hashDirective, ?range) =
            SynModuleDecl.HashDirective(hashDirective, range |> Option.defaultValue Range.Zero)

    type NamespaceFragment =
        static member CreateByDefault(fragment) =
            SynModuleDecl.NamespaceFragment(fragment)

module SynOpenDeclTarget =
    type ModuleOrNamespace =
        static member CreateByDefault(longId, ?range) =
            SynOpenDeclTarget.ModuleOrNamespace(longId, range |> Option.defaultValue Range.Zero)

    type Type =
        static member CreateByDefault(typeName, ?range) =
            SynOpenDeclTarget.Type(typeName, range |> Option.defaultValue Range.Zero)

type SynExceptionSig with

    static member CreateByDefault(exnRepr, ?withKeyword, ?members, ?range) =
        SynExceptionSig.SynExceptionSig(
            exnRepr,
            withKeyword |> Option.defaultValue Option.None,
            members |> Option.defaultValue List.empty,
            range |> Option.defaultValue Range.Zero
        )

module SynModuleSigDecl =
    type ModuleAbbrev =
        static member CreateByDefault(ident, longId, ?range) =
            SynModuleSigDecl.ModuleAbbrev(ident, longId, range |> Option.defaultValue Range.Zero)

    type NestedModule =
        static member CreateByDefault(moduleInfo, trivia, ?isRecursive, ?moduleDecls, ?range) =
            SynModuleSigDecl.NestedModule(
                moduleInfo,
                isRecursive |> Option.defaultValue false,
                moduleDecls |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

    type Val =
        static member CreateByDefault(valSig, ?range) =
            SynModuleSigDecl.Val(valSig, range |> Option.defaultValue Range.Zero)

    type Types =
        static member CreateByDefault(?types, ?range) =
            SynModuleSigDecl.Types(types |> Option.defaultValue List.empty, range |> Option.defaultValue Range.Zero)

    type Exception =
        static member CreateByDefault(exnSig, ?range) =
            SynModuleSigDecl.Exception(exnSig, range |> Option.defaultValue Range.Zero)

    type Open =
        static member CreateByDefault(target, ?range) =
            SynModuleSigDecl.Open(target, range |> Option.defaultValue Range.Zero)

    type HashDirective =
        static member CreateByDefault(hashDirective, ?range) =
            SynModuleSigDecl.HashDirective(hashDirective, range |> Option.defaultValue Range.Zero)

    type NamespaceFragment =
        static member CreateByDefault(item) =
            SynModuleSigDecl.NamespaceFragment(item)

type SynModuleOrNamespace with

    static member CreateByDefault
        (
            longId,
            kind,
            trivia,
            ?isRecursive,
            ?decls,
            ?xmlDoc,
            ?attribs,
            ?accessibility,
            ?range
        ) =
        SynModuleOrNamespace.SynModuleOrNamespace(
            longId,
            isRecursive |> Option.defaultValue false,
            kind,
            decls |> Option.defaultValue List.empty,
            xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
            attribs |> Option.defaultValue List.empty,
            accessibility |> Option.defaultValue Option.None,
            range |> Option.defaultValue Range.Zero,
            trivia
        )

type SynModuleOrNamespaceSig with

    static member CreateByDefault
        (
            longId,
            kind,
            trivia,
            ?isRecursive,
            ?decls,
            ?xmlDoc,
            ?attribs,
            ?accessibility,
            ?range
        ) =
        SynModuleOrNamespaceSig.SynModuleOrNamespaceSig(
            longId,
            isRecursive |> Option.defaultValue false,
            kind,
            decls |> Option.defaultValue List.empty,
            xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
            attribs |> Option.defaultValue List.empty,
            accessibility |> Option.defaultValue Option.None,
            range |> Option.defaultValue Range.Zero,
            trivia
        )

module ParsedHashDirectiveArgument =
    type String =
        static member CreateByDefault(value, ?stringKind, ?range) =
            ParsedHashDirectiveArgument.String(
                value,
                stringKind |> Option.defaultValue SynStringKind.Regular,
                range |> Option.defaultValue Range.Zero
            )

    type SourceIdentifier =
        static member CreateByDefault(constant, value, ?range) =
            ParsedHashDirectiveArgument.SourceIdentifier(constant, value, range |> Option.defaultValue Range.Zero)

type ParsedHashDirective with

    static member CreateByDefault(ident, ?args, ?range) =
        ParsedHashDirective.ParsedHashDirective(
            ident,
            args |> Option.defaultValue List.empty,
            range |> Option.defaultValue Range.Zero
        )

module ParsedImplFileFragment =
    type AnonModule =
        static member CreateByDefault(?decls, ?range) =
            ParsedImplFileFragment.AnonModule(
                decls |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type NamedModule =
        static member CreateByDefault(namedModule) =
            ParsedImplFileFragment.NamedModule(namedModule)

    type NamespaceFragment =
        static member CreateByDefault(longId, kind, trivia, ?isRecursive, ?decls, ?xmlDoc, ?attributes, ?range) =
            ParsedImplFileFragment.NamespaceFragment(
                longId,
                isRecursive |> Option.defaultValue false,
                kind,
                decls |> Option.defaultValue List.empty,
                xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
                attributes |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

module ParsedSigFileFragment =
    type AnonModule =
        static member CreateByDefault(?decls, ?range) =
            ParsedSigFileFragment.AnonModule(
                decls |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

    type NamedModule =
        static member CreateByDefault(namedModule) =
            ParsedSigFileFragment.NamedModule(namedModule)

    type NamespaceFragment =
        static member CreateByDefault(longId, kind, trivia, ?isRecursive, ?decls, ?xmlDoc, ?attributes, ?range) =
            ParsedSigFileFragment.NamespaceFragment(
                longId,
                isRecursive |> Option.defaultValue false,
                kind,
                decls |> Option.defaultValue List.empty,
                xmlDoc |> Option.defaultValue PreXmlDoc.Empty,
                attributes |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero,
                trivia
            )

module ParsedScriptInteraction =
    type Definitions =
        static member CreateByDefault(?defns, ?range) =
            ParsedScriptInteraction.Definitions(
                defns |> Option.defaultValue List.empty,
                range |> Option.defaultValue Range.Zero
            )

type ParsedImplFile with

    static member CreateByDefault(?hashDirectives, ?fragments) =
        ParsedImplFile.ParsedImplFile(
            hashDirectives |> Option.defaultValue List.empty,
            fragments |> Option.defaultValue List.empty
        )

type ParsedSigFile with

    static member CreateByDefault(?hashDirectives, ?fragments) =
        ParsedSigFile.ParsedSigFile(
            hashDirectives |> Option.defaultValue List.empty,
            fragments |> Option.defaultValue List.empty
        )

module ScopedPragma =
    type WarningOff =
        static member CreateByDefault(warningNumber, ?range) =
            ScopedPragma.WarningOff(range |> Option.defaultValue Range.Zero, warningNumber)

type QualifiedNameOfFile with

    static member CreateByDefault(item) =
        QualifiedNameOfFile.QualifiedNameOfFile(item)

type ParsedImplFileInput with

    static member CreateByDefault
        (
            fileName,
            qualifiedNameOfFile,
            flags,
            trivia,
            ?isScript,
            ?scopedPragmas,
            ?hashDirectives,
            ?contents,
            ?identifiers
        ) =
        ParsedImplFileInput.ParsedImplFileInput(
            fileName,
            isScript |> Option.defaultValue false,
            qualifiedNameOfFile,
            scopedPragmas |> Option.defaultValue List.empty,
            hashDirectives |> Option.defaultValue List.empty,
            contents |> Option.defaultValue List.empty,
            flags,
            trivia,
            identifiers |> Option.defaultValue Set.empty
        )

type ParsedSigFileInput with

    static member CreateByDefault
        (
            fileName,
            qualifiedNameOfFile,
            trivia,
            ?scopedPragmas,
            ?hashDirectives,
            ?contents,
            ?identifiers
        ) =
        ParsedSigFileInput.ParsedSigFileInput(
            fileName,
            qualifiedNameOfFile,
            scopedPragmas |> Option.defaultValue List.empty,
            hashDirectives |> Option.defaultValue List.empty,
            contents |> Option.defaultValue List.empty,
            trivia,
            identifiers |> Option.defaultValue Set.empty
        )

module ParsedInput =
    type ImplFile =
        static member CreateByDefault(item) = ParsedInput.ImplFile(item)

    type SigFile =
        static member CreateByDefault(item) = ParsedInput.SigFile(item)
