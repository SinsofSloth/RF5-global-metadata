public class LastBossBehaviorController : BossBehaviorController // TypeDefIndex: 7930
{
	// Fields
	private DN18BossStageManager DN18BossStageManager; // 0x1C8
	private float MoveTime; // 0x1D0

	// Methods

	// RVA: 0x2183AF0 Offset: 0x2183BF1 VA: 0x2183AF0 Slot: 12
	public override void SetupNavMeshAgent(Vector3 createPosition) { }

	// RVA: 0x2183C30 Offset: 0x2183D31 VA: 0x2183C30 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x21854C0 Offset: 0x21855C1 VA: 0x21854C0 Slot: 9
	protected override void Update() { }

	// RVA: 0x2185590 Offset: 0x2185691 VA: 0x2185590 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x2185600 Offset: 0x2185701 VA: 0x2185600
	private void SetMoveTime(float moveTime) { }

	// RVA: 0x21841F0 Offset: 0x21842F1 VA: 0x21841F0
	private MonsterBehaviorController.BehaviorActionParam CreateSuction() { }

	// RVA: 0x21842F0 Offset: 0x21843F1 VA: 0x21842F0
	private MonsterBehaviorController.BehaviorActionParam CreateWaveCanon() { }

	// RVA: 0x21843F0 Offset: 0x21844F1 VA: 0x21843F0
	private MonsterBehaviorController.BehaviorActionParam CreateArrow() { }

	// RVA: 0x21844F0 Offset: 0x21845F1 VA: 0x21844F0
	private MonsterBehaviorController.BehaviorActionParam CreateLaserShelling() { }

	// RVA: 0x2184600 Offset: 0x2184701 VA: 0x2184600
	private MonsterBehaviorController.BehaviorActionParam CreateLaserRadiation() { }

	// RVA: 0x2184710 Offset: 0x2184811 VA: 0x2184710
	private MonsterBehaviorController.BehaviorActionParam CreateWarpAttack() { }

	// RVA: 0x2184810 Offset: 0x2184911 VA: 0x2184810
	private MonsterBehaviorController.BehaviorActionParam CreateBoneDrop() { }

	// RVA: 0x2184910 Offset: 0x2184A11 VA: 0x2184910
	private MonsterBehaviorController.BehaviorActionParam CreateRiseHere() { }

	// RVA: 0x2184A10 Offset: 0x2184B11 VA: 0x2184A10
	private MonsterBehaviorController.BehaviorActionParam CreateDescendHere() { }

	// RVA: 0x2184B10 Offset: 0x2184C11 VA: 0x2184B10
	private MonsterBehaviorController.BehaviorActionParam CreateRiseToTarget() { }

	// RVA: 0x2184C10 Offset: 0x2184D11 VA: 0x2184C10
	private MonsterBehaviorController.BehaviorActionParam CreateDescendToTarget() { }

	// RVA: 0x2184D60 Offset: 0x2184E61 VA: 0x2184D60
	private MonsterBehaviorController.BehaviorActionParam CreateFloorMove() { }

	// RVA: 0x2184E70 Offset: 0x2184F71 VA: 0x2184E70
	private MonsterBehaviorController.BehaviorActionParam CreateOutSideMove() { }

	// RVA: 0x2185040 Offset: 0x2185141 VA: 0x2185040
	private MonsterBehaviorController.BehaviorActionParam CreatePointMove(int point) { }

	// RVA: 0x2185180 Offset: 0x2185281 VA: 0x2185180
	private MonsterBehaviorController.BehaviorActionParam CreatePointLookAt(int point) { }

	// RVA: 0x2184F80 Offset: 0x2185081 VA: 0x2184F80
	private MonsterBehaviorController.BehaviorActionParam CreateCallapse() { }

	// RVA: 0x21852C0 Offset: 0x21853C1 VA: 0x21852C0
	private MonsterBehaviorController.BehaviorActionParam CreateAttack12() { }

	// RVA: 0x21853C0 Offset: 0x21854C1 VA: 0x21853C0
	private MonsterBehaviorController.BehaviorActionParam CreateAttack13() { }

	// RVA: 0x2185700 Offset: 0x2185801 VA: 0x2185700 Slot: 89
	public override string GetLotteryTypeEnumToString(int SelectType) { }

	// RVA: 0x2185840 Offset: 0x2185941 VA: 0x2185840
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4610 Offset: 0x1A4711 VA: 0x1A4610
	// RVA: 0x2185850 Offset: 0x2185951 VA: 0x2185850
	private void <CreateSuction>b__7_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4620 Offset: 0x1A4721 VA: 0x1A4620
	// RVA: 0x21858A0 Offset: 0x21859A1 VA: 0x21858A0
	private void <CreateWaveCanon>b__8_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4630 Offset: 0x1A4731 VA: 0x1A4630
	// RVA: 0x21858F0 Offset: 0x21859F1 VA: 0x21858F0
	private void <CreateArrow>b__9_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4640 Offset: 0x1A4741 VA: 0x1A4640
	// RVA: 0x2185940 Offset: 0x2185A41 VA: 0x2185940
	private void <CreateLaserShelling>b__10_0(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4650 Offset: 0x1A4751 VA: 0x1A4650
	// RVA: 0x2185990 Offset: 0x2185A91 VA: 0x2185990
	private void <CreateLaserRadiation>b__11_0(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4660 Offset: 0x1A4761 VA: 0x1A4660
	// RVA: 0x21859E0 Offset: 0x2185AE1 VA: 0x21859E0
	private void <CreateWarpAttack>b__12_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4670 Offset: 0x1A4771 VA: 0x1A4670
	// RVA: 0x2185A30 Offset: 0x2185B31 VA: 0x2185A30
	private void <CreateBoneDrop>b__13_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4680 Offset: 0x1A4781 VA: 0x1A4680
	// RVA: 0x2185A80 Offset: 0x2185B81 VA: 0x2185A80
	private void <CreateRiseHere>b__14_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4690 Offset: 0x1A4791 VA: 0x1A4690
	// RVA: 0x2185AD0 Offset: 0x2185BD1 VA: 0x2185AD0
	private void <CreateDescendHere>b__15_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A46A0 Offset: 0x1A47A1 VA: 0x1A46A0
	// RVA: 0x2185B20 Offset: 0x2185C21 VA: 0x2185B20
	private void <CreateRiseToTarget>b__16_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A46B0 Offset: 0x1A47B1 VA: 0x1A46B0
	// RVA: 0x2185B70 Offset: 0x2185C71 VA: 0x2185B70
	private void <CreateDescendToTarget>b__17_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A46C0 Offset: 0x1A47C1 VA: 0x1A46C0
	// RVA: 0x2185BC0 Offset: 0x2185CC1 VA: 0x2185BC0
	private void <CreateDescendToTarget>b__17_1(int _, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A46D0 Offset: 0x1A47D1 VA: 0x1A46D0
	// RVA: 0x2185DD0 Offset: 0x2185ED1 VA: 0x2185DD0
	private void <CreateFloorMove>b__18_0(int _, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A46E0 Offset: 0x1A47E1 VA: 0x1A46E0
	// RVA: 0x2185DF0 Offset: 0x2185EF1 VA: 0x2185DF0
	private void <CreateOutSideMove>b__19_0(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A46F0 Offset: 0x1A47F1 VA: 0x1A46F0
	// RVA: 0x2186050 Offset: 0x2186151 VA: 0x2186050
	private void <CreateAttack12>b__23_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4700 Offset: 0x1A4801 VA: 0x1A4700
	// RVA: 0x21860A0 Offset: 0x21861A1 VA: 0x21860A0
	private void <CreateAttack13>b__24_0() { }
}

