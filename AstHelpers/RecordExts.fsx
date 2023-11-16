#i "nuget: https://api.nuget.org/v3/index.json"
#r "nuget: Fantomas.Core, 6.2.1"
#r "nuget: FSharpx.Collections, 3.1.0"

open Fantomas.FCS
open Fantomas.FCS.Text
open Fantomas.FCS.Xml
open Fantomas.FCS.Syntax
open Fantomas.FCS.SyntaxTrivia
open FSharpx.Collections

type ParsedImplFileInputTrivia with

    static member CreateByDefault(?conditionalDirectives, ?codeComments) : ParsedImplFileInputTrivia =
        { ConditionalDirectives = conditionalDirectives |> Option.defaultValue List.empty
          CodeComments = codeComments |> Option.defaultValue List.empty }

type ParsedSigFileInputTrivia with

    static member CreateByDefault(?conditionalDirectives, ?codeComments) : ParsedSigFileInputTrivia =
        { ConditionalDirectives = conditionalDirectives |> Option.defaultValue List.empty
          CodeComments = codeComments |> Option.defaultValue List.empty }

type SynExprTryWithTrivia with

    static member CreateByDefault(?tryKeyword, ?tryToWithRange, ?withKeyword, ?withToEndRange) : SynExprTryWithTrivia =
        { TryKeyword = tryKeyword |> Option.defaultValue Range.Zero
          TryToWithRange = tryToWithRange |> Option.defaultValue Range.Zero
          WithKeyword = withKeyword |> Option.defaultValue Range.Zero
          WithToEndRange = withToEndRange |> Option.defaultValue Range.Zero }

type SynExprTryFinallyTrivia with

    static member CreateByDefault(?tryKeyword, ?finallyKeyword) : SynExprTryFinallyTrivia =
        { TryKeyword = tryKeyword |> Option.defaultValue Range.Zero
          FinallyKeyword = finallyKeyword |> Option.defaultValue Range.Zero }

type SynExprIfThenElseTrivia with

    static member CreateByDefault
        (
            ?ifKeyword,
            ?isElif,
            ?thenKeyword,
            ?elseKeyword,
            ?ifToThenRange
        ) : SynExprIfThenElseTrivia =
        { IfKeyword = ifKeyword |> Option.defaultValue Range.Zero
          IsElif = isElif |> Option.defaultValue false
          ThenKeyword = thenKeyword |> Option.defaultValue Range.Zero
          ElseKeyword = elseKeyword |> Option.defaultValue Option.None
          IfToThenRange = ifToThenRange |> Option.defaultValue Range.Zero }

type SynExprLambdaTrivia with

    static member CreateByDefault(?arrowRange) : SynExprLambdaTrivia =
        { ArrowRange = arrowRange |> Option.defaultValue Option.None }

type SynExprDotLambdaTrivia with

    static member CreateByDefault(?underscoreRange, ?dotRange) : SynExprDotLambdaTrivia =
        { UnderscoreRange = underscoreRange |> Option.defaultValue Range.Zero
          DotRange = dotRange |> Option.defaultValue Range.Zero }

type SynExprLetOrUseTrivia with

    static member CreateByDefault(?inKeyword) : SynExprLetOrUseTrivia =
        { InKeyword = inKeyword |> Option.defaultValue Option.None }

type SynExprLetOrUseBangTrivia with

    static member CreateByDefault(?equalsRange) : SynExprLetOrUseBangTrivia =
        { EqualsRange = equalsRange |> Option.defaultValue Option.None }

type SynExprMatchTrivia with

    static member CreateByDefault(?matchKeyword, ?withKeyword) : SynExprMatchTrivia =
        { MatchKeyword = matchKeyword |> Option.defaultValue Range.Zero
          WithKeyword = withKeyword |> Option.defaultValue Range.Zero }

type SynExprMatchBangTrivia with

    static member CreateByDefault(?matchBangKeyword, ?withKeyword) : SynExprMatchBangTrivia =
        { MatchBangKeyword = matchBangKeyword |> Option.defaultValue Range.Zero
          WithKeyword = withKeyword |> Option.defaultValue Range.Zero }

type SynExprAnonRecdTrivia with

    static member CreateByDefault(?openingBraceRange) : SynExprAnonRecdTrivia =
        { OpeningBraceRange = openingBraceRange |> Option.defaultValue Range.Zero }

type SynMatchClauseTrivia with

    static member CreateByDefault(?arrowRange, ?barRange) : SynMatchClauseTrivia =
        { ArrowRange = arrowRange |> Option.defaultValue Option.None
          BarRange = barRange |> Option.defaultValue Option.None }

type SynEnumCaseTrivia with

    static member CreateByDefault(?barRange, ?equalsRange) : SynEnumCaseTrivia =
        { BarRange = barRange |> Option.defaultValue Option.None
          EqualsRange = equalsRange |> Option.defaultValue Range.Zero }

type SynUnionCaseTrivia with

    static member CreateByDefault(?barRange) : SynUnionCaseTrivia =
        { BarRange = barRange |> Option.defaultValue Option.None }

type SynPatOrTrivia with

    static member CreateByDefault(?barRange) : SynPatOrTrivia =
        { BarRange = barRange |> Option.defaultValue Range.Zero }

type SynPatListConsTrivia with

    static member CreateByDefault(?colonColonRange) : SynPatListConsTrivia =
        { ColonColonRange = colonColonRange |> Option.defaultValue Range.Zero }

type SynTypeDefnTrivia with

    static member CreateByDefault(leadingKeyword, ?equalsRange, ?withKeyword) : SynTypeDefnTrivia =
        { LeadingKeyword = leadingKeyword
          EqualsRange = equalsRange |> Option.defaultValue Option.None
          WithKeyword = withKeyword |> Option.defaultValue Option.None }

type SynTypeDefnSigTrivia with

    static member CreateByDefault(leadingKeyword, ?equalsRange, ?withKeyword) : SynTypeDefnSigTrivia =
        { LeadingKeyword = leadingKeyword
          EqualsRange = equalsRange |> Option.defaultValue Option.None
          WithKeyword = withKeyword |> Option.defaultValue Option.None }

type SynBindingTrivia with

    static member CreateByDefault(leadingKeyword, ?inlineKeyword, ?equalsRange) : SynBindingTrivia =
        { LeadingKeyword = leadingKeyword
          InlineKeyword = inlineKeyword |> Option.defaultValue Option.None
          EqualsRange = equalsRange |> Option.defaultValue Option.None }

type SynExprAndBangTrivia with

    static member CreateByDefault(?equalsRange, ?inKeyword) : SynExprAndBangTrivia =
        { EqualsRange = equalsRange |> Option.defaultValue Range.Zero
          InKeyword = inKeyword |> Option.defaultValue Option.None }

type SynModuleDeclNestedModuleTrivia with

    static member CreateByDefault(?moduleKeyword, ?equalsRange) : SynModuleDeclNestedModuleTrivia =
        { ModuleKeyword = moduleKeyword |> Option.defaultValue Option.None
          EqualsRange = equalsRange |> Option.defaultValue Option.None }

type SynModuleSigDeclNestedModuleTrivia with

    static member CreateByDefault(?moduleKeyword, ?equalsRange) : SynModuleSigDeclNestedModuleTrivia =
        { ModuleKeyword = moduleKeyword |> Option.defaultValue Option.None
          EqualsRange = equalsRange |> Option.defaultValue Option.None }

type SynModuleOrNamespaceTrivia with

    static member CreateByDefault(leadingKeyword) : SynModuleOrNamespaceTrivia = { LeadingKeyword = leadingKeyword }

type SynModuleOrNamespaceSigTrivia with

    static member CreateByDefault(leadingKeyword) : SynModuleOrNamespaceSigTrivia = { LeadingKeyword = leadingKeyword }

type SynValSigTrivia with

    static member CreateByDefault(leadingKeyword, ?inlineKeyword, ?withKeyword, ?equalsRange) : SynValSigTrivia =
        { LeadingKeyword = leadingKeyword
          InlineKeyword = inlineKeyword |> Option.defaultValue Option.None
          WithKeyword = withKeyword |> Option.defaultValue Option.None
          EqualsRange = equalsRange |> Option.defaultValue Option.None }

type SynTypeFunTrivia with

    static member CreateByDefault(?arrowRange) : SynTypeFunTrivia =
        { ArrowRange = arrowRange |> Option.defaultValue Range.Zero }

type SynMemberGetSetTrivia with

    static member CreateByDefault
        (
            ?inlineKeyword,
            ?withKeyword,
            ?getKeyword,
            ?andKeyword,
            ?setKeyword
        ) : SynMemberGetSetTrivia =
        { InlineKeyword = inlineKeyword |> Option.defaultValue Option.None
          WithKeyword = withKeyword |> Option.defaultValue Range.Zero
          GetKeyword = getKeyword |> Option.defaultValue Option.None
          AndKeyword = andKeyword |> Option.defaultValue Option.None
          SetKeyword = setKeyword |> Option.defaultValue Option.None }

type SynMemberDefnImplicitCtorTrivia with

    static member CreateByDefault(?asKeyword) : SynMemberDefnImplicitCtorTrivia =
        { AsKeyword = asKeyword |> Option.defaultValue Option.None }

type SynArgPatsNamePatPairsTrivia with

    static member CreateByDefault(?parenRange) : SynArgPatsNamePatPairsTrivia =
        { ParenRange = parenRange |> Option.defaultValue Range.Zero }

type SynMemberDefnAutoPropertyTrivia with

    static member CreateByDefault
        (
            leadingKeyword,
            ?withKeyword,
            ?equalsRange,
            ?getSetKeywords
        ) : SynMemberDefnAutoPropertyTrivia =
        { LeadingKeyword = leadingKeyword
          WithKeyword = withKeyword |> Option.defaultValue Option.None
          EqualsRange = equalsRange |> Option.defaultValue Option.None
          GetSetKeywords = getSetKeywords |> Option.defaultValue Option.None }

type SynMemberDefnAbstractSlotTrivia with

    static member CreateByDefault(?getSetKeywords) : SynMemberDefnAbstractSlotTrivia =
        { GetSetKeywords = getSetKeywords |> Option.defaultValue Option.None }

type SynFieldTrivia with

    static member CreateByDefault(?leadingKeyword) : SynFieldTrivia =
        { LeadingKeyword = leadingKeyword |> Option.defaultValue Option.None }

type SynTypeOrTrivia with

    static member CreateByDefault(?orKeyword) : SynTypeOrTrivia =
        { OrKeyword = orKeyword |> Option.defaultValue Range.Zero }

type SynBindingReturnInfoTrivia with

    static member CreateByDefault(?colonRange) : SynBindingReturnInfoTrivia =
        { ColonRange = colonRange |> Option.defaultValue Option.None }

type SynMemberSigMemberTrivia with

    static member CreateByDefault(?getSetKeywords) : SynMemberSigMemberTrivia =
        { GetSetKeywords = getSetKeywords |> Option.defaultValue Option.None }

type SynTyparDeclTrivia with

    static member CreateByDefault(?ampersandRanges) : SynTyparDeclTrivia =
        { AmpersandRanges = ampersandRanges |> Option.defaultValue List.empty }

type SynMeasureConstantTrivia with

    static member CreateByDefault(?lessRange, ?greaterRange) : SynMeasureConstantTrivia =
        { LessRange = lessRange |> Option.defaultValue Range.Zero
          GreaterRange = greaterRange |> Option.defaultValue Range.Zero }

type SynAttribute with

    static member CreateByDefault(typeName, argExpr, ?target, ?appliesToGetterAndSetter, ?range) : SynAttribute =
        { TypeName = typeName
          ArgExpr = argExpr
          Target = target |> Option.defaultValue Option.None
          AppliesToGetterAndSetter = appliesToGetterAndSetter |> Option.defaultValue false
          Range = range |> Option.defaultValue Range.Zero }

type SynAttributeList with

    static member CreateByDefault(?attributes, ?range) : SynAttributeList =
        { Attributes = attributes |> Option.defaultValue List.empty
          Range = range |> Option.defaultValue Range.Zero }

type SynMemberFlags with

    static member CreateByDefault
        (
            memberKind,
            ?isInstance,
            ?isDispatchSlot,
            ?isOverrideOrExplicitImpl,
            ?isFinal,
            ?getterOrSetterIsCompilerGenerated
        ) : SynMemberFlags =
        { IsInstance = isInstance |> Option.defaultValue false
          IsDispatchSlot = isDispatchSlot |> Option.defaultValue false
          IsOverrideOrExplicitImpl = isOverrideOrExplicitImpl |> Option.defaultValue false
          IsFinal = isFinal |> Option.defaultValue false
          GetterOrSetterIsCompilerGenerated = getterOrSetterIsCompilerGenerated |> Option.defaultValue false
          MemberKind = memberKind }
