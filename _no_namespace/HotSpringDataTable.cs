[Serializable]
public class HotSpringDataTable // TypeDefIndex: 6971
{
	// Fields
	[SerializeField] // RVA: 0x162170 Offset: 0x162271 VA: 0x162170
	public int Price; // 0x10
	[SerializeField] // RVA: 0x162180 Offset: 0x162281 VA: 0x162180
	public bool IsMedical; // 0x14
	[SerializeField] // RVA: 0x162190 Offset: 0x162291 VA: 0x162190
	public int Time; // 0x18
	[SerializeField] // RVA: 0x1621A0 Offset: 0x1622A1 VA: 0x1621A0
	public float Args1; // 0x1C
	[SerializeField] // RVA: 0x1621B0 Offset: 0x1622B1 VA: 0x1621B0
	public float Args2; // 0x20
	[SerializeField] // RVA: 0x1621C0 Offset: 0x1622C1 VA: 0x1621C0
	public string ScreenNameID; // 0x28
	[SerializeField] // RVA: 0x1621D0 Offset: 0x1622D1 VA: 0x1621D0
	public string DetailTextID; // 0x30
	[SerializeField] // RVA: 0x1621E0 Offset: 0x1622E1 VA: 0x1621E0
	public BuilderId Release_BuilderID; // 0x38
	private static HotSpringDataTableArray _HotSpringDataTableArray; // 0x0

	// Methods

	// RVA: 0x1E821F0 Offset: 0x1E822F1 VA: 0x1E821F0
	public static HotSpringDataTable GetDataTable(HotSpringID hotSpringID) { }

	// RVA: 0x1E82330 Offset: 0x1E82431 VA: 0x1E82330
	public static IEnumerable<SerializeHotSpringDataTable> GetDataTables() { }

	// RVA: 0x1E82450 Offset: 0x1E82551 VA: 0x1E82450
	public void .ctor() { }
}

