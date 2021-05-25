[CreateAssetMenuAttribute] // RVA: 0x14A2D0 Offset: 0x14A3D1 VA: 0x14A2D0
public class OuroborosBossDataAsset : BossDataAssetBase // TypeDefIndex: 10081
{
	// Fields
	[SerializeField] // RVA: 0x180630 Offset: 0x180731 VA: 0x180630
	private OuroborosBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x30
	[SerializeField] // RVA: 0x180640 Offset: 0x180741 VA: 0x180640
	private OuroborosBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x38

	// Methods

	// RVA: 0x205A1D0 Offset: 0x205A2D1 VA: 0x205A1D0 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x205A230 Offset: 0x205A331 VA: 0x205A230 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x205A330 Offset: 0x205A431 VA: 0x205A330
	public void .ctor() { }
}

