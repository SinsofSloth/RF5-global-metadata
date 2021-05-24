[ComVisibleAttribute] // RVA: 0xAD0E0 Offset: 0xAD1E1 VA: 0xAD0E0
[Serializable]
public class ASCIIEncoding : Encoding // TypeDefIndex: 442
{
	// Methods

	// RVA: 0x2A70400 Offset: 0x2A70501 VA: 0x2A70400
	public void .ctor() { }

	// RVA: 0x2A70520 Offset: 0x2A70621 VA: 0x2A70520 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x2A70920 Offset: 0x2A70A21 VA: 0x2A70920 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x2A70AF0 Offset: 0x2A70BF1 VA: 0x2A70AF0 Slot: 9
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0xB7580 Offset: 0xB7681 VA: 0xB7580
	[CLSCompliantAttribute] // RVA: 0xB7580 Offset: 0xB7681 VA: 0xB7580
	// RVA: 0x2A70BA0 Offset: 0x2A70CA1 VA: 0x2A70BA0 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x2A70CB0 Offset: 0x2A70DB1 VA: 0x2A70CB0 Slot: 16
	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A70F20 Offset: 0x2A71021 VA: 0x2A70F20 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0xB75C0 Offset: 0xB76C1 VA: 0xB75C0
	[CLSCompliantAttribute] // RVA: 0xB75C0 Offset: 0xB76C1 VA: 0xB75C0
	// RVA: 0x2A711C0 Offset: 0x2A712C1 VA: 0x2A711C0 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x2A71320 Offset: 0x2A71421 VA: 0x2A71320 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7600 Offset: 0xB7701 VA: 0xB7600
	[CLSCompliantAttribute] // RVA: 0xB7600 Offset: 0xB7701 VA: 0xB7600
	// RVA: 0x2A714F0 Offset: 0x2A715F1 VA: 0x2A714F0 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2A71610 Offset: 0x2A71711 VA: 0x2A71610 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7640 Offset: 0xB7741 VA: 0xB7640
	[CLSCompliantAttribute] // RVA: 0xB7640 Offset: 0xB7741 VA: 0xB7640
	// RVA: 0x2A718B0 Offset: 0x2A719B1 VA: 0x2A718B0 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2A71A10 Offset: 0x2A71B11 VA: 0x2A71A10 Slot: 32
	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	// RVA: 0x2A71BE0 Offset: 0x2A71CE1 VA: 0x2A71BE0 Slot: 12
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x2A72180 Offset: 0x2A72281 VA: 0x2A72180 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x2A72800 Offset: 0x2A72901 VA: 0x2A72800 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x2A72A90 Offset: 0x2A72B91 VA: 0x2A72A90 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x2A72FC0 Offset: 0x2A730C1 VA: 0x2A72FC0 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x2A730D0 Offset: 0x2A731D1 VA: 0x2A730D0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }

	[ComVisibleAttribute] // RVA: 0xB7680 Offset: 0xB7781 VA: 0xB7680
	// RVA: 0x2A731E0 Offset: 0x2A732E1 VA: 0x2A731E0 Slot: 27
	public override Decoder GetDecoder() { }

	[ComVisibleAttribute] // RVA: 0xB76A0 Offset: 0xB77A1 VA: 0xB76A0
	// RVA: 0x2A73300 Offset: 0x2A73401 VA: 0x2A73300 Slot: 28
	public override Encoder GetEncoder() { }
}

