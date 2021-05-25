[ComVisibleAttribute] // RVA: 0xACB70 Offset: 0xACC71 VA: 0xACB70
[CLSCompliantAttribute] // RVA: 0xACB70 Offset: 0xACC71 VA: 0xACB70
[Serializable]
public struct UInt32 : IComparable, IFormattable, IConvertible, IComparable<uint>, IEquatable<uint> // TypeDefIndex: 337
{
	// Fields
	private uint m_value; // 0x0
	public const uint MaxValue = 4294967295;
	public const uint MinValue = 0;

	// Methods

	// RVA: 0x1A0D0 Offset: 0x1A1D1 VA: 0x1A0D0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1A0E0 Offset: 0x1A1E1 VA: 0x1A0E0 Slot: 23
	public int CompareTo(uint value) { }

	// RVA: 0x1A100 Offset: 0x1A201 VA: 0x1A100 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A1B0 Offset: 0x1A2B1 VA: 0x1A1B0 Slot: 24
	public bool Equals(uint obj) { }

	// RVA: 0x1A1C0 Offset: 0x1A2C1 VA: 0x1A1C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A1D0 Offset: 0x1A2D1 VA: 0x1A1D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A210 Offset: 0x1A311 VA: 0x1A210 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1A250 Offset: 0x1A351 VA: 0x1A250
	public string ToString(string format) { }

	// RVA: 0x1A290 Offset: 0x1A391 VA: 0x1A290 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB7000 Offset: 0xB7101 VA: 0xB7000
	// RVA: 0x1AE2560 Offset: 0x1AE2661 VA: 0x1AE2560
	public static uint Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0xB7020 Offset: 0xB7121 VA: 0xB7020
	// RVA: 0x1AE25A0 Offset: 0x1AE26A1 VA: 0x1AE25A0
	public static uint Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB7040 Offset: 0xB7141 VA: 0xB7040
	// RVA: 0x1AE25E0 Offset: 0x1AE26E1 VA: 0x1AE25E0
	public static uint Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB7060 Offset: 0xB7161 VA: 0xB7060
	// RVA: 0x1AE2640 Offset: 0x1AE2741 VA: 0x1AE2640
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result) { }

	// RVA: 0x1A2D0 Offset: 0x1A3D1 VA: 0x1A2D0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1A2E0 Offset: 0x1A3E1 VA: 0x1A2E0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1A350 Offset: 0x1A451 VA: 0x1A350 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1A3C0 Offset: 0x1A4C1 VA: 0x1A3C0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1A430 Offset: 0x1A531 VA: 0x1A430 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1A4A0 Offset: 0x1A5A1 VA: 0x1A4A0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1A510 Offset: 0x1A611 VA: 0x1A510 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1A580 Offset: 0x1A681 VA: 0x1A580 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1A5F0 Offset: 0x1A6F1 VA: 0x1A5F0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1A600 Offset: 0x1A701 VA: 0x1A600 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1A670 Offset: 0x1A771 VA: 0x1A670 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1A6E0 Offset: 0x1A7E1 VA: 0x1A6E0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1A750 Offset: 0x1A851 VA: 0x1A750 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1A7C0 Offset: 0x1A8C1 VA: 0x1A7C0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1A830 Offset: 0x1A931 VA: 0x1A830 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1A840 Offset: 0x1A941 VA: 0x1A840 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

