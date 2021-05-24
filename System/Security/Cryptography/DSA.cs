[ComVisibleAttribute] // RVA: 0xAFED0 Offset: 0xAFFD1 VA: 0xAFED0
public abstract class DSA : AsymmetricAlgorithm // TypeDefIndex: 930
{
	// Methods

	// RVA: 0x194C850 Offset: 0x194C951 VA: 0x194C850
	protected void .ctor() { }

	// RVA: 0x194C860 Offset: 0x194C961 VA: 0x194C860
	public static DSA Create() { }

	// RVA: 0x194C8E0 Offset: 0x194C9E1 VA: 0x194C8E0 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x194CE90 Offset: 0x194CF91 VA: 0x194CE90 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void ImportParameters(DSAParameters parameters) { }
}

