internal static class SystemCertificateValidator // TypeDefIndex: 1726
{
	// Fields
	private static bool is_macosx; // 0x0
	private static X509KeyUsageFlags s_flags; // 0x4

	// Methods

	// RVA: 0x16F7E10 Offset: 0x16F7F11 VA: 0x16F7E10
	private static void .cctor() { }

	// RVA: 0x16F7EB0 Offset: 0x16F7FB1 VA: 0x16F7EB0
	public static X509Chain CreateX509Chain(X509CertificateCollection certs) { }

	// RVA: 0x16F2290 Offset: 0x16F2391 VA: 0x16F2290
	internal static bool NeedsChain(MonoTlsSettings settings) { }
}

