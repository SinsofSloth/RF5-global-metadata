[ComVisibleAttribute] // RVA: 0xAC720 Offset: 0xAC821 VA: 0xAC720
[Serializable]
public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float> // TypeDefIndex: 308
{
	// Fields
	internal float m_value; // 0x0
	public const float MinValue = -3.4028235E+38;
	public const float Epsilon = 1E-45;
	public const float MaxValue = 3.4028235E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = NaN;

	// Methods

	// RVA: 0x2645FF0 Offset: 0x26460F1 VA: 0x2645FF0
	public static bool IsInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D20 Offset: 0xB6E21 VA: 0xB6D20
	// RVA: 0x2646010 Offset: 0x2646111 VA: 0x2646010
	public static bool IsNaN(float f) { }

	// RVA: 0x354B40 Offset: 0x354C41 VA: 0x354B40 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x354B50 Offset: 0x354C51 VA: 0x354B50 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x354BB0 Offset: 0x354CB1 VA: 0x354BB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x354CB0 Offset: 0x354DB1 VA: 0x354CB0 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x354D00 Offset: 0x354E01 VA: 0x354D00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x354D20 Offset: 0x354E21 VA: 0x354D20 Slot: 3
	public override string ToString() { }

	// RVA: 0x354D60 Offset: 0x354E61 VA: 0x354D60 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x354DA0 Offset: 0x354EA1 VA: 0x354DA0
	public string ToString(string format) { }

	// RVA: 0x354DE0 Offset: 0x354EE1 VA: 0x354DE0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2646490 Offset: 0x2646591 VA: 0x2646490
	public static float Parse(string s) { }

	// RVA: 0x26464E0 Offset: 0x26465E1 VA: 0x26464E0
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2646520 Offset: 0x2646621 VA: 0x2646520
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x26464D0 Offset: 0x26465D1 VA: 0x26464D0
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2646580 Offset: 0x2646681 VA: 0x2646580
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x26465C0 Offset: 0x26466C1 VA: 0x26465C0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x354E30 Offset: 0x354F31 VA: 0x354E30 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x354E40 Offset: 0x354F41 VA: 0x354E40 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x354EC0 Offset: 0x354FC1 VA: 0x354EC0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x354ED0 Offset: 0x354FD1 VA: 0x354ED0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x354F50 Offset: 0x355051 VA: 0x354F50 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x354FD0 Offset: 0x3550D1 VA: 0x354FD0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x355050 Offset: 0x355151 VA: 0x355050 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3550D0 Offset: 0x3551D1 VA: 0x3550D0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x355150 Offset: 0x355251 VA: 0x355150 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3551D0 Offset: 0x3552D1 VA: 0x3551D0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x355250 Offset: 0x355351 VA: 0x355250 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3552D0 Offset: 0x3553D1 VA: 0x3552D0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3552E0 Offset: 0x3553E1 VA: 0x3552E0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x355360 Offset: 0x355461 VA: 0x355360 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3553E0 Offset: 0x3554E1 VA: 0x3553E0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3553F0 Offset: 0x3554F1 VA: 0x3553F0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

[ComVisibleAttribute] // RVA: 0xAC720 Offset: 0xAC821 VA: 0xAC720
[Serializable]
public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float> // TypeDefIndex: 308
{
	// Fields
	internal float m_value; // 0x0
	public const float MinValue = -3.4028235E+38;
	public const float Epsilon = 1E-45;
	public const float MaxValue = 3.4028235E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = NaN;

	// Methods

	// RVA: 0x2645FF0 Offset: 0x26460F1 VA: 0x2645FF0
	public static bool IsInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D20 Offset: 0xB6E21 VA: 0xB6D20
	// RVA: 0x2646010 Offset: 0x2646111 VA: 0x2646010
	public static bool IsNaN(float f) { }

	// RVA: 0x354B40 Offset: 0x354C41 VA: 0x354B40 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x354B50 Offset: 0x354C51 VA: 0x354B50 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x354BB0 Offset: 0x354CB1 VA: 0x354BB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x354CB0 Offset: 0x354DB1 VA: 0x354CB0 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x354D00 Offset: 0x354E01 VA: 0x354D00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x354D20 Offset: 0x354E21 VA: 0x354D20 Slot: 3
	public override string ToString() { }

	// RVA: 0x354D60 Offset: 0x354E61 VA: 0x354D60 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x354DA0 Offset: 0x354EA1 VA: 0x354DA0
	public string ToString(string format) { }

	// RVA: 0x354DE0 Offset: 0x354EE1 VA: 0x354DE0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2646490 Offset: 0x2646591 VA: 0x2646490
	public static float Parse(string s) { }

	// RVA: 0x26464E0 Offset: 0x26465E1 VA: 0x26464E0
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2646520 Offset: 0x2646621 VA: 0x2646520
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x26464D0 Offset: 0x26465D1 VA: 0x26464D0
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2646580 Offset: 0x2646681 VA: 0x2646580
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x26465C0 Offset: 0x26466C1 VA: 0x26465C0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x354E30 Offset: 0x354F31 VA: 0x354E30 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x354E40 Offset: 0x354F41 VA: 0x354E40 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x354EC0 Offset: 0x354FC1 VA: 0x354EC0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x354ED0 Offset: 0x354FD1 VA: 0x354ED0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x354F50 Offset: 0x355051 VA: 0x354F50 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x354FD0 Offset: 0x3550D1 VA: 0x354FD0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x355050 Offset: 0x355151 VA: 0x355050 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3550D0 Offset: 0x3551D1 VA: 0x3550D0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x355150 Offset: 0x355251 VA: 0x355150 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3551D0 Offset: 0x3552D1 VA: 0x3551D0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x355250 Offset: 0x355351 VA: 0x355250 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3552D0 Offset: 0x3553D1 VA: 0x3552D0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3552E0 Offset: 0x3553E1 VA: 0x3552E0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x355360 Offset: 0x355461 VA: 0x355360 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3553E0 Offset: 0x3554E1 VA: 0x3553E0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3553F0 Offset: 0x3554F1 VA: 0x3553F0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

[ComVisibleAttribute] // RVA: 0xAC720 Offset: 0xAC821 VA: 0xAC720
[Serializable]
public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float> // TypeDefIndex: 308
{
	// Fields
	internal float m_value; // 0x0
	public const float MinValue = -3.4028235E+38;
	public const float Epsilon = 1E-45;
	public const float MaxValue = 3.4028235E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = NaN;

	// Methods

	// RVA: 0x2645FF0 Offset: 0x26460F1 VA: 0x2645FF0
	public static bool IsInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D20 Offset: 0xB6E21 VA: 0xB6D20
	// RVA: 0x2646010 Offset: 0x2646111 VA: 0x2646010
	public static bool IsNaN(float f) { }

	// RVA: 0x354B40 Offset: 0x354C41 VA: 0x354B40 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x354B50 Offset: 0x354C51 VA: 0x354B50 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x354BB0 Offset: 0x354CB1 VA: 0x354BB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x354CB0 Offset: 0x354DB1 VA: 0x354CB0 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x354D00 Offset: 0x354E01 VA: 0x354D00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x354D20 Offset: 0x354E21 VA: 0x354D20 Slot: 3
	public override string ToString() { }

	// RVA: 0x354D60 Offset: 0x354E61 VA: 0x354D60 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x354DA0 Offset: 0x354EA1 VA: 0x354DA0
	public string ToString(string format) { }

	// RVA: 0x354DE0 Offset: 0x354EE1 VA: 0x354DE0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2646490 Offset: 0x2646591 VA: 0x2646490
	public static float Parse(string s) { }

	// RVA: 0x26464E0 Offset: 0x26465E1 VA: 0x26464E0
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2646520 Offset: 0x2646621 VA: 0x2646520
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x26464D0 Offset: 0x26465D1 VA: 0x26464D0
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2646580 Offset: 0x2646681 VA: 0x2646580
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x26465C0 Offset: 0x26466C1 VA: 0x26465C0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x354E30 Offset: 0x354F31 VA: 0x354E30 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x354E40 Offset: 0x354F41 VA: 0x354E40 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x354EC0 Offset: 0x354FC1 VA: 0x354EC0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x354ED0 Offset: 0x354FD1 VA: 0x354ED0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x354F50 Offset: 0x355051 VA: 0x354F50 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x354FD0 Offset: 0x3550D1 VA: 0x354FD0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x355050 Offset: 0x355151 VA: 0x355050 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3550D0 Offset: 0x3551D1 VA: 0x3550D0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x355150 Offset: 0x355251 VA: 0x355150 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3551D0 Offset: 0x3552D1 VA: 0x3551D0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x355250 Offset: 0x355351 VA: 0x355250 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3552D0 Offset: 0x3553D1 VA: 0x3552D0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3552E0 Offset: 0x3553E1 VA: 0x3552E0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x355360 Offset: 0x355461 VA: 0x355360 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3553E0 Offset: 0x3554E1 VA: 0x3553E0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3553F0 Offset: 0x3554F1 VA: 0x3553F0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

[ComVisibleAttribute] // RVA: 0xAC720 Offset: 0xAC821 VA: 0xAC720
[Serializable]
public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float> // TypeDefIndex: 308
{
	// Fields
	internal float m_value; // 0x0
	public const float MinValue = -3.4028235E+38;
	public const float Epsilon = 1E-45;
	public const float MaxValue = 3.4028235E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = NaN;

	// Methods

	// RVA: 0x2645FF0 Offset: 0x26460F1 VA: 0x2645FF0
	public static bool IsInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D20 Offset: 0xB6E21 VA: 0xB6D20
	// RVA: 0x2646010 Offset: 0x2646111 VA: 0x2646010
	public static bool IsNaN(float f) { }

	// RVA: 0x354B40 Offset: 0x354C41 VA: 0x354B40 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x354B50 Offset: 0x354C51 VA: 0x354B50 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x354BB0 Offset: 0x354CB1 VA: 0x354BB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x354CB0 Offset: 0x354DB1 VA: 0x354CB0 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x354D00 Offset: 0x354E01 VA: 0x354D00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x354D20 Offset: 0x354E21 VA: 0x354D20 Slot: 3
	public override string ToString() { }

	// RVA: 0x354D60 Offset: 0x354E61 VA: 0x354D60 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x354DA0 Offset: 0x354EA1 VA: 0x354DA0
	public string ToString(string format) { }

	// RVA: 0x354DE0 Offset: 0x354EE1 VA: 0x354DE0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2646490 Offset: 0x2646591 VA: 0x2646490
	public static float Parse(string s) { }

	// RVA: 0x26464E0 Offset: 0x26465E1 VA: 0x26464E0
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2646520 Offset: 0x2646621 VA: 0x2646520
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x26464D0 Offset: 0x26465D1 VA: 0x26464D0
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2646580 Offset: 0x2646681 VA: 0x2646580
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x26465C0 Offset: 0x26466C1 VA: 0x26465C0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x354E30 Offset: 0x354F31 VA: 0x354E30 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x354E40 Offset: 0x354F41 VA: 0x354E40 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x354EC0 Offset: 0x354FC1 VA: 0x354EC0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x354ED0 Offset: 0x354FD1 VA: 0x354ED0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x354F50 Offset: 0x355051 VA: 0x354F50 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x354FD0 Offset: 0x3550D1 VA: 0x354FD0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x355050 Offset: 0x355151 VA: 0x355050 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3550D0 Offset: 0x3551D1 VA: 0x3550D0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x355150 Offset: 0x355251 VA: 0x355150 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3551D0 Offset: 0x3552D1 VA: 0x3551D0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x355250 Offset: 0x355351 VA: 0x355250 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3552D0 Offset: 0x3553D1 VA: 0x3552D0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3552E0 Offset: 0x3553E1 VA: 0x3552E0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x355360 Offset: 0x355461 VA: 0x355360 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3553E0 Offset: 0x3554E1 VA: 0x3553E0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3553F0 Offset: 0x3554F1 VA: 0x3553F0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

[ComVisibleAttribute] // RVA: 0xAC720 Offset: 0xAC821 VA: 0xAC720
[Serializable]
public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float> // TypeDefIndex: 308
{
	// Fields
	internal float m_value; // 0x0
	public const float MinValue = -3.4028235E+38;
	public const float Epsilon = 1E-45;
	public const float MaxValue = 3.4028235E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = NaN;

	// Methods

	// RVA: 0x2645FF0 Offset: 0x26460F1 VA: 0x2645FF0
	public static bool IsInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D20 Offset: 0xB6E21 VA: 0xB6D20
	// RVA: 0x2646010 Offset: 0x2646111 VA: 0x2646010
	public static bool IsNaN(float f) { }

	// RVA: 0x354B40 Offset: 0x354C41 VA: 0x354B40 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x354B50 Offset: 0x354C51 VA: 0x354B50 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x354BB0 Offset: 0x354CB1 VA: 0x354BB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x354CB0 Offset: 0x354DB1 VA: 0x354CB0 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x354D00 Offset: 0x354E01 VA: 0x354D00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x354D20 Offset: 0x354E21 VA: 0x354D20 Slot: 3
	public override string ToString() { }

	// RVA: 0x354D60 Offset: 0x354E61 VA: 0x354D60 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x354DA0 Offset: 0x354EA1 VA: 0x354DA0
	public string ToString(string format) { }

	// RVA: 0x354DE0 Offset: 0x354EE1 VA: 0x354DE0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2646490 Offset: 0x2646591 VA: 0x2646490
	public static float Parse(string s) { }

	// RVA: 0x26464E0 Offset: 0x26465E1 VA: 0x26464E0
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2646520 Offset: 0x2646621 VA: 0x2646520
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x26464D0 Offset: 0x26465D1 VA: 0x26464D0
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2646580 Offset: 0x2646681 VA: 0x2646580
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x26465C0 Offset: 0x26466C1 VA: 0x26465C0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x354E30 Offset: 0x354F31 VA: 0x354E30 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x354E40 Offset: 0x354F41 VA: 0x354E40 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x354EC0 Offset: 0x354FC1 VA: 0x354EC0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x354ED0 Offset: 0x354FD1 VA: 0x354ED0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x354F50 Offset: 0x355051 VA: 0x354F50 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x354FD0 Offset: 0x3550D1 VA: 0x354FD0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x355050 Offset: 0x355151 VA: 0x355050 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3550D0 Offset: 0x3551D1 VA: 0x3550D0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x355150 Offset: 0x355251 VA: 0x355150 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3551D0 Offset: 0x3552D1 VA: 0x3551D0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x355250 Offset: 0x355351 VA: 0x355250 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3552D0 Offset: 0x3553D1 VA: 0x3552D0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3552E0 Offset: 0x3553E1 VA: 0x3552E0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x355360 Offset: 0x355461 VA: 0x355360 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3553E0 Offset: 0x3554E1 VA: 0x3553E0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3553F0 Offset: 0x3554F1 VA: 0x3553F0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

[ComVisibleAttribute] // RVA: 0xAC720 Offset: 0xAC821 VA: 0xAC720
[Serializable]
public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float> // TypeDefIndex: 308
{
	// Fields
	internal float m_value; // 0x0
	public const float MinValue = -3.4028235E+38;
	public const float Epsilon = 1E-45;
	public const float MaxValue = 3.4028235E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = NaN;

	// Methods

	// RVA: 0x2645FF0 Offset: 0x26460F1 VA: 0x2645FF0
	public static bool IsInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D20 Offset: 0xB6E21 VA: 0xB6D20
	// RVA: 0x2646010 Offset: 0x2646111 VA: 0x2646010
	public static bool IsNaN(float f) { }

	// RVA: 0x354B40 Offset: 0x354C41 VA: 0x354B40 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x354B50 Offset: 0x354C51 VA: 0x354B50 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x354BB0 Offset: 0x354CB1 VA: 0x354BB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x354CB0 Offset: 0x354DB1 VA: 0x354CB0 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x354D00 Offset: 0x354E01 VA: 0x354D00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x354D20 Offset: 0x354E21 VA: 0x354D20 Slot: 3
	public override string ToString() { }

	// RVA: 0x354D60 Offset: 0x354E61 VA: 0x354D60 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x354DA0 Offset: 0x354EA1 VA: 0x354DA0
	public string ToString(string format) { }

	// RVA: 0x354DE0 Offset: 0x354EE1 VA: 0x354DE0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2646490 Offset: 0x2646591 VA: 0x2646490
	public static float Parse(string s) { }

	// RVA: 0x26464E0 Offset: 0x26465E1 VA: 0x26464E0
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2646520 Offset: 0x2646621 VA: 0x2646520
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x26464D0 Offset: 0x26465D1 VA: 0x26464D0
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2646580 Offset: 0x2646681 VA: 0x2646580
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x26465C0 Offset: 0x26466C1 VA: 0x26465C0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x354E30 Offset: 0x354F31 VA: 0x354E30 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x354E40 Offset: 0x354F41 VA: 0x354E40 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x354EC0 Offset: 0x354FC1 VA: 0x354EC0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x354ED0 Offset: 0x354FD1 VA: 0x354ED0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x354F50 Offset: 0x355051 VA: 0x354F50 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x354FD0 Offset: 0x3550D1 VA: 0x354FD0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x355050 Offset: 0x355151 VA: 0x355050 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3550D0 Offset: 0x3551D1 VA: 0x3550D0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x355150 Offset: 0x355251 VA: 0x355150 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3551D0 Offset: 0x3552D1 VA: 0x3551D0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x355250 Offset: 0x355351 VA: 0x355250 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3552D0 Offset: 0x3553D1 VA: 0x3552D0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3552E0 Offset: 0x3553E1 VA: 0x3552E0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x355360 Offset: 0x355461 VA: 0x355360 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3553E0 Offset: 0x3554E1 VA: 0x3553E0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3553F0 Offset: 0x3554F1 VA: 0x3553F0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

[ComVisibleAttribute] // RVA: 0xAC720 Offset: 0xAC821 VA: 0xAC720
[Serializable]
public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float> // TypeDefIndex: 308
{
	// Fields
	internal float m_value; // 0x0
	public const float MinValue = -3.4028235E+38;
	public const float Epsilon = 1E-45;
	public const float MaxValue = 3.4028235E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = NaN;

	// Methods

	// RVA: 0x2645FF0 Offset: 0x26460F1 VA: 0x2645FF0
	public static bool IsInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D20 Offset: 0xB6E21 VA: 0xB6D20
	// RVA: 0x2646010 Offset: 0x2646111 VA: 0x2646010
	public static bool IsNaN(float f) { }

	// RVA: 0x354B40 Offset: 0x354C41 VA: 0x354B40 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x354B50 Offset: 0x354C51 VA: 0x354B50 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x354BB0 Offset: 0x354CB1 VA: 0x354BB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x354CB0 Offset: 0x354DB1 VA: 0x354CB0 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x354D00 Offset: 0x354E01 VA: 0x354D00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x354D20 Offset: 0x354E21 VA: 0x354D20 Slot: 3
	public override string ToString() { }

	// RVA: 0x354D60 Offset: 0x354E61 VA: 0x354D60 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x354DA0 Offset: 0x354EA1 VA: 0x354DA0
	public string ToString(string format) { }

	// RVA: 0x354DE0 Offset: 0x354EE1 VA: 0x354DE0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2646490 Offset: 0x2646591 VA: 0x2646490
	public static float Parse(string s) { }

	// RVA: 0x26464E0 Offset: 0x26465E1 VA: 0x26464E0
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2646520 Offset: 0x2646621 VA: 0x2646520
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x26464D0 Offset: 0x26465D1 VA: 0x26464D0
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x2646580 Offset: 0x2646681 VA: 0x2646580
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x26465C0 Offset: 0x26466C1 VA: 0x26465C0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x354E30 Offset: 0x354F31 VA: 0x354E30 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x354E40 Offset: 0x354F41 VA: 0x354E40 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x354EC0 Offset: 0x354FC1 VA: 0x354EC0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x354ED0 Offset: 0x354FD1 VA: 0x354ED0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x354F50 Offset: 0x355051 VA: 0x354F50 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x354FD0 Offset: 0x3550D1 VA: 0x354FD0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x355050 Offset: 0x355151 VA: 0x355050 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3550D0 Offset: 0x3551D1 VA: 0x3550D0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x355150 Offset: 0x355251 VA: 0x355150 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3551D0 Offset: 0x3552D1 VA: 0x3551D0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x355250 Offset: 0x355351 VA: 0x355250 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3552D0 Offset: 0x3553D1 VA: 0x3552D0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3552E0 Offset: 0x3553E1 VA: 0x3552E0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x355360 Offset: 0x355461 VA: 0x355360 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3553E0 Offset: 0x3554E1 VA: 0x3553E0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3553F0 Offset: 0x3554F1 VA: 0x3553F0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

