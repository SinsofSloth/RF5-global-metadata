[CreateAssetMenuAttribute] // RVA: 0x149EC0 Offset: 0x149FC1 VA: 0x149EC0
public class DragonSisterBossDataAsset : BossDataAssetBase // TypeDefIndex: 9996
{
	// Fields
	[SerializeField] // RVA: 0x180190 Offset: 0x180291 VA: 0x180190
	private DragonSisterBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x30
	[SerializeField] // RVA: 0x1801A0 Offset: 0x1802A1 VA: 0x1801A0
	private DragonSisterBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x38

	// Methods

	// RVA: 0x22EB830 Offset: 0x22EB931 VA: 0x22EB830 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x22EB890 Offset: 0x22EB991 VA: 0x22EB890 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x22EBAB0 Offset: 0x22EBBB1 VA: 0x22EBAB0
	public void .ctor() { }
}

