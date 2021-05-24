[CreateAssetMenuAttribute] // RVA: 0x149E20 Offset: 0x149F21 VA: 0x149E20
public class CerberusBossDataAsset : BossDataAssetBase // TypeDefIndex: 9984
{
	// Fields
	[SerializeField] // RVA: 0x180040 Offset: 0x180141 VA: 0x180040
	private float HungryTime; // 0x2C
	[SerializeField] // RVA: 0x180050 Offset: 0x180151 VA: 0x180050
	private float MinWaitVigilanceTime; // 0x30
	[SerializeField] // RVA: 0x180060 Offset: 0x180161 VA: 0x180060
	private float MaxWaitVigilanceTime; // 0x34
	[SerializeField] // RVA: 0x180070 Offset: 0x180171 VA: 0x180070
	private float EscapeHPDamageResetTime; // 0x38
	[SerializeField] // RVA: 0x180080 Offset: 0x180181 VA: 0x180080
	private float EscapeHPDamagePercent; // 0x3C
	[SerializeField] // RVA: 0x180090 Offset: 0x180191 VA: 0x180090
	private float DivisionHPDamageResetTimer; // 0x40
	[SerializeField] // RVA: 0x1800A0 Offset: 0x1801A1 VA: 0x1800A0
	private float DivisionHPDamagePercent; // 0x44
	[SerializeField] // RVA: 0x1800B0 Offset: 0x1801B1 VA: 0x1800B0
	private List<CerberusBossDataAsset.LotteryParam> AttackPriorityList; // 0x48
	[SerializeField] // RVA: 0x1800C0 Offset: 0x1801C1 VA: 0x1800C0
	private List<CerberusBossDataAsset.LotteryParam> MadnessAttackPriorityList; // 0x50

	// Methods

	// RVA: 0x22EA830 Offset: 0x22EA931 VA: 0x22EA830 Slot: 7
	public override float GetFloatParam(string key) { }

	// RVA: 0x22EA9D0 Offset: 0x22EAAD1 VA: 0x22EA9D0 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x22EAA30 Offset: 0x22EAB31 VA: 0x22EAA30 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x22EAC10 Offset: 0x22EAD11 VA: 0x22EAC10
	public void .ctor() { }
}

