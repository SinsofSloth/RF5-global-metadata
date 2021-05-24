[DocumentationSortingAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[DisallowMultipleComponent] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[ExecuteAlways] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[ExcludeFromPresetAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[AddComponentMenu] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[HelpURLAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4778
{
	// Fields
	[TooltipAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	[NoSaveDuringPlayAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	[VcamTargetPropertyAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	public Transform m_LookAt; // 0x68
	[TooltipAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	[NoSaveDuringPlayAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	[VcamTargetPropertyAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	public Transform m_Follow; // 0x70
	[FormerlySerializedAsAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	[TooltipAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	[LensSettingsPropertyAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	public LensSettings m_Lens; // 0x78
	public CinemachineVirtualCameraBase.TransitionParams m_Transitions; // 0xA8
	[SerializeField] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[HideInInspector] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[FormerlySerializedAsAttribute] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[FormerlySerializedAsAttribute] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint; // 0xB8
	public const string PipelineName = "cm";
	public static CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride; // 0x0
	public static CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x131CD0 Offset: 0x131DD1 VA: 0x131CD0
	private bool <UserIsDragging>k__BackingField; // 0xBC
	private CameraState m_State; // 0xC0
	private CinemachineComponentBase[] m_ComponentPipeline; // 0x1A0
	[SerializeField] // RVA: 0x131CE0 Offset: 0x131DE1 VA: 0x131CE0
	[HideInInspector] // RVA: 0x131CE0 Offset: 0x131DE1 VA: 0x131CE0
	private Transform m_ComponentOwner; // 0x1A8
	private Transform mCachedLookAtTarget; // 0x1B0
	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x1B8

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public bool UserIsDragging { get; set; }

	// Methods

	// RVA: 0x1A17AF0 Offset: 0x1A17BF1 VA: 0x1A17AF0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1A17B00 Offset: 0x1A17C01 VA: 0x1A17B00 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1A17C60 Offset: 0x1A17D61 VA: 0x1A17C60 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1A17C70 Offset: 0x1A17D71 VA: 0x1A17C70 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1A17DD0 Offset: 0x1A17ED1 VA: 0x1A17DD0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1A17DE0 Offset: 0x1A17EE1 VA: 0x1A17DE0 Slot: 21
	public override float GetMaxDampTime() { }

	// RVA: 0x1A186B0 Offset: 0x1A187B1 VA: 0x1A186B0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A18E90 Offset: 0x1A18F91 VA: 0x1A18E90 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x1A19800 Offset: 0x1A19901 VA: 0x1A19800 Slot: 35
	protected override void OnDestroy() { }

	// RVA: 0x1A19C10 Offset: 0x1A19D11 VA: 0x1A19C10 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x1A19E10 Offset: 0x1A19F11 VA: 0x1A19E10
	private void OnTransformChildrenChanged() { }

	// RVA: 0x1A19E30 Offset: 0x1A19F31 VA: 0x1A19E30
	private void Reset() { }

	// RVA: 0x1A19E40 Offset: 0x1A19F41 VA: 0x1A19E40
	private void DestroyPipeline() { }

	// RVA: 0x1A1A900 Offset: 0x1A1AA01 VA: 0x1A1A900
	private Transform CreatePipeline(CinemachineVirtualCamera copyFrom) { }

	// RVA: 0x1A196B0 Offset: 0x1A197B1 VA: 0x1A196B0
	public void InvalidateComponentPipeline() { }

	// RVA: 0x1A1AF00 Offset: 0x1A1B001 VA: 0x1A1AF00
	public Transform GetComponentOwner() { }

	// RVA: 0x1A1AA80 Offset: 0x1A1AB81 VA: 0x1A1AA80
	public CinemachineComponentBase[] GetComponentPipeline() { }

	// RVA: 0x1A19760 Offset: 0x1A19861 VA: 0x1A19760
	public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage) { }

	// RVA: -1 Offset: -1
	public T GetCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEC30 Offset: 0x23BED31 VA: 0x23BEC30
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineComposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public T AddCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEA60 Offset: 0x23BEB61 VA: 0x23BEA60
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLockToTarget>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLookAt>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.AddCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public void DestroyCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CECF0 Offset: 0x21CEDF1 VA: 0x21CECF0
	|-CinemachineVirtualCamera.DestroyCinemachineComponent<object>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x136C60 Offset: 0x136D61 VA: 0x136C60
	// RVA: 0x1A1AF30 Offset: 0x1A1B031 VA: 0x1A1AF30
	public bool get_UserIsDragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x136C70 Offset: 0x136D71 VA: 0x136C70
	// RVA: 0x1A1AF40 Offset: 0x1A1B041 VA: 0x1A1AF40
	public void set_UserIsDragging(bool value) { }

	// RVA: 0x1A17FD0 Offset: 0x1A180D1 VA: 0x1A17FD0
	private void UpdateComponentPipeline() { }

	// RVA: 0x1A1AF50 Offset: 0x1A1B051 VA: 0x1A1AF50
	internal static void SetFlagsForHiddenChild(GameObject child) { }

	// RVA: 0x1A188C0 Offset: 0x1A189C1 VA: 0x1A188C0
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1BB90 Offset: 0x1A1BC91 VA: 0x1A1BB90 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A1BEB0 Offset: 0x1A1BFB1 VA: 0x1A1BEB0 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A1C1A0 Offset: 0x1A1C2A1 VA: 0x1A1C1A0
	internal void SetStateRawPosition(Vector3 pos) { }

	// RVA: 0x1A1C1B0 Offset: 0x1A1C2B1 VA: 0x1A1C1B0 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1C780 Offset: 0x1A1C881 VA: 0x1A1C780
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[DisallowMultipleComponent] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[ExecuteAlways] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[ExcludeFromPresetAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[AddComponentMenu] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[HelpURLAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4778
{
	// Fields
	[TooltipAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	[NoSaveDuringPlayAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	[VcamTargetPropertyAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	public Transform m_LookAt; // 0x68
	[TooltipAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	[NoSaveDuringPlayAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	[VcamTargetPropertyAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	public Transform m_Follow; // 0x70
	[FormerlySerializedAsAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	[TooltipAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	[LensSettingsPropertyAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	public LensSettings m_Lens; // 0x78
	public CinemachineVirtualCameraBase.TransitionParams m_Transitions; // 0xA8
	[SerializeField] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[HideInInspector] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[FormerlySerializedAsAttribute] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[FormerlySerializedAsAttribute] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint; // 0xB8
	public const string PipelineName = "cm";
	public static CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride; // 0x0
	public static CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x131CD0 Offset: 0x131DD1 VA: 0x131CD0
	private bool <UserIsDragging>k__BackingField; // 0xBC
	private CameraState m_State; // 0xC0
	private CinemachineComponentBase[] m_ComponentPipeline; // 0x1A0
	[SerializeField] // RVA: 0x131CE0 Offset: 0x131DE1 VA: 0x131CE0
	[HideInInspector] // RVA: 0x131CE0 Offset: 0x131DE1 VA: 0x131CE0
	private Transform m_ComponentOwner; // 0x1A8
	private Transform mCachedLookAtTarget; // 0x1B0
	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x1B8

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public bool UserIsDragging { get; set; }

	// Methods

	// RVA: 0x1A17AF0 Offset: 0x1A17BF1 VA: 0x1A17AF0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1A17B00 Offset: 0x1A17C01 VA: 0x1A17B00 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1A17C60 Offset: 0x1A17D61 VA: 0x1A17C60 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1A17C70 Offset: 0x1A17D71 VA: 0x1A17C70 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1A17DD0 Offset: 0x1A17ED1 VA: 0x1A17DD0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1A17DE0 Offset: 0x1A17EE1 VA: 0x1A17DE0 Slot: 21
	public override float GetMaxDampTime() { }

	// RVA: 0x1A186B0 Offset: 0x1A187B1 VA: 0x1A186B0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A18E90 Offset: 0x1A18F91 VA: 0x1A18E90 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x1A19800 Offset: 0x1A19901 VA: 0x1A19800 Slot: 35
	protected override void OnDestroy() { }

	// RVA: 0x1A19C10 Offset: 0x1A19D11 VA: 0x1A19C10 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x1A19E10 Offset: 0x1A19F11 VA: 0x1A19E10
	private void OnTransformChildrenChanged() { }

	// RVA: 0x1A19E30 Offset: 0x1A19F31 VA: 0x1A19E30
	private void Reset() { }

	// RVA: 0x1A19E40 Offset: 0x1A19F41 VA: 0x1A19E40
	private void DestroyPipeline() { }

	// RVA: 0x1A1A900 Offset: 0x1A1AA01 VA: 0x1A1A900
	private Transform CreatePipeline(CinemachineVirtualCamera copyFrom) { }

	// RVA: 0x1A196B0 Offset: 0x1A197B1 VA: 0x1A196B0
	public void InvalidateComponentPipeline() { }

	// RVA: 0x1A1AF00 Offset: 0x1A1B001 VA: 0x1A1AF00
	public Transform GetComponentOwner() { }

	// RVA: 0x1A1AA80 Offset: 0x1A1AB81 VA: 0x1A1AA80
	public CinemachineComponentBase[] GetComponentPipeline() { }

	// RVA: 0x1A19760 Offset: 0x1A19861 VA: 0x1A19760
	public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage) { }

	// RVA: -1 Offset: -1
	public T GetCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEC30 Offset: 0x23BED31 VA: 0x23BEC30
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineComposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public T AddCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEA60 Offset: 0x23BEB61 VA: 0x23BEA60
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLockToTarget>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLookAt>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.AddCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public void DestroyCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CECF0 Offset: 0x21CEDF1 VA: 0x21CECF0
	|-CinemachineVirtualCamera.DestroyCinemachineComponent<object>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x136C60 Offset: 0x136D61 VA: 0x136C60
	// RVA: 0x1A1AF30 Offset: 0x1A1B031 VA: 0x1A1AF30
	public bool get_UserIsDragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x136C70 Offset: 0x136D71 VA: 0x136C70
	// RVA: 0x1A1AF40 Offset: 0x1A1B041 VA: 0x1A1AF40
	public void set_UserIsDragging(bool value) { }

	// RVA: 0x1A17FD0 Offset: 0x1A180D1 VA: 0x1A17FD0
	private void UpdateComponentPipeline() { }

	// RVA: 0x1A1AF50 Offset: 0x1A1B051 VA: 0x1A1AF50
	internal static void SetFlagsForHiddenChild(GameObject child) { }

	// RVA: 0x1A188C0 Offset: 0x1A189C1 VA: 0x1A188C0
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1BB90 Offset: 0x1A1BC91 VA: 0x1A1BB90 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A1BEB0 Offset: 0x1A1BFB1 VA: 0x1A1BEB0 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A1C1A0 Offset: 0x1A1C2A1 VA: 0x1A1C1A0
	internal void SetStateRawPosition(Vector3 pos) { }

	// RVA: 0x1A1C1B0 Offset: 0x1A1C2B1 VA: 0x1A1C1B0 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1C780 Offset: 0x1A1C881 VA: 0x1A1C780
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[DisallowMultipleComponent] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[ExecuteAlways] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[ExcludeFromPresetAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[AddComponentMenu] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[HelpURLAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4778
{
	// Fields
	[TooltipAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	[NoSaveDuringPlayAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	[VcamTargetPropertyAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	public Transform m_LookAt; // 0x68
	[TooltipAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	[NoSaveDuringPlayAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	[VcamTargetPropertyAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	public Transform m_Follow; // 0x70
	[FormerlySerializedAsAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	[TooltipAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	[LensSettingsPropertyAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	public LensSettings m_Lens; // 0x78
	public CinemachineVirtualCameraBase.TransitionParams m_Transitions; // 0xA8
	[SerializeField] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[HideInInspector] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[FormerlySerializedAsAttribute] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[FormerlySerializedAsAttribute] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint; // 0xB8
	public const string PipelineName = "cm";
	public static CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride; // 0x0
	public static CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x131CD0 Offset: 0x131DD1 VA: 0x131CD0
	private bool <UserIsDragging>k__BackingField; // 0xBC
	private CameraState m_State; // 0xC0
	private CinemachineComponentBase[] m_ComponentPipeline; // 0x1A0
	[SerializeField] // RVA: 0x131CE0 Offset: 0x131DE1 VA: 0x131CE0
	[HideInInspector] // RVA: 0x131CE0 Offset: 0x131DE1 VA: 0x131CE0
	private Transform m_ComponentOwner; // 0x1A8
	private Transform mCachedLookAtTarget; // 0x1B0
	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x1B8

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public bool UserIsDragging { get; set; }

	// Methods

	// RVA: 0x1A17AF0 Offset: 0x1A17BF1 VA: 0x1A17AF0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1A17B00 Offset: 0x1A17C01 VA: 0x1A17B00 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1A17C60 Offset: 0x1A17D61 VA: 0x1A17C60 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1A17C70 Offset: 0x1A17D71 VA: 0x1A17C70 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1A17DD0 Offset: 0x1A17ED1 VA: 0x1A17DD0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1A17DE0 Offset: 0x1A17EE1 VA: 0x1A17DE0 Slot: 21
	public override float GetMaxDampTime() { }

	// RVA: 0x1A186B0 Offset: 0x1A187B1 VA: 0x1A186B0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A18E90 Offset: 0x1A18F91 VA: 0x1A18E90 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x1A19800 Offset: 0x1A19901 VA: 0x1A19800 Slot: 35
	protected override void OnDestroy() { }

	// RVA: 0x1A19C10 Offset: 0x1A19D11 VA: 0x1A19C10 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x1A19E10 Offset: 0x1A19F11 VA: 0x1A19E10
	private void OnTransformChildrenChanged() { }

	// RVA: 0x1A19E30 Offset: 0x1A19F31 VA: 0x1A19E30
	private void Reset() { }

	// RVA: 0x1A19E40 Offset: 0x1A19F41 VA: 0x1A19E40
	private void DestroyPipeline() { }

	// RVA: 0x1A1A900 Offset: 0x1A1AA01 VA: 0x1A1A900
	private Transform CreatePipeline(CinemachineVirtualCamera copyFrom) { }

	// RVA: 0x1A196B0 Offset: 0x1A197B1 VA: 0x1A196B0
	public void InvalidateComponentPipeline() { }

	// RVA: 0x1A1AF00 Offset: 0x1A1B001 VA: 0x1A1AF00
	public Transform GetComponentOwner() { }

	// RVA: 0x1A1AA80 Offset: 0x1A1AB81 VA: 0x1A1AA80
	public CinemachineComponentBase[] GetComponentPipeline() { }

	// RVA: 0x1A19760 Offset: 0x1A19861 VA: 0x1A19760
	public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage) { }

	// RVA: -1 Offset: -1
	public T GetCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEC30 Offset: 0x23BED31 VA: 0x23BEC30
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineComposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public T AddCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEA60 Offset: 0x23BEB61 VA: 0x23BEA60
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLockToTarget>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLookAt>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.AddCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public void DestroyCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CECF0 Offset: 0x21CEDF1 VA: 0x21CECF0
	|-CinemachineVirtualCamera.DestroyCinemachineComponent<object>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x136C60 Offset: 0x136D61 VA: 0x136C60
	// RVA: 0x1A1AF30 Offset: 0x1A1B031 VA: 0x1A1AF30
	public bool get_UserIsDragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x136C70 Offset: 0x136D71 VA: 0x136C70
	// RVA: 0x1A1AF40 Offset: 0x1A1B041 VA: 0x1A1AF40
	public void set_UserIsDragging(bool value) { }

	// RVA: 0x1A17FD0 Offset: 0x1A180D1 VA: 0x1A17FD0
	private void UpdateComponentPipeline() { }

	// RVA: 0x1A1AF50 Offset: 0x1A1B051 VA: 0x1A1AF50
	internal static void SetFlagsForHiddenChild(GameObject child) { }

	// RVA: 0x1A188C0 Offset: 0x1A189C1 VA: 0x1A188C0
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1BB90 Offset: 0x1A1BC91 VA: 0x1A1BB90 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A1BEB0 Offset: 0x1A1BFB1 VA: 0x1A1BEB0 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A1C1A0 Offset: 0x1A1C2A1 VA: 0x1A1C1A0
	internal void SetStateRawPosition(Vector3 pos) { }

	// RVA: 0x1A1C1B0 Offset: 0x1A1C2B1 VA: 0x1A1C1B0 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1C780 Offset: 0x1A1C881 VA: 0x1A1C780
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[DisallowMultipleComponent] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[ExecuteAlways] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[ExcludeFromPresetAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[AddComponentMenu] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[HelpURLAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4778
{
	// Fields
	[TooltipAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	[NoSaveDuringPlayAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	[VcamTargetPropertyAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	public Transform m_LookAt; // 0x68
	[TooltipAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	[NoSaveDuringPlayAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	[VcamTargetPropertyAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	public Transform m_Follow; // 0x70
	[FormerlySerializedAsAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	[TooltipAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	[LensSettingsPropertyAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	public LensSettings m_Lens; // 0x78
	public CinemachineVirtualCameraBase.TransitionParams m_Transitions; // 0xA8
	[SerializeField] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[HideInInspector] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[FormerlySerializedAsAttribute] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[FormerlySerializedAsAttribute] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint; // 0xB8
	public const string PipelineName = "cm";
	public static CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride; // 0x0
	public static CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x131CD0 Offset: 0x131DD1 VA: 0x131CD0
	private bool <UserIsDragging>k__BackingField; // 0xBC
	private CameraState m_State; // 0xC0
	private CinemachineComponentBase[] m_ComponentPipeline; // 0x1A0
	[SerializeField] // RVA: 0x131CE0 Offset: 0x131DE1 VA: 0x131CE0
	[HideInInspector] // RVA: 0x131CE0 Offset: 0x131DE1 VA: 0x131CE0
	private Transform m_ComponentOwner; // 0x1A8
	private Transform mCachedLookAtTarget; // 0x1B0
	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x1B8

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public bool UserIsDragging { get; set; }

	// Methods

	// RVA: 0x1A17AF0 Offset: 0x1A17BF1 VA: 0x1A17AF0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1A17B00 Offset: 0x1A17C01 VA: 0x1A17B00 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1A17C60 Offset: 0x1A17D61 VA: 0x1A17C60 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1A17C70 Offset: 0x1A17D71 VA: 0x1A17C70 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1A17DD0 Offset: 0x1A17ED1 VA: 0x1A17DD0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1A17DE0 Offset: 0x1A17EE1 VA: 0x1A17DE0 Slot: 21
	public override float GetMaxDampTime() { }

	// RVA: 0x1A186B0 Offset: 0x1A187B1 VA: 0x1A186B0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A18E90 Offset: 0x1A18F91 VA: 0x1A18E90 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x1A19800 Offset: 0x1A19901 VA: 0x1A19800 Slot: 35
	protected override void OnDestroy() { }

	// RVA: 0x1A19C10 Offset: 0x1A19D11 VA: 0x1A19C10 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x1A19E10 Offset: 0x1A19F11 VA: 0x1A19E10
	private void OnTransformChildrenChanged() { }

	// RVA: 0x1A19E30 Offset: 0x1A19F31 VA: 0x1A19E30
	private void Reset() { }

	// RVA: 0x1A19E40 Offset: 0x1A19F41 VA: 0x1A19E40
	private void DestroyPipeline() { }

	// RVA: 0x1A1A900 Offset: 0x1A1AA01 VA: 0x1A1A900
	private Transform CreatePipeline(CinemachineVirtualCamera copyFrom) { }

	// RVA: 0x1A196B0 Offset: 0x1A197B1 VA: 0x1A196B0
	public void InvalidateComponentPipeline() { }

	// RVA: 0x1A1AF00 Offset: 0x1A1B001 VA: 0x1A1AF00
	public Transform GetComponentOwner() { }

	// RVA: 0x1A1AA80 Offset: 0x1A1AB81 VA: 0x1A1AA80
	public CinemachineComponentBase[] GetComponentPipeline() { }

	// RVA: 0x1A19760 Offset: 0x1A19861 VA: 0x1A19760
	public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage) { }

	// RVA: -1 Offset: -1
	public T GetCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEC30 Offset: 0x23BED31 VA: 0x23BEC30
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineComposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public T AddCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEA60 Offset: 0x23BEB61 VA: 0x23BEA60
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLockToTarget>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLookAt>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.AddCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public void DestroyCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CECF0 Offset: 0x21CEDF1 VA: 0x21CECF0
	|-CinemachineVirtualCamera.DestroyCinemachineComponent<object>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x136C60 Offset: 0x136D61 VA: 0x136C60
	// RVA: 0x1A1AF30 Offset: 0x1A1B031 VA: 0x1A1AF30
	public bool get_UserIsDragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x136C70 Offset: 0x136D71 VA: 0x136C70
	// RVA: 0x1A1AF40 Offset: 0x1A1B041 VA: 0x1A1AF40
	public void set_UserIsDragging(bool value) { }

	// RVA: 0x1A17FD0 Offset: 0x1A180D1 VA: 0x1A17FD0
	private void UpdateComponentPipeline() { }

	// RVA: 0x1A1AF50 Offset: 0x1A1B051 VA: 0x1A1AF50
	internal static void SetFlagsForHiddenChild(GameObject child) { }

	// RVA: 0x1A188C0 Offset: 0x1A189C1 VA: 0x1A188C0
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1BB90 Offset: 0x1A1BC91 VA: 0x1A1BB90 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A1BEB0 Offset: 0x1A1BFB1 VA: 0x1A1BEB0 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A1C1A0 Offset: 0x1A1C2A1 VA: 0x1A1C1A0
	internal void SetStateRawPosition(Vector3 pos) { }

	// RVA: 0x1A1C1B0 Offset: 0x1A1C2B1 VA: 0x1A1C1B0 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1C780 Offset: 0x1A1C881 VA: 0x1A1C780
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[DisallowMultipleComponent] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[ExecuteAlways] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[ExcludeFromPresetAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[AddComponentMenu] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[HelpURLAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4778
{
	// Fields
	[TooltipAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	[NoSaveDuringPlayAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	[VcamTargetPropertyAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	public Transform m_LookAt; // 0x68
	[TooltipAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	[NoSaveDuringPlayAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	[VcamTargetPropertyAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	public Transform m_Follow; // 0x70
	[FormerlySerializedAsAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	[TooltipAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	[LensSettingsPropertyAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	public LensSettings m_Lens; // 0x78
	public CinemachineVirtualCameraBase.TransitionParams m_Transitions; // 0xA8
	[SerializeField] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[HideInInspector] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[FormerlySerializedAsAttribute] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[FormerlySerializedAsAttribute] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint; // 0xB8
	public const string PipelineName = "cm";
	public static CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride; // 0x0
	public static CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x131CD0 Offset: 0x131DD1 VA: 0x131CD0
	private bool <UserIsDragging>k__BackingField; // 0xBC
	private CameraState m_State; // 0xC0
	private CinemachineComponentBase[] m_ComponentPipeline; // 0x1A0
	[SerializeField] // RVA: 0x131CE0 Offset: 0x131DE1 VA: 0x131CE0
	[HideInInspector] // RVA: 0x131CE0 Offset: 0x131DE1 VA: 0x131CE0
	private Transform m_ComponentOwner; // 0x1A8
	private Transform mCachedLookAtTarget; // 0x1B0
	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x1B8

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public bool UserIsDragging { get; set; }

	// Methods

	// RVA: 0x1A17AF0 Offset: 0x1A17BF1 VA: 0x1A17AF0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1A17B00 Offset: 0x1A17C01 VA: 0x1A17B00 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1A17C60 Offset: 0x1A17D61 VA: 0x1A17C60 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1A17C70 Offset: 0x1A17D71 VA: 0x1A17C70 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1A17DD0 Offset: 0x1A17ED1 VA: 0x1A17DD0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1A17DE0 Offset: 0x1A17EE1 VA: 0x1A17DE0 Slot: 21
	public override float GetMaxDampTime() { }

	// RVA: 0x1A186B0 Offset: 0x1A187B1 VA: 0x1A186B0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A18E90 Offset: 0x1A18F91 VA: 0x1A18E90 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x1A19800 Offset: 0x1A19901 VA: 0x1A19800 Slot: 35
	protected override void OnDestroy() { }

	// RVA: 0x1A19C10 Offset: 0x1A19D11 VA: 0x1A19C10 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x1A19E10 Offset: 0x1A19F11 VA: 0x1A19E10
	private void OnTransformChildrenChanged() { }

	// RVA: 0x1A19E30 Offset: 0x1A19F31 VA: 0x1A19E30
	private void Reset() { }

	// RVA: 0x1A19E40 Offset: 0x1A19F41 VA: 0x1A19E40
	private void DestroyPipeline() { }

	// RVA: 0x1A1A900 Offset: 0x1A1AA01 VA: 0x1A1A900
	private Transform CreatePipeline(CinemachineVirtualCamera copyFrom) { }

	// RVA: 0x1A196B0 Offset: 0x1A197B1 VA: 0x1A196B0
	public void InvalidateComponentPipeline() { }

	// RVA: 0x1A1AF00 Offset: 0x1A1B001 VA: 0x1A1AF00
	public Transform GetComponentOwner() { }

	// RVA: 0x1A1AA80 Offset: 0x1A1AB81 VA: 0x1A1AA80
	public CinemachineComponentBase[] GetComponentPipeline() { }

	// RVA: 0x1A19760 Offset: 0x1A19861 VA: 0x1A19760
	public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage) { }

	// RVA: -1 Offset: -1
	public T GetCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEC30 Offset: 0x23BED31 VA: 0x23BEC30
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineComposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public T AddCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEA60 Offset: 0x23BEB61 VA: 0x23BEA60
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLockToTarget>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLookAt>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.AddCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public void DestroyCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CECF0 Offset: 0x21CEDF1 VA: 0x21CECF0
	|-CinemachineVirtualCamera.DestroyCinemachineComponent<object>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x136C60 Offset: 0x136D61 VA: 0x136C60
	// RVA: 0x1A1AF30 Offset: 0x1A1B031 VA: 0x1A1AF30
	public bool get_UserIsDragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x136C70 Offset: 0x136D71 VA: 0x136C70
	// RVA: 0x1A1AF40 Offset: 0x1A1B041 VA: 0x1A1AF40
	public void set_UserIsDragging(bool value) { }

	// RVA: 0x1A17FD0 Offset: 0x1A180D1 VA: 0x1A17FD0
	private void UpdateComponentPipeline() { }

	// RVA: 0x1A1AF50 Offset: 0x1A1B051 VA: 0x1A1AF50
	internal static void SetFlagsForHiddenChild(GameObject child) { }

	// RVA: 0x1A188C0 Offset: 0x1A189C1 VA: 0x1A188C0
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1BB90 Offset: 0x1A1BC91 VA: 0x1A1BB90 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A1BEB0 Offset: 0x1A1BFB1 VA: 0x1A1BEB0 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A1C1A0 Offset: 0x1A1C2A1 VA: 0x1A1C1A0
	internal void SetStateRawPosition(Vector3 pos) { }

	// RVA: 0x1A1C1B0 Offset: 0x1A1C2B1 VA: 0x1A1C1B0 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1C780 Offset: 0x1A1C881 VA: 0x1A1C780
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[DisallowMultipleComponent] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[ExecuteAlways] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[ExcludeFromPresetAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[AddComponentMenu] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
[HelpURLAttribute] // RVA: 0x12E820 Offset: 0x12E921 VA: 0x12E820
public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4778
{
	// Fields
	[TooltipAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	[NoSaveDuringPlayAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	[VcamTargetPropertyAttribute] // RVA: 0x131B20 Offset: 0x131C21 VA: 0x131B20
	public Transform m_LookAt; // 0x68
	[TooltipAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	[NoSaveDuringPlayAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	[VcamTargetPropertyAttribute] // RVA: 0x131B80 Offset: 0x131C81 VA: 0x131B80
	public Transform m_Follow; // 0x70
	[FormerlySerializedAsAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	[TooltipAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	[LensSettingsPropertyAttribute] // RVA: 0x131BE0 Offset: 0x131CE1 VA: 0x131BE0
	public LensSettings m_Lens; // 0x78
	public CinemachineVirtualCameraBase.TransitionParams m_Transitions; // 0xA8
	[SerializeField] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[HideInInspector] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[FormerlySerializedAsAttribute] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	[FormerlySerializedAsAttribute] // RVA: 0x131C50 Offset: 0x131D51 VA: 0x131C50
	private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint; // 0xB8
	public const string PipelineName = "cm";
	public static CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride; // 0x0
	public static CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x131CD0 Offset: 0x131DD1 VA: 0x131CD0
	private bool <UserIsDragging>k__BackingField; // 0xBC
	private CameraState m_State; // 0xC0
	private CinemachineComponentBase[] m_ComponentPipeline; // 0x1A0
	[SerializeField] // RVA: 0x131CE0 Offset: 0x131DE1 VA: 0x131CE0
	[HideInInspector] // RVA: 0x131CE0 Offset: 0x131DE1 VA: 0x131CE0
	private Transform m_ComponentOwner; // 0x1A8
	private Transform mCachedLookAtTarget; // 0x1B0
	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x1B8

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public bool UserIsDragging { get; set; }

	// Methods

	// RVA: 0x1A17AF0 Offset: 0x1A17BF1 VA: 0x1A17AF0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1A17B00 Offset: 0x1A17C01 VA: 0x1A17B00 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1A17C60 Offset: 0x1A17D61 VA: 0x1A17C60 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1A17C70 Offset: 0x1A17D71 VA: 0x1A17C70 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1A17DD0 Offset: 0x1A17ED1 VA: 0x1A17DD0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1A17DE0 Offset: 0x1A17EE1 VA: 0x1A17DE0 Slot: 21
	public override float GetMaxDampTime() { }

	// RVA: 0x1A186B0 Offset: 0x1A187B1 VA: 0x1A186B0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A18E90 Offset: 0x1A18F91 VA: 0x1A18E90 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x1A19800 Offset: 0x1A19901 VA: 0x1A19800 Slot: 35
	protected override void OnDestroy() { }

	// RVA: 0x1A19C10 Offset: 0x1A19D11 VA: 0x1A19C10 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x1A19E10 Offset: 0x1A19F11 VA: 0x1A19E10
	private void OnTransformChildrenChanged() { }

	// RVA: 0x1A19E30 Offset: 0x1A19F31 VA: 0x1A19E30
	private void Reset() { }

	// RVA: 0x1A19E40 Offset: 0x1A19F41 VA: 0x1A19E40
	private void DestroyPipeline() { }

	// RVA: 0x1A1A900 Offset: 0x1A1AA01 VA: 0x1A1A900
	private Transform CreatePipeline(CinemachineVirtualCamera copyFrom) { }

	// RVA: 0x1A196B0 Offset: 0x1A197B1 VA: 0x1A196B0
	public void InvalidateComponentPipeline() { }

	// RVA: 0x1A1AF00 Offset: 0x1A1B001 VA: 0x1A1AF00
	public Transform GetComponentOwner() { }

	// RVA: 0x1A1AA80 Offset: 0x1A1AB81 VA: 0x1A1AA80
	public CinemachineComponentBase[] GetComponentPipeline() { }

	// RVA: 0x1A19760 Offset: 0x1A19861 VA: 0x1A19760
	public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage) { }

	// RVA: -1 Offset: -1
	public T GetCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEC30 Offset: 0x23BED31 VA: 0x23BEC30
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineComposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public T AddCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEA60 Offset: 0x23BEB61 VA: 0x23BEA60
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLockToTarget>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLookAt>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.AddCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public void DestroyCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CECF0 Offset: 0x21CEDF1 VA: 0x21CECF0
	|-CinemachineVirtualCamera.DestroyCinemachineComponent<object>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x136C60 Offset: 0x136D61 VA: 0x136C60
	// RVA: 0x1A1AF30 Offset: 0x1A1B031 VA: 0x1A1AF30
	public bool get_UserIsDragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x136C70 Offset: 0x136D71 VA: 0x136C70
	// RVA: 0x1A1AF40 Offset: 0x1A1B041 VA: 0x1A1AF40
	public void set_UserIsDragging(bool value) { }

	// RVA: 0x1A17FD0 Offset: 0x1A180D1 VA: 0x1A17FD0
	private void UpdateComponentPipeline() { }

	// RVA: 0x1A1AF50 Offset: 0x1A1B051 VA: 0x1A1AF50
	internal static void SetFlagsForHiddenChild(GameObject child) { }

	// RVA: 0x1A188C0 Offset: 0x1A189C1 VA: 0x1A188C0
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1BB90 Offset: 0x1A1BC91 VA: 0x1A1BB90 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A1BEB0 Offset: 0x1A1BFB1 VA: 0x1A1BEB0 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A1C1A0 Offset: 0x1A1C2A1 VA: 0x1A1C1A0
	internal void SetStateRawPosition(Vector3 pos) { }

	// RVA: 0x1A1C1B0 Offset: 0x1A1C2B1 VA: 0x1A1C1B0 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1C780 Offset: 0x1A1C881 VA: 0x1A1C780
	public void .ctor() { }
}

