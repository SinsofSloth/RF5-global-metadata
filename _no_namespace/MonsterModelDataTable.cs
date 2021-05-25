public class MonsterModelDataTable : ScriptableObject // TypeDefIndex: 7779
{
	// Fields
	public List<MonsterModelData> MonsterModelDatas; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x169910 Offset: 0x169A11 VA: 0x169910
	private Dictionary<MonsterModelDataID, MonsterModelData> <DataTables>k__BackingField; // 0x20

	// Properties
	public Dictionary<MonsterModelDataID, MonsterModelData> DataTables { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A2BF0 Offset: 0x1A2CF1 VA: 0x1A2BF0
	// RVA: 0x1CD2F40 Offset: 0x1CD3041 VA: 0x1CD2F40
	public Dictionary<MonsterModelDataID, MonsterModelData> get_DataTables() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2C00 Offset: 0x1A2D01 VA: 0x1A2C00
	// RVA: 0x1CD2F50 Offset: 0x1CD3051 VA: 0x1CD2F50
	private void set_DataTables(Dictionary<MonsterModelDataID, MonsterModelData> value) { }

	// RVA: 0x1CCE960 Offset: 0x1CCEA61 VA: 0x1CCE960
	public void Setup() { }

	// RVA: 0x1CD2F60 Offset: 0x1CD3061 VA: 0x1CD2F60
	public void Clear() { }

	// RVA: 0x1CD0590 Offset: 0x1CD0691 VA: 0x1CD0590
	public MonsterModelData GetModelData(MonsterModelDataID id) { }

	// RVA: 0x1CD2FC0 Offset: 0x1CD30C1 VA: 0x1CD2FC0
	public void .ctor() { }
}

