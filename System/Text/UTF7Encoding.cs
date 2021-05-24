[ComVisibleAttribute] // RVA: 0xAD210 Offset: 0xAD311 VA: 0xAD210
[Serializable]
public class UTF7Encoding : Encoding // TypeDefIndex: 479
{
	// Fields
	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0xB4630 Offset: 0xB4731 VA: 0xB4630
	private bool m_allowOptionals; // 0x50

	// Methods

	// RVA: 0x19FF1F0 Offset: 0x19FF2F1 VA: 0x19FF1F0
	public void .ctor() { }

	// RVA: 0x19FF220 Offset: 0x19FF321 VA: 0x19FF220
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x19FF260 Offset: 0x19FF361 VA: 0x19FF260
	private void MakeTables() { }

	// RVA: 0x19FF4D0 Offset: 0x19FF5D1 VA: 0x19FF4D0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0xB7BE0 Offset: 0xB7CE1 VA: 0xB7BE0
	// RVA: 0x19FF5A0 Offset: 0x19FF6A1 VA: 0x19FF5A0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7BF0 Offset: 0xB7CF1 VA: 0xB7BF0
	// RVA: 0x19FF5B0 Offset: 0x19FF6B1 VA: 0x19FF5B0
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0xB7C00 Offset: 0xB7D01 VA: 0xB7C00
	// RVA: 0x19FF660 Offset: 0x19FF761 VA: 0x19FF660 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0xB7C20 Offset: 0xB7D21 VA: 0xB7C20
	// RVA: 0x19FF760 Offset: 0x19FF861 VA: 0x19FF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19FF7D0 Offset: 0x19FF8D1 VA: 0x19FF7D0 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7C40 Offset: 0xB7D41 VA: 0xB7C40
	// RVA: 0x19FF9A0 Offset: 0x19FFAA1 VA: 0x19FF9A0 Slot: 9
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0xB7C60 Offset: 0xB7D61 VA: 0xB7C60
	[ComVisibleAttribute] // RVA: 0xB7C60 Offset: 0xB7D61 VA: 0xB7C60
	// RVA: 0x19FFA50 Offset: 0x19FFB51 VA: 0x19FFA50 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7CA0 Offset: 0xB7DA1 VA: 0xB7CA0
	// RVA: 0x19FFB60 Offset: 0x19FFC61 VA: 0x19FFB60 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19FFDD0 Offset: 0x19FFED1 VA: 0x19FFDD0 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7CC0 Offset: 0xB7DC1 VA: 0xB7CC0
	[ComVisibleAttribute] // RVA: 0xB7CC0 Offset: 0xB7DC1 VA: 0xB7CC0
	// RVA: 0x1A00070 Offset: 0x1A00171 VA: 0x1A00070 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A001D0 Offset: 0x1A002D1 VA: 0x1A001D0 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7D00 Offset: 0xB7E01 VA: 0xB7D00
	[ComVisibleAttribute] // RVA: 0xB7D00 Offset: 0xB7E01 VA: 0xB7D00
	// RVA: 0x1A003A0 Offset: 0x1A004A1 VA: 0x1A003A0 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A004C0 Offset: 0x1A005C1 VA: 0x1A004C0 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7D40 Offset: 0xB7E41 VA: 0xB7D40
	[CLSCompliantAttribute] // RVA: 0xB7D40 Offset: 0xB7E41 VA: 0xB7D40
	// RVA: 0x1A00760 Offset: 0x1A00861 VA: 0x1A00760 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7D80 Offset: 0xB7E81 VA: 0xB7D80
	// RVA: 0x1A008C0 Offset: 0x1A009C1 VA: 0x1A008C0 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A00A90 Offset: 0x1A00B91 VA: 0x1A00A90 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A00AB0 Offset: 0x1A00BB1 VA: 0x1A00AB0 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A00EE0 Offset: 0x1A00FE1 VA: 0x1A00EE0 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A00F00 Offset: 0x1A01001 VA: 0x1A00F00 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A01220 Offset: 0x1A01321 VA: 0x1A01220 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A012A0 Offset: 0x1A013A1 VA: 0x1A012A0 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A01320 Offset: 0x1A01421 VA: 0x1A01320 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A013E0 Offset: 0x1A014E1 VA: 0x1A013E0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }
}

[ComVisibleAttribute] // RVA: 0xAD210 Offset: 0xAD311 VA: 0xAD210
[Serializable]
public class UTF7Encoding : Encoding // TypeDefIndex: 479
{
	// Fields
	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0xB4630 Offset: 0xB4731 VA: 0xB4630
	private bool m_allowOptionals; // 0x50

	// Methods

	// RVA: 0x19FF1F0 Offset: 0x19FF2F1 VA: 0x19FF1F0
	public void .ctor() { }

	// RVA: 0x19FF220 Offset: 0x19FF321 VA: 0x19FF220
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x19FF260 Offset: 0x19FF361 VA: 0x19FF260
	private void MakeTables() { }

	// RVA: 0x19FF4D0 Offset: 0x19FF5D1 VA: 0x19FF4D0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0xB7BE0 Offset: 0xB7CE1 VA: 0xB7BE0
	// RVA: 0x19FF5A0 Offset: 0x19FF6A1 VA: 0x19FF5A0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7BF0 Offset: 0xB7CF1 VA: 0xB7BF0
	// RVA: 0x19FF5B0 Offset: 0x19FF6B1 VA: 0x19FF5B0
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0xB7C00 Offset: 0xB7D01 VA: 0xB7C00
	// RVA: 0x19FF660 Offset: 0x19FF761 VA: 0x19FF660 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0xB7C20 Offset: 0xB7D21 VA: 0xB7C20
	// RVA: 0x19FF760 Offset: 0x19FF861 VA: 0x19FF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19FF7D0 Offset: 0x19FF8D1 VA: 0x19FF7D0 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7C40 Offset: 0xB7D41 VA: 0xB7C40
	// RVA: 0x19FF9A0 Offset: 0x19FFAA1 VA: 0x19FF9A0 Slot: 9
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0xB7C60 Offset: 0xB7D61 VA: 0xB7C60
	[ComVisibleAttribute] // RVA: 0xB7C60 Offset: 0xB7D61 VA: 0xB7C60
	// RVA: 0x19FFA50 Offset: 0x19FFB51 VA: 0x19FFA50 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7CA0 Offset: 0xB7DA1 VA: 0xB7CA0
	// RVA: 0x19FFB60 Offset: 0x19FFC61 VA: 0x19FFB60 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19FFDD0 Offset: 0x19FFED1 VA: 0x19FFDD0 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7CC0 Offset: 0xB7DC1 VA: 0xB7CC0
	[ComVisibleAttribute] // RVA: 0xB7CC0 Offset: 0xB7DC1 VA: 0xB7CC0
	// RVA: 0x1A00070 Offset: 0x1A00171 VA: 0x1A00070 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A001D0 Offset: 0x1A002D1 VA: 0x1A001D0 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7D00 Offset: 0xB7E01 VA: 0xB7D00
	[ComVisibleAttribute] // RVA: 0xB7D00 Offset: 0xB7E01 VA: 0xB7D00
	// RVA: 0x1A003A0 Offset: 0x1A004A1 VA: 0x1A003A0 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A004C0 Offset: 0x1A005C1 VA: 0x1A004C0 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7D40 Offset: 0xB7E41 VA: 0xB7D40
	[CLSCompliantAttribute] // RVA: 0xB7D40 Offset: 0xB7E41 VA: 0xB7D40
	// RVA: 0x1A00760 Offset: 0x1A00861 VA: 0x1A00760 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7D80 Offset: 0xB7E81 VA: 0xB7D80
	// RVA: 0x1A008C0 Offset: 0x1A009C1 VA: 0x1A008C0 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A00A90 Offset: 0x1A00B91 VA: 0x1A00A90 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A00AB0 Offset: 0x1A00BB1 VA: 0x1A00AB0 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A00EE0 Offset: 0x1A00FE1 VA: 0x1A00EE0 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A00F00 Offset: 0x1A01001 VA: 0x1A00F00 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A01220 Offset: 0x1A01321 VA: 0x1A01220 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A012A0 Offset: 0x1A013A1 VA: 0x1A012A0 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A01320 Offset: 0x1A01421 VA: 0x1A01320 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A013E0 Offset: 0x1A014E1 VA: 0x1A013E0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }
}

[ComVisibleAttribute] // RVA: 0xAD210 Offset: 0xAD311 VA: 0xAD210
[Serializable]
public class UTF7Encoding : Encoding // TypeDefIndex: 479
{
	// Fields
	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0xB4630 Offset: 0xB4731 VA: 0xB4630
	private bool m_allowOptionals; // 0x50

	// Methods

	// RVA: 0x19FF1F0 Offset: 0x19FF2F1 VA: 0x19FF1F0
	public void .ctor() { }

	// RVA: 0x19FF220 Offset: 0x19FF321 VA: 0x19FF220
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x19FF260 Offset: 0x19FF361 VA: 0x19FF260
	private void MakeTables() { }

	// RVA: 0x19FF4D0 Offset: 0x19FF5D1 VA: 0x19FF4D0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0xB7BE0 Offset: 0xB7CE1 VA: 0xB7BE0
	// RVA: 0x19FF5A0 Offset: 0x19FF6A1 VA: 0x19FF5A0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7BF0 Offset: 0xB7CF1 VA: 0xB7BF0
	// RVA: 0x19FF5B0 Offset: 0x19FF6B1 VA: 0x19FF5B0
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0xB7C00 Offset: 0xB7D01 VA: 0xB7C00
	// RVA: 0x19FF660 Offset: 0x19FF761 VA: 0x19FF660 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0xB7C20 Offset: 0xB7D21 VA: 0xB7C20
	// RVA: 0x19FF760 Offset: 0x19FF861 VA: 0x19FF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19FF7D0 Offset: 0x19FF8D1 VA: 0x19FF7D0 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7C40 Offset: 0xB7D41 VA: 0xB7C40
	// RVA: 0x19FF9A0 Offset: 0x19FFAA1 VA: 0x19FF9A0 Slot: 9
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0xB7C60 Offset: 0xB7D61 VA: 0xB7C60
	[ComVisibleAttribute] // RVA: 0xB7C60 Offset: 0xB7D61 VA: 0xB7C60
	// RVA: 0x19FFA50 Offset: 0x19FFB51 VA: 0x19FFA50 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7CA0 Offset: 0xB7DA1 VA: 0xB7CA0
	// RVA: 0x19FFB60 Offset: 0x19FFC61 VA: 0x19FFB60 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19FFDD0 Offset: 0x19FFED1 VA: 0x19FFDD0 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7CC0 Offset: 0xB7DC1 VA: 0xB7CC0
	[ComVisibleAttribute] // RVA: 0xB7CC0 Offset: 0xB7DC1 VA: 0xB7CC0
	// RVA: 0x1A00070 Offset: 0x1A00171 VA: 0x1A00070 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A001D0 Offset: 0x1A002D1 VA: 0x1A001D0 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7D00 Offset: 0xB7E01 VA: 0xB7D00
	[ComVisibleAttribute] // RVA: 0xB7D00 Offset: 0xB7E01 VA: 0xB7D00
	// RVA: 0x1A003A0 Offset: 0x1A004A1 VA: 0x1A003A0 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A004C0 Offset: 0x1A005C1 VA: 0x1A004C0 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7D40 Offset: 0xB7E41 VA: 0xB7D40
	[CLSCompliantAttribute] // RVA: 0xB7D40 Offset: 0xB7E41 VA: 0xB7D40
	// RVA: 0x1A00760 Offset: 0x1A00861 VA: 0x1A00760 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7D80 Offset: 0xB7E81 VA: 0xB7D80
	// RVA: 0x1A008C0 Offset: 0x1A009C1 VA: 0x1A008C0 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A00A90 Offset: 0x1A00B91 VA: 0x1A00A90 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A00AB0 Offset: 0x1A00BB1 VA: 0x1A00AB0 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A00EE0 Offset: 0x1A00FE1 VA: 0x1A00EE0 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A00F00 Offset: 0x1A01001 VA: 0x1A00F00 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A01220 Offset: 0x1A01321 VA: 0x1A01220 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A012A0 Offset: 0x1A013A1 VA: 0x1A012A0 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A01320 Offset: 0x1A01421 VA: 0x1A01320 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A013E0 Offset: 0x1A014E1 VA: 0x1A013E0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }
}

[ComVisibleAttribute] // RVA: 0xAD210 Offset: 0xAD311 VA: 0xAD210
[Serializable]
public class UTF7Encoding : Encoding // TypeDefIndex: 479
{
	// Fields
	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0xB4630 Offset: 0xB4731 VA: 0xB4630
	private bool m_allowOptionals; // 0x50

	// Methods

	// RVA: 0x19FF1F0 Offset: 0x19FF2F1 VA: 0x19FF1F0
	public void .ctor() { }

	// RVA: 0x19FF220 Offset: 0x19FF321 VA: 0x19FF220
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x19FF260 Offset: 0x19FF361 VA: 0x19FF260
	private void MakeTables() { }

	// RVA: 0x19FF4D0 Offset: 0x19FF5D1 VA: 0x19FF4D0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0xB7BE0 Offset: 0xB7CE1 VA: 0xB7BE0
	// RVA: 0x19FF5A0 Offset: 0x19FF6A1 VA: 0x19FF5A0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7BF0 Offset: 0xB7CF1 VA: 0xB7BF0
	// RVA: 0x19FF5B0 Offset: 0x19FF6B1 VA: 0x19FF5B0
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0xB7C00 Offset: 0xB7D01 VA: 0xB7C00
	// RVA: 0x19FF660 Offset: 0x19FF761 VA: 0x19FF660 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0xB7C20 Offset: 0xB7D21 VA: 0xB7C20
	// RVA: 0x19FF760 Offset: 0x19FF861 VA: 0x19FF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19FF7D0 Offset: 0x19FF8D1 VA: 0x19FF7D0 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7C40 Offset: 0xB7D41 VA: 0xB7C40
	// RVA: 0x19FF9A0 Offset: 0x19FFAA1 VA: 0x19FF9A0 Slot: 9
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0xB7C60 Offset: 0xB7D61 VA: 0xB7C60
	[ComVisibleAttribute] // RVA: 0xB7C60 Offset: 0xB7D61 VA: 0xB7C60
	// RVA: 0x19FFA50 Offset: 0x19FFB51 VA: 0x19FFA50 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7CA0 Offset: 0xB7DA1 VA: 0xB7CA0
	// RVA: 0x19FFB60 Offset: 0x19FFC61 VA: 0x19FFB60 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19FFDD0 Offset: 0x19FFED1 VA: 0x19FFDD0 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7CC0 Offset: 0xB7DC1 VA: 0xB7CC0
	[ComVisibleAttribute] // RVA: 0xB7CC0 Offset: 0xB7DC1 VA: 0xB7CC0
	// RVA: 0x1A00070 Offset: 0x1A00171 VA: 0x1A00070 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A001D0 Offset: 0x1A002D1 VA: 0x1A001D0 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7D00 Offset: 0xB7E01 VA: 0xB7D00
	[ComVisibleAttribute] // RVA: 0xB7D00 Offset: 0xB7E01 VA: 0xB7D00
	// RVA: 0x1A003A0 Offset: 0x1A004A1 VA: 0x1A003A0 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A004C0 Offset: 0x1A005C1 VA: 0x1A004C0 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7D40 Offset: 0xB7E41 VA: 0xB7D40
	[CLSCompliantAttribute] // RVA: 0xB7D40 Offset: 0xB7E41 VA: 0xB7D40
	// RVA: 0x1A00760 Offset: 0x1A00861 VA: 0x1A00760 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7D80 Offset: 0xB7E81 VA: 0xB7D80
	// RVA: 0x1A008C0 Offset: 0x1A009C1 VA: 0x1A008C0 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A00A90 Offset: 0x1A00B91 VA: 0x1A00A90 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A00AB0 Offset: 0x1A00BB1 VA: 0x1A00AB0 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A00EE0 Offset: 0x1A00FE1 VA: 0x1A00EE0 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A00F00 Offset: 0x1A01001 VA: 0x1A00F00 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A01220 Offset: 0x1A01321 VA: 0x1A01220 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A012A0 Offset: 0x1A013A1 VA: 0x1A012A0 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A01320 Offset: 0x1A01421 VA: 0x1A01320 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A013E0 Offset: 0x1A014E1 VA: 0x1A013E0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }
}

[ComVisibleAttribute] // RVA: 0xAD210 Offset: 0xAD311 VA: 0xAD210
[Serializable]
public class UTF7Encoding : Encoding // TypeDefIndex: 479
{
	// Fields
	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0xB4630 Offset: 0xB4731 VA: 0xB4630
	private bool m_allowOptionals; // 0x50

	// Methods

	// RVA: 0x19FF1F0 Offset: 0x19FF2F1 VA: 0x19FF1F0
	public void .ctor() { }

	// RVA: 0x19FF220 Offset: 0x19FF321 VA: 0x19FF220
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x19FF260 Offset: 0x19FF361 VA: 0x19FF260
	private void MakeTables() { }

	// RVA: 0x19FF4D0 Offset: 0x19FF5D1 VA: 0x19FF4D0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0xB7BE0 Offset: 0xB7CE1 VA: 0xB7BE0
	// RVA: 0x19FF5A0 Offset: 0x19FF6A1 VA: 0x19FF5A0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7BF0 Offset: 0xB7CF1 VA: 0xB7BF0
	// RVA: 0x19FF5B0 Offset: 0x19FF6B1 VA: 0x19FF5B0
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0xB7C00 Offset: 0xB7D01 VA: 0xB7C00
	// RVA: 0x19FF660 Offset: 0x19FF761 VA: 0x19FF660 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0xB7C20 Offset: 0xB7D21 VA: 0xB7C20
	// RVA: 0x19FF760 Offset: 0x19FF861 VA: 0x19FF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19FF7D0 Offset: 0x19FF8D1 VA: 0x19FF7D0 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7C40 Offset: 0xB7D41 VA: 0xB7C40
	// RVA: 0x19FF9A0 Offset: 0x19FFAA1 VA: 0x19FF9A0 Slot: 9
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0xB7C60 Offset: 0xB7D61 VA: 0xB7C60
	[ComVisibleAttribute] // RVA: 0xB7C60 Offset: 0xB7D61 VA: 0xB7C60
	// RVA: 0x19FFA50 Offset: 0x19FFB51 VA: 0x19FFA50 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7CA0 Offset: 0xB7DA1 VA: 0xB7CA0
	// RVA: 0x19FFB60 Offset: 0x19FFC61 VA: 0x19FFB60 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19FFDD0 Offset: 0x19FFED1 VA: 0x19FFDD0 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7CC0 Offset: 0xB7DC1 VA: 0xB7CC0
	[ComVisibleAttribute] // RVA: 0xB7CC0 Offset: 0xB7DC1 VA: 0xB7CC0
	// RVA: 0x1A00070 Offset: 0x1A00171 VA: 0x1A00070 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A001D0 Offset: 0x1A002D1 VA: 0x1A001D0 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7D00 Offset: 0xB7E01 VA: 0xB7D00
	[ComVisibleAttribute] // RVA: 0xB7D00 Offset: 0xB7E01 VA: 0xB7D00
	// RVA: 0x1A003A0 Offset: 0x1A004A1 VA: 0x1A003A0 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A004C0 Offset: 0x1A005C1 VA: 0x1A004C0 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7D40 Offset: 0xB7E41 VA: 0xB7D40
	[CLSCompliantAttribute] // RVA: 0xB7D40 Offset: 0xB7E41 VA: 0xB7D40
	// RVA: 0x1A00760 Offset: 0x1A00861 VA: 0x1A00760 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7D80 Offset: 0xB7E81 VA: 0xB7D80
	// RVA: 0x1A008C0 Offset: 0x1A009C1 VA: 0x1A008C0 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A00A90 Offset: 0x1A00B91 VA: 0x1A00A90 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A00AB0 Offset: 0x1A00BB1 VA: 0x1A00AB0 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A00EE0 Offset: 0x1A00FE1 VA: 0x1A00EE0 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A00F00 Offset: 0x1A01001 VA: 0x1A00F00 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A01220 Offset: 0x1A01321 VA: 0x1A01220 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A012A0 Offset: 0x1A013A1 VA: 0x1A012A0 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A01320 Offset: 0x1A01421 VA: 0x1A01320 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A013E0 Offset: 0x1A014E1 VA: 0x1A013E0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }
}

[ComVisibleAttribute] // RVA: 0xAD210 Offset: 0xAD311 VA: 0xAD210
[Serializable]
public class UTF7Encoding : Encoding // TypeDefIndex: 479
{
	// Fields
	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0xB4630 Offset: 0xB4731 VA: 0xB4630
	private bool m_allowOptionals; // 0x50

	// Methods

	// RVA: 0x19FF1F0 Offset: 0x19FF2F1 VA: 0x19FF1F0
	public void .ctor() { }

	// RVA: 0x19FF220 Offset: 0x19FF321 VA: 0x19FF220
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x19FF260 Offset: 0x19FF361 VA: 0x19FF260
	private void MakeTables() { }

	// RVA: 0x19FF4D0 Offset: 0x19FF5D1 VA: 0x19FF4D0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0xB7BE0 Offset: 0xB7CE1 VA: 0xB7BE0
	// RVA: 0x19FF5A0 Offset: 0x19FF6A1 VA: 0x19FF5A0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7BF0 Offset: 0xB7CF1 VA: 0xB7BF0
	// RVA: 0x19FF5B0 Offset: 0x19FF6B1 VA: 0x19FF5B0
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0xB7C00 Offset: 0xB7D01 VA: 0xB7C00
	// RVA: 0x19FF660 Offset: 0x19FF761 VA: 0x19FF660 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0xB7C20 Offset: 0xB7D21 VA: 0xB7C20
	// RVA: 0x19FF760 Offset: 0x19FF861 VA: 0x19FF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19FF7D0 Offset: 0x19FF8D1 VA: 0x19FF7D0 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7C40 Offset: 0xB7D41 VA: 0xB7C40
	// RVA: 0x19FF9A0 Offset: 0x19FFAA1 VA: 0x19FF9A0 Slot: 9
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0xB7C60 Offset: 0xB7D61 VA: 0xB7C60
	[ComVisibleAttribute] // RVA: 0xB7C60 Offset: 0xB7D61 VA: 0xB7C60
	// RVA: 0x19FFA50 Offset: 0x19FFB51 VA: 0x19FFA50 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7CA0 Offset: 0xB7DA1 VA: 0xB7CA0
	// RVA: 0x19FFB60 Offset: 0x19FFC61 VA: 0x19FFB60 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19FFDD0 Offset: 0x19FFED1 VA: 0x19FFDD0 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7CC0 Offset: 0xB7DC1 VA: 0xB7CC0
	[ComVisibleAttribute] // RVA: 0xB7CC0 Offset: 0xB7DC1 VA: 0xB7CC0
	// RVA: 0x1A00070 Offset: 0x1A00171 VA: 0x1A00070 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A001D0 Offset: 0x1A002D1 VA: 0x1A001D0 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7D00 Offset: 0xB7E01 VA: 0xB7D00
	[ComVisibleAttribute] // RVA: 0xB7D00 Offset: 0xB7E01 VA: 0xB7D00
	// RVA: 0x1A003A0 Offset: 0x1A004A1 VA: 0x1A003A0 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A004C0 Offset: 0x1A005C1 VA: 0x1A004C0 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7D40 Offset: 0xB7E41 VA: 0xB7D40
	[CLSCompliantAttribute] // RVA: 0xB7D40 Offset: 0xB7E41 VA: 0xB7D40
	// RVA: 0x1A00760 Offset: 0x1A00861 VA: 0x1A00760 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7D80 Offset: 0xB7E81 VA: 0xB7D80
	// RVA: 0x1A008C0 Offset: 0x1A009C1 VA: 0x1A008C0 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A00A90 Offset: 0x1A00B91 VA: 0x1A00A90 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A00AB0 Offset: 0x1A00BB1 VA: 0x1A00AB0 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A00EE0 Offset: 0x1A00FE1 VA: 0x1A00EE0 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A00F00 Offset: 0x1A01001 VA: 0x1A00F00 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A01220 Offset: 0x1A01321 VA: 0x1A01220 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A012A0 Offset: 0x1A013A1 VA: 0x1A012A0 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A01320 Offset: 0x1A01421 VA: 0x1A01320 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A013E0 Offset: 0x1A014E1 VA: 0x1A013E0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }
}

