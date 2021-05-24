[DocumentationSortingAttribute] // RVA: 0x12DE20 Offset: 0x12DF21 VA: 0x12DE20
[DisallowMultipleComponent] // RVA: 0x12DE20 Offset: 0x12DF21 VA: 0x12DE20
[ExecuteAlways] // RVA: 0x12DE20 Offset: 0x12DF21 VA: 0x12DE20
[AddComponentMenu] // RVA: 0x12DE20 Offset: 0x12DF21 VA: 0x12DE20
[SaveDuringPlayAttribute] // RVA: 0x12DE20 Offset: 0x12DF21 VA: 0x12DE20
[HelpURLAttribute] // RVA: 0x12DE20 Offset: 0x12DF21 VA: 0x12DE20
public class CinemachineBrain : MonoBehaviour // TypeDefIndex: 4733
{
	// Fields
	[TooltipAttribute] // RVA: 0x12FC10 Offset: 0x12FD11 VA: 0x12FC10
	public bool m_ShowDebugText; // 0x18
	[TooltipAttribute] // RVA: 0x12FC50 Offset: 0x12FD51 VA: 0x12FC50
	public bool m_ShowCameraFrustum; // 0x19
	[TooltipAttribute] // RVA: 0x12FC90 Offset: 0x12FD91 VA: 0x12FC90
	public bool m_IgnoreTimeScale; // 0x1A
	[TooltipAttribute] // RVA: 0x12FCD0 Offset: 0x12FDD1 VA: 0x12FCD0
	public Transform m_WorldUpOverride; // 0x20
	[TooltipAttribute] // RVA: 0x12FD10 Offset: 0x12FE11 VA: 0x12FD10
	public CinemachineBrain.UpdateMethod m_UpdateMethod; // 0x28
	[TooltipAttribute] // RVA: 0x12FD50 Offset: 0x12FE51 VA: 0x12FD50
	public CinemachineBrain.BrainUpdateMethod m_BlendUpdateMethod; // 0x2C
	[CinemachineBlendDefinitionPropertyAttribute] // RVA: 0x12FD90 Offset: 0x12FE91 VA: 0x12FD90
	[TooltipAttribute] // RVA: 0x12FD90 Offset: 0x12FE91 VA: 0x12FD90
	public CinemachineBlendDefinition m_DefaultBlend; // 0x30
	[TooltipAttribute] // RVA: 0x12FDE0 Offset: 0x12FEE1 VA: 0x12FDE0
	public CinemachineBlenderSettings m_CustomBlends; // 0x40
	private Camera m_OutputCamera; // 0x48
	[TooltipAttribute] // RVA: 0x12FE20 Offset: 0x12FF21 VA: 0x12FE20
	public CinemachineBrain.BrainEvent m_CameraCutEvent; // 0x50
	[TooltipAttribute] // RVA: 0x12FE60 Offset: 0x12FF61 VA: 0x12FE60
	public CinemachineBrain.VcamActivatedEvent m_CameraActivatedEvent; // 0x58
	private static ICinemachineCamera mSoloCamera; // 0x0
	private Coroutine mPhysicsCoroutine; // 0x60
	private WaitForFixedUpdate mWaitForFixedUpdate; // 0x68
	private List<CinemachineBrain.BrainFrame> mFrameStack; // 0x70
	private int mNextFrameId; // 0x78
	private CinemachineBlend mCurrentLiveCameras; // 0x80
	private static readonly AnimationCurve mDefaultLinearAnimationCurve; // 0x8
	private ICinemachineCamera mActiveCameraPreviousFrame; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x12FEA0 Offset: 0x12FFA1 VA: 0x12FEA0
	private CameraState <CurrentCameraState>k__BackingField; // 0x90

	// Properties
	public Camera OutputCamera { get; }
	public static ICinemachineCamera SoloCamera { get; set; }
	public Vector3 DefaultWorldUp { get; }
	public ICinemachineCamera ActiveVirtualCamera { get; }
	public bool IsBlending { get; }
	public CinemachineBlend ActiveBlend { get; }
	public CameraState CurrentCameraState { get; set; }

	// Methods

	// RVA: 0x1886B90 Offset: 0x1886C91 VA: 0x1886B90
	public Camera get_OutputCamera() { }

	// RVA: 0x188B7F0 Offset: 0x188B8F1 VA: 0x188B7F0
	public static ICinemachineCamera get_SoloCamera() { }

	// RVA: 0x188B860 Offset: 0x188B961 VA: 0x188B860
	public static void set_SoloCamera(ICinemachineCamera value) { }

	// RVA: 0x188BCA0 Offset: 0x188BDA1 VA: 0x188BCA0
	public static Color GetSoloGUIColor() { }

	// RVA: 0x188BD20 Offset: 0x188BE21 VA: 0x188BD20
	public Vector3 get_DefaultWorldUp() { }

	// RVA: 0x188BE00 Offset: 0x188BF01 VA: 0x188BE00
	private void OnEnable() { }

	// RVA: 0x188C390 Offset: 0x188C491 VA: 0x188C390
	private void OnDisable() { }

	// RVA: 0x188C610 Offset: 0x188C711 VA: 0x188C610
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x188C830 Offset: 0x188C931 VA: 0x188C830
	private void OnSceneUnloaded(Scene scene) { }

	// RVA: 0x188C840 Offset: 0x188C941 VA: 0x188C840
	private void Start() { }

	// RVA: 0x188CC20 Offset: 0x188CD21 VA: 0x188CC20
	private void OnGuiHandler() { }

	[IteratorStateMachineAttribute] // RVA: 0x136A80 Offset: 0x136B81 VA: 0x136A80
	// RVA: 0x188C310 Offset: 0x188C411 VA: 0x188C310
	private IEnumerator AfterPhysics() { }

	// RVA: 0x188D3C0 Offset: 0x188D4C1 VA: 0x188D3C0
	private void LateUpdate() { }

	// RVA: 0x188C620 Offset: 0x188C721 VA: 0x188C620
	public void ManualUpdate() { }

	// RVA: 0x188D3E0 Offset: 0x188D4E1 VA: 0x188D3E0
	private float GetEffectiveDeltaTime(bool fixedDelta) { }

	// RVA: 0x188C850 Offset: 0x188C951 VA: 0x188C850
	private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime) { }

	// RVA: 0x188D210 Offset: 0x188D311 VA: 0x188D210
	public ICinemachineCamera get_ActiveVirtualCamera() { }

	// RVA: 0x188E8C0 Offset: 0x188E9C1 VA: 0x188E8C0
	private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend) { }

	// RVA: 0x188D090 Offset: 0x188D191 VA: 0x188D090
	public bool get_IsBlending() { }

	// RVA: 0x188D0B0 Offset: 0x188D1B1 VA: 0x188D0B0
	public CinemachineBlend get_ActiveBlend() { }

	// RVA: 0x188E9F0 Offset: 0x188EAF1 VA: 0x188E9F0
	private int GetBrainFrame(int withId) { }

	// RVA: 0x188EAF0 Offset: 0x188EBF1 VA: 0x188EAF0
	public int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime) { }

	// RVA: 0x188ED40 Offset: 0x188EE41 VA: 0x188ED40
	public void ReleaseCameraOverride(int overrideId) { }

	// RVA: 0x188DE50 Offset: 0x188DF51 VA: 0x188DE50
	private void ProcessActiveCamera(float deltaTime) { }

	// RVA: 0x188D610 Offset: 0x188D711 VA: 0x188D610
	private void UpdateFrame0(float deltaTime) { }

	// RVA: 0x188D9E0 Offset: 0x188DAE1 VA: 0x188D9E0
	public void ComputeCurrentBlend(ref CinemachineBlend outputBlend, int numTopLayersToExclude) { }

	// RVA: 0x1886840 Offset: 0x1886941 VA: 0x1886840
	public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	[CompilerGeneratedAttribute] // RVA: 0x136AF0 Offset: 0x136BF1 VA: 0x136AF0
	// RVA: 0x188F640 Offset: 0x188F741 VA: 0x188F640
	public CameraState get_CurrentCameraState() { }

	[CompilerGeneratedAttribute] // RVA: 0x136B00 Offset: 0x136C01 VA: 0x136B00
	// RVA: 0x188F650 Offset: 0x188F751 VA: 0x188F650
	private void set_CurrentCameraState(CameraState value) { }

	// RVA: 0x188F140 Offset: 0x188F241 VA: 0x188F140
	private ICinemachineCamera TopCameraFromPriorityQueue() { }

	// RVA: 0x188F3D0 Offset: 0x188F4D1 VA: 0x188F3D0
	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	// RVA: 0x188EE10 Offset: 0x188EF11 VA: 0x188EE10
	private void PushStateToUnityCamera(CameraState state) { }

	// RVA: 0x188F750 Offset: 0x188F851 VA: 0x188F750
	public void .ctor() { }

	// RVA: 0x188FA10 Offset: 0x188FB11 VA: 0x188FA10
	private static void .cctor() { }
}

