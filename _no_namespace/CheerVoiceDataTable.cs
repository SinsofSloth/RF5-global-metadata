public class CheerVoiceDataTable : ScriptableObject // TypeDefIndex: 7360
{
	// Fields
	public List<PlayerCheerVoiceData> PlayerCheerVoiceData; // 0x18
	public List<CheerVoiceData> CheerVoiceDatas; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x165ED0 Offset: 0x165FD1 VA: 0x165ED0
	private List<CheerVoiceData> <DataTable>k__BackingField; // 0x28

	// Properties
	public List<CheerVoiceData> DataTable { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A02E0 Offset: 0x1A03E1 VA: 0x1A02E0
	// RVA: 0x1E5EA20 Offset: 0x1E5EB21 VA: 0x1E5EA20
	public List<CheerVoiceData> get_DataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A02F0 Offset: 0x1A03F1 VA: 0x1A02F0
	// RVA: 0x1E5EA30 Offset: 0x1E5EB31 VA: 0x1E5EA30
	private void set_DataTable(List<CheerVoiceData> value) { }

	// RVA: 0x1E5EA40 Offset: 0x1E5EB41 VA: 0x1E5EA40
	public void Setup(List<ActorID> _festival_actor) { }

	// RVA: 0x1E5EE10 Offset: 0x1E5EF11 VA: 0x1E5EE10
	public void SetupPriscillaVoice(CheerVoiceDataTable.Flag _prs_flag) { }

	// RVA: 0x1E5EF60 Offset: 0x1E5F061 VA: 0x1E5EF60
	public void SetupChildVoice(CheerVoiceDataTable.Flag _baby_flag, CheerVoiceDataTable.Flag _child_boy_flag, CheerVoiceDataTable.Flag _child_girl_flag) { }

	// RVA: 0x1E5F230 Offset: 0x1E5F331 VA: 0x1E5F230
	public void RemoveKey(ActorID _actor_id) { }

	// RVA: 0x1E5F300 Offset: 0x1E5F401 VA: 0x1E5F300
	public void Clear() { }

	// RVA: 0x1E5F370 Offset: 0x1E5F471 VA: 0x1E5F370
	public void .ctor() { }
}

