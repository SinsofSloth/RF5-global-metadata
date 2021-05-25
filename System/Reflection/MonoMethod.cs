[Serializable]
internal class MonoMethod : RuntimeMethodInfo // TypeDefIndex: 595
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override Type ReturnType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsGenericMethodDefinition { get; }
	public override bool IsGenericMethod { get; }
	public override bool ContainsGenericParameters { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x196DAE0 Offset: 0x196DBE1 VA: 0x196DAE0
	internal void .ctor() { }

	// RVA: 0x196C880 Offset: 0x196C981 VA: 0x196C880
	internal static string get_name(MethodBase method) { }

	// RVA: 0x196DAF0 Offset: 0x196DBF1 VA: 0x196DAF0
	internal static MonoMethod get_base_method(MonoMethod method, bool definition) { }

	// RVA: 0x196DB00 Offset: 0x196DC01 VA: 0x196DB00 Slot: 45
	internal override MethodInfo GetBaseMethod() { }

	// RVA: 0x196DB10 Offset: 0x196DC11 VA: 0x196DB10 Slot: 40
	public override Type get_ReturnType() { }

	// RVA: 0x196DB70 Offset: 0x196DC71 VA: 0x196DB70 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x196DBA0 Offset: 0x196DCA1 VA: 0x196DBA0 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x196DC40 Offset: 0x196DD41 VA: 0x196DC40 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x196DC50 Offset: 0x196DD51 VA: 0x196DC50 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x196DC80 Offset: 0x196DD81 VA: 0x196DC80
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerStepThroughAttribute] // RVA: 0xB83D0 Offset: 0xB84D1 VA: 0xB83D0
	[DebuggerHiddenAttribute] // RVA: 0xB83D0 Offset: 0xB84D1 VA: 0xB83D0
	// RVA: 0x196DC90 Offset: 0x196DD91 VA: 0x196DC90 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196C2D0 Offset: 0x196C3D1 VA: 0x196C2D0
	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x196DEC0 Offset: 0x196DFC1 VA: 0x196DEC0 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x196DED0 Offset: 0x196DFD1 VA: 0x196DED0 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x196DEE0 Offset: 0x196DFE1 VA: 0x196DEE0 Slot: 22
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x196DF10 Offset: 0x196E011 VA: 0x196DF10 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x196DF20 Offset: 0x196E021 VA: 0x196DF20 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x196DF50 Offset: 0x196E051 VA: 0x196DF50 Slot: 7
	public override string get_Name() { }

	// RVA: 0x196DF80 Offset: 0x196E081 VA: 0x196DF80 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196E000 Offset: 0x196E101 VA: 0x196E000 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x196E080 Offset: 0x196E181 VA: 0x196E080 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196E100 Offset: 0x196E201 VA: 0x196E100
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	// RVA: 0x196E110 Offset: 0x196E211 VA: 0x196E110
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x196E2F0 Offset: 0x196E3F1 VA: 0x196E2F0 Slot: 42
	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	// RVA: 0x196E630 Offset: 0x196E731 VA: 0x196E630
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	// RVA: 0x196E640 Offset: 0x196E741 VA: 0x196E640 Slot: 23
	public override Type[] GetGenericArguments() { }

	// RVA: 0x196E650 Offset: 0x196E751 VA: 0x196E650
	private MethodInfo GetGenericMethodDefinition_impl() { }

	// RVA: 0x196E660 Offset: 0x196E761 VA: 0x196E660 Slot: 41
	public override MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x196E710 Offset: 0x196E811 VA: 0x196E710 Slot: 24
	public override bool get_IsGenericMethodDefinition() { }

	// RVA: 0x196E720 Offset: 0x196E821 VA: 0x196E720 Slot: 26
	public override bool get_IsGenericMethod() { }

	// RVA: 0x196E730 Offset: 0x196E831 VA: 0x196E730 Slot: 25
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x196E810 Offset: 0x196E911 VA: 0x196E810 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x196E880 Offset: 0x196E981 VA: 0x196E880
	private static int get_core_clr_security_level() { }

	// RVA: 0x196E890 Offset: 0x196E991 VA: 0x196E890 Slot: 27
	public override bool get_IsSecurityCritical() { }
}

