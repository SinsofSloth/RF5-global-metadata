[ComVisibleAttribute] // RVA: 0xAFF30 Offset: 0xB0031 VA: 0xAFF30
public abstract class HashAlgorithm : IDisposable, ICryptoTransform // TypeDefIndex: 933
{
	// Fields
	protected int HashSizeValue; // 0x10
	protected internal byte[] HashValue; // 0x18
	protected int State; // 0x20
	private bool m_bDisposed; // 0x24

	// Properties
	public virtual int HashSize { get; }
	public virtual byte[] Hash { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	public virtual bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x194ED00 Offset: 0x194EE01 VA: 0x194ED00
	protected void .ctor() { }

	// RVA: 0x194ED10 Offset: 0x194EE11 VA: 0x194ED10 Slot: 10
	public virtual int get_HashSize() { }

	// RVA: 0x194ED20 Offset: 0x194EE21 VA: 0x194ED20 Slot: 11
	public virtual byte[] get_Hash() { }

	// RVA: 0x194DB30 Offset: 0x194DC31 VA: 0x194DB30
	public byte[] ComputeHash(byte[] buffer) { }

	// RVA: 0x194EE30 Offset: 0x194EF31 VA: 0x194EE30
	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	// RVA: 0x194F060 Offset: 0x194F161 VA: 0x194F060 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x194F070 Offset: 0x194F171 VA: 0x194F070 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x194F080 Offset: 0x194F181 VA: 0x194F080 Slot: 14
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x194DF30 Offset: 0x194E031 VA: 0x194DF30 Slot: 8
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x194E270 Offset: 0x194E371 VA: 0x194E270 Slot: 9
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x194F090 Offset: 0x194F191 VA: 0x194F090 Slot: 4
	public void Dispose() { }

	// RVA: 0x194F110 Offset: 0x194F211 VA: 0x194F110
	public void Clear() { }

	// RVA: 0x194F1C0 Offset: 0x194F2C1 VA: 0x194F1C0 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Initialize() { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract byte[] HashFinal() { }
}

