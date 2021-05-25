public class CerberusBehaviorController : BossBehaviorController // TypeDefIndex: 7824
{
	// Fields
	private const float OpossumHPPercent = 20;
	private float CheckTargetRangeValue; // 0x1C8
	private bool IsInRange; // 0x1CC
	private List<MonsterActionBehaviorType> TargetInRangeBehaviorList; // 0x1D0
	private List<MonsterActionBehaviorType> TargetOutRangeBehaviorList; // 0x1D8
	private List<MonsterActionBehaviorType> RestrainBehaviorList; // 0x1E0
	private List<MonsterActionBehaviorType> NotRestrainBehaviorList; // 0x1E8
	private CerberusController controller; // 0x1F0
	private bool IsRestrain; // 0x1F8
	private bool OpossumBefor; // 0x1F9
	private bool IsGetUp; // 0x1FA

	// Properties
	private bool IsOpossum { get; }
	private bool IsEndOpossumAnimation { get; }

	// Methods

	// RVA: 0x1D3B0D0 Offset: 0x1D3B1D1 VA: 0x1D3B0D0
	private bool get_IsOpossum() { }

	// RVA: 0x1D3B0F0 Offset: 0x1D3B1F1 VA: 0x1D3B0F0
	private bool get_IsEndOpossumAnimation() { }

	// RVA: 0x1D3B110 Offset: 0x1D3B211 VA: 0x1D3B110
	private TaskStatus CheckTargetInRange_Update() { }

	// RVA: 0x1D3B330 Offset: 0x1D3B431 VA: 0x1D3B330
	private TaskStatus CheckRestrain_Update() { }

	// RVA: 0x1D3B3E0 Offset: 0x1D3B4E1 VA: 0x1D3B3E0
	private MonsterBehaviorController.BehaviorActionParam CreateBiteAttackAction() { }

	// RVA: 0x1D3B4E0 Offset: 0x1D3B5E1 VA: 0x1D3B4E0
	private MonsterBehaviorController.BehaviorActionParam CreateStrikeAttackAction() { }

	// RVA: 0x1D3B5E0 Offset: 0x1D3B6E1 VA: 0x1D3B5E0
	private MonsterBehaviorController.BehaviorActionParam CreateSever11AttackAction() { }

	// RVA: 0x1D3B6E0 Offset: 0x1D3B7E1 VA: 0x1D3B6E0
	private MonsterBehaviorController.BehaviorActionParam CreateSever12AttackAction() { }

	// RVA: 0x1D3B7E0 Offset: 0x1D3B8E1 VA: 0x1D3B7E0
	private MonsterBehaviorController.BehaviorActionParam CreateSplitAttack() { }

	// RVA: 0x1D3B940 Offset: 0x1D3BA41 VA: 0x1D3B940
	private MonsterBehaviorController.BehaviorActionParam CreateOpossumBeehavior() { }

	// RVA: 0x1D3BAC0 Offset: 0x1D3BBC1 VA: 0x1D3BAC0
	private MonsterBehaviorController.BehaviorActionParam CreateDarkBallAttackAction() { }

	// RVA: 0x1D3BBC0 Offset: 0x1D3BCC1 VA: 0x1D3BBC0
	private MonsterBehaviorController.BehaviorActionParam CreateMovement() { }

	// RVA: 0x1D3BD10 Offset: 0x1D3BE11 VA: 0x1D3BD10
	private MonsterBehaviorController.BehaviorActionParam CreateBackJump() { }

	// RVA: 0x1D3BE60 Offset: 0x1D3BF61 VA: 0x1D3BE60 Slot: 56
	public override void OnHitAttack() { }

	// RVA: 0x1D3BE70 Offset: 0x1D3BF71 VA: 0x1D3BE70 Slot: 4
	protected override void Start() { }

	// RVA: 0x1D3BF10 Offset: 0x1D3C011 VA: 0x1D3BF10 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x1D3C280 Offset: 0x1D3C381 VA: 0x1D3C280 Slot: 76
	public override void SetupMonsterAction() { }

	// RVA: 0x1D3C2C0 Offset: 0x1D3C3C1 VA: 0x1D3C2C0 Slot: 71
	public override void OnEndAnimEventMadnessState() { }

	// RVA: 0x1D3C300 Offset: 0x1D3C401 VA: 0x1D3C300 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x1D3C340 Offset: 0x1D3C441 VA: 0x1D3C340 Slot: 59
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: 0x1D3C550 Offset: 0x1D3C651 VA: 0x1D3C550 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x1D3C5C0 Offset: 0x1D3C6C1 VA: 0x1D3C5C0 Slot: 95
	protected override void UpdateReciveItemBehaviorTiming() { }

	// RVA: 0x1D3C760 Offset: 0x1D3C861 VA: 0x1D3C760 Slot: 81
	public override void OnRestraint() { }

	// RVA: 0x1D3C790 Offset: 0x1D3C891 VA: 0x1D3C790
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3110 Offset: 0x1A3211 VA: 0x1A3110
	// RVA: 0x1D3C880 Offset: 0x1D3C981 VA: 0x1D3C880
	private void <CreateBiteAttackAction>b__22_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3120 Offset: 0x1A3221 VA: 0x1A3120
	// RVA: 0x1D3C910 Offset: 0x1D3CA11 VA: 0x1D3C910
	private void <CreateStrikeAttackAction>b__23_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3130 Offset: 0x1A3231 VA: 0x1A3130
	// RVA: 0x1D3C960 Offset: 0x1D3CA61 VA: 0x1D3C960
	private void <CreateSever11AttackAction>b__24_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3140 Offset: 0x1A3241 VA: 0x1A3140
	// RVA: 0x1D3C9F0 Offset: 0x1D3CAF1 VA: 0x1D3C9F0
	private void <CreateSever12AttackAction>b__25_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3150 Offset: 0x1A3251 VA: 0x1A3150
	// RVA: 0x1D3CA80 Offset: 0x1D3CB81 VA: 0x1D3CA80
	private void <CreateSplitAttack>b__26_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3160 Offset: 0x1A3261 VA: 0x1A3160
	// RVA: 0x1D3CAF0 Offset: 0x1D3CBF1 VA: 0x1D3CAF0
	private void <CreateSplitAttack>b__26_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3170 Offset: 0x1A3271 VA: 0x1A3170
	// RVA: 0x1D3CBF0 Offset: 0x1D3CCF1 VA: 0x1D3CBF0
	private void <CreateOpossumBeehavior>b__27_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3180 Offset: 0x1A3281 VA: 0x1A3180
	// RVA: 0x1D3CC80 Offset: 0x1D3CD81 VA: 0x1D3CC80
	private void <CreateOpossumBeehavior>b__27_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3190 Offset: 0x1A3291 VA: 0x1A3190
	// RVA: 0x1D3CCA0 Offset: 0x1D3CDA1 VA: 0x1D3CCA0
	private void <CreateOpossumBeehavior>b__27_2(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A31A0 Offset: 0x1A32A1 VA: 0x1A31A0
	// RVA: 0x1D3CCC0 Offset: 0x1D3CDC1 VA: 0x1D3CCC0
	private void <CreateDarkBallAttackAction>b__28_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A31B0 Offset: 0x1A32B1 VA: 0x1A31B0
	// RVA: 0x1D3CD10 Offset: 0x1D3CE11 VA: 0x1D3CD10
	private void <CreateMovement>b__29_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A31C0 Offset: 0x1A32C1 VA: 0x1A31C0
	// RVA: 0x1D3CD80 Offset: 0x1D3CE81 VA: 0x1D3CD80
	private void <CreateMovement>b__29_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A31D0 Offset: 0x1A32D1 VA: 0x1A31D0
	// RVA: 0x1D3CE00 Offset: 0x1D3CF01 VA: 0x1D3CE00
	private void <CreateBackJump>b__30_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A31E0 Offset: 0x1A32E1 VA: 0x1A31E0
	// RVA: 0x1D3CE70 Offset: 0x1D3CF71 VA: 0x1D3CE70
	private void <CreateBackJump>b__30_1(int index, int type) { }
}

