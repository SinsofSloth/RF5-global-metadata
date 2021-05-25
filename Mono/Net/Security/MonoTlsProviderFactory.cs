internal static class MonoTlsProviderFactory // TypeDefIndex: 1723
{
	// Fields
	private static object locker; // 0x0
	private static bool initialized; // 0x8
	private static MonoTlsProvider defaultProvider; // 0x10
	private static Dictionary<string, Tuple<Guid, string>> providerRegistration; // 0x18
	private static Dictionary<Guid, MonoTlsProvider> providerCache; // 0x20
	internal static readonly Guid UnityTlsId; // 0x28
	internal static readonly Guid AppleTlsId; // 0x38
	internal static readonly Guid BtlsId; // 0x48
	internal static readonly Guid LegacyId; // 0x58

	// Methods

	// RVA: 0x16F62E0 Offset: 0x16F63E1 VA: 0x16F62E0
	internal static MonoTlsProvider GetProviderInternal() { }

	// RVA: 0x16F63F0 Offset: 0x16F64F1 VA: 0x16F63F0
	internal static void InitializeInternal() { }

	// RVA: 0x16F6D00 Offset: 0x16F6E01 VA: 0x16F6D00
	private static MonoTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0x16F6810 Offset: 0x16F6911 VA: 0x16F6810
	private static void InitializeProviderRegistration() { }

	// RVA: 0x16F6C60 Offset: 0x16F6D61 VA: 0x16F6C60
	private static MonoTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0x16F12C0 Offset: 0x16F13C1 VA: 0x16F12C0
	internal static MonoTlsProvider GetProvider() { }

	// RVA: 0x16F7230 Offset: 0x16F7331 VA: 0x16F7230
	private static void .cctor() { }
}

