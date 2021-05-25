[DocumentationSortingAttribute] // RVA: 0x12E230 Offset: 0x12E331 VA: 0x12E230
[AddComponentMenu] // RVA: 0x12E230 Offset: 0x12E331 VA: 0x12E230
[SaveDuringPlayAttribute] // RVA: 0x12E230 Offset: 0x12E331 VA: 0x12E230
[ExecuteAlways] // RVA: 0x12E230 Offset: 0x12E331 VA: 0x12E230
[DisallowMultipleComponent] // RVA: 0x12E230 Offset: 0x12E331 VA: 0x12E230
[HelpURLAttribute] // RVA: 0x12E230 Offset: 0x12E331 VA: 0x12E230
public class CinemachineFollowZoom : CinemachineExtension // TypeDefIndex: 4752
{
	// Fields
	[TooltipAttribute] // RVA: 0x1309C0 Offset: 0x130AC1 VA: 0x1309C0
	public float m_Width; // 0x28
	[RangeAttribute] // RVA: 0x130A00 Offset: 0x130B01 VA: 0x130A00
	[TooltipAttribute] // RVA: 0x130A00 Offset: 0x130B01 VA: 0x130A00
	public float m_Damping; // 0x2C
	[RangeAttribute] // RVA: 0x130A60 Offset: 0x130B61 VA: 0x130A60
	[TooltipAttribute] // RVA: 0x130A60 Offset: 0x130B61 VA: 0x130A60
	public float m_MinFOV; // 0x30
	[RangeAttribute] // RVA: 0x130AC0 Offset: 0x130BC1 VA: 0x130AC0
	[TooltipAttribute] // RVA: 0x130AC0 Offset: 0x130BC1 VA: 0x130AC0
	public float m_MaxFOV; // 0x34

	// Methods

	// RVA: 0x1721970 Offset: 0x1721A71 VA: 0x1721970
	private void OnValidate() { }

	// RVA: 0x1721A30 Offset: 0x1721B31 VA: 0x1721A30 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1721A40 Offset: 0x1721B41 VA: 0x1721A40 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1721EF0 Offset: 0x1721FF1 VA: 0x1721EF0
	public void .ctor() { }
}

