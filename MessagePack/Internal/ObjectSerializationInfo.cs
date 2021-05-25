internal class ObjectSerializationInfo // TypeDefIndex: 5334
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x139A10 Offset: 0x139B11 VA: 0x139A10
	private Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139A20 Offset: 0x139B21 VA: 0x139A20
	private bool <IsIntKey>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139A30 Offset: 0x139B31 VA: 0x139A30
	private bool <IsClass>k__BackingField; // 0x19
	[CompilerGeneratedAttribute] // RVA: 0x139A40 Offset: 0x139B41 VA: 0x139A40
	private ConstructorInfo <BestmatchConstructor>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x139A50 Offset: 0x139B51 VA: 0x139A50
	private ObjectSerializationInfo.EmittableMemberAndConstructorParameter[] <ConstructorParameters>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x139A60 Offset: 0x139B61 VA: 0x139A60
	private ObjectSerializationInfo.EmittableMember[] <Members>k__BackingField; // 0x30

	// Properties
	public Type Type { get; set; }
	public bool IsIntKey { get; set; }
	public bool IsStringKey { get; }
	public bool IsClass { get; set; }
	public bool IsStruct { get; }
	public ConstructorInfo BestmatchConstructor { get; set; }
	public ObjectSerializationInfo.EmittableMemberAndConstructorParameter[] ConstructorParameters { get; set; }
	public ObjectSerializationInfo.EmittableMember[] Members { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x13A930 Offset: 0x13AA31 VA: 0x13A930
	// RVA: 0x1680D90 Offset: 0x1680E91 VA: 0x1680D90
	public Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A940 Offset: 0x13AA41 VA: 0x13A940
	// RVA: 0x1680DA0 Offset: 0x1680EA1 VA: 0x1680DA0
	public void set_Type(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A950 Offset: 0x13AA51 VA: 0x13A950
	// RVA: 0x1680DB0 Offset: 0x1680EB1 VA: 0x1680DB0
	public bool get_IsIntKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A960 Offset: 0x13AA61 VA: 0x13A960
	// RVA: 0x1680DC0 Offset: 0x1680EC1 VA: 0x1680DC0
	public void set_IsIntKey(bool value) { }

	// RVA: 0x1672020 Offset: 0x1672121 VA: 0x1672020
	public bool get_IsStringKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A970 Offset: 0x13AA71 VA: 0x13A970
	// RVA: 0x1680DD0 Offset: 0x1680ED1 VA: 0x1680DD0
	public bool get_IsClass() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A980 Offset: 0x13AA81 VA: 0x13A980
	// RVA: 0x1680DE0 Offset: 0x1680EE1 VA: 0x1680DE0
	public void set_IsClass(bool value) { }

	// RVA: 0x16765B0 Offset: 0x16766B1 VA: 0x16765B0
	public bool get_IsStruct() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A990 Offset: 0x13AA91 VA: 0x13A990
	// RVA: 0x1680DF0 Offset: 0x1680EF1 VA: 0x1680DF0
	public ConstructorInfo get_BestmatchConstructor() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A9A0 Offset: 0x13AAA1 VA: 0x13A9A0
	// RVA: 0x1680E00 Offset: 0x1680F01 VA: 0x1680E00
	public void set_BestmatchConstructor(ConstructorInfo value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A9B0 Offset: 0x13AAB1 VA: 0x13A9B0
	// RVA: 0x1680E10 Offset: 0x1680F11 VA: 0x1680E10
	public ObjectSerializationInfo.EmittableMemberAndConstructorParameter[] get_ConstructorParameters() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A9C0 Offset: 0x13AAC1 VA: 0x13A9C0
	// RVA: 0x1680E20 Offset: 0x1680F21 VA: 0x1680E20
	public void set_ConstructorParameters(ObjectSerializationInfo.EmittableMemberAndConstructorParameter[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A9D0 Offset: 0x13AAD1 VA: 0x13A9D0
	// RVA: 0x1680E30 Offset: 0x1680F31 VA: 0x1680E30
	public ObjectSerializationInfo.EmittableMember[] get_Members() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A9E0 Offset: 0x13AAE1 VA: 0x13A9E0
	// RVA: 0x1680E40 Offset: 0x1680F41 VA: 0x1680E40
	public void set_Members(ObjectSerializationInfo.EmittableMember[] value) { }

	// RVA: 0x1680E50 Offset: 0x1680F51 VA: 0x1680E50
	private void .ctor() { }

	// RVA: 0x166E2A0 Offset: 0x166E3A1 VA: 0x166E2A0
	public static ObjectSerializationInfo CreateOrNull(Type type, bool forceStringKey, bool contractless, bool allowPrivate) { }

	[IteratorStateMachineAttribute] // RVA: 0x13A9F0 Offset: 0x13AAF1 VA: 0x13A9F0
	// RVA: 0x1680EE0 Offset: 0x1680FE1 VA: 0x1680EE0
	private static IEnumerable<FieldInfo> GetAllFields(Type type) { }

	[IteratorStateMachineAttribute] // RVA: 0x13AA60 Offset: 0x13AB61 VA: 0x13AA60
	// RVA: 0x1680E60 Offset: 0x1680F61 VA: 0x1680E60
	private static IEnumerable<PropertyInfo> GetAllProperties(Type type) { }

	// RVA: 0x1680F60 Offset: 0x1681061 VA: 0x1680F60
	private static bool TryGetNextConstructor(IEnumerator<ConstructorInfo> ctorEnumerator, ref ConstructorInfo ctor) { }
}

