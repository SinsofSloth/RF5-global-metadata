internal class Encoding.EncodingByteBuffer // TypeDefIndex: 469
{
	// Fields
	private byte* bytes; // 0x10
	private byte* byteStart; // 0x18
	private byte* byteEnd; // 0x20
	private char* chars; // 0x28
	private char* charStart; // 0x30
	private char* charEnd; // 0x38
	private int byteCountResult; // 0x40
	private Encoding enc; // 0x48
	private EncoderNLS encoder; // 0x50
	internal EncoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int CharsUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x2A7C4F0 Offset: 0x2A7C5F1 VA: 0x2A7C4F0
	internal void .ctor(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount) { }

	// RVA: 0x2A7C7A0 Offset: 0x2A7C8A1 VA: 0x2A7C7A0
	internal bool AddByte(byte b, int moreBytesExpected) { }

	// RVA: 0x2A7C8E0 Offset: 0x2A7C9E1 VA: 0x2A7C8E0
	internal bool AddByte(byte b1) { }

	// RVA: 0x2A7C930 Offset: 0x2A7CA31 VA: 0x2A7C930
	internal bool AddByte(byte b1, byte b2) { }

	// RVA: 0x2A7C9D0 Offset: 0x2A7CAD1 VA: 0x2A7C9D0
	internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

	// RVA: 0x2A7C800 Offset: 0x2A7C901 VA: 0x2A7C800
	internal void MovePrevious(bool bThrow) { }

	// RVA: 0x2A7CA70 Offset: 0x2A7CB71 VA: 0x2A7CA70
	internal bool get_MoreData() { }

	// RVA: 0x2A7CAD0 Offset: 0x2A7CBD1 VA: 0x2A7CAD0
	internal char GetNextChar() { }

	// RVA: 0x2A7CB40 Offset: 0x2A7CC41 VA: 0x2A7CB40
	internal int get_CharsUsed() { }

	// RVA: 0x2A7CB60 Offset: 0x2A7CC61 VA: 0x2A7CB60
	internal int get_Count() { }
}

