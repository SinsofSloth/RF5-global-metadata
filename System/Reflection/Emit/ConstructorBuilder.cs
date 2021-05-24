public abstract class ConstructorBuilder : ConstructorInfo // TypeDefIndex: 614
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x195E010 Offset: 0x195E111 VA: 0x195E010 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x195E070 Offset: 0x195E171 VA: 0x195E070 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x195E0D0 Offset: 0x195E1D1 VA: 0x195E0D0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x195E130 Offset: 0x195E231 VA: 0x195E130
	public ILGenerator GetILGenerator() { }

	// RVA: 0x195E190 Offset: 0x195E291 VA: 0x195E190 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x195E1F0 Offset: 0x195E2F1 VA: 0x195E1F0 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x195E230 Offset: 0x195E331 VA: 0x195E230 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x195E270 Offset: 0x195E371 VA: 0x195E270 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x195E2B0 Offset: 0x195E3B1 VA: 0x195E2B0 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x195E2F0 Offset: 0x195E3F1 VA: 0x195E2F0 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x195E330 Offset: 0x195E431 VA: 0x195E330 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x195E370 Offset: 0x195E471 VA: 0x195E370 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x195E3B0 Offset: 0x195E4B1 VA: 0x195E3B0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

