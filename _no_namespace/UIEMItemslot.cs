public class UIEMItemslot : MonoBehaviour // TypeDefIndex: 8523
{
	// Fields
	[SerializeField] // RVA: 0x1701C0 Offset: 0x1702C1 VA: 0x1701C0
	private Image ItemImage; // 0x18
	[SerializeField] // RVA: 0x1701D0 Offset: 0x1702D1 VA: 0x1701D0
	private ItemIconLoader ItemIconLoader; // 0x20
	[SerializeField] // RVA: 0x1701E0 Offset: 0x1702E1 VA: 0x1701E0
	private Image FocusImage; // 0x28
	[SerializeField] // RVA: 0x1701F0 Offset: 0x1702F1 VA: 0x1701F0
	private Image ItemCountImage; // 0x30
	[SerializeField] // RVA: 0x170200 Offset: 0x170301 VA: 0x170200
	private Sprite[] ItemCountSprite; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x170210 Offset: 0x170311 VA: 0x170210
	private ItemDataLinker <itemDataLinker>k__BackingField; // 0x40
	private UnityAction touchAction; // 0x48

	// Properties
	public ItemDataLinker itemDataLinker { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7AD0 Offset: 0x1A7BD1 VA: 0x1A7AD0
	// RVA: 0x1F10CF0 Offset: 0x1F10DF1 VA: 0x1F10CF0
	public ItemDataLinker get_itemDataLinker() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7AE0 Offset: 0x1A7BE1 VA: 0x1A7AE0
	// RVA: 0x1F10D00 Offset: 0x1F10E01 VA: 0x1F10D00
	private void set_itemDataLinker(ItemDataLinker value) { }

	// RVA: 0x1F10D10 Offset: 0x1F10E11 VA: 0x1F10D10
	private void Awake() { }

	// RVA: 0x1F10E30 Offset: 0x1F10F31 VA: 0x1F10E30
	public void SetEvent(UnityAction _action) { }

	// RVA: 0x1F10E40 Offset: 0x1F10F41 VA: 0x1F10E40
	private void OnTouch() { }

	// RVA: 0x1F10E60 Offset: 0x1F10F61 VA: 0x1F10E60
	private bool HoldUpItem(UIEMMainControl UIEMMainControl) { }

	// RVA: 0x1F10690 Offset: 0x1F10791 VA: 0x1F10690
	public bool EquipItem(UIEMMainControl UIEMMainControl) { }

	// RVA: 0x1F10010 Offset: 0x1F10111 VA: 0x1F10010
	public void SetItem(ItemDataLinker _itemDataLinker) { }

	// RVA: 0x1F10500 Offset: 0x1F10601 VA: 0x1F10500
	public void Focus() { }

	// RVA: 0x1F104A0 Offset: 0x1F105A1 VA: 0x1F104A0
	public void UnFocus() { }

	// RVA: 0x1F10FE0 Offset: 0x1F110E1 VA: 0x1F10FE0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7AF0 Offset: 0x1A7BF1 VA: 0x1A7AF0
	// RVA: 0x1F11050 Offset: 0x1F11151 VA: 0x1F11050
	private void <Awake>b__10_0(BaseEventData _data) { }
}

