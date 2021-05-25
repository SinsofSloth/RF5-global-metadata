public class GansekiDragonBehaviorController : BossBehaviorController // TypeDefIndex: 7860
{
	// Fields
	private const float RUSH_CLOSE_RANGE = 6;
	private const float DEFAULT_MOVESPEED = 0.8;
	private const float RUSH_MOVESPEED = 1;
	private float T; // 0x1C8
	private float AccumulatedDamageMimicryCounter; // 0x1CC
	private bool IsMimicryRelease; // 0x1D0
	private int BehaviorSkipCount; // 0x1D4
	private float AccumulatedDamageMimicry; // 0x1D8
	private float MimicryWaitTime; // 0x1DC

	// Properties
	private bool IsAccumulatedDamage { get; }

	// Methods

	// RVA: 0x1E39320 Offset: 0x1E39421 VA: 0x1E39320
	private bool get_IsAccumulatedDamage() { }

	// RVA: 0x1E393A0 Offset: 0x1E394A1 VA: 0x1E393A0 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x1E3BE80 Offset: 0x1E3BF81 VA: 0x1E3BE80 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x1E3BEC0 Offset: 0x1E3BFC1 VA: 0x1E3BEC0 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x1E3BF90 Offset: 0x1E3C091 VA: 0x1E3BF90 Slot: 59
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: 0x1E3C150 Offset: 0x1E3C251 VA: 0x1E3C150 Slot: 86
	public override void OnMadness() { }

	// RVA: 0x1E3C200 Offset: 0x1E3C301 VA: 0x1E3C200 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x1E3C2F0 Offset: 0x1E3C3F1 VA: 0x1E3C2F0 Slot: 95
	protected override void UpdateReciveItemBehaviorTiming() { }

	// RVA: 0x1E3C3B0 Offset: 0x1E3C4B1 VA: 0x1E3C3B0 Slot: 81
	public override void OnRestraint() { }

	// RVA: 0x1E398B0 Offset: 0x1E399B1 VA: 0x1E398B0
	private MonsterBehaviorController.BehaviorActionParam CreateRushAttack() { }

	// RVA: 0x1E39A70 Offset: 0x1E39B71 VA: 0x1E39A70
	private MonsterBehaviorController.BehaviorActionParam CreateDoubleRushAttack() { }

	// RVA: 0x1E39C30 Offset: 0x1E39D31 VA: 0x1E39C30
	private MonsterBehaviorController.BehaviorActionParam CreateTramplingAttack() { }

	// RVA: 0x1E39E00 Offset: 0x1E39F01 VA: 0x1E39E00
	private MonsterBehaviorController.BehaviorActionParam CreateHeadButtAttack() { }

	// RVA: 0x1E3A0D0 Offset: 0x1E3A1D1 VA: 0x1E3A0D0
	private MonsterBehaviorController.BehaviorActionParam CreateRockSkippingAttack() { }

	// RVA: 0x1E3A2A0 Offset: 0x1E3A3A1 VA: 0x1E3A2A0
	private MonsterBehaviorController.BehaviorActionParam CreateTiltTramplingAttack() { }

	// RVA: 0x1E39F10 Offset: 0x1E3A011 VA: 0x1E39F10
	private MonsterBehaviorController.BehaviorActionParam CreateJumpAttack() { }

	// RVA: 0x1E3A9C0 Offset: 0x1E3AAC1 VA: 0x1E3A9C0
	private MonsterBehaviorController.BehaviorActionParam CreateRockMimicryAttack() { }

	// RVA: 0x1E3AB80 Offset: 0x1E3AC81 VA: 0x1E3AB80
	private MonsterBehaviorController.BehaviorActionParam CreateRockMimicryJumpAttack() { }

	// RVA: 0x1E3ADE0 Offset: 0x1E3AEE1 VA: 0x1E3ADE0
	private MonsterBehaviorController.BehaviorActionParam CreateRockMimicryRushAttack() { }

	// RVA: 0x1E3B040 Offset: 0x1E3B141 VA: 0x1E3B040
	private MonsterBehaviorController.BehaviorActionParam CreateDoubleRockMimicryRushAttack() { }

	// RVA: 0x1E3B2A0 Offset: 0x1E3B3A1 VA: 0x1E3B2A0
	private MonsterBehaviorController.BehaviorActionParam CreateRockMimicryRelease() { }

	// RVA: 0x1E3A470 Offset: 0x1E3A571 VA: 0x1E3A470
	private MonsterBehaviorController.BehaviorActionParam CreateDoubleEarthSpike() { }

	// RVA: 0x1E3A630 Offset: 0x1E3A731 VA: 0x1E3A630
	private MonsterBehaviorController.BehaviorActionParam CreateTripleEarthSpike() { }

	// RVA: 0x1E3A7F0 Offset: 0x1E3A8F1 VA: 0x1E3A7F0
	private MonsterBehaviorController.BehaviorActionParam CreateAvengerRock() { }

	// RVA: 0x1E3B4A0 Offset: 0x1E3B5A1 VA: 0x1E3B4A0
	private MonsterBehaviorController.BehaviorActionParam CreateEatRock1() { }

	// RVA: 0x1E3B670 Offset: 0x1E3B771 VA: 0x1E3B670
	private MonsterBehaviorController.BehaviorActionParam CreateEatRock2() { }

	// RVA: 0x1E3B840 Offset: 0x1E3B941 VA: 0x1E3B840
	private MonsterBehaviorController.BehaviorActionParam CreateRushMove() { }

	// RVA: 0x1E3B980 Offset: 0x1E3BA81 VA: 0x1E3B980
	private MonsterBehaviorController.BehaviorActionParam CreateMimicryWait1() { }

	// RVA: 0x1E3BA80 Offset: 0x1E3BB81 VA: 0x1E3BA80
	private MonsterBehaviorController.BehaviorActionParam CreateMimicryWait2() { }

	// RVA: 0x1E3BC80 Offset: 0x1E3BD81 VA: 0x1E3BC80
	private MonsterBehaviorController.BehaviorActionParam CreateAngry() { }

	// RVA: 0x1E3BD80 Offset: 0x1E3BE81 VA: 0x1E3BD80
	private MonsterBehaviorController.BehaviorActionParam CreateMimicryMagic() { }

	// RVA: 0x1E3C3F0 Offset: 0x1E3C4F1 VA: 0x1E3C3F0
	private TaskStatus MimicryWait() { }

	// RVA: 0x1E3C590 Offset: 0x1E3C691 VA: 0x1E3C590 Slot: 89
	public override string GetLotteryTypeEnumToString(int SelectType) { }

	// RVA: 0x1E3C6D0 Offset: 0x1E3C7D1 VA: 0x1E3C6D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3750 Offset: 0x1A3851 VA: 0x1A3750
	// RVA: 0x1E3C6E0 Offset: 0x1E3C7E1 VA: 0x1E3C6E0
	private void <OnSetup>b__12_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3760 Offset: 0x1A3861 VA: 0x1A3760
	// RVA: 0x1E3C6F0 Offset: 0x1E3C7F1 VA: 0x1E3C6F0
	private void <CreateRushAttack>b__20_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3770 Offset: 0x1A3871 VA: 0x1A3770
	// RVA: 0x1E3C740 Offset: 0x1E3C841 VA: 0x1E3C740
	private void <CreateDoubleRushAttack>b__21_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3780 Offset: 0x1A3881 VA: 0x1A3780
	// RVA: 0x1E3C790 Offset: 0x1E3C891 VA: 0x1E3C790
	private void <CreateTramplingAttack>b__22_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3790 Offset: 0x1A3891 VA: 0x1A3790
	// RVA: 0x1E3C7E0 Offset: 0x1E3C8E1 VA: 0x1E3C7E0
	private void <CreateHeadButtAttack>b__23_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A37A0 Offset: 0x1A38A1 VA: 0x1A37A0
	// RVA: 0x1E3C830 Offset: 0x1E3C931 VA: 0x1E3C830
	private void <CreateRockSkippingAttack>b__24_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A37B0 Offset: 0x1A38B1 VA: 0x1A37B0
	// RVA: 0x1E3C880 Offset: 0x1E3C981 VA: 0x1E3C880
	private void <CreateTiltTramplingAttack>b__25_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A37C0 Offset: 0x1A38C1 VA: 0x1A37C0
	// RVA: 0x1E3C8D0 Offset: 0x1E3C9D1 VA: 0x1E3C8D0
	private void <CreateJumpAttack>b__26_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A37D0 Offset: 0x1A38D1 VA: 0x1A37D0
	// RVA: 0x1E3C920 Offset: 0x1E3CA21 VA: 0x1E3C920
	private void <CreateRockMimicryAttack>b__27_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A37E0 Offset: 0x1A38E1 VA: 0x1A37E0
	// RVA: 0x1E3C980 Offset: 0x1E3CA81 VA: 0x1E3C980
	private void <CreateRockMimicryJumpAttack>b__28_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A37F0 Offset: 0x1A38F1 VA: 0x1A37F0
	// RVA: 0x1E3C9D0 Offset: 0x1E3CAD1 VA: 0x1E3C9D0
	private void <CreateRockMimicryRushAttack>b__29_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3800 Offset: 0x1A3901 VA: 0x1A3800
	// RVA: 0x1E3CA20 Offset: 0x1E3CB21 VA: 0x1E3CA20
	private void <CreateDoubleRockMimicryRushAttack>b__30_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3810 Offset: 0x1A3911 VA: 0x1A3810
	// RVA: 0x1E3CA70 Offset: 0x1E3CB71 VA: 0x1E3CA70
	private void <CreateRockMimicryRelease>b__31_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3820 Offset: 0x1A3921 VA: 0x1A3820
	// RVA: 0x1E3CAC0 Offset: 0x1E3CBC1 VA: 0x1E3CAC0
	private void <CreateRockMimicryRelease>b__31_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3830 Offset: 0x1A3931 VA: 0x1A3830
	// RVA: 0x1E3CB70 Offset: 0x1E3CC71 VA: 0x1E3CB70
	private void <CreateDoubleEarthSpike>b__32_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3840 Offset: 0x1A3941 VA: 0x1A3840
	// RVA: 0x1E3CBC0 Offset: 0x1E3CCC1 VA: 0x1E3CBC0
	private void <CreateTripleEarthSpike>b__33_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3850 Offset: 0x1A3951 VA: 0x1A3850
	// RVA: 0x1E3CC10 Offset: 0x1E3CD11 VA: 0x1E3CC10
	private void <CreateAvengerRock>b__34_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3860 Offset: 0x1A3961 VA: 0x1A3860
	// RVA: 0x1E3CC70 Offset: 0x1E3CD71 VA: 0x1E3CC70
	private void <CreateEatRock1>b__35_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3870 Offset: 0x1A3971 VA: 0x1A3870
	// RVA: 0x1E3CCC0 Offset: 0x1E3CDC1 VA: 0x1E3CCC0
	private void <CreateEatRock2>b__36_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3880 Offset: 0x1A3981 VA: 0x1A3880
	// RVA: 0x1E3CD10 Offset: 0x1E3CE11 VA: 0x1E3CD10
	private void <CreateRushMove>b__37_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3890 Offset: 0x1A3991 VA: 0x1A3890
	// RVA: 0x1E3CD70 Offset: 0x1E3CE71 VA: 0x1E3CD70
	private void <CreateRushMove>b__37_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A38A0 Offset: 0x1A39A1 VA: 0x1A38A0
	// RVA: 0x1E3CE10 Offset: 0x1E3CF11 VA: 0x1E3CE10
	private void <CreateMimicryWait1>b__38_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A38B0 Offset: 0x1A39B1 VA: 0x1A38B0
	// RVA: 0x1E3CE30 Offset: 0x1E3CF31 VA: 0x1E3CE30
	private void <CreateMimicryWait2>b__39_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A38C0 Offset: 0x1A39C1 VA: 0x1A38C0
	// RVA: 0x1E3CE50 Offset: 0x1E3CF51 VA: 0x1E3CE50
	private void <CreateMimicryWait2>b__39_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A38D0 Offset: 0x1A39D1 VA: 0x1A38D0
	// RVA: 0x1E3CE60 Offset: 0x1E3CF61 VA: 0x1E3CE60
	private void <CreateAngry>b__40_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A38E0 Offset: 0x1A39E1 VA: 0x1A38E0
	// RVA: 0x1E3CEB0 Offset: 0x1E3CFB1 VA: 0x1E3CEB0
	private void <CreateMimicryMagic>b__41_0() { }
}

