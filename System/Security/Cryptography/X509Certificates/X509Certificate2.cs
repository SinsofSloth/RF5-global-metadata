[Serializable]
public class X509Certificate2 : X509Certificate // TypeDefIndex: 1842
{
	// Fields
	private string friendlyName; // 0x30
	private static byte[] signedData; // 0x0

	// Properties
	internal X509Certificate2Impl Impl { get; }
	public DateTime NotAfter { get; }
	public DateTime NotBefore { get; }
	public AsymmetricAlgorithm PrivateKey { get; }
	public PublicKey PublicKey { get; }
	public string SerialNumber { get; }
	public Oid SignatureAlgorithm { get; }
	public string Thumbprint { get; }
	public int Version { get; }

	// Methods

	// RVA: 0x1713C80 Offset: 0x1713D81 VA: 0x1713C80
	internal X509Certificate2Impl get_Impl() { }

	// RVA: 0x1713D30 Offset: 0x1713E31 VA: 0x1713D30
	public void .ctor() { }

	// RVA: 0x1713DA0 Offset: 0x1713EA1 VA: 0x1713DA0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1713E30 Offset: 0x1713F31 VA: 0x1713E30
	public DateTime get_NotAfter() { }

	// RVA: 0x1713F00 Offset: 0x1714001 VA: 0x1713F00
	public DateTime get_NotBefore() { }

	// RVA: 0x1713FD0 Offset: 0x17140D1 VA: 0x1713FD0
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1714090 Offset: 0x1714191 VA: 0x1714090
	public PublicKey get_PublicKey() { }

	// RVA: 0x1714150 Offset: 0x1714251 VA: 0x1714150
	public string get_SerialNumber() { }

	// RVA: 0x1714160 Offset: 0x1714261 VA: 0x1714160
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x1714220 Offset: 0x1714321 VA: 0x1714220
	public string get_Thumbprint() { }

	// RVA: 0x1714230 Offset: 0x1714331 VA: 0x1714230
	public int get_Version() { }

	[MonoTODOAttribute] // RVA: 0xBD6C0 Offset: 0xBD7C1 VA: 0xBD6C0
	// RVA: 0x17142F0 Offset: 0x17143F1 VA: 0x17142F0 Slot: 14
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1714460 Offset: 0x1714561 VA: 0x1714460 Slot: 16
	public override void Reset() { }

	// RVA: 0x17144D0 Offset: 0x17145D1 VA: 0x17144D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1714550 Offset: 0x1714651 VA: 0x1714550 Slot: 13
	public override string ToString(bool verbose) { }

	// RVA: 0x1714990 Offset: 0x1714A91 VA: 0x1714990
	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	// RVA: 0x1714AA0 Offset: 0x1714BA1 VA: 0x1714AA0
	private static void .cctor() { }
}

