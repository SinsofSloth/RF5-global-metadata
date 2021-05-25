public class ReviatanBehaviorController : BossBehaviorController // TypeDefIndex: 7961
{
	// Fields
	private const float LEAVE_LENGTH = 10;
	private const float TSUNAMI_LEAVE_LENGTH = 15;
	private const float NAVMESH_SAMPLE_LENGTH = 1.5;
	private const float LEAVE_SAMPLE_RATIO = 1.5;
	private static readonly Vector3[] LEAVE_NORMAL; // 0x0
	private List<Vector2> RecoveryPercentList; // 0x1C8
	private int RemainRecovery; // 0x1D0

	// Methods

	// RVA: 0x232C6E0 Offset: 0x232C7E1 VA: 0x232C6E0 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x232D970 Offset: 0x232DA71 VA: 0x232D970 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x232DA80 Offset: 0x232DB81 VA: 0x232DA80 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x232DC60 Offset: 0x232DD61 VA: 0x232DC60 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x232DD50 Offset: 0x232DE51 VA: 0x232DD50
	private void LeaveMove(int type, float leaveLength) { }

	// RVA: 0x232C960 Offset: 0x232CA61 VA: 0x232C960
	private MonsterBehaviorController.BehaviorActionParam CreateGeyserAttack() { }

	// RVA: 0x232CB30 Offset: 0x232CC31 VA: 0x232CB30
	private MonsterBehaviorController.BehaviorActionParam CreateWaterGunAttack() { }

	// RVA: 0x232D680 Offset: 0x232D781 VA: 0x232D680
	private MonsterBehaviorController.BehaviorActionParam CreateWaterGunHeadbuttAttack() { }

	// RVA: 0x232CD00 Offset: 0x232CE01 VA: 0x232CD00
	private MonsterBehaviorController.BehaviorActionParam CreateWaterLaserAttack() { }

	// RVA: 0x232D020 Offset: 0x232D121 VA: 0x232D020
	private MonsterBehaviorController.BehaviorActionParam CreateIcePillarAttack() { }

	// RVA: 0x232CED0 Offset: 0x232CFD1 VA: 0x232CED0
	private MonsterBehaviorController.BehaviorActionParam CreateTsunamiAttack() { }

	// RVA: 0x232D1F0 Offset: 0x232D2F1 VA: 0x232D1F0
	private MonsterBehaviorController.BehaviorActionParam CreateRecoveryAction() { }

	// RVA: 0x232D4C0 Offset: 0x232D5C1 VA: 0x232D4C0
	private MonsterBehaviorController.BehaviorActionParam CreateLeaveMove() { }

	// RVA: 0x232D3B0 Offset: 0x232D4B1 VA: 0x232D3B0
	private MonsterBehaviorController.BehaviorActionParam CreateHeadButtAttack() { }

	// RVA: 0x232D870 Offset: 0x232D971 VA: 0x232D870
	private MonsterBehaviorController.BehaviorActionParam CreateBigGeyser() { }

	// RVA: 0x232E1F0 Offset: 0x232E2F1 VA: 0x232E1F0 Slot: 89
	public override string GetLotteryTypeEnumToString(int SelectType) { }

	// RVA: 0x232E330 Offset: 0x232E431 VA: 0x232E330
	public void .ctor() { }

	// RVA: 0x232E340 Offset: 0x232E441 VA: 0x232E340
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4A60 Offset: 0x1A4B61 VA: 0x1A4A60
	// RVA: 0x232E5D0 Offset: 0x232E6D1 VA: 0x232E5D0
	private void <CreateGeyserAttack>b__12_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4A70 Offset: 0x1A4B71 VA: 0x1A4A70
	// RVA: 0x232E620 Offset: 0x232E721 VA: 0x232E620
	private void <CreateWaterGunAttack>b__13_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4A80 Offset: 0x1A4B81 VA: 0x1A4A80
	// RVA: 0x232E670 Offset: 0x232E771 VA: 0x232E670
	private void <CreateWaterGunHeadbuttAttack>b__14_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4A90 Offset: 0x1A4B91 VA: 0x1A4A90
	// RVA: 0x232E700 Offset: 0x232E801 VA: 0x232E700
	private void <CreateWaterLaserAttack>b__15_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4AA0 Offset: 0x1A4BA1 VA: 0x1A4AA0
	// RVA: 0x232E750 Offset: 0x232E851 VA: 0x232E750
	private void <CreateIcePillarAttack>b__16_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4AB0 Offset: 0x1A4BB1 VA: 0x1A4AB0
	// RVA: 0x232E7A0 Offset: 0x232E8A1 VA: 0x232E7A0
	private void <CreateTsunamiAttack>b__17_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4AC0 Offset: 0x1A4BC1 VA: 0x1A4AC0
	// RVA: 0x232E7F0 Offset: 0x232E8F1 VA: 0x232E7F0
	private void <CreateTsunamiAttack>b__17_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4AD0 Offset: 0x1A4BD1 VA: 0x1A4AD0
	// RVA: 0x232E800 Offset: 0x232E901 VA: 0x232E800
	private void <CreateRecoveryAction>b__18_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4AE0 Offset: 0x1A4BE1 VA: 0x1A4AE0
	// RVA: 0x232E850 Offset: 0x232E951 VA: 0x232E850
	private void <CreateLeaveMove>b__19_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4AF0 Offset: 0x1A4BF1 VA: 0x1A4AF0
	// RVA: 0x232E860 Offset: 0x232E961 VA: 0x232E860
	private void <CreateHeadButtAttack>b__20_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4B00 Offset: 0x1A4C01 VA: 0x1A4B00
	// RVA: 0x232E8B0 Offset: 0x232E9B1 VA: 0x232E8B0
	private void <CreateBigGeyser>b__21_0() { }
}

