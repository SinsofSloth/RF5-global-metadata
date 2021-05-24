[ComVisibleAttribute] // RVA: 0xABE10 Offset: 0xABF11 VA: 0xABE10
[Serializable]
public struct Double : IComparable, IFormattable, IConvertible, IComparable<double>, IEquatable<double> // TypeDefIndex: 218
{
	// Fields
	internal double m_value; // 0x0
	public const double MinValue = -1.7976931348623157E+308;
	public const double MaxValue = 1.7976931348623157E+308;
	public const double Epsilon = 5E-324;
	public const double NegativeInfinity = -∞;
	public const double PositiveInfinity = ∞;
	public const double NaN = NaN;
	internal static double NegativeZero; // 0x0

	// Methods

	// RVA: 0x19B6510 Offset: 0x19B6611 VA: 0x19B6510
	public static bool IsInfinity(double d) { }

	// RVA: 0x19B6530 Offset: 0x19B6631 VA: 0x19B6530
	public static bool IsPositiveInfinity(double d) { }

	// RVA: 0x19B6550 Offset: 0x19B6651 VA: 0x19B6550
	public static bool IsNegativeInfinity(double d) { }

	// RVA: 0x19B6570 Offset: 0x19B6671 VA: 0x19B6570
	internal static bool IsNegative(double d) { }

	[ReliabilityContractAttribute] // RVA: 0xB6700 Offset: 0xB6801 VA: 0xB6700
	// RVA: 0x19B6580 Offset: 0x19B6681 VA: 0x19B6580
	public static bool IsNaN(double d) { }

	// RVA: 0x142F0 Offset: 0x143F1 VA: 0x142F0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x14300 Offset: 0x14401 VA: 0x14300 Slot: 23
	public int CompareTo(double value) { }

	// RVA: 0x14420 Offset: 0x14521 VA: 0x14420 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14430 Offset: 0x14531 VA: 0x14430 Slot: 24
	public bool Equals(double obj) { }

	// RVA: 0x14520 Offset: 0x14621 VA: 0x14520 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14530 Offset: 0x14631 VA: 0x14530 Slot: 3
	public override string ToString() { }

	// RVA: 0x14570 Offset: 0x14671 VA: 0x14570
	public string ToString(string format) { }

	// RVA: 0x145B0 Offset: 0x146B1 VA: 0x145B0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x145F0 Offset: 0x146F1 VA: 0x145F0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x19B6B20 Offset: 0x19B6C21 VA: 0x19B6B20
	public static double Parse(string s) { }

	// RVA: 0x19B6BB0 Offset: 0x19B6CB1 VA: 0x19B6BB0
	public static double Parse(string s, IFormatProvider provider) { }

	// RVA: 0x19B6C40 Offset: 0x19B6D41 VA: 0x19B6C40
	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x19B6BA0 Offset: 0x19B6CA1 VA: 0x19B6BA0
	private static double Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x19B6CE0 Offset: 0x19B6DE1 VA: 0x19B6CE0
	public static bool TryParse(string s, out double result) { }

	// RVA: 0x19B6E50 Offset: 0x19B6F51 VA: 0x19B6E50
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

	// RVA: 0x19B6D70 Offset: 0x19B6E71 VA: 0x19B6D70
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out double result) { }

	// RVA: 0x14640 Offset: 0x14741 VA: 0x14640 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x14650 Offset: 0x14751 VA: 0x14650 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x146D0 Offset: 0x147D1 VA: 0x146D0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x146E0 Offset: 0x147E1 VA: 0x146E0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x14760 Offset: 0x14861 VA: 0x14760 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x147E0 Offset: 0x148E1 VA: 0x147E0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x14860 Offset: 0x14961 VA: 0x14860 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x148E0 Offset: 0x149E1 VA: 0x148E0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x14960 Offset: 0x14A61 VA: 0x14960 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x149E0 Offset: 0x14AE1 VA: 0x149E0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x14A60 Offset: 0x14B61 VA: 0x14A60 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x14AE0 Offset: 0x14BE1 VA: 0x14AE0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x14B60 Offset: 0x14C61 VA: 0x14B60 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x14B70 Offset: 0x14C71 VA: 0x14B70 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x14BF0 Offset: 0x14CF1 VA: 0x14BF0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x14C00 Offset: 0x14D01 VA: 0x14C00 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x19B7730 Offset: 0x19B7831 VA: 0x19B7730
	private static void .cctor() { }
}

