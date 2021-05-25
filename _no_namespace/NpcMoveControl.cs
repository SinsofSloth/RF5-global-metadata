public class NpcMoveControl : MonoBehaviour // TypeDefIndex: 8140
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16B480 Offset: 0x16B581 VA: 0x16B480
	private NpcMoveControl.STATE <State>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x16B490 Offset: 0x16B591 VA: 0x16B490
	public NpcMoveControl.MOVE_TYPE MoveType; // 0x1C
	[SerializeField] // RVA: 0x16B4A0 Offset: 0x16B5A1 VA: 0x16B4A0
	private NavMeshAgent m_NavMeshAgent; // 0x20
	[SerializeField] // RVA: 0x16B4B0 Offset: 0x16B5B1 VA: 0x16B4B0
	private CharacterMovement m_CharacterMovement; // 0x28
	[SerializeField] // RVA: 0x16B4C0 Offset: 0x16B5C1 VA: 0x16B4C0
	[RangeAttribute] // RVA: 0x16B4C0 Offset: 0x16B5C1 VA: 0x16B4C0
	private float m_OutDoorSpeedRate; // 0x30
	[SerializeField] // RVA: 0x16B500 Offset: 0x16B601 VA: 0x16B500
	[RangeAttribute] // RVA: 0x16B500 Offset: 0x16B601 VA: 0x16B500
	private float m_InDoorSpeedRate; // 0x34
	[SerializeField] // RVA: 0x16B540 Offset: 0x16B641 VA: 0x16B540
	private float m_SpeedScale; // 0x38
	private NpcMoveControl.MOVE_TYPE move_type_; // 0x3C
	private NavMeshPath path_; // 0x40
	private Vector3 start_; // 0x48
	private Quaternion start_rot_; // 0x54
	private Vector3 goal_; // 0x64
	private float speed_; // 0x70
	private Tweener tween_; // 0x78
	private Animator anim_; // 0x80
	private Vector3 old_pos; // 0x88
	private bool pause_; // 0x94
	private bool moveEnabled; // 0x95
	private const float ObstacleEnableDistance = 40;
	private const float ObstacleCheckDistance = 1.5;
	private const float ObstacleCheckDistanceAdd = 1;
	private const float ObstacleCheckRadius = 0.75;
	private const float DecelerateRemainingDistance = 3;
	private static float[] ObstacleCheckAngle; // 0x0
	private const float ObstacleAvoidDuration = 1.5;
	private const float ObstacleAvoicCoolTime = 0.25;
	private const float ObstacleAvoicCoolTimeSub = 0.15;
	private const float IgnoreObstacleDuration = 1;
	private float m_avoidElapsed; // 0x98
	private float m_avoidCoolTime; // 0x9C
	private Vector3 m_avoidDirection; // 0xA0
	private bool m_ignore; // 0xAC
	private float m_ignoreElapsed; // 0xB0
	private const float m_MovementSpeedMax = 4;
	private const float m_MovementAcceleration = 4;
	private const float m_MovementDeceleration = 8;
	[CompilerGeneratedAttribute] // RVA: 0x16B550 Offset: 0x16B651 VA: 0x16B550
	private bool <IsInDoor>k__BackingField; // 0xB4
	private const float m_MovementAngularSpeed = 80;

	// Properties
	[SerializeField] // RVA: 0x1B9000 Offset: 0x1B9101 VA: 0x1B9000
	public NpcMoveControl.STATE State { get; set; }
	public CharacterMovement Movement { get; }
	public float SpeedScale { get; }
	public bool IsInDoor { get; set; }
	public float speed { get; set; }
	public float remainingDistance { get; }
	public bool IsReady { get; }
	public bool MoveEnable { get; set; }
	public bool Pause { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6420 Offset: 0x1A6521 VA: 0x1A6420
	// RVA: 0x1D87B00 Offset: 0x1D87C01 VA: 0x1D87B00
	public NpcMoveControl.STATE get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6430 Offset: 0x1A6531 VA: 0x1A6430
	// RVA: 0x1D87B10 Offset: 0x1D87C11 VA: 0x1D87B10
	private void set_State(NpcMoveControl.STATE value) { }

	// RVA: 0x1D87B20 Offset: 0x1D87C21 VA: 0x1D87B20
	public CharacterMovement get_Movement() { }

	// RVA: 0x1D87B30 Offset: 0x1D87C31 VA: 0x1D87B30
	public float get_SpeedScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6440 Offset: 0x1A6541 VA: 0x1A6440
	// RVA: 0x1D87B40 Offset: 0x1D87C41 VA: 0x1D87B40
	public bool get_IsInDoor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6450 Offset: 0x1A6551 VA: 0x1A6450
	// RVA: 0x1D87B50 Offset: 0x1D87C51 VA: 0x1D87B50
	private void set_IsInDoor(bool value) { }

	// RVA: 0x1D87B60 Offset: 0x1D87C61 VA: 0x1D87B60
	public float get_speed() { }

	// RVA: 0x1D87B70 Offset: 0x1D87C71 VA: 0x1D87B70
	public void set_speed(float value) { }

	// RVA: 0x1D87B80 Offset: 0x1D87C81 VA: 0x1D87B80
	public float get_remainingDistance() { }

	// RVA: 0x1D87C40 Offset: 0x1D87D41 VA: 0x1D87C40
	public bool get_IsReady() { }

	// RVA: 0x1D87D00 Offset: 0x1D87E01 VA: 0x1D87D00
	public bool get_MoveEnable() { }

	// RVA: 0x1D84730 Offset: 0x1D84831 VA: 0x1D84730
	public void set_MoveEnable(bool value) { }

	// RVA: 0x1D87D10 Offset: 0x1D87E11 VA: 0x1D87D10
	public void StopMove() { }

	// RVA: 0x1D87ED0 Offset: 0x1D87FD1 VA: 0x1D87ED0
	public void StartMove() { }

	// RVA: 0x1D87F50 Offset: 0x1D88051 VA: 0x1D87F50
	public void SetIdle() { }

	// RVA: 0x1D88010 Offset: 0x1D88111 VA: 0x1D88010
	private void Start() { }

	// RVA: 0x1D88240 Offset: 0x1D88341 VA: 0x1D88240
	private void Update() { }

	// RVA: 0x1D89310 Offset: 0x1D89411 VA: 0x1D89310
	private void FixedUpdate() { }

	// RVA: 0x1D89450 Offset: 0x1D89551 VA: 0x1D89450 Slot: 4
	protected virtual void UpdateRotate(float deltaTime) { }

	// RVA: 0x1D894C0 Offset: 0x1D895C1 VA: 0x1D894C0 Slot: 5
	protected virtual void UpdateMove(float deltaTime) { }

	// RVA: 0x1D89560 Offset: 0x1D89661 VA: 0x1D89560
	public bool get_Pause() { }

	// RVA: 0x1D87DA0 Offset: 0x1D87EA1 VA: 0x1D87DA0
	public void set_Pause(bool value) { }

	// RVA: 0x1D89570 Offset: 0x1D89671 VA: 0x1D89570
	public void SetRoute(Vector3 start, Vector3 goal, float speed, bool go = True) { }

	// RVA: 0x1D89680 Offset: 0x1D89781 VA: 0x1D89680
	public void SetRoute(Transform start, Vector3 goal, float speed, bool go = True) { }

	// RVA: 0x1D89740 Offset: 0x1D89841 VA: 0x1D89740
	public void SetRoute(Vector3 goal, float speed, bool go = True) { }

	// RVA: 0x1D89770 Offset: 0x1D89871 VA: 0x1D89770
	public void Go() { }

	// RVA: 0x1D895A0 Offset: 0x1D896A1 VA: 0x1D895A0
	public void GoRestart() { }

	// RVA: 0x1D89850 Offset: 0x1D89951 VA: 0x1D89850
	public void SetTestRoute(NpcMoveControl.MOVE_TYPE type, Vector3 start, Vector3 goal, float speed) { }

	// RVA: 0x1D89870 Offset: 0x1D89971 VA: 0x1D89870
	public void OnTestGo() { }

	// RVA: 0x1D89950 Offset: 0x1D89A51 VA: 0x1D89950
	public void OnTestGoRestart() { }

	// RVA: 0x1D88550 Offset: 0x1D88651 VA: 0x1D88550
	private NpcMoveControl.STATE StateInit(NpcMoveControl.MOVE_TYPE move_type) { }

	// RVA: 0x1D885D0 Offset: 0x1D886D1 VA: 0x1D885D0
	private NpcMoveControl.STATE StateStart(NpcMoveControl.MOVE_TYPE move_type) { }

	// RVA: 0x1D88720 Offset: 0x1D88821 VA: 0x1D88720
	private NpcMoveControl.STATE StateCalc(NpcMoveControl.MOVE_TYPE move_type) { }

	// RVA: 0x1D88A30 Offset: 0x1D88B31 VA: 0x1D88A30
	private NpcMoveControl.STATE StateMove(NpcMoveControl.MOVE_TYPE move_type) { }

	// RVA: 0x1D89A30 Offset: 0x1D89B31 VA: 0x1D89A30
	private Vector3 GetObstacleAvoidToward(Vector3 pos, Vector3 center, Vector3 toward, float maxDistance, float speedRate) { }

	// RVA: 0x1D8A060 Offset: 0x1D8A161 VA: 0x1D8A060
	public void SetOutDoorMode() { }

	// RVA: 0x1D8A140 Offset: 0x1D8A241 VA: 0x1D8A140
	public void SetInDoorMode() { }

	// RVA: 0x1D8A220 Offset: 0x1D8A321 VA: 0x1D8A220
	public void ClearVelocity() { }

	// RVA: 0x1D8A2A0 Offset: 0x1D8A3A1 VA: 0x1D8A2A0
	public void .ctor() { }

	// RVA: 0x1D8A340 Offset: 0x1D8A441 VA: 0x1D8A340
	private static void .cctor() { }
}

