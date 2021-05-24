[ComVisibleAttribute] // RVA: 0xACD80 Offset: 0xACE81 VA: 0xACD80
[ClassInterfaceAttribute] // RVA: 0xACD80 Offset: 0xACE81 VA: 0xACD80
[Serializable]
public abstract class Delegate : ICloneable, ISerializable // TypeDefIndex: 367
{
	// Fields
	private IntPtr method_ptr; // 0x10
	private IntPtr invoke_impl; // 0x18
	private object m_target; // 0x20
	private IntPtr method; // 0x28
	private IntPtr delegate_trampoline; // 0x30
	private IntPtr extra_arg; // 0x38
	private IntPtr method_code; // 0x40
	private MethodInfo method_info; // 0x48
	private MethodInfo original_method_info; // 0x50
	private DelegateData data; // 0x58
	private bool method_is_virtual; // 0x60

	// Properties
	public MethodInfo Method { get; }
	public object Target { get; }

	// Methods

	// RVA: 0x19B1FD0 Offset: 0x19B20D1 VA: 0x19B1FD0
	public MethodInfo get_Method() { }

	// RVA: 0x19B1FE0 Offset: 0x19B20E1 VA: 0x19B1FE0
	private MethodInfo GetVirtualMethod_internal() { }

	// RVA: 0x19B1FF0 Offset: 0x19B20F1 VA: 0x19B1FF0
	public object get_Target() { }

	// RVA: 0x19B2000 Offset: 0x19B2101 VA: 0x19B2000
	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	// RVA: 0x19B2010 Offset: 0x19B2111 VA: 0x19B2010
	private static bool arg_type_match(Type delArgType, Type argType) { }

	// RVA: 0x19B21D0 Offset: 0x19B22D1 VA: 0x19B21D0
	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	// RVA: 0x19B2350 Offset: 0x19B2451 VA: 0x19B2350
	private static bool return_type_match(Type delReturnType, Type returnType) { }

	// RVA: 0x19B2420 Offset: 0x19B2521 VA: 0x19B2420
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0x19B2430 Offset: 0x19B2531 VA: 0x19B2430
	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	// RVA: 0x19B2C50 Offset: 0x19B2D51 VA: 0x19B2C50
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	// RVA: 0x19B2C60 Offset: 0x19B2D61 VA: 0x19B2C60
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0x19B2C80 Offset: 0x19B2D81 VA: 0x19B2C80
	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	// RVA: 0x19B2CA0 Offset: 0x19B2DA1 VA: 0x19B2CA0
	public static Delegate CreateDelegate(Type type, object target, string method) { }

	// RVA: 0x19B2CC0 Offset: 0x19B2DC1 VA: 0x19B2CC0
	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x19B3100 Offset: 0x19B3201 VA: 0x19B3100
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x19B3220 Offset: 0x19B3321 VA: 0x19B3220
	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	// RVA: 0x19B3230 Offset: 0x19B3331 VA: 0x19B3230
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x19B2CB0 Offset: 0x19B2DB1 VA: 0x19B2CB0
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	// RVA: 0x19B3330 Offset: 0x19B3431 VA: 0x19B3330
	public object DynamicInvoke(object[] args) { }

	// RVA: 0x19B3340 Offset: 0x19B3441 VA: 0x19B3340
	private void InitializeDelegateData() { }

	// RVA: 0x19B3440 Offset: 0x19B3541 VA: 0x19B3440 Slot: 6
	protected virtual object DynamicInvokeImpl(object[] args) { }

	// RVA: 0x19B3770 Offset: 0x19B3871 VA: 0x19B3770 Slot: 7
	public virtual object Clone() { }

	// RVA: 0x19B3780 Offset: 0x19B3881 VA: 0x19B3780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x19B3960 Offset: 0x19B3A61 VA: 0x19B3960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19B39F0 Offset: 0x19B3AF1 VA: 0x19B39F0 Slot: 8
	protected virtual MethodInfo GetMethodImpl() { }

	// RVA: 0x19B3AE0 Offset: 0x19B3BE1 VA: 0x19B3AE0 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19B3DA0 Offset: 0x19B3EA1 VA: 0x19B3DA0 Slot: 10
	public virtual Delegate[] GetInvocationList() { }

	// RVA: 0x19B3E50 Offset: 0x19B3F51 VA: 0x19B3E50
	public static Delegate Combine(Delegate a, Delegate b) { }

	[ComVisibleAttribute] // RVA: 0xB7170 Offset: 0xB7271 VA: 0xB7170
	// RVA: 0x19B4040 Offset: 0x19B4141 VA: 0x19B4040
	public static Delegate Combine(Delegate[] delegates) { }

	// RVA: 0x19B40D0 Offset: 0x19B41D1 VA: 0x19B40D0 Slot: 11
	protected virtual Delegate CombineImpl(Delegate d) { }

	// RVA: 0x19B4150 Offset: 0x19B4251 VA: 0x19B4150
	public static Delegate Remove(Delegate source, Delegate value) { }

	// RVA: 0x19B4340 Offset: 0x19B4441 VA: 0x19B4340 Slot: 12
	protected virtual Delegate RemoveImpl(Delegate d) { }

	// RVA: 0x19B4370 Offset: 0x19B4471 VA: 0x19B4370
	public static bool op_Equality(Delegate d1, Delegate d2) { }

	// RVA: 0x19B43A0 Offset: 0x19B44A1 VA: 0x19B43A0
	public static bool op_Inequality(Delegate d1, Delegate d2) { }

	// RVA: 0x19B43E0 Offset: 0x19B44E1 VA: 0x19B43E0
	internal static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, object firstArgument, MethodInfo method) { }

	// RVA: 0x19B43F0 Offset: 0x19B44F1 VA: 0x19B43F0
	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }
}

