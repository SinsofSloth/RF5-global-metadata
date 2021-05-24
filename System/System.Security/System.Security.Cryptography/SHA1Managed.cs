[ComVisibleAttribute] // RVA: 0xB0230 Offset: 0xB0331 VA: 0xB0230
public class SHA1Managed : SHA1 // TypeDefIndex: 959
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA1; // 0x38
	private uint[] _expandedBuffer; // 0x40

	// Methods

	// RVA: 0x2633100 Offset: 0x2633201 VA: 0x2633100
	public void .ctor() { }

	// RVA: 0x26332E0 Offset: 0x26333E1 VA: 0x26332E0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2633330 Offset: 0x2633431 VA: 0x2633330 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x26334E0 Offset: 0x26335E1 VA: 0x26334E0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2633220 Offset: 0x2633321 VA: 0x2633220
	private void InitializeState() { }

	// RVA: 0x2633340 Offset: 0x2633441 VA: 0x2633340
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26334F0 Offset: 0x26335F1 VA: 0x26334F0
	private byte[] _EndHash() { }

	// RVA: 0x26336C0 Offset: 0x26337C1 VA: 0x26336C0
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x2634010 Offset: 0x2634111 VA: 0x2634010
	private static void SHAExpand(uint* x) { }
}

