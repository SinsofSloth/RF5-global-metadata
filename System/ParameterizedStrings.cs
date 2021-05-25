internal static class ParameterizedStrings // TypeDefIndex: 405
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0xB4510 Offset: 0xB4611 VA: 0xB4510
	private static ParameterizedStrings.LowLevelStack _cachedStack; // 0x80000000

	// Methods

	// RVA: 0x18EC780 Offset: 0x18EC881 VA: 0x18EC780
	public static string Evaluate(string format, ParameterizedStrings.FormatParam[] args) { }

	// RVA: 0x18EC8C0 Offset: 0x18EC9C1 VA: 0x18EC8C0
	private static string EvaluateInternal(string format, ref int pos, ParameterizedStrings.FormatParam[] args, ParameterizedStrings.LowLevelStack stack, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars) { }

	// RVA: 0x18ED6C0 Offset: 0x18ED7C1 VA: 0x18ED6C0
	private static bool AsBool(int i) { }

	// RVA: 0x18ED6B0 Offset: 0x18ED7B1 VA: 0x18ED6B0
	private static int AsInt(bool b) { }

	// RVA: 0x18ED6D0 Offset: 0x18ED7D1 VA: 0x18ED6D0
	private static string StringFromAsciiBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x18ED7E0 Offset: 0x18ED8E1 VA: 0x18ED7E0
	private static extern int snprintf(byte* str, IntPtr size, string format, string arg1) { }

	// RVA: 0x18ED8C0 Offset: 0x18ED9C1 VA: 0x18ED8C0
	private static extern int snprintf(byte* str, IntPtr size, string format, int arg1) { }

	// RVA: 0x18ED1B0 Offset: 0x18ED2B1 VA: 0x18ED1B0
	private static string FormatPrintF(string format, object arg) { }

	// RVA: 0x18ED580 Offset: 0x18ED681 VA: 0x18ED580
	private static ParameterizedStrings.FormatParam[] GetDynamicOrStaticVariables(char c, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars, out int index) { }
}

