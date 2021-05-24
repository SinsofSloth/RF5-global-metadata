[ComVisibleAttribute] // RVA: 0xACF70 Offset: 0xAD071 VA: 0xACF70
[Serializable]
public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 402
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x118E0 Offset: 0x119E1 VA: 0x118E0
	internal void .ctor(IntPtr val) { }

	// RVA: 0x118F0 Offset: 0x119F1 VA: 0x118F0
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x11910 Offset: 0x11A11 VA: 0x11910
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11920 Offset: 0x11A21 VA: 0x11920
	public IntPtr get_Value() { }

	// RVA: 0x11930 Offset: 0x11A31 VA: 0x11930 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0xB74C0 Offset: 0xB75C1 VA: 0xB74C0
	// RVA: 0x11940 Offset: 0x11A41 VA: 0x11940 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB74E0 Offset: 0xB75E1 VA: 0xB74E0
	// RVA: 0x11950 Offset: 0x11A51 VA: 0x11950
	public bool Equals(RuntimeTypeHandle handle) { }

	// RVA: 0x11960 Offset: 0x11A61 VA: 0x11960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1942480 Offset: 0x1942581 VA: 0x1942480
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x1942490 Offset: 0x1942591 VA: 0x1942490
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x19424A0 Offset: 0x19425A1 VA: 0x19424A0
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x19424B0 Offset: 0x19425B1 VA: 0x19424B0
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x19424C0 Offset: 0x19425C1 VA: 0x19424C0
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x19424D0 Offset: 0x19425D1 VA: 0x19424D0
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x1942550 Offset: 0x1942651 VA: 0x1942550
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x1942520 Offset: 0x1942621 VA: 0x1942520
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x1942530 Offset: 0x1942631 VA: 0x1942530
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0x1942560 Offset: 0x1942661 VA: 0x1942560
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x1942570 Offset: 0x1942671 VA: 0x1942570
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x1942540 Offset: 0x1942641 VA: 0x1942540
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x1942580 Offset: 0x1942681 VA: 0x1942580
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x1942590 Offset: 0x1942691 VA: 0x1942590
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x19425A0 Offset: 0x19426A1 VA: 0x19425A0
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x19425B0 Offset: 0x19426B1 VA: 0x19425B0
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x1942640 Offset: 0x1942741 VA: 0x1942640
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x1942650 Offset: 0x1942751 VA: 0x1942650
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x19426B0 Offset: 0x19427B1 VA: 0x19426B0
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x19426E0 Offset: 0x19427E1 VA: 0x19426E0
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x19426F0 Offset: 0x19427F1 VA: 0x19426F0
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x1942700 Offset: 0x1942801 VA: 0x1942700
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x1942710 Offset: 0x1942811 VA: 0x1942710
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x1942720 Offset: 0x1942821 VA: 0x1942720
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x1942730 Offset: 0x1942831 VA: 0x1942730
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x1942740 Offset: 0x1942841 VA: 0x1942740
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x1942750 Offset: 0x1942851 VA: 0x1942750
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x1942760 Offset: 0x1942861 VA: 0x1942760
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1942770 Offset: 0x1942871 VA: 0x1942770
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }
}

[ComVisibleAttribute] // RVA: 0xACF70 Offset: 0xAD071 VA: 0xACF70
[Serializable]
public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 402
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x118E0 Offset: 0x119E1 VA: 0x118E0
	internal void .ctor(IntPtr val) { }

	// RVA: 0x118F0 Offset: 0x119F1 VA: 0x118F0
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x11910 Offset: 0x11A11 VA: 0x11910
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11920 Offset: 0x11A21 VA: 0x11920
	public IntPtr get_Value() { }

	// RVA: 0x11930 Offset: 0x11A31 VA: 0x11930 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0xB74C0 Offset: 0xB75C1 VA: 0xB74C0
	// RVA: 0x11940 Offset: 0x11A41 VA: 0x11940 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB74E0 Offset: 0xB75E1 VA: 0xB74E0
	// RVA: 0x11950 Offset: 0x11A51 VA: 0x11950
	public bool Equals(RuntimeTypeHandle handle) { }

	// RVA: 0x11960 Offset: 0x11A61 VA: 0x11960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1942480 Offset: 0x1942581 VA: 0x1942480
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x1942490 Offset: 0x1942591 VA: 0x1942490
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x19424A0 Offset: 0x19425A1 VA: 0x19424A0
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x19424B0 Offset: 0x19425B1 VA: 0x19424B0
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x19424C0 Offset: 0x19425C1 VA: 0x19424C0
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x19424D0 Offset: 0x19425D1 VA: 0x19424D0
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x1942550 Offset: 0x1942651 VA: 0x1942550
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x1942520 Offset: 0x1942621 VA: 0x1942520
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x1942530 Offset: 0x1942631 VA: 0x1942530
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0x1942560 Offset: 0x1942661 VA: 0x1942560
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x1942570 Offset: 0x1942671 VA: 0x1942570
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x1942540 Offset: 0x1942641 VA: 0x1942540
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x1942580 Offset: 0x1942681 VA: 0x1942580
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x1942590 Offset: 0x1942691 VA: 0x1942590
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x19425A0 Offset: 0x19426A1 VA: 0x19425A0
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x19425B0 Offset: 0x19426B1 VA: 0x19425B0
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x1942640 Offset: 0x1942741 VA: 0x1942640
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x1942650 Offset: 0x1942751 VA: 0x1942650
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x19426B0 Offset: 0x19427B1 VA: 0x19426B0
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x19426E0 Offset: 0x19427E1 VA: 0x19426E0
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x19426F0 Offset: 0x19427F1 VA: 0x19426F0
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x1942700 Offset: 0x1942801 VA: 0x1942700
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x1942710 Offset: 0x1942811 VA: 0x1942710
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x1942720 Offset: 0x1942821 VA: 0x1942720
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x1942730 Offset: 0x1942831 VA: 0x1942730
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x1942740 Offset: 0x1942841 VA: 0x1942740
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x1942750 Offset: 0x1942851 VA: 0x1942750
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x1942760 Offset: 0x1942861 VA: 0x1942760
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1942770 Offset: 0x1942871 VA: 0x1942770
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }
}

[ComVisibleAttribute] // RVA: 0xACF70 Offset: 0xAD071 VA: 0xACF70
[Serializable]
public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 402
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x118E0 Offset: 0x119E1 VA: 0x118E0
	internal void .ctor(IntPtr val) { }

	// RVA: 0x118F0 Offset: 0x119F1 VA: 0x118F0
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x11910 Offset: 0x11A11 VA: 0x11910
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11920 Offset: 0x11A21 VA: 0x11920
	public IntPtr get_Value() { }

	// RVA: 0x11930 Offset: 0x11A31 VA: 0x11930 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0xB74C0 Offset: 0xB75C1 VA: 0xB74C0
	// RVA: 0x11940 Offset: 0x11A41 VA: 0x11940 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB74E0 Offset: 0xB75E1 VA: 0xB74E0
	// RVA: 0x11950 Offset: 0x11A51 VA: 0x11950
	public bool Equals(RuntimeTypeHandle handle) { }

	// RVA: 0x11960 Offset: 0x11A61 VA: 0x11960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1942480 Offset: 0x1942581 VA: 0x1942480
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x1942490 Offset: 0x1942591 VA: 0x1942490
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x19424A0 Offset: 0x19425A1 VA: 0x19424A0
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x19424B0 Offset: 0x19425B1 VA: 0x19424B0
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x19424C0 Offset: 0x19425C1 VA: 0x19424C0
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x19424D0 Offset: 0x19425D1 VA: 0x19424D0
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x1942550 Offset: 0x1942651 VA: 0x1942550
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x1942520 Offset: 0x1942621 VA: 0x1942520
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x1942530 Offset: 0x1942631 VA: 0x1942530
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0x1942560 Offset: 0x1942661 VA: 0x1942560
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x1942570 Offset: 0x1942671 VA: 0x1942570
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x1942540 Offset: 0x1942641 VA: 0x1942540
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x1942580 Offset: 0x1942681 VA: 0x1942580
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x1942590 Offset: 0x1942691 VA: 0x1942590
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x19425A0 Offset: 0x19426A1 VA: 0x19425A0
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x19425B0 Offset: 0x19426B1 VA: 0x19425B0
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x1942640 Offset: 0x1942741 VA: 0x1942640
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x1942650 Offset: 0x1942751 VA: 0x1942650
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x19426B0 Offset: 0x19427B1 VA: 0x19426B0
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x19426E0 Offset: 0x19427E1 VA: 0x19426E0
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x19426F0 Offset: 0x19427F1 VA: 0x19426F0
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x1942700 Offset: 0x1942801 VA: 0x1942700
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x1942710 Offset: 0x1942811 VA: 0x1942710
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x1942720 Offset: 0x1942821 VA: 0x1942720
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x1942730 Offset: 0x1942831 VA: 0x1942730
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x1942740 Offset: 0x1942841 VA: 0x1942740
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x1942750 Offset: 0x1942851 VA: 0x1942750
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x1942760 Offset: 0x1942861 VA: 0x1942760
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1942770 Offset: 0x1942871 VA: 0x1942770
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }
}

[ComVisibleAttribute] // RVA: 0xACF70 Offset: 0xAD071 VA: 0xACF70
[Serializable]
public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 402
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x118E0 Offset: 0x119E1 VA: 0x118E0
	internal void .ctor(IntPtr val) { }

	// RVA: 0x118F0 Offset: 0x119F1 VA: 0x118F0
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x11910 Offset: 0x11A11 VA: 0x11910
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11920 Offset: 0x11A21 VA: 0x11920
	public IntPtr get_Value() { }

	// RVA: 0x11930 Offset: 0x11A31 VA: 0x11930 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0xB74C0 Offset: 0xB75C1 VA: 0xB74C0
	// RVA: 0x11940 Offset: 0x11A41 VA: 0x11940 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB74E0 Offset: 0xB75E1 VA: 0xB74E0
	// RVA: 0x11950 Offset: 0x11A51 VA: 0x11950
	public bool Equals(RuntimeTypeHandle handle) { }

	// RVA: 0x11960 Offset: 0x11A61 VA: 0x11960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1942480 Offset: 0x1942581 VA: 0x1942480
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x1942490 Offset: 0x1942591 VA: 0x1942490
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x19424A0 Offset: 0x19425A1 VA: 0x19424A0
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x19424B0 Offset: 0x19425B1 VA: 0x19424B0
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x19424C0 Offset: 0x19425C1 VA: 0x19424C0
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x19424D0 Offset: 0x19425D1 VA: 0x19424D0
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x1942550 Offset: 0x1942651 VA: 0x1942550
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x1942520 Offset: 0x1942621 VA: 0x1942520
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x1942530 Offset: 0x1942631 VA: 0x1942530
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0x1942560 Offset: 0x1942661 VA: 0x1942560
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x1942570 Offset: 0x1942671 VA: 0x1942570
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x1942540 Offset: 0x1942641 VA: 0x1942540
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x1942580 Offset: 0x1942681 VA: 0x1942580
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x1942590 Offset: 0x1942691 VA: 0x1942590
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x19425A0 Offset: 0x19426A1 VA: 0x19425A0
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x19425B0 Offset: 0x19426B1 VA: 0x19425B0
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x1942640 Offset: 0x1942741 VA: 0x1942640
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x1942650 Offset: 0x1942751 VA: 0x1942650
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x19426B0 Offset: 0x19427B1 VA: 0x19426B0
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x19426E0 Offset: 0x19427E1 VA: 0x19426E0
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x19426F0 Offset: 0x19427F1 VA: 0x19426F0
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x1942700 Offset: 0x1942801 VA: 0x1942700
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x1942710 Offset: 0x1942811 VA: 0x1942710
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x1942720 Offset: 0x1942821 VA: 0x1942720
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x1942730 Offset: 0x1942831 VA: 0x1942730
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x1942740 Offset: 0x1942841 VA: 0x1942740
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x1942750 Offset: 0x1942851 VA: 0x1942750
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x1942760 Offset: 0x1942861 VA: 0x1942760
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1942770 Offset: 0x1942871 VA: 0x1942770
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }
}

[ComVisibleAttribute] // RVA: 0xACF70 Offset: 0xAD071 VA: 0xACF70
[Serializable]
public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 402
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x118E0 Offset: 0x119E1 VA: 0x118E0
	internal void .ctor(IntPtr val) { }

	// RVA: 0x118F0 Offset: 0x119F1 VA: 0x118F0
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x11910 Offset: 0x11A11 VA: 0x11910
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11920 Offset: 0x11A21 VA: 0x11920
	public IntPtr get_Value() { }

	// RVA: 0x11930 Offset: 0x11A31 VA: 0x11930 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0xB74C0 Offset: 0xB75C1 VA: 0xB74C0
	// RVA: 0x11940 Offset: 0x11A41 VA: 0x11940 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB74E0 Offset: 0xB75E1 VA: 0xB74E0
	// RVA: 0x11950 Offset: 0x11A51 VA: 0x11950
	public bool Equals(RuntimeTypeHandle handle) { }

	// RVA: 0x11960 Offset: 0x11A61 VA: 0x11960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1942480 Offset: 0x1942581 VA: 0x1942480
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x1942490 Offset: 0x1942591 VA: 0x1942490
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x19424A0 Offset: 0x19425A1 VA: 0x19424A0
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x19424B0 Offset: 0x19425B1 VA: 0x19424B0
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x19424C0 Offset: 0x19425C1 VA: 0x19424C0
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x19424D0 Offset: 0x19425D1 VA: 0x19424D0
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x1942550 Offset: 0x1942651 VA: 0x1942550
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x1942520 Offset: 0x1942621 VA: 0x1942520
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x1942530 Offset: 0x1942631 VA: 0x1942530
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0x1942560 Offset: 0x1942661 VA: 0x1942560
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x1942570 Offset: 0x1942671 VA: 0x1942570
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x1942540 Offset: 0x1942641 VA: 0x1942540
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x1942580 Offset: 0x1942681 VA: 0x1942580
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x1942590 Offset: 0x1942691 VA: 0x1942590
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x19425A0 Offset: 0x19426A1 VA: 0x19425A0
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x19425B0 Offset: 0x19426B1 VA: 0x19425B0
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x1942640 Offset: 0x1942741 VA: 0x1942640
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x1942650 Offset: 0x1942751 VA: 0x1942650
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x19426B0 Offset: 0x19427B1 VA: 0x19426B0
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x19426E0 Offset: 0x19427E1 VA: 0x19426E0
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x19426F0 Offset: 0x19427F1 VA: 0x19426F0
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x1942700 Offset: 0x1942801 VA: 0x1942700
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x1942710 Offset: 0x1942811 VA: 0x1942710
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x1942720 Offset: 0x1942821 VA: 0x1942720
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x1942730 Offset: 0x1942831 VA: 0x1942730
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x1942740 Offset: 0x1942841 VA: 0x1942740
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x1942750 Offset: 0x1942851 VA: 0x1942750
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x1942760 Offset: 0x1942861 VA: 0x1942760
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1942770 Offset: 0x1942871 VA: 0x1942770
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }
}

[ComVisibleAttribute] // RVA: 0xACF70 Offset: 0xAD071 VA: 0xACF70
[Serializable]
public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 402
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x118E0 Offset: 0x119E1 VA: 0x118E0
	internal void .ctor(IntPtr val) { }

	// RVA: 0x118F0 Offset: 0x119F1 VA: 0x118F0
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x11910 Offset: 0x11A11 VA: 0x11910
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11920 Offset: 0x11A21 VA: 0x11920
	public IntPtr get_Value() { }

	// RVA: 0x11930 Offset: 0x11A31 VA: 0x11930 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0xB74C0 Offset: 0xB75C1 VA: 0xB74C0
	// RVA: 0x11940 Offset: 0x11A41 VA: 0x11940 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB74E0 Offset: 0xB75E1 VA: 0xB74E0
	// RVA: 0x11950 Offset: 0x11A51 VA: 0x11950
	public bool Equals(RuntimeTypeHandle handle) { }

	// RVA: 0x11960 Offset: 0x11A61 VA: 0x11960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1942480 Offset: 0x1942581 VA: 0x1942480
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x1942490 Offset: 0x1942591 VA: 0x1942490
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x19424A0 Offset: 0x19425A1 VA: 0x19424A0
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x19424B0 Offset: 0x19425B1 VA: 0x19424B0
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x19424C0 Offset: 0x19425C1 VA: 0x19424C0
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x19424D0 Offset: 0x19425D1 VA: 0x19424D0
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x1942550 Offset: 0x1942651 VA: 0x1942550
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x1942520 Offset: 0x1942621 VA: 0x1942520
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x1942530 Offset: 0x1942631 VA: 0x1942530
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0x1942560 Offset: 0x1942661 VA: 0x1942560
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x1942570 Offset: 0x1942671 VA: 0x1942570
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x1942540 Offset: 0x1942641 VA: 0x1942540
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x1942580 Offset: 0x1942681 VA: 0x1942580
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x1942590 Offset: 0x1942691 VA: 0x1942590
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x19425A0 Offset: 0x19426A1 VA: 0x19425A0
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x19425B0 Offset: 0x19426B1 VA: 0x19425B0
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x1942640 Offset: 0x1942741 VA: 0x1942640
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x1942650 Offset: 0x1942751 VA: 0x1942650
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x19426B0 Offset: 0x19427B1 VA: 0x19426B0
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x19426E0 Offset: 0x19427E1 VA: 0x19426E0
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x19426F0 Offset: 0x19427F1 VA: 0x19426F0
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x1942700 Offset: 0x1942801 VA: 0x1942700
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x1942710 Offset: 0x1942811 VA: 0x1942710
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x1942720 Offset: 0x1942821 VA: 0x1942720
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x1942730 Offset: 0x1942831 VA: 0x1942730
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x1942740 Offset: 0x1942841 VA: 0x1942740
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x1942750 Offset: 0x1942851 VA: 0x1942750
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x1942760 Offset: 0x1942861 VA: 0x1942760
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1942770 Offset: 0x1942871 VA: 0x1942770
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }
}

[ComVisibleAttribute] // RVA: 0xACF70 Offset: 0xAD071 VA: 0xACF70
[Serializable]
public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 402
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x118E0 Offset: 0x119E1 VA: 0x118E0
	internal void .ctor(IntPtr val) { }

	// RVA: 0x118F0 Offset: 0x119F1 VA: 0x118F0
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x11910 Offset: 0x11A11 VA: 0x11910
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11920 Offset: 0x11A21 VA: 0x11920
	public IntPtr get_Value() { }

	// RVA: 0x11930 Offset: 0x11A31 VA: 0x11930 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0xB74C0 Offset: 0xB75C1 VA: 0xB74C0
	// RVA: 0x11940 Offset: 0x11A41 VA: 0x11940 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB74E0 Offset: 0xB75E1 VA: 0xB74E0
	// RVA: 0x11950 Offset: 0x11A51 VA: 0x11950
	public bool Equals(RuntimeTypeHandle handle) { }

	// RVA: 0x11960 Offset: 0x11A61 VA: 0x11960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1942480 Offset: 0x1942581 VA: 0x1942480
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x1942490 Offset: 0x1942591 VA: 0x1942490
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x19424A0 Offset: 0x19425A1 VA: 0x19424A0
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x19424B0 Offset: 0x19425B1 VA: 0x19424B0
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x19424C0 Offset: 0x19425C1 VA: 0x19424C0
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x19424D0 Offset: 0x19425D1 VA: 0x19424D0
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x1942550 Offset: 0x1942651 VA: 0x1942550
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x1942520 Offset: 0x1942621 VA: 0x1942520
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x1942530 Offset: 0x1942631 VA: 0x1942530
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0x1942560 Offset: 0x1942661 VA: 0x1942560
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x1942570 Offset: 0x1942671 VA: 0x1942570
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x1942540 Offset: 0x1942641 VA: 0x1942540
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x1942580 Offset: 0x1942681 VA: 0x1942580
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x1942590 Offset: 0x1942691 VA: 0x1942590
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x19425A0 Offset: 0x19426A1 VA: 0x19425A0
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x19425B0 Offset: 0x19426B1 VA: 0x19425B0
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x1942640 Offset: 0x1942741 VA: 0x1942640
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x1942650 Offset: 0x1942751 VA: 0x1942650
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x19426B0 Offset: 0x19427B1 VA: 0x19426B0
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x19426E0 Offset: 0x19427E1 VA: 0x19426E0
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x19426F0 Offset: 0x19427F1 VA: 0x19426F0
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x1942700 Offset: 0x1942801 VA: 0x1942700
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x1942710 Offset: 0x1942811 VA: 0x1942710
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x1942720 Offset: 0x1942821 VA: 0x1942720
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x1942730 Offset: 0x1942831 VA: 0x1942730
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x1942740 Offset: 0x1942841 VA: 0x1942740
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x1942750 Offset: 0x1942851 VA: 0x1942750
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x1942760 Offset: 0x1942861 VA: 0x1942760
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1942770 Offset: 0x1942871 VA: 0x1942770
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }
}

