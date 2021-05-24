[CreateAssetMenuAttribute] // RVA: 0x14A460 Offset: 0x14A561 VA: 0x14A460
public class YadokariBossDataAsset : BossDataAssetBase // TypeDefIndex: 10114
{
	// Fields
	[SerializeField] // RVA: 0x1807A0 Offset: 0x1808A1 VA: 0x1807A0
	private int ShellDamageBonusPercent; // 0x2C
	[SerializeField] // RVA: 0x1807B0 Offset: 0x1808B1 VA: 0x1807B0
	private YadokariBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x30
	[SerializeField] // RVA: 0x1807C0 Offset: 0x1808C1 VA: 0x1807C0
	private YadokariBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x38

	// Methods

	// RVA: 0x205B4E0 Offset: 0x205B5E1 VA: 0x205B4E0 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x205B540 Offset: 0x205B641 VA: 0x205B540 Slot: 6
	public override int GetIntParam(string key) { }

	// RVA: 0x205B5D0 Offset: 0x205B6D1 VA: 0x205B5D0 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x205B6D0 Offset: 0x205B7D1 VA: 0x205B6D0
	public void .ctor() { }
}

