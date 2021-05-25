public class UIEMMainControl : MonoBehaviour // TypeDefIndex: 8525
{
	// Fields
	private List<int> EMCategoryList; // 0x18
	[SerializeField] // RVA: 0x170220 Offset: 0x170321 VA: 0x170220
	private Sprite[] ItemCategoryIcon; // 0x20
	[SerializeField] // RVA: 0x170230 Offset: 0x170331 VA: 0x170230
	private UIEMMainControl.EquipMenuType equipMenuType; // 0x28
	public UIEMEquipItemSlot TopSlot; // 0x30
	[SerializeField] // RVA: 0x170240 Offset: 0x170341 VA: 0x170240
	private UIEMItemsControl UIEMItemsControl; // 0x38
	private int _equipSlotType; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x170250 Offset: 0x170351 VA: 0x170250
	private int <FocusingItem>k__BackingField; // 0x44
	[SerializeField] // RVA: 0x170260 Offset: 0x170361 VA: 0x170260
	private Text UpText; // 0x48
	[SerializeField] // RVA: 0x170270 Offset: 0x170371 VA: 0x170270
	private Text DownText; // 0x50
	[SerializeField] // RVA: 0x170280 Offset: 0x170381 VA: 0x170280
	private Text NowText; // 0x58
	[SerializeField] // RVA: 0x170290 Offset: 0x170391 VA: 0x170290
	private Text TopText; // 0x60
	[SerializeField] // RVA: 0x1702A0 Offset: 0x1703A1 VA: 0x1702A0
	private Text BottomText; // 0x68
	[SerializeField] // RVA: 0x1702B0 Offset: 0x1703B1 VA: 0x1702B0
	private Image UpIcon; // 0x70
	[SerializeField] // RVA: 0x1702C0 Offset: 0x1703C1 VA: 0x1702C0
	private Image DownIcon; // 0x78
	[SerializeField] // RVA: 0x1702D0 Offset: 0x1703D1 VA: 0x1702D0
	private Image NowIcon; // 0x80
	[SerializeField] // RVA: 0x1702E0 Offset: 0x1703E1 VA: 0x1702E0
	private Image TopIcon; // 0x88
	[SerializeField] // RVA: 0x1702F0 Offset: 0x1703F1 VA: 0x1702F0
	private Image BottomIcon; // 0x90
	[SerializeField] // RVA: 0x170300 Offset: 0x170401 VA: 0x170300
	private Image PadIcon; // 0x98
	[SerializeField] // RVA: 0x170310 Offset: 0x170411 VA: 0x170310
	private UIEMItemDetail UIEMItemDetail; // 0xA0
	[SerializeField] // RVA: 0x170320 Offset: 0x170421 VA: 0x170320
	private EquipStatusMenu EquipStatusMenu; // 0xA8
	[SerializeField] // RVA: 0x170330 Offset: 0x170431 VA: 0x170330
	private UIOnOffAnimate UIOnOffAnimate; // 0xB0
	[SerializeField] // RVA: 0x170340 Offset: 0x170441 VA: 0x170340
	private Animator CategoryAnim; // 0xB8
	private bool FocusOnEquip; // 0xC0
	private UIQuickEquipMenuMain UIQuickEquipMenuMain; // 0xC8
	private UICampEquipMenuMain UICampEquipMenuMain; // 0xD0
	private int ItemCount; // 0xD8

	// Properties
	public EquipSlotType equipSlotType { get; }
	public UIEMDefine.CategoryDataSet NowEquipSlotData { get; }
	private UIEMDefine.CategoryDataSet UpEquipSlotData { get; }
	private UIEMDefine.CategoryDataSet DownEquipSlotData { get; }
	private UIEMDefine.CategoryDataSet TopEquipSlotData { get; }
	private UIEMDefine.CategoryDataSet BottomEquipSlotData { get; }
	public int FocusingItem { get; set; }

	// Methods

	// RVA: 0x1F10F10 Offset: 0x1F11011 VA: 0x1F10F10
	public EquipSlotType get_equipSlotType() { }

	// RVA: 0x1F0FDF0 Offset: 0x1F0FEF1 VA: 0x1F0FDF0
	public UIEMDefine.CategoryDataSet get_NowEquipSlotData() { }

	// RVA: 0x1F11070 Offset: 0x1F11171 VA: 0x1F11070
	private UIEMDefine.CategoryDataSet get_UpEquipSlotData() { }

	// RVA: 0x1F11160 Offset: 0x1F11261 VA: 0x1F11160
	private UIEMDefine.CategoryDataSet get_DownEquipSlotData() { }

	// RVA: 0x1F11250 Offset: 0x1F11351 VA: 0x1F11250
	private UIEMDefine.CategoryDataSet get_TopEquipSlotData() { }

	// RVA: 0x1F11340 Offset: 0x1F11441 VA: 0x1F11340
	private UIEMDefine.CategoryDataSet get_BottomEquipSlotData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7B00 Offset: 0x1A7C01 VA: 0x1A7B00
	// RVA: 0x1F11430 Offset: 0x1F11531 VA: 0x1F11430
	public int get_FocusingItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7B10 Offset: 0x1A7C11 VA: 0x1A7B10
	// RVA: 0x1F11440 Offset: 0x1F11541 VA: 0x1F11440
	public void set_FocusingItem(int value) { }

	// RVA: 0x1F11450 Offset: 0x1F11551 VA: 0x1F11450
	private void Start() { }

	// RVA: 0x1F0E6B0 Offset: 0x1F0E7B1 VA: 0x1F0E6B0
	public ActorID GetActorID() { }

	// RVA: 0x1F114E0 Offset: 0x1F115E1 VA: 0x1F114E0
	private void SetItemGroupText() { }

	// RVA: 0x1F11B40 Offset: 0x1F11C41 VA: 0x1F11B40
	private void UpdateStatusText() { }

	// RVA: 0x1F11CD0 Offset: 0x1F11DD1 VA: 0x1F11CD0
	private void UpdateItemDetail() { }

	// RVA: 0x1F11EB0 Offset: 0x1F11FB1 VA: 0x1F11EB0
	private void CloseWindow(bool isWeaponChange = False) { }

	// RVA: 0x1F11FF0 Offset: 0x1F120F1 VA: 0x1F11FF0
	private void OnDisable() { }

	// RVA: 0x1F120C0 Offset: 0x1F121C1 VA: 0x1F120C0
	private ItemStorage GetItemStorage(ItemData itemData) { }

	// RVA: 0x1F121A0 Offset: 0x1F122A1 VA: 0x1F121A0
	public void DoOpenPage(UIQuickEquipMenuMain uiQuickEquipMenuMain) { }

	// RVA: 0x1F05140 Offset: 0x1F05241 VA: 0x1F05140
	public void DoOpenPage(UICampEquipMenuMain uiCampEquipMenuMain) { }

	// RVA: 0x1F123A0 Offset: 0x1F124A1 VA: 0x1F123A0
	private void ReDrawItems() { }

	// RVA: 0x1F12440 Offset: 0x1F12541 VA: 0x1F12440
	private bool CheckEquipNotItemOnHand() { }

	// RVA: 0x1F124A0 Offset: 0x1F125A1 VA: 0x1F124A0
	private void Update() { }

	// RVA: 0x1F132E0 Offset: 0x1F133E1 VA: 0x1F132E0
	private void BackToTopSlot() { }

	// RVA: 0x1F13130 Offset: 0x1F13231 VA: 0x1F13130
	private void OnChangePage() { }

	// RVA: 0x1F12E30 Offset: 0x1F12F31 VA: 0x1F12E30
	private bool PressA() { }

	// RVA: 0x1F10BB0 Offset: 0x1F10CB1 VA: 0x1F10BB0
	public void OnTouchItemSlot(int _index) { }

	// RVA: 0x1F10890 Offset: 0x1F10991 VA: 0x1F10890
	public void InputLeft() { }

	// RVA: 0x1F10A00 Offset: 0x1F10B01 VA: 0x1F10A00
	public void InputRight() { }

	// RVA: 0x1F13360 Offset: 0x1F13461 VA: 0x1F13360
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7B20 Offset: 0x1A7C21 VA: 0x1A7B20
	// RVA: 0x1F13370 Offset: 0x1F13471 VA: 0x1F13370
	private void <Start>b__42_0() { }
}

