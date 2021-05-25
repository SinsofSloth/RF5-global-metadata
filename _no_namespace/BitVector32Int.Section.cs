public struct BitVector32Int.Section // TypeDefIndex: 6804
{
	// Fields
	private readonly uint mask; // 0x0
	private readonly short offset; // 0x4
	private readonly byte bitCount; // 0x6
	private readonly bool isSigned; // 0x7

	// Properties
	public uint Mask { get; }
	public short Offset { get; }
	public byte BitCount { get; }
	public bool IsSigned { get; }

	// Methods

	// RVA: 0x2F3350 Offset: 0x2F3451 VA: 0x2F3350
	internal void .ctor(uint mask, short offset, bool signed) { }

	// RVA: 0x2F3380 Offset: 0x2F3481 VA: 0x2F3380
	public uint get_Mask() { }

	// RVA: 0x2F3390 Offset: 0x2F3491 VA: 0x2F3390
	public short get_Offset() { }

	// RVA: 0x2F33A0 Offset: 0x2F34A1 VA: 0x2F33A0
	public byte get_BitCount() { }

	// RVA: 0x2F33B0 Offset: 0x2F34B1 VA: 0x2F33B0
	public bool get_IsSigned() { }

	// RVA: 0x2F33C0 Offset: 0x2F34C1 VA: 0x2F33C0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2F3490 Offset: 0x2F3591 VA: 0x2F3490
	public bool Equals(BitVector32Int.Section obj) { }

	// RVA: 0x22E6080 Offset: 0x22E6181 VA: 0x22E6080
	public static bool op_Equality(BitVector32Int.Section a, BitVector32Int.Section b) { }

	// RVA: 0x22E60A0 Offset: 0x22E61A1 VA: 0x22E60A0
	public static bool op_Inequality(BitVector32Int.Section a, BitVector32Int.Section b) { }

	// RVA: 0x2F34C0 Offset: 0x2F35C1 VA: 0x2F34C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22E6140 Offset: 0x22E6241 VA: 0x22E6140
	public static string ToString(BitVector32Int.Section value) { }

	// RVA: 0x2F3540 Offset: 0x2F3641 VA: 0x2F3540 Slot: 3
	public override string ToString() { }
}

