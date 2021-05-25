internal struct IntVec3 : IEquatable<IntVec3> // TypeDefIndex: 5952
{
	// Fields
	public Vector3 value; // 0x0

	// Properties
	public float x { get; }
	public float y { get; }
	public float z { get; }

	// Methods

	// RVA: 0x19240 Offset: 0x19341 VA: 0x19240
	public float get_x() { }

	// RVA: 0x19250 Offset: 0x19351 VA: 0x19250
	public float get_y() { }

	// RVA: 0x19260 Offset: 0x19361 VA: 0x19260
	public float get_z() { }

	// RVA: 0x19270 Offset: 0x19371 VA: 0x19270
	public void .ctor(Vector3 vector) { }

	// RVA: 0x19280 Offset: 0x19381 VA: 0x19280 Slot: 3
	public override string ToString() { }

	// RVA: 0x19290 Offset: 0x19391 VA: 0x19290 Slot: 4
	public bool Equals(IntVec3 p) { }

	// RVA: 0x192A0 Offset: 0x193A1 VA: 0x192A0
	public bool Equals(Vector3 p) { }

	// RVA: 0x192B0 Offset: 0x193B1 VA: 0x192B0 Slot: 0
	public override bool Equals(object b) { }

	// RVA: 0x192C0 Offset: 0x193C1 VA: 0x192C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A93040 Offset: 0x1A93141 VA: 0x1A93040
	private static int round(float v) { }

	// RVA: 0x1A93540 Offset: 0x1A93641 VA: 0x1A93540
	public static IntVec3 op_Implicit(Vector3 p) { }
}

