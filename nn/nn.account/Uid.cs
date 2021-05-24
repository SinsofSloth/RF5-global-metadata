public struct Uid : IEquatable<Uid> // TypeDefIndex: 11717
{
	// Fields
	public ulong _data0; // 0x0
	public ulong _data1; // 0x8

	// Properties
	public static Uid Invalid { get; }

	// Methods

	// RVA: 0x26A4EC0 Offset: 0x26A4FC1 VA: 0x26A4EC0
	public static Uid get_Invalid() { }

	// RVA: 0x361800 Offset: 0x361901 VA: 0x361800
	public bool IsValid() { }

	// RVA: 0x361820 Offset: 0x361921 VA: 0x361820 Slot: 3
	public override string ToString() { }

	// RVA: 0x3618C0 Offset: 0x3619C1 VA: 0x3618C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x361980 Offset: 0x361A81 VA: 0x361980 Slot: 4
	public bool Equals(Uid other) { }

	// RVA: 0x3619A0 Offset: 0x361AA1 VA: 0x3619A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26A5070 Offset: 0x26A5171 VA: 0x26A5070
	public static bool op_Equality(Uid lhs, Uid rhs) { }

	// RVA: 0x26A5110 Offset: 0x26A5211 VA: 0x26A5110
	public static bool op_Inequality(Uid lhs, Uid rhs) { }
}

