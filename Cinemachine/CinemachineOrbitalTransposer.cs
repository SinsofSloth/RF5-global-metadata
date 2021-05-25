[DocumentationSortingAttribute] // RVA: 0x12EB60 Offset: 0x12EC61 VA: 0x12EB60
[AddComponentMenu] // RVA: 0x12EB60 Offset: 0x12EC61 VA: 0x12EB60
[SaveDuringPlayAttribute] // RVA: 0x12EB60 Offset: 0x12EC61 VA: 0x12EB60
public class CinemachineOrbitalTransposer : CinemachineTransposer // TypeDefIndex: 4794
{
	// Fields
	[SpaceAttribute] // RVA: 0x1334D0 Offset: 0x1335D1 VA: 0x1334D0
	[OrbitalTransposerHeadingPropertyAttribute] // RVA: 0x1334D0 Offset: 0x1335D1 VA: 0x1334D0
	[TooltipAttribute] // RVA: 0x1334D0 Offset: 0x1335D1 VA: 0x1334D0
	public CinemachineOrbitalTransposer.Heading m_Heading; // 0xC8
	[TooltipAttribute] // RVA: 0x133530 Offset: 0x133631 VA: 0x133530
	public AxisState.Recentering m_RecenterToTargetHeading; // 0xD4
	[TooltipAttribute] // RVA: 0x133570 Offset: 0x133671 VA: 0x133570
	[AxisStatePropertyAttribute] // RVA: 0x133570 Offset: 0x133671 VA: 0x133570
	public AxisState m_XAxis; // 0xF0
	[SerializeField] // RVA: 0x1335C0 Offset: 0x1336C1 VA: 0x1335C0
	[HideInInspector] // RVA: 0x1335C0 Offset: 0x1336C1 VA: 0x1335C0
	[FormerlySerializedAsAttribute] // RVA: 0x1335C0 Offset: 0x1336C1 VA: 0x1335C0
	private float m_LegacyRadius; // 0x158
	[SerializeField] // RVA: 0x133620 Offset: 0x133721 VA: 0x133620
	[HideInInspector] // RVA: 0x133620 Offset: 0x133721 VA: 0x133620
	[FormerlySerializedAsAttribute] // RVA: 0x133620 Offset: 0x133721 VA: 0x133620
	private float m_LegacyHeightOffset; // 0x15C
	[SerializeField] // RVA: 0x133680 Offset: 0x133781 VA: 0x133680
	[HideInInspector] // RVA: 0x133680 Offset: 0x133781 VA: 0x133680
	[FormerlySerializedAsAttribute] // RVA: 0x133680 Offset: 0x133781 VA: 0x133680
	private float m_LegacyHeadingBias; // 0x160
	[HideInInspector] // RVA: 0x1336E0 Offset: 0x1337E1 VA: 0x1336E0
	[NoSaveDuringPlayAttribute] // RVA: 0x1336E0 Offset: 0x1337E1 VA: 0x1336E0
	public bool m_HeadingIsSlave; // 0x164
	internal CinemachineOrbitalTransposer.UpdateHeadingDelegate HeadingUpdater; // 0x168
	private Vector3 mLastTargetPosition; // 0x170
	private HeadingTracker mHeadingTracker; // 0x180
	private Rigidbody mTargetRigidBody; // 0x188
	[CompilerGeneratedAttribute] // RVA: 0x133720 Offset: 0x133821 VA: 0x133720
	private Transform <PreviousTarget>k__BackingField; // 0x190
	private Vector3 mLastCameraPosition; // 0x198
	[CompilerGeneratedAttribute] // RVA: 0x133730 Offset: 0x133831 VA: 0x133730
	private float <LastHeading>k__BackingField; // 0x1A4

	// Properties
	private Transform PreviousTarget { get; set; }
	private float LastHeading { get; set; }

	// Methods

	// RVA: 0x172FB60 Offset: 0x172FC61 VA: 0x172FB60 Slot: 13
	protected override void OnValidate() { }

	// RVA: 0x172FC70 Offset: 0x172FD71 VA: 0x172FC70
	public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis) { }

	// RVA: 0x17292C0 Offset: 0x17293C1 VA: 0x17292C0
	public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref AxisState.Recentering recentering, bool isLive) { }

	// RVA: 0x1730110 Offset: 0x1730211 VA: 0x1730110
	private void OnEnable() { }

	// RVA: 0x17301A0 Offset: 0x17302A1 VA: 0x17301A0
	public void UpdateInputAxisProvider() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D60 Offset: 0x136E61 VA: 0x136D60
	// RVA: 0x1730290 Offset: 0x1730391 VA: 0x1730290
	private Transform get_PreviousTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D70 Offset: 0x136E71 VA: 0x136D70
	// RVA: 0x17302A0 Offset: 0x17303A1 VA: 0x17302A0
	private void set_PreviousTarget(Transform value) { }

	// RVA: 0x17302B0 Offset: 0x17303B1 VA: 0x17302B0 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1730410 Offset: 0x1730511 VA: 0x1730410 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x17304B0 Offset: 0x17305B1 VA: 0x17304B0 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	// RVA: 0x1726550 Offset: 0x1726651 VA: 0x1726550
	public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up) { }

	[CompilerGeneratedAttribute] // RVA: 0x136D80 Offset: 0x136E81 VA: 0x136D80
	// RVA: 0x1730610 Offset: 0x1730711 VA: 0x1730610
	private float get_LastHeading() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D90 Offset: 0x136E91 VA: 0x136D90
	// RVA: 0x1730620 Offset: 0x1730721 VA: 0x1730620
	private void set_LastHeading(float value) { }

	// RVA: 0x1730630 Offset: 0x1730731 VA: 0x1730630 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1731120 Offset: 0x1731221 VA: 0x1731120 Slot: 14
	public override Vector3 GetTargetCameraPosition(Vector3 worldUp) { }

	// RVA: 0x1731300 Offset: 0x1731401 VA: 0x1731300
	private static string GetFullName(GameObject current) { }

	// RVA: 0x172FC80 Offset: 0x172FD81 VA: 0x172FC80
	private float GetTargetHeading(float currentHeading, Quaternion targetOrientation) { }

	// RVA: 0x1731470 Offset: 0x1731571 VA: 0x1731470
	public void .ctor() { }
}

