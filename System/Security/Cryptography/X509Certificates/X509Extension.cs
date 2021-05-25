public class X509Extension : AsnEncodedData // TypeDefIndex: 1857
{
	// Fields
	private bool _critical; // 0x20

	// Properties
	public bool Critical { get; set; }

	// Methods

	// RVA: 0x1713050 Offset: 0x1713151 VA: 0x1713050
	protected void .ctor() { }

	// RVA: 0x1719240 Offset: 0x1719341 VA: 0x1719240
	public bool get_Critical() { }

	// RVA: 0x1719250 Offset: 0x1719351 VA: 0x1719250
	public void set_Critical(bool value) { }

	// RVA: 0x1719260 Offset: 0x1719361 VA: 0x1719260 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1713B40 Offset: 0x1713C41 VA: 0x1713B40
	internal string FormatUnkownData(byte[] data) { }
}

