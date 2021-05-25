public class HarinezumiBehaviorController : BossBehaviorController // TypeDefIndex: 7873
{
	// Fields
	private HarinezumiController _HarinezumiController; // 0x1C8
	private float RespawnNeedleTime; // 0x1D0

	// Properties
	private HarinezumiController HarinezumiController { get; }

	// Methods

	// RVA: 0x22F5300 Offset: 0x22F5401 VA: 0x22F5300
	private HarinezumiController get_HarinezumiController() { }

	// RVA: 0x22F53E0 Offset: 0x22F54E1 VA: 0x22F53E0
	private MonsterBehaviorController.BehaviorActionParam CreateShotNeedleAttackAction() { }

	// RVA: 0x22F5500 Offset: 0x22F5601 VA: 0x22F5500
	private MonsterBehaviorController.BehaviorActionParam CreateRushAttackAction() { }

	// RVA: 0x22F5620 Offset: 0x22F5721 VA: 0x22F5620
	private MonsterBehaviorController.BehaviorActionParam CreateScratchAttackAction() { }

	// RVA: 0x22F5740 Offset: 0x22F5841 VA: 0x22F5740
	private MonsterBehaviorController.BehaviorActionParam CreateSpinAttackAction() { }

	// RVA: 0x22F5860 Offset: 0x22F5961 VA: 0x22F5860
	private MonsterBehaviorController.BehaviorActionParam CreateTreateAction() { }

	// RVA: 0x22F5980 Offset: 0x22F5A81 VA: 0x22F5980
	private MonsterBehaviorController.BehaviorActionParam CreateJumpAction() { }

	// RVA: 0x22F5AA0 Offset: 0x22F5BA1 VA: 0x22F5AA0
	private MonsterBehaviorController.BehaviorActionParam CreateApproachWalk() { }

	// RVA: 0x22F5BF0 Offset: 0x22F5CF1 VA: 0x22F5BF0
	private MonsterBehaviorController.BehaviorActionParam CreateApproachDash() { }

	// RVA: 0x22F5D40 Offset: 0x22F5E41 VA: 0x22F5D40 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x22F5EC0 Offset: 0x22F5FC1 VA: 0x22F5EC0 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x22F5F60 Offset: 0x22F6061 VA: 0x22F5F60 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x22F5FB0 Offset: 0x22F60B1 VA: 0x22F5FB0 Slot: 88
	public override void StartMadness() { }

	// RVA: 0x22F60C0 Offset: 0x22F61C1 VA: 0x22F60C0 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x22F6100 Offset: 0x22F6201 VA: 0x22F6100 Slot: 95
	protected override void UpdateReciveItemBehaviorTiming() { }

	// RVA: 0x22F61C0 Offset: 0x22F62C1 VA: 0x22F61C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3AB0 Offset: 0x1A3BB1 VA: 0x1A3AB0
	// RVA: 0x22F61D0 Offset: 0x22F62D1 VA: 0x22F61D0
	private void <CreateShotNeedleAttackAction>b__4_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3AC0 Offset: 0x1A3BC1 VA: 0x1A3AC0
	// RVA: 0x22F6260 Offset: 0x22F6361 VA: 0x22F6260
	private void <CreateRushAttackAction>b__5_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3AD0 Offset: 0x1A3BD1 VA: 0x1A3AD0
	// RVA: 0x22F62F0 Offset: 0x22F63F1 VA: 0x22F62F0
	private void <CreateScratchAttackAction>b__6_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3AE0 Offset: 0x1A3BE1 VA: 0x1A3AE0
	// RVA: 0x22F6380 Offset: 0x22F6481 VA: 0x22F6380
	private void <CreateSpinAttackAction>b__7_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3AF0 Offset: 0x1A3BF1 VA: 0x1A3AF0
	// RVA: 0x22F6410 Offset: 0x22F6511 VA: 0x22F6410
	private void <CreateTreateAction>b__8_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3B00 Offset: 0x1A3C01 VA: 0x1A3B00
	// RVA: 0x22F64A0 Offset: 0x22F65A1 VA: 0x22F64A0
	private void <CreateJumpAction>b__9_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3B10 Offset: 0x1A3C11 VA: 0x1A3B10
	// RVA: 0x22F6530 Offset: 0x22F6631 VA: 0x22F6530
	private void <CreateApproachWalk>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3B20 Offset: 0x1A3C21 VA: 0x1A3B20
	// RVA: 0x22F6590 Offset: 0x22F6691 VA: 0x22F6590
	private void <CreateApproachWalk>b__10_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3B30 Offset: 0x1A3C31 VA: 0x1A3B30
	// RVA: 0x22F6630 Offset: 0x22F6731 VA: 0x22F6630
	private void <CreateApproachDash>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3B40 Offset: 0x1A3C41 VA: 0x1A3B40
	// RVA: 0x22F6690 Offset: 0x22F6791 VA: 0x22F6690
	private void <CreateApproachDash>b__11_1(int index, int type) { }
}

