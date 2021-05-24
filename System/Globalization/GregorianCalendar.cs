[ComVisibleAttribute] // RVA: 0xAEE00 Offset: 0xAEF01 VA: 0xAEE00
[Serializable]
public class GregorianCalendar : Calendar // TypeDefIndex: 716
{
	// Fields
	internal GregorianCalendarTypes m_type; // 0x1C
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	private static Calendar s_defaultInstance; // 0x10

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA270 Offset: 0xBA371 VA: 0xBA270
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0xBA290 Offset: 0xBA391 VA: 0xBA290
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }

	// Methods

	[OnDeserializedAttribute] // RVA: 0xB8890 Offset: 0xB8991 VA: 0xB8890
	// RVA: 0x19C0A30 Offset: 0x19C0B31 VA: 0x19C0A30
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x19C0B40 Offset: 0x19C0C41 VA: 0x19C0B40 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x19C0BB0 Offset: 0x19C0CB1 VA: 0x19C0BB0 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x19C0C20 Offset: 0x19C0D21 VA: 0x19C0C20
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x19C0D60 Offset: 0x19C0E61 VA: 0x19C0D60
	public void .ctor() { }

	// RVA: 0x19C0DC0 Offset: 0x19C0EC1 VA: 0x19C0DC0
	public void .ctor(GregorianCalendarTypes type) { }

	// RVA: 0x19C0F20 Offset: 0x19C1021 VA: 0x19C0F20 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x19C0F30 Offset: 0x19C1031 VA: 0x19C0F30 Slot: 28
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x19C11B0 Offset: 0x19C12B1 VA: 0x19C11B0 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x19C1200 Offset: 0x19C1301 VA: 0x19C1200 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x19C1280 Offset: 0x19C1381 VA: 0x19C1280 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x19C1540 Offset: 0x19C1641 VA: 0x19C1540 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x19C1550 Offset: 0x19C1651 VA: 0x19C1550 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x19C15D0 Offset: 0x19C16D1 VA: 0x19C15D0 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x19C1620 Offset: 0x19C1721 VA: 0x19C1620 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x19C17A0 Offset: 0x19C18A1 VA: 0x19C17A0 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x19C17F0 Offset: 0x19C18F1 VA: 0x19C17F0 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x19C19B0 Offset: 0x19C1AB1 VA: 0x19C19B0 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x19C1AC0 Offset: 0x19C1BC1 VA: 0x19C1AC0 Slot: 22
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x19C1BD0 Offset: 0x19C1CD1 VA: 0x19C1BD0 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x19C1C30 Offset: 0x19C1D31 VA: 0x19C1C30 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x19C1D90 Offset: 0x19C1E91 VA: 0x19C1D90
	private static void .cctor() { }
}

