[CreateAssetMenuAttribute] // RVA: 0x14A050 Offset: 0x14A151 VA: 0x14A050
public class HekatonkeilBossDataAsset : BossDataAssetBase // TypeDefIndex: 10030
{
	// Fields
	[SerializeField] // RVA: 0x180410 Offset: 0x180511 VA: 0x180410
	private HekatonkeilBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x30
	[SerializeField] // RVA: 0x180420 Offset: 0x180521 VA: 0x180420
	private HekatonkeilBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x38

	// Methods

	// RVA: 0x22ED720 Offset: 0x22ED821 VA: 0x22ED720 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x22ED780 Offset: 0x22ED881 VA: 0x22ED780 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x22ED9A0 Offset: 0x22EDAA1 VA: 0x22ED9A0
	public void .ctor() { }
}

