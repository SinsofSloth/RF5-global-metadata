[Serializable]
internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 301
{
	// Fields
	internal static readonly RuntimeType ValueType; // 0x0
	internal static readonly RuntimeType EnumType; // 0x8
	private static readonly RuntimeType ObjectType; // 0x10
	private static readonly RuntimeType StringType; // 0x18
	private static readonly RuntimeType DelegateType; // 0x20
	private static Type[] s_SICtorParamTypes; // 0x28
	private const BindingFlags MemberBindingMask = 255;
	private const BindingFlags InvocationMask = 65280;
	private const BindingFlags BinderNonCreateInstance = 15616;
	private const BindingFlags BinderGetSetProperty = 12288;
	private const BindingFlags BinderSetInvokeProperty = 8448;
	private const BindingFlags BinderGetSetField = 3072;
	private const BindingFlags BinderSetInvokeField = 2304;
	private const BindingFlags BinderNonFieldGetSet = 16773888;
	private const BindingFlags ClassicBindingMask = 61696;
	private static RuntimeType s_typedRef; // 0x30
	private MonoTypeInfo type_info; // 0x18
	internal object GenericCache; // 0x20
	private RuntimeConstructorInfo m_serializationCtor; // 0x28

	// Properties
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override Type BaseType { get; }
	public override Type UnderlyingSystemType { get; }
	public override bool IsEnum { get; }
	public override GenericParameterAttributes GenericParameterAttributes { get; }
	internal override bool IsSzArray { get; }
	public override bool IsGenericTypeDefinition { get; }
	public override bool IsGenericParameter { get; }
	public override int GenericParameterPosition { get; }
	public override bool IsGenericType { get; }
	public override bool IsConstructedGenericType { get; }
	public override MemberTypes MemberType { get; }
	public override Type ReflectedType { get; }
	public override int MetadataToken { get; }
	public override bool ContainsGenericParameters { get; }
	public override Guid GUID { get; }
	public override MethodBase DeclaringMethod { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override string FullName { get; }
	public override bool IsSZArray { get; }

	// Methods

	// RVA: 0x1521650 Offset: 0x1521751 VA: 0x1521650
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x15217B0 Offset: 0x15218B1 VA: 0x15217B0
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x15219E0 Offset: 0x1521AE1 VA: 0x15219E0
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x1521B20 Offset: 0x1521C21 VA: 0x1521B20
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1521C70 Offset: 0x1521D71 VA: 0x1521C70
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1521DA0 Offset: 0x1521EA1 VA: 0x1521DA0
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x1521E30 Offset: 0x1521F31 VA: 0x1521E30
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x1522040 Offset: 0x1522141 VA: 0x1522040
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x1522170 Offset: 0x1522271 VA: 0x1522170
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x15224A0 Offset: 0x15225A1 VA: 0x15224A0
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1522210 Offset: 0x1522311 VA: 0x1522210
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1522540 Offset: 0x1522641 VA: 0x1522540
	internal void .ctor() { }

	// RVA: 0x15225B0 Offset: 0x15226B1 VA: 0x15225B0
	internal bool IsSpecialSerializableType() { }

	// RVA: 0x15228D0 Offset: 0x15229D1 VA: 0x15228D0
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1522F40 Offset: 0x1523041 VA: 0x1522F40
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x15235A0 Offset: 0x15236A1 VA: 0x15235A0
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1523BB0 Offset: 0x1523CB1 VA: 0x1523BB0
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1524140 Offset: 0x1524241 VA: 0x1524140
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x15246D0 Offset: 0x15247D1 VA: 0x15246D0
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1524C90 Offset: 0x1524D91 VA: 0x1524C90 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisibleAttribute] // RVA: 0xB6C20 Offset: 0xB6D21 VA: 0xB6C20
	// RVA: 0x1524D20 Offset: 0x1524E21 VA: 0x1524D20 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1524DC0 Offset: 0x1524EC1 VA: 0x1524DC0 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1524E50 Offset: 0x1524F51 VA: 0x1524E50 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1524EE0 Offset: 0x1524FE1 VA: 0x1524EE0 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1525120 Offset: 0x1525221 VA: 0x1525120 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1525380 Offset: 0x1525481 VA: 0x1525380 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1525570 Offset: 0x1525671 VA: 0x1525570 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x15257D0 Offset: 0x15258D1 VA: 0x15257D0 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x15259B0 Offset: 0x1525AB1 VA: 0x15259B0 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1525CB0 Offset: 0x1525DB1 VA: 0x1525CB0 Slot: 55
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x1525EC0 Offset: 0x1525FC1 VA: 0x1525EC0 Slot: 58
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x15262C0 Offset: 0x15263C1 VA: 0x15262C0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x15262D0 Offset: 0x15263D1 VA: 0x15262D0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x15262E0 Offset: 0x15263E1 VA: 0x15262E0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x15262F0 Offset: 0x15263F1 VA: 0x15262F0
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x1526300 Offset: 0x1526401 VA: 0x1526300 Slot: 25
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1526330 Offset: 0x1526431 VA: 0x1526330 Slot: 112
	public override bool IsInstanceOfType(object o) { }

	[ComVisibleAttribute] // RVA: 0xB6C40 Offset: 0xB6D41 VA: 0xB6C40
	// RVA: 0x1526340 Offset: 0x1526441 VA: 0x1526340 Slot: 111
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x1526520 Offset: 0x1526621 VA: 0x1526520 Slot: 121
	public override bool IsAssignableFrom(TypeInfo typeInfo) { }

	// RVA: 0x15265F0 Offset: 0x15266F1 VA: 0x15265F0 Slot: 113
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x1526700 Offset: 0x1526801 VA: 0x1526700 Slot: 114
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x1526800 Offset: 0x1526901 VA: 0x1526800 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x15226B0 Offset: 0x15227B1 VA: 0x15226B0
	private RuntimeType GetBaseType() { }

	// RVA: 0x1526810 Offset: 0x1526911 VA: 0x1526810 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1526820 Offset: 0x1526921 VA: 0x1526820 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1526830 Offset: 0x1526931 VA: 0x1526830 Slot: 98
	protected override bool IsContextfulImpl() { }

	// RVA: 0x1526840 Offset: 0x1526941 VA: 0x1526840 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x1526850 Offset: 0x1526951 VA: 0x1526850 Slot: 95
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1526860 Offset: 0x1526961 VA: 0x1526860 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x1526870 Offset: 0x1526971 VA: 0x1526870 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x1526880 Offset: 0x1526981 VA: 0x1526880 Slot: 90
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x15269B0 Offset: 0x1526AB1 VA: 0x15269B0 Slot: 72
	public override bool get_IsEnum() { }

	// RVA: 0x1526A30 Offset: 0x1526B31 VA: 0x1526A30 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1526A40 Offset: 0x1526B41 VA: 0x1526A40 Slot: 61
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1526B70 Offset: 0x1526C71 VA: 0x1526B70 Slot: 75
	internal override bool get_IsSzArray() { }

	// RVA: 0x1526B80 Offset: 0x1526C81 VA: 0x1526B80 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x1526B90 Offset: 0x1526C91 VA: 0x1526B90 Slot: 29
	public override int GetArrayRank() { }

	// RVA: 0x1526C40 Offset: 0x1526D41 VA: 0x1526C40 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x1526C50 Offset: 0x1526D51 VA: 0x1526C50 Slot: 105
	public override string[] GetEnumNames() { }

	// RVA: 0x1526D70 Offset: 0x1526E71 VA: 0x1526D70 Slot: 106
	public override Array GetEnumValues() { }

	// RVA: 0x1526F60 Offset: 0x1527061 VA: 0x1526F60 Slot: 107
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x1527040 Offset: 0x1527141 VA: 0x1527040 Slot: 108
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x1527590 Offset: 0x1527691 VA: 0x1527590 Slot: 109
	public override string GetEnumName(object value) { }

	// RVA: 0x1527790 Offset: 0x1527891 VA: 0x1527790
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x1527820 Offset: 0x1527921 VA: 0x1527820 Slot: 101
	public override Type[] GetGenericArguments() { }

	// RVA: 0x15278C0 Offset: 0x15279C1 VA: 0x15278C0 Slot: 97
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x1527E30 Offset: 0x1527F31 VA: 0x1527E30 Slot: 77
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x1527E40 Offset: 0x1527F41 VA: 0x1527E40 Slot: 79
	public override bool get_IsGenericParameter() { }

	// RVA: 0x1527E50 Offset: 0x1527F51 VA: 0x1527E50 Slot: 80
	public override int get_GenericParameterPosition() { }

	// RVA: 0x1527F10 Offset: 0x1528011 VA: 0x1527F10 Slot: 103
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x1527FC0 Offset: 0x15280C1 VA: 0x1527FC0 Slot: 76
	public override bool get_IsGenericType() { }

	// RVA: 0x1527FD0 Offset: 0x15280D1 VA: 0x1527FD0 Slot: 78
	public override bool get_IsConstructedGenericType() { }

	[DebuggerHiddenAttribute] // RVA: 0xB6C60 Offset: 0xB6D61 VA: 0xB6C60
	[DebuggerStepThroughAttribute] // RVA: 0xB6C60 Offset: 0xB6D61 VA: 0xB6C60
	// RVA: 0x1528030 Offset: 0x1528131 VA: 0x1528030 Slot: 23
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x15292F0 Offset: 0x15293F1 VA: 0x15292F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x151D210 Offset: 0x151D311 VA: 0x151D210
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x15228C0 Offset: 0x15229C1 VA: 0x15228C0
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x1529300 Offset: 0x1529401 VA: 0x1529300 Slot: 128
	public object Clone() { }

	// RVA: 0x1529310 Offset: 0x1529411 VA: 0x1529310 Slot: 127
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15293B0 Offset: 0x15294B1 VA: 0x15293B0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1529460 Offset: 0x1529561 VA: 0x1529460 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x15295F0 Offset: 0x15296F1 VA: 0x15295F0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1529780 Offset: 0x1529881 VA: 0x1529780 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x1529790 Offset: 0x1529891 VA: 0x1529790 Slot: 115
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x15299D0 Offset: 0x1529AD1 VA: 0x15299D0 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1529A30 Offset: 0x1529B31 VA: 0x1529A30 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x1529A40 Offset: 0x1529B41 VA: 0x1529A40 Slot: 14
	public override int get_MetadataToken() { }

	// RVA: 0x1529A50 Offset: 0x1529B51 VA: 0x1529A50
	private void CreateInstanceCheckThis() { }

	// RVA: 0x1529C60 Offset: 0x1529D61 VA: 0x1529C60
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThroughAttribute] // RVA: 0xB6CA0 Offset: 0xB6DA1 VA: 0xB6CA0
	[DebuggerHiddenAttribute] // RVA: 0xB6CA0 Offset: 0xB6DA1 VA: 0xB6CA0
	// RVA: 0x152A750 Offset: 0x152A851 VA: 0x152A750
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x152A8B0 Offset: 0x152A9B1 VA: 0x152A8B0
	internal MonoCMethod GetDefaultConstructor() { }

	// RVA: 0x1529200 Offset: 0x1529301 VA: 0x1529200
	private string GetDefaultMemberName() { }

	// RVA: 0x151B0C0 Offset: 0x151B1C1 VA: 0x151B0C0
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x152A870 Offset: 0x152A971 VA: 0x152A870
	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x152AA60 Offset: 0x152AB61 VA: 0x152AA60
	private object CreateInstanceMono(bool nonPublic) { }

	// RVA: 0x152AD60 Offset: 0x152AE61 VA: 0x152AD60
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x152AEE0 Offset: 0x152AFE1 VA: 0x152AEE0
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x152B140 Offset: 0x152B241 VA: 0x152B140
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x1529940 Offset: 0x1529A41 VA: 0x1529940
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x152BB50 Offset: 0x152BC51 VA: 0x152BB50
	private Type make_array_type(int rank) { }

	// RVA: 0x152BB60 Offset: 0x152BC61 VA: 0x152BB60 Slot: 19
	public override Type MakeArrayType() { }

	// RVA: 0x152BB70 Offset: 0x152BC71 VA: 0x152BB70 Slot: 20
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x152BC00 Offset: 0x152BD01 VA: 0x152BC00
	private Type make_byref_type() { }

	// RVA: 0x152BC10 Offset: 0x152BD11 VA: 0x152BC10 Slot: 18
	public override Type MakeByRefType() { }

	// RVA: 0x152BCA0 Offset: 0x152BDA1 VA: 0x152BCA0
	private static Type MakePointerType(Type type) { }

	// RVA: 0x152BCB0 Offset: 0x152BDB1 VA: 0x152BCB0 Slot: 17
	public override Type MakePointerType() { }

	// RVA: 0x152BD30 Offset: 0x152BE31 VA: 0x152BD30 Slot: 81
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x152BE50 Offset: 0x152BF51 VA: 0x152BE50 Slot: 82
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x152BF70 Offset: 0x152C071 VA: 0x152BF70
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x1527E20 Offset: 0x1527F21 VA: 0x1527E20
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x152C0A0 Offset: 0x152C1A1 VA: 0x152C0A0
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	// RVA: 0x1522C10 Offset: 0x1522D11 VA: 0x1522C10
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	// RVA: 0x152C0B0 Offset: 0x152C1B1 VA: 0x152C0B0
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) { }

	// RVA: 0x152C0C0 Offset: 0x152C1C1 VA: 0x152C0C0
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x1523320 Offset: 0x1523421 VA: 0x1523320
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1523880 Offset: 0x1523981 VA: 0x1523880
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	// RVA: 0x152C0D0 Offset: 0x152C1D1 VA: 0x152C0D0 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x152C210 Offset: 0x152C311 VA: 0x152C210
	internal static Type GetTypeFromCLSIDImpl(Guid clsid, string server, bool throwOnError) { }

	// RVA: 0x152C280 Offset: 0x152C381 VA: 0x152C280 Slot: 21
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x152C300 Offset: 0x152C401 VA: 0x152C300
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x152C310 Offset: 0x152C411 VA: 0x152C310 Slot: 3
	public override string ToString() { }

	// RVA: 0x152A740 Offset: 0x152A841 VA: 0x152A740
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x152AD50 Offset: 0x152AE51 VA: 0x152AD50
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0x152C330 Offset: 0x152C431 VA: 0x152C330 Slot: 16
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x152C320 Offset: 0x152C421 VA: 0x152C320
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x1527810 Offset: 0x1527911 VA: 0x1527810
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x1526B20 Offset: 0x1526C21 VA: 0x1526B20
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x1527F00 Offset: 0x1528001 VA: 0x1527F00
	private int GetGenericParameterPosition() { }

	// RVA: 0x152C340 Offset: 0x152C441 VA: 0x152C340
	private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x152C350 Offset: 0x152C451 VA: 0x152C350
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x15243B0 Offset: 0x15244B1 VA: 0x15243B0
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1523E20 Offset: 0x1523F21 VA: 0x1523E20
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x152C360 Offset: 0x152C461 VA: 0x152C360 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x152C370 Offset: 0x152C471 VA: 0x152C370
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x1524890 Offset: 0x1524991 VA: 0x1524890
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	// RVA: 0x152C380 Offset: 0x152C481 VA: 0x152C380 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x152C390 Offset: 0x152C491 VA: 0x152C390 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x152C3A0 Offset: 0x152C4A1 VA: 0x152C3A0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x152C3B0 Offset: 0x152C4B1 VA: 0x152C3B0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x152C3C0 Offset: 0x152C4C1 VA: 0x152C3C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x152C4B0 Offset: 0x152C5B1 VA: 0x152C4B0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x152C5C0 Offset: 0x152C6C1 VA: 0x152C5C0 Slot: 118
	public override bool get_IsSZArray() { }

	// RVA: 0x152C630 Offset: 0x152C731 VA: 0x152C630
	private static void .cctor() { }
}

[Serializable]
internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 301
{
	// Fields
	internal static readonly RuntimeType ValueType; // 0x0
	internal static readonly RuntimeType EnumType; // 0x8
	private static readonly RuntimeType ObjectType; // 0x10
	private static readonly RuntimeType StringType; // 0x18
	private static readonly RuntimeType DelegateType; // 0x20
	private static Type[] s_SICtorParamTypes; // 0x28
	private const BindingFlags MemberBindingMask = 255;
	private const BindingFlags InvocationMask = 65280;
	private const BindingFlags BinderNonCreateInstance = 15616;
	private const BindingFlags BinderGetSetProperty = 12288;
	private const BindingFlags BinderSetInvokeProperty = 8448;
	private const BindingFlags BinderGetSetField = 3072;
	private const BindingFlags BinderSetInvokeField = 2304;
	private const BindingFlags BinderNonFieldGetSet = 16773888;
	private const BindingFlags ClassicBindingMask = 61696;
	private static RuntimeType s_typedRef; // 0x30
	private MonoTypeInfo type_info; // 0x18
	internal object GenericCache; // 0x20
	private RuntimeConstructorInfo m_serializationCtor; // 0x28

	// Properties
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override Type BaseType { get; }
	public override Type UnderlyingSystemType { get; }
	public override bool IsEnum { get; }
	public override GenericParameterAttributes GenericParameterAttributes { get; }
	internal override bool IsSzArray { get; }
	public override bool IsGenericTypeDefinition { get; }
	public override bool IsGenericParameter { get; }
	public override int GenericParameterPosition { get; }
	public override bool IsGenericType { get; }
	public override bool IsConstructedGenericType { get; }
	public override MemberTypes MemberType { get; }
	public override Type ReflectedType { get; }
	public override int MetadataToken { get; }
	public override bool ContainsGenericParameters { get; }
	public override Guid GUID { get; }
	public override MethodBase DeclaringMethod { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override string FullName { get; }
	public override bool IsSZArray { get; }

	// Methods

	// RVA: 0x1521650 Offset: 0x1521751 VA: 0x1521650
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x15217B0 Offset: 0x15218B1 VA: 0x15217B0
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x15219E0 Offset: 0x1521AE1 VA: 0x15219E0
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x1521B20 Offset: 0x1521C21 VA: 0x1521B20
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1521C70 Offset: 0x1521D71 VA: 0x1521C70
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1521DA0 Offset: 0x1521EA1 VA: 0x1521DA0
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x1521E30 Offset: 0x1521F31 VA: 0x1521E30
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x1522040 Offset: 0x1522141 VA: 0x1522040
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x1522170 Offset: 0x1522271 VA: 0x1522170
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x15224A0 Offset: 0x15225A1 VA: 0x15224A0
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1522210 Offset: 0x1522311 VA: 0x1522210
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1522540 Offset: 0x1522641 VA: 0x1522540
	internal void .ctor() { }

	// RVA: 0x15225B0 Offset: 0x15226B1 VA: 0x15225B0
	internal bool IsSpecialSerializableType() { }

	// RVA: 0x15228D0 Offset: 0x15229D1 VA: 0x15228D0
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1522F40 Offset: 0x1523041 VA: 0x1522F40
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x15235A0 Offset: 0x15236A1 VA: 0x15235A0
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1523BB0 Offset: 0x1523CB1 VA: 0x1523BB0
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1524140 Offset: 0x1524241 VA: 0x1524140
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x15246D0 Offset: 0x15247D1 VA: 0x15246D0
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1524C90 Offset: 0x1524D91 VA: 0x1524C90 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisibleAttribute] // RVA: 0xB6C20 Offset: 0xB6D21 VA: 0xB6C20
	// RVA: 0x1524D20 Offset: 0x1524E21 VA: 0x1524D20 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1524DC0 Offset: 0x1524EC1 VA: 0x1524DC0 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1524E50 Offset: 0x1524F51 VA: 0x1524E50 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1524EE0 Offset: 0x1524FE1 VA: 0x1524EE0 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1525120 Offset: 0x1525221 VA: 0x1525120 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1525380 Offset: 0x1525481 VA: 0x1525380 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1525570 Offset: 0x1525671 VA: 0x1525570 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x15257D0 Offset: 0x15258D1 VA: 0x15257D0 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x15259B0 Offset: 0x1525AB1 VA: 0x15259B0 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1525CB0 Offset: 0x1525DB1 VA: 0x1525CB0 Slot: 55
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x1525EC0 Offset: 0x1525FC1 VA: 0x1525EC0 Slot: 58
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x15262C0 Offset: 0x15263C1 VA: 0x15262C0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x15262D0 Offset: 0x15263D1 VA: 0x15262D0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x15262E0 Offset: 0x15263E1 VA: 0x15262E0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x15262F0 Offset: 0x15263F1 VA: 0x15262F0
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x1526300 Offset: 0x1526401 VA: 0x1526300 Slot: 25
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1526330 Offset: 0x1526431 VA: 0x1526330 Slot: 112
	public override bool IsInstanceOfType(object o) { }

	[ComVisibleAttribute] // RVA: 0xB6C40 Offset: 0xB6D41 VA: 0xB6C40
	// RVA: 0x1526340 Offset: 0x1526441 VA: 0x1526340 Slot: 111
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x1526520 Offset: 0x1526621 VA: 0x1526520 Slot: 121
	public override bool IsAssignableFrom(TypeInfo typeInfo) { }

	// RVA: 0x15265F0 Offset: 0x15266F1 VA: 0x15265F0 Slot: 113
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x1526700 Offset: 0x1526801 VA: 0x1526700 Slot: 114
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x1526800 Offset: 0x1526901 VA: 0x1526800 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x15226B0 Offset: 0x15227B1 VA: 0x15226B0
	private RuntimeType GetBaseType() { }

	// RVA: 0x1526810 Offset: 0x1526911 VA: 0x1526810 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1526820 Offset: 0x1526921 VA: 0x1526820 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1526830 Offset: 0x1526931 VA: 0x1526830 Slot: 98
	protected override bool IsContextfulImpl() { }

	// RVA: 0x1526840 Offset: 0x1526941 VA: 0x1526840 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x1526850 Offset: 0x1526951 VA: 0x1526850 Slot: 95
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1526860 Offset: 0x1526961 VA: 0x1526860 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x1526870 Offset: 0x1526971 VA: 0x1526870 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x1526880 Offset: 0x1526981 VA: 0x1526880 Slot: 90
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x15269B0 Offset: 0x1526AB1 VA: 0x15269B0 Slot: 72
	public override bool get_IsEnum() { }

	// RVA: 0x1526A30 Offset: 0x1526B31 VA: 0x1526A30 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1526A40 Offset: 0x1526B41 VA: 0x1526A40 Slot: 61
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1526B70 Offset: 0x1526C71 VA: 0x1526B70 Slot: 75
	internal override bool get_IsSzArray() { }

	// RVA: 0x1526B80 Offset: 0x1526C81 VA: 0x1526B80 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x1526B90 Offset: 0x1526C91 VA: 0x1526B90 Slot: 29
	public override int GetArrayRank() { }

	// RVA: 0x1526C40 Offset: 0x1526D41 VA: 0x1526C40 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x1526C50 Offset: 0x1526D51 VA: 0x1526C50 Slot: 105
	public override string[] GetEnumNames() { }

	// RVA: 0x1526D70 Offset: 0x1526E71 VA: 0x1526D70 Slot: 106
	public override Array GetEnumValues() { }

	// RVA: 0x1526F60 Offset: 0x1527061 VA: 0x1526F60 Slot: 107
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x1527040 Offset: 0x1527141 VA: 0x1527040 Slot: 108
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x1527590 Offset: 0x1527691 VA: 0x1527590 Slot: 109
	public override string GetEnumName(object value) { }

	// RVA: 0x1527790 Offset: 0x1527891 VA: 0x1527790
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x1527820 Offset: 0x1527921 VA: 0x1527820 Slot: 101
	public override Type[] GetGenericArguments() { }

	// RVA: 0x15278C0 Offset: 0x15279C1 VA: 0x15278C0 Slot: 97
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x1527E30 Offset: 0x1527F31 VA: 0x1527E30 Slot: 77
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x1527E40 Offset: 0x1527F41 VA: 0x1527E40 Slot: 79
	public override bool get_IsGenericParameter() { }

	// RVA: 0x1527E50 Offset: 0x1527F51 VA: 0x1527E50 Slot: 80
	public override int get_GenericParameterPosition() { }

	// RVA: 0x1527F10 Offset: 0x1528011 VA: 0x1527F10 Slot: 103
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x1527FC0 Offset: 0x15280C1 VA: 0x1527FC0 Slot: 76
	public override bool get_IsGenericType() { }

	// RVA: 0x1527FD0 Offset: 0x15280D1 VA: 0x1527FD0 Slot: 78
	public override bool get_IsConstructedGenericType() { }

	[DebuggerHiddenAttribute] // RVA: 0xB6C60 Offset: 0xB6D61 VA: 0xB6C60
	[DebuggerStepThroughAttribute] // RVA: 0xB6C60 Offset: 0xB6D61 VA: 0xB6C60
	// RVA: 0x1528030 Offset: 0x1528131 VA: 0x1528030 Slot: 23
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x15292F0 Offset: 0x15293F1 VA: 0x15292F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x151D210 Offset: 0x151D311 VA: 0x151D210
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x15228C0 Offset: 0x15229C1 VA: 0x15228C0
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x1529300 Offset: 0x1529401 VA: 0x1529300 Slot: 128
	public object Clone() { }

	// RVA: 0x1529310 Offset: 0x1529411 VA: 0x1529310 Slot: 127
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15293B0 Offset: 0x15294B1 VA: 0x15293B0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1529460 Offset: 0x1529561 VA: 0x1529460 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x15295F0 Offset: 0x15296F1 VA: 0x15295F0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1529780 Offset: 0x1529881 VA: 0x1529780 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x1529790 Offset: 0x1529891 VA: 0x1529790 Slot: 115
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x15299D0 Offset: 0x1529AD1 VA: 0x15299D0 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1529A30 Offset: 0x1529B31 VA: 0x1529A30 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x1529A40 Offset: 0x1529B41 VA: 0x1529A40 Slot: 14
	public override int get_MetadataToken() { }

	// RVA: 0x1529A50 Offset: 0x1529B51 VA: 0x1529A50
	private void CreateInstanceCheckThis() { }

	// RVA: 0x1529C60 Offset: 0x1529D61 VA: 0x1529C60
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThroughAttribute] // RVA: 0xB6CA0 Offset: 0xB6DA1 VA: 0xB6CA0
	[DebuggerHiddenAttribute] // RVA: 0xB6CA0 Offset: 0xB6DA1 VA: 0xB6CA0
	// RVA: 0x152A750 Offset: 0x152A851 VA: 0x152A750
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x152A8B0 Offset: 0x152A9B1 VA: 0x152A8B0
	internal MonoCMethod GetDefaultConstructor() { }

	// RVA: 0x1529200 Offset: 0x1529301 VA: 0x1529200
	private string GetDefaultMemberName() { }

	// RVA: 0x151B0C0 Offset: 0x151B1C1 VA: 0x151B0C0
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x152A870 Offset: 0x152A971 VA: 0x152A870
	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x152AA60 Offset: 0x152AB61 VA: 0x152AA60
	private object CreateInstanceMono(bool nonPublic) { }

	// RVA: 0x152AD60 Offset: 0x152AE61 VA: 0x152AD60
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x152AEE0 Offset: 0x152AFE1 VA: 0x152AEE0
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x152B140 Offset: 0x152B241 VA: 0x152B140
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x1529940 Offset: 0x1529A41 VA: 0x1529940
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x152BB50 Offset: 0x152BC51 VA: 0x152BB50
	private Type make_array_type(int rank) { }

	// RVA: 0x152BB60 Offset: 0x152BC61 VA: 0x152BB60 Slot: 19
	public override Type MakeArrayType() { }

	// RVA: 0x152BB70 Offset: 0x152BC71 VA: 0x152BB70 Slot: 20
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x152BC00 Offset: 0x152BD01 VA: 0x152BC00
	private Type make_byref_type() { }

	// RVA: 0x152BC10 Offset: 0x152BD11 VA: 0x152BC10 Slot: 18
	public override Type MakeByRefType() { }

	// RVA: 0x152BCA0 Offset: 0x152BDA1 VA: 0x152BCA0
	private static Type MakePointerType(Type type) { }

	// RVA: 0x152BCB0 Offset: 0x152BDB1 VA: 0x152BCB0 Slot: 17
	public override Type MakePointerType() { }

	// RVA: 0x152BD30 Offset: 0x152BE31 VA: 0x152BD30 Slot: 81
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x152BE50 Offset: 0x152BF51 VA: 0x152BE50 Slot: 82
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x152BF70 Offset: 0x152C071 VA: 0x152BF70
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x1527E20 Offset: 0x1527F21 VA: 0x1527E20
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x152C0A0 Offset: 0x152C1A1 VA: 0x152C0A0
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	// RVA: 0x1522C10 Offset: 0x1522D11 VA: 0x1522C10
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	// RVA: 0x152C0B0 Offset: 0x152C1B1 VA: 0x152C0B0
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) { }

	// RVA: 0x152C0C0 Offset: 0x152C1C1 VA: 0x152C0C0
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x1523320 Offset: 0x1523421 VA: 0x1523320
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1523880 Offset: 0x1523981 VA: 0x1523880
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	// RVA: 0x152C0D0 Offset: 0x152C1D1 VA: 0x152C0D0 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x152C210 Offset: 0x152C311 VA: 0x152C210
	internal static Type GetTypeFromCLSIDImpl(Guid clsid, string server, bool throwOnError) { }

	// RVA: 0x152C280 Offset: 0x152C381 VA: 0x152C280 Slot: 21
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x152C300 Offset: 0x152C401 VA: 0x152C300
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x152C310 Offset: 0x152C411 VA: 0x152C310 Slot: 3
	public override string ToString() { }

	// RVA: 0x152A740 Offset: 0x152A841 VA: 0x152A740
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x152AD50 Offset: 0x152AE51 VA: 0x152AD50
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0x152C330 Offset: 0x152C431 VA: 0x152C330 Slot: 16
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x152C320 Offset: 0x152C421 VA: 0x152C320
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x1527810 Offset: 0x1527911 VA: 0x1527810
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x1526B20 Offset: 0x1526C21 VA: 0x1526B20
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x1527F00 Offset: 0x1528001 VA: 0x1527F00
	private int GetGenericParameterPosition() { }

	// RVA: 0x152C340 Offset: 0x152C441 VA: 0x152C340
	private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x152C350 Offset: 0x152C451 VA: 0x152C350
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x15243B0 Offset: 0x15244B1 VA: 0x15243B0
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1523E20 Offset: 0x1523F21 VA: 0x1523E20
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x152C360 Offset: 0x152C461 VA: 0x152C360 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x152C370 Offset: 0x152C471 VA: 0x152C370
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x1524890 Offset: 0x1524991 VA: 0x1524890
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	// RVA: 0x152C380 Offset: 0x152C481 VA: 0x152C380 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x152C390 Offset: 0x152C491 VA: 0x152C390 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x152C3A0 Offset: 0x152C4A1 VA: 0x152C3A0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x152C3B0 Offset: 0x152C4B1 VA: 0x152C3B0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x152C3C0 Offset: 0x152C4C1 VA: 0x152C3C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x152C4B0 Offset: 0x152C5B1 VA: 0x152C4B0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x152C5C0 Offset: 0x152C6C1 VA: 0x152C5C0 Slot: 118
	public override bool get_IsSZArray() { }

	// RVA: 0x152C630 Offset: 0x152C731 VA: 0x152C630
	private static void .cctor() { }
}

[Serializable]
internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 301
{
	// Fields
	internal static readonly RuntimeType ValueType; // 0x0
	internal static readonly RuntimeType EnumType; // 0x8
	private static readonly RuntimeType ObjectType; // 0x10
	private static readonly RuntimeType StringType; // 0x18
	private static readonly RuntimeType DelegateType; // 0x20
	private static Type[] s_SICtorParamTypes; // 0x28
	private const BindingFlags MemberBindingMask = 255;
	private const BindingFlags InvocationMask = 65280;
	private const BindingFlags BinderNonCreateInstance = 15616;
	private const BindingFlags BinderGetSetProperty = 12288;
	private const BindingFlags BinderSetInvokeProperty = 8448;
	private const BindingFlags BinderGetSetField = 3072;
	private const BindingFlags BinderSetInvokeField = 2304;
	private const BindingFlags BinderNonFieldGetSet = 16773888;
	private const BindingFlags ClassicBindingMask = 61696;
	private static RuntimeType s_typedRef; // 0x30
	private MonoTypeInfo type_info; // 0x18
	internal object GenericCache; // 0x20
	private RuntimeConstructorInfo m_serializationCtor; // 0x28

	// Properties
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override Type BaseType { get; }
	public override Type UnderlyingSystemType { get; }
	public override bool IsEnum { get; }
	public override GenericParameterAttributes GenericParameterAttributes { get; }
	internal override bool IsSzArray { get; }
	public override bool IsGenericTypeDefinition { get; }
	public override bool IsGenericParameter { get; }
	public override int GenericParameterPosition { get; }
	public override bool IsGenericType { get; }
	public override bool IsConstructedGenericType { get; }
	public override MemberTypes MemberType { get; }
	public override Type ReflectedType { get; }
	public override int MetadataToken { get; }
	public override bool ContainsGenericParameters { get; }
	public override Guid GUID { get; }
	public override MethodBase DeclaringMethod { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override string FullName { get; }
	public override bool IsSZArray { get; }

	// Methods

	// RVA: 0x1521650 Offset: 0x1521751 VA: 0x1521650
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x15217B0 Offset: 0x15218B1 VA: 0x15217B0
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x15219E0 Offset: 0x1521AE1 VA: 0x15219E0
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x1521B20 Offset: 0x1521C21 VA: 0x1521B20
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1521C70 Offset: 0x1521D71 VA: 0x1521C70
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1521DA0 Offset: 0x1521EA1 VA: 0x1521DA0
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x1521E30 Offset: 0x1521F31 VA: 0x1521E30
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x1522040 Offset: 0x1522141 VA: 0x1522040
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x1522170 Offset: 0x1522271 VA: 0x1522170
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x15224A0 Offset: 0x15225A1 VA: 0x15224A0
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1522210 Offset: 0x1522311 VA: 0x1522210
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1522540 Offset: 0x1522641 VA: 0x1522540
	internal void .ctor() { }

	// RVA: 0x15225B0 Offset: 0x15226B1 VA: 0x15225B0
	internal bool IsSpecialSerializableType() { }

	// RVA: 0x15228D0 Offset: 0x15229D1 VA: 0x15228D0
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1522F40 Offset: 0x1523041 VA: 0x1522F40
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x15235A0 Offset: 0x15236A1 VA: 0x15235A0
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1523BB0 Offset: 0x1523CB1 VA: 0x1523BB0
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1524140 Offset: 0x1524241 VA: 0x1524140
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x15246D0 Offset: 0x15247D1 VA: 0x15246D0
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1524C90 Offset: 0x1524D91 VA: 0x1524C90 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisibleAttribute] // RVA: 0xB6C20 Offset: 0xB6D21 VA: 0xB6C20
	// RVA: 0x1524D20 Offset: 0x1524E21 VA: 0x1524D20 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1524DC0 Offset: 0x1524EC1 VA: 0x1524DC0 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1524E50 Offset: 0x1524F51 VA: 0x1524E50 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1524EE0 Offset: 0x1524FE1 VA: 0x1524EE0 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1525120 Offset: 0x1525221 VA: 0x1525120 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1525380 Offset: 0x1525481 VA: 0x1525380 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1525570 Offset: 0x1525671 VA: 0x1525570 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x15257D0 Offset: 0x15258D1 VA: 0x15257D0 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x15259B0 Offset: 0x1525AB1 VA: 0x15259B0 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1525CB0 Offset: 0x1525DB1 VA: 0x1525CB0 Slot: 55
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x1525EC0 Offset: 0x1525FC1 VA: 0x1525EC0 Slot: 58
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x15262C0 Offset: 0x15263C1 VA: 0x15262C0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x15262D0 Offset: 0x15263D1 VA: 0x15262D0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x15262E0 Offset: 0x15263E1 VA: 0x15262E0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x15262F0 Offset: 0x15263F1 VA: 0x15262F0
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x1526300 Offset: 0x1526401 VA: 0x1526300 Slot: 25
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1526330 Offset: 0x1526431 VA: 0x1526330 Slot: 112
	public override bool IsInstanceOfType(object o) { }

	[ComVisibleAttribute] // RVA: 0xB6C40 Offset: 0xB6D41 VA: 0xB6C40
	// RVA: 0x1526340 Offset: 0x1526441 VA: 0x1526340 Slot: 111
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x1526520 Offset: 0x1526621 VA: 0x1526520 Slot: 121
	public override bool IsAssignableFrom(TypeInfo typeInfo) { }

	// RVA: 0x15265F0 Offset: 0x15266F1 VA: 0x15265F0 Slot: 113
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x1526700 Offset: 0x1526801 VA: 0x1526700 Slot: 114
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x1526800 Offset: 0x1526901 VA: 0x1526800 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x15226B0 Offset: 0x15227B1 VA: 0x15226B0
	private RuntimeType GetBaseType() { }

	// RVA: 0x1526810 Offset: 0x1526911 VA: 0x1526810 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1526820 Offset: 0x1526921 VA: 0x1526820 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1526830 Offset: 0x1526931 VA: 0x1526830 Slot: 98
	protected override bool IsContextfulImpl() { }

	// RVA: 0x1526840 Offset: 0x1526941 VA: 0x1526840 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x1526850 Offset: 0x1526951 VA: 0x1526850 Slot: 95
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1526860 Offset: 0x1526961 VA: 0x1526860 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x1526870 Offset: 0x1526971 VA: 0x1526870 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x1526880 Offset: 0x1526981 VA: 0x1526880 Slot: 90
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x15269B0 Offset: 0x1526AB1 VA: 0x15269B0 Slot: 72
	public override bool get_IsEnum() { }

	// RVA: 0x1526A30 Offset: 0x1526B31 VA: 0x1526A30 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1526A40 Offset: 0x1526B41 VA: 0x1526A40 Slot: 61
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1526B70 Offset: 0x1526C71 VA: 0x1526B70 Slot: 75
	internal override bool get_IsSzArray() { }

	// RVA: 0x1526B80 Offset: 0x1526C81 VA: 0x1526B80 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x1526B90 Offset: 0x1526C91 VA: 0x1526B90 Slot: 29
	public override int GetArrayRank() { }

	// RVA: 0x1526C40 Offset: 0x1526D41 VA: 0x1526C40 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x1526C50 Offset: 0x1526D51 VA: 0x1526C50 Slot: 105
	public override string[] GetEnumNames() { }

	// RVA: 0x1526D70 Offset: 0x1526E71 VA: 0x1526D70 Slot: 106
	public override Array GetEnumValues() { }

	// RVA: 0x1526F60 Offset: 0x1527061 VA: 0x1526F60 Slot: 107
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x1527040 Offset: 0x1527141 VA: 0x1527040 Slot: 108
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x1527590 Offset: 0x1527691 VA: 0x1527590 Slot: 109
	public override string GetEnumName(object value) { }

	// RVA: 0x1527790 Offset: 0x1527891 VA: 0x1527790
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x1527820 Offset: 0x1527921 VA: 0x1527820 Slot: 101
	public override Type[] GetGenericArguments() { }

	// RVA: 0x15278C0 Offset: 0x15279C1 VA: 0x15278C0 Slot: 97
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x1527E30 Offset: 0x1527F31 VA: 0x1527E30 Slot: 77
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x1527E40 Offset: 0x1527F41 VA: 0x1527E40 Slot: 79
	public override bool get_IsGenericParameter() { }

	// RVA: 0x1527E50 Offset: 0x1527F51 VA: 0x1527E50 Slot: 80
	public override int get_GenericParameterPosition() { }

	// RVA: 0x1527F10 Offset: 0x1528011 VA: 0x1527F10 Slot: 103
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x1527FC0 Offset: 0x15280C1 VA: 0x1527FC0 Slot: 76
	public override bool get_IsGenericType() { }

	// RVA: 0x1527FD0 Offset: 0x15280D1 VA: 0x1527FD0 Slot: 78
	public override bool get_IsConstructedGenericType() { }

	[DebuggerHiddenAttribute] // RVA: 0xB6C60 Offset: 0xB6D61 VA: 0xB6C60
	[DebuggerStepThroughAttribute] // RVA: 0xB6C60 Offset: 0xB6D61 VA: 0xB6C60
	// RVA: 0x1528030 Offset: 0x1528131 VA: 0x1528030 Slot: 23
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x15292F0 Offset: 0x15293F1 VA: 0x15292F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x151D210 Offset: 0x151D311 VA: 0x151D210
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x15228C0 Offset: 0x15229C1 VA: 0x15228C0
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x1529300 Offset: 0x1529401 VA: 0x1529300 Slot: 128
	public object Clone() { }

	// RVA: 0x1529310 Offset: 0x1529411 VA: 0x1529310 Slot: 127
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15293B0 Offset: 0x15294B1 VA: 0x15293B0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1529460 Offset: 0x1529561 VA: 0x1529460 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x15295F0 Offset: 0x15296F1 VA: 0x15295F0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1529780 Offset: 0x1529881 VA: 0x1529780 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x1529790 Offset: 0x1529891 VA: 0x1529790 Slot: 115
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x15299D0 Offset: 0x1529AD1 VA: 0x15299D0 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1529A30 Offset: 0x1529B31 VA: 0x1529A30 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x1529A40 Offset: 0x1529B41 VA: 0x1529A40 Slot: 14
	public override int get_MetadataToken() { }

	// RVA: 0x1529A50 Offset: 0x1529B51 VA: 0x1529A50
	private void CreateInstanceCheckThis() { }

	// RVA: 0x1529C60 Offset: 0x1529D61 VA: 0x1529C60
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThroughAttribute] // RVA: 0xB6CA0 Offset: 0xB6DA1 VA: 0xB6CA0
	[DebuggerHiddenAttribute] // RVA: 0xB6CA0 Offset: 0xB6DA1 VA: 0xB6CA0
	// RVA: 0x152A750 Offset: 0x152A851 VA: 0x152A750
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x152A8B0 Offset: 0x152A9B1 VA: 0x152A8B0
	internal MonoCMethod GetDefaultConstructor() { }

	// RVA: 0x1529200 Offset: 0x1529301 VA: 0x1529200
	private string GetDefaultMemberName() { }

	// RVA: 0x151B0C0 Offset: 0x151B1C1 VA: 0x151B0C0
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x152A870 Offset: 0x152A971 VA: 0x152A870
	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x152AA60 Offset: 0x152AB61 VA: 0x152AA60
	private object CreateInstanceMono(bool nonPublic) { }

	// RVA: 0x152AD60 Offset: 0x152AE61 VA: 0x152AD60
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x152AEE0 Offset: 0x152AFE1 VA: 0x152AEE0
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x152B140 Offset: 0x152B241 VA: 0x152B140
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x1529940 Offset: 0x1529A41 VA: 0x1529940
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x152BB50 Offset: 0x152BC51 VA: 0x152BB50
	private Type make_array_type(int rank) { }

	// RVA: 0x152BB60 Offset: 0x152BC61 VA: 0x152BB60 Slot: 19
	public override Type MakeArrayType() { }

	// RVA: 0x152BB70 Offset: 0x152BC71 VA: 0x152BB70 Slot: 20
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x152BC00 Offset: 0x152BD01 VA: 0x152BC00
	private Type make_byref_type() { }

	// RVA: 0x152BC10 Offset: 0x152BD11 VA: 0x152BC10 Slot: 18
	public override Type MakeByRefType() { }

	// RVA: 0x152BCA0 Offset: 0x152BDA1 VA: 0x152BCA0
	private static Type MakePointerType(Type type) { }

	// RVA: 0x152BCB0 Offset: 0x152BDB1 VA: 0x152BCB0 Slot: 17
	public override Type MakePointerType() { }

	// RVA: 0x152BD30 Offset: 0x152BE31 VA: 0x152BD30 Slot: 81
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x152BE50 Offset: 0x152BF51 VA: 0x152BE50 Slot: 82
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x152BF70 Offset: 0x152C071 VA: 0x152BF70
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x1527E20 Offset: 0x1527F21 VA: 0x1527E20
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x152C0A0 Offset: 0x152C1A1 VA: 0x152C0A0
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	// RVA: 0x1522C10 Offset: 0x1522D11 VA: 0x1522C10
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	// RVA: 0x152C0B0 Offset: 0x152C1B1 VA: 0x152C0B0
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) { }

	// RVA: 0x152C0C0 Offset: 0x152C1C1 VA: 0x152C0C0
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x1523320 Offset: 0x1523421 VA: 0x1523320
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1523880 Offset: 0x1523981 VA: 0x1523880
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	// RVA: 0x152C0D0 Offset: 0x152C1D1 VA: 0x152C0D0 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x152C210 Offset: 0x152C311 VA: 0x152C210
	internal static Type GetTypeFromCLSIDImpl(Guid clsid, string server, bool throwOnError) { }

	// RVA: 0x152C280 Offset: 0x152C381 VA: 0x152C280 Slot: 21
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x152C300 Offset: 0x152C401 VA: 0x152C300
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x152C310 Offset: 0x152C411 VA: 0x152C310 Slot: 3
	public override string ToString() { }

	// RVA: 0x152A740 Offset: 0x152A841 VA: 0x152A740
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x152AD50 Offset: 0x152AE51 VA: 0x152AD50
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0x152C330 Offset: 0x152C431 VA: 0x152C330 Slot: 16
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x152C320 Offset: 0x152C421 VA: 0x152C320
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x1527810 Offset: 0x1527911 VA: 0x1527810
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x1526B20 Offset: 0x1526C21 VA: 0x1526B20
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x1527F00 Offset: 0x1528001 VA: 0x1527F00
	private int GetGenericParameterPosition() { }

	// RVA: 0x152C340 Offset: 0x152C441 VA: 0x152C340
	private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x152C350 Offset: 0x152C451 VA: 0x152C350
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x15243B0 Offset: 0x15244B1 VA: 0x15243B0
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1523E20 Offset: 0x1523F21 VA: 0x1523E20
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x152C360 Offset: 0x152C461 VA: 0x152C360 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x152C370 Offset: 0x152C471 VA: 0x152C370
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x1524890 Offset: 0x1524991 VA: 0x1524890
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	// RVA: 0x152C380 Offset: 0x152C481 VA: 0x152C380 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x152C390 Offset: 0x152C491 VA: 0x152C390 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x152C3A0 Offset: 0x152C4A1 VA: 0x152C3A0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x152C3B0 Offset: 0x152C4B1 VA: 0x152C3B0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x152C3C0 Offset: 0x152C4C1 VA: 0x152C3C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x152C4B0 Offset: 0x152C5B1 VA: 0x152C4B0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x152C5C0 Offset: 0x152C6C1 VA: 0x152C5C0 Slot: 118
	public override bool get_IsSZArray() { }

	// RVA: 0x152C630 Offset: 0x152C731 VA: 0x152C630
	private static void .cctor() { }
}

[Serializable]
internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 301
{
	// Fields
	internal static readonly RuntimeType ValueType; // 0x0
	internal static readonly RuntimeType EnumType; // 0x8
	private static readonly RuntimeType ObjectType; // 0x10
	private static readonly RuntimeType StringType; // 0x18
	private static readonly RuntimeType DelegateType; // 0x20
	private static Type[] s_SICtorParamTypes; // 0x28
	private const BindingFlags MemberBindingMask = 255;
	private const BindingFlags InvocationMask = 65280;
	private const BindingFlags BinderNonCreateInstance = 15616;
	private const BindingFlags BinderGetSetProperty = 12288;
	private const BindingFlags BinderSetInvokeProperty = 8448;
	private const BindingFlags BinderGetSetField = 3072;
	private const BindingFlags BinderSetInvokeField = 2304;
	private const BindingFlags BinderNonFieldGetSet = 16773888;
	private const BindingFlags ClassicBindingMask = 61696;
	private static RuntimeType s_typedRef; // 0x30
	private MonoTypeInfo type_info; // 0x18
	internal object GenericCache; // 0x20
	private RuntimeConstructorInfo m_serializationCtor; // 0x28

	// Properties
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override Type BaseType { get; }
	public override Type UnderlyingSystemType { get; }
	public override bool IsEnum { get; }
	public override GenericParameterAttributes GenericParameterAttributes { get; }
	internal override bool IsSzArray { get; }
	public override bool IsGenericTypeDefinition { get; }
	public override bool IsGenericParameter { get; }
	public override int GenericParameterPosition { get; }
	public override bool IsGenericType { get; }
	public override bool IsConstructedGenericType { get; }
	public override MemberTypes MemberType { get; }
	public override Type ReflectedType { get; }
	public override int MetadataToken { get; }
	public override bool ContainsGenericParameters { get; }
	public override Guid GUID { get; }
	public override MethodBase DeclaringMethod { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override string FullName { get; }
	public override bool IsSZArray { get; }

	// Methods

	// RVA: 0x1521650 Offset: 0x1521751 VA: 0x1521650
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x15217B0 Offset: 0x15218B1 VA: 0x15217B0
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x15219E0 Offset: 0x1521AE1 VA: 0x15219E0
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x1521B20 Offset: 0x1521C21 VA: 0x1521B20
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1521C70 Offset: 0x1521D71 VA: 0x1521C70
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1521DA0 Offset: 0x1521EA1 VA: 0x1521DA0
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x1521E30 Offset: 0x1521F31 VA: 0x1521E30
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x1522040 Offset: 0x1522141 VA: 0x1522040
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x1522170 Offset: 0x1522271 VA: 0x1522170
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x15224A0 Offset: 0x15225A1 VA: 0x15224A0
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1522210 Offset: 0x1522311 VA: 0x1522210
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1522540 Offset: 0x1522641 VA: 0x1522540
	internal void .ctor() { }

	// RVA: 0x15225B0 Offset: 0x15226B1 VA: 0x15225B0
	internal bool IsSpecialSerializableType() { }

	// RVA: 0x15228D0 Offset: 0x15229D1 VA: 0x15228D0
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1522F40 Offset: 0x1523041 VA: 0x1522F40
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x15235A0 Offset: 0x15236A1 VA: 0x15235A0
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1523BB0 Offset: 0x1523CB1 VA: 0x1523BB0
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1524140 Offset: 0x1524241 VA: 0x1524140
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x15246D0 Offset: 0x15247D1 VA: 0x15246D0
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1524C90 Offset: 0x1524D91 VA: 0x1524C90 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisibleAttribute] // RVA: 0xB6C20 Offset: 0xB6D21 VA: 0xB6C20
	// RVA: 0x1524D20 Offset: 0x1524E21 VA: 0x1524D20 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1524DC0 Offset: 0x1524EC1 VA: 0x1524DC0 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1524E50 Offset: 0x1524F51 VA: 0x1524E50 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1524EE0 Offset: 0x1524FE1 VA: 0x1524EE0 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1525120 Offset: 0x1525221 VA: 0x1525120 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1525380 Offset: 0x1525481 VA: 0x1525380 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1525570 Offset: 0x1525671 VA: 0x1525570 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x15257D0 Offset: 0x15258D1 VA: 0x15257D0 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x15259B0 Offset: 0x1525AB1 VA: 0x15259B0 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1525CB0 Offset: 0x1525DB1 VA: 0x1525CB0 Slot: 55
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x1525EC0 Offset: 0x1525FC1 VA: 0x1525EC0 Slot: 58
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x15262C0 Offset: 0x15263C1 VA: 0x15262C0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x15262D0 Offset: 0x15263D1 VA: 0x15262D0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x15262E0 Offset: 0x15263E1 VA: 0x15262E0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x15262F0 Offset: 0x15263F1 VA: 0x15262F0
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x1526300 Offset: 0x1526401 VA: 0x1526300 Slot: 25
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1526330 Offset: 0x1526431 VA: 0x1526330 Slot: 112
	public override bool IsInstanceOfType(object o) { }

	[ComVisibleAttribute] // RVA: 0xB6C40 Offset: 0xB6D41 VA: 0xB6C40
	// RVA: 0x1526340 Offset: 0x1526441 VA: 0x1526340 Slot: 111
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x1526520 Offset: 0x1526621 VA: 0x1526520 Slot: 121
	public override bool IsAssignableFrom(TypeInfo typeInfo) { }

	// RVA: 0x15265F0 Offset: 0x15266F1 VA: 0x15265F0 Slot: 113
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x1526700 Offset: 0x1526801 VA: 0x1526700 Slot: 114
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x1526800 Offset: 0x1526901 VA: 0x1526800 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x15226B0 Offset: 0x15227B1 VA: 0x15226B0
	private RuntimeType GetBaseType() { }

	// RVA: 0x1526810 Offset: 0x1526911 VA: 0x1526810 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1526820 Offset: 0x1526921 VA: 0x1526820 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1526830 Offset: 0x1526931 VA: 0x1526830 Slot: 98
	protected override bool IsContextfulImpl() { }

	// RVA: 0x1526840 Offset: 0x1526941 VA: 0x1526840 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x1526850 Offset: 0x1526951 VA: 0x1526850 Slot: 95
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1526860 Offset: 0x1526961 VA: 0x1526860 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x1526870 Offset: 0x1526971 VA: 0x1526870 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x1526880 Offset: 0x1526981 VA: 0x1526880 Slot: 90
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x15269B0 Offset: 0x1526AB1 VA: 0x15269B0 Slot: 72
	public override bool get_IsEnum() { }

	// RVA: 0x1526A30 Offset: 0x1526B31 VA: 0x1526A30 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1526A40 Offset: 0x1526B41 VA: 0x1526A40 Slot: 61
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1526B70 Offset: 0x1526C71 VA: 0x1526B70 Slot: 75
	internal override bool get_IsSzArray() { }

	// RVA: 0x1526B80 Offset: 0x1526C81 VA: 0x1526B80 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x1526B90 Offset: 0x1526C91 VA: 0x1526B90 Slot: 29
	public override int GetArrayRank() { }

	// RVA: 0x1526C40 Offset: 0x1526D41 VA: 0x1526C40 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x1526C50 Offset: 0x1526D51 VA: 0x1526C50 Slot: 105
	public override string[] GetEnumNames() { }

	// RVA: 0x1526D70 Offset: 0x1526E71 VA: 0x1526D70 Slot: 106
	public override Array GetEnumValues() { }

	// RVA: 0x1526F60 Offset: 0x1527061 VA: 0x1526F60 Slot: 107
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x1527040 Offset: 0x1527141 VA: 0x1527040 Slot: 108
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x1527590 Offset: 0x1527691 VA: 0x1527590 Slot: 109
	public override string GetEnumName(object value) { }

	// RVA: 0x1527790 Offset: 0x1527891 VA: 0x1527790
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x1527820 Offset: 0x1527921 VA: 0x1527820 Slot: 101
	public override Type[] GetGenericArguments() { }

	// RVA: 0x15278C0 Offset: 0x15279C1 VA: 0x15278C0 Slot: 97
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x1527E30 Offset: 0x1527F31 VA: 0x1527E30 Slot: 77
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x1527E40 Offset: 0x1527F41 VA: 0x1527E40 Slot: 79
	public override bool get_IsGenericParameter() { }

	// RVA: 0x1527E50 Offset: 0x1527F51 VA: 0x1527E50 Slot: 80
	public override int get_GenericParameterPosition() { }

	// RVA: 0x1527F10 Offset: 0x1528011 VA: 0x1527F10 Slot: 103
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x1527FC0 Offset: 0x15280C1 VA: 0x1527FC0 Slot: 76
	public override bool get_IsGenericType() { }

	// RVA: 0x1527FD0 Offset: 0x15280D1 VA: 0x1527FD0 Slot: 78
	public override bool get_IsConstructedGenericType() { }

	[DebuggerHiddenAttribute] // RVA: 0xB6C60 Offset: 0xB6D61 VA: 0xB6C60
	[DebuggerStepThroughAttribute] // RVA: 0xB6C60 Offset: 0xB6D61 VA: 0xB6C60
	// RVA: 0x1528030 Offset: 0x1528131 VA: 0x1528030 Slot: 23
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x15292F0 Offset: 0x15293F1 VA: 0x15292F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x151D210 Offset: 0x151D311 VA: 0x151D210
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x15228C0 Offset: 0x15229C1 VA: 0x15228C0
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x1529300 Offset: 0x1529401 VA: 0x1529300 Slot: 128
	public object Clone() { }

	// RVA: 0x1529310 Offset: 0x1529411 VA: 0x1529310 Slot: 127
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15293B0 Offset: 0x15294B1 VA: 0x15293B0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1529460 Offset: 0x1529561 VA: 0x1529460 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x15295F0 Offset: 0x15296F1 VA: 0x15295F0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1529780 Offset: 0x1529881 VA: 0x1529780 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x1529790 Offset: 0x1529891 VA: 0x1529790 Slot: 115
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x15299D0 Offset: 0x1529AD1 VA: 0x15299D0 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1529A30 Offset: 0x1529B31 VA: 0x1529A30 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x1529A40 Offset: 0x1529B41 VA: 0x1529A40 Slot: 14
	public override int get_MetadataToken() { }

	// RVA: 0x1529A50 Offset: 0x1529B51 VA: 0x1529A50
	private void CreateInstanceCheckThis() { }

	// RVA: 0x1529C60 Offset: 0x1529D61 VA: 0x1529C60
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThroughAttribute] // RVA: 0xB6CA0 Offset: 0xB6DA1 VA: 0xB6CA0
	[DebuggerHiddenAttribute] // RVA: 0xB6CA0 Offset: 0xB6DA1 VA: 0xB6CA0
	// RVA: 0x152A750 Offset: 0x152A851 VA: 0x152A750
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x152A8B0 Offset: 0x152A9B1 VA: 0x152A8B0
	internal MonoCMethod GetDefaultConstructor() { }

	// RVA: 0x1529200 Offset: 0x1529301 VA: 0x1529200
	private string GetDefaultMemberName() { }

	// RVA: 0x151B0C0 Offset: 0x151B1C1 VA: 0x151B0C0
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x152A870 Offset: 0x152A971 VA: 0x152A870
	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x152AA60 Offset: 0x152AB61 VA: 0x152AA60
	private object CreateInstanceMono(bool nonPublic) { }

	// RVA: 0x152AD60 Offset: 0x152AE61 VA: 0x152AD60
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x152AEE0 Offset: 0x152AFE1 VA: 0x152AEE0
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x152B140 Offset: 0x152B241 VA: 0x152B140
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x1529940 Offset: 0x1529A41 VA: 0x1529940
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x152BB50 Offset: 0x152BC51 VA: 0x152BB50
	private Type make_array_type(int rank) { }

	// RVA: 0x152BB60 Offset: 0x152BC61 VA: 0x152BB60 Slot: 19
	public override Type MakeArrayType() { }

	// RVA: 0x152BB70 Offset: 0x152BC71 VA: 0x152BB70 Slot: 20
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x152BC00 Offset: 0x152BD01 VA: 0x152BC00
	private Type make_byref_type() { }

	// RVA: 0x152BC10 Offset: 0x152BD11 VA: 0x152BC10 Slot: 18
	public override Type MakeByRefType() { }

	// RVA: 0x152BCA0 Offset: 0x152BDA1 VA: 0x152BCA0
	private static Type MakePointerType(Type type) { }

	// RVA: 0x152BCB0 Offset: 0x152BDB1 VA: 0x152BCB0 Slot: 17
	public override Type MakePointerType() { }

	// RVA: 0x152BD30 Offset: 0x152BE31 VA: 0x152BD30 Slot: 81
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x152BE50 Offset: 0x152BF51 VA: 0x152BE50 Slot: 82
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x152BF70 Offset: 0x152C071 VA: 0x152BF70
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x1527E20 Offset: 0x1527F21 VA: 0x1527E20
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x152C0A0 Offset: 0x152C1A1 VA: 0x152C0A0
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	// RVA: 0x1522C10 Offset: 0x1522D11 VA: 0x1522C10
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	// RVA: 0x152C0B0 Offset: 0x152C1B1 VA: 0x152C0B0
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) { }

	// RVA: 0x152C0C0 Offset: 0x152C1C1 VA: 0x152C0C0
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x1523320 Offset: 0x1523421 VA: 0x1523320
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1523880 Offset: 0x1523981 VA: 0x1523880
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	// RVA: 0x152C0D0 Offset: 0x152C1D1 VA: 0x152C0D0 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x152C210 Offset: 0x152C311 VA: 0x152C210
	internal static Type GetTypeFromCLSIDImpl(Guid clsid, string server, bool throwOnError) { }

	// RVA: 0x152C280 Offset: 0x152C381 VA: 0x152C280 Slot: 21
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x152C300 Offset: 0x152C401 VA: 0x152C300
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x152C310 Offset: 0x152C411 VA: 0x152C310 Slot: 3
	public override string ToString() { }

	// RVA: 0x152A740 Offset: 0x152A841 VA: 0x152A740
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x152AD50 Offset: 0x152AE51 VA: 0x152AD50
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0x152C330 Offset: 0x152C431 VA: 0x152C330 Slot: 16
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x152C320 Offset: 0x152C421 VA: 0x152C320
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x1527810 Offset: 0x1527911 VA: 0x1527810
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x1526B20 Offset: 0x1526C21 VA: 0x1526B20
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x1527F00 Offset: 0x1528001 VA: 0x1527F00
	private int GetGenericParameterPosition() { }

	// RVA: 0x152C340 Offset: 0x152C441 VA: 0x152C340
	private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x152C350 Offset: 0x152C451 VA: 0x152C350
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x15243B0 Offset: 0x15244B1 VA: 0x15243B0
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1523E20 Offset: 0x1523F21 VA: 0x1523E20
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x152C360 Offset: 0x152C461 VA: 0x152C360 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x152C370 Offset: 0x152C471 VA: 0x152C370
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x1524890 Offset: 0x1524991 VA: 0x1524890
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	// RVA: 0x152C380 Offset: 0x152C481 VA: 0x152C380 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x152C390 Offset: 0x152C491 VA: 0x152C390 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x152C3A0 Offset: 0x152C4A1 VA: 0x152C3A0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x152C3B0 Offset: 0x152C4B1 VA: 0x152C3B0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x152C3C0 Offset: 0x152C4C1 VA: 0x152C3C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x152C4B0 Offset: 0x152C5B1 VA: 0x152C4B0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x152C5C0 Offset: 0x152C6C1 VA: 0x152C5C0 Slot: 118
	public override bool get_IsSZArray() { }

	// RVA: 0x152C630 Offset: 0x152C731 VA: 0x152C630
	private static void .cctor() { }
}

[Serializable]
internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 301
{
	// Fields
	internal static readonly RuntimeType ValueType; // 0x0
	internal static readonly RuntimeType EnumType; // 0x8
	private static readonly RuntimeType ObjectType; // 0x10
	private static readonly RuntimeType StringType; // 0x18
	private static readonly RuntimeType DelegateType; // 0x20
	private static Type[] s_SICtorParamTypes; // 0x28
	private const BindingFlags MemberBindingMask = 255;
	private const BindingFlags InvocationMask = 65280;
	private const BindingFlags BinderNonCreateInstance = 15616;
	private const BindingFlags BinderGetSetProperty = 12288;
	private const BindingFlags BinderSetInvokeProperty = 8448;
	private const BindingFlags BinderGetSetField = 3072;
	private const BindingFlags BinderSetInvokeField = 2304;
	private const BindingFlags BinderNonFieldGetSet = 16773888;
	private const BindingFlags ClassicBindingMask = 61696;
	private static RuntimeType s_typedRef; // 0x30
	private MonoTypeInfo type_info; // 0x18
	internal object GenericCache; // 0x20
	private RuntimeConstructorInfo m_serializationCtor; // 0x28

	// Properties
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override Type BaseType { get; }
	public override Type UnderlyingSystemType { get; }
	public override bool IsEnum { get; }
	public override GenericParameterAttributes GenericParameterAttributes { get; }
	internal override bool IsSzArray { get; }
	public override bool IsGenericTypeDefinition { get; }
	public override bool IsGenericParameter { get; }
	public override int GenericParameterPosition { get; }
	public override bool IsGenericType { get; }
	public override bool IsConstructedGenericType { get; }
	public override MemberTypes MemberType { get; }
	public override Type ReflectedType { get; }
	public override int MetadataToken { get; }
	public override bool ContainsGenericParameters { get; }
	public override Guid GUID { get; }
	public override MethodBase DeclaringMethod { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override string FullName { get; }
	public override bool IsSZArray { get; }

	// Methods

	// RVA: 0x1521650 Offset: 0x1521751 VA: 0x1521650
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x15217B0 Offset: 0x15218B1 VA: 0x15217B0
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x15219E0 Offset: 0x1521AE1 VA: 0x15219E0
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x1521B20 Offset: 0x1521C21 VA: 0x1521B20
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1521C70 Offset: 0x1521D71 VA: 0x1521C70
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1521DA0 Offset: 0x1521EA1 VA: 0x1521DA0
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x1521E30 Offset: 0x1521F31 VA: 0x1521E30
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x1522040 Offset: 0x1522141 VA: 0x1522040
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x1522170 Offset: 0x1522271 VA: 0x1522170
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x15224A0 Offset: 0x15225A1 VA: 0x15224A0
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1522210 Offset: 0x1522311 VA: 0x1522210
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1522540 Offset: 0x1522641 VA: 0x1522540
	internal void .ctor() { }

	// RVA: 0x15225B0 Offset: 0x15226B1 VA: 0x15225B0
	internal bool IsSpecialSerializableType() { }

	// RVA: 0x15228D0 Offset: 0x15229D1 VA: 0x15228D0
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1522F40 Offset: 0x1523041 VA: 0x1522F40
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x15235A0 Offset: 0x15236A1 VA: 0x15235A0
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1523BB0 Offset: 0x1523CB1 VA: 0x1523BB0
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1524140 Offset: 0x1524241 VA: 0x1524140
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x15246D0 Offset: 0x15247D1 VA: 0x15246D0
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1524C90 Offset: 0x1524D91 VA: 0x1524C90 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisibleAttribute] // RVA: 0xB6C20 Offset: 0xB6D21 VA: 0xB6C20
	// RVA: 0x1524D20 Offset: 0x1524E21 VA: 0x1524D20 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1524DC0 Offset: 0x1524EC1 VA: 0x1524DC0 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1524E50 Offset: 0x1524F51 VA: 0x1524E50 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1524EE0 Offset: 0x1524FE1 VA: 0x1524EE0 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1525120 Offset: 0x1525221 VA: 0x1525120 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1525380 Offset: 0x1525481 VA: 0x1525380 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1525570 Offset: 0x1525671 VA: 0x1525570 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x15257D0 Offset: 0x15258D1 VA: 0x15257D0 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x15259B0 Offset: 0x1525AB1 VA: 0x15259B0 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1525CB0 Offset: 0x1525DB1 VA: 0x1525CB0 Slot: 55
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x1525EC0 Offset: 0x1525FC1 VA: 0x1525EC0 Slot: 58
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x15262C0 Offset: 0x15263C1 VA: 0x15262C0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x15262D0 Offset: 0x15263D1 VA: 0x15262D0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x15262E0 Offset: 0x15263E1 VA: 0x15262E0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x15262F0 Offset: 0x15263F1 VA: 0x15262F0
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x1526300 Offset: 0x1526401 VA: 0x1526300 Slot: 25
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1526330 Offset: 0x1526431 VA: 0x1526330 Slot: 112
	public override bool IsInstanceOfType(object o) { }

	[ComVisibleAttribute] // RVA: 0xB6C40 Offset: 0xB6D41 VA: 0xB6C40
	// RVA: 0x1526340 Offset: 0x1526441 VA: 0x1526340 Slot: 111
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x1526520 Offset: 0x1526621 VA: 0x1526520 Slot: 121
	public override bool IsAssignableFrom(TypeInfo typeInfo) { }

	// RVA: 0x15265F0 Offset: 0x15266F1 VA: 0x15265F0 Slot: 113
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x1526700 Offset: 0x1526801 VA: 0x1526700 Slot: 114
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x1526800 Offset: 0x1526901 VA: 0x1526800 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x15226B0 Offset: 0x15227B1 VA: 0x15226B0
	private RuntimeType GetBaseType() { }

	// RVA: 0x1526810 Offset: 0x1526911 VA: 0x1526810 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1526820 Offset: 0x1526921 VA: 0x1526820 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1526830 Offset: 0x1526931 VA: 0x1526830 Slot: 98
	protected override bool IsContextfulImpl() { }

	// RVA: 0x1526840 Offset: 0x1526941 VA: 0x1526840 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x1526850 Offset: 0x1526951 VA: 0x1526850 Slot: 95
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1526860 Offset: 0x1526961 VA: 0x1526860 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x1526870 Offset: 0x1526971 VA: 0x1526870 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x1526880 Offset: 0x1526981 VA: 0x1526880 Slot: 90
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x15269B0 Offset: 0x1526AB1 VA: 0x15269B0 Slot: 72
	public override bool get_IsEnum() { }

	// RVA: 0x1526A30 Offset: 0x1526B31 VA: 0x1526A30 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1526A40 Offset: 0x1526B41 VA: 0x1526A40 Slot: 61
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1526B70 Offset: 0x1526C71 VA: 0x1526B70 Slot: 75
	internal override bool get_IsSzArray() { }

	// RVA: 0x1526B80 Offset: 0x1526C81 VA: 0x1526B80 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x1526B90 Offset: 0x1526C91 VA: 0x1526B90 Slot: 29
	public override int GetArrayRank() { }

	// RVA: 0x1526C40 Offset: 0x1526D41 VA: 0x1526C40 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x1526C50 Offset: 0x1526D51 VA: 0x1526C50 Slot: 105
	public override string[] GetEnumNames() { }

	// RVA: 0x1526D70 Offset: 0x1526E71 VA: 0x1526D70 Slot: 106
	public override Array GetEnumValues() { }

	// RVA: 0x1526F60 Offset: 0x1527061 VA: 0x1526F60 Slot: 107
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x1527040 Offset: 0x1527141 VA: 0x1527040 Slot: 108
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x1527590 Offset: 0x1527691 VA: 0x1527590 Slot: 109
	public override string GetEnumName(object value) { }

	// RVA: 0x1527790 Offset: 0x1527891 VA: 0x1527790
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x1527820 Offset: 0x1527921 VA: 0x1527820 Slot: 101
	public override Type[] GetGenericArguments() { }

	// RVA: 0x15278C0 Offset: 0x15279C1 VA: 0x15278C0 Slot: 97
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x1527E30 Offset: 0x1527F31 VA: 0x1527E30 Slot: 77
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x1527E40 Offset: 0x1527F41 VA: 0x1527E40 Slot: 79
	public override bool get_IsGenericParameter() { }

	// RVA: 0x1527E50 Offset: 0x1527F51 VA: 0x1527E50 Slot: 80
	public override int get_GenericParameterPosition() { }

	// RVA: 0x1527F10 Offset: 0x1528011 VA: 0x1527F10 Slot: 103
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x1527FC0 Offset: 0x15280C1 VA: 0x1527FC0 Slot: 76
	public override bool get_IsGenericType() { }

	// RVA: 0x1527FD0 Offset: 0x15280D1 VA: 0x1527FD0 Slot: 78
	public override bool get_IsConstructedGenericType() { }

	[DebuggerHiddenAttribute] // RVA: 0xB6C60 Offset: 0xB6D61 VA: 0xB6C60
	[DebuggerStepThroughAttribute] // RVA: 0xB6C60 Offset: 0xB6D61 VA: 0xB6C60
	// RVA: 0x1528030 Offset: 0x1528131 VA: 0x1528030 Slot: 23
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x15292F0 Offset: 0x15293F1 VA: 0x15292F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x151D210 Offset: 0x151D311 VA: 0x151D210
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x15228C0 Offset: 0x15229C1 VA: 0x15228C0
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x1529300 Offset: 0x1529401 VA: 0x1529300 Slot: 128
	public object Clone() { }

	// RVA: 0x1529310 Offset: 0x1529411 VA: 0x1529310 Slot: 127
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15293B0 Offset: 0x15294B1 VA: 0x15293B0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1529460 Offset: 0x1529561 VA: 0x1529460 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x15295F0 Offset: 0x15296F1 VA: 0x15295F0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1529780 Offset: 0x1529881 VA: 0x1529780 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x1529790 Offset: 0x1529891 VA: 0x1529790 Slot: 115
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x15299D0 Offset: 0x1529AD1 VA: 0x15299D0 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1529A30 Offset: 0x1529B31 VA: 0x1529A30 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x1529A40 Offset: 0x1529B41 VA: 0x1529A40 Slot: 14
	public override int get_MetadataToken() { }

	// RVA: 0x1529A50 Offset: 0x1529B51 VA: 0x1529A50
	private void CreateInstanceCheckThis() { }

	// RVA: 0x1529C60 Offset: 0x1529D61 VA: 0x1529C60
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThroughAttribute] // RVA: 0xB6CA0 Offset: 0xB6DA1 VA: 0xB6CA0
	[DebuggerHiddenAttribute] // RVA: 0xB6CA0 Offset: 0xB6DA1 VA: 0xB6CA0
	// RVA: 0x152A750 Offset: 0x152A851 VA: 0x152A750
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x152A8B0 Offset: 0x152A9B1 VA: 0x152A8B0
	internal MonoCMethod GetDefaultConstructor() { }

	// RVA: 0x1529200 Offset: 0x1529301 VA: 0x1529200
	private string GetDefaultMemberName() { }

	// RVA: 0x151B0C0 Offset: 0x151B1C1 VA: 0x151B0C0
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x152A870 Offset: 0x152A971 VA: 0x152A870
	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x152AA60 Offset: 0x152AB61 VA: 0x152AA60
	private object CreateInstanceMono(bool nonPublic) { }

	// RVA: 0x152AD60 Offset: 0x152AE61 VA: 0x152AD60
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x152AEE0 Offset: 0x152AFE1 VA: 0x152AEE0
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x152B140 Offset: 0x152B241 VA: 0x152B140
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x1529940 Offset: 0x1529A41 VA: 0x1529940
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x152BB50 Offset: 0x152BC51 VA: 0x152BB50
	private Type make_array_type(int rank) { }

	// RVA: 0x152BB60 Offset: 0x152BC61 VA: 0x152BB60 Slot: 19
	public override Type MakeArrayType() { }

	// RVA: 0x152BB70 Offset: 0x152BC71 VA: 0x152BB70 Slot: 20
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x152BC00 Offset: 0x152BD01 VA: 0x152BC00
	private Type make_byref_type() { }

	// RVA: 0x152BC10 Offset: 0x152BD11 VA: 0x152BC10 Slot: 18
	public override Type MakeByRefType() { }

	// RVA: 0x152BCA0 Offset: 0x152BDA1 VA: 0x152BCA0
	private static Type MakePointerType(Type type) { }

	// RVA: 0x152BCB0 Offset: 0x152BDB1 VA: 0x152BCB0 Slot: 17
	public override Type MakePointerType() { }

	// RVA: 0x152BD30 Offset: 0x152BE31 VA: 0x152BD30 Slot: 81
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x152BE50 Offset: 0x152BF51 VA: 0x152BE50 Slot: 82
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x152BF70 Offset: 0x152C071 VA: 0x152BF70
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x1527E20 Offset: 0x1527F21 VA: 0x1527E20
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x152C0A0 Offset: 0x152C1A1 VA: 0x152C0A0
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	// RVA: 0x1522C10 Offset: 0x1522D11 VA: 0x1522C10
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	// RVA: 0x152C0B0 Offset: 0x152C1B1 VA: 0x152C0B0
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) { }

	// RVA: 0x152C0C0 Offset: 0x152C1C1 VA: 0x152C0C0
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x1523320 Offset: 0x1523421 VA: 0x1523320
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1523880 Offset: 0x1523981 VA: 0x1523880
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	// RVA: 0x152C0D0 Offset: 0x152C1D1 VA: 0x152C0D0 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x152C210 Offset: 0x152C311 VA: 0x152C210
	internal static Type GetTypeFromCLSIDImpl(Guid clsid, string server, bool throwOnError) { }

	// RVA: 0x152C280 Offset: 0x152C381 VA: 0x152C280 Slot: 21
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x152C300 Offset: 0x152C401 VA: 0x152C300
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x152C310 Offset: 0x152C411 VA: 0x152C310 Slot: 3
	public override string ToString() { }

	// RVA: 0x152A740 Offset: 0x152A841 VA: 0x152A740
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x152AD50 Offset: 0x152AE51 VA: 0x152AD50
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0x152C330 Offset: 0x152C431 VA: 0x152C330 Slot: 16
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x152C320 Offset: 0x152C421 VA: 0x152C320
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x1527810 Offset: 0x1527911 VA: 0x1527810
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x1526B20 Offset: 0x1526C21 VA: 0x1526B20
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x1527F00 Offset: 0x1528001 VA: 0x1527F00
	private int GetGenericParameterPosition() { }

	// RVA: 0x152C340 Offset: 0x152C441 VA: 0x152C340
	private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x152C350 Offset: 0x152C451 VA: 0x152C350
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x15243B0 Offset: 0x15244B1 VA: 0x15243B0
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1523E20 Offset: 0x1523F21 VA: 0x1523E20
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x152C360 Offset: 0x152C461 VA: 0x152C360 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x152C370 Offset: 0x152C471 VA: 0x152C370
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x1524890 Offset: 0x1524991 VA: 0x1524890
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	// RVA: 0x152C380 Offset: 0x152C481 VA: 0x152C380 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x152C390 Offset: 0x152C491 VA: 0x152C390 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x152C3A0 Offset: 0x152C4A1 VA: 0x152C3A0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x152C3B0 Offset: 0x152C4B1 VA: 0x152C3B0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x152C3C0 Offset: 0x152C4C1 VA: 0x152C3C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x152C4B0 Offset: 0x152C5B1 VA: 0x152C4B0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x152C5C0 Offset: 0x152C6C1 VA: 0x152C5C0 Slot: 118
	public override bool get_IsSZArray() { }

	// RVA: 0x152C630 Offset: 0x152C731 VA: 0x152C630
	private static void .cctor() { }
}

[Serializable]
internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 301
{
	// Fields
	internal static readonly RuntimeType ValueType; // 0x0
	internal static readonly RuntimeType EnumType; // 0x8
	private static readonly RuntimeType ObjectType; // 0x10
	private static readonly RuntimeType StringType; // 0x18
	private static readonly RuntimeType DelegateType; // 0x20
	private static Type[] s_SICtorParamTypes; // 0x28
	private const BindingFlags MemberBindingMask = 255;
	private const BindingFlags InvocationMask = 65280;
	private const BindingFlags BinderNonCreateInstance = 15616;
	private const BindingFlags BinderGetSetProperty = 12288;
	private const BindingFlags BinderSetInvokeProperty = 8448;
	private const BindingFlags BinderGetSetField = 3072;
	private const BindingFlags BinderSetInvokeField = 2304;
	private const BindingFlags BinderNonFieldGetSet = 16773888;
	private const BindingFlags ClassicBindingMask = 61696;
	private static RuntimeType s_typedRef; // 0x30
	private MonoTypeInfo type_info; // 0x18
	internal object GenericCache; // 0x20
	private RuntimeConstructorInfo m_serializationCtor; // 0x28

	// Properties
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override Type BaseType { get; }
	public override Type UnderlyingSystemType { get; }
	public override bool IsEnum { get; }
	public override GenericParameterAttributes GenericParameterAttributes { get; }
	internal override bool IsSzArray { get; }
	public override bool IsGenericTypeDefinition { get; }
	public override bool IsGenericParameter { get; }
	public override int GenericParameterPosition { get; }
	public override bool IsGenericType { get; }
	public override bool IsConstructedGenericType { get; }
	public override MemberTypes MemberType { get; }
	public override Type ReflectedType { get; }
	public override int MetadataToken { get; }
	public override bool ContainsGenericParameters { get; }
	public override Guid GUID { get; }
	public override MethodBase DeclaringMethod { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override string FullName { get; }
	public override bool IsSZArray { get; }

	// Methods

	// RVA: 0x1521650 Offset: 0x1521751 VA: 0x1521650
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x15217B0 Offset: 0x15218B1 VA: 0x15217B0
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x15219E0 Offset: 0x1521AE1 VA: 0x15219E0
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x1521B20 Offset: 0x1521C21 VA: 0x1521B20
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1521C70 Offset: 0x1521D71 VA: 0x1521C70
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1521DA0 Offset: 0x1521EA1 VA: 0x1521DA0
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x1521E30 Offset: 0x1521F31 VA: 0x1521E30
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x1522040 Offset: 0x1522141 VA: 0x1522040
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x1522170 Offset: 0x1522271 VA: 0x1522170
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x15224A0 Offset: 0x15225A1 VA: 0x15224A0
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1522210 Offset: 0x1522311 VA: 0x1522210
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1522540 Offset: 0x1522641 VA: 0x1522540
	internal void .ctor() { }

	// RVA: 0x15225B0 Offset: 0x15226B1 VA: 0x15225B0
	internal bool IsSpecialSerializableType() { }

	// RVA: 0x15228D0 Offset: 0x15229D1 VA: 0x15228D0
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1522F40 Offset: 0x1523041 VA: 0x1522F40
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x15235A0 Offset: 0x15236A1 VA: 0x15235A0
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1523BB0 Offset: 0x1523CB1 VA: 0x1523BB0
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1524140 Offset: 0x1524241 VA: 0x1524140
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x15246D0 Offset: 0x15247D1 VA: 0x15246D0
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1524C90 Offset: 0x1524D91 VA: 0x1524C90 Slot: 42
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisibleAttribute] // RVA: 0xB6C20 Offset: 0xB6D21 VA: 0xB6C20
	// RVA: 0x1524D20 Offset: 0x1524E21 VA: 0x1524D20 Slot: 35
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1524DC0 Offset: 0x1524EC1 VA: 0x1524DC0 Slot: 54
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1524E50 Offset: 0x1524F51 VA: 0x1524E50 Slot: 46
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1524EE0 Offset: 0x1524FE1 VA: 0x1524EE0 Slot: 59
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1525120 Offset: 0x1525221 VA: 0x1525120 Slot: 40
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1525380 Offset: 0x1525481 VA: 0x1525380 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1525570 Offset: 0x1525671 VA: 0x1525570 Slot: 53
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x15257D0 Offset: 0x15258D1 VA: 0x15257D0 Slot: 48
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x15259B0 Offset: 0x1525AB1 VA: 0x15259B0 Slot: 43
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1525CB0 Offset: 0x1525DB1 VA: 0x1525CB0 Slot: 55
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x1525EC0 Offset: 0x1525FC1 VA: 0x1525EC0 Slot: 58
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x15262C0 Offset: 0x15263C1 VA: 0x15262C0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x15262D0 Offset: 0x15263D1 VA: 0x15262D0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x15262E0 Offset: 0x15263E1 VA: 0x15262E0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x15262F0 Offset: 0x15263F1 VA: 0x15262F0
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x1526300 Offset: 0x1526401 VA: 0x1526300 Slot: 25
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1526330 Offset: 0x1526431 VA: 0x1526330 Slot: 112
	public override bool IsInstanceOfType(object o) { }

	[ComVisibleAttribute] // RVA: 0xB6C40 Offset: 0xB6D41 VA: 0xB6C40
	// RVA: 0x1526340 Offset: 0x1526441 VA: 0x1526340 Slot: 111
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x1526520 Offset: 0x1526621 VA: 0x1526520 Slot: 121
	public override bool IsAssignableFrom(TypeInfo typeInfo) { }

	// RVA: 0x15265F0 Offset: 0x15266F1 VA: 0x15265F0 Slot: 113
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x1526700 Offset: 0x1526801 VA: 0x1526700 Slot: 114
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x1526800 Offset: 0x1526901 VA: 0x1526800 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x15226B0 Offset: 0x15227B1 VA: 0x15226B0
	private RuntimeType GetBaseType() { }

	// RVA: 0x1526810 Offset: 0x1526911 VA: 0x1526810 Slot: 110
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1526820 Offset: 0x1526921 VA: 0x1526820 Slot: 91
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1526830 Offset: 0x1526931 VA: 0x1526830 Slot: 98
	protected override bool IsContextfulImpl() { }

	// RVA: 0x1526840 Offset: 0x1526941 VA: 0x1526840 Slot: 93
	protected override bool IsByRefImpl() { }

	// RVA: 0x1526850 Offset: 0x1526951 VA: 0x1526850 Slot: 95
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1526860 Offset: 0x1526961 VA: 0x1526860 Slot: 94
	protected override bool IsPointerImpl() { }

	// RVA: 0x1526870 Offset: 0x1526971 VA: 0x1526870 Slot: 96
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x1526880 Offset: 0x1526981 VA: 0x1526880 Slot: 90
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x15269B0 Offset: 0x1526AB1 VA: 0x15269B0 Slot: 72
	public override bool get_IsEnum() { }

	// RVA: 0x1526A30 Offset: 0x1526B31 VA: 0x1526A30 Slot: 104
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1526A40 Offset: 0x1526B41 VA: 0x1526A40 Slot: 61
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1526B70 Offset: 0x1526C71 VA: 0x1526B70 Slot: 75
	internal override bool get_IsSzArray() { }

	// RVA: 0x1526B80 Offset: 0x1526C81 VA: 0x1526B80 Slot: 92
	protected override bool IsArrayImpl() { }

	// RVA: 0x1526B90 Offset: 0x1526C91 VA: 0x1526B90 Slot: 29
	public override int GetArrayRank() { }

	// RVA: 0x1526C40 Offset: 0x1526D41 VA: 0x1526C40 Slot: 100
	public override Type GetElementType() { }

	// RVA: 0x1526C50 Offset: 0x1526D51 VA: 0x1526C50 Slot: 105
	public override string[] GetEnumNames() { }

	// RVA: 0x1526D70 Offset: 0x1526E71 VA: 0x1526D70 Slot: 106
	public override Array GetEnumValues() { }

	// RVA: 0x1526F60 Offset: 0x1527061 VA: 0x1526F60 Slot: 107
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x1527040 Offset: 0x1527141 VA: 0x1527040 Slot: 108
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x1527590 Offset: 0x1527691 VA: 0x1527590 Slot: 109
	public override string GetEnumName(object value) { }

	// RVA: 0x1527790 Offset: 0x1527891 VA: 0x1527790
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x1527820 Offset: 0x1527921 VA: 0x1527820 Slot: 101
	public override Type[] GetGenericArguments() { }

	// RVA: 0x15278C0 Offset: 0x15279C1 VA: 0x15278C0 Slot: 97
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x1527E30 Offset: 0x1527F31 VA: 0x1527E30 Slot: 77
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x1527E40 Offset: 0x1527F41 VA: 0x1527E40 Slot: 79
	public override bool get_IsGenericParameter() { }

	// RVA: 0x1527E50 Offset: 0x1527F51 VA: 0x1527E50 Slot: 80
	public override int get_GenericParameterPosition() { }

	// RVA: 0x1527F10 Offset: 0x1528011 VA: 0x1527F10 Slot: 103
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x1527FC0 Offset: 0x15280C1 VA: 0x1527FC0 Slot: 76
	public override bool get_IsGenericType() { }

	// RVA: 0x1527FD0 Offset: 0x15280D1 VA: 0x1527FD0 Slot: 78
	public override bool get_IsConstructedGenericType() { }

	[DebuggerHiddenAttribute] // RVA: 0xB6C60 Offset: 0xB6D61 VA: 0xB6C60
	[DebuggerStepThroughAttribute] // RVA: 0xB6C60 Offset: 0xB6D61 VA: 0xB6C60
	// RVA: 0x1528030 Offset: 0x1528131 VA: 0x1528030 Slot: 23
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x15292F0 Offset: 0x15293F1 VA: 0x15292F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x151D210 Offset: 0x151D311 VA: 0x151D210
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x15228C0 Offset: 0x15229C1 VA: 0x15228C0
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x1529300 Offset: 0x1529401 VA: 0x1529300 Slot: 128
	public object Clone() { }

	// RVA: 0x1529310 Offset: 0x1529411 VA: 0x1529310 Slot: 127
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15293B0 Offset: 0x15294B1 VA: 0x15293B0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1529460 Offset: 0x1529561 VA: 0x1529460 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x15295F0 Offset: 0x15296F1 VA: 0x15295F0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1529780 Offset: 0x1529881 VA: 0x1529780 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x1529790 Offset: 0x1529891 VA: 0x1529790 Slot: 115
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x15299D0 Offset: 0x1529AD1 VA: 0x15299D0 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1529A30 Offset: 0x1529B31 VA: 0x1529A30 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x1529A40 Offset: 0x1529B41 VA: 0x1529A40 Slot: 14
	public override int get_MetadataToken() { }

	// RVA: 0x1529A50 Offset: 0x1529B51 VA: 0x1529A50
	private void CreateInstanceCheckThis() { }

	// RVA: 0x1529C60 Offset: 0x1529D61 VA: 0x1529C60
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThroughAttribute] // RVA: 0xB6CA0 Offset: 0xB6DA1 VA: 0xB6CA0
	[DebuggerHiddenAttribute] // RVA: 0xB6CA0 Offset: 0xB6DA1 VA: 0xB6CA0
	// RVA: 0x152A750 Offset: 0x152A851 VA: 0x152A750
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x152A8B0 Offset: 0x152A9B1 VA: 0x152A8B0
	internal MonoCMethod GetDefaultConstructor() { }

	// RVA: 0x1529200 Offset: 0x1529301 VA: 0x1529200
	private string GetDefaultMemberName() { }

	// RVA: 0x151B0C0 Offset: 0x151B1C1 VA: 0x151B0C0
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x152A870 Offset: 0x152A971 VA: 0x152A870
	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x152AA60 Offset: 0x152AB61 VA: 0x152AA60
	private object CreateInstanceMono(bool nonPublic) { }

	// RVA: 0x152AD60 Offset: 0x152AE61 VA: 0x152AD60
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x152AEE0 Offset: 0x152AFE1 VA: 0x152AEE0
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x152B140 Offset: 0x152B241 VA: 0x152B140
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x1529940 Offset: 0x1529A41 VA: 0x1529940
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x152BB50 Offset: 0x152BC51 VA: 0x152BB50
	private Type make_array_type(int rank) { }

	// RVA: 0x152BB60 Offset: 0x152BC61 VA: 0x152BB60 Slot: 19
	public override Type MakeArrayType() { }

	// RVA: 0x152BB70 Offset: 0x152BC71 VA: 0x152BB70 Slot: 20
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x152BC00 Offset: 0x152BD01 VA: 0x152BC00
	private Type make_byref_type() { }

	// RVA: 0x152BC10 Offset: 0x152BD11 VA: 0x152BC10 Slot: 18
	public override Type MakeByRefType() { }

	// RVA: 0x152BCA0 Offset: 0x152BDA1 VA: 0x152BCA0
	private static Type MakePointerType(Type type) { }

	// RVA: 0x152BCB0 Offset: 0x152BDB1 VA: 0x152BCB0 Slot: 17
	public override Type MakePointerType() { }

	// RVA: 0x152BD30 Offset: 0x152BE31 VA: 0x152BD30 Slot: 81
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x152BE50 Offset: 0x152BF51 VA: 0x152BE50 Slot: 82
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x152BF70 Offset: 0x152C071 VA: 0x152BF70
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x1527E20 Offset: 0x1527F21 VA: 0x1527E20
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x152C0A0 Offset: 0x152C1A1 VA: 0x152C0A0
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	// RVA: 0x1522C10 Offset: 0x1522D11 VA: 0x1522C10
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	// RVA: 0x152C0B0 Offset: 0x152C1B1 VA: 0x152C0B0
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) { }

	// RVA: 0x152C0C0 Offset: 0x152C1C1 VA: 0x152C0C0
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x1523320 Offset: 0x1523421 VA: 0x1523320
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1523880 Offset: 0x1523981 VA: 0x1523880
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	// RVA: 0x152C0D0 Offset: 0x152C1D1 VA: 0x152C0D0 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x152C210 Offset: 0x152C311 VA: 0x152C210
	internal static Type GetTypeFromCLSIDImpl(Guid clsid, string server, bool throwOnError) { }

	// RVA: 0x152C280 Offset: 0x152C381 VA: 0x152C280 Slot: 21
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x152C300 Offset: 0x152C401 VA: 0x152C300
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x152C310 Offset: 0x152C411 VA: 0x152C310 Slot: 3
	public override string ToString() { }

	// RVA: 0x152A740 Offset: 0x152A841 VA: 0x152A740
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x152AD50 Offset: 0x152AE51 VA: 0x152AD50
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0x152C330 Offset: 0x152C431 VA: 0x152C330 Slot: 16
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x152C320 Offset: 0x152C421 VA: 0x152C320
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x1527810 Offset: 0x1527911 VA: 0x1527810
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x1526B20 Offset: 0x1526C21 VA: 0x1526B20
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x1527F00 Offset: 0x1528001 VA: 0x1527F00
	private int GetGenericParameterPosition() { }

	// RVA: 0x152C340 Offset: 0x152C441 VA: 0x152C340
	private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x152C350 Offset: 0x152C451 VA: 0x152C350
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x15243B0 Offset: 0x15244B1 VA: 0x15243B0
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1523E20 Offset: 0x1523F21 VA: 0x1523E20
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x152C360 Offset: 0x152C461 VA: 0x152C360 Slot: 47
	public override Type[] GetInterfaces() { }

	// RVA: 0x152C370 Offset: 0x152C471 VA: 0x152C370
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x1524890 Offset: 0x1524991 VA: 0x1524890
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	// RVA: 0x152C380 Offset: 0x152C481 VA: 0x152C380 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x152C390 Offset: 0x152C491 VA: 0x152C390 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x152C3A0 Offset: 0x152C4A1 VA: 0x152C3A0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x152C3B0 Offset: 0x152C4B1 VA: 0x152C3B0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x152C3C0 Offset: 0x152C4C1 VA: 0x152C3C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x152C4B0 Offset: 0x152C5B1 VA: 0x152C4B0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x152C5C0 Offset: 0x152C6C1 VA: 0x152C5C0 Slot: 118
	public override bool get_IsSZArray() { }

	// RVA: 0x152C630 Offset: 0x152C731 VA: 0x152C630
	private static void .cctor() { }
}

