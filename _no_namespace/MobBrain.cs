public class MobBrain : CharacterInput // TypeDefIndex: 6736
{
	// Fields
	private const float ObstacleEnableDistance = 40;
	private const float ObstacleCheckDistance = 1.5;
	private const float ObstacleCheckRadius = 0.75;
	private const float DecelerateRemainingDistance = 3;
	private static float[] ObstacleCheckAngle; // 0x0
	private const float ObstacleAvoidDuration = 1.5;
	private const float ObstacleAvoicCoolTime = 0.5;
	private const float IgnoreObstacleDuration = 1;
	private const int BrainPathMaxPosition = 24;
	private MobBrainState m_currentState; // 0x20
	private MobBrainState m_prevState; // 0x24
	private float m_duration; // 0x28
	private float m_elapsed; // 0x2C
	private Vector3 m_targetPosition; // 0x30
	[SerializeField] // RVA: 0x15F280 Offset: 0x15F381 VA: 0x15F280
	private bool m_isPause; // 0x3C
	[SerializeField] // RVA: 0x15F290 Offset: 0x15F391 VA: 0x15F290
	private List<Transform> m_moveTargets; // 0x40
	[SerializeField] // RVA: 0x15F2A0 Offset: 0x15F3A1 VA: 0x15F2A0
	private float m_moveSpeedRate; // 0x48
	private float m_avoidElapsed; // 0x4C
	private float m_avoidCoolTime; // 0x50
	private Vector3 m_avoidDirection; // 0x54
	private bool m_ignore; // 0x60
	private float m_ignoreElapsed; // 0x64
	private static List<MobBrain> m_PathFindingQueue; // 0x8
	private static MobBrain m_CurrentPathFinder; // 0x10

	// Properties
	public NavMeshAgent NavMeshAgent { get; }
	public bool Pause { get; set; }

	// Methods

	// RVA: 0x1CB9DF0 Offset: 0x1CB9EF1 VA: 0x1CB9DF0
	public NavMeshAgent get_NavMeshAgent() { }

	// RVA: 0x1CB9E10 Offset: 0x1CB9F11 VA: 0x1CB9E10
	public bool get_Pause() { }

	// RVA: 0x1CB9E20 Offset: 0x1CB9F21 VA: 0x1CB9E20
	public void set_Pause(bool value) { }

	// RVA: 0x1CB9E80 Offset: 0x1CB9F81 VA: 0x1CB9E80 Slot: 4
	protected override void Start() { }

	// RVA: 0x1CB9EE0 Offset: 0x1CB9FE1 VA: 0x1CB9EE0
	protected void OnEnable() { }

	// RVA: 0x1CB9EF0 Offset: 0x1CB9FF1 VA: 0x1CB9EF0
	protected void OnDisable() { }

	// RVA: 0x1CB9F80 Offset: 0x1CBA081 VA: 0x1CB9F80
	public void Update() { }

	// RVA: 0x1CB9F90 Offset: 0x1CBA091 VA: 0x1CB9F90
	public void OnUpdate() { }

	// RVA: 0x1CBA060 Offset: 0x1CBA161 VA: 0x1CBA060
	public void UpdateBrainState() { }

	// RVA: 0x1CBA250 Offset: 0x1CBA351 VA: 0x1CBA250
	private MobBrain.MoveResult Move() { }

	// RVA: 0x1CBA560 Offset: 0x1CBA661 VA: 0x1CBA560
	private Vector3 GetObstacleAvoidToward(Vector3 pos, Vector3 center, Vector3 toward) { }

	// RVA: 0x1CBAB10 Offset: 0x1CBAC11 VA: 0x1CBAB10
	public static void UpdatePathFinding() { }

	// RVA: 0x1CBAE60 Offset: 0x1CBAF61 VA: 0x1CBAE60
	public void .ctor() { }

	// RVA: 0x1CBAF30 Offset: 0x1CBB031 VA: 0x1CBAF30
	private static void .cctor() { }
}

