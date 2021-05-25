[CreateAssetMenuAttribute] // RVA: 0x14A280 Offset: 0x14A381 VA: 0x14A280
public class MummyBossDataAsset : BossDataAssetBase // TypeDefIndex: 10075
{
	// Fields
	[SerializeField] // RVA: 0x180610 Offset: 0x180711 VA: 0x180610
	private MummyBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x30
	[SerializeField] // RVA: 0x180620 Offset: 0x180721 VA: 0x180620
	private MummyBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x38

	// Methods

	// RVA: 0x2059F70 Offset: 0x205A071 VA: 0x2059F70 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x2059FD0 Offset: 0x205A0D1 VA: 0x2059FD0 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x205A0D0 Offset: 0x205A1D1 VA: 0x205A0D0
	public void .ctor() { }
}

