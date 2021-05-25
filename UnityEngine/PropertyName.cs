[UsedByNativeCodeAttribute] // RVA: 0xC6520 Offset: 0xC6621 VA: 0xC6520
public struct PropertyName : IEquatable<PropertyName> // TypeDefIndex: 2985
{
	// Fields
	internal int id; // 0x0

	// Methods

	// RVA: 0x381B30 Offset: 0x381C31 VA: 0x381B30
	public void .ctor(string name) { }

	// RVA: 0x381B90 Offset: 0x381C91 VA: 0x381B90
	public void .ctor(PropertyName other) { }

	// RVA: 0x2B73910 Offset: 0x2B73A11 VA: 0x2B73910
	public static bool op_Equality(PropertyName lhs, PropertyName rhs) { }

	// RVA: 0x381BA0 Offset: 0x381CA1 VA: 0x381BA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x381BB0 Offset: 0x381CB1 VA: 0x381BB0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x381C60 Offset: 0x381D61 VA: 0x381C60 Slot: 4
	public bool Equals(PropertyName other) { }

	// RVA: 0x381C70 Offset: 0x381D71 VA: 0x381C70 Slot: 3
	public override string ToString() { }
}

