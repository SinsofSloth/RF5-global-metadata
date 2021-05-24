[CreateAssetMenuAttribute] // RVA: 0x14A000 Offset: 0x14A101 VA: 0x14A000
public class HasibirokouBossDataAsset : BossDataAssetBase // TypeDefIndex: 10024
{
	// Fields
	[SerializeField] // RVA: 0x1803F0 Offset: 0x1804F1 VA: 0x1803F0
	private HasibirokouBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x30
	[SerializeField] // RVA: 0x180400 Offset: 0x180501 VA: 0x180400
	private HasibirokouBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x38

	// Methods

	// RVA: 0x22ED320 Offset: 0x22ED421 VA: 0x22ED320 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x22ED380 Offset: 0x22ED481 VA: 0x22ED380 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x22ED5A0 Offset: 0x22ED6A1 VA: 0x22ED5A0
	public void .ctor() { }
}

