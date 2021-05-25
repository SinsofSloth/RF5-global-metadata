public struct TimeManager.RFTimeSpan // TypeDefIndex: 6888
{
	// Fields
	public int Span; // 0x0

	// Properties
	public int Year { get; set; }
	public int TotalYear { get; set; }
	public int Season { get; set; }
	public int TotalSeason { get; set; }
	public int Day { get; set; }
	public int TotalDay { get; set; }
	public int Hour { get; set; }
	public int TotalHour { get; set; }
	public int Minute { get; set; }
	public int TotalMinute { get; set; }

	// Methods

	// RVA: 0x2DFBC0 Offset: 0x2DFCC1 VA: 0x2DFBC0
	public void .ctor(int span) { }

	// RVA: 0x2DFBD0 Offset: 0x2DFCD1 VA: 0x2DFBD0
	public void .ctor(int year = 0, int season = 0, int day = 0, int hour = 0, int min = 0) { }

	// RVA: 0x2DFC90 Offset: 0x2DFD91 VA: 0x2DFC90
	public int get_Year() { }

	// RVA: 0x2DFD10 Offset: 0x2DFE11 VA: 0x2DFD10
	public void set_Year(int value) { }

	// RVA: 0x2DFD20 Offset: 0x2DFE21 VA: 0x2DFD20
	public int get_TotalYear() { }

	// RVA: 0x2DFD50 Offset: 0x2DFE51 VA: 0x2DFD50
	public void set_TotalYear(int value) { }

	// RVA: 0x2DFD70 Offset: 0x2DFE71 VA: 0x2DFD70
	public int get_Season() { }

	// RVA: 0x2DFE10 Offset: 0x2DFF11 VA: 0x2DFE10
	public void set_Season(int value) { }

	// RVA: 0x2DFE20 Offset: 0x2DFF21 VA: 0x2DFE20
	public int get_TotalSeason() { }

	// RVA: 0x2DFE50 Offset: 0x2DFF51 VA: 0x2DFE50
	public void set_TotalSeason(int value) { }

	// RVA: 0x2DFE60 Offset: 0x2DFF61 VA: 0x2DFE60
	public int get_Day() { }

	// RVA: 0x2DFF10 Offset: 0x2E0011 VA: 0x2DFF10
	public void set_Day(int value) { }

	// RVA: 0x2DFF20 Offset: 0x2E0021 VA: 0x2DFF20
	public int get_TotalDay() { }

	// RVA: 0x2DFF50 Offset: 0x2E0051 VA: 0x2DFF50
	public void set_TotalDay(int value) { }

	// RVA: 0x2DFF60 Offset: 0x2E0061 VA: 0x2DFF60
	public int get_Hour() { }

	// RVA: 0x2E0000 Offset: 0x2E0101 VA: 0x2E0000
	public void set_Hour(int value) { }

	// RVA: 0x2E0010 Offset: 0x2E0111 VA: 0x2E0010
	public int get_TotalHour() { }

	// RVA: 0x2E0040 Offset: 0x2E0141 VA: 0x2E0040
	public void set_TotalHour(int value) { }

	// RVA: 0x2E0050 Offset: 0x2E0151 VA: 0x2E0050
	public int get_Minute() { }

	// RVA: 0x2E00E0 Offset: 0x2E01E1 VA: 0x2E00E0
	public void set_Minute(int value) { }

	// RVA: 0x2E00F0 Offset: 0x2E01F1 VA: 0x2E00F0
	public int get_TotalMinute() { }

	// RVA: 0x2E0100 Offset: 0x2E0201 VA: 0x2E0100
	public void set_TotalMinute(int value) { }

	// RVA: 0x1D21810 Offset: 0x1D21911 VA: 0x1D21810
	public static TimeManager.RFTimeSpan op_Addition(TimeManager.RFTimeSpan a, TimeManager.RFTimeSpan b) { }

	// RVA: 0x1D21820 Offset: 0x1D21921 VA: 0x1D21820
	public static TimeManager.RFTimeSpan op_Subtraction(TimeManager.RFTimeSpan a, TimeManager.RFTimeSpan b) { }
}

