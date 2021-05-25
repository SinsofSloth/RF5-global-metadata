public abstract class SphereUtility // TypeDefIndex: 9689
{
	// Fields
	private const float k_HalfPI = 1.5707964;

	// Methods

	// RVA: 0x228D600 Offset: 0x228D701 VA: 0x228D600
	public static Vector2 DirectionToSphericalCoordinate(Vector3 direction) { }

	// RVA: 0x228D800 Offset: 0x228D901 VA: 0x228D800
	public static Vector3 SphericalCoordinateToDirection(Vector2 coord) { }

	// RVA: 0x228D8D0 Offset: 0x228D9D1 VA: 0x228D8D0
	public static float RadiusAtHeight(float yPos) { }

	// RVA: 0x228D950 Offset: 0x228DA51 VA: 0x228D950
	public static Vector3 SphericalToPoint(float yPosition, float radAngle) { }

	// RVA: 0x228DA60 Offset: 0x228DB61 VA: 0x228DA60
	public static float RadAngleToPercent(float radAngle) { }

	// RVA: 0x228DA70 Offset: 0x228DB71 VA: 0x228DA70
	public static float PercentToRadAngle(float percent) { }

	// RVA: 0x228DA80 Offset: 0x228DB81 VA: 0x228DA80
	public static float HeightToPercent(float yValue) { }

	// RVA: 0x228DA90 Offset: 0x228DB91 VA: 0x228DA90
	public static float PercentToHeight(float hPercent) { }

	// RVA: 0x228DB10 Offset: 0x228DC11 VA: 0x228DB10
	public static float AngleToReachTarget(Vector2 point, float targetAngle) { }

	// RVA: 0x228D770 Offset: 0x228D871 VA: 0x228D770
	public static float Atan2Positive(float y, float x) { }

	// RVA: 0x228DBC0 Offset: 0x228DCC1 VA: 0x228DBC0
	public static Vector3 RotateAroundXAxis(Vector3 point, float angle) { }

	// RVA: 0x228DD20 Offset: 0x228DE21 VA: 0x228DD20
	public static Vector3 RotateAroundYAxis(Vector3 point, float angle) { }

	// RVA: 0x228DD90 Offset: 0x228DE91 VA: 0x228DD90
	public static Vector3 RotatePoint(Vector3 point, float xAxisRotation, float yAxisRotation) { }

	// RVA: 0x228DC30 Offset: 0x228DD31 VA: 0x228DC30
	public static Vector2 Rotate2d(Vector2 pos, float angle) { }

	// RVA: 0x228DE50 Offset: 0x228DF51 VA: 0x228DE50
	public static Vector2 Matrix2x2Mult(Vector4 matrix, Vector2 pos) { }

	// RVA: 0x228DF60 Offset: 0x228E061 VA: 0x228DF60
	public static void CalculateStarRotation(Vector3 star, out float xRotationAngle, out float yRotationAngle) { }

	// RVA: 0x228E190 Offset: 0x228E291 VA: 0x228E190
	public static Vector2 ConvertUVToSphericalCoordinate(Vector2 uv) { }

	// RVA: 0x228E250 Offset: 0x228E351 VA: 0x228E250
	public static Vector2 ConvertSphericalCoordateToUV(Vector2 sphereCoord) { }

	// RVA: 0x228E2A0 Offset: 0x228E3A1 VA: 0x228E2A0
	protected void .ctor() { }
}

