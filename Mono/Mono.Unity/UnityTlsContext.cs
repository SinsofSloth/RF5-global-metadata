internal class UnityTlsContext : MobileTlsContext // TypeDefIndex: 1680
{
	// Fields
	private UnityTls.unitytls_tlsctx* tlsContext; // 0x58
	private UnityTls.unitytls_x509list* requestedClientCertChain; // 0x60
	private UnityTls.unitytls_key* requestedClientKey; // 0x68
	private UnityTls.unitytls_tlsctx_read_callback readCallback; // 0x70
	private UnityTls.unitytls_tlsctx_write_callback writeCallback; // 0x78
	private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback; // 0x80
	private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback; // 0x88
	private X509Certificate localClientCertificate; // 0x90
	private X509Certificate remoteCertificate; // 0x98
	private MonoTlsConnectionInfo connectioninfo; // 0xA0
	private bool isAuthenticated; // 0xA8
	private bool hasContext; // 0xA9
	private bool closedGraceful; // 0xAA
	private byte[] writeBuffer; // 0xB0
	private byte[] readBuffer; // 0xB8
	private GCHandle handle; // 0xC0
	private Exception lastException; // 0xC8

	// Properties
	public override bool IsAuthenticated { get; }
	internal override X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x1700E40 Offset: 0x1700F41 VA: 0x1700E40
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x17015B0 Offset: 0x17016B1 VA: 0x17015B0
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) { }

	// RVA: 0x17018F0 Offset: 0x17019F1 VA: 0x17018F0 Slot: 5
	public override bool get_IsAuthenticated() { }

	// RVA: 0x1701900 Offset: 0x1701A01 VA: 0x1701900 Slot: 9
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0x1701910 Offset: 0x1701A11 VA: 0x1701910 Slot: 10
	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1701AD0 Offset: 0x1701BD1 VA: 0x1701AD0 Slot: 11
	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1701C80 Offset: 0x1701D81 VA: 0x1701C80 Slot: 12
	public override void Shutdown() { }

	// RVA: 0x1701D50 Offset: 0x1701E51 VA: 0x1701D50 Slot: 13
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1701E60 Offset: 0x1701F61 VA: 0x1701E60 Slot: 6
	public override void StartHandshake() { }

	// RVA: 0x1701FD0 Offset: 0x17020D1 VA: 0x1701FD0 Slot: 7
	public override bool ProcessHandshake() { }

	// RVA: 0x1702140 Offset: 0x1702241 VA: 0x1702140 Slot: 8
	public override void FinishHandshake() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xBD060 Offset: 0xBD161 VA: 0xBD060
	// RVA: 0x1700B00 Offset: 0x1700C01 VA: 0x1700B00
	private static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1702250 Offset: 0x1702351 VA: 0x1702250
	private IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xBD0D0 Offset: 0xBD1D1 VA: 0xBD0D0
	// RVA: 0x1700BD0 Offset: 0x1700CD1 VA: 0x1700BD0
	private static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1702520 Offset: 0x1702621 VA: 0x1702520
	private IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xBD140 Offset: 0xBD241 VA: 0xBD140
	// RVA: 0x1700CA0 Offset: 0x1700DA1 VA: 0x1700CA0
	private static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x17028A0 Offset: 0x17029A1 VA: 0x17028A0
	private UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xBD1B0 Offset: 0xBD2B1 VA: 0xBD1B0
	// RVA: 0x1700D70 Offset: 0x1700E71 VA: 0x1700D70
	private static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1702A40 Offset: 0x1702B41 VA: 0x1702A40
	private void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }
}

