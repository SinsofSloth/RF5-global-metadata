public static class Service // TypeDefIndex: 5658
{
	// Fields
	private static IConsoleService _consoleService; // 0x0
	private static IDebugPanelService _debugPanelService; // 0x8
	private static IDebugTriggerService _debugTriggerService; // 0x10
	private static IPinnedUIService _pinnedUiService; // 0x18
	private static IDebugCameraService _debugCameraService; // 0x20
	private static IOptionsService _optionsService; // 0x28
	private static IDockConsoleService _dockConsoleService; // 0x30

	// Properties
	public static IConsoleService Console { get; }
	public static IDockConsoleService DockConsole { get; }
	public static IDebugPanelService Panel { get; }
	public static IDebugTriggerService Trigger { get; }
	public static IPinnedUIService PinnedUI { get; }
	public static IDebugCameraService DebugCamera { get; }
	public static IOptionsService Options { get; }

	// Methods

	// RVA: 0x152DD00 Offset: 0x152DE01 VA: 0x152DD00
	public static IConsoleService get_Console() { }

	// RVA: 0x15308F0 Offset: 0x15309F1 VA: 0x15308F0
	public static IDockConsoleService get_DockConsole() { }

	// RVA: 0x15309A0 Offset: 0x1530AA1 VA: 0x15309A0
	public static IDebugPanelService get_Panel() { }

	// RVA: 0x1530A50 Offset: 0x1530B51 VA: 0x1530A50
	public static IDebugTriggerService get_Trigger() { }

	// RVA: 0x1530B00 Offset: 0x1530C01 VA: 0x1530B00
	public static IPinnedUIService get_PinnedUI() { }

	// RVA: 0x1530840 Offset: 0x1530941 VA: 0x1530840
	public static IDebugCameraService get_DebugCamera() { }

	// RVA: 0x1530BB0 Offset: 0x1530CB1 VA: 0x1530BB0
	public static IOptionsService get_Options() { }
}

