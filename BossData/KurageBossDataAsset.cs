[CreateAssetMenuAttribute] // RVA: 0x14A190 Offset: 0x14A291 VA: 0x14A190
public class KurageBossDataAsset : BossDataAssetBase // TypeDefIndex: 10056
{
	// Fields
	[SerializeField] // RVA: 0x1804E0 Offset: 0x1805E1 VA: 0x1804E0
	public Vector3 ChargingEffectPos; // 0x2C
	[SerializeField] // RVA: 0x1804F0 Offset: 0x1805F1 VA: 0x1804F0
	public Vector3 ChargingEffectScale; // 0x38
	[SerializeField] // RVA: 0x180500 Offset: 0x180601 VA: 0x180500
	private float HitAttackResetTime; // 0x44
	[SerializeField] // RVA: 0x180510 Offset: 0x180611 VA: 0x180510
	private float HitAttackChargePercent; // 0x48
	[SerializeField] // RVA: 0x180520 Offset: 0x180621 VA: 0x180520
	private float NotHitAttackChargePercent; // 0x4C
	[SerializeField] // RVA: 0x180530 Offset: 0x180631 VA: 0x180530
	private KurageBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x50
	[SerializeField] // RVA: 0x180540 Offset: 0x180641 VA: 0x180540
	private KurageBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x58

	// Methods

	// RVA: 0x22EE9A0 Offset: 0x22EEAA1 VA: 0x22EE9A0 Slot: 7
	public override float GetFloatParam(string key) { }

	// RVA: 0x22EEA80 Offset: 0x22EEB81 VA: 0x22EEA80 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x22EEAE0 Offset: 0x22EEBE1 VA: 0x22EEAE0 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x22EEBD0 Offset: 0x22EECD1 VA: 0x22EEBD0
	public void .ctor() { }
}

