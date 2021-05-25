[CLSCompliantAttribute] // RVA: 0xACBB0 Offset: 0xACCB1 VA: 0xACBB0
[ComVisibleAttribute] // RVA: 0xACBB0 Offset: 0xACCB1 VA: 0xACBB0
[Serializable]
public struct UInt64 : IComparable, IFormattable, IConvertible, IComparable<ulong>, IEquatable<ulong> // TypeDefIndex: 338
{
	// Fields
	private ulong m_value; // 0x0
	public const ulong MaxValue = 18446744073709551615;
	public const ulong MinValue = 0;

	// Methods

	// RVA: 0x1A8F0 Offset: 0x1A9F1 VA: 0x1A8F0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1A900 Offset: 0x1AA01 VA: 0x1A900 Slot: 23
	public int CompareTo(ulong value) { }

	// RVA: 0x1A920 Offset: 0x1AA21 VA: 0x1A920 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A9D0 Offset: 0x1AAD1 VA: 0x1A9D0 Slot: 24
	public bool Equals(ulong obj) { }

	// RVA: 0x1A9E0 Offset: 0x1AAE1 VA: 0x1A9E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A9F0 Offset: 0x1AAF1 VA: 0x1A9F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AA30 Offset: 0x1AB31 VA: 0x1AA30 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1AA70 Offset: 0x1AB71 VA: 0x1AA70
	public string ToString(string format) { }

	// RVA: 0x1AAB0 Offset: 0x1ABB1 VA: 0x1AAB0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB7080 Offset: 0xB7181 VA: 0xB7080
	// RVA: 0x1AE3090 Offset: 0x1AE3191 VA: 0x1AE3090
	public static ulong Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB70A0 Offset: 0xB71A1 VA: 0xB70A0
	// RVA: 0x1AE30D0 Offset: 0x1AE31D1 VA: 0x1AE30D0
	public static ulong Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB70C0 Offset: 0xB71C1 VA: 0xB70C0
	// RVA: 0x1AE3130 Offset: 0x1AE3231 VA: 0x1AE3130
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result) { }

	// RVA: 0x1AAF0 Offset: 0x1ABF1 VA: 0x1AAF0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1AB00 Offset: 0x1AC01 VA: 0x1AB00 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1AB70 Offset: 0x1AC71 VA: 0x1AB70 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1ABE0 Offset: 0x1ACE1 VA: 0x1ABE0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1AC50 Offset: 0x1AD51 VA: 0x1AC50 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1ACC0 Offset: 0x1ADC1 VA: 0x1ACC0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1AD30 Offset: 0x1AE31 VA: 0x1AD30 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1ADA0 Offset: 0x1AEA1 VA: 0x1ADA0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1AE10 Offset: 0x1AF11 VA: 0x1AE10 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1AE80 Offset: 0x1AF81 VA: 0x1AE80 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1AEF0 Offset: 0x1AFF1 VA: 0x1AEF0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1AF00 Offset: 0x1B001 VA: 0x1AF00 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1AF70 Offset: 0x1B071 VA: 0x1AF70 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1AFE0 Offset: 0x1B0E1 VA: 0x1AFE0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1B050 Offset: 0x1B151 VA: 0x1B050 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1B060 Offset: 0x1B161 VA: 0x1B060 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

