internal static class ConsoleDriver // TypeDefIndex: 365
{
	// Fields
	internal static IConsoleDriver driver; // 0x0
	private static bool is_console; // 0x8
	private static bool called_isatty; // 0x9

	// Properties
	public static bool IsConsole { get; }

	// Methods

	// RVA: 0x2979450 Offset: 0x2979551 VA: 0x2979450
	private static void .cctor() { }

	// RVA: 0x2979520 Offset: 0x2979621 VA: 0x2979520
	private static IConsoleDriver CreateNullConsoleDriver() { }

	// RVA: 0x2979580 Offset: 0x2979681 VA: 0x2979580
	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	// RVA: 0x29795E0 Offset: 0x29796E1 VA: 0x29795E0
	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	// RVA: 0x29783A0 Offset: 0x29784A1 VA: 0x29783A0
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x2977BD0 Offset: 0x2977CD1 VA: 0x2977BD0
	public static bool get_IsConsole() { }

	// RVA: 0x2979650 Offset: 0x2979751 VA: 0x2979650
	private static bool Isatty(IntPtr handle) { }

	// RVA: 0x2979660 Offset: 0x2979761 VA: 0x2979660
	internal static int InternalKeyAvailable(int ms_timeout) { }

	// RVA: 0x2979670 Offset: 0x2979771 VA: 0x2979670
	internal static bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address) { }

	// RVA: 0x2979680 Offset: 0x2979781 VA: 0x2979680
	internal static bool SetEcho(bool wantEcho) { }
}

