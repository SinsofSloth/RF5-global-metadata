[ServiceAttribute] // RVA: 0x13B760 Offset: 0x13B861 VA: 0x13B760
public class DebugPanelServiceImpl : ScriptableObject, IDebugPanelService // TypeDefIndex: 5629
{
	// Fields
	private DebugPanelRoot _debugPanelRootObject; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x13CA80 Offset: 0x13CB81 VA: 0x13CA80
	private Action<IDebugPanelService, bool> VisibilityChanged; // 0x20
	private bool _isVisible; // 0x28
	private Nullable<bool> _cursorWasVisible; // 0x29
	private Nullable<CursorLockMode> _cursorLockMode; // 0x2C

	// Properties
	public DebugPanelRoot RootObject { get; }
	public bool IsLoaded { get; }
	public bool IsVisible { get; set; }
	public Nullable<DefaultTabs> ActiveTab { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x13D260 Offset: 0x13D361 VA: 0x13D260
	// RVA: 0x1535490 Offset: 0x1535591 VA: 0x1535490 Slot: 8
	public void add_VisibilityChanged(Action<IDebugPanelService, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D270 Offset: 0x13D371 VA: 0x13D270
	// RVA: 0x1535540 Offset: 0x1535641 VA: 0x1535540 Slot: 9
	public void remove_VisibilityChanged(Action<IDebugPanelService, bool> value) { }

	// RVA: 0x15355F0 Offset: 0x15356F1 VA: 0x15355F0
	public DebugPanelRoot get_RootObject() { }

	// RVA: 0x1535600 Offset: 0x1535701 VA: 0x1535600 Slot: 4
	public bool get_IsLoaded() { }

	// RVA: 0x1535670 Offset: 0x1535771 VA: 0x1535670 Slot: 5
	public bool get_IsVisible() { }

	// RVA: 0x1535710 Offset: 0x1535811 VA: 0x1535710 Slot: 6
	public void set_IsVisible(bool value) { }

	// RVA: 0x1535B60 Offset: 0x1535C61 VA: 0x1535B60 Slot: 7
	public Nullable<DefaultTabs> get_ActiveTab() { }

	// RVA: 0x1535C00 Offset: 0x1535D01 VA: 0x1535C00 Slot: 11
	public void OpenTab(DefaultTabs tab) { }

	// RVA: 0x1535CB0 Offset: 0x1535DB1 VA: 0x1535CB0 Slot: 10
	public void Unload() { }

	// RVA: 0x15359B0 Offset: 0x1535AB1 VA: 0x15359B0
	private void Load() { }

	// RVA: 0x1535DC0 Offset: 0x1535EC1 VA: 0x1535DC0
	public void .ctor() { }
}

