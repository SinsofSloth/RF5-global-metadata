[ExtensionAttribute] // RVA: 0xBF1A0 Offset: 0xBF2A1 VA: 0xBF1A0
internal static class TypeExtensions // TypeDefIndex: 2737
{
	// Fields
	private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache; // 0x0

	// Methods

	[ExtensionAttribute] // RVA: 0xC12C0 Offset: 0xC13C1 VA: 0xC12C0
	// RVA: 0x16A2050 Offset: 0x16A2151 VA: 0x16A2050
	public static MethodInfo GetAnyStaticMethodValidated(Type type, string name, Type[] types) { }

	[ExtensionAttribute] // RVA: 0xC12D0 Offset: 0xC13D1 VA: 0xC12D0
	// RVA: 0x16A2100 Offset: 0x16A2201 VA: 0x16A2100
	private static bool MatchesArgumentTypes(MethodInfo mi, Type[] argTypes) { }

	[ExtensionAttribute] // RVA: 0xC12E0 Offset: 0xC13E1 VA: 0xC12E0
	// RVA: 0x16A2220 Offset: 0x16A2321 VA: 0x16A2220
	public static TypeCode GetTypeCode(Type type) { }

	[ExtensionAttribute] // RVA: 0xC12F0 Offset: 0xC13F1 VA: 0xC12F0
	// RVA: 0x16A1640 Offset: 0x16A1741 VA: 0x16A1640
	internal static ParameterInfo[] GetParametersCached(MethodBase method) { }

	// RVA: 0x16A2380 Offset: 0x16A2481 VA: 0x16A2380
	private static void .cctor() { }
}

