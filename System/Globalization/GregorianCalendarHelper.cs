[Serializable]
internal class GregorianCalendarHelper // TypeDefIndex: 718
{
	// Fields
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	[OptionalFieldAttribute] // RVA: 0xB4F60 Offset: 0xB5061 VA: 0xB4F60
	internal int m_maxYear; // 0x10
	[OptionalFieldAttribute] // RVA: 0xB4FA0 Offset: 0xB50A1 VA: 0xB4FA0
	internal int m_minYear; // 0x14
	internal Calendar m_Cal; // 0x18
	[OptionalFieldAttribute] // RVA: 0xB4FE0 Offset: 0xB50E1 VA: 0xB4FE0
	internal EraInfo[] m_EraInfo; // 0x20
	[OptionalFieldAttribute] // RVA: 0xB5020 Offset: 0xB5121 VA: 0xB5020
	internal int[] m_eras; // 0x28
	[OptionalFieldAttribute] // RVA: 0xB5060 Offset: 0xB5161 VA: 0xB5060
	internal DateTime m_minDate; // 0x30

	// Properties
	internal int MaxYear { get; }
	public int[] Eras { get; }

	// Methods

	// RVA: 0x19C1E60 Offset: 0x19C1F61 VA: 0x19C1E60
	internal int get_MaxYear() { }

	// RVA: 0x19C1E70 Offset: 0x19C1F71 VA: 0x19C1E70
	internal void .ctor(Calendar cal, EraInfo[] eraInfo) { }

	// RVA: 0x19C1F30 Offset: 0x19C2031 VA: 0x19C1F30
	internal int GetGregorianYear(int year, int era) { }

	// RVA: 0x19C2190 Offset: 0x19C2291 VA: 0x19C2190
	internal bool IsValidYear(int year, int era) { }

	// RVA: 0x19C2250 Offset: 0x19C2351 VA: 0x19C2250 Slot: 4
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x19C26A0 Offset: 0x19C27A1 VA: 0x19C26A0
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x19C28B0 Offset: 0x19C29B1 VA: 0x19C28B0
	internal static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x19C2940 Offset: 0x19C2A41 VA: 0x19C2940
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x19C24E0 Offset: 0x19C25E1 VA: 0x19C24E0
	internal void CheckTicksRange(long ticks) { }

	// RVA: 0x19C2B00 Offset: 0x19C2C01 VA: 0x19C2B00
	public int GetDayOfMonth(DateTime time) { }

	// RVA: 0x19C2B50 Offset: 0x19C2C51 VA: 0x19C2B50
	public DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x19C2BE0 Offset: 0x19C2CE1 VA: 0x19C2BE0
	public int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x19C2DA0 Offset: 0x19C2EA1 VA: 0x19C2DA0
	public int GetEra(DateTime time) { }

	// RVA: 0x19C2EA0 Offset: 0x19C2FA1 VA: 0x19C2EA0
	public int[] get_Eras() { }

	// RVA: 0x19C2FC0 Offset: 0x19C30C1 VA: 0x19C2FC0
	public int GetMonth(DateTime time) { }

	// RVA: 0x19C3010 Offset: 0x19C3111 VA: 0x19C3010
	public int GetMonthsInYear(int year, int era) { }

	// RVA: 0x19C3030 Offset: 0x19C3131 VA: 0x19C3030
	public int GetYear(DateTime time) { }

	// RVA: 0x19C3150 Offset: 0x19C3251 VA: 0x19C3150
	public bool IsLeapYear(int year, int era) { }

	// RVA: 0x19C31C0 Offset: 0x19C32C1 VA: 0x19C31C0
	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x19C3330 Offset: 0x19C3431 VA: 0x19C3330
	private static void .cctor() { }
}

