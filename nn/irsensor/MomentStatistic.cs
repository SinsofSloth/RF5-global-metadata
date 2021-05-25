public struct MomentStatistic : IEquatable<MomentStatistic> // TypeDefIndex: 11532
{
	// Fields
	public float averageIntensity; // 0x0
	public Float2 centroid; // 0x4

	// Methods

	// RVA: 0x3A01F0 Offset: 0x3A02F1 VA: 0x3A01F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x34EE100 Offset: 0x34EE201 VA: 0x34EE100
	public static bool op_Equality(MomentStatistic lhs, MomentStatistic rhs) { }

	// RVA: 0x34EFCB0 Offset: 0x34EFDB1 VA: 0x34EFCB0
	public static bool op_Inequality(MomentStatistic lhs, MomentStatistic rhs) { }

	// RVA: 0x3A0290 Offset: 0x3A0391 VA: 0x3A0290 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x3A0370 Offset: 0x3A0471 VA: 0x3A0370 Slot: 4
	public bool Equals(MomentStatistic other) { }

	// RVA: 0x3A03A0 Offset: 0x3A04A1 VA: 0x3A03A0 Slot: 2
	public override int GetHashCode() { }
}

