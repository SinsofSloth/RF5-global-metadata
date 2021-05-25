public class VRIKCalibrationController : MonoBehaviour // TypeDefIndex: 9392
{
	// Fields
	[TooltipAttribute] // RVA: 0x1786B0 Offset: 0x1787B1 VA: 0x1786B0
	public VRIK ik; // 0x18
	[TooltipAttribute] // RVA: 0x1786F0 Offset: 0x1787F1 VA: 0x1786F0
	public VRIKCalibrator.Settings settings; // 0x20
	[TooltipAttribute] // RVA: 0x178730 Offset: 0x178831 VA: 0x178730
	public Transform headTracker; // 0x28
	[TooltipAttribute] // RVA: 0x178770 Offset: 0x178871 VA: 0x178770
	public Transform bodyTracker; // 0x30
	[TooltipAttribute] // RVA: 0x1787B0 Offset: 0x1788B1 VA: 0x1787B0
	public Transform leftHandTracker; // 0x38
	[TooltipAttribute] // RVA: 0x1787F0 Offset: 0x1788F1 VA: 0x1787F0
	public Transform rightHandTracker; // 0x40
	[TooltipAttribute] // RVA: 0x178830 Offset: 0x178931 VA: 0x178830
	public Transform leftFootTracker; // 0x48
	[TooltipAttribute] // RVA: 0x178870 Offset: 0x178971 VA: 0x178870
	public Transform rightFootTracker; // 0x50
	[HeaderAttribute] // RVA: 0x1788B0 Offset: 0x1789B1 VA: 0x1788B0
	public VRIKCalibrator.CalibrationData data; // 0x58

	// Methods

	// RVA: 0x272DEA0 Offset: 0x272DFA1 VA: 0x272DEA0
	private void LateUpdate() { }

	// RVA: 0x272E050 Offset: 0x272E151 VA: 0x272E050
	public void .ctor() { }
}

