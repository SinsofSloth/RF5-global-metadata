[CreateAssetMenuAttribute] // RVA: 0x14A0F0 Offset: 0x14A1F1 VA: 0x14A0F0
public class KamereonBossDataAsset : BossDataAssetBase // TypeDefIndex: 10043
{
	// Fields
	[SerializeField] // RVA: 0x180460 Offset: 0x180561 VA: 0x180460
	private float StealthTimeNormal; // 0x2C
	[SerializeField] // RVA: 0x180470 Offset: 0x180571 VA: 0x180470
	private float StealthTimeMadness; // 0x30
	[SerializeField] // RVA: 0x180480 Offset: 0x180581 VA: 0x180480
	private float StealthSlowScale; // 0x34
	[SerializeField] // RVA: 0x180490 Offset: 0x180591 VA: 0x180490
	private KamereonBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x38
	[SerializeField] // RVA: 0x1804A0 Offset: 0x1805A1 VA: 0x1804A0
	private KamereonBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x40

	// Methods

	// RVA: 0x22EDFA0 Offset: 0x22EE0A1 VA: 0x22EDFA0 Slot: 7
	public override float GetFloatParam(string key) { }

	// RVA: 0x22EE080 Offset: 0x22EE181 VA: 0x22EE080 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x22EE0E0 Offset: 0x22EE1E1 VA: 0x22EE0E0 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x22EE300 Offset: 0x22EE401 VA: 0x22EE300
	public void .ctor() { }
}

