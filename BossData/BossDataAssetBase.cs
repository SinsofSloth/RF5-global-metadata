[Serializable]
public abstract class BossDataAssetBase : ScriptableObject // TypeDefIndex: 9980
{
	// Fields
	[HeaderAttribute] // RVA: 0x17FED0 Offset: 0x17FFD1 VA: 0x17FED0
	[SerializeField] // RVA: 0x17FED0 Offset: 0x17FFD1 VA: 0x17FED0
	private float _ChangeMadnessRemainHPPercent; // 0x18
	[HeaderAttribute] // RVA: 0x17FF20 Offset: 0x180021 VA: 0x17FF20
	[SerializeField] // RVA: 0x17FF20 Offset: 0x180021 VA: 0x17FF20
	private float VariationChangeMadnessRemainHPPercent; // 0x1C
	[HeaderAttribute] // RVA: 0x17FF70 Offset: 0x180071 VA: 0x17FF70
	[SerializeField] // RVA: 0x17FF70 Offset: 0x180071 VA: 0x17FF70
	private List<string> _MadnessEffectBoneList; // 0x20
	[SerializeField] // RVA: 0x17FFC0 Offset: 0x1800C1 VA: 0x17FFC0
	public float MadnessEffectScale; // 0x28

	// Properties
	public List<string> MadnessEffectBoneList { get; }

	// Methods

	// RVA: 0x22EA370 Offset: 0x22EA471 VA: 0x22EA370 Slot: 4
	public virtual float ChangeMadnessRemainHPPercent(bool isColorVariation, MonsterDataID dataid) { }

	// RVA: 0x22E89C0 Offset: 0x22E8AC1 VA: 0x22E89C0 Slot: 5
	public virtual float ChangeMadnessRemainHPPercent(bool isColorVariation) { }

	// RVA: 0x22EA390 Offset: 0x22EA491 VA: 0x22EA390
	public List<string> get_MadnessEffectBoneList() { }

	// RVA: 0x22E88F0 Offset: 0x22E89F1 VA: 0x22E88F0 Slot: 6
	public virtual int GetIntParam(string key) { }

	// RVA: 0x22E8980 Offset: 0x22E8A81 VA: 0x22E8980 Slot: 7
	public virtual float GetFloatParam(string key) { }

	// RVA: 0x22EA3A0 Offset: 0x22EA4A1 VA: 0x22EA3A0 Slot: 8
	public virtual bool GetBoolParam(string key) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract BossBehaviorController AddBossBehaviorControllerBase(GameObject monster) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract CalcLotteryBossBehavior GetCalcLotteryBossBehavior() { }

	// RVA: 0x22E8D10 Offset: 0x22E8E11 VA: 0x22E8D10
	protected void .ctor() { }
}

