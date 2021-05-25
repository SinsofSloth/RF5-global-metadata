[CreateAssetMenuAttribute] // RVA: 0x149D80 Offset: 0x149E81 VA: 0x149D80
public class AudmuraBossDataAsset : BossDataAssetBase // TypeDefIndex: 9959
{
	// Fields
	[SerializeField] // RVA: 0x17FCF0 Offset: 0x17FDF1 VA: 0x17FCF0
	private int CrystalHP; // 0x2C
	[SerializeField] // RVA: 0x17FD00 Offset: 0x17FE01 VA: 0x17FD00
	private AudmuraBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x30
	[SerializeField] // RVA: 0x17FD10 Offset: 0x17FE11 VA: 0x17FD10
	private AudmuraBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x38

	// Methods

	// RVA: 0x22E9490 Offset: 0x22E9591 VA: 0x22E9490 Slot: 6
	public override int GetIntParam(string key) { }

	// RVA: 0x22E9510 Offset: 0x22E9611 VA: 0x22E9510 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x22E9570 Offset: 0x22E9671 VA: 0x22E9570 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x22E9790 Offset: 0x22E9891 VA: 0x22E9790
	public void .ctor() { }
}

