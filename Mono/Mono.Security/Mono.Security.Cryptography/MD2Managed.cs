public class MD2Managed : MD2 // TypeDefIndex: 1591
{
	// Fields
	private byte[] state; // 0x28
	private byte[] checksum; // 0x30
	private byte[] buffer; // 0x38
	private int count; // 0x40
	private byte[] x; // 0x48
	private static readonly byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0x1A679A0 Offset: 0x1A67AA1 VA: 0x1A679A0
	private byte[] Padding(int nLength) { }

	// RVA: 0x1A678C0 Offset: 0x1A679C1 VA: 0x1A678C0
	public void .ctor() { }

	// RVA: 0x1A67A60 Offset: 0x1A67B61 VA: 0x1A67A60 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1A67AD0 Offset: 0x1A67BD1 VA: 0x1A67AD0 Slot: 17
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1A67E50 Offset: 0x1A67F51 VA: 0x1A67E50 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1A67BB0 Offset: 0x1A67CB1 VA: 0x1A67BB0
	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	// RVA: 0x1A67FE0 Offset: 0x1A680E1 VA: 0x1A67FE0
	private static void .cctor() { }
}

