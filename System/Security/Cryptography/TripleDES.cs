[ComVisibleAttribute] // RVA: 0xB0350 Offset: 0xB0451 VA: 0xB0350
public abstract class TripleDES : SymmetricAlgorithm // TypeDefIndex: 974
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x2639750 Offset: 0x2639851 VA: 0x2639750
	protected void .ctor() { }

	// RVA: 0x2639810 Offset: 0x2639911 VA: 0x2639810 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x2639A70 Offset: 0x2639B71 VA: 0x2639A70 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x2639CA0 Offset: 0x2639DA1 VA: 0x2639CA0
	public static TripleDES Create() { }

	// RVA: 0x2639900 Offset: 0x2639A01 VA: 0x2639900
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x2639ED0 Offset: 0x2639FD1 VA: 0x2639ED0
	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	// RVA: 0x2639DC0 Offset: 0x2639EC1 VA: 0x2639DC0
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x263A0B0 Offset: 0x263A1B1 VA: 0x263A0B0
	private static void .cctor() { }
}

