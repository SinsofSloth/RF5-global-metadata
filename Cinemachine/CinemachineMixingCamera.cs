[DocumentationSortingAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[DisallowMultipleComponent] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[ExecuteAlways] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[ExcludeFromPresetAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[AddComponentMenu] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[HelpURLAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4758
{
	// Fields
	public const int MaxCameras = 8;
	[TooltipAttribute] // RVA: 0x1310A0 Offset: 0x1311A1 VA: 0x1310A0
	public float m_Weight0; // 0x64
	[TooltipAttribute] // RVA: 0x1310E0 Offset: 0x1311E1 VA: 0x1310E0
	public float m_Weight1; // 0x68
	[TooltipAttribute] // RVA: 0x131120 Offset: 0x131221 VA: 0x131120
	public float m_Weight2; // 0x6C
	[TooltipAttribute] // RVA: 0x131160 Offset: 0x131261 VA: 0x131160
	public float m_Weight3; // 0x70
	[TooltipAttribute] // RVA: 0x1311A0 Offset: 0x1312A1 VA: 0x1311A0
	public float m_Weight4; // 0x74
	[TooltipAttribute] // RVA: 0x1311E0 Offset: 0x1312E1 VA: 0x1311E0
	public float m_Weight5; // 0x78
	[TooltipAttribute] // RVA: 0x131220 Offset: 0x131321 VA: 0x131220
	public float m_Weight6; // 0x7C
	[TooltipAttribute] // RVA: 0x131260 Offset: 0x131361 VA: 0x131260
	public float m_Weight7; // 0x80
	private CameraState m_State; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x1312A0 Offset: 0x1313A1 VA: 0x1312A0
	private ICinemachineCamera <LiveChild>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x1312B0 Offset: 0x1313B1 VA: 0x1312B0
	private Transform <LookAt>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x1312C0 Offset: 0x1313C1 VA: 0x1312C0
	private Transform <Follow>k__BackingField; // 0x178
	private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x180
	private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x188

	// Properties
	private ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }

	// Methods

	// RVA: 0x172E500 Offset: 0x172E601 VA: 0x172E500
	public float GetWeight(int index) { }

	// RVA: 0x172E680 Offset: 0x172E781 VA: 0x172E680
	public void SetWeight(int index, float w) { }

	// RVA: 0x172E7B0 Offset: 0x172E8B1 VA: 0x172E7B0
	public float GetWeight(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x172EB90 Offset: 0x172EC91 VA: 0x172EB90
	public void SetWeight(CinemachineVirtualCameraBase vcam, float w) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B90 Offset: 0x136C91 VA: 0x136B90
	// RVA: 0x172ECE0 Offset: 0x172EDE1 VA: 0x172ECE0
	private void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136BA0 Offset: 0x136CA1 VA: 0x136BA0
	// RVA: 0x172ECF0 Offset: 0x172EDF1 VA: 0x172ECF0
	private ICinemachineCamera get_LiveChild() { }

	// RVA: 0x172ED00 Offset: 0x172EE01 VA: 0x172ED00 Slot: 25
	public override CameraState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BB0 Offset: 0x136CB1 VA: 0x136BB0
	// RVA: 0x172ED10 Offset: 0x172EE11 VA: 0x172ED10 Slot: 27
	public override Transform get_LookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BC0 Offset: 0x136CC1 VA: 0x136BC0
	// RVA: 0x172ED20 Offset: 0x172EE21 VA: 0x172ED20 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136BD0 Offset: 0x136CD1 VA: 0x136BD0
	// RVA: 0x172ED30 Offset: 0x172EE31 VA: 0x172ED30 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BE0 Offset: 0x136CE1 VA: 0x136BE0
	// RVA: 0x172ED40 Offset: 0x172EE41 VA: 0x172ED40 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x172ED50 Offset: 0x172EE51 VA: 0x172ED50 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x172EE20 Offset: 0x172EF21 VA: 0x172EE20 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x172EF20 Offset: 0x172F021 VA: 0x172EF20 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x172EFC0 Offset: 0x172F0C1 VA: 0x172EFC0
	public void OnTransformChildrenChanged() { }

	// RVA: 0x172F010 Offset: 0x172F111 VA: 0x172F010 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x172F290 Offset: 0x172F391 VA: 0x172F290 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x172F420 Offset: 0x172F521 VA: 0x172F420
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x172EF70 Offset: 0x172F071 VA: 0x172EF70
	protected void InvalidateListOfChildren() { }

	// RVA: 0x172E8F0 Offset: 0x172E9F1 VA: 0x172E8F0
	protected void ValidateListOfChildren() { }

	// RVA: 0x172F450 Offset: 0x172F551 VA: 0x172F450 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x172F840 Offset: 0x172F941 VA: 0x172F840 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x172FAB0 Offset: 0x172FBB1 VA: 0x172FAB0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[DisallowMultipleComponent] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[ExecuteAlways] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[ExcludeFromPresetAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[AddComponentMenu] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[HelpURLAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4758
{
	// Fields
	public const int MaxCameras = 8;
	[TooltipAttribute] // RVA: 0x1310A0 Offset: 0x1311A1 VA: 0x1310A0
	public float m_Weight0; // 0x64
	[TooltipAttribute] // RVA: 0x1310E0 Offset: 0x1311E1 VA: 0x1310E0
	public float m_Weight1; // 0x68
	[TooltipAttribute] // RVA: 0x131120 Offset: 0x131221 VA: 0x131120
	public float m_Weight2; // 0x6C
	[TooltipAttribute] // RVA: 0x131160 Offset: 0x131261 VA: 0x131160
	public float m_Weight3; // 0x70
	[TooltipAttribute] // RVA: 0x1311A0 Offset: 0x1312A1 VA: 0x1311A0
	public float m_Weight4; // 0x74
	[TooltipAttribute] // RVA: 0x1311E0 Offset: 0x1312E1 VA: 0x1311E0
	public float m_Weight5; // 0x78
	[TooltipAttribute] // RVA: 0x131220 Offset: 0x131321 VA: 0x131220
	public float m_Weight6; // 0x7C
	[TooltipAttribute] // RVA: 0x131260 Offset: 0x131361 VA: 0x131260
	public float m_Weight7; // 0x80
	private CameraState m_State; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x1312A0 Offset: 0x1313A1 VA: 0x1312A0
	private ICinemachineCamera <LiveChild>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x1312B0 Offset: 0x1313B1 VA: 0x1312B0
	private Transform <LookAt>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x1312C0 Offset: 0x1313C1 VA: 0x1312C0
	private Transform <Follow>k__BackingField; // 0x178
	private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x180
	private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x188

	// Properties
	private ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }

	// Methods

	// RVA: 0x172E500 Offset: 0x172E601 VA: 0x172E500
	public float GetWeight(int index) { }

	// RVA: 0x172E680 Offset: 0x172E781 VA: 0x172E680
	public void SetWeight(int index, float w) { }

	// RVA: 0x172E7B0 Offset: 0x172E8B1 VA: 0x172E7B0
	public float GetWeight(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x172EB90 Offset: 0x172EC91 VA: 0x172EB90
	public void SetWeight(CinemachineVirtualCameraBase vcam, float w) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B90 Offset: 0x136C91 VA: 0x136B90
	// RVA: 0x172ECE0 Offset: 0x172EDE1 VA: 0x172ECE0
	private void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136BA0 Offset: 0x136CA1 VA: 0x136BA0
	// RVA: 0x172ECF0 Offset: 0x172EDF1 VA: 0x172ECF0
	private ICinemachineCamera get_LiveChild() { }

	// RVA: 0x172ED00 Offset: 0x172EE01 VA: 0x172ED00 Slot: 25
	public override CameraState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BB0 Offset: 0x136CB1 VA: 0x136BB0
	// RVA: 0x172ED10 Offset: 0x172EE11 VA: 0x172ED10 Slot: 27
	public override Transform get_LookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BC0 Offset: 0x136CC1 VA: 0x136BC0
	// RVA: 0x172ED20 Offset: 0x172EE21 VA: 0x172ED20 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136BD0 Offset: 0x136CD1 VA: 0x136BD0
	// RVA: 0x172ED30 Offset: 0x172EE31 VA: 0x172ED30 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BE0 Offset: 0x136CE1 VA: 0x136BE0
	// RVA: 0x172ED40 Offset: 0x172EE41 VA: 0x172ED40 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x172ED50 Offset: 0x172EE51 VA: 0x172ED50 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x172EE20 Offset: 0x172EF21 VA: 0x172EE20 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x172EF20 Offset: 0x172F021 VA: 0x172EF20 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x172EFC0 Offset: 0x172F0C1 VA: 0x172EFC0
	public void OnTransformChildrenChanged() { }

	// RVA: 0x172F010 Offset: 0x172F111 VA: 0x172F010 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x172F290 Offset: 0x172F391 VA: 0x172F290 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x172F420 Offset: 0x172F521 VA: 0x172F420
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x172EF70 Offset: 0x172F071 VA: 0x172EF70
	protected void InvalidateListOfChildren() { }

	// RVA: 0x172E8F0 Offset: 0x172E9F1 VA: 0x172E8F0
	protected void ValidateListOfChildren() { }

	// RVA: 0x172F450 Offset: 0x172F551 VA: 0x172F450 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x172F840 Offset: 0x172F941 VA: 0x172F840 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x172FAB0 Offset: 0x172FBB1 VA: 0x172FAB0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[DisallowMultipleComponent] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[ExecuteAlways] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[ExcludeFromPresetAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[AddComponentMenu] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[HelpURLAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4758
{
	// Fields
	public const int MaxCameras = 8;
	[TooltipAttribute] // RVA: 0x1310A0 Offset: 0x1311A1 VA: 0x1310A0
	public float m_Weight0; // 0x64
	[TooltipAttribute] // RVA: 0x1310E0 Offset: 0x1311E1 VA: 0x1310E0
	public float m_Weight1; // 0x68
	[TooltipAttribute] // RVA: 0x131120 Offset: 0x131221 VA: 0x131120
	public float m_Weight2; // 0x6C
	[TooltipAttribute] // RVA: 0x131160 Offset: 0x131261 VA: 0x131160
	public float m_Weight3; // 0x70
	[TooltipAttribute] // RVA: 0x1311A0 Offset: 0x1312A1 VA: 0x1311A0
	public float m_Weight4; // 0x74
	[TooltipAttribute] // RVA: 0x1311E0 Offset: 0x1312E1 VA: 0x1311E0
	public float m_Weight5; // 0x78
	[TooltipAttribute] // RVA: 0x131220 Offset: 0x131321 VA: 0x131220
	public float m_Weight6; // 0x7C
	[TooltipAttribute] // RVA: 0x131260 Offset: 0x131361 VA: 0x131260
	public float m_Weight7; // 0x80
	private CameraState m_State; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x1312A0 Offset: 0x1313A1 VA: 0x1312A0
	private ICinemachineCamera <LiveChild>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x1312B0 Offset: 0x1313B1 VA: 0x1312B0
	private Transform <LookAt>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x1312C0 Offset: 0x1313C1 VA: 0x1312C0
	private Transform <Follow>k__BackingField; // 0x178
	private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x180
	private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x188

	// Properties
	private ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }

	// Methods

	// RVA: 0x172E500 Offset: 0x172E601 VA: 0x172E500
	public float GetWeight(int index) { }

	// RVA: 0x172E680 Offset: 0x172E781 VA: 0x172E680
	public void SetWeight(int index, float w) { }

	// RVA: 0x172E7B0 Offset: 0x172E8B1 VA: 0x172E7B0
	public float GetWeight(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x172EB90 Offset: 0x172EC91 VA: 0x172EB90
	public void SetWeight(CinemachineVirtualCameraBase vcam, float w) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B90 Offset: 0x136C91 VA: 0x136B90
	// RVA: 0x172ECE0 Offset: 0x172EDE1 VA: 0x172ECE0
	private void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136BA0 Offset: 0x136CA1 VA: 0x136BA0
	// RVA: 0x172ECF0 Offset: 0x172EDF1 VA: 0x172ECF0
	private ICinemachineCamera get_LiveChild() { }

	// RVA: 0x172ED00 Offset: 0x172EE01 VA: 0x172ED00 Slot: 25
	public override CameraState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BB0 Offset: 0x136CB1 VA: 0x136BB0
	// RVA: 0x172ED10 Offset: 0x172EE11 VA: 0x172ED10 Slot: 27
	public override Transform get_LookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BC0 Offset: 0x136CC1 VA: 0x136BC0
	// RVA: 0x172ED20 Offset: 0x172EE21 VA: 0x172ED20 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136BD0 Offset: 0x136CD1 VA: 0x136BD0
	// RVA: 0x172ED30 Offset: 0x172EE31 VA: 0x172ED30 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BE0 Offset: 0x136CE1 VA: 0x136BE0
	// RVA: 0x172ED40 Offset: 0x172EE41 VA: 0x172ED40 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x172ED50 Offset: 0x172EE51 VA: 0x172ED50 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x172EE20 Offset: 0x172EF21 VA: 0x172EE20 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x172EF20 Offset: 0x172F021 VA: 0x172EF20 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x172EFC0 Offset: 0x172F0C1 VA: 0x172EFC0
	public void OnTransformChildrenChanged() { }

	// RVA: 0x172F010 Offset: 0x172F111 VA: 0x172F010 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x172F290 Offset: 0x172F391 VA: 0x172F290 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x172F420 Offset: 0x172F521 VA: 0x172F420
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x172EF70 Offset: 0x172F071 VA: 0x172EF70
	protected void InvalidateListOfChildren() { }

	// RVA: 0x172E8F0 Offset: 0x172E9F1 VA: 0x172E8F0
	protected void ValidateListOfChildren() { }

	// RVA: 0x172F450 Offset: 0x172F551 VA: 0x172F450 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x172F840 Offset: 0x172F941 VA: 0x172F840 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x172FAB0 Offset: 0x172FBB1 VA: 0x172FAB0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[DisallowMultipleComponent] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[ExecuteAlways] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[ExcludeFromPresetAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[AddComponentMenu] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[HelpURLAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4758
{
	// Fields
	public const int MaxCameras = 8;
	[TooltipAttribute] // RVA: 0x1310A0 Offset: 0x1311A1 VA: 0x1310A0
	public float m_Weight0; // 0x64
	[TooltipAttribute] // RVA: 0x1310E0 Offset: 0x1311E1 VA: 0x1310E0
	public float m_Weight1; // 0x68
	[TooltipAttribute] // RVA: 0x131120 Offset: 0x131221 VA: 0x131120
	public float m_Weight2; // 0x6C
	[TooltipAttribute] // RVA: 0x131160 Offset: 0x131261 VA: 0x131160
	public float m_Weight3; // 0x70
	[TooltipAttribute] // RVA: 0x1311A0 Offset: 0x1312A1 VA: 0x1311A0
	public float m_Weight4; // 0x74
	[TooltipAttribute] // RVA: 0x1311E0 Offset: 0x1312E1 VA: 0x1311E0
	public float m_Weight5; // 0x78
	[TooltipAttribute] // RVA: 0x131220 Offset: 0x131321 VA: 0x131220
	public float m_Weight6; // 0x7C
	[TooltipAttribute] // RVA: 0x131260 Offset: 0x131361 VA: 0x131260
	public float m_Weight7; // 0x80
	private CameraState m_State; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x1312A0 Offset: 0x1313A1 VA: 0x1312A0
	private ICinemachineCamera <LiveChild>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x1312B0 Offset: 0x1313B1 VA: 0x1312B0
	private Transform <LookAt>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x1312C0 Offset: 0x1313C1 VA: 0x1312C0
	private Transform <Follow>k__BackingField; // 0x178
	private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x180
	private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x188

	// Properties
	private ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }

	// Methods

	// RVA: 0x172E500 Offset: 0x172E601 VA: 0x172E500
	public float GetWeight(int index) { }

	// RVA: 0x172E680 Offset: 0x172E781 VA: 0x172E680
	public void SetWeight(int index, float w) { }

	// RVA: 0x172E7B0 Offset: 0x172E8B1 VA: 0x172E7B0
	public float GetWeight(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x172EB90 Offset: 0x172EC91 VA: 0x172EB90
	public void SetWeight(CinemachineVirtualCameraBase vcam, float w) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B90 Offset: 0x136C91 VA: 0x136B90
	// RVA: 0x172ECE0 Offset: 0x172EDE1 VA: 0x172ECE0
	private void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136BA0 Offset: 0x136CA1 VA: 0x136BA0
	// RVA: 0x172ECF0 Offset: 0x172EDF1 VA: 0x172ECF0
	private ICinemachineCamera get_LiveChild() { }

	// RVA: 0x172ED00 Offset: 0x172EE01 VA: 0x172ED00 Slot: 25
	public override CameraState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BB0 Offset: 0x136CB1 VA: 0x136BB0
	// RVA: 0x172ED10 Offset: 0x172EE11 VA: 0x172ED10 Slot: 27
	public override Transform get_LookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BC0 Offset: 0x136CC1 VA: 0x136BC0
	// RVA: 0x172ED20 Offset: 0x172EE21 VA: 0x172ED20 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136BD0 Offset: 0x136CD1 VA: 0x136BD0
	// RVA: 0x172ED30 Offset: 0x172EE31 VA: 0x172ED30 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BE0 Offset: 0x136CE1 VA: 0x136BE0
	// RVA: 0x172ED40 Offset: 0x172EE41 VA: 0x172ED40 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x172ED50 Offset: 0x172EE51 VA: 0x172ED50 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x172EE20 Offset: 0x172EF21 VA: 0x172EE20 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x172EF20 Offset: 0x172F021 VA: 0x172EF20 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x172EFC0 Offset: 0x172F0C1 VA: 0x172EFC0
	public void OnTransformChildrenChanged() { }

	// RVA: 0x172F010 Offset: 0x172F111 VA: 0x172F010 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x172F290 Offset: 0x172F391 VA: 0x172F290 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x172F420 Offset: 0x172F521 VA: 0x172F420
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x172EF70 Offset: 0x172F071 VA: 0x172EF70
	protected void InvalidateListOfChildren() { }

	// RVA: 0x172E8F0 Offset: 0x172E9F1 VA: 0x172E8F0
	protected void ValidateListOfChildren() { }

	// RVA: 0x172F450 Offset: 0x172F551 VA: 0x172F450 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x172F840 Offset: 0x172F941 VA: 0x172F840 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x172FAB0 Offset: 0x172FBB1 VA: 0x172FAB0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[DisallowMultipleComponent] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[ExecuteAlways] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[ExcludeFromPresetAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[AddComponentMenu] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[HelpURLAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4758
{
	// Fields
	public const int MaxCameras = 8;
	[TooltipAttribute] // RVA: 0x1310A0 Offset: 0x1311A1 VA: 0x1310A0
	public float m_Weight0; // 0x64
	[TooltipAttribute] // RVA: 0x1310E0 Offset: 0x1311E1 VA: 0x1310E0
	public float m_Weight1; // 0x68
	[TooltipAttribute] // RVA: 0x131120 Offset: 0x131221 VA: 0x131120
	public float m_Weight2; // 0x6C
	[TooltipAttribute] // RVA: 0x131160 Offset: 0x131261 VA: 0x131160
	public float m_Weight3; // 0x70
	[TooltipAttribute] // RVA: 0x1311A0 Offset: 0x1312A1 VA: 0x1311A0
	public float m_Weight4; // 0x74
	[TooltipAttribute] // RVA: 0x1311E0 Offset: 0x1312E1 VA: 0x1311E0
	public float m_Weight5; // 0x78
	[TooltipAttribute] // RVA: 0x131220 Offset: 0x131321 VA: 0x131220
	public float m_Weight6; // 0x7C
	[TooltipAttribute] // RVA: 0x131260 Offset: 0x131361 VA: 0x131260
	public float m_Weight7; // 0x80
	private CameraState m_State; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x1312A0 Offset: 0x1313A1 VA: 0x1312A0
	private ICinemachineCamera <LiveChild>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x1312B0 Offset: 0x1313B1 VA: 0x1312B0
	private Transform <LookAt>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x1312C0 Offset: 0x1313C1 VA: 0x1312C0
	private Transform <Follow>k__BackingField; // 0x178
	private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x180
	private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x188

	// Properties
	private ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }

	// Methods

	// RVA: 0x172E500 Offset: 0x172E601 VA: 0x172E500
	public float GetWeight(int index) { }

	// RVA: 0x172E680 Offset: 0x172E781 VA: 0x172E680
	public void SetWeight(int index, float w) { }

	// RVA: 0x172E7B0 Offset: 0x172E8B1 VA: 0x172E7B0
	public float GetWeight(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x172EB90 Offset: 0x172EC91 VA: 0x172EB90
	public void SetWeight(CinemachineVirtualCameraBase vcam, float w) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B90 Offset: 0x136C91 VA: 0x136B90
	// RVA: 0x172ECE0 Offset: 0x172EDE1 VA: 0x172ECE0
	private void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136BA0 Offset: 0x136CA1 VA: 0x136BA0
	// RVA: 0x172ECF0 Offset: 0x172EDF1 VA: 0x172ECF0
	private ICinemachineCamera get_LiveChild() { }

	// RVA: 0x172ED00 Offset: 0x172EE01 VA: 0x172ED00 Slot: 25
	public override CameraState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BB0 Offset: 0x136CB1 VA: 0x136BB0
	// RVA: 0x172ED10 Offset: 0x172EE11 VA: 0x172ED10 Slot: 27
	public override Transform get_LookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BC0 Offset: 0x136CC1 VA: 0x136BC0
	// RVA: 0x172ED20 Offset: 0x172EE21 VA: 0x172ED20 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136BD0 Offset: 0x136CD1 VA: 0x136BD0
	// RVA: 0x172ED30 Offset: 0x172EE31 VA: 0x172ED30 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BE0 Offset: 0x136CE1 VA: 0x136BE0
	// RVA: 0x172ED40 Offset: 0x172EE41 VA: 0x172ED40 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x172ED50 Offset: 0x172EE51 VA: 0x172ED50 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x172EE20 Offset: 0x172EF21 VA: 0x172EE20 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x172EF20 Offset: 0x172F021 VA: 0x172EF20 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x172EFC0 Offset: 0x172F0C1 VA: 0x172EFC0
	public void OnTransformChildrenChanged() { }

	// RVA: 0x172F010 Offset: 0x172F111 VA: 0x172F010 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x172F290 Offset: 0x172F391 VA: 0x172F290 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x172F420 Offset: 0x172F521 VA: 0x172F420
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x172EF70 Offset: 0x172F071 VA: 0x172EF70
	protected void InvalidateListOfChildren() { }

	// RVA: 0x172E8F0 Offset: 0x172E9F1 VA: 0x172E8F0
	protected void ValidateListOfChildren() { }

	// RVA: 0x172F450 Offset: 0x172F551 VA: 0x172F450 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x172F840 Offset: 0x172F941 VA: 0x172F840 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x172FAB0 Offset: 0x172FBB1 VA: 0x172FAB0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[DisallowMultipleComponent] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[ExecuteAlways] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[ExcludeFromPresetAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[AddComponentMenu] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
[HelpURLAttribute] // RVA: 0x12E390 Offset: 0x12E491 VA: 0x12E390
public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4758
{
	// Fields
	public const int MaxCameras = 8;
	[TooltipAttribute] // RVA: 0x1310A0 Offset: 0x1311A1 VA: 0x1310A0
	public float m_Weight0; // 0x64
	[TooltipAttribute] // RVA: 0x1310E0 Offset: 0x1311E1 VA: 0x1310E0
	public float m_Weight1; // 0x68
	[TooltipAttribute] // RVA: 0x131120 Offset: 0x131221 VA: 0x131120
	public float m_Weight2; // 0x6C
	[TooltipAttribute] // RVA: 0x131160 Offset: 0x131261 VA: 0x131160
	public float m_Weight3; // 0x70
	[TooltipAttribute] // RVA: 0x1311A0 Offset: 0x1312A1 VA: 0x1311A0
	public float m_Weight4; // 0x74
	[TooltipAttribute] // RVA: 0x1311E0 Offset: 0x1312E1 VA: 0x1311E0
	public float m_Weight5; // 0x78
	[TooltipAttribute] // RVA: 0x131220 Offset: 0x131321 VA: 0x131220
	public float m_Weight6; // 0x7C
	[TooltipAttribute] // RVA: 0x131260 Offset: 0x131361 VA: 0x131260
	public float m_Weight7; // 0x80
	private CameraState m_State; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x1312A0 Offset: 0x1313A1 VA: 0x1312A0
	private ICinemachineCamera <LiveChild>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x1312B0 Offset: 0x1313B1 VA: 0x1312B0
	private Transform <LookAt>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x1312C0 Offset: 0x1313C1 VA: 0x1312C0
	private Transform <Follow>k__BackingField; // 0x178
	private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x180
	private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x188

	// Properties
	private ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }

	// Methods

	// RVA: 0x172E500 Offset: 0x172E601 VA: 0x172E500
	public float GetWeight(int index) { }

	// RVA: 0x172E680 Offset: 0x172E781 VA: 0x172E680
	public void SetWeight(int index, float w) { }

	// RVA: 0x172E7B0 Offset: 0x172E8B1 VA: 0x172E7B0
	public float GetWeight(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x172EB90 Offset: 0x172EC91 VA: 0x172EB90
	public void SetWeight(CinemachineVirtualCameraBase vcam, float w) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B90 Offset: 0x136C91 VA: 0x136B90
	// RVA: 0x172ECE0 Offset: 0x172EDE1 VA: 0x172ECE0
	private void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136BA0 Offset: 0x136CA1 VA: 0x136BA0
	// RVA: 0x172ECF0 Offset: 0x172EDF1 VA: 0x172ECF0
	private ICinemachineCamera get_LiveChild() { }

	// RVA: 0x172ED00 Offset: 0x172EE01 VA: 0x172ED00 Slot: 25
	public override CameraState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BB0 Offset: 0x136CB1 VA: 0x136BB0
	// RVA: 0x172ED10 Offset: 0x172EE11 VA: 0x172ED10 Slot: 27
	public override Transform get_LookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BC0 Offset: 0x136CC1 VA: 0x136BC0
	// RVA: 0x172ED20 Offset: 0x172EE21 VA: 0x172ED20 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136BD0 Offset: 0x136CD1 VA: 0x136BD0
	// RVA: 0x172ED30 Offset: 0x172EE31 VA: 0x172ED30 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x136BE0 Offset: 0x136CE1 VA: 0x136BE0
	// RVA: 0x172ED40 Offset: 0x172EE41 VA: 0x172ED40 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x172ED50 Offset: 0x172EE51 VA: 0x172ED50 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x172EE20 Offset: 0x172EF21 VA: 0x172EE20 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x172EF20 Offset: 0x172F021 VA: 0x172EF20 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x172EFC0 Offset: 0x172F0C1 VA: 0x172EFC0
	public void OnTransformChildrenChanged() { }

	// RVA: 0x172F010 Offset: 0x172F111 VA: 0x172F010 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x172F290 Offset: 0x172F391 VA: 0x172F290 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x172F420 Offset: 0x172F521 VA: 0x172F420
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x172EF70 Offset: 0x172F071 VA: 0x172EF70
	protected void InvalidateListOfChildren() { }

	// RVA: 0x172E8F0 Offset: 0x172E9F1 VA: 0x172E8F0
	protected void ValidateListOfChildren() { }

	// RVA: 0x172F450 Offset: 0x172F551 VA: 0x172F450 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x172F840 Offset: 0x172F941 VA: 0x172F840 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x172FAB0 Offset: 0x172FBB1 VA: 0x172FAB0
	public void .ctor() { }
}

