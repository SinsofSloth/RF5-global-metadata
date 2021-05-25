public class HumanEquipment : AS_ToolController // TypeDefIndex: 6642
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15E5A0 Offset: 0x15E6A1 VA: 0x15E5A0
	private HumanModel <HumanModel>k__BackingField; // 0x1C0
	[CompilerGeneratedAttribute] // RVA: 0x15E5B0 Offset: 0x15E6B1 VA: 0x15E5B0
	private HumanStatus <HumanStatus>k__BackingField; // 0x1C8
	[CompilerGeneratedAttribute] // RVA: 0x15E5C0 Offset: 0x15E6C1 VA: 0x15E5C0
	private UnityEventDicHumanItemEquip <ResetDicHumanItemEquipEvent>k__BackingField; // 0x1D0
	[CompilerGeneratedAttribute] // RVA: 0x15E5D0 Offset: 0x15E6D1 VA: 0x15E5D0
	private int <LoadCount>k__BackingField; // 0x1D8
	private readonly EquipSlotType[] EquipItemSlots; // 0x1E0
	private Dictionary<EquipSlotType, HumanEquipItem> EquipItemList; // 0x1E8
	[CompilerGeneratedAttribute] // RVA: 0x15E5E0 Offset: 0x15E6E1 VA: 0x15E5E0
	private bool <InitedToolEquip>k__BackingField; // 0x1F0

	// Properties
	public HumanModel HumanModel { get; set; }
	public HumanStatus HumanStatus { get; set; }
	public UnityEventDicHumanItemEquip ResetDicHumanItemEquipEvent { get; set; }
	public int LoadCount { get; set; }
	public bool IsLoading { get; }
	public bool InitedToolEquip { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19C4C0 Offset: 0x19C5C1 VA: 0x19C4C0
	// RVA: 0x1E93450 Offset: 0x1E93551 VA: 0x1E93450
	public HumanModel get_HumanModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C4D0 Offset: 0x19C5D1 VA: 0x19C4D0
	// RVA: 0x1E93460 Offset: 0x1E93561 VA: 0x1E93460
	private void set_HumanModel(HumanModel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C4E0 Offset: 0x19C5E1 VA: 0x19C4E0
	// RVA: 0x1E93470 Offset: 0x1E93571 VA: 0x1E93470
	public HumanStatus get_HumanStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C4F0 Offset: 0x19C5F1 VA: 0x19C4F0
	// RVA: 0x1E93480 Offset: 0x1E93581 VA: 0x1E93480
	private void set_HumanStatus(HumanStatus value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C500 Offset: 0x19C601 VA: 0x19C500
	// RVA: 0x1E93490 Offset: 0x1E93591 VA: 0x1E93490
	public UnityEventDicHumanItemEquip get_ResetDicHumanItemEquipEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C510 Offset: 0x19C611 VA: 0x19C510
	// RVA: 0x1E934A0 Offset: 0x1E935A1 VA: 0x1E934A0
	public void set_ResetDicHumanItemEquipEvent(UnityEventDicHumanItemEquip value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C520 Offset: 0x19C621 VA: 0x19C520
	// RVA: 0x1E934B0 Offset: 0x1E935B1 VA: 0x1E934B0
	public int get_LoadCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C530 Offset: 0x19C631 VA: 0x19C530
	// RVA: 0x1E934C0 Offset: 0x1E935C1 VA: 0x1E934C0
	protected void set_LoadCount(int value) { }

	// RVA: 0x1E934D0 Offset: 0x1E935D1 VA: 0x1E934D0
	public bool get_IsLoading() { }

	// RVA: 0x1E934E0 Offset: 0x1E935E1 VA: 0x1E934E0
	public bool CanEquip(EquipSlotType slot_type) { }

	// RVA: 0x1E8BA70 Offset: 0x1E8BB71 VA: 0x1E8BA70
	public void ResetEquip(bool enableWeaponAndTool, bool force) { }

	// RVA: 0x1E8BE40 Offset: 0x1E8BF41 VA: 0x1E8BE40
	public bool Equip(EquipSlotType slot_type, bool force) { }

	// RVA: 0x1E93560 Offset: 0x1E93661 VA: 0x1E93560
	private void ClearEquipItem(HumanEquipItem equipItem) { }

	// RVA: 0x1E8C200 Offset: 0x1E8C301 VA: 0x1E8C200
	public bool UnEquip(EquipSlotType slot_type) { }

	// RVA: 0x1E86630 Offset: 0x1E86731 VA: 0x1E86630
	public void UnEquipAll() { }

	// RVA: 0x1E86FD0 Offset: 0x1E870D1 VA: 0x1E86FD0
	public void SetVisible(EquipSlotType slot_type, bool visible) { }

	// RVA: 0x1E93AA0 Offset: 0x1E93BA1 VA: 0x1E93AA0
	public ItemData GetItemData(EquipSlotType slot_type) { }

	// RVA: 0x1E93B50 Offset: 0x1E93C51 VA: 0x1E93B50
	public ItemEquip[] GetItemEquip(EquipSlotType slot_type) { }

	// RVA: 0x1E86C00 Offset: 0x1E86D01 VA: 0x1E86C00
	public void OnUpdate() { }

	// RVA: 0x1E85D80 Offset: 0x1E85E81 VA: 0x1E85D80
	public void Init(HumanController humanController, bool useManager) { }

	// RVA: 0x1E93C00 Offset: 0x1E93D01 VA: 0x1E93C00 Slot: 8
	protected override void Awake() { }

	// RVA: 0x1E93C10 Offset: 0x1E93D11 VA: 0x1E93C10
	protected void Start() { }

	// RVA: 0x1E93ED0 Offset: 0x1E93FD1 VA: 0x1E93ED0
	private void ItemLoaded(EquipSlotType slot_type, ItemID item_id, bool force) { }

	// RVA: 0x1E93670 Offset: 0x1E93771 VA: 0x1E93670
	private void AttachEquips(EquipSlotType slot_type, HumanEquipItem equipItem) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C540 Offset: 0x19C641 VA: 0x19C540
	// RVA: 0x1E94080 Offset: 0x1E94181 VA: 0x1E94080
	public bool get_InitedToolEquip() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C550 Offset: 0x19C651 VA: 0x19C550
	// RVA: 0x1E94090 Offset: 0x1E94191 VA: 0x1E94090
	protected void set_InitedToolEquip(bool value) { }

	// RVA: 0x1E940A0 Offset: 0x1E941A1 VA: 0x1E940A0
	private void OnOpenToolEquip() { }

	// RVA: 0x1E83910 Offset: 0x1E83A11 VA: 0x1E83910
	public void OpenToolEquip(EquipSlotType equipSlotType) { }

	// RVA: 0x1E84030 Offset: 0x1E84131 VA: 0x1E84030
	public void CloseToolEquip() { }

	// RVA: 0x1E83890 Offset: 0x1E83991 VA: 0x1E83890
	public void OnOpenedToolEquip() { }

	// RVA: 0x1E83E30 Offset: 0x1E83F31 VA: 0x1E83E30
	public void OnClosedToolEquip() { }

	// RVA: 0x1E940B0 Offset: 0x1E941B1 VA: 0x1E940B0
	public void .ctor() { }
}

