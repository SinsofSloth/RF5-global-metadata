public class UICraftSlot : UIItemSlot // TypeDefIndex: 8605
{
	// Fields
	[SerializeField] // RVA: 0x171120 Offset: 0x171221 VA: 0x171120
	private Image StorageIconImage; // 0xD8
	[SerializeField] // RVA: 0x171130 Offset: 0x171231 VA: 0x171130
	private Sprite[] StorageSprites; // 0xE0
	[SerializeField] // RVA: 0x171140 Offset: 0x171241 VA: 0x171140
	private UICraftMenu UICraftMenu; // 0xE8
	private static ItemData[] StockItemData; // 0x0

	// Properties
	public override bool IsEquipItemSlot { get; }
	public override bool isCraftSlot { get; }

	// Methods

	// RVA: 0x1F0C8B0 Offset: 0x1F0C9B1 VA: 0x1F0C8B0 Slot: 17
	public override bool get_IsEquipItemSlot() { }

	// RVA: 0x1F0C8C0 Offset: 0x1F0C9C1 VA: 0x1F0C8C0 Slot: 19
	public override bool get_isCraftSlot() { }

	// RVA: 0x1F0C8D0 Offset: 0x1F0C9D1 VA: 0x1F0C8D0 Slot: 21
	public override void SwapSlotA(UIItemSlot slotB) { }

	// RVA: 0x1F0C950 Offset: 0x1F0CA51 VA: 0x1F0C950 Slot: 22
	public override void SwapSlotB(UIItemSlot slotA) { }

	// RVA: 0x1F0A630 Offset: 0x1F0A731 VA: 0x1F0A630
	public void SetStorageImage() { }

	// RVA: 0x1F0CD70 Offset: 0x1F0CE71 VA: 0x1F0CD70 Slot: 23
	protected override ItemData GetItemData() { }

	// RVA: 0x1F0CE10 Offset: 0x1F0CF11 VA: 0x1F0CE10 Slot: 24
	protected override void SetItemData(ItemData _itemData) { }

	// RVA: 0x1F0CF00 Offset: 0x1F0D001 VA: 0x1F0CF00 Slot: 25
	public override void ReDisp() { }

	// RVA: 0x1F0CF30 Offset: 0x1F0D031 VA: 0x1F0CF30 Slot: 26
	public override bool FilterCheck(ItemData itemData) { }

	// RVA: 0x1F0CF40 Offset: 0x1F0D041 VA: 0x1F0CF40 Slot: 27
	protected override void OnEnable() { }

	// RVA: 0x1F0CCB0 Offset: 0x1F0CDB1 VA: 0x1F0CCB0
	private void RestorageItem() { }

	// RVA: 0x1F0CF80 Offset: 0x1F0D081 VA: 0x1F0CF80
	private void OnDestroy() { }

	// RVA: 0x1F0CF90 Offset: 0x1F0D091 VA: 0x1F0CF90
	private void OnDisable() { }

	// RVA: 0x1F0CFA0 Offset: 0x1F0D0A1 VA: 0x1F0CFA0 Slot: 28
	public override void DoEquipInput(ActorID actorID, StorageType storageType) { }

	// RVA: 0x1F0D030 Offset: 0x1F0D131 VA: 0x1F0D030
	public void .ctor() { }

	// RVA: 0x1F0D0A0 Offset: 0x1F0D1A1 VA: 0x1F0D0A0
	private static void .cctor() { }
}

