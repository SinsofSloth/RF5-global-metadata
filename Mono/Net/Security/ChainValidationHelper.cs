internal class ChainValidationHelper : ICertificateValidator2, ICertificateValidator // TypeDefIndex: 1714
{
	// Fields
	private readonly object sender; // 0x10
	private readonly MonoTlsSettings settings; // 0x18
	private readonly MonoTlsProvider provider; // 0x20
	private readonly ServerCertValidationCallback certValidationCallback; // 0x28
	private readonly LocalCertSelectionCallback certSelectionCallback; // 0x30
	private readonly ServerCertValidationCallbackWrapper callbackWrapper; // 0x38
	private readonly MonoTlsStream tlsStream; // 0x40
	private readonly HttpWebRequest request; // 0x48

	// Properties
	public MonoTlsSettings Settings { get; }

	// Methods

	// RVA: 0x16F0E50 Offset: 0x16F0F51 VA: 0x16F0E50
	internal static ICertificateValidator GetInternalValidator(MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16F1210 Offset: 0x16F1311 VA: 0x16F1210
	internal static ChainValidationHelper Create(MonoTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0x16F0F00 Offset: 0x16F1001 VA: 0x16F0F00
	private void .ctor(MonoTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream, ServerCertValidationCallbackWrapper callbackWrapper) { }

	// RVA: 0x16F14E0 Offset: 0x16F15E1 VA: 0x16F14E0
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x16F1530 Offset: 0x16F1631 VA: 0x16F1530 Slot: 5
	public MonoTlsSettings get_Settings() { }

	// RVA: 0x16F1540 Offset: 0x16F1641 VA: 0x16F1540 Slot: 6
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: 0x16F15A0 Offset: 0x16F16A1 VA: 0x16F15A0 Slot: 7
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509CertificateCollection certs) { }

	// RVA: 0x16F1810 Offset: 0x16F1911 VA: 0x16F1810 Slot: 4
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x16F1760 Offset: 0x16F1861 VA: 0x16F1760
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x16F1950 Offset: 0x16F1A51 VA: 0x16F1950
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }
}

