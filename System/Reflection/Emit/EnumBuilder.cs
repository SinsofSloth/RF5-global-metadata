public abstract class EnumBuilder : TypeInfo // TypeDefIndex: 616
{
	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Guid GUID { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x195E730 Offset: 0x195E831 VA: 0x195E730 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x195E790 Offset: 0x195E891 VA: 0x195E790 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x195E7F0 Offset: 0x195E8F1 VA: 0x195E7F0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x195E850 Offset: 0x195E951 VA: 0x195E850 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x195E8B0 Offset: 0x195E9B1 VA: 0x195E8B0 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x195E910 Offset: 0x195EA11 VA: 0x195E910 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x195E970 Offset: 0x195EA71 VA: 0x195E970 Slot: 7
	public override string get_Name() { }

	// RVA: 0x195E9D0 Offset: 0x195EAD1 VA: 0x195E9D0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x195EA30 Offset: 0x195EB31 VA: 0x195EA30 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x195EA90 Offset: 0x195EB91 VA: 0x195EA90 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x195EAD0 Offset: 0x195EBD1 VA: 0x195EAD0 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x195EB10 Offset: 0x195EC11 VA: 0x195EB10 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0xB8550 Offset: 0xB8651 VA: 0xB8550
	// RVA: 0x195EB50 Offset: 0x195EC51 VA: 0x195EB50 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x195EB90 Offset: 0x195EC91 VA: 0x195EB90 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x195EBD0 Offset: 0x195ECD1 VA: 0x195EBD0 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x195EC10 Offset: 0x195ED11 VA: 0x195EC10 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195EC50 Offset: 0x195ED51 VA: 0x195EC50 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195EC90 Offset: 0x195ED91 VA: 0x195EC90 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x195ECD0 Offset: 0x195EDD1 VA: 0x195ECD0 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x195ED10 Offset: 0x195EE11 VA: 0x195ED10 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x195ED50 Offset: 0x195EE51 VA: 0x195ED50 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195ED90 Offset: 0x195EE91 VA: 0x195ED90 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x195EDD0 Offset: 0x195EED1 VA: 0x195EDD0 Slot: 55
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195EE10 Offset: 0x195EF11 VA: 0x195EE10 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x195EE50 Offset: 0x195EF51 VA: 0x195EE50 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195EE90 Offset: 0x195EF91 VA: 0x195EE90 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x195EED0 Offset: 0x195EFD1 VA: 0x195EED0 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x195EF10 Offset: 0x195F011 VA: 0x195EF10 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x195EF50 Offset: 0x195F051 VA: 0x195EF50 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x195EF90 Offset: 0x195F091 VA: 0x195EF90 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x195EFD0 Offset: 0x195F0D1 VA: 0x195EFD0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x195F010 Offset: 0x195F111 VA: 0x195F010 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x195F050 Offset: 0x195F151 VA: 0x195F050 Slot: 95
	protected override bool IsPrimitiveImpl() { }
}

