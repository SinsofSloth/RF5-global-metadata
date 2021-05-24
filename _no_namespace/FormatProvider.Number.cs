private class FormatProvider.Number // TypeDefIndex: 3406
{
	// Fields
	private static string[] s_posCurrencyFormats; // 0x0
	private static string[] s_negCurrencyFormats; // 0x8
	private static string[] s_posPercentFormats; // 0x10
	private static string[] s_negPercentFormats; // 0x18
	private static string[] s_negNumberFormats; // 0x20
	private static string s_posNumberFormat; // 0x28

	// Methods

	// RVA: 0x1BA1620 Offset: 0x1BA1721 VA: 0x1BA1620
	internal static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) { }

	// RVA: 0x1B9FD50 Offset: 0x1B9FE51 VA: 0x1B9FD50
	internal static char ParseFormatSpecifier(string format, out int digits) { }

	// RVA: 0x1B9FE10 Offset: 0x1B9FF11 VA: 0x1B9FE10
	internal static string NumberToString(FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x1BA1780 Offset: 0x1BA1881 VA: 0x1BA1780
	private static void FormatCurrency(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x1BA25F0 Offset: 0x1BA26F1 VA: 0x1BA25F0
	private static int wcslen(char* s) { }

	// RVA: 0x1BA19A0 Offset: 0x1BA1AA1 VA: 0x1BA19A0
	private static void FormatFixed(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x1BA1E60 Offset: 0x1BA1F61 VA: 0x1BA1E60
	private static void FormatNumber(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x1BA20C0 Offset: 0x1BA21C1 VA: 0x1BA20C0
	private static void FormatScientific(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x1BA2610 Offset: 0x1BA2711 VA: 0x1BA2610
	private static void FormatExponent(StringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x1BA2200 Offset: 0x1BA2301 VA: 0x1BA2200
	private static void FormatGeneral(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x1BA23D0 Offset: 0x1BA24D1 VA: 0x1BA23D0
	private static void FormatPercent(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x1BA1680 Offset: 0x1BA1781 VA: 0x1BA1680
	private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos) { }

	// RVA: 0x1BA27A0 Offset: 0x1BA28A1 VA: 0x1BA27A0
	private static int FindSection(string format, int section) { }

	// RVA: 0x1BA0880 Offset: 0x1BA0981 VA: 0x1BA0880
	internal static string NumberToStringFormat(FormatProvider.Number.NumberBuffer number, string format, NumberFormatInfo info) { }

	// RVA: 0x1BA2870 Offset: 0x1BA2971 VA: 0x1BA2870
	private static void .cctor() { }
}

