public sealed class AesCryptoServiceProvider : Aes // TypeDefIndex: 2160
{
	// Properties
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override int FeedbackSize { get; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x1B58A70 Offset: 0x1B58B71 VA: 0x1B58A70
	public void .ctor() { }

	// RVA: 0x1B58AF0 Offset: 0x1B58BF1 VA: 0x1B58AF0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1B58B30 Offset: 0x1B58C31 VA: 0x1B58B30 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x1B58B70 Offset: 0x1B58C71 VA: 0x1B58B70 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B593F0 Offset: 0x1B594F1 VA: 0x1B593F0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B594E0 Offset: 0x1B595E1 VA: 0x1B594E0 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x1B594F0 Offset: 0x1B595F1 VA: 0x1B594F0 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1B59500 Offset: 0x1B59601 VA: 0x1B59500 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1B59510 Offset: 0x1B59611 VA: 0x1B59510 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1B59520 Offset: 0x1B59621 VA: 0x1B59520 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1B59530 Offset: 0x1B59631 VA: 0x1B59530 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1B59540 Offset: 0x1B59641 VA: 0x1B59540 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x1B59550 Offset: 0x1B59651 VA: 0x1B59550 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x1B59560 Offset: 0x1B59661 VA: 0x1B59560 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x1B59600 Offset: 0x1B59701 VA: 0x1B59600 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x1B59610 Offset: 0x1B59711 VA: 0x1B59610 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x1B59620 Offset: 0x1B59721 VA: 0x1B59620 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x1B59680 Offset: 0x1B59781 VA: 0x1B59680 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x1B596E0 Offset: 0x1B597E1 VA: 0x1B596E0 Slot: 5
	protected override void Dispose(bool disposing) { }
}

