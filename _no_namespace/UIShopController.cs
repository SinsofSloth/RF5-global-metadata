public class UIShopController : MonoBehaviour // TypeDefIndex: 8835
{
	// Fields
	public static NpcShopType _shopType; // 0x0
	[SerializeField] // RVA: 0x174080 Offset: 0x174181 VA: 0x174080
	private UIItemDetailDisp UIItemDetailDisp; // 0x18
	[SerializeField] // RVA: 0x174090 Offset: 0x174191 VA: 0x174090
	private Text UIBuildNameText; // 0x20
	[SerializeField] // RVA: 0x1740A0 Offset: 0x1741A1 VA: 0x1740A0
	private Text UIBuildDetailText; // 0x28
	[SerializeField] // RVA: 0x1740B0 Offset: 0x1741B1 VA: 0x1740B0
	private Text CategoryPageText; // 0x30
	[SerializeField] // RVA: 0x1740C0 Offset: 0x1741C1 VA: 0x1740C0
	private GameObject ChangePagesGroup; // 0x38
	[SerializeField] // RVA: 0x1740D0 Offset: 0x1741D1 VA: 0x1740D0
	private Image DiscountImage; // 0x40
	[SerializeField] // RVA: 0x1740E0 Offset: 0x1741E1 VA: 0x1740E0
	private Sprite Discount10Sprite; // 0x48
	[SerializeField] // RVA: 0x1740F0 Offset: 0x1741F1 VA: 0x1740F0
	private Sprite Discount20Sprite; // 0x50
	[SerializeField] // RVA: 0x174100 Offset: 0x174201 VA: 0x174100
	private AdvCharaImageControl AdvCharaImageControl; // 0x58
	[SerializeField] // RVA: 0x174110 Offset: 0x174211 VA: 0x174110
	private NpcShopTable _NpcShopTable; // 0x60
	public List<BuildItemData> BuildItemList; // 0x68
	[SerializeField] // RVA: 0x174120 Offset: 0x174221 VA: 0x174120
	private UIShopItemBlock[] shopItemBlocks; // 0x70
	[SerializeField] // RVA: 0x174130 Offset: 0x174231 VA: 0x174130
	private UIShopControl UIShopControl; // 0x78
	[SerializeField] // RVA: 0x174140 Offset: 0x174241 VA: 0x174140
	private RectTransform NPCTalkBorder; // 0x80
	[SerializeField] // RVA: 0x174150 Offset: 0x174251 VA: 0x174150
	private Text NPCTalkText; // 0x88
	private ShopParameterCalc ShopParameterCalc; // 0x90
	private float NowMouthTime; // 0x98
	private float WaitTalkDelay; // 0x9C
	private int LastTalkType; // 0xA0
	private UIShopItemBlock focusingBlock; // 0xA8
	private UIShopItemBlock buildSelectingBlock; // 0xB0
	private ShopItem selectingShopItem; // 0xB8
	private int pageNum; // 0xC0
	private int pageMax; // 0xC4
	private int buyNum; // 0xC8
	private int totalPrice; // 0xCC
	private int myShopLv; // 0xD0
	private static NPCID _NPCID; // 0x4
	[SerializeField] // RVA: 0x174160 Offset: 0x174261 VA: 0x174160
	private Image BGR; // 0xD8
	[SerializeField] // RVA: 0x174170 Offset: 0x174271 VA: 0x174170
	private Sprite[] BGRSprites; // 0xE0
	[SerializeField] // RVA: 0x174180 Offset: 0x174281 VA: 0x174180
	private Sprite[] MokSprites; // 0xE8
	[SerializeField] // RVA: 0x174190 Offset: 0x174291 VA: 0x174190
	private Image[] MokImage; // 0xF0
	[SerializeField] // RVA: 0x1741A0 Offset: 0x1742A1 VA: 0x1741A0
	private ItemMoveToBasket ItemMoveToBasket; // 0xF8
	private List<ItemMoveToBasket> UsingItemMoveToBaskets; // 0x100
	[SerializeField] // RVA: 0x1741B0 Offset: 0x1742B1 VA: 0x1741B0
	private UIShopCoinGen UIShopCoinGen; // 0x108
	private UIShopCoinGen usingUIShopCoinGen; // 0x110
	private int addedInCartNum; // 0x118
	[SerializeField] // RVA: 0x1741C0 Offset: 0x1742C1 VA: 0x1741C0
	private UIShopItemSplash UIShopItemSplash; // 0x120
	private bool Purchased; // 0x128
	private float idelTime; // 0x12C
	private ShopMenuType ShopMenuType; // 0x130
	private bool EndShop; // 0x134
	private float DelayCloseShop; // 0x138
	[SerializeField] // RVA: 0x1741D0 Offset: 0x1742D1 VA: 0x1741D0
	private float CloseShopDelayTime; // 0x13C
	private bool buildSelecting; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x1741E0 Offset: 0x1742E1 VA: 0x1741E0
	private static ItemID <RestaurantBuyItemId>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x1741F0 Offset: 0x1742F1 VA: 0x1741F0
	private static bool <IsBuyFist>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x174200 Offset: 0x174301 VA: 0x174200
	private static bool <IsBuyRAorMagic>k__BackingField; // 0xD
	[CompilerGeneratedAttribute] // RVA: 0x174210 Offset: 0x174311 VA: 0x174210
	private static bool <IsBuyCrystal>k__BackingField; // 0xE
	private static UIShopController shopController; // 0x10
	private static SpriteAtlas BuildIconAtlas; // 0x18
	private static SpriteAtlas FurnitureIconAtlas; // 0x20
	[SerializeField] // RVA: 0x174220 Offset: 0x174321 VA: 0x174220
	private bool useEquipStatusMenu; // 0x141
	private bool isOpenedStatusWindow; // 0x142
	[SerializeField] // RVA: 0x174230 Offset: 0x174331 VA: 0x174230
	private EquipStatusMenu EquipStatusMenu; // 0x148
	[SerializeField] // RVA: 0x174240 Offset: 0x174341 VA: 0x174240
	private NonFocusButton ZR_Button; // 0x150
	[SerializeField] // RVA: 0x174250 Offset: 0x174351 VA: 0x174250
	private NonFocusButton L_Button; // 0x158
	[SerializeField] // RVA: 0x174260 Offset: 0x174361 VA: 0x174260
	private NonFocusButton R_Button; // 0x160
	private static int lastBounghtBuildId; // 0x28
	private const float SellDiscountRate = 0.9;
	private const float BigSellDiscountRate = 0.8;

	// Properties
	private NpcShopType shopType { get; set; }
	private NpcShopTable NpcShopTable { get; }
	public NPCID npcId { get; set; }
	public static ItemID RestaurantBuyItemId { get; set; }
	public static bool IsBuyFist { get; set; }
	public static bool IsBuyRAorMagic { get; set; }
	public static bool IsBuyCrystal { get; set; }
	private string PlayerName { get; }
	public static BuilderId LastBounghtBuildId { get; }

	// Methods

	// RVA: 0x1DDF800 Offset: 0x1DDF901 VA: 0x1DDF800
	private NpcShopType get_shopType() { }

	// RVA: 0x1DDF870 Offset: 0x1DDF971 VA: 0x1DDF870
	private void set_shopType(NpcShopType value) { }

	// RVA: 0x1DDF8E0 Offset: 0x1DDF9E1 VA: 0x1DDF8E0
	private NpcShopTable get_NpcShopTable() { }

	// RVA: 0x1DE0BF0 Offset: 0x1DE0CF1 VA: 0x1DE0BF0
	public NPCID get_npcId() { }

	// RVA: 0x1DE0C60 Offset: 0x1DE0D61 VA: 0x1DE0C60
	public void set_npcId(NPCID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8860 Offset: 0x1A8961 VA: 0x1A8860
	// RVA: 0x1DE0CD0 Offset: 0x1DE0DD1 VA: 0x1DE0CD0
	public static ItemID get_RestaurantBuyItemId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8870 Offset: 0x1A8971 VA: 0x1A8870
	// RVA: 0x1DE0D40 Offset: 0x1DE0E41 VA: 0x1DE0D40
	private static void set_RestaurantBuyItemId(ItemID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8880 Offset: 0x1A8981 VA: 0x1A8880
	// RVA: 0x1DE0DB0 Offset: 0x1DE0EB1 VA: 0x1DE0DB0
	public static bool get_IsBuyFist() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8890 Offset: 0x1A8991 VA: 0x1A8890
	// RVA: 0x1DE0E20 Offset: 0x1DE0F21 VA: 0x1DE0E20
	private static void set_IsBuyFist(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A88A0 Offset: 0x1A89A1 VA: 0x1A88A0
	// RVA: 0x1DE0E90 Offset: 0x1DE0F91 VA: 0x1DE0E90
	public static bool get_IsBuyRAorMagic() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A88B0 Offset: 0x1A89B1 VA: 0x1A88B0
	// RVA: 0x1DE0F00 Offset: 0x1DE1001 VA: 0x1DE0F00
	private static void set_IsBuyRAorMagic(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A88C0 Offset: 0x1A89C1 VA: 0x1A88C0
	// RVA: 0x1DE0F70 Offset: 0x1DE1071 VA: 0x1DE0F70
	public static bool get_IsBuyCrystal() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A88D0 Offset: 0x1A89D1 VA: 0x1A88D0
	// RVA: 0x1DE0FE0 Offset: 0x1DE10E1 VA: 0x1DE0FE0
	private static void set_IsBuyCrystal(bool value) { }

	// RVA: 0x1DE1050 Offset: 0x1DE1151 VA: 0x1DE1050
	private string get_PlayerName() { }

	// RVA: 0x1DE11D0 Offset: 0x1DE12D1 VA: 0x1DE11D0
	public static BuilderId get_LastBounghtBuildId() { }

	// RVA: 0x1DE1240 Offset: 0x1DE1341 VA: 0x1DE1240
	public static void LoadedAtlas(AssetHandle<SpriteAtlas> handle) { }

	// RVA: 0x1DE1540 Offset: 0x1DE1641 VA: 0x1DE1540
	public static void OpenShop(NPCID _npcId, NpcShopType npcShopType, UnityAction EndCallback) { }

	// RVA: 0x1DE1AE0 Offset: 0x1DE1BE1 VA: 0x1DE1AE0
	private void OnDestroy() { }

	// RVA: 0x1DE1CE0 Offset: 0x1DE1DE1 VA: 0x1DE1CE0
	private void Start() { }

	// RVA: 0x1DE2030 Offset: 0x1DE2131 VA: 0x1DE2030
	public void SwitchItemDetailToStatusParameter() { }

	// RVA: 0x1DE2090 Offset: 0x1DE2191 VA: 0x1DE2090
	private void SetStatusParameter() { }

	// RVA: 0x1DE2240 Offset: 0x1DE2341 VA: 0x1DE2240
	public void SetFocusBlock(UIShopItemBlock onFocusBlock) { }

	// RVA: 0x1DE27E0 Offset: 0x1DE28E1 VA: 0x1DE27E0
	public void ClearFocusBlock() { }

	// RVA: 0x1DE27F0 Offset: 0x1DE28F1 VA: 0x1DE27F0
	public void SetShopType(NpcShopType _shopType) { }

	// RVA: 0x1DE13F0 Offset: 0x1DE14F1 VA: 0x1DE13F0
	public void SetBuildIcon() { }

	// RVA: 0x1DE2960 Offset: 0x1DE2A61 VA: 0x1DE2960
	private void SetItemFromTable(int itemPage) { }

	// RVA: 0x1DE1CF0 Offset: 0x1DE1DF1 VA: 0x1DE1CF0
	public void OpenShop() { }

	// RVA: 0x1DE3AA0 Offset: 0x1DE3BA1 VA: 0x1DE3AA0
	private void EndDelayCloseShop() { }

	// RVA: 0x1DE3B40 Offset: 0x1DE3C41 VA: 0x1DE3B40
	private void UpdateCloseShop() { }

	// RVA: 0x1DE3BA0 Offset: 0x1DE3CA1 VA: 0x1DE3BA0
	private void CloseShop() { }

	// RVA: 0x1DE3C40 Offset: 0x1DE3D41 VA: 0x1DE3C40
	private ItemStorage GetItemStorage(ItemID id) { }

	// RVA: 0x1DE3D20 Offset: 0x1DE3E21 VA: 0x1DE3D20
	private ItemID GetNowFocusItemId() { }

	// RVA: 0x1DE3DD0 Offset: 0x1DE3ED1 VA: 0x1DE3DD0
	public void AddItemInBasket() { }

	// RVA: 0x1DE3F10 Offset: 0x1DE4011 VA: 0x1DE3F10
	private void AddItemToBasket() { }

	// RVA: 0x1DE4420 Offset: 0x1DE4521 VA: 0x1DE4420
	private void ResetBasket() { }

	// RVA: 0x1DE4690 Offset: 0x1DE4791 VA: 0x1DE4690
	private void BuyItemFromBasket() { }

	// RVA: 0x1DE35B0 Offset: 0x1DE36B1 VA: 0x1DE35B0
	private void ChangePage() { }

	// RVA: 0x1DDD930 Offset: 0x1DDDA31 VA: 0x1DDD930
	public void ChangePage(int plusPage) { }

	// RVA: 0x1DE4F40 Offset: 0x1DE5041 VA: 0x1DE4F40
	private void SetNpcBustup(NPCID npcId, int variationId, int eyeId, int EyeBrowsId, int MouthId) { }

	// RVA: 0x1DE3A90 Offset: 0x1DE3B91 VA: 0x1DE3A90
	public void SetTalkBox(UIShopController.ShopTalkType talkType) { }

	// RVA: 0x1DE4F70 Offset: 0x1DE5071 VA: 0x1DE4F70
	private void SetTalkBox(int talkType) { }

	// RVA: 0x1DE5910 Offset: 0x1DE5A11 VA: 0x1DE5910
	private void SetTalkCantBuy(string TextId) { }

	// RVA: 0x1DE5D60 Offset: 0x1DE5E61 VA: 0x1DE5D60
	private void Update() { }

	// RVA: 0x1DE6820 Offset: 0x1DE6921 VA: 0x1DE6820
	private uint rf3MainBigSellLimitU32(ulong rand_seed, uint limit, uint shop_id) { }

	// RVA: 0x1DDF970 Offset: 0x1DDFA71 VA: 0x1DDF970
	private void SetShopTable() { }

	// RVA: 0x1DE6930 Offset: 0x1DE6A31 VA: 0x1DE6930
	public void .ctor() { }

	// RVA: 0x1DE6A30 Offset: 0x1DE6B31 VA: 0x1DE6A30
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A88E0 Offset: 0x1A89E1 VA: 0x1A88E0
	// RVA: 0x1DE6A40 Offset: 0x1DE6B41 VA: 0x1DE6A40
	private void <Update>b__114_0(bool selector) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A88F0 Offset: 0x1A89F1 VA: 0x1A88F0
	// RVA: 0x1DE6DA0 Offset: 0x1DE6EA1 VA: 0x1DE6DA0
	private void <Update>b__114_1(bool selector) { }
}

