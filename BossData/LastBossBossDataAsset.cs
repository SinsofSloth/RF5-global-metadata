[CreateAssetMenuAttribute] // RVA: 0x14A230 Offset: 0x14A331 VA: 0x14A230
public class LastBossBossDataAsset : BossDataAssetBase // TypeDefIndex: 10069
{
	// Fields
	[SerializeField] // RVA: 0x1805F0 Offset: 0x1806F1 VA: 0x1805F0
	private LastBossBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x30
	[SerializeField] // RVA: 0x180600 Offset: 0x180701 VA: 0x180600
	private LastBossBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x38

	// Methods

	// RVA: 0x2059D10 Offset: 0x2059E11 VA: 0x2059D10 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x2059D70 Offset: 0x2059E71 VA: 0x2059D70 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x2059E70 Offset: 0x2059F71 VA: 0x2059E70
	public void .ctor() { }
}

