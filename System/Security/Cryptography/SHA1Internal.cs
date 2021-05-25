internal class SHA1Internal // TypeDefIndex: 985
{
	// Fields
	private uint[] _H; // 0x10
	private ulong count; // 0x18
	private byte[] _ProcessingBuffer; // 0x20
	private int _ProcessingBufferCount; // 0x28
	private uint[] buff; // 0x30

	// Methods

	// RVA: 0x26318C0 Offset: 0x26319C1 VA: 0x26318C0
	public void .ctor() { }

	// RVA: 0x2631A30 Offset: 0x2631B31 VA: 0x2631A30
	public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2631B60 Offset: 0x2631C61 VA: 0x2631B60
	public byte[] HashFinal() { }

	// RVA: 0x2631EF0 Offset: 0x2631FF1 VA: 0x2631EF0
	public void Initialize() { }

	// RVA: 0x2631FC0 Offset: 0x26320C1 VA: 0x2631FC0
	private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

	// RVA: 0x26326D0 Offset: 0x26327D1 VA: 0x26326D0
	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

	// RVA: 0x2632DC0 Offset: 0x2632EC1 VA: 0x2632DC0
	private static void FillBuff(uint[] buff) { }

	// RVA: 0x26324F0 Offset: 0x26325F1 VA: 0x26324F0
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x2633000 Offset: 0x2633101 VA: 0x2633000
	internal void AddLength(ulong length, byte[] buffer, int position) { }
}

