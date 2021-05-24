internal static class CertHelper // TypeDefIndex: 1626
{
	// Methods

	// RVA: 0x16F7FA0 Offset: 0x16F80A1 VA: 0x16F7FA0
	public static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16F8110 Offset: 0x16F8211 VA: 0x16F8110
	public static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16F8680 Offset: 0x16F8781 VA: 0x16F8680
	public static X509CertificateCollection NativeChainToManagedCollection(UnityTls.unitytls_x509list_ref nativeCertificateChain, UnityTls.unitytls_errorstate* errorState) { }
}

