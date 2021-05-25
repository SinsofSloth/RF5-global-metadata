public struct Length : IEquatable<Length> // TypeDefIndex: 4232
{
	// Fields
	private float m_Value; // 0x0
	private LengthUnit m_Unit; // 0x4

	// Properties
	public float value { get; }
	public LengthUnit unit { get; }

	// Methods

	// RVA: 0x4530 Offset: 0x4631 VA: 0x4530
	public float get_value() { }

	// RVA: 0x4540 Offset: 0x4641 VA: 0x4540
	public LengthUnit get_unit() { }

	// RVA: 0x4550 Offset: 0x4651 VA: 0x4550
	public void .ctor(float value) { }

	// RVA: 0x4560 Offset: 0x4661 VA: 0x4560
	public void .ctor(float value, LengthUnit unit) { }

	// RVA: 0x15C19D0 Offset: 0x15C1AD1 VA: 0x15C19D0
	public static bool op_Equality(Length lhs, Length rhs) { }

	// RVA: 0x4570 Offset: 0x4671 VA: 0x4570 Slot: 4
	public bool Equals(Length other) { }

	// RVA: 0x45A0 Offset: 0x46A1 VA: 0x45A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4660 Offset: 0x4761 VA: 0x4660 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x46B0 Offset: 0x47B1 VA: 0x46B0 Slot: 3
	public override string ToString() { }
}

