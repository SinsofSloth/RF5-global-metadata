public interface ICertificateValidator // TypeDefIndex: 1576
{
	// Properties
	public abstract MonoTlsSettings Settings { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ValidationResult ValidateCertificate(string targetHost, bool serverMode, X509CertificateCollection certificates) { }
}

