[ComVisibleAttribute] // RVA: 0xAD230 Offset: 0xAD331 VA: 0xAD230
[Serializable]
public class UTF8Encoding : Encoding // TypeDefIndex: 484
{
	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x1A01D70 Offset: 0x1A01E71 VA: 0x1A01D70
	public void .ctor() { }

	// RVA: 0x1A01DA0 Offset: 0x1A01EA1 VA: 0x1A01DA0
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x1A01DE0 Offset: 0x1A01EE1 VA: 0x1A01DE0
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x1A01E50 Offset: 0x1A01F51 VA: 0x1A01E50 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1A01F40 Offset: 0x1A02041 VA: 0x1A01F40 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1A02110 Offset: 0x1A02211 VA: 0x1A02110 Slot: 9
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	[CLSCompliantAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	// RVA: 0x1A021C0 Offset: 0x1A022C1 VA: 0x1A021C0 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1A022D0 Offset: 0x1A023D1 VA: 0x1A022D0 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1A02540 Offset: 0x1A02641 VA: 0x1A02540 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	[CLSCompliantAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	// RVA: 0x1A027E0 Offset: 0x1A028E1 VA: 0x1A027E0 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A02940 Offset: 0x1A02A41 VA: 0x1A02940 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	[CLSCompliantAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	// RVA: 0x1A02B10 Offset: 0x1A02C11 VA: 0x1A02B10 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A02C30 Offset: 0x1A02D31 VA: 0x1A02C30 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	[ComVisibleAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	// RVA: 0x1A02ED0 Offset: 0x1A02FD1 VA: 0x1A02ED0 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7EA0 Offset: 0xB7FA1 VA: 0xB7EA0
	// RVA: 0x1A03030 Offset: 0x1A03131 VA: 0x1A03030 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A03200 Offset: 0x1A03301 VA: 0x1A03200 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A03840 Offset: 0x1A03941 VA: 0x1A03840
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x1A03850 Offset: 0x1A03951 VA: 0x1A03850
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x1A03820 Offset: 0x1A03921 VA: 0x1A03820
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x1A03860 Offset: 0x1A03961 VA: 0x1A03860 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A04050 Offset: 0x1A04151 VA: 0x1A04050 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04620 Offset: 0x1A04721 VA: 0x1A04620 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04EB0 Offset: 0x1A04FB1 VA: 0x1A04EB0
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1A045D0 Offset: 0x1A046D1 VA: 0x1A045D0
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x1A04F40 Offset: 0x1A05041 VA: 0x1A04F40
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x1A051B0 Offset: 0x1A052B1 VA: 0x1A051B0 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A05230 Offset: 0x1A05331 VA: 0x1A05230 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A052B0 Offset: 0x1A053B1 VA: 0x1A052B0 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A053C0 Offset: 0x1A054C1 VA: 0x1A053C0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1A054D0 Offset: 0x1A055D1 VA: 0x1A054D0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1A05590 Offset: 0x1A05691 VA: 0x1A05590 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1A05690 Offset: 0x1A05791 VA: 0x1A05690 Slot: 2
	public override int GetHashCode() { }
}

[ComVisibleAttribute] // RVA: 0xAD230 Offset: 0xAD331 VA: 0xAD230
[Serializable]
public class UTF8Encoding : Encoding // TypeDefIndex: 484
{
	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x1A01D70 Offset: 0x1A01E71 VA: 0x1A01D70
	public void .ctor() { }

	// RVA: 0x1A01DA0 Offset: 0x1A01EA1 VA: 0x1A01DA0
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x1A01DE0 Offset: 0x1A01EE1 VA: 0x1A01DE0
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x1A01E50 Offset: 0x1A01F51 VA: 0x1A01E50 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1A01F40 Offset: 0x1A02041 VA: 0x1A01F40 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1A02110 Offset: 0x1A02211 VA: 0x1A02110 Slot: 9
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	[CLSCompliantAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	// RVA: 0x1A021C0 Offset: 0x1A022C1 VA: 0x1A021C0 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1A022D0 Offset: 0x1A023D1 VA: 0x1A022D0 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1A02540 Offset: 0x1A02641 VA: 0x1A02540 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	[CLSCompliantAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	// RVA: 0x1A027E0 Offset: 0x1A028E1 VA: 0x1A027E0 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A02940 Offset: 0x1A02A41 VA: 0x1A02940 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	[CLSCompliantAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	// RVA: 0x1A02B10 Offset: 0x1A02C11 VA: 0x1A02B10 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A02C30 Offset: 0x1A02D31 VA: 0x1A02C30 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	[ComVisibleAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	// RVA: 0x1A02ED0 Offset: 0x1A02FD1 VA: 0x1A02ED0 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7EA0 Offset: 0xB7FA1 VA: 0xB7EA0
	// RVA: 0x1A03030 Offset: 0x1A03131 VA: 0x1A03030 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A03200 Offset: 0x1A03301 VA: 0x1A03200 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A03840 Offset: 0x1A03941 VA: 0x1A03840
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x1A03850 Offset: 0x1A03951 VA: 0x1A03850
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x1A03820 Offset: 0x1A03921 VA: 0x1A03820
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x1A03860 Offset: 0x1A03961 VA: 0x1A03860 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A04050 Offset: 0x1A04151 VA: 0x1A04050 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04620 Offset: 0x1A04721 VA: 0x1A04620 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04EB0 Offset: 0x1A04FB1 VA: 0x1A04EB0
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1A045D0 Offset: 0x1A046D1 VA: 0x1A045D0
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x1A04F40 Offset: 0x1A05041 VA: 0x1A04F40
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x1A051B0 Offset: 0x1A052B1 VA: 0x1A051B0 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A05230 Offset: 0x1A05331 VA: 0x1A05230 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A052B0 Offset: 0x1A053B1 VA: 0x1A052B0 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A053C0 Offset: 0x1A054C1 VA: 0x1A053C0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1A054D0 Offset: 0x1A055D1 VA: 0x1A054D0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1A05590 Offset: 0x1A05691 VA: 0x1A05590 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1A05690 Offset: 0x1A05791 VA: 0x1A05690 Slot: 2
	public override int GetHashCode() { }
}

[ComVisibleAttribute] // RVA: 0xAD230 Offset: 0xAD331 VA: 0xAD230
[Serializable]
public class UTF8Encoding : Encoding // TypeDefIndex: 484
{
	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x1A01D70 Offset: 0x1A01E71 VA: 0x1A01D70
	public void .ctor() { }

	// RVA: 0x1A01DA0 Offset: 0x1A01EA1 VA: 0x1A01DA0
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x1A01DE0 Offset: 0x1A01EE1 VA: 0x1A01DE0
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x1A01E50 Offset: 0x1A01F51 VA: 0x1A01E50 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1A01F40 Offset: 0x1A02041 VA: 0x1A01F40 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1A02110 Offset: 0x1A02211 VA: 0x1A02110 Slot: 9
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	[CLSCompliantAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	// RVA: 0x1A021C0 Offset: 0x1A022C1 VA: 0x1A021C0 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1A022D0 Offset: 0x1A023D1 VA: 0x1A022D0 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1A02540 Offset: 0x1A02641 VA: 0x1A02540 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	[CLSCompliantAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	// RVA: 0x1A027E0 Offset: 0x1A028E1 VA: 0x1A027E0 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A02940 Offset: 0x1A02A41 VA: 0x1A02940 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	[CLSCompliantAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	// RVA: 0x1A02B10 Offset: 0x1A02C11 VA: 0x1A02B10 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A02C30 Offset: 0x1A02D31 VA: 0x1A02C30 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	[ComVisibleAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	// RVA: 0x1A02ED0 Offset: 0x1A02FD1 VA: 0x1A02ED0 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7EA0 Offset: 0xB7FA1 VA: 0xB7EA0
	// RVA: 0x1A03030 Offset: 0x1A03131 VA: 0x1A03030 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A03200 Offset: 0x1A03301 VA: 0x1A03200 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A03840 Offset: 0x1A03941 VA: 0x1A03840
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x1A03850 Offset: 0x1A03951 VA: 0x1A03850
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x1A03820 Offset: 0x1A03921 VA: 0x1A03820
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x1A03860 Offset: 0x1A03961 VA: 0x1A03860 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A04050 Offset: 0x1A04151 VA: 0x1A04050 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04620 Offset: 0x1A04721 VA: 0x1A04620 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04EB0 Offset: 0x1A04FB1 VA: 0x1A04EB0
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1A045D0 Offset: 0x1A046D1 VA: 0x1A045D0
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x1A04F40 Offset: 0x1A05041 VA: 0x1A04F40
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x1A051B0 Offset: 0x1A052B1 VA: 0x1A051B0 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A05230 Offset: 0x1A05331 VA: 0x1A05230 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A052B0 Offset: 0x1A053B1 VA: 0x1A052B0 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A053C0 Offset: 0x1A054C1 VA: 0x1A053C0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1A054D0 Offset: 0x1A055D1 VA: 0x1A054D0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1A05590 Offset: 0x1A05691 VA: 0x1A05590 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1A05690 Offset: 0x1A05791 VA: 0x1A05690 Slot: 2
	public override int GetHashCode() { }
}

[ComVisibleAttribute] // RVA: 0xAD230 Offset: 0xAD331 VA: 0xAD230
[Serializable]
public class UTF8Encoding : Encoding // TypeDefIndex: 484
{
	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x1A01D70 Offset: 0x1A01E71 VA: 0x1A01D70
	public void .ctor() { }

	// RVA: 0x1A01DA0 Offset: 0x1A01EA1 VA: 0x1A01DA0
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x1A01DE0 Offset: 0x1A01EE1 VA: 0x1A01DE0
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x1A01E50 Offset: 0x1A01F51 VA: 0x1A01E50 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1A01F40 Offset: 0x1A02041 VA: 0x1A01F40 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1A02110 Offset: 0x1A02211 VA: 0x1A02110 Slot: 9
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	[CLSCompliantAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	// RVA: 0x1A021C0 Offset: 0x1A022C1 VA: 0x1A021C0 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1A022D0 Offset: 0x1A023D1 VA: 0x1A022D0 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1A02540 Offset: 0x1A02641 VA: 0x1A02540 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	[CLSCompliantAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	// RVA: 0x1A027E0 Offset: 0x1A028E1 VA: 0x1A027E0 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A02940 Offset: 0x1A02A41 VA: 0x1A02940 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	[CLSCompliantAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	// RVA: 0x1A02B10 Offset: 0x1A02C11 VA: 0x1A02B10 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A02C30 Offset: 0x1A02D31 VA: 0x1A02C30 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	[ComVisibleAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	// RVA: 0x1A02ED0 Offset: 0x1A02FD1 VA: 0x1A02ED0 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7EA0 Offset: 0xB7FA1 VA: 0xB7EA0
	// RVA: 0x1A03030 Offset: 0x1A03131 VA: 0x1A03030 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A03200 Offset: 0x1A03301 VA: 0x1A03200 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A03840 Offset: 0x1A03941 VA: 0x1A03840
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x1A03850 Offset: 0x1A03951 VA: 0x1A03850
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x1A03820 Offset: 0x1A03921 VA: 0x1A03820
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x1A03860 Offset: 0x1A03961 VA: 0x1A03860 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A04050 Offset: 0x1A04151 VA: 0x1A04050 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04620 Offset: 0x1A04721 VA: 0x1A04620 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04EB0 Offset: 0x1A04FB1 VA: 0x1A04EB0
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1A045D0 Offset: 0x1A046D1 VA: 0x1A045D0
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x1A04F40 Offset: 0x1A05041 VA: 0x1A04F40
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x1A051B0 Offset: 0x1A052B1 VA: 0x1A051B0 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A05230 Offset: 0x1A05331 VA: 0x1A05230 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A052B0 Offset: 0x1A053B1 VA: 0x1A052B0 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A053C0 Offset: 0x1A054C1 VA: 0x1A053C0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1A054D0 Offset: 0x1A055D1 VA: 0x1A054D0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1A05590 Offset: 0x1A05691 VA: 0x1A05590 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1A05690 Offset: 0x1A05791 VA: 0x1A05690 Slot: 2
	public override int GetHashCode() { }
}

[ComVisibleAttribute] // RVA: 0xAD230 Offset: 0xAD331 VA: 0xAD230
[Serializable]
public class UTF8Encoding : Encoding // TypeDefIndex: 484
{
	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x1A01D70 Offset: 0x1A01E71 VA: 0x1A01D70
	public void .ctor() { }

	// RVA: 0x1A01DA0 Offset: 0x1A01EA1 VA: 0x1A01DA0
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x1A01DE0 Offset: 0x1A01EE1 VA: 0x1A01DE0
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x1A01E50 Offset: 0x1A01F51 VA: 0x1A01E50 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1A01F40 Offset: 0x1A02041 VA: 0x1A01F40 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1A02110 Offset: 0x1A02211 VA: 0x1A02110 Slot: 9
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	[CLSCompliantAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	// RVA: 0x1A021C0 Offset: 0x1A022C1 VA: 0x1A021C0 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1A022D0 Offset: 0x1A023D1 VA: 0x1A022D0 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1A02540 Offset: 0x1A02641 VA: 0x1A02540 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	[CLSCompliantAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	// RVA: 0x1A027E0 Offset: 0x1A028E1 VA: 0x1A027E0 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A02940 Offset: 0x1A02A41 VA: 0x1A02940 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	[CLSCompliantAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	// RVA: 0x1A02B10 Offset: 0x1A02C11 VA: 0x1A02B10 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A02C30 Offset: 0x1A02D31 VA: 0x1A02C30 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	[ComVisibleAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	// RVA: 0x1A02ED0 Offset: 0x1A02FD1 VA: 0x1A02ED0 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7EA0 Offset: 0xB7FA1 VA: 0xB7EA0
	// RVA: 0x1A03030 Offset: 0x1A03131 VA: 0x1A03030 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A03200 Offset: 0x1A03301 VA: 0x1A03200 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A03840 Offset: 0x1A03941 VA: 0x1A03840
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x1A03850 Offset: 0x1A03951 VA: 0x1A03850
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x1A03820 Offset: 0x1A03921 VA: 0x1A03820
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x1A03860 Offset: 0x1A03961 VA: 0x1A03860 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A04050 Offset: 0x1A04151 VA: 0x1A04050 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04620 Offset: 0x1A04721 VA: 0x1A04620 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04EB0 Offset: 0x1A04FB1 VA: 0x1A04EB0
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1A045D0 Offset: 0x1A046D1 VA: 0x1A045D0
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x1A04F40 Offset: 0x1A05041 VA: 0x1A04F40
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x1A051B0 Offset: 0x1A052B1 VA: 0x1A051B0 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A05230 Offset: 0x1A05331 VA: 0x1A05230 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A052B0 Offset: 0x1A053B1 VA: 0x1A052B0 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A053C0 Offset: 0x1A054C1 VA: 0x1A053C0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1A054D0 Offset: 0x1A055D1 VA: 0x1A054D0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1A05590 Offset: 0x1A05691 VA: 0x1A05590 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1A05690 Offset: 0x1A05791 VA: 0x1A05690 Slot: 2
	public override int GetHashCode() { }
}

[ComVisibleAttribute] // RVA: 0xAD230 Offset: 0xAD331 VA: 0xAD230
[Serializable]
public class UTF8Encoding : Encoding // TypeDefIndex: 484
{
	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x1A01D70 Offset: 0x1A01E71 VA: 0x1A01D70
	public void .ctor() { }

	// RVA: 0x1A01DA0 Offset: 0x1A01EA1 VA: 0x1A01DA0
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x1A01DE0 Offset: 0x1A01EE1 VA: 0x1A01DE0
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x1A01E50 Offset: 0x1A01F51 VA: 0x1A01E50 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1A01F40 Offset: 0x1A02041 VA: 0x1A01F40 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1A02110 Offset: 0x1A02211 VA: 0x1A02110 Slot: 9
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	[CLSCompliantAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	// RVA: 0x1A021C0 Offset: 0x1A022C1 VA: 0x1A021C0 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1A022D0 Offset: 0x1A023D1 VA: 0x1A022D0 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1A02540 Offset: 0x1A02641 VA: 0x1A02540 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	[CLSCompliantAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	// RVA: 0x1A027E0 Offset: 0x1A028E1 VA: 0x1A027E0 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A02940 Offset: 0x1A02A41 VA: 0x1A02940 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	[CLSCompliantAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	// RVA: 0x1A02B10 Offset: 0x1A02C11 VA: 0x1A02B10 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A02C30 Offset: 0x1A02D31 VA: 0x1A02C30 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	[ComVisibleAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	// RVA: 0x1A02ED0 Offset: 0x1A02FD1 VA: 0x1A02ED0 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7EA0 Offset: 0xB7FA1 VA: 0xB7EA0
	// RVA: 0x1A03030 Offset: 0x1A03131 VA: 0x1A03030 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A03200 Offset: 0x1A03301 VA: 0x1A03200 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A03840 Offset: 0x1A03941 VA: 0x1A03840
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x1A03850 Offset: 0x1A03951 VA: 0x1A03850
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x1A03820 Offset: 0x1A03921 VA: 0x1A03820
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x1A03860 Offset: 0x1A03961 VA: 0x1A03860 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A04050 Offset: 0x1A04151 VA: 0x1A04050 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04620 Offset: 0x1A04721 VA: 0x1A04620 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04EB0 Offset: 0x1A04FB1 VA: 0x1A04EB0
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1A045D0 Offset: 0x1A046D1 VA: 0x1A045D0
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x1A04F40 Offset: 0x1A05041 VA: 0x1A04F40
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x1A051B0 Offset: 0x1A052B1 VA: 0x1A051B0 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A05230 Offset: 0x1A05331 VA: 0x1A05230 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A052B0 Offset: 0x1A053B1 VA: 0x1A052B0 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A053C0 Offset: 0x1A054C1 VA: 0x1A053C0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1A054D0 Offset: 0x1A055D1 VA: 0x1A054D0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1A05590 Offset: 0x1A05691 VA: 0x1A05590 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1A05690 Offset: 0x1A05791 VA: 0x1A05690 Slot: 2
	public override int GetHashCode() { }
}

[ComVisibleAttribute] // RVA: 0xAD230 Offset: 0xAD331 VA: 0xAD230
[Serializable]
public class UTF8Encoding : Encoding // TypeDefIndex: 484
{
	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x1A01D70 Offset: 0x1A01E71 VA: 0x1A01D70
	public void .ctor() { }

	// RVA: 0x1A01DA0 Offset: 0x1A01EA1 VA: 0x1A01DA0
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x1A01DE0 Offset: 0x1A01EE1 VA: 0x1A01DE0
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x1A01E50 Offset: 0x1A01F51 VA: 0x1A01E50 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1A01F40 Offset: 0x1A02041 VA: 0x1A01F40 Slot: 10
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1A02110 Offset: 0x1A02211 VA: 0x1A02110 Slot: 9
	public override int GetByteCount(string chars) { }

	[ComVisibleAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	[CLSCompliantAttribute] // RVA: 0xB7DA0 Offset: 0xB7EA1 VA: 0xB7DA0
	// RVA: 0x1A021C0 Offset: 0x1A022C1 VA: 0x1A021C0 Slot: 11
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1A022D0 Offset: 0x1A023D1 VA: 0x1A022D0 Slot: 16
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1A02540 Offset: 0x1A02641 VA: 0x1A02540 Slot: 14
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	[CLSCompliantAttribute] // RVA: 0xB7DE0 Offset: 0xB7EE1 VA: 0xB7DE0
	// RVA: 0x1A027E0 Offset: 0x1A028E1 VA: 0x1A027E0 Slot: 18
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1A02940 Offset: 0x1A02A41 VA: 0x1A02940 Slot: 19
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	[CLSCompliantAttribute] // RVA: 0xB7E20 Offset: 0xB7F21 VA: 0xB7E20
	// RVA: 0x1A02B10 Offset: 0x1A02C11 VA: 0x1A02B10 Slot: 20
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1A02C30 Offset: 0x1A02D31 VA: 0x1A02C30 Slot: 23
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	[ComVisibleAttribute] // RVA: 0xB7E60 Offset: 0xB7F61 VA: 0xB7E60
	// RVA: 0x1A02ED0 Offset: 0x1A02FD1 VA: 0x1A02ED0 Slot: 24
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0xB7EA0 Offset: 0xB7FA1 VA: 0xB7EA0
	// RVA: 0x1A03030 Offset: 0x1A03131 VA: 0x1A03030 Slot: 32
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1A03200 Offset: 0x1A03301 VA: 0x1A03200 Slot: 12
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x1A03840 Offset: 0x1A03941 VA: 0x1A03840
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x1A03850 Offset: 0x1A03951 VA: 0x1A03850
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x1A03820 Offset: 0x1A03921 VA: 0x1A03820
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x1A03860 Offset: 0x1A03961 VA: 0x1A03860 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x1A04050 Offset: 0x1A04151 VA: 0x1A04050 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04620 Offset: 0x1A04721 VA: 0x1A04620 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x1A04EB0 Offset: 0x1A04FB1 VA: 0x1A04EB0
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x1A045D0 Offset: 0x1A046D1 VA: 0x1A045D0
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x1A04F40 Offset: 0x1A05041 VA: 0x1A04F40
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x1A051B0 Offset: 0x1A052B1 VA: 0x1A051B0 Slot: 27
	public override Decoder GetDecoder() { }

	// RVA: 0x1A05230 Offset: 0x1A05331 VA: 0x1A05230 Slot: 28
	public override Encoder GetEncoder() { }

	// RVA: 0x1A052B0 Offset: 0x1A053B1 VA: 0x1A052B0 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1A053C0 Offset: 0x1A054C1 VA: 0x1A053C0 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1A054D0 Offset: 0x1A055D1 VA: 0x1A054D0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x1A05590 Offset: 0x1A05691 VA: 0x1A05590 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1A05690 Offset: 0x1A05791 VA: 0x1A05690 Slot: 2
	public override int GetHashCode() { }
}

