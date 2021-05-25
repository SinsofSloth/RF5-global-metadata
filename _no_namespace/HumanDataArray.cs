[Serializable]
public class HumanDataArray // TypeDefIndex: 6974
{
	// Fields
	[SerializeField] // RVA: 0x162250 Offset: 0x162351 VA: 0x162250
	public CharID CharId; // 0x10
	[SerializeField] // RVA: 0x162260 Offset: 0x162361 VA: 0x162260
	public List<HumanData> HumanDatas; // 0x18
	[SerializeField] // RVA: 0x162270 Offset: 0x162371 VA: 0x162270
	public Character[] BaseId; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x162280 Offset: 0x162381 VA: 0x162280
	private Dictionary<HairType, Dictionary<VariationNo, HumanData>> <DataTables>k__BackingField; // 0x28

	// Properties
	public Dictionary<HairType, Dictionary<VariationNo, HumanData>> DataTables { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DD30 Offset: 0x19DE31 VA: 0x19DD30
	// RVA: 0x1E915D0 Offset: 0x1E916D1 VA: 0x1E915D0
	public Dictionary<HairType, Dictionary<VariationNo, HumanData>> get_DataTables() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DD40 Offset: 0x19DE41 VA: 0x19DD40
	// RVA: 0x1E915E0 Offset: 0x1E916E1 VA: 0x1E915E0
	private void set_DataTables(Dictionary<HairType, Dictionary<VariationNo, HumanData>> value) { }

	// RVA: 0x1E915F0 Offset: 0x1E916F1 VA: 0x1E915F0
	public void Setup() { }

	// RVA: 0x1E91900 Offset: 0x1E91A01 VA: 0x1E91900
	public void Clear() { }

	// RVA: 0x1E91970 Offset: 0x1E91A71 VA: 0x1E91970
	public void .ctor() { }
}

