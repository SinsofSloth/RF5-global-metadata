[ServiceAttribute] // RVA: 0x13BA00 Offset: 0x13BB01 VA: 0x13BA00
public class PinnedUIServiceImpl : SRServiceBase<IPinnedUIService>, IPinnedUIService // TypeDefIndex: 5635
{
	// Fields
	private readonly List<OptionsControlBase> _controlList; // 0x48
	private readonly Dictionary<OptionDefinition, OptionsControlBase> _pinnedObjects; // 0x50
	private bool _queueRefresh; // 0x58
	private PinnedUIRoot _uiRoot; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x13CAB0 Offset: 0x13CBB1 VA: 0x13CAB0
	private Action<OptionDefinition, bool> OptionPinStateChanged; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x13CAC0 Offset: 0x13CBC1 VA: 0x13CAC0
	private Action<RectTransform> OptionsCanvasCreated; // 0x70

	// Properties
	public DockConsoleController DockConsoleController { get; }
	public bool IsProfilerPinned { get; set; }

	// Methods

	// RVA: 0x15373E0 Offset: 0x15374E1 VA: 0x15373E0
	public DockConsoleController get_DockConsoleController() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D2D0 Offset: 0x13D3D1 VA: 0x13D2D0
	// RVA: 0x153A770 Offset: 0x153A871 VA: 0x153A770 Slot: 11
	public void add_OptionPinStateChanged(Action<OptionDefinition, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D2E0 Offset: 0x13D3E1 VA: 0x13D2E0
	// RVA: 0x153A820 Offset: 0x153A921 VA: 0x153A820 Slot: 12
	public void remove_OptionPinStateChanged(Action<OptionDefinition, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D2F0 Offset: 0x13D3F1 VA: 0x13D2F0
	// RVA: 0x153A8D0 Offset: 0x153A9D1 VA: 0x153A8D0 Slot: 13
	public void add_OptionsCanvasCreated(Action<RectTransform> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D300 Offset: 0x13D401 VA: 0x13D300
	// RVA: 0x153A980 Offset: 0x153AA81 VA: 0x153A980 Slot: 14
	public void remove_OptionsCanvasCreated(Action<RectTransform> value) { }

	// RVA: 0x153AA30 Offset: 0x153AB31 VA: 0x153AA30 Slot: 15
	public bool get_IsProfilerPinned() { }

	// RVA: 0x153AAD0 Offset: 0x153ABD1 VA: 0x153AAD0 Slot: 16
	public void set_IsProfilerPinned(bool value) { }

	// RVA: 0x153AB80 Offset: 0x153AC81 VA: 0x153AB80 Slot: 17
	public void Pin(OptionDefinition obj, int order = -1) { }

	// RVA: 0x153ADA0 Offset: 0x153AEA1 VA: 0x153ADA0 Slot: 18
	public void Unpin(OptionDefinition obj) { }

	// RVA: 0x153AD20 Offset: 0x153AE21 VA: 0x153AD20
	private void OnPinnedStateChanged(OptionDefinition option, bool isPinned) { }

	// RVA: 0x153AF00 Offset: 0x153B001 VA: 0x153AF00 Slot: 19
	public void UnpinAll() { }

	// RVA: 0x153B080 Offset: 0x153B181 VA: 0x153B080 Slot: 20
	public bool HasPinned(OptionDefinition option) { }

	// RVA: 0x153B0F0 Offset: 0x153B1F1 VA: 0x153B0F0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x153A280 Offset: 0x153A381 VA: 0x153A280
	private void Load() { }

	// RVA: 0x153B1A0 Offset: 0x153B2A1 VA: 0x153B1A0
	private void UpdateAnchors() { }

	// RVA: 0x153B420 Offset: 0x153B521 VA: 0x153B420 Slot: 6
	protected override void Update() { }

	// RVA: 0x153B570 Offset: 0x153B671 VA: 0x153B570
	private void OnOptionsUpdated(object sender, EventArgs eventArgs) { }

	// RVA: 0x153B880 Offset: 0x153B981 VA: 0x153B880
	private void OptionsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) { }

	// RVA: 0x153B890 Offset: 0x153B991 VA: 0x153B890
	private void OnDebugPanelVisibilityChanged(bool isVisible) { }

	// RVA: 0x153B4D0 Offset: 0x153B5D1 VA: 0x153B4D0
	private void Refresh() { }

	// RVA: 0x153B8A0 Offset: 0x153B9A1 VA: 0x153B8A0
	public void .ctor() { }
}

