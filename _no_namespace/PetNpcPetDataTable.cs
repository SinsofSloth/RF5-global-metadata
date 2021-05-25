public class PetNpcPetDataTable : ScriptableObject // TypeDefIndex: 7404
{
	// Fields
	[SerializeField] // RVA: 0x166310 Offset: 0x166411 VA: 0x166310
	public List<PetNpcPetData> DataList; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x166320 Offset: 0x166421 VA: 0x166320
	private Dictionary<ActorID, List<MonsterDataID>> <DataTable>k__BackingField; // 0x20

	// Properties
	public Dictionary<ActorID, List<MonsterDataID>> DataTable { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A09F0 Offset: 0x1A0AF1 VA: 0x1A09F0
	// RVA: 0x1FE6A30 Offset: 0x1FE6B31 VA: 0x1FE6A30
	public Dictionary<ActorID, List<MonsterDataID>> get_DataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0A00 Offset: 0x1A0B01 VA: 0x1A0A00
	// RVA: 0x1FE6A40 Offset: 0x1FE6B41 VA: 0x1FE6A40
	private void set_DataTable(Dictionary<ActorID, List<MonsterDataID>> value) { }

	// RVA: 0x1FE3430 Offset: 0x1FE3531 VA: 0x1FE3430
	public void Setup(Gender _baby_gender) { }

	// RVA: 0x1FE6A50 Offset: 0x1FE6B51 VA: 0x1FE6A50
	public void Clear() { }

	// RVA: 0x1FE6AC0 Offset: 0x1FE6BC1 VA: 0x1FE6AC0
	public void RemoveKey(ActorID _actor) { }

	// RVA: 0x1FE6B60 Offset: 0x1FE6C61 VA: 0x1FE6B60
	public void .ctor() { }
}

