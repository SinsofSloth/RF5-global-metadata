[ComVisibleAttribute] // RVA: 0xABDA0 Offset: 0xABEA1 VA: 0xABDA0
[Serializable]
public struct Decimal : IFormattable, IComparable, IConvertible, IDeserializationCallback, IComparable<Decimal>, IEquatable<Decimal> // TypeDefIndex: 212
{
	// Fields
	private const int SignMask = -2147483648;
	private const byte DECIMAL_NEG = 128;
	private const byte DECIMAL_ADD = 0;
	private const int ScaleMask = 16711680;
	private const int ScaleShift = 16;
	private const int MaxInt32Scale = 9;
	private static uint[] Powers10; // 0x0
	[DecimalConstantAttribute] // RVA: 0xB4250 Offset: 0xB4351 VA: 0xB4250
	public static readonly Decimal Zero; // 0x8
	[DecimalConstantAttribute] // RVA: 0xB4280 Offset: 0xB4381 VA: 0xB4280
	public static readonly Decimal One; // 0x18
	[DecimalConstantAttribute] // RVA: 0xB42B0 Offset: 0xB43B1 VA: 0xB42B0
	public static readonly Decimal MinusOne; // 0x28
	[DecimalConstantAttribute] // RVA: 0xB42E0 Offset: 0xB43E1 VA: 0xB42E0
	public static readonly Decimal MaxValue; // 0x38
	[DecimalConstantAttribute] // RVA: 0xB4310 Offset: 0xB4411 VA: 0xB4310
	public static readonly Decimal MinValue; // 0x48
	[DecimalConstantAttribute] // RVA: 0xB4340 Offset: 0xB4441 VA: 0xB4340
	private static readonly Decimal NearNegativeZero; // 0x58
	[DecimalConstantAttribute] // RVA: 0xB4370 Offset: 0xB4471 VA: 0xB4370
	private static readonly Decimal NearPositiveZero; // 0x68
	private int flags; // 0x0
	private int hi; // 0x4
	private int lo; // 0x8
	private int mid; // 0xC

	// Methods

	// RVA: 0x13730 Offset: 0x13831 VA: 0x13730
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB6570 Offset: 0xB6671 VA: 0xB6570
	// RVA: 0x13760 Offset: 0x13861 VA: 0x13760
	public void .ctor(uint value) { }

	// RVA: 0x13770 Offset: 0x13871 VA: 0x13770
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB6590 Offset: 0xB6691 VA: 0xB6590
	// RVA: 0x137B0 Offset: 0x138B1 VA: 0x137B0
	public void .ctor(ulong value) { }

	// RVA: 0x137C0 Offset: 0x138C1 VA: 0x137C0
	public void .ctor(float value) { }

	// RVA: 0x137D0 Offset: 0x138D1 VA: 0x137D0
	public void .ctor(double value) { }

	// RVA: 0x137E0 Offset: 0x138E1 VA: 0x137E0
	public void .ctor(int[] bits) { }

	// RVA: 0x137F0 Offset: 0x138F1 VA: 0x137F0
	private void SetBits(int[] bits) { }

	// RVA: 0x13800 Offset: 0x13901 VA: 0x13800
	public void .ctor(int lo, int mid, int hi, bool isNegative, byte scale) { }

	[OnSerializingAttribute] // RVA: 0xB65B0 Offset: 0xB66B1 VA: 0xB65B0
	// RVA: 0x138F0 Offset: 0x139F1 VA: 0x138F0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x13900 Offset: 0x13A01 VA: 0x13900 Slot: 23
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x13910 Offset: 0x13A11 VA: 0x13910
	private void .ctor(int lo, int mid, int hi, int flags) { }

	// RVA: 0x19AA1A0 Offset: 0x19AA2A1 VA: 0x19AA1A0
	private static void FCallAddSub(ref Decimal d1, ref Decimal d2, byte bSign) { }

	[ReliabilityContractAttribute] // RVA: 0xB65C0 Offset: 0xB66C1 VA: 0xB65C0
	// RVA: 0x19AA1B0 Offset: 0x19AA2B1 VA: 0x19AA1B0
	private static int FCallCompare(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x139E0 Offset: 0x13AE1 VA: 0x139E0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x139F0 Offset: 0x13AF1 VA: 0x139F0 Slot: 24
	public int CompareTo(Decimal value) { }

	// RVA: 0x13A70 Offset: 0x13B71 VA: 0x13A70 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x13B30 Offset: 0x13C31 VA: 0x13B30 Slot: 25
	public bool Equals(Decimal value) { }

	// RVA: 0x13BB0 Offset: 0x13CB1 VA: 0x13BB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13BC0 Offset: 0x13CC1 VA: 0x13BC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x13C00 Offset: 0x13D01 VA: 0x13C00 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x13C40 Offset: 0x13D41 VA: 0x13C40 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x19AA560 Offset: 0x19AA661 VA: 0x19AA560
	public static Decimal Parse(string s, IFormatProvider provider) { }

	// RVA: 0x19AA5A0 Offset: 0x19AA6A1 VA: 0x19AA5A0
	public static Decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x19AA600 Offset: 0x19AA701 VA: 0x19AA600
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result) { }

	// RVA: 0x19A9ED0 Offset: 0x19A9FD1 VA: 0x19A9ED0
	public static int[] GetBits(Decimal d) { }

	// RVA: 0x19AA660 Offset: 0x19AA761 VA: 0x19AA660
	internal static Decimal ToDecimal(byte[] buffer) { }

	// RVA: 0x19AA860 Offset: 0x19AA961 VA: 0x19AA860
	private static void InternalAddUInt32RawUnchecked(ref Decimal value, uint i) { }

	// RVA: 0x19AA8B0 Offset: 0x19AA9B1 VA: 0x19AA8B0
	private static uint InternalDivRemUInt32(ref Decimal value, uint divisor) { }

	// RVA: 0x19AA940 Offset: 0x19AAA41 VA: 0x19AA940
	private static void InternalRoundFromZero(ref Decimal d, int decimalCount) { }

	// RVA: 0x19AAAF0 Offset: 0x19AABF1 VA: 0x19AAAF0
	private static void FCallMultiply(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x19AAB00 Offset: 0x19AAC01 VA: 0x19AAB00
	public static Decimal Round(Decimal d, int decimals) { }

	// RVA: 0x19AAB90 Offset: 0x19AAC91 VA: 0x19AAB90
	public static Decimal Round(Decimal d, int decimals, MidpointRounding mode) { }

	// RVA: 0x19AAB80 Offset: 0x19AAC81 VA: 0x19AAB80
	private static void FCallRound(ref Decimal d, int decimals) { }

	// RVA: 0x19AAD80 Offset: 0x19AAE81 VA: 0x19AAD80
	public static byte ToByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB65E0 Offset: 0xB66E1 VA: 0xB65E0
	// RVA: 0x19AB000 Offset: 0x19AB101 VA: 0x19AB000
	public static sbyte ToSByte(Decimal value) { }

	// RVA: 0x19AB290 Offset: 0x19AB391 VA: 0x19AB290
	public static short ToInt16(Decimal value) { }

	// RVA: 0x19AB420 Offset: 0x19AB521 VA: 0x19AB420
	public static double ToDouble(Decimal d) { }

	// RVA: 0x19AB430 Offset: 0x19AB531 VA: 0x19AB430
	internal static int FCallToInt32(Decimal d) { }

	// RVA: 0x19AB190 Offset: 0x19AB291 VA: 0x19AB190
	public static int ToInt32(Decimal d) { }

	// RVA: 0x19AB450 Offset: 0x19AB551 VA: 0x19AB450
	public static long ToInt64(Decimal d) { }

	[CLSCompliantAttribute] // RVA: 0xB6600 Offset: 0xB6701 VA: 0xB6600
	// RVA: 0x19AB550 Offset: 0x19AB651 VA: 0x19AB550
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB6620 Offset: 0xB6721 VA: 0xB6620
	// RVA: 0x19AAF10 Offset: 0x19AB011 VA: 0x19AAF10
	public static uint ToUInt32(Decimal d) { }

	[CLSCompliantAttribute] // RVA: 0xB6640 Offset: 0xB6741 VA: 0xB6640
	// RVA: 0x19AB6E0 Offset: 0x19AB7E1 VA: 0x19AB6E0
	public static ulong ToUInt64(Decimal d) { }

	// RVA: 0x19AB7D0 Offset: 0x19AB8D1 VA: 0x19AB7D0
	public static float ToSingle(Decimal d) { }

	// RVA: 0x19AB440 Offset: 0x19AB541 VA: 0x19AB440
	private static void FCallTruncate(ref Decimal d) { }

	// RVA: 0x19AB7E0 Offset: 0x19AB8E1 VA: 0x19AB7E0
	public static Decimal op_Implicit(byte value) { }

	[CLSCompliantAttribute] // RVA: 0xB6660 Offset: 0xB6761 VA: 0xB6660
	// RVA: 0x19AB7F0 Offset: 0x19AB8F1 VA: 0x19AB7F0
	public static Decimal op_Implicit(sbyte value) { }

	// RVA: 0x19AB810 Offset: 0x19AB911 VA: 0x19AB810
	public static Decimal op_Implicit(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB6680 Offset: 0xB6781 VA: 0xB6680
	// RVA: 0x19AB830 Offset: 0x19AB931 VA: 0x19AB830
	public static Decimal op_Implicit(ushort value) { }

	// RVA: 0x19AB840 Offset: 0x19AB941 VA: 0x19AB840
	public static Decimal op_Implicit(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB66A0 Offset: 0xB67A1 VA: 0xB66A0
	// RVA: 0x19AB850 Offset: 0x19AB951 VA: 0x19AB850
	public static Decimal op_Implicit(uint value) { }

	// RVA: 0x19AB860 Offset: 0x19AB961 VA: 0x19AB860
	public static Decimal op_Implicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB66C0 Offset: 0xB67C1 VA: 0xB66C0
	// RVA: 0x19AB880 Offset: 0x19AB981 VA: 0x19AB880
	public static Decimal op_Implicit(ulong value) { }

	// RVA: 0x19AB890 Offset: 0x19AB991 VA: 0x19AB890
	public static Decimal op_Explicit(float value) { }

	// RVA: 0x19AB8C0 Offset: 0x19AB9C1 VA: 0x19AB8C0
	public static Decimal op_Explicit(double value) { }

	// RVA: 0x19AB8F0 Offset: 0x19AB9F1 VA: 0x19AB8F0
	public static long op_Explicit(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0xB66E0 Offset: 0xB67E1 VA: 0xB66E0
	// RVA: 0x19AB970 Offset: 0x19ABA71 VA: 0x19AB970
	public static ulong op_Explicit(Decimal value) { }

	// RVA: 0x19AB9F0 Offset: 0x19ABAF1 VA: 0x19AB9F0
	public static float op_Explicit(Decimal value) { }

	// RVA: 0x19ABA70 Offset: 0x19ABB71 VA: 0x19ABA70
	public static double op_Explicit(Decimal value) { }

	// RVA: 0x19ABAF0 Offset: 0x19ABBF1 VA: 0x19ABAF0
	public static Decimal op_Addition(Decimal d1, Decimal d2) { }

	// RVA: 0x19ABB70 Offset: 0x19ABC71 VA: 0x19ABB70
	public static Decimal op_Subtraction(Decimal d1, Decimal d2) { }

	// RVA: 0x19ABBF0 Offset: 0x19ABCF1 VA: 0x19ABBF0
	public static Decimal op_Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x19ABC70 Offset: 0x19ABD71 VA: 0x19ABC70
	public static bool op_Equality(Decimal d1, Decimal d2) { }

	// RVA: 0x19ABCF0 Offset: 0x19ABDF1 VA: 0x19ABCF0
	public static bool op_Inequality(Decimal d1, Decimal d2) { }

	// RVA: 0x13C90 Offset: 0x13D91 VA: 0x13C90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x13CA0 Offset: 0x13DA1 VA: 0x13CA0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x13D10 Offset: 0x13E11 VA: 0x13D10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x13D20 Offset: 0x13E21 VA: 0x13D20 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x13D90 Offset: 0x13E91 VA: 0x13D90 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x13E00 Offset: 0x13F01 VA: 0x13E00 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x13E70 Offset: 0x13F71 VA: 0x13E70 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x13EE0 Offset: 0x13FE1 VA: 0x13EE0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x13F50 Offset: 0x14051 VA: 0x13F50 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x13FC0 Offset: 0x140C1 VA: 0x13FC0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x14030 Offset: 0x14131 VA: 0x14030 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x140A0 Offset: 0x141A1 VA: 0x140A0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x14110 Offset: 0x14211 VA: 0x14110 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x14180 Offset: 0x14281 VA: 0x14180 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x14190 Offset: 0x14291 VA: 0x14190 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x141A0 Offset: 0x142A1 VA: 0x141A0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x19AC4F0 Offset: 0x19AC5F1 VA: 0x19AC4F0
	private static void .cctor() { }
}

