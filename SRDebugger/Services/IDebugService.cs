public interface IDebugService // TypeDefIndex: 5614
{
	// Properties
	public abstract Settings Settings { get; }
	public abstract bool IsDebugPanelVisible { get; }
	public abstract bool IsTriggerEnabled { get; set; }
	public abstract IDockConsoleService DockConsole { get; }
	public abstract bool IsProfilerDocked { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Settings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsDebugPanelVisible() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsTriggerEnabled() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_IsTriggerEnabled(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IDockConsoleService get_DockConsole() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsProfilerDocked() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_IsProfilerDocked(bool value) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void AddSystemInfo(InfoEntry entry, string category = "Default") { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ShowDebugPanel(bool requireEntryCode = True) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = True) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void HideDebugPanel() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void DestroyDebugPanel() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void AddOptionContainer(object container) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void RemoveOptionContainer(object container) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void PinAllOptions(string category) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void UnpinAllOptions(string category) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void PinOption(string name) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void UnpinOption(string name) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void ClearPinnedOptions() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void ShowBugReportSheet(ActionCompleteCallback onComplete, bool takeScreenshot = True, string descriptionContent) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D040 Offset: 0x13D141 VA: 0x13D040
	// RVA: -1 Offset: -1 Slot: 20
	public abstract void add_PanelVisibilityChanged(VisibilityChangedDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D050 Offset: 0x13D151 VA: 0x13D050
	// RVA: -1 Offset: -1 Slot: 21
	public abstract void remove_PanelVisibilityChanged(VisibilityChangedDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D060 Offset: 0x13D161 VA: 0x13D060
	// RVA: -1 Offset: -1 Slot: 22
	public abstract void add_PinnedUiCanvasCreated(PinnedUiCanvasCreated value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D070 Offset: 0x13D171 VA: 0x13D070
	// RVA: -1 Offset: -1 Slot: 23
	public abstract void remove_PinnedUiCanvasCreated(PinnedUiCanvasCreated value) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract RectTransform EnableWorldSpaceMode() { }
}

