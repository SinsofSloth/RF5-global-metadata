[Serializable]
public class ItemDataTable // TypeDefIndex: 6980
{
	// Fields
	[SerializeField] // RVA: 0x162330 Offset: 0x162431 VA: 0x162330
	public string OnGroundItemPrefabPath; // 0x10
	[SerializeField] // RVA: 0x162340 Offset: 0x162441 VA: 0x162340
	public Prefab PrefabID; // 0x18
	[SerializeField] // RVA: 0x162350 Offset: 0x162451 VA: 0x162350
	public int ItemIndex; // 0x1C
	[SerializeField] // RVA: 0x162360 Offset: 0x162461 VA: 0x162360
	public int ShopPriceTableIndex; // 0x20
	[SerializeField] // RVA: 0x162370 Offset: 0x162471 VA: 0x162370
	public int SellPriceTableIndex; // 0x24
	[SerializeField] // RVA: 0x162380 Offset: 0x162481 VA: 0x162380
	public ItemCategory ItemCategory; // 0x28
	[SerializeField] // RVA: 0x162390 Offset: 0x162491 VA: 0x162390
	public int ShopPrice; // 0x2C
	[SerializeField] // RVA: 0x1623A0 Offset: 0x1624A1 VA: 0x1623A0
	public int SellPrice; // 0x30
	[SerializeField] // RVA: 0x1623B0 Offset: 0x1624B1 VA: 0x1623B0
	public int UpgradeLevel; // 0x34
	[SerializeField] // RVA: 0x1623C0 Offset: 0x1624C1 VA: 0x1623C0
	public string ModelName; // 0x38
	[SerializeField] // RVA: 0x1623D0 Offset: 0x1624D1 VA: 0x1623D0
	public string IconName; // 0x40
	[SerializeField] // RVA: 0x1623E0 Offset: 0x1624E1 VA: 0x1623E0
	public ItemSize ItemSize; // 0x48
	[SerializeField] // RVA: 0x1623F0 Offset: 0x1624F1 VA: 0x1623F0
	public int StackSize; // 0x4C
	[SerializeField] // RVA: 0x162400 Offset: 0x162501 VA: 0x162400
	public CropID CropID; // 0x50
	[SerializeField] // RVA: 0x162410 Offset: 0x162511 VA: 0x162410
	public HoldMotionType HoldMotionType; // 0x54
	[SerializeField] // RVA: 0x162420 Offset: 0x162521 VA: 0x162420
	public DropCapID DropCap; // 0x58
	[SerializeField] // RVA: 0x162430 Offset: 0x162531 VA: 0x162430
	public bool IsAutoPickup; // 0x5C
	private static Sprite NotDefineSpriteAsset; // 0x0
	private static ItemDataTableArray _ItemDataTableArray; // 0x8

	// Properties
	public ItemType ItemType { get; }
	public string ScreenName { get; }
	public string Describe { get; }
	public Sprite Image_Debug { get; }

	// Methods

	// RVA: 0x20D1840 Offset: 0x20D1941 VA: 0x20D1840
	public ItemType get_ItemType() { }

	// RVA: 0x20D1870 Offset: 0x20D1971 VA: 0x20D1870
	public string get_ScreenName() { }

	// RVA: 0x20D1A00 Offset: 0x20D1B01 VA: 0x20D1A00
	public string get_Describe() { }

	// RVA: 0x20D1B90 Offset: 0x20D1C91 VA: 0x20D1B90
	public Sprite get_Image_Debug() { }

	// RVA: 0x20D0AC0 Offset: 0x20D0BC1 VA: 0x20D0AC0
	public static ItemDataTable GetDataTable(ItemID itemID) { }

	// RVA: 0x20D1CB0 Offset: 0x20D1DB1 VA: 0x20D1CB0
	public static SerializedItemDataTable[] GetDataTables() { }

	// RVA: 0x20D1DD0 Offset: 0x20D1ED1 VA: 0x20D1DD0
	public static int Length() { }

	// RVA: 0x20D1F00 Offset: 0x20D2001 VA: 0x20D1F00
	public static ItemID GetItemID(int itemDataTableIndex) { }

	// RVA: 0x20D2080 Offset: 0x20D2181 VA: 0x20D2080
	public static IEnumerable<ItemID> GetCategoryToItems(ItemCategory itemCategory) { }

	// RVA: 0x20D1400 Offset: 0x20D1501 VA: 0x20D1400
	public static int CalcPrice(int basePrice, int tableIndex, int itemLv) { }

	// RVA: 0x20D21D0 Offset: 0x20D22D1 VA: 0x20D21D0
	public int GetShopPrice(int itemLv) { }

	// RVA: 0x20D21F0 Offset: 0x20D22F1 VA: 0x20D21F0
	public void .ctor() { }
}

