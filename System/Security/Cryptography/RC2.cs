[ComVisibleAttribute] // RVA: 0xB00D0 Offset: 0xB01D1 VA: 0xB00D0
public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 947
{
	// Fields
	protected int EffectiveKeySizeValue; // 0x44
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }

	// Methods

	// RVA: 0x1950F70 Offset: 0x1951071 VA: 0x1950F70
	protected void .ctor() { }

	// RVA: 0x1951020 Offset: 0x1951121 VA: 0x1951020 Slot: 26
	public virtual int get_EffectiveKeySize() { }

	// RVA: 0x1951040 Offset: 0x1951141 VA: 0x1951040 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1951050 Offset: 0x1951151 VA: 0x1951050 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1951100 Offset: 0x1951201 VA: 0x1951100
	public static RC2 Create() { }

	// RVA: 0x1951160 Offset: 0x1951261 VA: 0x1951160
	private static void .cctor() { }
}

