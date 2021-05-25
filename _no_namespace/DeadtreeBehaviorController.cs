public class DeadtreeBehaviorController : BossBehaviorController // TypeDefIndex: 7836
{
	// Fields
	private const float HoldMushroomTime = 0.66;
	private const float ReleseMushroomTime = 2.66;
	private const string BoneName = "MashRoomPos";
	private DeadtreeController _DeadTreeController; // 0x1C8
	private bool IsDamage; // 0x1D0
	private bool IsExistBurr; // 0x1D1
	public bool IsMashHeal; // 0x1D2
	private int healCount; // 0x1D4
	public bool IsJump; // 0x1D8

	// Properties
	private DeadtreeController DeadTreeController { get; }

	// Methods

	// RVA: 0x1CE2B80 Offset: 0x1CE2C81 VA: 0x1CE2B80
	private DeadtreeController get_DeadTreeController() { }

	// RVA: 0x1CE2C60 Offset: 0x1CE2D61 VA: 0x1CE2C60
	private TaskStatus Stripping_Update() { }

	// RVA: 0x1CE2D00 Offset: 0x1CE2E01 VA: 0x1CE2D00
	private void RespawnBurr_End() { }

	// RVA: 0x1CE3220 Offset: 0x1CE3321 VA: 0x1CE3220
	public void LotteryHeal(int heal) { }

	// RVA: 0x1CE3300 Offset: 0x1CE3401 VA: 0x1CE3300
	private MonsterBehaviorController.BehaviorActionParam CreateAroundMoveAction() { }

	// RVA: 0x1CE3430 Offset: 0x1CE3531 VA: 0x1CE3430
	private MonsterBehaviorController.BehaviorActionParam CreateLeaveMoveAction() { }

	// RVA: 0x1CE3560 Offset: 0x1CE3661 VA: 0x1CE3560
	private MonsterBehaviorController.BehaviorActionParam CreateWaitAction() { }

	// RVA: 0x1CE3690 Offset: 0x1CE3791 VA: 0x1CE3690
	private MonsterBehaviorController.BehaviorActionParam CreateStrippingAttackAction() { }

	// RVA: 0x1CE37C0 Offset: 0x1CE38C1 VA: 0x1CE37C0
	private MonsterBehaviorController.BehaviorActionParam CreateBurrBarrierAction() { }

	// RVA: 0x1CE38C0 Offset: 0x1CE39C1 VA: 0x1CE38C0
	private MonsterBehaviorController.BehaviorActionParam CreateBurrBombAction() { }

	// RVA: 0x1CE39C0 Offset: 0x1CE3AC1 VA: 0x1CE39C0
	private MonsterBehaviorController.BehaviorActionParam CreateNoiseofTreeAttackAction() { }

	// RVA: 0x1CE3AE0 Offset: 0x1CE3BE1 VA: 0x1CE3AE0
	private MonsterBehaviorController.BehaviorActionParam CreateCureAction() { }

	// RVA: 0x1CE3C60 Offset: 0x1CE3D61 VA: 0x1CE3C60
	private MonsterBehaviorController.BehaviorActionParam CreateLeaveRespawnBurrAction() { }

	// RVA: 0x1CE3D60 Offset: 0x1CE3E61 VA: 0x1CE3D60 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x1CE4000 Offset: 0x1CE4101 VA: 0x1CE4000 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x1CE4040 Offset: 0x1CE4141 VA: 0x1CE4040 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x1CE40F0 Offset: 0x1CE41F1 VA: 0x1CE40F0 Slot: 71
	public override void OnEndAnimEventMadnessState() { }

	// RVA: 0x1CE4170 Offset: 0x1CE4271 VA: 0x1CE4170 Slot: 9
	protected override void Update() { }

	// RVA: 0x1CE46D0 Offset: 0x1CE47D1 VA: 0x1CE46D0 Slot: 95
	protected override void UpdateReciveItemBehaviorTiming() { }

	// RVA: 0x1CE47A0 Offset: 0x1CE48A1 VA: 0x1CE47A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3230 Offset: 0x1A3331 VA: 0x1A3230
	// RVA: 0x1CE47B0 Offset: 0x1CE48B1 VA: 0x1CE47B0
	private void <CreateAroundMoveAction>b__15_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3240 Offset: 0x1A3341 VA: 0x1A3240
	// RVA: 0x1CE4810 Offset: 0x1CE4911 VA: 0x1CE4810
	private void <CreateAroundMoveAction>b__15_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3250 Offset: 0x1A3351 VA: 0x1A3250
	// RVA: 0x1CE4A00 Offset: 0x1CE4B01 VA: 0x1CE4A00
	private void <CreateLeaveMoveAction>b__16_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3260 Offset: 0x1A3361 VA: 0x1A3260
	// RVA: 0x1CE4A60 Offset: 0x1CE4B61 VA: 0x1CE4A60
	private void <CreateLeaveMoveAction>b__16_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3270 Offset: 0x1A3371 VA: 0x1A3270
	// RVA: 0x1CE4C80 Offset: 0x1CE4D81 VA: 0x1CE4C80
	private void <CreateWaitAction>b__17_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3280 Offset: 0x1A3381 VA: 0x1A3280
	// RVA: 0x1CE4CE0 Offset: 0x1CE4DE1 VA: 0x1CE4CE0
	private void <CreateWaitAction>b__17_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3290 Offset: 0x1A3391 VA: 0x1A3290
	// RVA: 0x1CE4F30 Offset: 0x1CE5031 VA: 0x1CE4F30
	private void <CreateStrippingAttackAction>b__18_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A32A0 Offset: 0x1A33A1 VA: 0x1A32A0
	// RVA: 0x1CE4FA0 Offset: 0x1CE50A1 VA: 0x1CE4FA0
	private void <CreateBurrBarrierAction>b__19_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A32B0 Offset: 0x1A33B1 VA: 0x1A32B0
	// RVA: 0x1CE4FF0 Offset: 0x1CE50F1 VA: 0x1CE4FF0
	private void <CreateBurrBombAction>b__20_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A32C0 Offset: 0x1A33C1 VA: 0x1A32C0
	// RVA: 0x1CE5060 Offset: 0x1CE5161 VA: 0x1CE5060
	private void <CreateNoiseofTreeAttackAction>b__21_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A32D0 Offset: 0x1A33D1 VA: 0x1A32D0
	// RVA: 0x1CE50B0 Offset: 0x1CE51B1 VA: 0x1CE50B0
	private void <CreateCureAction>b__22_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A32E0 Offset: 0x1A33E1 VA: 0x1A32E0
	// RVA: 0x1CE5100 Offset: 0x1CE5201 VA: 0x1CE5100
	private void <CreateLeaveRespawnBurrAction>b__23_0() { }
}

