public struct Finger : IEquatable<Finger> // TypeDefIndex: 11499
{
	// Fields
	public bool isValid; // 0x0
	public Float2 tip; // 0x4
	public float tipDepthFactor; // 0xC
	public Float2 root; // 0x10
	public int protrusionIndex; // 0x18

	// Methods

	// RVA: 0x38B170 Offset: 0x38B271 VA: 0x38B170 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C7E280 Offset: 0x2C7E381 VA: 0x2C7E280
	public static bool op_Equality(Finger lhs, Finger rhs) { }

	// RVA: 0x2C7E350 Offset: 0x2C7E451 VA: 0x2C7E350
	public static bool op_Inequality(Finger lhs, Finger rhs) { }

	// RVA: 0x38B180 Offset: 0x38B281 VA: 0x38B180 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x38B190 Offset: 0x38B291 VA: 0x38B190 Slot: 4
	public bool Equals(Finger other) { }

	// RVA: 0x38B250 Offset: 0x38B351 VA: 0x38B250 Slot: 2
	public override int GetHashCode() { }
}

