public sealed class X509SubjectKeyIdentifierExtension : X509Extension // TypeDefIndex: 1862
{
	// Fields
	internal const string oid = "2.5.29.14";
	internal const string friendlyName = "Subject Key Identifier";
	private byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Properties
	public string SubjectKeyIdentifier { get; }

	// Methods

	// RVA: 0x171A310 Offset: 0x171A411 VA: 0x171A310
	public void .ctor() { }

	// RVA: 0x17103B0 Offset: 0x17104B1 VA: 0x17103B0
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x171A5A0 Offset: 0x171A6A1 VA: 0x171A5A0
	public void .ctor(byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x171A830 Offset: 0x171A931 VA: 0x171A830
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x171AC00 Offset: 0x171AD01 VA: 0x171AC00
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x171AC10 Offset: 0x171AD11 VA: 0x171AC10
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x171B010 Offset: 0x171B111 VA: 0x171B010
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x171B0C0 Offset: 0x171B1C1 VA: 0x171B0C0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x171B290 Offset: 0x171B391 VA: 0x171B290
	internal static byte FromHexChar(char c) { }

	// RVA: 0x171B2D0 Offset: 0x171B3D1 VA: 0x171B2D0
	internal static byte FromHexChars(char c1, char c2) { }

	// RVA: 0x171AA10 Offset: 0x171AB11 VA: 0x171AA10
	internal static byte[] FromHex(string hex) { }

	// RVA: 0x171A3D0 Offset: 0x171A4D1 VA: 0x171A3D0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x171A7B0 Offset: 0x171A8B1 VA: 0x171A7B0
	internal byte[] Encode() { }

	// RVA: 0x171B370 Offset: 0x171B471 VA: 0x171B370 Slot: 5
	internal override string ToString(bool multiLine) { }
}

