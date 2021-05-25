[DocumentationSortingAttribute] // RVA: 0x12DD70 Offset: 0x12DE71 VA: 0x12DD70
[DisallowMultipleComponent] // RVA: 0x12DD70 Offset: 0x12DE71 VA: 0x12DD70
[ExecuteAlways] // RVA: 0x12DD70 Offset: 0x12DE71 VA: 0x12DD70
[ExcludeFromPresetAttribute] // RVA: 0x12DD70 Offset: 0x12DE71 VA: 0x12DD70
[AddComponentMenu] // RVA: 0x12DD70 Offset: 0x12DE71 VA: 0x12DD70
[HelpURLAttribute] // RVA: 0x12DD70 Offset: 0x12DE71 VA: 0x12DD70
public class CinemachineBlendListCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4731
{
	// Fields
	[TooltipAttribute] // RVA: 0x12FA20 Offset: 0x12FB21 VA: 0x12FA20
	[NoSaveDuringPlayAttribute] // RVA: 0x12FA20 Offset: 0x12FB21 VA: 0x12FA20
	[VcamTargetPropertyAttribute] // RVA: 0x12FA20 Offset: 0x12FB21 VA: 0x12FA20
	public Transform m_LookAt; // 0x68
	[TooltipAttribute] // RVA: 0x12FA80 Offset: 0x12FB81 VA: 0x12FA80
	[NoSaveDuringPlayAttribute] // RVA: 0x12FA80 Offset: 0x12FB81 VA: 0x12FA80
	[VcamTargetPropertyAttribute] // RVA: 0x12FA80 Offset: 0x12FB81 VA: 0x12FA80
	public Transform m_Follow; // 0x70
	[TooltipAttribute] // RVA: 0x12FAE0 Offset: 0x12FBE1 VA: 0x12FAE0
	public bool m_ShowDebugText; // 0x78
	[TooltipAttribute] // RVA: 0x12FB20 Offset: 0x12FC21 VA: 0x12FB20
	public bool m_Loop; // 0x79
	[SerializeField] // RVA: 0x12FB60 Offset: 0x12FC61 VA: 0x12FB60
	[HideInInspector] // RVA: 0x12FB60 Offset: 0x12FC61 VA: 0x12FB60
	[NoSaveDuringPlayAttribute] // RVA: 0x12FB60 Offset: 0x12FC61 VA: 0x12FB60
	internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x80
	[TooltipAttribute] // RVA: 0x12FBB0 Offset: 0x12FCB1 VA: 0x12FBB0
	public CinemachineBlendListCamera.Instruction[] m_Instructions; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x12FBF0 Offset: 0x12FCF1 VA: 0x12FBF0
	private ICinemachineCamera <LiveChild>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x12FC00 Offset: 0x12FD01 VA: 0x12FC00
	private ICinemachineCamera <TransitioningFrom>k__BackingField; // 0x98
	private CameraState m_State; // 0xA0
	private float mActivationTime; // 0x180
	private int mCurrentInstruction; // 0x184
	private CinemachineBlend mActiveBlend; // 0x188

	// Properties
	public override string Description { get; }
	public ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	private ICinemachineCamera TransitioningFrom { get; set; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }
	public bool IsBlending { get; }

	// Methods

	// RVA: 0x1889AB0 Offset: 0x1889BB1 VA: 0x1889AB0 Slot: 24
	public override string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x136A40 Offset: 0x136B41 VA: 0x136A40
	// RVA: 0x1889C00 Offset: 0x1889D01 VA: 0x1889C00
	public void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136A50 Offset: 0x136B51 VA: 0x136A50
	// RVA: 0x1889C10 Offset: 0x1889D11 VA: 0x1889C10
	public ICinemachineCamera get_LiveChild() { }

	// RVA: 0x1889C20 Offset: 0x1889D21 VA: 0x1889C20 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x1889C50 Offset: 0x1889D51 VA: 0x1889C50 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1889C60 Offset: 0x1889D61 VA: 0x1889C60 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1889C70 Offset: 0x1889D71 VA: 0x1889C70 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1889C80 Offset: 0x1889D81 VA: 0x1889C80 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1889C90 Offset: 0x1889D91 VA: 0x1889C90 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1889CA0 Offset: 0x1889DA1 VA: 0x1889CA0 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1889FC0 Offset: 0x188A0C1 VA: 0x1889FC0 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x188A0C0 Offset: 0x188A1C1 VA: 0x188A0C0 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[CompilerGeneratedAttribute] // RVA: 0x136A60 Offset: 0x136B61 VA: 0x136A60
	// RVA: 0x188A280 Offset: 0x188A381 VA: 0x188A280
	private ICinemachineCamera get_TransitioningFrom() { }

	[CompilerGeneratedAttribute] // RVA: 0x136A70 Offset: 0x136B71 VA: 0x136A70
	// RVA: 0x188A290 Offset: 0x188A391 VA: 0x188A290
	private void set_TransitioningFrom(ICinemachineCamera value) { }

	// RVA: 0x188A2A0 Offset: 0x188A3A1 VA: 0x188A2A0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x188AE70 Offset: 0x188AF71 VA: 0x188AE70 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x188B040 Offset: 0x188B141 VA: 0x188B040 Slot: 40
	protected override void OnDisable() { }

	// RVA: 0x188B120 Offset: 0x188B221 VA: 0x188B120
	private void OnTransformChildrenChanged() { }

	// RVA: 0x188B160 Offset: 0x188B261 VA: 0x188B160
	private void OnGuiHandler() { }

	// RVA: 0x188B300 Offset: 0x188B401 VA: 0x188B300
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x188B330 Offset: 0x188B431 VA: 0x188B330
	public bool get_IsBlending() { }

	// RVA: 0x188B000 Offset: 0x188B101 VA: 0x188B000
	private void InvalidateListOfChildren() { }

	// RVA: 0x1889D70 Offset: 0x1889E71 VA: 0x1889D70
	private void UpdateListOfChildren() { }

	// RVA: 0x188B340 Offset: 0x188B441 VA: 0x188B340
	internal void ValidateInstructions() { }

	// RVA: 0x188A780 Offset: 0x188A881 VA: 0x188A780
	private void AdvanceCurrentInstruction(float deltaTime) { }

	// RVA: 0x188B4F0 Offset: 0x188B5F1 VA: 0x188B4F0
	public void .ctor() { }
}

