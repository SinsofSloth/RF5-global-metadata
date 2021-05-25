[CreateAssetMenuAttribute] // RVA: 0x149F60 Offset: 0x14A061 VA: 0x149F60
public class GansekiDragonBossDataAsset : BossDataAssetBase // TypeDefIndex: 10010
{
	// Fields
	[HeaderAttribute] // RVA: 0x1802C0 Offset: 0x1803C1 VA: 0x1802C0
	[SerializeField] // RVA: 0x1802C0 Offset: 0x1803C1 VA: 0x1802C0
	private int NormalLoopPattenMax; // 0x2C
	[SerializeField] // RVA: 0x180310 Offset: 0x180411 VA: 0x180310
	private int MadnessLoopPattenMax; // 0x30
	[SerializeField] // RVA: 0x180320 Offset: 0x180421 VA: 0x180320
	private float AccumulatedDamageMimicry; // 0x34
	[SerializeField] // RVA: 0x180330 Offset: 0x180431 VA: 0x180330
	private float DefencelayerDamageRate; // 0x38
	[SerializeField] // RVA: 0x180340 Offset: 0x180441 VA: 0x180340
	private float MimicryWaitTime; // 0x3C
	[SerializeField] // RVA: 0x180350 Offset: 0x180451 VA: 0x180350
	private float ForceReleaseMimicryDamageRate; // 0x40
	[SerializeField] // RVA: 0x180360 Offset: 0x180461 VA: 0x180360
	private float ForceReleaseMimicryDamageRateTime; // 0x44
	[SerializeField] // RVA: 0x180370 Offset: 0x180471 VA: 0x180370
	private GansekiDragonBossDataAsset.LotteryBossBehaviorPramsList NormalAttackActionList; // 0x48
	[SerializeField] // RVA: 0x180380 Offset: 0x180481 VA: 0x180380
	private GansekiDragonBossDataAsset.LotteryBossBehaviorPramsList MadnessAttackActionList; // 0x50
	[SerializeField] // RVA: 0x180390 Offset: 0x180491 VA: 0x180390
	private GansekiDragonBossDataAsset.LotteryBossBehaviorPramsList MimicryAttackActionList; // 0x58

	// Methods

	// RVA: 0x22EC690 Offset: 0x22EC791 VA: 0x22EC690 Slot: 7
	public override float GetFloatParam(string key) { }

	// RVA: 0x22EC7D0 Offset: 0x22EC8D1 VA: 0x22EC7D0 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x22EC830 Offset: 0x22EC931 VA: 0x22EC830 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x22ECA20 Offset: 0x22ECB21 VA: 0x22ECA20
	public void .ctor() { }
}

