public abstract class OptionsControlBase : SRMonoBehaviourEx // TypeDefIndex: 5584
{
	// Fields
	private bool _selectionModeEnabled; // 0x48
	[RequiredFieldAttribute] // RVA: 0x13C800 Offset: 0x13C901 VA: 0x13C800
	public Toggle SelectionModeToggle; // 0x50
	public OptionDefinition Option; // 0x58

	// Properties
	public bool SelectionModeEnabled { get; set; }
	public bool IsSelected { get; set; }

	// Methods

	// RVA: 0x1546C40 Offset: 0x1546D41 VA: 0x1546C40
	public bool get_SelectionModeEnabled() { }

	// RVA: 0x1546C50 Offset: 0x1546D51 VA: 0x1546C50
	public void set_SelectionModeEnabled(bool value) { }

	// RVA: 0x1546D80 Offset: 0x1546E81 VA: 0x1546D80
	public bool get_IsSelected() { }

	// RVA: 0x1546DA0 Offset: 0x1546EA1 VA: 0x1546DA0
	public void set_IsSelected(bool value) { }

	// RVA: 0x1546EA0 Offset: 0x1546FA1 VA: 0x1546EA0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1546AA0 Offset: 0x1546BA1 VA: 0x1546AA0 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x1546EF0 Offset: 0x1546FF1 VA: 0x1546EF0 Slot: 11
	public virtual void Refresh() { }

	// RVA: 0x15448D0 Offset: 0x15449D1 VA: 0x15448D0
	protected void .ctor() { }
}

