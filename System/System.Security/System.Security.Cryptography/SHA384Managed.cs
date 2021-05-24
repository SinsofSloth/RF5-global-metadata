[ComVisibleAttribute] // RVA: 0xB02B0 Offset: 0xB03B1 VA: 0xB02B0
public class SHA384Managed : SHA384 // TypeDefIndex: 963
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA384; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x2635680 Offset: 0x2635781 VA: 0x2635680
	public void .ctor() { }

	// RVA: 0x2635900 Offset: 0x2635A01 VA: 0x2635900 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2635950 Offset: 0x2635A51 VA: 0x2635950 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2635B70 Offset: 0x2635C71 VA: 0x2635B70 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x26357A0 Offset: 0x26358A1 VA: 0x26357A0
	private void InitializeState() { }

	// RVA: 0x2635960 Offset: 0x2635A61 VA: 0x2635960
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x2635B80 Offset: 0x2635C81 VA: 0x2635B80
	private byte[] _EndHash() { }

	// RVA: 0x2635D50 Offset: 0x2635E51 VA: 0x2635D50
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x2636CA0 Offset: 0x2636DA1 VA: 0x2636CA0
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x2636C00 Offset: 0x2636D01 VA: 0x2636C00
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x2636C80 Offset: 0x2636D81 VA: 0x2636C80
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x2636C10 Offset: 0x2636D11 VA: 0x2636C10
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x2636B90 Offset: 0x2636C91 VA: 0x2636B90
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x2636CB0 Offset: 0x2636DB1 VA: 0x2636CB0
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x2636D20 Offset: 0x2636E21 VA: 0x2636D20
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x2636A20 Offset: 0x2636B21 VA: 0x2636A20
	private static void SHA384Expand(ulong* x) { }

	// RVA: 0x2636D90 Offset: 0x2636E91 VA: 0x2636D90
	private static void .cctor() { }
}

