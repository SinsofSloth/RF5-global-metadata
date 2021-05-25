public static class VRIKCalibrator // TypeDefIndex: 9581
{
	// Methods

	// RVA: 0x29275B0 Offset: 0x29276B1 VA: 0x29275B0
	public static void RecalibrateScale(VRIK ik, VRIKCalibrator.Settings settings) { }

	// RVA: 0x2927720 Offset: 0x2927821 VA: 0x2927720
	public static VRIKCalibrator.CalibrationData Calibrate(VRIK ik, VRIKCalibrator.Settings settings, Transform headTracker, Transform bodyTracker, Transform leftHandTracker, Transform rightHandTracker, Transform leftFootTracker, Transform rightFootTracker) { }

	// RVA: 0x2928AE0 Offset: 0x2928BE1 VA: 0x2928AE0
	private static void CalibrateLeg(VRIKCalibrator.Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft) { }

	// RVA: 0x29295F0 Offset: 0x29296F1 VA: 0x29295F0
	public static void Calibrate(VRIK ik, VRIKCalibrator.CalibrationData data, Transform headTracker, Transform bodyTracker, Transform leftHandTracker, Transform rightHandTracker, Transform leftFootTracker, Transform rightFootTracker) { }

	// RVA: 0x292A1C0 Offset: 0x292A2C1 VA: 0x292A1C0
	private static void CalibrateLeg(VRIKCalibrator.CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft) { }
}

