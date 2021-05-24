public abstract class PropertyBuilder : PropertyInfo // TypeDefIndex: 629
{
	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x1966300 Offset: 0x1966401 VA: 0x1966300 Slot: 16
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x1966360 Offset: 0x1966461 VA: 0x1966360 Slot: 17
	public override bool get_CanRead() { }

	// RVA: 0x19663C0 Offset: 0x19664C1 VA: 0x19663C0 Slot: 18
	public override bool get_CanWrite() { }

	// RVA: 0x1966420 Offset: 0x1966521 VA: 0x1966420 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x1966480 Offset: 0x1966581 VA: 0x1966480 Slot: 7
	public override string get_Name() { }

	// RVA: 0x19664E0 Offset: 0x19665E1 VA: 0x19664E0 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x1966540 Offset: 0x1966641 VA: 0x1966540 Slot: 25
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x19665A0 Offset: 0x19666A1 VA: 0x19665A0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x19665E0 Offset: 0x19666E1 VA: 0x19665E0 Slot: 22
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x1966620 Offset: 0x1966721 VA: 0x1966620 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1966660 Offset: 0x1966761 VA: 0x1966660 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x19666A0 Offset: 0x19667A1 VA: 0x19666A0 Slot: 24
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x19666E0 Offset: 0x19667E1 VA: 0x19666E0 Slot: 27
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x1966720 Offset: 0x1966821 VA: 0x1966720 Slot: 29
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x1966760 Offset: 0x1966861 VA: 0x1966760 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x19667A0 Offset: 0x19668A1 VA: 0x19667A0 Slot: 31
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }
}

