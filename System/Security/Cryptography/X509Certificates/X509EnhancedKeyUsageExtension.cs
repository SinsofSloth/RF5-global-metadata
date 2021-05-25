public sealed class X509EnhancedKeyUsageExtension : X509Extension // TypeDefIndex: 1856
{
	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x17101B0 Offset: 0x17102B1 VA: 0x17101B0
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x1718D70 Offset: 0x1718E71 VA: 0x1718D70 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1718A50 Offset: 0x1718B51 VA: 0x1718A50
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1718F40 Offset: 0x1719041 VA: 0x1718F40 Slot: 5
	internal override string ToString(bool multiLine) { }
}

