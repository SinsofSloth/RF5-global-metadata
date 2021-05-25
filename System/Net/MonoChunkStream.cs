internal class MonoChunkStream // TypeDefIndex: 1983
{
	// Fields
	internal WebHeaderCollection headers; // 0x10
	private int chunkSize; // 0x18
	private int chunkRead; // 0x1C
	private int totalWritten; // 0x20
	private MonoChunkStream.State state; // 0x24
	private StringBuilder saved; // 0x28
	private bool sawCR; // 0x30
	private bool gotit; // 0x31
	private int trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Properties
	public bool WantMore { get; }
	public bool DataAvailable { get; }
	public int ChunkLeft { get; }

	// Methods

	// RVA: 0x1795910 Offset: 0x1795A11 VA: 0x1795910
	public void .ctor(byte[] buffer, int offset, int size, WebHeaderCollection headers) { }

	// RVA: 0x1795970 Offset: 0x1795A71 VA: 0x1795970
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x1795A70 Offset: 0x1795B71 VA: 0x1795A70
	public void ResetBuffer() { }

	// RVA: 0x1795AA0 Offset: 0x1795BA1 VA: 0x1795AA0
	public void WriteAndReadBack(byte[] buffer, int offset, int size, ref int read) { }

	// RVA: 0x1795B20 Offset: 0x1795C21 VA: 0x1795B20
	public int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1795B30 Offset: 0x1795C31 VA: 0x1795B30
	private int ReadFromChunks(byte[] buffer, int offset, int size) { }

	// RVA: 0x1795A40 Offset: 0x1795B41 VA: 0x1795A40
	public void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1795E50 Offset: 0x1795F51 VA: 0x1795E50
	private void InternalWrite(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1796940 Offset: 0x1796A41 VA: 0x1796940
	public bool get_WantMore() { }

	// RVA: 0x1796970 Offset: 0x1796A71 VA: 0x1796970
	public bool get_DataAvailable() { }

	// RVA: 0x1796A90 Offset: 0x1796B91 VA: 0x1796A90
	public int get_ChunkLeft() { }

	// RVA: 0x1796390 Offset: 0x1796491 VA: 0x1796390
	private MonoChunkStream.State ReadBody(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1795F90 Offset: 0x1796091 VA: 0x1795F90
	private MonoChunkStream.State GetChunkSize(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1796B20 Offset: 0x1796C21 VA: 0x1796B20
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x17964C0 Offset: 0x17965C1 VA: 0x17964C0
	private MonoChunkStream.State ReadCRLF(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x17965E0 Offset: 0x17966E1 VA: 0x17965E0
	private MonoChunkStream.State ReadTrailer(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1796AA0 Offset: 0x1796BA1 VA: 0x1796AA0
	private static void ThrowProtocolViolation(string message) { }
}

