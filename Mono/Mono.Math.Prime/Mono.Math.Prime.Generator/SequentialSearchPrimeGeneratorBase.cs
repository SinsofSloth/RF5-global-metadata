public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 1608
{
	// Methods

	// RVA: 0x1A63C80 Offset: 0x1A63D81 VA: 0x1A63C80 Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x1A63D80 Offset: 0x1A63E81 VA: 0x1A63D80 Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x1A63D90 Offset: 0x1A63E91 VA: 0x1A63D90 Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x1A64580 Offset: 0x1A64681 VA: 0x1A64580 Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x1A622E0 Offset: 0x1A623E1 VA: 0x1A622E0
	public void .ctor() { }
}

