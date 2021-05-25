[CreateAssetMenuAttribute] // RVA: 0x14A140 Offset: 0x14A241 VA: 0x14A140
public class KrakenBossDataAsset : BossDataAssetBase // TypeDefIndex: 10049
{
	// Fields
	[SerializeField] // RVA: 0x1804B0 Offset: 0x1805B1 VA: 0x1804B0
	private KrakenBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x30
	[SerializeField] // RVA: 0x1804C0 Offset: 0x1805C1 VA: 0x1804C0
	private KrakenBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x38
	[SerializeField] // RVA: 0x1804D0 Offset: 0x1805D1 VA: 0x1804D0
	private KrakenBossDataAsset.LotteryBossBehaviorPramsList InWaterActionList; // 0x40

	// Methods

	// RVA: 0x22EE490 Offset: 0x22EE591 VA: 0x22EE490 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x22EE4F0 Offset: 0x22EE5F1 VA: 0x22EE4F0 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x22EE730 Offset: 0x22EE831 VA: 0x22EE730
	public void .ctor() { }
}

