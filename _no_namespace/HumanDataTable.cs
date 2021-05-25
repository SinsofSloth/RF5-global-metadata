[Serializable]
public class HumanDataTable : ScriptableObject // TypeDefIndex: 6975
{
	// Fields
	[SerializeField] // RVA: 0x162290 Offset: 0x162391 VA: 0x162290
	public List<HumanDataArray> HumanDatas; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1622A0 Offset: 0x1623A1 VA: 0x1622A0
	private Dictionary<CharID, HumanDataArray> <DataTables>k__BackingField; // 0x20

	// Properties
	public Dictionary<CharID, HumanDataArray> DataTables { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DD50 Offset: 0x19DE51 VA: 0x19DD50
	// RVA: 0x1E919E0 Offset: 0x1E91AE1 VA: 0x1E919E0
	public Dictionary<CharID, HumanDataArray> get_DataTables() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DD60 Offset: 0x19DE61 VA: 0x19DD60
	// RVA: 0x1E919F0 Offset: 0x1E91AF1 VA: 0x1E919F0
	private void set_DataTables(Dictionary<CharID, HumanDataArray> value) { }

	// RVA: 0x1E91A00 Offset: 0x1E91B01 VA: 0x1E91A00
	public void Setup() { }

	// RVA: 0x1E91BD0 Offset: 0x1E91CD1 VA: 0x1E91BD0
	public void Clear() { }

	// RVA: 0x1E91C30 Offset: 0x1E91D31 VA: 0x1E91C30
	public HumanData GetHumanData(CharID char_id, VariationNo variation_no, HairType hair_type) { }

	// RVA: 0x1E91D50 Offset: 0x1E91E51 VA: 0x1E91D50
	public Character GetBaseLoaderId(ActorType actor_type, CharID char_id) { }

	// RVA: 0x1E91E20 Offset: 0x1E91F21 VA: 0x1E91E20
	public Character GetCharacterLoaderId(CharID char_id, VariationNo variation_no, HairType hair_type) { }

	// RVA: 0x1E91E40 Offset: 0x1E91F41 VA: 0x1E91E40
	public void .ctor() { }
}

