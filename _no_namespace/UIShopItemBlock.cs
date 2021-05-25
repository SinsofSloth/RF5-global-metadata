public class UIShopItemBlock : ButtonLinker // TypeDefIndex: 8840
{
	// Fields
	[SerializeField] // RVA: 0x174270 Offset: 0x174371 VA: 0x174270
	public UIShopController UIShopController; // 0x60
	[SerializeField] // RVA: 0x174280 Offset: 0x174381 VA: 0x174280
	public Image ItemBagImage; // 0x68
	[SerializeField] // RVA: 0x174290 Offset: 0x174391 VA: 0x174290
	public Image BuildImage; // 0x70
	[SerializeField] // RVA: 0x1742A0 Offset: 0x1743A1 VA: 0x1742A0
	public ItemIconLoader ItemImage; // 0x78
	[SerializeField] // RVA: 0x1742B0 Offset: 0x1743B1 VA: 0x1742B0
	private Text Gold; // 0x80
	[SerializeField] // RVA: 0x1742C0 Offset: 0x1743C1 VA: 0x1742C0
	private Text Point; // 0x88
	[SerializeField] // RVA: 0x1742D0 Offset: 0x1743D1 VA: 0x1742D0
	private Text Stone; // 0x90
	[SerializeField] // RVA: 0x1742E0 Offset: 0x1743E1 VA: 0x1742E0
	private Text Lumber; // 0x98
	public ItemID ItemID; // 0xA0
	public int buildId; // 0xA4
	public ShopItem shopItem; // 0xA8
	public BuildItemData buildData; // 0xB0
	[SerializeField] // RVA: 0x1742F0 Offset: 0x1743F1 VA: 0x1742F0
	private string NotEnoughColorHead; // 0x128

	// Methods

	// RVA: 0x1DE66C0 Offset: 0x1DE67C1 VA: 0x1DE66C0
	public bool CheckBuildDataCanBuy() { }

	// RVA: 0x1DE74D0 Offset: 0x1DE75D1 VA: 0x1DE74D0
	public void BuyBuildData(int _buildid) { }

	// RVA: 0x1DE6F90 Offset: 0x1DE7091 VA: 0x1DE6F90
	public void BuyBuildData() { }

	// RVA: 0x1DE6BF0 Offset: 0x1DE6CF1 VA: 0x1DE6BF0
	public void BuyFurnitureData() { }

	// RVA: 0x1DE30A0 Offset: 0x1DE31A1 VA: 0x1DE30A0
	public void SetItem(ShopItem _shopItem, int price) { }

	// RVA: 0x1DE2860 Offset: 0x1DE2961 VA: 0x1DE2860
	public void SetLoadBuildIcon(SpriteAtlas spriteAtlas) { }

	// RVA: 0x1DE7BD0 Offset: 0x1DE7CD1 VA: 0x1DE7BD0
	private void SetPriceBuild(BuildItemData buildData) { }

	// RVA: 0x1DE34C0 Offset: 0x1DE35C1 VA: 0x1DE34C0
	public void SetBuild(BuildItemData _buildData) { }

	// RVA: 0x1DE33E0 Offset: 0x1DE34E1 VA: 0x1DE33E0
	public void SetFurniture(BuildItemData _buildData) { }

	// RVA: 0x1DE3260 Offset: 0x1DE3361 VA: 0x1DE3260
	public void ClearItem() { }

	// RVA: 0x1DE8000 Offset: 0x1DE8101 VA: 0x1DE8000 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1DE8040 Offset: 0x1DE8141 VA: 0x1DE8040 Slot: 11
	public override void EndFocus() { }

	// RVA: 0x1DE8080 Offset: 0x1DE8181 VA: 0x1DE8080
	public void .ctor() { }
}

