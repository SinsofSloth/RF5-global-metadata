public class PKCS7.EncryptedData // TypeDefIndex: 49
{
	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x18FAF60 Offset: 0x18FB061 VA: 0x18FAF60
	public void .ctor() { }

	// RVA: 0x18FAF90 Offset: 0x18FB091 VA: 0x18FAF90
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x18FB360 Offset: 0x18FB461 VA: 0x18FB360
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x18FB370 Offset: 0x18FB471 VA: 0x18FB370
	public byte[] get_EncryptedContent() { }
}

public class PKCS7.EncryptedData // TypeDefIndex: 1553
{
	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x1A6E400 Offset: 0x1A6E501 VA: 0x1A6E400
	public void .ctor() { }

	// RVA: 0x1A6E430 Offset: 0x1A6E531 VA: 0x1A6E430
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1A6E710 Offset: 0x1A6E811 VA: 0x1A6E710
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x1A6E720 Offset: 0x1A6E821 VA: 0x1A6E720
	public byte[] get_EncryptedContent() { }
}

