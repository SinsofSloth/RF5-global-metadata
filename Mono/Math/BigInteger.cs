internal class BigInteger // TypeDefIndex: 76
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x1938A60 Offset: 0x1938B61 VA: 0x1938A60
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1938AF0 Offset: 0x1938BF1 VA: 0x1938AF0
	public void .ctor(BigInteger bi) { }

	// RVA: 0x1938BB0 Offset: 0x1938CB1 VA: 0x1938BB0
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1938CB0 Offset: 0x1938DB1 VA: 0x1938CB0
	public void .ctor(byte[] inData) { }

	// RVA: 0x1939000 Offset: 0x1939101 VA: 0x1939000
	public void .ctor(uint ui) { }

	// RVA: 0x19390A0 Offset: 0x19391A1 VA: 0x19390A0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1939100 Offset: 0x1939201 VA: 0x1939100
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x19391A0 Offset: 0x19392A1 VA: 0x19391A0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x19397F0 Offset: 0x19398F1 VA: 0x19397F0
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x19398F0 Offset: 0x19399F1 VA: 0x19398F0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FB0 Offset: 0x193A0B1 VA: 0x1939FB0
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FF0 Offset: 0x193A0F1 VA: 0x1939FF0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193A500 Offset: 0x193A601 VA: 0x193A500
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x193A7F0 Offset: 0x193A8F1 VA: 0x193A7F0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193AA80 Offset: 0x193AB81 VA: 0x193AA80
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193ACE0 Offset: 0x193ADE1 VA: 0x193ACE0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x193ADC0 Offset: 0x193AEC1 VA: 0x193ADC0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x193B000 Offset: 0x193B101 VA: 0x193B000
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x193B070 Offset: 0x193B171 VA: 0x193B070
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x193B330 Offset: 0x193B431 VA: 0x193B330
	public void Randomize() { }

	// RVA: 0x193B280 Offset: 0x193B381 VA: 0x193B280
	public int BitCount() { }

	// RVA: 0x193B3A0 Offset: 0x193B4A1 VA: 0x193B3A0
	public bool TestBit(uint bitNum) { }

	// RVA: 0x193B3F0 Offset: 0x193B4F1 VA: 0x193B3F0
	public bool TestBit(int bitNum) { }

	// RVA: 0x193B4C0 Offset: 0x193B5C1 VA: 0x193B4C0
	public void SetBit(uint bitNum) { }

	// RVA: 0x193B520 Offset: 0x193B621 VA: 0x193B520
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x193B590 Offset: 0x193B691 VA: 0x193B590
	public int LowestSetBit() { }

	// RVA: 0x193B620 Offset: 0x193B721 VA: 0x193B620
	public byte[] GetBytes() { }

	// RVA: 0x1939350 Offset: 0x1939451 VA: 0x1939350
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B7F0 Offset: 0x193B8F1 VA: 0x193B7F0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B890 Offset: 0x193B991 VA: 0x193B890
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193B9B0 Offset: 0x193BAB1 VA: 0x193B9B0
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAD0 Offset: 0x193BBD1 VA: 0x193BAD0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAF0 Offset: 0x193BBF1 VA: 0x193BAF0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB10 Offset: 0x193BC11 VA: 0x193BB10
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB30 Offset: 0x193BC31 VA: 0x193BB30
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB50 Offset: 0x193BC51 VA: 0x193BB50
	public string ToString(uint radix) { }

	// RVA: 0x193BBB0 Offset: 0x193BCB1 VA: 0x193BBB0
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1938F90 Offset: 0x1939091 VA: 0x1938F90
	private void Normalize() { }

	// RVA: 0x193BEB0 Offset: 0x193BFB1 VA: 0x193BEB0
	public void Clear() { }

	// RVA: 0x193BF10 Offset: 0x193C011 VA: 0x193BF10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x193BF80 Offset: 0x193C081 VA: 0x193BF80 Slot: 3
	public override string ToString() { }

	// RVA: 0x193BFE0 Offset: 0x193C0E1 VA: 0x193BFE0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x193C180 Offset: 0x193C281 VA: 0x193C180
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x193C8E0 Offset: 0x193C9E1 VA: 0x193C8E0
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x193CC60 Offset: 0x193CD61 VA: 0x193CC60
	public bool IsProbablePrime() { }

	// RVA: 0x193CFC0 Offset: 0x193D0C1 VA: 0x193CFC0
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x193D050 Offset: 0x193D151 VA: 0x193D050
	public void Incr2() { }

	// RVA: 0x193D120 Offset: 0x193D221 VA: 0x193D120
	private static void .cctor() { }
}

public class BigInteger // TypeDefIndex: 1600
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xBAF80 Offset: 0xBB081 VA: 0xBAF80
	// RVA: 0x1A5EA00 Offset: 0x1A5EB01 VA: 0x1A5EA00
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1A5EA90 Offset: 0x1A5EB91 VA: 0x1A5EA90
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0xBAFA0 Offset: 0xBB0A1 VA: 0xBAFA0
	// RVA: 0x1A5EB50 Offset: 0x1A5EC51 VA: 0x1A5EB50
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1A5EC50 Offset: 0x1A5ED51 VA: 0x1A5EC50
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0xBAFC0 Offset: 0xBB0C1 VA: 0xBAFC0
	// RVA: 0x1A5EFA0 Offset: 0x1A5F0A1 VA: 0x1A5EFA0
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBAFE0 Offset: 0xBB0E1 VA: 0xBAFE0
	// RVA: 0x1A5F040 Offset: 0x1A5F141 VA: 0x1A5F040
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1A5F0A0 Offset: 0x1A5F1A1 VA: 0x1A5F0A0
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1A5F140 Offset: 0x1A5F241 VA: 0x1A5F140
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB000 Offset: 0xBB101 VA: 0xBB000
	// RVA: 0x1A5F790 Offset: 0x1A5F891 VA: 0x1A5F790
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1A5F890 Offset: 0x1A5F991 VA: 0x1A5F890
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF50 Offset: 0x1A60051 VA: 0x1A5FF50
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF90 Offset: 0x1A60091 VA: 0x1A5FF90
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A604A0 Offset: 0x1A605A1 VA: 0x1A604A0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60730 Offset: 0x1A60831 VA: 0x1A60730
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60990 Offset: 0x1A60A91 VA: 0x1A60990
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1A60A70 Offset: 0x1A60B71 VA: 0x1A60A70
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1A60CB0 Offset: 0x1A60DB1 VA: 0x1A60CB0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1A60D20 Offset: 0x1A60E21 VA: 0x1A60D20
	public int BitCount() { }

	// RVA: 0x1A60DD0 Offset: 0x1A60ED1 VA: 0x1A60DD0
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB020 Offset: 0xBB121 VA: 0xBB020
	// RVA: 0x1A60EA0 Offset: 0x1A60FA1 VA: 0x1A60EA0
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB040 Offset: 0xBB141 VA: 0xBB040
	// RVA: 0x1A60F00 Offset: 0x1A61001 VA: 0x1A60F00
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1A60F70 Offset: 0x1A61071 VA: 0x1A60F70
	public int LowestSetBit() { }

	// RVA: 0x1A61000 Offset: 0x1A61101 VA: 0x1A61000
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0xBB060 Offset: 0xBB161 VA: 0xBB060
	// RVA: 0x1A5F2F0 Offset: 0x1A5F3F1 VA: 0x1A5F2F0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBB080 Offset: 0xBB181 VA: 0xBB080
	// RVA: 0x1A611D0 Offset: 0x1A612D1 VA: 0x1A611D0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1A61270 Offset: 0x1A61371 VA: 0x1A61270
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61390 Offset: 0x1A61491 VA: 0x1A61390
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614B0 Offset: 0x1A615B1 VA: 0x1A614B0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614D0 Offset: 0x1A615D1 VA: 0x1A614D0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614F0 Offset: 0x1A615F1 VA: 0x1A614F0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61510 Offset: 0x1A61611 VA: 0x1A61510
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB0A0 Offset: 0xBB1A1 VA: 0xBB0A0
	// RVA: 0x1A61530 Offset: 0x1A61631 VA: 0x1A61530
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0xBB0C0 Offset: 0xBB1C1 VA: 0xBB0C0
	// RVA: 0x1A61590 Offset: 0x1A61691 VA: 0x1A61590
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1A5EF30 Offset: 0x1A5F031 VA: 0x1A5EF30
	private void Normalize() { }

	// RVA: 0x1A61890 Offset: 0x1A61991 VA: 0x1A61890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A61900 Offset: 0x1A61A01 VA: 0x1A61900 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A61960 Offset: 0x1A61A61 VA: 0x1A61960 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1A61B00 Offset: 0x1A61C01 VA: 0x1A61B00
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1A62260 Offset: 0x1A62361 VA: 0x1A62260
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1A622F0 Offset: 0x1A623F1 VA: 0x1A622F0
	public void Incr2() { }

	// RVA: 0x1A623C0 Offset: 0x1A624C1 VA: 0x1A623C0
	private static void .cctor() { }
}

internal class BigInteger // TypeDefIndex: 76
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x1938A60 Offset: 0x1938B61 VA: 0x1938A60
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1938AF0 Offset: 0x1938BF1 VA: 0x1938AF0
	public void .ctor(BigInteger bi) { }

	// RVA: 0x1938BB0 Offset: 0x1938CB1 VA: 0x1938BB0
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1938CB0 Offset: 0x1938DB1 VA: 0x1938CB0
	public void .ctor(byte[] inData) { }

	// RVA: 0x1939000 Offset: 0x1939101 VA: 0x1939000
	public void .ctor(uint ui) { }

	// RVA: 0x19390A0 Offset: 0x19391A1 VA: 0x19390A0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1939100 Offset: 0x1939201 VA: 0x1939100
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x19391A0 Offset: 0x19392A1 VA: 0x19391A0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x19397F0 Offset: 0x19398F1 VA: 0x19397F0
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x19398F0 Offset: 0x19399F1 VA: 0x19398F0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FB0 Offset: 0x193A0B1 VA: 0x1939FB0
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FF0 Offset: 0x193A0F1 VA: 0x1939FF0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193A500 Offset: 0x193A601 VA: 0x193A500
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x193A7F0 Offset: 0x193A8F1 VA: 0x193A7F0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193AA80 Offset: 0x193AB81 VA: 0x193AA80
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193ACE0 Offset: 0x193ADE1 VA: 0x193ACE0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x193ADC0 Offset: 0x193AEC1 VA: 0x193ADC0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x193B000 Offset: 0x193B101 VA: 0x193B000
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x193B070 Offset: 0x193B171 VA: 0x193B070
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x193B330 Offset: 0x193B431 VA: 0x193B330
	public void Randomize() { }

	// RVA: 0x193B280 Offset: 0x193B381 VA: 0x193B280
	public int BitCount() { }

	// RVA: 0x193B3A0 Offset: 0x193B4A1 VA: 0x193B3A0
	public bool TestBit(uint bitNum) { }

	// RVA: 0x193B3F0 Offset: 0x193B4F1 VA: 0x193B3F0
	public bool TestBit(int bitNum) { }

	// RVA: 0x193B4C0 Offset: 0x193B5C1 VA: 0x193B4C0
	public void SetBit(uint bitNum) { }

	// RVA: 0x193B520 Offset: 0x193B621 VA: 0x193B520
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x193B590 Offset: 0x193B691 VA: 0x193B590
	public int LowestSetBit() { }

	// RVA: 0x193B620 Offset: 0x193B721 VA: 0x193B620
	public byte[] GetBytes() { }

	// RVA: 0x1939350 Offset: 0x1939451 VA: 0x1939350
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B7F0 Offset: 0x193B8F1 VA: 0x193B7F0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B890 Offset: 0x193B991 VA: 0x193B890
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193B9B0 Offset: 0x193BAB1 VA: 0x193B9B0
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAD0 Offset: 0x193BBD1 VA: 0x193BAD0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAF0 Offset: 0x193BBF1 VA: 0x193BAF0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB10 Offset: 0x193BC11 VA: 0x193BB10
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB30 Offset: 0x193BC31 VA: 0x193BB30
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB50 Offset: 0x193BC51 VA: 0x193BB50
	public string ToString(uint radix) { }

	// RVA: 0x193BBB0 Offset: 0x193BCB1 VA: 0x193BBB0
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1938F90 Offset: 0x1939091 VA: 0x1938F90
	private void Normalize() { }

	// RVA: 0x193BEB0 Offset: 0x193BFB1 VA: 0x193BEB0
	public void Clear() { }

	// RVA: 0x193BF10 Offset: 0x193C011 VA: 0x193BF10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x193BF80 Offset: 0x193C081 VA: 0x193BF80 Slot: 3
	public override string ToString() { }

	// RVA: 0x193BFE0 Offset: 0x193C0E1 VA: 0x193BFE0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x193C180 Offset: 0x193C281 VA: 0x193C180
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x193C8E0 Offset: 0x193C9E1 VA: 0x193C8E0
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x193CC60 Offset: 0x193CD61 VA: 0x193CC60
	public bool IsProbablePrime() { }

	// RVA: 0x193CFC0 Offset: 0x193D0C1 VA: 0x193CFC0
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x193D050 Offset: 0x193D151 VA: 0x193D050
	public void Incr2() { }

	// RVA: 0x193D120 Offset: 0x193D221 VA: 0x193D120
	private static void .cctor() { }
}

public class BigInteger // TypeDefIndex: 1600
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xBAF80 Offset: 0xBB081 VA: 0xBAF80
	// RVA: 0x1A5EA00 Offset: 0x1A5EB01 VA: 0x1A5EA00
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1A5EA90 Offset: 0x1A5EB91 VA: 0x1A5EA90
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0xBAFA0 Offset: 0xBB0A1 VA: 0xBAFA0
	// RVA: 0x1A5EB50 Offset: 0x1A5EC51 VA: 0x1A5EB50
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1A5EC50 Offset: 0x1A5ED51 VA: 0x1A5EC50
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0xBAFC0 Offset: 0xBB0C1 VA: 0xBAFC0
	// RVA: 0x1A5EFA0 Offset: 0x1A5F0A1 VA: 0x1A5EFA0
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBAFE0 Offset: 0xBB0E1 VA: 0xBAFE0
	// RVA: 0x1A5F040 Offset: 0x1A5F141 VA: 0x1A5F040
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1A5F0A0 Offset: 0x1A5F1A1 VA: 0x1A5F0A0
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1A5F140 Offset: 0x1A5F241 VA: 0x1A5F140
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB000 Offset: 0xBB101 VA: 0xBB000
	// RVA: 0x1A5F790 Offset: 0x1A5F891 VA: 0x1A5F790
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1A5F890 Offset: 0x1A5F991 VA: 0x1A5F890
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF50 Offset: 0x1A60051 VA: 0x1A5FF50
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF90 Offset: 0x1A60091 VA: 0x1A5FF90
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A604A0 Offset: 0x1A605A1 VA: 0x1A604A0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60730 Offset: 0x1A60831 VA: 0x1A60730
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60990 Offset: 0x1A60A91 VA: 0x1A60990
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1A60A70 Offset: 0x1A60B71 VA: 0x1A60A70
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1A60CB0 Offset: 0x1A60DB1 VA: 0x1A60CB0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1A60D20 Offset: 0x1A60E21 VA: 0x1A60D20
	public int BitCount() { }

	// RVA: 0x1A60DD0 Offset: 0x1A60ED1 VA: 0x1A60DD0
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB020 Offset: 0xBB121 VA: 0xBB020
	// RVA: 0x1A60EA0 Offset: 0x1A60FA1 VA: 0x1A60EA0
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB040 Offset: 0xBB141 VA: 0xBB040
	// RVA: 0x1A60F00 Offset: 0x1A61001 VA: 0x1A60F00
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1A60F70 Offset: 0x1A61071 VA: 0x1A60F70
	public int LowestSetBit() { }

	// RVA: 0x1A61000 Offset: 0x1A61101 VA: 0x1A61000
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0xBB060 Offset: 0xBB161 VA: 0xBB060
	// RVA: 0x1A5F2F0 Offset: 0x1A5F3F1 VA: 0x1A5F2F0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBB080 Offset: 0xBB181 VA: 0xBB080
	// RVA: 0x1A611D0 Offset: 0x1A612D1 VA: 0x1A611D0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1A61270 Offset: 0x1A61371 VA: 0x1A61270
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61390 Offset: 0x1A61491 VA: 0x1A61390
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614B0 Offset: 0x1A615B1 VA: 0x1A614B0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614D0 Offset: 0x1A615D1 VA: 0x1A614D0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614F0 Offset: 0x1A615F1 VA: 0x1A614F0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61510 Offset: 0x1A61611 VA: 0x1A61510
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB0A0 Offset: 0xBB1A1 VA: 0xBB0A0
	// RVA: 0x1A61530 Offset: 0x1A61631 VA: 0x1A61530
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0xBB0C0 Offset: 0xBB1C1 VA: 0xBB0C0
	// RVA: 0x1A61590 Offset: 0x1A61691 VA: 0x1A61590
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1A5EF30 Offset: 0x1A5F031 VA: 0x1A5EF30
	private void Normalize() { }

	// RVA: 0x1A61890 Offset: 0x1A61991 VA: 0x1A61890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A61900 Offset: 0x1A61A01 VA: 0x1A61900 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A61960 Offset: 0x1A61A61 VA: 0x1A61960 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1A61B00 Offset: 0x1A61C01 VA: 0x1A61B00
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1A62260 Offset: 0x1A62361 VA: 0x1A62260
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1A622F0 Offset: 0x1A623F1 VA: 0x1A622F0
	public void Incr2() { }

	// RVA: 0x1A623C0 Offset: 0x1A624C1 VA: 0x1A623C0
	private static void .cctor() { }
}

internal class BigInteger // TypeDefIndex: 76
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x1938A60 Offset: 0x1938B61 VA: 0x1938A60
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1938AF0 Offset: 0x1938BF1 VA: 0x1938AF0
	public void .ctor(BigInteger bi) { }

	// RVA: 0x1938BB0 Offset: 0x1938CB1 VA: 0x1938BB0
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1938CB0 Offset: 0x1938DB1 VA: 0x1938CB0
	public void .ctor(byte[] inData) { }

	// RVA: 0x1939000 Offset: 0x1939101 VA: 0x1939000
	public void .ctor(uint ui) { }

	// RVA: 0x19390A0 Offset: 0x19391A1 VA: 0x19390A0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1939100 Offset: 0x1939201 VA: 0x1939100
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x19391A0 Offset: 0x19392A1 VA: 0x19391A0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x19397F0 Offset: 0x19398F1 VA: 0x19397F0
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x19398F0 Offset: 0x19399F1 VA: 0x19398F0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FB0 Offset: 0x193A0B1 VA: 0x1939FB0
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FF0 Offset: 0x193A0F1 VA: 0x1939FF0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193A500 Offset: 0x193A601 VA: 0x193A500
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x193A7F0 Offset: 0x193A8F1 VA: 0x193A7F0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193AA80 Offset: 0x193AB81 VA: 0x193AA80
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193ACE0 Offset: 0x193ADE1 VA: 0x193ACE0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x193ADC0 Offset: 0x193AEC1 VA: 0x193ADC0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x193B000 Offset: 0x193B101 VA: 0x193B000
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x193B070 Offset: 0x193B171 VA: 0x193B070
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x193B330 Offset: 0x193B431 VA: 0x193B330
	public void Randomize() { }

	// RVA: 0x193B280 Offset: 0x193B381 VA: 0x193B280
	public int BitCount() { }

	// RVA: 0x193B3A0 Offset: 0x193B4A1 VA: 0x193B3A0
	public bool TestBit(uint bitNum) { }

	// RVA: 0x193B3F0 Offset: 0x193B4F1 VA: 0x193B3F0
	public bool TestBit(int bitNum) { }

	// RVA: 0x193B4C0 Offset: 0x193B5C1 VA: 0x193B4C0
	public void SetBit(uint bitNum) { }

	// RVA: 0x193B520 Offset: 0x193B621 VA: 0x193B520
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x193B590 Offset: 0x193B691 VA: 0x193B590
	public int LowestSetBit() { }

	// RVA: 0x193B620 Offset: 0x193B721 VA: 0x193B620
	public byte[] GetBytes() { }

	// RVA: 0x1939350 Offset: 0x1939451 VA: 0x1939350
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B7F0 Offset: 0x193B8F1 VA: 0x193B7F0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B890 Offset: 0x193B991 VA: 0x193B890
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193B9B0 Offset: 0x193BAB1 VA: 0x193B9B0
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAD0 Offset: 0x193BBD1 VA: 0x193BAD0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAF0 Offset: 0x193BBF1 VA: 0x193BAF0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB10 Offset: 0x193BC11 VA: 0x193BB10
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB30 Offset: 0x193BC31 VA: 0x193BB30
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB50 Offset: 0x193BC51 VA: 0x193BB50
	public string ToString(uint radix) { }

	// RVA: 0x193BBB0 Offset: 0x193BCB1 VA: 0x193BBB0
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1938F90 Offset: 0x1939091 VA: 0x1938F90
	private void Normalize() { }

	// RVA: 0x193BEB0 Offset: 0x193BFB1 VA: 0x193BEB0
	public void Clear() { }

	// RVA: 0x193BF10 Offset: 0x193C011 VA: 0x193BF10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x193BF80 Offset: 0x193C081 VA: 0x193BF80 Slot: 3
	public override string ToString() { }

	// RVA: 0x193BFE0 Offset: 0x193C0E1 VA: 0x193BFE0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x193C180 Offset: 0x193C281 VA: 0x193C180
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x193C8E0 Offset: 0x193C9E1 VA: 0x193C8E0
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x193CC60 Offset: 0x193CD61 VA: 0x193CC60
	public bool IsProbablePrime() { }

	// RVA: 0x193CFC0 Offset: 0x193D0C1 VA: 0x193CFC0
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x193D050 Offset: 0x193D151 VA: 0x193D050
	public void Incr2() { }

	// RVA: 0x193D120 Offset: 0x193D221 VA: 0x193D120
	private static void .cctor() { }
}

public class BigInteger // TypeDefIndex: 1600
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xBAF80 Offset: 0xBB081 VA: 0xBAF80
	// RVA: 0x1A5EA00 Offset: 0x1A5EB01 VA: 0x1A5EA00
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1A5EA90 Offset: 0x1A5EB91 VA: 0x1A5EA90
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0xBAFA0 Offset: 0xBB0A1 VA: 0xBAFA0
	// RVA: 0x1A5EB50 Offset: 0x1A5EC51 VA: 0x1A5EB50
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1A5EC50 Offset: 0x1A5ED51 VA: 0x1A5EC50
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0xBAFC0 Offset: 0xBB0C1 VA: 0xBAFC0
	// RVA: 0x1A5EFA0 Offset: 0x1A5F0A1 VA: 0x1A5EFA0
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBAFE0 Offset: 0xBB0E1 VA: 0xBAFE0
	// RVA: 0x1A5F040 Offset: 0x1A5F141 VA: 0x1A5F040
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1A5F0A0 Offset: 0x1A5F1A1 VA: 0x1A5F0A0
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1A5F140 Offset: 0x1A5F241 VA: 0x1A5F140
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB000 Offset: 0xBB101 VA: 0xBB000
	// RVA: 0x1A5F790 Offset: 0x1A5F891 VA: 0x1A5F790
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1A5F890 Offset: 0x1A5F991 VA: 0x1A5F890
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF50 Offset: 0x1A60051 VA: 0x1A5FF50
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF90 Offset: 0x1A60091 VA: 0x1A5FF90
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A604A0 Offset: 0x1A605A1 VA: 0x1A604A0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60730 Offset: 0x1A60831 VA: 0x1A60730
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60990 Offset: 0x1A60A91 VA: 0x1A60990
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1A60A70 Offset: 0x1A60B71 VA: 0x1A60A70
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1A60CB0 Offset: 0x1A60DB1 VA: 0x1A60CB0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1A60D20 Offset: 0x1A60E21 VA: 0x1A60D20
	public int BitCount() { }

	// RVA: 0x1A60DD0 Offset: 0x1A60ED1 VA: 0x1A60DD0
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB020 Offset: 0xBB121 VA: 0xBB020
	// RVA: 0x1A60EA0 Offset: 0x1A60FA1 VA: 0x1A60EA0
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB040 Offset: 0xBB141 VA: 0xBB040
	// RVA: 0x1A60F00 Offset: 0x1A61001 VA: 0x1A60F00
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1A60F70 Offset: 0x1A61071 VA: 0x1A60F70
	public int LowestSetBit() { }

	// RVA: 0x1A61000 Offset: 0x1A61101 VA: 0x1A61000
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0xBB060 Offset: 0xBB161 VA: 0xBB060
	// RVA: 0x1A5F2F0 Offset: 0x1A5F3F1 VA: 0x1A5F2F0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBB080 Offset: 0xBB181 VA: 0xBB080
	// RVA: 0x1A611D0 Offset: 0x1A612D1 VA: 0x1A611D0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1A61270 Offset: 0x1A61371 VA: 0x1A61270
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61390 Offset: 0x1A61491 VA: 0x1A61390
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614B0 Offset: 0x1A615B1 VA: 0x1A614B0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614D0 Offset: 0x1A615D1 VA: 0x1A614D0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614F0 Offset: 0x1A615F1 VA: 0x1A614F0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61510 Offset: 0x1A61611 VA: 0x1A61510
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB0A0 Offset: 0xBB1A1 VA: 0xBB0A0
	// RVA: 0x1A61530 Offset: 0x1A61631 VA: 0x1A61530
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0xBB0C0 Offset: 0xBB1C1 VA: 0xBB0C0
	// RVA: 0x1A61590 Offset: 0x1A61691 VA: 0x1A61590
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1A5EF30 Offset: 0x1A5F031 VA: 0x1A5EF30
	private void Normalize() { }

	// RVA: 0x1A61890 Offset: 0x1A61991 VA: 0x1A61890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A61900 Offset: 0x1A61A01 VA: 0x1A61900 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A61960 Offset: 0x1A61A61 VA: 0x1A61960 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1A61B00 Offset: 0x1A61C01 VA: 0x1A61B00
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1A62260 Offset: 0x1A62361 VA: 0x1A62260
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1A622F0 Offset: 0x1A623F1 VA: 0x1A622F0
	public void Incr2() { }

	// RVA: 0x1A623C0 Offset: 0x1A624C1 VA: 0x1A623C0
	private static void .cctor() { }
}

internal class BigInteger // TypeDefIndex: 76
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x1938A60 Offset: 0x1938B61 VA: 0x1938A60
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1938AF0 Offset: 0x1938BF1 VA: 0x1938AF0
	public void .ctor(BigInteger bi) { }

	// RVA: 0x1938BB0 Offset: 0x1938CB1 VA: 0x1938BB0
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1938CB0 Offset: 0x1938DB1 VA: 0x1938CB0
	public void .ctor(byte[] inData) { }

	// RVA: 0x1939000 Offset: 0x1939101 VA: 0x1939000
	public void .ctor(uint ui) { }

	// RVA: 0x19390A0 Offset: 0x19391A1 VA: 0x19390A0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1939100 Offset: 0x1939201 VA: 0x1939100
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x19391A0 Offset: 0x19392A1 VA: 0x19391A0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x19397F0 Offset: 0x19398F1 VA: 0x19397F0
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x19398F0 Offset: 0x19399F1 VA: 0x19398F0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FB0 Offset: 0x193A0B1 VA: 0x1939FB0
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FF0 Offset: 0x193A0F1 VA: 0x1939FF0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193A500 Offset: 0x193A601 VA: 0x193A500
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x193A7F0 Offset: 0x193A8F1 VA: 0x193A7F0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193AA80 Offset: 0x193AB81 VA: 0x193AA80
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193ACE0 Offset: 0x193ADE1 VA: 0x193ACE0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x193ADC0 Offset: 0x193AEC1 VA: 0x193ADC0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x193B000 Offset: 0x193B101 VA: 0x193B000
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x193B070 Offset: 0x193B171 VA: 0x193B070
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x193B330 Offset: 0x193B431 VA: 0x193B330
	public void Randomize() { }

	// RVA: 0x193B280 Offset: 0x193B381 VA: 0x193B280
	public int BitCount() { }

	// RVA: 0x193B3A0 Offset: 0x193B4A1 VA: 0x193B3A0
	public bool TestBit(uint bitNum) { }

	// RVA: 0x193B3F0 Offset: 0x193B4F1 VA: 0x193B3F0
	public bool TestBit(int bitNum) { }

	// RVA: 0x193B4C0 Offset: 0x193B5C1 VA: 0x193B4C0
	public void SetBit(uint bitNum) { }

	// RVA: 0x193B520 Offset: 0x193B621 VA: 0x193B520
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x193B590 Offset: 0x193B691 VA: 0x193B590
	public int LowestSetBit() { }

	// RVA: 0x193B620 Offset: 0x193B721 VA: 0x193B620
	public byte[] GetBytes() { }

	// RVA: 0x1939350 Offset: 0x1939451 VA: 0x1939350
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B7F0 Offset: 0x193B8F1 VA: 0x193B7F0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B890 Offset: 0x193B991 VA: 0x193B890
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193B9B0 Offset: 0x193BAB1 VA: 0x193B9B0
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAD0 Offset: 0x193BBD1 VA: 0x193BAD0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAF0 Offset: 0x193BBF1 VA: 0x193BAF0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB10 Offset: 0x193BC11 VA: 0x193BB10
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB30 Offset: 0x193BC31 VA: 0x193BB30
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB50 Offset: 0x193BC51 VA: 0x193BB50
	public string ToString(uint radix) { }

	// RVA: 0x193BBB0 Offset: 0x193BCB1 VA: 0x193BBB0
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1938F90 Offset: 0x1939091 VA: 0x1938F90
	private void Normalize() { }

	// RVA: 0x193BEB0 Offset: 0x193BFB1 VA: 0x193BEB0
	public void Clear() { }

	// RVA: 0x193BF10 Offset: 0x193C011 VA: 0x193BF10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x193BF80 Offset: 0x193C081 VA: 0x193BF80 Slot: 3
	public override string ToString() { }

	// RVA: 0x193BFE0 Offset: 0x193C0E1 VA: 0x193BFE0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x193C180 Offset: 0x193C281 VA: 0x193C180
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x193C8E0 Offset: 0x193C9E1 VA: 0x193C8E0
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x193CC60 Offset: 0x193CD61 VA: 0x193CC60
	public bool IsProbablePrime() { }

	// RVA: 0x193CFC0 Offset: 0x193D0C1 VA: 0x193CFC0
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x193D050 Offset: 0x193D151 VA: 0x193D050
	public void Incr2() { }

	// RVA: 0x193D120 Offset: 0x193D221 VA: 0x193D120
	private static void .cctor() { }
}

public class BigInteger // TypeDefIndex: 1600
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xBAF80 Offset: 0xBB081 VA: 0xBAF80
	// RVA: 0x1A5EA00 Offset: 0x1A5EB01 VA: 0x1A5EA00
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1A5EA90 Offset: 0x1A5EB91 VA: 0x1A5EA90
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0xBAFA0 Offset: 0xBB0A1 VA: 0xBAFA0
	// RVA: 0x1A5EB50 Offset: 0x1A5EC51 VA: 0x1A5EB50
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1A5EC50 Offset: 0x1A5ED51 VA: 0x1A5EC50
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0xBAFC0 Offset: 0xBB0C1 VA: 0xBAFC0
	// RVA: 0x1A5EFA0 Offset: 0x1A5F0A1 VA: 0x1A5EFA0
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBAFE0 Offset: 0xBB0E1 VA: 0xBAFE0
	// RVA: 0x1A5F040 Offset: 0x1A5F141 VA: 0x1A5F040
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1A5F0A0 Offset: 0x1A5F1A1 VA: 0x1A5F0A0
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1A5F140 Offset: 0x1A5F241 VA: 0x1A5F140
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB000 Offset: 0xBB101 VA: 0xBB000
	// RVA: 0x1A5F790 Offset: 0x1A5F891 VA: 0x1A5F790
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1A5F890 Offset: 0x1A5F991 VA: 0x1A5F890
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF50 Offset: 0x1A60051 VA: 0x1A5FF50
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF90 Offset: 0x1A60091 VA: 0x1A5FF90
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A604A0 Offset: 0x1A605A1 VA: 0x1A604A0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60730 Offset: 0x1A60831 VA: 0x1A60730
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60990 Offset: 0x1A60A91 VA: 0x1A60990
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1A60A70 Offset: 0x1A60B71 VA: 0x1A60A70
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1A60CB0 Offset: 0x1A60DB1 VA: 0x1A60CB0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1A60D20 Offset: 0x1A60E21 VA: 0x1A60D20
	public int BitCount() { }

	// RVA: 0x1A60DD0 Offset: 0x1A60ED1 VA: 0x1A60DD0
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB020 Offset: 0xBB121 VA: 0xBB020
	// RVA: 0x1A60EA0 Offset: 0x1A60FA1 VA: 0x1A60EA0
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB040 Offset: 0xBB141 VA: 0xBB040
	// RVA: 0x1A60F00 Offset: 0x1A61001 VA: 0x1A60F00
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1A60F70 Offset: 0x1A61071 VA: 0x1A60F70
	public int LowestSetBit() { }

	// RVA: 0x1A61000 Offset: 0x1A61101 VA: 0x1A61000
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0xBB060 Offset: 0xBB161 VA: 0xBB060
	// RVA: 0x1A5F2F0 Offset: 0x1A5F3F1 VA: 0x1A5F2F0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBB080 Offset: 0xBB181 VA: 0xBB080
	// RVA: 0x1A611D0 Offset: 0x1A612D1 VA: 0x1A611D0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1A61270 Offset: 0x1A61371 VA: 0x1A61270
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61390 Offset: 0x1A61491 VA: 0x1A61390
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614B0 Offset: 0x1A615B1 VA: 0x1A614B0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614D0 Offset: 0x1A615D1 VA: 0x1A614D0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614F0 Offset: 0x1A615F1 VA: 0x1A614F0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61510 Offset: 0x1A61611 VA: 0x1A61510
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB0A0 Offset: 0xBB1A1 VA: 0xBB0A0
	// RVA: 0x1A61530 Offset: 0x1A61631 VA: 0x1A61530
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0xBB0C0 Offset: 0xBB1C1 VA: 0xBB0C0
	// RVA: 0x1A61590 Offset: 0x1A61691 VA: 0x1A61590
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1A5EF30 Offset: 0x1A5F031 VA: 0x1A5EF30
	private void Normalize() { }

	// RVA: 0x1A61890 Offset: 0x1A61991 VA: 0x1A61890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A61900 Offset: 0x1A61A01 VA: 0x1A61900 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A61960 Offset: 0x1A61A61 VA: 0x1A61960 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1A61B00 Offset: 0x1A61C01 VA: 0x1A61B00
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1A62260 Offset: 0x1A62361 VA: 0x1A62260
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1A622F0 Offset: 0x1A623F1 VA: 0x1A622F0
	public void Incr2() { }

	// RVA: 0x1A623C0 Offset: 0x1A624C1 VA: 0x1A623C0
	private static void .cctor() { }
}

internal class BigInteger // TypeDefIndex: 76
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x1938A60 Offset: 0x1938B61 VA: 0x1938A60
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1938AF0 Offset: 0x1938BF1 VA: 0x1938AF0
	public void .ctor(BigInteger bi) { }

	// RVA: 0x1938BB0 Offset: 0x1938CB1 VA: 0x1938BB0
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1938CB0 Offset: 0x1938DB1 VA: 0x1938CB0
	public void .ctor(byte[] inData) { }

	// RVA: 0x1939000 Offset: 0x1939101 VA: 0x1939000
	public void .ctor(uint ui) { }

	// RVA: 0x19390A0 Offset: 0x19391A1 VA: 0x19390A0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1939100 Offset: 0x1939201 VA: 0x1939100
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x19391A0 Offset: 0x19392A1 VA: 0x19391A0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x19397F0 Offset: 0x19398F1 VA: 0x19397F0
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x19398F0 Offset: 0x19399F1 VA: 0x19398F0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FB0 Offset: 0x193A0B1 VA: 0x1939FB0
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FF0 Offset: 0x193A0F1 VA: 0x1939FF0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193A500 Offset: 0x193A601 VA: 0x193A500
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x193A7F0 Offset: 0x193A8F1 VA: 0x193A7F0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193AA80 Offset: 0x193AB81 VA: 0x193AA80
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193ACE0 Offset: 0x193ADE1 VA: 0x193ACE0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x193ADC0 Offset: 0x193AEC1 VA: 0x193ADC0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x193B000 Offset: 0x193B101 VA: 0x193B000
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x193B070 Offset: 0x193B171 VA: 0x193B070
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x193B330 Offset: 0x193B431 VA: 0x193B330
	public void Randomize() { }

	// RVA: 0x193B280 Offset: 0x193B381 VA: 0x193B280
	public int BitCount() { }

	// RVA: 0x193B3A0 Offset: 0x193B4A1 VA: 0x193B3A0
	public bool TestBit(uint bitNum) { }

	// RVA: 0x193B3F0 Offset: 0x193B4F1 VA: 0x193B3F0
	public bool TestBit(int bitNum) { }

	// RVA: 0x193B4C0 Offset: 0x193B5C1 VA: 0x193B4C0
	public void SetBit(uint bitNum) { }

	// RVA: 0x193B520 Offset: 0x193B621 VA: 0x193B520
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x193B590 Offset: 0x193B691 VA: 0x193B590
	public int LowestSetBit() { }

	// RVA: 0x193B620 Offset: 0x193B721 VA: 0x193B620
	public byte[] GetBytes() { }

	// RVA: 0x1939350 Offset: 0x1939451 VA: 0x1939350
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B7F0 Offset: 0x193B8F1 VA: 0x193B7F0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B890 Offset: 0x193B991 VA: 0x193B890
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193B9B0 Offset: 0x193BAB1 VA: 0x193B9B0
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAD0 Offset: 0x193BBD1 VA: 0x193BAD0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAF0 Offset: 0x193BBF1 VA: 0x193BAF0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB10 Offset: 0x193BC11 VA: 0x193BB10
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB30 Offset: 0x193BC31 VA: 0x193BB30
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB50 Offset: 0x193BC51 VA: 0x193BB50
	public string ToString(uint radix) { }

	// RVA: 0x193BBB0 Offset: 0x193BCB1 VA: 0x193BBB0
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1938F90 Offset: 0x1939091 VA: 0x1938F90
	private void Normalize() { }

	// RVA: 0x193BEB0 Offset: 0x193BFB1 VA: 0x193BEB0
	public void Clear() { }

	// RVA: 0x193BF10 Offset: 0x193C011 VA: 0x193BF10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x193BF80 Offset: 0x193C081 VA: 0x193BF80 Slot: 3
	public override string ToString() { }

	// RVA: 0x193BFE0 Offset: 0x193C0E1 VA: 0x193BFE0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x193C180 Offset: 0x193C281 VA: 0x193C180
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x193C8E0 Offset: 0x193C9E1 VA: 0x193C8E0
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x193CC60 Offset: 0x193CD61 VA: 0x193CC60
	public bool IsProbablePrime() { }

	// RVA: 0x193CFC0 Offset: 0x193D0C1 VA: 0x193CFC0
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x193D050 Offset: 0x193D151 VA: 0x193D050
	public void Incr2() { }

	// RVA: 0x193D120 Offset: 0x193D221 VA: 0x193D120
	private static void .cctor() { }
}

public class BigInteger // TypeDefIndex: 1600
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xBAF80 Offset: 0xBB081 VA: 0xBAF80
	// RVA: 0x1A5EA00 Offset: 0x1A5EB01 VA: 0x1A5EA00
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1A5EA90 Offset: 0x1A5EB91 VA: 0x1A5EA90
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0xBAFA0 Offset: 0xBB0A1 VA: 0xBAFA0
	// RVA: 0x1A5EB50 Offset: 0x1A5EC51 VA: 0x1A5EB50
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1A5EC50 Offset: 0x1A5ED51 VA: 0x1A5EC50
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0xBAFC0 Offset: 0xBB0C1 VA: 0xBAFC0
	// RVA: 0x1A5EFA0 Offset: 0x1A5F0A1 VA: 0x1A5EFA0
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBAFE0 Offset: 0xBB0E1 VA: 0xBAFE0
	// RVA: 0x1A5F040 Offset: 0x1A5F141 VA: 0x1A5F040
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1A5F0A0 Offset: 0x1A5F1A1 VA: 0x1A5F0A0
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1A5F140 Offset: 0x1A5F241 VA: 0x1A5F140
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB000 Offset: 0xBB101 VA: 0xBB000
	// RVA: 0x1A5F790 Offset: 0x1A5F891 VA: 0x1A5F790
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1A5F890 Offset: 0x1A5F991 VA: 0x1A5F890
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF50 Offset: 0x1A60051 VA: 0x1A5FF50
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF90 Offset: 0x1A60091 VA: 0x1A5FF90
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A604A0 Offset: 0x1A605A1 VA: 0x1A604A0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60730 Offset: 0x1A60831 VA: 0x1A60730
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60990 Offset: 0x1A60A91 VA: 0x1A60990
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1A60A70 Offset: 0x1A60B71 VA: 0x1A60A70
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1A60CB0 Offset: 0x1A60DB1 VA: 0x1A60CB0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1A60D20 Offset: 0x1A60E21 VA: 0x1A60D20
	public int BitCount() { }

	// RVA: 0x1A60DD0 Offset: 0x1A60ED1 VA: 0x1A60DD0
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB020 Offset: 0xBB121 VA: 0xBB020
	// RVA: 0x1A60EA0 Offset: 0x1A60FA1 VA: 0x1A60EA0
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB040 Offset: 0xBB141 VA: 0xBB040
	// RVA: 0x1A60F00 Offset: 0x1A61001 VA: 0x1A60F00
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1A60F70 Offset: 0x1A61071 VA: 0x1A60F70
	public int LowestSetBit() { }

	// RVA: 0x1A61000 Offset: 0x1A61101 VA: 0x1A61000
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0xBB060 Offset: 0xBB161 VA: 0xBB060
	// RVA: 0x1A5F2F0 Offset: 0x1A5F3F1 VA: 0x1A5F2F0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBB080 Offset: 0xBB181 VA: 0xBB080
	// RVA: 0x1A611D0 Offset: 0x1A612D1 VA: 0x1A611D0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1A61270 Offset: 0x1A61371 VA: 0x1A61270
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61390 Offset: 0x1A61491 VA: 0x1A61390
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614B0 Offset: 0x1A615B1 VA: 0x1A614B0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614D0 Offset: 0x1A615D1 VA: 0x1A614D0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614F0 Offset: 0x1A615F1 VA: 0x1A614F0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61510 Offset: 0x1A61611 VA: 0x1A61510
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB0A0 Offset: 0xBB1A1 VA: 0xBB0A0
	// RVA: 0x1A61530 Offset: 0x1A61631 VA: 0x1A61530
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0xBB0C0 Offset: 0xBB1C1 VA: 0xBB0C0
	// RVA: 0x1A61590 Offset: 0x1A61691 VA: 0x1A61590
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1A5EF30 Offset: 0x1A5F031 VA: 0x1A5EF30
	private void Normalize() { }

	// RVA: 0x1A61890 Offset: 0x1A61991 VA: 0x1A61890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A61900 Offset: 0x1A61A01 VA: 0x1A61900 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A61960 Offset: 0x1A61A61 VA: 0x1A61960 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1A61B00 Offset: 0x1A61C01 VA: 0x1A61B00
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1A62260 Offset: 0x1A62361 VA: 0x1A62260
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1A622F0 Offset: 0x1A623F1 VA: 0x1A622F0
	public void Incr2() { }

	// RVA: 0x1A623C0 Offset: 0x1A624C1 VA: 0x1A623C0
	private static void .cctor() { }
}

internal class BigInteger // TypeDefIndex: 76
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x1938A60 Offset: 0x1938B61 VA: 0x1938A60
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1938AF0 Offset: 0x1938BF1 VA: 0x1938AF0
	public void .ctor(BigInteger bi) { }

	// RVA: 0x1938BB0 Offset: 0x1938CB1 VA: 0x1938BB0
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1938CB0 Offset: 0x1938DB1 VA: 0x1938CB0
	public void .ctor(byte[] inData) { }

	// RVA: 0x1939000 Offset: 0x1939101 VA: 0x1939000
	public void .ctor(uint ui) { }

	// RVA: 0x19390A0 Offset: 0x19391A1 VA: 0x19390A0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1939100 Offset: 0x1939201 VA: 0x1939100
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x19391A0 Offset: 0x19392A1 VA: 0x19391A0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x19397F0 Offset: 0x19398F1 VA: 0x19397F0
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x19398F0 Offset: 0x19399F1 VA: 0x19398F0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FB0 Offset: 0x193A0B1 VA: 0x1939FB0
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FF0 Offset: 0x193A0F1 VA: 0x1939FF0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193A500 Offset: 0x193A601 VA: 0x193A500
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x193A7F0 Offset: 0x193A8F1 VA: 0x193A7F0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193AA80 Offset: 0x193AB81 VA: 0x193AA80
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193ACE0 Offset: 0x193ADE1 VA: 0x193ACE0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x193ADC0 Offset: 0x193AEC1 VA: 0x193ADC0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x193B000 Offset: 0x193B101 VA: 0x193B000
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x193B070 Offset: 0x193B171 VA: 0x193B070
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x193B330 Offset: 0x193B431 VA: 0x193B330
	public void Randomize() { }

	// RVA: 0x193B280 Offset: 0x193B381 VA: 0x193B280
	public int BitCount() { }

	// RVA: 0x193B3A0 Offset: 0x193B4A1 VA: 0x193B3A0
	public bool TestBit(uint bitNum) { }

	// RVA: 0x193B3F0 Offset: 0x193B4F1 VA: 0x193B3F0
	public bool TestBit(int bitNum) { }

	// RVA: 0x193B4C0 Offset: 0x193B5C1 VA: 0x193B4C0
	public void SetBit(uint bitNum) { }

	// RVA: 0x193B520 Offset: 0x193B621 VA: 0x193B520
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x193B590 Offset: 0x193B691 VA: 0x193B590
	public int LowestSetBit() { }

	// RVA: 0x193B620 Offset: 0x193B721 VA: 0x193B620
	public byte[] GetBytes() { }

	// RVA: 0x1939350 Offset: 0x1939451 VA: 0x1939350
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B7F0 Offset: 0x193B8F1 VA: 0x193B7F0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B890 Offset: 0x193B991 VA: 0x193B890
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193B9B0 Offset: 0x193BAB1 VA: 0x193B9B0
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAD0 Offset: 0x193BBD1 VA: 0x193BAD0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAF0 Offset: 0x193BBF1 VA: 0x193BAF0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB10 Offset: 0x193BC11 VA: 0x193BB10
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB30 Offset: 0x193BC31 VA: 0x193BB30
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB50 Offset: 0x193BC51 VA: 0x193BB50
	public string ToString(uint radix) { }

	// RVA: 0x193BBB0 Offset: 0x193BCB1 VA: 0x193BBB0
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1938F90 Offset: 0x1939091 VA: 0x1938F90
	private void Normalize() { }

	// RVA: 0x193BEB0 Offset: 0x193BFB1 VA: 0x193BEB0
	public void Clear() { }

	// RVA: 0x193BF10 Offset: 0x193C011 VA: 0x193BF10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x193BF80 Offset: 0x193C081 VA: 0x193BF80 Slot: 3
	public override string ToString() { }

	// RVA: 0x193BFE0 Offset: 0x193C0E1 VA: 0x193BFE0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x193C180 Offset: 0x193C281 VA: 0x193C180
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x193C8E0 Offset: 0x193C9E1 VA: 0x193C8E0
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x193CC60 Offset: 0x193CD61 VA: 0x193CC60
	public bool IsProbablePrime() { }

	// RVA: 0x193CFC0 Offset: 0x193D0C1 VA: 0x193CFC0
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x193D050 Offset: 0x193D151 VA: 0x193D050
	public void Incr2() { }

	// RVA: 0x193D120 Offset: 0x193D221 VA: 0x193D120
	private static void .cctor() { }
}

public class BigInteger // TypeDefIndex: 1600
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xBAF80 Offset: 0xBB081 VA: 0xBAF80
	// RVA: 0x1A5EA00 Offset: 0x1A5EB01 VA: 0x1A5EA00
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1A5EA90 Offset: 0x1A5EB91 VA: 0x1A5EA90
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0xBAFA0 Offset: 0xBB0A1 VA: 0xBAFA0
	// RVA: 0x1A5EB50 Offset: 0x1A5EC51 VA: 0x1A5EB50
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1A5EC50 Offset: 0x1A5ED51 VA: 0x1A5EC50
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0xBAFC0 Offset: 0xBB0C1 VA: 0xBAFC0
	// RVA: 0x1A5EFA0 Offset: 0x1A5F0A1 VA: 0x1A5EFA0
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBAFE0 Offset: 0xBB0E1 VA: 0xBAFE0
	// RVA: 0x1A5F040 Offset: 0x1A5F141 VA: 0x1A5F040
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1A5F0A0 Offset: 0x1A5F1A1 VA: 0x1A5F0A0
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1A5F140 Offset: 0x1A5F241 VA: 0x1A5F140
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB000 Offset: 0xBB101 VA: 0xBB000
	// RVA: 0x1A5F790 Offset: 0x1A5F891 VA: 0x1A5F790
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1A5F890 Offset: 0x1A5F991 VA: 0x1A5F890
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF50 Offset: 0x1A60051 VA: 0x1A5FF50
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF90 Offset: 0x1A60091 VA: 0x1A5FF90
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A604A0 Offset: 0x1A605A1 VA: 0x1A604A0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60730 Offset: 0x1A60831 VA: 0x1A60730
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60990 Offset: 0x1A60A91 VA: 0x1A60990
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1A60A70 Offset: 0x1A60B71 VA: 0x1A60A70
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1A60CB0 Offset: 0x1A60DB1 VA: 0x1A60CB0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1A60D20 Offset: 0x1A60E21 VA: 0x1A60D20
	public int BitCount() { }

	// RVA: 0x1A60DD0 Offset: 0x1A60ED1 VA: 0x1A60DD0
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB020 Offset: 0xBB121 VA: 0xBB020
	// RVA: 0x1A60EA0 Offset: 0x1A60FA1 VA: 0x1A60EA0
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB040 Offset: 0xBB141 VA: 0xBB040
	// RVA: 0x1A60F00 Offset: 0x1A61001 VA: 0x1A60F00
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1A60F70 Offset: 0x1A61071 VA: 0x1A60F70
	public int LowestSetBit() { }

	// RVA: 0x1A61000 Offset: 0x1A61101 VA: 0x1A61000
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0xBB060 Offset: 0xBB161 VA: 0xBB060
	// RVA: 0x1A5F2F0 Offset: 0x1A5F3F1 VA: 0x1A5F2F0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBB080 Offset: 0xBB181 VA: 0xBB080
	// RVA: 0x1A611D0 Offset: 0x1A612D1 VA: 0x1A611D0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1A61270 Offset: 0x1A61371 VA: 0x1A61270
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61390 Offset: 0x1A61491 VA: 0x1A61390
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614B0 Offset: 0x1A615B1 VA: 0x1A614B0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614D0 Offset: 0x1A615D1 VA: 0x1A614D0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614F0 Offset: 0x1A615F1 VA: 0x1A614F0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61510 Offset: 0x1A61611 VA: 0x1A61510
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB0A0 Offset: 0xBB1A1 VA: 0xBB0A0
	// RVA: 0x1A61530 Offset: 0x1A61631 VA: 0x1A61530
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0xBB0C0 Offset: 0xBB1C1 VA: 0xBB0C0
	// RVA: 0x1A61590 Offset: 0x1A61691 VA: 0x1A61590
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1A5EF30 Offset: 0x1A5F031 VA: 0x1A5EF30
	private void Normalize() { }

	// RVA: 0x1A61890 Offset: 0x1A61991 VA: 0x1A61890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A61900 Offset: 0x1A61A01 VA: 0x1A61900 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A61960 Offset: 0x1A61A61 VA: 0x1A61960 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1A61B00 Offset: 0x1A61C01 VA: 0x1A61B00
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1A62260 Offset: 0x1A62361 VA: 0x1A62260
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1A622F0 Offset: 0x1A623F1 VA: 0x1A622F0
	public void Incr2() { }

	// RVA: 0x1A623C0 Offset: 0x1A624C1 VA: 0x1A623C0
	private static void .cctor() { }
}

internal class BigInteger // TypeDefIndex: 76
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x1938A60 Offset: 0x1938B61 VA: 0x1938A60
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1938AF0 Offset: 0x1938BF1 VA: 0x1938AF0
	public void .ctor(BigInteger bi) { }

	// RVA: 0x1938BB0 Offset: 0x1938CB1 VA: 0x1938BB0
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1938CB0 Offset: 0x1938DB1 VA: 0x1938CB0
	public void .ctor(byte[] inData) { }

	// RVA: 0x1939000 Offset: 0x1939101 VA: 0x1939000
	public void .ctor(uint ui) { }

	// RVA: 0x19390A0 Offset: 0x19391A1 VA: 0x19390A0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1939100 Offset: 0x1939201 VA: 0x1939100
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x19391A0 Offset: 0x19392A1 VA: 0x19391A0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x19397F0 Offset: 0x19398F1 VA: 0x19397F0
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x19398F0 Offset: 0x19399F1 VA: 0x19398F0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FB0 Offset: 0x193A0B1 VA: 0x1939FB0
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1939FF0 Offset: 0x193A0F1 VA: 0x1939FF0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193A500 Offset: 0x193A601 VA: 0x193A500
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x193A7F0 Offset: 0x193A8F1 VA: 0x193A7F0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193AA80 Offset: 0x193AB81 VA: 0x193AA80
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x193ACE0 Offset: 0x193ADE1 VA: 0x193ACE0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x193ADC0 Offset: 0x193AEC1 VA: 0x193ADC0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x193B000 Offset: 0x193B101 VA: 0x193B000
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x193B070 Offset: 0x193B171 VA: 0x193B070
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x193B330 Offset: 0x193B431 VA: 0x193B330
	public void Randomize() { }

	// RVA: 0x193B280 Offset: 0x193B381 VA: 0x193B280
	public int BitCount() { }

	// RVA: 0x193B3A0 Offset: 0x193B4A1 VA: 0x193B3A0
	public bool TestBit(uint bitNum) { }

	// RVA: 0x193B3F0 Offset: 0x193B4F1 VA: 0x193B3F0
	public bool TestBit(int bitNum) { }

	// RVA: 0x193B4C0 Offset: 0x193B5C1 VA: 0x193B4C0
	public void SetBit(uint bitNum) { }

	// RVA: 0x193B520 Offset: 0x193B621 VA: 0x193B520
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x193B590 Offset: 0x193B691 VA: 0x193B590
	public int LowestSetBit() { }

	// RVA: 0x193B620 Offset: 0x193B721 VA: 0x193B620
	public byte[] GetBytes() { }

	// RVA: 0x1939350 Offset: 0x1939451 VA: 0x1939350
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B7F0 Offset: 0x193B8F1 VA: 0x193B7F0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x193B890 Offset: 0x193B991 VA: 0x193B890
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193B9B0 Offset: 0x193BAB1 VA: 0x193B9B0
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAD0 Offset: 0x193BBD1 VA: 0x193BAD0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BAF0 Offset: 0x193BBF1 VA: 0x193BAF0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB10 Offset: 0x193BC11 VA: 0x193BB10
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB30 Offset: 0x193BC31 VA: 0x193BB30
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BB50 Offset: 0x193BC51 VA: 0x193BB50
	public string ToString(uint radix) { }

	// RVA: 0x193BBB0 Offset: 0x193BCB1 VA: 0x193BBB0
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1938F90 Offset: 0x1939091 VA: 0x1938F90
	private void Normalize() { }

	// RVA: 0x193BEB0 Offset: 0x193BFB1 VA: 0x193BEB0
	public void Clear() { }

	// RVA: 0x193BF10 Offset: 0x193C011 VA: 0x193BF10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x193BF80 Offset: 0x193C081 VA: 0x193BF80 Slot: 3
	public override string ToString() { }

	// RVA: 0x193BFE0 Offset: 0x193C0E1 VA: 0x193BFE0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x193C180 Offset: 0x193C281 VA: 0x193C180
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x193C8E0 Offset: 0x193C9E1 VA: 0x193C8E0
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x193CC60 Offset: 0x193CD61 VA: 0x193CC60
	public bool IsProbablePrime() { }

	// RVA: 0x193CFC0 Offset: 0x193D0C1 VA: 0x193CFC0
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x193D050 Offset: 0x193D151 VA: 0x193D050
	public void Incr2() { }

	// RVA: 0x193D120 Offset: 0x193D221 VA: 0x193D120
	private static void .cctor() { }
}

public class BigInteger // TypeDefIndex: 1600
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0xBAF80 Offset: 0xBB081 VA: 0xBAF80
	// RVA: 0x1A5EA00 Offset: 0x1A5EB01 VA: 0x1A5EA00
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1A5EA90 Offset: 0x1A5EB91 VA: 0x1A5EA90
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0xBAFA0 Offset: 0xBB0A1 VA: 0xBAFA0
	// RVA: 0x1A5EB50 Offset: 0x1A5EC51 VA: 0x1A5EB50
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1A5EC50 Offset: 0x1A5ED51 VA: 0x1A5EC50
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0xBAFC0 Offset: 0xBB0C1 VA: 0xBAFC0
	// RVA: 0x1A5EFA0 Offset: 0x1A5F0A1 VA: 0x1A5EFA0
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBAFE0 Offset: 0xBB0E1 VA: 0xBAFE0
	// RVA: 0x1A5F040 Offset: 0x1A5F141 VA: 0x1A5F040
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1A5F0A0 Offset: 0x1A5F1A1 VA: 0x1A5F0A0
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1A5F140 Offset: 0x1A5F241 VA: 0x1A5F140
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB000 Offset: 0xBB101 VA: 0xBB000
	// RVA: 0x1A5F790 Offset: 0x1A5F891 VA: 0x1A5F790
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1A5F890 Offset: 0x1A5F991 VA: 0x1A5F890
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF50 Offset: 0x1A60051 VA: 0x1A5FF50
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5FF90 Offset: 0x1A60091 VA: 0x1A5FF90
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A604A0 Offset: 0x1A605A1 VA: 0x1A604A0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60730 Offset: 0x1A60831 VA: 0x1A60730
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1A60990 Offset: 0x1A60A91 VA: 0x1A60990
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1A60A70 Offset: 0x1A60B71 VA: 0x1A60A70
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1A60CB0 Offset: 0x1A60DB1 VA: 0x1A60CB0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1A60D20 Offset: 0x1A60E21 VA: 0x1A60D20
	public int BitCount() { }

	// RVA: 0x1A60DD0 Offset: 0x1A60ED1 VA: 0x1A60DD0
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB020 Offset: 0xBB121 VA: 0xBB020
	// RVA: 0x1A60EA0 Offset: 0x1A60FA1 VA: 0x1A60EA0
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0xBB040 Offset: 0xBB141 VA: 0xBB040
	// RVA: 0x1A60F00 Offset: 0x1A61001 VA: 0x1A60F00
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1A60F70 Offset: 0x1A61071 VA: 0x1A60F70
	public int LowestSetBit() { }

	// RVA: 0x1A61000 Offset: 0x1A61101 VA: 0x1A61000
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0xBB060 Offset: 0xBB161 VA: 0xBB060
	// RVA: 0x1A5F2F0 Offset: 0x1A5F3F1 VA: 0x1A5F2F0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0xBB080 Offset: 0xBB181 VA: 0xBB080
	// RVA: 0x1A611D0 Offset: 0x1A612D1 VA: 0x1A611D0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1A61270 Offset: 0x1A61371 VA: 0x1A61270
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61390 Offset: 0x1A61491 VA: 0x1A61390
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614B0 Offset: 0x1A615B1 VA: 0x1A614B0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614D0 Offset: 0x1A615D1 VA: 0x1A614D0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A614F0 Offset: 0x1A615F1 VA: 0x1A614F0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A61510 Offset: 0x1A61611 VA: 0x1A61510
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0xBB0A0 Offset: 0xBB1A1 VA: 0xBB0A0
	// RVA: 0x1A61530 Offset: 0x1A61631 VA: 0x1A61530
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0xBB0C0 Offset: 0xBB1C1 VA: 0xBB0C0
	// RVA: 0x1A61590 Offset: 0x1A61691 VA: 0x1A61590
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1A5EF30 Offset: 0x1A5F031 VA: 0x1A5EF30
	private void Normalize() { }

	// RVA: 0x1A61890 Offset: 0x1A61991 VA: 0x1A61890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A61900 Offset: 0x1A61A01 VA: 0x1A61900 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A61960 Offset: 0x1A61A61 VA: 0x1A61960 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1A61B00 Offset: 0x1A61C01 VA: 0x1A61B00
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1A62260 Offset: 0x1A62361 VA: 0x1A62260
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1A622F0 Offset: 0x1A623F1 VA: 0x1A622F0
	public void Incr2() { }

	// RVA: 0x1A623C0 Offset: 0x1A624C1 VA: 0x1A623C0
	private static void .cctor() { }
}

