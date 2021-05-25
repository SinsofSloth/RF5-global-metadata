public class UIEMEquipItemSlot : MonoBehaviour // TypeDefIndex: 8518
{
	// Fields
	private EquipSlotType EquipSlotType; // 0x18
	private UIEMMainControl UIEMMainControl; // 0x20
	[SerializeField] // RVA: 0x1700C0 Offset: 0x1701C1 VA: 0x1700C0
	private ItemIconLoader ItemIconLoader; // 0x28
	[SerializeField] // RVA: 0x1700D0 Offset: 0x1701D1 VA: 0x1700D0
	private Image FocusImage; // 0x30
	[SerializeField] // RVA: 0x1700E0 Offset: 0x1701E1 VA: 0x1700E0
	private Image ItemCountImage; // 0x38
	[SerializeField] // RVA: 0x1700F0 Offset: 0x1701F1 VA: 0x1700F0
	private Sprite[] ItemCountSprite; // 0x40
	private UnityAction touchAction; // 0x48

	// Methods

	// RVA: 0x1F0E4B0 Offset: 0x1F0E5B1 VA: 0x1F0E4B0
	private void Awake() { }

	// RVA: 0x1F0E5D0 Offset: 0x1F0E6D1 VA: 0x1F0E5D0
	public void SetEvent(UnityAction _action) { }

	// RVA: 0x1F0E5E0 Offset: 0x1F0E6E1 VA: 0x1F0E5E0
	private void OnTouch() { }

	// RVA: 0x1F0E600 Offset: 0x1F0E701 VA: 0x1F0E600
	public void SetSlotType(EquipSlotType _EquipSlotType, UIEMMainControl _UIEMMainControl) { }

	// RVA: 0x1F0E660 Offset: 0x1F0E761 VA: 0x1F0E660
	public ItemData GetItemData() { }

	// RVA: 0x1F0E630 Offset: 0x1F0E731 VA: 0x1F0E630
	public void SetItem(EquipSlotType _EquipSlotType, UIEMMainControl _UIEMMainControl) { }

	// RVA: 0x1F0E6C0 Offset: 0x1F0E7C1 VA: 0x1F0E6C0
	public void DrawItem() { }

	// RVA: 0x1F0E820 Offset: 0x1F0E921 VA: 0x1F0E820
	public void Focus() { }

	// RVA: 0x1F0E870 Offset: 0x1F0E971 VA: 0x1F0E870
	public void UnFocus() { }

	// RVA: 0x1F0E8C0 Offset: 0x1F0E9C1 VA: 0x1F0E8C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7AA0 Offset: 0x1A7BA1 VA: 0x1A7AA0
	// RVA: 0x1F0E930 Offset: 0x1F0EA31 VA: 0x1F0E930
	private void <Awake>b__7_0(BaseEventData _data) { }
}

