[CreateAssetMenuAttribute] // RVA: 0x14A370 Offset: 0x14A471 VA: 0x14A370
public class SasquatchBossDataAsset : BossDataAssetBase // TypeDefIndex: 10095
{
	// Fields
	[SerializeField] // RVA: 0x1806B0 Offset: 0x1807B1 VA: 0x1806B0
	private float WalkRange; // 0x2C
	[SerializeField] // RVA: 0x1806C0 Offset: 0x1807C1 VA: 0x1806C0
	private float RestraintDamageRate; // 0x30
	[SerializeField] // RVA: 0x1806D0 Offset: 0x1807D1 VA: 0x1806D0
	private SasquatchBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x38
	[SerializeField] // RVA: 0x1806E0 Offset: 0x1807E1 VA: 0x1806E0
	private SasquatchBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x40

	// Methods

	// RVA: 0x205A980 Offset: 0x205AA81 VA: 0x205A980 Slot: 7
	public override float GetFloatParam(string key) { }

	// RVA: 0x205AA40 Offset: 0x205AB41 VA: 0x205AA40 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x205AAA0 Offset: 0x205ABA1 VA: 0x205AAA0 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x205ABA0 Offset: 0x205ACA1 VA: 0x205ABA0
	public void .ctor() { }
}

