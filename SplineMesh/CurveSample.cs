public struct CurveSample // TypeDefIndex: 9733
{
	// Fields
	public readonly Vector3 location; // 0x0
	public readonly Vector3 tangent; // 0xC
	public readonly Vector3 up; // 0x18
	public readonly Vector2 scale; // 0x24
	public readonly float roll; // 0x2C
	public readonly float distanceInCurve; // 0x30
	public readonly float timeInCurve; // 0x34
	private Quaternion rotation; // 0x38

	// Properties
	public Quaternion Rotation { get; }

	// Methods

	// RVA: 0x2E29C0 Offset: 0x2E2AC1 VA: 0x2E29C0
	public Quaternion get_Rotation() { }

	// RVA: 0x2E29D0 Offset: 0x2E2AD1 VA: 0x2E29D0
	public void .ctor(Vector3 location, Vector3 tangent, Vector3 up, Vector2 scale, float roll, float distanceInCurve, float timeInCurve) { }

	// RVA: 0x2E2A10 Offset: 0x2E2B11 VA: 0x2E2A10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2E2A20 Offset: 0x2E2B21 VA: 0x2E2A20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211EE70 Offset: 0x211EF71 VA: 0x211EE70
	public static bool op_Equality(CurveSample cs1, CurveSample cs2) { }

	// RVA: 0x21203A0 Offset: 0x21204A1 VA: 0x21203A0
	public static bool op_Inequality(CurveSample cs1, CurveSample cs2) { }

	// RVA: 0x211EF10 Offset: 0x211F011 VA: 0x211EF10
	public static CurveSample Lerp(CurveSample a, CurveSample b, float t) { }

	// RVA: 0x2E2AC0 Offset: 0x2E2BC1 VA: 0x2E2AC0
	public MeshVertex GetBent(MeshVertex vert) { }
}

