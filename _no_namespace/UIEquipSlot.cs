public class UIEquipSlot : UIItemSlot // TypeDefIndex: 8607
{
	// Fields
	[SerializeField] // RVA: 0x171160 Offset: 0x171261 VA: 0x171160
	public UIEquipSlot.SlotOwner slotOwner; // 0xD4
	public ActorID actorID; // 0xD8
	[SerializeField] // RVA: 0x171170 Offset: 0x171271 VA: 0x171170
	public EquipSlotType MyType; // 0xDC
	public ItemData EquipItemData; // 0xE0

	// Properties
	public override bool IsEquipItemSlot { get; }
	public override EquipSlotType EquipSlotType { get; }

	// Methods

	// RVA: 0x1F134D0 Offset: 0x1F135D1 VA: 0x1F134D0
	public void SetOwner(UIEquipSlot.SlotOwner owner) { }

	// RVA: 0x1F136F0 Offset: 0x1F137F1 VA: 0x1F136F0 Slot: 17
	public override bool get_IsEquipItemSlot() { }

	// RVA: 0x1F13700 Offset: 0x1F13801 VA: 0x1F13700 Slot: 18
	public override EquipSlotType get_EquipSlotType() { }

	// RVA: 0x1F13710 Offset: 0x1F13811 VA: 0x1F13710 Slot: 23
	protected override ItemData GetItemData() { }

	// RVA: 0x1F137E0 Offset: 0x1F138E1 VA: 0x1F137E0 Slot: 24
	protected override void SetItemData(ItemData itemData) { }

	// RVA: 0x1F138C0 Offset: 0x1F139C1 VA: 0x1F138C0
	private bool HoldingNotStorable() { }

	// RVA: 0x1F13920 Offset: 0x1F13A21 VA: 0x1F13920 Slot: 26
	public override bool FilterCheck(ItemData itemData) { }

	// RVA: 0x1F13B50 Offset: 0x1F13C51 VA: 0x1F13B50 Slot: 27
	protected override void OnEnable() { }

	// RVA: 0x1F13BA0 Offset: 0x1F13CA1 VA: 0x1F13BA0 Slot: 28
	public override void DoEquipInput(ActorID actorID, StorageType storageType) { }

	// RVA: 0x1F13DF0 Offset: 0x1F13EF1 VA: 0x1F13DF0
	public void .ctor() { }
}

