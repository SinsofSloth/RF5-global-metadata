[ExtensionAttribute] // RVA: 0xAD410 Offset: 0xAD511 VA: 0xAD410
public static class RuntimeReflectionExtensions // TypeDefIndex: 513
{
	// Methods

	// RVA: 0x17F2550 Offset: 0x17F2651 VA: 0x17F2550
	private static void CheckAndThrow(Type t) { }

	[ExtensionAttribute] // RVA: 0xB8050 Offset: 0xB8151 VA: 0xB8050
	// RVA: 0x17F2690 Offset: 0x17F2791 VA: 0x17F2690
	public static IEnumerable<PropertyInfo> GetRuntimeProperties(Type type) { }

	[ExtensionAttribute] // RVA: 0xB8060 Offset: 0xB8161 VA: 0xB8060
	// RVA: 0x17F26D0 Offset: 0x17F27D1 VA: 0x17F26D0
	public static IEnumerable<MethodInfo> GetRuntimeMethods(Type type) { }

	[ExtensionAttribute] // RVA: 0xB8070 Offset: 0xB8171 VA: 0xB8070
	// RVA: 0x17F2710 Offset: 0x17F2811 VA: 0x17F2710
	public static IEnumerable<FieldInfo> GetRuntimeFields(Type type) { }

	[ExtensionAttribute] // RVA: 0xB8080 Offset: 0xB8181 VA: 0xB8080
	// RVA: 0x17F2750 Offset: 0x17F2851 VA: 0x17F2750
	public static PropertyInfo GetRuntimeProperty(Type type, string name) { }

	[ExtensionAttribute] // RVA: 0xB8090 Offset: 0xB8191 VA: 0xB8090
	// RVA: 0x17F2790 Offset: 0x17F2891 VA: 0x17F2790
	public static MethodInfo GetRuntimeMethod(Type type, string name, Type[] parameters) { }

	[ExtensionAttribute] // RVA: 0xB80A0 Offset: 0xB81A1 VA: 0xB80A0
	// RVA: 0x17F27E0 Offset: 0x17F28E1 VA: 0x17F27E0
	public static FieldInfo GetRuntimeField(Type type, string name) { }
}

