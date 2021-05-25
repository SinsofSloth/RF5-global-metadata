public class GateEnemyController : MonsterControllerBase // TypeDefIndex: 7868
{
	// Fields
	[HeaderAttribute] // RVA: 0x169C60 Offset: 0x169D61 VA: 0x169C60
	[SerializeField] // RVA: 0x169C60 Offset: 0x169D61 VA: 0x169C60
	private GateEnemyModelContainer GateEnemyModelContainer; // 0x500
	[SerializeField] // RVA: 0x169CB0 Offset: 0x169DB1 VA: 0x169CB0
	public float SweepWaitTime; // 0x508
	[SerializeField] // RVA: 0x169CC0 Offset: 0x169DC1 VA: 0x169CC0
	private float SweepTime; // 0x50C
	[SerializeField] // RVA: 0x169CD0 Offset: 0x169DD1 VA: 0x169CD0
	private AnimationCurve SweepScale; // 0x510
	[SerializeField] // RVA: 0x169CE0 Offset: 0x169DE1 VA: 0x169CE0
	private AnimationCurve SweepSpeed; // 0x518
	[SerializeField] // RVA: 0x169CF0 Offset: 0x169DF1 VA: 0x169CF0
	private AnimationCurve EaseInOut; // 0x520
	private bool IsSweep; // 0x528
	private Coroutine SweepCoroutine; // 0x530
	private float SweepTimer; // 0x538
	private ParticleSystem[] ChildrenParticle; // 0x540
	private GateMovePoint[] GateMovePoints; // 0x548
	private int NextMoveIndex; // 0x550
	private int NowIndex; // 0x554
	private bool IsMove; // 0x558
	private float MoveCompleteTime; // 0x55C
	private float MoveLerpTimer; // 0x560
	private float MoveWaitElpasedTimer; // 0x564
	private float MoveWaitTime; // 0x568

	// Properties
	public override Vector3 GetTakeLockonPos { get; }

	// Methods

	// RVA: 0x1E44890 Offset: 0x1E44991 VA: 0x1E44890 Slot: 11
	protected override void Awake() { }

	// RVA: 0x1E44920 Offset: 0x1E44A21 VA: 0x1E44920 Slot: 40
	protected override void Update() { }

	// RVA: 0x1E44E40 Offset: 0x1E44F41 VA: 0x1E44E40 Slot: 10
	public override Vector3 get_GetTakeLockonPos() { }

	// RVA: 0x1E44F00 Offset: 0x1E45001 VA: 0x1E44F00
	private void SetupParticleSystem() { }

	// RVA: 0x1E43E60 Offset: 0x1E43F61 VA: 0x1E43E60
	public void OnSummon() { }

	// RVA: 0x1E43040 Offset: 0x1E43141 VA: 0x1E43040
	public void SetupMove(GateMovePoint[] gateMovePoints, float moveWaitTime, float moveCompleteTime) { }

	// RVA: 0x1E44970 Offset: 0x1E44A71 VA: 0x1E44970
	private void UpdateGateMove() { }

	// RVA: 0x1E41CB0 Offset: 0x1E41DB1 VA: 0x1E41CB0
	public void OnSweep() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A3A30 Offset: 0x1A3B31 VA: 0x1A3A30
	// RVA: 0x1E453A0 Offset: 0x1E454A1 VA: 0x1E453A0
	private IEnumerator SweepWait() { }

	// RVA: 0x1E44B80 Offset: 0x1E44C81 VA: 0x1E44B80
	private void UpdateSweep() { }

	// RVA: 0x1E45450 Offset: 0x1E45551 VA: 0x1E45450 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x1E45630 Offset: 0x1E45731 VA: 0x1E45630 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x1E456A0 Offset: 0x1E457A1 VA: 0x1E456A0 Slot: 111
	public override void SetStatusController(MonsterStatusBase statusController) { }

	// RVA: 0x1E45790 Offset: 0x1E45891 VA: 0x1E45790
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3AA0 Offset: 0x1A3BA1 VA: 0x1A3AA0
	// RVA: 0x1E458A0 Offset: 0x1E459A1 VA: 0x1E458A0
	private void <SetStatusController>b__31_0() { }
}

