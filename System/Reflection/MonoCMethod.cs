[Serializable]
internal class MonoCMethod : RuntimeConstructorInfo // TypeDefIndex: 597
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x196BF10 Offset: 0x196C011 VA: 0x196BF10 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x196BF70 Offset: 0x196C071 VA: 0x196BF70 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x196BF90 Offset: 0x196C091 VA: 0x196BF90 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x196BFA0 Offset: 0x196C0A1 VA: 0x196BFA0 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x196BFD0 Offset: 0x196C0D1 VA: 0x196BFD0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8410 Offset: 0xB8511 VA: 0xB8410
	[DebuggerStepThroughAttribute] // RVA: 0xB8410 Offset: 0xB8511 VA: 0xB8410
	// RVA: 0x196BFE0 Offset: 0x196C0E1 VA: 0x196BFE0 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C110 Offset: 0x196C211 VA: 0x196C110
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C590 Offset: 0x196C691 VA: 0x196C590
	public object InternalInvoke(object obj, object[] parameters) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8450 Offset: 0xB8551 VA: 0xB8450
	[DebuggerStepThroughAttribute] // RVA: 0xB8450 Offset: 0xB8551 VA: 0xB8450
	// RVA: 0x196C700 Offset: 0x196C801 VA: 0x196C700 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C720 Offset: 0x196C821 VA: 0x196C720 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x196C730 Offset: 0x196C831 VA: 0x196C730 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x196C750 Offset: 0x196C851 VA: 0x196C750 Slot: 22
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x196C7B0 Offset: 0x196C8B1 VA: 0x196C7B0 Slot: 25
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x196C7E0 Offset: 0x196C8E1 VA: 0x196C7E0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x196C7F0 Offset: 0x196C8F1 VA: 0x196C7F0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x196C850 Offset: 0x196C951 VA: 0x196C850 Slot: 7
	public override string get_Name() { }

	// RVA: 0x196C890 Offset: 0x196C991 VA: 0x196C890 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196C910 Offset: 0x196CA11 VA: 0x196C910 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x196C990 Offset: 0x196CA91 VA: 0x196C990 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196CA10 Offset: 0x196CB11 VA: 0x196CA10 Slot: 3
	public override string ToString() { }

	// RVA: 0x196CBE0 Offset: 0x196CCE1 VA: 0x196CBE0 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x196CC50 Offset: 0x196CD51 VA: 0x196CC50
	private static int get_core_clr_security_level() { }

	// RVA: 0x196CC60 Offset: 0x196CD61 VA: 0x196CC60 Slot: 27
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x196CC70 Offset: 0x196CD71 VA: 0x196CC70
	public void .ctor() { }
}

[Serializable]
internal class MonoCMethod : RuntimeConstructorInfo // TypeDefIndex: 597
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x196BF10 Offset: 0x196C011 VA: 0x196BF10 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x196BF70 Offset: 0x196C071 VA: 0x196BF70 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x196BF90 Offset: 0x196C091 VA: 0x196BF90 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x196BFA0 Offset: 0x196C0A1 VA: 0x196BFA0 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x196BFD0 Offset: 0x196C0D1 VA: 0x196BFD0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8410 Offset: 0xB8511 VA: 0xB8410
	[DebuggerStepThroughAttribute] // RVA: 0xB8410 Offset: 0xB8511 VA: 0xB8410
	// RVA: 0x196BFE0 Offset: 0x196C0E1 VA: 0x196BFE0 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C110 Offset: 0x196C211 VA: 0x196C110
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C590 Offset: 0x196C691 VA: 0x196C590
	public object InternalInvoke(object obj, object[] parameters) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8450 Offset: 0xB8551 VA: 0xB8450
	[DebuggerStepThroughAttribute] // RVA: 0xB8450 Offset: 0xB8551 VA: 0xB8450
	// RVA: 0x196C700 Offset: 0x196C801 VA: 0x196C700 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C720 Offset: 0x196C821 VA: 0x196C720 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x196C730 Offset: 0x196C831 VA: 0x196C730 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x196C750 Offset: 0x196C851 VA: 0x196C750 Slot: 22
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x196C7B0 Offset: 0x196C8B1 VA: 0x196C7B0 Slot: 25
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x196C7E0 Offset: 0x196C8E1 VA: 0x196C7E0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x196C7F0 Offset: 0x196C8F1 VA: 0x196C7F0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x196C850 Offset: 0x196C951 VA: 0x196C850 Slot: 7
	public override string get_Name() { }

	// RVA: 0x196C890 Offset: 0x196C991 VA: 0x196C890 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196C910 Offset: 0x196CA11 VA: 0x196C910 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x196C990 Offset: 0x196CA91 VA: 0x196C990 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196CA10 Offset: 0x196CB11 VA: 0x196CA10 Slot: 3
	public override string ToString() { }

	// RVA: 0x196CBE0 Offset: 0x196CCE1 VA: 0x196CBE0 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x196CC50 Offset: 0x196CD51 VA: 0x196CC50
	private static int get_core_clr_security_level() { }

	// RVA: 0x196CC60 Offset: 0x196CD61 VA: 0x196CC60 Slot: 27
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x196CC70 Offset: 0x196CD71 VA: 0x196CC70
	public void .ctor() { }
}

[Serializable]
internal class MonoCMethod : RuntimeConstructorInfo // TypeDefIndex: 597
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x196BF10 Offset: 0x196C011 VA: 0x196BF10 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x196BF70 Offset: 0x196C071 VA: 0x196BF70 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x196BF90 Offset: 0x196C091 VA: 0x196BF90 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x196BFA0 Offset: 0x196C0A1 VA: 0x196BFA0 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x196BFD0 Offset: 0x196C0D1 VA: 0x196BFD0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8410 Offset: 0xB8511 VA: 0xB8410
	[DebuggerStepThroughAttribute] // RVA: 0xB8410 Offset: 0xB8511 VA: 0xB8410
	// RVA: 0x196BFE0 Offset: 0x196C0E1 VA: 0x196BFE0 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C110 Offset: 0x196C211 VA: 0x196C110
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C590 Offset: 0x196C691 VA: 0x196C590
	public object InternalInvoke(object obj, object[] parameters) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8450 Offset: 0xB8551 VA: 0xB8450
	[DebuggerStepThroughAttribute] // RVA: 0xB8450 Offset: 0xB8551 VA: 0xB8450
	// RVA: 0x196C700 Offset: 0x196C801 VA: 0x196C700 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C720 Offset: 0x196C821 VA: 0x196C720 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x196C730 Offset: 0x196C831 VA: 0x196C730 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x196C750 Offset: 0x196C851 VA: 0x196C750 Slot: 22
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x196C7B0 Offset: 0x196C8B1 VA: 0x196C7B0 Slot: 25
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x196C7E0 Offset: 0x196C8E1 VA: 0x196C7E0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x196C7F0 Offset: 0x196C8F1 VA: 0x196C7F0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x196C850 Offset: 0x196C951 VA: 0x196C850 Slot: 7
	public override string get_Name() { }

	// RVA: 0x196C890 Offset: 0x196C991 VA: 0x196C890 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196C910 Offset: 0x196CA11 VA: 0x196C910 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x196C990 Offset: 0x196CA91 VA: 0x196C990 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196CA10 Offset: 0x196CB11 VA: 0x196CA10 Slot: 3
	public override string ToString() { }

	// RVA: 0x196CBE0 Offset: 0x196CCE1 VA: 0x196CBE0 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x196CC50 Offset: 0x196CD51 VA: 0x196CC50
	private static int get_core_clr_security_level() { }

	// RVA: 0x196CC60 Offset: 0x196CD61 VA: 0x196CC60 Slot: 27
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x196CC70 Offset: 0x196CD71 VA: 0x196CC70
	public void .ctor() { }
}

[Serializable]
internal class MonoCMethod : RuntimeConstructorInfo // TypeDefIndex: 597
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x196BF10 Offset: 0x196C011 VA: 0x196BF10 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x196BF70 Offset: 0x196C071 VA: 0x196BF70 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x196BF90 Offset: 0x196C091 VA: 0x196BF90 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x196BFA0 Offset: 0x196C0A1 VA: 0x196BFA0 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x196BFD0 Offset: 0x196C0D1 VA: 0x196BFD0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8410 Offset: 0xB8511 VA: 0xB8410
	[DebuggerStepThroughAttribute] // RVA: 0xB8410 Offset: 0xB8511 VA: 0xB8410
	// RVA: 0x196BFE0 Offset: 0x196C0E1 VA: 0x196BFE0 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C110 Offset: 0x196C211 VA: 0x196C110
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C590 Offset: 0x196C691 VA: 0x196C590
	public object InternalInvoke(object obj, object[] parameters) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8450 Offset: 0xB8551 VA: 0xB8450
	[DebuggerStepThroughAttribute] // RVA: 0xB8450 Offset: 0xB8551 VA: 0xB8450
	// RVA: 0x196C700 Offset: 0x196C801 VA: 0x196C700 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C720 Offset: 0x196C821 VA: 0x196C720 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x196C730 Offset: 0x196C831 VA: 0x196C730 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x196C750 Offset: 0x196C851 VA: 0x196C750 Slot: 22
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x196C7B0 Offset: 0x196C8B1 VA: 0x196C7B0 Slot: 25
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x196C7E0 Offset: 0x196C8E1 VA: 0x196C7E0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x196C7F0 Offset: 0x196C8F1 VA: 0x196C7F0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x196C850 Offset: 0x196C951 VA: 0x196C850 Slot: 7
	public override string get_Name() { }

	// RVA: 0x196C890 Offset: 0x196C991 VA: 0x196C890 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196C910 Offset: 0x196CA11 VA: 0x196C910 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x196C990 Offset: 0x196CA91 VA: 0x196C990 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196CA10 Offset: 0x196CB11 VA: 0x196CA10 Slot: 3
	public override string ToString() { }

	// RVA: 0x196CBE0 Offset: 0x196CCE1 VA: 0x196CBE0 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x196CC50 Offset: 0x196CD51 VA: 0x196CC50
	private static int get_core_clr_security_level() { }

	// RVA: 0x196CC60 Offset: 0x196CD61 VA: 0x196CC60 Slot: 27
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x196CC70 Offset: 0x196CD71 VA: 0x196CC70
	public void .ctor() { }
}

[Serializable]
internal class MonoCMethod : RuntimeConstructorInfo // TypeDefIndex: 597
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x196BF10 Offset: 0x196C011 VA: 0x196BF10 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x196BF70 Offset: 0x196C071 VA: 0x196BF70 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x196BF90 Offset: 0x196C091 VA: 0x196BF90 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x196BFA0 Offset: 0x196C0A1 VA: 0x196BFA0 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x196BFD0 Offset: 0x196C0D1 VA: 0x196BFD0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8410 Offset: 0xB8511 VA: 0xB8410
	[DebuggerStepThroughAttribute] // RVA: 0xB8410 Offset: 0xB8511 VA: 0xB8410
	// RVA: 0x196BFE0 Offset: 0x196C0E1 VA: 0x196BFE0 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C110 Offset: 0x196C211 VA: 0x196C110
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C590 Offset: 0x196C691 VA: 0x196C590
	public object InternalInvoke(object obj, object[] parameters) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8450 Offset: 0xB8551 VA: 0xB8450
	[DebuggerStepThroughAttribute] // RVA: 0xB8450 Offset: 0xB8551 VA: 0xB8450
	// RVA: 0x196C700 Offset: 0x196C801 VA: 0x196C700 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C720 Offset: 0x196C821 VA: 0x196C720 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x196C730 Offset: 0x196C831 VA: 0x196C730 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x196C750 Offset: 0x196C851 VA: 0x196C750 Slot: 22
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x196C7B0 Offset: 0x196C8B1 VA: 0x196C7B0 Slot: 25
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x196C7E0 Offset: 0x196C8E1 VA: 0x196C7E0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x196C7F0 Offset: 0x196C8F1 VA: 0x196C7F0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x196C850 Offset: 0x196C951 VA: 0x196C850 Slot: 7
	public override string get_Name() { }

	// RVA: 0x196C890 Offset: 0x196C991 VA: 0x196C890 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196C910 Offset: 0x196CA11 VA: 0x196C910 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x196C990 Offset: 0x196CA91 VA: 0x196C990 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196CA10 Offset: 0x196CB11 VA: 0x196CA10 Slot: 3
	public override string ToString() { }

	// RVA: 0x196CBE0 Offset: 0x196CCE1 VA: 0x196CBE0 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x196CC50 Offset: 0x196CD51 VA: 0x196CC50
	private static int get_core_clr_security_level() { }

	// RVA: 0x196CC60 Offset: 0x196CD61 VA: 0x196CC60 Slot: 27
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x196CC70 Offset: 0x196CD71 VA: 0x196CC70
	public void .ctor() { }
}

[Serializable]
internal class MonoCMethod : RuntimeConstructorInfo // TypeDefIndex: 597
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x196BF10 Offset: 0x196C011 VA: 0x196BF10 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x196BF70 Offset: 0x196C071 VA: 0x196BF70 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x196BF90 Offset: 0x196C091 VA: 0x196BF90 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x196BFA0 Offset: 0x196C0A1 VA: 0x196BFA0 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x196BFD0 Offset: 0x196C0D1 VA: 0x196BFD0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8410 Offset: 0xB8511 VA: 0xB8410
	[DebuggerStepThroughAttribute] // RVA: 0xB8410 Offset: 0xB8511 VA: 0xB8410
	// RVA: 0x196BFE0 Offset: 0x196C0E1 VA: 0x196BFE0 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C110 Offset: 0x196C211 VA: 0x196C110
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C590 Offset: 0x196C691 VA: 0x196C590
	public object InternalInvoke(object obj, object[] parameters) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8450 Offset: 0xB8551 VA: 0xB8450
	[DebuggerStepThroughAttribute] // RVA: 0xB8450 Offset: 0xB8551 VA: 0xB8450
	// RVA: 0x196C700 Offset: 0x196C801 VA: 0x196C700 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C720 Offset: 0x196C821 VA: 0x196C720 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x196C730 Offset: 0x196C831 VA: 0x196C730 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x196C750 Offset: 0x196C851 VA: 0x196C750 Slot: 22
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x196C7B0 Offset: 0x196C8B1 VA: 0x196C7B0 Slot: 25
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x196C7E0 Offset: 0x196C8E1 VA: 0x196C7E0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x196C7F0 Offset: 0x196C8F1 VA: 0x196C7F0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x196C850 Offset: 0x196C951 VA: 0x196C850 Slot: 7
	public override string get_Name() { }

	// RVA: 0x196C890 Offset: 0x196C991 VA: 0x196C890 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196C910 Offset: 0x196CA11 VA: 0x196C910 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x196C990 Offset: 0x196CA91 VA: 0x196C990 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196CA10 Offset: 0x196CB11 VA: 0x196CA10 Slot: 3
	public override string ToString() { }

	// RVA: 0x196CBE0 Offset: 0x196CCE1 VA: 0x196CBE0 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x196CC50 Offset: 0x196CD51 VA: 0x196CC50
	private static int get_core_clr_security_level() { }

	// RVA: 0x196CC60 Offset: 0x196CD61 VA: 0x196CC60 Slot: 27
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x196CC70 Offset: 0x196CD71 VA: 0x196CC70
	public void .ctor() { }
}

