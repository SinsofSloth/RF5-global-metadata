[ComVisibleAttribute] // RVA: 0xAC690 Offset: 0xAC791 VA: 0xAC690
[CLSCompliantAttribute] // RVA: 0xAC690 Offset: 0xAC791 VA: 0xAC690
[Serializable]
public struct SByte : IComparable, IFormattable, IConvertible, IComparable<sbyte>, IEquatable<sbyte> // TypeDefIndex: 305
{
	// Fields
	private sbyte m_value; // 0x0
	public const sbyte MaxValue = 127;
	public const sbyte MinValue = -128;

	// Methods

	// RVA: 0x11970 Offset: 0x11A71 VA: 0x11970 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x11980 Offset: 0x11A81 VA: 0x11980 Slot: 23
	public int CompareTo(sbyte value) { }

	// RVA: 0x11990 Offset: 0x11A91 VA: 0x11990 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x11A40 Offset: 0x11B41 VA: 0x11A40 Slot: 24
	public bool Equals(sbyte obj) { }

	// RVA: 0x11A50 Offset: 0x11B51 VA: 0x11A50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x11A60 Offset: 0x11B61 VA: 0x11A60 Slot: 3
	public override string ToString() { }

	// RVA: 0x11AA0 Offset: 0x11BA1 VA: 0x11AA0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x11AE0 Offset: 0x11BE1 VA: 0x11AE0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x11AF0 Offset: 0x11BF1 VA: 0x11AF0
	private string ToString(string format, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0xB6CE0 Offset: 0xB6DE1 VA: 0xB6CE0
	// RVA: 0x1942B30 Offset: 0x1942C31 VA: 0x1942B30
	public static sbyte Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB6D00 Offset: 0xB6E01 VA: 0xB6D00
	// RVA: 0x1942CF0 Offset: 0x1942DF1 VA: 0x1942CF0
	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1942B70 Offset: 0x1942C71 VA: 0x1942B70
	private static sbyte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x11BA0 Offset: 0x11CA1 VA: 0x11BA0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x11BB0 Offset: 0x11CB1 VA: 0x11BB0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x11C20 Offset: 0x11D21 VA: 0x11C20 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x11C90 Offset: 0x11D91 VA: 0x11C90 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x11CA0 Offset: 0x11DA1 VA: 0x11CA0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x11D10 Offset: 0x11E11 VA: 0x11D10 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x11D80 Offset: 0x11E81 VA: 0x11D80 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x11DF0 Offset: 0x11EF1 VA: 0x11DF0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x11E00 Offset: 0x11F01 VA: 0x11E00 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x11E70 Offset: 0x11F71 VA: 0x11E70 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x11EE0 Offset: 0x11FE1 VA: 0x11EE0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x11F50 Offset: 0x12051 VA: 0x11F50 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x11FC0 Offset: 0x120C1 VA: 0x11FC0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x12030 Offset: 0x12131 VA: 0x12030 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x120A0 Offset: 0x121A1 VA: 0x120A0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x120B0 Offset: 0x121B1 VA: 0x120B0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

