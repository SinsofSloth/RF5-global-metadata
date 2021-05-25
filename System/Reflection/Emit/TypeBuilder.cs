public abstract class TypeBuilder : TypeInfo // TypeDefIndex: 631
{
	// Fields
	public const int UnspecifiedTypeSize = 0;

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

	// RVA: 0x19667E0 Offset: 0x19668E1 VA: 0x19667E0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x1966840 Offset: 0x1966941 VA: 0x1966840 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x19668A0 Offset: 0x19669A1 VA: 0x19668A0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x1966900 Offset: 0x1966A01 VA: 0x1966900 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x1966960 Offset: 0x1966A61 VA: 0x1966960 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x19669C0 Offset: 0x1966AC1 VA: 0x19669C0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x1966A20 Offset: 0x1966B21 VA: 0x1966A20 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1966A80 Offset: 0x1966B81 VA: 0x1966A80 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x1966AE0 Offset: 0x1966BE1 VA: 0x1966AE0
	public TypeInfo CreateTypeInfo() { }

	// RVA: 0x1966B40 Offset: 0x1966C41 VA: 0x1966B40
	public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes) { }

	// RVA: 0x1966BA0 Offset: 0x1966CA1 VA: 0x1966BA0
	public FieldBuilder DefineField(string fieldName, Type type, FieldAttributes attributes) { }

	// RVA: 0x1966C00 Offset: 0x1966D01 VA: 0x1966C00
	public MethodBuilder DefineMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes) { }

	// RVA: 0x1966C60 Offset: 0x1966D61 VA: 0x1966C60 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x1966CC0 Offset: 0x1966DC1 VA: 0x1966CC0 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1966D00 Offset: 0x1966E01 VA: 0x1966D00 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1966D40 Offset: 0x1966E41 VA: 0x1966D40 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0xB85B0 Offset: 0xB86B1 VA: 0xB85B0
	// RVA: 0x1966D80 Offset: 0x1966E81 VA: 0x1966D80 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1966DC0 Offset: 0x1966EC1 VA: 0x1966DC0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1966E00 Offset: 0x1966F01 VA: 0x1966E00 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1966E40 Offset: 0x1966F41 VA: 0x1966E40 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1966E80 Offset: 0x1966F81 VA: 0x1966E80 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1966EC0 Offset: 0x1966FC1 VA: 0x1966EC0 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1966F00 Offset: 0x1967001 VA: 0x1966F00 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x1966F40 Offset: 0x1967041 VA: 0x1966F40 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1966F80 Offset: 0x1967081 VA: 0x1966F80 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1966FC0 Offset: 0x19670C1 VA: 0x1966FC0 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x1967000 Offset: 0x1967101 VA: 0x1967000 Slot: 55
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1967040 Offset: 0x1967141 VA: 0x1967040 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1967080 Offset: 0x1967181 VA: 0x1967080 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x19670C0 Offset: 0x19671C1 VA: 0x19670C0 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1967100 Offset: 0x1967201 VA: 0x1967100 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x1967140 Offset: 0x1967241 VA: 0x1967140 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x1967180 Offset: 0x1967281 VA: 0x1967180 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x19671C0 Offset: 0x19672C1 VA: 0x19671C0 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x1967200 Offset: 0x1967301 VA: 0x1967200 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1967240 Offset: 0x1967341 VA: 0x1967240 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x1967280 Offset: 0x1967381 VA: 0x1967280 Slot: 95
	protected override bool IsPrimitiveImpl() { }
}

