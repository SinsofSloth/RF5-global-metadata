[Serializable]
public class ShopItem // TypeDefIndex: 9775
{
	// Fields
	public ItemID ItemId; // 0x10
	public int itemLv; // 0x14
	public int id; // 0x18
	public int prices; // 0x1C
	public List<ulong> conditions; // 0x20
	public GameFlagData storyLineFrag; // 0x28
	public int shopLv; // 0x2C

	// Methods

	// RVA: 0x1DF6C80 Offset: 0x1DF6D81 VA: 0x1DF6C80
	public void .ctor() { }

	// RVA: 0x1DF6CB0 Offset: 0x1DF6DB1 VA: 0x1DF6CB0
	public int GetPrices() { }

	// RVA: 0x1DF6D10 Offset: 0x1DF6E11 VA: 0x1DF6D10
	private ItemID GetRandItemId(int id) { }

	// RVA: 0x1DF6FB0 Offset: 0x1DF70B1 VA: 0x1DF6FB0
	private void CheckDropCap() { }

	// RVA: 0x1DF7060 Offset: 0x1DF7161 VA: 0x1DF7060
	private void CheckShipment() { }

	// RVA: 0x1DF70D0 Offset: 0x1DF71D1 VA: 0x1DF70D0
	private void CheckGet() { }

	// RVA: 0x1DF7120 Offset: 0x1DF7221 VA: 0x1DF7120
	private UIShopRandomItemTable.RandomIdList GetRandomList(int id) { }

	// RVA: 0x1DF7260 Offset: 0x1DF7361 VA: 0x1DF7260
	public ItemID CheckRandItem(int RandCnt, List<int> randItems) { }

	// RVA: 0x1DF62A0 Offset: 0x1DF63A1 VA: 0x1DF62A0
	public void CheckCropSeed() { }

	// RVA: 0x1DF7620 Offset: 0x1DF7721 VA: 0x1DF7620
	public ItemData GetItemData() { }
}

