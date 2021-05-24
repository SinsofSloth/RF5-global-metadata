public class CategoryGroup : SRMonoBehaviourEx // TypeDefIndex: 5561
{
	// Fields
	[RequiredFieldAttribute] // RVA: 0x13C380 Offset: 0x13C481 VA: 0x13C380
	public RectTransform Container; // 0x48
	[RequiredFieldAttribute] // RVA: 0x13C390 Offset: 0x13C491 VA: 0x13C390
	public Text Header; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C3A0 Offset: 0x13C4A1 VA: 0x13C3A0
	public GameObject Background; // 0x58
	[RequiredFieldAttribute] // RVA: 0x13C3B0 Offset: 0x13C4B1 VA: 0x13C3B0
	public Toggle SelectionToggle; // 0x60
	public GameObject[] EnabledDuringSelectionMode; // 0x68
	private bool _selectionModeEnabled; // 0x70

	// Properties
	public bool IsSelected { get; set; }
	public bool SelectionModeEnabled { get; set; }

	// Methods

	// RVA: 0x1B2FEE0 Offset: 0x1B2FFE1 VA: 0x1B2FEE0
	public bool get_IsSelected() { }

	// RVA: 0x1B2FF00 Offset: 0x1B30001 VA: 0x1B2FF00
	public void set_IsSelected(bool value) { }

	// RVA: 0x1B30000 Offset: 0x1B30101 VA: 0x1B30000
	public bool get_SelectionModeEnabled() { }

	// RVA: 0x1B30010 Offset: 0x1B30111 VA: 0x1B30010
	public void set_SelectionModeEnabled(bool value) { }

	// RVA: 0x1B300A0 Offset: 0x1B301A1 VA: 0x1B300A0
	public void .ctor() { }
}

