public class KyubiBehaviorController : BossBehaviorController // TypeDefIndex: 7923
{
	// Fields
	private float ChangeMoveDefaultTargetLength; // 0x1C8
	private float ChangeMoveMadnessTargetLength; // 0x1CC
	private float JumpLength; // 0x1D0
	private float BeforeRushWaitTime; // 0x1D4
	private float BeforeJumpAttackWaitTime; // 0x1D8
	private float BeforeFireBallWaitTime; // 0x1DC
	private float BeforeRoarAttackWaitTime; // 0x1E0
	private float BeforeKyubiFireWaitTime; // 0x1E4
	private int FireBallCount; // 0x1E8

	// Methods

	// RVA: 0x20A0790 Offset: 0x20A0891 VA: 0x20A0790
	private void JumpRotate(bool JumpMove) { }

	// RVA: 0x20A0A60 Offset: 0x20A0B61 VA: 0x20A0A60
	private MonsterBehaviorController.BehaviorActionParam CreateRushAttack1() { }

	// RVA: 0x20A0BE0 Offset: 0x20A0CE1 VA: 0x20A0BE0
	private MonsterBehaviorController.BehaviorActionParam CreateRushAttack2() { }

	// RVA: 0x20A0D60 Offset: 0x20A0E61 VA: 0x20A0D60
	private MonsterBehaviorController.BehaviorActionParam CreateDropAttack() { }

	// RVA: 0x20A0EC0 Offset: 0x20A0FC1 VA: 0x20A0EC0
	private MonsterBehaviorController.BehaviorActionParam CreateKyubiFireAttack() { }

	// RVA: 0x20A1040 Offset: 0x20A1141 VA: 0x20A1040
	private MonsterBehaviorController.BehaviorActionParam CreateRoarAttack() { }

	// RVA: 0x20A11C0 Offset: 0x20A12C1 VA: 0x20A11C0
	private MonsterBehaviorController.BehaviorActionParam CreateJumpAttack() { }

	// RVA: 0x20A1340 Offset: 0x20A1441 VA: 0x20A1340
	private MonsterBehaviorController.BehaviorActionParam CreateFireBallAttack() { }

	// RVA: 0x20A14B0 Offset: 0x20A15B1 VA: 0x20A14B0
	private MonsterBehaviorController.BehaviorActionParam CreateMultiFireBallAttack() { }

	// RVA: 0x20A1620 Offset: 0x20A1721 VA: 0x20A1620
	private TaskStatus SelectMove_Update() { }

	// RVA: 0x20A1A10 Offset: 0x20A1B11 VA: 0x20A1A10
	private MonsterBehaviorController.BehaviorActionParam CreateAroundMove() { }

	// RVA: 0x20A1B20 Offset: 0x20A1C21 VA: 0x20A1B20
	private MonsterBehaviorController.BehaviorActionParam CreateJumpMove() { }

	// RVA: 0x20A1C30 Offset: 0x20A1D31 VA: 0x20A1C30 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x20A1E30 Offset: 0x20A1F31 VA: 0x20A1E30 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x20A1FA0 Offset: 0x20A20A1 VA: 0x20A1FA0 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x20A1FE0 Offset: 0x20A20E1 VA: 0x20A1FE0 Slot: 95
	protected override void UpdateReciveItemBehaviorTiming() { }

	// RVA: 0x20A20A0 Offset: 0x20A21A1 VA: 0x20A20A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4420 Offset: 0x1A4521 VA: 0x1A4420
	// RVA: 0x20A20B0 Offset: 0x20A21B1 VA: 0x20A20B0
	private void <CreateRushAttack1>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4430 Offset: 0x1A4531 VA: 0x1A4430
	// RVA: 0x20A2100 Offset: 0x20A2201 VA: 0x20A2100
	private void <CreateRushAttack1>b__10_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4440 Offset: 0x1A4541 VA: 0x1A4440
	// RVA: 0x20A21F0 Offset: 0x20A22F1 VA: 0x20A21F0
	private void <CreateRushAttack2>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4450 Offset: 0x1A4551 VA: 0x1A4450
	// RVA: 0x20A2240 Offset: 0x20A2341 VA: 0x20A2240
	private void <CreateRushAttack2>b__11_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4460 Offset: 0x1A4561 VA: 0x1A4460
	// RVA: 0x20A2330 Offset: 0x20A2431 VA: 0x20A2330
	private void <CreateDropAttack>b__12_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4470 Offset: 0x1A4571 VA: 0x1A4470
	// RVA: 0x20A2380 Offset: 0x20A2481 VA: 0x20A2380
	private void <CreateDropAttack>b__12_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4480 Offset: 0x1A4581 VA: 0x1A4480
	// RVA: 0x20A2410 Offset: 0x20A2511 VA: 0x20A2410
	private void <CreateKyubiFireAttack>b__13_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4490 Offset: 0x1A4591 VA: 0x1A4490
	// RVA: 0x20A2460 Offset: 0x20A2561 VA: 0x20A2460
	private void <CreateKyubiFireAttack>b__13_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A44A0 Offset: 0x1A45A1 VA: 0x1A44A0
	// RVA: 0x20A2550 Offset: 0x20A2651 VA: 0x20A2550
	private void <CreateRoarAttack>b__14_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A44B0 Offset: 0x1A45B1 VA: 0x1A44B0
	// RVA: 0x20A25A0 Offset: 0x20A26A1 VA: 0x20A25A0
	private void <CreateRoarAttack>b__14_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A44C0 Offset: 0x1A45C1 VA: 0x1A44C0
	// RVA: 0x20A2690 Offset: 0x20A2791 VA: 0x20A2690
	private void <CreateJumpAttack>b__15_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A44D0 Offset: 0x1A45D1 VA: 0x1A44D0
	// RVA: 0x20A26E0 Offset: 0x20A27E1 VA: 0x20A26E0
	private void <CreateJumpAttack>b__15_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A44E0 Offset: 0x1A45E1 VA: 0x1A44E0
	// RVA: 0x20A27D0 Offset: 0x20A28D1 VA: 0x20A27D0
	private void <CreateFireBallAttack>b__16_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A44F0 Offset: 0x1A45F1 VA: 0x1A44F0
	// RVA: 0x20A2820 Offset: 0x20A2921 VA: 0x20A2820
	private void <CreateFireBallAttack>b__16_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4500 Offset: 0x1A4601 VA: 0x1A4500
	// RVA: 0x20A2910 Offset: 0x20A2A11 VA: 0x20A2910
	private void <CreateMultiFireBallAttack>b__18_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4510 Offset: 0x1A4611 VA: 0x1A4510
	// RVA: 0x20A2970 Offset: 0x20A2A71 VA: 0x20A2970
	private void <CreateMultiFireBallAttack>b__18_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4520 Offset: 0x1A4621 VA: 0x1A4520
	// RVA: 0x20A2A60 Offset: 0x20A2B61 VA: 0x20A2A60
	private void <CreateAroundMove>b__20_0(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4530 Offset: 0x1A4631 VA: 0x1A4530
	// RVA: 0x20A2C80 Offset: 0x20A2D81 VA: 0x20A2C80
	private void <CreateJumpMove>b__21_0(int index, int type) { }
}

