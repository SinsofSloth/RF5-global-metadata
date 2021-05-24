[ComVisibleAttribute] // RVA: 0xAFF50 Offset: 0xB0051 VA: 0xAFF50
public abstract class HMAC : KeyedHashAlgorithm // TypeDefIndex: 934
{
	// Fields
	private int blockSizeValue; // 0x30
	internal string m_hashName; // 0x38
	internal HashAlgorithm m_hash1; // 0x40
	internal HashAlgorithm m_hash2; // 0x48
	private byte[] m_inner; // 0x50
	private byte[] m_outer; // 0x58
	private bool m_hashing; // 0x60

	// Properties
	protected int BlockSizeValue { get; set; }
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x194D850 Offset: 0x194D951 VA: 0x194D850
	protected int get_BlockSizeValue() { }

	// RVA: 0x194D860 Offset: 0x194D961 VA: 0x194D860
	protected void set_BlockSizeValue(int value) { }

	// RVA: 0x194D870 Offset: 0x194D971 VA: 0x194D870
	private void UpdateIOPadBuffers() { }

	// RVA: 0x194DA40 Offset: 0x194DB41 VA: 0x194DA40
	internal void InitializeKey(byte[] key) { }

	// RVA: 0x194DCA0 Offset: 0x194DDA1 VA: 0x194DCA0 Slot: 19
	public override byte[] get_Key() { }

	// RVA: 0x194DD20 Offset: 0x194DE21 VA: 0x194DD20 Slot: 20
	public override void set_Key(byte[] value) { }

	// RVA: 0x194DDD0 Offset: 0x194DED1 VA: 0x194DDD0
	public static HMAC Create() { }

	// RVA: 0x194DE40 Offset: 0x194DF41 VA: 0x194DE40 Slot: 16
	public override void Initialize() { }

	// RVA: 0x194DEA0 Offset: 0x194DFA1 VA: 0x194DEA0 Slot: 17
	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	// RVA: 0x194E120 Offset: 0x194E221 VA: 0x194E120 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x194E4B0 Offset: 0x194E5B1 VA: 0x194E4B0 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x194E710 Offset: 0x194E811 VA: 0x194E710
	protected void .ctor() { }
}

