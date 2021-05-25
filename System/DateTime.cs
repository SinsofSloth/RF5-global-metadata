[Serializable]
public struct DateTime : IComparable, IFormattable, IConvertible, ISerializable, IComparable<DateTime>, IEquatable<DateTime> // TypeDefIndex: 207
{
	// Fields
	private const long TicksPerMillisecond = 10000;
	private const long TicksPerSecond = 10000000;
	private const long TicksPerMinute = 600000000;
	private const long TicksPerHour = 36000000000;
	private const long TicksPerDay = 864000000000;
	private const int MillisPerSecond = 1000;
	private const int MillisPerMinute = 60000;
	private const int MillisPerHour = 3600000;
	private const int MillisPerDay = 86400000;
	private const int DaysPerYear = 365;
	private const int DaysPer4Years = 1461;
	private const int DaysPer100Years = 36524;
	private const int DaysPer400Years = 146097;
	private const int DaysTo1601 = 584388;
	private const int DaysTo1899 = 693593;
	internal const int DaysTo1970 = 719162;
	private const int DaysTo10000 = 3652059;
	internal const long MinTicks = 0;
	internal const long MaxTicks = 3155378975999999999;
	private const long MaxMillis = 315537897600000;
	private const long FileTimeOffset = 504911232000000000;
	private const long DoubleDateOffset = 599264352000000000;
	private const long OADateMinAsTicks = 31241376000000000;
	private const double OADateMinAsDouble = -657435;
	private const double OADateMaxAsDouble = 2958466;
	private const int DatePartYear = 0;
	private const int DatePartDayOfYear = 1;
	private const int DatePartMonth = 2;
	private const int DatePartDay = 3;
	private static readonly int[] DaysToMonth365; // 0x0
	private static readonly int[] DaysToMonth366; // 0x8
	public static readonly DateTime MinValue; // 0x10
	public static readonly DateTime MaxValue; // 0x18
	private const ulong TicksMask = 4611686018427387903;
	private const ulong FlagsMask = 13835058055282163712;
	private const ulong LocalMask = 9223372036854775808;
	private const long TicksCeiling = 4611686018427387904;
	private const ulong KindUnspecified = 0;
	private const ulong KindUtc = 4611686018427387904;
	private const ulong KindLocal = 9223372036854775808;
	private const ulong KindLocalAmbiguousDst = 13835058055282163712;
	private const int KindShift = 62;
	private const string TicksField = "ticks";
	private const string DateDataField = "dateData";
	private ulong dateData; // 0x0

	// Properties
	internal long InternalTicks { get; }
	private ulong InternalKind { get; }
	public DateTime Date { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public int Hour { get; }
	public DateTimeKind Kind { get; }
	public int Minute { get; }
	public int Month { get; }
	public static DateTime Now { get; }
	public static DateTime UtcNow { get; }
	public int Second { get; }
	public long Ticks { get; }
	public TimeSpan TimeOfDay { get; }
	public int Year { get; }

	// Methods

	// RVA: 0x3731C0 Offset: 0x3732C1 VA: 0x3731C0
	public void .ctor(long ticks) { }

	// RVA: 0x373280 Offset: 0x373381 VA: 0x373280
	private void .ctor(ulong dateData) { }

	// RVA: 0x373290 Offset: 0x373391 VA: 0x373290
	public void .ctor(long ticks, DateTimeKind kind) { }

	// RVA: 0x3732A0 Offset: 0x3733A1 VA: 0x3732A0
	internal void .ctor(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	// RVA: 0x373380 Offset: 0x373481 VA: 0x373380
	public void .ctor(int year, int month, int day) { }

	// RVA: 0x373410 Offset: 0x373511 VA: 0x373410
	public void .ctor(int year, int month, int day, int hour, int minute, int second) { }

	// RVA: 0x3734D0 Offset: 0x3735D1 VA: 0x3734D0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	// RVA: 0x3734E0 Offset: 0x3735E1 VA: 0x3734E0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: 0x3734F0 Offset: 0x3735F1 VA: 0x3734F0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x373500 Offset: 0x373601 VA: 0x373500
	internal long get_InternalTicks() { }

	// RVA: 0x373510 Offset: 0x373611 VA: 0x373510
	private ulong get_InternalKind() { }

	// RVA: 0x373520 Offset: 0x373621 VA: 0x373520
	public DateTime Add(TimeSpan value) { }

	// RVA: 0x373530 Offset: 0x373631 VA: 0x373530
	private DateTime Add(double value, int scale) { }

	// RVA: 0x373540 Offset: 0x373641 VA: 0x373540
	public DateTime AddDays(double value) { }

	// RVA: 0x373550 Offset: 0x373651 VA: 0x373550
	public DateTime AddMilliseconds(double value) { }

	// RVA: 0x373560 Offset: 0x373661 VA: 0x373560
	public DateTime AddMonths(int months) { }

	// RVA: 0x373570 Offset: 0x373671 VA: 0x373570
	public DateTime AddSeconds(double value) { }

	// RVA: 0x373580 Offset: 0x373681 VA: 0x373580
	public DateTime AddTicks(long value) { }

	// RVA: 0x373590 Offset: 0x373691 VA: 0x373590
	public DateTime AddYears(int value) { }

	// RVA: 0x3735A0 Offset: 0x3736A1 VA: 0x3735A0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x3735B0 Offset: 0x3736B1 VA: 0x3735B0 Slot: 24
	public int CompareTo(DateTime value) { }

	// RVA: 0x29848A0 Offset: 0x29849A1 VA: 0x29848A0
	private static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x2984B50 Offset: 0x2984C51 VA: 0x2984B50
	private static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x2985A80 Offset: 0x2985B81 VA: 0x2985A80
	public static int DaysInMonth(int year, int month) { }

	// RVA: 0x3735D0 Offset: 0x3736D1 VA: 0x3735D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x373680 Offset: 0x373781 VA: 0x373680 Slot: 25
	public bool Equals(DateTime value) { }

	// RVA: 0x2985FE0 Offset: 0x29860E1 VA: 0x2985FE0
	public static DateTime FromBinary(long dateData) { }

	// RVA: 0x29862A0 Offset: 0x29863A1 VA: 0x29862A0
	internal static DateTime FromBinaryRaw(long dateData) { }

	// RVA: 0x3736A0 Offset: 0x3737A1 VA: 0x3736A0 Slot: 23
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2986430 Offset: 0x2986531 VA: 0x2986430
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	// RVA: 0x3736B0 Offset: 0x3737B1 VA: 0x3736B0
	public long ToBinary() { }

	// RVA: 0x373720 Offset: 0x373821 VA: 0x373720
	internal long ToBinaryRaw() { }

	// RVA: 0x373730 Offset: 0x373831 VA: 0x373730
	public DateTime get_Date() { }

	// RVA: 0x373770 Offset: 0x373871 VA: 0x373770
	private int GetDatePart(int part) { }

	// RVA: 0x373780 Offset: 0x373881 VA: 0x373780
	public int get_Day() { }

	// RVA: 0x373790 Offset: 0x373891 VA: 0x373790
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x3737E0 Offset: 0x3738E1 VA: 0x3737E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3737F0 Offset: 0x3738F1 VA: 0x3737F0
	public int get_Hour() { }

	// RVA: 0x373830 Offset: 0x373931 VA: 0x373830
	public DateTimeKind get_Kind() { }

	// RVA: 0x373860 Offset: 0x373961 VA: 0x373860
	public int get_Minute() { }

	// RVA: 0x3738A0 Offset: 0x3739A1 VA: 0x3738A0
	public int get_Month() { }

	// RVA: 0x2986660 Offset: 0x2986761 VA: 0x2986660
	public static DateTime get_Now() { }

	// RVA: 0x2986810 Offset: 0x2986911 VA: 0x2986810
	public static DateTime get_UtcNow() { }

	// RVA: 0x2986890 Offset: 0x2986991 VA: 0x2986890
	internal static long GetSystemTimeAsFileTime() { }

	// RVA: 0x3738B0 Offset: 0x3739B1 VA: 0x3738B0
	public int get_Second() { }

	// RVA: 0x3738F0 Offset: 0x3739F1 VA: 0x3738F0
	public long get_Ticks() { }

	// RVA: 0x373900 Offset: 0x373A01 VA: 0x373900
	public TimeSpan get_TimeOfDay() { }

	// RVA: 0x373940 Offset: 0x373A41 VA: 0x373940
	public int get_Year() { }

	// RVA: 0x2985E00 Offset: 0x2985F01 VA: 0x2985E00
	public static bool IsLeapYear(int year) { }

	// RVA: 0x2981670 Offset: 0x2981771 VA: 0x2981670
	public static DateTime Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2986A50 Offset: 0x2986B51 VA: 0x2986A50
	public static DateTime ParseExact(string s, string format, IFormatProvider provider) { }

	// RVA: 0x2986B10 Offset: 0x2986C11 VA: 0x2986B10
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x373A70 Offset: 0x373B71 VA: 0x373A70
	public DateTime ToLocalTime() { }

	// RVA: 0x373A80 Offset: 0x373B81 VA: 0x373A80
	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	// RVA: 0x373A90 Offset: 0x373B91 VA: 0x373A90
	public string ToLongTimeString() { }

	// RVA: 0x373AA0 Offset: 0x373BA1 VA: 0x373AA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x373AB0 Offset: 0x373BB1 VA: 0x373AB0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x373AC0 Offset: 0x373BC1 VA: 0x373AC0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x373AD0 Offset: 0x373BD1 VA: 0x373AD0
	public DateTime ToUniversalTime() { }

	// RVA: 0x2987270 Offset: 0x2987371 VA: 0x2987270
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x2987350 Offset: 0x2987451 VA: 0x2987350
	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	// RVA: 0x2987430 Offset: 0x2987531 VA: 0x2987430
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	// RVA: 0x2987510 Offset: 0x2987611 VA: 0x2987510
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	// RVA: 0x2987520 Offset: 0x2987621 VA: 0x2987520
	public static bool op_Equality(DateTime d1, DateTime d2) { }

	// RVA: 0x2987530 Offset: 0x2987631 VA: 0x2987530
	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	// RVA: 0x2987540 Offset: 0x2987641 VA: 0x2987540
	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	// RVA: 0x2987560 Offset: 0x2987661 VA: 0x2987560
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x2987580 Offset: 0x2987681 VA: 0x2987580
	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	// RVA: 0x29875A0 Offset: 0x29876A1 VA: 0x29875A0
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x373AE0 Offset: 0x373BE1 VA: 0x373AE0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x373AF0 Offset: 0x373BF1 VA: 0x373AF0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x373B00 Offset: 0x373C01 VA: 0x373B00 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x373B10 Offset: 0x373C11 VA: 0x373B10 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x373B20 Offset: 0x373C21 VA: 0x373B20 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x373B30 Offset: 0x373C31 VA: 0x373B30 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x373B40 Offset: 0x373C41 VA: 0x373B40 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x373B50 Offset: 0x373C51 VA: 0x373B50 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x373B60 Offset: 0x373C61 VA: 0x373B60 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x373B70 Offset: 0x373C71 VA: 0x373B70 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x373B80 Offset: 0x373C81 VA: 0x373B80 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x373B90 Offset: 0x373C91 VA: 0x373B90 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x373BA0 Offset: 0x373CA1 VA: 0x373BA0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x373BB0 Offset: 0x373CB1 VA: 0x373BB0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x373BC0 Offset: 0x373CC1 VA: 0x373BC0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x373BD0 Offset: 0x373CD1 VA: 0x373BD0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x29882C0 Offset: 0x29883C1 VA: 0x29882C0
	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	// RVA: 0x2988500 Offset: 0x2988601 VA: 0x2988500
	private static void .cctor() { }
}

