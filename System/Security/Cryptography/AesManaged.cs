public sealed class AesManaged : Aes // TypeDefIndex: 2159
{
	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x1B596F0 Offset: 0x1B597F1 VA: 0x1B596F0
	public void .ctor() { }

	// RVA: 0x1B59850 Offset: 0x1B59951 VA: 0x1B59850 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x1B59870 Offset: 0x1B59971 VA: 0x1B59870 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x1B59890 Offset: 0x1B59991 VA: 0x1B59890 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1B598B0 Offset: 0x1B599B1 VA: 0x1B598B0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1B598D0 Offset: 0x1B599D1 VA: 0x1B598D0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1B598F0 Offset: 0x1B599F1 VA: 0x1B598F0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1B59920 Offset: 0x1B59A21 VA: 0x1B59920 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1B59950 Offset: 0x1B59A51 VA: 0x1B59950 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x1B59980 Offset: 0x1B59A81 VA: 0x1B59980 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x1B59A40 Offset: 0x1B59B41 VA: 0x1B59A40 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x1B59A70 Offset: 0x1B59B71 VA: 0x1B59A70 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x1B59AA0 Offset: 0x1B59BA1 VA: 0x1B59AA0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x1B59AD0 Offset: 0x1B59BD1 VA: 0x1B59AD0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B59C40 Offset: 0x1B59D41 VA: 0x1B59C40 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x1B59C70 Offset: 0x1B59D71 VA: 0x1B59C70 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B59DE0 Offset: 0x1B59EE1 VA: 0x1B59DE0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1B59F00 Offset: 0x1B5A001 VA: 0x1B59F00 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1B59F30 Offset: 0x1B5A031 VA: 0x1B59F30 Slot: 24
	public override void GenerateKey() { }
}

public sealed class AesManaged : Aes // TypeDefIndex: 2159
{
	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x1B596F0 Offset: 0x1B597F1 VA: 0x1B596F0
	public void .ctor() { }

	// RVA: 0x1B59850 Offset: 0x1B59951 VA: 0x1B59850 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x1B59870 Offset: 0x1B59971 VA: 0x1B59870 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x1B59890 Offset: 0x1B59991 VA: 0x1B59890 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1B598B0 Offset: 0x1B599B1 VA: 0x1B598B0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1B598D0 Offset: 0x1B599D1 VA: 0x1B598D0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1B598F0 Offset: 0x1B599F1 VA: 0x1B598F0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1B59920 Offset: 0x1B59A21 VA: 0x1B59920 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1B59950 Offset: 0x1B59A51 VA: 0x1B59950 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x1B59980 Offset: 0x1B59A81 VA: 0x1B59980 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x1B59A40 Offset: 0x1B59B41 VA: 0x1B59A40 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x1B59A70 Offset: 0x1B59B71 VA: 0x1B59A70 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x1B59AA0 Offset: 0x1B59BA1 VA: 0x1B59AA0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x1B59AD0 Offset: 0x1B59BD1 VA: 0x1B59AD0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B59C40 Offset: 0x1B59D41 VA: 0x1B59C40 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x1B59C70 Offset: 0x1B59D71 VA: 0x1B59C70 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B59DE0 Offset: 0x1B59EE1 VA: 0x1B59DE0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1B59F00 Offset: 0x1B5A001 VA: 0x1B59F00 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1B59F30 Offset: 0x1B5A031 VA: 0x1B59F30 Slot: 24
	public override void GenerateKey() { }
}

public sealed class AesManaged : Aes // TypeDefIndex: 2159
{
	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x1B596F0 Offset: 0x1B597F1 VA: 0x1B596F0
	public void .ctor() { }

	// RVA: 0x1B59850 Offset: 0x1B59951 VA: 0x1B59850 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x1B59870 Offset: 0x1B59971 VA: 0x1B59870 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x1B59890 Offset: 0x1B59991 VA: 0x1B59890 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1B598B0 Offset: 0x1B599B1 VA: 0x1B598B0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1B598D0 Offset: 0x1B599D1 VA: 0x1B598D0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1B598F0 Offset: 0x1B599F1 VA: 0x1B598F0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1B59920 Offset: 0x1B59A21 VA: 0x1B59920 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1B59950 Offset: 0x1B59A51 VA: 0x1B59950 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x1B59980 Offset: 0x1B59A81 VA: 0x1B59980 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x1B59A40 Offset: 0x1B59B41 VA: 0x1B59A40 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x1B59A70 Offset: 0x1B59B71 VA: 0x1B59A70 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x1B59AA0 Offset: 0x1B59BA1 VA: 0x1B59AA0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x1B59AD0 Offset: 0x1B59BD1 VA: 0x1B59AD0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B59C40 Offset: 0x1B59D41 VA: 0x1B59C40 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x1B59C70 Offset: 0x1B59D71 VA: 0x1B59C70 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B59DE0 Offset: 0x1B59EE1 VA: 0x1B59DE0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1B59F00 Offset: 0x1B5A001 VA: 0x1B59F00 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1B59F30 Offset: 0x1B5A031 VA: 0x1B59F30 Slot: 24
	public override void GenerateKey() { }
}

public sealed class AesManaged : Aes // TypeDefIndex: 2159
{
	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x1B596F0 Offset: 0x1B597F1 VA: 0x1B596F0
	public void .ctor() { }

	// RVA: 0x1B59850 Offset: 0x1B59951 VA: 0x1B59850 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x1B59870 Offset: 0x1B59971 VA: 0x1B59870 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x1B59890 Offset: 0x1B59991 VA: 0x1B59890 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1B598B0 Offset: 0x1B599B1 VA: 0x1B598B0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1B598D0 Offset: 0x1B599D1 VA: 0x1B598D0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1B598F0 Offset: 0x1B599F1 VA: 0x1B598F0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1B59920 Offset: 0x1B59A21 VA: 0x1B59920 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1B59950 Offset: 0x1B59A51 VA: 0x1B59950 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x1B59980 Offset: 0x1B59A81 VA: 0x1B59980 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x1B59A40 Offset: 0x1B59B41 VA: 0x1B59A40 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x1B59A70 Offset: 0x1B59B71 VA: 0x1B59A70 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x1B59AA0 Offset: 0x1B59BA1 VA: 0x1B59AA0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x1B59AD0 Offset: 0x1B59BD1 VA: 0x1B59AD0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B59C40 Offset: 0x1B59D41 VA: 0x1B59C40 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x1B59C70 Offset: 0x1B59D71 VA: 0x1B59C70 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B59DE0 Offset: 0x1B59EE1 VA: 0x1B59DE0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1B59F00 Offset: 0x1B5A001 VA: 0x1B59F00 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1B59F30 Offset: 0x1B5A031 VA: 0x1B59F30 Slot: 24
	public override void GenerateKey() { }
}

public sealed class AesManaged : Aes // TypeDefIndex: 2159
{
	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x1B596F0 Offset: 0x1B597F1 VA: 0x1B596F0
	public void .ctor() { }

	// RVA: 0x1B59850 Offset: 0x1B59951 VA: 0x1B59850 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x1B59870 Offset: 0x1B59971 VA: 0x1B59870 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x1B59890 Offset: 0x1B59991 VA: 0x1B59890 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1B598B0 Offset: 0x1B599B1 VA: 0x1B598B0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1B598D0 Offset: 0x1B599D1 VA: 0x1B598D0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1B598F0 Offset: 0x1B599F1 VA: 0x1B598F0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1B59920 Offset: 0x1B59A21 VA: 0x1B59920 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1B59950 Offset: 0x1B59A51 VA: 0x1B59950 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x1B59980 Offset: 0x1B59A81 VA: 0x1B59980 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x1B59A40 Offset: 0x1B59B41 VA: 0x1B59A40 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x1B59A70 Offset: 0x1B59B71 VA: 0x1B59A70 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x1B59AA0 Offset: 0x1B59BA1 VA: 0x1B59AA0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x1B59AD0 Offset: 0x1B59BD1 VA: 0x1B59AD0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B59C40 Offset: 0x1B59D41 VA: 0x1B59C40 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x1B59C70 Offset: 0x1B59D71 VA: 0x1B59C70 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B59DE0 Offset: 0x1B59EE1 VA: 0x1B59DE0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1B59F00 Offset: 0x1B5A001 VA: 0x1B59F00 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1B59F30 Offset: 0x1B5A031 VA: 0x1B59F30 Slot: 24
	public override void GenerateKey() { }
}

public sealed class AesManaged : Aes // TypeDefIndex: 2159
{
	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x1B596F0 Offset: 0x1B597F1 VA: 0x1B596F0
	public void .ctor() { }

	// RVA: 0x1B59850 Offset: 0x1B59951 VA: 0x1B59850 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x1B59870 Offset: 0x1B59971 VA: 0x1B59870 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x1B59890 Offset: 0x1B59991 VA: 0x1B59890 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x1B598B0 Offset: 0x1B599B1 VA: 0x1B598B0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1B598D0 Offset: 0x1B599D1 VA: 0x1B598D0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1B598F0 Offset: 0x1B599F1 VA: 0x1B598F0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1B59920 Offset: 0x1B59A21 VA: 0x1B59920 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1B59950 Offset: 0x1B59A51 VA: 0x1B59950 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x1B59980 Offset: 0x1B59A81 VA: 0x1B59980 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x1B59A40 Offset: 0x1B59B41 VA: 0x1B59A40 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x1B59A70 Offset: 0x1B59B71 VA: 0x1B59A70 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x1B59AA0 Offset: 0x1B59BA1 VA: 0x1B59AA0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x1B59AD0 Offset: 0x1B59BD1 VA: 0x1B59AD0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B59C40 Offset: 0x1B59D41 VA: 0x1B59C40 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x1B59C70 Offset: 0x1B59D71 VA: 0x1B59C70 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x1B59DE0 Offset: 0x1B59EE1 VA: 0x1B59DE0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1B59F00 Offset: 0x1B5A001 VA: 0x1B59F00 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1B59F30 Offset: 0x1B5A031 VA: 0x1B59F30 Slot: 24
	public override void GenerateKey() { }
}

