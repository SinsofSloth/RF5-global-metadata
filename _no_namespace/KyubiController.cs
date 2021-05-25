public class KyubiController : BossMonsterContoroller // TypeDefIndex: 7925
{
	// Fields
	private List<KyubiController.FireballParameter> CreateFireBallParameterList; // 0x510
	private List<float> AttackReadyPositionZList; // 0x518
	private List<float> AttackReadyAngleList; // 0x520
	private float AddAttackReadyAngle; // 0x528
	private List<float> AttackReadyLengthList; // 0x530
	private float FireBallTimer; // 0x538
	private Transform _TailTransform; // 0x540
	private Vector3 GroundPosition; // 0x548
	private KyubiController.JumpAttackState CurrentJumpAttackState; // 0x554
	private Vector3 MoveDirection; // 0x558
	private float MoveSpeed; // 0x564
	private float JumpSpeed; // 0x568
	private float ForcusSpeed; // 0x56C
	private float AttackSpeed; // 0x570
	private float T; // 0x574
	private int BlueCount; // 0x578
	private int MaxBlueCount; // 0x57C
	private string RedFireActionScriptName; // 0x580
	private string BlueFireActionScriptName; // 0x588
	private GameObject FireBlueBall; // 0x590
	private GameObject FireRedBall; // 0x598
	private int LoadCount; // 0x5A0

	// Properties
	private Transform TailTransform { get; }

	// Methods

	// RVA: 0x2178C40 Offset: 0x2178D41 VA: 0x2178C40
	private Transform get_TailTransform() { }

	// RVA: 0x2178D50 Offset: 0x2178E51 VA: 0x2178D50 Slot: 11
	protected override void Awake() { }

	// RVA: 0x2178D60 Offset: 0x2178E61 VA: 0x2178D60 Slot: 12
	protected override void Start() { }

	// RVA: 0x2178D70 Offset: 0x2178E71 VA: 0x2178D70 Slot: 117
	protected override void OnSetupMonsterAnimationEvent(MonsterAnimatorStateEvent monsterAnimatorStateEvent) { }

	// RVA: 0x2178D80 Offset: 0x2178E81 VA: 0x2178D80 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x2178EE0 Offset: 0x2178FE1 VA: 0x2178EE0
	private void StartJumpEvent() { }

	// RVA: 0x2178F40 Offset: 0x2179041 VA: 0x2178F40
	private void EndJumpEvent() { }

	// RVA: 0x2178F50 Offset: 0x2179051 VA: 0x2178F50
	private void Attack2SE01() { }

	// RVA: 0x2178FB0 Offset: 0x21790B1 VA: 0x2178FB0
	private void Attack3SE01() { }

	// RVA: 0x2179010 Offset: 0x2179111 VA: 0x2179010
	private void Attack3SE02() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A4540 Offset: 0x1A4641 VA: 0x1A4540
	// RVA: 0x2179070 Offset: 0x2179171 VA: 0x2179070 Slot: 131
	protected override IEnumerator OnSetupAsync() { }

	// RVA: 0x2178DB0 Offset: 0x2178EB1 VA: 0x2178DB0
	private void RemoveFireBallPrefab() { }

	// RVA: 0x2179120 Offset: 0x2179221 VA: 0x2179120
	private void FireballSpawn(Vector3 readyAttackPosition) { }

	// RVA: 0x2179620 Offset: 0x2179721 VA: 0x2179620
	public void CreateProjectile() { }

	// RVA: 0x2179C50 Offset: 0x2179D51 VA: 0x2179C50
	private void UpdateCreateFireBall() { }

	// RVA: 0x2179E10 Offset: 0x2179F11 VA: 0x2179E10
	public void StartJump() { }

	// RVA: 0x2179ED0 Offset: 0x2179FD1 VA: 0x2179ED0
	public void StartForcus() { }

	// RVA: 0x217A030 Offset: 0x217A131 VA: 0x217A030
	public void StartAttack() { }

	// RVA: 0x217A150 Offset: 0x217A251 VA: 0x217A150
	private void StartBrake() { }

	// RVA: 0x217A1B0 Offset: 0x217A2B1 VA: 0x217A1B0
	private void UpdateJumpState() { }

	// RVA: 0x217A330 Offset: 0x217A431 VA: 0x217A330
	private void UpdateFocusState() { }

	// RVA: 0x217A490 Offset: 0x217A591 VA: 0x217A490
	private void UpdateAttackState() { }

	// RVA: 0x217A750 Offset: 0x217A851 VA: 0x217A750
	private void UpdateBrakeState() { }

	// RVA: 0x217A850 Offset: 0x217A951 VA: 0x217A850
	private void UpdateJumpAttack() { }

	// RVA: 0x217AAC0 Offset: 0x217ABC1 VA: 0x217AAC0
	private void UpdateGroundHeight() { }

	// RVA: 0x217AC90 Offset: 0x217AD91 VA: 0x217AC90
	private void EndJumpAttack() { }

	// RVA: 0x217AD30 Offset: 0x217AE31 VA: 0x217AD30 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x217AD60 Offset: 0x217AE61 VA: 0x217AD60 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x217AEE0 Offset: 0x217AFE1 VA: 0x217AEE0 Slot: 40
	protected override void Update() { }

	// RVA: 0x217AF10 Offset: 0x217B011 VA: 0x217AF10
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A45B0 Offset: 0x1A46B1 VA: 0x1A45B0
	// RVA: 0x217B0E0 Offset: 0x217B1E1 VA: 0x217B0E0
	private void <OnSetupAsync>b__35_0(AssetHandle<GameObject> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A45C0 Offset: 0x1A46C1 VA: 0x1A45C0
	// RVA: 0x217B170 Offset: 0x217B271 VA: 0x217B170
	private void <OnSetupAsync>b__35_1(AssetHandle<GameObject> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A45D0 Offset: 0x1A46D1 VA: 0x1A45D0
	[DebuggerHiddenAttribute] // RVA: 0x1A45D0 Offset: 0x1A46D1 VA: 0x1A45D0
	// RVA: 0x217B200 Offset: 0x217B301 VA: 0x217B200
	private IEnumerator <>n__0() { }
}

