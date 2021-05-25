[ComVisibleAttribute] // RVA: 0xAEE40 Offset: 0xAEF41 VA: 0xAEE40
[Serializable]
public class JapaneseCalendar : Calendar // TypeDefIndex: 726
{
	// Fields
	internal static readonly DateTime calendarMinValue; // 0x0
	internal static EraInfo[] japaneseEraInfo; // 0x8
	internal static Calendar s_defaultInstance; // 0x10
	internal GregorianCalendarHelper helper; // 0x20

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA2B0 Offset: 0xBA3B1 VA: 0xBA2B0
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0xBA2D0 Offset: 0xBA3D1 VA: 0xBA2D0
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x19C5C00 Offset: 0x19C5D01 VA: 0x19C5C00 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x19C5C70 Offset: 0x19C5D71 VA: 0x19C5C70 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x19C5CE0 Offset: 0x19C5DE1 VA: 0x19C5CE0
	internal static EraInfo[] GetEraInfo() { }

	// RVA: 0x19C6230 Offset: 0x19C6331 VA: 0x19C6230
	private static EraInfo[] GetErasFromRegistry() { }

	// RVA: 0x19C6240 Offset: 0x19C6341 VA: 0x19C6240
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x19C6340 Offset: 0x19C6441 VA: 0x19C6340
	public void .ctor() { }

	// RVA: 0x19C64E0 Offset: 0x19C65E1 VA: 0x19C64E0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x19C64F0 Offset: 0x19C65F1 VA: 0x19C64F0 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x19C6510 Offset: 0x19C6611 VA: 0x19C6510 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x19C6560 Offset: 0x19C6661 VA: 0x19C6560 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x19C6600 Offset: 0x19C6701 VA: 0x19C6600 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x19C6630 Offset: 0x19C6731 VA: 0x19C6630 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x19C6650 Offset: 0x19C6751 VA: 0x19C6650 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x19C66A0 Offset: 0x19C67A1 VA: 0x19C66A0 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x19C66C0 Offset: 0x19C67C1 VA: 0x19C66C0 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x19C6740 Offset: 0x19C6841 VA: 0x19C6740 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x19C6770 Offset: 0x19C6871 VA: 0x19C6770 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x19C68E0 Offset: 0x19C69E1 VA: 0x19C68E0 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x19C6900 Offset: 0x19C6A01 VA: 0x19C6900
	internal static string[] EraNames() { }

	// RVA: 0x19C6A50 Offset: 0x19C6B51 VA: 0x19C6A50
	internal static string[] AbbrevEraNames() { }

	// RVA: 0x19C6BA0 Offset: 0x19C6CA1 VA: 0x19C6BA0
	internal static string[] EnglishEraNames() { }

	// RVA: 0x19C6CF0 Offset: 0x19C6DF1 VA: 0x19C6CF0 Slot: 23
	internal override bool IsValidYear(int year, int era) { }

	// RVA: 0x19C6D10 Offset: 0x19C6E11 VA: 0x19C6D10 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x19C6D70 Offset: 0x19C6E71 VA: 0x19C6D70
	private static void .cctor() { }
}

