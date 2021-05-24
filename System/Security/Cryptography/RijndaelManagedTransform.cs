[ComVisibleAttribute] // RVA: 0xB0150 Offset: 0xB0251 VA: 0xB0150
public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable // TypeDefIndex: 952
{
	// Fields
	private CipherMode m_cipherMode; // 0x10
	private PaddingMode m_paddingValue; // 0x14
	private RijndaelManagedTransformMode m_transformMode; // 0x18
	private int m_blockSizeBits; // 0x1C
	private int m_blockSizeBytes; // 0x20
	private int m_inputBlockSize; // 0x24
	private int m_outputBlockSize; // 0x28
	private int[] m_encryptKeyExpansion; // 0x30
	private int[] m_decryptKeyExpansion; // 0x38
	private int m_Nr; // 0x40
	private int m_Nb; // 0x44
	private int m_Nk; // 0x48
	private int[] m_encryptindex; // 0x50
	private int[] m_decryptindex; // 0x58
	private int[] m_IV; // 0x60
	private int[] m_lastBlockBuffer; // 0x68
	private byte[] m_depadBuffer; // 0x70
	private byte[] m_shiftRegister; // 0x78
	private static readonly byte[] s_Sbox; // 0x0
	private static readonly int[] s_Rcon; // 0x8
	private static readonly int[] s_T; // 0x10
	private static readonly int[] s_TF; // 0x18
	private static readonly int[] s_iT; // 0x20
	private static readonly int[] s_iTF; // 0x28

	// Properties
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }
	public bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x262E400 Offset: 0x262E501 VA: 0x262E400
	internal void .ctor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	// RVA: 0x262F040 Offset: 0x262F141 VA: 0x262F040 Slot: 9
	public void Dispose() { }

	// RVA: 0x262F050 Offset: 0x262F151 VA: 0x262F050
	private void Dispose(bool disposing) { }

	// RVA: 0x262F180 Offset: 0x262F281 VA: 0x262F180 Slot: 4
	public int get_InputBlockSize() { }

	// RVA: 0x262F190 Offset: 0x262F291 VA: 0x262F190 Slot: 5
	public int get_OutputBlockSize() { }

	// RVA: 0x262F1A0 Offset: 0x262F2A1 VA: 0x262F1A0 Slot: 6
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x262F1B0 Offset: 0x262F2B1 VA: 0x262F1B0 Slot: 7
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x2630BB0 Offset: 0x2630CB1 VA: 0x2630BB0 Slot: 8
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x2630FA0 Offset: 0x26310A1 VA: 0x2630FA0
	public void Reset() { }

	// RVA: 0x262F480 Offset: 0x262F581 VA: 0x262F480
	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x2630100 Offset: 0x2630201 VA: 0x2630100
	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x26310D0 Offset: 0x26311D1 VA: 0x26310D0
	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	// RVA: 0x2631290 Offset: 0x2631391 VA: 0x2631290
	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	// RVA: 0x262EA60 Offset: 0x262EB61 VA: 0x262EA60
	private void GenerateKeyExpansion(byte[] rgbKey) { }

	// RVA: 0x2631590 Offset: 0x2631691 VA: 0x2631590
	private static int rot1(int val) { }

	// RVA: 0x2631580 Offset: 0x2631681 VA: 0x2631580
	private static int rot2(int val) { }

	// RVA: 0x2631460 Offset: 0x2631561 VA: 0x2631460
	private static int rot3(int val) { }

	// RVA: 0x2631470 Offset: 0x2631571 VA: 0x2631470
	private static int SubWord(int a) { }

	// RVA: 0x2631550 Offset: 0x2631651 VA: 0x2631550
	private static int MulX(int x) { }

	// RVA: 0x26315A0 Offset: 0x26316A1 VA: 0x26315A0
	private static void .cctor() { }
}

