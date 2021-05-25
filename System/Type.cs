[ComVisibleAttribute] // RVA: 0xACA20 Offset: 0xACB21 VA: 0xACA20
[ClassInterfaceAttribute] // RVA: 0xACA20 Offset: 0xACB21 VA: 0xACA20
[ComDefaultInterfaceAttribute] // RVA: 0xACA20 Offset: 0xACB21 VA: 0xACA20
[Serializable]
public abstract class Type : MemberInfo, _Type // TypeDefIndex: 331
{
	// Fields
	public static readonly MemberFilter FilterAttribute; // 0x0
	public static readonly MemberFilter FilterName; // 0x8
	public static readonly MemberFilter FilterNameIgnoreCase; // 0x10
	public static readonly object Missing; // 0x18
	public static readonly char Delimiter; // 0x20
	public static readonly Type[] EmptyTypes; // 0x28
	private static Binder defaultBinder; // 0x30
	private const BindingFlags DefaultLookup = 28;
	internal const BindingFlags DeclaredOnlyLookup = 62;
	internal RuntimeTypeHandle _impl; // 0x10

	// Properties
	public override MemberTypes MemberType { get; }
	public override Type DeclaringType { get; }
	public virtual MethodBase DeclaringMethod { get; }
	public override Type ReflectedType { get; }
	public abstract Guid GUID { get; }
	public static Binder DefaultBinder { get; }
	public abstract override Module Module { get; }
	public abstract Assembly Assembly { get; }
	public virtual RuntimeTypeHandle TypeHandle { get; }
	public abstract string FullName { get; }
	public abstract string Namespace { get; }
	public abstract string AssemblyQualifiedName { get; }
	public abstract Type BaseType { get; }
	public bool IsNested { get; }
	public TypeAttributes Attributes { get; }
	public virtual GenericParameterAttributes GenericParameterAttributes { get; }
	public bool IsNotPublic { get; }
	public bool IsPublic { get; }
	public bool IsNestedPublic { get; }
	public bool IsNestedAssembly { get; }
	public bool IsExplicitLayout { get; }
	public bool IsClass { get; }
	public bool IsInterface { get; }
	public bool IsValueType { get; }
	public bool IsAbstract { get; }
	public bool IsSealed { get; }
	public virtual bool IsEnum { get; }
	public virtual bool IsSerializable { get; }
	public bool IsArray { get; }
	internal virtual bool IsSzArray { get; }
	public virtual bool IsGenericType { get; }
	public virtual bool IsGenericTypeDefinition { get; }
	public virtual bool IsConstructedGenericType { get; }
	public virtual bool IsGenericParameter { get; }
	public virtual int GenericParameterPosition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public bool IsByRef { get; }
	public bool IsPointer { get; }
	public bool IsPrimitive { get; }
	public bool IsCOMObject { get; }
	public bool HasElementType { get; }
	public bool IsContextful { get; }
	public bool IsMarshalByRef { get; }
	public virtual Type[] GenericTypeArguments { get; }
	public abstract Type UnderlyingSystemType { get; }
	public virtual bool IsSZArray { get; }

	// Methods

	// RVA: 0x1AD9660 Offset: 0x1AD9761 VA: 0x1AD9660
	protected void .ctor() { }

	// RVA: 0x1AD9670 Offset: 0x1AD9771 VA: 0x1AD9670 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1AD9680 Offset: 0x1AD9781 VA: 0x1AD9680 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x1AD9690 Offset: 0x1AD9791 VA: 0x1AD9690 Slot: 16
	public virtual MethodBase get_DeclaringMethod() { }

	// RVA: 0x1AD96A0 Offset: 0x1AD97A1 VA: 0x1AD96A0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x1AD96B0 Offset: 0x1AD97B1 VA: 0x1AD96B0
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) { }

	// RVA: 0x1AD9750 Offset: 0x1AD9851 VA: 0x1AD9750 Slot: 17
	public virtual Type MakePointerType() { }

	// RVA: 0x1AD97B0 Offset: 0x1AD98B1 VA: 0x1AD97B0 Slot: 18
	public virtual Type MakeByRefType() { }

	// RVA: 0x1AD9810 Offset: 0x1AD9911 VA: 0x1AD9810 Slot: 19
	public virtual Type MakeArrayType() { }

	// RVA: 0x1AD9870 Offset: 0x1AD9971 VA: 0x1AD9870 Slot: 20
	public virtual Type MakeArrayType(int rank) { }

	// RVA: 0x1AD98D0 Offset: 0x1AD99D1 VA: 0x1AD98D0
	public static Type GetTypeFromCLSID(Guid clsid) { }

	// RVA: 0x1AD9950 Offset: 0x1AD9A51 VA: 0x1AD9950
	public static TypeCode GetTypeCode(Type type) { }

	// RVA: 0x1AD99F0 Offset: 0x1AD9AF1 VA: 0x1AD99F0 Slot: 21
	protected virtual TypeCode GetTypeCodeImpl() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Guid get_GUID() { }

	// RVA: 0x1AD9B90 Offset: 0x1AD9C91 VA: 0x1AD9B90
	public static Binder get_DefaultBinder() { }

	// RVA: 0x1AD9C50 Offset: 0x1AD9D51 VA: 0x1AD9C50
	private static void CreateBinder() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract override Module get_Module() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Assembly get_Assembly() { }

	// RVA: 0x1AD9D20 Offset: 0x1AD9E21 VA: 0x1AD9D20 Slot: 25
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1AD9D80 Offset: 0x1AD9E81 VA: 0x1AD9D80
	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_FullName() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_Namespace() { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract string get_AssemblyQualifiedName() { }

	// RVA: 0x1AD9E90 Offset: 0x1AD9F91 VA: 0x1AD9E90 Slot: 29
	public virtual int GetArrayRank() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract Type get_BaseType() { }

	[ComVisibleAttribute] // RVA: 0xB6EE0 Offset: 0xB6FE1 VA: 0xB6EE0
	// RVA: 0x1AD9F10 Offset: 0x1ADA011 VA: 0x1AD9F10 Slot: 31
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0xB6F00 Offset: 0xB7001 VA: 0xB6F00
	// RVA: 0x1ADA050 Offset: 0x1ADA151 VA: 0x1ADA050 Slot: 32
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0xB6F20 Offset: 0xB7021 VA: 0xB6F20
	// RVA: 0x1ADA190 Offset: 0x1ADA291 VA: 0x1ADA190 Slot: 33
	public ConstructorInfo GetConstructor(Type[] types) { }

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0xB6F40 Offset: 0xB7041 VA: 0xB6F40
	// RVA: -1 Offset: -1 Slot: 35
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1ADA1B0 Offset: 0x1ADA2B1 VA: 0x1ADA1B0 Slot: 36
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1ADA310 Offset: 0x1ADA411 VA: 0x1ADA310 Slot: 37
	public MethodInfo GetMethod(string name, Type[] types) { }

	// RVA: 0x1ADA460 Offset: 0x1ADA561 VA: 0x1ADA460 Slot: 38
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1ADA520 Offset: 0x1ADA621 VA: 0x1ADA520 Slot: 39
	public MethodInfo GetMethod(string name) { }

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1ADA5E0 Offset: 0x1ADA6E1 VA: 0x1ADA5E0 Slot: 41
	public MethodInfo[] GetMethods() { }

	// RVA: -1 Offset: -1 Slot: 42
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1ADA600 Offset: 0x1ADA701 VA: 0x1ADA600 Slot: 44
	public FieldInfo GetField(string name) { }

	// RVA: 0x1ADA620 Offset: 0x1ADA721 VA: 0x1ADA620 Slot: 45
	public FieldInfo[] GetFields() { }

	// RVA: -1 Offset: -1 Slot: 46
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract Type[] GetInterfaces() { }

	// RVA: -1 Offset: -1 Slot: 48
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1ADA640 Offset: 0x1ADA741 VA: 0x1ADA640 Slot: 49
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1ADA700 Offset: 0x1ADA801 VA: 0x1ADA700 Slot: 50
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	// RVA: 0x1ADA7F0 Offset: 0x1ADA8F1 VA: 0x1ADA7F0 Slot: 51
	public PropertyInfo GetProperty(string name, Type returnType) { }

	// RVA: 0x1ADA8F0 Offset: 0x1ADA9F1 VA: 0x1ADA8F0 Slot: 52
	public PropertyInfo GetProperty(string name) { }

	// RVA: -1 Offset: -1 Slot: 53
	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: -1 Offset: -1 Slot: 54
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1 Slot: 55
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1ADA9B0 Offset: 0x1ADAAB1 VA: 0x1ADA9B0 Slot: 56
	public MemberInfo[] GetMember(string name) { }

	// RVA: 0x1ADA9D0 Offset: 0x1ADAAD1 VA: 0x1ADA9D0 Slot: 57
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1ADA9F0 Offset: 0x1ADAAF1 VA: 0x1ADA9F0 Slot: 58
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1 Slot: 59
	public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1ADAA70 Offset: 0x1ADAB71 VA: 0x1ADAA70
	public bool get_IsNested() { }

	// RVA: 0x1ADAAF0 Offset: 0x1ADABF1 VA: 0x1ADAAF0 Slot: 60
	public TypeAttributes get_Attributes() { }

	// RVA: 0x1ADAB00 Offset: 0x1ADAC01 VA: 0x1ADAB00 Slot: 61
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1ADAB60 Offset: 0x1ADAC61 VA: 0x1ADAB60 Slot: 62
	public bool get_IsNotPublic() { }

	// RVA: 0x1ADAB90 Offset: 0x1ADAC91 VA: 0x1ADAB90 Slot: 63
	public bool get_IsPublic() { }

	// RVA: 0x1ADABC0 Offset: 0x1ADACC1 VA: 0x1ADABC0 Slot: 64
	public bool get_IsNestedPublic() { }

	// RVA: 0x1ADABF0 Offset: 0x1ADACF1 VA: 0x1ADABF0 Slot: 65
	public bool get_IsNestedAssembly() { }

	// RVA: 0x1ADAC20 Offset: 0x1ADAD21 VA: 0x1ADAC20 Slot: 66
	public bool get_IsExplicitLayout() { }

	// RVA: 0x1ADAC50 Offset: 0x1ADAD51 VA: 0x1ADAC50 Slot: 67
	public bool get_IsClass() { }

	// RVA: 0x1ADACC0 Offset: 0x1ADADC1 VA: 0x1ADACC0 Slot: 68
	public bool get_IsInterface() { }

	// RVA: 0x1ADACB0 Offset: 0x1ADADB1 VA: 0x1ADACB0 Slot: 69
	public bool get_IsValueType() { }

	// RVA: 0x1ADADA0 Offset: 0x1ADAEA1 VA: 0x1ADADA0 Slot: 70
	public bool get_IsAbstract() { }

	// RVA: 0x1ADADD0 Offset: 0x1ADAED1 VA: 0x1ADADD0 Slot: 71
	public bool get_IsSealed() { }

	// RVA: 0x1ADAE00 Offset: 0x1ADAF01 VA: 0x1ADAE00 Slot: 72
	public virtual bool get_IsEnum() { }

	// RVA: 0x1ADAE80 Offset: 0x1ADAF81 VA: 0x1ADAE80 Slot: 73
	public virtual bool get_IsSerializable() { }

	// RVA: 0x1ADAF90 Offset: 0x1ADB091 VA: 0x1ADAF90 Slot: 74
	public bool get_IsArray() { }

	// RVA: 0x1ADAFA0 Offset: 0x1ADB0A1 VA: 0x1ADAFA0 Slot: 75
	internal virtual bool get_IsSzArray() { }

	// RVA: 0x1ADAFB0 Offset: 0x1ADB0B1 VA: 0x1ADAFB0 Slot: 76
	public virtual bool get_IsGenericType() { }

	// RVA: 0x1ADAFC0 Offset: 0x1ADB0C1 VA: 0x1ADAFC0 Slot: 77
	public virtual bool get_IsGenericTypeDefinition() { }

	// RVA: 0x1ADAFD0 Offset: 0x1ADB0D1 VA: 0x1ADAFD0 Slot: 78
	public virtual bool get_IsConstructedGenericType() { }

	// RVA: 0x1ADB030 Offset: 0x1ADB131 VA: 0x1ADB030 Slot: 79
	public virtual bool get_IsGenericParameter() { }

	// RVA: 0x1ADB040 Offset: 0x1ADB141 VA: 0x1ADB040 Slot: 80
	public virtual int get_GenericParameterPosition() { }

	// RVA: 0x1ADB0C0 Offset: 0x1ADB1C1 VA: 0x1ADB0C0 Slot: 81
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x1ADB280 Offset: 0x1ADB381 VA: 0x1ADB280 Slot: 82
	public virtual Type[] GetGenericParameterConstraints() { }

	// RVA: 0x1ADB350 Offset: 0x1ADB451 VA: 0x1ADB350 Slot: 83
	public bool get_IsByRef() { }

	// RVA: 0x1ADB360 Offset: 0x1ADB461 VA: 0x1ADB360 Slot: 84
	public bool get_IsPointer() { }

	// RVA: 0x1ADB370 Offset: 0x1ADB471 VA: 0x1ADB370 Slot: 85
	public bool get_IsPrimitive() { }

	// RVA: 0x1ADB380 Offset: 0x1ADB481 VA: 0x1ADB380 Slot: 86
	public bool get_IsCOMObject() { }

	// RVA: 0x1ADB210 Offset: 0x1ADB311 VA: 0x1ADB210 Slot: 87
	public bool get_HasElementType() { }

	// RVA: 0x1ADB390 Offset: 0x1ADB491 VA: 0x1ADB390 Slot: 88
	public bool get_IsContextful() { }

	// RVA: 0x1ADB3A0 Offset: 0x1ADB4A1 VA: 0x1ADB3A0 Slot: 89
	public bool get_IsMarshalByRef() { }

	// RVA: 0x1ADB3B0 Offset: 0x1ADB4B1 VA: 0x1ADB3B0 Slot: 90
	protected virtual bool IsValueTypeImpl() { }

	// RVA: -1 Offset: -1 Slot: 91
	protected abstract TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: -1 Offset: -1 Slot: 92
	protected abstract bool IsArrayImpl() { }

	// RVA: -1 Offset: -1 Slot: 93
	protected abstract bool IsByRefImpl() { }

	// RVA: -1 Offset: -1 Slot: 94
	protected abstract bool IsPointerImpl() { }

	// RVA: -1 Offset: -1 Slot: 95
	protected abstract bool IsPrimitiveImpl() { }

	// RVA: -1 Offset: -1 Slot: 96
	protected abstract bool IsCOMObjectImpl() { }

	// RVA: 0x1ADB430 Offset: 0x1ADB531 VA: 0x1ADB430 Slot: 97
	public virtual Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x1ADB4B0 Offset: 0x1ADB5B1 VA: 0x1ADB4B0 Slot: 98
	protected virtual bool IsContextfulImpl() { }

	// RVA: 0x1ADB5B0 Offset: 0x1ADB6B1 VA: 0x1ADB5B0 Slot: 99
	protected virtual bool IsMarshalByRefImpl() { }

	// RVA: -1 Offset: -1 Slot: 100
	public abstract Type GetElementType() { }

	// RVA: 0x1ADB6B0 Offset: 0x1ADB7B1 VA: 0x1ADB6B0 Slot: 101
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x1ADB730 Offset: 0x1ADB831 VA: 0x1ADB730 Slot: 102
	public virtual Type[] get_GenericTypeArguments() { }

	// RVA: 0x1ADB7F0 Offset: 0x1ADB8F1 VA: 0x1ADB7F0 Slot: 103
	public virtual Type GetGenericTypeDefinition() { }

	// RVA: -1 Offset: -1 Slot: 104
	protected abstract bool HasElementTypeImpl() { }

	// RVA: 0x1ADB220 Offset: 0x1ADB321 VA: 0x1ADB220
	internal Type GetRootElementType() { }

	// RVA: 0x1ADB870 Offset: 0x1ADB971 VA: 0x1ADB870 Slot: 105
	public virtual string[] GetEnumNames() { }

	// RVA: 0x1ADBDA0 Offset: 0x1ADBEA1 VA: 0x1ADBDA0 Slot: 106
	public virtual Array GetEnumValues() { }

	// RVA: 0x1ADBE80 Offset: 0x1ADBF81 VA: 0x1ADBE80
	private Array GetEnumRawConstantValues() { }

	// RVA: 0x1ADB940 Offset: 0x1ADBA41 VA: 0x1ADB940
	private void GetEnumData(out string[] enumNames, out Array enumValues) { }

	// RVA: 0x1ADBEB0 Offset: 0x1ADBFB1 VA: 0x1ADBEB0 Slot: 107
	public virtual Type GetEnumUnderlyingType() { }

	// RVA: 0x1ADBFB0 Offset: 0x1ADC0B1 VA: 0x1ADBFB0 Slot: 108
	public virtual bool IsEnumDefined(object value) { }

	// RVA: 0x1ADCD30 Offset: 0x1ADCE31 VA: 0x1ADCD30 Slot: 109
	public virtual string GetEnumName(object value) { }

	// RVA: 0x1ADCB90 Offset: 0x1ADCC91 VA: 0x1ADCB90
	private static int BinarySearch(Array array, object value) { }

	// RVA: 0x1ADC520 Offset: 0x1ADC621 VA: 0x1ADC520
	internal static bool IsIntegerType(Type t) { }

	// RVA: -1 Offset: -1 Slot: 110
	public abstract Type get_UnderlyingSystemType() { }

	[ComVisibleAttribute] // RVA: 0xB6F60 Offset: 0xB7061 VA: 0xB6F60
	// RVA: 0x1ADCF60 Offset: 0x1ADD061 VA: 0x1ADCF60 Slot: 111
	public virtual bool IsSubclassOf(Type c) { }

	// RVA: 0x1ADD060 Offset: 0x1ADD161 VA: 0x1ADD060 Slot: 112
	public virtual bool IsInstanceOfType(object o) { }

	// RVA: 0x1ADD0B0 Offset: 0x1ADD1B1 VA: 0x1ADD0B0 Slot: 113
	public virtual bool IsAssignableFrom(Type c) { }

	// RVA: 0x1ADD480 Offset: 0x1ADD581 VA: 0x1ADD480 Slot: 114
	public virtual bool IsEquivalentTo(Type other) { }

	// RVA: 0x1ADD300 Offset: 0x1ADD401 VA: 0x1ADD300
	internal bool ImplementInterface(Type ifaceType) { }

	// RVA: 0x1ADD500 Offset: 0x1ADD601 VA: 0x1ADD500
	internal string FormatTypeName() { }

	// RVA: 0x1ADD520 Offset: 0x1ADD621 VA: 0x1ADD520 Slot: 115
	internal virtual string FormatTypeName(bool serialization) { }

	// RVA: 0x1ADD580 Offset: 0x1ADD681 VA: 0x1ADD580 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ADD5F0 Offset: 0x1ADD6F1 VA: 0x1ADD5F0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1ADD6A0 Offset: 0x1ADD7A1 VA: 0x1ADD6A0 Slot: 116
	public virtual bool Equals(Type o) { }

	// RVA: 0x1AD99E0 Offset: 0x1AD9AE1 VA: 0x1AD99E0
	public static bool op_Equality(Type left, Type right) { }

	// RVA: 0x1AD9B80 Offset: 0x1AD9C81 VA: 0x1AD9B80
	public static bool op_Inequality(Type left, Type right) { }

	// RVA: 0x1ADD700 Offset: 0x1ADD801 VA: 0x1ADD700 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ADD760 Offset: 0x1ADD861 VA: 0x1ADD760 Slot: 117
	public Type GetType() { }

	// RVA: 0x1ADD770 Offset: 0x1ADD871 VA: 0x1ADD770 Slot: 118
	public virtual bool get_IsSZArray() { }

	// RVA: 0x1ADD7D0 Offset: 0x1ADD8D1 VA: 0x1ADD7D0
	private static Type internal_from_name(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x1ADD7E0 Offset: 0x1ADD8E1 VA: 0x1ADD7E0
	public static Type GetType(string typeName) { }

	// RVA: 0x1ADDA20 Offset: 0x1ADDB21 VA: 0x1ADDA20
	public static Type GetType(string typeName, bool throwOnError) { }

	// RVA: 0x1ADD880 Offset: 0x1ADD981 VA: 0x1ADD880
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x1AD8460 Offset: 0x1AD8561 VA: 0x1AD8460
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	// RVA: 0x1ADDB20 Offset: 0x1ADDC21 VA: 0x1ADDB20
	private static Type internal_from_handle(IntPtr handle) { }

	// RVA: 0x1ADDB30 Offset: 0x1ADDC31 VA: 0x1ADDB30
	private static void .cctor() { }
}

