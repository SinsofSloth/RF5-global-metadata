[ComVisibleAttribute] // RVA: 0xAEDA0 Offset: 0xAEEA1 VA: 0xAEDA0
[Serializable]
public sealed class DateTimeFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 709
{
	// Fields
	private static DateTimeFormatInfo invariantInfo; // 0x0
	private CultureData m_cultureData; // 0x10
	[OptionalFieldAttribute] // RVA: 0xB49A0 Offset: 0xB4AA1 VA: 0xB49A0
	internal string m_name; // 0x18
	private string m_langName; // 0x20
	private CompareInfo m_compareInfo; // 0x28
	private CultureInfo m_cultureInfo; // 0x30
	internal string amDesignator; // 0x38
	internal string pmDesignator; // 0x40
	[OptionalFieldAttribute] // RVA: 0xB49E0 Offset: 0xB4AE1 VA: 0xB49E0
	internal string dateSeparator; // 0x48
	[OptionalFieldAttribute] // RVA: 0xB4A20 Offset: 0xB4B21 VA: 0xB4A20
	internal string generalShortTimePattern; // 0x50
	[OptionalFieldAttribute] // RVA: 0xB4A60 Offset: 0xB4B61 VA: 0xB4A60
	internal string generalLongTimePattern; // 0x58
	[OptionalFieldAttribute] // RVA: 0xB4AA0 Offset: 0xB4BA1 VA: 0xB4AA0
	internal string timeSeparator; // 0x60
	internal string monthDayPattern; // 0x68
	[OptionalFieldAttribute] // RVA: 0xB4AE0 Offset: 0xB4BE1 VA: 0xB4AE0
	internal string dateTimeOffsetPattern; // 0x70
	internal const string rfc1123Pattern = "ddd, dd MMM yyyy HH\':\'mm\':\'ss \'GMT\'";
	internal const string sortableDateTimePattern = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss";
	internal const string universalSortableDateTimePattern = "yyyy\'-\'MM\'-\'dd HH\':\'mm\':\'ss\'Z\'";
	internal Calendar calendar; // 0x78
	internal int firstDayOfWeek; // 0x80
	internal int calendarWeekRule; // 0x84
	[OptionalFieldAttribute] // RVA: 0xB4B20 Offset: 0xB4C21 VA: 0xB4B20
	internal string fullDateTimePattern; // 0x88
	internal string[] abbreviatedDayNames; // 0x90
	[OptionalFieldAttribute] // RVA: 0xB4B60 Offset: 0xB4C61 VA: 0xB4B60
	internal string[] m_superShortDayNames; // 0x98
	internal string[] dayNames; // 0xA0
	internal string[] abbreviatedMonthNames; // 0xA8
	internal string[] monthNames; // 0xB0
	[OptionalFieldAttribute] // RVA: 0xB4BA0 Offset: 0xB4CA1 VA: 0xB4BA0
	internal string[] genitiveMonthNames; // 0xB8
	[OptionalFieldAttribute] // RVA: 0xB4BE0 Offset: 0xB4CE1 VA: 0xB4BE0
	internal string[] m_genitiveAbbreviatedMonthNames; // 0xC0
	[OptionalFieldAttribute] // RVA: 0xB4C20 Offset: 0xB4D21 VA: 0xB4C20
	internal string[] leapYearMonthNames; // 0xC8
	internal string longDatePattern; // 0xD0
	internal string shortDatePattern; // 0xD8
	internal string yearMonthPattern; // 0xE0
	internal string longTimePattern; // 0xE8
	internal string shortTimePattern; // 0xF0
	[OptionalFieldAttribute] // RVA: 0xB4C60 Offset: 0xB4D61 VA: 0xB4C60
	private string[] allYearMonthPatterns; // 0xF8
	internal string[] allShortDatePatterns; // 0x100
	internal string[] allLongDatePatterns; // 0x108
	internal string[] allShortTimePatterns; // 0x110
	internal string[] allLongTimePatterns; // 0x118
	internal string[] m_eraNames; // 0x120
	internal string[] m_abbrevEraNames; // 0x128
	internal string[] m_abbrevEnglishEraNames; // 0x130
	internal int[] optionalCalendars; // 0x138
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132;
	internal bool m_isReadOnly; // 0x140
	[OptionalFieldAttribute] // RVA: 0xB4CA0 Offset: 0xB4DA1 VA: 0xB4CA0
	internal DateTimeFormatFlags formatFlags; // 0x144
	internal static bool preferExistingTokens; // 0x8
	[OptionalFieldAttribute] // RVA: 0xB4CE0 Offset: 0xB4DE1 VA: 0xB4CE0
	private int CultureID; // 0x148
	[OptionalFieldAttribute] // RVA: 0xB4D20 Offset: 0xB4E21 VA: 0xB4D20
	private bool m_useUserOverride; // 0x14C
	[OptionalFieldAttribute] // RVA: 0xB4D60 Offset: 0xB4E61 VA: 0xB4D60
	private bool bUseCalendarInfo; // 0x14D
	[OptionalFieldAttribute] // RVA: 0xB4DA0 Offset: 0xB4EA1 VA: 0xB4DA0
	private int nDataItem; // 0x150
	[OptionalFieldAttribute] // RVA: 0xB4DE0 Offset: 0xB4EE1 VA: 0xB4DE0
	internal bool m_isDefaultCalendar; // 0x154
	[OptionalFieldAttribute] // RVA: 0xB4E20 Offset: 0xB4F21 VA: 0xB4E20
	private static Hashtable s_calendarNativeNames; // 0x10
	[OptionalFieldAttribute] // RVA: 0xB4E60 Offset: 0xB4F61 VA: 0xB4E60
	internal string[] m_dateWords; // 0x158
	private string m_fullTimeSpanPositivePattern; // 0x160
	private string m_fullTimeSpanNegativePattern; // 0x168
	internal const DateTimeStyles InvalidDateTimeStyles = -256;
	private TokenHashValue[] m_dtfiTokenHash; // 0x170
	private const int TOKEN_HASH_SIZE = 199;
	private const int SECOND_PRIME = 197;
	private const string dateSeparatorOrTimeZoneOffset = "-";
	private const string invariantDateSeparator = "/";
	private const string invariantTimeSeparator = ":";
	internal const string IgnorablePeriod = ".";
	internal const string IgnorableComma = ",";
	internal const string CJKYearSuff = "年";
	internal const string CJKMonthSuff = "月";
	internal const string CJKDaySuff = "日";
	internal const string KoreanYearSuff = "년";
	internal const string KoreanMonthSuff = "월";
	internal const string KoreanDaySuff = "일";
	internal const string KoreanHourSuff = "시";
	internal const string KoreanMinuteSuff = "분";
	internal const string KoreanSecondSuff = "초";
	internal const string CJKHourSuff = "時";
	internal const string ChineseHourSuff = "时";
	internal const string CJKMinuteSuff = "分";
	internal const string CJKSecondSuff = "秒";
	internal const string LocalTimeMark = "T";
	internal const string KoreanLangName = "ko";
	internal const string JapaneseLangName = "ja";
	internal const string EnglishLangName = "en";
	private static DateTimeFormatInfo s_jajpDTFI; // 0x18
	private static DateTimeFormatInfo s_zhtwDTFI; // 0x20

	// Properties
	private string CultureName { get; }
	private CultureInfo Culture { get; }
	private string LanguageName { get; }
	public static DateTimeFormatInfo InvariantInfo { get; }
	public static DateTimeFormatInfo CurrentInfo { get; }
	public string AMDesignator { get; }
	public Calendar Calendar { get; set; }
	private int[] OptionalCalendars { get; }
	internal string[] EraNames { get; }
	internal string[] AbbreviatedEraNames { get; }
	internal string[] AbbreviatedEnglishEraNames { get; }
	public string DateSeparator { get; }
	public string FullDateTimePattern { get; }
	public string LongDatePattern { get; set; }
	public string LongTimePattern { get; set; }
	public string MonthDayPattern { get; }
	public string PMDesignator { get; }
	public string RFC1123Pattern { get; }
	public string ShortDatePattern { get; set; }
	public string ShortTimePattern { get; set; }
	public string SortableDateTimePattern { get; }
	internal string GeneralShortTimePattern { get; }
	internal string GeneralLongTimePattern { get; }
	internal string DateTimeOffsetPattern { get; }
	public string TimeSeparator { get; }
	public string UniversalSortableDateTimePattern { get; }
	public string YearMonthPattern { get; set; }
	public string[] AbbreviatedDayNames { get; }
	public string[] DayNames { get; }
	public string[] AbbreviatedMonthNames { get; }
	public string[] MonthNames { get; }
	internal bool HasSpacesInMonthNames { get; }
	internal bool HasSpacesInDayNames { get; }
	private string[] AllYearMonthPatterns { get; }
	private string[] AllShortDatePatterns { get; }
	private string[] AllShortTimePatterns { get; }
	private string[] AllLongDatePatterns { get; }
	private string[] AllLongTimePatterns { get; }
	private string[] UnclonedYearMonthPatterns { get; }
	private string[] UnclonedShortDatePatterns { get; }
	private string[] UnclonedLongDatePatterns { get; }
	private string[] UnclonedShortTimePatterns { get; }
	private string[] UnclonedLongTimePatterns { get; }
	public bool IsReadOnly { get; }
	[ComVisibleAttribute] // RVA: 0xBA250 Offset: 0xBA351 VA: 0xBA250
	public string[] MonthGenitiveNames { get; }
	internal string FullTimeSpanPositivePattern { get; }
	internal string FullTimeSpanNegativePattern { get; }
	internal CompareInfo CompareInfo { get; }
	internal DateTimeFormatFlags FormatFlags { get; }
	internal bool HasForceTwoDigitYears { get; }
	internal bool HasYearMonthAdjustment { get; }

	// Methods

	// RVA: 0x17AC610 Offset: 0x17AC711 VA: 0x17AC610
	private static bool InitPreferExistingTokens() { }

	// RVA: 0x17AC620 Offset: 0x17AC721 VA: 0x17AC620
	private string get_CultureName() { }

	// RVA: 0x17AC680 Offset: 0x17AC781 VA: 0x17AC680
	private CultureInfo get_Culture() { }

	// RVA: 0x17AC750 Offset: 0x17AC851 VA: 0x17AC750
	private string get_LanguageName() { }

	// RVA: 0x17AC7B0 Offset: 0x17AC8B1 VA: 0x17AC7B0
	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	// RVA: 0x17AC830 Offset: 0x17AC931 VA: 0x17AC830
	private string[] internalGetDayOfWeekNames() { }

	// RVA: 0x17AC8B0 Offset: 0x17AC9B1 VA: 0x17AC8B0
	private string[] internalGetAbbreviatedMonthNames() { }

	// RVA: 0x17AC930 Offset: 0x17ACA31 VA: 0x17AC930
	private string[] internalGetMonthNames() { }

	// RVA: 0x17AC9B0 Offset: 0x17ACAB1 VA: 0x17AC9B0
	public void .ctor() { }

	// RVA: 0x17A8A50 Offset: 0x17A8B51 VA: 0x17A8A50
	internal void .ctor(CultureData cultureData, Calendar cal) { }

	// RVA: 0x17ACE90 Offset: 0x17ACF91 VA: 0x17ACE90
	private void InitializeOverridableProperties(CultureData cultureData, int calendarID) { }

	[OnDeserializedAttribute] // RVA: 0xB8870 Offset: 0xB8971 VA: 0xB8870
	// RVA: 0x17AD060 Offset: 0x17AD161 VA: 0x17AD060
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0xB8880 Offset: 0xB8981 VA: 0xB8880
	// RVA: 0x17AD830 Offset: 0x17AD931 VA: 0x17AD830
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x17AE0C0 Offset: 0x17AE1C1 VA: 0x17AE0C0
	public static DateTimeFormatInfo get_InvariantInfo() { }

	// RVA: 0x17AE1E0 Offset: 0x17AE2E1 VA: 0x17AE1E0
	public static DateTimeFormatInfo get_CurrentInfo() { }

	// RVA: 0x17AE2D0 Offset: 0x17AE3D1 VA: 0x17AE2D0
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	// RVA: 0x17AE490 Offset: 0x17AE591 VA: 0x17AE490 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x17A83C0 Offset: 0x17A84C1 VA: 0x17A83C0 Slot: 4
	public object Clone() { }

	// RVA: 0x17AE530 Offset: 0x17AE631 VA: 0x17AE530
	public string get_AMDesignator() { }

	// RVA: 0x17AE540 Offset: 0x17AE641 VA: 0x17AE540
	public Calendar get_Calendar() { }

	// RVA: 0x17ACAE0 Offset: 0x17ACBE1 VA: 0x17ACAE0
	public void set_Calendar(Calendar value) { }

	// RVA: 0x17AE550 Offset: 0x17AE651 VA: 0x17AE550
	private int[] get_OptionalCalendars() { }

	// RVA: 0x17AE5F0 Offset: 0x17AE6F1 VA: 0x17AE5F0
	internal string[] get_EraNames() { }

	// RVA: 0x17AE670 Offset: 0x17AE771 VA: 0x17AE670
	public string GetEraName(int era) { }

	// RVA: 0x17AE7B0 Offset: 0x17AE8B1 VA: 0x17AE7B0
	internal string[] get_AbbreviatedEraNames() { }

	// RVA: 0x17AE830 Offset: 0x17AE931 VA: 0x17AE830
	public string GetAbbreviatedEraName(int era) { }

	// RVA: 0x17AE990 Offset: 0x17AEA91 VA: 0x17AE990
	internal string[] get_AbbreviatedEnglishEraNames() { }

	// RVA: 0x17AEA10 Offset: 0x17AEB11 VA: 0x17AEA10
	public string get_DateSeparator() { }

	// RVA: 0x17AEA20 Offset: 0x17AEB21 VA: 0x17AEA20
	public string get_FullDateTimePattern() { }

	// RVA: 0x17ADA30 Offset: 0x17ADB31 VA: 0x17ADA30
	public string get_LongDatePattern() { }

	// RVA: 0x17AD2B0 Offset: 0x17AD3B1 VA: 0x17AD2B0
	public void set_LongDatePattern(string value) { }

	// RVA: 0x17AD9A0 Offset: 0x17ADAA1 VA: 0x17AD9A0
	public string get_LongTimePattern() { }

	// RVA: 0x17AD5F0 Offset: 0x17AD6F1 VA: 0x17AD5F0
	public void set_LongTimePattern(string value) { }

	// RVA: 0x17AEBC0 Offset: 0x17AECC1 VA: 0x17AEBC0
	public string get_MonthDayPattern() { }

	// RVA: 0x17AEC40 Offset: 0x17AED41 VA: 0x17AEC40
	public string get_PMDesignator() { }

	// RVA: 0x17AEC50 Offset: 0x17AED51 VA: 0x17AEC50
	public string get_RFC1123Pattern() { }

	// RVA: 0x17ADB80 Offset: 0x17ADC81 VA: 0x17ADB80
	public string get_ShortDatePattern() { }

	// RVA: 0x17AD3C0 Offset: 0x17AD4C1 VA: 0x17AD3C0
	public void set_ShortDatePattern(string value) { }

	// RVA: 0x17ADAF0 Offset: 0x17ADBF1 VA: 0x17ADAF0
	public string get_ShortTimePattern() { }

	// RVA: 0x17AD720 Offset: 0x17AD821 VA: 0x17AD720
	public void set_ShortTimePattern(string value) { }

	// RVA: 0x17AED80 Offset: 0x17AEE81 VA: 0x17AED80
	public string get_SortableDateTimePattern() { }

	// RVA: 0x17AEDD0 Offset: 0x17AEED1 VA: 0x17AEDD0
	internal string get_GeneralShortTimePattern() { }

	// RVA: 0x17AEE90 Offset: 0x17AEF91 VA: 0x17AEE90
	internal string get_GeneralLongTimePattern() { }

	// RVA: 0x17AEF50 Offset: 0x17AF051 VA: 0x17AEF50
	internal string get_DateTimeOffsetPattern() { }

	// RVA: 0x17AF110 Offset: 0x17AF211 VA: 0x17AF110
	public string get_TimeSeparator() { }

	// RVA: 0x17AF120 Offset: 0x17AF221 VA: 0x17AF120
	public string get_UniversalSortableDateTimePattern() { }

	// RVA: 0x17ADC40 Offset: 0x17ADD41 VA: 0x17ADC40
	public string get_YearMonthPattern() { }

	// RVA: 0x17AD4F0 Offset: 0x17AD5F1 VA: 0x17AD4F0
	public void set_YearMonthPattern(string value) { }

	// RVA: 0x17AF1F0 Offset: 0x17AF2F1 VA: 0x17AF1F0
	public string[] get_AbbreviatedDayNames() { }

	// RVA: 0x17AF2C0 Offset: 0x17AF3C1 VA: 0x17AF2C0
	public string[] get_DayNames() { }

	// RVA: 0x17AF390 Offset: 0x17AF491 VA: 0x17AF390
	public string[] get_AbbreviatedMonthNames() { }

	// RVA: 0x17AF460 Offset: 0x17AF561 VA: 0x17AF460
	public string[] get_MonthNames() { }

	// RVA: 0x17AF530 Offset: 0x17AF631 VA: 0x17AF530
	internal bool get_HasSpacesInMonthNames() { }

	// RVA: 0x17AF7C0 Offset: 0x17AF8C1 VA: 0x17AF7C0
	internal bool get_HasSpacesInDayNames() { }

	// RVA: 0x17AF7E0 Offset: 0x17AF8E1 VA: 0x17AF7E0
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	// RVA: 0x17AFA70 Offset: 0x17AFB71 VA: 0x17AFA70
	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	// RVA: 0x17AFB30 Offset: 0x17AFC31 VA: 0x17AFB30
	internal string[] internalGetLeapYearMonthNames() { }

	// RVA: 0x17AFBB0 Offset: 0x17AFCB1 VA: 0x17AFBB0
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	// RVA: 0x17AFD70 Offset: 0x17AFE71 VA: 0x17AFD70
	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	// RVA: 0x17AFF50 Offset: 0x17B0051 VA: 0x17AFF50
	public string[] GetAllDateTimePatterns(char format) { }

	// RVA: 0x17B0320 Offset: 0x17B0421 VA: 0x17B0320
	public string GetDayName(DayOfWeek dayofweek) { }

	// RVA: 0x17B04E0 Offset: 0x17B05E1 VA: 0x17B04E0
	public string GetAbbreviatedMonthName(int month) { }

	// RVA: 0x17B06A0 Offset: 0x17B07A1 VA: 0x17B06A0
	public string GetMonthName(int month) { }

	// RVA: 0x17B0860 Offset: 0x17B0961 VA: 0x17B0860
	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	// RVA: 0x17ADFF0 Offset: 0x17AE0F1 VA: 0x17ADFF0
	private string[] get_AllYearMonthPatterns() { }

	// RVA: 0x17ADF20 Offset: 0x17AE021 VA: 0x17ADF20
	private string[] get_AllShortDatePatterns() { }

	// RVA: 0x17ADE70 Offset: 0x17ADF71 VA: 0x17ADE70
	private string[] get_AllShortTimePatterns() { }

	// RVA: 0x17ADDA0 Offset: 0x17ADEA1 VA: 0x17ADDA0
	private string[] get_AllLongDatePatterns() { }

	// RVA: 0x17ADCF0 Offset: 0x17ADDF1 VA: 0x17ADCF0
	private string[] get_AllLongTimePatterns() { }

	// RVA: 0x17AF170 Offset: 0x17AF271 VA: 0x17AF170
	private string[] get_UnclonedYearMonthPatterns() { }

	// RVA: 0x17AECA0 Offset: 0x17AEDA1 VA: 0x17AECA0
	private string[] get_UnclonedShortDatePatterns() { }

	// RVA: 0x17AEAE0 Offset: 0x17AEBE1 VA: 0x17AEAE0
	private string[] get_UnclonedLongDatePatterns() { }

	// RVA: 0x17AED20 Offset: 0x17AEE21 VA: 0x17AED20
	private string[] get_UnclonedShortTimePatterns() { }

	// RVA: 0x17AEB60 Offset: 0x17AEC61 VA: 0x17AEB60
	private string[] get_UnclonedLongTimePatterns() { }

	// RVA: 0x17B0A90 Offset: 0x17B0B91 VA: 0x17B0A90
	public bool get_IsReadOnly() { }

	// RVA: 0x17B0AA0 Offset: 0x17B0BA1 VA: 0x17B0AA0
	public string[] get_MonthGenitiveNames() { }

	// RVA: 0x17B0B70 Offset: 0x17B0C71 VA: 0x17B0B70
	internal string get_FullTimeSpanPositivePattern() { }

	// RVA: 0x17B0C60 Offset: 0x17B0D61 VA: 0x17B0C60
	internal string get_FullTimeSpanNegativePattern() { }

	// RVA: 0x17B0D00 Offset: 0x17B0E01 VA: 0x17B0D00
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x17B0D90 Offset: 0x17B0E91 VA: 0x17B0D90
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x17AF550 Offset: 0x17AF651 VA: 0x17AF550
	internal DateTimeFormatFlags get_FormatFlags() { }

	// RVA: 0x17B0FD0 Offset: 0x17B10D1 VA: 0x17B0FD0
	internal bool get_HasForceTwoDigitYears() { }

	// RVA: 0x17B1010 Offset: 0x17B1111 VA: 0x17B1010
	internal bool get_HasYearMonthAdjustment() { }

	// RVA: 0x17B1030 Offset: 0x17B1131 VA: 0x17B1030
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

	// RVA: 0x17B1160 Offset: 0x17B1261 VA: 0x17B1160
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	// RVA: 0x17B12B0 Offset: 0x17B13B1 VA: 0x17B12B0
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	// RVA: 0x17AE5B0 Offset: 0x17AE6B1 VA: 0x17AE5B0
	private void ClearTokenHashTable() { }

	// RVA: 0x17B1400 Offset: 0x17B1501 VA: 0x17B1400
	internal TokenHashValue[] CreateTokenHashTable() { }

	// RVA: 0x17B36D0 Offset: 0x17B37D1 VA: 0x17B36D0
	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

	// RVA: 0x17B3800 Offset: 0x17B3901 VA: 0x17B3800
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	// RVA: 0x17B3980 Offset: 0x17B3A81 VA: 0x17B3980
	private static bool IsHebrewChar(char ch) { }

	// RVA: 0x17B39A0 Offset: 0x17B3AA1 VA: 0x17B39A0
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	// RVA: 0x17B3DB0 Offset: 0x17B3EB1 VA: 0x17B3DB0
	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	// RVA: 0x17B2E50 Offset: 0x17B2F51 VA: 0x17B2E50
	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	// RVA: 0x17B3FC0 Offset: 0x17B40C1 VA: 0x17B3FC0
	private static void .cctor() { }
}

