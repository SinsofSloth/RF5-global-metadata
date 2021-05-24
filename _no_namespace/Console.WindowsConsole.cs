private class Console.WindowsConsole // TypeDefIndex: 362
{
	// Fields
	public static bool ctrlHandlerAdded; // 0x0
	private static Console.WindowsConsole.WindowsCancelHandler cancelHandler; // 0x8

	// Methods

	// RVA: 0x2978E10 Offset: 0x2978F11 VA: 0x2978E10
	private static extern int GetConsoleCP() { }

	// RVA: 0x2978E80 Offset: 0x2978F81 VA: 0x2978E80
	private static extern int GetConsoleOutputCP() { }

	// RVA: 0x2978F00 Offset: 0x2979001 VA: 0x2978F00
	private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

	// RVA: 0x2977670 Offset: 0x2977771 VA: 0x2977670
	public static int GetInputCodePage() { }

	// RVA: 0x2977740 Offset: 0x2977841 VA: 0x2977740
	public static int GetOutputCodePage() { }

	// RVA: 0x2978F70 Offset: 0x2979071 VA: 0x2978F70
	private static void .cctor() { }
}

