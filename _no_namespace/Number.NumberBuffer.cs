[FriendAccessAllowedAttribute] // RVA: 0xAC480 Offset: 0xAC581 VA: 0xAC480
internal struct Number.NumberBuffer // TypeDefIndex: 288
{
	// Fields
	public static readonly int NumberBufferBytes; // 0x0
	private byte* baseAddress; // 0x0
	public char* digits; // 0x8
	public int precision; // 0x10
	public int scale; // 0x14
	public bool sign; // 0x18

	// Methods

	// RVA: 0x10EB0 Offset: 0x10FB1 VA: 0x10EB0
	public void .ctor(byte* stackBuffer) { }

	// RVA: 0x10ED0 Offset: 0x10FD1 VA: 0x10ED0
	public byte* PackForNative() { }

	// RVA: 0x18E4CF0 Offset: 0x18E4DF1 VA: 0x18E4CF0
	private static void .cctor() { }
}

