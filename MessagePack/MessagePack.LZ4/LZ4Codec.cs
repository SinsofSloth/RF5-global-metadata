internal static class LZ4Codec // TypeDefIndex: 5276
{
	// Fields
	private const int MEMORY_USAGE = 12;
	private const int NOTCOMPRESSIBLE_DETECTIONLEVEL = 6;
	private const int MINMATCH = 4;
	private const int SKIPSTRENGTH = 6;
	private const int COPYLENGTH = 8;
	private const int LASTLITERALS = 5;
	private const int MFLIMIT = 12;
	private const int MINLENGTH = 13;
	private const int MAXD_LOG = 16;
	private const int MAXD = 65536;
	private const int MAXD_MASK = 65535;
	private const int MAX_DISTANCE = 65535;
	private const int ML_BITS = 4;
	private const int ML_MASK = 15;
	private const int RUN_BITS = 4;
	private const int RUN_MASK = 15;
	private const int STEPSIZE_64 = 8;
	private const int STEPSIZE_32 = 4;
	private const int LZ4_64KLIMIT = 65547;
	private const int HASH_LOG = 10;
	private const int HASH_TABLESIZE = 1024;
	private const int HASH_ADJUST = 22;
	private const int HASH64K_LOG = 11;
	private const int HASH64K_TABLESIZE = 2048;
	private const int HASH64K_ADJUST = 21;
	private const int HASHHC_LOG = 15;
	private const int HASHHC_TABLESIZE = 32768;
	private const int HASHHC_ADJUST = 17;
	private const int MAX_NB_ATTEMPTS = 256;
	private const int OPTIMAL_ML = 18;
	private const int BLOCK_COPY_LIMIT = 16;
	private static readonly int[] DECODER_TABLE_32; // 0x0
	private static readonly int[] DECODER_TABLE_64; // 0x8
	private static readonly int[] DEBRUIJN_TABLE_32; // 0x10
	private static readonly int[] DEBRUIJN_TABLE_64; // 0x18

	// Methods

	// RVA: 0x16848C0 Offset: 0x16849C1 VA: 0x16848C0
	public static int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x1684CA0 Offset: 0x1684DA1 VA: 0x1684CA0
	public static int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	[ConditionalAttribute] // RVA: 0x13A600 Offset: 0x13A701 VA: 0x13A600
	// RVA: 0x1684FE0 Offset: 0x16850E1 VA: 0x1684FE0
	private static void Assert(bool condition, string errorMessage) { }

	// RVA: 0x1685070 Offset: 0x1685171 VA: 0x1685070
	internal static void Poke2(byte[] buffer, int offset, ushort value) { }

	// RVA: 0x16850D0 Offset: 0x16851D1 VA: 0x16850D0
	internal static ushort Peek2(byte[] buffer, int offset) { }

	// RVA: 0x1685120 Offset: 0x1685221 VA: 0x1685120
	internal static uint Peek4(byte[] buffer, int offset) { }

	// RVA: 0x16851A0 Offset: 0x16852A1 VA: 0x16851A0
	private static uint Xor4(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x1685280 Offset: 0x1685381 VA: 0x1685280
	private static ulong Xor8(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x1685420 Offset: 0x1685521 VA: 0x1685420
	private static bool Equal2(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x16854B0 Offset: 0x16855B1 VA: 0x16854B0
	private static bool Equal4(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x16855B0 Offset: 0x16856B1 VA: 0x16855B0
	private static void Copy4(byte[] buf, int src, int dst) { }

	// RVA: 0x1685670 Offset: 0x1685771 VA: 0x1685670
	private static void Copy8(byte[] buf, int src, int dst) { }

	// RVA: 0x16857D0 Offset: 0x16858D1 VA: 0x16857D0
	private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len) { }

	// RVA: 0x1685B40 Offset: 0x1685C41 VA: 0x1685B40
	private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end) { }

	// RVA: 0x1685D10 Offset: 0x1685E11 VA: 0x1685D10
	private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end) { }

	// RVA: 0x16849C0 Offset: 0x1684AC1 VA: 0x16849C0
	public static int Encode32Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x1684B30 Offset: 0x1684C31 VA: 0x1684B30
	public static int Encode64Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x1684DA0 Offset: 0x1684EA1 VA: 0x1684DA0
	public static int Decode32Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x1684EC0 Offset: 0x1684FC1 VA: 0x1684EC0
	public static int Decode64Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x1686B30 Offset: 0x1686C31 VA: 0x1686B30
	private static int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x1686160 Offset: 0x1686261 VA: 0x1686160
	private static int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x1688720 Offset: 0x1688821 VA: 0x1688720
	private static int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	// RVA: 0x1687DA0 Offset: 0x1687EA1 VA: 0x1687DA0
	private static int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x1687460 Offset: 0x1687561 VA: 0x1687460
	private static int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x1688C70 Offset: 0x1688D71 VA: 0x1688C70
	private static int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	// RVA: 0x1689170 Offset: 0x1689271 VA: 0x1689170
	public static int Encode(ReadOnlySpan<byte> input, Span<byte> output) { }

	// RVA: 0x168B090 Offset: 0x168B191 VA: 0x168B090
	public static int Decode(ReadOnlySpan<byte> input, Span<byte> output) { }

	// RVA: 0x168A230 Offset: 0x168A331 VA: 0x168A230
	private static int LZ4_compressCtx_32(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x16893B0 Offset: 0x16894B1 VA: 0x16893B0
	private static int LZ4_compress64kCtx_32(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x168B200 Offset: 0x168B301 VA: 0x168B200
	private static int LZ4_uncompress_32(byte* src, byte* dst, int dst_len) { }

	// RVA: 0x168B8C0 Offset: 0x168B9C1 VA: 0x168B8C0
	private static void BlockCopy32(byte* src, byte* dst, int len) { }

	// RVA: 0x168A940 Offset: 0x168AA41 VA: 0x168A940
	private static int LZ4_compressCtx_64(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x1689A60 Offset: 0x1689B61 VA: 0x1689A60
	private static int LZ4_compress64kCtx_64(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x168B550 Offset: 0x168B651 VA: 0x168B550
	private static int LZ4_uncompress_64(byte* src, byte* dst, int dst_len) { }

	// RVA: 0x168B960 Offset: 0x168BA61 VA: 0x168B960
	private static void BlockCopy64(byte* src, byte* dst, int len) { }

	// RVA: 0x168BA10 Offset: 0x168BB11 VA: 0x168BA10
	public static int MaximumOutputLength(int inputLength) { }

	// RVA: 0x1685F10 Offset: 0x1686011 VA: 0x1685F10
	internal static void CheckArguments(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x168BA40 Offset: 0x168BB41 VA: 0x168BA40
	private static void .cctor() { }
}

