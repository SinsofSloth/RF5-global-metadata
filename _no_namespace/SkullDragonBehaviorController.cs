public class SkullDragonBehaviorController : BossBehaviorController // TypeDefIndex: 7972
{
	// Fields
	private float LoopTimer; // 0x1C8
	private float WaitAngerTime; // 0x1CC
	private float FireBreathTimer; // 0x1D0
	private float FireBreathTime; // 0x1D4
	[CompilerGeneratedAttribute] // RVA: 0x169E70 Offset: 0x169F71 VA: 0x169E70
	private bool <IsRedyFireBreath>k__BackingField; // 0x1D8
	private float MaxHP; // 0x1DC
	private float MaxTailDamageHPPercent; // 0x1E0
	private float TailTotalDamage; // 0x1E4
	private SkullDragonController _SkullDragonController; // 0x1E8
	private int BehaviorSkipCount; // 0x1F0
	private bool _IsFilledTailDamage; // 0x1F4

	// Properties
	public bool IsRedyFireBreath { get; set; }
	private SkullDragonController SkullDragonController { get; }
	private bool IsFilledTailDamage { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A4CD0 Offset: 0x1A4DD1 VA: 0x1A4CD0
	// RVA: 0x1C55A90 Offset: 0x1C55B91 VA: 0x1C55A90
	public bool get_IsRedyFireBreath() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4CE0 Offset: 0x1A4DE1 VA: 0x1A4CE0
	// RVA: 0x1C55AA0 Offset: 0x1C55BA1 VA: 0x1C55AA0
	public void set_IsRedyFireBreath(bool value) { }

	// RVA: 0x1C55AB0 Offset: 0x1C55BB1 VA: 0x1C55AB0
	private SkullDragonController get_SkullDragonController() { }

	// RVA: 0x1C55B60 Offset: 0x1C55C61 VA: 0x1C55B60
	private bool get_IsFilledTailDamage() { }

	// RVA: 0x1C55B70 Offset: 0x1C55C71 VA: 0x1C55B70
	private void set_IsFilledTailDamage(bool value) { }

	// RVA: 0x1C55C30 Offset: 0x1C55D31 VA: 0x1C55C30
	private void WaitAnger_Init() { }

	// RVA: 0x1C55C40 Offset: 0x1C55D41 VA: 0x1C55C40
	private TaskStatus WaitAnger_Update() { }

	// RVA: 0x1C55CA0 Offset: 0x1C55DA1 VA: 0x1C55CA0
	private MonsterBehaviorController.BehaviorActionParam CreateAroundMoveAction() { }

	// RVA: 0x1C55DF0 Offset: 0x1C55EF1 VA: 0x1C55DF0
	private MonsterBehaviorController.BehaviorActionParam CreateThreateAction() { }

	// RVA: 0x1C55F20 Offset: 0x1C56021 VA: 0x1C55F20
	private MonsterBehaviorController.BehaviorActionParam CreateThreateAroundMoveAction() { }

	// RVA: 0x1C56050 Offset: 0x1C56151 VA: 0x1C56050
	private MonsterBehaviorController.BehaviorActionParam CreateStompAttackAction() { }

	// RVA: 0x1C56180 Offset: 0x1C56281 VA: 0x1C56180
	private MonsterBehaviorController.BehaviorActionParam CreateServerAttackAction() { }

	// RVA: 0x1C56290 Offset: 0x1C56391 VA: 0x1C56290
	private MonsterBehaviorController.BehaviorActionParam CreateMoveServerAttackAction() { }

	// RVA: 0x1C56400 Offset: 0x1C56501 VA: 0x1C56400
	private MonsterBehaviorController.BehaviorActionParam CreateRushServerAttackAction() { }

	// RVA: 0x1C565A0 Offset: 0x1C566A1 VA: 0x1C565A0
	private MonsterBehaviorController.BehaviorActionParam CreateBreathAttackAction() { }

	// RVA: 0x1C566D0 Offset: 0x1C567D1 VA: 0x1C566D0
	private MonsterBehaviorController.BehaviorActionParam CreateHeadAttackAction() { }

	// RVA: 0x1C567E0 Offset: 0x1C568E1 VA: 0x1C567E0 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x1C56A50 Offset: 0x1C56B51 VA: 0x1C56A50 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x1C56B40 Offset: 0x1C56C41 VA: 0x1C56B40 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x1C56BB0 Offset: 0x1C56CB1 VA: 0x1C56BB0 Slot: 79
	public override void EndMonsterAction() { }

	// RVA: 0x1C56CA0 Offset: 0x1C56DA1 VA: 0x1C56CA0 Slot: 59
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: 0x1C56D80 Offset: 0x1C56E81 VA: 0x1C56D80 Slot: 71
	public override void OnEndAnimEventMadnessState() { }

	// RVA: 0x1C56D90 Offset: 0x1C56E91 VA: 0x1C56D90 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x1C56ED0 Offset: 0x1C56FD1 VA: 0x1C56ED0 Slot: 95
	protected override void UpdateReciveItemBehaviorTiming() { }

	// RVA: 0x1C56FA0 Offset: 0x1C570A1 VA: 0x1C56FA0 Slot: 81
	public override void OnRestraint() { }

	// RVA: 0x1C56FB0 Offset: 0x1C570B1 VA: 0x1C56FB0 Slot: 9
	protected override void Update() { }

	// RVA: 0x1C57040 Offset: 0x1C57141 VA: 0x1C57040
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4CF0 Offset: 0x1A4DF1 VA: 0x1A4CF0
	// RVA: 0x1C57060 Offset: 0x1C57161 VA: 0x1C57060
	private void <CreateAroundMoveAction>b__22_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4D00 Offset: 0x1A4E01 VA: 0x1A4D00
	// RVA: 0x1C570C0 Offset: 0x1C571C1 VA: 0x1C570C0
	private void <CreateAroundMoveAction>b__22_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4D10 Offset: 0x1A4E11 VA: 0x1A4D10
	// RVA: 0x1C572B0 Offset: 0x1C573B1 VA: 0x1C572B0
	private void <CreateThreateAction>b__23_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4D20 Offset: 0x1A4E21 VA: 0x1A4D20
	// RVA: 0x1C57360 Offset: 0x1C57461 VA: 0x1C57360
	private void <CreateThreateAroundMoveAction>b__24_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4D30 Offset: 0x1A4E31 VA: 0x1A4D30
	// RVA: 0x1C57410 Offset: 0x1C57511 VA: 0x1C57410
	private void <CreateStompAttackAction>b__25_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4D40 Offset: 0x1A4E41 VA: 0x1A4D40
	// RVA: 0x1C57480 Offset: 0x1C57581 VA: 0x1C57480
	private void <CreateServerAttackAction>b__26_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4D50 Offset: 0x1A4E51 VA: 0x1A4D50
	// RVA: 0x1C574D0 Offset: 0x1C575D1 VA: 0x1C574D0
	private void <CreateMoveServerAttackAction>b__27_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4D60 Offset: 0x1A4E61 VA: 0x1A4D60
	// RVA: 0x1C57520 Offset: 0x1C57621 VA: 0x1C57520
	private void <CreateMoveServerAttackAction>b__27_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4D70 Offset: 0x1A4E71 VA: 0x1A4D70
	// RVA: 0x1C575E0 Offset: 0x1C576E1 VA: 0x1C575E0
	private void <CreateRushServerAttackAction>b__28_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4D80 Offset: 0x1A4E81 VA: 0x1A4D80
	// RVA: 0x1C57710 Offset: 0x1C57811 VA: 0x1C57710
	private void <CreateRushServerAttackAction>b__28_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4D90 Offset: 0x1A4E91 VA: 0x1A4D90
	// RVA: 0x1C577D0 Offset: 0x1C578D1 VA: 0x1C577D0
	private void <CreateRushServerAttackAction>b__28_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4DA0 Offset: 0x1A4EA1 VA: 0x1A4DA0
	// RVA: 0x1C57830 Offset: 0x1C57931 VA: 0x1C57830
	private void <CreateBreathAttackAction>b__29_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4DB0 Offset: 0x1A4EB1 VA: 0x1A4DB0
	// RVA: 0x1C578C0 Offset: 0x1C579C1 VA: 0x1C578C0
	private void <CreateHeadAttackAction>b__30_0() { }
}

