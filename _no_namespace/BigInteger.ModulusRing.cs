internal sealed class BigInteger.ModulusRing // TypeDefIndex: 78
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x193C960 Offset: 0x193CA61 VA: 0x193C960
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x193DC60 Offset: 0x193DD61 VA: 0x193DC60
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x193E330 Offset: 0x193E431 VA: 0x193E330
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x193D9F0 Offset: 0x193DAF1 VA: 0x193D9F0
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x193CAF0 Offset: 0x193CBF1 VA: 0x193CAF0
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0x193E590 Offset: 0x193E691 VA: 0x193E590
	public BigInteger Pow(uint b, BigInteger exp) { }
}

public sealed class BigInteger.ModulusRing // TypeDefIndex: 1602
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x1A62C90 Offset: 0x1A62D91 VA: 0x1A62C90
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1A63090 Offset: 0x1A63191 VA: 0x1A63090
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1A63760 Offset: 0x1A63861 VA: 0x1A63760
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1A62E20 Offset: 0x1A62F21 VA: 0x1A62E20
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1A639C0 Offset: 0x1A63AC1 VA: 0x1A639C0
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	[CLSCompliantAttribute] // RVA: 0xBB0E0 Offset: 0xBB1E1 VA: 0xBB0E0
	// RVA: 0x1A63B30 Offset: 0x1A63C31 VA: 0x1A63B30
	public BigInteger Pow(uint b, BigInteger exp) { }
}

