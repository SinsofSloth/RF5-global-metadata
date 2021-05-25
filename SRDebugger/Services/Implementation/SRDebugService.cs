[ServiceAttribute] // RVA: 0x13BA70 Offset: 0x13BB71 VA: 0x13BA70
public class SRDebugService : IDebugService // TypeDefIndex: 5636
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13CAD0 Offset: 0x13CBD1 VA: 0x13CAD0
	private VisibilityChangedDelegate PanelVisibilityChanged; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x13CAE0 Offset: 0x13CBE1 VA: 0x13CAE0
	private PinnedUiCanvasCreated PinnedUiCanvasCreated; // 0x18
	private readonly IDebugPanelService _debugPanelService; // 0x20
	private readonly IDebugTriggerService _debugTrigger; // 0x28
	private readonly ISystemInformationService _informationService; // 0x30
	private readonly IOptionsService _optionsService; // 0x38
	private readonly IPinnedUIService _pinnedUiService; // 0x40
	private bool _entryCodeEnabled; // 0x48
	private bool _hasAuthorised; // 0x49
	private Nullable<DefaultTabs> _queuedTab; // 0x4C
	private RectTransform _worldSpaceTransform; // 0x58

	// Properties
	public IDockConsoleService DockConsole { get; }
	public Settings Settings { get; }
	public bool IsDebugPanelVisible { get; }
	public bool IsTriggerEnabled { get; set; }
	public bool IsProfilerDocked { get; set; }

	// Methods

	// RVA: 0x153B960 Offset: 0x153BA61 VA: 0x153B960 Slot: 8
	public IDockConsoleService get_DockConsole() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D310 Offset: 0x13D411 VA: 0x13D310
	// RVA: 0x153BA10 Offset: 0x153BB11 VA: 0x153BA10 Slot: 24
	public void add_PanelVisibilityChanged(VisibilityChangedDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D320 Offset: 0x13D421 VA: 0x13D320
	// RVA: 0x153BAC0 Offset: 0x153BBC1 VA: 0x153BAC0 Slot: 25
	public void remove_PanelVisibilityChanged(VisibilityChangedDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D330 Offset: 0x13D431 VA: 0x13D330
	// RVA: 0x153BB70 Offset: 0x153BC71 VA: 0x153BB70 Slot: 26
	public void add_PinnedUiCanvasCreated(PinnedUiCanvasCreated value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D340 Offset: 0x13D441 VA: 0x13D340
	// RVA: 0x153BC20 Offset: 0x153BD21 VA: 0x153BC20 Slot: 27
	public void remove_PinnedUiCanvasCreated(PinnedUiCanvasCreated value) { }

	// RVA: 0x153BCD0 Offset: 0x153BDD1 VA: 0x153BCD0
	public void .ctor() { }

	// RVA: 0x153C3B0 Offset: 0x153C4B1 VA: 0x153C3B0 Slot: 4
	public Settings get_Settings() { }

	// RVA: 0x153C430 Offset: 0x153C531 VA: 0x153C430 Slot: 5
	public bool get_IsDebugPanelVisible() { }

	// RVA: 0x153C4F0 Offset: 0x153C5F1 VA: 0x153C4F0 Slot: 6
	public bool get_IsTriggerEnabled() { }

	// RVA: 0x153C5A0 Offset: 0x153C6A1 VA: 0x153C5A0 Slot: 7
	public void set_IsTriggerEnabled(bool value) { }

	// RVA: 0x153C670 Offset: 0x153C771 VA: 0x153C670 Slot: 9
	public bool get_IsProfilerDocked() { }

	// RVA: 0x153C7B0 Offset: 0x153C8B1 VA: 0x153C7B0 Slot: 10
	public void set_IsProfilerDocked(bool value) { }

	// RVA: 0x153C900 Offset: 0x153CA01 VA: 0x153C900 Slot: 11
	public void AddSystemInfo(InfoEntry entry, string category = "Default") { }

	// RVA: 0x153C9D0 Offset: 0x153CAD1 VA: 0x153C9D0 Slot: 12
	public void ShowDebugPanel(bool requireEntryCode = True) { }

	// RVA: 0x153CC90 Offset: 0x153CD91 VA: 0x153CC90 Slot: 13
	public void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = True) { }

	// RVA: 0x153CE30 Offset: 0x153CF31 VA: 0x153CE30 Slot: 14
	public void HideDebugPanel() { }

	// RVA: 0x153CEF0 Offset: 0x153CFF1 VA: 0x153CEF0 Slot: 15
	public void DestroyDebugPanel() { }

	// RVA: 0x153D020 Offset: 0x153D121 VA: 0x153D020 Slot: 16
	public void AddOptionContainer(object container) { }

	// RVA: 0x153D0F0 Offset: 0x153D1F1 VA: 0x153D0F0 Slot: 17
	public void RemoveOptionContainer(object container) { }

	// RVA: 0x153D1C0 Offset: 0x153D2C1 VA: 0x153D1C0 Slot: 18
	public void PinAllOptions(string category) { }

	// RVA: 0x153D590 Offset: 0x153D691 VA: 0x153D590 Slot: 19
	public void UnpinAllOptions(string category) { }

	// RVA: 0x153D950 Offset: 0x153DA51 VA: 0x153D950 Slot: 20
	public void PinOption(string name) { }

	// RVA: 0x153DD20 Offset: 0x153DE21 VA: 0x153DD20 Slot: 21
	public void UnpinOption(string name) { }

	// RVA: 0x153E0E0 Offset: 0x153E1E1 VA: 0x153E0E0 Slot: 22
	public void ClearPinnedOptions() { }

	// RVA: 0x153E1A0 Offset: 0x153E2A1 VA: 0x153E1A0 Slot: 23
	public void ShowBugReportSheet(ActionCompleteCallback onComplete, bool takeScreenshot = True, string descriptionContent) { }

	// RVA: 0x153E2E0 Offset: 0x153E3E1 VA: 0x153E2E0
	private void DebugPanelServiceOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) { }

	// RVA: 0x153CAC0 Offset: 0x153CBC1 VA: 0x153CAC0
	private void PromptEntryCode() { }

	// RVA: 0x153E420 Offset: 0x153E521 VA: 0x153E420 Slot: 28
	public RectTransform EnableWorldSpaceMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D350 Offset: 0x13D451 VA: 0x13D350
	// RVA: 0x153E6B0 Offset: 0x153E7B1 VA: 0x153E6B0
	private void <.ctor>b__17_0(RectTransform transform) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D360 Offset: 0x13D461 VA: 0x13D360
	// RVA: 0x153E7B0 Offset: 0x153E8B1 VA: 0x153E7B0
	private void <PromptEntryCode>b__42_0(bool entered) { }
}

