internal class X509Certificate2ImplMono : X509Certificate2Impl // TypeDefIndex: 1845
{
	// Fields
	private bool _archived; // 0x18
	private X509ExtensionCollection _extensions; // 0x20
	private PublicKey _publicKey; // 0x28
	private X500DistinguishedName issuer_name; // 0x30
	private X500DistinguishedName subject_name; // 0x38
	private Oid signature_algorithm; // 0x40
	private X509CertificateImplCollection intermediateCerts; // 0x48
	private X509Certificate _cert; // 0x50
	private static string empty_error; // 0x0
	private static byte[] commonName; // 0x8
	private static byte[] email; // 0x10
	private static byte[] signedData; // 0x18

	// Properties
	public override bool IsValid { get; }
	public override AsymmetricAlgorithm PrivateKey { get; }
	public override PublicKey PublicKey { get; }
	public override Oid SignatureAlgorithm { get; }
	public override int Version { get; }
	internal override X509CertificateImplCollection IntermediateCertificates { get; }

	// Methods

	// RVA: 0x1714C00 Offset: 0x1714D01 VA: 0x1714C00 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x1714C10 Offset: 0x1714D11 VA: 0x1714C10
	private void .ctor(X509Certificate cert) { }

	// RVA: 0x1714C50 Offset: 0x1714D51 VA: 0x1714C50
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x1714D60 Offset: 0x1714E61 VA: 0x1714D60 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x1714DD0 Offset: 0x1714ED1 VA: 0x1714DD0 Slot: 7
	public override string GetIssuerName(bool legacyV1Mode) { }

	// RVA: 0x1714E90 Offset: 0x1714F91 VA: 0x1714E90 Slot: 8
	public override string GetSubjectName(bool legacyV1Mode) { }

	// RVA: 0x1714F60 Offset: 0x1715061 VA: 0x1714F60 Slot: 9
	public override byte[] GetRawCertData() { }

	// RVA: 0x1714FA0 Offset: 0x17150A1 VA: 0x1714FA0 Slot: 12
	protected override byte[] GetCertHash(bool lazy) { }

	// RVA: 0x1715000 Offset: 0x1715101 VA: 0x1715000 Slot: 10
	public override DateTime GetValidFrom() { }

	// RVA: 0x1715040 Offset: 0x1715141 VA: 0x1715040 Slot: 11
	public override DateTime GetValidUntil() { }

	// RVA: 0x1715080 Offset: 0x1715181 VA: 0x1715080 Slot: 13
	public override bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: 0x1715090 Offset: 0x1715191 VA: 0x1715090 Slot: 14
	public override byte[] GetSerialNumber() { }

	// RVA: 0x17150D0 Offset: 0x17151D1 VA: 0x17150D0
	public void .ctor() { }

	// RVA: 0x1715100 Offset: 0x1715201 VA: 0x1715100 Slot: 17
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1715540 Offset: 0x1715641 VA: 0x1715540 Slot: 18
	public override PublicKey get_PublicKey() { }

	// RVA: 0x1715700 Offset: 0x1715801 VA: 0x1715700 Slot: 19
	public override Oid get_SignatureAlgorithm() { }

	// RVA: 0x1715810 Offset: 0x1715911 VA: 0x1715810 Slot: 20
	public override int get_Version() { }

	// RVA: 0x17158C0 Offset: 0x17159C1 VA: 0x17158C0
	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	[MonoTODOAttribute] // RVA: 0xBD700 Offset: 0xBD801 VA: 0xBD700
	// RVA: 0x1716250 Offset: 0x1716351 VA: 0x1716250 Slot: 22
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x17164D0 Offset: 0x17165D1 VA: 0x17164D0 Slot: 23
	public override void Reset() { }

	// RVA: 0x1716660 Offset: 0x1716761 VA: 0x1716660 Slot: 3
	public override string ToString() { }

	// RVA: 0x17166E0 Offset: 0x17167E1 VA: 0x17166E0 Slot: 15
	public override string ToString(bool verbose) { }

	// RVA: 0x1716CD0 Offset: 0x1716DD1 VA: 0x1716CD0
	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	// RVA: 0x1716DE0 Offset: 0x1716EE1 VA: 0x1716DE0 Slot: 21
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x1716DF0 Offset: 0x1716EF1 VA: 0x1716DF0
	private static void .cctor() { }
}

