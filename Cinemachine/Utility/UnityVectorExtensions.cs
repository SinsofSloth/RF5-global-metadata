[ExtensionAttribute] // RVA: 0x12F310 Offset: 0x12F411 VA: 0x12F310
public static class UnityVectorExtensions // TypeDefIndex: 4906
{
	// Fields
	public const float Epsilon = 0.0001;

	// Methods

	[ExtensionAttribute] // RVA: 0x137360 Offset: 0x137461 VA: 0x137360
	// RVA: 0x1A25DF0 Offset: 0x1A25EF1 VA: 0x1A25DF0
	public static float ClosestPointOnSegment(Vector3 p, Vector3 s0, Vector3 s1) { }

	[ExtensionAttribute] // RVA: 0x137370 Offset: 0x137471 VA: 0x137370
	// RVA: 0x1A25F70 Offset: 0x1A26071 VA: 0x1A25F70
	public static float ClosestPointOnSegment(Vector2 p, Vector2 s0, Vector2 s1) { }

	[ExtensionAttribute] // RVA: 0x137380 Offset: 0x137481 VA: 0x137380
	// RVA: 0x1A166B0 Offset: 0x1A167B1 VA: 0x1A166B0
	public static Vector3 ProjectOntoPlane(Vector3 vector, Vector3 planeNormal) { }

	[ExtensionAttribute] // RVA: 0x137390 Offset: 0x137491 VA: 0x137390
	// RVA: 0x1A260D0 Offset: 0x1A261D1 VA: 0x1A260D0
	public static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x1373A0 Offset: 0x1374A1 VA: 0x1373A0
	// RVA: 0x1A16910 Offset: 0x1A16A11 VA: 0x1A16910
	public static bool AlmostZero(Vector3 v) { }

	// RVA: 0x1A26180 Offset: 0x1A26281 VA: 0x1A26180
	public static float Angle(Vector3 v1, Vector3 v2) { }

	// RVA: 0x1A25AC0 Offset: 0x1A25BC1 VA: 0x1A25AC0
	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 up) { }

	// RVA: 0x1A16790 Offset: 0x1A16891 VA: 0x1A16790
	public static Quaternion SafeFromToRotation(Vector3 v1, Vector3 v2, Vector3 up) { }

	// RVA: 0x1A262E0 Offset: 0x1A263E1 VA: 0x1A262E0
	public static Vector3 SlerpWithReferenceUp(Vector3 vA, Vector3 vB, float t, Vector3 up) { }
}

