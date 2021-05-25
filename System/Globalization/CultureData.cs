internal class CultureData // TypeDefIndex: 737
{
	// Fields
	private string sAM1159; // 0x10
	private string sPM2359; // 0x18
	private string sTimeSeparator; // 0x20
	private string[] saLongTimes; // 0x28
	private string[] saShortTimes; // 0x30
	private int iFirstDayOfWeek; // 0x38
	private int iFirstWeekOfYear; // 0x3C
	private int[] waCalendars; // 0x40
	private CalendarData[] calendars; // 0x48
	private string sISO639Language; // 0x50
	private readonly string sRealName; // 0x58
	private bool bUseOverrides; // 0x60
	private int calendarId; // 0x64
	private int numberIndex; // 0x68
	private int iDefaultAnsiCodePage; // 0x6C
	private int iDefaultOemCodePage; // 0x70
	private int iDefaultMacCodePage; // 0x74
	private int iDefaultEbcdicCodePage; // 0x78
	private bool isRightToLeft; // 0x7C
	private string sListSeparator; // 0x80
	private static CultureData s_Invariant; // 0x0

	// Properties
	public static CultureData Invariant { get; }
	internal string[] LongTimes { get; }
	internal string[] ShortTimes { get; }
	internal string SISO639LANGNAME { get; }
	internal int IFIRSTDAYOFWEEK { get; }
	internal int IFIRSTWEEKOFYEAR { get; }
	internal string SAM1159 { get; }
	internal string SPM2359 { get; }
	internal string TimeSeparator { get; }
	internal int[] CalendarIds { get; }
	internal bool IsInvariantCulture { get; }
	internal string CultureName { get; }
	internal string SCOMPAREINFO { get; }
	internal string STEXTINFO { get; }
	internal int ILANGUAGE { get; }
	internal bool UseUserOverride { get; }

	// Methods

	// RVA: 0x17A62B0 Offset: 0x17A63B1 VA: 0x17A62B0
	private void .ctor(string name) { }

	// RVA: 0x17A62F0 Offset: 0x17A63F1 VA: 0x17A62F0
	public static CultureData get_Invariant() { }

	// RVA: 0x17A6710 Offset: 0x17A6811 VA: 0x17A6710
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	// RVA: 0x17A6820 Offset: 0x17A6921 VA: 0x17A6820
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	// RVA: 0x17A6990 Offset: 0x17A6A91 VA: 0x17A6990
	internal static CultureData GetCultureData(int culture, bool bUseUserOverride) { }

	// RVA: 0x17A6980 Offset: 0x17A6A81 VA: 0x17A6980
	private void fill_culture_data(int datetimeIndex) { }

	// RVA: 0x17A3670 Offset: 0x17A3771 VA: 0x17A3670
	public CalendarData GetCalendar(int calendarId) { }

	// RVA: 0x17A69A0 Offset: 0x17A6AA1 VA: 0x17A69A0
	internal string[] get_LongTimes() { }

	// RVA: 0x17A69D0 Offset: 0x17A6AD1 VA: 0x17A69D0
	internal string[] get_ShortTimes() { }

	// RVA: 0x17A6A00 Offset: 0x17A6B01 VA: 0x17A6A00
	internal string get_SISO639LANGNAME() { }

	// RVA: 0x17A6A10 Offset: 0x17A6B11 VA: 0x17A6A10
	internal int get_IFIRSTDAYOFWEEK() { }

	// RVA: 0x17A6A20 Offset: 0x17A6B21 VA: 0x17A6A20
	internal int get_IFIRSTWEEKOFYEAR() { }

	// RVA: 0x17A6A30 Offset: 0x17A6B31 VA: 0x17A6A30
	internal string get_SAM1159() { }

	// RVA: 0x17A6A40 Offset: 0x17A6B41 VA: 0x17A6A40
	internal string get_SPM2359() { }

	// RVA: 0x17A6A50 Offset: 0x17A6B51 VA: 0x17A6A50
	internal string get_TimeSeparator() { }

	// RVA: 0x17A6A60 Offset: 0x17A6B61 VA: 0x17A6A60
	internal int[] get_CalendarIds() { }

	// RVA: 0x17A6BD0 Offset: 0x17A6CD1 VA: 0x17A6BD0
	internal bool get_IsInvariantCulture() { }

	// RVA: 0x17A6BE0 Offset: 0x17A6CE1 VA: 0x17A6BE0
	internal string get_CultureName() { }

	// RVA: 0x17A6BF0 Offset: 0x17A6CF1 VA: 0x17A6BF0
	internal string get_SCOMPAREINFO() { }

	// RVA: 0x17A6C40 Offset: 0x17A6D41 VA: 0x17A6C40
	internal string get_STEXTINFO() { }

	// RVA: 0x17A6C50 Offset: 0x17A6D51 VA: 0x17A6C50
	internal int get_ILANGUAGE() { }

	// RVA: 0x17A6C60 Offset: 0x17A6D61 VA: 0x17A6C60
	internal bool get_UseUserOverride() { }

	// RVA: 0x17A6C70 Offset: 0x17A6D71 VA: 0x17A6C70
	internal string[] EraNames(int calendarId) { }

	// RVA: 0x17A6C90 Offset: 0x17A6D91 VA: 0x17A6C90
	internal string[] AbbrevEraNames(int calendarId) { }

	// RVA: 0x17A6CB0 Offset: 0x17A6DB1 VA: 0x17A6CB0
	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	// RVA: 0x17A6CD0 Offset: 0x17A6DD1 VA: 0x17A6CD0
	internal string[] ShortDates(int calendarId) { }

	// RVA: 0x17A6CF0 Offset: 0x17A6DF1 VA: 0x17A6CF0
	internal string[] LongDates(int calendarId) { }

	// RVA: 0x17A6D10 Offset: 0x17A6E11 VA: 0x17A6D10
	internal string[] YearMonths(int calendarId) { }

	// RVA: 0x17A6D30 Offset: 0x17A6E31 VA: 0x17A6D30
	internal string[] DayNames(int calendarId) { }

	// RVA: 0x17A6D50 Offset: 0x17A6E51 VA: 0x17A6D50
	internal string[] AbbreviatedDayNames(int calendarId) { }

	// RVA: 0x17A6D70 Offset: 0x17A6E71 VA: 0x17A6D70
	internal string[] MonthNames(int calendarId) { }

	// RVA: 0x17A6D90 Offset: 0x17A6E91 VA: 0x17A6D90
	internal string[] GenitiveMonthNames(int calendarId) { }

	// RVA: 0x17A6DB0 Offset: 0x17A6EB1 VA: 0x17A6DB0
	internal string[] AbbreviatedMonthNames(int calendarId) { }

	// RVA: 0x17A6DD0 Offset: 0x17A6ED1 VA: 0x17A6DD0
	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	// RVA: 0x17A6DF0 Offset: 0x17A6EF1 VA: 0x17A6DF0
	internal string[] LeapYearMonthNames(int calendarId) { }

	// RVA: 0x17A6E10 Offset: 0x17A6F11 VA: 0x17A6E10
	internal string MonthDay(int calendarId) { }

	// RVA: 0x17A6E30 Offset: 0x17A6F31 VA: 0x17A6E30
	internal string DateSeparator(int calendarId) { }

	// RVA: 0x17A6EB0 Offset: 0x17A6FB1 VA: 0x17A6EB0
	private static string GetDateSeparator(string format) { }

	// RVA: 0x17A6F00 Offset: 0x17A7001 VA: 0x17A6F00
	private static string GetSeparator(string format, string timeParts) { }

	// RVA: 0x17A7010 Offset: 0x17A7111 VA: 0x17A7010
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	// RVA: 0x17A7150 Offset: 0x17A7251 VA: 0x17A7150
	private static string UnescapeNlsString(string str, int start, int end) { }

	// RVA: 0x17A2BC0 Offset: 0x17A2CC1 VA: 0x17A2BC0
	internal static string[] ReescapeWin32Strings(string[] array) { }

	// RVA: 0x17A2BD0 Offset: 0x17A2CD1 VA: 0x17A2BD0
	internal static string ReescapeWin32String(string str) { }

	// RVA: 0x17A7330 Offset: 0x17A7431 VA: 0x17A7330
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	// RVA: 0x17A73B0 Offset: 0x17A74B1 VA: 0x17A73B0
	private static void fill_number_data(NumberFormatInfo nfi, int numberIndex) { }
}

