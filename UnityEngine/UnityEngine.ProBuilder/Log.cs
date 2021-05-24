internal static class Log // TypeDefIndex: 5955
{
	// Fields
	private static Stack<LogLevel> s_logStack; // 0x0
	private static LogLevel s_LogLevel; // 0x8
	private static LogOutput s_Output; // 0xC
	private static string s_LogFilePath; // 0x10

	// Methods

	// RVA: 0x1A93550 Offset: 0x1A93651 VA: 0x1A93550
	public static void Warning(string message) { }

	// RVA: 0x1A93600 Offset: 0x1A93701 VA: 0x1A93600
	private static void DoPrint(string message, LogType type) { }

	// RVA: 0x1A93840 Offset: 0x1A93941 VA: 0x1A93840
	private static void PrintToFile(string message, string path) { }

	// RVA: 0x1A93720 Offset: 0x1A93821 VA: 0x1A93720
	private static void PrintToConsole(string message, LogType type = 3) { }

	// RVA: 0x1A93BB0 Offset: 0x1A93CB1 VA: 0x1A93BB0
	private static void .cctor() { }
}

