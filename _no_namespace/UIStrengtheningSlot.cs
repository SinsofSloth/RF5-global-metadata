public class UIStrengtheningSlot : UIItemSlot // TypeDefIndex: 8860
{
	// Fields
	[SerializeField] // RVA: 0x174450 Offset: 0x174551 VA: 0x174450
	private UIStrengthening.SlotType slotType; // 0xD4
	private static ItemData[] StrengtheningItems; // 0x0
	[SerializeField] // RVA: 0x174460 Offset: 0x174561 VA: 0x174460
	private UIStrengthening uiStrengthening; // 0xD8
	[SerializeField] // RVA: 0x174470 Offset: 0x174571 VA: 0x174470
	private Image storageImage; // 0xE0
	[SerializeField] // RVA: 0x174480 Offset: 0x174581 VA: 0x174480
	private List<Sprite> storageIcon; // 0xE8

	// Properties
	public override bool isStrengtheningSlot { get; }

	// Methods

	// RVA: 0x1FF5AD0 Offset: 0x1FF5BD1 VA: 0x1FF5AD0 Slot: 20
	public override bool get_isStrengtheningSlot() { }

	// RVA: 0x1FF5AE0 Offset: 0x1FF5BE1 VA: 0x1FF5AE0 Slot: 21
	public override void SwapSlotA(UIItemSlot slotB) { }

	// RVA: 0x1FF5B70 Offset: 0x1FF5C71 VA: 0x1FF5B70 Slot: 22
	public override void SwapSlotB(UIItemSlot slotA) { }

	// RVA: 0x1FF51B0 Offset: 0x1FF52B1 VA: 0x1FF51B0
	public void RestorageItem() { }

	// RVA: 0x1FF5FB0 Offset: 0x1FF60B1 VA: 0x1FF5FB0
	private void SetStorageIcon() { }

	// RVA: 0x1FF60B0 Offset: 0x1FF61B1 VA: 0x1FF60B0 Slot: 23
	protected override ItemData GetItemData() { }

	// RVA: 0x1FF6150 Offset: 0x1FF6251 VA: 0x1FF6150 Slot: 24
	protected override void SetItemData(ItemData _item_data) { }

	// RVA: 0x1FF6240 Offset: 0x1FF6341 VA: 0x1FF6240 Slot: 26
	public override bool FilterCheck(ItemData _item_data) { }

	// RVA: 0x1FF6280 Offset: 0x1FF6381 VA: 0x1FF6280 Slot: 28
	public override void DoEquipInput(ActorID actorID, StorageType storageType) { }

	// RVA: 0x1FF6330 Offset: 0x1FF6431 VA: 0x1FF6330
	private void OnDestroy() { }

	// RVA: 0x1FF6340 Offset: 0x1FF6441 VA: 0x1FF6340 Slot: 27
	protected override void OnEnable() { }

	// RVA: 0x1FF6350 Offset: 0x1FF6451 VA: 0x1FF6350
	public void .ctor() { }

	// RVA: 0x1FF63E0 Offset: 0x1FF64E1 VA: 0x1FF63E0
	private static void .cctor() { }
}

