[CreateAssetMenuAttribute] // RVA: 0x14A320 Offset: 0x14A421 VA: 0x14A320
public class ReviatanBossDataAsset : BossDataAssetBase // TypeDefIndex: 10088
{
	// Fields
	[SerializeField] // RVA: 0x180650 Offset: 0x180751 VA: 0x180650
	private int IcePillarMax; // 0x2C
	[SerializeField] // RVA: 0x180660 Offset: 0x180761 VA: 0x180660
	private int NormalRecoveryCount; // 0x30
	[SerializeField] // RVA: 0x180670 Offset: 0x180771 VA: 0x180670
	private int VariationRecoveryCount; // 0x34
	[SerializeField] // RVA: 0x180680 Offset: 0x180781 VA: 0x180680
	private Vector2[] RecoveryPercents; // 0x38
	[SerializeField] // RVA: 0x180690 Offset: 0x180791 VA: 0x180690
	private ReviatanBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x40
	[SerializeField] // RVA: 0x1806A0 Offset: 0x1807A1 VA: 0x1806A0
	private ReviatanBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x48

	// Properties
	public Vector2[] GetRecoveryPercents { get; }

	// Methods

	// RVA: 0x205A430 Offset: 0x205A531 VA: 0x205A430
	public Vector2[] get_GetRecoveryPercents() { }

	// RVA: 0x205A440 Offset: 0x205A541 VA: 0x205A440 Slot: 6
	public override int GetIntParam(string key) { }

	// RVA: 0x205A530 Offset: 0x205A631 VA: 0x205A530 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x205A590 Offset: 0x205A691 VA: 0x205A590 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x205A690 Offset: 0x205A791 VA: 0x205A690
	public void .ctor() { }
}

