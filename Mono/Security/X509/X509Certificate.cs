internal class X509Certificate : ISerializable // TypeDefIndex: 54
{
	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private RSA _rsa; // 0x80
	private DSA _dsa; // 0x88
	private int version; // 0x90
	private byte[] serialnumber; // 0x98
	private byte[] issuerUniqueID; // 0xA0
	private byte[] subjectUniqueID; // 0xA8
	private X509ExtensionCollection extensions; // 0xB0
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; }
	public virtual string IssuerName { get; }
	public virtual byte[] KeyAlgorithmParameters { get; }
	public virtual RSA RSA { get; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }

	// Methods

	// RVA: 0x1905170 Offset: 0x1905271 VA: 0x1905170
	private void Parse(byte[] data) { }

	// RVA: 0x18FDAB0 Offset: 0x18FDBB1 VA: 0x18FDAB0
	public void .ctor(byte[] data) { }

	// RVA: 0x1906190 Offset: 0x1906291 VA: 0x1906190
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x18FEDD0 Offset: 0x18FEED1 VA: 0x18FEDD0
	public DSA get_DSA() { }

	// RVA: 0x1906240 Offset: 0x1906341 VA: 0x1906240 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x1906250 Offset: 0x1906351 VA: 0x1906250 Slot: 6
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x19062D0 Offset: 0x19063D1 VA: 0x19062D0 Slot: 7
	public virtual RSA get_RSA() { }

	// RVA: 0x19064D0 Offset: 0x19065D1 VA: 0x19064D0 Slot: 8
	public virtual byte[] get_RawData() { }

	// RVA: 0x1906550 Offset: 0x1906651 VA: 0x1906550 Slot: 9
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x19065D0 Offset: 0x19066D1 VA: 0x19065D0 Slot: 10
	public virtual string get_SubjectName() { }

	// RVA: 0x19065E0 Offset: 0x19066E1 VA: 0x19065E0 Slot: 11
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x19065F0 Offset: 0x19066F1 VA: 0x19065F0 Slot: 12
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x1906600 Offset: 0x1906701 VA: 0x1906600
	public ASN1 GetIssuerName() { }

	// RVA: 0x1906610 Offset: 0x1906711 VA: 0x1906610
	public ASN1 GetSubjectName() { }

	// RVA: 0x1906620 Offset: 0x1906721 VA: 0x1906620 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1906070 Offset: 0x1906171 VA: 0x1906070
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x1906690 Offset: 0x1906791 VA: 0x1906690
	private static void .cctor() { }
}

public class X509Certificate : ISerializable // TypeDefIndex: 1558
{
	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private RSA _rsa; // 0x80
	private DSA _dsa; // 0x88
	private int version; // 0x90
	private byte[] serialnumber; // 0x98
	private byte[] issuerUniqueID; // 0xA0
	private byte[] subjectUniqueID; // 0xA8
	private X509ExtensionCollection extensions; // 0xB0
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; set; }
	public virtual string IssuerName { get; }
	public virtual string KeyAlgorithm { get; }
	public virtual byte[] KeyAlgorithmParameters { get; }
	public virtual byte[] PublicKey { get; }
	public virtual RSA RSA { get; set; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual string SignatureAlgorithm { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }
	public int Version { get; }

	// Methods

	// RVA: 0x1BD06B0 Offset: 0x1BD07B1 VA: 0x1BD06B0
	private void Parse(byte[] data) { }

	// RVA: 0x1BD15C0 Offset: 0x1BD16C1 VA: 0x1BD15C0
	public void .ctor(byte[] data) { }

	// RVA: 0x1BD1890 Offset: 0x1BD1991 VA: 0x1BD1890
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x1BD1940 Offset: 0x1BD1A41 VA: 0x1BD1940
	public DSA get_DSA() { }

	// RVA: 0x1BD1C80 Offset: 0x1BD1D81 VA: 0x1BD1C80
	public void set_DSA(DSA value) { }

	// RVA: 0x1BD1CD0 Offset: 0x1BD1DD1 VA: 0x1BD1CD0 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x1BD1CE0 Offset: 0x1BD1DE1 VA: 0x1BD1CE0 Slot: 6
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0x1BD1CF0 Offset: 0x1BD1DF1 VA: 0x1BD1CF0 Slot: 7
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x1BD1D70 Offset: 0x1BD1E71 VA: 0x1BD1D70 Slot: 8
	public virtual byte[] get_PublicKey() { }

	// RVA: 0x1BD1DF0 Offset: 0x1BD1EF1 VA: 0x1BD1DF0 Slot: 9
	public virtual RSA get_RSA() { }

	// RVA: 0x1BD1FF0 Offset: 0x1BD20F1 VA: 0x1BD1FF0 Slot: 10
	public virtual void set_RSA(RSA value) { }

	// RVA: 0x1BD2030 Offset: 0x1BD2131 VA: 0x1BD2030 Slot: 11
	public virtual byte[] get_RawData() { }

	// RVA: 0x1BD20B0 Offset: 0x1BD21B1 VA: 0x1BD20B0 Slot: 12
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x1BD2130 Offset: 0x1BD2231 VA: 0x1BD2130 Slot: 13
	public virtual string get_SignatureAlgorithm() { }

	// RVA: 0x1BD2140 Offset: 0x1BD2241 VA: 0x1BD2140 Slot: 14
	public virtual string get_SubjectName() { }

	// RVA: 0x1BD2150 Offset: 0x1BD2251 VA: 0x1BD2150 Slot: 15
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x1BD2160 Offset: 0x1BD2261 VA: 0x1BD2160 Slot: 16
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x1BD2170 Offset: 0x1BD2271 VA: 0x1BD2170
	public int get_Version() { }

	// RVA: 0x1BD2180 Offset: 0x1BD2281 VA: 0x1BD2180
	public ASN1 GetIssuerName() { }

	// RVA: 0x1BD2190 Offset: 0x1BD2291 VA: 0x1BD2190
	public ASN1 GetSubjectName() { }

	// RVA: 0x1BD21A0 Offset: 0x1BD22A1 VA: 0x1BD21A0 Slot: 17
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BD1770 Offset: 0x1BD1871 VA: 0x1BD1770
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x1BD2210 Offset: 0x1BD2311 VA: 0x1BD2210
	private static void .cctor() { }
}

