public static class CameraUtility // TypeDefIndex: 6488
{
	// Fields
	private const float CAMERA_AXIS_THRESHOLD = 0.25;

	// Methods

	// RVA: 0x1D36B90 Offset: 0x1D36C91 VA: 0x1D36B90
	public static float GetAxisY() { }

	// RVA: 0x1D36C40 Offset: 0x1D36D41 VA: 0x1D36C40
	public static float GetAxisX() { }

	// RVA: 0x1D36C30 Offset: 0x1D36D31 VA: 0x1D36C30
	private static float GetAxis(float input, bool invert) { }

	// RVA: 0x1D36CE0 Offset: 0x1D36DE1 VA: 0x1D36CE0
	public static float UpdateAxisSpeed(float input, AxisSetting setting, float prevSpeed, CameraUtility.AxisType axisType) { }
}

