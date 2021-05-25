internal class DateTimeFormatInfoScanner // TypeDefIndex: 713
{
	// Fields
	internal List<string> m_dateWords; // 0x10
	private static Dictionary<string, string> s_knownWords; // 0x0
	private DateTimeFormatInfoScanner.FoundDatePattern m_ymdFlags; // 0x18

	// Properties
	private static Dictionary<string, string> KnownWords { get; }

	// Methods

	// RVA: 0x17B4010 Offset: 0x17B4111 VA: 0x17B4010
	private static Dictionary<string, string> get_KnownWords() { }

	// RVA: 0x17B4320 Offset: 0x17B4421 VA: 0x17B4320
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

	// RVA: 0x17B4440 Offset: 0x17B4541 VA: 0x17B4440
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	// RVA: 0x17B4740 Offset: 0x17B4841 VA: 0x17B4740
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	// RVA: 0x17B49C0 Offset: 0x17B4AC1 VA: 0x17B49C0
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	// RVA: 0x17B4650 Offset: 0x17B4751 VA: 0x17B4650
	internal void AddIgnorableSymbols(string text) { }

	// RVA: 0x17B4A50 Offset: 0x17B4B51 VA: 0x17B4A50
	internal void ScanDateWord(string pattern) { }

	// RVA: 0x17B3300 Offset: 0x17B3401 VA: 0x17B3300
	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	// RVA: 0x17B0E60 Offset: 0x17B0F61 VA: 0x17B0E60
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x17B0EB0 Offset: 0x17B0FB1 VA: 0x17B0EB0
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x17B0F70 Offset: 0x17B1071 VA: 0x17B0F70
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

	// RVA: 0x17B0FC0 Offset: 0x17B10C1 VA: 0x17B0FC0
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	// RVA: 0x17B4D80 Offset: 0x17B4E81 VA: 0x17B4D80
	private static bool EqualStringArrays(string[] array1, string[] array2) { }

	// RVA: 0x17B50C0 Offset: 0x17B51C1 VA: 0x17B50C0
	private static bool ArrayElementsHaveSpace(string[] array) { }

	// RVA: 0x17B4E40 Offset: 0x17B4F41 VA: 0x17B4E40
	private static bool ArrayElementsBeginWithDigit(string[] array) { }

	// RVA: 0x17B3280 Offset: 0x17B3381 VA: 0x17B3280
	public void .ctor() { }
}

