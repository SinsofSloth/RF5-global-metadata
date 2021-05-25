[CreateAssetMenuAttribute] // RVA: 0x14A0A0 Offset: 0x14A1A1 VA: 0x14A0A0
public class InosisiBossDataAsset : BossDataAssetBase // TypeDefIndex: 10036
{
	// Fields
	[SerializeField] // RVA: 0x180430 Offset: 0x180531 VA: 0x180430
	private float MaxDamageHPPercent; // 0x2C
	[SerializeField] // RVA: 0x180440 Offset: 0x180541 VA: 0x180440
	private InosisiBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x30
	[SerializeField] // RVA: 0x180450 Offset: 0x180551 VA: 0x180450
	private InosisiBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x38

	// Methods

	// RVA: 0x22EDB20 Offset: 0x22EDC21 VA: 0x22EDB20 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x22EDB80 Offset: 0x22EDC81 VA: 0x22EDB80 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x22EDDA0 Offset: 0x22EDEA1 VA: 0x22EDDA0 Slot: 7
	public override float GetFloatParam(string key) { }

	// RVA: 0x22EDE20 Offset: 0x22EDF21 VA: 0x22EDE20
	public void .ctor() { }
}

