public class UIShopControl : MonoBehaviour // TypeDefIndex: 8834
{
	// Fields
	[SerializeField] // RVA: 0x173FE0 Offset: 0x1740E1 VA: 0x173FE0
	private Text PlayerMoneyText; // 0x18
	[SerializeField] // RVA: 0x173FF0 Offset: 0x1740F1 VA: 0x173FF0
	private Text PlayerPointText; // 0x20
	[SerializeField] // RVA: 0x174000 Offset: 0x174101 VA: 0x174000
	private Text PlayerStoneText; // 0x28
	[SerializeField] // RVA: 0x174010 Offset: 0x174111 VA: 0x174010
	private Text PlayerLumberText; // 0x30
	private long NowDispPlayerMoney; // 0x38
	private long NowDispPlayerPoint; // 0x40
	private long NowDispPlayerStone; // 0x48
	private long NowDispPlayerLumber; // 0x50
	[SerializeField] // RVA: 0x174020 Offset: 0x174121 VA: 0x174020
	private Text BasketItemNameText; // 0x58
	[SerializeField] // RVA: 0x174030 Offset: 0x174131 VA: 0x174030
	private Text BaketItemPiecesText; // 0x60
	[SerializeField] // RVA: 0x174040 Offset: 0x174141 VA: 0x174040
	private Text BasketItemTotalPriceText; // 0x68
	[SerializeField] // RVA: 0x174050 Offset: 0x174151 VA: 0x174050
	public ItemIconLoader BasketItemIconImage; // 0x70
	[SerializeField] // RVA: 0x174060 Offset: 0x174161 VA: 0x174060
	private Text ItemInRuckText; // 0x78
	[SerializeField] // RVA: 0x174070 Offset: 0x174171 VA: 0x174070
	private Text PageNameText; // 0x80
	public float discountRate; // 0x88
	private ItemID focusingItemID; // 0x8C
	private ShopItem inBasketItem; // 0x90
	private int inBasketCount; // 0x98

	// Methods

	// RVA: 0x1DDE5D0 Offset: 0x1DDE6D1 VA: 0x1DDE5D0
	private void Start() { }

	// RVA: 0x1DDE900 Offset: 0x1DDEA01 VA: 0x1DDE900
	public int CalDiscountPrice(int basePrice) { }

	// RVA: 0x1DDE5E0 Offset: 0x1DDE6E1 VA: 0x1DDE5E0
	public void OpenShop() { }

	// RVA: 0x1DDE9D0 Offset: 0x1DDEAD1 VA: 0x1DDE9D0
	public void CloseShop() { }

	// RVA: 0x1DDEA00 Offset: 0x1DDEB01 VA: 0x1DDEA00
	public void SetPageNameText(string pageName) { }

	// RVA: 0x1DDEAC0 Offset: 0x1DDEBC1 VA: 0x1DDEAC0
	private void UpdateBasketItem() { }

	// RVA: 0x1DDF370 Offset: 0x1DDF471 VA: 0x1DDF370
	public void SetFocusItem(ItemID itemID) { }

	// RVA: 0x1DDE990 Offset: 0x1DDEA91 VA: 0x1DDE990
	public void SetBasketItem(ShopItem basketItem, int InCount) { }

	// RVA: 0x1DDF380 Offset: 0x1DDF481 VA: 0x1DDF380
	private void LateUpdate() { }

	// RVA: 0x1DDF7F0 Offset: 0x1DDF8F1 VA: 0x1DDF7F0
	public void .ctor() { }
}

