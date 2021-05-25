public class PlayerTrackingCamera : SingletonMonoBehaviour<PlayerTrackingCamera>, IPlayerCamera // TypeDefIndex: 6502
{
	// Fields
	private const float LERP_DISTANCE_SPEED = 10;
	private const float LERP_FOV_SPEED = 15;
	private const float LERP_DEADZONE_SPEED_X = 1.5;
	private const float LERP_DEADZONE_SPEED_Y = 2;
	private const float LERP_DEADZONE_ACTION_SPEED = 15;
	private const float LERP_DEADZONE_INPUT_SPEED = 10;
	private const float STOP_THRESHOLD = 0.01;
	private const float DOT_THERSHOLD = 0.9;
	[SerializeField] // RVA: 0x15CF90 Offset: 0x15D091 VA: 0x15CF90
	private CinemachineVirtualCamera m_VirtualCamera; // 0x18
	[SerializeField] // RVA: 0x15CFA0 Offset: 0x15D0A1 VA: 0x15CFA0
	private TrackingCameraSetting m_Setting; // 0x20
	[SerializeField] // RVA: 0x15CFB0 Offset: 0x15D0B1 VA: 0x15CFB0
	private TrackingCameraSettingTable m_SettingTable; // 0x28
	[SerializeField] // RVA: 0x15CFC0 Offset: 0x15D0C1 VA: 0x15CFC0
	private float m_RotateXAxisMax; // 0x30
	[SerializeField] // RVA: 0x15CFD0 Offset: 0x15D0D1 VA: 0x15CFD0
	private float m_RotateXAxisMin; // 0x34
	[SerializeField] // RVA: 0x15CFE0 Offset: 0x15D0E1 VA: 0x15CFE0
	public float m_AutoRotateSpeed; // 0x38
	[SerializeField] // RVA: 0x15CFF0 Offset: 0x15D0F1 VA: 0x15CFF0
	public float m_AutoRotateStartTime; // 0x3C
	public float m_AutoRotateInSpeed; // 0x40
	public float m_AutoRotateOutSpeed; // 0x44
	public float m_DeadZoneWidth; // 0x48
	private float m_DeadZoneHeight; // 0x4C
	[SerializeField] // RVA: 0x15D000 Offset: 0x15D101 VA: 0x15D000
	private AnimationCurve m_AutoRotateCurve; // 0x50
	[SerializeField] // RVA: 0x15D010 Offset: 0x15D111 VA: 0x15D010
	private AnimationCurve m_FOVRateCurve; // 0x58
	private float m_SpeedYAxis; // 0x60
	private float m_PrevSpeedYAxis; // 0x64
	private float m_SpeedXAxis; // 0x68
	private float m_PrevSpeedXAxis; // 0x6C
	private float m_RotateYAxis; // 0x70
	private float m_RotateXAxis; // 0x74
	private CinemachineTransposer m_Transposer; // 0x78
	private CinemachineComposer m_Composer; // 0x80
	private float m_MoveElapsed; // 0x88
	private Vector3 m_FollowTargetPosition; // 0x8C
	private float m_CurrentDistance; // 0x98
	private PlayerTrackingCamera.AutoRotateState m_AutoRotateState; // 0x9C
	private float m_AutoRotateElapasedTime; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x15D020 Offset: 0x15D121 VA: 0x15D020
	private float <DistanceOffset>k__BackingField; // 0xA4

	// Properties
	public CinemachineTransposer Transposer { get; }
	public float DistanceOffset { get; set; }
	private Character CtrlCharacter { get; }
	private bool IsInput { get; }

	// Methods

	// RVA: 0x2208970 Offset: 0x2208A71 VA: 0x2208970
	public CinemachineTransposer get_Transposer() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B430 Offset: 0x19B531 VA: 0x19B430
	// RVA: 0x2208980 Offset: 0x2208A81 VA: 0x2208980 Slot: 9
	public float get_DistanceOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B440 Offset: 0x19B541 VA: 0x19B440
	// RVA: 0x2208990 Offset: 0x2208A91 VA: 0x2208990 Slot: 10
	public void set_DistanceOffset(float value) { }

	// RVA: 0x22089A0 Offset: 0x2208AA1 VA: 0x22089A0
	private Character get_CtrlCharacter() { }

	// RVA: 0x2208A00 Offset: 0x2208B01 VA: 0x2208A00
	private bool get_IsInput() { }

	// RVA: 0x2208A30 Offset: 0x2208B31 VA: 0x2208A30 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2208B80 Offset: 0x2208C81 VA: 0x2208B80
	protected void Start() { }

	// RVA: 0x2208C20 Offset: 0x2208D21 VA: 0x2208C20 Slot: 5
	public void PreUpdate() { }

	// RVA: 0x2208C40 Offset: 0x2208D41 VA: 0x2208C40 Slot: 6
	public void FrameUpdate() { }

	// RVA: 0x2209600 Offset: 0x2209701 VA: 0x2209600 Slot: 7
	public void TimeStepUpdate() { }

	// RVA: 0x2208E30 Offset: 0x2208F31 VA: 0x2208E30
	private void UpdateInputAxis() { }

	// RVA: 0x2209E50 Offset: 0x2209F51 VA: 0x2209E50
	private void AutoRotateTimeReset() { }

	// RVA: 0x2208F60 Offset: 0x2209061 VA: 0x2208F60
	private void UpdateAutoRotateState() { }

	// RVA: 0x2209C90 Offset: 0x2209D91 VA: 0x2209C90
	private void UpdateAutoRotateAxis() { }

	// RVA: 0x2209970 Offset: 0x2209A71 VA: 0x2209970
	private void UpdateDeadZone() { }

	// RVA: 0x2209E60 Offset: 0x2209F61 VA: 0x2209E60 Slot: 8
	public void CameraReset(Nullable<Quaternion> resetRotation) { }

	// RVA: 0x2208D00 Offset: 0x2208E01 VA: 0x2208D00
	public TrackingCameraSetting GetSetting() { }

	// RVA: 0x220A3D0 Offset: 0x220A4D1 VA: 0x220A3D0
	public TrackingCameraSetting GetSetting(TrackinCameraType type) { }

	// RVA: 0x220A3F0 Offset: 0x220A4F1 VA: 0x220A3F0
	public void .ctor() { }
}

