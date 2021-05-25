public class SnowballDataTable : ScriptableObject // TypeDefIndex: 7412
{
	// Fields
	[SerializeField] // RVA: 0x166480 Offset: 0x166581 VA: 0x166480
	public List<SnowballData> SnowballDataList; // 0x18
	[SerializeField] // RVA: 0x166490 Offset: 0x166591 VA: 0x166490
	public List<MocomocoData> MocomocoDataList; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x1664A0 Offset: 0x1665A1 VA: 0x1664A0
	private Dictionary<SnowmanObjectID, SnowballData> <SnowBallData>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1664B0 Offset: 0x1665B1 VA: 0x1664B0
	private Dictionary<SnowmanObjectID, MocomocoData> <MocomocoData>k__BackingField; // 0x30

	// Properties
	public Dictionary<SnowmanObjectID, SnowballData> SnowBallData { get; set; }
	public Dictionary<SnowmanObjectID, MocomocoData> MocomocoData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A0B90 Offset: 0x1A0C91 VA: 0x1A0B90
	// RVA: 0x210D150 Offset: 0x210D251 VA: 0x210D150
	public Dictionary<SnowmanObjectID, SnowballData> get_SnowBallData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0BA0 Offset: 0x1A0CA1 VA: 0x1A0BA0
	// RVA: 0x210D160 Offset: 0x210D261 VA: 0x210D160
	private void set_SnowBallData(Dictionary<SnowmanObjectID, SnowballData> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0BB0 Offset: 0x1A0CB1 VA: 0x1A0BB0
	// RVA: 0x210D170 Offset: 0x210D271 VA: 0x210D170
	public Dictionary<SnowmanObjectID, MocomocoData> get_MocomocoData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0BC0 Offset: 0x1A0CC1 VA: 0x1A0BC0
	// RVA: 0x210D180 Offset: 0x210D281 VA: 0x210D180
	private void set_MocomocoData(Dictionary<SnowmanObjectID, MocomocoData> value) { }

	// RVA: 0x210D190 Offset: 0x210D291 VA: 0x210D190
	public void Setup() { }

	// RVA: 0x210D380 Offset: 0x210D481 VA: 0x210D380
	public void Clear() { }

	// RVA: 0x210D3F0 Offset: 0x210D4F1 VA: 0x210D3F0
	public void .ctor() { }
}

