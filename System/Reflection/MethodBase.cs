[ClassInterfaceAttribute] // RVA: 0xADC40 Offset: 0xADD41 VA: 0xADC40
[ComVisibleAttribute] // RVA: 0xADC40 Offset: 0xADD41 VA: 0xADC40
[ComDefaultInterfaceAttribute] // RVA: 0xADC40 Offset: 0xADD41 VA: 0xADC40
[Serializable]
public abstract class MethodBase : MemberInfo, _MethodBase // TypeDefIndex: 550
{
	// Properties
	public abstract RuntimeMethodHandle MethodHandle { get; }
	public abstract MethodAttributes Attributes { get; }
	public virtual CallingConventions CallingConvention { get; }
	public virtual bool IsGenericMethodDefinition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public virtual bool IsGenericMethod { get; }
	public virtual bool IsSecurityCritical { get; }
	public bool IsPublic { get; }
	public bool IsStatic { get; }
	public bool IsFinal { get; }
	public bool IsVirtual { get; }
	public bool IsAbstract { get; }
	public bool IsSpecialName { get; }
	[ComVisibleAttribute] // RVA: 0xBA0E0 Offset: 0xBA1E1 VA: 0xBA0E0
	public bool IsConstructor { get; }

	// Methods

	// RVA: 0x1969FB0 Offset: 0x196A0B1 VA: 0x1969FB0
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	// RVA: 0x195BAE0 Offset: 0x195BBE1 VA: 0x195BAE0
	protected void .ctor() { }

	// RVA: 0x1968E10 Offset: 0x1968F11 VA: 0x1968E10
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	// RVA: 0x1968DF0 Offset: 0x1968EF1 VA: 0x1968DF0
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	// RVA: 0x196A2B0 Offset: 0x196A3B1 VA: 0x196A2B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x195BBE0 Offset: 0x195BCE1 VA: 0x195BBE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x196A2C0 Offset: 0x196A3C1 VA: 0x196A2C0 Slot: 16
	internal virtual ParameterInfo[] GetParametersNoCopy() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract ParameterInfo[] GetParameters() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract RuntimeMethodHandle get_MethodHandle() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract MethodAttributes get_Attributes() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x196A2D0 Offset: 0x196A3D1 VA: 0x196A2D0 Slot: 22
	public virtual CallingConventions get_CallingConvention() { }

	[ComVisibleAttribute] // RVA: 0xB80C0 Offset: 0xB81C1 VA: 0xB80C0
	// RVA: 0x196A2E0 Offset: 0x196A3E1 VA: 0x196A2E0 Slot: 23
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x196A360 Offset: 0x196A461 VA: 0x196A360 Slot: 24
	public virtual bool get_IsGenericMethodDefinition() { }

	// RVA: 0x196A370 Offset: 0x196A471 VA: 0x196A370 Slot: 25
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x196A380 Offset: 0x196A481 VA: 0x196A380 Slot: 26
	public virtual bool get_IsGenericMethod() { }

	// RVA: 0x196A390 Offset: 0x196A491 VA: 0x196A390 Slot: 27
	public virtual bool get_IsSecurityCritical() { }

	[DebuggerStepThroughAttribute] // RVA: 0xB80E0 Offset: 0xB81E1 VA: 0xB80E0
	[DebuggerHiddenAttribute] // RVA: 0xB80E0 Offset: 0xB81E1 VA: 0xB80E0
	// RVA: 0x196A3F0 Offset: 0x196A4F1 VA: 0x196A3F0 Slot: 28
	public object Invoke(object obj, object[] parameters) { }

	// RVA: 0x196A410 Offset: 0x196A511 VA: 0x196A410 Slot: 29
	public bool get_IsPublic() { }

	// RVA: 0x196A440 Offset: 0x196A541 VA: 0x196A440 Slot: 30
	public bool get_IsStatic() { }

	// RVA: 0x196A470 Offset: 0x196A571 VA: 0x196A470 Slot: 31
	public bool get_IsFinal() { }

	// RVA: 0x196A4A0 Offset: 0x196A5A1 VA: 0x196A4A0 Slot: 32
	public bool get_IsVirtual() { }

	// RVA: 0x196A4D0 Offset: 0x196A5D1 VA: 0x196A4D0 Slot: 33
	public bool get_IsAbstract() { }

	// RVA: 0x196A500 Offset: 0x196A601 VA: 0x196A500 Slot: 34
	public bool get_IsSpecialName() { }

	// RVA: 0x196A530 Offset: 0x196A631 VA: 0x196A530 Slot: 35
	public bool get_IsConstructor() { }

	// RVA: 0x196A620 Offset: 0x196A721 VA: 0x196A620
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x196A810 Offset: 0x196A911 VA: 0x196A810 Slot: 36
	internal virtual string FormatNameAndSig(bool serialization) { }

	// RVA: 0x196A920 Offset: 0x196AA21 VA: 0x196A920 Slot: 37
	internal virtual Type[] GetParameterTypes() { }

	// RVA: 0x196AA70 Offset: 0x196AB71 VA: 0x196AA70 Slot: 38
	internal virtual ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x196AA80 Offset: 0x196AB81 VA: 0x196AA80 Slot: 39
	internal virtual int GetParametersCount() { }

	// RVA: 0x196AAB0 Offset: 0x196ABB1 VA: 0x196AAB0
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	// RVA: 0x196AB10 Offset: 0x196AC11 VA: 0x196AB10
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x196A1C0 Offset: 0x196A2C1 VA: 0x196A1C0
	private static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	// RVA: 0x196AB00 Offset: 0x196AC01 VA: 0x196AB00
	internal static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }
}

