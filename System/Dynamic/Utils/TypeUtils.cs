[ExtensionAttribute] // RVA: 0xBF1B0 Offset: 0xBF2B1 VA: 0xBF1B0
internal static class TypeUtils // TypeDefIndex: 2738
{
	// Fields
	private static Assembly s_mscorlib; // 0x0

	// Properties
	private static Assembly MsCorLib { get; }

	// Methods

	[ExtensionAttribute] // RVA: 0xC1300 Offset: 0xC1401 VA: 0xC1300
	// RVA: 0x16A2400 Offset: 0x16A2501 VA: 0x16A2400
	public static Type GetNonNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1310 Offset: 0xC1411 VA: 0xC1310
	// RVA: 0x16A2530 Offset: 0x16A2631 VA: 0x16A2530
	public static Type GetNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1320 Offset: 0xC1421 VA: 0xC1320
	// RVA: 0x16A2460 Offset: 0x16A2561 VA: 0x16A2460
	public static bool IsNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1330 Offset: 0xC1431 VA: 0xC1330
	// RVA: 0x16A2670 Offset: 0x16A2771 VA: 0x16A2670
	public static bool IsNullableOrReferenceType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1340 Offset: 0xC1441 VA: 0xC1340
	// RVA: 0x16A26C0 Offset: 0x16A27C1 VA: 0x16A26C0
	public static bool IsBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1350 Offset: 0xC1451 VA: 0xC1350
	// RVA: 0x16A2790 Offset: 0x16A2891 VA: 0x16A2790
	public static bool IsNumeric(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1360 Offset: 0xC1461 VA: 0xC1360
	// RVA: 0x16A28C0 Offset: 0x16A29C1 VA: 0x16A28C0
	public static bool IsInteger(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1370 Offset: 0xC1471 VA: 0xC1370
	// RVA: 0x16A29F0 Offset: 0x16A2AF1 VA: 0x16A29F0
	public static bool IsArithmetic(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1380 Offset: 0xC1481 VA: 0xC1380
	// RVA: 0x16A2B20 Offset: 0x16A2C21 VA: 0x16A2B20
	public static bool IsUnsignedInt(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1390 Offset: 0xC1491 VA: 0xC1390
	// RVA: 0x16A2C60 Offset: 0x16A2D61 VA: 0x16A2C60
	public static bool IsIntegerOrBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC13A0 Offset: 0xC14A1 VA: 0xC13A0
	// RVA: 0x16A2DA0 Offset: 0x16A2EA1 VA: 0x16A2DA0
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x16A2DE0 Offset: 0x16A2EE1 VA: 0x16A2DE0
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[ExtensionAttribute] // RVA: 0xC13B0 Offset: 0xC14B1 VA: 0xC13B0
	// RVA: 0x16A3240 Offset: 0x16A3341 VA: 0x16A3240
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13C0 Offset: 0xC14C1 VA: 0xC13C0
	// RVA: 0x16A3780 Offset: 0x16A3881 VA: 0x16A3780
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	// RVA: 0x16A3DC0 Offset: 0x16A3EC1 VA: 0x16A3DC0
	private static bool IsCovariant(Type t) { }

	// RVA: 0x16A3DF0 Offset: 0x16A3EF1 VA: 0x16A3DF0
	private static bool IsContravariant(Type t) { }

	// RVA: 0x16A3E20 Offset: 0x16A3F21 VA: 0x16A3E20
	private static bool IsInvariant(Type t) { }

	// RVA: 0x16A3E50 Offset: 0x16A3F51 VA: 0x16A3E50
	private static bool IsDelegate(Type t) { }

	// RVA: 0x16A39F0 Offset: 0x16A3AF1 VA: 0x16A39F0
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13D0 Offset: 0xC14D1 VA: 0xC13D0
	// RVA: 0x16A3650 Offset: 0x16A3751 VA: 0x16A3650
	public static bool IsConvertible(Type type) { }

	// RVA: 0x16A3EF0 Offset: 0x16A3FF1 VA: 0x16A3EF0
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x16A3FA0 Offset: 0x16A40A1 VA: 0x16A3FA0
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[ExtensionAttribute] // RVA: 0xC13E0 Offset: 0xC14E1 VA: 0xC13E0
	// RVA: 0x16A41D0 Offset: 0x16A42D1 VA: 0x16A41D0
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x16A4790 Offset: 0x16A4891 VA: 0x16A4790
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x16A4A20 Offset: 0x16A4B21 VA: 0x16A4A20
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x16A42D0 Offset: 0x16A43D1 VA: 0x16A42D0
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x16A4520 Offset: 0x16A4621 VA: 0x16A4520
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x16A4550 Offset: 0x16A4651 VA: 0x16A4550
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x16A46D0 Offset: 0x16A47D1 VA: 0x16A46D0
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x16A4C80 Offset: 0x16A4D81 VA: 0x16A4C80
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x16A5160 Offset: 0x16A5261 VA: 0x16A5160
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[ExtensionAttribute] // RVA: 0xC13F0 Offset: 0xC14F1 VA: 0xC13F0
	// RVA: 0x16A5370 Offset: 0x16A5471 VA: 0x16A5370
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x16A35A0 Offset: 0x16A36A1 VA: 0x16A35A0
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x16A0E40 Offset: 0x16A0F41 VA: 0x16A0E40
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x16A1470 Offset: 0x16A1571 VA: 0x16A1470
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x16A53C0 Offset: 0x16A54C1 VA: 0x16A53C0
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x16A0D60 Offset: 0x16A0E61 VA: 0x16A0D60
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x16A53D0 Offset: 0x16A54D1 VA: 0x16A53D0
	public static bool ValidateType(Type type, string paramName, int index) { }

	// RVA: 0x16A57E0 Offset: 0x16A58E1 VA: 0x16A57E0
	private static Assembly get_MsCorLib() { }

	[ExtensionAttribute] // RVA: 0xC1400 Offset: 0xC1501 VA: 0xC1400
	// RVA: 0x16A2290 Offset: 0x16A2391 VA: 0x16A2290
	public static bool CanCache(Type t) { }

	[ExtensionAttribute] // RVA: 0xC1410 Offset: 0xC1511 VA: 0xC1410
	// RVA: 0x16A58B0 Offset: 0x16A59B1 VA: 0x16A58B0
	public static MethodInfo GetInvokeMethod(Type delegateType) { }
}

[ExtensionAttribute] // RVA: 0xBF1B0 Offset: 0xBF2B1 VA: 0xBF1B0
internal static class TypeUtils // TypeDefIndex: 2738
{
	// Fields
	private static Assembly s_mscorlib; // 0x0

	// Properties
	private static Assembly MsCorLib { get; }

	// Methods

	[ExtensionAttribute] // RVA: 0xC1300 Offset: 0xC1401 VA: 0xC1300
	// RVA: 0x16A2400 Offset: 0x16A2501 VA: 0x16A2400
	public static Type GetNonNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1310 Offset: 0xC1411 VA: 0xC1310
	// RVA: 0x16A2530 Offset: 0x16A2631 VA: 0x16A2530
	public static Type GetNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1320 Offset: 0xC1421 VA: 0xC1320
	// RVA: 0x16A2460 Offset: 0x16A2561 VA: 0x16A2460
	public static bool IsNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1330 Offset: 0xC1431 VA: 0xC1330
	// RVA: 0x16A2670 Offset: 0x16A2771 VA: 0x16A2670
	public static bool IsNullableOrReferenceType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1340 Offset: 0xC1441 VA: 0xC1340
	// RVA: 0x16A26C0 Offset: 0x16A27C1 VA: 0x16A26C0
	public static bool IsBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1350 Offset: 0xC1451 VA: 0xC1350
	// RVA: 0x16A2790 Offset: 0x16A2891 VA: 0x16A2790
	public static bool IsNumeric(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1360 Offset: 0xC1461 VA: 0xC1360
	// RVA: 0x16A28C0 Offset: 0x16A29C1 VA: 0x16A28C0
	public static bool IsInteger(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1370 Offset: 0xC1471 VA: 0xC1370
	// RVA: 0x16A29F0 Offset: 0x16A2AF1 VA: 0x16A29F0
	public static bool IsArithmetic(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1380 Offset: 0xC1481 VA: 0xC1380
	// RVA: 0x16A2B20 Offset: 0x16A2C21 VA: 0x16A2B20
	public static bool IsUnsignedInt(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1390 Offset: 0xC1491 VA: 0xC1390
	// RVA: 0x16A2C60 Offset: 0x16A2D61 VA: 0x16A2C60
	public static bool IsIntegerOrBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC13A0 Offset: 0xC14A1 VA: 0xC13A0
	// RVA: 0x16A2DA0 Offset: 0x16A2EA1 VA: 0x16A2DA0
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x16A2DE0 Offset: 0x16A2EE1 VA: 0x16A2DE0
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[ExtensionAttribute] // RVA: 0xC13B0 Offset: 0xC14B1 VA: 0xC13B0
	// RVA: 0x16A3240 Offset: 0x16A3341 VA: 0x16A3240
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13C0 Offset: 0xC14C1 VA: 0xC13C0
	// RVA: 0x16A3780 Offset: 0x16A3881 VA: 0x16A3780
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	// RVA: 0x16A3DC0 Offset: 0x16A3EC1 VA: 0x16A3DC0
	private static bool IsCovariant(Type t) { }

	// RVA: 0x16A3DF0 Offset: 0x16A3EF1 VA: 0x16A3DF0
	private static bool IsContravariant(Type t) { }

	// RVA: 0x16A3E20 Offset: 0x16A3F21 VA: 0x16A3E20
	private static bool IsInvariant(Type t) { }

	// RVA: 0x16A3E50 Offset: 0x16A3F51 VA: 0x16A3E50
	private static bool IsDelegate(Type t) { }

	// RVA: 0x16A39F0 Offset: 0x16A3AF1 VA: 0x16A39F0
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13D0 Offset: 0xC14D1 VA: 0xC13D0
	// RVA: 0x16A3650 Offset: 0x16A3751 VA: 0x16A3650
	public static bool IsConvertible(Type type) { }

	// RVA: 0x16A3EF0 Offset: 0x16A3FF1 VA: 0x16A3EF0
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x16A3FA0 Offset: 0x16A40A1 VA: 0x16A3FA0
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[ExtensionAttribute] // RVA: 0xC13E0 Offset: 0xC14E1 VA: 0xC13E0
	// RVA: 0x16A41D0 Offset: 0x16A42D1 VA: 0x16A41D0
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x16A4790 Offset: 0x16A4891 VA: 0x16A4790
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x16A4A20 Offset: 0x16A4B21 VA: 0x16A4A20
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x16A42D0 Offset: 0x16A43D1 VA: 0x16A42D0
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x16A4520 Offset: 0x16A4621 VA: 0x16A4520
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x16A4550 Offset: 0x16A4651 VA: 0x16A4550
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x16A46D0 Offset: 0x16A47D1 VA: 0x16A46D0
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x16A4C80 Offset: 0x16A4D81 VA: 0x16A4C80
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x16A5160 Offset: 0x16A5261 VA: 0x16A5160
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[ExtensionAttribute] // RVA: 0xC13F0 Offset: 0xC14F1 VA: 0xC13F0
	// RVA: 0x16A5370 Offset: 0x16A5471 VA: 0x16A5370
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x16A35A0 Offset: 0x16A36A1 VA: 0x16A35A0
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x16A0E40 Offset: 0x16A0F41 VA: 0x16A0E40
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x16A1470 Offset: 0x16A1571 VA: 0x16A1470
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x16A53C0 Offset: 0x16A54C1 VA: 0x16A53C0
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x16A0D60 Offset: 0x16A0E61 VA: 0x16A0D60
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x16A53D0 Offset: 0x16A54D1 VA: 0x16A53D0
	public static bool ValidateType(Type type, string paramName, int index) { }

	// RVA: 0x16A57E0 Offset: 0x16A58E1 VA: 0x16A57E0
	private static Assembly get_MsCorLib() { }

	[ExtensionAttribute] // RVA: 0xC1400 Offset: 0xC1501 VA: 0xC1400
	// RVA: 0x16A2290 Offset: 0x16A2391 VA: 0x16A2290
	public static bool CanCache(Type t) { }

	[ExtensionAttribute] // RVA: 0xC1410 Offset: 0xC1511 VA: 0xC1410
	// RVA: 0x16A58B0 Offset: 0x16A59B1 VA: 0x16A58B0
	public static MethodInfo GetInvokeMethod(Type delegateType) { }
}

[ExtensionAttribute] // RVA: 0xBF1B0 Offset: 0xBF2B1 VA: 0xBF1B0
internal static class TypeUtils // TypeDefIndex: 2738
{
	// Fields
	private static Assembly s_mscorlib; // 0x0

	// Properties
	private static Assembly MsCorLib { get; }

	// Methods

	[ExtensionAttribute] // RVA: 0xC1300 Offset: 0xC1401 VA: 0xC1300
	// RVA: 0x16A2400 Offset: 0x16A2501 VA: 0x16A2400
	public static Type GetNonNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1310 Offset: 0xC1411 VA: 0xC1310
	// RVA: 0x16A2530 Offset: 0x16A2631 VA: 0x16A2530
	public static Type GetNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1320 Offset: 0xC1421 VA: 0xC1320
	// RVA: 0x16A2460 Offset: 0x16A2561 VA: 0x16A2460
	public static bool IsNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1330 Offset: 0xC1431 VA: 0xC1330
	// RVA: 0x16A2670 Offset: 0x16A2771 VA: 0x16A2670
	public static bool IsNullableOrReferenceType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1340 Offset: 0xC1441 VA: 0xC1340
	// RVA: 0x16A26C0 Offset: 0x16A27C1 VA: 0x16A26C0
	public static bool IsBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1350 Offset: 0xC1451 VA: 0xC1350
	// RVA: 0x16A2790 Offset: 0x16A2891 VA: 0x16A2790
	public static bool IsNumeric(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1360 Offset: 0xC1461 VA: 0xC1360
	// RVA: 0x16A28C0 Offset: 0x16A29C1 VA: 0x16A28C0
	public static bool IsInteger(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1370 Offset: 0xC1471 VA: 0xC1370
	// RVA: 0x16A29F0 Offset: 0x16A2AF1 VA: 0x16A29F0
	public static bool IsArithmetic(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1380 Offset: 0xC1481 VA: 0xC1380
	// RVA: 0x16A2B20 Offset: 0x16A2C21 VA: 0x16A2B20
	public static bool IsUnsignedInt(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1390 Offset: 0xC1491 VA: 0xC1390
	// RVA: 0x16A2C60 Offset: 0x16A2D61 VA: 0x16A2C60
	public static bool IsIntegerOrBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC13A0 Offset: 0xC14A1 VA: 0xC13A0
	// RVA: 0x16A2DA0 Offset: 0x16A2EA1 VA: 0x16A2DA0
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x16A2DE0 Offset: 0x16A2EE1 VA: 0x16A2DE0
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[ExtensionAttribute] // RVA: 0xC13B0 Offset: 0xC14B1 VA: 0xC13B0
	// RVA: 0x16A3240 Offset: 0x16A3341 VA: 0x16A3240
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13C0 Offset: 0xC14C1 VA: 0xC13C0
	// RVA: 0x16A3780 Offset: 0x16A3881 VA: 0x16A3780
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	// RVA: 0x16A3DC0 Offset: 0x16A3EC1 VA: 0x16A3DC0
	private static bool IsCovariant(Type t) { }

	// RVA: 0x16A3DF0 Offset: 0x16A3EF1 VA: 0x16A3DF0
	private static bool IsContravariant(Type t) { }

	// RVA: 0x16A3E20 Offset: 0x16A3F21 VA: 0x16A3E20
	private static bool IsInvariant(Type t) { }

	// RVA: 0x16A3E50 Offset: 0x16A3F51 VA: 0x16A3E50
	private static bool IsDelegate(Type t) { }

	// RVA: 0x16A39F0 Offset: 0x16A3AF1 VA: 0x16A39F0
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13D0 Offset: 0xC14D1 VA: 0xC13D0
	// RVA: 0x16A3650 Offset: 0x16A3751 VA: 0x16A3650
	public static bool IsConvertible(Type type) { }

	// RVA: 0x16A3EF0 Offset: 0x16A3FF1 VA: 0x16A3EF0
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x16A3FA0 Offset: 0x16A40A1 VA: 0x16A3FA0
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[ExtensionAttribute] // RVA: 0xC13E0 Offset: 0xC14E1 VA: 0xC13E0
	// RVA: 0x16A41D0 Offset: 0x16A42D1 VA: 0x16A41D0
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x16A4790 Offset: 0x16A4891 VA: 0x16A4790
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x16A4A20 Offset: 0x16A4B21 VA: 0x16A4A20
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x16A42D0 Offset: 0x16A43D1 VA: 0x16A42D0
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x16A4520 Offset: 0x16A4621 VA: 0x16A4520
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x16A4550 Offset: 0x16A4651 VA: 0x16A4550
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x16A46D0 Offset: 0x16A47D1 VA: 0x16A46D0
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x16A4C80 Offset: 0x16A4D81 VA: 0x16A4C80
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x16A5160 Offset: 0x16A5261 VA: 0x16A5160
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[ExtensionAttribute] // RVA: 0xC13F0 Offset: 0xC14F1 VA: 0xC13F0
	// RVA: 0x16A5370 Offset: 0x16A5471 VA: 0x16A5370
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x16A35A0 Offset: 0x16A36A1 VA: 0x16A35A0
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x16A0E40 Offset: 0x16A0F41 VA: 0x16A0E40
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x16A1470 Offset: 0x16A1571 VA: 0x16A1470
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x16A53C0 Offset: 0x16A54C1 VA: 0x16A53C0
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x16A0D60 Offset: 0x16A0E61 VA: 0x16A0D60
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x16A53D0 Offset: 0x16A54D1 VA: 0x16A53D0
	public static bool ValidateType(Type type, string paramName, int index) { }

	// RVA: 0x16A57E0 Offset: 0x16A58E1 VA: 0x16A57E0
	private static Assembly get_MsCorLib() { }

	[ExtensionAttribute] // RVA: 0xC1400 Offset: 0xC1501 VA: 0xC1400
	// RVA: 0x16A2290 Offset: 0x16A2391 VA: 0x16A2290
	public static bool CanCache(Type t) { }

	[ExtensionAttribute] // RVA: 0xC1410 Offset: 0xC1511 VA: 0xC1410
	// RVA: 0x16A58B0 Offset: 0x16A59B1 VA: 0x16A58B0
	public static MethodInfo GetInvokeMethod(Type delegateType) { }
}

[ExtensionAttribute] // RVA: 0xBF1B0 Offset: 0xBF2B1 VA: 0xBF1B0
internal static class TypeUtils // TypeDefIndex: 2738
{
	// Fields
	private static Assembly s_mscorlib; // 0x0

	// Properties
	private static Assembly MsCorLib { get; }

	// Methods

	[ExtensionAttribute] // RVA: 0xC1300 Offset: 0xC1401 VA: 0xC1300
	// RVA: 0x16A2400 Offset: 0x16A2501 VA: 0x16A2400
	public static Type GetNonNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1310 Offset: 0xC1411 VA: 0xC1310
	// RVA: 0x16A2530 Offset: 0x16A2631 VA: 0x16A2530
	public static Type GetNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1320 Offset: 0xC1421 VA: 0xC1320
	// RVA: 0x16A2460 Offset: 0x16A2561 VA: 0x16A2460
	public static bool IsNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1330 Offset: 0xC1431 VA: 0xC1330
	// RVA: 0x16A2670 Offset: 0x16A2771 VA: 0x16A2670
	public static bool IsNullableOrReferenceType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1340 Offset: 0xC1441 VA: 0xC1340
	// RVA: 0x16A26C0 Offset: 0x16A27C1 VA: 0x16A26C0
	public static bool IsBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1350 Offset: 0xC1451 VA: 0xC1350
	// RVA: 0x16A2790 Offset: 0x16A2891 VA: 0x16A2790
	public static bool IsNumeric(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1360 Offset: 0xC1461 VA: 0xC1360
	// RVA: 0x16A28C0 Offset: 0x16A29C1 VA: 0x16A28C0
	public static bool IsInteger(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1370 Offset: 0xC1471 VA: 0xC1370
	// RVA: 0x16A29F0 Offset: 0x16A2AF1 VA: 0x16A29F0
	public static bool IsArithmetic(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1380 Offset: 0xC1481 VA: 0xC1380
	// RVA: 0x16A2B20 Offset: 0x16A2C21 VA: 0x16A2B20
	public static bool IsUnsignedInt(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1390 Offset: 0xC1491 VA: 0xC1390
	// RVA: 0x16A2C60 Offset: 0x16A2D61 VA: 0x16A2C60
	public static bool IsIntegerOrBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC13A0 Offset: 0xC14A1 VA: 0xC13A0
	// RVA: 0x16A2DA0 Offset: 0x16A2EA1 VA: 0x16A2DA0
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x16A2DE0 Offset: 0x16A2EE1 VA: 0x16A2DE0
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[ExtensionAttribute] // RVA: 0xC13B0 Offset: 0xC14B1 VA: 0xC13B0
	// RVA: 0x16A3240 Offset: 0x16A3341 VA: 0x16A3240
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13C0 Offset: 0xC14C1 VA: 0xC13C0
	// RVA: 0x16A3780 Offset: 0x16A3881 VA: 0x16A3780
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	// RVA: 0x16A3DC0 Offset: 0x16A3EC1 VA: 0x16A3DC0
	private static bool IsCovariant(Type t) { }

	// RVA: 0x16A3DF0 Offset: 0x16A3EF1 VA: 0x16A3DF0
	private static bool IsContravariant(Type t) { }

	// RVA: 0x16A3E20 Offset: 0x16A3F21 VA: 0x16A3E20
	private static bool IsInvariant(Type t) { }

	// RVA: 0x16A3E50 Offset: 0x16A3F51 VA: 0x16A3E50
	private static bool IsDelegate(Type t) { }

	// RVA: 0x16A39F0 Offset: 0x16A3AF1 VA: 0x16A39F0
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13D0 Offset: 0xC14D1 VA: 0xC13D0
	// RVA: 0x16A3650 Offset: 0x16A3751 VA: 0x16A3650
	public static bool IsConvertible(Type type) { }

	// RVA: 0x16A3EF0 Offset: 0x16A3FF1 VA: 0x16A3EF0
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x16A3FA0 Offset: 0x16A40A1 VA: 0x16A3FA0
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[ExtensionAttribute] // RVA: 0xC13E0 Offset: 0xC14E1 VA: 0xC13E0
	// RVA: 0x16A41D0 Offset: 0x16A42D1 VA: 0x16A41D0
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x16A4790 Offset: 0x16A4891 VA: 0x16A4790
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x16A4A20 Offset: 0x16A4B21 VA: 0x16A4A20
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x16A42D0 Offset: 0x16A43D1 VA: 0x16A42D0
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x16A4520 Offset: 0x16A4621 VA: 0x16A4520
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x16A4550 Offset: 0x16A4651 VA: 0x16A4550
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x16A46D0 Offset: 0x16A47D1 VA: 0x16A46D0
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x16A4C80 Offset: 0x16A4D81 VA: 0x16A4C80
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x16A5160 Offset: 0x16A5261 VA: 0x16A5160
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[ExtensionAttribute] // RVA: 0xC13F0 Offset: 0xC14F1 VA: 0xC13F0
	// RVA: 0x16A5370 Offset: 0x16A5471 VA: 0x16A5370
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x16A35A0 Offset: 0x16A36A1 VA: 0x16A35A0
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x16A0E40 Offset: 0x16A0F41 VA: 0x16A0E40
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x16A1470 Offset: 0x16A1571 VA: 0x16A1470
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x16A53C0 Offset: 0x16A54C1 VA: 0x16A53C0
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x16A0D60 Offset: 0x16A0E61 VA: 0x16A0D60
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x16A53D0 Offset: 0x16A54D1 VA: 0x16A53D0
	public static bool ValidateType(Type type, string paramName, int index) { }

	// RVA: 0x16A57E0 Offset: 0x16A58E1 VA: 0x16A57E0
	private static Assembly get_MsCorLib() { }

	[ExtensionAttribute] // RVA: 0xC1400 Offset: 0xC1501 VA: 0xC1400
	// RVA: 0x16A2290 Offset: 0x16A2391 VA: 0x16A2290
	public static bool CanCache(Type t) { }

	[ExtensionAttribute] // RVA: 0xC1410 Offset: 0xC1511 VA: 0xC1410
	// RVA: 0x16A58B0 Offset: 0x16A59B1 VA: 0x16A58B0
	public static MethodInfo GetInvokeMethod(Type delegateType) { }
}

[ExtensionAttribute] // RVA: 0xBF1B0 Offset: 0xBF2B1 VA: 0xBF1B0
internal static class TypeUtils // TypeDefIndex: 2738
{
	// Fields
	private static Assembly s_mscorlib; // 0x0

	// Properties
	private static Assembly MsCorLib { get; }

	// Methods

	[ExtensionAttribute] // RVA: 0xC1300 Offset: 0xC1401 VA: 0xC1300
	// RVA: 0x16A2400 Offset: 0x16A2501 VA: 0x16A2400
	public static Type GetNonNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1310 Offset: 0xC1411 VA: 0xC1310
	// RVA: 0x16A2530 Offset: 0x16A2631 VA: 0x16A2530
	public static Type GetNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1320 Offset: 0xC1421 VA: 0xC1320
	// RVA: 0x16A2460 Offset: 0x16A2561 VA: 0x16A2460
	public static bool IsNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1330 Offset: 0xC1431 VA: 0xC1330
	// RVA: 0x16A2670 Offset: 0x16A2771 VA: 0x16A2670
	public static bool IsNullableOrReferenceType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1340 Offset: 0xC1441 VA: 0xC1340
	// RVA: 0x16A26C0 Offset: 0x16A27C1 VA: 0x16A26C0
	public static bool IsBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1350 Offset: 0xC1451 VA: 0xC1350
	// RVA: 0x16A2790 Offset: 0x16A2891 VA: 0x16A2790
	public static bool IsNumeric(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1360 Offset: 0xC1461 VA: 0xC1360
	// RVA: 0x16A28C0 Offset: 0x16A29C1 VA: 0x16A28C0
	public static bool IsInteger(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1370 Offset: 0xC1471 VA: 0xC1370
	// RVA: 0x16A29F0 Offset: 0x16A2AF1 VA: 0x16A29F0
	public static bool IsArithmetic(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1380 Offset: 0xC1481 VA: 0xC1380
	// RVA: 0x16A2B20 Offset: 0x16A2C21 VA: 0x16A2B20
	public static bool IsUnsignedInt(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1390 Offset: 0xC1491 VA: 0xC1390
	// RVA: 0x16A2C60 Offset: 0x16A2D61 VA: 0x16A2C60
	public static bool IsIntegerOrBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC13A0 Offset: 0xC14A1 VA: 0xC13A0
	// RVA: 0x16A2DA0 Offset: 0x16A2EA1 VA: 0x16A2DA0
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x16A2DE0 Offset: 0x16A2EE1 VA: 0x16A2DE0
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[ExtensionAttribute] // RVA: 0xC13B0 Offset: 0xC14B1 VA: 0xC13B0
	// RVA: 0x16A3240 Offset: 0x16A3341 VA: 0x16A3240
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13C0 Offset: 0xC14C1 VA: 0xC13C0
	// RVA: 0x16A3780 Offset: 0x16A3881 VA: 0x16A3780
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	// RVA: 0x16A3DC0 Offset: 0x16A3EC1 VA: 0x16A3DC0
	private static bool IsCovariant(Type t) { }

	// RVA: 0x16A3DF0 Offset: 0x16A3EF1 VA: 0x16A3DF0
	private static bool IsContravariant(Type t) { }

	// RVA: 0x16A3E20 Offset: 0x16A3F21 VA: 0x16A3E20
	private static bool IsInvariant(Type t) { }

	// RVA: 0x16A3E50 Offset: 0x16A3F51 VA: 0x16A3E50
	private static bool IsDelegate(Type t) { }

	// RVA: 0x16A39F0 Offset: 0x16A3AF1 VA: 0x16A39F0
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13D0 Offset: 0xC14D1 VA: 0xC13D0
	// RVA: 0x16A3650 Offset: 0x16A3751 VA: 0x16A3650
	public static bool IsConvertible(Type type) { }

	// RVA: 0x16A3EF0 Offset: 0x16A3FF1 VA: 0x16A3EF0
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x16A3FA0 Offset: 0x16A40A1 VA: 0x16A3FA0
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[ExtensionAttribute] // RVA: 0xC13E0 Offset: 0xC14E1 VA: 0xC13E0
	// RVA: 0x16A41D0 Offset: 0x16A42D1 VA: 0x16A41D0
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x16A4790 Offset: 0x16A4891 VA: 0x16A4790
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x16A4A20 Offset: 0x16A4B21 VA: 0x16A4A20
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x16A42D0 Offset: 0x16A43D1 VA: 0x16A42D0
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x16A4520 Offset: 0x16A4621 VA: 0x16A4520
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x16A4550 Offset: 0x16A4651 VA: 0x16A4550
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x16A46D0 Offset: 0x16A47D1 VA: 0x16A46D0
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x16A4C80 Offset: 0x16A4D81 VA: 0x16A4C80
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x16A5160 Offset: 0x16A5261 VA: 0x16A5160
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[ExtensionAttribute] // RVA: 0xC13F0 Offset: 0xC14F1 VA: 0xC13F0
	// RVA: 0x16A5370 Offset: 0x16A5471 VA: 0x16A5370
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x16A35A0 Offset: 0x16A36A1 VA: 0x16A35A0
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x16A0E40 Offset: 0x16A0F41 VA: 0x16A0E40
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x16A1470 Offset: 0x16A1571 VA: 0x16A1470
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x16A53C0 Offset: 0x16A54C1 VA: 0x16A53C0
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x16A0D60 Offset: 0x16A0E61 VA: 0x16A0D60
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x16A53D0 Offset: 0x16A54D1 VA: 0x16A53D0
	public static bool ValidateType(Type type, string paramName, int index) { }

	// RVA: 0x16A57E0 Offset: 0x16A58E1 VA: 0x16A57E0
	private static Assembly get_MsCorLib() { }

	[ExtensionAttribute] // RVA: 0xC1400 Offset: 0xC1501 VA: 0xC1400
	// RVA: 0x16A2290 Offset: 0x16A2391 VA: 0x16A2290
	public static bool CanCache(Type t) { }

	[ExtensionAttribute] // RVA: 0xC1410 Offset: 0xC1511 VA: 0xC1410
	// RVA: 0x16A58B0 Offset: 0x16A59B1 VA: 0x16A58B0
	public static MethodInfo GetInvokeMethod(Type delegateType) { }
}

[ExtensionAttribute] // RVA: 0xBF1B0 Offset: 0xBF2B1 VA: 0xBF1B0
internal static class TypeUtils // TypeDefIndex: 2738
{
	// Fields
	private static Assembly s_mscorlib; // 0x0

	// Properties
	private static Assembly MsCorLib { get; }

	// Methods

	[ExtensionAttribute] // RVA: 0xC1300 Offset: 0xC1401 VA: 0xC1300
	// RVA: 0x16A2400 Offset: 0x16A2501 VA: 0x16A2400
	public static Type GetNonNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1310 Offset: 0xC1411 VA: 0xC1310
	// RVA: 0x16A2530 Offset: 0x16A2631 VA: 0x16A2530
	public static Type GetNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1320 Offset: 0xC1421 VA: 0xC1320
	// RVA: 0x16A2460 Offset: 0x16A2561 VA: 0x16A2460
	public static bool IsNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1330 Offset: 0xC1431 VA: 0xC1330
	// RVA: 0x16A2670 Offset: 0x16A2771 VA: 0x16A2670
	public static bool IsNullableOrReferenceType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1340 Offset: 0xC1441 VA: 0xC1340
	// RVA: 0x16A26C0 Offset: 0x16A27C1 VA: 0x16A26C0
	public static bool IsBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1350 Offset: 0xC1451 VA: 0xC1350
	// RVA: 0x16A2790 Offset: 0x16A2891 VA: 0x16A2790
	public static bool IsNumeric(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1360 Offset: 0xC1461 VA: 0xC1360
	// RVA: 0x16A28C0 Offset: 0x16A29C1 VA: 0x16A28C0
	public static bool IsInteger(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1370 Offset: 0xC1471 VA: 0xC1370
	// RVA: 0x16A29F0 Offset: 0x16A2AF1 VA: 0x16A29F0
	public static bool IsArithmetic(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1380 Offset: 0xC1481 VA: 0xC1380
	// RVA: 0x16A2B20 Offset: 0x16A2C21 VA: 0x16A2B20
	public static bool IsUnsignedInt(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1390 Offset: 0xC1491 VA: 0xC1390
	// RVA: 0x16A2C60 Offset: 0x16A2D61 VA: 0x16A2C60
	public static bool IsIntegerOrBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC13A0 Offset: 0xC14A1 VA: 0xC13A0
	// RVA: 0x16A2DA0 Offset: 0x16A2EA1 VA: 0x16A2DA0
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x16A2DE0 Offset: 0x16A2EE1 VA: 0x16A2DE0
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[ExtensionAttribute] // RVA: 0xC13B0 Offset: 0xC14B1 VA: 0xC13B0
	// RVA: 0x16A3240 Offset: 0x16A3341 VA: 0x16A3240
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13C0 Offset: 0xC14C1 VA: 0xC13C0
	// RVA: 0x16A3780 Offset: 0x16A3881 VA: 0x16A3780
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	// RVA: 0x16A3DC0 Offset: 0x16A3EC1 VA: 0x16A3DC0
	private static bool IsCovariant(Type t) { }

	// RVA: 0x16A3DF0 Offset: 0x16A3EF1 VA: 0x16A3DF0
	private static bool IsContravariant(Type t) { }

	// RVA: 0x16A3E20 Offset: 0x16A3F21 VA: 0x16A3E20
	private static bool IsInvariant(Type t) { }

	// RVA: 0x16A3E50 Offset: 0x16A3F51 VA: 0x16A3E50
	private static bool IsDelegate(Type t) { }

	// RVA: 0x16A39F0 Offset: 0x16A3AF1 VA: 0x16A39F0
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13D0 Offset: 0xC14D1 VA: 0xC13D0
	// RVA: 0x16A3650 Offset: 0x16A3751 VA: 0x16A3650
	public static bool IsConvertible(Type type) { }

	// RVA: 0x16A3EF0 Offset: 0x16A3FF1 VA: 0x16A3EF0
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x16A3FA0 Offset: 0x16A40A1 VA: 0x16A3FA0
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[ExtensionAttribute] // RVA: 0xC13E0 Offset: 0xC14E1 VA: 0xC13E0
	// RVA: 0x16A41D0 Offset: 0x16A42D1 VA: 0x16A41D0
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x16A4790 Offset: 0x16A4891 VA: 0x16A4790
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x16A4A20 Offset: 0x16A4B21 VA: 0x16A4A20
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x16A42D0 Offset: 0x16A43D1 VA: 0x16A42D0
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x16A4520 Offset: 0x16A4621 VA: 0x16A4520
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x16A4550 Offset: 0x16A4651 VA: 0x16A4550
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x16A46D0 Offset: 0x16A47D1 VA: 0x16A46D0
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x16A4C80 Offset: 0x16A4D81 VA: 0x16A4C80
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x16A5160 Offset: 0x16A5261 VA: 0x16A5160
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[ExtensionAttribute] // RVA: 0xC13F0 Offset: 0xC14F1 VA: 0xC13F0
	// RVA: 0x16A5370 Offset: 0x16A5471 VA: 0x16A5370
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x16A35A0 Offset: 0x16A36A1 VA: 0x16A35A0
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x16A0E40 Offset: 0x16A0F41 VA: 0x16A0E40
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x16A1470 Offset: 0x16A1571 VA: 0x16A1470
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x16A53C0 Offset: 0x16A54C1 VA: 0x16A53C0
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x16A0D60 Offset: 0x16A0E61 VA: 0x16A0D60
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x16A53D0 Offset: 0x16A54D1 VA: 0x16A53D0
	public static bool ValidateType(Type type, string paramName, int index) { }

	// RVA: 0x16A57E0 Offset: 0x16A58E1 VA: 0x16A57E0
	private static Assembly get_MsCorLib() { }

	[ExtensionAttribute] // RVA: 0xC1400 Offset: 0xC1501 VA: 0xC1400
	// RVA: 0x16A2290 Offset: 0x16A2391 VA: 0x16A2290
	public static bool CanCache(Type t) { }

	[ExtensionAttribute] // RVA: 0xC1410 Offset: 0xC1511 VA: 0xC1410
	// RVA: 0x16A58B0 Offset: 0x16A59B1 VA: 0x16A58B0
	public static MethodInfo GetInvokeMethod(Type delegateType) { }
}

[ExtensionAttribute] // RVA: 0xBF1B0 Offset: 0xBF2B1 VA: 0xBF1B0
internal static class TypeUtils // TypeDefIndex: 2738
{
	// Fields
	private static Assembly s_mscorlib; // 0x0

	// Properties
	private static Assembly MsCorLib { get; }

	// Methods

	[ExtensionAttribute] // RVA: 0xC1300 Offset: 0xC1401 VA: 0xC1300
	// RVA: 0x16A2400 Offset: 0x16A2501 VA: 0x16A2400
	public static Type GetNonNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1310 Offset: 0xC1411 VA: 0xC1310
	// RVA: 0x16A2530 Offset: 0x16A2631 VA: 0x16A2530
	public static Type GetNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1320 Offset: 0xC1421 VA: 0xC1320
	// RVA: 0x16A2460 Offset: 0x16A2561 VA: 0x16A2460
	public static bool IsNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1330 Offset: 0xC1431 VA: 0xC1330
	// RVA: 0x16A2670 Offset: 0x16A2771 VA: 0x16A2670
	public static bool IsNullableOrReferenceType(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1340 Offset: 0xC1441 VA: 0xC1340
	// RVA: 0x16A26C0 Offset: 0x16A27C1 VA: 0x16A26C0
	public static bool IsBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1350 Offset: 0xC1451 VA: 0xC1350
	// RVA: 0x16A2790 Offset: 0x16A2891 VA: 0x16A2790
	public static bool IsNumeric(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1360 Offset: 0xC1461 VA: 0xC1360
	// RVA: 0x16A28C0 Offset: 0x16A29C1 VA: 0x16A28C0
	public static bool IsInteger(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1370 Offset: 0xC1471 VA: 0xC1370
	// RVA: 0x16A29F0 Offset: 0x16A2AF1 VA: 0x16A29F0
	public static bool IsArithmetic(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1380 Offset: 0xC1481 VA: 0xC1380
	// RVA: 0x16A2B20 Offset: 0x16A2C21 VA: 0x16A2B20
	public static bool IsUnsignedInt(Type type) { }

	[ExtensionAttribute] // RVA: 0xC1390 Offset: 0xC1491 VA: 0xC1390
	// RVA: 0x16A2C60 Offset: 0x16A2D61 VA: 0x16A2C60
	public static bool IsIntegerOrBool(Type type) { }

	[ExtensionAttribute] // RVA: 0xC13A0 Offset: 0xC14A1 VA: 0xC13A0
	// RVA: 0x16A2DA0 Offset: 0x16A2EA1 VA: 0x16A2DA0
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x16A2DE0 Offset: 0x16A2EE1 VA: 0x16A2DE0
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[ExtensionAttribute] // RVA: 0xC13B0 Offset: 0xC14B1 VA: 0xC13B0
	// RVA: 0x16A3240 Offset: 0x16A3341 VA: 0x16A3240
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13C0 Offset: 0xC14C1 VA: 0xC13C0
	// RVA: 0x16A3780 Offset: 0x16A3881 VA: 0x16A3780
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	// RVA: 0x16A3DC0 Offset: 0x16A3EC1 VA: 0x16A3DC0
	private static bool IsCovariant(Type t) { }

	// RVA: 0x16A3DF0 Offset: 0x16A3EF1 VA: 0x16A3DF0
	private static bool IsContravariant(Type t) { }

	// RVA: 0x16A3E20 Offset: 0x16A3F21 VA: 0x16A3E20
	private static bool IsInvariant(Type t) { }

	// RVA: 0x16A3E50 Offset: 0x16A3F51 VA: 0x16A3E50
	private static bool IsDelegate(Type t) { }

	// RVA: 0x16A39F0 Offset: 0x16A3AF1 VA: 0x16A39F0
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0xC13D0 Offset: 0xC14D1 VA: 0xC13D0
	// RVA: 0x16A3650 Offset: 0x16A3751 VA: 0x16A3650
	public static bool IsConvertible(Type type) { }

	// RVA: 0x16A3EF0 Offset: 0x16A3FF1 VA: 0x16A3EF0
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x16A3FA0 Offset: 0x16A40A1 VA: 0x16A3FA0
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[ExtensionAttribute] // RVA: 0xC13E0 Offset: 0xC14E1 VA: 0xC13E0
	// RVA: 0x16A41D0 Offset: 0x16A42D1 VA: 0x16A41D0
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x16A4790 Offset: 0x16A4891 VA: 0x16A4790
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x16A4A20 Offset: 0x16A4B21 VA: 0x16A4A20
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x16A42D0 Offset: 0x16A43D1 VA: 0x16A42D0
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x16A4520 Offset: 0x16A4621 VA: 0x16A4520
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x16A4550 Offset: 0x16A4651 VA: 0x16A4550
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x16A46D0 Offset: 0x16A47D1 VA: 0x16A46D0
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x16A4C80 Offset: 0x16A4D81 VA: 0x16A4C80
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x16A5160 Offset: 0x16A5261 VA: 0x16A5160
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[ExtensionAttribute] // RVA: 0xC13F0 Offset: 0xC14F1 VA: 0xC13F0
	// RVA: 0x16A5370 Offset: 0x16A5471 VA: 0x16A5370
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x16A35A0 Offset: 0x16A36A1 VA: 0x16A35A0
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x16A0E40 Offset: 0x16A0F41 VA: 0x16A0E40
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x16A1470 Offset: 0x16A1571 VA: 0x16A1470
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x16A53C0 Offset: 0x16A54C1 VA: 0x16A53C0
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x16A0D60 Offset: 0x16A0E61 VA: 0x16A0D60
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x16A53D0 Offset: 0x16A54D1 VA: 0x16A53D0
	public static bool ValidateType(Type type, string paramName, int index) { }

	// RVA: 0x16A57E0 Offset: 0x16A58E1 VA: 0x16A57E0
	private static Assembly get_MsCorLib() { }

	[ExtensionAttribute] // RVA: 0xC1400 Offset: 0xC1501 VA: 0xC1400
	// RVA: 0x16A2290 Offset: 0x16A2391 VA: 0x16A2290
	public static bool CanCache(Type t) { }

	[ExtensionAttribute] // RVA: 0xC1410 Offset: 0xC1511 VA: 0xC1410
	// RVA: 0x16A58B0 Offset: 0x16A59B1 VA: 0x16A58B0
	public static MethodInfo GetInvokeMethod(Type delegateType) { }
}

