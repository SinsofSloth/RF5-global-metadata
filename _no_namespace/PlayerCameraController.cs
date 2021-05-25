public class PlayerCameraController : CameraControllerBase // TypeDefIndex: 6497
{
	// Fields
	private const float GROUND_RAY_LENGTH = 10;
	private const float GROUND_UP_OFFSET = 0.1;
	[SerializeField] // RVA: 0x15CF20 Offset: 0x15D021 VA: 0x15CF20
	private Animator m_Animator; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15CF30 Offset: 0x15D031 VA: 0x15CF30
	private PlayerCameraController.PlayerCameraType <CurrentCameraType>k__BackingField; // 0x30
	private CinemachineStateDrivenCamera m_StateDrivenCamere; // 0x38
	private IPlayerCamera m_CurrentCamera; // 0x40
	private CinemachineImpulseSource CinemachineImpulseSource; // 0x48
	private GameObject m_PlayerTarget; // 0x50
	private GameObject m_LookonTarget; // 0x58
	private Vector3 PrevTargetPostion; // 0x60
	private bool m_IsFarmCameraCancel; // 0x6C
	private float m_FarmStopDuration; // 0x70

	// Properties
	public PlayerCameraController.PlayerCameraType CurrentCameraType { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B3D0 Offset: 0x19B4D1 VA: 0x19B3D0
	// RVA: 0x1FE9A80 Offset: 0x1FE9B81 VA: 0x1FE9A80
	public PlayerCameraController.PlayerCameraType get_CurrentCameraType() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B3E0 Offset: 0x19B4E1 VA: 0x19B3E0
	// RVA: 0x1FE9A90 Offset: 0x1FE9B91 VA: 0x1FE9A90
	protected void set_CurrentCameraType(PlayerCameraController.PlayerCameraType value) { }

	// RVA: 0x1FE9AA0 Offset: 0x1FE9BA1 VA: 0x1FE9AA0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1FEA230 Offset: 0x1FEA331 VA: 0x1FEA230 Slot: 6
	public override void EnableCameraSetup(UseCameraType prevCameraType, CinemachineVirtualCamera vcam) { }

	// RVA: 0x1FEA420 Offset: 0x1FEA521 VA: 0x1FEA420 Slot: 8
	public override void PreFrameUpdate() { }

	// RVA: 0x1FEA4E0 Offset: 0x1FEA5E1 VA: 0x1FEA4E0 Slot: 9
	public override void FrameUpdate() { }

	// RVA: 0x1FEA850 Offset: 0x1FEA951 VA: 0x1FEA850 Slot: 10
	public override void TimeStepUpdate() { }

	// RVA: 0x1FE9EC0 Offset: 0x1FE9FC1 VA: 0x1FE9EC0
	public void ChangeCameraType(PlayerCameraController.PlayerCameraType cameraType, Nullable<Quaternion> rotation) { }

	// RVA: 0x1FEAAF0 Offset: 0x1FEABF1 VA: 0x1FEAAF0
	private void VirtualCameraReset(Nullable<Quaternion> resetRotation) { }

	// RVA: 0x1FEA380 Offset: 0x1FEA481 VA: 0x1FEA380
	public void CameraReset(Nullable<Quaternion> resetRotation) { }

	// RVA: 0x1FEA920 Offset: 0x1FEAA21 VA: 0x1FEA920
	private void TargetPositionUpdate() { }

	// RVA: 0x1FEAC30 Offset: 0x1FEAD31 VA: 0x1FEAC30
	public Vector3 GetCameraLockPos(float xzSpeed, float ySpeed) { }

	// RVA: 0x1FEAC00 Offset: 0x1FEAD01 VA: 0x1FEAC00
	public Vector3 GetCameraLockPosReset() { }

	// RVA: 0x1FEAEB0 Offset: 0x1FEAFB1 VA: 0x1FEAEB0
	private Vector3 GetDefaultTargetPoistion() { }

	// RVA: 0x1FEB1A0 Offset: 0x1FEB2A1 VA: 0x1FEB1A0
	public void Shake(Vector3 pos, float amplitudeGain, float frequencyGain, float impactRadius, float dissipationDistance, float attack = 0, float sustainTime = 1, float decay = 2) { }

	// RVA: 0x1FEB290 Offset: 0x1FEB391 VA: 0x1FEB290
	public void SetOptimalCamera() { }

	// RVA: 0x1FEA760 Offset: 0x1FEA861 VA: 0x1FEA760
	public void StopFarmCamera() { }

	// RVA: 0x1FEB300 Offset: 0x1FEB401 VA: 0x1FEB300
	public void .ctor() { }
}

