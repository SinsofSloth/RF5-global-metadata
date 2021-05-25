public class HekatonkeilBehaviorController : BossBehaviorController // TypeDefIndex: 7886
{
	// Fields
	private const float CHACKRANGE_TIME = 3.3;
	private float DefaultForceSuccessWaitTime; // 0x1C8
	private SharedFloat ForceSuccessWaitTime; // 0x1D0

	// Methods

	// RVA: 0x22FEDE0 Offset: 0x22FEEE1 VA: 0x22FEDE0 Slot: 19
	protected override void OnGetVariableBehaviorParameter() { }

	// RVA: 0x22FEEC0 Offset: 0x22FEFC1 VA: 0x22FEEC0 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x2300400 Offset: 0x2300501 VA: 0x2300400 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x23004C0 Offset: 0x23005C1 VA: 0x23004C0 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x22FF1B0 Offset: 0x22FF2B1 VA: 0x22FF1B0
	private MonsterBehaviorController.BehaviorActionParam ThreePunchGroundAction() { }

	// RVA: 0x22FF3B0 Offset: 0x22FF4B1 VA: 0x22FF3B0
	private MonsterBehaviorController.BehaviorActionParam RangeCheckThreePunchGroundAction() { }

	// RVA: 0x22FF5B0 Offset: 0x22FF6B1 VA: 0x22FF5B0
	private MonsterBehaviorController.BehaviorActionParam MadnessThreePunchGroundAction() { }

	// RVA: 0x22FF7B0 Offset: 0x22FF8B1 VA: 0x22FF7B0
	private MonsterBehaviorController.BehaviorActionParam RangeCheckMadnessThreePunchGroundAction() { }

	// RVA: 0x22FF2B0 Offset: 0x22FF3B1 VA: 0x22FF2B0
	private MonsterBehaviorController.BehaviorActionParam HoldArmsGroundAction() { }

	// RVA: 0x22FF4B0 Offset: 0x22FF5B1 VA: 0x22FF4B0
	private MonsterBehaviorController.BehaviorActionParam RangeCheckHoldArmsGroundAction() { }

	// RVA: 0x22FF6B0 Offset: 0x22FF7B1 VA: 0x22FF6B0
	private MonsterBehaviorController.BehaviorActionParam MadnessHoldArmsGroundAction() { }

	// RVA: 0x22FF8B0 Offset: 0x22FF9B1 VA: 0x22FF8B0
	private MonsterBehaviorController.BehaviorActionParam RangeCheckMadnessHoldArmsGroundAction() { }

	// RVA: 0x22FF9B0 Offset: 0x22FFAB1 VA: 0x22FF9B0
	private MonsterBehaviorController.BehaviorActionParam FlameAction() { }

	// RVA: 0x22FFAB0 Offset: 0x22FFBB1 VA: 0x22FFAB0
	private MonsterBehaviorController.BehaviorActionParam FireBallAction() { }

	// RVA: 0x22FFBB0 Offset: 0x22FFCB1 VA: 0x22FFBB0
	private MonsterBehaviorController.BehaviorActionParam FireBall3Action() { }

	// RVA: 0x2300000 Offset: 0x2300101 VA: 0x2300000
	private MonsterBehaviorController.BehaviorActionParam ThrowRockSmall3() { }

	// RVA: 0x2300100 Offset: 0x2300201 VA: 0x2300100
	private MonsterBehaviorController.BehaviorActionParam ThrowRockSmall1() { }

	// RVA: 0x2300200 Offset: 0x2300301 VA: 0x2300200
	private MonsterBehaviorController.BehaviorActionParam ThrowRockSmall3Attribute() { }

	// RVA: 0x2300300 Offset: 0x2300401 VA: 0x2300300
	private MonsterBehaviorController.BehaviorActionParam ThrowRockBig1Attribute() { }

	// RVA: 0x22FFCB0 Offset: 0x22FFDB1 VA: 0x22FFCB0
	private MonsterBehaviorController.BehaviorActionParam DashAttackAction() { }

	// RVA: 0x22FFDB0 Offset: 0x22FFEB1 VA: 0x22FFDB0
	private MonsterBehaviorController.BehaviorActionParam EarthQuakeAction() { }

	// RVA: 0x22FFEE0 Offset: 0x22FFFE1 VA: 0x22FFEE0
	private MonsterBehaviorController.BehaviorActionParam RapidBlowAction() { }

	// RVA: 0x23005C0 Offset: 0x23006C1 VA: 0x23005C0 Slot: 89
	public override string GetLotteryTypeEnumToString(int SelectType) { }

	// RVA: 0x2300700 Offset: 0x2300801 VA: 0x2300700
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3D00 Offset: 0x1A3E01 VA: 0x1A3D00
	// RVA: 0x2300710 Offset: 0x2300811 VA: 0x2300710
	private void <ThreePunchGroundAction>b__7_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3D10 Offset: 0x1A3E11 VA: 0x1A3D10
	// RVA: 0x2300760 Offset: 0x2300861 VA: 0x2300760
	private void <RangeCheckThreePunchGroundAction>b__8_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3D20 Offset: 0x1A3E21 VA: 0x1A3D20
	// RVA: 0x2300800 Offset: 0x2300901 VA: 0x2300800
	private void <MadnessThreePunchGroundAction>b__9_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3D30 Offset: 0x1A3E31 VA: 0x1A3D30
	// RVA: 0x2300850 Offset: 0x2300951 VA: 0x2300850
	private void <RangeCheckMadnessThreePunchGroundAction>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3D40 Offset: 0x1A3E41 VA: 0x1A3D40
	// RVA: 0x23008F0 Offset: 0x23009F1 VA: 0x23008F0
	private void <HoldArmsGroundAction>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3D50 Offset: 0x1A3E51 VA: 0x1A3D50
	// RVA: 0x2300940 Offset: 0x2300A41 VA: 0x2300940
	private void <RangeCheckHoldArmsGroundAction>b__12_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3D60 Offset: 0x1A3E61 VA: 0x1A3D60
	// RVA: 0x23009E0 Offset: 0x2300AE1 VA: 0x23009E0
	private void <MadnessHoldArmsGroundAction>b__13_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3D70 Offset: 0x1A3E71 VA: 0x1A3D70
	// RVA: 0x2300A30 Offset: 0x2300B31 VA: 0x2300A30
	private void <RangeCheckMadnessHoldArmsGroundAction>b__14_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3D80 Offset: 0x1A3E81 VA: 0x1A3D80
	// RVA: 0x2300AD0 Offset: 0x2300BD1 VA: 0x2300AD0
	private void <FlameAction>b__15_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3D90 Offset: 0x1A3E91 VA: 0x1A3D90
	// RVA: 0x2300B20 Offset: 0x2300C21 VA: 0x2300B20
	private void <FireBallAction>b__16_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3DA0 Offset: 0x1A3EA1 VA: 0x1A3DA0
	// RVA: 0x2300B70 Offset: 0x2300C71 VA: 0x2300B70
	private void <FireBall3Action>b__17_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3DB0 Offset: 0x1A3EB1 VA: 0x1A3DB0
	// RVA: 0x2300BC0 Offset: 0x2300CC1 VA: 0x2300BC0
	private void <ThrowRockSmall3>b__18_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3DC0 Offset: 0x1A3EC1 VA: 0x1A3DC0
	// RVA: 0x2300C10 Offset: 0x2300D11 VA: 0x2300C10
	private void <ThrowRockSmall1>b__19_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3DD0 Offset: 0x1A3ED1 VA: 0x1A3DD0
	// RVA: 0x2300C60 Offset: 0x2300D61 VA: 0x2300C60
	private void <ThrowRockSmall3Attribute>b__20_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3DE0 Offset: 0x1A3EE1 VA: 0x1A3DE0
	// RVA: 0x2300CB0 Offset: 0x2300DB1 VA: 0x2300CB0
	private void <ThrowRockBig1Attribute>b__21_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3DF0 Offset: 0x1A3EF1 VA: 0x1A3DF0
	// RVA: 0x2300D00 Offset: 0x2300E01 VA: 0x2300D00
	private void <DashAttackAction>b__22_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3E00 Offset: 0x1A3F01 VA: 0x1A3E00
	// RVA: 0x2300D50 Offset: 0x2300E51 VA: 0x2300D50
	private void <EarthQuakeAction>b__23_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3E10 Offset: 0x1A3F11 VA: 0x1A3E10
	// RVA: 0x2300DA0 Offset: 0x2300EA1 VA: 0x2300DA0
	private void <RapidBlowAction>b__24_0() { }
}

