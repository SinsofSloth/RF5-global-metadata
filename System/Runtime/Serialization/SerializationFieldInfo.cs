internal sealed class SerializationFieldInfo : FieldInfo // TypeDefIndex: 1030
{
	// Fields
	private RuntimeFieldInfo m_field; // 0x10
	private string m_serializationName; // 0x18

	// Properties
	public override Module Module { get; }
	public override int MetadataToken { get; }
	public override string Name { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override Type FieldType { get; }
	internal RuntimeFieldInfo FieldInfo { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override FieldAttributes Attributes { get; }

	// Methods

	// RVA: 0x151EAE0 Offset: 0x151EBE1 VA: 0x151EAE0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x151EB10 Offset: 0x151EC11 VA: 0x151EB10 Slot: 14
	public override int get_MetadataToken() { }

	// RVA: 0x151EB40 Offset: 0x151EC41 VA: 0x151EB40
	internal void .ctor(RuntimeFieldInfo field, string namePrefix) { }

	// RVA: 0x151EBF0 Offset: 0x151ECF1 VA: 0x151EBF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x151EC00 Offset: 0x151ED01 VA: 0x151EC00 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x151EC20 Offset: 0x151ED21 VA: 0x151EC20 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x151EC40 Offset: 0x151ED41 VA: 0x151EC40 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x151EC70 Offset: 0x151ED71 VA: 0x151EC70 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x151ECA0 Offset: 0x151EDA1 VA: 0x151ECA0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x151ECD0 Offset: 0x151EDD1 VA: 0x151ECD0 Slot: 18
	public override Type get_FieldType() { }

	// RVA: 0x151ED00 Offset: 0x151EE01 VA: 0x151ED00 Slot: 19
	public override object GetValue(object obj) { }

	// RVA: 0x151ED30 Offset: 0x151EE31 VA: 0x151ED30
	internal object InternalGetValue(object obj) { }

	// RVA: 0x151EE20 Offset: 0x151EF21 VA: 0x151EE20 Slot: 27
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x151EE50 Offset: 0x151EF51 VA: 0x151EE50
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x151EF90 Offset: 0x151F091 VA: 0x151EF90
	internal RuntimeFieldInfo get_FieldInfo() { }

	// RVA: 0x151EFA0 Offset: 0x151F0A1 VA: 0x151EFA0 Slot: 17
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x151EFD0 Offset: 0x151F0D1 VA: 0x151EFD0 Slot: 16
	public override FieldAttributes get_Attributes() { }
}

