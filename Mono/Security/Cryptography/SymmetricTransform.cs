internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 73
{
	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x18F9150 Offset: 0x18F9251 VA: 0x18F9150
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x18F9450 Offset: 0x18F9551 VA: 0x18F9450 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18F94D0 Offset: 0x18F95D1 VA: 0x18F94D0 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18F9550 Offset: 0x18F9651 VA: 0x18F9550 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18F95E0 Offset: 0x18F96E1 VA: 0x18F95E0 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x18F95F0 Offset: 0x18F96F1 VA: 0x18F95F0 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x18F9600 Offset: 0x18F9701 VA: 0x18F9600 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x18F9610 Offset: 0x18F9711 VA: 0x18F9610 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output) { }

	// RVA: 0x18F97C0 Offset: 0x18F98C1 VA: 0x18F97C0 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x18F9950 Offset: 0x18F9A51 VA: 0x18F9950 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x18F9BD0 Offset: 0x18F9CD1 VA: 0x18F9BD0 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x18F9C40 Offset: 0x18F9D41 VA: 0x18F9C40 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x18F9CB0 Offset: 0x18F9DB1 VA: 0x18F9CB0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18F9E10 Offset: 0x18F9F11 VA: 0x18F9E10 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18FA030 Offset: 0x18FA131 VA: 0x18FA030
	private bool get_KeepLastBlock() { }

	// RVA: 0x18FA060 Offset: 0x18FA161 VA: 0x18FA060
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18FA260 Offset: 0x18FA361 VA: 0x18FA260
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x18FA330 Offset: 0x18FA431 VA: 0x18FA330
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x18FA4A0 Offset: 0x18FA5A1 VA: 0x18FA4A0 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18FA760 Offset: 0x18FA861 VA: 0x18FA760 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18FAA30 Offset: 0x18FAB31 VA: 0x18FAA30 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 73
{
	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x18F9150 Offset: 0x18F9251 VA: 0x18F9150
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x18F9450 Offset: 0x18F9551 VA: 0x18F9450 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18F94D0 Offset: 0x18F95D1 VA: 0x18F94D0 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18F9550 Offset: 0x18F9651 VA: 0x18F9550 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18F95E0 Offset: 0x18F96E1 VA: 0x18F95E0 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x18F95F0 Offset: 0x18F96F1 VA: 0x18F95F0 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x18F9600 Offset: 0x18F9701 VA: 0x18F9600 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x18F9610 Offset: 0x18F9711 VA: 0x18F9610 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output) { }

	// RVA: 0x18F97C0 Offset: 0x18F98C1 VA: 0x18F97C0 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x18F9950 Offset: 0x18F9A51 VA: 0x18F9950 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x18F9BD0 Offset: 0x18F9CD1 VA: 0x18F9BD0 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x18F9C40 Offset: 0x18F9D41 VA: 0x18F9C40 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x18F9CB0 Offset: 0x18F9DB1 VA: 0x18F9CB0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18F9E10 Offset: 0x18F9F11 VA: 0x18F9E10 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18FA030 Offset: 0x18FA131 VA: 0x18FA030
	private bool get_KeepLastBlock() { }

	// RVA: 0x18FA060 Offset: 0x18FA161 VA: 0x18FA060
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18FA260 Offset: 0x18FA361 VA: 0x18FA260
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x18FA330 Offset: 0x18FA431 VA: 0x18FA330
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x18FA4A0 Offset: 0x18FA5A1 VA: 0x18FA4A0 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18FA760 Offset: 0x18FA861 VA: 0x18FA760 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18FAA30 Offset: 0x18FAB31 VA: 0x18FAA30 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 73
{
	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x18F9150 Offset: 0x18F9251 VA: 0x18F9150
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x18F9450 Offset: 0x18F9551 VA: 0x18F9450 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18F94D0 Offset: 0x18F95D1 VA: 0x18F94D0 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18F9550 Offset: 0x18F9651 VA: 0x18F9550 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18F95E0 Offset: 0x18F96E1 VA: 0x18F95E0 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x18F95F0 Offset: 0x18F96F1 VA: 0x18F95F0 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x18F9600 Offset: 0x18F9701 VA: 0x18F9600 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x18F9610 Offset: 0x18F9711 VA: 0x18F9610 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output) { }

	// RVA: 0x18F97C0 Offset: 0x18F98C1 VA: 0x18F97C0 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x18F9950 Offset: 0x18F9A51 VA: 0x18F9950 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x18F9BD0 Offset: 0x18F9CD1 VA: 0x18F9BD0 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x18F9C40 Offset: 0x18F9D41 VA: 0x18F9C40 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x18F9CB0 Offset: 0x18F9DB1 VA: 0x18F9CB0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18F9E10 Offset: 0x18F9F11 VA: 0x18F9E10 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18FA030 Offset: 0x18FA131 VA: 0x18FA030
	private bool get_KeepLastBlock() { }

	// RVA: 0x18FA060 Offset: 0x18FA161 VA: 0x18FA060
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18FA260 Offset: 0x18FA361 VA: 0x18FA260
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x18FA330 Offset: 0x18FA431 VA: 0x18FA330
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x18FA4A0 Offset: 0x18FA5A1 VA: 0x18FA4A0 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18FA760 Offset: 0x18FA861 VA: 0x18FA760 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18FAA30 Offset: 0x18FAB31 VA: 0x18FAA30 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 73
{
	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x18F9150 Offset: 0x18F9251 VA: 0x18F9150
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x18F9450 Offset: 0x18F9551 VA: 0x18F9450 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18F94D0 Offset: 0x18F95D1 VA: 0x18F94D0 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18F9550 Offset: 0x18F9651 VA: 0x18F9550 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18F95E0 Offset: 0x18F96E1 VA: 0x18F95E0 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x18F95F0 Offset: 0x18F96F1 VA: 0x18F95F0 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x18F9600 Offset: 0x18F9701 VA: 0x18F9600 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x18F9610 Offset: 0x18F9711 VA: 0x18F9610 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output) { }

	// RVA: 0x18F97C0 Offset: 0x18F98C1 VA: 0x18F97C0 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x18F9950 Offset: 0x18F9A51 VA: 0x18F9950 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x18F9BD0 Offset: 0x18F9CD1 VA: 0x18F9BD0 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x18F9C40 Offset: 0x18F9D41 VA: 0x18F9C40 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x18F9CB0 Offset: 0x18F9DB1 VA: 0x18F9CB0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18F9E10 Offset: 0x18F9F11 VA: 0x18F9E10 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18FA030 Offset: 0x18FA131 VA: 0x18FA030
	private bool get_KeepLastBlock() { }

	// RVA: 0x18FA060 Offset: 0x18FA161 VA: 0x18FA060
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18FA260 Offset: 0x18FA361 VA: 0x18FA260
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x18FA330 Offset: 0x18FA431 VA: 0x18FA330
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x18FA4A0 Offset: 0x18FA5A1 VA: 0x18FA4A0 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18FA760 Offset: 0x18FA861 VA: 0x18FA760 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18FAA30 Offset: 0x18FAB31 VA: 0x18FAA30 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 73
{
	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x18F9150 Offset: 0x18F9251 VA: 0x18F9150
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x18F9450 Offset: 0x18F9551 VA: 0x18F9450 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18F94D0 Offset: 0x18F95D1 VA: 0x18F94D0 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18F9550 Offset: 0x18F9651 VA: 0x18F9550 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18F95E0 Offset: 0x18F96E1 VA: 0x18F95E0 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x18F95F0 Offset: 0x18F96F1 VA: 0x18F95F0 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x18F9600 Offset: 0x18F9701 VA: 0x18F9600 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x18F9610 Offset: 0x18F9711 VA: 0x18F9610 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output) { }

	// RVA: 0x18F97C0 Offset: 0x18F98C1 VA: 0x18F97C0 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x18F9950 Offset: 0x18F9A51 VA: 0x18F9950 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x18F9BD0 Offset: 0x18F9CD1 VA: 0x18F9BD0 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x18F9C40 Offset: 0x18F9D41 VA: 0x18F9C40 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x18F9CB0 Offset: 0x18F9DB1 VA: 0x18F9CB0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18F9E10 Offset: 0x18F9F11 VA: 0x18F9E10 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18FA030 Offset: 0x18FA131 VA: 0x18FA030
	private bool get_KeepLastBlock() { }

	// RVA: 0x18FA060 Offset: 0x18FA161 VA: 0x18FA060
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18FA260 Offset: 0x18FA361 VA: 0x18FA260
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x18FA330 Offset: 0x18FA431 VA: 0x18FA330
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x18FA4A0 Offset: 0x18FA5A1 VA: 0x18FA4A0 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18FA760 Offset: 0x18FA861 VA: 0x18FA760 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18FAA30 Offset: 0x18FAB31 VA: 0x18FAA30 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 73
{
	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x18F9150 Offset: 0x18F9251 VA: 0x18F9150
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x18F9450 Offset: 0x18F9551 VA: 0x18F9450 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18F94D0 Offset: 0x18F95D1 VA: 0x18F94D0 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18F9550 Offset: 0x18F9651 VA: 0x18F9550 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18F95E0 Offset: 0x18F96E1 VA: 0x18F95E0 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x18F95F0 Offset: 0x18F96F1 VA: 0x18F95F0 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x18F9600 Offset: 0x18F9701 VA: 0x18F9600 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x18F9610 Offset: 0x18F9711 VA: 0x18F9610 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output) { }

	// RVA: 0x18F97C0 Offset: 0x18F98C1 VA: 0x18F97C0 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x18F9950 Offset: 0x18F9A51 VA: 0x18F9950 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x18F9BD0 Offset: 0x18F9CD1 VA: 0x18F9BD0 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x18F9C40 Offset: 0x18F9D41 VA: 0x18F9C40 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x18F9CB0 Offset: 0x18F9DB1 VA: 0x18F9CB0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18F9E10 Offset: 0x18F9F11 VA: 0x18F9E10 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18FA030 Offset: 0x18FA131 VA: 0x18FA030
	private bool get_KeepLastBlock() { }

	// RVA: 0x18FA060 Offset: 0x18FA161 VA: 0x18FA060
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x18FA260 Offset: 0x18FA361 VA: 0x18FA260
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x18FA330 Offset: 0x18FA431 VA: 0x18FA330
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x18FA4A0 Offset: 0x18FA5A1 VA: 0x18FA4A0 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18FA760 Offset: 0x18FA861 VA: 0x18FA760 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x18FAA30 Offset: 0x18FAB31 VA: 0x18FAA30 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

