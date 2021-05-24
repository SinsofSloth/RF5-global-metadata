public class ShippingManager : SingletonMonoBehaviour<ShippingManager> // TypeDefIndex: 9797
{
	// Fields
	private const int ShippingTime = 8;
	private const long ShipMoneyMax = 9999999999;
	private const int ShipItemPiecesMax = 99999999;
	private List<int> ShippingCategoryItemMax; // 0x18
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_COPPER = 20;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MAX_AMOUNT_COPPER = 49;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_SILVER = 50;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MAX_AMOUNT_SILVER = 99;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_GOLD = 100;
	private readonly string[] ShippingCategoryStrTable; // 0x20

	// Properties
	public RF5ShippingData ShippingSaveDatas { get; }

	// Methods

	// RVA: 0x1DF35A0 Offset: 0x1DF36A1 VA: 0x1DF35A0
	public RF5ShippingData get_ShippingSaveDatas() { }

	// RVA: 0x1DF3640 Offset: 0x1DF3741 VA: 0x1DF3640
	public long GetTotalIncome() { }

	// RVA: 0x1DF3660 Offset: 0x1DF3761 VA: 0x1DF3660
	public int CalTotalPriceInBox() { }

	// RVA: 0x1DF37C0 Offset: 0x1DF38C1 VA: 0x1DF37C0
	public void SetFishingCrown(ItemID itemid, CROWNTYPE crownType) { }

	// RVA: 0x1DF3940 Offset: 0x1DF3A41 VA: 0x1DF3940
	private void DoShipping() { }

	// RVA: 0x1DF49E0 Offset: 0x1DF4AE1 VA: 0x1DF49E0
	private void CheckShipping() { }

	// RVA: 0x1DF4B30 Offset: 0x1DF4C31 VA: 0x1DF4B30
	private void Update() { }

	// RVA: 0x1DF4BC0 Offset: 0x1DF4CC1 VA: 0x1DF4BC0
	private void InitShippingCategoryItemMax() { }

	// RVA: 0x1DF4D70 Offset: 0x1DF4E71 VA: 0x1DF4D70
	public int GetShippingCategoryItemMax(ShippingCategory shippingCategory) { }

	// RVA: 0x1DF4D40 Offset: 0x1DF4E41 VA: 0x1DF4D40
	private ShippingCategory GetShippingCategory(ItemCategory itemCategory) { }

	// RVA: 0x1DF3F40 Offset: 0x1DF4041 VA: 0x1DF3F40
	private int AddItemRecord(ItemData itemData) { }

	// RVA: 0x1DF4E10 Offset: 0x1DF4F11 VA: 0x1DF4E10
	public CROWNTYPE rf3ShipmentRecord_GetCrownTypeFromAmount(ItemID item_id, long amount) { }

	// RVA: 0x1DF4EB0 Offset: 0x1DF4FB1 VA: 0x1DF4EB0
	public string GetShippingCategoryStr(ShippingCategory shippingCategory) { }

	// RVA: 0x1DF4FD0 Offset: 0x1DF50D1 VA: 0x1DF4FD0
	public bool CheckShipmentData(ItemID itemID) { }

	// RVA: 0x1DF5120 Offset: 0x1DF5221 VA: 0x1DF5120
	public int CalTotalCompletePercent() { }

	// RVA: 0x1DF45F0 Offset: 0x1DF46F1 VA: 0x1DF45F0
	private int DoCalTotalCompletePercent() { }

	// RVA: 0x1DF5170 Offset: 0x1DF5271 VA: 0x1DF5170
	public int GetSeedMaxLv(ItemID itemID) { }

	// RVA: 0x1DF52A0 Offset: 0x1DF53A1 VA: 0x1DF52A0
	public void .ctor() { }
}

public class ShippingManager : SingletonMonoBehaviour<ShippingManager> // TypeDefIndex: 9797
{
	// Fields
	private const int ShippingTime = 8;
	private const long ShipMoneyMax = 9999999999;
	private const int ShipItemPiecesMax = 99999999;
	private List<int> ShippingCategoryItemMax; // 0x18
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_COPPER = 20;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MAX_AMOUNT_COPPER = 49;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_SILVER = 50;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MAX_AMOUNT_SILVER = 99;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_GOLD = 100;
	private readonly string[] ShippingCategoryStrTable; // 0x20

	// Properties
	public RF5ShippingData ShippingSaveDatas { get; }

	// Methods

	// RVA: 0x1DF35A0 Offset: 0x1DF36A1 VA: 0x1DF35A0
	public RF5ShippingData get_ShippingSaveDatas() { }

	// RVA: 0x1DF3640 Offset: 0x1DF3741 VA: 0x1DF3640
	public long GetTotalIncome() { }

	// RVA: 0x1DF3660 Offset: 0x1DF3761 VA: 0x1DF3660
	public int CalTotalPriceInBox() { }

	// RVA: 0x1DF37C0 Offset: 0x1DF38C1 VA: 0x1DF37C0
	public void SetFishingCrown(ItemID itemid, CROWNTYPE crownType) { }

	// RVA: 0x1DF3940 Offset: 0x1DF3A41 VA: 0x1DF3940
	private void DoShipping() { }

	// RVA: 0x1DF49E0 Offset: 0x1DF4AE1 VA: 0x1DF49E0
	private void CheckShipping() { }

	// RVA: 0x1DF4B30 Offset: 0x1DF4C31 VA: 0x1DF4B30
	private void Update() { }

	// RVA: 0x1DF4BC0 Offset: 0x1DF4CC1 VA: 0x1DF4BC0
	private void InitShippingCategoryItemMax() { }

	// RVA: 0x1DF4D70 Offset: 0x1DF4E71 VA: 0x1DF4D70
	public int GetShippingCategoryItemMax(ShippingCategory shippingCategory) { }

	// RVA: 0x1DF4D40 Offset: 0x1DF4E41 VA: 0x1DF4D40
	private ShippingCategory GetShippingCategory(ItemCategory itemCategory) { }

	// RVA: 0x1DF3F40 Offset: 0x1DF4041 VA: 0x1DF3F40
	private int AddItemRecord(ItemData itemData) { }

	// RVA: 0x1DF4E10 Offset: 0x1DF4F11 VA: 0x1DF4E10
	public CROWNTYPE rf3ShipmentRecord_GetCrownTypeFromAmount(ItemID item_id, long amount) { }

	// RVA: 0x1DF4EB0 Offset: 0x1DF4FB1 VA: 0x1DF4EB0
	public string GetShippingCategoryStr(ShippingCategory shippingCategory) { }

	// RVA: 0x1DF4FD0 Offset: 0x1DF50D1 VA: 0x1DF4FD0
	public bool CheckShipmentData(ItemID itemID) { }

	// RVA: 0x1DF5120 Offset: 0x1DF5221 VA: 0x1DF5120
	public int CalTotalCompletePercent() { }

	// RVA: 0x1DF45F0 Offset: 0x1DF46F1 VA: 0x1DF45F0
	private int DoCalTotalCompletePercent() { }

	// RVA: 0x1DF5170 Offset: 0x1DF5271 VA: 0x1DF5170
	public int GetSeedMaxLv(ItemID itemID) { }

	// RVA: 0x1DF52A0 Offset: 0x1DF53A1 VA: 0x1DF52A0
	public void .ctor() { }
}

public class ShippingManager : SingletonMonoBehaviour<ShippingManager> // TypeDefIndex: 9797
{
	// Fields
	private const int ShippingTime = 8;
	private const long ShipMoneyMax = 9999999999;
	private const int ShipItemPiecesMax = 99999999;
	private List<int> ShippingCategoryItemMax; // 0x18
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_COPPER = 20;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MAX_AMOUNT_COPPER = 49;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_SILVER = 50;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MAX_AMOUNT_SILVER = 99;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_GOLD = 100;
	private readonly string[] ShippingCategoryStrTable; // 0x20

	// Properties
	public RF5ShippingData ShippingSaveDatas { get; }

	// Methods

	// RVA: 0x1DF35A0 Offset: 0x1DF36A1 VA: 0x1DF35A0
	public RF5ShippingData get_ShippingSaveDatas() { }

	// RVA: 0x1DF3640 Offset: 0x1DF3741 VA: 0x1DF3640
	public long GetTotalIncome() { }

	// RVA: 0x1DF3660 Offset: 0x1DF3761 VA: 0x1DF3660
	public int CalTotalPriceInBox() { }

	// RVA: 0x1DF37C0 Offset: 0x1DF38C1 VA: 0x1DF37C0
	public void SetFishingCrown(ItemID itemid, CROWNTYPE crownType) { }

	// RVA: 0x1DF3940 Offset: 0x1DF3A41 VA: 0x1DF3940
	private void DoShipping() { }

	// RVA: 0x1DF49E0 Offset: 0x1DF4AE1 VA: 0x1DF49E0
	private void CheckShipping() { }

	// RVA: 0x1DF4B30 Offset: 0x1DF4C31 VA: 0x1DF4B30
	private void Update() { }

	// RVA: 0x1DF4BC0 Offset: 0x1DF4CC1 VA: 0x1DF4BC0
	private void InitShippingCategoryItemMax() { }

	// RVA: 0x1DF4D70 Offset: 0x1DF4E71 VA: 0x1DF4D70
	public int GetShippingCategoryItemMax(ShippingCategory shippingCategory) { }

	// RVA: 0x1DF4D40 Offset: 0x1DF4E41 VA: 0x1DF4D40
	private ShippingCategory GetShippingCategory(ItemCategory itemCategory) { }

	// RVA: 0x1DF3F40 Offset: 0x1DF4041 VA: 0x1DF3F40
	private int AddItemRecord(ItemData itemData) { }

	// RVA: 0x1DF4E10 Offset: 0x1DF4F11 VA: 0x1DF4E10
	public CROWNTYPE rf3ShipmentRecord_GetCrownTypeFromAmount(ItemID item_id, long amount) { }

	// RVA: 0x1DF4EB0 Offset: 0x1DF4FB1 VA: 0x1DF4EB0
	public string GetShippingCategoryStr(ShippingCategory shippingCategory) { }

	// RVA: 0x1DF4FD0 Offset: 0x1DF50D1 VA: 0x1DF4FD0
	public bool CheckShipmentData(ItemID itemID) { }

	// RVA: 0x1DF5120 Offset: 0x1DF5221 VA: 0x1DF5120
	public int CalTotalCompletePercent() { }

	// RVA: 0x1DF45F0 Offset: 0x1DF46F1 VA: 0x1DF45F0
	private int DoCalTotalCompletePercent() { }

	// RVA: 0x1DF5170 Offset: 0x1DF5271 VA: 0x1DF5170
	public int GetSeedMaxLv(ItemID itemID) { }

	// RVA: 0x1DF52A0 Offset: 0x1DF53A1 VA: 0x1DF52A0
	public void .ctor() { }
}

public class ShippingManager : SingletonMonoBehaviour<ShippingManager> // TypeDefIndex: 9797
{
	// Fields
	private const int ShippingTime = 8;
	private const long ShipMoneyMax = 9999999999;
	private const int ShipItemPiecesMax = 99999999;
	private List<int> ShippingCategoryItemMax; // 0x18
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_COPPER = 20;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MAX_AMOUNT_COPPER = 49;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_SILVER = 50;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MAX_AMOUNT_SILVER = 99;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_GOLD = 100;
	private readonly string[] ShippingCategoryStrTable; // 0x20

	// Properties
	public RF5ShippingData ShippingSaveDatas { get; }

	// Methods

	// RVA: 0x1DF35A0 Offset: 0x1DF36A1 VA: 0x1DF35A0
	public RF5ShippingData get_ShippingSaveDatas() { }

	// RVA: 0x1DF3640 Offset: 0x1DF3741 VA: 0x1DF3640
	public long GetTotalIncome() { }

	// RVA: 0x1DF3660 Offset: 0x1DF3761 VA: 0x1DF3660
	public int CalTotalPriceInBox() { }

	// RVA: 0x1DF37C0 Offset: 0x1DF38C1 VA: 0x1DF37C0
	public void SetFishingCrown(ItemID itemid, CROWNTYPE crownType) { }

	// RVA: 0x1DF3940 Offset: 0x1DF3A41 VA: 0x1DF3940
	private void DoShipping() { }

	// RVA: 0x1DF49E0 Offset: 0x1DF4AE1 VA: 0x1DF49E0
	private void CheckShipping() { }

	// RVA: 0x1DF4B30 Offset: 0x1DF4C31 VA: 0x1DF4B30
	private void Update() { }

	// RVA: 0x1DF4BC0 Offset: 0x1DF4CC1 VA: 0x1DF4BC0
	private void InitShippingCategoryItemMax() { }

	// RVA: 0x1DF4D70 Offset: 0x1DF4E71 VA: 0x1DF4D70
	public int GetShippingCategoryItemMax(ShippingCategory shippingCategory) { }

	// RVA: 0x1DF4D40 Offset: 0x1DF4E41 VA: 0x1DF4D40
	private ShippingCategory GetShippingCategory(ItemCategory itemCategory) { }

	// RVA: 0x1DF3F40 Offset: 0x1DF4041 VA: 0x1DF3F40
	private int AddItemRecord(ItemData itemData) { }

	// RVA: 0x1DF4E10 Offset: 0x1DF4F11 VA: 0x1DF4E10
	public CROWNTYPE rf3ShipmentRecord_GetCrownTypeFromAmount(ItemID item_id, long amount) { }

	// RVA: 0x1DF4EB0 Offset: 0x1DF4FB1 VA: 0x1DF4EB0
	public string GetShippingCategoryStr(ShippingCategory shippingCategory) { }

	// RVA: 0x1DF4FD0 Offset: 0x1DF50D1 VA: 0x1DF4FD0
	public bool CheckShipmentData(ItemID itemID) { }

	// RVA: 0x1DF5120 Offset: 0x1DF5221 VA: 0x1DF5120
	public int CalTotalCompletePercent() { }

	// RVA: 0x1DF45F0 Offset: 0x1DF46F1 VA: 0x1DF45F0
	private int DoCalTotalCompletePercent() { }

	// RVA: 0x1DF5170 Offset: 0x1DF5271 VA: 0x1DF5170
	public int GetSeedMaxLv(ItemID itemID) { }

	// RVA: 0x1DF52A0 Offset: 0x1DF53A1 VA: 0x1DF52A0
	public void .ctor() { }
}

public class ShippingManager : SingletonMonoBehaviour<ShippingManager> // TypeDefIndex: 9797
{
	// Fields
	private const int ShippingTime = 8;
	private const long ShipMoneyMax = 9999999999;
	private const int ShipItemPiecesMax = 99999999;
	private List<int> ShippingCategoryItemMax; // 0x18
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_COPPER = 20;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MAX_AMOUNT_COPPER = 49;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_SILVER = 50;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MAX_AMOUNT_SILVER = 99;
	private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_GOLD = 100;
	private readonly string[] ShippingCategoryStrTable; // 0x20

	// Properties
	public RF5ShippingData ShippingSaveDatas { get; }

	// Methods

	// RVA: 0x1DF35A0 Offset: 0x1DF36A1 VA: 0x1DF35A0
	public RF5ShippingData get_ShippingSaveDatas() { }

	// RVA: 0x1DF3640 Offset: 0x1DF3741 VA: 0x1DF3640
	public long GetTotalIncome() { }

	// RVA: 0x1DF3660 Offset: 0x1DF3761 VA: 0x1DF3660
	public int CalTotalPriceInBox() { }

	// RVA: 0x1DF37C0 Offset: 0x1DF38C1 VA: 0x1DF37C0
	public void SetFishingCrown(ItemID itemid, CROWNTYPE crownType) { }

	// RVA: 0x1DF3940 Offset: 0x1DF3A41 VA: 0x1DF3940
	private void DoShipping() { }

	// RVA: 0x1DF49E0 Offset: 0x1DF4AE1 VA: 0x1DF49E0
	private void CheckShipping() { }

	// RVA: 0x1DF4B30 Offset: 0x1DF4C31 VA: 0x1DF4B30
	private void Update() { }

	// RVA: 0x1DF4BC0 Offset: 0x1DF4CC1 VA: 0x1DF4BC0
	private void InitShippingCategoryItemMax() { }

	// RVA: 0x1DF4D70 Offset: 0x1DF4E71 VA: 0x1DF4D70
	public int GetShippingCategoryItemMax(ShippingCategory shippingCategory) { }

	// RVA: 0x1DF4D40 Offset: 0x1DF4E41 VA: 0x1DF4D40
	private ShippingCategory GetShippingCategory(ItemCategory itemCategory) { }

	// RVA: 0x1DF3F40 Offset: 0x1DF4041 VA: 0x1DF3F40
	private int AddItemRecord(ItemData itemData) { }

	// RVA: 0x1DF4E10 Offset: 0x1DF4F11 VA: 0x1DF4E10
	public CROWNTYPE rf3ShipmentRecord_GetCrownTypeFromAmount(ItemID item_id, long amount) { }

	// RVA: 0x1DF4EB0 Offset: 0x1DF4FB1 VA: 0x1DF4EB0
	public string GetShippingCategoryStr(ShippingCategory shippingCategory) { }

	// RVA: 0x1DF4FD0 Offset: 0x1DF50D1 VA: 0x1DF4FD0
	public bool CheckShipmentData(ItemID itemID) { }

	// RVA: 0x1DF5120 Offset: 0x1DF5221 VA: 0x1DF5120
	public int CalTotalCompletePercent() { }

	// RVA: 0x1DF45F0 Offset: 0x1DF46F1 VA: 0x1DF45F0
	private int DoCalTotalCompletePercent() { }

	// RVA: 0x1DF5170 Offset: 0x1DF5271 VA: 0x1DF5170
	public int GetSeedMaxLv(ItemID itemID) { }

	// RVA: 0x1DF52A0 Offset: 0x1DF53A1 VA: 0x1DF52A0
	public void .ctor() { }
}

