[Serializable]
public class CraftGenreDataTableArray : ScriptableObject // TypeDefIndex: 6939
{
	// Fields
	[SerializeField] // RVA: 0x1619D0 Offset: 0x161AD1 VA: 0x1619D0
	public CraftGenreDataTable[] DataTables; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1619E0 Offset: 0x161AE1 VA: 0x1619E0
	private Dictionary<int, ItemID[]> <m_GenreToItemsDic>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x1619F0 Offset: 0x161AF1 VA: 0x1619F0
	private Dictionary<ItemID, ItemID> <m_ItemIdToGenre>k__BackingField; // 0x28

	// Properties
	public Dictionary<int, ItemID[]> m_GenreToItemsDic { get; set; }
	public Dictionary<ItemID, ItemID> m_ItemIdToGenre { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DCD0 Offset: 0x19DDD1 VA: 0x19DCD0
	// RVA: 0x1FCC0A0 Offset: 0x1FCC1A1 VA: 0x1FCC0A0
	public Dictionary<int, ItemID[]> get_m_GenreToItemsDic() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DCE0 Offset: 0x19DDE1 VA: 0x19DCE0
	// RVA: 0x1FCC0B0 Offset: 0x1FCC1B1 VA: 0x1FCC0B0
	private void set_m_GenreToItemsDic(Dictionary<int, ItemID[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DCF0 Offset: 0x19DDF1 VA: 0x19DCF0
	// RVA: 0x1FCC0C0 Offset: 0x1FCC1C1 VA: 0x1FCC0C0
	public Dictionary<ItemID, ItemID> get_m_ItemIdToGenre() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DD00 Offset: 0x19DE01 VA: 0x19DD00
	// RVA: 0x1FCC0D0 Offset: 0x1FCC1D1 VA: 0x1FCC0D0
	private void set_m_ItemIdToGenre(Dictionary<ItemID, ItemID> value) { }

	// RVA: 0x1FCBB70 Offset: 0x1FCBC71 VA: 0x1FCBB70
	public void Setup() { }

	// RVA: 0x1FCC0E0 Offset: 0x1FCC1E1 VA: 0x1FCC0E0
	public void .ctor() { }
}

