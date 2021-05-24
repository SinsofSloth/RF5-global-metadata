public sealed class X509KeyUsageExtension : X509Extension // TypeDefIndex: 1861
{
	// Fields
	internal const string oid = "2.5.29.15";
	internal const string friendlyName = "Key Usage";
	internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public X509KeyUsageFlags KeyUsages { get; }

	// Methods

	// RVA: 0x1719670 Offset: 0x1719771 VA: 0x1719670
	public void .ctor() { }

	// RVA: 0x17102B0 Offset: 0x17103B1 VA: 0x17102B0
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x1719960 Offset: 0x1719A61 VA: 0x1719960
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x1719C10 Offset: 0x1719D11 VA: 0x1719C10
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x1719CA0 Offset: 0x1719DA1 VA: 0x1719CA0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1719A50 Offset: 0x1719B51 VA: 0x1719A50
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x1719730 Offset: 0x1719831 VA: 0x1719730
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1719A60 Offset: 0x1719B61 VA: 0x1719A60
	internal byte[] Encode() { }

	// RVA: 0x1719E70 Offset: 0x1719F71 VA: 0x1719E70 Slot: 5
	internal override string ToString(bool multiLine) { }
}

