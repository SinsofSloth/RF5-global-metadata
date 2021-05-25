public class YadokariBehaviorController : BossBehaviorController // TypeDefIndex: 7988
{
	// Fields
	private const float WAiT_S = 0.5;
	private const float WAiT_M = 1;
	private const float WAiT_L = 1.5;
	public YadokariController YadokariController; // 0x1C8

	// Methods

	// RVA: 0x1D12440 Offset: 0x1D12541 VA: 0x1D12440
	private MonsterBehaviorController.BehaviorActionParam CreateMoveAroundAction() { }

	// RVA: 0x1D12550 Offset: 0x1D12651 VA: 0x1D12550
	private MonsterBehaviorController.BehaviorActionParam CreateClubClawAction() { }

	// RVA: 0x1D12720 Offset: 0x1D12821 VA: 0x1D12720
	private MonsterBehaviorController.BehaviorActionParam CreateBubbleBurstAction(int num) { }

	// RVA: 0x1D12920 Offset: 0x1D12A21 VA: 0x1D12920
	private MonsterBehaviorController.BehaviorActionParam CreateLaserAction_Right() { }

	// RVA: 0x1D12930 Offset: 0x1D12A31 VA: 0x1D12930
	private MonsterBehaviorController.BehaviorActionParam CreateLaserAction_Left() { }

	// RVA: 0x1D12940 Offset: 0x1D12A41 VA: 0x1D12940
	private MonsterBehaviorController.BehaviorActionParam CreateRotateAttackAction() { }

	// RVA: 0x1D12B00 Offset: 0x1D12C01 VA: 0x1D12B00
	private MonsterBehaviorController.BehaviorActionParam CreateThrowShellAction() { }

	// RVA: 0x1D12CC0 Offset: 0x1D12DC1 VA: 0x1D12CC0
	private MonsterBehaviorController.BehaviorActionParam CreateBubbleThreeWayAction(int action) { }

	// RVA: 0x1D12ED0 Offset: 0x1D12FD1 VA: 0x1D12ED0
	private MonsterBehaviorController.BehaviorActionParam CreateJumpAttackAction(int action) { }

	// RVA: 0x1D130D0 Offset: 0x1D131D1 VA: 0x1D130D0
	private MonsterBehaviorController.BehaviorActionParam CreatePickupShellAction() { }

	// RVA: 0x1D131F0 Offset: 0x1D132F1 VA: 0x1D131F0
	private MonsterBehaviorController.BehaviorActionParam CreateDashAttackAction() { }

	// RVA: 0x1D13300 Offset: 0x1D13401 VA: 0x1D13300
	private MonsterBehaviorController.BehaviorActionParam CreateCrossClawAction(int action) { }

	// RVA: 0x1D13510 Offset: 0x1D13611 VA: 0x1D13510
	private MonsterBehaviorController.BehaviorActionParam CreateSpin_HammerAttackAction() { }

	// RVA: 0x1D13620 Offset: 0x1D13721 VA: 0x1D13620
	private MonsterBehaviorController.BehaviorActionParam CreateSpin_BubbleAttackAction() { }

	// RVA: 0x1D13730 Offset: 0x1D13831 VA: 0x1D13730
	private MonsterBehaviorController.BehaviorActionParam CreateShellAction() { }

	// RVA: 0x1D13880 Offset: 0x1D13981 VA: 0x1D13880
	private MonsterBehaviorController.BehaviorActionParam CreateDash_BubbleAttackAction() { }

	// RVA: 0x1D13990 Offset: 0x1D13A91 VA: 0x1D13990 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x1D13D20 Offset: 0x1D13E21 VA: 0x1D13D20 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x1D13D60 Offset: 0x1D13E61 VA: 0x1D13D60 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x1D13D70 Offset: 0x1D13E71 VA: 0x1D13D70 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x1D13E30 Offset: 0x1D13F31 VA: 0x1D13E30 Slot: 95
	protected override void UpdateReciveItemBehaviorTiming() { }

	// RVA: 0x1D13EF0 Offset: 0x1D13FF1 VA: 0x1D13EF0 Slot: 81
	public override void OnRestraint() { }

	// RVA: 0x1D13F30 Offset: 0x1D14031 VA: 0x1D13F30
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4F50 Offset: 0x1A5051 VA: 0x1A4F50
	// RVA: 0x1D13F40 Offset: 0x1D14041 VA: 0x1D13F40
	private void <CreateMoveAroundAction>b__5_0(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4F60 Offset: 0x1A5061 VA: 0x1A4F60
	// RVA: 0x1D14140 Offset: 0x1D14241 VA: 0x1D14140
	private void <CreateClubClawAction>b__6_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4F70 Offset: 0x1A5071 VA: 0x1A4F70
	// RVA: 0x1D141B0 Offset: 0x1D142B1 VA: 0x1D141B0
	private void <CreateRotateAttackAction>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4F80 Offset: 0x1A5081 VA: 0x1A4F80
	// RVA: 0x1D14200 Offset: 0x1D14301 VA: 0x1D14200
	private void <CreateThrowShellAction>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4F90 Offset: 0x1A5091 VA: 0x1A4F90
	// RVA: 0x1D14250 Offset: 0x1D14351 VA: 0x1D14250
	private void <CreatePickupShellAction>b__14_0(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4FA0 Offset: 0x1A50A1 VA: 0x1A4FA0
	// RVA: 0x1D14340 Offset: 0x1D14441 VA: 0x1D14340
	private void <CreateDashAttackAction>b__15_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4FB0 Offset: 0x1A50B1 VA: 0x1A4FB0
	// RVA: 0x1D14390 Offset: 0x1D14491 VA: 0x1D14390
	private void <CreateSpin_HammerAttackAction>b__17_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4FC0 Offset: 0x1A50C1 VA: 0x1A4FC0
	// RVA: 0x1D14400 Offset: 0x1D14501 VA: 0x1D14400
	private void <CreateSpin_BubbleAttackAction>b__18_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4FD0 Offset: 0x1A50D1 VA: 0x1A4FD0
	// RVA: 0x1D144A0 Offset: 0x1D145A1 VA: 0x1D144A0
	private void <CreateShellAction>b__19_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4FE0 Offset: 0x1A50E1 VA: 0x1A4FE0
	// RVA: 0x1D14510 Offset: 0x1D14611 VA: 0x1D14510
	private void <CreateShellAction>b__19_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4FF0 Offset: 0x1A50F1 VA: 0x1A4FF0
	// RVA: 0x1D14630 Offset: 0x1D14731 VA: 0x1D14630
	private void <CreateDash_BubbleAttackAction>b__20_0() { }
}

