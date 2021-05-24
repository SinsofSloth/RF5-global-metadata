[Serializable]
internal sealed class MonoEvent : RuntimeEventInfo // TypeDefIndex: 589
{
	// Fields
	private IntPtr klass; // 0x18
	private IntPtr handle; // 0x20

	// Properties
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x196CC80 Offset: 0x196CD81 VA: 0x196CC80 Slot: 17
	public override MethodInfo GetAddMethod(bool nonPublic) { }

	// RVA: 0x196CD80 Offset: 0x196CE81 VA: 0x196CD80 Slot: 18
	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	// RVA: 0x196CE20 Offset: 0x196CF21 VA: 0x196CE20 Slot: 19
	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	// RVA: 0x196CEC0 Offset: 0x196CFC1 VA: 0x196CEC0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x196CF00 Offset: 0x196D001 VA: 0x196CF00 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x196CF40 Offset: 0x196D041 VA: 0x196CF40 Slot: 7
	public override string get_Name() { }

	// RVA: 0x196CF80 Offset: 0x196D081 VA: 0x196CF80 Slot: 3
	public override string ToString() { }

	// RVA: 0x196D000 Offset: 0x196D101 VA: 0x196D000 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196D080 Offset: 0x196D181 VA: 0x196D080 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x196D100 Offset: 0x196D201 VA: 0x196D100 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196D180 Offset: 0x196D281 VA: 0x196D180 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x196D1F0 Offset: 0x196D2F1 VA: 0x196D1F0
	public void .ctor() { }
}

