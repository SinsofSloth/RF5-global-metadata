public struct TimeManager.RFTimeInt // TypeDefIndex: 6893
{
	// Fields
	public const long YearOffset = 10000000;
	public const long SeasonOffset = 1000000;
	public const long DayOffset = 10000;
	public const long HourOffset = 100;
	public long Time; // 0x0

	// Properties
	public int Year { get; }
	public int Season { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Min { get; }
	public int YearSeasonDay { get; }

	// Methods

	// RVA: 0x2DF7A0 Offset: 0x2DF8A1 VA: 0x2DF7A0
	public void .ctor(long time) { }

	// RVA: 0x2DF7B0 Offset: 0x2DF8B1 VA: 0x2DF7B0
	public void .ctor(TimeManager.RFDateTime date) { }

	// RVA: 0x2DF7C0 Offset: 0x2DF8C1 VA: 0x2DF7C0
	public void .ctor(int year, int season, int day, int hour, int min) { }

	// RVA: 0x2DF800 Offset: 0x2DF901 VA: 0x2DF800
	public int get_Year() { }

	// RVA: 0x2DF830 Offset: 0x2DF931 VA: 0x2DF830
	public int get_Season() { }

	// RVA: 0x2DF890 Offset: 0x2DF991 VA: 0x2DF890
	public int get_Day() { }

	// RVA: 0x2DF8E0 Offset: 0x2DF9E1 VA: 0x2DF8E0
	public int get_Hour() { }

	// RVA: 0x2DF930 Offset: 0x2DFA31 VA: 0x2DF930
	public int get_Min() { }

	// RVA: 0x2DF970 Offset: 0x2DFA71 VA: 0x2DF970
	public int get_YearSeasonDay() { }

	// RVA: 0x1D20030 Offset: 0x1D20131 VA: 0x1D20030
	public static long CalcTimeInt(int year, int season, int day, int hour, int min) { }

	// RVA: 0x1D20200 Offset: 0x1D20301 VA: 0x1D20200
	public static long CalcYearSeasonDay(int ysd) { }

	// RVA: 0x2DF9A0 Offset: 0x2DFAA1 VA: 0x2DF9A0
	public bool IsSame_YearSeasonDay(TimeManager.RFTimeInt other) { }

	// RVA: 0x2DF9E0 Offset: 0x2DFAE1 VA: 0x2DF9E0
	public TimeManager.RFDateTime CalcDateTime() { }

	// RVA: 0x2DFAF0 Offset: 0x2DFBF1 VA: 0x2DFAF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2DFBA0 Offset: 0x2DFCA1 VA: 0x2DFBA0
	public bool Equals(TimeManager.RFTimeInt p) { }

	// RVA: 0x2DFBB0 Offset: 0x2DFCB1 VA: 0x2DFBB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D20430 Offset: 0x1D20531 VA: 0x1D20430
	public static bool op_Equality(TimeManager.RFTimeInt lhs, TimeManager.RFTimeInt rhs) { }

	// RVA: 0x1D20440 Offset: 0x1D20541 VA: 0x1D20440
	public static bool op_Inequality(TimeManager.RFTimeInt lhs, TimeManager.RFTimeInt rhs) { }
}

