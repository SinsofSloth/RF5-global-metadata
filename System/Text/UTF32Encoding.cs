[Serializable]
public sealed class UTF32Encoding : Encoding // TypeDefIndex: 477
{
	// Fields
	private bool emitUTF32ByteOrderMark; // 0x38
	private bool isThrowException; // 0x39
	private bool bigEndian; // 0x3A

	// Methods

	// RVA: 0x19FC640 Offset: 0x19FC741 VA: 0x19FC640
	public void .ctor() { }

	// RVA: 0x19FC710 Offset: 0x19FC811 VA: 0x19FC710
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x19FC680 Offset: 0x19FC781 VA: 0x19FC680
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	// RVA: 0x19FC770 Offset: 0x19FC871 VA: 0x19FC770 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x19FC860 Offset: 0x19FC961 VA: 0x19FC860 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x19FCA30 Offset: 0x19FCB31 VA: 0x19FCA30 Slot: 9
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0xB7B60 Offset: 0xB7C61 VA: 0xB7B60
	// RVA: 0x19FCAE0 Offset: 0x19FCBE1 VA: 0x19FCAE0 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x19FCBF0 Offset: 0x19FCCF1 VA: 0x19FCBF0 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19FCE60 Offset: 0x19FCF61 VA: 0x19FCE60 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7B80 Offset: 0xB7C81 VA: 0xB7B80
	// RVA: 0x19FD100 Offset: 0x19FD201 VA: 0x19FD100 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x19FD260 Offset: 0x19FD361 VA: 0x19FD260 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7BA0 Offset: 0xB7CA1 VA: 0xB7BA0
	// RVA: 0x19FD430 Offset: 0x19FD531 VA: 0x19FD430 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x19FD550 Offset: 0x19FD651 VA: 0x19FD550 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7BC0 Offset: 0xB7CC1 VA: 0xB7BC0
	// RVA: 0x19FD7F0 Offset: 0x19FD8F1 VA: 0x19FD7F0 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x19FD950 Offset: 0x19FDA51 VA: 0x19FD950 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x19FDB20 Offset: 0x19FDC21 VA: 0x19FDB20 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x19FDF70 Offset: 0x19FE071 VA: 0x19FDF70 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x19FE410 Offset: 0x19FE511 VA: 0x19FE410 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x19FE7A0 Offset: 0x19FE8A1 VA: 0x19FE7A0 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x19FE3F0 Offset: 0x19FE4F1 VA: 0x19FE3F0
	private uint GetSurrogate(char cHigh, char cLow) { }

	// RVA: 0x19FEC00 Offset: 0x19FED01 VA: 0x19FEC00
	private char GetHighSurrogate(uint iChar) { }

	// RVA: 0x19FEC20 Offset: 0x19FED21 VA: 0x19FEC20
	private char GetLowSurrogate(uint iChar) { }

	// RVA: 0x19FEC30 Offset: 0x19FED31 VA: 0x19FEC30 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x19FECB0 Offset: 0x19FEDB1 VA: 0x19FECB0 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x19FED20 Offset: 0x19FEE21 VA: 0x19FED20 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x19FEE30 Offset: 0x19FEF31 VA: 0x19FEE30 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x19FEF30 Offset: 0x19FF031 VA: 0x19FEF30 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x19FF030 Offset: 0x19FF131 VA: 0x19FF030 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x19FF130 Offset: 0x19FF231 VA: 0x19FF130 Slot: 2
	public override int GetHashCode() { }
}

