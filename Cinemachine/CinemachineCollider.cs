[DocumentationSortingAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[AddComponentMenu] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[SaveDuringPlayAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[ExecuteAlways] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[DisallowMultipleComponent] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[HelpURLAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 4743
{
	// Fields
	[HeaderAttribute] // RVA: 0x130150 Offset: 0x130251 VA: 0x130150
	[TooltipAttribute] // RVA: 0x130150 Offset: 0x130251 VA: 0x130150
	public LayerMask m_CollideAgainst; // 0x28
	[TagFieldAttribute] // RVA: 0x1301B0 Offset: 0x1302B1 VA: 0x1301B0
	[TooltipAttribute] // RVA: 0x1301B0 Offset: 0x1302B1 VA: 0x1301B0
	public string m_IgnoreTag; // 0x30
	[TooltipAttribute] // RVA: 0x130200 Offset: 0x130301 VA: 0x130200
	public LayerMask m_TransparentLayers; // 0x38
	[TooltipAttribute] // RVA: 0x130240 Offset: 0x130341 VA: 0x130240
	public float m_MinimumDistanceFromTarget; // 0x3C
	[SpaceAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	[TooltipAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	[FormerlySerializedAsAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	public bool m_AvoidObstacles; // 0x40
	[TooltipAttribute] // RVA: 0x1302F0 Offset: 0x1303F1 VA: 0x1302F0
	[FormerlySerializedAsAttribute] // RVA: 0x1302F0 Offset: 0x1303F1 VA: 0x1302F0
	public float m_DistanceLimit; // 0x44
	[TooltipAttribute] // RVA: 0x130350 Offset: 0x130451 VA: 0x130350
	public float m_MinimumOcclusionTime; // 0x48
	[TooltipAttribute] // RVA: 0x130390 Offset: 0x130491 VA: 0x130390
	public float m_CameraRadius; // 0x4C
	[TooltipAttribute] // RVA: 0x1303D0 Offset: 0x1304D1 VA: 0x1303D0
	public CinemachineCollider.ResolutionStrategy m_Strategy; // 0x50
	[RangeAttribute] // RVA: 0x130410 Offset: 0x130511 VA: 0x130410
	[TooltipAttribute] // RVA: 0x130410 Offset: 0x130511 VA: 0x130410
	public int m_MaximumEffort; // 0x54
	[RangeAttribute] // RVA: 0x130470 Offset: 0x130571 VA: 0x130470
	[TooltipAttribute] // RVA: 0x130470 Offset: 0x130571 VA: 0x130470
	public float m_SmoothingTime; // 0x58
	[RangeAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	[TooltipAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	[FormerlySerializedAsAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	public float m_Damping; // 0x5C
	[RangeAttribute] // RVA: 0x130550 Offset: 0x130651 VA: 0x130550
	[TooltipAttribute] // RVA: 0x130550 Offset: 0x130651 VA: 0x130550
	public float m_DampingWhenOccluded; // 0x60
	[HeaderAttribute] // RVA: 0x1305B0 Offset: 0x1306B1 VA: 0x1305B0
	[TooltipAttribute] // RVA: 0x1305B0 Offset: 0x1306B1 VA: 0x1305B0
	public float m_OptimalTargetDistance; // 0x64
	private const float PrecisionSlush = 0.001;
	private RaycastHit[] m_CornerBuffer; // 0x68
	private const float AngleThreshold = 0.1;
	private Collider[] mColliderBuffer; // 0x70
	private static SphereCollider mCameraCollider; // 0x0
	private static GameObject mCameraColliderGameObject; // 0x8

	// Properties
	public List<List<Vector3>> DebugPaths { get; }

	// Methods

	// RVA: 0x1891A10 Offset: 0x1891B11 VA: 0x1891A10
	public bool IsTargetObscured(ICinemachineCamera vcam) { }

	// RVA: 0x1891A80 Offset: 0x1891B81 VA: 0x1891A80
	public bool CameraWasDisplaced(ICinemachineCamera vcam) { }

	// RVA: 0x1891B00 Offset: 0x1891C01 VA: 0x1891B00
	public float GetCameraDisplacementDistance(ICinemachineCamera vcam) { }

	// RVA: 0x1891B70 Offset: 0x1891C71 VA: 0x1891B70
	private void OnValidate() { }

	// RVA: 0x1891C50 Offset: 0x1891D51 VA: 0x1891C50 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x1891DA0 Offset: 0x1891EA1 VA: 0x1891DA0
	public List<List<Vector3>> get_DebugPaths() { }

	// RVA: 0x1891F60 Offset: 0x1892061 VA: 0x1891F60 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1892000 Offset: 0x1892101 VA: 0x1892000 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1892A40 Offset: 0x1892B41 VA: 0x1892A40
	private Vector3 PreserveLignOfSight(ref CameraState state, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0x18945F0 Offset: 0x18946F1 VA: 0x18945F0
	private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo) { }

	// RVA: 0x1894990 Offset: 0x1894A91 VA: 0x1894990
	private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0x1894FD0 Offset: 0x18950D1 VA: 0x1894FD0
	private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) { }

	// RVA: 0x18956D0 Offset: 0x18957D1 VA: 0x18956D0
	private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) { }

	// RVA: 0x1895930 Offset: 0x1895A31 VA: 0x1895930
	private float ClampRayToBounds(Ray ray, float distance, Bounds bounds) { }

	// RVA: 0x1891C80 Offset: 0x1891D81 VA: 0x1891C80
	private static void DestroyCollider() { }

	// RVA: 0x18932D0 Offset: 0x18933D1 VA: 0x18932D0
	private Vector3 RespectCameraRadius(Vector3 cameraPos, ref CameraState state) { }

	// RVA: 0x1894340 Offset: 0x1894441 VA: 0x1894340
	private bool CheckForTargetObstructions(CameraState state) { }

	// RVA: 0x1893E60 Offset: 0x1893F61 VA: 0x1893E60
	private bool IsTargetOffscreen(CameraState state) { }

	// RVA: 0x1896030 Offset: 0x1896131 VA: 0x1896030
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[AddComponentMenu] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[SaveDuringPlayAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[ExecuteAlways] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[DisallowMultipleComponent] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[HelpURLAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 4743
{
	// Fields
	[HeaderAttribute] // RVA: 0x130150 Offset: 0x130251 VA: 0x130150
	[TooltipAttribute] // RVA: 0x130150 Offset: 0x130251 VA: 0x130150
	public LayerMask m_CollideAgainst; // 0x28
	[TagFieldAttribute] // RVA: 0x1301B0 Offset: 0x1302B1 VA: 0x1301B0
	[TooltipAttribute] // RVA: 0x1301B0 Offset: 0x1302B1 VA: 0x1301B0
	public string m_IgnoreTag; // 0x30
	[TooltipAttribute] // RVA: 0x130200 Offset: 0x130301 VA: 0x130200
	public LayerMask m_TransparentLayers; // 0x38
	[TooltipAttribute] // RVA: 0x130240 Offset: 0x130341 VA: 0x130240
	public float m_MinimumDistanceFromTarget; // 0x3C
	[SpaceAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	[TooltipAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	[FormerlySerializedAsAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	public bool m_AvoidObstacles; // 0x40
	[TooltipAttribute] // RVA: 0x1302F0 Offset: 0x1303F1 VA: 0x1302F0
	[FormerlySerializedAsAttribute] // RVA: 0x1302F0 Offset: 0x1303F1 VA: 0x1302F0
	public float m_DistanceLimit; // 0x44
	[TooltipAttribute] // RVA: 0x130350 Offset: 0x130451 VA: 0x130350
	public float m_MinimumOcclusionTime; // 0x48
	[TooltipAttribute] // RVA: 0x130390 Offset: 0x130491 VA: 0x130390
	public float m_CameraRadius; // 0x4C
	[TooltipAttribute] // RVA: 0x1303D0 Offset: 0x1304D1 VA: 0x1303D0
	public CinemachineCollider.ResolutionStrategy m_Strategy; // 0x50
	[RangeAttribute] // RVA: 0x130410 Offset: 0x130511 VA: 0x130410
	[TooltipAttribute] // RVA: 0x130410 Offset: 0x130511 VA: 0x130410
	public int m_MaximumEffort; // 0x54
	[RangeAttribute] // RVA: 0x130470 Offset: 0x130571 VA: 0x130470
	[TooltipAttribute] // RVA: 0x130470 Offset: 0x130571 VA: 0x130470
	public float m_SmoothingTime; // 0x58
	[RangeAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	[TooltipAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	[FormerlySerializedAsAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	public float m_Damping; // 0x5C
	[RangeAttribute] // RVA: 0x130550 Offset: 0x130651 VA: 0x130550
	[TooltipAttribute] // RVA: 0x130550 Offset: 0x130651 VA: 0x130550
	public float m_DampingWhenOccluded; // 0x60
	[HeaderAttribute] // RVA: 0x1305B0 Offset: 0x1306B1 VA: 0x1305B0
	[TooltipAttribute] // RVA: 0x1305B0 Offset: 0x1306B1 VA: 0x1305B0
	public float m_OptimalTargetDistance; // 0x64
	private const float PrecisionSlush = 0.001;
	private RaycastHit[] m_CornerBuffer; // 0x68
	private const float AngleThreshold = 0.1;
	private Collider[] mColliderBuffer; // 0x70
	private static SphereCollider mCameraCollider; // 0x0
	private static GameObject mCameraColliderGameObject; // 0x8

	// Properties
	public List<List<Vector3>> DebugPaths { get; }

	// Methods

	// RVA: 0x1891A10 Offset: 0x1891B11 VA: 0x1891A10
	public bool IsTargetObscured(ICinemachineCamera vcam) { }

	// RVA: 0x1891A80 Offset: 0x1891B81 VA: 0x1891A80
	public bool CameraWasDisplaced(ICinemachineCamera vcam) { }

	// RVA: 0x1891B00 Offset: 0x1891C01 VA: 0x1891B00
	public float GetCameraDisplacementDistance(ICinemachineCamera vcam) { }

	// RVA: 0x1891B70 Offset: 0x1891C71 VA: 0x1891B70
	private void OnValidate() { }

	// RVA: 0x1891C50 Offset: 0x1891D51 VA: 0x1891C50 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x1891DA0 Offset: 0x1891EA1 VA: 0x1891DA0
	public List<List<Vector3>> get_DebugPaths() { }

	// RVA: 0x1891F60 Offset: 0x1892061 VA: 0x1891F60 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1892000 Offset: 0x1892101 VA: 0x1892000 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1892A40 Offset: 0x1892B41 VA: 0x1892A40
	private Vector3 PreserveLignOfSight(ref CameraState state, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0x18945F0 Offset: 0x18946F1 VA: 0x18945F0
	private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo) { }

	// RVA: 0x1894990 Offset: 0x1894A91 VA: 0x1894990
	private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0x1894FD0 Offset: 0x18950D1 VA: 0x1894FD0
	private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) { }

	// RVA: 0x18956D0 Offset: 0x18957D1 VA: 0x18956D0
	private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) { }

	// RVA: 0x1895930 Offset: 0x1895A31 VA: 0x1895930
	private float ClampRayToBounds(Ray ray, float distance, Bounds bounds) { }

	// RVA: 0x1891C80 Offset: 0x1891D81 VA: 0x1891C80
	private static void DestroyCollider() { }

	// RVA: 0x18932D0 Offset: 0x18933D1 VA: 0x18932D0
	private Vector3 RespectCameraRadius(Vector3 cameraPos, ref CameraState state) { }

	// RVA: 0x1894340 Offset: 0x1894441 VA: 0x1894340
	private bool CheckForTargetObstructions(CameraState state) { }

	// RVA: 0x1893E60 Offset: 0x1893F61 VA: 0x1893E60
	private bool IsTargetOffscreen(CameraState state) { }

	// RVA: 0x1896030 Offset: 0x1896131 VA: 0x1896030
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[AddComponentMenu] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[SaveDuringPlayAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[ExecuteAlways] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[DisallowMultipleComponent] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[HelpURLAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 4743
{
	// Fields
	[HeaderAttribute] // RVA: 0x130150 Offset: 0x130251 VA: 0x130150
	[TooltipAttribute] // RVA: 0x130150 Offset: 0x130251 VA: 0x130150
	public LayerMask m_CollideAgainst; // 0x28
	[TagFieldAttribute] // RVA: 0x1301B0 Offset: 0x1302B1 VA: 0x1301B0
	[TooltipAttribute] // RVA: 0x1301B0 Offset: 0x1302B1 VA: 0x1301B0
	public string m_IgnoreTag; // 0x30
	[TooltipAttribute] // RVA: 0x130200 Offset: 0x130301 VA: 0x130200
	public LayerMask m_TransparentLayers; // 0x38
	[TooltipAttribute] // RVA: 0x130240 Offset: 0x130341 VA: 0x130240
	public float m_MinimumDistanceFromTarget; // 0x3C
	[SpaceAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	[TooltipAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	[FormerlySerializedAsAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	public bool m_AvoidObstacles; // 0x40
	[TooltipAttribute] // RVA: 0x1302F0 Offset: 0x1303F1 VA: 0x1302F0
	[FormerlySerializedAsAttribute] // RVA: 0x1302F0 Offset: 0x1303F1 VA: 0x1302F0
	public float m_DistanceLimit; // 0x44
	[TooltipAttribute] // RVA: 0x130350 Offset: 0x130451 VA: 0x130350
	public float m_MinimumOcclusionTime; // 0x48
	[TooltipAttribute] // RVA: 0x130390 Offset: 0x130491 VA: 0x130390
	public float m_CameraRadius; // 0x4C
	[TooltipAttribute] // RVA: 0x1303D0 Offset: 0x1304D1 VA: 0x1303D0
	public CinemachineCollider.ResolutionStrategy m_Strategy; // 0x50
	[RangeAttribute] // RVA: 0x130410 Offset: 0x130511 VA: 0x130410
	[TooltipAttribute] // RVA: 0x130410 Offset: 0x130511 VA: 0x130410
	public int m_MaximumEffort; // 0x54
	[RangeAttribute] // RVA: 0x130470 Offset: 0x130571 VA: 0x130470
	[TooltipAttribute] // RVA: 0x130470 Offset: 0x130571 VA: 0x130470
	public float m_SmoothingTime; // 0x58
	[RangeAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	[TooltipAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	[FormerlySerializedAsAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	public float m_Damping; // 0x5C
	[RangeAttribute] // RVA: 0x130550 Offset: 0x130651 VA: 0x130550
	[TooltipAttribute] // RVA: 0x130550 Offset: 0x130651 VA: 0x130550
	public float m_DampingWhenOccluded; // 0x60
	[HeaderAttribute] // RVA: 0x1305B0 Offset: 0x1306B1 VA: 0x1305B0
	[TooltipAttribute] // RVA: 0x1305B0 Offset: 0x1306B1 VA: 0x1305B0
	public float m_OptimalTargetDistance; // 0x64
	private const float PrecisionSlush = 0.001;
	private RaycastHit[] m_CornerBuffer; // 0x68
	private const float AngleThreshold = 0.1;
	private Collider[] mColliderBuffer; // 0x70
	private static SphereCollider mCameraCollider; // 0x0
	private static GameObject mCameraColliderGameObject; // 0x8

	// Properties
	public List<List<Vector3>> DebugPaths { get; }

	// Methods

	// RVA: 0x1891A10 Offset: 0x1891B11 VA: 0x1891A10
	public bool IsTargetObscured(ICinemachineCamera vcam) { }

	// RVA: 0x1891A80 Offset: 0x1891B81 VA: 0x1891A80
	public bool CameraWasDisplaced(ICinemachineCamera vcam) { }

	// RVA: 0x1891B00 Offset: 0x1891C01 VA: 0x1891B00
	public float GetCameraDisplacementDistance(ICinemachineCamera vcam) { }

	// RVA: 0x1891B70 Offset: 0x1891C71 VA: 0x1891B70
	private void OnValidate() { }

	// RVA: 0x1891C50 Offset: 0x1891D51 VA: 0x1891C50 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x1891DA0 Offset: 0x1891EA1 VA: 0x1891DA0
	public List<List<Vector3>> get_DebugPaths() { }

	// RVA: 0x1891F60 Offset: 0x1892061 VA: 0x1891F60 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1892000 Offset: 0x1892101 VA: 0x1892000 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1892A40 Offset: 0x1892B41 VA: 0x1892A40
	private Vector3 PreserveLignOfSight(ref CameraState state, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0x18945F0 Offset: 0x18946F1 VA: 0x18945F0
	private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo) { }

	// RVA: 0x1894990 Offset: 0x1894A91 VA: 0x1894990
	private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0x1894FD0 Offset: 0x18950D1 VA: 0x1894FD0
	private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) { }

	// RVA: 0x18956D0 Offset: 0x18957D1 VA: 0x18956D0
	private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) { }

	// RVA: 0x1895930 Offset: 0x1895A31 VA: 0x1895930
	private float ClampRayToBounds(Ray ray, float distance, Bounds bounds) { }

	// RVA: 0x1891C80 Offset: 0x1891D81 VA: 0x1891C80
	private static void DestroyCollider() { }

	// RVA: 0x18932D0 Offset: 0x18933D1 VA: 0x18932D0
	private Vector3 RespectCameraRadius(Vector3 cameraPos, ref CameraState state) { }

	// RVA: 0x1894340 Offset: 0x1894441 VA: 0x1894340
	private bool CheckForTargetObstructions(CameraState state) { }

	// RVA: 0x1893E60 Offset: 0x1893F61 VA: 0x1893E60
	private bool IsTargetOffscreen(CameraState state) { }

	// RVA: 0x1896030 Offset: 0x1896131 VA: 0x1896030
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[AddComponentMenu] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[SaveDuringPlayAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[ExecuteAlways] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[DisallowMultipleComponent] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[HelpURLAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 4743
{
	// Fields
	[HeaderAttribute] // RVA: 0x130150 Offset: 0x130251 VA: 0x130150
	[TooltipAttribute] // RVA: 0x130150 Offset: 0x130251 VA: 0x130150
	public LayerMask m_CollideAgainst; // 0x28
	[TagFieldAttribute] // RVA: 0x1301B0 Offset: 0x1302B1 VA: 0x1301B0
	[TooltipAttribute] // RVA: 0x1301B0 Offset: 0x1302B1 VA: 0x1301B0
	public string m_IgnoreTag; // 0x30
	[TooltipAttribute] // RVA: 0x130200 Offset: 0x130301 VA: 0x130200
	public LayerMask m_TransparentLayers; // 0x38
	[TooltipAttribute] // RVA: 0x130240 Offset: 0x130341 VA: 0x130240
	public float m_MinimumDistanceFromTarget; // 0x3C
	[SpaceAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	[TooltipAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	[FormerlySerializedAsAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	public bool m_AvoidObstacles; // 0x40
	[TooltipAttribute] // RVA: 0x1302F0 Offset: 0x1303F1 VA: 0x1302F0
	[FormerlySerializedAsAttribute] // RVA: 0x1302F0 Offset: 0x1303F1 VA: 0x1302F0
	public float m_DistanceLimit; // 0x44
	[TooltipAttribute] // RVA: 0x130350 Offset: 0x130451 VA: 0x130350
	public float m_MinimumOcclusionTime; // 0x48
	[TooltipAttribute] // RVA: 0x130390 Offset: 0x130491 VA: 0x130390
	public float m_CameraRadius; // 0x4C
	[TooltipAttribute] // RVA: 0x1303D0 Offset: 0x1304D1 VA: 0x1303D0
	public CinemachineCollider.ResolutionStrategy m_Strategy; // 0x50
	[RangeAttribute] // RVA: 0x130410 Offset: 0x130511 VA: 0x130410
	[TooltipAttribute] // RVA: 0x130410 Offset: 0x130511 VA: 0x130410
	public int m_MaximumEffort; // 0x54
	[RangeAttribute] // RVA: 0x130470 Offset: 0x130571 VA: 0x130470
	[TooltipAttribute] // RVA: 0x130470 Offset: 0x130571 VA: 0x130470
	public float m_SmoothingTime; // 0x58
	[RangeAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	[TooltipAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	[FormerlySerializedAsAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	public float m_Damping; // 0x5C
	[RangeAttribute] // RVA: 0x130550 Offset: 0x130651 VA: 0x130550
	[TooltipAttribute] // RVA: 0x130550 Offset: 0x130651 VA: 0x130550
	public float m_DampingWhenOccluded; // 0x60
	[HeaderAttribute] // RVA: 0x1305B0 Offset: 0x1306B1 VA: 0x1305B0
	[TooltipAttribute] // RVA: 0x1305B0 Offset: 0x1306B1 VA: 0x1305B0
	public float m_OptimalTargetDistance; // 0x64
	private const float PrecisionSlush = 0.001;
	private RaycastHit[] m_CornerBuffer; // 0x68
	private const float AngleThreshold = 0.1;
	private Collider[] mColliderBuffer; // 0x70
	private static SphereCollider mCameraCollider; // 0x0
	private static GameObject mCameraColliderGameObject; // 0x8

	// Properties
	public List<List<Vector3>> DebugPaths { get; }

	// Methods

	// RVA: 0x1891A10 Offset: 0x1891B11 VA: 0x1891A10
	public bool IsTargetObscured(ICinemachineCamera vcam) { }

	// RVA: 0x1891A80 Offset: 0x1891B81 VA: 0x1891A80
	public bool CameraWasDisplaced(ICinemachineCamera vcam) { }

	// RVA: 0x1891B00 Offset: 0x1891C01 VA: 0x1891B00
	public float GetCameraDisplacementDistance(ICinemachineCamera vcam) { }

	// RVA: 0x1891B70 Offset: 0x1891C71 VA: 0x1891B70
	private void OnValidate() { }

	// RVA: 0x1891C50 Offset: 0x1891D51 VA: 0x1891C50 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x1891DA0 Offset: 0x1891EA1 VA: 0x1891DA0
	public List<List<Vector3>> get_DebugPaths() { }

	// RVA: 0x1891F60 Offset: 0x1892061 VA: 0x1891F60 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1892000 Offset: 0x1892101 VA: 0x1892000 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1892A40 Offset: 0x1892B41 VA: 0x1892A40
	private Vector3 PreserveLignOfSight(ref CameraState state, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0x18945F0 Offset: 0x18946F1 VA: 0x18945F0
	private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo) { }

	// RVA: 0x1894990 Offset: 0x1894A91 VA: 0x1894990
	private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0x1894FD0 Offset: 0x18950D1 VA: 0x1894FD0
	private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) { }

	// RVA: 0x18956D0 Offset: 0x18957D1 VA: 0x18956D0
	private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) { }

	// RVA: 0x1895930 Offset: 0x1895A31 VA: 0x1895930
	private float ClampRayToBounds(Ray ray, float distance, Bounds bounds) { }

	// RVA: 0x1891C80 Offset: 0x1891D81 VA: 0x1891C80
	private static void DestroyCollider() { }

	// RVA: 0x18932D0 Offset: 0x18933D1 VA: 0x18932D0
	private Vector3 RespectCameraRadius(Vector3 cameraPos, ref CameraState state) { }

	// RVA: 0x1894340 Offset: 0x1894441 VA: 0x1894340
	private bool CheckForTargetObstructions(CameraState state) { }

	// RVA: 0x1893E60 Offset: 0x1893F61 VA: 0x1893E60
	private bool IsTargetOffscreen(CameraState state) { }

	// RVA: 0x1896030 Offset: 0x1896131 VA: 0x1896030
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[AddComponentMenu] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[SaveDuringPlayAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[ExecuteAlways] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[DisallowMultipleComponent] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
[HelpURLAttribute] // RVA: 0x12DF80 Offset: 0x12E081 VA: 0x12DF80
public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 4743
{
	// Fields
	[HeaderAttribute] // RVA: 0x130150 Offset: 0x130251 VA: 0x130150
	[TooltipAttribute] // RVA: 0x130150 Offset: 0x130251 VA: 0x130150
	public LayerMask m_CollideAgainst; // 0x28
	[TagFieldAttribute] // RVA: 0x1301B0 Offset: 0x1302B1 VA: 0x1301B0
	[TooltipAttribute] // RVA: 0x1301B0 Offset: 0x1302B1 VA: 0x1301B0
	public string m_IgnoreTag; // 0x30
	[TooltipAttribute] // RVA: 0x130200 Offset: 0x130301 VA: 0x130200
	public LayerMask m_TransparentLayers; // 0x38
	[TooltipAttribute] // RVA: 0x130240 Offset: 0x130341 VA: 0x130240
	public float m_MinimumDistanceFromTarget; // 0x3C
	[SpaceAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	[TooltipAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	[FormerlySerializedAsAttribute] // RVA: 0x130280 Offset: 0x130381 VA: 0x130280
	public bool m_AvoidObstacles; // 0x40
	[TooltipAttribute] // RVA: 0x1302F0 Offset: 0x1303F1 VA: 0x1302F0
	[FormerlySerializedAsAttribute] // RVA: 0x1302F0 Offset: 0x1303F1 VA: 0x1302F0
	public float m_DistanceLimit; // 0x44
	[TooltipAttribute] // RVA: 0x130350 Offset: 0x130451 VA: 0x130350
	public float m_MinimumOcclusionTime; // 0x48
	[TooltipAttribute] // RVA: 0x130390 Offset: 0x130491 VA: 0x130390
	public float m_CameraRadius; // 0x4C
	[TooltipAttribute] // RVA: 0x1303D0 Offset: 0x1304D1 VA: 0x1303D0
	public CinemachineCollider.ResolutionStrategy m_Strategy; // 0x50
	[RangeAttribute] // RVA: 0x130410 Offset: 0x130511 VA: 0x130410
	[TooltipAttribute] // RVA: 0x130410 Offset: 0x130511 VA: 0x130410
	public int m_MaximumEffort; // 0x54
	[RangeAttribute] // RVA: 0x130470 Offset: 0x130571 VA: 0x130470
	[TooltipAttribute] // RVA: 0x130470 Offset: 0x130571 VA: 0x130470
	public float m_SmoothingTime; // 0x58
	[RangeAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	[TooltipAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	[FormerlySerializedAsAttribute] // RVA: 0x1304D0 Offset: 0x1305D1 VA: 0x1304D0
	public float m_Damping; // 0x5C
	[RangeAttribute] // RVA: 0x130550 Offset: 0x130651 VA: 0x130550
	[TooltipAttribute] // RVA: 0x130550 Offset: 0x130651 VA: 0x130550
	public float m_DampingWhenOccluded; // 0x60
	[HeaderAttribute] // RVA: 0x1305B0 Offset: 0x1306B1 VA: 0x1305B0
	[TooltipAttribute] // RVA: 0x1305B0 Offset: 0x1306B1 VA: 0x1305B0
	public float m_OptimalTargetDistance; // 0x64
	private const float PrecisionSlush = 0.001;
	private RaycastHit[] m_CornerBuffer; // 0x68
	private const float AngleThreshold = 0.1;
	private Collider[] mColliderBuffer; // 0x70
	private static SphereCollider mCameraCollider; // 0x0
	private static GameObject mCameraColliderGameObject; // 0x8

	// Properties
	public List<List<Vector3>> DebugPaths { get; }

	// Methods

	// RVA: 0x1891A10 Offset: 0x1891B11 VA: 0x1891A10
	public bool IsTargetObscured(ICinemachineCamera vcam) { }

	// RVA: 0x1891A80 Offset: 0x1891B81 VA: 0x1891A80
	public bool CameraWasDisplaced(ICinemachineCamera vcam) { }

	// RVA: 0x1891B00 Offset: 0x1891C01 VA: 0x1891B00
	public float GetCameraDisplacementDistance(ICinemachineCamera vcam) { }

	// RVA: 0x1891B70 Offset: 0x1891C71 VA: 0x1891B70
	private void OnValidate() { }

	// RVA: 0x1891C50 Offset: 0x1891D51 VA: 0x1891C50 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x1891DA0 Offset: 0x1891EA1 VA: 0x1891DA0
	public List<List<Vector3>> get_DebugPaths() { }

	// RVA: 0x1891F60 Offset: 0x1892061 VA: 0x1891F60 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1892000 Offset: 0x1892101 VA: 0x1892000 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1892A40 Offset: 0x1892B41 VA: 0x1892A40
	private Vector3 PreserveLignOfSight(ref CameraState state, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0x18945F0 Offset: 0x18946F1 VA: 0x18945F0
	private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo) { }

	// RVA: 0x1894990 Offset: 0x1894A91 VA: 0x1894990
	private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0x1894FD0 Offset: 0x18950D1 VA: 0x1894FD0
	private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) { }

	// RVA: 0x18956D0 Offset: 0x18957D1 VA: 0x18956D0
	private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) { }

	// RVA: 0x1895930 Offset: 0x1895A31 VA: 0x1895930
	private float ClampRayToBounds(Ray ray, float distance, Bounds bounds) { }

	// RVA: 0x1891C80 Offset: 0x1891D81 VA: 0x1891C80
	private static void DestroyCollider() { }

	// RVA: 0x18932D0 Offset: 0x18933D1 VA: 0x18932D0
	private Vector3 RespectCameraRadius(Vector3 cameraPos, ref CameraState state) { }

	// RVA: 0x1894340 Offset: 0x1894441 VA: 0x1894340
	private bool CheckForTargetObstructions(CameraState state) { }

	// RVA: 0x1893E60 Offset: 0x1893F61 VA: 0x1893E60
	private bool IsTargetOffscreen(CameraState state) { }

	// RVA: 0x1896030 Offset: 0x1896131 VA: 0x1896030
	public void .ctor() { }
}

