public class NpcStatusDataTable : ScriptableObject // TypeDefIndex: 7023
{
	// Fields
	[SerializeField] // RVA: 0x162810 Offset: 0x162911 VA: 0x162810
	public List<NpcStatusData> NpcStatusDatas; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x162820 Offset: 0x162921 VA: 0x162820
	private Dictionary<ActorID, NpcStatusData> <DataTables>k__BackingField; // 0x20

	// Properties
	public Dictionary<ActorID, NpcStatusData> DataTables { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DD70 Offset: 0x19DE71 VA: 0x19DD70
	// RVA: 0x1D8C8E0 Offset: 0x1D8C9E1 VA: 0x1D8C8E0
	public Dictionary<ActorID, NpcStatusData> get_DataTables() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DD80 Offset: 0x19DE81 VA: 0x19DD80
	// RVA: 0x1D8C8F0 Offset: 0x1D8C9F1 VA: 0x1D8C8F0
	private void set_DataTables(Dictionary<ActorID, NpcStatusData> value) { }

	// RVA: 0x1D8C900 Offset: 0x1D8CA01 VA: 0x1D8C900
	public NpcStatusData Get(ActorID actorID) { }

	// RVA: 0x1D8C9A0 Offset: 0x1D8CAA1 VA: 0x1D8C9A0
	public void Setup() { }

	// RVA: 0x1D8CB90 Offset: 0x1D8CC91 VA: 0x1D8CB90
	public void Clear() { }

	// RVA: 0x1D8CC00 Offset: 0x1D8CD01 VA: 0x1D8CC00
	public void .ctor() { }
}

