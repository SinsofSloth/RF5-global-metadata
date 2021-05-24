public class MP4FileProcessing // TypeDefIndex: 9614
{
	// Fields
	private const int ChunkHeaderSize = 8;
	private const int CopyBufferSize = 65536;
	private static uint Atom_moov; // 0x0
	private static uint Atom_mdat; // 0x4
	private static uint Atom_cmov; // 0x8
	private static uint Atom_trak; // 0xC
	private static uint Atom_mdia; // 0x10
	private static uint Atom_minf; // 0x14
	private static uint Atom_stbl; // 0x18
	private static uint Atom_stco; // 0x1C
	private static uint Atom_co64; // 0x20
	private BinaryReader _reader; // 0x10
	private Stream _writeFile; // 0x18

	// Methods

	// RVA: 0x23248C0 Offset: 0x23249C1 VA: 0x23248C0
	public static bool ApplyFastStart(string filePath, bool keepBackup) { }

	// RVA: 0x2324CE0 Offset: 0x2324DE1 VA: 0x2324CE0
	public static bool ApplyFastStart(string srcPath, string dstPath) { }

	// RVA: 0x2324FF0 Offset: 0x23250F1 VA: 0x2324FF0
	public bool Open(Stream srcStream, Stream dstStream) { }

	// RVA: 0x23253C0 Offset: 0x23254C1 VA: 0x23253C0
	public void Close() { }

	// RVA: 0x2325610 Offset: 0x2325711 VA: 0x2325610
	private static MP4FileProcessing.Chunk GetFirstChunkOfType(uint id, List<MP4FileProcessing.Chunk> chunks) { }

	// RVA: 0x2325410 Offset: 0x2325511 VA: 0x2325410
	private List<MP4FileProcessing.Chunk> ReadChildChunks(MP4FileProcessing.Chunk parentChunk) { }

	// RVA: 0x2325E50 Offset: 0x2325F51 VA: 0x2325E50
	private MP4FileProcessing.Chunk ReadChunkHeader() { }

	// RVA: 0x2325730 Offset: 0x2325831 VA: 0x2325730
	private bool ChunkContainsChildChunkWithId(MP4FileProcessing.Chunk chunk, uint id) { }

	// RVA: 0x2325DF0 Offset: 0x2325EF1 VA: 0x2325DF0
	private void WriteChunk(MP4FileProcessing.Chunk chunk) { }

	// RVA: 0x2326230 Offset: 0x2326331 VA: 0x2326230
	private void WriteChunkHeader(MP4FileProcessing.Chunk chunk) { }

	// RVA: 0x2326130 Offset: 0x2326231 VA: 0x2326130
	private void CopyBytes(long numBytes) { }

	// RVA: 0x2325840 Offset: 0x2325941 VA: 0x2325840
	private void WriteChunk_moov(MP4FileProcessing.Chunk parentChunk, ulong byteOffset) { }

	// RVA: 0x2325FF0 Offset: 0x23260F1 VA: 0x2325FF0
	private uint ReadUInt32() { }

	// RVA: 0x2326090 Offset: 0x2326191 VA: 0x2326090
	private ulong ReadUInt64() { }

	// RVA: 0x2326290 Offset: 0x2326391 VA: 0x2326290
	private void WriteUInt32(uint value, bool isBigEndian = True) { }

	// RVA: 0x2326350 Offset: 0x2326451 VA: 0x2326350
	private void WriteUInt64(ulong value) { }

	// RVA: 0x2326400 Offset: 0x2326501 VA: 0x2326400
	private static string ChunkType(uint id) { }

	// RVA: 0x23265E0 Offset: 0x23266E1 VA: 0x23265E0
	private static uint ChunkId(string id) { }

	// RVA: 0x2324FE0 Offset: 0x23250E1 VA: 0x2324FE0
	public void .ctor() { }

	// RVA: 0x2326670 Offset: 0x2326771 VA: 0x2326670
	private static void .cctor() { }
}

public class MP4FileProcessing // TypeDefIndex: 9614
{
	// Fields
	private const int ChunkHeaderSize = 8;
	private const int CopyBufferSize = 65536;
	private static uint Atom_moov; // 0x0
	private static uint Atom_mdat; // 0x4
	private static uint Atom_cmov; // 0x8
	private static uint Atom_trak; // 0xC
	private static uint Atom_mdia; // 0x10
	private static uint Atom_minf; // 0x14
	private static uint Atom_stbl; // 0x18
	private static uint Atom_stco; // 0x1C
	private static uint Atom_co64; // 0x20
	private BinaryReader _reader; // 0x10
	private Stream _writeFile; // 0x18

	// Methods

	// RVA: 0x23248C0 Offset: 0x23249C1 VA: 0x23248C0
	public static bool ApplyFastStart(string filePath, bool keepBackup) { }

	// RVA: 0x2324CE0 Offset: 0x2324DE1 VA: 0x2324CE0
	public static bool ApplyFastStart(string srcPath, string dstPath) { }

	// RVA: 0x2324FF0 Offset: 0x23250F1 VA: 0x2324FF0
	public bool Open(Stream srcStream, Stream dstStream) { }

	// RVA: 0x23253C0 Offset: 0x23254C1 VA: 0x23253C0
	public void Close() { }

	// RVA: 0x2325610 Offset: 0x2325711 VA: 0x2325610
	private static MP4FileProcessing.Chunk GetFirstChunkOfType(uint id, List<MP4FileProcessing.Chunk> chunks) { }

	// RVA: 0x2325410 Offset: 0x2325511 VA: 0x2325410
	private List<MP4FileProcessing.Chunk> ReadChildChunks(MP4FileProcessing.Chunk parentChunk) { }

	// RVA: 0x2325E50 Offset: 0x2325F51 VA: 0x2325E50
	private MP4FileProcessing.Chunk ReadChunkHeader() { }

	// RVA: 0x2325730 Offset: 0x2325831 VA: 0x2325730
	private bool ChunkContainsChildChunkWithId(MP4FileProcessing.Chunk chunk, uint id) { }

	// RVA: 0x2325DF0 Offset: 0x2325EF1 VA: 0x2325DF0
	private void WriteChunk(MP4FileProcessing.Chunk chunk) { }

	// RVA: 0x2326230 Offset: 0x2326331 VA: 0x2326230
	private void WriteChunkHeader(MP4FileProcessing.Chunk chunk) { }

	// RVA: 0x2326130 Offset: 0x2326231 VA: 0x2326130
	private void CopyBytes(long numBytes) { }

	// RVA: 0x2325840 Offset: 0x2325941 VA: 0x2325840
	private void WriteChunk_moov(MP4FileProcessing.Chunk parentChunk, ulong byteOffset) { }

	// RVA: 0x2325FF0 Offset: 0x23260F1 VA: 0x2325FF0
	private uint ReadUInt32() { }

	// RVA: 0x2326090 Offset: 0x2326191 VA: 0x2326090
	private ulong ReadUInt64() { }

	// RVA: 0x2326290 Offset: 0x2326391 VA: 0x2326290
	private void WriteUInt32(uint value, bool isBigEndian = True) { }

	// RVA: 0x2326350 Offset: 0x2326451 VA: 0x2326350
	private void WriteUInt64(ulong value) { }

	// RVA: 0x2326400 Offset: 0x2326501 VA: 0x2326400
	private static string ChunkType(uint id) { }

	// RVA: 0x23265E0 Offset: 0x23266E1 VA: 0x23265E0
	private static uint ChunkId(string id) { }

	// RVA: 0x2324FE0 Offset: 0x23250E1 VA: 0x2324FE0
	public void .ctor() { }

	// RVA: 0x2326670 Offset: 0x2326771 VA: 0x2326670
	private static void .cctor() { }
}

public class MP4FileProcessing // TypeDefIndex: 9614
{
	// Fields
	private const int ChunkHeaderSize = 8;
	private const int CopyBufferSize = 65536;
	private static uint Atom_moov; // 0x0
	private static uint Atom_mdat; // 0x4
	private static uint Atom_cmov; // 0x8
	private static uint Atom_trak; // 0xC
	private static uint Atom_mdia; // 0x10
	private static uint Atom_minf; // 0x14
	private static uint Atom_stbl; // 0x18
	private static uint Atom_stco; // 0x1C
	private static uint Atom_co64; // 0x20
	private BinaryReader _reader; // 0x10
	private Stream _writeFile; // 0x18

	// Methods

	// RVA: 0x23248C0 Offset: 0x23249C1 VA: 0x23248C0
	public static bool ApplyFastStart(string filePath, bool keepBackup) { }

	// RVA: 0x2324CE0 Offset: 0x2324DE1 VA: 0x2324CE0
	public static bool ApplyFastStart(string srcPath, string dstPath) { }

	// RVA: 0x2324FF0 Offset: 0x23250F1 VA: 0x2324FF0
	public bool Open(Stream srcStream, Stream dstStream) { }

	// RVA: 0x23253C0 Offset: 0x23254C1 VA: 0x23253C0
	public void Close() { }

	// RVA: 0x2325610 Offset: 0x2325711 VA: 0x2325610
	private static MP4FileProcessing.Chunk GetFirstChunkOfType(uint id, List<MP4FileProcessing.Chunk> chunks) { }

	// RVA: 0x2325410 Offset: 0x2325511 VA: 0x2325410
	private List<MP4FileProcessing.Chunk> ReadChildChunks(MP4FileProcessing.Chunk parentChunk) { }

	// RVA: 0x2325E50 Offset: 0x2325F51 VA: 0x2325E50
	private MP4FileProcessing.Chunk ReadChunkHeader() { }

	// RVA: 0x2325730 Offset: 0x2325831 VA: 0x2325730
	private bool ChunkContainsChildChunkWithId(MP4FileProcessing.Chunk chunk, uint id) { }

	// RVA: 0x2325DF0 Offset: 0x2325EF1 VA: 0x2325DF0
	private void WriteChunk(MP4FileProcessing.Chunk chunk) { }

	// RVA: 0x2326230 Offset: 0x2326331 VA: 0x2326230
	private void WriteChunkHeader(MP4FileProcessing.Chunk chunk) { }

	// RVA: 0x2326130 Offset: 0x2326231 VA: 0x2326130
	private void CopyBytes(long numBytes) { }

	// RVA: 0x2325840 Offset: 0x2325941 VA: 0x2325840
	private void WriteChunk_moov(MP4FileProcessing.Chunk parentChunk, ulong byteOffset) { }

	// RVA: 0x2325FF0 Offset: 0x23260F1 VA: 0x2325FF0
	private uint ReadUInt32() { }

	// RVA: 0x2326090 Offset: 0x2326191 VA: 0x2326090
	private ulong ReadUInt64() { }

	// RVA: 0x2326290 Offset: 0x2326391 VA: 0x2326290
	private void WriteUInt32(uint value, bool isBigEndian = True) { }

	// RVA: 0x2326350 Offset: 0x2326451 VA: 0x2326350
	private void WriteUInt64(ulong value) { }

	// RVA: 0x2326400 Offset: 0x2326501 VA: 0x2326400
	private static string ChunkType(uint id) { }

	// RVA: 0x23265E0 Offset: 0x23266E1 VA: 0x23265E0
	private static uint ChunkId(string id) { }

	// RVA: 0x2324FE0 Offset: 0x23250E1 VA: 0x2324FE0
	public void .ctor() { }

	// RVA: 0x2326670 Offset: 0x2326771 VA: 0x2326670
	private static void .cctor() { }
}

public class MP4FileProcessing // TypeDefIndex: 9614
{
	// Fields
	private const int ChunkHeaderSize = 8;
	private const int CopyBufferSize = 65536;
	private static uint Atom_moov; // 0x0
	private static uint Atom_mdat; // 0x4
	private static uint Atom_cmov; // 0x8
	private static uint Atom_trak; // 0xC
	private static uint Atom_mdia; // 0x10
	private static uint Atom_minf; // 0x14
	private static uint Atom_stbl; // 0x18
	private static uint Atom_stco; // 0x1C
	private static uint Atom_co64; // 0x20
	private BinaryReader _reader; // 0x10
	private Stream _writeFile; // 0x18

	// Methods

	// RVA: 0x23248C0 Offset: 0x23249C1 VA: 0x23248C0
	public static bool ApplyFastStart(string filePath, bool keepBackup) { }

	// RVA: 0x2324CE0 Offset: 0x2324DE1 VA: 0x2324CE0
	public static bool ApplyFastStart(string srcPath, string dstPath) { }

	// RVA: 0x2324FF0 Offset: 0x23250F1 VA: 0x2324FF0
	public bool Open(Stream srcStream, Stream dstStream) { }

	// RVA: 0x23253C0 Offset: 0x23254C1 VA: 0x23253C0
	public void Close() { }

	// RVA: 0x2325610 Offset: 0x2325711 VA: 0x2325610
	private static MP4FileProcessing.Chunk GetFirstChunkOfType(uint id, List<MP4FileProcessing.Chunk> chunks) { }

	// RVA: 0x2325410 Offset: 0x2325511 VA: 0x2325410
	private List<MP4FileProcessing.Chunk> ReadChildChunks(MP4FileProcessing.Chunk parentChunk) { }

	// RVA: 0x2325E50 Offset: 0x2325F51 VA: 0x2325E50
	private MP4FileProcessing.Chunk ReadChunkHeader() { }

	// RVA: 0x2325730 Offset: 0x2325831 VA: 0x2325730
	private bool ChunkContainsChildChunkWithId(MP4FileProcessing.Chunk chunk, uint id) { }

	// RVA: 0x2325DF0 Offset: 0x2325EF1 VA: 0x2325DF0
	private void WriteChunk(MP4FileProcessing.Chunk chunk) { }

	// RVA: 0x2326230 Offset: 0x2326331 VA: 0x2326230
	private void WriteChunkHeader(MP4FileProcessing.Chunk chunk) { }

	// RVA: 0x2326130 Offset: 0x2326231 VA: 0x2326130
	private void CopyBytes(long numBytes) { }

	// RVA: 0x2325840 Offset: 0x2325941 VA: 0x2325840
	private void WriteChunk_moov(MP4FileProcessing.Chunk parentChunk, ulong byteOffset) { }

	// RVA: 0x2325FF0 Offset: 0x23260F1 VA: 0x2325FF0
	private uint ReadUInt32() { }

	// RVA: 0x2326090 Offset: 0x2326191 VA: 0x2326090
	private ulong ReadUInt64() { }

	// RVA: 0x2326290 Offset: 0x2326391 VA: 0x2326290
	private void WriteUInt32(uint value, bool isBigEndian = True) { }

	// RVA: 0x2326350 Offset: 0x2326451 VA: 0x2326350
	private void WriteUInt64(ulong value) { }

	// RVA: 0x2326400 Offset: 0x2326501 VA: 0x2326400
	private static string ChunkType(uint id) { }

	// RVA: 0x23265E0 Offset: 0x23266E1 VA: 0x23265E0
	private static uint ChunkId(string id) { }

	// RVA: 0x2324FE0 Offset: 0x23250E1 VA: 0x2324FE0
	public void .ctor() { }

	// RVA: 0x2326670 Offset: 0x2326771 VA: 0x2326670
	private static void .cctor() { }
}

public class MP4FileProcessing // TypeDefIndex: 9614
{
	// Fields
	private const int ChunkHeaderSize = 8;
	private const int CopyBufferSize = 65536;
	private static uint Atom_moov; // 0x0
	private static uint Atom_mdat; // 0x4
	private static uint Atom_cmov; // 0x8
	private static uint Atom_trak; // 0xC
	private static uint Atom_mdia; // 0x10
	private static uint Atom_minf; // 0x14
	private static uint Atom_stbl; // 0x18
	private static uint Atom_stco; // 0x1C
	private static uint Atom_co64; // 0x20
	private BinaryReader _reader; // 0x10
	private Stream _writeFile; // 0x18

	// Methods

	// RVA: 0x23248C0 Offset: 0x23249C1 VA: 0x23248C0
	public static bool ApplyFastStart(string filePath, bool keepBackup) { }

	// RVA: 0x2324CE0 Offset: 0x2324DE1 VA: 0x2324CE0
	public static bool ApplyFastStart(string srcPath, string dstPath) { }

	// RVA: 0x2324FF0 Offset: 0x23250F1 VA: 0x2324FF0
	public bool Open(Stream srcStream, Stream dstStream) { }

	// RVA: 0x23253C0 Offset: 0x23254C1 VA: 0x23253C0
	public void Close() { }

	// RVA: 0x2325610 Offset: 0x2325711 VA: 0x2325610
	private static MP4FileProcessing.Chunk GetFirstChunkOfType(uint id, List<MP4FileProcessing.Chunk> chunks) { }

	// RVA: 0x2325410 Offset: 0x2325511 VA: 0x2325410
	private List<MP4FileProcessing.Chunk> ReadChildChunks(MP4FileProcessing.Chunk parentChunk) { }

	// RVA: 0x2325E50 Offset: 0x2325F51 VA: 0x2325E50
	private MP4FileProcessing.Chunk ReadChunkHeader() { }

	// RVA: 0x2325730 Offset: 0x2325831 VA: 0x2325730
	private bool ChunkContainsChildChunkWithId(MP4FileProcessing.Chunk chunk, uint id) { }

	// RVA: 0x2325DF0 Offset: 0x2325EF1 VA: 0x2325DF0
	private void WriteChunk(MP4FileProcessing.Chunk chunk) { }

	// RVA: 0x2326230 Offset: 0x2326331 VA: 0x2326230
	private void WriteChunkHeader(MP4FileProcessing.Chunk chunk) { }

	// RVA: 0x2326130 Offset: 0x2326231 VA: 0x2326130
	private void CopyBytes(long numBytes) { }

	// RVA: 0x2325840 Offset: 0x2325941 VA: 0x2325840
	private void WriteChunk_moov(MP4FileProcessing.Chunk parentChunk, ulong byteOffset) { }

	// RVA: 0x2325FF0 Offset: 0x23260F1 VA: 0x2325FF0
	private uint ReadUInt32() { }

	// RVA: 0x2326090 Offset: 0x2326191 VA: 0x2326090
	private ulong ReadUInt64() { }

	// RVA: 0x2326290 Offset: 0x2326391 VA: 0x2326290
	private void WriteUInt32(uint value, bool isBigEndian = True) { }

	// RVA: 0x2326350 Offset: 0x2326451 VA: 0x2326350
	private void WriteUInt64(ulong value) { }

	// RVA: 0x2326400 Offset: 0x2326501 VA: 0x2326400
	private static string ChunkType(uint id) { }

	// RVA: 0x23265E0 Offset: 0x23266E1 VA: 0x23265E0
	private static uint ChunkId(string id) { }

	// RVA: 0x2324FE0 Offset: 0x23250E1 VA: 0x2324FE0
	public void .ctor() { }

	// RVA: 0x2326670 Offset: 0x2326771 VA: 0x2326670
	private static void .cctor() { }
}

