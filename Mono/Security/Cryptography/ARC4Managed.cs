internal class ARC4Managed : RC4, ICryptoTransform, IDisposable // TypeDefIndex: 59
{
	// Fields
	private byte[] key; // 0x48
	private byte[] state; // 0x50
	private byte x; // 0x58
	private byte y; // 0x59
	private bool m_disposed; // 0x5A

	// Properties
	public override byte[] Key { get; set; }
	public bool CanTransformMultipleBlocks { get; }
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }

	// Methods

	// RVA: 0x18EEC70 Offset: 0x18EED71 VA: 0x18EEC70
	public void .ctor() { }

	// RVA: 0x18EEDB0 Offset: 0x18EEEB1 VA: 0x18EEDB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18EEE30 Offset: 0x18EEF31 VA: 0x18EEE30 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18EEF20 Offset: 0x18EF021 VA: 0x18EEF20 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x18EEFC0 Offset: 0x18EF0C1 VA: 0x18EEFC0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x18EF1B0 Offset: 0x18EF2B1 VA: 0x18EF1B0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x18EF1E0 Offset: 0x18EF2E1 VA: 0x18EF1E0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x18EF220 Offset: 0x18EF321 VA: 0x18EF220 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x18EF290 Offset: 0x18EF391 VA: 0x18EF290 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x18EF3B0 Offset: 0x18EF4B1 VA: 0x18EF3B0 Slot: 28
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x18EF3C0 Offset: 0x18EF4C1 VA: 0x18EF3C0 Slot: 26
	public int get_InputBlockSize() { }

	// RVA: 0x18EF3D0 Offset: 0x18EF4D1 VA: 0x18EF3D0 Slot: 27
	public int get_OutputBlockSize() { }

	// RVA: 0x18EF0C0 Offset: 0x18EF1C1 VA: 0x18EF0C0
	private void KeySetup(byte[] key) { }

	// RVA: 0x18EF3E0 Offset: 0x18EF4E1 VA: 0x18EF3E0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18EF540 Offset: 0x18EF641 VA: 0x18EF540 Slot: 29
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18EF6C0 Offset: 0x18EF7C1 VA: 0x18EF6C0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18EF8C0 Offset: 0x18EF9C1 VA: 0x18EF8C0 Slot: 30
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

internal class ARC4Managed : RC4, ICryptoTransform, IDisposable // TypeDefIndex: 59
{
	// Fields
	private byte[] key; // 0x48
	private byte[] state; // 0x50
	private byte x; // 0x58
	private byte y; // 0x59
	private bool m_disposed; // 0x5A

	// Properties
	public override byte[] Key { get; set; }
	public bool CanTransformMultipleBlocks { get; }
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }

	// Methods

	// RVA: 0x18EEC70 Offset: 0x18EED71 VA: 0x18EEC70
	public void .ctor() { }

	// RVA: 0x18EEDB0 Offset: 0x18EEEB1 VA: 0x18EEDB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18EEE30 Offset: 0x18EEF31 VA: 0x18EEE30 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18EEF20 Offset: 0x18EF021 VA: 0x18EEF20 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x18EEFC0 Offset: 0x18EF0C1 VA: 0x18EEFC0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x18EF1B0 Offset: 0x18EF2B1 VA: 0x18EF1B0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x18EF1E0 Offset: 0x18EF2E1 VA: 0x18EF1E0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x18EF220 Offset: 0x18EF321 VA: 0x18EF220 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x18EF290 Offset: 0x18EF391 VA: 0x18EF290 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x18EF3B0 Offset: 0x18EF4B1 VA: 0x18EF3B0 Slot: 28
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x18EF3C0 Offset: 0x18EF4C1 VA: 0x18EF3C0 Slot: 26
	public int get_InputBlockSize() { }

	// RVA: 0x18EF3D0 Offset: 0x18EF4D1 VA: 0x18EF3D0 Slot: 27
	public int get_OutputBlockSize() { }

	// RVA: 0x18EF0C0 Offset: 0x18EF1C1 VA: 0x18EF0C0
	private void KeySetup(byte[] key) { }

	// RVA: 0x18EF3E0 Offset: 0x18EF4E1 VA: 0x18EF3E0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18EF540 Offset: 0x18EF641 VA: 0x18EF540 Slot: 29
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18EF6C0 Offset: 0x18EF7C1 VA: 0x18EF6C0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18EF8C0 Offset: 0x18EF9C1 VA: 0x18EF8C0 Slot: 30
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

internal class ARC4Managed : RC4, ICryptoTransform, IDisposable // TypeDefIndex: 59
{
	// Fields
	private byte[] key; // 0x48
	private byte[] state; // 0x50
	private byte x; // 0x58
	private byte y; // 0x59
	private bool m_disposed; // 0x5A

	// Properties
	public override byte[] Key { get; set; }
	public bool CanTransformMultipleBlocks { get; }
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }

	// Methods

	// RVA: 0x18EEC70 Offset: 0x18EED71 VA: 0x18EEC70
	public void .ctor() { }

	// RVA: 0x18EEDB0 Offset: 0x18EEEB1 VA: 0x18EEDB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18EEE30 Offset: 0x18EEF31 VA: 0x18EEE30 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18EEF20 Offset: 0x18EF021 VA: 0x18EEF20 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x18EEFC0 Offset: 0x18EF0C1 VA: 0x18EEFC0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x18EF1B0 Offset: 0x18EF2B1 VA: 0x18EF1B0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x18EF1E0 Offset: 0x18EF2E1 VA: 0x18EF1E0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x18EF220 Offset: 0x18EF321 VA: 0x18EF220 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x18EF290 Offset: 0x18EF391 VA: 0x18EF290 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x18EF3B0 Offset: 0x18EF4B1 VA: 0x18EF3B0 Slot: 28
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x18EF3C0 Offset: 0x18EF4C1 VA: 0x18EF3C0 Slot: 26
	public int get_InputBlockSize() { }

	// RVA: 0x18EF3D0 Offset: 0x18EF4D1 VA: 0x18EF3D0 Slot: 27
	public int get_OutputBlockSize() { }

	// RVA: 0x18EF0C0 Offset: 0x18EF1C1 VA: 0x18EF0C0
	private void KeySetup(byte[] key) { }

	// RVA: 0x18EF3E0 Offset: 0x18EF4E1 VA: 0x18EF3E0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18EF540 Offset: 0x18EF641 VA: 0x18EF540 Slot: 29
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18EF6C0 Offset: 0x18EF7C1 VA: 0x18EF6C0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18EF8C0 Offset: 0x18EF9C1 VA: 0x18EF8C0 Slot: 30
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

internal class ARC4Managed : RC4, ICryptoTransform, IDisposable // TypeDefIndex: 59
{
	// Fields
	private byte[] key; // 0x48
	private byte[] state; // 0x50
	private byte x; // 0x58
	private byte y; // 0x59
	private bool m_disposed; // 0x5A

	// Properties
	public override byte[] Key { get; set; }
	public bool CanTransformMultipleBlocks { get; }
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }

	// Methods

	// RVA: 0x18EEC70 Offset: 0x18EED71 VA: 0x18EEC70
	public void .ctor() { }

	// RVA: 0x18EEDB0 Offset: 0x18EEEB1 VA: 0x18EEDB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18EEE30 Offset: 0x18EEF31 VA: 0x18EEE30 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18EEF20 Offset: 0x18EF021 VA: 0x18EEF20 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x18EEFC0 Offset: 0x18EF0C1 VA: 0x18EEFC0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x18EF1B0 Offset: 0x18EF2B1 VA: 0x18EF1B0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x18EF1E0 Offset: 0x18EF2E1 VA: 0x18EF1E0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x18EF220 Offset: 0x18EF321 VA: 0x18EF220 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x18EF290 Offset: 0x18EF391 VA: 0x18EF290 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x18EF3B0 Offset: 0x18EF4B1 VA: 0x18EF3B0 Slot: 28
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x18EF3C0 Offset: 0x18EF4C1 VA: 0x18EF3C0 Slot: 26
	public int get_InputBlockSize() { }

	// RVA: 0x18EF3D0 Offset: 0x18EF4D1 VA: 0x18EF3D0 Slot: 27
	public int get_OutputBlockSize() { }

	// RVA: 0x18EF0C0 Offset: 0x18EF1C1 VA: 0x18EF0C0
	private void KeySetup(byte[] key) { }

	// RVA: 0x18EF3E0 Offset: 0x18EF4E1 VA: 0x18EF3E0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18EF540 Offset: 0x18EF641 VA: 0x18EF540 Slot: 29
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18EF6C0 Offset: 0x18EF7C1 VA: 0x18EF6C0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18EF8C0 Offset: 0x18EF9C1 VA: 0x18EF8C0 Slot: 30
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

internal class ARC4Managed : RC4, ICryptoTransform, IDisposable // TypeDefIndex: 59
{
	// Fields
	private byte[] key; // 0x48
	private byte[] state; // 0x50
	private byte x; // 0x58
	private byte y; // 0x59
	private bool m_disposed; // 0x5A

	// Properties
	public override byte[] Key { get; set; }
	public bool CanTransformMultipleBlocks { get; }
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }

	// Methods

	// RVA: 0x18EEC70 Offset: 0x18EED71 VA: 0x18EEC70
	public void .ctor() { }

	// RVA: 0x18EEDB0 Offset: 0x18EEEB1 VA: 0x18EEDB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18EEE30 Offset: 0x18EEF31 VA: 0x18EEE30 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18EEF20 Offset: 0x18EF021 VA: 0x18EEF20 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x18EEFC0 Offset: 0x18EF0C1 VA: 0x18EEFC0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x18EF1B0 Offset: 0x18EF2B1 VA: 0x18EF1B0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x18EF1E0 Offset: 0x18EF2E1 VA: 0x18EF1E0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x18EF220 Offset: 0x18EF321 VA: 0x18EF220 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x18EF290 Offset: 0x18EF391 VA: 0x18EF290 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x18EF3B0 Offset: 0x18EF4B1 VA: 0x18EF3B0 Slot: 28
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x18EF3C0 Offset: 0x18EF4C1 VA: 0x18EF3C0 Slot: 26
	public int get_InputBlockSize() { }

	// RVA: 0x18EF3D0 Offset: 0x18EF4D1 VA: 0x18EF3D0 Slot: 27
	public int get_OutputBlockSize() { }

	// RVA: 0x18EF0C0 Offset: 0x18EF1C1 VA: 0x18EF0C0
	private void KeySetup(byte[] key) { }

	// RVA: 0x18EF3E0 Offset: 0x18EF4E1 VA: 0x18EF3E0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18EF540 Offset: 0x18EF641 VA: 0x18EF540 Slot: 29
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18EF6C0 Offset: 0x18EF7C1 VA: 0x18EF6C0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18EF8C0 Offset: 0x18EF9C1 VA: 0x18EF8C0 Slot: 30
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

internal class ARC4Managed : RC4, ICryptoTransform, IDisposable // TypeDefIndex: 59
{
	// Fields
	private byte[] key; // 0x48
	private byte[] state; // 0x50
	private byte x; // 0x58
	private byte y; // 0x59
	private bool m_disposed; // 0x5A

	// Properties
	public override byte[] Key { get; set; }
	public bool CanTransformMultipleBlocks { get; }
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }

	// Methods

	// RVA: 0x18EEC70 Offset: 0x18EED71 VA: 0x18EEC70
	public void .ctor() { }

	// RVA: 0x18EEDB0 Offset: 0x18EEEB1 VA: 0x18EEDB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18EEE30 Offset: 0x18EEF31 VA: 0x18EEE30 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18EEF20 Offset: 0x18EF021 VA: 0x18EEF20 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x18EEFC0 Offset: 0x18EF0C1 VA: 0x18EEFC0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x18EF1B0 Offset: 0x18EF2B1 VA: 0x18EF1B0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x18EF1E0 Offset: 0x18EF2E1 VA: 0x18EF1E0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x18EF220 Offset: 0x18EF321 VA: 0x18EF220 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x18EF290 Offset: 0x18EF391 VA: 0x18EF290 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x18EF3B0 Offset: 0x18EF4B1 VA: 0x18EF3B0 Slot: 28
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x18EF3C0 Offset: 0x18EF4C1 VA: 0x18EF3C0 Slot: 26
	public int get_InputBlockSize() { }

	// RVA: 0x18EF3D0 Offset: 0x18EF4D1 VA: 0x18EF3D0 Slot: 27
	public int get_OutputBlockSize() { }

	// RVA: 0x18EF0C0 Offset: 0x18EF1C1 VA: 0x18EF0C0
	private void KeySetup(byte[] key) { }

	// RVA: 0x18EF3E0 Offset: 0x18EF4E1 VA: 0x18EF3E0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18EF540 Offset: 0x18EF641 VA: 0x18EF540 Slot: 29
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18EF6C0 Offset: 0x18EF7C1 VA: 0x18EF6C0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18EF8C0 Offset: 0x18EF9C1 VA: 0x18EF8C0 Slot: 30
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

