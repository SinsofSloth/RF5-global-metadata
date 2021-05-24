[DocumentationSortingAttribute] // RVA: 0x12EBC0 Offset: 0x12ECC1 VA: 0x12EBC0
[AddComponentMenu] // RVA: 0x12EBC0 Offset: 0x12ECC1 VA: 0x12EBC0
[SaveDuringPlayAttribute] // RVA: 0x12EBC0 Offset: 0x12ECC1 VA: 0x12EBC0
public class CinemachinePOV : CinemachineComponentBase // TypeDefIndex: 4799
{
	// Fields
	public CinemachinePOV.RecenterTargetMode m_RecenterTarget; // 0x50
	[TooltipAttribute] // RVA: 0x133740 Offset: 0x133841 VA: 0x133740
	[AxisStatePropertyAttribute] // RVA: 0x133740 Offset: 0x133841 VA: 0x133740
	public AxisState m_VerticalAxis; // 0x58
	[TooltipAttribute] // RVA: 0x133790 Offset: 0x133891 VA: 0x133790
	public AxisState.Recentering m_VerticalRecentering; // 0xC0
	[TooltipAttribute] // RVA: 0x1337D0 Offset: 0x1338D1 VA: 0x1337D0
	[AxisStatePropertyAttribute] // RVA: 0x1337D0 Offset: 0x1338D1 VA: 0x1337D0
	public AxisState m_HorizontalAxis; // 0xE0
	[TooltipAttribute] // RVA: 0x133820 Offset: 0x133921 VA: 0x133820
	public AxisState.Recentering m_HorizontalRecentering; // 0x148
	[HideInInspector] // RVA: 0x133860 Offset: 0x133961 VA: 0x133860
	[TooltipAttribute] // RVA: 0x133860 Offset: 0x133961 VA: 0x133860
	public bool m_ApplyBeforeBody; // 0x164

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0x1731930 Offset: 0x1731A31 VA: 0x1731930 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1731940 Offset: 0x1731A41 VA: 0x1731940 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1731950 Offset: 0x1731A51 VA: 0x1731950
	private void OnValidate() { }

	// RVA: 0x17319A0 Offset: 0x1731AA1 VA: 0x17319A0
	private void OnEnable() { }

	// RVA: 0x17319B0 Offset: 0x1731AB1 VA: 0x17319B0
	public void UpdateInputAxisProvider() { }

	// RVA: 0x1731AD0 Offset: 0x1731BD1 VA: 0x1731AD0 Slot: 5
	public override void PrePipelineMutateCameraState(ref CameraState state, float deltaTime) { }

	// RVA: 0x1731AE0 Offset: 0x1731BE1 VA: 0x1731AE0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1731E00 Offset: 0x1731F01 VA: 0x1731E00
	public Vector2 GetRecenterTarget() { }

	// RVA: 0x17320C0 Offset: 0x17321C1 VA: 0x17320C0 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1732510 Offset: 0x1732611 VA: 0x1732510 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	// RVA: 0x17320E0 Offset: 0x17321E1 VA: 0x17320E0
	private void SetAxesForRotation(Quaternion targetRot) { }

	// RVA: 0x1732670 Offset: 0x1732771 VA: 0x1732670
	public void .ctor() { }
}

