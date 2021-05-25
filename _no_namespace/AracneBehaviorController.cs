public class AracneBehaviorController : BossBehaviorController // TypeDefIndex: 7783
{
	// Fields
	private int AccumulatedDamageCounter; // 0x1C8
	private float AccumulatedDamagePercent; // 0x1CC
	private int MaxSpiderNum; // 0x1D0

	// Properties
	private bool IsAccumulatedDamage { get; }
	private bool Is2PColor { get; }

	// Methods

	// RVA: 0x227AA60 Offset: 0x227AB61 VA: 0x227AA60
	private bool get_IsAccumulatedDamage() { }

	// RVA: 0x227AAD0 Offset: 0x227ABD1 VA: 0x227AAD0
	private bool get_Is2PColor() { }

	// RVA: 0x227AB20 Offset: 0x227AC21 VA: 0x227AB20 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x227B830 Offset: 0x227B931 VA: 0x227B830 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x227B870 Offset: 0x227B971 VA: 0x227B870 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x227B9B0 Offset: 0x227BAB1 VA: 0x227B9B0 Slot: 59
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: 0x227BAB0 Offset: 0x227BBB1 VA: 0x227BAB0 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x227BAF0 Offset: 0x227BBF1 VA: 0x227BAF0 Slot: 95
	protected override void UpdateReciveItemBehaviorTiming() { }

	// RVA: 0x227ACA0 Offset: 0x227ADA1 VA: 0x227ACA0
	private MonsterBehaviorController.BehaviorActionParam CreateBothfeetStabAttack() { }

	// RVA: 0x227AE80 Offset: 0x227AF81 VA: 0x227AE80
	private MonsterBehaviorController.BehaviorActionParam CreateFlatWebAttack() { }

	// RVA: 0x227B060 Offset: 0x227B161 VA: 0x227B060
	private MonsterBehaviorController.BehaviorActionParam CreateEightfeetStabAttack() { }

	// RVA: 0x227B230 Offset: 0x227B331 VA: 0x227B230
	private MonsterBehaviorController.BehaviorActionParam CreateCageWebAttack() { }

	// RVA: 0x227B410 Offset: 0x227B511 VA: 0x227B410
	private MonsterBehaviorController.BehaviorActionParam CreateSprinklingVenomAttack() { }

	// RVA: 0x227B670 Offset: 0x227B771 VA: 0x227B670
	private MonsterBehaviorController.BehaviorActionParam CreateMasterSpiderSpawn() { }

	// RVA: 0x227BBD0 Offset: 0x227BCD1 VA: 0x227BBD0 Slot: 89
	public override string GetLotteryTypeEnumToString(int SelectType) { }

	// RVA: 0x227BD10 Offset: 0x227BE11 VA: 0x227BD10
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2C10 Offset: 0x1A2D11 VA: 0x1A2C10
	// RVA: 0x227BD20 Offset: 0x227BE21 VA: 0x227BD20
	private void <CreateBothfeetStabAttack>b__13_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2C20 Offset: 0x1A2D21 VA: 0x1A2C20
	// RVA: 0x227BD70 Offset: 0x227BE71 VA: 0x227BD70
	private void <CreateFlatWebAttack>b__14_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2C30 Offset: 0x1A2D31 VA: 0x1A2C30
	// RVA: 0x227BDC0 Offset: 0x227BEC1 VA: 0x227BDC0
	private void <CreateEightfeetStabAttack>b__15_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2C40 Offset: 0x1A2D41 VA: 0x1A2C40
	// RVA: 0x227BE10 Offset: 0x227BF11 VA: 0x227BE10
	private void <CreateCageWebAttack>b__16_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2C50 Offset: 0x1A2D51 VA: 0x1A2C50
	// RVA: 0x227BE60 Offset: 0x227BF61 VA: 0x227BE60
	private void <CreateSprinklingVenomAttack>b__17_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2C60 Offset: 0x1A2D61 VA: 0x1A2C60
	// RVA: 0x227BEB0 Offset: 0x227BFB1 VA: 0x227BEB0
	private void <CreateMasterSpiderSpawn>b__18_0() { }
}

