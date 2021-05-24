[ComVisibleAttribute] // RVA: 0xAEEC0 Offset: 0xAEFC1 VA: 0xAEEC0
[Serializable]
public class TaiwanCalendar : Calendar // TypeDefIndex: 730
{
	// Fields
	internal static EraInfo[] taiwanEraInfo; // 0x0
	internal static Calendar s_defaultInstance; // 0x8
	internal GregorianCalendarHelper helper; // 0x20
	internal static readonly DateTime calendarMinValue; // 0x10

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA2F0 Offset: 0xBA3F1 VA: 0xBA2F0
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0xBA310 Offset: 0xBA411 VA: 0xBA310
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x19C8E30 Offset: 0x19C8F31 VA: 0x19C8E30
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x19C90D0 Offset: 0x19C91D1 VA: 0x19C90D0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x19C9140 Offset: 0x19C9241 VA: 0x19C9140 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x19C8F30 Offset: 0x19C9031 VA: 0x19C8F30
	public void .ctor() { }

	// RVA: 0x19C91B0 Offset: 0x19C92B1 VA: 0x19C91B0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x19C91C0 Offset: 0x19C92C1 VA: 0x19C91C0 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x19C91E0 Offset: 0x19C92E1 VA: 0x19C91E0 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x19C9230 Offset: 0x19C9331 VA: 0x19C9230 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x19C92D0 Offset: 0x19C93D1 VA: 0x19C92D0 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x19C9300 Offset: 0x19C9401 VA: 0x19C9300 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x19C9320 Offset: 0x19C9421 VA: 0x19C9320 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x19C9370 Offset: 0x19C9471 VA: 0x19C9370 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x19C9390 Offset: 0x19C9491 VA: 0x19C9390 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x19C9410 Offset: 0x19C9511 VA: 0x19C9410 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x19C9440 Offset: 0x19C9541 VA: 0x19C9440 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x19C9460 Offset: 0x19C9561 VA: 0x19C9460 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x19C94C0 Offset: 0x19C95C1 VA: 0x19C94C0 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x19C9630 Offset: 0x19C9731 VA: 0x19C9630
	private static void .cctor() { }
}

