[Serializable]
internal class MonoProperty : RuntimePropertyInfo // TypeDefIndex: 605
{
	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private MonoProperty.GetterAdapter cached_getter; // 0x58

	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x17ED830 Offset: 0x17ED931 VA: 0x17ED830
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x17ED890 Offset: 0x17ED991 VA: 0x17ED890 Slot: 16
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x17ED8E0 Offset: 0x17ED9E1 VA: 0x17ED8E0 Slot: 17
	public override bool get_CanRead() { }

	// RVA: 0x17ED930 Offset: 0x17EDA31 VA: 0x17ED930 Slot: 18
	public override bool get_CanWrite() { }

	// RVA: 0x17ED980 Offset: 0x17EDA81 VA: 0x17ED980 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x17EDA50 Offset: 0x17EDB51 VA: 0x17EDA50 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x17EDAA0 Offset: 0x17EDBA1 VA: 0x17EDAA0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x17EDAF0 Offset: 0x17EDBF1 VA: 0x17EDAF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x17EDB40 Offset: 0x17EDC41 VA: 0x17EDB40 Slot: 22
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x17EDCE0 Offset: 0x17EDDE1 VA: 0x17EDCE0 Slot: 24
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x17EDD70 Offset: 0x17EDE71 VA: 0x17EDD70 Slot: 25
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x17EE060 Offset: 0x17EE161 VA: 0x17EE060 Slot: 27
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x17EE0F0 Offset: 0x17EE1F1 VA: 0x17EE0F0 Slot: 34
	public override object GetConstantValue() { }

	// RVA: 0x17EE110 Offset: 0x17EE211 VA: 0x17EE110 Slot: 35
	public override object GetRawConstantValue() { }

	// RVA: 0x17EE120 Offset: 0x17EE221 VA: 0x17EE120 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EE1A0 Offset: 0x17EE2A1 VA: 0x17EE1A0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EE210 Offset: 0x17EE311 VA: 0x17EE210 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25614F0 Offset: 0x25615F1 VA: 0x25614F0
	|-MonoProperty.GetterAdapterFrame<object, object>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561590 Offset: 0x2561691 VA: 0x2561590
	|-MonoProperty.StaticGetterAdapterFrame<object>
	*/

	// RVA: 0x17EE290 Offset: 0x17EE391 VA: 0x17EE290
	private static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	// RVA: 0x17EE5B0 Offset: 0x17EE6B1 VA: 0x17EE5B0 Slot: 28
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x17EE5D0 Offset: 0x17EE6D1 VA: 0x17EE5D0 Slot: 29
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EE890 Offset: 0x17EE991 VA: 0x17EE890 Slot: 31
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EEAB0 Offset: 0x17EEBB1 VA: 0x17EEAB0 Slot: 32
	public override Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x17EEB60 Offset: 0x17EEC61 VA: 0x17EEB60 Slot: 33
	public override Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x17EEC00 Offset: 0x17EED01 VA: 0x17EEC00 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x17EEC10 Offset: 0x17EED11 VA: 0x17EEC10
	public void .ctor() { }
}

[Serializable]
internal class MonoProperty : RuntimePropertyInfo // TypeDefIndex: 605
{
	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private MonoProperty.GetterAdapter cached_getter; // 0x58

	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x17ED830 Offset: 0x17ED931 VA: 0x17ED830
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x17ED890 Offset: 0x17ED991 VA: 0x17ED890 Slot: 16
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x17ED8E0 Offset: 0x17ED9E1 VA: 0x17ED8E0 Slot: 17
	public override bool get_CanRead() { }

	// RVA: 0x17ED930 Offset: 0x17EDA31 VA: 0x17ED930 Slot: 18
	public override bool get_CanWrite() { }

	// RVA: 0x17ED980 Offset: 0x17EDA81 VA: 0x17ED980 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x17EDA50 Offset: 0x17EDB51 VA: 0x17EDA50 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x17EDAA0 Offset: 0x17EDBA1 VA: 0x17EDAA0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x17EDAF0 Offset: 0x17EDBF1 VA: 0x17EDAF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x17EDB40 Offset: 0x17EDC41 VA: 0x17EDB40 Slot: 22
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x17EDCE0 Offset: 0x17EDDE1 VA: 0x17EDCE0 Slot: 24
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x17EDD70 Offset: 0x17EDE71 VA: 0x17EDD70 Slot: 25
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x17EE060 Offset: 0x17EE161 VA: 0x17EE060 Slot: 27
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x17EE0F0 Offset: 0x17EE1F1 VA: 0x17EE0F0 Slot: 34
	public override object GetConstantValue() { }

	// RVA: 0x17EE110 Offset: 0x17EE211 VA: 0x17EE110 Slot: 35
	public override object GetRawConstantValue() { }

	// RVA: 0x17EE120 Offset: 0x17EE221 VA: 0x17EE120 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EE1A0 Offset: 0x17EE2A1 VA: 0x17EE1A0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EE210 Offset: 0x17EE311 VA: 0x17EE210 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25614F0 Offset: 0x25615F1 VA: 0x25614F0
	|-MonoProperty.GetterAdapterFrame<object, object>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561590 Offset: 0x2561691 VA: 0x2561590
	|-MonoProperty.StaticGetterAdapterFrame<object>
	*/

	// RVA: 0x17EE290 Offset: 0x17EE391 VA: 0x17EE290
	private static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	// RVA: 0x17EE5B0 Offset: 0x17EE6B1 VA: 0x17EE5B0 Slot: 28
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x17EE5D0 Offset: 0x17EE6D1 VA: 0x17EE5D0 Slot: 29
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EE890 Offset: 0x17EE991 VA: 0x17EE890 Slot: 31
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EEAB0 Offset: 0x17EEBB1 VA: 0x17EEAB0 Slot: 32
	public override Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x17EEB60 Offset: 0x17EEC61 VA: 0x17EEB60 Slot: 33
	public override Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x17EEC00 Offset: 0x17EED01 VA: 0x17EEC00 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x17EEC10 Offset: 0x17EED11 VA: 0x17EEC10
	public void .ctor() { }
}

[Serializable]
internal class MonoProperty : RuntimePropertyInfo // TypeDefIndex: 605
{
	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private MonoProperty.GetterAdapter cached_getter; // 0x58

	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x17ED830 Offset: 0x17ED931 VA: 0x17ED830
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x17ED890 Offset: 0x17ED991 VA: 0x17ED890 Slot: 16
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x17ED8E0 Offset: 0x17ED9E1 VA: 0x17ED8E0 Slot: 17
	public override bool get_CanRead() { }

	// RVA: 0x17ED930 Offset: 0x17EDA31 VA: 0x17ED930 Slot: 18
	public override bool get_CanWrite() { }

	// RVA: 0x17ED980 Offset: 0x17EDA81 VA: 0x17ED980 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x17EDA50 Offset: 0x17EDB51 VA: 0x17EDA50 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x17EDAA0 Offset: 0x17EDBA1 VA: 0x17EDAA0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x17EDAF0 Offset: 0x17EDBF1 VA: 0x17EDAF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x17EDB40 Offset: 0x17EDC41 VA: 0x17EDB40 Slot: 22
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x17EDCE0 Offset: 0x17EDDE1 VA: 0x17EDCE0 Slot: 24
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x17EDD70 Offset: 0x17EDE71 VA: 0x17EDD70 Slot: 25
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x17EE060 Offset: 0x17EE161 VA: 0x17EE060 Slot: 27
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x17EE0F0 Offset: 0x17EE1F1 VA: 0x17EE0F0 Slot: 34
	public override object GetConstantValue() { }

	// RVA: 0x17EE110 Offset: 0x17EE211 VA: 0x17EE110 Slot: 35
	public override object GetRawConstantValue() { }

	// RVA: 0x17EE120 Offset: 0x17EE221 VA: 0x17EE120 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EE1A0 Offset: 0x17EE2A1 VA: 0x17EE1A0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EE210 Offset: 0x17EE311 VA: 0x17EE210 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25614F0 Offset: 0x25615F1 VA: 0x25614F0
	|-MonoProperty.GetterAdapterFrame<object, object>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561590 Offset: 0x2561691 VA: 0x2561590
	|-MonoProperty.StaticGetterAdapterFrame<object>
	*/

	// RVA: 0x17EE290 Offset: 0x17EE391 VA: 0x17EE290
	private static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	// RVA: 0x17EE5B0 Offset: 0x17EE6B1 VA: 0x17EE5B0 Slot: 28
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x17EE5D0 Offset: 0x17EE6D1 VA: 0x17EE5D0 Slot: 29
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EE890 Offset: 0x17EE991 VA: 0x17EE890 Slot: 31
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EEAB0 Offset: 0x17EEBB1 VA: 0x17EEAB0 Slot: 32
	public override Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x17EEB60 Offset: 0x17EEC61 VA: 0x17EEB60 Slot: 33
	public override Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x17EEC00 Offset: 0x17EED01 VA: 0x17EEC00 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x17EEC10 Offset: 0x17EED11 VA: 0x17EEC10
	public void .ctor() { }
}

[Serializable]
internal class MonoProperty : RuntimePropertyInfo // TypeDefIndex: 605
{
	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private MonoProperty.GetterAdapter cached_getter; // 0x58

	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x17ED830 Offset: 0x17ED931 VA: 0x17ED830
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x17ED890 Offset: 0x17ED991 VA: 0x17ED890 Slot: 16
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x17ED8E0 Offset: 0x17ED9E1 VA: 0x17ED8E0 Slot: 17
	public override bool get_CanRead() { }

	// RVA: 0x17ED930 Offset: 0x17EDA31 VA: 0x17ED930 Slot: 18
	public override bool get_CanWrite() { }

	// RVA: 0x17ED980 Offset: 0x17EDA81 VA: 0x17ED980 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x17EDA50 Offset: 0x17EDB51 VA: 0x17EDA50 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x17EDAA0 Offset: 0x17EDBA1 VA: 0x17EDAA0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x17EDAF0 Offset: 0x17EDBF1 VA: 0x17EDAF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x17EDB40 Offset: 0x17EDC41 VA: 0x17EDB40 Slot: 22
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x17EDCE0 Offset: 0x17EDDE1 VA: 0x17EDCE0 Slot: 24
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x17EDD70 Offset: 0x17EDE71 VA: 0x17EDD70 Slot: 25
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x17EE060 Offset: 0x17EE161 VA: 0x17EE060 Slot: 27
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x17EE0F0 Offset: 0x17EE1F1 VA: 0x17EE0F0 Slot: 34
	public override object GetConstantValue() { }

	// RVA: 0x17EE110 Offset: 0x17EE211 VA: 0x17EE110 Slot: 35
	public override object GetRawConstantValue() { }

	// RVA: 0x17EE120 Offset: 0x17EE221 VA: 0x17EE120 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EE1A0 Offset: 0x17EE2A1 VA: 0x17EE1A0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EE210 Offset: 0x17EE311 VA: 0x17EE210 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25614F0 Offset: 0x25615F1 VA: 0x25614F0
	|-MonoProperty.GetterAdapterFrame<object, object>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561590 Offset: 0x2561691 VA: 0x2561590
	|-MonoProperty.StaticGetterAdapterFrame<object>
	*/

	// RVA: 0x17EE290 Offset: 0x17EE391 VA: 0x17EE290
	private static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	// RVA: 0x17EE5B0 Offset: 0x17EE6B1 VA: 0x17EE5B0 Slot: 28
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x17EE5D0 Offset: 0x17EE6D1 VA: 0x17EE5D0 Slot: 29
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EE890 Offset: 0x17EE991 VA: 0x17EE890 Slot: 31
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EEAB0 Offset: 0x17EEBB1 VA: 0x17EEAB0 Slot: 32
	public override Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x17EEB60 Offset: 0x17EEC61 VA: 0x17EEB60 Slot: 33
	public override Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x17EEC00 Offset: 0x17EED01 VA: 0x17EEC00 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x17EEC10 Offset: 0x17EED11 VA: 0x17EEC10
	public void .ctor() { }
}

[Serializable]
internal class MonoProperty : RuntimePropertyInfo // TypeDefIndex: 605
{
	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private MonoProperty.GetterAdapter cached_getter; // 0x58

	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x17ED830 Offset: 0x17ED931 VA: 0x17ED830
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x17ED890 Offset: 0x17ED991 VA: 0x17ED890 Slot: 16
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x17ED8E0 Offset: 0x17ED9E1 VA: 0x17ED8E0 Slot: 17
	public override bool get_CanRead() { }

	// RVA: 0x17ED930 Offset: 0x17EDA31 VA: 0x17ED930 Slot: 18
	public override bool get_CanWrite() { }

	// RVA: 0x17ED980 Offset: 0x17EDA81 VA: 0x17ED980 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x17EDA50 Offset: 0x17EDB51 VA: 0x17EDA50 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x17EDAA0 Offset: 0x17EDBA1 VA: 0x17EDAA0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x17EDAF0 Offset: 0x17EDBF1 VA: 0x17EDAF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x17EDB40 Offset: 0x17EDC41 VA: 0x17EDB40 Slot: 22
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x17EDCE0 Offset: 0x17EDDE1 VA: 0x17EDCE0 Slot: 24
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x17EDD70 Offset: 0x17EDE71 VA: 0x17EDD70 Slot: 25
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x17EE060 Offset: 0x17EE161 VA: 0x17EE060 Slot: 27
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x17EE0F0 Offset: 0x17EE1F1 VA: 0x17EE0F0 Slot: 34
	public override object GetConstantValue() { }

	// RVA: 0x17EE110 Offset: 0x17EE211 VA: 0x17EE110 Slot: 35
	public override object GetRawConstantValue() { }

	// RVA: 0x17EE120 Offset: 0x17EE221 VA: 0x17EE120 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EE1A0 Offset: 0x17EE2A1 VA: 0x17EE1A0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EE210 Offset: 0x17EE311 VA: 0x17EE210 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25614F0 Offset: 0x25615F1 VA: 0x25614F0
	|-MonoProperty.GetterAdapterFrame<object, object>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561590 Offset: 0x2561691 VA: 0x2561590
	|-MonoProperty.StaticGetterAdapterFrame<object>
	*/

	// RVA: 0x17EE290 Offset: 0x17EE391 VA: 0x17EE290
	private static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	// RVA: 0x17EE5B0 Offset: 0x17EE6B1 VA: 0x17EE5B0 Slot: 28
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x17EE5D0 Offset: 0x17EE6D1 VA: 0x17EE5D0 Slot: 29
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EE890 Offset: 0x17EE991 VA: 0x17EE890 Slot: 31
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EEAB0 Offset: 0x17EEBB1 VA: 0x17EEAB0 Slot: 32
	public override Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x17EEB60 Offset: 0x17EEC61 VA: 0x17EEB60 Slot: 33
	public override Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x17EEC00 Offset: 0x17EED01 VA: 0x17EEC00 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x17EEC10 Offset: 0x17EED11 VA: 0x17EEC10
	public void .ctor() { }
}

[Serializable]
internal class MonoProperty : RuntimePropertyInfo // TypeDefIndex: 605
{
	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private MonoProperty.GetterAdapter cached_getter; // 0x58

	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x17ED830 Offset: 0x17ED931 VA: 0x17ED830
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x17ED890 Offset: 0x17ED991 VA: 0x17ED890 Slot: 16
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x17ED8E0 Offset: 0x17ED9E1 VA: 0x17ED8E0 Slot: 17
	public override bool get_CanRead() { }

	// RVA: 0x17ED930 Offset: 0x17EDA31 VA: 0x17ED930 Slot: 18
	public override bool get_CanWrite() { }

	// RVA: 0x17ED980 Offset: 0x17EDA81 VA: 0x17ED980 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x17EDA50 Offset: 0x17EDB51 VA: 0x17EDA50 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x17EDAA0 Offset: 0x17EDBA1 VA: 0x17EDAA0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x17EDAF0 Offset: 0x17EDBF1 VA: 0x17EDAF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x17EDB40 Offset: 0x17EDC41 VA: 0x17EDB40 Slot: 22
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x17EDCE0 Offset: 0x17EDDE1 VA: 0x17EDCE0 Slot: 24
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x17EDD70 Offset: 0x17EDE71 VA: 0x17EDD70 Slot: 25
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x17EE060 Offset: 0x17EE161 VA: 0x17EE060 Slot: 27
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x17EE0F0 Offset: 0x17EE1F1 VA: 0x17EE0F0 Slot: 34
	public override object GetConstantValue() { }

	// RVA: 0x17EE110 Offset: 0x17EE211 VA: 0x17EE110 Slot: 35
	public override object GetRawConstantValue() { }

	// RVA: 0x17EE120 Offset: 0x17EE221 VA: 0x17EE120 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EE1A0 Offset: 0x17EE2A1 VA: 0x17EE1A0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EE210 Offset: 0x17EE311 VA: 0x17EE210 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25614F0 Offset: 0x25615F1 VA: 0x25614F0
	|-MonoProperty.GetterAdapterFrame<object, object>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561590 Offset: 0x2561691 VA: 0x2561590
	|-MonoProperty.StaticGetterAdapterFrame<object>
	*/

	// RVA: 0x17EE290 Offset: 0x17EE391 VA: 0x17EE290
	private static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	// RVA: 0x17EE5B0 Offset: 0x17EE6B1 VA: 0x17EE5B0 Slot: 28
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x17EE5D0 Offset: 0x17EE6D1 VA: 0x17EE5D0 Slot: 29
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EE890 Offset: 0x17EE991 VA: 0x17EE890 Slot: 31
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EEAB0 Offset: 0x17EEBB1 VA: 0x17EEAB0 Slot: 32
	public override Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x17EEB60 Offset: 0x17EEC61 VA: 0x17EEB60 Slot: 33
	public override Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x17EEC00 Offset: 0x17EED01 VA: 0x17EEC00 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x17EEC10 Offset: 0x17EED11 VA: 0x17EEC10
	public void .ctor() { }
}

