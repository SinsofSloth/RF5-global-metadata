internal class Encoding.EncodingCharBuffer // TypeDefIndex: 468
{
	// Fields
	private char* chars; // 0x10
	private char* charStart; // 0x18
	private char* charEnd; // 0x20
	private int charCountResult; // 0x28
	private Encoding enc; // 0x30
	private DecoderNLS decoder; // 0x38
	private byte* byteStart; // 0x40
	private byte* byteEnd; // 0x48
	private byte* bytes; // 0x50
	private DecoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int BytesUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x2A7CB70 Offset: 0x2A7CC71 VA: 0x2A7CB70
	internal void .ctor(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount) { }

	// RVA: 0x2A7CC90 Offset: 0x2A7CD91 VA: 0x2A7CC90
	internal bool AddChar(char ch, int numBytes) { }

	// RVA: 0x2A7CD60 Offset: 0x2A7CE61 VA: 0x2A7CD60
	internal bool AddChar(char ch) { }

	// RVA: 0x2A7CD70 Offset: 0x2A7CE71 VA: 0x2A7CD70
	internal void AdjustBytes(int count) { }

	// RVA: 0x2A7CD80 Offset: 0x2A7CE81 VA: 0x2A7CD80
	internal bool get_MoreData() { }

	// RVA: 0x2A7CD90 Offset: 0x2A7CE91 VA: 0x2A7CD90
	internal byte GetNextByte() { }

	// RVA: 0x2A7CDC0 Offset: 0x2A7CEC1 VA: 0x2A7CDC0
	internal int get_BytesUsed() { }

	// RVA: 0x2A7CDD0 Offset: 0x2A7CED1 VA: 0x2A7CDD0
	internal bool Fallback(byte fallbackByte) { }

	// RVA: 0x2A7CE60 Offset: 0x2A7CF61 VA: 0x2A7CE60
	internal bool Fallback(byte[] byteBuffer) { }

	// RVA: 0x2A7CFB0 Offset: 0x2A7D0B1 VA: 0x2A7CFB0
	internal int get_Count() { }
}

