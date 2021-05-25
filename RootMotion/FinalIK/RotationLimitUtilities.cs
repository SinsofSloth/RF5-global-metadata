public static class RotationLimitUtilities // TypeDefIndex: 9455
{
	// Methods

	// RVA: 0x2923FF0 Offset: 0x29240F1 VA: 0x2923FF0
	public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle) { }

	// RVA: 0x2924320 Offset: 0x2924421 VA: 0x2924320
	public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) { }

	// RVA: 0x2924410 Offset: 0x2924511 VA: 0x2924410
	public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit) { }

	// RVA: 0x2924480 Offset: 0x2924581 VA: 0x2924480
	public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit) { }

	// RVA: 0x29246C0 Offset: 0x29247C1 VA: 0x29246C0
	public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) { }
}

