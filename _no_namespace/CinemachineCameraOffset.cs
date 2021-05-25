[AddComponentMenu] // RVA: 0x12DB70 Offset: 0x12DC71 VA: 0x12DB70
[ExecuteAlways] // RVA: 0x12DB70 Offset: 0x12DC71 VA: 0x12DB70
[HelpURLAttribute] // RVA: 0x12DB70 Offset: 0x12DC71 VA: 0x12DB70
public class CinemachineCameraOffset : CinemachineExtension // TypeDefIndex: 4722
{
	// Fields
	[TooltipAttribute] // RVA: 0x12F630 Offset: 0x12F731 VA: 0x12F630
	public Vector3 m_Offset; // 0x28
	[TooltipAttribute] // RVA: 0x12F670 Offset: 0x12F771 VA: 0x12F670
	public CinemachineCore.Stage m_ApplyAfter; // 0x34
	[TooltipAttribute] // RVA: 0x12F6B0 Offset: 0x12F7B1 VA: 0x12F6B0
	public bool m_PreserveComposition; // 0x38

	// Methods

	// RVA: 0x1A265A0 Offset: 0x1A266A1 VA: 0x1A265A0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1A269A0 Offset: 0x1A26AA1 VA: 0x1A269A0
	public void .ctor() { }
}

