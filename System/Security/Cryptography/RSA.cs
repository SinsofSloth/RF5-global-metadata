[ComVisibleAttribute] // RVA: 0xB01D0 Offset: 0xB02D1 VA: 0xB01D0
public abstract class RSA : AsymmetricAlgorithm // TypeDefIndex: 956
{
	// Methods

	// RVA: 0x1954A60 Offset: 0x1954B61 VA: 0x1954A60
	protected void .ctor() { }

	// RVA: 0x1954A70 Offset: 0x1954B71 VA: 0x1954A70
	public static RSA Create() { }

	// RVA: 0x1954AF0 Offset: 0x1954BF1 VA: 0x1954AF0 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x1954FF0 Offset: 0x19550F1 VA: 0x1954FF0 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void ImportParameters(RSAParameters parameters) { }
}

