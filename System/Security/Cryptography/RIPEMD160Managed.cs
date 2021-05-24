[ComVisibleAttribute] // RVA: 0xB0190 Offset: 0xB0291 VA: 0xB0190
public class RIPEMD160Managed : RIPEMD160 // TypeDefIndex: 954
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateMD160; // 0x38
	private uint[] _blockDWords; // 0x40

	// Methods

	// RVA: 0x1945C80 Offset: 0x1945D81 VA: 0x1945C80
	public void .ctor() { }

	// RVA: 0x1952B40 Offset: 0x1952C41 VA: 0x1952B40 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1952B90 Offset: 0x1952C91 VA: 0x1952B90 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1952D40 Offset: 0x1952E41 VA: 0x1952D40 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1952A80 Offset: 0x1952B81 VA: 0x1952A80
	private void InitializeState() { }

	// RVA: 0x1952BA0 Offset: 0x1952CA1 VA: 0x1952BA0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x1952D50 Offset: 0x1952E51 VA: 0x1952D50
	private byte[] _EndHash() { }

	// RVA: 0x1952F20 Offset: 0x1953021 VA: 0x1952F20
	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

	// RVA: 0x1954560 Offset: 0x1954661 VA: 0x1954560
	private static uint F(uint x, uint y, uint z) { }

	// RVA: 0x1954570 Offset: 0x1954671 VA: 0x1954570
	private static uint G(uint x, uint y, uint z) { }

	// RVA: 0x1954580 Offset: 0x1954681 VA: 0x1954580
	private static uint H(uint x, uint y, uint z) { }

	// RVA: 0x1954590 Offset: 0x1954691 VA: 0x1954590
	private static uint I(uint x, uint y, uint z) { }

	// RVA: 0x19545A0 Offset: 0x19546A1 VA: 0x19545A0
	private static uint J(uint x, uint y, uint z) { }
}

