[ComVisibleAttribute] // RVA: 0xB03D0 Offset: 0xB04D1 VA: 0xB03D0
public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 980
{
	// Fields
	private uint[] _H; // 0x28
	private uint[] buff; // 0x30
	private ulong count; // 0x38
	private byte[] _ProcessingBuffer; // 0x40
	private int _ProcessingBufferCount; // 0x48
	private static readonly uint[] K; // 0x0

	// Methods

	// RVA: 0x1945AA0 Offset: 0x1945BA1 VA: 0x1945AA0
	public void .ctor() { }

	// RVA: 0x194F9C0 Offset: 0x194FAC1 VA: 0x194F9C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x194FA40 Offset: 0x194FB41 VA: 0x194FA40 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x194FAE0 Offset: 0x194FBE1 VA: 0x194FAE0 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x19508A0 Offset: 0x19509A1 VA: 0x19508A0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1950D40 Offset: 0x1950E41 VA: 0x1950D40 Slot: 16
	public override void Initialize() { }

	// RVA: 0x194FBF0 Offset: 0x194FCF1 VA: 0x194FBF0
	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	// RVA: 0x1950B70 Offset: 0x1950C71 VA: 0x1950B70
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1950DF0 Offset: 0x1950EF1 VA: 0x1950DF0
	internal void AddLength(ulong length, byte[] buffer, int position) { }

	// RVA: 0x1950EF0 Offset: 0x1950FF1 VA: 0x1950EF0
	private static void .cctor() { }
}

