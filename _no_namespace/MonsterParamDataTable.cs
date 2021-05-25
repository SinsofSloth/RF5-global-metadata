[Serializable]
public class MonsterParamDataTable // TypeDefIndex: 7013
{
	// Fields
	[SerializeField] // RVA: 0x162730 Offset: 0x162831 VA: 0x162730
	public int Level; // 0x10
	[SerializeField] // RVA: 0x162740 Offset: 0x162841 VA: 0x162740
	public Parameter Parameter; // 0x14
	[SerializeField] // RVA: 0x162750 Offset: 0x162851 VA: 0x162750
	public int Exp; // 0xD0
	private static MonsterParamDataTableArray _MonsterParamTypeDataTableArray; // 0x0

	// Methods

	// RVA: 0x1CD33A0 Offset: 0x1CD34A1 VA: 0x1CD33A0
	public static ValueTuple<MonsterParamDataTable, MonsterParamDataTable> GetDataTables(int level, bool levelup) { }

	// RVA: 0x1CD35F0 Offset: 0x1CD36F1 VA: 0x1CD35F0
	public void .ctor() { }
}

