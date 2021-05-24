public abstract class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 619
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

	// RVA: 0x195F3F0 Offset: 0x195F4F1 VA: 0x195F3F0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x195F450 Offset: 0x195F551 VA: 0x195F450 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x195F4B0 Offset: 0x195F5B1 VA: 0x195F4B0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x195F510 Offset: 0x195F611 VA: 0x195F510 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x195F570 Offset: 0x195F671 VA: 0x195F570 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x195F5D0 Offset: 0x195F6D1 VA: 0x195F5D0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x195F630 Offset: 0x195F731 VA: 0x195F630 Slot: 7
	public override string get_Name() { }

	// RVA: 0x195F690 Offset: 0x195F791 VA: 0x195F690 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x195F6F0 Offset: 0x195F7F1 VA: 0x195F6F0 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x195F750 Offset: 0x195F851 VA: 0x195F750 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x195F790 Offset: 0x195F891 VA: 0x195F790 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x195F7D0 Offset: 0x195F8D1 VA: 0x195F7D0 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0xB8570 Offset: 0xB8671 VA: 0xB8570
	// RVA: 0x195F810 Offset: 0x195F911 VA: 0x195F810 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x195F850 Offset: 0x195F951 VA: 0x195F850 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x195F890 Offset: 0x195F991 VA: 0x195F890 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x195F8D0 Offset: 0x195F9D1 VA: 0x195F8D0 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195F910 Offset: 0x195FA11 VA: 0x195F910 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195F950 Offset: 0x195FA51 VA: 0x195F950 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x195F990 Offset: 0x195FA91 VA: 0x195F990 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x195F9D0 Offset: 0x195FAD1 VA: 0x195F9D0 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x195FA10 Offset: 0x195FB11 VA: 0x195FA10 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195FA50 Offset: 0x195FB51 VA: 0x195FA50 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x195FA90 Offset: 0x195FB91 VA: 0x195FA90 Slot: 55
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195FAD0 Offset: 0x195FBD1 VA: 0x195FAD0 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x195FB10 Offset: 0x195FC11 VA: 0x195FB10 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195FB50 Offset: 0x195FC51 VA: 0x195FB50 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x195FB90 Offset: 0x195FC91 VA: 0x195FB90 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x195FBD0 Offset: 0x195FCD1 VA: 0x195FBD0 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x195FC10 Offset: 0x195FD11 VA: 0x195FC10 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x195FC50 Offset: 0x195FD51 VA: 0x195FC50 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x195FC90 Offset: 0x195FD91 VA: 0x195FC90 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x195FCD0 Offset: 0x195FDD1 VA: 0x195FCD0 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x195FD10 Offset: 0x195FE11 VA: 0x195FD10 Slot: 95
	protected override bool IsPrimitiveImpl() { }
}

public abstract class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 619
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

	// RVA: 0x195F3F0 Offset: 0x195F4F1 VA: 0x195F3F0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x195F450 Offset: 0x195F551 VA: 0x195F450 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x195F4B0 Offset: 0x195F5B1 VA: 0x195F4B0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x195F510 Offset: 0x195F611 VA: 0x195F510 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x195F570 Offset: 0x195F671 VA: 0x195F570 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x195F5D0 Offset: 0x195F6D1 VA: 0x195F5D0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x195F630 Offset: 0x195F731 VA: 0x195F630 Slot: 7
	public override string get_Name() { }

	// RVA: 0x195F690 Offset: 0x195F791 VA: 0x195F690 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x195F6F0 Offset: 0x195F7F1 VA: 0x195F6F0 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x195F750 Offset: 0x195F851 VA: 0x195F750 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x195F790 Offset: 0x195F891 VA: 0x195F790 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x195F7D0 Offset: 0x195F8D1 VA: 0x195F7D0 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0xB8570 Offset: 0xB8671 VA: 0xB8570
	// RVA: 0x195F810 Offset: 0x195F911 VA: 0x195F810 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x195F850 Offset: 0x195F951 VA: 0x195F850 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x195F890 Offset: 0x195F991 VA: 0x195F890 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x195F8D0 Offset: 0x195F9D1 VA: 0x195F8D0 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195F910 Offset: 0x195FA11 VA: 0x195F910 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195F950 Offset: 0x195FA51 VA: 0x195F950 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x195F990 Offset: 0x195FA91 VA: 0x195F990 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x195F9D0 Offset: 0x195FAD1 VA: 0x195F9D0 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x195FA10 Offset: 0x195FB11 VA: 0x195FA10 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195FA50 Offset: 0x195FB51 VA: 0x195FA50 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x195FA90 Offset: 0x195FB91 VA: 0x195FA90 Slot: 55
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195FAD0 Offset: 0x195FBD1 VA: 0x195FAD0 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x195FB10 Offset: 0x195FC11 VA: 0x195FB10 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195FB50 Offset: 0x195FC51 VA: 0x195FB50 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x195FB90 Offset: 0x195FC91 VA: 0x195FB90 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x195FBD0 Offset: 0x195FCD1 VA: 0x195FBD0 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x195FC10 Offset: 0x195FD11 VA: 0x195FC10 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x195FC50 Offset: 0x195FD51 VA: 0x195FC50 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x195FC90 Offset: 0x195FD91 VA: 0x195FC90 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x195FCD0 Offset: 0x195FDD1 VA: 0x195FCD0 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x195FD10 Offset: 0x195FE11 VA: 0x195FD10 Slot: 95
	protected override bool IsPrimitiveImpl() { }
}

public abstract class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 619
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

	// RVA: 0x195F3F0 Offset: 0x195F4F1 VA: 0x195F3F0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x195F450 Offset: 0x195F551 VA: 0x195F450 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x195F4B0 Offset: 0x195F5B1 VA: 0x195F4B0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x195F510 Offset: 0x195F611 VA: 0x195F510 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x195F570 Offset: 0x195F671 VA: 0x195F570 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x195F5D0 Offset: 0x195F6D1 VA: 0x195F5D0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x195F630 Offset: 0x195F731 VA: 0x195F630 Slot: 7
	public override string get_Name() { }

	// RVA: 0x195F690 Offset: 0x195F791 VA: 0x195F690 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x195F6F0 Offset: 0x195F7F1 VA: 0x195F6F0 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x195F750 Offset: 0x195F851 VA: 0x195F750 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x195F790 Offset: 0x195F891 VA: 0x195F790 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x195F7D0 Offset: 0x195F8D1 VA: 0x195F7D0 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0xB8570 Offset: 0xB8671 VA: 0xB8570
	// RVA: 0x195F810 Offset: 0x195F911 VA: 0x195F810 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x195F850 Offset: 0x195F951 VA: 0x195F850 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x195F890 Offset: 0x195F991 VA: 0x195F890 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x195F8D0 Offset: 0x195F9D1 VA: 0x195F8D0 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195F910 Offset: 0x195FA11 VA: 0x195F910 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195F950 Offset: 0x195FA51 VA: 0x195F950 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x195F990 Offset: 0x195FA91 VA: 0x195F990 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x195F9D0 Offset: 0x195FAD1 VA: 0x195F9D0 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x195FA10 Offset: 0x195FB11 VA: 0x195FA10 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195FA50 Offset: 0x195FB51 VA: 0x195FA50 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x195FA90 Offset: 0x195FB91 VA: 0x195FA90 Slot: 55
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195FAD0 Offset: 0x195FBD1 VA: 0x195FAD0 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x195FB10 Offset: 0x195FC11 VA: 0x195FB10 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195FB50 Offset: 0x195FC51 VA: 0x195FB50 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x195FB90 Offset: 0x195FC91 VA: 0x195FB90 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x195FBD0 Offset: 0x195FCD1 VA: 0x195FBD0 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x195FC10 Offset: 0x195FD11 VA: 0x195FC10 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x195FC50 Offset: 0x195FD51 VA: 0x195FC50 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x195FC90 Offset: 0x195FD91 VA: 0x195FC90 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x195FCD0 Offset: 0x195FDD1 VA: 0x195FCD0 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x195FD10 Offset: 0x195FE11 VA: 0x195FD10 Slot: 95
	protected override bool IsPrimitiveImpl() { }
}

public abstract class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 619
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

	// RVA: 0x195F3F0 Offset: 0x195F4F1 VA: 0x195F3F0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x195F450 Offset: 0x195F551 VA: 0x195F450 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x195F4B0 Offset: 0x195F5B1 VA: 0x195F4B0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x195F510 Offset: 0x195F611 VA: 0x195F510 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x195F570 Offset: 0x195F671 VA: 0x195F570 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x195F5D0 Offset: 0x195F6D1 VA: 0x195F5D0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x195F630 Offset: 0x195F731 VA: 0x195F630 Slot: 7
	public override string get_Name() { }

	// RVA: 0x195F690 Offset: 0x195F791 VA: 0x195F690 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x195F6F0 Offset: 0x195F7F1 VA: 0x195F6F0 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x195F750 Offset: 0x195F851 VA: 0x195F750 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x195F790 Offset: 0x195F891 VA: 0x195F790 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x195F7D0 Offset: 0x195F8D1 VA: 0x195F7D0 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0xB8570 Offset: 0xB8671 VA: 0xB8570
	// RVA: 0x195F810 Offset: 0x195F911 VA: 0x195F810 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x195F850 Offset: 0x195F951 VA: 0x195F850 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x195F890 Offset: 0x195F991 VA: 0x195F890 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x195F8D0 Offset: 0x195F9D1 VA: 0x195F8D0 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195F910 Offset: 0x195FA11 VA: 0x195F910 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195F950 Offset: 0x195FA51 VA: 0x195F950 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x195F990 Offset: 0x195FA91 VA: 0x195F990 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x195F9D0 Offset: 0x195FAD1 VA: 0x195F9D0 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x195FA10 Offset: 0x195FB11 VA: 0x195FA10 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195FA50 Offset: 0x195FB51 VA: 0x195FA50 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x195FA90 Offset: 0x195FB91 VA: 0x195FA90 Slot: 55
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195FAD0 Offset: 0x195FBD1 VA: 0x195FAD0 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x195FB10 Offset: 0x195FC11 VA: 0x195FB10 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195FB50 Offset: 0x195FC51 VA: 0x195FB50 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x195FB90 Offset: 0x195FC91 VA: 0x195FB90 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x195FBD0 Offset: 0x195FCD1 VA: 0x195FBD0 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x195FC10 Offset: 0x195FD11 VA: 0x195FC10 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x195FC50 Offset: 0x195FD51 VA: 0x195FC50 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x195FC90 Offset: 0x195FD91 VA: 0x195FC90 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x195FCD0 Offset: 0x195FDD1 VA: 0x195FCD0 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x195FD10 Offset: 0x195FE11 VA: 0x195FD10 Slot: 95
	protected override bool IsPrimitiveImpl() { }
}

public abstract class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 619
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

	// RVA: 0x195F3F0 Offset: 0x195F4F1 VA: 0x195F3F0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x195F450 Offset: 0x195F551 VA: 0x195F450 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x195F4B0 Offset: 0x195F5B1 VA: 0x195F4B0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x195F510 Offset: 0x195F611 VA: 0x195F510 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x195F570 Offset: 0x195F671 VA: 0x195F570 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x195F5D0 Offset: 0x195F6D1 VA: 0x195F5D0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x195F630 Offset: 0x195F731 VA: 0x195F630 Slot: 7
	public override string get_Name() { }

	// RVA: 0x195F690 Offset: 0x195F791 VA: 0x195F690 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x195F6F0 Offset: 0x195F7F1 VA: 0x195F6F0 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x195F750 Offset: 0x195F851 VA: 0x195F750 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x195F790 Offset: 0x195F891 VA: 0x195F790 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x195F7D0 Offset: 0x195F8D1 VA: 0x195F7D0 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0xB8570 Offset: 0xB8671 VA: 0xB8570
	// RVA: 0x195F810 Offset: 0x195F911 VA: 0x195F810 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x195F850 Offset: 0x195F951 VA: 0x195F850 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x195F890 Offset: 0x195F991 VA: 0x195F890 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x195F8D0 Offset: 0x195F9D1 VA: 0x195F8D0 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195F910 Offset: 0x195FA11 VA: 0x195F910 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195F950 Offset: 0x195FA51 VA: 0x195F950 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x195F990 Offset: 0x195FA91 VA: 0x195F990 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x195F9D0 Offset: 0x195FAD1 VA: 0x195F9D0 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x195FA10 Offset: 0x195FB11 VA: 0x195FA10 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195FA50 Offset: 0x195FB51 VA: 0x195FA50 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x195FA90 Offset: 0x195FB91 VA: 0x195FA90 Slot: 55
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195FAD0 Offset: 0x195FBD1 VA: 0x195FAD0 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x195FB10 Offset: 0x195FC11 VA: 0x195FB10 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195FB50 Offset: 0x195FC51 VA: 0x195FB50 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x195FB90 Offset: 0x195FC91 VA: 0x195FB90 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x195FBD0 Offset: 0x195FCD1 VA: 0x195FBD0 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x195FC10 Offset: 0x195FD11 VA: 0x195FC10 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x195FC50 Offset: 0x195FD51 VA: 0x195FC50 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x195FC90 Offset: 0x195FD91 VA: 0x195FC90 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x195FCD0 Offset: 0x195FDD1 VA: 0x195FCD0 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x195FD10 Offset: 0x195FE11 VA: 0x195FD10 Slot: 95
	protected override bool IsPrimitiveImpl() { }
}

public abstract class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 619
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

	// RVA: 0x195F3F0 Offset: 0x195F4F1 VA: 0x195F3F0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x195F450 Offset: 0x195F551 VA: 0x195F450 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x195F4B0 Offset: 0x195F5B1 VA: 0x195F4B0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x195F510 Offset: 0x195F611 VA: 0x195F510 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x195F570 Offset: 0x195F671 VA: 0x195F570 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x195F5D0 Offset: 0x195F6D1 VA: 0x195F5D0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x195F630 Offset: 0x195F731 VA: 0x195F630 Slot: 7
	public override string get_Name() { }

	// RVA: 0x195F690 Offset: 0x195F791 VA: 0x195F690 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x195F6F0 Offset: 0x195F7F1 VA: 0x195F6F0 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x195F750 Offset: 0x195F851 VA: 0x195F750 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x195F790 Offset: 0x195F891 VA: 0x195F790 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x195F7D0 Offset: 0x195F8D1 VA: 0x195F7D0 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0xB8570 Offset: 0xB8671 VA: 0xB8570
	// RVA: 0x195F810 Offset: 0x195F911 VA: 0x195F810 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x195F850 Offset: 0x195F951 VA: 0x195F850 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x195F890 Offset: 0x195F991 VA: 0x195F890 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x195F8D0 Offset: 0x195F9D1 VA: 0x195F8D0 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195F910 Offset: 0x195FA11 VA: 0x195F910 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195F950 Offset: 0x195FA51 VA: 0x195F950 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x195F990 Offset: 0x195FA91 VA: 0x195F990 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x195F9D0 Offset: 0x195FAD1 VA: 0x195F9D0 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x195FA10 Offset: 0x195FB11 VA: 0x195FA10 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195FA50 Offset: 0x195FB51 VA: 0x195FA50 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x195FA90 Offset: 0x195FB91 VA: 0x195FA90 Slot: 55
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x195FAD0 Offset: 0x195FBD1 VA: 0x195FAD0 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x195FB10 Offset: 0x195FC11 VA: 0x195FB10 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x195FB50 Offset: 0x195FC51 VA: 0x195FB50 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x195FB90 Offset: 0x195FC91 VA: 0x195FB90 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x195FBD0 Offset: 0x195FCD1 VA: 0x195FBD0 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x195FC10 Offset: 0x195FD11 VA: 0x195FC10 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x195FC50 Offset: 0x195FD51 VA: 0x195FC50 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x195FC90 Offset: 0x195FD91 VA: 0x195FC90 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x195FCD0 Offset: 0x195FDD1 VA: 0x195FCD0 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x195FD10 Offset: 0x195FE11 VA: 0x195FD10 Slot: 95
	protected override bool IsPrimitiveImpl() { }
}

