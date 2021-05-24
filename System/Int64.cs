[ComVisibleAttribute] // RVA: 0xAC220 Offset: 0xAC321 VA: 0xAC220
[Serializable]
public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 270
{
	// Fields
	internal long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0xFA60 Offset: 0xFB61 VA: 0xFA60 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0xFA70 Offset: 0xFB71 VA: 0xFA70 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0xFA90 Offset: 0xFB91 VA: 0xFA90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xFB40 Offset: 0xFC41 VA: 0xFB40 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0xFB50 Offset: 0xFC51 VA: 0xFB50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFB60 Offset: 0xFC61 VA: 0xFB60 Slot: 3
	public override string ToString() { }

	// RVA: 0xFBE0 Offset: 0xFCE1 VA: 0xFBE0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0xFC70 Offset: 0xFD71 VA: 0xFC70
	public string ToString(string format) { }

	// RVA: 0xFD00 Offset: 0xFE01 VA: 0xFD00 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x18D95E0 Offset: 0x18D96E1 VA: 0x18D95E0
	public static long Parse(string s) { }

	// RVA: 0x18D9840 Offset: 0x18D9941 VA: 0x18D9840
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18D9880 Offset: 0x18D9981 VA: 0x18D9880
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18D98D0 Offset: 0x18D99D1 VA: 0x18D98D0
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x18D9B90 Offset: 0x18D9C91 VA: 0x18D9B90
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0xFD90 Offset: 0xFE91 VA: 0xFD90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0xFDA0 Offset: 0xFEA1 VA: 0xFDA0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xFE10 Offset: 0xFF11 VA: 0xFE10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xFE80 Offset: 0xFF81 VA: 0xFE80 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xFEF0 Offset: 0xFFF1 VA: 0xFEF0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xFF60 Offset: 0x10061 VA: 0xFF60 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xFFD0 Offset: 0x100D1 VA: 0xFFD0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x10040 Offset: 0x10141 VA: 0x10040 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x100B0 Offset: 0x101B1 VA: 0x100B0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x10120 Offset: 0x10221 VA: 0x10120 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x10130 Offset: 0x10231 VA: 0x10130 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x101A0 Offset: 0x102A1 VA: 0x101A0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x10210 Offset: 0x10311 VA: 0x10210 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x10280 Offset: 0x10381 VA: 0x10280 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x102F0 Offset: 0x103F1 VA: 0x102F0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x10300 Offset: 0x10401 VA: 0x10300 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

[ComVisibleAttribute] // RVA: 0xAC220 Offset: 0xAC321 VA: 0xAC220
[Serializable]
public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 270
{
	// Fields
	internal long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0xFA60 Offset: 0xFB61 VA: 0xFA60 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0xFA70 Offset: 0xFB71 VA: 0xFA70 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0xFA90 Offset: 0xFB91 VA: 0xFA90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xFB40 Offset: 0xFC41 VA: 0xFB40 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0xFB50 Offset: 0xFC51 VA: 0xFB50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFB60 Offset: 0xFC61 VA: 0xFB60 Slot: 3
	public override string ToString() { }

	// RVA: 0xFBE0 Offset: 0xFCE1 VA: 0xFBE0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0xFC70 Offset: 0xFD71 VA: 0xFC70
	public string ToString(string format) { }

	// RVA: 0xFD00 Offset: 0xFE01 VA: 0xFD00 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x18D95E0 Offset: 0x18D96E1 VA: 0x18D95E0
	public static long Parse(string s) { }

	// RVA: 0x18D9840 Offset: 0x18D9941 VA: 0x18D9840
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18D9880 Offset: 0x18D9981 VA: 0x18D9880
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18D98D0 Offset: 0x18D99D1 VA: 0x18D98D0
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x18D9B90 Offset: 0x18D9C91 VA: 0x18D9B90
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0xFD90 Offset: 0xFE91 VA: 0xFD90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0xFDA0 Offset: 0xFEA1 VA: 0xFDA0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xFE10 Offset: 0xFF11 VA: 0xFE10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xFE80 Offset: 0xFF81 VA: 0xFE80 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xFEF0 Offset: 0xFFF1 VA: 0xFEF0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xFF60 Offset: 0x10061 VA: 0xFF60 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xFFD0 Offset: 0x100D1 VA: 0xFFD0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x10040 Offset: 0x10141 VA: 0x10040 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x100B0 Offset: 0x101B1 VA: 0x100B0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x10120 Offset: 0x10221 VA: 0x10120 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x10130 Offset: 0x10231 VA: 0x10130 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x101A0 Offset: 0x102A1 VA: 0x101A0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x10210 Offset: 0x10311 VA: 0x10210 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x10280 Offset: 0x10381 VA: 0x10280 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x102F0 Offset: 0x103F1 VA: 0x102F0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x10300 Offset: 0x10401 VA: 0x10300 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

[ComVisibleAttribute] // RVA: 0xAC220 Offset: 0xAC321 VA: 0xAC220
[Serializable]
public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 270
{
	// Fields
	internal long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0xFA60 Offset: 0xFB61 VA: 0xFA60 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0xFA70 Offset: 0xFB71 VA: 0xFA70 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0xFA90 Offset: 0xFB91 VA: 0xFA90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xFB40 Offset: 0xFC41 VA: 0xFB40 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0xFB50 Offset: 0xFC51 VA: 0xFB50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFB60 Offset: 0xFC61 VA: 0xFB60 Slot: 3
	public override string ToString() { }

	// RVA: 0xFBE0 Offset: 0xFCE1 VA: 0xFBE0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0xFC70 Offset: 0xFD71 VA: 0xFC70
	public string ToString(string format) { }

	// RVA: 0xFD00 Offset: 0xFE01 VA: 0xFD00 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x18D95E0 Offset: 0x18D96E1 VA: 0x18D95E0
	public static long Parse(string s) { }

	// RVA: 0x18D9840 Offset: 0x18D9941 VA: 0x18D9840
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18D9880 Offset: 0x18D9981 VA: 0x18D9880
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18D98D0 Offset: 0x18D99D1 VA: 0x18D98D0
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x18D9B90 Offset: 0x18D9C91 VA: 0x18D9B90
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0xFD90 Offset: 0xFE91 VA: 0xFD90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0xFDA0 Offset: 0xFEA1 VA: 0xFDA0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xFE10 Offset: 0xFF11 VA: 0xFE10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xFE80 Offset: 0xFF81 VA: 0xFE80 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xFEF0 Offset: 0xFFF1 VA: 0xFEF0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xFF60 Offset: 0x10061 VA: 0xFF60 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xFFD0 Offset: 0x100D1 VA: 0xFFD0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x10040 Offset: 0x10141 VA: 0x10040 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x100B0 Offset: 0x101B1 VA: 0x100B0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x10120 Offset: 0x10221 VA: 0x10120 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x10130 Offset: 0x10231 VA: 0x10130 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x101A0 Offset: 0x102A1 VA: 0x101A0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x10210 Offset: 0x10311 VA: 0x10210 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x10280 Offset: 0x10381 VA: 0x10280 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x102F0 Offset: 0x103F1 VA: 0x102F0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x10300 Offset: 0x10401 VA: 0x10300 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

[ComVisibleAttribute] // RVA: 0xAC220 Offset: 0xAC321 VA: 0xAC220
[Serializable]
public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 270
{
	// Fields
	internal long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0xFA60 Offset: 0xFB61 VA: 0xFA60 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0xFA70 Offset: 0xFB71 VA: 0xFA70 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0xFA90 Offset: 0xFB91 VA: 0xFA90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xFB40 Offset: 0xFC41 VA: 0xFB40 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0xFB50 Offset: 0xFC51 VA: 0xFB50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFB60 Offset: 0xFC61 VA: 0xFB60 Slot: 3
	public override string ToString() { }

	// RVA: 0xFBE0 Offset: 0xFCE1 VA: 0xFBE0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0xFC70 Offset: 0xFD71 VA: 0xFC70
	public string ToString(string format) { }

	// RVA: 0xFD00 Offset: 0xFE01 VA: 0xFD00 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x18D95E0 Offset: 0x18D96E1 VA: 0x18D95E0
	public static long Parse(string s) { }

	// RVA: 0x18D9840 Offset: 0x18D9941 VA: 0x18D9840
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18D9880 Offset: 0x18D9981 VA: 0x18D9880
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18D98D0 Offset: 0x18D99D1 VA: 0x18D98D0
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x18D9B90 Offset: 0x18D9C91 VA: 0x18D9B90
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0xFD90 Offset: 0xFE91 VA: 0xFD90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0xFDA0 Offset: 0xFEA1 VA: 0xFDA0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xFE10 Offset: 0xFF11 VA: 0xFE10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xFE80 Offset: 0xFF81 VA: 0xFE80 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xFEF0 Offset: 0xFFF1 VA: 0xFEF0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xFF60 Offset: 0x10061 VA: 0xFF60 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xFFD0 Offset: 0x100D1 VA: 0xFFD0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x10040 Offset: 0x10141 VA: 0x10040 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x100B0 Offset: 0x101B1 VA: 0x100B0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x10120 Offset: 0x10221 VA: 0x10120 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x10130 Offset: 0x10231 VA: 0x10130 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x101A0 Offset: 0x102A1 VA: 0x101A0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x10210 Offset: 0x10311 VA: 0x10210 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x10280 Offset: 0x10381 VA: 0x10280 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x102F0 Offset: 0x103F1 VA: 0x102F0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x10300 Offset: 0x10401 VA: 0x10300 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

[ComVisibleAttribute] // RVA: 0xAC220 Offset: 0xAC321 VA: 0xAC220
[Serializable]
public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 270
{
	// Fields
	internal long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0xFA60 Offset: 0xFB61 VA: 0xFA60 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0xFA70 Offset: 0xFB71 VA: 0xFA70 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0xFA90 Offset: 0xFB91 VA: 0xFA90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xFB40 Offset: 0xFC41 VA: 0xFB40 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0xFB50 Offset: 0xFC51 VA: 0xFB50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFB60 Offset: 0xFC61 VA: 0xFB60 Slot: 3
	public override string ToString() { }

	// RVA: 0xFBE0 Offset: 0xFCE1 VA: 0xFBE0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0xFC70 Offset: 0xFD71 VA: 0xFC70
	public string ToString(string format) { }

	// RVA: 0xFD00 Offset: 0xFE01 VA: 0xFD00 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x18D95E0 Offset: 0x18D96E1 VA: 0x18D95E0
	public static long Parse(string s) { }

	// RVA: 0x18D9840 Offset: 0x18D9941 VA: 0x18D9840
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18D9880 Offset: 0x18D9981 VA: 0x18D9880
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18D98D0 Offset: 0x18D99D1 VA: 0x18D98D0
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x18D9B90 Offset: 0x18D9C91 VA: 0x18D9B90
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0xFD90 Offset: 0xFE91 VA: 0xFD90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0xFDA0 Offset: 0xFEA1 VA: 0xFDA0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xFE10 Offset: 0xFF11 VA: 0xFE10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xFE80 Offset: 0xFF81 VA: 0xFE80 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xFEF0 Offset: 0xFFF1 VA: 0xFEF0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xFF60 Offset: 0x10061 VA: 0xFF60 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xFFD0 Offset: 0x100D1 VA: 0xFFD0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x10040 Offset: 0x10141 VA: 0x10040 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x100B0 Offset: 0x101B1 VA: 0x100B0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x10120 Offset: 0x10221 VA: 0x10120 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x10130 Offset: 0x10231 VA: 0x10130 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x101A0 Offset: 0x102A1 VA: 0x101A0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x10210 Offset: 0x10311 VA: 0x10210 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x10280 Offset: 0x10381 VA: 0x10280 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x102F0 Offset: 0x103F1 VA: 0x102F0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x10300 Offset: 0x10401 VA: 0x10300 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

[ComVisibleAttribute] // RVA: 0xAC220 Offset: 0xAC321 VA: 0xAC220
[Serializable]
public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 270
{
	// Fields
	internal long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0xFA60 Offset: 0xFB61 VA: 0xFA60 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0xFA70 Offset: 0xFB71 VA: 0xFA70 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0xFA90 Offset: 0xFB91 VA: 0xFA90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xFB40 Offset: 0xFC41 VA: 0xFB40 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0xFB50 Offset: 0xFC51 VA: 0xFB50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFB60 Offset: 0xFC61 VA: 0xFB60 Slot: 3
	public override string ToString() { }

	// RVA: 0xFBE0 Offset: 0xFCE1 VA: 0xFBE0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0xFC70 Offset: 0xFD71 VA: 0xFC70
	public string ToString(string format) { }

	// RVA: 0xFD00 Offset: 0xFE01 VA: 0xFD00 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x18D95E0 Offset: 0x18D96E1 VA: 0x18D95E0
	public static long Parse(string s) { }

	// RVA: 0x18D9840 Offset: 0x18D9941 VA: 0x18D9840
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18D9880 Offset: 0x18D9981 VA: 0x18D9880
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18D98D0 Offset: 0x18D99D1 VA: 0x18D98D0
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x18D9B90 Offset: 0x18D9C91 VA: 0x18D9B90
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0xFD90 Offset: 0xFE91 VA: 0xFD90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0xFDA0 Offset: 0xFEA1 VA: 0xFDA0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xFE10 Offset: 0xFF11 VA: 0xFE10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xFE80 Offset: 0xFF81 VA: 0xFE80 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xFEF0 Offset: 0xFFF1 VA: 0xFEF0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xFF60 Offset: 0x10061 VA: 0xFF60 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xFFD0 Offset: 0x100D1 VA: 0xFFD0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x10040 Offset: 0x10141 VA: 0x10040 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x100B0 Offset: 0x101B1 VA: 0x100B0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x10120 Offset: 0x10221 VA: 0x10120 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x10130 Offset: 0x10231 VA: 0x10130 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x101A0 Offset: 0x102A1 VA: 0x101A0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x10210 Offset: 0x10311 VA: 0x10210 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x10280 Offset: 0x10381 VA: 0x10280 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x102F0 Offset: 0x103F1 VA: 0x102F0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x10300 Offset: 0x10401 VA: 0x10300 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

[ComVisibleAttribute] // RVA: 0xAC220 Offset: 0xAC321 VA: 0xAC220
[Serializable]
public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 270
{
	// Fields
	internal long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0xFA60 Offset: 0xFB61 VA: 0xFA60 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0xFA70 Offset: 0xFB71 VA: 0xFA70 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0xFA90 Offset: 0xFB91 VA: 0xFA90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xFB40 Offset: 0xFC41 VA: 0xFB40 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0xFB50 Offset: 0xFC51 VA: 0xFB50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFB60 Offset: 0xFC61 VA: 0xFB60 Slot: 3
	public override string ToString() { }

	// RVA: 0xFBE0 Offset: 0xFCE1 VA: 0xFBE0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0xFC70 Offset: 0xFD71 VA: 0xFC70
	public string ToString(string format) { }

	// RVA: 0xFD00 Offset: 0xFE01 VA: 0xFD00 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x18D95E0 Offset: 0x18D96E1 VA: 0x18D95E0
	public static long Parse(string s) { }

	// RVA: 0x18D9840 Offset: 0x18D9941 VA: 0x18D9840
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18D9880 Offset: 0x18D9981 VA: 0x18D9880
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18D98D0 Offset: 0x18D99D1 VA: 0x18D98D0
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x18D9B90 Offset: 0x18D9C91 VA: 0x18D9B90
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0xFD90 Offset: 0xFE91 VA: 0xFD90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0xFDA0 Offset: 0xFEA1 VA: 0xFDA0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xFE10 Offset: 0xFF11 VA: 0xFE10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xFE80 Offset: 0xFF81 VA: 0xFE80 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xFEF0 Offset: 0xFFF1 VA: 0xFEF0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xFF60 Offset: 0x10061 VA: 0xFF60 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xFFD0 Offset: 0x100D1 VA: 0xFFD0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x10040 Offset: 0x10141 VA: 0x10040 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x100B0 Offset: 0x101B1 VA: 0x100B0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x10120 Offset: 0x10221 VA: 0x10120 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x10130 Offset: 0x10231 VA: 0x10130 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x101A0 Offset: 0x102A1 VA: 0x101A0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x10210 Offset: 0x10311 VA: 0x10210 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x10280 Offset: 0x10381 VA: 0x10280 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x102F0 Offset: 0x103F1 VA: 0x102F0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x10300 Offset: 0x10401 VA: 0x10300 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

