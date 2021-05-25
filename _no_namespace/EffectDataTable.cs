[Serializable]
public struct EffectDataTable // TypeDefIndex: 7103
{
	// Fields
	[SerializeField] // RVA: 0x162E40 Offset: 0x162F41 VA: 0x162E40
	public Effect EffectAssetID; // 0x0
	[SerializeField] // RVA: 0x162E50 Offset: 0x162F51 VA: 0x162E50
	public bool Loop; // 0x4
	[SerializeField] // RVA: 0x162E60 Offset: 0x162F61 VA: 0x162E60
	public HumanJointIDEnum WorldAttach; // 0x8
	[SerializeField] // RVA: 0x162E70 Offset: 0x162F71 VA: 0x162E70
	public HumanJointIDEnum ChildAttach; // 0xC
	[SerializeField] // RVA: 0x162E80 Offset: 0x162F81 VA: 0x162E80
	public SoundID SE; // 0x10
	private static EffectDataTableArray _EffectDataTableArray; // 0x0

	// Methods

	// RVA: 0x2016960 Offset: 0x2016A61 VA: 0x2016960
	public static EffectDataTable GetDataTable(EffectID id) { }

	// RVA: 0x2016AE0 Offset: 0x2016BE1 VA: 0x2016AE0
	public static SerializeEffectDataTable[] GetDataTables() { }

	// RVA: 0x2016C00 Offset: 0x2016D01 VA: 0x2016C00
	public static bool HasDataTable(EffectID id) { }
}

