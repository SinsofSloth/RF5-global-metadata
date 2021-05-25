public class UIEMItemsControl : MonoBehaviour // TypeDefIndex: 8521
{
	// Fields
	[SerializeField] // RVA: 0x170180 Offset: 0x170281 VA: 0x170180
	private UIEMItemslot[] itemslots; // 0x18
	[SerializeField] // RVA: 0x170190 Offset: 0x170291 VA: 0x170190
	private List<ItemDataLinker> itemLists; // 0x20
	private int startNum; // 0x28
	private int focusInPage; // 0x2C
	[SerializeField] // RVA: 0x1701A0 Offset: 0x1702A1 VA: 0x1701A0
	private NonFocusButton L_Button; // 0x30
	[SerializeField] // RVA: 0x1701B0 Offset: 0x1702B1 VA: 0x1701B0
	private NonFocusButton R_Button; // 0x38
	private UIEMMainControl UIEMMainControl; // 0x40

	// Methods

	// RVA: 0x1F0F990 Offset: 0x1F0FA91 VA: 0x1F0F990
	public void SetEvent(int _index) { }

	// RVA: 0x1F0FA90 Offset: 0x1F0FB91 VA: 0x1F0FA90
	private void Start() { }

	// RVA: 0x1F0FB90 Offset: 0x1F0FC91 VA: 0x1F0FB90
	private void SetMyItemSlot() { }

	// RVA: 0x1F0FC20 Offset: 0x1F0FD21 VA: 0x1F0FC20
	private int UpdateItemList(EquipSlotType type) { }

	// RVA: 0x1F0FED0 Offset: 0x1F0FFD1 VA: 0x1F0FED0
	public int SetItemList(EquipSlotType type, UIEMMainControl _UIEMMainControl) { }

	// RVA: 0x1F0FF10 Offset: 0x1F10011 VA: 0x1F0FF10
	private void UpdateItemSlots(int _startNum) { }

	// RVA: 0x1F101E0 Offset: 0x1F102E1 VA: 0x1F101E0
	public int ResetFocusPoint() { }

	// RVA: 0x1F10200 Offset: 0x1F10301 VA: 0x1F10200
	public int RefreshFocusPoint() { }

	// RVA: 0x1F102B0 Offset: 0x1F103B1 VA: 0x1F102B0
	public void UnFocus() { }

	// RVA: 0x1F104F0 Offset: 0x1F105F1 VA: 0x1F104F0
	public void RedrawItems() { }

	// RVA: 0x1F10330 Offset: 0x1F10431 VA: 0x1F10330
	public int FocusItem(int focusNum) { }

	// RVA: 0x1F10550 Offset: 0x1F10651 VA: 0x1F10550
	public int GetItemListCount() { }

	// RVA: 0x1F105A0 Offset: 0x1F106A1 VA: 0x1F105A0
	public UIEMItemslot GetSlot(int focusNum, UIEMMainControl uIEMMainControl) { }

	// RVA: 0x1F10610 Offset: 0x1F10711 VA: 0x1F10610
	public bool EquipItem(int focusNum, UIEMMainControl uIEMMainControl) { }

	// RVA: 0x1F10750 Offset: 0x1F10851 VA: 0x1F10750
	public ItemData GetItemData(int focusNum) { }

	// RVA: 0x1F107F0 Offset: 0x1F108F1 VA: 0x1F107F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7AB0 Offset: 0x1A7BB1 VA: 0x1A7AB0
	// RVA: 0x1F10870 Offset: 0x1F10971 VA: 0x1F10870
	private void <Start>b__8_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7AC0 Offset: 0x1A7BC1 VA: 0x1A7AC0
	// RVA: 0x1F109E0 Offset: 0x1F10AE1 VA: 0x1F109E0
	private void <Start>b__8_1() { }
}

