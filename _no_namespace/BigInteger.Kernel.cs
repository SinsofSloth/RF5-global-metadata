private sealed class BigInteger.Kernel // TypeDefIndex: 79
{
	// Methods

	// RVA: 0x1939560 Offset: 0x1939661 VA: 0x1939560
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x193D1A0 Offset: 0x193D2A1 VA: 0x193D1A0
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x193D2D0 Offset: 0x193D3D1 VA: 0x193D2D0
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x19393F0 Offset: 0x19394F1 VA: 0x19393F0
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193BDE0 Offset: 0x193BEE1 VA: 0x193BDE0
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x1939870 Offset: 0x1939971 VA: 0x1939870
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x193D4B0 Offset: 0x193D5B1 VA: 0x193D4B0
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x1939930 Offset: 0x1939A31 VA: 0x1939930
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x193A800 Offset: 0x193A901 VA: 0x193A800
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x193AA90 Offset: 0x193AB91 VA: 0x193AA90
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x193A630 Offset: 0x193A731 VA: 0x193A630
	public static BigInteger MultiplyByDword(BigInteger n, uint f) { }

	// RVA: 0x193A3E0 Offset: 0x193A4E1 VA: 0x193A3E0
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x193D740 Offset: 0x193D841 VA: 0x193D740
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x193D890 Offset: 0x193D991 VA: 0x193D890
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x193C190 Offset: 0x193C291 VA: 0x193C190
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }
}

private sealed class BigInteger.Kernel // TypeDefIndex: 1603
{
	// Methods

	// RVA: 0x1A5F500 Offset: 0x1A5F601 VA: 0x1A5F500
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x1A62440 Offset: 0x1A62541 VA: 0x1A62440
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x1A62570 Offset: 0x1A62671 VA: 0x1A62570
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A5F390 Offset: 0x1A5F491 VA: 0x1A5F390
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A617C0 Offset: 0x1A618C1 VA: 0x1A617C0
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x1A5F810 Offset: 0x1A5F911 VA: 0x1A5F810
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x1A62750 Offset: 0x1A62851 VA: 0x1A62750
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x1A5F8D0 Offset: 0x1A5F9D1 VA: 0x1A5F8D0
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1A604B0 Offset: 0x1A605B1 VA: 0x1A604B0
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x1A60740 Offset: 0x1A60841 VA: 0x1A60740
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x1A60380 Offset: 0x1A60481 VA: 0x1A60380
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x1A629E0 Offset: 0x1A62AE1 VA: 0x1A629E0
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x1A62B30 Offset: 0x1A62C31 VA: 0x1A62B30
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x1A61B10 Offset: 0x1A61C11 VA: 0x1A61B10
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }
}

