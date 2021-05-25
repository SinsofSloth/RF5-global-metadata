public class AudmuraBehaviorController : BossBehaviorController // TypeDefIndex: 7800
{
	// Fields
	private const int BackAttackSerchKey = 3;
	private readonly MonsterSearchRangeParameter BackAttackSearchRangeParameter; // 0x1C8

	// Methods

	// RVA: 0x2289F20 Offset: 0x228A021 VA: 0x2289F20 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x228AEF0 Offset: 0x228AFF1 VA: 0x228AEF0 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x228AF30 Offset: 0x228B031 VA: 0x228AF30 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x228B030 Offset: 0x228B131 VA: 0x228B030 Slot: 50
	protected override void AddMonsterSearchParameter() { }

	// RVA: 0x228B180 Offset: 0x228B281 VA: 0x228B180 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x228B270 Offset: 0x228B371 VA: 0x228B270 Slot: 95
	protected override void UpdateReciveItemBehaviorTiming() { }

	// RVA: 0x228A110 Offset: 0x228A211 VA: 0x228A110
	private MonsterBehaviorController.BehaviorActionParam CreateBackKickAttack() { }

	// RVA: 0x228A2D0 Offset: 0x228A3D1 VA: 0x228A2D0
	private MonsterBehaviorController.BehaviorActionParam CreateSwingingAroundAttack() { }

	// RVA: 0x228A4B0 Offset: 0x228A5B1 VA: 0x228A4B0
	private MonsterBehaviorController.BehaviorActionParam CreateCrystallizationAttack() { }

	// RVA: 0x228A690 Offset: 0x228A791 VA: 0x228A690
	private MonsterBehaviorController.BehaviorActionParam CreateReflectiveLaserAttack() { }

	// RVA: 0x228A860 Offset: 0x228A961 VA: 0x228A860
	private MonsterBehaviorController.BehaviorActionParam CreateTiltSwingingAroundAttack() { }

	// RVA: 0x228AA40 Offset: 0x228AB41 VA: 0x228AA40
	private MonsterBehaviorController.BehaviorActionParam CreateJumpAttack() { }

	// RVA: 0x228AC10 Offset: 0x228AD11 VA: 0x228AC10
	private MonsterBehaviorController.BehaviorActionParam CreateThreeWayLaserAttack() { }

	// RVA: 0x228ADE0 Offset: 0x228AEE1 VA: 0x228ADE0
	private MonsterBehaviorController.BehaviorActionParam CreateAroundMove() { }

	// RVA: 0x228B340 Offset: 0x228B441 VA: 0x228B340 Slot: 89
	public override string GetLotteryTypeEnumToString(int SelectType) { }

	// RVA: 0x228B480 Offset: 0x228B581 VA: 0x228B480
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2E10 Offset: 0x1A2F11 VA: 0x1A2E10
	// RVA: 0x228B4A0 Offset: 0x228B5A1 VA: 0x228B4A0
	private bool <OnUpdateBossDataBitArray>b__4_0(Character character) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2E20 Offset: 0x1A2F21 VA: 0x1A2E20
	// RVA: 0x228B550 Offset: 0x228B651 VA: 0x228B550
	private void <CreateBackKickAttack>b__8_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2E30 Offset: 0x1A2F31 VA: 0x1A2E30
	// RVA: 0x228B5A0 Offset: 0x228B6A1 VA: 0x228B5A0
	private void <CreateSwingingAroundAttack>b__9_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2E40 Offset: 0x1A2F41 VA: 0x1A2E40
	// RVA: 0x228B5F0 Offset: 0x228B6F1 VA: 0x228B5F0
	private void <CreateCrystallizationAttack>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2E50 Offset: 0x1A2F51 VA: 0x1A2E50
	// RVA: 0x228B640 Offset: 0x228B741 VA: 0x228B640
	private void <CreateReflectiveLaserAttack>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2E60 Offset: 0x1A2F61 VA: 0x1A2E60
	// RVA: 0x228B690 Offset: 0x228B791 VA: 0x228B690
	private void <CreateTiltSwingingAroundAttack>b__12_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2E70 Offset: 0x1A2F71 VA: 0x1A2E70
	// RVA: 0x228B6E0 Offset: 0x228B7E1 VA: 0x228B6E0
	private void <CreateJumpAttack>b__13_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2E80 Offset: 0x1A2F81 VA: 0x1A2E80
	// RVA: 0x228B730 Offset: 0x228B831 VA: 0x228B730
	private void <CreateThreeWayLaserAttack>b__14_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2E90 Offset: 0x1A2F91 VA: 0x1A2E90
	// RVA: 0x228B780 Offset: 0x228B881 VA: 0x228B780
	private void <CreateAroundMove>b__15_0(int index, int type) { }
}

