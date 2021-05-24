[ComVisibleAttribute] // RVA: 0xB0130 Offset: 0xB0231 VA: 0xB0130
public sealed class RijndaelManaged : Rijndael // TypeDefIndex: 950
{
	// Methods

	// RVA: 0x262DFA0 Offset: 0x262E0A1 VA: 0x262DFA0
	public void .ctor() { }

	// RVA: 0x262E060 Offset: 0x262E161 VA: 0x262E060 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x262E220 Offset: 0x262E321 VA: 0x262E220 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x262E240 Offset: 0x262E341 VA: 0x262E240 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x262E360 Offset: 0x262E461 VA: 0x262E360 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x262E080 Offset: 0x262E181 VA: 0x262E080
	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }
}

