[ComVisibleAttribute] // RVA: 0xB0330 Offset: 0xB0431 VA: 0xB0330
public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 973
{
	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x262DE00 Offset: 0x262DF01 VA: 0x262DE00
	protected void .ctor() { }

	// RVA: 0x2638440 Offset: 0x2638541 VA: 0x2638440 Slot: 4
	public void Dispose() { }

	// RVA: 0x26384C0 Offset: 0x26385C1 VA: 0x26384C0
	public void Clear() { }

	// RVA: 0x2638570 Offset: 0x2638671 VA: 0x2638570 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x26385F0 Offset: 0x26386F1 VA: 0x26385F0 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x2638600 Offset: 0x2638701 VA: 0x2638600 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x2638750 Offset: 0x2638851 VA: 0x2638750 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x2638760 Offset: 0x2638861 VA: 0x2638760 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x2638800 Offset: 0x2638901 VA: 0x2638800 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x2638940 Offset: 0x2638A41 VA: 0x2638940 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x26389E0 Offset: 0x2638AE1 VA: 0x26389E0 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x2638C70 Offset: 0x2638D71 VA: 0x2638C70 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x2638CF0 Offset: 0x2638DF1 VA: 0x2638CF0 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x2638D00 Offset: 0x2638E01 VA: 0x2638D00 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x2638E30 Offset: 0x2638F31 VA: 0x2638E30 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x2638E40 Offset: 0x2638F41 VA: 0x2638E40 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x2638EF0 Offset: 0x2638FF1 VA: 0x2638EF0 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x2638F00 Offset: 0x2639001 VA: 0x2638F00 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x2638BA0 Offset: 0x2638CA1 VA: 0x2638BA0
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x2638FB0 Offset: 0x26390B1 VA: 0x2638FB0
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x2639040 Offset: 0x2639141 VA: 0x2639040 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x26390A0 Offset: 0x26391A1 VA: 0x26390A0 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV() { }
}

[ComVisibleAttribute] // RVA: 0xB0330 Offset: 0xB0431 VA: 0xB0330
public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 973
{
	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x262DE00 Offset: 0x262DF01 VA: 0x262DE00
	protected void .ctor() { }

	// RVA: 0x2638440 Offset: 0x2638541 VA: 0x2638440 Slot: 4
	public void Dispose() { }

	// RVA: 0x26384C0 Offset: 0x26385C1 VA: 0x26384C0
	public void Clear() { }

	// RVA: 0x2638570 Offset: 0x2638671 VA: 0x2638570 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x26385F0 Offset: 0x26386F1 VA: 0x26385F0 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x2638600 Offset: 0x2638701 VA: 0x2638600 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x2638750 Offset: 0x2638851 VA: 0x2638750 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x2638760 Offset: 0x2638861 VA: 0x2638760 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x2638800 Offset: 0x2638901 VA: 0x2638800 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x2638940 Offset: 0x2638A41 VA: 0x2638940 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x26389E0 Offset: 0x2638AE1 VA: 0x26389E0 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x2638C70 Offset: 0x2638D71 VA: 0x2638C70 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x2638CF0 Offset: 0x2638DF1 VA: 0x2638CF0 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x2638D00 Offset: 0x2638E01 VA: 0x2638D00 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x2638E30 Offset: 0x2638F31 VA: 0x2638E30 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x2638E40 Offset: 0x2638F41 VA: 0x2638E40 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x2638EF0 Offset: 0x2638FF1 VA: 0x2638EF0 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x2638F00 Offset: 0x2639001 VA: 0x2638F00 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x2638BA0 Offset: 0x2638CA1 VA: 0x2638BA0
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x2638FB0 Offset: 0x26390B1 VA: 0x2638FB0
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x2639040 Offset: 0x2639141 VA: 0x2639040 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x26390A0 Offset: 0x26391A1 VA: 0x26390A0 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV() { }
}

[ComVisibleAttribute] // RVA: 0xB0330 Offset: 0xB0431 VA: 0xB0330
public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 973
{
	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x262DE00 Offset: 0x262DF01 VA: 0x262DE00
	protected void .ctor() { }

	// RVA: 0x2638440 Offset: 0x2638541 VA: 0x2638440 Slot: 4
	public void Dispose() { }

	// RVA: 0x26384C0 Offset: 0x26385C1 VA: 0x26384C0
	public void Clear() { }

	// RVA: 0x2638570 Offset: 0x2638671 VA: 0x2638570 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x26385F0 Offset: 0x26386F1 VA: 0x26385F0 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x2638600 Offset: 0x2638701 VA: 0x2638600 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x2638750 Offset: 0x2638851 VA: 0x2638750 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x2638760 Offset: 0x2638861 VA: 0x2638760 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x2638800 Offset: 0x2638901 VA: 0x2638800 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x2638940 Offset: 0x2638A41 VA: 0x2638940 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x26389E0 Offset: 0x2638AE1 VA: 0x26389E0 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x2638C70 Offset: 0x2638D71 VA: 0x2638C70 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x2638CF0 Offset: 0x2638DF1 VA: 0x2638CF0 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x2638D00 Offset: 0x2638E01 VA: 0x2638D00 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x2638E30 Offset: 0x2638F31 VA: 0x2638E30 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x2638E40 Offset: 0x2638F41 VA: 0x2638E40 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x2638EF0 Offset: 0x2638FF1 VA: 0x2638EF0 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x2638F00 Offset: 0x2639001 VA: 0x2638F00 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x2638BA0 Offset: 0x2638CA1 VA: 0x2638BA0
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x2638FB0 Offset: 0x26390B1 VA: 0x2638FB0
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x2639040 Offset: 0x2639141 VA: 0x2639040 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x26390A0 Offset: 0x26391A1 VA: 0x26390A0 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV() { }
}

[ComVisibleAttribute] // RVA: 0xB0330 Offset: 0xB0431 VA: 0xB0330
public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 973
{
	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x262DE00 Offset: 0x262DF01 VA: 0x262DE00
	protected void .ctor() { }

	// RVA: 0x2638440 Offset: 0x2638541 VA: 0x2638440 Slot: 4
	public void Dispose() { }

	// RVA: 0x26384C0 Offset: 0x26385C1 VA: 0x26384C0
	public void Clear() { }

	// RVA: 0x2638570 Offset: 0x2638671 VA: 0x2638570 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x26385F0 Offset: 0x26386F1 VA: 0x26385F0 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x2638600 Offset: 0x2638701 VA: 0x2638600 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x2638750 Offset: 0x2638851 VA: 0x2638750 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x2638760 Offset: 0x2638861 VA: 0x2638760 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x2638800 Offset: 0x2638901 VA: 0x2638800 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x2638940 Offset: 0x2638A41 VA: 0x2638940 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x26389E0 Offset: 0x2638AE1 VA: 0x26389E0 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x2638C70 Offset: 0x2638D71 VA: 0x2638C70 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x2638CF0 Offset: 0x2638DF1 VA: 0x2638CF0 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x2638D00 Offset: 0x2638E01 VA: 0x2638D00 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x2638E30 Offset: 0x2638F31 VA: 0x2638E30 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x2638E40 Offset: 0x2638F41 VA: 0x2638E40 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x2638EF0 Offset: 0x2638FF1 VA: 0x2638EF0 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x2638F00 Offset: 0x2639001 VA: 0x2638F00 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x2638BA0 Offset: 0x2638CA1 VA: 0x2638BA0
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x2638FB0 Offset: 0x26390B1 VA: 0x2638FB0
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x2639040 Offset: 0x2639141 VA: 0x2639040 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x26390A0 Offset: 0x26391A1 VA: 0x26390A0 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV() { }
}

[ComVisibleAttribute] // RVA: 0xB0330 Offset: 0xB0431 VA: 0xB0330
public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 973
{
	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x262DE00 Offset: 0x262DF01 VA: 0x262DE00
	protected void .ctor() { }

	// RVA: 0x2638440 Offset: 0x2638541 VA: 0x2638440 Slot: 4
	public void Dispose() { }

	// RVA: 0x26384C0 Offset: 0x26385C1 VA: 0x26384C0
	public void Clear() { }

	// RVA: 0x2638570 Offset: 0x2638671 VA: 0x2638570 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x26385F0 Offset: 0x26386F1 VA: 0x26385F0 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x2638600 Offset: 0x2638701 VA: 0x2638600 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x2638750 Offset: 0x2638851 VA: 0x2638750 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x2638760 Offset: 0x2638861 VA: 0x2638760 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x2638800 Offset: 0x2638901 VA: 0x2638800 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x2638940 Offset: 0x2638A41 VA: 0x2638940 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x26389E0 Offset: 0x2638AE1 VA: 0x26389E0 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x2638C70 Offset: 0x2638D71 VA: 0x2638C70 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x2638CF0 Offset: 0x2638DF1 VA: 0x2638CF0 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x2638D00 Offset: 0x2638E01 VA: 0x2638D00 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x2638E30 Offset: 0x2638F31 VA: 0x2638E30 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x2638E40 Offset: 0x2638F41 VA: 0x2638E40 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x2638EF0 Offset: 0x2638FF1 VA: 0x2638EF0 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x2638F00 Offset: 0x2639001 VA: 0x2638F00 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x2638BA0 Offset: 0x2638CA1 VA: 0x2638BA0
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x2638FB0 Offset: 0x26390B1 VA: 0x2638FB0
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x2639040 Offset: 0x2639141 VA: 0x2639040 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x26390A0 Offset: 0x26391A1 VA: 0x26390A0 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV() { }
}

[ComVisibleAttribute] // RVA: 0xB0330 Offset: 0xB0431 VA: 0xB0330
public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 973
{
	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x262DE00 Offset: 0x262DF01 VA: 0x262DE00
	protected void .ctor() { }

	// RVA: 0x2638440 Offset: 0x2638541 VA: 0x2638440 Slot: 4
	public void Dispose() { }

	// RVA: 0x26384C0 Offset: 0x26385C1 VA: 0x26384C0
	public void Clear() { }

	// RVA: 0x2638570 Offset: 0x2638671 VA: 0x2638570 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x26385F0 Offset: 0x26386F1 VA: 0x26385F0 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x2638600 Offset: 0x2638701 VA: 0x2638600 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x2638750 Offset: 0x2638851 VA: 0x2638750 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x2638760 Offset: 0x2638861 VA: 0x2638760 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x2638800 Offset: 0x2638901 VA: 0x2638800 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x2638940 Offset: 0x2638A41 VA: 0x2638940 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x26389E0 Offset: 0x2638AE1 VA: 0x26389E0 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x2638C70 Offset: 0x2638D71 VA: 0x2638C70 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x2638CF0 Offset: 0x2638DF1 VA: 0x2638CF0 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x2638D00 Offset: 0x2638E01 VA: 0x2638D00 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x2638E30 Offset: 0x2638F31 VA: 0x2638E30 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x2638E40 Offset: 0x2638F41 VA: 0x2638E40 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x2638EF0 Offset: 0x2638FF1 VA: 0x2638EF0 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x2638F00 Offset: 0x2639001 VA: 0x2638F00 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x2638BA0 Offset: 0x2638CA1 VA: 0x2638BA0
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x2638FB0 Offset: 0x26390B1 VA: 0x2638FB0
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x2639040 Offset: 0x2639141 VA: 0x2639040 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x26390A0 Offset: 0x26391A1 VA: 0x26390A0 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV() { }
}

