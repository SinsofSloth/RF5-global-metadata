public class InosisiBehaviorController : BossBehaviorController // TypeDefIndex: 7888
{
	// Fields
	private float DamageAmount; // 0x1C8
	private float MaxDamageHPPercent; // 0x1CC
	private bool IsFilledDamage; // 0x1D0

	// Methods

	// RVA: 0x20C7190 Offset: 0x20C7291 VA: 0x20C7190
	private MonsterBehaviorController.BehaviorActionParam CreateMoveAroundAction() { }

	// RVA: 0x20C7350 Offset: 0x20C7451 VA: 0x20C7350
	private MonsterBehaviorController.BehaviorActionParam CreateStompAction() { }

	// RVA: 0x20C7520 Offset: 0x20C7621 VA: 0x20C7520
	private MonsterBehaviorController.BehaviorActionParam CreateChargeStompAction() { }

	// RVA: 0x20C76F0 Offset: 0x20C77F1 VA: 0x20C76F0
	private MonsterBehaviorController.BehaviorActionParam CreateThrowHornAction(int Rock) { }

	// RVA: 0x20C78F0 Offset: 0x20C79F1 VA: 0x20C78F0
	private MonsterBehaviorController.BehaviorActionParam CreateThrowWaveAction() { }

	// RVA: 0x20C7900 Offset: 0x20C7A01 VA: 0x20C7900
	private MonsterBehaviorController.BehaviorActionParam CreateThrowRockAction() { }

	// RVA: 0x20C7910 Offset: 0x20C7A11 VA: 0x20C7910
	private MonsterBehaviorController.BehaviorActionParam CreateMeteorAction() { }

	// RVA: 0x20C7AD0 Offset: 0x20C7BD1 VA: 0x20C7AD0
	private MonsterBehaviorController.BehaviorActionParam CreateSuperDushAction() { }

	// RVA: 0x20C7C90 Offset: 0x20C7D91 VA: 0x20C7C90
	private MonsterBehaviorController.BehaviorActionParam CreateRushMissileAction() { }

	// RVA: 0x20C7E60 Offset: 0x20C7F61 VA: 0x20C7E60
	private MonsterBehaviorController.BehaviorActionParam CreateMadnessMissileAction() { }

	// RVA: 0x20C8030 Offset: 0x20C8131 VA: 0x20C8030
	private MonsterBehaviorController.BehaviorActionParam CreateRushAction() { }

	// RVA: 0x20C81F0 Offset: 0x20C82F1 VA: 0x20C81F0 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x20C8430 Offset: 0x20C8531 VA: 0x20C8430 Slot: 84
	public override void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x20C84D0 Offset: 0x20C85D1 VA: 0x20C84D0 Slot: 90
	public override void OnUpdateBossDataBitArray() { }

	// RVA: 0x20C8550 Offset: 0x20C8651 VA: 0x20C8550
	private void UpdateDamageAmount(int damage) { }

	// RVA: 0x20C85D0 Offset: 0x20C86D1 VA: 0x20C85D0 Slot: 59
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: 0x20C86E0 Offset: 0x20C87E1 VA: 0x20C86E0 Slot: 94
	protected override void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x20C8730 Offset: 0x20C8831 VA: 0x20C8730
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3E30 Offset: 0x1A3F31 VA: 0x1A3E30
	// RVA: 0x20C8740 Offset: 0x20C8841 VA: 0x20C8740
	private void <CreateMoveAroundAction>b__3_1(int index, int type) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3E40 Offset: 0x1A3F41 VA: 0x1A3E40
	// RVA: 0x20C8920 Offset: 0x20C8A21 VA: 0x20C8920
	private void <CreateStompAction>b__4_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3E50 Offset: 0x1A3F51 VA: 0x1A3E50
	// RVA: 0x20C8970 Offset: 0x20C8A71 VA: 0x20C8970
	private void <CreateChargeStompAction>b__5_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3E60 Offset: 0x1A3F61 VA: 0x1A3E60
	// RVA: 0x20C89C0 Offset: 0x20C8AC1 VA: 0x20C89C0
	private void <CreateMeteorAction>b__9_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3E70 Offset: 0x1A3F71 VA: 0x1A3E70
	// RVA: 0x20C8A10 Offset: 0x20C8B11 VA: 0x20C8A10
	private void <CreateSuperDushAction>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3E80 Offset: 0x1A3F81 VA: 0x1A3E80
	// RVA: 0x20C8A60 Offset: 0x20C8B61 VA: 0x20C8A60
	private void <CreateRushMissileAction>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3E90 Offset: 0x1A3F91 VA: 0x1A3E90
	// RVA: 0x20C8AB0 Offset: 0x20C8BB1 VA: 0x20C8AB0
	private void <CreateMadnessMissileAction>b__12_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3EA0 Offset: 0x1A3FA1 VA: 0x1A3EA0
	// RVA: 0x20C8B00 Offset: 0x20C8C01 VA: 0x20C8B00
	private void <CreateRushAction>b__13_0() { }
}

