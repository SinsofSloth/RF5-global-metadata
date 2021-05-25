internal class UnityTlsStream : MobileAuthenticatedStream // TypeDefIndex: 1683
{
	// Methods

	// RVA: 0x28DFD20 Offset: 0x28DFE21 VA: 0x28DFD20
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	// RVA: 0x28E04C0 Offset: 0x28E05C1 VA: 0x28E04C0 Slot: 47
	protected override MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }
}

