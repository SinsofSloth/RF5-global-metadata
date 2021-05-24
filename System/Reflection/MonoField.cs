[Serializable]
internal class MonoField : RtFieldInfo // TypeDefIndex: 592
{
	// Fields
	internal IntPtr klass; // 0x10
	internal RuntimeFieldHandle fhandle; // 0x18
	private string name; // 0x20
	private Type type; // 0x28
	private FieldAttributes attrs; // 0x30

	// Properties
	public override FieldAttributes Attributes { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x196D210 Offset: 0x196D311 VA: 0x196D210 Slot: 16
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x196D220 Offset: 0x196D321 VA: 0x196D220 Slot: 17
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x196D230 Offset: 0x196D331 VA: 0x196D230
	private Type ResolveType() { }

	// RVA: 0x196D240 Offset: 0x196D341 VA: 0x196D240 Slot: 18
	public override Type get_FieldType() { }

	// RVA: 0x196D2E0 Offset: 0x196D3E1 VA: 0x196D2E0
	private Type GetParentType(bool declaring) { }

	// RVA: 0x196D2F0 Offset: 0x196D3F1 VA: 0x196D2F0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x196D300 Offset: 0x196D401 VA: 0x196D300 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x196D310 Offset: 0x196D411 VA: 0x196D310 Slot: 7
	public override string get_Name() { }

	// RVA: 0x196D320 Offset: 0x196D421 VA: 0x196D320 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196D3A0 Offset: 0x196D4A1 VA: 0x196D3A0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x196D420 Offset: 0x196D521 VA: 0x196D420 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196D4A0 Offset: 0x196D5A1 VA: 0x196D4A0 Slot: 29
	internal override int GetFieldOffset() { }

	// RVA: 0x196D4B0 Offset: 0x196D5B1 VA: 0x196D4B0
	private object GetValueInternal(object obj) { }

	// RVA: 0x196D4C0 Offset: 0x196D5C1 VA: 0x196D4C0 Slot: 19
	public override object GetValue(object obj) { }

	// RVA: 0x196D720 Offset: 0x196D821 VA: 0x196D720 Slot: 3
	public override string ToString() { }

	// RVA: 0x196D790 Offset: 0x196D891 VA: 0x196D790
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x196D7A0 Offset: 0x196D8A1 VA: 0x196D7A0 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x196DA50 Offset: 0x196DB51 VA: 0x196DA50 Slot: 31
	public override object GetRawConstantValue() { }

	// RVA: 0x196DA60 Offset: 0x196DB61 VA: 0x196DA60 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x196D670 Offset: 0x196D771 VA: 0x196D670
	private void CheckGeneric() { }

	// RVA: 0x196DAD0 Offset: 0x196DBD1 VA: 0x196DAD0
	public void .ctor() { }
}

