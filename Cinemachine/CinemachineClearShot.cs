[DocumentationSortingAttribute] // RVA: 0x12DED0 Offset: 0x12DFD1 VA: 0x12DED0
[DisallowMultipleComponent] // RVA: 0x12DED0 Offset: 0x12DFD1 VA: 0x12DED0
[ExecuteAlways] // RVA: 0x12DED0 Offset: 0x12DFD1 VA: 0x12DED0
[ExcludeFromPresetAttribute] // RVA: 0x12DED0 Offset: 0x12DFD1 VA: 0x12DED0
[AddComponentMenu] // RVA: 0x12DED0 Offset: 0x12DFD1 VA: 0x12DED0
[HelpURLAttribute] // RVA: 0x12DED0 Offset: 0x12DFD1 VA: 0x12DED0
public class CinemachineClearShot : CinemachineVirtualCameraBase // TypeDefIndex: 4740
{
	// Fields
	[TooltipAttribute] // RVA: 0x12FEB0 Offset: 0x12FFB1 VA: 0x12FEB0
	[NoSaveDuringPlayAttribute] // RVA: 0x12FEB0 Offset: 0x12FFB1 VA: 0x12FEB0
	[VcamTargetPropertyAttribute] // RVA: 0x12FEB0 Offset: 0x12FFB1 VA: 0x12FEB0
	public Transform m_LookAt; // 0x68
	[TooltipAttribute] // RVA: 0x12FF10 Offset: 0x130011 VA: 0x12FF10
	[NoSaveDuringPlayAttribute] // RVA: 0x12FF10 Offset: 0x130011 VA: 0x12FF10
	[VcamTargetPropertyAttribute] // RVA: 0x12FF10 Offset: 0x130011 VA: 0x12FF10
	public Transform m_Follow; // 0x70
	[TooltipAttribute] // RVA: 0x12FF70 Offset: 0x130071 VA: 0x12FF70
	[NoSaveDuringPlayAttribute] // RVA: 0x12FF70 Offset: 0x130071 VA: 0x12FF70
	public bool m_ShowDebugText; // 0x78
	[SerializeField] // RVA: 0x12FFC0 Offset: 0x1300C1 VA: 0x12FFC0
	[HideInInspector] // RVA: 0x12FFC0 Offset: 0x1300C1 VA: 0x12FFC0
	[NoSaveDuringPlayAttribute] // RVA: 0x12FFC0 Offset: 0x1300C1 VA: 0x12FFC0
	internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x80
	[TooltipAttribute] // RVA: 0x130010 Offset: 0x130111 VA: 0x130010
	public float m_ActivateAfter; // 0x88
	[TooltipAttribute] // RVA: 0x130050 Offset: 0x130151 VA: 0x130050
	public float m_MinDuration; // 0x8C
	[TooltipAttribute] // RVA: 0x130090 Offset: 0x130191 VA: 0x130090
	public bool m_RandomizeChoice; // 0x90
	[CinemachineBlendDefinitionPropertyAttribute] // RVA: 0x1300D0 Offset: 0x1301D1 VA: 0x1300D0
	[TooltipAttribute] // RVA: 0x1300D0 Offset: 0x1301D1 VA: 0x1300D0
	public CinemachineBlendDefinition m_DefaultBlend; // 0x98
	[HideInInspector] // RVA: 0x130120 Offset: 0x130221 VA: 0x130120
	public CinemachineBlenderSettings m_CustomBlends; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x130130 Offset: 0x130231 VA: 0x130130
	private ICinemachineCamera <LiveChild>k__BackingField; // 0xB0
	private CameraState m_State; // 0xB8
	private float mActivationTime; // 0x198
	private float mPendingActivationTime; // 0x19C
	private ICinemachineCamera mPendingCamera; // 0x1A0
	private CinemachineBlend mActiveBlend; // 0x1A8
	private bool mRandomizeNow; // 0x1B0
	private CinemachineVirtualCameraBase[] m_RandomizedChilden; // 0x1B8
	[CompilerGeneratedAttribute] // RVA: 0x130140 Offset: 0x130241 VA: 0x130140
	private ICinemachineCamera <TransitioningFrom>k__BackingField; // 0x1C0

	// Properties
	public override string Description { get; }
	public ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public bool IsBlending { get; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }
	private ICinemachineCamera TransitioningFrom { get; set; }

	// Methods

	// RVA: 0x188FC40 Offset: 0x188FD41 VA: 0x188FC40 Slot: 24
	public override string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x136B10 Offset: 0x136C11 VA: 0x136B10
	// RVA: 0x188FD90 Offset: 0x188FE91 VA: 0x188FD90
	public void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B20 Offset: 0x136C21 VA: 0x136B20
	// RVA: 0x188FDA0 Offset: 0x188FEA1 VA: 0x188FDA0
	public ICinemachineCamera get_LiveChild() { }

	// RVA: 0x188FDB0 Offset: 0x188FEB1 VA: 0x188FDB0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x188FDC0 Offset: 0x188FEC1 VA: 0x188FDC0 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x188FDF0 Offset: 0x188FEF1 VA: 0x188FDF0 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x188FE00 Offset: 0x188FF01 VA: 0x188FE00 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x188FE10 Offset: 0x188FF11 VA: 0x188FE10 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x188FE20 Offset: 0x188FF21 VA: 0x188FE20 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x188FE30 Offset: 0x188FF31 VA: 0x188FE30 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1890170 Offset: 0x1890271 VA: 0x1890170 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1890270 Offset: 0x1890371 VA: 0x1890270 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1890FD0 Offset: 0x18910D1 VA: 0x1890FD0 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x18911A0 Offset: 0x18912A1 VA: 0x18911A0 Slot: 40
	protected override void OnDisable() { }

	// RVA: 0x1891280 Offset: 0x1891381 VA: 0x1891280
	public void OnTransformChildrenChanged() { }

	// RVA: 0x18912D0 Offset: 0x18913D1 VA: 0x18912D0
	private void OnGuiHandler() { }

	// RVA: 0x1891470 Offset: 0x1891571 VA: 0x1891470
	public bool get_IsBlending() { }

	// RVA: 0x1891480 Offset: 0x1891581 VA: 0x1891480
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x1891150 Offset: 0x1891251 VA: 0x1891150
	private void InvalidateListOfChildren() { }

	// RVA: 0x18914B0 Offset: 0x18915B1 VA: 0x18914B0
	public void ResetRandomization() { }

	// RVA: 0x188FF00 Offset: 0x1890001 VA: 0x188FF00
	private void UpdateListOfChildren() { }

	// RVA: 0x1890660 Offset: 0x1890761 VA: 0x1890660
	private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp) { }

	// RVA: 0x18914F0 Offset: 0x18915F1 VA: 0x18914F0
	private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src) { }

	// RVA: 0x1890D60 Offset: 0x1890E61 VA: 0x1890D60
	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	// RVA: 0x18917B0 Offset: 0x18918B1 VA: 0x18917B0 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B30 Offset: 0x136C31 VA: 0x136B30
	// RVA: 0x1891880 Offset: 0x1891981 VA: 0x1891880
	private ICinemachineCamera get_TransitioningFrom() { }

	[CompilerGeneratedAttribute] // RVA: 0x136B40 Offset: 0x136C41 VA: 0x136B40
	// RVA: 0x1891890 Offset: 0x1891991 VA: 0x1891890
	private void set_TransitioningFrom(ICinemachineCamera value) { }

	// RVA: 0x18918A0 Offset: 0x18919A1 VA: 0x18918A0
	public void .ctor() { }
}

