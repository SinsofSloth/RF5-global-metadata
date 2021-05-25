internal static class DateTimeFormat // TypeDefIndex: 235
{
	// Fields
	internal static readonly TimeSpan NullOffset; // 0x0
	internal static char[] allStandardFormats; // 0x8
	internal static string[] fixedNumberFormats; // 0x10

	// Methods

	// RVA: 0x2988610 Offset: 0x2988711 VA: 0x2988610
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) { }

	// RVA: 0x2988740 Offset: 0x2988841 VA: 0x2988740
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) { }

	// RVA: 0x2988820 Offset: 0x2988921 VA: 0x2988820
	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) { }

	// RVA: 0x29888B0 Offset: 0x29889B1 VA: 0x29888B0
	internal static int ParseRepeatPattern(string format, int pos, char patternChar) { }

	// RVA: 0x2988930 Offset: 0x2988A31 VA: 0x2988930
	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2988970 Offset: 0x2988A71 VA: 0x2988970
	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x29889B0 Offset: 0x2988AB1 VA: 0x29889B0
	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2988A80 Offset: 0x2988B81 VA: 0x2988A80
	internal static int ParseQuoteString(string format, int pos, StringBuilder result) { }

	// RVA: 0x2988C80 Offset: 0x2988D81 VA: 0x2988C80
	internal static int ParseNextChar(string format, int pos) { }

	// RVA: 0x2988CD0 Offset: 0x2988DD1 VA: 0x2988CD0
	private static bool IsUseGenitiveForm(string format, int index, int tokenLen, char patternToMatch) { }

	// RVA: 0x2988E20 Offset: 0x2988F21 VA: 0x2988E20
	private static string FormatCustomized(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x2989EE0 Offset: 0x2989FE1 VA: 0x2989EE0
	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, string format, int tokenLen, bool timeOnly, StringBuilder result) { }

	// RVA: 0x298A290 Offset: 0x298A391 VA: 0x298A290
	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) { }

	// RVA: 0x298A4C0 Offset: 0x298A5C1 VA: 0x298A4C0
	internal static string GetRealFormat(string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x298A770 Offset: 0x298A871 VA: 0x298A770
	private static string ExpandPredefinedFormat(string format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) { }

	// RVA: 0x2986EB0 Offset: 0x2986FB1 VA: 0x2986EB0
	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x298ABE0 Offset: 0x298ACE1 VA: 0x298ABE0
	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x298ABD0 Offset: 0x298ACD1 VA: 0x298ABD0
	internal static void InvalidFormatForLocal(string format, DateTime dateTime) { }

	// RVA: 0x298A4B0 Offset: 0x298A5B1 VA: 0x298A4B0
	internal static void InvalidFormatForUtc(string format, DateTime dateTime) { }

	// RVA: 0x298AE20 Offset: 0x298AF21 VA: 0x298AE20
	private static void .cctor() { }
}

