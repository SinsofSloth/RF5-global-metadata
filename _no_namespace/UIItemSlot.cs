public class UIItemSlot : UIButtonLinkerInScrollBox // TypeDefIndex: 8612
{
	// Fields
	private StorageType ItemStorageType; // 0x70
	private ItemDataLinker _ItemDataLinker; // 0x78
	[SerializeField] // RVA: 0x171200 Offset: 0x171301 VA: 0x171200
	public Image ItemImage; // 0x80
	[SerializeField] // RVA: 0x171210 Offset: 0x171311 VA: 0x171210
	public TextMeshProUGUI ItemAmountText; // 0x88
	[SerializeField] // RVA: 0x171220 Offset: 0x171321 VA: 0x171220
	public Image ItemAmountImage; // 0x90
	[SerializeField] // RVA: 0x171230 Offset: 0x171331 VA: 0x171230
	private GameObject ItemSelectingImgObj; // 0x98
	[SerializeField] // RVA: 0x171240 Offset: 0x171341 VA: 0x171240
	private GameObject BlockFilterImageObj; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x171250 Offset: 0x171351 VA: 0x171250
	private int <SlotNum>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x171260 Offset: 0x171361 VA: 0x171260
	private bool <SlotSelecting>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x171270 Offset: 0x171371 VA: 0x171270
	private bool <FilterGuard>k__BackingField; // 0xAD
	[CompilerGeneratedAttribute] // RVA: 0x171280 Offset: 0x171381 VA: 0x171280
	private GenerateItemSlot <MyGenerator>k__BackingField; // 0xB0
	public ItemID LastDrawItemId; // 0xB8
	public int LastDrawAmount; // 0xBC
	protected UIItemSlot baseSlot; // 0xC0
	public bool isDummySlot; // 0xC8
	public int CraftSlotNo; // 0xCC
	public int StrengtheningSlotNo; // 0xD0

	// Properties
	public StorageType StorageType { get; set; }
	public ItemStorage ItemStorage { get; set; }
	public ItemDataLinker ItemDataLinker { get; set; }
	public virtual bool IsEquipItemSlot { get; }
	public virtual EquipSlotType EquipSlotType { get; }
	public virtual bool isCraftSlot { get; }
	public virtual bool isStrengtheningSlot { get; }
	public int SlotNum { get; set; }
	public bool SlotSelecting { get; set; }
	public bool FilterGuard { get; set; }
	public GenerateItemSlot MyGenerator { get; set; }
	public ItemData ItemData { get; set; }

	// Methods

	// RVA: 0x1ED2BB0 Offset: 0x1ED2CB1 VA: 0x1ED2BB0
	public StorageType get_StorageType() { }

	// RVA: 0x1ED2C20 Offset: 0x1ED2D21 VA: 0x1ED2C20
	public void set_StorageType(StorageType value) { }

	// RVA: 0x1ED2C90 Offset: 0x1ED2D91 VA: 0x1ED2C90
	public ItemStorage get_ItemStorage() { }

	// RVA: 0x1ED2E00 Offset: 0x1ED2F01 VA: 0x1ED2E00
	public void set_ItemStorage(ItemStorage value) { }

	// RVA: 0x1ED2E90 Offset: 0x1ED2F91 VA: 0x1ED2E90
	public ItemDataLinker get_ItemDataLinker() { }

	// RVA: 0x1ED2EA0 Offset: 0x1ED2FA1 VA: 0x1ED2EA0
	protected void set_ItemDataLinker(ItemDataLinker value) { }

	// RVA: 0x1ED2EB0 Offset: 0x1ED2FB1 VA: 0x1ED2EB0 Slot: 17
	public virtual bool get_IsEquipItemSlot() { }

	// RVA: 0x1ED2EC0 Offset: 0x1ED2FC1 VA: 0x1ED2EC0 Slot: 18
	public virtual EquipSlotType get_EquipSlotType() { }

	// RVA: 0x1ED2ED0 Offset: 0x1ED2FD1 VA: 0x1ED2ED0 Slot: 19
	public virtual bool get_isCraftSlot() { }

	// RVA: 0x1ED2EE0 Offset: 0x1ED2FE1 VA: 0x1ED2EE0 Slot: 20
	public virtual bool get_isStrengtheningSlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7E50 Offset: 0x1A7F51 VA: 0x1A7E50
	// RVA: 0x1ED2EF0 Offset: 0x1ED2FF1 VA: 0x1ED2EF0
	public int get_SlotNum() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7E60 Offset: 0x1A7F61 VA: 0x1A7E60
	// RVA: 0x1ED2F00 Offset: 0x1ED3001 VA: 0x1ED2F00
	private void set_SlotNum(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7E70 Offset: 0x1A7F71 VA: 0x1A7E70
	// RVA: 0x1ED2F10 Offset: 0x1ED3011 VA: 0x1ED2F10
	public bool get_SlotSelecting() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7E80 Offset: 0x1A7F81 VA: 0x1A7E80
	// RVA: 0x1ED2F20 Offset: 0x1ED3021 VA: 0x1ED2F20
	private void set_SlotSelecting(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7E90 Offset: 0x1A7F91 VA: 0x1A7E90
	// RVA: 0x1ED2F30 Offset: 0x1ED3031 VA: 0x1ED2F30
	public bool get_FilterGuard() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7EA0 Offset: 0x1A7FA1 VA: 0x1A7EA0
	// RVA: 0x1ED2F40 Offset: 0x1ED3041 VA: 0x1ED2F40
	private void set_FilterGuard(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7EB0 Offset: 0x1A7FB1 VA: 0x1A7EB0
	// RVA: 0x1ED2F50 Offset: 0x1ED3051 VA: 0x1ED2F50
	public GenerateItemSlot get_MyGenerator() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7EC0 Offset: 0x1A7FC1 VA: 0x1A7EC0
	// RVA: 0x1ED2F60 Offset: 0x1ED3061 VA: 0x1ED2F60
	private void set_MyGenerator(GenerateItemSlot value) { }

	// RVA: 0x1ED2F70 Offset: 0x1ED3071 VA: 0x1ED2F70 Slot: 21
	public virtual void SwapSlotA(UIItemSlot slotB) { }

	// RVA: 0x1ED2FA0 Offset: 0x1ED30A1 VA: 0x1ED2FA0 Slot: 22
	public virtual void SwapSlotB(UIItemSlot slotA) { }

	// RVA: 0x1ED3050 Offset: 0x1ED3151 VA: 0x1ED3050
	public UIItemSlot CloneDummy(Transform parent) { }

	// RVA: 0x1ED3160 Offset: 0x1ED3261 VA: 0x1ED3160
	public bool CheckSameSlot(UIItemSlot targetSlot) { }

	// RVA: 0x1ED3030 Offset: 0x1ED3131 VA: 0x1ED3030
	public ItemData get_ItemData() { }

	// RVA: 0x1ED3040 Offset: 0x1ED3141 VA: 0x1ED3040
	public void set_ItemData(ItemData value) { }

	// RVA: 0x1ED3320 Offset: 0x1ED3421 VA: 0x1ED3320 Slot: 23
	protected virtual ItemData GetItemData() { }

	// RVA: 0x1ED3340 Offset: 0x1ED3441 VA: 0x1ED3340 Slot: 24
	protected virtual void SetItemData(ItemData itemData) { }

	// RVA: 0x1ED3360 Offset: 0x1ED3461 VA: 0x1ED3360
	public void SetSlotType(int slotNum, ItemStorage storage) { }

	// RVA: 0x1ED3440 Offset: 0x1ED3541 VA: 0x1ED3440
	public void SetSlotType(int slotNum, StorageType storageType) { }

	// RVA: 0x1ED3580 Offset: 0x1ED3681 VA: 0x1ED3580
	public void CheckToCursorTakedItem() { }

	// RVA: 0x1ED3630 Offset: 0x1ED3731 VA: 0x1ED3630 Slot: 25
	public virtual void ReDisp() { }

	// RVA: 0x1ED3B70 Offset: 0x1ED3C71 VA: 0x1ED3B70
	public void CheckSelecting() { }

	// RVA: 0x1ED3AD0 Offset: 0x1ED3BD1 VA: 0x1ED3AD0
	private void SetFilterImage() { }

	// RVA: 0x1ED3CD0 Offset: 0x1ED3DD1 VA: 0x1ED3CD0
	private void SetSelectingImage() { }

	// RVA: 0x1ED3D70 Offset: 0x1ED3E71 VA: 0x1ED3D70 Slot: 26
	public virtual bool FilterCheck(ItemData itemData) { }

	// RVA: 0x1ED3DE0 Offset: 0x1ED3EE1 VA: 0x1ED3DE0
	public void SetFilter(UIItemSlot itemSlot) { }

	// RVA: 0x1ED3F40 Offset: 0x1ED4041 VA: 0x1ED3F40
	public void ReleaseFilter() { }

	// RVA: 0x1ED36D0 Offset: 0x1ED37D1 VA: 0x1ED36D0
	private void SetItemImage() { }

	// RVA: 0x1ED3FE0 Offset: 0x1ED40E1 VA: 0x1ED3FE0 Slot: 16
	public override void Init() { }

	// RVA: 0x1ED4070 Offset: 0x1ED4171 VA: 0x1ED4070
	private void OnDisable() { }

	// RVA: 0x1ED4250 Offset: 0x1ED4351 VA: 0x1ED4250 Slot: 27
	protected virtual void OnEnable() { }

	// RVA: 0x1ED43E0 Offset: 0x1ED44E1 VA: 0x1ED43E0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1ED44A0 Offset: 0x1ED45A1 VA: 0x1ED44A0
	private void Start() { }

	// RVA: 0x1ED44C0 Offset: 0x1ED45C1 VA: 0x1ED44C0 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1ED4780 Offset: 0x1ED4881 VA: 0x1ED4780 Slot: 11
	public override void EndFocus() { }

	// RVA: 0x1ED4540 Offset: 0x1ED4641 VA: 0x1ED4540
	public void SetButtonHint() { }

	// RVA: 0x1ED4960 Offset: 0x1ED4A61 VA: 0x1ED4960
	protected EquipSlotType GetSlotType(ItemID itemID) { }

	// RVA: 0x1ED49B0 Offset: 0x1ED4AB1 VA: 0x1ED49B0 Slot: 28
	public virtual void DoEquipInput(ActorID actorId, StorageType storageType) { }

	// RVA: 0x1ED5150 Offset: 0x1ED5251 VA: 0x1ED5150
	private void Update() { }

	// RVA: 0x1ED5210 Offset: 0x1ED5311 VA: 0x1ED5210
	public void .ctor() { }
}

