[Serializable]
public class RecipePanShopDataTable // TypeDefIndex: 7036
{
	// Fields
	[SerializeField] // RVA: 0x162950 Offset: 0x162A51 VA: 0x162950
	public ItemID ItemID; // 0x10
	[SerializeField] // RVA: 0x162960 Offset: 0x162A61 VA: 0x162960
	public PanShopType PanShopType; // 0x14
	[SerializeField] // RVA: 0x162970 Offset: 0x162A71 VA: 0x162970
	public BuilderId Release_BuilderID; // 0x18
	[SerializeField] // RVA: 0x162980 Offset: 0x162A81 VA: 0x162980
	public int Price; // 0x1C
	private static RecipePanShopDataTableArray _RecipePanShopDataTableArray; // 0x0

	// Methods

	// RVA: 0x1DB0790 Offset: 0x1DB0891 VA: 0x1DB0790
	public static RecipePanShopDataTable GetDataTable(RecipePanShopID id) { }

	// RVA: 0x1DB08D0 Offset: 0x1DB09D1 VA: 0x1DB08D0
	public static IEnumerable<SerializeRecipePanShopDataTable> GetDataTables_Restaurant() { }

	// RVA: 0x1DB0AB0 Offset: 0x1DB0BB1 VA: 0x1DB0AB0
	public static IEnumerable<SerializeRecipePanShopDataTable> GetDataTables_Bakery() { }

	// RVA: 0x1DB0C90 Offset: 0x1DB0D91 VA: 0x1DB0C90
	public void .ctor() { }
}

