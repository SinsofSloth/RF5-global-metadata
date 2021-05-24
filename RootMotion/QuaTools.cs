public static class QuaTools // TypeDefIndex: 9323
{
	// Methods

	// RVA: 0x1D652C0 Offset: 0x1D653C1 VA: 0x1D652C0
	public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight) { }

	// RVA: 0x1D65410 Offset: 0x1D65511 VA: 0x1D65410
	public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight) { }

	// RVA: 0x1D65560 Offset: 0x1D65661 VA: 0x1D65560
	public static Quaternion LinearBlend(Quaternion q, float weight) { }

	// RVA: 0x1D65680 Offset: 0x1D65781 VA: 0x1D65680
	public static Quaternion SphericalBlend(Quaternion q, float weight) { }

	// RVA: 0x1D657A0 Offset: 0x1D658A1 VA: 0x1D657A0
	public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis) { }

	// RVA: 0x1D65930 Offset: 0x1D65A31 VA: 0x1D65930
	public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation) { }

	// RVA: 0x1D65A00 Offset: 0x1D65B01 VA: 0x1D65A00
	public static Quaternion FromToRotation(Quaternion from, Quaternion to) { }

	// RVA: 0x1D65B50 Offset: 0x1D65C51 VA: 0x1D65B50
	public static Vector3 GetAxis(Vector3 v) { }

	// RVA: 0x1D65E10 Offset: 0x1D65F11 VA: 0x1D65E10
	public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing) { }

	// RVA: 0x1D66040 Offset: 0x1D66141 VA: 0x1D66040
	public static float ClampAngle(float angle, float clampWeight, int clampSmoothing) { }

	// RVA: 0x1D661D0 Offset: 0x1D662D1 VA: 0x1D661D0
	public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis) { }

	// RVA: 0x1D66340 Offset: 0x1D66441 VA: 0x1D66340
	public static Vector3 ToBiPolar(Vector3 euler) { }

	// RVA: 0x1D66450 Offset: 0x1D66551 VA: 0x1D66450
	public static float ToBiPolar(float angle) { }
}

