[ComVisibleAttribute] // RVA: 0xB00F0 Offset: 0xB01F1 VA: 0xB00F0
public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 948
{
	// Fields
	private bool m_use40bitSalt; // 0x48
	private static KeySizes[] s_legalKeySizes; // 0x0

	// Properties
	public override int EffectiveKeySize { get; }

	// Methods

	// RVA: 0x1945B70 Offset: 0x1945C71 VA: 0x1945B70
	public void .ctor() { }

	// RVA: 0x19512E0 Offset: 0x19513E1 VA: 0x19512E0 Slot: 26
	public override int get_EffectiveKeySize() { }

	// RVA: 0x19512F0 Offset: 0x19513F1 VA: 0x19512F0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x19519E0 Offset: 0x1951AE1 VA: 0x19519E0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1951AA0 Offset: 0x1951BA1 VA: 0x1951AA0 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x1951B40 Offset: 0x1951C41 VA: 0x1951B40 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1951BC0 Offset: 0x1951CC1 VA: 0x1951BC0
	private static void .cctor() { }
}

