public struct Arm : IEquatable<Arm> // TypeDefIndex: 11501
{
	// Fields
	public bool isValid; // 0x0
	public Float2 wristPosition; // 0x4
	public Float2 armDirection; // 0xC
	public int protrusionIndex; // 0x14

	// Methods

	// RVA: 0x38AB10 Offset: 0x38AC11 VA: 0x38AB10 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C7B900 Offset: 0x2C7BA01 VA: 0x2C7B900
	public static bool op_Equality(Arm lhs, Arm rhs) { }

	// RVA: 0x2C7B9B0 Offset: 0x2C7BAB1 VA: 0x2C7B9B0
	public static bool op_Inequality(Arm lhs, Arm rhs) { }

	// RVA: 0x38AB20 Offset: 0x38AC21 VA: 0x38AB20 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x38AB30 Offset: 0x38AC31 VA: 0x38AB30 Slot: 4
	public bool Equals(Arm other) { }

	// RVA: 0x38ABD0 Offset: 0x38ACD1 VA: 0x38ABD0 Slot: 2
	public override int GetHashCode() { }
}

