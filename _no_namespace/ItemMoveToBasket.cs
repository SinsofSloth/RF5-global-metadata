public class ItemMoveToBasket : MonoBehaviour // TypeDefIndex: 8829
{
	// Fields
	public UIShopController UIShopController; // 0x18
	public RectTransform BasketItem; // 0x20
	private Vector2 StartPos; // 0x28
	private Vector2 StartSize; // 0x30
	private Image Image; // 0x38
	private Image BaseItem; // 0x40
	public float MovTimeMax; // 0x48
	private float MovTime; // 0x4C
	public AnimationCurve AddXCurve; // 0x50
	public AnimationCurve AddYCurve; // 0x58
	public Vector2 AddRange; // 0x60
	public BasketAnim basketAnim; // 0x68
	public UIShopItemSplash UIShopItemSplash; // 0x70
	private bool EndsplashFlag; // 0x78

	// Methods

	// RVA: 0x1F49CD0 Offset: 0x1F49DD1 VA: 0x1F49CD0
	public ItemMoveToBasket CloneUse(Image _baseItem, bool EndSplash = False) { }

	// RVA: 0x1F49DB0 Offset: 0x1F49EB1 VA: 0x1F49DB0
	public void SetCloneInit(Image _baseItem, ItemMoveToBasket originalObject, bool EndSplash) { }

	// RVA: 0x1F49F60 Offset: 0x1F4A061 VA: 0x1F49F60
	private void Start() { }

	// RVA: 0x1F49FE0 Offset: 0x1F4A0E1 VA: 0x1F49FE0
	private void Update() { }

	// RVA: 0x1F4A2A0 Offset: 0x1F4A3A1 VA: 0x1F4A2A0
	private void SplashItem(Image baseItem) { }

	// RVA: 0x1F4A340 Offset: 0x1F4A441 VA: 0x1F4A340
	public void SplashItem() { }

	// RVA: 0x1F4A350 Offset: 0x1F4A451 VA: 0x1F4A350
	public void .ctor() { }
}

