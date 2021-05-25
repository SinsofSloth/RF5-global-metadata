[DefaultMemberAttribute] // RVA: 0x145F70 Offset: 0x146071 VA: 0x145F70
[MessagePackObjectAttribute] // RVA: 0x145F70 Offset: 0x146071 VA: 0x145F70
public struct BitVector32Int // TypeDefIndex: 6803
{
	// Fields
	[KeyAttribute] // RVA: 0x15FAB0 Offset: 0x15FBB1 VA: 0x15FAB0
	public uint data; // 0x0

	// Properties
	[IgnoreMemberAttribute] // RVA: 0x1B8FD0 Offset: 0x1B90D1 VA: 0x1B8FD0
	public bool Item { get; set; }
	[IgnoreMemberAttribute] // RVA: 0x1B8FE0 Offset: 0x1B90E1 VA: 0x1B8FE0
	public int Item { get; set; }
	[IgnoreMemberAttribute] // RVA: 0x1B8FF0 Offset: 0x1B90F1 VA: 0x1B8FF0
	public int Data { get; }

	// Methods

	// RVA: 0x2F3070 Offset: 0x2F3171 VA: 0x2F3070
	public bool get_Item(int bit) { }

	// RVA: 0x2F3090 Offset: 0x2F3191 VA: 0x2F3090
	public void set_Item(int bit, bool value) { }

	// RVA: 0x2F30B0 Offset: 0x2F31B1 VA: 0x2F30B0
	public int get_Item(BitVector32Int.Section section) { }

	// RVA: 0x2F3140 Offset: 0x2F3241 VA: 0x2F3140
	public void set_Item(BitVector32Int.Section section, int value) { }

	// RVA: 0x2F3190 Offset: 0x2F3291 VA: 0x2F3190
	public int get_Data() { }

	// RVA: 0x22E5990 Offset: 0x22E5A91 VA: 0x22E5990
	private static short CountBitsSet(uint mask) { }

	// RVA: 0x22E59C0 Offset: 0x22E5AC1 VA: 0x22E59C0
	public static int CreateMask() { }

	// RVA: 0x22E5A00 Offset: 0x22E5B01 VA: 0x22E5A00
	public static int CreateMask(int previous) { }

	// RVA: 0x22E5AA0 Offset: 0x22E5BA1 VA: 0x22E5AA0
	private static uint CreateMaskFromHighValue(uint highValue) { }

	// RVA: 0x22E5AF0 Offset: 0x22E5BF1 VA: 0x22E5AF0
	public static BitVector32Int.Section CreateSection(uint maxValue, bool signed = False) { }

	// RVA: 0x22E5CD0 Offset: 0x22E5DD1 VA: 0x22E5CD0
	public static BitVector32Int.Section CreateSection(uint maxValue, BitVector32Int.Section previous, bool signed = False) { }

	// RVA: 0x22E5B00 Offset: 0x22E5C01 VA: 0x22E5B00
	private static BitVector32Int.Section CreateSectionHelper(uint maxValue, uint priorMask, short priorOffset, bool signed) { }

	// RVA: 0x2F31A0 Offset: 0x2F32A1 VA: 0x2F31A0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2F3250 Offset: 0x2F3351 VA: 0x2F3250 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22E5E40 Offset: 0x22E5F41 VA: 0x22E5E40
	public static string ToString(BitVector32Int value) { }

	// RVA: 0x2F32D0 Offset: 0x2F33D1 VA: 0x2F32D0 Slot: 3
	public override string ToString() { }
}

