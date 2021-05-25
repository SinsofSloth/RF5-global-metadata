public class GandageBehaviorController : BossBehaviorController // TypeDefIndex: 7849
{
	// Fields
	private const float CloseRangeValue = 5;
	private const float LeaveRangeValue = 10;
	private const float EscapeTime = 1;
	private const int InitEscapeConut = 3;
	private const int EscapePercent = 5;
	private List<MonsterActionBehaviorType> TargetInRangeBehaviorList; // 0x1C8
	private List<MonsterActionBehaviorType> TargetOutRangeBehaviorList; // 0x1D0
	private GandageController _GandageController; // 0x1D8
	private bool IsCheckStartEscape; // 0x1E0
	private float EscapeTimer; // 0x1E4
	private bool IsEscape; // 0x1E8
	private bool IsGuard; // 0x1E9
	private bool IsHitAttack; // 0x1EA
	private bool IsRestraint; // 0x1EB

	// Properties
	private GandageController GandageController { get; }

	// Methods

	// RVA: 0x22A5C90 Offset: 0x22A5D91 VA: 0x22A5C90
	private GandageController get_GandageController() { }

	// RVA: 0x22A5D70 Offset: 0x22A5E71 VA: 0x22A5D70
	private MonsterBehaviorController.BehaviorActionParam CreateSwordAttack() { }

	// RVA: 0x22A5E70 Offset: 0x22A5F71 VA: 0x22A5E70
	private MonsterBehaviorController.BehaviorActionParam CreateRushAttack() { }

	// RVA: 0x22A5FD0 Offset: 0x22A60D1 VA: 0x22A5FD0
	private MonsterBehaviorController.BehaviorActionParam CreateShockWaveColumnAttack() { }

	// RVA: 0x22A60D0 Offset: 0x22A61D1 VA: 0x22A60D0
	private MonsterBehaviorController.BehaviorActionParam CreateShockWaveRowAttack31() { }

	// RVA: 0x22A61D0 Offset: 0x22A62D1 VA: 0x22A61D0
	private MonsterBehaviorController.BehaviorActionParam CreateShockWaveRowAttack32() { }

	// RVA: 0x22A62D0 Offset: 0x22A63D1 VA: 0x22A62D0
	private MonsterBehaviorController.BehaviorActionParam CreateSwordGround() { }

	// RVA: 0x22A63D0 Offset: 0x22A64D1 VA: 0x22A63D0
	private MonsterBehaviorController.BehaviorActionParam CreateLastBossLaserAttack() { }

	// RVA: 0x22A64D0 Offset: 0x22A65D1 VA: 0x22A64D0
	private MonsterBehaviorController.BehaviorActionParam CreateFlyswatterAttack() { }

	// RVA: 0x22A65F0 Offset: 0x22A66F1 VA: 0x22A65F0
	private MonsterBehaviorController.BehaviorActionParam CreateUpperDownAttack51() { }

	// RVA: 0x22A66F0 Offset: 0x22A67F1 VA: 0x22A66F0
	private MonsterBehaviorController.BehaviorActionParam CreateUpperDownAttack52() { }

	// RVA: 0x22A67F0 Offset: 0x22A68F1 VA: 0x22A67F0
	private MonsterBehaviorController.BehaviorActionParam CreateCrackAreaAttackReady() { }

	// RVA: 0x22A6910 Offset: 0x22A6A11 VA: 0x22A6910
	private MonsterBehaviorController.BehaviorActionParam CreateCrackAreaAttack() { }

	// RVA: 0x22A6A10 Offset: 0x22A6B11 VA: 0x22A6A10
	private MonsterBehaviorController.BehaviorActionParam CreateFlyingkickAttack() { }

	// RVA: 0x22A6B30 Offset: 0x22A6C31 VA: 0x22A6B30
	private MonsterBehaviorController.BehaviorActionParam CreateBeatupAttack() { }

	// RVA: 0x22A6C30 Offset: 0x22A6D31 VA: 0x22A6C30
	private MonsterBehaviorController.BehaviorActionParam CreateAroundMonveAction() { }

	// RVA: 0x22A6DF0 Offset: 0x22A6EF1 VA: 0x22A6DF0
	private MonsterBehaviorController.BehaviorActionParam CreateJump() { }

	// RVA: 0x22A6F40 Offset: 0x22A7041 VA: 0x22A6F40
	private MonsterBehaviorController.BehaviorActionParam CreateTakeBehindJump() { }

	// RVA: 0x22A7090 Offset: 0x22A7191 VA: 0x22A7090
	private MonsterBehaviorController.BehaviorActionParam CreateEscapeJump() { }

	// RVA: 0x22A71A0 Offset: 0x22A72A1 VA: 0x22A71A0
	private MonsterBehaviorController.BehaviorActionParam CreateCloseStep() { }

	// RVA: 0x22A72F0 Offset: 0x22A73F1 VA: 0x22A72F0
	private MonsterBehaviorController.BehaviorActionParam CreateLeaveStep() { }

	// RVA: 0x22A7440 Offset: 0x22A7541 VA: 0x22A7440
	private MonsterBehaviorController.BehaviorActionParam CreateCloseDash() { }

	// RVA: 0x22A7590 Offset: 0x22A7691 VA: 0x22A7590
	private MonsterBehaviorController.BehaviorActionParam CreateLeaveDash() { }

	// RVA: 0x22A76E0 Offset: 0x22A77E1 VA: 0x22A76E0
	private MonsterBehaviorController.BehaviorActionParam CreateGuard() { }

	// RVA: 0x22A7830 Offset: 0x22A7931 VA: 0x22A7830 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x22A7BB0 Offset: 0x22A7CB1 VA: 0x22A7BB0 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x22A7BF0 Offset: 0x22A7CF1 VA: 0x22A7BF0 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x22A7D10 Offset: 0x22A7E11 VA: 0x22A7D10 Slot: 87
	public override void CreateMadnessEffect() { }

	// RVA: 0x22A7DB0 Offset: 0x22A7EB1 VA: 0x22A7DB0 Slot: 56
	public override void OnHitAttack() { }

	// RVA: 0x22A7E40 Offset: 0x22A7F41 VA: 0x22A7E40
	private void ExcuteGuard() { }

	// RVA: 0x22A7EC0 Offset: 0x22A7FC1 VA: 0x22A7EC0
	private void ExcuteEscape() { }

	// RVA: 0x22A7CE0 Offset: 0x22A7DE1 VA: 0x22A7CE0
	private void ResetEscape() { }

	// RVA: 0x22A7D00 Offset: 0x22A7E01 VA: 0x22A7D00
	private void ResetGuard() { }

	// RVA: 0x22A7E00 Offset: 0x22A7F01 VA: 0x22A7E00
	private void UpdateHitAttack() { }

	// RVA: 0x22A7CA0 Offset: 0x22A7DA1 VA: 0x22A7CA0
	private void ResetHitAttack() { }

	// RVA: 0x22A7F40 Offset: 0x22A8041 VA: 0x22A7F40
	public void UpdateEscape() { }

	// RVA: 0x22A8010 Offset: 0x22A8111 VA: 0x22A8010 Slot: 9
	protected override void Update() { }

	// RVA: 0x22A8040 Offset: 0x22A8141 VA: 0x22A8040 Slot: 88
	public override void StartMadness() { }

	// RVA: 0x22A80C0 Offset: 0x22A81C1 VA: 0x22A80C0 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x22A8110 Offset: 0x22A8211 VA: 0x22A8110 Slot: 81
	public override void OnRestraint() { }

	// RVA: 0x22A8140 Offset: 0x22A8241 VA: 0x22A8140 Slot: 71
	public override void OnEndAnimEventMadnessState() { }

	// RVA: 0x22A8190 Offset: 0x22A8291 VA: 0x22A8190
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3450 Offset: 0x1A3551 VA: 0x1A3450
	// RVA: 0x22A8240 Offset: 0x22A8341 VA: 0x22A8240
	private void <CreateSwordAttack>b__17_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3460 Offset: 0x1A3561 VA: 0x1A3460
	// RVA: 0x22A82D0 Offset: 0x22A83D1 VA: 0x22A82D0
	private void <CreateRushAttack>b__18_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3470 Offset: 0x1A3571 VA: 0x1A3470
	// RVA: 0x22A8320 Offset: 0x22A8421 VA: 0x22A8320
	private void <CreateRushAttack>b__18_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3480 Offset: 0x1A3581 VA: 0x1A3480
	// RVA: 0x22A83B0 Offset: 0x22A84B1 VA: 0x22A83B0
	private void <CreateShockWaveColumnAttack>b__19_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3490 Offset: 0x1A3591 VA: 0x1A3490
	// RVA: 0x22A8400 Offset: 0x22A8501 VA: 0x22A8400
	private void <CreateShockWaveRowAttack31>b__20_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A34A0 Offset: 0x1A35A1 VA: 0x1A34A0
	// RVA: 0x22A8450 Offset: 0x22A8551 VA: 0x22A8450
	private void <CreateShockWaveRowAttack32>b__21_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A34B0 Offset: 0x1A35B1 VA: 0x1A34B0
	// RVA: 0x22A84A0 Offset: 0x22A85A1 VA: 0x22A84A0
	private void <CreateSwordGround>b__22_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A34C0 Offset: 0x1A35C1 VA: 0x1A34C0
	// RVA: 0x22A84F0 Offset: 0x22A85F1 VA: 0x22A84F0
	private void <CreateLastBossLaserAttack>b__23_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A34D0 Offset: 0x1A35D1 VA: 0x1A34D0
	// RVA: 0x22A8540 Offset: 0x22A8641 VA: 0x22A8540
	private void <CreateFlyswatterAttack>b__24_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A34E0 Offset: 0x1A35E1 VA: 0x1A34E0
	// RVA: 0x22A85D0 Offset: 0x22A86D1 VA: 0x22A85D0
	private void <CreateUpperDownAttack51>b__25_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A34F0 Offset: 0x1A35F1 VA: 0x1A34F0
	// RVA: 0x22A8620 Offset: 0x22A8721 VA: 0x22A8620
	private void <CreateUpperDownAttack52>b__26_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3500 Offset: 0x1A3601 VA: 0x1A3500
	// RVA: 0x22A8670 Offset: 0x22A8771 VA: 0x22A8670
	private void <CreateCrackAreaAttackReady>b__27_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3510 Offset: 0x1A3611 VA: 0x1A3510
	// RVA: 0x22A8710 Offset: 0x22A8811 VA: 0x22A8710
	private void <CreateCrackAreaAttack>b__28_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3520 Offset: 0x1A3621 VA: 0x1A3520
	// RVA: 0x22A87B0 Offset: 0x22A88B1 VA: 0x22A87B0
	private void <CreateFlyingkickAttack>b__29_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3530 Offset: 0x1A3631 VA: 0x1A3530
	// RVA: 0x22A8800 Offset: 0x22A8901 VA: 0x22A8800
	private void <CreateBeatupAttack>b__30_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3540 Offset: 0x1A3641 VA: 0x1A3540
	// RVA: 0x22A8850 Offset: 0x22A8951 VA: 0x22A8850
	private void <CreateAroundMonveAction>b__31_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3550 Offset: 0x1A3651 VA: 0x1A3550
	// RVA: 0x22A8A50 Offset: 0x22A8B51 VA: 0x22A8A50
	private void <CreateJump>b__32_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3560 Offset: 0x1A3661 VA: 0x1A3560
	// RVA: 0x22A8AB0 Offset: 0x22A8BB1 VA: 0x22A8AB0
	private void <CreateJump>b__32_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3570 Offset: 0x1A3671 VA: 0x1A3570
	// RVA: 0x22A8B30 Offset: 0x22A8C31 VA: 0x22A8B30
	private void <CreateTakeBehindJump>b__33_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3580 Offset: 0x1A3681 VA: 0x1A3580
	// RVA: 0x22A8B90 Offset: 0x22A8C91 VA: 0x22A8B90
	private void <CreateTakeBehindJump>b__33_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3590 Offset: 0x1A3691 VA: 0x1A3590
	// RVA: 0x22A8C10 Offset: 0x22A8D11 VA: 0x22A8C10
	private void <CreateEscapeJump>b__34_0(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A35A0 Offset: 0x1A36A1 VA: 0x1A35A0
	// RVA: 0x22A8C90 Offset: 0x22A8D91 VA: 0x22A8C90
	private void <CreateCloseStep>b__35_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A35B0 Offset: 0x1A36B1 VA: 0x1A35B0
	// RVA: 0x22A8CF0 Offset: 0x22A8DF1 VA: 0x22A8CF0
	private void <CreateCloseStep>b__35_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A35C0 Offset: 0x1A36C1 VA: 0x1A35C0
	// RVA: 0x22A8D70 Offset: 0x22A8E71 VA: 0x22A8D70
	private void <CreateLeaveStep>b__36_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A35D0 Offset: 0x1A36D1 VA: 0x1A35D0
	// RVA: 0x22A8DD0 Offset: 0x22A8ED1 VA: 0x22A8DD0
	private void <CreateLeaveStep>b__36_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A35E0 Offset: 0x1A36E1 VA: 0x1A35E0
	// RVA: 0x22A8E50 Offset: 0x22A8F51 VA: 0x22A8E50
	private void <CreateCloseDash>b__37_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A35F0 Offset: 0x1A36F1 VA: 0x1A35F0
	// RVA: 0x22A8EB0 Offset: 0x22A8FB1 VA: 0x22A8EB0
	private void <CreateCloseDash>b__37_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3600 Offset: 0x1A3701 VA: 0x1A3600
	// RVA: 0x22A8F50 Offset: 0x22A9051 VA: 0x22A8F50
	private void <CreateLeaveDash>b__38_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3610 Offset: 0x1A3711 VA: 0x1A3610
	// RVA: 0x22A8FB0 Offset: 0x22A90B1 VA: 0x22A8FB0
	private void <CreateLeaveDash>b__38_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3620 Offset: 0x1A3721 VA: 0x1A3620
	// RVA: 0x22A9050 Offset: 0x22A9151 VA: 0x22A9050
	private void <CreateGuard>b__39_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3630 Offset: 0x1A3731 VA: 0x1A3630
	// RVA: 0x22A90B0 Offset: 0x22A91B1 VA: 0x22A90B0
	private void <CreateGuard>b__39_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3640 Offset: 0x1A3741 VA: 0x1A3640
	// RVA: 0x22A9130 Offset: 0x22A9231 VA: 0x22A9130
	private void <CreateMadnessEffect>b__43_0(ParticleSystem effect) { }
}

