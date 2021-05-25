[Serializable]
public class SkillDataTable // TypeDefIndex: 7042
{
	// Fields
	[SerializeField] // RVA: 0x162B80 Offset: 0x162C81 VA: 0x162B80
	public FloatParameter Parameter; // 0x10
	[SerializeField] // RVA: 0x162B90 Offset: 0x162C91 VA: 0x162B90
	public float ReduceRp; // 0xCC
	[SerializeField] // RVA: 0x162BA0 Offset: 0x162CA1 VA: 0x162BA0
	public int MaxLevel; // 0xD0
	[SerializeField] // RVA: 0x162BB0 Offset: 0x162CB1 VA: 0x162BB0
	public SkillLevelupType SkillLevelupType; // 0xD4
	private static SkillDataTableArray _SkillDataTableArray; // 0x0

	// Methods

	// RVA: 0x1C538D0 Offset: 0x1C539D1 VA: 0x1C538D0
	public static SkillDataTable GetDataTable(SkillID id) { }

	// RVA: 0x1C53A10 Offset: 0x1C53B11 VA: 0x1C53A10
	public void .ctor() { }
}

