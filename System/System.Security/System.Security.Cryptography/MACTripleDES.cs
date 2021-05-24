[ComVisibleAttribute] // RVA: 0xB0070 Offset: 0xB0171 VA: 0xB0070
public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 943
{
	// Fields
	private ICryptoTransform m_encryptor; // 0x30
	private CryptoStream _cs; // 0x38
	private TailStream _ts; // 0x40
	private int m_bytesPerBlock; // 0x48
	private TripleDES des; // 0x50

	// Methods

	// RVA: 0x1945930 Offset: 0x1945A31 VA: 0x1945930
	public void .ctor() { }

	// RVA: 0x194F4C0 Offset: 0x194F5C1 VA: 0x194F4C0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x194F4D0 Offset: 0x194F5D1 VA: 0x194F4D0 Slot: 17
	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	// RVA: 0x194F650 Offset: 0x194F751 VA: 0x194F650 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x194F7C0 Offset: 0x194F8C1 VA: 0x194F7C0 Slot: 15
	protected override void Dispose(bool disposing) { }
}

