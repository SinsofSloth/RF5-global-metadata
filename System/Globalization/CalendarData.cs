internal class CalendarData // TypeDefIndex: 703
{
	// Fields
	internal const int MAX_CALENDARS = 23;
	internal string sNativeName; // 0x10
	internal string[] saShortDates; // 0x18
	internal string[] saYearMonths; // 0x20
	internal string[] saLongDates; // 0x28
	internal string sMonthDay; // 0x30
	internal string[] saEraNames; // 0x38
	internal string[] saAbbrevEraNames; // 0x40
	internal string[] saAbbrevEnglishEraNames; // 0x48
	internal string[] saDayNames; // 0x50
	internal string[] saAbbrevDayNames; // 0x58
	internal string[] saSuperShortDayNames; // 0x60
	internal string[] saMonthNames; // 0x68
	internal string[] saAbbrevMonthNames; // 0x70
	internal string[] saMonthGenitiveNames; // 0x78
	internal string[] saAbbrevMonthGenitiveNames; // 0x80
	internal string[] saLeapYearMonthNames; // 0x88
	internal int iTwoDigitYearMax; // 0x90
	internal int iCurrentEra; // 0x94
	internal bool bUseUserOverrides; // 0x98
	internal static CalendarData Invariant; // 0x0

	// Methods

	// RVA: 0x17A1150 Offset: 0x17A1251 VA: 0x17A1150
	private void .ctor() { }

	// RVA: 0x17A1160 Offset: 0x17A1261 VA: 0x17A1160
	private static void .cctor() { }

	// RVA: 0x17A2480 Offset: 0x17A2581 VA: 0x17A2480
	internal void .ctor(string localeName, int calendarId, bool bUseUserOverrides) { }

	// RVA: 0x17A2BE0 Offset: 0x17A2CE1 VA: 0x17A2BE0
	private void InitializeEraNames(string localeName, int calendarId) { }

	// RVA: 0x17A3050 Offset: 0x17A3151 VA: 0x17A3050
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	// RVA: 0x17A0B50 Offset: 0x17A0C51 VA: 0x17A0B50
	internal static CalendarData GetCalendarData(int calendarId) { }

	// RVA: 0x17A33C0 Offset: 0x17A34C1 VA: 0x17A33C0
	private static string CalendarIdToCultureName(int calendarId) { }

	// RVA: 0x17A1140 Offset: 0x17A1241 VA: 0x17A1140
	public static int nativeGetTwoDigitYearMax(int calID) { }

	// RVA: 0x17A2B70 Offset: 0x17A2C71 VA: 0x17A2B70
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	// RVA: 0x17A37B0 Offset: 0x17A38B1 VA: 0x17A37B0
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }
}

