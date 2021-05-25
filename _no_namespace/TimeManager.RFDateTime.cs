public struct TimeManager.RFDateTime // TypeDefIndex: 6887
{
	// Fields
	public int LowTime; // 0x0

	// Properties
	public int Year { get; set; }
	public Season Season { get; set; }
	public int Day { get; set; }
	public int Hour { get; set; }
	public int Minute { get; set; }
	public int ElapsedDay { get; }

	// Methods

	// RVA: 0x2DF390 Offset: 0x2DF491 VA: 0x2DF390
	public void .ctor(int value) { }

	// RVA: 0x2DF3A0 Offset: 0x2DF4A1 VA: 0x2DF3A0
	public void .ctor(int year = 1, Season season = 1, int day = 1, int hour = 0, int min = 0) { }

	// RVA: 0x2DF3B0 Offset: 0x2DF4B1 VA: 0x2DF3B0
	public int get_Year() { }

	// RVA: 0x2DF440 Offset: 0x2DF541 VA: 0x2DF440
	public void set_Year(int value) { }

	// RVA: 0x2DF450 Offset: 0x2DF551 VA: 0x2DF450
	public Season get_Season() { }

	// RVA: 0x2DF4F0 Offset: 0x2DF5F1 VA: 0x2DF4F0
	public void set_Season(Season value) { }

	// RVA: 0x2DF500 Offset: 0x2DF601 VA: 0x2DF500
	public int get_Day() { }

	// RVA: 0x2DF5B0 Offset: 0x2DF6B1 VA: 0x2DF5B0
	public void set_Day(int value) { }

	// RVA: 0x2DF5C0 Offset: 0x2DF6C1 VA: 0x2DF5C0
	public int get_Hour() { }

	// RVA: 0x2DF660 Offset: 0x2DF761 VA: 0x2DF660
	public void set_Hour(int value) { }

	// RVA: 0x2DF670 Offset: 0x2DF771 VA: 0x2DF670
	public int get_Minute() { }

	// RVA: 0x2DF700 Offset: 0x2DF801 VA: 0x2DF700
	public void set_Minute(int value) { }

	// RVA: 0x2DF710 Offset: 0x2DF811 VA: 0x2DF710
	public int get_ElapsedDay() { }

	// RVA: 0x1D1FFC0 Offset: 0x1D200C1 VA: 0x1D1FFC0
	public static TimeManager.RFTimeSpan op_Subtraction(TimeManager.RFDateTime a, TimeManager.RFDateTime b) { }

	// RVA: 0x1D1FFD0 Offset: 0x1D200D1 VA: 0x1D1FFD0
	public static TimeManager.RFDateTime op_Subtraction(TimeManager.RFDateTime a, TimeManager.RFTimeSpan b) { }
}

