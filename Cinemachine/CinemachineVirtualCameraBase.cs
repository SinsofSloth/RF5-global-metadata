[SaveDuringPlayAttribute] // RVA: 0x12EE30 Offset: 0x12EF31 VA: 0x12EE30
public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera // TypeDefIndex: 4848
{
	// Fields
	[HideInInspector] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	[SerializeField] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	[NoSaveDuringPlayAttribute] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	public string[] m_ExcludedPropertiesInInspector; // 0x18
	[HideInInspector] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	[SerializeField] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	[NoSaveDuringPlayAttribute] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	public CinemachineCore.Stage[] m_LockStageInInspector; // 0x20
	private int m_ValidatingStreamVersion; // 0x28
	private bool m_OnValidateCalled; // 0x2C
	[HideInInspector] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	[SerializeField] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	[NoSaveDuringPlayAttribute] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	private int m_StreamingVersion; // 0x30
	[NoSaveDuringPlayAttribute] // RVA: 0x134A00 Offset: 0x134B01 VA: 0x134A00
	[TooltipAttribute] // RVA: 0x134A00 Offset: 0x134B01 VA: 0x134A00
	public int m_Priority; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x134A50 Offset: 0x134B51 VA: 0x134A50
	private float <FollowTargetAttachment>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x134A60 Offset: 0x134B61 VA: 0x134A60
	private float <LookAtTargetAttachment>k__BackingField; // 0x3C
	[TooltipAttribute] // RVA: 0x134A70 Offset: 0x134B71 VA: 0x134A70
	public CinemachineVirtualCameraBase.StandbyUpdateMode m_StandbyUpdate; // 0x40
	private List<CinemachineExtension> mExtensions; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x134AB0 Offset: 0x134BB1 VA: 0x134AB0
	private bool <PreviousStateIsValid>k__BackingField; // 0x50
	private bool m_WasStarted; // 0x51
	private bool mSlaveStatusUpdated; // 0x52
	private CinemachineVirtualCameraBase m_parentVcam; // 0x58
	private int m_QueuePriority; // 0x60

	// Properties
	public int ValidatingStreamVersion { get; set; }
	public float FollowTargetAttachment { get; set; }
	public float LookAtTargetAttachment { get; set; }
	public string Name { get; }
	public virtual string Description { get; }
	public int Priority { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public abstract CameraState State { get; }
	public ICinemachineCamera ParentCamera { get; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public virtual bool PreviousStateIsValid { get; set; }

	// Methods

	// RVA: 0x1A196D0 Offset: 0x1A197D1 VA: 0x1A196D0
	public int get_ValidatingStreamVersion() { }

	// RVA: 0x1A1CAE0 Offset: 0x1A1CBE1 VA: 0x1A1CAE0
	private void set_ValidatingStreamVersion(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371B0 Offset: 0x1372B1 VA: 0x1371B0
	// RVA: 0x1A1CAF0 Offset: 0x1A1CBF1 VA: 0x1A1CAF0
	public float get_FollowTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x1371C0 Offset: 0x1372C1 VA: 0x1371C0
	// RVA: 0x1A1CB00 Offset: 0x1A1CC01 VA: 0x1A1CB00
	public void set_FollowTargetAttachment(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371D0 Offset: 0x1372D1 VA: 0x1371D0
	// RVA: 0x1A1CB10 Offset: 0x1A1CC11 VA: 0x1A1CB10
	public float get_LookAtTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x1371E0 Offset: 0x1372E1 VA: 0x1371E0
	// RVA: 0x1A1CB20 Offset: 0x1A1CC21 VA: 0x1A1CB20
	public void set_LookAtTargetAttachment(float value) { }

	// RVA: 0x1A17EE0 Offset: 0x1A17FE1 VA: 0x1A17EE0 Slot: 21
	public virtual float GetMaxDampTime() { }

	// RVA: 0x1A16400 Offset: 0x1A16501 VA: 0x1A16400
	public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A16580 Offset: 0x1A16681 VA: 0x1A16580
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A1CB30 Offset: 0x1A1CC31 VA: 0x1A1CB30
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CC10 Offset: 0x1A1CD11 VA: 0x1A1CC10
	public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CD90 Offset: 0x1A1CE91 VA: 0x1A1CD90
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A1CEC0 Offset: 0x1A1CFC1 VA: 0x1A1CEC0
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CFA0 Offset: 0x1A1D0A1 VA: 0x1A1CFA0 Slot: 22
	public virtual void AddExtension(CinemachineExtension extension) { }

	// RVA: 0x1A1D060 Offset: 0x1A1D161 VA: 0x1A1D060 Slot: 23
	public virtual void RemoveExtension(CinemachineExtension extension) { }

	// RVA: 0x1A1B990 Offset: 0x1A1BA91 VA: 0x1A1B990
	protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A1B7A0 Offset: 0x1A1B8A1 VA: 0x1A1B7A0
	protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A1C550 Offset: 0x1A1C651 VA: 0x1A1C550
	protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1D120 Offset: 0x1A1D221 VA: 0x1A1D120 Slot: 4
	public string get_Name() { }

	// RVA: 0x1A1D130 Offset: 0x1A1D231 VA: 0x1A1D130 Slot: 24
	public virtual string get_Description() { }

	// RVA: 0x1A1D180 Offset: 0x1A1D281 VA: 0x1A1D180 Slot: 6
	public int get_Priority() { }

	// RVA: 0x1A1D190 Offset: 0x1A1D291 VA: 0x1A1D190 Slot: 7
	public void set_Priority(int value) { }

	// RVA: 0x1A18E60 Offset: 0x1A18F61 VA: 0x1A18E60
	protected void ApplyPositionBlendMethod(ref CameraState state, CinemachineVirtualCameraBase.BlendHint hint) { }

	// RVA: 0x1A1D1A0 Offset: 0x1A1D2A1 VA: 0x1A1D1A0 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0x1A1D230 Offset: 0x1A1D331 VA: 0x1A1D230 Slot: 14
	public bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract CameraState get_State() { }

	// RVA: 0x1A1D0E0 Offset: 0x1A1D1E1 VA: 0x1A1D0E0 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0x1A1D390 Offset: 0x1A1D491 VA: 0x1A1D390 Slot: 26
	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Transform get_LookAt() { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void set_LookAt(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract Transform get_Follow() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void set_Follow(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371F0 Offset: 0x1372F1 VA: 0x1371F0
	// RVA: 0x1A1D3A0 Offset: 0x1A1D4A1 VA: 0x1A1D3A0 Slot: 31
	public virtual bool get_PreviousStateIsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x137200 Offset: 0x137301 VA: 0x137200
	// RVA: 0x1A1D3B0 Offset: 0x1A1D4B1 VA: 0x1A1D3B0 Slot: 32
	public virtual void set_PreviousStateIsValid(bool value) { }

	// RVA: 0x1A1C6D0 Offset: 0x1A1C7D1 VA: 0x1A1C6D0 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1C4F0 Offset: 0x1A1C5F1 VA: 0x1A1C4F0 Slot: 34
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A19B90 Offset: 0x1A19C91 VA: 0x1A19B90 Slot: 35
	protected virtual void OnDestroy() { }

	// RVA: 0x1A1D3C0 Offset: 0x1A1D4C1 VA: 0x1A1D3C0 Slot: 36
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x1A1D570 Offset: 0x1A1D671 VA: 0x1A1D570 Slot: 37
	protected virtual void Start() { }

	// RVA: 0x1A1D580 Offset: 0x1A1D681 VA: 0x1A1D580
	internal void EnsureStarted() { }

	// RVA: 0x1A1D640 Offset: 0x1A1D741 VA: 0x1A1D640
	public AxisState.IInputAxisProvider GetInputAxisProvider() { }

	// RVA: 0x1A19CB0 Offset: 0x1A19DB1 VA: 0x1A19CB0 Slot: 38
	protected virtual void OnValidate() { }

	// RVA: 0x1A191C0 Offset: 0x1A192C1 VA: 0x1A191C0 Slot: 39
	protected virtual void OnEnable() { }

	// RVA: 0x1A1D700 Offset: 0x1A1D801 VA: 0x1A1D700 Slot: 40
	protected virtual void OnDisable() { }

	// RVA: 0x1A1D780 Offset: 0x1A1D881 VA: 0x1A1D780 Slot: 41
	protected virtual void Update() { }

	// RVA: 0x1A1D2B0 Offset: 0x1A1D3B1 VA: 0x1A1D2B0
	private void UpdateSlaveStatus() { }

	// RVA: 0x1A17B10 Offset: 0x1A17C11 VA: 0x1A17B10
	protected Transform ResolveLookAt(Transform localLookAt) { }

	// RVA: 0x1A17C80 Offset: 0x1A17D81 VA: 0x1A17C80
	protected Transform ResolveFollow(Transform localFollow) { }

	// RVA: 0x1A1D460 Offset: 0x1A1D561 VA: 0x1A1D460
	private void UpdateVcamPoolStatus() { }

	// RVA: 0x1A17AE0 Offset: 0x1A17BE1 VA: 0x1A17AE0
	public void MoveToTopOfPrioritySubqueue() { }

	// RVA: 0x1A1BDE0 Offset: 0x1A1BEE1 VA: 0x1A1BDE0 Slot: 42
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A1C0A0 Offset: 0x1A1C1A1 VA: 0x1A1C0A0 Slot: 43
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A1D7A0 Offset: 0x1A1D8A1 VA: 0x1A1D7A0
	protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend) { }

	// RVA: 0x1A193F0 Offset: 0x1A194F1 VA: 0x1A193F0
	protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens) { }

	// RVA: 0x1A1C850 Offset: 0x1A1C951 VA: 0x1A1C850
	protected void .ctor() { }
}

[SaveDuringPlayAttribute] // RVA: 0x12EE30 Offset: 0x12EF31 VA: 0x12EE30
public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera // TypeDefIndex: 4848
{
	// Fields
	[HideInInspector] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	[SerializeField] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	[NoSaveDuringPlayAttribute] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	public string[] m_ExcludedPropertiesInInspector; // 0x18
	[HideInInspector] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	[SerializeField] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	[NoSaveDuringPlayAttribute] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	public CinemachineCore.Stage[] m_LockStageInInspector; // 0x20
	private int m_ValidatingStreamVersion; // 0x28
	private bool m_OnValidateCalled; // 0x2C
	[HideInInspector] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	[SerializeField] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	[NoSaveDuringPlayAttribute] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	private int m_StreamingVersion; // 0x30
	[NoSaveDuringPlayAttribute] // RVA: 0x134A00 Offset: 0x134B01 VA: 0x134A00
	[TooltipAttribute] // RVA: 0x134A00 Offset: 0x134B01 VA: 0x134A00
	public int m_Priority; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x134A50 Offset: 0x134B51 VA: 0x134A50
	private float <FollowTargetAttachment>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x134A60 Offset: 0x134B61 VA: 0x134A60
	private float <LookAtTargetAttachment>k__BackingField; // 0x3C
	[TooltipAttribute] // RVA: 0x134A70 Offset: 0x134B71 VA: 0x134A70
	public CinemachineVirtualCameraBase.StandbyUpdateMode m_StandbyUpdate; // 0x40
	private List<CinemachineExtension> mExtensions; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x134AB0 Offset: 0x134BB1 VA: 0x134AB0
	private bool <PreviousStateIsValid>k__BackingField; // 0x50
	private bool m_WasStarted; // 0x51
	private bool mSlaveStatusUpdated; // 0x52
	private CinemachineVirtualCameraBase m_parentVcam; // 0x58
	private int m_QueuePriority; // 0x60

	// Properties
	public int ValidatingStreamVersion { get; set; }
	public float FollowTargetAttachment { get; set; }
	public float LookAtTargetAttachment { get; set; }
	public string Name { get; }
	public virtual string Description { get; }
	public int Priority { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public abstract CameraState State { get; }
	public ICinemachineCamera ParentCamera { get; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public virtual bool PreviousStateIsValid { get; set; }

	// Methods

	// RVA: 0x1A196D0 Offset: 0x1A197D1 VA: 0x1A196D0
	public int get_ValidatingStreamVersion() { }

	// RVA: 0x1A1CAE0 Offset: 0x1A1CBE1 VA: 0x1A1CAE0
	private void set_ValidatingStreamVersion(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371B0 Offset: 0x1372B1 VA: 0x1371B0
	// RVA: 0x1A1CAF0 Offset: 0x1A1CBF1 VA: 0x1A1CAF0
	public float get_FollowTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x1371C0 Offset: 0x1372C1 VA: 0x1371C0
	// RVA: 0x1A1CB00 Offset: 0x1A1CC01 VA: 0x1A1CB00
	public void set_FollowTargetAttachment(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371D0 Offset: 0x1372D1 VA: 0x1371D0
	// RVA: 0x1A1CB10 Offset: 0x1A1CC11 VA: 0x1A1CB10
	public float get_LookAtTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x1371E0 Offset: 0x1372E1 VA: 0x1371E0
	// RVA: 0x1A1CB20 Offset: 0x1A1CC21 VA: 0x1A1CB20
	public void set_LookAtTargetAttachment(float value) { }

	// RVA: 0x1A17EE0 Offset: 0x1A17FE1 VA: 0x1A17EE0 Slot: 21
	public virtual float GetMaxDampTime() { }

	// RVA: 0x1A16400 Offset: 0x1A16501 VA: 0x1A16400
	public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A16580 Offset: 0x1A16681 VA: 0x1A16580
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A1CB30 Offset: 0x1A1CC31 VA: 0x1A1CB30
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CC10 Offset: 0x1A1CD11 VA: 0x1A1CC10
	public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CD90 Offset: 0x1A1CE91 VA: 0x1A1CD90
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A1CEC0 Offset: 0x1A1CFC1 VA: 0x1A1CEC0
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CFA0 Offset: 0x1A1D0A1 VA: 0x1A1CFA0 Slot: 22
	public virtual void AddExtension(CinemachineExtension extension) { }

	// RVA: 0x1A1D060 Offset: 0x1A1D161 VA: 0x1A1D060 Slot: 23
	public virtual void RemoveExtension(CinemachineExtension extension) { }

	// RVA: 0x1A1B990 Offset: 0x1A1BA91 VA: 0x1A1B990
	protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A1B7A0 Offset: 0x1A1B8A1 VA: 0x1A1B7A0
	protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A1C550 Offset: 0x1A1C651 VA: 0x1A1C550
	protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1D120 Offset: 0x1A1D221 VA: 0x1A1D120 Slot: 4
	public string get_Name() { }

	// RVA: 0x1A1D130 Offset: 0x1A1D231 VA: 0x1A1D130 Slot: 24
	public virtual string get_Description() { }

	// RVA: 0x1A1D180 Offset: 0x1A1D281 VA: 0x1A1D180 Slot: 6
	public int get_Priority() { }

	// RVA: 0x1A1D190 Offset: 0x1A1D291 VA: 0x1A1D190 Slot: 7
	public void set_Priority(int value) { }

	// RVA: 0x1A18E60 Offset: 0x1A18F61 VA: 0x1A18E60
	protected void ApplyPositionBlendMethod(ref CameraState state, CinemachineVirtualCameraBase.BlendHint hint) { }

	// RVA: 0x1A1D1A0 Offset: 0x1A1D2A1 VA: 0x1A1D1A0 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0x1A1D230 Offset: 0x1A1D331 VA: 0x1A1D230 Slot: 14
	public bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract CameraState get_State() { }

	// RVA: 0x1A1D0E0 Offset: 0x1A1D1E1 VA: 0x1A1D0E0 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0x1A1D390 Offset: 0x1A1D491 VA: 0x1A1D390 Slot: 26
	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Transform get_LookAt() { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void set_LookAt(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract Transform get_Follow() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void set_Follow(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371F0 Offset: 0x1372F1 VA: 0x1371F0
	// RVA: 0x1A1D3A0 Offset: 0x1A1D4A1 VA: 0x1A1D3A0 Slot: 31
	public virtual bool get_PreviousStateIsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x137200 Offset: 0x137301 VA: 0x137200
	// RVA: 0x1A1D3B0 Offset: 0x1A1D4B1 VA: 0x1A1D3B0 Slot: 32
	public virtual void set_PreviousStateIsValid(bool value) { }

	// RVA: 0x1A1C6D0 Offset: 0x1A1C7D1 VA: 0x1A1C6D0 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1C4F0 Offset: 0x1A1C5F1 VA: 0x1A1C4F0 Slot: 34
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A19B90 Offset: 0x1A19C91 VA: 0x1A19B90 Slot: 35
	protected virtual void OnDestroy() { }

	// RVA: 0x1A1D3C0 Offset: 0x1A1D4C1 VA: 0x1A1D3C0 Slot: 36
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x1A1D570 Offset: 0x1A1D671 VA: 0x1A1D570 Slot: 37
	protected virtual void Start() { }

	// RVA: 0x1A1D580 Offset: 0x1A1D681 VA: 0x1A1D580
	internal void EnsureStarted() { }

	// RVA: 0x1A1D640 Offset: 0x1A1D741 VA: 0x1A1D640
	public AxisState.IInputAxisProvider GetInputAxisProvider() { }

	// RVA: 0x1A19CB0 Offset: 0x1A19DB1 VA: 0x1A19CB0 Slot: 38
	protected virtual void OnValidate() { }

	// RVA: 0x1A191C0 Offset: 0x1A192C1 VA: 0x1A191C0 Slot: 39
	protected virtual void OnEnable() { }

	// RVA: 0x1A1D700 Offset: 0x1A1D801 VA: 0x1A1D700 Slot: 40
	protected virtual void OnDisable() { }

	// RVA: 0x1A1D780 Offset: 0x1A1D881 VA: 0x1A1D780 Slot: 41
	protected virtual void Update() { }

	// RVA: 0x1A1D2B0 Offset: 0x1A1D3B1 VA: 0x1A1D2B0
	private void UpdateSlaveStatus() { }

	// RVA: 0x1A17B10 Offset: 0x1A17C11 VA: 0x1A17B10
	protected Transform ResolveLookAt(Transform localLookAt) { }

	// RVA: 0x1A17C80 Offset: 0x1A17D81 VA: 0x1A17C80
	protected Transform ResolveFollow(Transform localFollow) { }

	// RVA: 0x1A1D460 Offset: 0x1A1D561 VA: 0x1A1D460
	private void UpdateVcamPoolStatus() { }

	// RVA: 0x1A17AE0 Offset: 0x1A17BE1 VA: 0x1A17AE0
	public void MoveToTopOfPrioritySubqueue() { }

	// RVA: 0x1A1BDE0 Offset: 0x1A1BEE1 VA: 0x1A1BDE0 Slot: 42
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A1C0A0 Offset: 0x1A1C1A1 VA: 0x1A1C0A0 Slot: 43
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A1D7A0 Offset: 0x1A1D8A1 VA: 0x1A1D7A0
	protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend) { }

	// RVA: 0x1A193F0 Offset: 0x1A194F1 VA: 0x1A193F0
	protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens) { }

	// RVA: 0x1A1C850 Offset: 0x1A1C951 VA: 0x1A1C850
	protected void .ctor() { }
}

[SaveDuringPlayAttribute] // RVA: 0x12EE30 Offset: 0x12EF31 VA: 0x12EE30
public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera // TypeDefIndex: 4848
{
	// Fields
	[HideInInspector] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	[SerializeField] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	[NoSaveDuringPlayAttribute] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	public string[] m_ExcludedPropertiesInInspector; // 0x18
	[HideInInspector] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	[SerializeField] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	[NoSaveDuringPlayAttribute] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	public CinemachineCore.Stage[] m_LockStageInInspector; // 0x20
	private int m_ValidatingStreamVersion; // 0x28
	private bool m_OnValidateCalled; // 0x2C
	[HideInInspector] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	[SerializeField] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	[NoSaveDuringPlayAttribute] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	private int m_StreamingVersion; // 0x30
	[NoSaveDuringPlayAttribute] // RVA: 0x134A00 Offset: 0x134B01 VA: 0x134A00
	[TooltipAttribute] // RVA: 0x134A00 Offset: 0x134B01 VA: 0x134A00
	public int m_Priority; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x134A50 Offset: 0x134B51 VA: 0x134A50
	private float <FollowTargetAttachment>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x134A60 Offset: 0x134B61 VA: 0x134A60
	private float <LookAtTargetAttachment>k__BackingField; // 0x3C
	[TooltipAttribute] // RVA: 0x134A70 Offset: 0x134B71 VA: 0x134A70
	public CinemachineVirtualCameraBase.StandbyUpdateMode m_StandbyUpdate; // 0x40
	private List<CinemachineExtension> mExtensions; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x134AB0 Offset: 0x134BB1 VA: 0x134AB0
	private bool <PreviousStateIsValid>k__BackingField; // 0x50
	private bool m_WasStarted; // 0x51
	private bool mSlaveStatusUpdated; // 0x52
	private CinemachineVirtualCameraBase m_parentVcam; // 0x58
	private int m_QueuePriority; // 0x60

	// Properties
	public int ValidatingStreamVersion { get; set; }
	public float FollowTargetAttachment { get; set; }
	public float LookAtTargetAttachment { get; set; }
	public string Name { get; }
	public virtual string Description { get; }
	public int Priority { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public abstract CameraState State { get; }
	public ICinemachineCamera ParentCamera { get; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public virtual bool PreviousStateIsValid { get; set; }

	// Methods

	// RVA: 0x1A196D0 Offset: 0x1A197D1 VA: 0x1A196D0
	public int get_ValidatingStreamVersion() { }

	// RVA: 0x1A1CAE0 Offset: 0x1A1CBE1 VA: 0x1A1CAE0
	private void set_ValidatingStreamVersion(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371B0 Offset: 0x1372B1 VA: 0x1371B0
	// RVA: 0x1A1CAF0 Offset: 0x1A1CBF1 VA: 0x1A1CAF0
	public float get_FollowTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x1371C0 Offset: 0x1372C1 VA: 0x1371C0
	// RVA: 0x1A1CB00 Offset: 0x1A1CC01 VA: 0x1A1CB00
	public void set_FollowTargetAttachment(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371D0 Offset: 0x1372D1 VA: 0x1371D0
	// RVA: 0x1A1CB10 Offset: 0x1A1CC11 VA: 0x1A1CB10
	public float get_LookAtTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x1371E0 Offset: 0x1372E1 VA: 0x1371E0
	// RVA: 0x1A1CB20 Offset: 0x1A1CC21 VA: 0x1A1CB20
	public void set_LookAtTargetAttachment(float value) { }

	// RVA: 0x1A17EE0 Offset: 0x1A17FE1 VA: 0x1A17EE0 Slot: 21
	public virtual float GetMaxDampTime() { }

	// RVA: 0x1A16400 Offset: 0x1A16501 VA: 0x1A16400
	public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A16580 Offset: 0x1A16681 VA: 0x1A16580
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A1CB30 Offset: 0x1A1CC31 VA: 0x1A1CB30
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CC10 Offset: 0x1A1CD11 VA: 0x1A1CC10
	public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CD90 Offset: 0x1A1CE91 VA: 0x1A1CD90
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A1CEC0 Offset: 0x1A1CFC1 VA: 0x1A1CEC0
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CFA0 Offset: 0x1A1D0A1 VA: 0x1A1CFA0 Slot: 22
	public virtual void AddExtension(CinemachineExtension extension) { }

	// RVA: 0x1A1D060 Offset: 0x1A1D161 VA: 0x1A1D060 Slot: 23
	public virtual void RemoveExtension(CinemachineExtension extension) { }

	// RVA: 0x1A1B990 Offset: 0x1A1BA91 VA: 0x1A1B990
	protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A1B7A0 Offset: 0x1A1B8A1 VA: 0x1A1B7A0
	protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A1C550 Offset: 0x1A1C651 VA: 0x1A1C550
	protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1D120 Offset: 0x1A1D221 VA: 0x1A1D120 Slot: 4
	public string get_Name() { }

	// RVA: 0x1A1D130 Offset: 0x1A1D231 VA: 0x1A1D130 Slot: 24
	public virtual string get_Description() { }

	// RVA: 0x1A1D180 Offset: 0x1A1D281 VA: 0x1A1D180 Slot: 6
	public int get_Priority() { }

	// RVA: 0x1A1D190 Offset: 0x1A1D291 VA: 0x1A1D190 Slot: 7
	public void set_Priority(int value) { }

	// RVA: 0x1A18E60 Offset: 0x1A18F61 VA: 0x1A18E60
	protected void ApplyPositionBlendMethod(ref CameraState state, CinemachineVirtualCameraBase.BlendHint hint) { }

	// RVA: 0x1A1D1A0 Offset: 0x1A1D2A1 VA: 0x1A1D1A0 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0x1A1D230 Offset: 0x1A1D331 VA: 0x1A1D230 Slot: 14
	public bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract CameraState get_State() { }

	// RVA: 0x1A1D0E0 Offset: 0x1A1D1E1 VA: 0x1A1D0E0 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0x1A1D390 Offset: 0x1A1D491 VA: 0x1A1D390 Slot: 26
	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Transform get_LookAt() { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void set_LookAt(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract Transform get_Follow() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void set_Follow(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371F0 Offset: 0x1372F1 VA: 0x1371F0
	// RVA: 0x1A1D3A0 Offset: 0x1A1D4A1 VA: 0x1A1D3A0 Slot: 31
	public virtual bool get_PreviousStateIsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x137200 Offset: 0x137301 VA: 0x137200
	// RVA: 0x1A1D3B0 Offset: 0x1A1D4B1 VA: 0x1A1D3B0 Slot: 32
	public virtual void set_PreviousStateIsValid(bool value) { }

	// RVA: 0x1A1C6D0 Offset: 0x1A1C7D1 VA: 0x1A1C6D0 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1C4F0 Offset: 0x1A1C5F1 VA: 0x1A1C4F0 Slot: 34
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A19B90 Offset: 0x1A19C91 VA: 0x1A19B90 Slot: 35
	protected virtual void OnDestroy() { }

	// RVA: 0x1A1D3C0 Offset: 0x1A1D4C1 VA: 0x1A1D3C0 Slot: 36
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x1A1D570 Offset: 0x1A1D671 VA: 0x1A1D570 Slot: 37
	protected virtual void Start() { }

	// RVA: 0x1A1D580 Offset: 0x1A1D681 VA: 0x1A1D580
	internal void EnsureStarted() { }

	// RVA: 0x1A1D640 Offset: 0x1A1D741 VA: 0x1A1D640
	public AxisState.IInputAxisProvider GetInputAxisProvider() { }

	// RVA: 0x1A19CB0 Offset: 0x1A19DB1 VA: 0x1A19CB0 Slot: 38
	protected virtual void OnValidate() { }

	// RVA: 0x1A191C0 Offset: 0x1A192C1 VA: 0x1A191C0 Slot: 39
	protected virtual void OnEnable() { }

	// RVA: 0x1A1D700 Offset: 0x1A1D801 VA: 0x1A1D700 Slot: 40
	protected virtual void OnDisable() { }

	// RVA: 0x1A1D780 Offset: 0x1A1D881 VA: 0x1A1D780 Slot: 41
	protected virtual void Update() { }

	// RVA: 0x1A1D2B0 Offset: 0x1A1D3B1 VA: 0x1A1D2B0
	private void UpdateSlaveStatus() { }

	// RVA: 0x1A17B10 Offset: 0x1A17C11 VA: 0x1A17B10
	protected Transform ResolveLookAt(Transform localLookAt) { }

	// RVA: 0x1A17C80 Offset: 0x1A17D81 VA: 0x1A17C80
	protected Transform ResolveFollow(Transform localFollow) { }

	// RVA: 0x1A1D460 Offset: 0x1A1D561 VA: 0x1A1D460
	private void UpdateVcamPoolStatus() { }

	// RVA: 0x1A17AE0 Offset: 0x1A17BE1 VA: 0x1A17AE0
	public void MoveToTopOfPrioritySubqueue() { }

	// RVA: 0x1A1BDE0 Offset: 0x1A1BEE1 VA: 0x1A1BDE0 Slot: 42
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A1C0A0 Offset: 0x1A1C1A1 VA: 0x1A1C0A0 Slot: 43
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A1D7A0 Offset: 0x1A1D8A1 VA: 0x1A1D7A0
	protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend) { }

	// RVA: 0x1A193F0 Offset: 0x1A194F1 VA: 0x1A193F0
	protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens) { }

	// RVA: 0x1A1C850 Offset: 0x1A1C951 VA: 0x1A1C850
	protected void .ctor() { }
}

[SaveDuringPlayAttribute] // RVA: 0x12EE30 Offset: 0x12EF31 VA: 0x12EE30
public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera // TypeDefIndex: 4848
{
	// Fields
	[HideInInspector] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	[SerializeField] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	[NoSaveDuringPlayAttribute] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	public string[] m_ExcludedPropertiesInInspector; // 0x18
	[HideInInspector] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	[SerializeField] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	[NoSaveDuringPlayAttribute] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	public CinemachineCore.Stage[] m_LockStageInInspector; // 0x20
	private int m_ValidatingStreamVersion; // 0x28
	private bool m_OnValidateCalled; // 0x2C
	[HideInInspector] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	[SerializeField] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	[NoSaveDuringPlayAttribute] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	private int m_StreamingVersion; // 0x30
	[NoSaveDuringPlayAttribute] // RVA: 0x134A00 Offset: 0x134B01 VA: 0x134A00
	[TooltipAttribute] // RVA: 0x134A00 Offset: 0x134B01 VA: 0x134A00
	public int m_Priority; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x134A50 Offset: 0x134B51 VA: 0x134A50
	private float <FollowTargetAttachment>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x134A60 Offset: 0x134B61 VA: 0x134A60
	private float <LookAtTargetAttachment>k__BackingField; // 0x3C
	[TooltipAttribute] // RVA: 0x134A70 Offset: 0x134B71 VA: 0x134A70
	public CinemachineVirtualCameraBase.StandbyUpdateMode m_StandbyUpdate; // 0x40
	private List<CinemachineExtension> mExtensions; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x134AB0 Offset: 0x134BB1 VA: 0x134AB0
	private bool <PreviousStateIsValid>k__BackingField; // 0x50
	private bool m_WasStarted; // 0x51
	private bool mSlaveStatusUpdated; // 0x52
	private CinemachineVirtualCameraBase m_parentVcam; // 0x58
	private int m_QueuePriority; // 0x60

	// Properties
	public int ValidatingStreamVersion { get; set; }
	public float FollowTargetAttachment { get; set; }
	public float LookAtTargetAttachment { get; set; }
	public string Name { get; }
	public virtual string Description { get; }
	public int Priority { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public abstract CameraState State { get; }
	public ICinemachineCamera ParentCamera { get; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public virtual bool PreviousStateIsValid { get; set; }

	// Methods

	// RVA: 0x1A196D0 Offset: 0x1A197D1 VA: 0x1A196D0
	public int get_ValidatingStreamVersion() { }

	// RVA: 0x1A1CAE0 Offset: 0x1A1CBE1 VA: 0x1A1CAE0
	private void set_ValidatingStreamVersion(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371B0 Offset: 0x1372B1 VA: 0x1371B0
	// RVA: 0x1A1CAF0 Offset: 0x1A1CBF1 VA: 0x1A1CAF0
	public float get_FollowTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x1371C0 Offset: 0x1372C1 VA: 0x1371C0
	// RVA: 0x1A1CB00 Offset: 0x1A1CC01 VA: 0x1A1CB00
	public void set_FollowTargetAttachment(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371D0 Offset: 0x1372D1 VA: 0x1371D0
	// RVA: 0x1A1CB10 Offset: 0x1A1CC11 VA: 0x1A1CB10
	public float get_LookAtTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x1371E0 Offset: 0x1372E1 VA: 0x1371E0
	// RVA: 0x1A1CB20 Offset: 0x1A1CC21 VA: 0x1A1CB20
	public void set_LookAtTargetAttachment(float value) { }

	// RVA: 0x1A17EE0 Offset: 0x1A17FE1 VA: 0x1A17EE0 Slot: 21
	public virtual float GetMaxDampTime() { }

	// RVA: 0x1A16400 Offset: 0x1A16501 VA: 0x1A16400
	public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A16580 Offset: 0x1A16681 VA: 0x1A16580
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A1CB30 Offset: 0x1A1CC31 VA: 0x1A1CB30
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CC10 Offset: 0x1A1CD11 VA: 0x1A1CC10
	public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CD90 Offset: 0x1A1CE91 VA: 0x1A1CD90
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A1CEC0 Offset: 0x1A1CFC1 VA: 0x1A1CEC0
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CFA0 Offset: 0x1A1D0A1 VA: 0x1A1CFA0 Slot: 22
	public virtual void AddExtension(CinemachineExtension extension) { }

	// RVA: 0x1A1D060 Offset: 0x1A1D161 VA: 0x1A1D060 Slot: 23
	public virtual void RemoveExtension(CinemachineExtension extension) { }

	// RVA: 0x1A1B990 Offset: 0x1A1BA91 VA: 0x1A1B990
	protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A1B7A0 Offset: 0x1A1B8A1 VA: 0x1A1B7A0
	protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A1C550 Offset: 0x1A1C651 VA: 0x1A1C550
	protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1D120 Offset: 0x1A1D221 VA: 0x1A1D120 Slot: 4
	public string get_Name() { }

	// RVA: 0x1A1D130 Offset: 0x1A1D231 VA: 0x1A1D130 Slot: 24
	public virtual string get_Description() { }

	// RVA: 0x1A1D180 Offset: 0x1A1D281 VA: 0x1A1D180 Slot: 6
	public int get_Priority() { }

	// RVA: 0x1A1D190 Offset: 0x1A1D291 VA: 0x1A1D190 Slot: 7
	public void set_Priority(int value) { }

	// RVA: 0x1A18E60 Offset: 0x1A18F61 VA: 0x1A18E60
	protected void ApplyPositionBlendMethod(ref CameraState state, CinemachineVirtualCameraBase.BlendHint hint) { }

	// RVA: 0x1A1D1A0 Offset: 0x1A1D2A1 VA: 0x1A1D1A0 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0x1A1D230 Offset: 0x1A1D331 VA: 0x1A1D230 Slot: 14
	public bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract CameraState get_State() { }

	// RVA: 0x1A1D0E0 Offset: 0x1A1D1E1 VA: 0x1A1D0E0 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0x1A1D390 Offset: 0x1A1D491 VA: 0x1A1D390 Slot: 26
	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Transform get_LookAt() { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void set_LookAt(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract Transform get_Follow() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void set_Follow(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371F0 Offset: 0x1372F1 VA: 0x1371F0
	// RVA: 0x1A1D3A0 Offset: 0x1A1D4A1 VA: 0x1A1D3A0 Slot: 31
	public virtual bool get_PreviousStateIsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x137200 Offset: 0x137301 VA: 0x137200
	// RVA: 0x1A1D3B0 Offset: 0x1A1D4B1 VA: 0x1A1D3B0 Slot: 32
	public virtual void set_PreviousStateIsValid(bool value) { }

	// RVA: 0x1A1C6D0 Offset: 0x1A1C7D1 VA: 0x1A1C6D0 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1C4F0 Offset: 0x1A1C5F1 VA: 0x1A1C4F0 Slot: 34
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A19B90 Offset: 0x1A19C91 VA: 0x1A19B90 Slot: 35
	protected virtual void OnDestroy() { }

	// RVA: 0x1A1D3C0 Offset: 0x1A1D4C1 VA: 0x1A1D3C0 Slot: 36
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x1A1D570 Offset: 0x1A1D671 VA: 0x1A1D570 Slot: 37
	protected virtual void Start() { }

	// RVA: 0x1A1D580 Offset: 0x1A1D681 VA: 0x1A1D580
	internal void EnsureStarted() { }

	// RVA: 0x1A1D640 Offset: 0x1A1D741 VA: 0x1A1D640
	public AxisState.IInputAxisProvider GetInputAxisProvider() { }

	// RVA: 0x1A19CB0 Offset: 0x1A19DB1 VA: 0x1A19CB0 Slot: 38
	protected virtual void OnValidate() { }

	// RVA: 0x1A191C0 Offset: 0x1A192C1 VA: 0x1A191C0 Slot: 39
	protected virtual void OnEnable() { }

	// RVA: 0x1A1D700 Offset: 0x1A1D801 VA: 0x1A1D700 Slot: 40
	protected virtual void OnDisable() { }

	// RVA: 0x1A1D780 Offset: 0x1A1D881 VA: 0x1A1D780 Slot: 41
	protected virtual void Update() { }

	// RVA: 0x1A1D2B0 Offset: 0x1A1D3B1 VA: 0x1A1D2B0
	private void UpdateSlaveStatus() { }

	// RVA: 0x1A17B10 Offset: 0x1A17C11 VA: 0x1A17B10
	protected Transform ResolveLookAt(Transform localLookAt) { }

	// RVA: 0x1A17C80 Offset: 0x1A17D81 VA: 0x1A17C80
	protected Transform ResolveFollow(Transform localFollow) { }

	// RVA: 0x1A1D460 Offset: 0x1A1D561 VA: 0x1A1D460
	private void UpdateVcamPoolStatus() { }

	// RVA: 0x1A17AE0 Offset: 0x1A17BE1 VA: 0x1A17AE0
	public void MoveToTopOfPrioritySubqueue() { }

	// RVA: 0x1A1BDE0 Offset: 0x1A1BEE1 VA: 0x1A1BDE0 Slot: 42
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A1C0A0 Offset: 0x1A1C1A1 VA: 0x1A1C0A0 Slot: 43
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A1D7A0 Offset: 0x1A1D8A1 VA: 0x1A1D7A0
	protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend) { }

	// RVA: 0x1A193F0 Offset: 0x1A194F1 VA: 0x1A193F0
	protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens) { }

	// RVA: 0x1A1C850 Offset: 0x1A1C951 VA: 0x1A1C850
	protected void .ctor() { }
}

[SaveDuringPlayAttribute] // RVA: 0x12EE30 Offset: 0x12EF31 VA: 0x12EE30
public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera // TypeDefIndex: 4848
{
	// Fields
	[HideInInspector] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	[SerializeField] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	[NoSaveDuringPlayAttribute] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	public string[] m_ExcludedPropertiesInInspector; // 0x18
	[HideInInspector] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	[SerializeField] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	[NoSaveDuringPlayAttribute] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	public CinemachineCore.Stage[] m_LockStageInInspector; // 0x20
	private int m_ValidatingStreamVersion; // 0x28
	private bool m_OnValidateCalled; // 0x2C
	[HideInInspector] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	[SerializeField] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	[NoSaveDuringPlayAttribute] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	private int m_StreamingVersion; // 0x30
	[NoSaveDuringPlayAttribute] // RVA: 0x134A00 Offset: 0x134B01 VA: 0x134A00
	[TooltipAttribute] // RVA: 0x134A00 Offset: 0x134B01 VA: 0x134A00
	public int m_Priority; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x134A50 Offset: 0x134B51 VA: 0x134A50
	private float <FollowTargetAttachment>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x134A60 Offset: 0x134B61 VA: 0x134A60
	private float <LookAtTargetAttachment>k__BackingField; // 0x3C
	[TooltipAttribute] // RVA: 0x134A70 Offset: 0x134B71 VA: 0x134A70
	public CinemachineVirtualCameraBase.StandbyUpdateMode m_StandbyUpdate; // 0x40
	private List<CinemachineExtension> mExtensions; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x134AB0 Offset: 0x134BB1 VA: 0x134AB0
	private bool <PreviousStateIsValid>k__BackingField; // 0x50
	private bool m_WasStarted; // 0x51
	private bool mSlaveStatusUpdated; // 0x52
	private CinemachineVirtualCameraBase m_parentVcam; // 0x58
	private int m_QueuePriority; // 0x60

	// Properties
	public int ValidatingStreamVersion { get; set; }
	public float FollowTargetAttachment { get; set; }
	public float LookAtTargetAttachment { get; set; }
	public string Name { get; }
	public virtual string Description { get; }
	public int Priority { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public abstract CameraState State { get; }
	public ICinemachineCamera ParentCamera { get; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public virtual bool PreviousStateIsValid { get; set; }

	// Methods

	// RVA: 0x1A196D0 Offset: 0x1A197D1 VA: 0x1A196D0
	public int get_ValidatingStreamVersion() { }

	// RVA: 0x1A1CAE0 Offset: 0x1A1CBE1 VA: 0x1A1CAE0
	private void set_ValidatingStreamVersion(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371B0 Offset: 0x1372B1 VA: 0x1371B0
	// RVA: 0x1A1CAF0 Offset: 0x1A1CBF1 VA: 0x1A1CAF0
	public float get_FollowTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x1371C0 Offset: 0x1372C1 VA: 0x1371C0
	// RVA: 0x1A1CB00 Offset: 0x1A1CC01 VA: 0x1A1CB00
	public void set_FollowTargetAttachment(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371D0 Offset: 0x1372D1 VA: 0x1371D0
	// RVA: 0x1A1CB10 Offset: 0x1A1CC11 VA: 0x1A1CB10
	public float get_LookAtTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x1371E0 Offset: 0x1372E1 VA: 0x1371E0
	// RVA: 0x1A1CB20 Offset: 0x1A1CC21 VA: 0x1A1CB20
	public void set_LookAtTargetAttachment(float value) { }

	// RVA: 0x1A17EE0 Offset: 0x1A17FE1 VA: 0x1A17EE0 Slot: 21
	public virtual float GetMaxDampTime() { }

	// RVA: 0x1A16400 Offset: 0x1A16501 VA: 0x1A16400
	public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A16580 Offset: 0x1A16681 VA: 0x1A16580
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A1CB30 Offset: 0x1A1CC31 VA: 0x1A1CB30
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CC10 Offset: 0x1A1CD11 VA: 0x1A1CC10
	public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CD90 Offset: 0x1A1CE91 VA: 0x1A1CD90
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A1CEC0 Offset: 0x1A1CFC1 VA: 0x1A1CEC0
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CFA0 Offset: 0x1A1D0A1 VA: 0x1A1CFA0 Slot: 22
	public virtual void AddExtension(CinemachineExtension extension) { }

	// RVA: 0x1A1D060 Offset: 0x1A1D161 VA: 0x1A1D060 Slot: 23
	public virtual void RemoveExtension(CinemachineExtension extension) { }

	// RVA: 0x1A1B990 Offset: 0x1A1BA91 VA: 0x1A1B990
	protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A1B7A0 Offset: 0x1A1B8A1 VA: 0x1A1B7A0
	protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A1C550 Offset: 0x1A1C651 VA: 0x1A1C550
	protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1D120 Offset: 0x1A1D221 VA: 0x1A1D120 Slot: 4
	public string get_Name() { }

	// RVA: 0x1A1D130 Offset: 0x1A1D231 VA: 0x1A1D130 Slot: 24
	public virtual string get_Description() { }

	// RVA: 0x1A1D180 Offset: 0x1A1D281 VA: 0x1A1D180 Slot: 6
	public int get_Priority() { }

	// RVA: 0x1A1D190 Offset: 0x1A1D291 VA: 0x1A1D190 Slot: 7
	public void set_Priority(int value) { }

	// RVA: 0x1A18E60 Offset: 0x1A18F61 VA: 0x1A18E60
	protected void ApplyPositionBlendMethod(ref CameraState state, CinemachineVirtualCameraBase.BlendHint hint) { }

	// RVA: 0x1A1D1A0 Offset: 0x1A1D2A1 VA: 0x1A1D1A0 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0x1A1D230 Offset: 0x1A1D331 VA: 0x1A1D230 Slot: 14
	public bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract CameraState get_State() { }

	// RVA: 0x1A1D0E0 Offset: 0x1A1D1E1 VA: 0x1A1D0E0 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0x1A1D390 Offset: 0x1A1D491 VA: 0x1A1D390 Slot: 26
	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Transform get_LookAt() { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void set_LookAt(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract Transform get_Follow() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void set_Follow(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371F0 Offset: 0x1372F1 VA: 0x1371F0
	// RVA: 0x1A1D3A0 Offset: 0x1A1D4A1 VA: 0x1A1D3A0 Slot: 31
	public virtual bool get_PreviousStateIsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x137200 Offset: 0x137301 VA: 0x137200
	// RVA: 0x1A1D3B0 Offset: 0x1A1D4B1 VA: 0x1A1D3B0 Slot: 32
	public virtual void set_PreviousStateIsValid(bool value) { }

	// RVA: 0x1A1C6D0 Offset: 0x1A1C7D1 VA: 0x1A1C6D0 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1C4F0 Offset: 0x1A1C5F1 VA: 0x1A1C4F0 Slot: 34
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A19B90 Offset: 0x1A19C91 VA: 0x1A19B90 Slot: 35
	protected virtual void OnDestroy() { }

	// RVA: 0x1A1D3C0 Offset: 0x1A1D4C1 VA: 0x1A1D3C0 Slot: 36
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x1A1D570 Offset: 0x1A1D671 VA: 0x1A1D570 Slot: 37
	protected virtual void Start() { }

	// RVA: 0x1A1D580 Offset: 0x1A1D681 VA: 0x1A1D580
	internal void EnsureStarted() { }

	// RVA: 0x1A1D640 Offset: 0x1A1D741 VA: 0x1A1D640
	public AxisState.IInputAxisProvider GetInputAxisProvider() { }

	// RVA: 0x1A19CB0 Offset: 0x1A19DB1 VA: 0x1A19CB0 Slot: 38
	protected virtual void OnValidate() { }

	// RVA: 0x1A191C0 Offset: 0x1A192C1 VA: 0x1A191C0 Slot: 39
	protected virtual void OnEnable() { }

	// RVA: 0x1A1D700 Offset: 0x1A1D801 VA: 0x1A1D700 Slot: 40
	protected virtual void OnDisable() { }

	// RVA: 0x1A1D780 Offset: 0x1A1D881 VA: 0x1A1D780 Slot: 41
	protected virtual void Update() { }

	// RVA: 0x1A1D2B0 Offset: 0x1A1D3B1 VA: 0x1A1D2B0
	private void UpdateSlaveStatus() { }

	// RVA: 0x1A17B10 Offset: 0x1A17C11 VA: 0x1A17B10
	protected Transform ResolveLookAt(Transform localLookAt) { }

	// RVA: 0x1A17C80 Offset: 0x1A17D81 VA: 0x1A17C80
	protected Transform ResolveFollow(Transform localFollow) { }

	// RVA: 0x1A1D460 Offset: 0x1A1D561 VA: 0x1A1D460
	private void UpdateVcamPoolStatus() { }

	// RVA: 0x1A17AE0 Offset: 0x1A17BE1 VA: 0x1A17AE0
	public void MoveToTopOfPrioritySubqueue() { }

	// RVA: 0x1A1BDE0 Offset: 0x1A1BEE1 VA: 0x1A1BDE0 Slot: 42
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A1C0A0 Offset: 0x1A1C1A1 VA: 0x1A1C0A0 Slot: 43
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A1D7A0 Offset: 0x1A1D8A1 VA: 0x1A1D7A0
	protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend) { }

	// RVA: 0x1A193F0 Offset: 0x1A194F1 VA: 0x1A193F0
	protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens) { }

	// RVA: 0x1A1C850 Offset: 0x1A1C951 VA: 0x1A1C850
	protected void .ctor() { }
}

[SaveDuringPlayAttribute] // RVA: 0x12EE30 Offset: 0x12EF31 VA: 0x12EE30
public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera // TypeDefIndex: 4848
{
	// Fields
	[HideInInspector] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	[SerializeField] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	[NoSaveDuringPlayAttribute] // RVA: 0x134910 Offset: 0x134A11 VA: 0x134910
	public string[] m_ExcludedPropertiesInInspector; // 0x18
	[HideInInspector] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	[SerializeField] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	[NoSaveDuringPlayAttribute] // RVA: 0x134960 Offset: 0x134A61 VA: 0x134960
	public CinemachineCore.Stage[] m_LockStageInInspector; // 0x20
	private int m_ValidatingStreamVersion; // 0x28
	private bool m_OnValidateCalled; // 0x2C
	[HideInInspector] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	[SerializeField] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	[NoSaveDuringPlayAttribute] // RVA: 0x1349B0 Offset: 0x134AB1 VA: 0x1349B0
	private int m_StreamingVersion; // 0x30
	[NoSaveDuringPlayAttribute] // RVA: 0x134A00 Offset: 0x134B01 VA: 0x134A00
	[TooltipAttribute] // RVA: 0x134A00 Offset: 0x134B01 VA: 0x134A00
	public int m_Priority; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x134A50 Offset: 0x134B51 VA: 0x134A50
	private float <FollowTargetAttachment>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x134A60 Offset: 0x134B61 VA: 0x134A60
	private float <LookAtTargetAttachment>k__BackingField; // 0x3C
	[TooltipAttribute] // RVA: 0x134A70 Offset: 0x134B71 VA: 0x134A70
	public CinemachineVirtualCameraBase.StandbyUpdateMode m_StandbyUpdate; // 0x40
	private List<CinemachineExtension> mExtensions; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x134AB0 Offset: 0x134BB1 VA: 0x134AB0
	private bool <PreviousStateIsValid>k__BackingField; // 0x50
	private bool m_WasStarted; // 0x51
	private bool mSlaveStatusUpdated; // 0x52
	private CinemachineVirtualCameraBase m_parentVcam; // 0x58
	private int m_QueuePriority; // 0x60

	// Properties
	public int ValidatingStreamVersion { get; set; }
	public float FollowTargetAttachment { get; set; }
	public float LookAtTargetAttachment { get; set; }
	public string Name { get; }
	public virtual string Description { get; }
	public int Priority { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public abstract CameraState State { get; }
	public ICinemachineCamera ParentCamera { get; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public virtual bool PreviousStateIsValid { get; set; }

	// Methods

	// RVA: 0x1A196D0 Offset: 0x1A197D1 VA: 0x1A196D0
	public int get_ValidatingStreamVersion() { }

	// RVA: 0x1A1CAE0 Offset: 0x1A1CBE1 VA: 0x1A1CAE0
	private void set_ValidatingStreamVersion(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371B0 Offset: 0x1372B1 VA: 0x1371B0
	// RVA: 0x1A1CAF0 Offset: 0x1A1CBF1 VA: 0x1A1CAF0
	public float get_FollowTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x1371C0 Offset: 0x1372C1 VA: 0x1371C0
	// RVA: 0x1A1CB00 Offset: 0x1A1CC01 VA: 0x1A1CB00
	public void set_FollowTargetAttachment(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371D0 Offset: 0x1372D1 VA: 0x1371D0
	// RVA: 0x1A1CB10 Offset: 0x1A1CC11 VA: 0x1A1CB10
	public float get_LookAtTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x1371E0 Offset: 0x1372E1 VA: 0x1371E0
	// RVA: 0x1A1CB20 Offset: 0x1A1CC21 VA: 0x1A1CB20
	public void set_LookAtTargetAttachment(float value) { }

	// RVA: 0x1A17EE0 Offset: 0x1A17FE1 VA: 0x1A17EE0 Slot: 21
	public virtual float GetMaxDampTime() { }

	// RVA: 0x1A16400 Offset: 0x1A16501 VA: 0x1A16400
	public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A16580 Offset: 0x1A16681 VA: 0x1A16580
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A1CB30 Offset: 0x1A1CC31 VA: 0x1A1CB30
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CC10 Offset: 0x1A1CD11 VA: 0x1A1CC10
	public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CD90 Offset: 0x1A1CE91 VA: 0x1A1CD90
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A1CEC0 Offset: 0x1A1CFC1 VA: 0x1A1CEC0
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A1CFA0 Offset: 0x1A1D0A1 VA: 0x1A1CFA0 Slot: 22
	public virtual void AddExtension(CinemachineExtension extension) { }

	// RVA: 0x1A1D060 Offset: 0x1A1D161 VA: 0x1A1D060 Slot: 23
	public virtual void RemoveExtension(CinemachineExtension extension) { }

	// RVA: 0x1A1B990 Offset: 0x1A1BA91 VA: 0x1A1B990
	protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A1B7A0 Offset: 0x1A1B8A1 VA: 0x1A1B7A0
	protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A1C550 Offset: 0x1A1C651 VA: 0x1A1C550
	protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1D120 Offset: 0x1A1D221 VA: 0x1A1D120 Slot: 4
	public string get_Name() { }

	// RVA: 0x1A1D130 Offset: 0x1A1D231 VA: 0x1A1D130 Slot: 24
	public virtual string get_Description() { }

	// RVA: 0x1A1D180 Offset: 0x1A1D281 VA: 0x1A1D180 Slot: 6
	public int get_Priority() { }

	// RVA: 0x1A1D190 Offset: 0x1A1D291 VA: 0x1A1D190 Slot: 7
	public void set_Priority(int value) { }

	// RVA: 0x1A18E60 Offset: 0x1A18F61 VA: 0x1A18E60
	protected void ApplyPositionBlendMethod(ref CameraState state, CinemachineVirtualCameraBase.BlendHint hint) { }

	// RVA: 0x1A1D1A0 Offset: 0x1A1D2A1 VA: 0x1A1D1A0 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0x1A1D230 Offset: 0x1A1D331 VA: 0x1A1D230 Slot: 14
	public bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract CameraState get_State() { }

	// RVA: 0x1A1D0E0 Offset: 0x1A1D1E1 VA: 0x1A1D0E0 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0x1A1D390 Offset: 0x1A1D491 VA: 0x1A1D390 Slot: 26
	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Transform get_LookAt() { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void set_LookAt(Transform value) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract Transform get_Follow() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void set_Follow(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1371F0 Offset: 0x1372F1 VA: 0x1371F0
	// RVA: 0x1A1D3A0 Offset: 0x1A1D4A1 VA: 0x1A1D3A0 Slot: 31
	public virtual bool get_PreviousStateIsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x137200 Offset: 0x137301 VA: 0x137200
	// RVA: 0x1A1D3B0 Offset: 0x1A1D4B1 VA: 0x1A1D3B0 Slot: 32
	public virtual void set_PreviousStateIsValid(bool value) { }

	// RVA: 0x1A1C6D0 Offset: 0x1A1C7D1 VA: 0x1A1C6D0 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1C4F0 Offset: 0x1A1C5F1 VA: 0x1A1C4F0 Slot: 34
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A19B90 Offset: 0x1A19C91 VA: 0x1A19B90 Slot: 35
	protected virtual void OnDestroy() { }

	// RVA: 0x1A1D3C0 Offset: 0x1A1D4C1 VA: 0x1A1D3C0 Slot: 36
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x1A1D570 Offset: 0x1A1D671 VA: 0x1A1D570 Slot: 37
	protected virtual void Start() { }

	// RVA: 0x1A1D580 Offset: 0x1A1D681 VA: 0x1A1D580
	internal void EnsureStarted() { }

	// RVA: 0x1A1D640 Offset: 0x1A1D741 VA: 0x1A1D640
	public AxisState.IInputAxisProvider GetInputAxisProvider() { }

	// RVA: 0x1A19CB0 Offset: 0x1A19DB1 VA: 0x1A19CB0 Slot: 38
	protected virtual void OnValidate() { }

	// RVA: 0x1A191C0 Offset: 0x1A192C1 VA: 0x1A191C0 Slot: 39
	protected virtual void OnEnable() { }

	// RVA: 0x1A1D700 Offset: 0x1A1D801 VA: 0x1A1D700 Slot: 40
	protected virtual void OnDisable() { }

	// RVA: 0x1A1D780 Offset: 0x1A1D881 VA: 0x1A1D780 Slot: 41
	protected virtual void Update() { }

	// RVA: 0x1A1D2B0 Offset: 0x1A1D3B1 VA: 0x1A1D2B0
	private void UpdateSlaveStatus() { }

	// RVA: 0x1A17B10 Offset: 0x1A17C11 VA: 0x1A17B10
	protected Transform ResolveLookAt(Transform localLookAt) { }

	// RVA: 0x1A17C80 Offset: 0x1A17D81 VA: 0x1A17C80
	protected Transform ResolveFollow(Transform localFollow) { }

	// RVA: 0x1A1D460 Offset: 0x1A1D561 VA: 0x1A1D460
	private void UpdateVcamPoolStatus() { }

	// RVA: 0x1A17AE0 Offset: 0x1A17BE1 VA: 0x1A17AE0
	public void MoveToTopOfPrioritySubqueue() { }

	// RVA: 0x1A1BDE0 Offset: 0x1A1BEE1 VA: 0x1A1BDE0 Slot: 42
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A1C0A0 Offset: 0x1A1C1A1 VA: 0x1A1C0A0 Slot: 43
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A1D7A0 Offset: 0x1A1D8A1 VA: 0x1A1D7A0
	protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend) { }

	// RVA: 0x1A193F0 Offset: 0x1A194F1 VA: 0x1A193F0
	protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens) { }

	// RVA: 0x1A1C850 Offset: 0x1A1C951 VA: 0x1A1C850
	protected void .ctor() { }
}

