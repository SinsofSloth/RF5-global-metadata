public class MD4Managed : MD4 // TypeDefIndex: 1593
{
	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x1A680F0 Offset: 0x1A681F1 VA: 0x1A680F0
	public void .ctor() { }

	// RVA: 0x1A68200 Offset: 0x1A68301 VA: 0x1A68200 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1A68300 Offset: 0x1A68401 VA: 0x1A68300 Slot: 17
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1A68AD0 Offset: 0x1A68BD1 VA: 0x1A68AD0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1A68D40 Offset: 0x1A68E41 VA: 0x1A68D40
	private byte[] Padding(int nLength) { }

	// RVA: 0x1A68DD0 Offset: 0x1A68ED1 VA: 0x1A68DD0
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x1A68DE0 Offset: 0x1A68EE1 VA: 0x1A68DE0
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x1A68E00 Offset: 0x1A68F01 VA: 0x1A68E00
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x1A68E10 Offset: 0x1A68F11 VA: 0x1A68E10
	private uint ROL(uint x, byte n) { }

	// RVA: 0x1A68E20 Offset: 0x1A68F21 VA: 0x1A68E20
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1A68E50 Offset: 0x1A68F51 VA: 0x1A68E50
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1A68E90 Offset: 0x1A68F91 VA: 0x1A68E90
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1A68C30 Offset: 0x1A68D31 VA: 0x1A68C30
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x1A68EC0 Offset: 0x1A68FC1 VA: 0x1A68EC0
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x1A68450 Offset: 0x1A68551 VA: 0x1A68450
	private void MD4Transform(uint[] state, byte[] block, int index) { }
}

