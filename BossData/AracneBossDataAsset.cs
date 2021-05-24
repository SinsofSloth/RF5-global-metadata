[CreateAssetMenuAttribute] // RVA: 0x149CE0 Offset: 0x149DE1 VA: 0x149CE0
public class AracneBossDataAsset : BossDataAssetBase // TypeDefIndex: 9946
{
	// Fields
	[SerializeField] // RVA: 0x17FC40 Offset: 0x17FD41 VA: 0x17FC40
	private float AccumulatedDamage; // 0x2C
	[SerializeField] // RVA: 0x17FC50 Offset: 0x17FD51 VA: 0x17FC50
	private int MaxSpider; // 0x30
	[SerializeField] // RVA: 0x17FC60 Offset: 0x17FD61 VA: 0x17FC60
	private AracneBossDataAsset.LotteryBossBehaviorPramsList NormalActionList; // 0x38
	[SerializeField] // RVA: 0x17FC70 Offset: 0x17FD71 VA: 0x17FC70
	private AracneBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList; // 0x40
	[HeaderAttribute] // RVA: 0x17FC80 Offset: 0x17FD81 VA: 0x17FC80
	[SerializeField] // RVA: 0x17FC80 Offset: 0x17FD81 VA: 0x17FC80
	private float EventChangeMadnessRemainHPPercent; // 0x48

	// Methods

	// RVA: 0x22E8870 Offset: 0x22E8971 VA: 0x22E8870 Slot: 6
	public override int GetIntParam(string key) { }

	// RVA: 0x22E8900 Offset: 0x22E8A01 VA: 0x22E8900 Slot: 7
	public override float GetFloatParam(string key) { }

	// RVA: 0x22E8990 Offset: 0x22E8A91 VA: 0x22E8990 Slot: 4
	public override float ChangeMadnessRemainHPPercent(bool isColorVariation, MonsterDataID id) { }

	// RVA: 0x22E89E0 Offset: 0x22E8AE1 VA: 0x22E89E0 Slot: 9
	public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: 0x22E8A40 Offset: 0x22E8B41 VA: 0x22E8A40 Slot: 10
	public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x22E8C60 Offset: 0x22E8D61 VA: 0x22E8C60
	public void .ctor() { }
}

