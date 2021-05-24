public abstract class FieldBuilder : FieldInfo // TypeDefIndex: 618
{
	// Properties
	public override FieldAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override Type FieldType { get; }
	public override string Name { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x195F090 Offset: 0x195F191 VA: 0x195F090 Slot: 16
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x195F0F0 Offset: 0x195F1F1 VA: 0x195F0F0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x195F150 Offset: 0x195F251 VA: 0x195F150 Slot: 18
	public override Type get_FieldType() { }

	// RVA: 0x195F1B0 Offset: 0x195F2B1 VA: 0x195F1B0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x195F210 Offset: 0x195F311 VA: 0x195F210 Slot: 19
	public override object GetValue(object obj) { }

	// RVA: 0x195F270 Offset: 0x195F371 VA: 0x195F270 Slot: 17
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x195F2B0 Offset: 0x195F3B1 VA: 0x195F2B0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x195F2F0 Offset: 0x195F3F1 VA: 0x195F2F0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x195F330 Offset: 0x195F431 VA: 0x195F330 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x195F370 Offset: 0x195F471 VA: 0x195F370 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x195F3B0 Offset: 0x195F4B1 VA: 0x195F3B0 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }
}

