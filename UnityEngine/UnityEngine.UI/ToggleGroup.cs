[AddComponentMenu] // RVA: 0x11A7F0 Offset: 0x11A8F1 VA: 0x11A7F0
[DisallowMultipleComponent] // RVA: 0x11A7F0 Offset: 0x11A8F1 VA: 0x11A7F0
public class ToggleGroup : UIBehaviour // TypeDefIndex: 4017
{
	// Fields
	[SerializeField] // RVA: 0x11C9E0 Offset: 0x11CAE1 VA: 0x11C9E0
	private bool m_AllowSwitchOff; // 0x18
	protected List<Toggle> m_Toggles; // 0x20

	// Properties
	public bool allowSwitchOff { get; set; }

	// Methods

	// RVA: 0x1B841D0 Offset: 0x1B842D1 VA: 0x1B841D0
	public bool get_allowSwitchOff() { }

	// RVA: 0x1B841E0 Offset: 0x1B842E1 VA: 0x1B841E0
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x1B841F0 Offset: 0x1B842F1 VA: 0x1B841F0
	protected void .ctor() { }

	// RVA: 0x1B84270 Offset: 0x1B84371 VA: 0x1B84270 Slot: 6
	protected override void Start() { }

	// RVA: 0x1B842A0 Offset: 0x1B843A1 VA: 0x1B842A0
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x1B83C60 Offset: 0x1B83D61 VA: 0x1B83C60
	public void NotifyToggleOn(Toggle toggle, bool sendCallback = True) { }

	// RVA: 0x1B83B20 Offset: 0x1B83C21 VA: 0x1B83B20
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x1B83BC0 Offset: 0x1B83CC1 VA: 0x1B83BC0
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x1B836E0 Offset: 0x1B837E1 VA: 0x1B836E0
	public void EnsureValidState() { }

	// RVA: 0x1B83E50 Offset: 0x1B83F51 VA: 0x1B83E50
	public bool AnyTogglesOn() { }

	// RVA: 0x1B843F0 Offset: 0x1B844F1 VA: 0x1B843F0
	public IEnumerable<Toggle> ActiveToggles() { }

	// RVA: 0x1B84500 Offset: 0x1B84601 VA: 0x1B84500
	public void SetAllTogglesOff(bool sendCallback = True) { }
}

