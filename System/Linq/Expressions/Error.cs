internal static class Error // TypeDefIndex: 2263
{
	// Methods

	// RVA: 0x16AE680 Offset: 0x16AE781 VA: 0x16AE680
	internal static Exception ReducibleMustOverrideReduce() { }

	// RVA: 0x169CBE0 Offset: 0x169CCE1 VA: 0x169CBE0
	internal static Exception AmbiguousMatchInExpandoObject(object p0) { }

	// RVA: 0x169D320 Offset: 0x169D421 VA: 0x169D320
	internal static Exception SameKeyExistsInExpando(object key) { }

	// RVA: 0x169E040 Offset: 0x169E141 VA: 0x169E040
	internal static Exception KeyDoesNotExistInExpando(object p0) { }

	// RVA: 0x169F110 Offset: 0x169F211 VA: 0x169F110
	internal static Exception CollectionModifiedWhileEnumerating() { }

	// RVA: 0x169F570 Offset: 0x169F671 VA: 0x169F570
	internal static Exception CollectionReadOnly() { }

	// RVA: 0x16AE6F0 Offset: 0x16AE7F1 VA: 0x16AE6F0
	internal static Exception MustReduceToDifferent() { }

	// RVA: 0x16AE760 Offset: 0x16AE861 VA: 0x16AE760
	internal static Exception ReducedNotCompatible() { }

	// RVA: 0x16AE7D0 Offset: 0x16AE8D1 VA: 0x16AE7D0
	internal static Exception SetterHasNoParams(string paramName) { }

	// RVA: 0x16AE850 Offset: 0x16AE951 VA: 0x16AE850
	internal static Exception PropertyCannotHaveRefType(string paramName) { }

	// RVA: 0x16AE8D0 Offset: 0x16AE9D1 VA: 0x16AE8D0
	internal static Exception IndexesOfSetGetMustMatch(string paramName) { }

	// RVA: 0x16AE950 Offset: 0x16AEA51 VA: 0x16AE950
	internal static Exception AccessorsCannotHaveVarArgs(string paramName) { }

	// RVA: 0x16AE9D0 Offset: 0x16AEAD1 VA: 0x16AE9D0
	private static Exception AccessorsCannotHaveByRefArgs(string paramName) { }

	// RVA: 0x16AEA50 Offset: 0x16AEB51 VA: 0x16AEA50
	internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) { }

	// RVA: 0x16AEBC0 Offset: 0x16AECC1 VA: 0x16AEBC0
	internal static Exception BoundsCannotBeLessThanOne(string paramName) { }

	// RVA: 0x16A5500 Offset: 0x16A5601 VA: 0x16A5500
	internal static Exception TypeMustNotBeByRef(string paramName) { }

	// RVA: 0x16A5580 Offset: 0x16A5681 VA: 0x16A5580
	internal static Exception TypeMustNotBePointer(string paramName) { }

	// RVA: 0x16AEC40 Offset: 0x16AED41 VA: 0x16AEC40
	internal static Exception SetterMustBeVoid(string paramName) { }

	// RVA: 0x16AECC0 Offset: 0x16AEDC1 VA: 0x16AECC0
	internal static Exception PropertyTypeMustMatchGetter(string paramName) { }

	// RVA: 0x16AED40 Offset: 0x16AEE41 VA: 0x16AED40
	internal static Exception PropertyTypeMustMatchSetter(string paramName) { }

	// RVA: 0x16AEDC0 Offset: 0x16AEEC1 VA: 0x16AEDC0
	internal static Exception BothAccessorsMustBeStatic(string paramName) { }

	// RVA: 0x16AEE40 Offset: 0x16AEF41 VA: 0x16AEE40
	internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) { }

	// RVA: 0x16AEEC0 Offset: 0x16AEFC1 VA: 0x16AEEC0
	internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) { }

	// RVA: 0x16AEF40 Offset: 0x16AF041 VA: 0x16AEF40
	internal static Exception OnlyStaticMethodsHaveNullInstance() { }

	// RVA: 0x16AEFB0 Offset: 0x16AF0B1 VA: 0x16AEFB0
	internal static Exception PropertyTypeCannotBeVoid(string paramName) { }

	// RVA: 0x16AF030 Offset: 0x16AF131 VA: 0x16AF030
	internal static Exception InvalidUnboxType(string paramName) { }

	// RVA: 0x16AF0B0 Offset: 0x16AF1B1 VA: 0x16AF0B0
	internal static Exception ExpressionMustBeWriteable(string paramName) { }

	// RVA: 0x16AF130 Offset: 0x16AF231 VA: 0x16AF130
	internal static Exception ArgumentMustNotHaveValueType(string paramName) { }

	// RVA: 0x16AF1B0 Offset: 0x16AF2B1 VA: 0x16AF1B0
	internal static Exception MustBeReducible() { }

	// RVA: 0x16AF220 Offset: 0x16AF321 VA: 0x16AF220
	internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) { }

	// RVA: 0x16AF2A0 Offset: 0x16AF3A1 VA: 0x16AF2A0
	internal static Exception QuotedExpressionMustBeLambda(string paramName) { }

	// RVA: 0x16AF320 Offset: 0x16AF421 VA: 0x16AF320
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) { }

	// RVA: 0x16AF3B0 Offset: 0x16AF4B1 VA: 0x16AF3B0
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16AF4B0 Offset: 0x16AF5B1 VA: 0x16AF4B0
	private static Exception DuplicateVariable(object p0, string paramName) { }

	// RVA: 0x16AF540 Offset: 0x16AF641 VA: 0x16AF540
	internal static Exception DuplicateVariable(object p0, string paramName, int index) { }

	// RVA: 0x16AF630 Offset: 0x16AF731 VA: 0x16AF630
	internal static Exception FaultCannotHaveCatchOrFinally(string paramName) { }

	// RVA: 0x16AF6B0 Offset: 0x16AF7B1 VA: 0x16AF6B0
	internal static Exception TryMustHaveCatchFinallyOrFault() { }

	// RVA: 0x16AF720 Offset: 0x16AF821 VA: 0x16AF720
	internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	// RVA: 0x16AF790 Offset: 0x16AF891 VA: 0x16AF790
	internal static Exception ExtensionNodeMustOverrideProperty(object p0) { }

	// RVA: 0x16AF810 Offset: 0x16AF911 VA: 0x16AF810
	internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) { }

	// RVA: 0x16AF8A0 Offset: 0x16AF9A1 VA: 0x16AF8A0
	internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) { }

	// RVA: 0x16AF930 Offset: 0x16AFA31 VA: 0x16AF930
	internal static Exception CoercionOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x16AF9C0 Offset: 0x16AFAC1 VA: 0x16AF9C0
	internal static Exception UnaryOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x16AFA50 Offset: 0x16AFB51 VA: 0x16AFA50
	internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	// RVA: 0x16AFAE0 Offset: 0x16AFBE1 VA: 0x16AFAE0
	internal static Exception ReferenceEqualityNotDefined(object p0, object p1) { }

	// RVA: 0x16AFB70 Offset: 0x16AFC71 VA: 0x16AFB70
	internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) { }

	// RVA: 0x16AFC00 Offset: 0x16AFD01 VA: 0x16AFC00
	internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	// RVA: 0x16AFC90 Offset: 0x16AFD91 VA: 0x16AFC90
	internal static Exception ConversionIsNotSupportedForArithmeticTypes() { }

	// RVA: 0x16AFD00 Offset: 0x16AFE01 VA: 0x16AFD00
	internal static Exception ArgumentMustBeArray(string paramName) { }

	// RVA: 0x16AFD80 Offset: 0x16AFE81 VA: 0x16AFD80
	internal static Exception ArgumentMustBeBoolean(string paramName) { }

	// RVA: 0x16AFE00 Offset: 0x16AFF01 VA: 0x16AFE00
	private static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName) { }

	// RVA: 0x16AFE80 Offset: 0x16AFF81 VA: 0x16AFE80
	internal static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName, int index) { }

	// RVA: 0x16AFF60 Offset: 0x16B0061 VA: 0x16AFF60
	private static Exception ArgumentMustBeInstanceMember(string paramName) { }

	// RVA: 0x16AFFE0 Offset: 0x16B00E1 VA: 0x16AFFE0
	internal static Exception ArgumentMustBeInstanceMember(string paramName, int index) { }

	// RVA: 0x16B00C0 Offset: 0x16B01C1 VA: 0x16B00C0
	private static Exception ArgumentMustBeInteger(string paramName) { }

	// RVA: 0x16B0140 Offset: 0x16B0241 VA: 0x16B0140
	internal static Exception ArgumentMustBeInteger(string paramName, int index) { }

	// RVA: 0x16B0220 Offset: 0x16B0321 VA: 0x16B0220
	internal static Exception ArgumentMustBeArrayIndexType(string paramName) { }

	// RVA: 0x16B02A0 Offset: 0x16B03A1 VA: 0x16B02A0
	internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) { }

	// RVA: 0x16B0320 Offset: 0x16B0421 VA: 0x16B0320
	internal static Exception ArgumentTypesMustMatch() { }

	// RVA: 0x16B0390 Offset: 0x16B0491 VA: 0x16B0390
	internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	// RVA: 0x16B0410 Offset: 0x16B0511 VA: 0x16B0410
	internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) { }

	// RVA: 0x16B04A0 Offset: 0x16B05A1 VA: 0x16B04A0
	internal static Exception CoalesceUsedOnNonNullType() { }

	// RVA: 0x16B0510 Offset: 0x16B0611 VA: 0x16B0510
	internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	// RVA: 0x16B05A0 Offset: 0x16B06A1 VA: 0x16B05A0
	private static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName) { }

	// RVA: 0x16B0630 Offset: 0x16B0731 VA: 0x16B0630
	internal static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B0730 Offset: 0x16B0831 VA: 0x16B0730
	private static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName) { }

	// RVA: 0x16B07C0 Offset: 0x16B08C1 VA: 0x16B07C0
	internal static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B08C0 Offset: 0x16B09C1 VA: 0x16B08C0
	internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	// RVA: 0x16B0950 Offset: 0x16B0A51 VA: 0x16B0950
	internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	// RVA: 0x16B09E0 Offset: 0x16B0AE1 VA: 0x16B09E0
	internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	// RVA: 0x16B0A70 Offset: 0x16B0B71 VA: 0x16B0A70
	internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) { }

	// RVA: 0x16B0B00 Offset: 0x16B0C01 VA: 0x16B0B00
	internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x16B0B90 Offset: 0x16B0C91 VA: 0x16B0B90
	internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	// RVA: 0x16B0C20 Offset: 0x16B0D21 VA: 0x16B0C20
	internal static Exception IncorrectNumberOfIndexes() { }

	// RVA: 0x16B0C90 Offset: 0x16B0D91 VA: 0x16B0C90
	internal static Exception IncorrectNumberOfLambdaDeclarationParameters() { }

	// RVA: 0x16B0D00 Offset: 0x16B0E01 VA: 0x16B0D00
	internal static Exception IncorrectNumberOfMembersForGivenConstructor() { }

	// RVA: 0x16B0D70 Offset: 0x16B0E71 VA: 0x16B0D70
	internal static Exception IncorrectNumberOfArgumentsForMembers() { }

	// RVA: 0x16B0DE0 Offset: 0x16B0EE1 VA: 0x16B0DE0
	internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) { }

	// RVA: 0x16B0E60 Offset: 0x16B0F61 VA: 0x16B0E60
	internal static Exception MemberNotFieldOrProperty(object p0, string paramName) { }

	// RVA: 0x16B0EF0 Offset: 0x16B0FF1 VA: 0x16B0EF0
	internal static Exception MethodContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x16B0F80 Offset: 0x16B1081 VA: 0x16B0F80
	internal static Exception MethodIsGeneric(object p0, string paramName) { }

	// RVA: 0x16B1010 Offset: 0x16B1111 VA: 0x16B1010
	private static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName) { }

	// RVA: 0x16B10A0 Offset: 0x16B11A1 VA: 0x16B10A0
	internal static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B11A0 Offset: 0x16B12A1 VA: 0x16B11A0
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName) { }

	// RVA: 0x16B1230 Offset: 0x16B1331 VA: 0x16B1230
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName, int index) { }

	// RVA: 0x16B1320 Offset: 0x16B1421 VA: 0x16B1320
	internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) { }

	// RVA: 0x16B13B0 Offset: 0x16B14B1 VA: 0x16B13B0
	internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	// RVA: 0x16B1440 Offset: 0x16B1541 VA: 0x16B1440
	internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x16B14D0 Offset: 0x16B15D1 VA: 0x16B14D0
	internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x16B1560 Offset: 0x16B1661 VA: 0x16B1560
	internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	// RVA: 0x16B15F0 Offset: 0x16B16F1 VA: 0x16B15F0
	internal static Exception UnhandledBinary(object p0, string paramName) { }

	// RVA: 0x16B1680 Offset: 0x16B1781 VA: 0x16B1680
	internal static Exception UnhandledUnary(object p0, string paramName) { }

	// RVA: 0x16B1710 Offset: 0x16B1811 VA: 0x16B1710
	internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	// RVA: 0x16B17A0 Offset: 0x16B18A1 VA: 0x16B17A0
	internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	// RVA: 0x16B1830 Offset: 0x16B1931 VA: 0x16B1830
	internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	// RVA: 0x16B18C0 Offset: 0x16B19C1 VA: 0x16B18C0
	internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x16B1950 Offset: 0x16B1A51 VA: 0x16B1950
	internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x16B19E0 Offset: 0x16B1AE1 VA: 0x16B19E0
	internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x16B1A70 Offset: 0x16B1B71 VA: 0x16B1A70
	internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) { }

	// RVA: 0x16B1AF0 Offset: 0x16B1BF1 VA: 0x16B1AF0
	internal static Exception LabelTargetAlreadyDefined(object p0) { }

	// RVA: 0x16B1B70 Offset: 0x16B1C71 VA: 0x16B1B70
	internal static Exception LabelTargetUndefined(object p0) { }

	// RVA: 0x16B1BF0 Offset: 0x16B1CF1 VA: 0x16B1BF0
	internal static Exception ControlCannotLeaveFinally() { }

	// RVA: 0x16B1C60 Offset: 0x16B1D61 VA: 0x16B1C60
	internal static Exception ControlCannotLeaveFilterTest() { }

	// RVA: 0x16B1CD0 Offset: 0x16B1DD1 VA: 0x16B1CD0
	internal static Exception AmbiguousJump(object p0) { }

	// RVA: 0x16B1D50 Offset: 0x16B1E51 VA: 0x16B1D50
	internal static Exception ControlCannotEnterTry() { }

	// RVA: 0x16B1DC0 Offset: 0x16B1EC1 VA: 0x16B1DC0
	internal static Exception ControlCannotEnterExpression() { }

	// RVA: 0x16B1E30 Offset: 0x16B1F31 VA: 0x16B1E30
	internal static Exception NonLocalJumpWithValue(object p0) { }

	// RVA: 0x16B1EB0 Offset: 0x16B1FB1 VA: 0x16B1EB0
	internal static Exception InvalidLvalue(ExpressionType p0) { }

	// RVA: 0x16B1F40 Offset: 0x16B2041 VA: 0x16B1F40
	internal static Exception RethrowRequiresCatch() { }

	// RVA: 0x16B1FB0 Offset: 0x16B20B1 VA: 0x16B1FB0
	internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) { }

	// RVA: 0x16B2040 Offset: 0x16B2141 VA: 0x16B2040
	internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) { }

	// RVA: 0x16B20D0 Offset: 0x16B21D1 VA: 0x16B20D0
	internal static Exception MustRewriteWithoutMethod(object p0, object p1) { }

	// RVA: 0x16AB6A0 Offset: 0x16AB7A1 VA: 0x16AB6A0
	internal static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x16B2160 Offset: 0x16B2261 VA: 0x16B2160
	internal static Exception NotSupported() { }

	// RVA: 0x16B21C0 Offset: 0x16B22C1 VA: 0x16B21C0
	internal static Exception NonStaticConstructorRequired(string paramName) { }

	// RVA: 0x16B2240 Offset: 0x16B2341 VA: 0x16B2240
	internal static Exception NonAbstractConstructorRequired() { }

	// RVA: 0x16B22B0 Offset: 0x16B23B1 VA: 0x16B22B0
	internal static Exception InvalidProgram() { }

	// RVA: 0x16B2310 Offset: 0x16B2411 VA: 0x16B2310
	internal static Exception EnumerationIsDone() { }

	// RVA: 0x16B2380 Offset: 0x16B2481 VA: 0x16B2380
	private static Exception TypeContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x16A5600 Offset: 0x16A5701 VA: 0x16A5600
	internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) { }

	// RVA: 0x16B2410 Offset: 0x16B2511 VA: 0x16B2410
	internal static Exception TypeIsGeneric(object p0, string paramName) { }

	// RVA: 0x16A56F0 Offset: 0x16A57F1 VA: 0x16A56F0
	internal static Exception TypeIsGeneric(object p0, string paramName, int index) { }

	// RVA: 0x16A09E0 Offset: 0x16A0AE1 VA: 0x16A09E0
	internal static Exception IncorrectNumberOfConstructorArguments() { }

	// RVA: 0x16B24A0 Offset: 0x16B25A1 VA: 0x16B24A0
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) { }

	// RVA: 0x16A1270 Offset: 0x16A1371 VA: 0x16A1270
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) { }

	// RVA: 0x16B2540 Offset: 0x16B2641 VA: 0x16B2540
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) { }

	// RVA: 0x16A1170 Offset: 0x16A1271 VA: 0x16A1170
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16A0A50 Offset: 0x16A0B51 VA: 0x16A0A50
	internal static Exception IncorrectNumberOfLambdaArguments() { }

	// RVA: 0x16A0AC0 Offset: 0x16A0BC1 VA: 0x16A0AC0
	internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) { }

	// RVA: 0x16B25D0 Offset: 0x16B26D1 VA: 0x16B25D0
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) { }

	// RVA: 0x16A1070 Offset: 0x16A1171 VA: 0x16A1070
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B2660 Offset: 0x16B2761 VA: 0x16B2660
	internal static Exception ExpressionMustBeReadable(string paramName) { }

	// RVA: 0x16A1390 Offset: 0x16A1491 VA: 0x16A1390
	internal static Exception ExpressionMustBeReadable(string paramName, int index) { }

	// RVA: 0x16A00F0 Offset: 0x16A01F1 VA: 0x16A00F0
	internal static Exception InvalidArgumentValue(string paramName) { }

	// RVA: 0x16B26E0 Offset: 0x16B27E1 VA: 0x16B26E0
	internal static Exception InvalidNullValue(Type type, string paramName) { }

	// RVA: 0x16B2770 Offset: 0x16B2871 VA: 0x16B2770
	internal static Exception InvalidTypeException(object value, Type type, string paramName) { }

	// RVA: 0x16AEB30 Offset: 0x16AEC31 VA: 0x16AEB30
	private static string GetParamName(string paramName, int index) { }
}

internal static class Error // TypeDefIndex: 2263
{
	// Methods

	// RVA: 0x16AE680 Offset: 0x16AE781 VA: 0x16AE680
	internal static Exception ReducibleMustOverrideReduce() { }

	// RVA: 0x169CBE0 Offset: 0x169CCE1 VA: 0x169CBE0
	internal static Exception AmbiguousMatchInExpandoObject(object p0) { }

	// RVA: 0x169D320 Offset: 0x169D421 VA: 0x169D320
	internal static Exception SameKeyExistsInExpando(object key) { }

	// RVA: 0x169E040 Offset: 0x169E141 VA: 0x169E040
	internal static Exception KeyDoesNotExistInExpando(object p0) { }

	// RVA: 0x169F110 Offset: 0x169F211 VA: 0x169F110
	internal static Exception CollectionModifiedWhileEnumerating() { }

	// RVA: 0x169F570 Offset: 0x169F671 VA: 0x169F570
	internal static Exception CollectionReadOnly() { }

	// RVA: 0x16AE6F0 Offset: 0x16AE7F1 VA: 0x16AE6F0
	internal static Exception MustReduceToDifferent() { }

	// RVA: 0x16AE760 Offset: 0x16AE861 VA: 0x16AE760
	internal static Exception ReducedNotCompatible() { }

	// RVA: 0x16AE7D0 Offset: 0x16AE8D1 VA: 0x16AE7D0
	internal static Exception SetterHasNoParams(string paramName) { }

	// RVA: 0x16AE850 Offset: 0x16AE951 VA: 0x16AE850
	internal static Exception PropertyCannotHaveRefType(string paramName) { }

	// RVA: 0x16AE8D0 Offset: 0x16AE9D1 VA: 0x16AE8D0
	internal static Exception IndexesOfSetGetMustMatch(string paramName) { }

	// RVA: 0x16AE950 Offset: 0x16AEA51 VA: 0x16AE950
	internal static Exception AccessorsCannotHaveVarArgs(string paramName) { }

	// RVA: 0x16AE9D0 Offset: 0x16AEAD1 VA: 0x16AE9D0
	private static Exception AccessorsCannotHaveByRefArgs(string paramName) { }

	// RVA: 0x16AEA50 Offset: 0x16AEB51 VA: 0x16AEA50
	internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) { }

	// RVA: 0x16AEBC0 Offset: 0x16AECC1 VA: 0x16AEBC0
	internal static Exception BoundsCannotBeLessThanOne(string paramName) { }

	// RVA: 0x16A5500 Offset: 0x16A5601 VA: 0x16A5500
	internal static Exception TypeMustNotBeByRef(string paramName) { }

	// RVA: 0x16A5580 Offset: 0x16A5681 VA: 0x16A5580
	internal static Exception TypeMustNotBePointer(string paramName) { }

	// RVA: 0x16AEC40 Offset: 0x16AED41 VA: 0x16AEC40
	internal static Exception SetterMustBeVoid(string paramName) { }

	// RVA: 0x16AECC0 Offset: 0x16AEDC1 VA: 0x16AECC0
	internal static Exception PropertyTypeMustMatchGetter(string paramName) { }

	// RVA: 0x16AED40 Offset: 0x16AEE41 VA: 0x16AED40
	internal static Exception PropertyTypeMustMatchSetter(string paramName) { }

	// RVA: 0x16AEDC0 Offset: 0x16AEEC1 VA: 0x16AEDC0
	internal static Exception BothAccessorsMustBeStatic(string paramName) { }

	// RVA: 0x16AEE40 Offset: 0x16AEF41 VA: 0x16AEE40
	internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) { }

	// RVA: 0x16AEEC0 Offset: 0x16AEFC1 VA: 0x16AEEC0
	internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) { }

	// RVA: 0x16AEF40 Offset: 0x16AF041 VA: 0x16AEF40
	internal static Exception OnlyStaticMethodsHaveNullInstance() { }

	// RVA: 0x16AEFB0 Offset: 0x16AF0B1 VA: 0x16AEFB0
	internal static Exception PropertyTypeCannotBeVoid(string paramName) { }

	// RVA: 0x16AF030 Offset: 0x16AF131 VA: 0x16AF030
	internal static Exception InvalidUnboxType(string paramName) { }

	// RVA: 0x16AF0B0 Offset: 0x16AF1B1 VA: 0x16AF0B0
	internal static Exception ExpressionMustBeWriteable(string paramName) { }

	// RVA: 0x16AF130 Offset: 0x16AF231 VA: 0x16AF130
	internal static Exception ArgumentMustNotHaveValueType(string paramName) { }

	// RVA: 0x16AF1B0 Offset: 0x16AF2B1 VA: 0x16AF1B0
	internal static Exception MustBeReducible() { }

	// RVA: 0x16AF220 Offset: 0x16AF321 VA: 0x16AF220
	internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) { }

	// RVA: 0x16AF2A0 Offset: 0x16AF3A1 VA: 0x16AF2A0
	internal static Exception QuotedExpressionMustBeLambda(string paramName) { }

	// RVA: 0x16AF320 Offset: 0x16AF421 VA: 0x16AF320
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) { }

	// RVA: 0x16AF3B0 Offset: 0x16AF4B1 VA: 0x16AF3B0
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16AF4B0 Offset: 0x16AF5B1 VA: 0x16AF4B0
	private static Exception DuplicateVariable(object p0, string paramName) { }

	// RVA: 0x16AF540 Offset: 0x16AF641 VA: 0x16AF540
	internal static Exception DuplicateVariable(object p0, string paramName, int index) { }

	// RVA: 0x16AF630 Offset: 0x16AF731 VA: 0x16AF630
	internal static Exception FaultCannotHaveCatchOrFinally(string paramName) { }

	// RVA: 0x16AF6B0 Offset: 0x16AF7B1 VA: 0x16AF6B0
	internal static Exception TryMustHaveCatchFinallyOrFault() { }

	// RVA: 0x16AF720 Offset: 0x16AF821 VA: 0x16AF720
	internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	// RVA: 0x16AF790 Offset: 0x16AF891 VA: 0x16AF790
	internal static Exception ExtensionNodeMustOverrideProperty(object p0) { }

	// RVA: 0x16AF810 Offset: 0x16AF911 VA: 0x16AF810
	internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) { }

	// RVA: 0x16AF8A0 Offset: 0x16AF9A1 VA: 0x16AF8A0
	internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) { }

	// RVA: 0x16AF930 Offset: 0x16AFA31 VA: 0x16AF930
	internal static Exception CoercionOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x16AF9C0 Offset: 0x16AFAC1 VA: 0x16AF9C0
	internal static Exception UnaryOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x16AFA50 Offset: 0x16AFB51 VA: 0x16AFA50
	internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	// RVA: 0x16AFAE0 Offset: 0x16AFBE1 VA: 0x16AFAE0
	internal static Exception ReferenceEqualityNotDefined(object p0, object p1) { }

	// RVA: 0x16AFB70 Offset: 0x16AFC71 VA: 0x16AFB70
	internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) { }

	// RVA: 0x16AFC00 Offset: 0x16AFD01 VA: 0x16AFC00
	internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	// RVA: 0x16AFC90 Offset: 0x16AFD91 VA: 0x16AFC90
	internal static Exception ConversionIsNotSupportedForArithmeticTypes() { }

	// RVA: 0x16AFD00 Offset: 0x16AFE01 VA: 0x16AFD00
	internal static Exception ArgumentMustBeArray(string paramName) { }

	// RVA: 0x16AFD80 Offset: 0x16AFE81 VA: 0x16AFD80
	internal static Exception ArgumentMustBeBoolean(string paramName) { }

	// RVA: 0x16AFE00 Offset: 0x16AFF01 VA: 0x16AFE00
	private static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName) { }

	// RVA: 0x16AFE80 Offset: 0x16AFF81 VA: 0x16AFE80
	internal static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName, int index) { }

	// RVA: 0x16AFF60 Offset: 0x16B0061 VA: 0x16AFF60
	private static Exception ArgumentMustBeInstanceMember(string paramName) { }

	// RVA: 0x16AFFE0 Offset: 0x16B00E1 VA: 0x16AFFE0
	internal static Exception ArgumentMustBeInstanceMember(string paramName, int index) { }

	// RVA: 0x16B00C0 Offset: 0x16B01C1 VA: 0x16B00C0
	private static Exception ArgumentMustBeInteger(string paramName) { }

	// RVA: 0x16B0140 Offset: 0x16B0241 VA: 0x16B0140
	internal static Exception ArgumentMustBeInteger(string paramName, int index) { }

	// RVA: 0x16B0220 Offset: 0x16B0321 VA: 0x16B0220
	internal static Exception ArgumentMustBeArrayIndexType(string paramName) { }

	// RVA: 0x16B02A0 Offset: 0x16B03A1 VA: 0x16B02A0
	internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) { }

	// RVA: 0x16B0320 Offset: 0x16B0421 VA: 0x16B0320
	internal static Exception ArgumentTypesMustMatch() { }

	// RVA: 0x16B0390 Offset: 0x16B0491 VA: 0x16B0390
	internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	// RVA: 0x16B0410 Offset: 0x16B0511 VA: 0x16B0410
	internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) { }

	// RVA: 0x16B04A0 Offset: 0x16B05A1 VA: 0x16B04A0
	internal static Exception CoalesceUsedOnNonNullType() { }

	// RVA: 0x16B0510 Offset: 0x16B0611 VA: 0x16B0510
	internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	// RVA: 0x16B05A0 Offset: 0x16B06A1 VA: 0x16B05A0
	private static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName) { }

	// RVA: 0x16B0630 Offset: 0x16B0731 VA: 0x16B0630
	internal static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B0730 Offset: 0x16B0831 VA: 0x16B0730
	private static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName) { }

	// RVA: 0x16B07C0 Offset: 0x16B08C1 VA: 0x16B07C0
	internal static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B08C0 Offset: 0x16B09C1 VA: 0x16B08C0
	internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	// RVA: 0x16B0950 Offset: 0x16B0A51 VA: 0x16B0950
	internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	// RVA: 0x16B09E0 Offset: 0x16B0AE1 VA: 0x16B09E0
	internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	// RVA: 0x16B0A70 Offset: 0x16B0B71 VA: 0x16B0A70
	internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) { }

	// RVA: 0x16B0B00 Offset: 0x16B0C01 VA: 0x16B0B00
	internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x16B0B90 Offset: 0x16B0C91 VA: 0x16B0B90
	internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	// RVA: 0x16B0C20 Offset: 0x16B0D21 VA: 0x16B0C20
	internal static Exception IncorrectNumberOfIndexes() { }

	// RVA: 0x16B0C90 Offset: 0x16B0D91 VA: 0x16B0C90
	internal static Exception IncorrectNumberOfLambdaDeclarationParameters() { }

	// RVA: 0x16B0D00 Offset: 0x16B0E01 VA: 0x16B0D00
	internal static Exception IncorrectNumberOfMembersForGivenConstructor() { }

	// RVA: 0x16B0D70 Offset: 0x16B0E71 VA: 0x16B0D70
	internal static Exception IncorrectNumberOfArgumentsForMembers() { }

	// RVA: 0x16B0DE0 Offset: 0x16B0EE1 VA: 0x16B0DE0
	internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) { }

	// RVA: 0x16B0E60 Offset: 0x16B0F61 VA: 0x16B0E60
	internal static Exception MemberNotFieldOrProperty(object p0, string paramName) { }

	// RVA: 0x16B0EF0 Offset: 0x16B0FF1 VA: 0x16B0EF0
	internal static Exception MethodContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x16B0F80 Offset: 0x16B1081 VA: 0x16B0F80
	internal static Exception MethodIsGeneric(object p0, string paramName) { }

	// RVA: 0x16B1010 Offset: 0x16B1111 VA: 0x16B1010
	private static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName) { }

	// RVA: 0x16B10A0 Offset: 0x16B11A1 VA: 0x16B10A0
	internal static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B11A0 Offset: 0x16B12A1 VA: 0x16B11A0
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName) { }

	// RVA: 0x16B1230 Offset: 0x16B1331 VA: 0x16B1230
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName, int index) { }

	// RVA: 0x16B1320 Offset: 0x16B1421 VA: 0x16B1320
	internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) { }

	// RVA: 0x16B13B0 Offset: 0x16B14B1 VA: 0x16B13B0
	internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	// RVA: 0x16B1440 Offset: 0x16B1541 VA: 0x16B1440
	internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x16B14D0 Offset: 0x16B15D1 VA: 0x16B14D0
	internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x16B1560 Offset: 0x16B1661 VA: 0x16B1560
	internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	// RVA: 0x16B15F0 Offset: 0x16B16F1 VA: 0x16B15F0
	internal static Exception UnhandledBinary(object p0, string paramName) { }

	// RVA: 0x16B1680 Offset: 0x16B1781 VA: 0x16B1680
	internal static Exception UnhandledUnary(object p0, string paramName) { }

	// RVA: 0x16B1710 Offset: 0x16B1811 VA: 0x16B1710
	internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	// RVA: 0x16B17A0 Offset: 0x16B18A1 VA: 0x16B17A0
	internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	// RVA: 0x16B1830 Offset: 0x16B1931 VA: 0x16B1830
	internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	// RVA: 0x16B18C0 Offset: 0x16B19C1 VA: 0x16B18C0
	internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x16B1950 Offset: 0x16B1A51 VA: 0x16B1950
	internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x16B19E0 Offset: 0x16B1AE1 VA: 0x16B19E0
	internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x16B1A70 Offset: 0x16B1B71 VA: 0x16B1A70
	internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) { }

	// RVA: 0x16B1AF0 Offset: 0x16B1BF1 VA: 0x16B1AF0
	internal static Exception LabelTargetAlreadyDefined(object p0) { }

	// RVA: 0x16B1B70 Offset: 0x16B1C71 VA: 0x16B1B70
	internal static Exception LabelTargetUndefined(object p0) { }

	// RVA: 0x16B1BF0 Offset: 0x16B1CF1 VA: 0x16B1BF0
	internal static Exception ControlCannotLeaveFinally() { }

	// RVA: 0x16B1C60 Offset: 0x16B1D61 VA: 0x16B1C60
	internal static Exception ControlCannotLeaveFilterTest() { }

	// RVA: 0x16B1CD0 Offset: 0x16B1DD1 VA: 0x16B1CD0
	internal static Exception AmbiguousJump(object p0) { }

	// RVA: 0x16B1D50 Offset: 0x16B1E51 VA: 0x16B1D50
	internal static Exception ControlCannotEnterTry() { }

	// RVA: 0x16B1DC0 Offset: 0x16B1EC1 VA: 0x16B1DC0
	internal static Exception ControlCannotEnterExpression() { }

	// RVA: 0x16B1E30 Offset: 0x16B1F31 VA: 0x16B1E30
	internal static Exception NonLocalJumpWithValue(object p0) { }

	// RVA: 0x16B1EB0 Offset: 0x16B1FB1 VA: 0x16B1EB0
	internal static Exception InvalidLvalue(ExpressionType p0) { }

	// RVA: 0x16B1F40 Offset: 0x16B2041 VA: 0x16B1F40
	internal static Exception RethrowRequiresCatch() { }

	// RVA: 0x16B1FB0 Offset: 0x16B20B1 VA: 0x16B1FB0
	internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) { }

	// RVA: 0x16B2040 Offset: 0x16B2141 VA: 0x16B2040
	internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) { }

	// RVA: 0x16B20D0 Offset: 0x16B21D1 VA: 0x16B20D0
	internal static Exception MustRewriteWithoutMethod(object p0, object p1) { }

	// RVA: 0x16AB6A0 Offset: 0x16AB7A1 VA: 0x16AB6A0
	internal static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x16B2160 Offset: 0x16B2261 VA: 0x16B2160
	internal static Exception NotSupported() { }

	// RVA: 0x16B21C0 Offset: 0x16B22C1 VA: 0x16B21C0
	internal static Exception NonStaticConstructorRequired(string paramName) { }

	// RVA: 0x16B2240 Offset: 0x16B2341 VA: 0x16B2240
	internal static Exception NonAbstractConstructorRequired() { }

	// RVA: 0x16B22B0 Offset: 0x16B23B1 VA: 0x16B22B0
	internal static Exception InvalidProgram() { }

	// RVA: 0x16B2310 Offset: 0x16B2411 VA: 0x16B2310
	internal static Exception EnumerationIsDone() { }

	// RVA: 0x16B2380 Offset: 0x16B2481 VA: 0x16B2380
	private static Exception TypeContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x16A5600 Offset: 0x16A5701 VA: 0x16A5600
	internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) { }

	// RVA: 0x16B2410 Offset: 0x16B2511 VA: 0x16B2410
	internal static Exception TypeIsGeneric(object p0, string paramName) { }

	// RVA: 0x16A56F0 Offset: 0x16A57F1 VA: 0x16A56F0
	internal static Exception TypeIsGeneric(object p0, string paramName, int index) { }

	// RVA: 0x16A09E0 Offset: 0x16A0AE1 VA: 0x16A09E0
	internal static Exception IncorrectNumberOfConstructorArguments() { }

	// RVA: 0x16B24A0 Offset: 0x16B25A1 VA: 0x16B24A0
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) { }

	// RVA: 0x16A1270 Offset: 0x16A1371 VA: 0x16A1270
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) { }

	// RVA: 0x16B2540 Offset: 0x16B2641 VA: 0x16B2540
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) { }

	// RVA: 0x16A1170 Offset: 0x16A1271 VA: 0x16A1170
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16A0A50 Offset: 0x16A0B51 VA: 0x16A0A50
	internal static Exception IncorrectNumberOfLambdaArguments() { }

	// RVA: 0x16A0AC0 Offset: 0x16A0BC1 VA: 0x16A0AC0
	internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) { }

	// RVA: 0x16B25D0 Offset: 0x16B26D1 VA: 0x16B25D0
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) { }

	// RVA: 0x16A1070 Offset: 0x16A1171 VA: 0x16A1070
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B2660 Offset: 0x16B2761 VA: 0x16B2660
	internal static Exception ExpressionMustBeReadable(string paramName) { }

	// RVA: 0x16A1390 Offset: 0x16A1491 VA: 0x16A1390
	internal static Exception ExpressionMustBeReadable(string paramName, int index) { }

	// RVA: 0x16A00F0 Offset: 0x16A01F1 VA: 0x16A00F0
	internal static Exception InvalidArgumentValue(string paramName) { }

	// RVA: 0x16B26E0 Offset: 0x16B27E1 VA: 0x16B26E0
	internal static Exception InvalidNullValue(Type type, string paramName) { }

	// RVA: 0x16B2770 Offset: 0x16B2871 VA: 0x16B2770
	internal static Exception InvalidTypeException(object value, Type type, string paramName) { }

	// RVA: 0x16AEB30 Offset: 0x16AEC31 VA: 0x16AEB30
	private static string GetParamName(string paramName, int index) { }
}

internal static class Error // TypeDefIndex: 2263
{
	// Methods

	// RVA: 0x16AE680 Offset: 0x16AE781 VA: 0x16AE680
	internal static Exception ReducibleMustOverrideReduce() { }

	// RVA: 0x169CBE0 Offset: 0x169CCE1 VA: 0x169CBE0
	internal static Exception AmbiguousMatchInExpandoObject(object p0) { }

	// RVA: 0x169D320 Offset: 0x169D421 VA: 0x169D320
	internal static Exception SameKeyExistsInExpando(object key) { }

	// RVA: 0x169E040 Offset: 0x169E141 VA: 0x169E040
	internal static Exception KeyDoesNotExistInExpando(object p0) { }

	// RVA: 0x169F110 Offset: 0x169F211 VA: 0x169F110
	internal static Exception CollectionModifiedWhileEnumerating() { }

	// RVA: 0x169F570 Offset: 0x169F671 VA: 0x169F570
	internal static Exception CollectionReadOnly() { }

	// RVA: 0x16AE6F0 Offset: 0x16AE7F1 VA: 0x16AE6F0
	internal static Exception MustReduceToDifferent() { }

	// RVA: 0x16AE760 Offset: 0x16AE861 VA: 0x16AE760
	internal static Exception ReducedNotCompatible() { }

	// RVA: 0x16AE7D0 Offset: 0x16AE8D1 VA: 0x16AE7D0
	internal static Exception SetterHasNoParams(string paramName) { }

	// RVA: 0x16AE850 Offset: 0x16AE951 VA: 0x16AE850
	internal static Exception PropertyCannotHaveRefType(string paramName) { }

	// RVA: 0x16AE8D0 Offset: 0x16AE9D1 VA: 0x16AE8D0
	internal static Exception IndexesOfSetGetMustMatch(string paramName) { }

	// RVA: 0x16AE950 Offset: 0x16AEA51 VA: 0x16AE950
	internal static Exception AccessorsCannotHaveVarArgs(string paramName) { }

	// RVA: 0x16AE9D0 Offset: 0x16AEAD1 VA: 0x16AE9D0
	private static Exception AccessorsCannotHaveByRefArgs(string paramName) { }

	// RVA: 0x16AEA50 Offset: 0x16AEB51 VA: 0x16AEA50
	internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) { }

	// RVA: 0x16AEBC0 Offset: 0x16AECC1 VA: 0x16AEBC0
	internal static Exception BoundsCannotBeLessThanOne(string paramName) { }

	// RVA: 0x16A5500 Offset: 0x16A5601 VA: 0x16A5500
	internal static Exception TypeMustNotBeByRef(string paramName) { }

	// RVA: 0x16A5580 Offset: 0x16A5681 VA: 0x16A5580
	internal static Exception TypeMustNotBePointer(string paramName) { }

	// RVA: 0x16AEC40 Offset: 0x16AED41 VA: 0x16AEC40
	internal static Exception SetterMustBeVoid(string paramName) { }

	// RVA: 0x16AECC0 Offset: 0x16AEDC1 VA: 0x16AECC0
	internal static Exception PropertyTypeMustMatchGetter(string paramName) { }

	// RVA: 0x16AED40 Offset: 0x16AEE41 VA: 0x16AED40
	internal static Exception PropertyTypeMustMatchSetter(string paramName) { }

	// RVA: 0x16AEDC0 Offset: 0x16AEEC1 VA: 0x16AEDC0
	internal static Exception BothAccessorsMustBeStatic(string paramName) { }

	// RVA: 0x16AEE40 Offset: 0x16AEF41 VA: 0x16AEE40
	internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) { }

	// RVA: 0x16AEEC0 Offset: 0x16AEFC1 VA: 0x16AEEC0
	internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) { }

	// RVA: 0x16AEF40 Offset: 0x16AF041 VA: 0x16AEF40
	internal static Exception OnlyStaticMethodsHaveNullInstance() { }

	// RVA: 0x16AEFB0 Offset: 0x16AF0B1 VA: 0x16AEFB0
	internal static Exception PropertyTypeCannotBeVoid(string paramName) { }

	// RVA: 0x16AF030 Offset: 0x16AF131 VA: 0x16AF030
	internal static Exception InvalidUnboxType(string paramName) { }

	// RVA: 0x16AF0B0 Offset: 0x16AF1B1 VA: 0x16AF0B0
	internal static Exception ExpressionMustBeWriteable(string paramName) { }

	// RVA: 0x16AF130 Offset: 0x16AF231 VA: 0x16AF130
	internal static Exception ArgumentMustNotHaveValueType(string paramName) { }

	// RVA: 0x16AF1B0 Offset: 0x16AF2B1 VA: 0x16AF1B0
	internal static Exception MustBeReducible() { }

	// RVA: 0x16AF220 Offset: 0x16AF321 VA: 0x16AF220
	internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) { }

	// RVA: 0x16AF2A0 Offset: 0x16AF3A1 VA: 0x16AF2A0
	internal static Exception QuotedExpressionMustBeLambda(string paramName) { }

	// RVA: 0x16AF320 Offset: 0x16AF421 VA: 0x16AF320
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) { }

	// RVA: 0x16AF3B0 Offset: 0x16AF4B1 VA: 0x16AF3B0
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16AF4B0 Offset: 0x16AF5B1 VA: 0x16AF4B0
	private static Exception DuplicateVariable(object p0, string paramName) { }

	// RVA: 0x16AF540 Offset: 0x16AF641 VA: 0x16AF540
	internal static Exception DuplicateVariable(object p0, string paramName, int index) { }

	// RVA: 0x16AF630 Offset: 0x16AF731 VA: 0x16AF630
	internal static Exception FaultCannotHaveCatchOrFinally(string paramName) { }

	// RVA: 0x16AF6B0 Offset: 0x16AF7B1 VA: 0x16AF6B0
	internal static Exception TryMustHaveCatchFinallyOrFault() { }

	// RVA: 0x16AF720 Offset: 0x16AF821 VA: 0x16AF720
	internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	// RVA: 0x16AF790 Offset: 0x16AF891 VA: 0x16AF790
	internal static Exception ExtensionNodeMustOverrideProperty(object p0) { }

	// RVA: 0x16AF810 Offset: 0x16AF911 VA: 0x16AF810
	internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) { }

	// RVA: 0x16AF8A0 Offset: 0x16AF9A1 VA: 0x16AF8A0
	internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) { }

	// RVA: 0x16AF930 Offset: 0x16AFA31 VA: 0x16AF930
	internal static Exception CoercionOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x16AF9C0 Offset: 0x16AFAC1 VA: 0x16AF9C0
	internal static Exception UnaryOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x16AFA50 Offset: 0x16AFB51 VA: 0x16AFA50
	internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	// RVA: 0x16AFAE0 Offset: 0x16AFBE1 VA: 0x16AFAE0
	internal static Exception ReferenceEqualityNotDefined(object p0, object p1) { }

	// RVA: 0x16AFB70 Offset: 0x16AFC71 VA: 0x16AFB70
	internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) { }

	// RVA: 0x16AFC00 Offset: 0x16AFD01 VA: 0x16AFC00
	internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	// RVA: 0x16AFC90 Offset: 0x16AFD91 VA: 0x16AFC90
	internal static Exception ConversionIsNotSupportedForArithmeticTypes() { }

	// RVA: 0x16AFD00 Offset: 0x16AFE01 VA: 0x16AFD00
	internal static Exception ArgumentMustBeArray(string paramName) { }

	// RVA: 0x16AFD80 Offset: 0x16AFE81 VA: 0x16AFD80
	internal static Exception ArgumentMustBeBoolean(string paramName) { }

	// RVA: 0x16AFE00 Offset: 0x16AFF01 VA: 0x16AFE00
	private static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName) { }

	// RVA: 0x16AFE80 Offset: 0x16AFF81 VA: 0x16AFE80
	internal static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName, int index) { }

	// RVA: 0x16AFF60 Offset: 0x16B0061 VA: 0x16AFF60
	private static Exception ArgumentMustBeInstanceMember(string paramName) { }

	// RVA: 0x16AFFE0 Offset: 0x16B00E1 VA: 0x16AFFE0
	internal static Exception ArgumentMustBeInstanceMember(string paramName, int index) { }

	// RVA: 0x16B00C0 Offset: 0x16B01C1 VA: 0x16B00C0
	private static Exception ArgumentMustBeInteger(string paramName) { }

	// RVA: 0x16B0140 Offset: 0x16B0241 VA: 0x16B0140
	internal static Exception ArgumentMustBeInteger(string paramName, int index) { }

	// RVA: 0x16B0220 Offset: 0x16B0321 VA: 0x16B0220
	internal static Exception ArgumentMustBeArrayIndexType(string paramName) { }

	// RVA: 0x16B02A0 Offset: 0x16B03A1 VA: 0x16B02A0
	internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) { }

	// RVA: 0x16B0320 Offset: 0x16B0421 VA: 0x16B0320
	internal static Exception ArgumentTypesMustMatch() { }

	// RVA: 0x16B0390 Offset: 0x16B0491 VA: 0x16B0390
	internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	// RVA: 0x16B0410 Offset: 0x16B0511 VA: 0x16B0410
	internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) { }

	// RVA: 0x16B04A0 Offset: 0x16B05A1 VA: 0x16B04A0
	internal static Exception CoalesceUsedOnNonNullType() { }

	// RVA: 0x16B0510 Offset: 0x16B0611 VA: 0x16B0510
	internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	// RVA: 0x16B05A0 Offset: 0x16B06A1 VA: 0x16B05A0
	private static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName) { }

	// RVA: 0x16B0630 Offset: 0x16B0731 VA: 0x16B0630
	internal static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B0730 Offset: 0x16B0831 VA: 0x16B0730
	private static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName) { }

	// RVA: 0x16B07C0 Offset: 0x16B08C1 VA: 0x16B07C0
	internal static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B08C0 Offset: 0x16B09C1 VA: 0x16B08C0
	internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	// RVA: 0x16B0950 Offset: 0x16B0A51 VA: 0x16B0950
	internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	// RVA: 0x16B09E0 Offset: 0x16B0AE1 VA: 0x16B09E0
	internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	// RVA: 0x16B0A70 Offset: 0x16B0B71 VA: 0x16B0A70
	internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) { }

	// RVA: 0x16B0B00 Offset: 0x16B0C01 VA: 0x16B0B00
	internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x16B0B90 Offset: 0x16B0C91 VA: 0x16B0B90
	internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	// RVA: 0x16B0C20 Offset: 0x16B0D21 VA: 0x16B0C20
	internal static Exception IncorrectNumberOfIndexes() { }

	// RVA: 0x16B0C90 Offset: 0x16B0D91 VA: 0x16B0C90
	internal static Exception IncorrectNumberOfLambdaDeclarationParameters() { }

	// RVA: 0x16B0D00 Offset: 0x16B0E01 VA: 0x16B0D00
	internal static Exception IncorrectNumberOfMembersForGivenConstructor() { }

	// RVA: 0x16B0D70 Offset: 0x16B0E71 VA: 0x16B0D70
	internal static Exception IncorrectNumberOfArgumentsForMembers() { }

	// RVA: 0x16B0DE0 Offset: 0x16B0EE1 VA: 0x16B0DE0
	internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) { }

	// RVA: 0x16B0E60 Offset: 0x16B0F61 VA: 0x16B0E60
	internal static Exception MemberNotFieldOrProperty(object p0, string paramName) { }

	// RVA: 0x16B0EF0 Offset: 0x16B0FF1 VA: 0x16B0EF0
	internal static Exception MethodContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x16B0F80 Offset: 0x16B1081 VA: 0x16B0F80
	internal static Exception MethodIsGeneric(object p0, string paramName) { }

	// RVA: 0x16B1010 Offset: 0x16B1111 VA: 0x16B1010
	private static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName) { }

	// RVA: 0x16B10A0 Offset: 0x16B11A1 VA: 0x16B10A0
	internal static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B11A0 Offset: 0x16B12A1 VA: 0x16B11A0
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName) { }

	// RVA: 0x16B1230 Offset: 0x16B1331 VA: 0x16B1230
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName, int index) { }

	// RVA: 0x16B1320 Offset: 0x16B1421 VA: 0x16B1320
	internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) { }

	// RVA: 0x16B13B0 Offset: 0x16B14B1 VA: 0x16B13B0
	internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	// RVA: 0x16B1440 Offset: 0x16B1541 VA: 0x16B1440
	internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x16B14D0 Offset: 0x16B15D1 VA: 0x16B14D0
	internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x16B1560 Offset: 0x16B1661 VA: 0x16B1560
	internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	// RVA: 0x16B15F0 Offset: 0x16B16F1 VA: 0x16B15F0
	internal static Exception UnhandledBinary(object p0, string paramName) { }

	// RVA: 0x16B1680 Offset: 0x16B1781 VA: 0x16B1680
	internal static Exception UnhandledUnary(object p0, string paramName) { }

	// RVA: 0x16B1710 Offset: 0x16B1811 VA: 0x16B1710
	internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	// RVA: 0x16B17A0 Offset: 0x16B18A1 VA: 0x16B17A0
	internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	// RVA: 0x16B1830 Offset: 0x16B1931 VA: 0x16B1830
	internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	// RVA: 0x16B18C0 Offset: 0x16B19C1 VA: 0x16B18C0
	internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x16B1950 Offset: 0x16B1A51 VA: 0x16B1950
	internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x16B19E0 Offset: 0x16B1AE1 VA: 0x16B19E0
	internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x16B1A70 Offset: 0x16B1B71 VA: 0x16B1A70
	internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) { }

	// RVA: 0x16B1AF0 Offset: 0x16B1BF1 VA: 0x16B1AF0
	internal static Exception LabelTargetAlreadyDefined(object p0) { }

	// RVA: 0x16B1B70 Offset: 0x16B1C71 VA: 0x16B1B70
	internal static Exception LabelTargetUndefined(object p0) { }

	// RVA: 0x16B1BF0 Offset: 0x16B1CF1 VA: 0x16B1BF0
	internal static Exception ControlCannotLeaveFinally() { }

	// RVA: 0x16B1C60 Offset: 0x16B1D61 VA: 0x16B1C60
	internal static Exception ControlCannotLeaveFilterTest() { }

	// RVA: 0x16B1CD0 Offset: 0x16B1DD1 VA: 0x16B1CD0
	internal static Exception AmbiguousJump(object p0) { }

	// RVA: 0x16B1D50 Offset: 0x16B1E51 VA: 0x16B1D50
	internal static Exception ControlCannotEnterTry() { }

	// RVA: 0x16B1DC0 Offset: 0x16B1EC1 VA: 0x16B1DC0
	internal static Exception ControlCannotEnterExpression() { }

	// RVA: 0x16B1E30 Offset: 0x16B1F31 VA: 0x16B1E30
	internal static Exception NonLocalJumpWithValue(object p0) { }

	// RVA: 0x16B1EB0 Offset: 0x16B1FB1 VA: 0x16B1EB0
	internal static Exception InvalidLvalue(ExpressionType p0) { }

	// RVA: 0x16B1F40 Offset: 0x16B2041 VA: 0x16B1F40
	internal static Exception RethrowRequiresCatch() { }

	// RVA: 0x16B1FB0 Offset: 0x16B20B1 VA: 0x16B1FB0
	internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) { }

	// RVA: 0x16B2040 Offset: 0x16B2141 VA: 0x16B2040
	internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) { }

	// RVA: 0x16B20D0 Offset: 0x16B21D1 VA: 0x16B20D0
	internal static Exception MustRewriteWithoutMethod(object p0, object p1) { }

	// RVA: 0x16AB6A0 Offset: 0x16AB7A1 VA: 0x16AB6A0
	internal static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x16B2160 Offset: 0x16B2261 VA: 0x16B2160
	internal static Exception NotSupported() { }

	// RVA: 0x16B21C0 Offset: 0x16B22C1 VA: 0x16B21C0
	internal static Exception NonStaticConstructorRequired(string paramName) { }

	// RVA: 0x16B2240 Offset: 0x16B2341 VA: 0x16B2240
	internal static Exception NonAbstractConstructorRequired() { }

	// RVA: 0x16B22B0 Offset: 0x16B23B1 VA: 0x16B22B0
	internal static Exception InvalidProgram() { }

	// RVA: 0x16B2310 Offset: 0x16B2411 VA: 0x16B2310
	internal static Exception EnumerationIsDone() { }

	// RVA: 0x16B2380 Offset: 0x16B2481 VA: 0x16B2380
	private static Exception TypeContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x16A5600 Offset: 0x16A5701 VA: 0x16A5600
	internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) { }

	// RVA: 0x16B2410 Offset: 0x16B2511 VA: 0x16B2410
	internal static Exception TypeIsGeneric(object p0, string paramName) { }

	// RVA: 0x16A56F0 Offset: 0x16A57F1 VA: 0x16A56F0
	internal static Exception TypeIsGeneric(object p0, string paramName, int index) { }

	// RVA: 0x16A09E0 Offset: 0x16A0AE1 VA: 0x16A09E0
	internal static Exception IncorrectNumberOfConstructorArguments() { }

	// RVA: 0x16B24A0 Offset: 0x16B25A1 VA: 0x16B24A0
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) { }

	// RVA: 0x16A1270 Offset: 0x16A1371 VA: 0x16A1270
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) { }

	// RVA: 0x16B2540 Offset: 0x16B2641 VA: 0x16B2540
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) { }

	// RVA: 0x16A1170 Offset: 0x16A1271 VA: 0x16A1170
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16A0A50 Offset: 0x16A0B51 VA: 0x16A0A50
	internal static Exception IncorrectNumberOfLambdaArguments() { }

	// RVA: 0x16A0AC0 Offset: 0x16A0BC1 VA: 0x16A0AC0
	internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) { }

	// RVA: 0x16B25D0 Offset: 0x16B26D1 VA: 0x16B25D0
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) { }

	// RVA: 0x16A1070 Offset: 0x16A1171 VA: 0x16A1070
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B2660 Offset: 0x16B2761 VA: 0x16B2660
	internal static Exception ExpressionMustBeReadable(string paramName) { }

	// RVA: 0x16A1390 Offset: 0x16A1491 VA: 0x16A1390
	internal static Exception ExpressionMustBeReadable(string paramName, int index) { }

	// RVA: 0x16A00F0 Offset: 0x16A01F1 VA: 0x16A00F0
	internal static Exception InvalidArgumentValue(string paramName) { }

	// RVA: 0x16B26E0 Offset: 0x16B27E1 VA: 0x16B26E0
	internal static Exception InvalidNullValue(Type type, string paramName) { }

	// RVA: 0x16B2770 Offset: 0x16B2871 VA: 0x16B2770
	internal static Exception InvalidTypeException(object value, Type type, string paramName) { }

	// RVA: 0x16AEB30 Offset: 0x16AEC31 VA: 0x16AEB30
	private static string GetParamName(string paramName, int index) { }
}

internal static class Error // TypeDefIndex: 2263
{
	// Methods

	// RVA: 0x16AE680 Offset: 0x16AE781 VA: 0x16AE680
	internal static Exception ReducibleMustOverrideReduce() { }

	// RVA: 0x169CBE0 Offset: 0x169CCE1 VA: 0x169CBE0
	internal static Exception AmbiguousMatchInExpandoObject(object p0) { }

	// RVA: 0x169D320 Offset: 0x169D421 VA: 0x169D320
	internal static Exception SameKeyExistsInExpando(object key) { }

	// RVA: 0x169E040 Offset: 0x169E141 VA: 0x169E040
	internal static Exception KeyDoesNotExistInExpando(object p0) { }

	// RVA: 0x169F110 Offset: 0x169F211 VA: 0x169F110
	internal static Exception CollectionModifiedWhileEnumerating() { }

	// RVA: 0x169F570 Offset: 0x169F671 VA: 0x169F570
	internal static Exception CollectionReadOnly() { }

	// RVA: 0x16AE6F0 Offset: 0x16AE7F1 VA: 0x16AE6F0
	internal static Exception MustReduceToDifferent() { }

	// RVA: 0x16AE760 Offset: 0x16AE861 VA: 0x16AE760
	internal static Exception ReducedNotCompatible() { }

	// RVA: 0x16AE7D0 Offset: 0x16AE8D1 VA: 0x16AE7D0
	internal static Exception SetterHasNoParams(string paramName) { }

	// RVA: 0x16AE850 Offset: 0x16AE951 VA: 0x16AE850
	internal static Exception PropertyCannotHaveRefType(string paramName) { }

	// RVA: 0x16AE8D0 Offset: 0x16AE9D1 VA: 0x16AE8D0
	internal static Exception IndexesOfSetGetMustMatch(string paramName) { }

	// RVA: 0x16AE950 Offset: 0x16AEA51 VA: 0x16AE950
	internal static Exception AccessorsCannotHaveVarArgs(string paramName) { }

	// RVA: 0x16AE9D0 Offset: 0x16AEAD1 VA: 0x16AE9D0
	private static Exception AccessorsCannotHaveByRefArgs(string paramName) { }

	// RVA: 0x16AEA50 Offset: 0x16AEB51 VA: 0x16AEA50
	internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) { }

	// RVA: 0x16AEBC0 Offset: 0x16AECC1 VA: 0x16AEBC0
	internal static Exception BoundsCannotBeLessThanOne(string paramName) { }

	// RVA: 0x16A5500 Offset: 0x16A5601 VA: 0x16A5500
	internal static Exception TypeMustNotBeByRef(string paramName) { }

	// RVA: 0x16A5580 Offset: 0x16A5681 VA: 0x16A5580
	internal static Exception TypeMustNotBePointer(string paramName) { }

	// RVA: 0x16AEC40 Offset: 0x16AED41 VA: 0x16AEC40
	internal static Exception SetterMustBeVoid(string paramName) { }

	// RVA: 0x16AECC0 Offset: 0x16AEDC1 VA: 0x16AECC0
	internal static Exception PropertyTypeMustMatchGetter(string paramName) { }

	// RVA: 0x16AED40 Offset: 0x16AEE41 VA: 0x16AED40
	internal static Exception PropertyTypeMustMatchSetter(string paramName) { }

	// RVA: 0x16AEDC0 Offset: 0x16AEEC1 VA: 0x16AEDC0
	internal static Exception BothAccessorsMustBeStatic(string paramName) { }

	// RVA: 0x16AEE40 Offset: 0x16AEF41 VA: 0x16AEE40
	internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) { }

	// RVA: 0x16AEEC0 Offset: 0x16AEFC1 VA: 0x16AEEC0
	internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) { }

	// RVA: 0x16AEF40 Offset: 0x16AF041 VA: 0x16AEF40
	internal static Exception OnlyStaticMethodsHaveNullInstance() { }

	// RVA: 0x16AEFB0 Offset: 0x16AF0B1 VA: 0x16AEFB0
	internal static Exception PropertyTypeCannotBeVoid(string paramName) { }

	// RVA: 0x16AF030 Offset: 0x16AF131 VA: 0x16AF030
	internal static Exception InvalidUnboxType(string paramName) { }

	// RVA: 0x16AF0B0 Offset: 0x16AF1B1 VA: 0x16AF0B0
	internal static Exception ExpressionMustBeWriteable(string paramName) { }

	// RVA: 0x16AF130 Offset: 0x16AF231 VA: 0x16AF130
	internal static Exception ArgumentMustNotHaveValueType(string paramName) { }

	// RVA: 0x16AF1B0 Offset: 0x16AF2B1 VA: 0x16AF1B0
	internal static Exception MustBeReducible() { }

	// RVA: 0x16AF220 Offset: 0x16AF321 VA: 0x16AF220
	internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) { }

	// RVA: 0x16AF2A0 Offset: 0x16AF3A1 VA: 0x16AF2A0
	internal static Exception QuotedExpressionMustBeLambda(string paramName) { }

	// RVA: 0x16AF320 Offset: 0x16AF421 VA: 0x16AF320
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) { }

	// RVA: 0x16AF3B0 Offset: 0x16AF4B1 VA: 0x16AF3B0
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16AF4B0 Offset: 0x16AF5B1 VA: 0x16AF4B0
	private static Exception DuplicateVariable(object p0, string paramName) { }

	// RVA: 0x16AF540 Offset: 0x16AF641 VA: 0x16AF540
	internal static Exception DuplicateVariable(object p0, string paramName, int index) { }

	// RVA: 0x16AF630 Offset: 0x16AF731 VA: 0x16AF630
	internal static Exception FaultCannotHaveCatchOrFinally(string paramName) { }

	// RVA: 0x16AF6B0 Offset: 0x16AF7B1 VA: 0x16AF6B0
	internal static Exception TryMustHaveCatchFinallyOrFault() { }

	// RVA: 0x16AF720 Offset: 0x16AF821 VA: 0x16AF720
	internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	// RVA: 0x16AF790 Offset: 0x16AF891 VA: 0x16AF790
	internal static Exception ExtensionNodeMustOverrideProperty(object p0) { }

	// RVA: 0x16AF810 Offset: 0x16AF911 VA: 0x16AF810
	internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) { }

	// RVA: 0x16AF8A0 Offset: 0x16AF9A1 VA: 0x16AF8A0
	internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) { }

	// RVA: 0x16AF930 Offset: 0x16AFA31 VA: 0x16AF930
	internal static Exception CoercionOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x16AF9C0 Offset: 0x16AFAC1 VA: 0x16AF9C0
	internal static Exception UnaryOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x16AFA50 Offset: 0x16AFB51 VA: 0x16AFA50
	internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	// RVA: 0x16AFAE0 Offset: 0x16AFBE1 VA: 0x16AFAE0
	internal static Exception ReferenceEqualityNotDefined(object p0, object p1) { }

	// RVA: 0x16AFB70 Offset: 0x16AFC71 VA: 0x16AFB70
	internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) { }

	// RVA: 0x16AFC00 Offset: 0x16AFD01 VA: 0x16AFC00
	internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	// RVA: 0x16AFC90 Offset: 0x16AFD91 VA: 0x16AFC90
	internal static Exception ConversionIsNotSupportedForArithmeticTypes() { }

	// RVA: 0x16AFD00 Offset: 0x16AFE01 VA: 0x16AFD00
	internal static Exception ArgumentMustBeArray(string paramName) { }

	// RVA: 0x16AFD80 Offset: 0x16AFE81 VA: 0x16AFD80
	internal static Exception ArgumentMustBeBoolean(string paramName) { }

	// RVA: 0x16AFE00 Offset: 0x16AFF01 VA: 0x16AFE00
	private static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName) { }

	// RVA: 0x16AFE80 Offset: 0x16AFF81 VA: 0x16AFE80
	internal static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName, int index) { }

	// RVA: 0x16AFF60 Offset: 0x16B0061 VA: 0x16AFF60
	private static Exception ArgumentMustBeInstanceMember(string paramName) { }

	// RVA: 0x16AFFE0 Offset: 0x16B00E1 VA: 0x16AFFE0
	internal static Exception ArgumentMustBeInstanceMember(string paramName, int index) { }

	// RVA: 0x16B00C0 Offset: 0x16B01C1 VA: 0x16B00C0
	private static Exception ArgumentMustBeInteger(string paramName) { }

	// RVA: 0x16B0140 Offset: 0x16B0241 VA: 0x16B0140
	internal static Exception ArgumentMustBeInteger(string paramName, int index) { }

	// RVA: 0x16B0220 Offset: 0x16B0321 VA: 0x16B0220
	internal static Exception ArgumentMustBeArrayIndexType(string paramName) { }

	// RVA: 0x16B02A0 Offset: 0x16B03A1 VA: 0x16B02A0
	internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) { }

	// RVA: 0x16B0320 Offset: 0x16B0421 VA: 0x16B0320
	internal static Exception ArgumentTypesMustMatch() { }

	// RVA: 0x16B0390 Offset: 0x16B0491 VA: 0x16B0390
	internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	// RVA: 0x16B0410 Offset: 0x16B0511 VA: 0x16B0410
	internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) { }

	// RVA: 0x16B04A0 Offset: 0x16B05A1 VA: 0x16B04A0
	internal static Exception CoalesceUsedOnNonNullType() { }

	// RVA: 0x16B0510 Offset: 0x16B0611 VA: 0x16B0510
	internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	// RVA: 0x16B05A0 Offset: 0x16B06A1 VA: 0x16B05A0
	private static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName) { }

	// RVA: 0x16B0630 Offset: 0x16B0731 VA: 0x16B0630
	internal static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B0730 Offset: 0x16B0831 VA: 0x16B0730
	private static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName) { }

	// RVA: 0x16B07C0 Offset: 0x16B08C1 VA: 0x16B07C0
	internal static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B08C0 Offset: 0x16B09C1 VA: 0x16B08C0
	internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	// RVA: 0x16B0950 Offset: 0x16B0A51 VA: 0x16B0950
	internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	// RVA: 0x16B09E0 Offset: 0x16B0AE1 VA: 0x16B09E0
	internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	// RVA: 0x16B0A70 Offset: 0x16B0B71 VA: 0x16B0A70
	internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) { }

	// RVA: 0x16B0B00 Offset: 0x16B0C01 VA: 0x16B0B00
	internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x16B0B90 Offset: 0x16B0C91 VA: 0x16B0B90
	internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	// RVA: 0x16B0C20 Offset: 0x16B0D21 VA: 0x16B0C20
	internal static Exception IncorrectNumberOfIndexes() { }

	// RVA: 0x16B0C90 Offset: 0x16B0D91 VA: 0x16B0C90
	internal static Exception IncorrectNumberOfLambdaDeclarationParameters() { }

	// RVA: 0x16B0D00 Offset: 0x16B0E01 VA: 0x16B0D00
	internal static Exception IncorrectNumberOfMembersForGivenConstructor() { }

	// RVA: 0x16B0D70 Offset: 0x16B0E71 VA: 0x16B0D70
	internal static Exception IncorrectNumberOfArgumentsForMembers() { }

	// RVA: 0x16B0DE0 Offset: 0x16B0EE1 VA: 0x16B0DE0
	internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) { }

	// RVA: 0x16B0E60 Offset: 0x16B0F61 VA: 0x16B0E60
	internal static Exception MemberNotFieldOrProperty(object p0, string paramName) { }

	// RVA: 0x16B0EF0 Offset: 0x16B0FF1 VA: 0x16B0EF0
	internal static Exception MethodContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x16B0F80 Offset: 0x16B1081 VA: 0x16B0F80
	internal static Exception MethodIsGeneric(object p0, string paramName) { }

	// RVA: 0x16B1010 Offset: 0x16B1111 VA: 0x16B1010
	private static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName) { }

	// RVA: 0x16B10A0 Offset: 0x16B11A1 VA: 0x16B10A0
	internal static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B11A0 Offset: 0x16B12A1 VA: 0x16B11A0
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName) { }

	// RVA: 0x16B1230 Offset: 0x16B1331 VA: 0x16B1230
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName, int index) { }

	// RVA: 0x16B1320 Offset: 0x16B1421 VA: 0x16B1320
	internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) { }

	// RVA: 0x16B13B0 Offset: 0x16B14B1 VA: 0x16B13B0
	internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	// RVA: 0x16B1440 Offset: 0x16B1541 VA: 0x16B1440
	internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x16B14D0 Offset: 0x16B15D1 VA: 0x16B14D0
	internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x16B1560 Offset: 0x16B1661 VA: 0x16B1560
	internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	// RVA: 0x16B15F0 Offset: 0x16B16F1 VA: 0x16B15F0
	internal static Exception UnhandledBinary(object p0, string paramName) { }

	// RVA: 0x16B1680 Offset: 0x16B1781 VA: 0x16B1680
	internal static Exception UnhandledUnary(object p0, string paramName) { }

	// RVA: 0x16B1710 Offset: 0x16B1811 VA: 0x16B1710
	internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	// RVA: 0x16B17A0 Offset: 0x16B18A1 VA: 0x16B17A0
	internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	// RVA: 0x16B1830 Offset: 0x16B1931 VA: 0x16B1830
	internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	// RVA: 0x16B18C0 Offset: 0x16B19C1 VA: 0x16B18C0
	internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x16B1950 Offset: 0x16B1A51 VA: 0x16B1950
	internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x16B19E0 Offset: 0x16B1AE1 VA: 0x16B19E0
	internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x16B1A70 Offset: 0x16B1B71 VA: 0x16B1A70
	internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) { }

	// RVA: 0x16B1AF0 Offset: 0x16B1BF1 VA: 0x16B1AF0
	internal static Exception LabelTargetAlreadyDefined(object p0) { }

	// RVA: 0x16B1B70 Offset: 0x16B1C71 VA: 0x16B1B70
	internal static Exception LabelTargetUndefined(object p0) { }

	// RVA: 0x16B1BF0 Offset: 0x16B1CF1 VA: 0x16B1BF0
	internal static Exception ControlCannotLeaveFinally() { }

	// RVA: 0x16B1C60 Offset: 0x16B1D61 VA: 0x16B1C60
	internal static Exception ControlCannotLeaveFilterTest() { }

	// RVA: 0x16B1CD0 Offset: 0x16B1DD1 VA: 0x16B1CD0
	internal static Exception AmbiguousJump(object p0) { }

	// RVA: 0x16B1D50 Offset: 0x16B1E51 VA: 0x16B1D50
	internal static Exception ControlCannotEnterTry() { }

	// RVA: 0x16B1DC0 Offset: 0x16B1EC1 VA: 0x16B1DC0
	internal static Exception ControlCannotEnterExpression() { }

	// RVA: 0x16B1E30 Offset: 0x16B1F31 VA: 0x16B1E30
	internal static Exception NonLocalJumpWithValue(object p0) { }

	// RVA: 0x16B1EB0 Offset: 0x16B1FB1 VA: 0x16B1EB0
	internal static Exception InvalidLvalue(ExpressionType p0) { }

	// RVA: 0x16B1F40 Offset: 0x16B2041 VA: 0x16B1F40
	internal static Exception RethrowRequiresCatch() { }

	// RVA: 0x16B1FB0 Offset: 0x16B20B1 VA: 0x16B1FB0
	internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) { }

	// RVA: 0x16B2040 Offset: 0x16B2141 VA: 0x16B2040
	internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) { }

	// RVA: 0x16B20D0 Offset: 0x16B21D1 VA: 0x16B20D0
	internal static Exception MustRewriteWithoutMethod(object p0, object p1) { }

	// RVA: 0x16AB6A0 Offset: 0x16AB7A1 VA: 0x16AB6A0
	internal static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x16B2160 Offset: 0x16B2261 VA: 0x16B2160
	internal static Exception NotSupported() { }

	// RVA: 0x16B21C0 Offset: 0x16B22C1 VA: 0x16B21C0
	internal static Exception NonStaticConstructorRequired(string paramName) { }

	// RVA: 0x16B2240 Offset: 0x16B2341 VA: 0x16B2240
	internal static Exception NonAbstractConstructorRequired() { }

	// RVA: 0x16B22B0 Offset: 0x16B23B1 VA: 0x16B22B0
	internal static Exception InvalidProgram() { }

	// RVA: 0x16B2310 Offset: 0x16B2411 VA: 0x16B2310
	internal static Exception EnumerationIsDone() { }

	// RVA: 0x16B2380 Offset: 0x16B2481 VA: 0x16B2380
	private static Exception TypeContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x16A5600 Offset: 0x16A5701 VA: 0x16A5600
	internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) { }

	// RVA: 0x16B2410 Offset: 0x16B2511 VA: 0x16B2410
	internal static Exception TypeIsGeneric(object p0, string paramName) { }

	// RVA: 0x16A56F0 Offset: 0x16A57F1 VA: 0x16A56F0
	internal static Exception TypeIsGeneric(object p0, string paramName, int index) { }

	// RVA: 0x16A09E0 Offset: 0x16A0AE1 VA: 0x16A09E0
	internal static Exception IncorrectNumberOfConstructorArguments() { }

	// RVA: 0x16B24A0 Offset: 0x16B25A1 VA: 0x16B24A0
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) { }

	// RVA: 0x16A1270 Offset: 0x16A1371 VA: 0x16A1270
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) { }

	// RVA: 0x16B2540 Offset: 0x16B2641 VA: 0x16B2540
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) { }

	// RVA: 0x16A1170 Offset: 0x16A1271 VA: 0x16A1170
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16A0A50 Offset: 0x16A0B51 VA: 0x16A0A50
	internal static Exception IncorrectNumberOfLambdaArguments() { }

	// RVA: 0x16A0AC0 Offset: 0x16A0BC1 VA: 0x16A0AC0
	internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) { }

	// RVA: 0x16B25D0 Offset: 0x16B26D1 VA: 0x16B25D0
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) { }

	// RVA: 0x16A1070 Offset: 0x16A1171 VA: 0x16A1070
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B2660 Offset: 0x16B2761 VA: 0x16B2660
	internal static Exception ExpressionMustBeReadable(string paramName) { }

	// RVA: 0x16A1390 Offset: 0x16A1491 VA: 0x16A1390
	internal static Exception ExpressionMustBeReadable(string paramName, int index) { }

	// RVA: 0x16A00F0 Offset: 0x16A01F1 VA: 0x16A00F0
	internal static Exception InvalidArgumentValue(string paramName) { }

	// RVA: 0x16B26E0 Offset: 0x16B27E1 VA: 0x16B26E0
	internal static Exception InvalidNullValue(Type type, string paramName) { }

	// RVA: 0x16B2770 Offset: 0x16B2871 VA: 0x16B2770
	internal static Exception InvalidTypeException(object value, Type type, string paramName) { }

	// RVA: 0x16AEB30 Offset: 0x16AEC31 VA: 0x16AEB30
	private static string GetParamName(string paramName, int index) { }
}

internal static class Error // TypeDefIndex: 2263
{
	// Methods

	// RVA: 0x16AE680 Offset: 0x16AE781 VA: 0x16AE680
	internal static Exception ReducibleMustOverrideReduce() { }

	// RVA: 0x169CBE0 Offset: 0x169CCE1 VA: 0x169CBE0
	internal static Exception AmbiguousMatchInExpandoObject(object p0) { }

	// RVA: 0x169D320 Offset: 0x169D421 VA: 0x169D320
	internal static Exception SameKeyExistsInExpando(object key) { }

	// RVA: 0x169E040 Offset: 0x169E141 VA: 0x169E040
	internal static Exception KeyDoesNotExistInExpando(object p0) { }

	// RVA: 0x169F110 Offset: 0x169F211 VA: 0x169F110
	internal static Exception CollectionModifiedWhileEnumerating() { }

	// RVA: 0x169F570 Offset: 0x169F671 VA: 0x169F570
	internal static Exception CollectionReadOnly() { }

	// RVA: 0x16AE6F0 Offset: 0x16AE7F1 VA: 0x16AE6F0
	internal static Exception MustReduceToDifferent() { }

	// RVA: 0x16AE760 Offset: 0x16AE861 VA: 0x16AE760
	internal static Exception ReducedNotCompatible() { }

	// RVA: 0x16AE7D0 Offset: 0x16AE8D1 VA: 0x16AE7D0
	internal static Exception SetterHasNoParams(string paramName) { }

	// RVA: 0x16AE850 Offset: 0x16AE951 VA: 0x16AE850
	internal static Exception PropertyCannotHaveRefType(string paramName) { }

	// RVA: 0x16AE8D0 Offset: 0x16AE9D1 VA: 0x16AE8D0
	internal static Exception IndexesOfSetGetMustMatch(string paramName) { }

	// RVA: 0x16AE950 Offset: 0x16AEA51 VA: 0x16AE950
	internal static Exception AccessorsCannotHaveVarArgs(string paramName) { }

	// RVA: 0x16AE9D0 Offset: 0x16AEAD1 VA: 0x16AE9D0
	private static Exception AccessorsCannotHaveByRefArgs(string paramName) { }

	// RVA: 0x16AEA50 Offset: 0x16AEB51 VA: 0x16AEA50
	internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) { }

	// RVA: 0x16AEBC0 Offset: 0x16AECC1 VA: 0x16AEBC0
	internal static Exception BoundsCannotBeLessThanOne(string paramName) { }

	// RVA: 0x16A5500 Offset: 0x16A5601 VA: 0x16A5500
	internal static Exception TypeMustNotBeByRef(string paramName) { }

	// RVA: 0x16A5580 Offset: 0x16A5681 VA: 0x16A5580
	internal static Exception TypeMustNotBePointer(string paramName) { }

	// RVA: 0x16AEC40 Offset: 0x16AED41 VA: 0x16AEC40
	internal static Exception SetterMustBeVoid(string paramName) { }

	// RVA: 0x16AECC0 Offset: 0x16AEDC1 VA: 0x16AECC0
	internal static Exception PropertyTypeMustMatchGetter(string paramName) { }

	// RVA: 0x16AED40 Offset: 0x16AEE41 VA: 0x16AED40
	internal static Exception PropertyTypeMustMatchSetter(string paramName) { }

	// RVA: 0x16AEDC0 Offset: 0x16AEEC1 VA: 0x16AEDC0
	internal static Exception BothAccessorsMustBeStatic(string paramName) { }

	// RVA: 0x16AEE40 Offset: 0x16AEF41 VA: 0x16AEE40
	internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) { }

	// RVA: 0x16AEEC0 Offset: 0x16AEFC1 VA: 0x16AEEC0
	internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) { }

	// RVA: 0x16AEF40 Offset: 0x16AF041 VA: 0x16AEF40
	internal static Exception OnlyStaticMethodsHaveNullInstance() { }

	// RVA: 0x16AEFB0 Offset: 0x16AF0B1 VA: 0x16AEFB0
	internal static Exception PropertyTypeCannotBeVoid(string paramName) { }

	// RVA: 0x16AF030 Offset: 0x16AF131 VA: 0x16AF030
	internal static Exception InvalidUnboxType(string paramName) { }

	// RVA: 0x16AF0B0 Offset: 0x16AF1B1 VA: 0x16AF0B0
	internal static Exception ExpressionMustBeWriteable(string paramName) { }

	// RVA: 0x16AF130 Offset: 0x16AF231 VA: 0x16AF130
	internal static Exception ArgumentMustNotHaveValueType(string paramName) { }

	// RVA: 0x16AF1B0 Offset: 0x16AF2B1 VA: 0x16AF1B0
	internal static Exception MustBeReducible() { }

	// RVA: 0x16AF220 Offset: 0x16AF321 VA: 0x16AF220
	internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) { }

	// RVA: 0x16AF2A0 Offset: 0x16AF3A1 VA: 0x16AF2A0
	internal static Exception QuotedExpressionMustBeLambda(string paramName) { }

	// RVA: 0x16AF320 Offset: 0x16AF421 VA: 0x16AF320
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) { }

	// RVA: 0x16AF3B0 Offset: 0x16AF4B1 VA: 0x16AF3B0
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16AF4B0 Offset: 0x16AF5B1 VA: 0x16AF4B0
	private static Exception DuplicateVariable(object p0, string paramName) { }

	// RVA: 0x16AF540 Offset: 0x16AF641 VA: 0x16AF540
	internal static Exception DuplicateVariable(object p0, string paramName, int index) { }

	// RVA: 0x16AF630 Offset: 0x16AF731 VA: 0x16AF630
	internal static Exception FaultCannotHaveCatchOrFinally(string paramName) { }

	// RVA: 0x16AF6B0 Offset: 0x16AF7B1 VA: 0x16AF6B0
	internal static Exception TryMustHaveCatchFinallyOrFault() { }

	// RVA: 0x16AF720 Offset: 0x16AF821 VA: 0x16AF720
	internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	// RVA: 0x16AF790 Offset: 0x16AF891 VA: 0x16AF790
	internal static Exception ExtensionNodeMustOverrideProperty(object p0) { }

	// RVA: 0x16AF810 Offset: 0x16AF911 VA: 0x16AF810
	internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) { }

	// RVA: 0x16AF8A0 Offset: 0x16AF9A1 VA: 0x16AF8A0
	internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) { }

	// RVA: 0x16AF930 Offset: 0x16AFA31 VA: 0x16AF930
	internal static Exception CoercionOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x16AF9C0 Offset: 0x16AFAC1 VA: 0x16AF9C0
	internal static Exception UnaryOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x16AFA50 Offset: 0x16AFB51 VA: 0x16AFA50
	internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	// RVA: 0x16AFAE0 Offset: 0x16AFBE1 VA: 0x16AFAE0
	internal static Exception ReferenceEqualityNotDefined(object p0, object p1) { }

	// RVA: 0x16AFB70 Offset: 0x16AFC71 VA: 0x16AFB70
	internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) { }

	// RVA: 0x16AFC00 Offset: 0x16AFD01 VA: 0x16AFC00
	internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	// RVA: 0x16AFC90 Offset: 0x16AFD91 VA: 0x16AFC90
	internal static Exception ConversionIsNotSupportedForArithmeticTypes() { }

	// RVA: 0x16AFD00 Offset: 0x16AFE01 VA: 0x16AFD00
	internal static Exception ArgumentMustBeArray(string paramName) { }

	// RVA: 0x16AFD80 Offset: 0x16AFE81 VA: 0x16AFD80
	internal static Exception ArgumentMustBeBoolean(string paramName) { }

	// RVA: 0x16AFE00 Offset: 0x16AFF01 VA: 0x16AFE00
	private static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName) { }

	// RVA: 0x16AFE80 Offset: 0x16AFF81 VA: 0x16AFE80
	internal static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName, int index) { }

	// RVA: 0x16AFF60 Offset: 0x16B0061 VA: 0x16AFF60
	private static Exception ArgumentMustBeInstanceMember(string paramName) { }

	// RVA: 0x16AFFE0 Offset: 0x16B00E1 VA: 0x16AFFE0
	internal static Exception ArgumentMustBeInstanceMember(string paramName, int index) { }

	// RVA: 0x16B00C0 Offset: 0x16B01C1 VA: 0x16B00C0
	private static Exception ArgumentMustBeInteger(string paramName) { }

	// RVA: 0x16B0140 Offset: 0x16B0241 VA: 0x16B0140
	internal static Exception ArgumentMustBeInteger(string paramName, int index) { }

	// RVA: 0x16B0220 Offset: 0x16B0321 VA: 0x16B0220
	internal static Exception ArgumentMustBeArrayIndexType(string paramName) { }

	// RVA: 0x16B02A0 Offset: 0x16B03A1 VA: 0x16B02A0
	internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) { }

	// RVA: 0x16B0320 Offset: 0x16B0421 VA: 0x16B0320
	internal static Exception ArgumentTypesMustMatch() { }

	// RVA: 0x16B0390 Offset: 0x16B0491 VA: 0x16B0390
	internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	// RVA: 0x16B0410 Offset: 0x16B0511 VA: 0x16B0410
	internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) { }

	// RVA: 0x16B04A0 Offset: 0x16B05A1 VA: 0x16B04A0
	internal static Exception CoalesceUsedOnNonNullType() { }

	// RVA: 0x16B0510 Offset: 0x16B0611 VA: 0x16B0510
	internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	// RVA: 0x16B05A0 Offset: 0x16B06A1 VA: 0x16B05A0
	private static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName) { }

	// RVA: 0x16B0630 Offset: 0x16B0731 VA: 0x16B0630
	internal static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B0730 Offset: 0x16B0831 VA: 0x16B0730
	private static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName) { }

	// RVA: 0x16B07C0 Offset: 0x16B08C1 VA: 0x16B07C0
	internal static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B08C0 Offset: 0x16B09C1 VA: 0x16B08C0
	internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	// RVA: 0x16B0950 Offset: 0x16B0A51 VA: 0x16B0950
	internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	// RVA: 0x16B09E0 Offset: 0x16B0AE1 VA: 0x16B09E0
	internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	// RVA: 0x16B0A70 Offset: 0x16B0B71 VA: 0x16B0A70
	internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) { }

	// RVA: 0x16B0B00 Offset: 0x16B0C01 VA: 0x16B0B00
	internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x16B0B90 Offset: 0x16B0C91 VA: 0x16B0B90
	internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	// RVA: 0x16B0C20 Offset: 0x16B0D21 VA: 0x16B0C20
	internal static Exception IncorrectNumberOfIndexes() { }

	// RVA: 0x16B0C90 Offset: 0x16B0D91 VA: 0x16B0C90
	internal static Exception IncorrectNumberOfLambdaDeclarationParameters() { }

	// RVA: 0x16B0D00 Offset: 0x16B0E01 VA: 0x16B0D00
	internal static Exception IncorrectNumberOfMembersForGivenConstructor() { }

	// RVA: 0x16B0D70 Offset: 0x16B0E71 VA: 0x16B0D70
	internal static Exception IncorrectNumberOfArgumentsForMembers() { }

	// RVA: 0x16B0DE0 Offset: 0x16B0EE1 VA: 0x16B0DE0
	internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) { }

	// RVA: 0x16B0E60 Offset: 0x16B0F61 VA: 0x16B0E60
	internal static Exception MemberNotFieldOrProperty(object p0, string paramName) { }

	// RVA: 0x16B0EF0 Offset: 0x16B0FF1 VA: 0x16B0EF0
	internal static Exception MethodContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x16B0F80 Offset: 0x16B1081 VA: 0x16B0F80
	internal static Exception MethodIsGeneric(object p0, string paramName) { }

	// RVA: 0x16B1010 Offset: 0x16B1111 VA: 0x16B1010
	private static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName) { }

	// RVA: 0x16B10A0 Offset: 0x16B11A1 VA: 0x16B10A0
	internal static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B11A0 Offset: 0x16B12A1 VA: 0x16B11A0
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName) { }

	// RVA: 0x16B1230 Offset: 0x16B1331 VA: 0x16B1230
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName, int index) { }

	// RVA: 0x16B1320 Offset: 0x16B1421 VA: 0x16B1320
	internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) { }

	// RVA: 0x16B13B0 Offset: 0x16B14B1 VA: 0x16B13B0
	internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	// RVA: 0x16B1440 Offset: 0x16B1541 VA: 0x16B1440
	internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x16B14D0 Offset: 0x16B15D1 VA: 0x16B14D0
	internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x16B1560 Offset: 0x16B1661 VA: 0x16B1560
	internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	// RVA: 0x16B15F0 Offset: 0x16B16F1 VA: 0x16B15F0
	internal static Exception UnhandledBinary(object p0, string paramName) { }

	// RVA: 0x16B1680 Offset: 0x16B1781 VA: 0x16B1680
	internal static Exception UnhandledUnary(object p0, string paramName) { }

	// RVA: 0x16B1710 Offset: 0x16B1811 VA: 0x16B1710
	internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	// RVA: 0x16B17A0 Offset: 0x16B18A1 VA: 0x16B17A0
	internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	// RVA: 0x16B1830 Offset: 0x16B1931 VA: 0x16B1830
	internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	// RVA: 0x16B18C0 Offset: 0x16B19C1 VA: 0x16B18C0
	internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x16B1950 Offset: 0x16B1A51 VA: 0x16B1950
	internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x16B19E0 Offset: 0x16B1AE1 VA: 0x16B19E0
	internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x16B1A70 Offset: 0x16B1B71 VA: 0x16B1A70
	internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) { }

	// RVA: 0x16B1AF0 Offset: 0x16B1BF1 VA: 0x16B1AF0
	internal static Exception LabelTargetAlreadyDefined(object p0) { }

	// RVA: 0x16B1B70 Offset: 0x16B1C71 VA: 0x16B1B70
	internal static Exception LabelTargetUndefined(object p0) { }

	// RVA: 0x16B1BF0 Offset: 0x16B1CF1 VA: 0x16B1BF0
	internal static Exception ControlCannotLeaveFinally() { }

	// RVA: 0x16B1C60 Offset: 0x16B1D61 VA: 0x16B1C60
	internal static Exception ControlCannotLeaveFilterTest() { }

	// RVA: 0x16B1CD0 Offset: 0x16B1DD1 VA: 0x16B1CD0
	internal static Exception AmbiguousJump(object p0) { }

	// RVA: 0x16B1D50 Offset: 0x16B1E51 VA: 0x16B1D50
	internal static Exception ControlCannotEnterTry() { }

	// RVA: 0x16B1DC0 Offset: 0x16B1EC1 VA: 0x16B1DC0
	internal static Exception ControlCannotEnterExpression() { }

	// RVA: 0x16B1E30 Offset: 0x16B1F31 VA: 0x16B1E30
	internal static Exception NonLocalJumpWithValue(object p0) { }

	// RVA: 0x16B1EB0 Offset: 0x16B1FB1 VA: 0x16B1EB0
	internal static Exception InvalidLvalue(ExpressionType p0) { }

	// RVA: 0x16B1F40 Offset: 0x16B2041 VA: 0x16B1F40
	internal static Exception RethrowRequiresCatch() { }

	// RVA: 0x16B1FB0 Offset: 0x16B20B1 VA: 0x16B1FB0
	internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) { }

	// RVA: 0x16B2040 Offset: 0x16B2141 VA: 0x16B2040
	internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) { }

	// RVA: 0x16B20D0 Offset: 0x16B21D1 VA: 0x16B20D0
	internal static Exception MustRewriteWithoutMethod(object p0, object p1) { }

	// RVA: 0x16AB6A0 Offset: 0x16AB7A1 VA: 0x16AB6A0
	internal static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x16B2160 Offset: 0x16B2261 VA: 0x16B2160
	internal static Exception NotSupported() { }

	// RVA: 0x16B21C0 Offset: 0x16B22C1 VA: 0x16B21C0
	internal static Exception NonStaticConstructorRequired(string paramName) { }

	// RVA: 0x16B2240 Offset: 0x16B2341 VA: 0x16B2240
	internal static Exception NonAbstractConstructorRequired() { }

	// RVA: 0x16B22B0 Offset: 0x16B23B1 VA: 0x16B22B0
	internal static Exception InvalidProgram() { }

	// RVA: 0x16B2310 Offset: 0x16B2411 VA: 0x16B2310
	internal static Exception EnumerationIsDone() { }

	// RVA: 0x16B2380 Offset: 0x16B2481 VA: 0x16B2380
	private static Exception TypeContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x16A5600 Offset: 0x16A5701 VA: 0x16A5600
	internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) { }

	// RVA: 0x16B2410 Offset: 0x16B2511 VA: 0x16B2410
	internal static Exception TypeIsGeneric(object p0, string paramName) { }

	// RVA: 0x16A56F0 Offset: 0x16A57F1 VA: 0x16A56F0
	internal static Exception TypeIsGeneric(object p0, string paramName, int index) { }

	// RVA: 0x16A09E0 Offset: 0x16A0AE1 VA: 0x16A09E0
	internal static Exception IncorrectNumberOfConstructorArguments() { }

	// RVA: 0x16B24A0 Offset: 0x16B25A1 VA: 0x16B24A0
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) { }

	// RVA: 0x16A1270 Offset: 0x16A1371 VA: 0x16A1270
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) { }

	// RVA: 0x16B2540 Offset: 0x16B2641 VA: 0x16B2540
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) { }

	// RVA: 0x16A1170 Offset: 0x16A1271 VA: 0x16A1170
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16A0A50 Offset: 0x16A0B51 VA: 0x16A0A50
	internal static Exception IncorrectNumberOfLambdaArguments() { }

	// RVA: 0x16A0AC0 Offset: 0x16A0BC1 VA: 0x16A0AC0
	internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) { }

	// RVA: 0x16B25D0 Offset: 0x16B26D1 VA: 0x16B25D0
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) { }

	// RVA: 0x16A1070 Offset: 0x16A1171 VA: 0x16A1070
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B2660 Offset: 0x16B2761 VA: 0x16B2660
	internal static Exception ExpressionMustBeReadable(string paramName) { }

	// RVA: 0x16A1390 Offset: 0x16A1491 VA: 0x16A1390
	internal static Exception ExpressionMustBeReadable(string paramName, int index) { }

	// RVA: 0x16A00F0 Offset: 0x16A01F1 VA: 0x16A00F0
	internal static Exception InvalidArgumentValue(string paramName) { }

	// RVA: 0x16B26E0 Offset: 0x16B27E1 VA: 0x16B26E0
	internal static Exception InvalidNullValue(Type type, string paramName) { }

	// RVA: 0x16B2770 Offset: 0x16B2871 VA: 0x16B2770
	internal static Exception InvalidTypeException(object value, Type type, string paramName) { }

	// RVA: 0x16AEB30 Offset: 0x16AEC31 VA: 0x16AEB30
	private static string GetParamName(string paramName, int index) { }
}

internal static class Error // TypeDefIndex: 2263
{
	// Methods

	// RVA: 0x16AE680 Offset: 0x16AE781 VA: 0x16AE680
	internal static Exception ReducibleMustOverrideReduce() { }

	// RVA: 0x169CBE0 Offset: 0x169CCE1 VA: 0x169CBE0
	internal static Exception AmbiguousMatchInExpandoObject(object p0) { }

	// RVA: 0x169D320 Offset: 0x169D421 VA: 0x169D320
	internal static Exception SameKeyExistsInExpando(object key) { }

	// RVA: 0x169E040 Offset: 0x169E141 VA: 0x169E040
	internal static Exception KeyDoesNotExistInExpando(object p0) { }

	// RVA: 0x169F110 Offset: 0x169F211 VA: 0x169F110
	internal static Exception CollectionModifiedWhileEnumerating() { }

	// RVA: 0x169F570 Offset: 0x169F671 VA: 0x169F570
	internal static Exception CollectionReadOnly() { }

	// RVA: 0x16AE6F0 Offset: 0x16AE7F1 VA: 0x16AE6F0
	internal static Exception MustReduceToDifferent() { }

	// RVA: 0x16AE760 Offset: 0x16AE861 VA: 0x16AE760
	internal static Exception ReducedNotCompatible() { }

	// RVA: 0x16AE7D0 Offset: 0x16AE8D1 VA: 0x16AE7D0
	internal static Exception SetterHasNoParams(string paramName) { }

	// RVA: 0x16AE850 Offset: 0x16AE951 VA: 0x16AE850
	internal static Exception PropertyCannotHaveRefType(string paramName) { }

	// RVA: 0x16AE8D0 Offset: 0x16AE9D1 VA: 0x16AE8D0
	internal static Exception IndexesOfSetGetMustMatch(string paramName) { }

	// RVA: 0x16AE950 Offset: 0x16AEA51 VA: 0x16AE950
	internal static Exception AccessorsCannotHaveVarArgs(string paramName) { }

	// RVA: 0x16AE9D0 Offset: 0x16AEAD1 VA: 0x16AE9D0
	private static Exception AccessorsCannotHaveByRefArgs(string paramName) { }

	// RVA: 0x16AEA50 Offset: 0x16AEB51 VA: 0x16AEA50
	internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) { }

	// RVA: 0x16AEBC0 Offset: 0x16AECC1 VA: 0x16AEBC0
	internal static Exception BoundsCannotBeLessThanOne(string paramName) { }

	// RVA: 0x16A5500 Offset: 0x16A5601 VA: 0x16A5500
	internal static Exception TypeMustNotBeByRef(string paramName) { }

	// RVA: 0x16A5580 Offset: 0x16A5681 VA: 0x16A5580
	internal static Exception TypeMustNotBePointer(string paramName) { }

	// RVA: 0x16AEC40 Offset: 0x16AED41 VA: 0x16AEC40
	internal static Exception SetterMustBeVoid(string paramName) { }

	// RVA: 0x16AECC0 Offset: 0x16AEDC1 VA: 0x16AECC0
	internal static Exception PropertyTypeMustMatchGetter(string paramName) { }

	// RVA: 0x16AED40 Offset: 0x16AEE41 VA: 0x16AED40
	internal static Exception PropertyTypeMustMatchSetter(string paramName) { }

	// RVA: 0x16AEDC0 Offset: 0x16AEEC1 VA: 0x16AEDC0
	internal static Exception BothAccessorsMustBeStatic(string paramName) { }

	// RVA: 0x16AEE40 Offset: 0x16AEF41 VA: 0x16AEE40
	internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) { }

	// RVA: 0x16AEEC0 Offset: 0x16AEFC1 VA: 0x16AEEC0
	internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) { }

	// RVA: 0x16AEF40 Offset: 0x16AF041 VA: 0x16AEF40
	internal static Exception OnlyStaticMethodsHaveNullInstance() { }

	// RVA: 0x16AEFB0 Offset: 0x16AF0B1 VA: 0x16AEFB0
	internal static Exception PropertyTypeCannotBeVoid(string paramName) { }

	// RVA: 0x16AF030 Offset: 0x16AF131 VA: 0x16AF030
	internal static Exception InvalidUnboxType(string paramName) { }

	// RVA: 0x16AF0B0 Offset: 0x16AF1B1 VA: 0x16AF0B0
	internal static Exception ExpressionMustBeWriteable(string paramName) { }

	// RVA: 0x16AF130 Offset: 0x16AF231 VA: 0x16AF130
	internal static Exception ArgumentMustNotHaveValueType(string paramName) { }

	// RVA: 0x16AF1B0 Offset: 0x16AF2B1 VA: 0x16AF1B0
	internal static Exception MustBeReducible() { }

	// RVA: 0x16AF220 Offset: 0x16AF321 VA: 0x16AF220
	internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) { }

	// RVA: 0x16AF2A0 Offset: 0x16AF3A1 VA: 0x16AF2A0
	internal static Exception QuotedExpressionMustBeLambda(string paramName) { }

	// RVA: 0x16AF320 Offset: 0x16AF421 VA: 0x16AF320
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) { }

	// RVA: 0x16AF3B0 Offset: 0x16AF4B1 VA: 0x16AF3B0
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16AF4B0 Offset: 0x16AF5B1 VA: 0x16AF4B0
	private static Exception DuplicateVariable(object p0, string paramName) { }

	// RVA: 0x16AF540 Offset: 0x16AF641 VA: 0x16AF540
	internal static Exception DuplicateVariable(object p0, string paramName, int index) { }

	// RVA: 0x16AF630 Offset: 0x16AF731 VA: 0x16AF630
	internal static Exception FaultCannotHaveCatchOrFinally(string paramName) { }

	// RVA: 0x16AF6B0 Offset: 0x16AF7B1 VA: 0x16AF6B0
	internal static Exception TryMustHaveCatchFinallyOrFault() { }

	// RVA: 0x16AF720 Offset: 0x16AF821 VA: 0x16AF720
	internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	// RVA: 0x16AF790 Offset: 0x16AF891 VA: 0x16AF790
	internal static Exception ExtensionNodeMustOverrideProperty(object p0) { }

	// RVA: 0x16AF810 Offset: 0x16AF911 VA: 0x16AF810
	internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) { }

	// RVA: 0x16AF8A0 Offset: 0x16AF9A1 VA: 0x16AF8A0
	internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) { }

	// RVA: 0x16AF930 Offset: 0x16AFA31 VA: 0x16AF930
	internal static Exception CoercionOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x16AF9C0 Offset: 0x16AFAC1 VA: 0x16AF9C0
	internal static Exception UnaryOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x16AFA50 Offset: 0x16AFB51 VA: 0x16AFA50
	internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	// RVA: 0x16AFAE0 Offset: 0x16AFBE1 VA: 0x16AFAE0
	internal static Exception ReferenceEqualityNotDefined(object p0, object p1) { }

	// RVA: 0x16AFB70 Offset: 0x16AFC71 VA: 0x16AFB70
	internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) { }

	// RVA: 0x16AFC00 Offset: 0x16AFD01 VA: 0x16AFC00
	internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	// RVA: 0x16AFC90 Offset: 0x16AFD91 VA: 0x16AFC90
	internal static Exception ConversionIsNotSupportedForArithmeticTypes() { }

	// RVA: 0x16AFD00 Offset: 0x16AFE01 VA: 0x16AFD00
	internal static Exception ArgumentMustBeArray(string paramName) { }

	// RVA: 0x16AFD80 Offset: 0x16AFE81 VA: 0x16AFD80
	internal static Exception ArgumentMustBeBoolean(string paramName) { }

	// RVA: 0x16AFE00 Offset: 0x16AFF01 VA: 0x16AFE00
	private static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName) { }

	// RVA: 0x16AFE80 Offset: 0x16AFF81 VA: 0x16AFE80
	internal static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName, int index) { }

	// RVA: 0x16AFF60 Offset: 0x16B0061 VA: 0x16AFF60
	private static Exception ArgumentMustBeInstanceMember(string paramName) { }

	// RVA: 0x16AFFE0 Offset: 0x16B00E1 VA: 0x16AFFE0
	internal static Exception ArgumentMustBeInstanceMember(string paramName, int index) { }

	// RVA: 0x16B00C0 Offset: 0x16B01C1 VA: 0x16B00C0
	private static Exception ArgumentMustBeInteger(string paramName) { }

	// RVA: 0x16B0140 Offset: 0x16B0241 VA: 0x16B0140
	internal static Exception ArgumentMustBeInteger(string paramName, int index) { }

	// RVA: 0x16B0220 Offset: 0x16B0321 VA: 0x16B0220
	internal static Exception ArgumentMustBeArrayIndexType(string paramName) { }

	// RVA: 0x16B02A0 Offset: 0x16B03A1 VA: 0x16B02A0
	internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) { }

	// RVA: 0x16B0320 Offset: 0x16B0421 VA: 0x16B0320
	internal static Exception ArgumentTypesMustMatch() { }

	// RVA: 0x16B0390 Offset: 0x16B0491 VA: 0x16B0390
	internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	// RVA: 0x16B0410 Offset: 0x16B0511 VA: 0x16B0410
	internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) { }

	// RVA: 0x16B04A0 Offset: 0x16B05A1 VA: 0x16B04A0
	internal static Exception CoalesceUsedOnNonNullType() { }

	// RVA: 0x16B0510 Offset: 0x16B0611 VA: 0x16B0510
	internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	// RVA: 0x16B05A0 Offset: 0x16B06A1 VA: 0x16B05A0
	private static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName) { }

	// RVA: 0x16B0630 Offset: 0x16B0731 VA: 0x16B0630
	internal static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B0730 Offset: 0x16B0831 VA: 0x16B0730
	private static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName) { }

	// RVA: 0x16B07C0 Offset: 0x16B08C1 VA: 0x16B07C0
	internal static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B08C0 Offset: 0x16B09C1 VA: 0x16B08C0
	internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	// RVA: 0x16B0950 Offset: 0x16B0A51 VA: 0x16B0950
	internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	// RVA: 0x16B09E0 Offset: 0x16B0AE1 VA: 0x16B09E0
	internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	// RVA: 0x16B0A70 Offset: 0x16B0B71 VA: 0x16B0A70
	internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) { }

	// RVA: 0x16B0B00 Offset: 0x16B0C01 VA: 0x16B0B00
	internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x16B0B90 Offset: 0x16B0C91 VA: 0x16B0B90
	internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	// RVA: 0x16B0C20 Offset: 0x16B0D21 VA: 0x16B0C20
	internal static Exception IncorrectNumberOfIndexes() { }

	// RVA: 0x16B0C90 Offset: 0x16B0D91 VA: 0x16B0C90
	internal static Exception IncorrectNumberOfLambdaDeclarationParameters() { }

	// RVA: 0x16B0D00 Offset: 0x16B0E01 VA: 0x16B0D00
	internal static Exception IncorrectNumberOfMembersForGivenConstructor() { }

	// RVA: 0x16B0D70 Offset: 0x16B0E71 VA: 0x16B0D70
	internal static Exception IncorrectNumberOfArgumentsForMembers() { }

	// RVA: 0x16B0DE0 Offset: 0x16B0EE1 VA: 0x16B0DE0
	internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) { }

	// RVA: 0x16B0E60 Offset: 0x16B0F61 VA: 0x16B0E60
	internal static Exception MemberNotFieldOrProperty(object p0, string paramName) { }

	// RVA: 0x16B0EF0 Offset: 0x16B0FF1 VA: 0x16B0EF0
	internal static Exception MethodContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x16B0F80 Offset: 0x16B1081 VA: 0x16B0F80
	internal static Exception MethodIsGeneric(object p0, string paramName) { }

	// RVA: 0x16B1010 Offset: 0x16B1111 VA: 0x16B1010
	private static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName) { }

	// RVA: 0x16B10A0 Offset: 0x16B11A1 VA: 0x16B10A0
	internal static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B11A0 Offset: 0x16B12A1 VA: 0x16B11A0
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName) { }

	// RVA: 0x16B1230 Offset: 0x16B1331 VA: 0x16B1230
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName, int index) { }

	// RVA: 0x16B1320 Offset: 0x16B1421 VA: 0x16B1320
	internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) { }

	// RVA: 0x16B13B0 Offset: 0x16B14B1 VA: 0x16B13B0
	internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	// RVA: 0x16B1440 Offset: 0x16B1541 VA: 0x16B1440
	internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x16B14D0 Offset: 0x16B15D1 VA: 0x16B14D0
	internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x16B1560 Offset: 0x16B1661 VA: 0x16B1560
	internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	// RVA: 0x16B15F0 Offset: 0x16B16F1 VA: 0x16B15F0
	internal static Exception UnhandledBinary(object p0, string paramName) { }

	// RVA: 0x16B1680 Offset: 0x16B1781 VA: 0x16B1680
	internal static Exception UnhandledUnary(object p0, string paramName) { }

	// RVA: 0x16B1710 Offset: 0x16B1811 VA: 0x16B1710
	internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	// RVA: 0x16B17A0 Offset: 0x16B18A1 VA: 0x16B17A0
	internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	// RVA: 0x16B1830 Offset: 0x16B1931 VA: 0x16B1830
	internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	// RVA: 0x16B18C0 Offset: 0x16B19C1 VA: 0x16B18C0
	internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x16B1950 Offset: 0x16B1A51 VA: 0x16B1950
	internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x16B19E0 Offset: 0x16B1AE1 VA: 0x16B19E0
	internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x16B1A70 Offset: 0x16B1B71 VA: 0x16B1A70
	internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) { }

	// RVA: 0x16B1AF0 Offset: 0x16B1BF1 VA: 0x16B1AF0
	internal static Exception LabelTargetAlreadyDefined(object p0) { }

	// RVA: 0x16B1B70 Offset: 0x16B1C71 VA: 0x16B1B70
	internal static Exception LabelTargetUndefined(object p0) { }

	// RVA: 0x16B1BF0 Offset: 0x16B1CF1 VA: 0x16B1BF0
	internal static Exception ControlCannotLeaveFinally() { }

	// RVA: 0x16B1C60 Offset: 0x16B1D61 VA: 0x16B1C60
	internal static Exception ControlCannotLeaveFilterTest() { }

	// RVA: 0x16B1CD0 Offset: 0x16B1DD1 VA: 0x16B1CD0
	internal static Exception AmbiguousJump(object p0) { }

	// RVA: 0x16B1D50 Offset: 0x16B1E51 VA: 0x16B1D50
	internal static Exception ControlCannotEnterTry() { }

	// RVA: 0x16B1DC0 Offset: 0x16B1EC1 VA: 0x16B1DC0
	internal static Exception ControlCannotEnterExpression() { }

	// RVA: 0x16B1E30 Offset: 0x16B1F31 VA: 0x16B1E30
	internal static Exception NonLocalJumpWithValue(object p0) { }

	// RVA: 0x16B1EB0 Offset: 0x16B1FB1 VA: 0x16B1EB0
	internal static Exception InvalidLvalue(ExpressionType p0) { }

	// RVA: 0x16B1F40 Offset: 0x16B2041 VA: 0x16B1F40
	internal static Exception RethrowRequiresCatch() { }

	// RVA: 0x16B1FB0 Offset: 0x16B20B1 VA: 0x16B1FB0
	internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) { }

	// RVA: 0x16B2040 Offset: 0x16B2141 VA: 0x16B2040
	internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) { }

	// RVA: 0x16B20D0 Offset: 0x16B21D1 VA: 0x16B20D0
	internal static Exception MustRewriteWithoutMethod(object p0, object p1) { }

	// RVA: 0x16AB6A0 Offset: 0x16AB7A1 VA: 0x16AB6A0
	internal static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x16B2160 Offset: 0x16B2261 VA: 0x16B2160
	internal static Exception NotSupported() { }

	// RVA: 0x16B21C0 Offset: 0x16B22C1 VA: 0x16B21C0
	internal static Exception NonStaticConstructorRequired(string paramName) { }

	// RVA: 0x16B2240 Offset: 0x16B2341 VA: 0x16B2240
	internal static Exception NonAbstractConstructorRequired() { }

	// RVA: 0x16B22B0 Offset: 0x16B23B1 VA: 0x16B22B0
	internal static Exception InvalidProgram() { }

	// RVA: 0x16B2310 Offset: 0x16B2411 VA: 0x16B2310
	internal static Exception EnumerationIsDone() { }

	// RVA: 0x16B2380 Offset: 0x16B2481 VA: 0x16B2380
	private static Exception TypeContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x16A5600 Offset: 0x16A5701 VA: 0x16A5600
	internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) { }

	// RVA: 0x16B2410 Offset: 0x16B2511 VA: 0x16B2410
	internal static Exception TypeIsGeneric(object p0, string paramName) { }

	// RVA: 0x16A56F0 Offset: 0x16A57F1 VA: 0x16A56F0
	internal static Exception TypeIsGeneric(object p0, string paramName, int index) { }

	// RVA: 0x16A09E0 Offset: 0x16A0AE1 VA: 0x16A09E0
	internal static Exception IncorrectNumberOfConstructorArguments() { }

	// RVA: 0x16B24A0 Offset: 0x16B25A1 VA: 0x16B24A0
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) { }

	// RVA: 0x16A1270 Offset: 0x16A1371 VA: 0x16A1270
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) { }

	// RVA: 0x16B2540 Offset: 0x16B2641 VA: 0x16B2540
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) { }

	// RVA: 0x16A1170 Offset: 0x16A1271 VA: 0x16A1170
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16A0A50 Offset: 0x16A0B51 VA: 0x16A0A50
	internal static Exception IncorrectNumberOfLambdaArguments() { }

	// RVA: 0x16A0AC0 Offset: 0x16A0BC1 VA: 0x16A0AC0
	internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) { }

	// RVA: 0x16B25D0 Offset: 0x16B26D1 VA: 0x16B25D0
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) { }

	// RVA: 0x16A1070 Offset: 0x16A1171 VA: 0x16A1070
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x16B2660 Offset: 0x16B2761 VA: 0x16B2660
	internal static Exception ExpressionMustBeReadable(string paramName) { }

	// RVA: 0x16A1390 Offset: 0x16A1491 VA: 0x16A1390
	internal static Exception ExpressionMustBeReadable(string paramName, int index) { }

	// RVA: 0x16A00F0 Offset: 0x16A01F1 VA: 0x16A00F0
	internal static Exception InvalidArgumentValue(string paramName) { }

	// RVA: 0x16B26E0 Offset: 0x16B27E1 VA: 0x16B26E0
	internal static Exception InvalidNullValue(Type type, string paramName) { }

	// RVA: 0x16B2770 Offset: 0x16B2871 VA: 0x16B2770
	internal static Exception InvalidTypeException(object value, Type type, string paramName) { }

	// RVA: 0x16AEB30 Offset: 0x16AEC31 VA: 0x16AEB30
	private static string GetParamName(string paramName, int index) { }
}

