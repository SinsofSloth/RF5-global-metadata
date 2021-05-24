[ComVisibleAttribute] // RVA: 0xB4160 Offset: 0xB4261 VA: 0xB4160
public sealed class DynamicMethod : MethodInfo // TypeDefIndex: 1532
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override string Name { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x195E3F0 Offset: 0x195E4F1 VA: 0x195E3F0
	public void .ctor(string name, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility) { }

	// RVA: 0x195E430 Offset: 0x195E531 VA: 0x195E430 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x195E470 Offset: 0x195E571 VA: 0x195E470 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x195E4B0 Offset: 0x195E5B1 VA: 0x195E4B0 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x195E4F0 Offset: 0x195E5F1 VA: 0x195E4F0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x195E530 Offset: 0x195E631 VA: 0x195E530 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x195E570 Offset: 0x195E671 VA: 0x195E570 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x195E5B0 Offset: 0x195E6B1 VA: 0x195E5B0 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x195E5F0 Offset: 0x195E6F1 VA: 0x195E5F0
	public ILGenerator GetILGenerator() { }

	// RVA: 0x195E630 Offset: 0x195E731 VA: 0x195E630 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x195E670 Offset: 0x195E771 VA: 0x195E670 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x195E6B0 Offset: 0x195E7B1 VA: 0x195E6B0 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x195E6F0 Offset: 0x195E7F1 VA: 0x195E6F0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

