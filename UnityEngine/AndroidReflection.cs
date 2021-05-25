internal class AndroidReflection // TypeDefIndex: 3797
{
	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0x1B9CEA0 Offset: 0x1B9CFA1 VA: 0x1B9CEA0
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x1B9CEC0 Offset: 0x1B9CFC1 VA: 0x1B9CEC0
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x1B9CEE0 Offset: 0x1B9CFE1 VA: 0x1B9CEE0
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x1B9CFD0 Offset: 0x1B9D0D1 VA: 0x1B9CFD0
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x1B9D0C0 Offset: 0x1B9D1C1 VA: 0x1B9D0C0
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x1B9D2B0 Offset: 0x1B9D3B1 VA: 0x1B9D2B0
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x1B9D570 Offset: 0x1B9D671 VA: 0x1B9D570
	public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x1B9BEF0 Offset: 0x1B9BFF1 VA: 0x1B9BEF0
	public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound) { }

	// RVA: 0x1B9D650 Offset: 0x1B9D751 VA: 0x1B9D650
	private static void .cctor() { }
}

