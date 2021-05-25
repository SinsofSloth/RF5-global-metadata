[CreateAssetMenuAttribute] // RVA: 0x14A3C0 Offset: 0x14A4C1 VA: 0x14A3C0
public class SkullDragonBossDataAsset : BossDataAssetBase // TypeDefIndex: 10101
{
	// Fields
	[SerializeField] // RVA: 0x1806F0 Offset: 0x1807F1 VA: 0x1806F0
	public float MaxTailDamageHPPercent; // 0x2C
	[SerializeField] // RVA: 0x180700 Offset: 0x180801 VA: 0x180700
	public float WaitFireBreathTime; // 0x30
	[SerializeField] // RVA: 0x180710 Offset: 0x180811 VA: 0x180710
	public float WaitAngerTime; // 0x34
	[SerializeField] // RVA: 0x180720 Offset: 0x180821 VA: 0x180720
	private List<SkullDragonBossDataAsset.LotteryParam> ActionList; // 0x38
	[SerializeField] // RVA: 0x180730 Offset: 0x180831 VA: 0x180730
	private List<SkullDragonBossDataAsset.LotteryParam> FilledTailDamageActionList; // 0x40
	[SerializeField] // RVA: 0x180740 Offset: 0x180841 VA: 0x180740
	private List<SkullDragonBossDataAsset.LotteryParam> MadnessActionList; // 0x48

	// Methods

	// RVA: 0x205ACB0 Offset: 0x205ADB1 VA: 0x205ACB0 Slot: 7
	public override float GetFloatParam(string key) { }

	// RVA: 0x205ADA0 Offset: 0x205AEA1 VA: 0x205ADA0 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x205AE00 Offset: 0x205AF01 VA: 0x205AE00 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x205AEE0 Offset: 0x205AFE1 VA: 0x205AEE0
	public void .ctor() { }
}

