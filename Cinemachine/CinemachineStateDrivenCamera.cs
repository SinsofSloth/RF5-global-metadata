[DocumentationSortingAttribute] // RVA: 0x12E610 Offset: 0x12E711 VA: 0x12E610
[DisallowMultipleComponent] // RVA: 0x12E610 Offset: 0x12E711 VA: 0x12E610
[ExecuteAlways] // RVA: 0x12E610 Offset: 0x12E711 VA: 0x12E610
[ExcludeFromPresetAttribute] // RVA: 0x12E610 Offset: 0x12E711 VA: 0x12E610
[AddComponentMenu] // RVA: 0x12E610 Offset: 0x12E711 VA: 0x12E610
[HelpURLAttribute] // RVA: 0x12E610 Offset: 0x12E711 VA: 0x12E610
public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4765
{
	// Fields
	[TooltipAttribute] // RVA: 0x1313D0 Offset: 0x1314D1 VA: 0x1313D0
	[NoSaveDuringPlayAttribute] // RVA: 0x1313D0 Offset: 0x1314D1 VA: 0x1313D0
	[VcamTargetPropertyAttribute] // RVA: 0x1313D0 Offset: 0x1314D1 VA: 0x1313D0
	public Transform m_LookAt; // 0x68
	[TooltipAttribute] // RVA: 0x131430 Offset: 0x131531 VA: 0x131430
	[NoSaveDuringPlayAttribute] // RVA: 0x131430 Offset: 0x131531 VA: 0x131430
	[VcamTargetPropertyAttribute] // RVA: 0x131430 Offset: 0x131531 VA: 0x131430
	public Transform m_Follow; // 0x70
	[SpaceAttribute] // RVA: 0x131490 Offset: 0x131591 VA: 0x131490
	[TooltipAttribute] // RVA: 0x131490 Offset: 0x131591 VA: 0x131490
	[NoSaveDuringPlayAttribute] // RVA: 0x131490 Offset: 0x131591 VA: 0x131490
	public Animator m_AnimatedTarget; // 0x78
	[TooltipAttribute] // RVA: 0x1314F0 Offset: 0x1315F1 VA: 0x1314F0
	[NoSaveDuringPlayAttribute] // RVA: 0x1314F0 Offset: 0x1315F1 VA: 0x1314F0
	public int m_LayerIndex; // 0x80
	[TooltipAttribute] // RVA: 0x131540 Offset: 0x131641 VA: 0x131540
	public bool m_ShowDebugText; // 0x84
	[SerializeField] // RVA: 0x131580 Offset: 0x131681 VA: 0x131580
	[HideInInspector] // RVA: 0x131580 Offset: 0x131681 VA: 0x131580
	[NoSaveDuringPlayAttribute] // RVA: 0x131580 Offset: 0x131681 VA: 0x131580
	internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x88
	[TooltipAttribute] // RVA: 0x1315D0 Offset: 0x1316D1 VA: 0x1315D0
	public CinemachineStateDrivenCamera.Instruction[] m_Instructions; // 0x90
	[CinemachineBlendDefinitionPropertyAttribute] // RVA: 0x131610 Offset: 0x131711 VA: 0x131610
	[TooltipAttribute] // RVA: 0x131610 Offset: 0x131711 VA: 0x131610
	public CinemachineBlendDefinition m_DefaultBlend; // 0x98
	[TooltipAttribute] // RVA: 0x131660 Offset: 0x131761 VA: 0x131660
	public CinemachineBlenderSettings m_CustomBlends; // 0xA8
	[HideInInspector] // RVA: 0x1316A0 Offset: 0x1317A1 VA: 0x1316A0
	[SerializeField] // RVA: 0x1316A0 Offset: 0x1317A1 VA: 0x1316A0
	internal CinemachineStateDrivenCamera.ParentHash[] m_ParentHash; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x1316E0 Offset: 0x1317E1 VA: 0x1316E0
	private ICinemachineCamera <LiveChild>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x1316F0 Offset: 0x1317F1 VA: 0x1316F0
	private ICinemachineCamera <TransitioningFrom>k__BackingField; // 0xC0
	private CameraState m_State; // 0xC8
	private Dictionary<AnimationClip, List<CinemachineStateDrivenCamera.HashPair>> mHashCache; // 0x1A8
	private float mActivationTime; // 0x1B0
	private CinemachineStateDrivenCamera.Instruction mActiveInstruction; // 0x1B8
	private float mPendingActivationTime; // 0x1D0
	private CinemachineStateDrivenCamera.Instruction mPendingInstruction; // 0x1D8
	private CinemachineBlend mActiveBlend; // 0x1F0
	private Dictionary<int, int> mInstructionDictionary; // 0x1F8
	private Dictionary<int, int> mStateParentLookup; // 0x200
	private List<AnimatorClipInfo> m_clipInfoList; // 0x208

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

	// RVA: 0x1735D20 Offset: 0x1735E21 VA: 0x1735D20 Slot: 24
	public override string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BF0 Offset: 0x136CF1 VA: 0x136BF0
	// RVA: 0x1735E80 Offset: 0x1735F81 VA: 0x1735E80
	public void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136C00 Offset: 0x136D01 VA: 0x136C00
	// RVA: 0x1735E90 Offset: 0x1735F91 VA: 0x1735E90
	public ICinemachineCamera get_LiveChild() { }

	// RVA: 0x1735EA0 Offset: 0x1735FA1 VA: 0x1735EA0 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x1735ED0 Offset: 0x1735FD1 VA: 0x1735ED0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1735EE0 Offset: 0x1735FE1 VA: 0x1735EE0 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1735EF0 Offset: 0x1735FF1 VA: 0x1735EF0 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1735F00 Offset: 0x1736001 VA: 0x1735F00 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1735F10 Offset: 0x1736011 VA: 0x1735F10 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1735F20 Offset: 0x1736021 VA: 0x1735F20 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1736250 Offset: 0x1736351 VA: 0x1736250 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1736350 Offset: 0x1736451 VA: 0x1736350 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[CompilerGeneratedAttribute] // RVA: 0x136C10 Offset: 0x136D11 VA: 0x136C10
	// RVA: 0x17363F0 Offset: 0x17364F1 VA: 0x17363F0
	private ICinemachineCamera get_TransitioningFrom() { }

	[CompilerGeneratedAttribute] // RVA: 0x136C20 Offset: 0x136D21 VA: 0x136C20
	// RVA: 0x1736400 Offset: 0x1736501 VA: 0x1736400
	private void set_TransitioningFrom(ICinemachineCamera value) { }

	// RVA: 0x1736410 Offset: 0x1736511 VA: 0x1736410 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1737020 Offset: 0x1737121 VA: 0x1737020 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x17371D0 Offset: 0x17372D1 VA: 0x17371D0 Slot: 40
	protected override void OnDisable() { }

	// RVA: 0x17372B0 Offset: 0x17373B1 VA: 0x17372B0
	public void OnTransformChildrenChanged() { }

	// RVA: 0x17372F0 Offset: 0x17373F1 VA: 0x17372F0
	private void OnGuiHandler() { }

	// RVA: 0x1737490 Offset: 0x1737591 VA: 0x1737490
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x17374C0 Offset: 0x17375C1 VA: 0x17374C0
	public bool get_IsBlending() { }

	// RVA: 0x17374D0 Offset: 0x17375D1 VA: 0x17374D0
	public static int CreateFakeHash(int parentHash, AnimationClip clip) { }

	// RVA: 0x1737570 Offset: 0x1737671 VA: 0x1737570
	private int LookupFakeHash(int parentHash, AnimationClip clip) { }

	// RVA: 0x1737190 Offset: 0x1737291 VA: 0x1737190
	private void InvalidateListOfChildren() { }

	// RVA: 0x1735FF0 Offset: 0x17360F1 VA: 0x1735FF0
	private void UpdateListOfChildren() { }

	// RVA: 0x17377C0 Offset: 0x17378C1 VA: 0x17377C0
	internal void ValidateInstructions() { }

	// RVA: 0x17368A0 Offset: 0x17369A1 VA: 0x17368A0
	private CinemachineVirtualCameraBase ChooseCurrentCamera() { }

	// RVA: 0x1737A80 Offset: 0x1737B81 VA: 0x1737A80
	private int GetClipHash(int hash, List<AnimatorClipInfo> clips) { }

	// RVA: 0x1736DB0 Offset: 0x1736EB1 VA: 0x1736DB0
	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	// RVA: 0x1737C30 Offset: 0x1737D31 VA: 0x1737C30
	public void .ctor() { }
}

