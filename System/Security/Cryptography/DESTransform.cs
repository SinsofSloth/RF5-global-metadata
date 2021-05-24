internal class DESTransform : SymmetricTransform // TypeDefIndex: 978
{
	// Fields
	internal static readonly int KEY_BIT_SIZE; // 0x0
	internal static readonly int KEY_BYTE_SIZE; // 0x4
	internal static readonly int BLOCK_BIT_SIZE; // 0x8
	internal static readonly int BLOCK_BYTE_SIZE; // 0xC
	private byte[] keySchedule; // 0x58
	private byte[] byteBuff; // 0x60
	private uint[] dwordBuff; // 0x68
	private static readonly uint[] spBoxes; // 0x10
	private static readonly byte[] PC1; // 0x18
	private static readonly byte[] leftRotTotal; // 0x20
	private static readonly byte[] PC2; // 0x28
	internal static readonly uint[] ipTab; // 0x30
	internal static readonly uint[] fpTab; // 0x38

	// Methods

	// RVA: 0x194B000 Offset: 0x194B101 VA: 0x194B000
	internal void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x194BB90 Offset: 0x194BC91 VA: 0x194BB90
	private uint CipherFunct(uint r, int n) { }

	// RVA: 0x194BDE0 Offset: 0x194BEE1 VA: 0x194BDE0
	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	// RVA: 0x194C140 Offset: 0x194C241 VA: 0x194C140
	private static void BSwap(byte[] byteBuff) { }

	// RVA: 0x194B650 Offset: 0x194B751 VA: 0x194B650
	internal void SetKey(byte[] key) { }

	// RVA: 0x194C1D0 Offset: 0x194C2D1 VA: 0x194C1D0
	public void ProcessBlock(byte[] input, byte[] output) { }

	// RVA: 0x194C590 Offset: 0x194C691 VA: 0x194C590 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x194B530 Offset: 0x194B631 VA: 0x194B530
	internal static byte[] GetStrongKey() { }

	// RVA: 0x194C650 Offset: 0x194C751 VA: 0x194C650
	private static void .cctor() { }
}

