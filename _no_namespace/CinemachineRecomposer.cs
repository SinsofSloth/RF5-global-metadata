[AddComponentMenu] // RVA: 0x12DBE0 Offset: 0x12DCE1 VA: 0x12DBE0
[ExecuteAlways] // RVA: 0x12DBE0 Offset: 0x12DCE1 VA: 0x12DBE0
[HelpURLAttribute] // RVA: 0x12DBE0 Offset: 0x12DCE1 VA: 0x12DBE0
public class CinemachineRecomposer : CinemachineExtension // TypeDefIndex: 4723
{
	// Fields
	[TooltipAttribute] // RVA: 0x12F6F0 Offset: 0x12F7F1 VA: 0x12F6F0
	public CinemachineCore.Stage m_ApplyAfter; // 0x28
	[TooltipAttribute] // RVA: 0x12F730 Offset: 0x12F831 VA: 0x12F730
	public float m_Tilt; // 0x2C
	[TooltipAttribute] // RVA: 0x12F770 Offset: 0x12F871 VA: 0x12F770
	public float m_Pan; // 0x30
	[TooltipAttribute] // RVA: 0x12F7B0 Offset: 0x12F8B1 VA: 0x12F7B0
	public float m_Dutch; // 0x34
	[TooltipAttribute] // RVA: 0x12F7F0 Offset: 0x12F8F1 VA: 0x12F7F0
	public float m_ZoomScale; // 0x38
	[RangeAttribute] // RVA: 0x12F830 Offset: 0x12F931 VA: 0x12F830
	[TooltipAttribute] // RVA: 0x12F830 Offset: 0x12F931 VA: 0x12F830
	public float m_FollowAttachment; // 0x3C
	[RangeAttribute] // RVA: 0x12F890 Offset: 0x12F991 VA: 0x12F890
	[TooltipAttribute] // RVA: 0x12F890 Offset: 0x12F991 VA: 0x12F890
	public float m_LookAtAttachment; // 0x40

	// Methods

	// RVA: 0x1A27560 Offset: 0x1A27661 VA: 0x1A27560
	private void Reset() { }

	// RVA: 0x1A27580 Offset: 0x1A27681 VA: 0x1A27580
	private void OnValidate() { }

	// RVA: 0x1A27630 Offset: 0x1A27731 VA: 0x1A27630 Slot: 8
	public override void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) { }

	// RVA: 0x1A27660 Offset: 0x1A27761 VA: 0x1A27660 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1A27890 Offset: 0x1A27991 VA: 0x1A27890
	public void .ctor() { }
}

