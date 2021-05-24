[ComVisibleAttribute] // RVA: 0xB0010 Offset: 0xB0111 VA: 0xB0010
public class HMACSHA512 : HMAC // TypeDefIndex: 940
{
	// Fields
	private bool m_useLegacyBlockSize; // 0x61

	// Properties
	private int BlockSize { get; }

	// Methods

	// RVA: 0x1945900 Offset: 0x1945A01 VA: 0x1945900
	public void .ctor() { }

	// RVA: 0x194EBD0 Offset: 0x194ECD1 VA: 0x194EBD0
	public void .ctor(byte[] key) { }

	// RVA: 0x194ECE0 Offset: 0x194EDE1 VA: 0x194ECE0
	private int get_BlockSize() { }
}

