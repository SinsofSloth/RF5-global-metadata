[ComVisibleAttribute] // RVA: 0xAD1F0 Offset: 0xAD2F1 VA: 0xAD1F0
[Serializable]
public class UnicodeEncoding : Encoding // TypeDefIndex: 475
{
	// Fields
	[OptionalFieldAttribute] // RVA: 0xB45F0 Offset: 0xB46F1 VA: 0xB45F0
	internal bool isThrowException; // 0x38
	internal bool bigEndian; // 0x39
	internal bool byteOrderMark; // 0x3A
	private static readonly ulong highLowPatternMask; // 0x0

	// Methods

	// RVA: 0x1A05FC0 Offset: 0x1A060C1 VA: 0x1A05FC0
	public void .ctor() { }

	// RVA: 0x1A06000 Offset: 0x1A06101 VA: 0x1A06000
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x1A06070 Offset: 0x1A06171 VA: 0x1A06070
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	[OnDeserializingAttribute] // RVA: 0xB7A10 Offset: 0xB7B11 VA: 0xB7A10
	// RVA: 0x1A06100 Offset: 0x1A06201 VA: 0x1A06100
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x1A06110 Offset: 0x1A06211 VA: 0x1A06110 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1A06200 Offset: 0x1A06301 VA: 0x1A06200 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1A063D0 Offset: 0x1A064D1 VA: 0x1A063D0 Slot: 9
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0xB7A20 Offset: 0xB7B21 VA: 0xB7A20
	[ComVisibleAttribute] // RVA: 0xB7A20 Offset: 0xB7B21 VA: 0xB7A20
	// RVA: 0x1A06480 Offset: 0x1A06581 VA: 0x1A06480 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1A06590 Offset: 0x1A06691 VA: 0x1A06590 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1A06800 Offset: 0x1A06901 VA: 0x1A06800 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7A60 Offset: 0xB7B61 VA: 0xB7A60
	[ComVisibleAttribute] // RVA: 0xB7A60 Offset: 0xB7B61 VA: 0xB7A60
	// RVA: 0x1A06AA0 Offset: 0x1A06BA1 VA: 0x1A06AA0 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A06C00 Offset: 0x1A06D01 VA: 0x1A06C00 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7AA0 Offset: 0xB7BA1 VA: 0xB7AA0
	[CLSCompliantAttribute] // RVA: 0xB7AA0 Offset: 0xB7BA1 VA: 0xB7AA0
	// RVA: 0x1A06DD0 Offset: 0x1A06ED1 VA: 0x1A06DD0 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A06EF0 Offset: 0x1A06FF1 VA: 0x1A06EF0 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7AE0 Offset: 0xB7BE1 VA: 0xB7AE0
	[CLSCompliantAttribute] // RVA: 0xB7AE0 Offset: 0xB7BE1 VA: 0xB7AE0
	// RVA: 0x1A07190 Offset: 0x1A07291 VA: 0x1A07190 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7B20 Offset: 0xB7C21 VA: 0xB7B20
	// RVA: 0x1A072F0 Offset: 0x1A073F1 VA: 0x1A072F0 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A074C0 Offset: 0x1A075C1 VA: 0x1A074C0 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1A07C20 Offset: 0x1A07D21 VA: 0x1A07C20 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x1A08490 Offset: 0x1A08591 VA: 0x1A08490 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A08C60 Offset: 0x1A08D61 VA: 0x1A08C60 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	[ComVisibleAttribute] // RVA: 0xB7B40 Offset: 0xB7C41 VA: 0xB7B40
	// RVA: 0x1A09670 Offset: 0x1A09771 VA: 0x1A09670 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A096E0 Offset: 0x1A097E1 VA: 0x1A096E0 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A09760 Offset: 0x1A09861 VA: 0x1A09760 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1A09860 Offset: 0x1A09961 VA: 0x1A09860 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A09970 Offset: 0x1A09A71 VA: 0x1A09970 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1A09A80 Offset: 0x1A09B81 VA: 0x1A09A80 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1A09BD0 Offset: 0x1A09CD1 VA: 0x1A09BD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A09C60 Offset: 0x1A09D61 VA: 0x1A09C60
	private static void .cctor() { }
}

