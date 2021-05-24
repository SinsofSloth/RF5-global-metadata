internal abstract class X509Certificate2Impl : X509CertificateImpl // TypeDefIndex: 1844
{
	// Properties
	public abstract AsymmetricAlgorithm PrivateKey { get; }
	public abstract PublicKey PublicKey { get; }
	public abstract Oid SignatureAlgorithm { get; }
	public abstract int Version { get; }
	internal abstract X509CertificateImplCollection IntermediateCertificates { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract PublicKey get_PublicKey() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract Oid get_SignatureAlgorithm() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract int get_Version() { }

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void Reset() { }

	// RVA: 0x1714BF0 Offset: 0x1714CF1 VA: 0x1714BF0
	protected void .ctor() { }
}

