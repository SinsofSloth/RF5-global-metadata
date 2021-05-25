public class UIItemSlotsManager : SingletonMonoBehaviour<UIItemSlotsManager> // TypeDefIndex: 8616
{
	// Fields
	private List<UIItemSlot> UIItemSlotList; // 0x18
	public UIItemSlot SelectSlot; // 0x20
	private UIItemSlot focusingSlot; // 0x28
	private GenerateItemSlot NowFocusGenerator; // 0x30
	public StorageType LinkingStorageType; // 0x38
	public UIItemSlotsManager.PickingItem pickItem; // 0x40

	// Methods

	// RVA: 0x1ED5EE0 Offset: 0x1ED5FE1 VA: 0x1ED5EE0
	public bool IsSelecting() { }

	// RVA: 0x1ED62A0 Offset: 0x1ED63A1 VA: 0x1ED62A0
	private void ClearItem() { }

	// RVA: 0x1ED4340 Offset: 0x1ED4441 VA: 0x1ED4340
	public void AddSlot(UIItemSlot itemSlot) { }

	// RVA: 0x1ED4140 Offset: 0x1ED4241 VA: 0x1ED4140
	public void RemoveSlot(UIItemSlot itemSlot) { }

	// RVA: 0x1ED63D0 Offset: 0x1ED64D1 VA: 0x1ED63D0
	public void ReDispAll() { }

	// RVA: 0x1ED64F0 Offset: 0x1ED65F1 VA: 0x1ED64F0
	public void ReDispAllSelecting() { }

	// RVA: 0x1ED6600 Offset: 0x1ED6701 VA: 0x1ED6600
	private void SplitItem(UIItemSlot slotA) { }

	// RVA: 0x1ED67D0 Offset: 0x1ED68D1 VA: 0x1ED67D0
	private void RefillItemSlot(UIItemSlot slotA, UIItemSlot slotB) { }

	// RVA: 0x1ED5020 Offset: 0x1ED5121 VA: 0x1ED5020
	public void SwapSlot(UIItemSlot slotA, UIItemSlot slotB) { }

	// RVA: 0x1ED68D0 Offset: 0x1ED69D1 VA: 0x1ED68D0
	private void SelectItemSlot() { }

	// RVA: 0x1ED6BA0 Offset: 0x1ED6CA1 VA: 0x1ED6BA0
	private void DoEquipItemSlot() { }

	// RVA: 0x1ED6C80 Offset: 0x1ED6D81 VA: 0x1ED6C80
	private void PushSelectSlot() { }

	// RVA: 0x1ED6E40 Offset: 0x1ED6F41 VA: 0x1ED6E40
	public void ReleaseItemSlot() { }

	// RVA: 0x1ED7070 Offset: 0x1ED7171 VA: 0x1ED7070
	public void ReCheckFilterAll() { }

	// RVA: 0x1ED6A80 Offset: 0x1ED6B81 VA: 0x1ED6A80
	public void SetFilterGuardAllItem(UIItemSlot itemSlot) { }

	// RVA: 0x1ED7110 Offset: 0x1ED7211 VA: 0x1ED7110
	public void SetFilterGuardAllItem(UIItemSlotsManager.PickingItem PickingItem) { }

	// RVA: 0x1ED7260 Offset: 0x1ED7361 VA: 0x1ED7260
	private bool CheckTargetSlotNoGuard() { }

	// RVA: 0x1ED72E0 Offset: 0x1ED73E1 VA: 0x1ED72E0
	public void OnClosePage() { }

	// RVA: 0x1ED5280 Offset: 0x1ED5381 VA: 0x1ED5280
	public void PushButton(Key padId) { }

	// RVA: 0x1ED7390 Offset: 0x1ED7491 VA: 0x1ED7390
	public void SetFocusIn(UIItemSlot inslot) { }

	// RVA: 0x1ED4870 Offset: 0x1ED4971 VA: 0x1ED4870
	public void SetFocusOut(UIItemSlot outslot) { }

	// RVA: 0x1ED54A0 Offset: 0x1ED55A1 VA: 0x1ED54A0
	public void FocusingUpdate() { }

	// RVA: 0x1ED73A0 Offset: 0x1ED74A1 VA: 0x1ED73A0
	private void Start() { }

	// RVA: 0x1ED7410 Offset: 0x1ED7511 VA: 0x1ED7410
	public void .ctor() { }
}

