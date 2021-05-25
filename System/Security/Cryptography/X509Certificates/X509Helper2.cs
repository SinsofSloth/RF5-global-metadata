internal static class X509Helper2 // TypeDefIndex: 1859
{
	// Methods

	// RVA: 0x17193F0 Offset: 0x17194F1 VA: 0x17193F0
	internal static void Initialize() { }

	// RVA: 0x1713D20 Offset: 0x1713E21 VA: 0x1713D20
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x17143B0 Offset: 0x17144B1 VA: 0x17143B0
	internal static X509Certificate2Impl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags, bool disableProvider = False) { }

	// RVA: 0x1719460 Offset: 0x1719561 VA: 0x1719460
	internal static X509Certificate2Impl Import(X509Certificate cert, bool disableProvider = False) { }

	// RVA: 0x1717E40 Offset: 0x1717F41 VA: 0x1717E40
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x17195C0 Offset: 0x17196C1 VA: 0x17195C0
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x1717CE0 Offset: 0x1717DE1 VA: 0x1717CE0
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x17195E0 Offset: 0x17196E1 VA: 0x17195E0
	internal static Exception GetInvalidChainContextException() { }
}

