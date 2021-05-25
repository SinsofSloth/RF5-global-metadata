[SaveDuringPlayAttribute] // RVA: 0x12F120 Offset: 0x12F221 VA: 0x12F120
[AddComponentMenu] // RVA: 0x12F120 Offset: 0x12F221 VA: 0x12F120
[DocumentationSortingAttribute] // RVA: 0x12F120 Offset: 0x12F221 VA: 0x12F120
[ExecuteAlways] // RVA: 0x12F120 Offset: 0x12F221 VA: 0x12F120
[HelpURLAttribute] // RVA: 0x12F120 Offset: 0x12F221 VA: 0x12F120
public class CinemachineImpulseListener : CinemachineExtension // TypeDefIndex: 4883
{
	// Fields
	[TooltipAttribute] // RVA: 0x1356D0 Offset: 0x1357D1 VA: 0x1356D0
	[CinemachineImpulseChannelPropertyAttribute] // RVA: 0x1356D0 Offset: 0x1357D1 VA: 0x1356D0
	public int m_ChannelMask; // 0x28
	[TooltipAttribute] // RVA: 0x135720 Offset: 0x135821 VA: 0x135720
	public float m_Gain; // 0x2C
	[TooltipAttribute] // RVA: 0x135760 Offset: 0x135861 VA: 0x135760
	public bool m_Use2DDistance; // 0x30

	// Methods

	// RVA: 0x172C440 Offset: 0x172C541 VA: 0x172C440 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x172CA10 Offset: 0x172CB11 VA: 0x172CA10
	public void .ctor() { }
}

