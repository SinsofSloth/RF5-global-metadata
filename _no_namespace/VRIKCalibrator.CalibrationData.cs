[Serializable]
public class VRIKCalibrator.CalibrationData // TypeDefIndex: 9583
{
	// Fields
	public float scale; // 0x10
	public VRIKCalibrator.CalibrationData.Target head; // 0x18
	public VRIKCalibrator.CalibrationData.Target leftHand; // 0x20
	public VRIKCalibrator.CalibrationData.Target rightHand; // 0x28
	public VRIKCalibrator.CalibrationData.Target pelvis; // 0x30
	public VRIKCalibrator.CalibrationData.Target leftFoot; // 0x38
	public VRIKCalibrator.CalibrationData.Target rightFoot; // 0x40
	public VRIKCalibrator.CalibrationData.Target leftLegGoal; // 0x48
	public VRIKCalibrator.CalibrationData.Target rightLegGoal; // 0x50
	public Vector3 pelvisTargetRight; // 0x58
	public float pelvisPositionWeight; // 0x64
	public float pelvisRotationWeight; // 0x68

	// Methods

	// RVA: 0x2928AD0 Offset: 0x2928BD1 VA: 0x2928AD0
	public void .ctor() { }
}

