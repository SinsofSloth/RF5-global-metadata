[ComVisibleAttribute] // RVA: 0xABBA0 Offset: 0xABCA1 VA: 0xABBA0
[Serializable]
public struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool> // TypeDefIndex: 189
{
	// Fields
	private bool m_value; // 0x0
	internal const int True = 1;
	internal const int False = 0;
	internal const string TrueLiteral = "True";
	internal const string FalseLiteral = "False";
	public static readonly string TrueString; // 0x0
	public static readonly string FalseString; // 0x8

	// Methods

	// RVA: 0xBD40 Offset: 0xBE41 VA: 0xBD40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xBD50 Offset: 0xBE51 VA: 0xBD50 Slot: 3
	public override string ToString() { }

	// RVA: 0xBDB0 Offset: 0xBEB1 VA: 0xBDB0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0xBE10 Offset: 0xBF11 VA: 0xBE10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xBEC0 Offset: 0xBFC1 VA: 0xBEC0 Slot: 23
	public bool Equals(bool obj) { }

	// RVA: 0xBEE0 Offset: 0xBFE1 VA: 0xBEE0 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0xBEF0 Offset: 0xBFF1 VA: 0xBEF0 Slot: 22
	public int CompareTo(bool value) { }

	// RVA: 0x1853BD0 Offset: 0x1853CD1 VA: 0x1853BD0
	public static bool Parse(string value) { }

	// RVA: 0x1853CE0 Offset: 0x1853DE1 VA: 0x1853CE0
	public static bool TryParse(string value, out bool result) { }

	// RVA: 0x1853E30 Offset: 0x1853F31 VA: 0x1853E30
	private static string TrimWhiteSpaceAndNull(string value) { }

	// RVA: 0xBF10 Offset: 0xC011 VA: 0xBF10 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0xBF20 Offset: 0xC021 VA: 0xBF20 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xBF30 Offset: 0xC031 VA: 0xBF30 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xBF40 Offset: 0xC041 VA: 0xBF40 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xBFB0 Offset: 0xC0B1 VA: 0xBFB0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xC020 Offset: 0xC121 VA: 0xC020 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xC090 Offset: 0xC191 VA: 0xC090 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xC100 Offset: 0xC201 VA: 0xC100 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xC170 Offset: 0xC271 VA: 0xC170 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xC1E0 Offset: 0xC2E1 VA: 0xC1E0 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xC250 Offset: 0xC351 VA: 0xC250 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xC2C0 Offset: 0xC3C1 VA: 0xC2C0 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xC330 Offset: 0xC431 VA: 0xC330 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xC3A0 Offset: 0xC4A1 VA: 0xC3A0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xC410 Offset: 0xC511 VA: 0xC410 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xC420 Offset: 0xC521 VA: 0xC420 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1854850 Offset: 0x1854951 VA: 0x1854850
	private static void .cctor() { }
}

