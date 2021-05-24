public struct Result : IEquatable<Result> // TypeDefIndex: 11451
{
	// Fields
	public const int ModuleBitsOffset = 0;
	public const int ModuleBitsCount = 9;
	public const int ModuleBitsMask = 511;
	public const int DescriptionBitsOffset = 9;
	public const int DescriptionBitsCount = 13;
	public const int DescriptionBitsMask = 8191;
	public uint innerValue; // 0x0

	// Methods

	// RVA: 0x361410 Offset: 0x361511 VA: 0x361410
	public void .ctor(int module, int description) { }

	// RVA: 0x361420 Offset: 0x361521 VA: 0x361420
	public bool IsSuccess() { }

	// RVA: 0x361430 Offset: 0x361531 VA: 0x361430
	public void abortUnlessSuccess() { }

	// RVA: 0x361470 Offset: 0x361571 VA: 0x361470
	public int GetModule() { }

	// RVA: 0x361480 Offset: 0x361581 VA: 0x361480
	public int GetDescription() { }

	// RVA: 0x361490 Offset: 0x361591 VA: 0x361490 Slot: 3
	public override string ToString() { }

	// RVA: 0x3614A0 Offset: 0x3615A1 VA: 0x3614A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x361550 Offset: 0x361651 VA: 0x361550 Slot: 4
	public bool Equals(Result other) { }

	// RVA: 0x361560 Offset: 0x361661 VA: 0x361560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26A3F50 Offset: 0x26A4051 VA: 0x26A3F50
	public static bool op_Equality(Result lhs, Result rhs) { }

	// RVA: 0x26A3FE0 Offset: 0x26A40E1 VA: 0x26A3FE0
	public static bool op_Inequality(Result lhs, Result rhs) { }
}

