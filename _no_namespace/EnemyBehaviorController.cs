public class EnemyBehaviorController : MonsterBehaviorController // TypeDefIndex: 7848
{
	// Fields
	private const float SearchCharacterControllerTickTime = 0.2;
	public Vector3[] PatrolPoints; // 0x120
	public GateController GateController; // 0x128
	private int CurrentPatrolIndex; // 0x130
	private SharedBool IsInTerritory; // 0x138
	private SharedEnemyBehaviorTreeState State; // 0x140
	private Vector3 TerritoryCenterPosition; // 0x148
	[CompilerGeneratedAttribute] // RVA: 0x169B60 Offset: 0x169C61 VA: 0x169B60
	private float <MaxCautionTime>k__BackingField; // 0x154
	[CompilerGeneratedAttribute] // RVA: 0x169B70 Offset: 0x169C71 VA: 0x169B70
	private float <MinCautionTime>k__BackingField; // 0x158
	public Vector3 ExecPoint; // 0x15C
	private GameObject SoulEffect; // 0x168
	private SimpleHpBar SimpleHpBar; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x169B80 Offset: 0x169C81 VA: 0x169B80
	private MonsterActionBehaviorController <ActionBehaviorController>k__BackingField; // 0x178

	// Properties
	public float MaxCautionTime { get; set; }
	public float MinCautionTime { get; set; }
	public MonsterActionBehaviorController ActionBehaviorController { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A33E0 Offset: 0x1A34E1 VA: 0x1A33E0
	// RVA: 0x201C3A0 Offset: 0x201C4A1 VA: 0x201C3A0
	public float get_MaxCautionTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A33F0 Offset: 0x1A34F1 VA: 0x1A33F0
	// RVA: 0x201C3B0 Offset: 0x201C4B1 VA: 0x201C3B0
	private void set_MaxCautionTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3400 Offset: 0x1A3501 VA: 0x1A3400
	// RVA: 0x201C3C0 Offset: 0x201C4C1 VA: 0x201C3C0
	public float get_MinCautionTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3410 Offset: 0x1A3511 VA: 0x1A3410
	// RVA: 0x201C3D0 Offset: 0x201C4D1 VA: 0x201C3D0
	private void set_MinCautionTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3420 Offset: 0x1A3521 VA: 0x1A3420
	// RVA: 0x201C3E0 Offset: 0x201C4E1 VA: 0x201C3E0
	public MonsterActionBehaviorController get_ActionBehaviorController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3430 Offset: 0x1A3531 VA: 0x1A3430
	// RVA: 0x201C3F0 Offset: 0x201C4F1 VA: 0x201C3F0
	protected void set_ActionBehaviorController(MonsterActionBehaviorController value) { }

	// RVA: 0x201C400 Offset: 0x201C501 VA: 0x201C400 Slot: 4
	protected override void Start() { }

	// RVA: 0x201C410 Offset: 0x201C511 VA: 0x201C410
	public void UpdateTerritory() { }

	// RVA: 0x201C4F0 Offset: 0x201C5F1 VA: 0x201C4F0 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x201C970 Offset: 0x201CA71 VA: 0x201C970 Slot: 11
	protected override void OnRelese() { }

	// RVA: 0x201CA40 Offset: 0x201CB41 VA: 0x201CA40
	private void OnDisable() { }

	// RVA: 0x201CAF0 Offset: 0x201CBF1 VA: 0x201CAF0 Slot: 19
	protected override void OnGetVariableBehaviorParameter() { }

	// RVA: 0x201CC30 Offset: 0x201CD31 VA: 0x201CC30
	private bool IgnoreCharacter(Character character) { }

	// RVA: 0x201CC70 Offset: 0x201CD71 VA: 0x201CC70 Slot: 15
	public override void SetupSearchCharacterController() { }

	// RVA: 0x201CE60 Offset: 0x201CF61 VA: 0x201CE60 Slot: 9
	protected override void Update() { }

	// RVA: 0x201C4D0 Offset: 0x201C5D1 VA: 0x201C4D0
	public bool IsHoldPatrolPoint() { }

	// RVA: 0x201D1C0 Offset: 0x201D2C1 VA: 0x201D1C0 Slot: 59
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: 0x201D3D0 Offset: 0x201D4D1 VA: 0x201D3D0
	public PatrolBehaviorType GetPatrollBehavior(out float moveSpeedScale, out float moveTime, out int waitCount) { }

	// RVA: 0x201D7C0 Offset: 0x201D8C1 VA: 0x201D7C0
	public Vector3 GetPatrollPosition() { }

	// RVA: 0x201D840 Offset: 0x201D941 VA: 0x201D840
	public MonsterActionInformation GetNearestDistanceAttackInformation(float distance) { }

	// RVA: 0x201D150 Offset: 0x201D251 VA: 0x201D150
	public void OnEnterGateArea() { }

	// RVA: 0x201D080 Offset: 0x201D181 VA: 0x201D080
	public void OnExitGateArea() { }

	// RVA: 0x201D9E0 Offset: 0x201DAE1 VA: 0x201D9E0 Slot: 65
	public override void OnEndActionScript() { }

	// RVA: 0x201DAA0 Offset: 0x201DBA1 VA: 0x201DAA0 Slot: 80
	public override void OnHearFootSteps() { }

	// RVA: 0x201DB90 Offset: 0x201DC91 VA: 0x201DB90 Slot: 83
	protected override void OnEndContDeadFade() { }

	// RVA: 0x201DD50 Offset: 0x201DE51 VA: 0x201DD50 Slot: 67
	public override void OnEndAnimEventDeadState() { }

	// RVA: 0x201DD80 Offset: 0x201DE81 VA: 0x201DD80 Slot: 73
	public override void OnEndAnimEventWait_2State() { }

	// RVA: 0x201C6D0 Offset: 0x201C7D1 VA: 0x201C6D0
	private void SetCautionWaitTime() { }

	// RVA: 0x201C750 Offset: 0x201C851 VA: 0x201C750
	private void SetupActionBehaviorContriller() { }

	// RVA: 0x201DDF0 Offset: 0x201DEF1 VA: 0x201DDF0 Slot: 76
	public override void SetupMonsterAction() { }

	// RVA: 0x201DE40 Offset: 0x201DF41 VA: 0x201DE40 Slot: 77
	public override void ExecuteMonsterAction(int index) { }

	// RVA: 0x201DE60 Offset: 0x201DF61 VA: 0x201DE60
	private bool IsFireWoolScene(FieldSceneId sceneId) { }

	// RVA: 0x201DEB0 Offset: 0x201DFB1 VA: 0x201DEB0
	private bool IsFireWoolField(FieldPlaceId fieldPlaceId) { }

	// RVA: 0x201C7D0 Offset: 0x201C8D1 VA: 0x201C7D0
	private void CheckStageWool() { }

	// RVA: 0x201DEC0 Offset: 0x201DFC1 VA: 0x201DEC0 Slot: 21
	protected override void OnDrawGizmosSelected() { }

	// RVA: 0x201DED0 Offset: 0x201DFD1 VA: 0x201DED0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3440 Offset: 0x1A3541 VA: 0x1A3440
	// RVA: 0x201DEE0 Offset: 0x201DFE1 VA: 0x201DEE0
	private void <OnEndContDeadFade>b__40_0() { }
}

