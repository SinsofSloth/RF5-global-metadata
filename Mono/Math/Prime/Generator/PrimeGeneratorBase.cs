internal abstract class PrimeGeneratorBase // TypeDefIndex: 83
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x193E610 Offset: 0x193E711 VA: 0x193E610 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x193E620 Offset: 0x193E721 VA: 0x193E620 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x193E6C0 Offset: 0x193E7C1 VA: 0x193E6C0 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x193E6D0 Offset: 0x193E7D1 VA: 0x193E6D0
	protected void .ctor() { }
}

public abstract class PrimeGeneratorBase // TypeDefIndex: 1607
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x1A63BB0 Offset: 0x1A63CB1 VA: 0x1A63BB0 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x1A63BC0 Offset: 0x1A63CC1 VA: 0x1A63BC0 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1A63C60 Offset: 0x1A63D61 VA: 0x1A63C60 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x1A63C70 Offset: 0x1A63D71 VA: 0x1A63C70
	protected void .ctor() { }
}

