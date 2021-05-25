public class ActorDataTable : ScriptableObject // TypeDefIndex: 6905
{
	// Fields
	[SerializeField] // RVA: 0x15FFC0 Offset: 0x1600C1 VA: 0x15FFC0
	public List<ActorData> ActorDatas; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15FFD0 Offset: 0x1600D1 VA: 0x15FFD0
	private Dictionary<ActorID, ActorData> <DataTables>k__BackingField; // 0x20

	// Properties
	public Dictionary<ActorID, ActorData> DataTables { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DCB0 Offset: 0x19DDB1 VA: 0x19DCB0
	// RVA: 0x1BE9580 Offset: 0x1BE9681 VA: 0x1BE9580
	public Dictionary<ActorID, ActorData> get_DataTables() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DCC0 Offset: 0x19DDC1 VA: 0x19DCC0
	// RVA: 0x1BE9590 Offset: 0x1BE9691 VA: 0x1BE9590
	private void set_DataTables(Dictionary<ActorID, ActorData> value) { }

	// RVA: 0x1BE95A0 Offset: 0x1BE96A1 VA: 0x1BE95A0
	public void Setup() { }

	// RVA: 0x1BE9760 Offset: 0x1BE9861 VA: 0x1BE9760
	public void Clear() { }

	// RVA: 0x1BE97D0 Offset: 0x1BE98D1 VA: 0x1BE97D0
	public void .ctor() { }
}

