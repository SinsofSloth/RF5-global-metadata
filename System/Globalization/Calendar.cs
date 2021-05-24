[ComVisibleAttribute] // RVA: 0xAECE0 Offset: 0xAEDE1 VA: 0xAECE0
[Serializable]
public abstract class Calendar : ICloneable // TypeDefIndex: 702
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalFieldAttribute] // RVA: 0xB48A0 Offset: 0xB49A1 VA: 0xB48A0
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA1F0 Offset: 0xBA2F1 VA: 0xBA1F0
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0xBA210 Offset: 0xBA311 VA: 0xBA210
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x17A08E0 Offset: 0x17A09E1 VA: 0x17A08E0 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x17A0950 Offset: 0x17A0A51 VA: 0x17A0950 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x17A09C0 Offset: 0x17A0AC1 VA: 0x17A09C0
	protected void .ctor() { }

	// RVA: 0x17A09E0 Offset: 0x17A0AE1 VA: 0x17A09E0 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x17A09F0 Offset: 0x17A0AF1 VA: 0x17A09F0 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisibleAttribute] // RVA: 0xB8820 Offset: 0xB8921 VA: 0xB8820
	// RVA: 0x17A0A00 Offset: 0x17A0B01 VA: 0x17A0A00 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x17A0A90 Offset: 0x17A0B91 VA: 0x17A0A90
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x17A0AA0 Offset: 0x17A0BA1 VA: 0x17A0AA0 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetEra(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int[] get_Eras() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int GetMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonthsInYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetYear(DateTime time) { }

	// RVA: 0x17A0C50 Offset: 0x17A0D51 VA: 0x17A0C50 Slot: 19
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool IsLeapYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x17A0C70 Offset: 0x17A0D71 VA: 0x17A0C70 Slot: 22
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x17A0DF0 Offset: 0x17A0EF1 VA: 0x17A0DF0 Slot: 23
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x17A0E80 Offset: 0x17A0F81 VA: 0x17A0E80 Slot: 24
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x17A0F00 Offset: 0x17A1001 VA: 0x17A0F00 Slot: 25
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x17A0F90 Offset: 0x17A1091 VA: 0x17A0F90 Slot: 26
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x17A0FA0 Offset: 0x17A10A1 VA: 0x17A0FA0 Slot: 27
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x17A10C0 Offset: 0x17A11C1 VA: 0x17A10C0
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}

[ComVisibleAttribute] // RVA: 0xAECE0 Offset: 0xAEDE1 VA: 0xAECE0
[Serializable]
public abstract class Calendar : ICloneable // TypeDefIndex: 702
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalFieldAttribute] // RVA: 0xB48A0 Offset: 0xB49A1 VA: 0xB48A0
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA1F0 Offset: 0xBA2F1 VA: 0xBA1F0
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0xBA210 Offset: 0xBA311 VA: 0xBA210
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x17A08E0 Offset: 0x17A09E1 VA: 0x17A08E0 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x17A0950 Offset: 0x17A0A51 VA: 0x17A0950 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x17A09C0 Offset: 0x17A0AC1 VA: 0x17A09C0
	protected void .ctor() { }

	// RVA: 0x17A09E0 Offset: 0x17A0AE1 VA: 0x17A09E0 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x17A09F0 Offset: 0x17A0AF1 VA: 0x17A09F0 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisibleAttribute] // RVA: 0xB8820 Offset: 0xB8921 VA: 0xB8820
	// RVA: 0x17A0A00 Offset: 0x17A0B01 VA: 0x17A0A00 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x17A0A90 Offset: 0x17A0B91 VA: 0x17A0A90
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x17A0AA0 Offset: 0x17A0BA1 VA: 0x17A0AA0 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetEra(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int[] get_Eras() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int GetMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonthsInYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetYear(DateTime time) { }

	// RVA: 0x17A0C50 Offset: 0x17A0D51 VA: 0x17A0C50 Slot: 19
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool IsLeapYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x17A0C70 Offset: 0x17A0D71 VA: 0x17A0C70 Slot: 22
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x17A0DF0 Offset: 0x17A0EF1 VA: 0x17A0DF0 Slot: 23
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x17A0E80 Offset: 0x17A0F81 VA: 0x17A0E80 Slot: 24
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x17A0F00 Offset: 0x17A1001 VA: 0x17A0F00 Slot: 25
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x17A0F90 Offset: 0x17A1091 VA: 0x17A0F90 Slot: 26
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x17A0FA0 Offset: 0x17A10A1 VA: 0x17A0FA0 Slot: 27
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x17A10C0 Offset: 0x17A11C1 VA: 0x17A10C0
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}

[ComVisibleAttribute] // RVA: 0xAECE0 Offset: 0xAEDE1 VA: 0xAECE0
[Serializable]
public abstract class Calendar : ICloneable // TypeDefIndex: 702
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalFieldAttribute] // RVA: 0xB48A0 Offset: 0xB49A1 VA: 0xB48A0
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA1F0 Offset: 0xBA2F1 VA: 0xBA1F0
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0xBA210 Offset: 0xBA311 VA: 0xBA210
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x17A08E0 Offset: 0x17A09E1 VA: 0x17A08E0 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x17A0950 Offset: 0x17A0A51 VA: 0x17A0950 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x17A09C0 Offset: 0x17A0AC1 VA: 0x17A09C0
	protected void .ctor() { }

	// RVA: 0x17A09E0 Offset: 0x17A0AE1 VA: 0x17A09E0 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x17A09F0 Offset: 0x17A0AF1 VA: 0x17A09F0 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisibleAttribute] // RVA: 0xB8820 Offset: 0xB8921 VA: 0xB8820
	// RVA: 0x17A0A00 Offset: 0x17A0B01 VA: 0x17A0A00 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x17A0A90 Offset: 0x17A0B91 VA: 0x17A0A90
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x17A0AA0 Offset: 0x17A0BA1 VA: 0x17A0AA0 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetEra(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int[] get_Eras() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int GetMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonthsInYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetYear(DateTime time) { }

	// RVA: 0x17A0C50 Offset: 0x17A0D51 VA: 0x17A0C50 Slot: 19
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool IsLeapYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x17A0C70 Offset: 0x17A0D71 VA: 0x17A0C70 Slot: 22
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x17A0DF0 Offset: 0x17A0EF1 VA: 0x17A0DF0 Slot: 23
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x17A0E80 Offset: 0x17A0F81 VA: 0x17A0E80 Slot: 24
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x17A0F00 Offset: 0x17A1001 VA: 0x17A0F00 Slot: 25
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x17A0F90 Offset: 0x17A1091 VA: 0x17A0F90 Slot: 26
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x17A0FA0 Offset: 0x17A10A1 VA: 0x17A0FA0 Slot: 27
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x17A10C0 Offset: 0x17A11C1 VA: 0x17A10C0
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}

[ComVisibleAttribute] // RVA: 0xAECE0 Offset: 0xAEDE1 VA: 0xAECE0
[Serializable]
public abstract class Calendar : ICloneable // TypeDefIndex: 702
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalFieldAttribute] // RVA: 0xB48A0 Offset: 0xB49A1 VA: 0xB48A0
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA1F0 Offset: 0xBA2F1 VA: 0xBA1F0
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0xBA210 Offset: 0xBA311 VA: 0xBA210
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x17A08E0 Offset: 0x17A09E1 VA: 0x17A08E0 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x17A0950 Offset: 0x17A0A51 VA: 0x17A0950 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x17A09C0 Offset: 0x17A0AC1 VA: 0x17A09C0
	protected void .ctor() { }

	// RVA: 0x17A09E0 Offset: 0x17A0AE1 VA: 0x17A09E0 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x17A09F0 Offset: 0x17A0AF1 VA: 0x17A09F0 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisibleAttribute] // RVA: 0xB8820 Offset: 0xB8921 VA: 0xB8820
	// RVA: 0x17A0A00 Offset: 0x17A0B01 VA: 0x17A0A00 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x17A0A90 Offset: 0x17A0B91 VA: 0x17A0A90
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x17A0AA0 Offset: 0x17A0BA1 VA: 0x17A0AA0 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetEra(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int[] get_Eras() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int GetMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonthsInYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetYear(DateTime time) { }

	// RVA: 0x17A0C50 Offset: 0x17A0D51 VA: 0x17A0C50 Slot: 19
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool IsLeapYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x17A0C70 Offset: 0x17A0D71 VA: 0x17A0C70 Slot: 22
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x17A0DF0 Offset: 0x17A0EF1 VA: 0x17A0DF0 Slot: 23
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x17A0E80 Offset: 0x17A0F81 VA: 0x17A0E80 Slot: 24
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x17A0F00 Offset: 0x17A1001 VA: 0x17A0F00 Slot: 25
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x17A0F90 Offset: 0x17A1091 VA: 0x17A0F90 Slot: 26
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x17A0FA0 Offset: 0x17A10A1 VA: 0x17A0FA0 Slot: 27
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x17A10C0 Offset: 0x17A11C1 VA: 0x17A10C0
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}

[ComVisibleAttribute] // RVA: 0xAECE0 Offset: 0xAEDE1 VA: 0xAECE0
[Serializable]
public abstract class Calendar : ICloneable // TypeDefIndex: 702
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalFieldAttribute] // RVA: 0xB48A0 Offset: 0xB49A1 VA: 0xB48A0
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA1F0 Offset: 0xBA2F1 VA: 0xBA1F0
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0xBA210 Offset: 0xBA311 VA: 0xBA210
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x17A08E0 Offset: 0x17A09E1 VA: 0x17A08E0 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x17A0950 Offset: 0x17A0A51 VA: 0x17A0950 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x17A09C0 Offset: 0x17A0AC1 VA: 0x17A09C0
	protected void .ctor() { }

	// RVA: 0x17A09E0 Offset: 0x17A0AE1 VA: 0x17A09E0 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x17A09F0 Offset: 0x17A0AF1 VA: 0x17A09F0 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisibleAttribute] // RVA: 0xB8820 Offset: 0xB8921 VA: 0xB8820
	// RVA: 0x17A0A00 Offset: 0x17A0B01 VA: 0x17A0A00 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x17A0A90 Offset: 0x17A0B91 VA: 0x17A0A90
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x17A0AA0 Offset: 0x17A0BA1 VA: 0x17A0AA0 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetEra(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int[] get_Eras() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int GetMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonthsInYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetYear(DateTime time) { }

	// RVA: 0x17A0C50 Offset: 0x17A0D51 VA: 0x17A0C50 Slot: 19
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool IsLeapYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x17A0C70 Offset: 0x17A0D71 VA: 0x17A0C70 Slot: 22
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x17A0DF0 Offset: 0x17A0EF1 VA: 0x17A0DF0 Slot: 23
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x17A0E80 Offset: 0x17A0F81 VA: 0x17A0E80 Slot: 24
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x17A0F00 Offset: 0x17A1001 VA: 0x17A0F00 Slot: 25
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x17A0F90 Offset: 0x17A1091 VA: 0x17A0F90 Slot: 26
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x17A0FA0 Offset: 0x17A10A1 VA: 0x17A0FA0 Slot: 27
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x17A10C0 Offset: 0x17A11C1 VA: 0x17A10C0
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}

[ComVisibleAttribute] // RVA: 0xAECE0 Offset: 0xAEDE1 VA: 0xAECE0
[Serializable]
public abstract class Calendar : ICloneable // TypeDefIndex: 702
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalFieldAttribute] // RVA: 0xB48A0 Offset: 0xB49A1 VA: 0xB48A0
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA1F0 Offset: 0xBA2F1 VA: 0xBA1F0
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0xBA210 Offset: 0xBA311 VA: 0xBA210
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x17A08E0 Offset: 0x17A09E1 VA: 0x17A08E0 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x17A0950 Offset: 0x17A0A51 VA: 0x17A0950 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x17A09C0 Offset: 0x17A0AC1 VA: 0x17A09C0
	protected void .ctor() { }

	// RVA: 0x17A09E0 Offset: 0x17A0AE1 VA: 0x17A09E0 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x17A09F0 Offset: 0x17A0AF1 VA: 0x17A09F0 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisibleAttribute] // RVA: 0xB8820 Offset: 0xB8921 VA: 0xB8820
	// RVA: 0x17A0A00 Offset: 0x17A0B01 VA: 0x17A0A00 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x17A0A90 Offset: 0x17A0B91 VA: 0x17A0A90
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x17A0AA0 Offset: 0x17A0BA1 VA: 0x17A0AA0 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetEra(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int[] get_Eras() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int GetMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonthsInYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetYear(DateTime time) { }

	// RVA: 0x17A0C50 Offset: 0x17A0D51 VA: 0x17A0C50 Slot: 19
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool IsLeapYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x17A0C70 Offset: 0x17A0D71 VA: 0x17A0C70 Slot: 22
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x17A0DF0 Offset: 0x17A0EF1 VA: 0x17A0DF0 Slot: 23
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x17A0E80 Offset: 0x17A0F81 VA: 0x17A0E80 Slot: 24
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x17A0F00 Offset: 0x17A1001 VA: 0x17A0F00 Slot: 25
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x17A0F90 Offset: 0x17A1091 VA: 0x17A0F90 Slot: 26
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x17A0FA0 Offset: 0x17A10A1 VA: 0x17A0FA0 Slot: 27
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x17A10C0 Offset: 0x17A11C1 VA: 0x17A10C0
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}

[ComVisibleAttribute] // RVA: 0xAECE0 Offset: 0xAEDE1 VA: 0xAECE0
[Serializable]
public abstract class Calendar : ICloneable // TypeDefIndex: 702
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalFieldAttribute] // RVA: 0xB48A0 Offset: 0xB49A1 VA: 0xB48A0
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA1F0 Offset: 0xBA2F1 VA: 0xBA1F0
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0xBA210 Offset: 0xBA311 VA: 0xBA210
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x17A08E0 Offset: 0x17A09E1 VA: 0x17A08E0 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x17A0950 Offset: 0x17A0A51 VA: 0x17A0950 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x17A09C0 Offset: 0x17A0AC1 VA: 0x17A09C0
	protected void .ctor() { }

	// RVA: 0x17A09E0 Offset: 0x17A0AE1 VA: 0x17A09E0 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x17A09F0 Offset: 0x17A0AF1 VA: 0x17A09F0 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisibleAttribute] // RVA: 0xB8820 Offset: 0xB8921 VA: 0xB8820
	// RVA: 0x17A0A00 Offset: 0x17A0B01 VA: 0x17A0A00 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x17A0A90 Offset: 0x17A0B91 VA: 0x17A0A90
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x17A0AA0 Offset: 0x17A0BA1 VA: 0x17A0AA0 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetEra(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int[] get_Eras() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int GetMonth(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonthsInYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetYear(DateTime time) { }

	// RVA: 0x17A0C50 Offset: 0x17A0D51 VA: 0x17A0C50 Slot: 19
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool IsLeapYear(int year, int era) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x17A0C70 Offset: 0x17A0D71 VA: 0x17A0C70 Slot: 22
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x17A0DF0 Offset: 0x17A0EF1 VA: 0x17A0DF0 Slot: 23
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x17A0E80 Offset: 0x17A0F81 VA: 0x17A0E80 Slot: 24
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x17A0F00 Offset: 0x17A1001 VA: 0x17A0F00 Slot: 25
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x17A0F90 Offset: 0x17A1091 VA: 0x17A0F90 Slot: 26
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x17A0FA0 Offset: 0x17A10A1 VA: 0x17A0FA0 Slot: 27
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x17A10C0 Offset: 0x17A11C1 VA: 0x17A10C0
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}

