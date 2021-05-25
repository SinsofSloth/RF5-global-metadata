[ComVisibleAttribute] // RVA: 0xAC200 Offset: 0xAC301 VA: 0xAC200
[Serializable]
public struct Int32 : IComparable, IFormattable, IConvertible, IComparable<int>, IEquatable<int> // TypeDefIndex: 269
{
	// Fields
	internal int m_value; // 0x0
	public const int MaxValue = 2147483647;
	public const int MinValue = -2147483648;

	// Methods

	// RVA: 0xF110 Offset: 0xF211 VA: 0xF110 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0xF120 Offset: 0xF221 VA: 0xF120 Slot: 23
	public int CompareTo(int value) { }

	// RVA: 0xF140 Offset: 0xF241 VA: 0xF140 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF1F0 Offset: 0xF2F1 VA: 0xF1F0 Slot: 24
	public bool Equals(int obj) { }

	// RVA: 0xF200 Offset: 0xF301 VA: 0xF200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF210 Offset: 0xF311 VA: 0xF210 Slot: 3
	public override string ToString() { }

	// RVA: 0xF290 Offset: 0xF391 VA: 0xF290
	public string ToString(string format) { }

	// RVA: 0xF320 Offset: 0xF421 VA: 0xF320 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0xF3B0 Offset: 0xF4B1 VA: 0xF3B0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x18D8630 Offset: 0x18D8731 VA: 0x18D8630
	public static int Parse(string s) { }

	// RVA: 0x18D8660 Offset: 0x18D8761 VA: 0x18D8660
	public static int Parse(string s, NumberStyles style) { }

	// RVA: 0x18D86A0 Offset: 0x18D87A1 VA: 0x18D86A0
	public static int Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18D86E0 Offset: 0x18D87E1 VA: 0x18D86E0
	public static int Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18D8730 Offset: 0x18D8831 VA: 0x18D8730
	public static bool TryParse(string s, out int result) { }

	// RVA: 0x18D89E0 Offset: 0x18D8AE1 VA: 0x18D89E0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) { }

	// RVA: 0xF440 Offset: 0xF541 VA: 0xF440 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0xF450 Offset: 0xF551 VA: 0xF450 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xF4C0 Offset: 0xF5C1 VA: 0xF4C0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xF530 Offset: 0xF631 VA: 0xF530 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xF5A0 Offset: 0xF6A1 VA: 0xF5A0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xF610 Offset: 0xF711 VA: 0xF610 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xF680 Offset: 0xF781 VA: 0xF680 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xF6F0 Offset: 0xF7F1 VA: 0xF6F0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xF700 Offset: 0xF801 VA: 0xF700 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xF770 Offset: 0xF871 VA: 0xF770 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xF7E0 Offset: 0xF8E1 VA: 0xF7E0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xF850 Offset: 0xF951 VA: 0xF850 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xF8C0 Offset: 0xF9C1 VA: 0xF8C0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xF930 Offset: 0xFA31 VA: 0xF930 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xF9A0 Offset: 0xFAA1 VA: 0xF9A0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xF9B0 Offset: 0xFAB1 VA: 0xF9B0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

