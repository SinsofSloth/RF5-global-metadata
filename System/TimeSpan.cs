[ComVisibleAttribute] // RVA: 0xAC8E0 Offset: 0xAC9E1 VA: 0xAC8E0
[Serializable]
public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable // TypeDefIndex: 321
{
	// Fields
	public static readonly TimeSpan Zero; // 0x0
	public static readonly TimeSpan MaxValue; // 0x8
	public static readonly TimeSpan MinValue; // 0x10
	internal long _ticks; // 0x0
	private static bool _legacyConfigChecked; // 0x18
	private static bool _legacyMode; // 0x19

	// Properties
	public long Ticks { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public double TotalHours { get; }
	public double TotalMilliseconds { get; }
	public double TotalMinutes { get; }
	public double TotalSeconds { get; }
	private static bool LegacyMode { get; }

	// Methods

	// RVA: 0x3A00 Offset: 0x3B01 VA: 0x3A00
	public void .ctor(long ticks) { }

	// RVA: 0x3A10 Offset: 0x3B11 VA: 0x3A10
	public void .ctor(int hours, int minutes, int seconds) { }

	// RVA: 0x3A20 Offset: 0x3B21 VA: 0x3A20
	public void .ctor(int days, int hours, int minutes, int seconds, int milliseconds) { }

	// RVA: 0x3A30 Offset: 0x3B31 VA: 0x3A30
	public long get_Ticks() { }

	// RVA: 0x3A40 Offset: 0x3B41 VA: 0x3A40
	public int get_Hours() { }

	// RVA: 0x3A90 Offset: 0x3B91 VA: 0x3A90
	public int get_Minutes() { }

	// RVA: 0x3AE0 Offset: 0x3BE1 VA: 0x3AE0
	public double get_TotalHours() { }

	// RVA: 0x3B00 Offset: 0x3C01 VA: 0x3B00
	public double get_TotalMilliseconds() { }

	// RVA: 0x3B40 Offset: 0x3C41 VA: 0x3B40
	public double get_TotalMinutes() { }

	// RVA: 0x3B60 Offset: 0x3C61 VA: 0x3B60
	public double get_TotalSeconds() { }

	// RVA: 0x3B80 Offset: 0x3C81 VA: 0x3B80
	public TimeSpan Add(TimeSpan ts) { }

	// RVA: 0x3C30 Offset: 0x3D31 VA: 0x3C30 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x3C40 Offset: 0x3D41 VA: 0x3C40 Slot: 5
	public int CompareTo(TimeSpan value) { }

	// RVA: 0x1591270 Offset: 0x1591371 VA: 0x1591270
	public static TimeSpan FromDays(double value) { }

	// RVA: 0x3C60 Offset: 0x3D61 VA: 0x3C60 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3D10 Offset: 0x3E11 VA: 0x3D10 Slot: 6
	public bool Equals(TimeSpan obj) { }

	// RVA: 0x3D20 Offset: 0x3E21 VA: 0x3D20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1591510 Offset: 0x1591611 VA: 0x1591510
	public static TimeSpan FromHours(double value) { }

	// RVA: 0x15912F0 Offset: 0x15913F1 VA: 0x15912F0
	private static TimeSpan Interval(double value, int scale) { }

	// RVA: 0x1591590 Offset: 0x1591691 VA: 0x1591590
	public static TimeSpan FromMilliseconds(double value) { }

	// RVA: 0x1591600 Offset: 0x1591701 VA: 0x1591600
	public static TimeSpan FromMinutes(double value) { }

	// RVA: 0x3D30 Offset: 0x3E31 VA: 0x3D30
	public TimeSpan Negate() { }

	// RVA: 0x1591750 Offset: 0x1591851 VA: 0x1591750
	public static TimeSpan FromSeconds(double value) { }

	// RVA: 0x3D40 Offset: 0x3E41 VA: 0x3D40
	public TimeSpan Subtract(TimeSpan ts) { }

	// RVA: 0x1591870 Offset: 0x1591971 VA: 0x1591870
	public static TimeSpan FromTicks(long value) { }

	// RVA: 0x1590EB0 Offset: 0x1590FB1 VA: 0x1590EB0
	internal static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x3DF0 Offset: 0x3EF1 VA: 0x3DF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3E70 Offset: 0x3F71 VA: 0x3E70
	public string ToString(string format) { }

	// RVA: 0x3EF0 Offset: 0x3FF1 VA: 0x3EF0 Slot: 7
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1591B80 Offset: 0x1591C81 VA: 0x1591B80
	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1591C30 Offset: 0x1591D31 VA: 0x1591C30
	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1591CE0 Offset: 0x1591DE1 VA: 0x1591CE0
	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1591CF0 Offset: 0x1591DF1 VA: 0x1591CF0
	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1591D00 Offset: 0x1591E01 VA: 0x1591D00
	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1591D10 Offset: 0x1591E11 VA: 0x1591D10
	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1591D20 Offset: 0x1591E21 VA: 0x1591D20
	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1591D30 Offset: 0x1591E31 VA: 0x1591D30
	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1591D40 Offset: 0x1591E41 VA: 0x1591D40
	private static bool GetLegacyFormatMode() { }

	// RVA: 0x1591A50 Offset: 0x1591B51 VA: 0x1591A50
	private static bool get_LegacyMode() { }

	// RVA: 0x1591D90 Offset: 0x1591E91 VA: 0x1591D90
	private static void .cctor() { }
}

