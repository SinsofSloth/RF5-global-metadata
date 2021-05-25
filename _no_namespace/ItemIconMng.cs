public class ItemIconMng : SingletonMonoBehaviour<ItemIconMng> // TypeDefIndex: 6830
{
	// Fields
	public Sprite LoadingSprite; // 0x18
	private const int workBuf = 19;
	private SpriteAtlas[] WorkSpriteAtlas; // 0x20
	private bool[] loadStarted; // 0x28
	[SerializeField] // RVA: 0x15FCB0 Offset: 0x15FDB1 VA: 0x15FCB0
	public Sprite[] AmountNumberSprite; // 0x30
	private List<ItemIconMng.SpriteWork> ItemIconSprites; // 0x38
	private List<ItemIconMng.ImageLoaderObj> ImageLoaderObjs; // 0x40

	// Methods

	// RVA: 0x1F46080 Offset: 0x1F46181 VA: 0x1F46080
	private void SetImageSprite(Image image, Sprite sprite) { }

	// RVA: 0x1F45980 Offset: 0x1F45A81 VA: 0x1F45980
	public void SetLoadIcon(Image Image, ItemID itemID) { }

	// RVA: 0x1F45B00 Offset: 0x1F45C01 VA: 0x1F45B00
	public void SetLoadIcon(Image Image, string iconName, ItemID itemID = 0) { }

	// RVA: 0x1F46370 Offset: 0x1F46471 VA: 0x1F46370
	public void RemoveAllResources() { }

	// RVA: 0x1F46480 Offset: 0x1F46581 VA: 0x1F46480
	private void AttachSprite(ItemIconMng.ImageLoaderObj imageLoaderObj, SpriteAtlas spriteAtlas) { }

	// RVA: 0x1F466A0 Offset: 0x1F467A1 VA: 0x1F466A0
	private void IconImageLoaded(AssetHandle<SpriteAtlas> handle) { }

	// RVA: 0x1F46880 Offset: 0x1F46981 VA: 0x1F46880
	private void IconImageLoadedSetIcon(SpriteAtlas spriteAtlas, int atlasId) { }

	// RVA: 0x1F46980 Offset: 0x1F46A81 VA: 0x1F46980
	public void SetAmountSprite(int amount, Image amountImage) { }

	// RVA: 0x1F46A20 Offset: 0x1F46B21 VA: 0x1F46A20
	public void .ctor() { }
}

