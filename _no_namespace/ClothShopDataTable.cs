[Serializable]
public class ClothShopDataTable // TypeDefIndex: 6931
{
	// Fields
	[SerializeField] // RVA: 0x161760 Offset: 0x161861 VA: 0x161760
	public int Price; // 0x10
	[SerializeField] // RVA: 0x161770 Offset: 0x161871 VA: 0x161770
	public VariationNo Variation; // 0x14
	[SerializeField] // RVA: 0x161780 Offset: 0x161881 VA: 0x161780
	public BuilderId Release_BuilderID; // 0x18
	private static ClothShopDataTableArray _ClothShopDataTableArray; // 0x0

	// Methods

	// RVA: 0x1E62240 Offset: 0x1E62341 VA: 0x1E62240
	public static ClothShopDataTable GetDataTable(ClothShopID clothShopID) { }

	// RVA: 0x1E62380 Offset: 0x1E62481 VA: 0x1E62380
	public static IEnumerable<SerializeClothShopDataTable> GetDataTables() { }

	// RVA: 0x1E624A0 Offset: 0x1E625A1 VA: 0x1E624A0
	public void .ctor() { }
}

