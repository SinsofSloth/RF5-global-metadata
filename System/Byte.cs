[ComVisibleAttribute] // RVA: 0xABBE0 Offset: 0xABCE1 VA: 0xABBE0
[Serializable]
public struct Byte : IComparable, IFormattable, IConvertible, IComparable<byte>, IEquatable<byte> // TypeDefIndex: 191
{
	// Fields
	private byte m_value; // 0x0
	public const byte MaxValue = 255;
	public const byte MinValue = 0;

	// Methods

	// RVA: 0xC4E0 Offset: 0xC5E1 VA: 0xC4E0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0xC4F0 Offset: 0xC5F1 VA: 0xC4F0 Slot: 23
	public int CompareTo(byte value) { }

	// RVA: 0xC500 Offset: 0xC601 VA: 0xC500 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xC5B0 Offset: 0xC6B1 VA: 0xC5B0 Slot: 24
	public bool Equals(byte obj) { }

	// RVA: 0xC5C0 Offset: 0xC6C1 VA: 0xC5C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1855630 Offset: 0x1855731 VA: 0x1855630
	public static byte Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18557E0 Offset: 0x18558E1 VA: 0x18557E0
	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1855670 Offset: 0x1855771 VA: 0x1855670
	private static byte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0xC5D0 Offset: 0xC6D1 VA: 0xC5D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xC610 Offset: 0xC711 VA: 0xC610
	public string ToString(string format) { }

	// RVA: 0xC650 Offset: 0xC751 VA: 0xC650 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0xC690 Offset: 0xC791 VA: 0xC690 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0xC6D0 Offset: 0xC7D1 VA: 0xC6D0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0xC6E0 Offset: 0xC7E1 VA: 0xC6E0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xC750 Offset: 0xC851 VA: 0xC750 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xC7C0 Offset: 0xC8C1 VA: 0xC7C0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xC830 Offset: 0xC931 VA: 0xC830 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xC840 Offset: 0xC941 VA: 0xC840 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xC8B0 Offset: 0xC9B1 VA: 0xC8B0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xC920 Offset: 0xCA21 VA: 0xC920 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xC990 Offset: 0xCA91 VA: 0xC990 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xCA00 Offset: 0xCB01 VA: 0xCA00 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xCA70 Offset: 0xCB71 VA: 0xCA70 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xCAE0 Offset: 0xCBE1 VA: 0xCAE0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xCB50 Offset: 0xCC51 VA: 0xCB50 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xCBC0 Offset: 0xCCC1 VA: 0xCBC0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xCC30 Offset: 0xCD31 VA: 0xCC30 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xCC40 Offset: 0xCD41 VA: 0xCC40 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

