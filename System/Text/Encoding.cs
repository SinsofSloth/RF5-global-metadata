[ComVisibleAttribute] // RVA: 0xAD140 Offset: 0xAD241 VA: 0xAD140
[Serializable]
public abstract class Encoding : ICloneable // TypeDefIndex: 465
{
	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Hashtable encodings; // 0x40
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalFieldAttribute] // RVA: 0xB4520 Offset: 0xB4621 VA: 0xB4520
	private bool m_isReadOnly; // 0x21
	[OptionalFieldAttribute] // RVA: 0xB4560 Offset: 0xB4661 VA: 0xB4560
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalFieldAttribute] // RVA: 0xB45A0 Offset: 0xB46A1 VA: 0xB45A0
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual string EncodingName { get; }
	[ComVisibleAttribute] // RVA: 0xBA080 Offset: 0xBA181 VA: 0xBA080
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA0A0 Offset: 0xBA1A1 VA: 0xBA0A0
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA0C0 Offset: 0xBA1C1 VA: 0xBA0C0
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x2A77E00 Offset: 0x2A77F01 VA: 0x2A77E00
	protected void .ctor() { }

	// RVA: 0x2A70470 Offset: 0x2A70571 VA: 0x2A70470
	protected void .ctor(int codePage) { }

	// RVA: 0x2A77E70 Offset: 0x2A77F71 VA: 0x2A77E70 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x2A77FD0 Offset: 0x2A780D1 VA: 0x2A77FD0
	internal void OnDeserializing() { }

	// RVA: 0x2A78010 Offset: 0x2A78111 VA: 0x2A78010
	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0xB7820 Offset: 0xB7921 VA: 0xB7820
	// RVA: 0x2A78060 Offset: 0x2A78161 VA: 0x2A78060
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7830 Offset: 0xB7931 VA: 0xB7830
	// RVA: 0x2A780A0 Offset: 0x2A781A1 VA: 0x2A780A0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0xB7840 Offset: 0xB7941 VA: 0xB7840
	// RVA: 0x2A780F0 Offset: 0x2A781F1 VA: 0x2A780F0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x2A78100 Offset: 0x2A78201 VA: 0x2A78100
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A784B0 Offset: 0x2A785B1 VA: 0x2A784B0
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A78600 Offset: 0x2A78701 VA: 0x2A78600
	private static object get_InternalSyncObject() { }

	// RVA: 0x2A786A0 Offset: 0x2A787A1 VA: 0x2A786A0
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x2A79FC0 Offset: 0x2A7A0C1 VA: 0x2A79FC0
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x2A7A190 Offset: 0x2A7A291 VA: 0x2A7A190 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x2A7A200 Offset: 0x2A7A301 VA: 0x2A7A200 Slot: 7
	public virtual string get_EncodingName() { }

	// RVA: 0x2A7A210 Offset: 0x2A7A311 VA: 0x2A7A210
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x2A7A220 Offset: 0x2A7A321 VA: 0x2A7A220
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x2A7A310 Offset: 0x2A7A411 VA: 0x2A7A310
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x2A7A320 Offset: 0x2A7A421 VA: 0x2A7A320
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0xB7850 Offset: 0xB7951 VA: 0xB7850
	// RVA: 0x2A7A410 Offset: 0x2A7A511 VA: 0x2A7A410 Slot: 8
	public virtual object Clone() { }

	// RVA: 0x2A7A4A0 Offset: 0x2A7A5A1 VA: 0x2A7A4A0
	public bool get_IsReadOnly() { }

	// RVA: 0x2A70310 Offset: 0x2A70411 VA: 0x2A70310
	public static Encoding get_ASCII() { }

	// RVA: 0x2A79840 Offset: 0x2A79941 VA: 0x2A79840
	private static Encoding get_Latin1() { }

	// RVA: 0x2A7A520 Offset: 0x2A7A621 VA: 0x2A7A520 Slot: 9
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int GetByteCount(char[] chars, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7870 Offset: 0xB7971 VA: 0xB7870
	[ComVisibleAttribute] // RVA: 0xB7870 Offset: 0xB7971 VA: 0xB7870
	// RVA: 0x2A7A5E0 Offset: 0x2A7A6E1 VA: 0x2A7A5E0 Slot: 11
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x2A7A750 Offset: 0x2A7A851 VA: 0x2A7A750 Slot: 12
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x2A7A760 Offset: 0x2A7A861 VA: 0x2A7A760 Slot: 13
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A7A820 Offset: 0x2A7A921 VA: 0x2A7A820 Slot: 15
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x2A7A920 Offset: 0x2A7AA21 VA: 0x2A7A920 Slot: 16
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A7AA00 Offset: 0x2A7AB01 VA: 0x2A7AA00 Slot: 17
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[ComVisibleAttribute] // RVA: 0xB78B0 Offset: 0xB79B1 VA: 0xB78B0
	[CLSCompliantAttribute] // RVA: 0xB78B0 Offset: 0xB79B1 VA: 0xB78B0
	// RVA: 0x2A7AA10 Offset: 0x2A7AB11 VA: 0x2A7AA10 Slot: 18
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB78F0 Offset: 0xB79F1 VA: 0xB78F0
	[ComVisibleAttribute] // RVA: 0xB78F0 Offset: 0xB79F1 VA: 0xB78F0
	// RVA: 0x2A7AC30 Offset: 0x2A7AD31 VA: 0x2A7AC30 Slot: 20
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2A7ADA0 Offset: 0x2A7AEA1 VA: 0x2A7ADA0 Slot: 21
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x2A7ADB0 Offset: 0x2A7AEB1 VA: 0x2A7ADB0 Slot: 22
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7930 Offset: 0xB7A31 VA: 0xB7930
	[CLSCompliantAttribute] // RVA: 0xB7930 Offset: 0xB7A31 VA: 0xB7930
	// RVA: 0x2A7AE70 Offset: 0x2A7AF71 VA: 0x2A7AE70 Slot: 24
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2A7B090 Offset: 0x2A7B191 VA: 0x2A7B090 Slot: 25
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[ComVisibleAttribute] // RVA: 0xB7970 Offset: 0xB7A71 VA: 0xB7970
	[CLSCompliantAttribute] // RVA: 0xB7970 Offset: 0xB7A71 VA: 0xB7970
	// RVA: 0x2A7B0A0 Offset: 0x2A7B1A1 VA: 0x2A7B0A0
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x2A7B1B0 Offset: 0x2A7B2B1 VA: 0x2A7B1B0 Slot: 26
	public virtual int get_CodePage() { }

	// RVA: 0x2A7B1C0 Offset: 0x2A7B2C1 VA: 0x2A7B1C0 Slot: 27
	public virtual Decoder GetDecoder() { }

	// RVA: 0x2A7B280 Offset: 0x2A7B381 VA: 0x2A7B280
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x2A7B4C0 Offset: 0x2A7B5C1 VA: 0x2A7B4C0
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x2A79400 Offset: 0x2A79501 VA: 0x2A79400
	public static Encoding get_Default() { }

	// RVA: 0x2A7B4D0 Offset: 0x2A7B5D1 VA: 0x2A7B4D0 Slot: 28
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetMaxByteCount(int charCount) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2A7B590 Offset: 0x2A7B691 VA: 0x2A7B590 Slot: 31
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x2A7B660 Offset: 0x2A7B761 VA: 0x2A7B660 Slot: 32
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x2A794E0 Offset: 0x2A795E1 VA: 0x2A794E0
	public static Encoding get_Unicode() { }

	// RVA: 0x2A79590 Offset: 0x2A79691 VA: 0x2A79590
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x2A79640 Offset: 0x2A79741 VA: 0x2A79640
	public static Encoding get_UTF7() { }

	// RVA: 0x2A79790 Offset: 0x2A79891 VA: 0x2A79790
	public static Encoding get_UTF8() { }

	// RVA: 0x2A796E0 Offset: 0x2A797E1 VA: 0x2A796E0
	public static Encoding get_UTF32() { }

	// RVA: 0x2A7B690 Offset: 0x2A7B791 VA: 0x2A7B690 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2A7B780 Offset: 0x2A7B881 VA: 0x2A7B780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A7B7E0 Offset: 0x2A7B8E1 VA: 0x2A7B7E0 Slot: 33
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x2A7B850 Offset: 0x2A7B951 VA: 0x2A7B850 Slot: 34
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x2A7B8C0 Offset: 0x2A7B9C1 VA: 0x2A7B8C0
	internal void ThrowBytesOverflow() { }

	// RVA: 0x2A72780 Offset: 0x2A72881 VA: 0x2A72780
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x2A7B9F0 Offset: 0x2A7BAF1 VA: 0x2A7B9F0
	internal void ThrowCharsOverflow() { }

	// RVA: 0x2A72F40 Offset: 0x2A73041 VA: 0x2A72F40
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }
}

[ComVisibleAttribute] // RVA: 0xAD140 Offset: 0xAD241 VA: 0xAD140
[Serializable]
public abstract class Encoding : ICloneable // TypeDefIndex: 465
{
	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Hashtable encodings; // 0x40
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalFieldAttribute] // RVA: 0xB4520 Offset: 0xB4621 VA: 0xB4520
	private bool m_isReadOnly; // 0x21
	[OptionalFieldAttribute] // RVA: 0xB4560 Offset: 0xB4661 VA: 0xB4560
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalFieldAttribute] // RVA: 0xB45A0 Offset: 0xB46A1 VA: 0xB45A0
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual string EncodingName { get; }
	[ComVisibleAttribute] // RVA: 0xBA080 Offset: 0xBA181 VA: 0xBA080
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA0A0 Offset: 0xBA1A1 VA: 0xBA0A0
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA0C0 Offset: 0xBA1C1 VA: 0xBA0C0
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x2A77E00 Offset: 0x2A77F01 VA: 0x2A77E00
	protected void .ctor() { }

	// RVA: 0x2A70470 Offset: 0x2A70571 VA: 0x2A70470
	protected void .ctor(int codePage) { }

	// RVA: 0x2A77E70 Offset: 0x2A77F71 VA: 0x2A77E70 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x2A77FD0 Offset: 0x2A780D1 VA: 0x2A77FD0
	internal void OnDeserializing() { }

	// RVA: 0x2A78010 Offset: 0x2A78111 VA: 0x2A78010
	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0xB7820 Offset: 0xB7921 VA: 0xB7820
	// RVA: 0x2A78060 Offset: 0x2A78161 VA: 0x2A78060
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7830 Offset: 0xB7931 VA: 0xB7830
	// RVA: 0x2A780A0 Offset: 0x2A781A1 VA: 0x2A780A0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0xB7840 Offset: 0xB7941 VA: 0xB7840
	// RVA: 0x2A780F0 Offset: 0x2A781F1 VA: 0x2A780F0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x2A78100 Offset: 0x2A78201 VA: 0x2A78100
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A784B0 Offset: 0x2A785B1 VA: 0x2A784B0
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A78600 Offset: 0x2A78701 VA: 0x2A78600
	private static object get_InternalSyncObject() { }

	// RVA: 0x2A786A0 Offset: 0x2A787A1 VA: 0x2A786A0
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x2A79FC0 Offset: 0x2A7A0C1 VA: 0x2A79FC0
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x2A7A190 Offset: 0x2A7A291 VA: 0x2A7A190 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x2A7A200 Offset: 0x2A7A301 VA: 0x2A7A200 Slot: 7
	public virtual string get_EncodingName() { }

	// RVA: 0x2A7A210 Offset: 0x2A7A311 VA: 0x2A7A210
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x2A7A220 Offset: 0x2A7A321 VA: 0x2A7A220
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x2A7A310 Offset: 0x2A7A411 VA: 0x2A7A310
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x2A7A320 Offset: 0x2A7A421 VA: 0x2A7A320
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0xB7850 Offset: 0xB7951 VA: 0xB7850
	// RVA: 0x2A7A410 Offset: 0x2A7A511 VA: 0x2A7A410 Slot: 8
	public virtual object Clone() { }

	// RVA: 0x2A7A4A0 Offset: 0x2A7A5A1 VA: 0x2A7A4A0
	public bool get_IsReadOnly() { }

	// RVA: 0x2A70310 Offset: 0x2A70411 VA: 0x2A70310
	public static Encoding get_ASCII() { }

	// RVA: 0x2A79840 Offset: 0x2A79941 VA: 0x2A79840
	private static Encoding get_Latin1() { }

	// RVA: 0x2A7A520 Offset: 0x2A7A621 VA: 0x2A7A520 Slot: 9
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int GetByteCount(char[] chars, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7870 Offset: 0xB7971 VA: 0xB7870
	[ComVisibleAttribute] // RVA: 0xB7870 Offset: 0xB7971 VA: 0xB7870
	// RVA: 0x2A7A5E0 Offset: 0x2A7A6E1 VA: 0x2A7A5E0 Slot: 11
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x2A7A750 Offset: 0x2A7A851 VA: 0x2A7A750 Slot: 12
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x2A7A760 Offset: 0x2A7A861 VA: 0x2A7A760 Slot: 13
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A7A820 Offset: 0x2A7A921 VA: 0x2A7A820 Slot: 15
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x2A7A920 Offset: 0x2A7AA21 VA: 0x2A7A920 Slot: 16
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A7AA00 Offset: 0x2A7AB01 VA: 0x2A7AA00 Slot: 17
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[ComVisibleAttribute] // RVA: 0xB78B0 Offset: 0xB79B1 VA: 0xB78B0
	[CLSCompliantAttribute] // RVA: 0xB78B0 Offset: 0xB79B1 VA: 0xB78B0
	// RVA: 0x2A7AA10 Offset: 0x2A7AB11 VA: 0x2A7AA10 Slot: 18
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB78F0 Offset: 0xB79F1 VA: 0xB78F0
	[ComVisibleAttribute] // RVA: 0xB78F0 Offset: 0xB79F1 VA: 0xB78F0
	// RVA: 0x2A7AC30 Offset: 0x2A7AD31 VA: 0x2A7AC30 Slot: 20
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2A7ADA0 Offset: 0x2A7AEA1 VA: 0x2A7ADA0 Slot: 21
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x2A7ADB0 Offset: 0x2A7AEB1 VA: 0x2A7ADB0 Slot: 22
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7930 Offset: 0xB7A31 VA: 0xB7930
	[CLSCompliantAttribute] // RVA: 0xB7930 Offset: 0xB7A31 VA: 0xB7930
	// RVA: 0x2A7AE70 Offset: 0x2A7AF71 VA: 0x2A7AE70 Slot: 24
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2A7B090 Offset: 0x2A7B191 VA: 0x2A7B090 Slot: 25
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[ComVisibleAttribute] // RVA: 0xB7970 Offset: 0xB7A71 VA: 0xB7970
	[CLSCompliantAttribute] // RVA: 0xB7970 Offset: 0xB7A71 VA: 0xB7970
	// RVA: 0x2A7B0A0 Offset: 0x2A7B1A1 VA: 0x2A7B0A0
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x2A7B1B0 Offset: 0x2A7B2B1 VA: 0x2A7B1B0 Slot: 26
	public virtual int get_CodePage() { }

	// RVA: 0x2A7B1C0 Offset: 0x2A7B2C1 VA: 0x2A7B1C0 Slot: 27
	public virtual Decoder GetDecoder() { }

	// RVA: 0x2A7B280 Offset: 0x2A7B381 VA: 0x2A7B280
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x2A7B4C0 Offset: 0x2A7B5C1 VA: 0x2A7B4C0
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x2A79400 Offset: 0x2A79501 VA: 0x2A79400
	public static Encoding get_Default() { }

	// RVA: 0x2A7B4D0 Offset: 0x2A7B5D1 VA: 0x2A7B4D0 Slot: 28
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetMaxByteCount(int charCount) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2A7B590 Offset: 0x2A7B691 VA: 0x2A7B590 Slot: 31
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x2A7B660 Offset: 0x2A7B761 VA: 0x2A7B660 Slot: 32
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x2A794E0 Offset: 0x2A795E1 VA: 0x2A794E0
	public static Encoding get_Unicode() { }

	// RVA: 0x2A79590 Offset: 0x2A79691 VA: 0x2A79590
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x2A79640 Offset: 0x2A79741 VA: 0x2A79640
	public static Encoding get_UTF7() { }

	// RVA: 0x2A79790 Offset: 0x2A79891 VA: 0x2A79790
	public static Encoding get_UTF8() { }

	// RVA: 0x2A796E0 Offset: 0x2A797E1 VA: 0x2A796E0
	public static Encoding get_UTF32() { }

	// RVA: 0x2A7B690 Offset: 0x2A7B791 VA: 0x2A7B690 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2A7B780 Offset: 0x2A7B881 VA: 0x2A7B780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A7B7E0 Offset: 0x2A7B8E1 VA: 0x2A7B7E0 Slot: 33
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x2A7B850 Offset: 0x2A7B951 VA: 0x2A7B850 Slot: 34
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x2A7B8C0 Offset: 0x2A7B9C1 VA: 0x2A7B8C0
	internal void ThrowBytesOverflow() { }

	// RVA: 0x2A72780 Offset: 0x2A72881 VA: 0x2A72780
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x2A7B9F0 Offset: 0x2A7BAF1 VA: 0x2A7B9F0
	internal void ThrowCharsOverflow() { }

	// RVA: 0x2A72F40 Offset: 0x2A73041 VA: 0x2A72F40
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }
}

[ComVisibleAttribute] // RVA: 0xAD140 Offset: 0xAD241 VA: 0xAD140
[Serializable]
public abstract class Encoding : ICloneable // TypeDefIndex: 465
{
	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Hashtable encodings; // 0x40
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalFieldAttribute] // RVA: 0xB4520 Offset: 0xB4621 VA: 0xB4520
	private bool m_isReadOnly; // 0x21
	[OptionalFieldAttribute] // RVA: 0xB4560 Offset: 0xB4661 VA: 0xB4560
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalFieldAttribute] // RVA: 0xB45A0 Offset: 0xB46A1 VA: 0xB45A0
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual string EncodingName { get; }
	[ComVisibleAttribute] // RVA: 0xBA080 Offset: 0xBA181 VA: 0xBA080
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA0A0 Offset: 0xBA1A1 VA: 0xBA0A0
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA0C0 Offset: 0xBA1C1 VA: 0xBA0C0
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x2A77E00 Offset: 0x2A77F01 VA: 0x2A77E00
	protected void .ctor() { }

	// RVA: 0x2A70470 Offset: 0x2A70571 VA: 0x2A70470
	protected void .ctor(int codePage) { }

	// RVA: 0x2A77E70 Offset: 0x2A77F71 VA: 0x2A77E70 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x2A77FD0 Offset: 0x2A780D1 VA: 0x2A77FD0
	internal void OnDeserializing() { }

	// RVA: 0x2A78010 Offset: 0x2A78111 VA: 0x2A78010
	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0xB7820 Offset: 0xB7921 VA: 0xB7820
	// RVA: 0x2A78060 Offset: 0x2A78161 VA: 0x2A78060
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7830 Offset: 0xB7931 VA: 0xB7830
	// RVA: 0x2A780A0 Offset: 0x2A781A1 VA: 0x2A780A0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0xB7840 Offset: 0xB7941 VA: 0xB7840
	// RVA: 0x2A780F0 Offset: 0x2A781F1 VA: 0x2A780F0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x2A78100 Offset: 0x2A78201 VA: 0x2A78100
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A784B0 Offset: 0x2A785B1 VA: 0x2A784B0
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A78600 Offset: 0x2A78701 VA: 0x2A78600
	private static object get_InternalSyncObject() { }

	// RVA: 0x2A786A0 Offset: 0x2A787A1 VA: 0x2A786A0
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x2A79FC0 Offset: 0x2A7A0C1 VA: 0x2A79FC0
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x2A7A190 Offset: 0x2A7A291 VA: 0x2A7A190 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x2A7A200 Offset: 0x2A7A301 VA: 0x2A7A200 Slot: 7
	public virtual string get_EncodingName() { }

	// RVA: 0x2A7A210 Offset: 0x2A7A311 VA: 0x2A7A210
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x2A7A220 Offset: 0x2A7A321 VA: 0x2A7A220
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x2A7A310 Offset: 0x2A7A411 VA: 0x2A7A310
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x2A7A320 Offset: 0x2A7A421 VA: 0x2A7A320
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0xB7850 Offset: 0xB7951 VA: 0xB7850
	// RVA: 0x2A7A410 Offset: 0x2A7A511 VA: 0x2A7A410 Slot: 8
	public virtual object Clone() { }

	// RVA: 0x2A7A4A0 Offset: 0x2A7A5A1 VA: 0x2A7A4A0
	public bool get_IsReadOnly() { }

	// RVA: 0x2A70310 Offset: 0x2A70411 VA: 0x2A70310
	public static Encoding get_ASCII() { }

	// RVA: 0x2A79840 Offset: 0x2A79941 VA: 0x2A79840
	private static Encoding get_Latin1() { }

	// RVA: 0x2A7A520 Offset: 0x2A7A621 VA: 0x2A7A520 Slot: 9
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int GetByteCount(char[] chars, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7870 Offset: 0xB7971 VA: 0xB7870
	[ComVisibleAttribute] // RVA: 0xB7870 Offset: 0xB7971 VA: 0xB7870
	// RVA: 0x2A7A5E0 Offset: 0x2A7A6E1 VA: 0x2A7A5E0 Slot: 11
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x2A7A750 Offset: 0x2A7A851 VA: 0x2A7A750 Slot: 12
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x2A7A760 Offset: 0x2A7A861 VA: 0x2A7A760 Slot: 13
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A7A820 Offset: 0x2A7A921 VA: 0x2A7A820 Slot: 15
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x2A7A920 Offset: 0x2A7AA21 VA: 0x2A7A920 Slot: 16
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A7AA00 Offset: 0x2A7AB01 VA: 0x2A7AA00 Slot: 17
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[ComVisibleAttribute] // RVA: 0xB78B0 Offset: 0xB79B1 VA: 0xB78B0
	[CLSCompliantAttribute] // RVA: 0xB78B0 Offset: 0xB79B1 VA: 0xB78B0
	// RVA: 0x2A7AA10 Offset: 0x2A7AB11 VA: 0x2A7AA10 Slot: 18
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB78F0 Offset: 0xB79F1 VA: 0xB78F0
	[ComVisibleAttribute] // RVA: 0xB78F0 Offset: 0xB79F1 VA: 0xB78F0
	// RVA: 0x2A7AC30 Offset: 0x2A7AD31 VA: 0x2A7AC30 Slot: 20
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2A7ADA0 Offset: 0x2A7AEA1 VA: 0x2A7ADA0 Slot: 21
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x2A7ADB0 Offset: 0x2A7AEB1 VA: 0x2A7ADB0 Slot: 22
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7930 Offset: 0xB7A31 VA: 0xB7930
	[CLSCompliantAttribute] // RVA: 0xB7930 Offset: 0xB7A31 VA: 0xB7930
	// RVA: 0x2A7AE70 Offset: 0x2A7AF71 VA: 0x2A7AE70 Slot: 24
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2A7B090 Offset: 0x2A7B191 VA: 0x2A7B090 Slot: 25
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[ComVisibleAttribute] // RVA: 0xB7970 Offset: 0xB7A71 VA: 0xB7970
	[CLSCompliantAttribute] // RVA: 0xB7970 Offset: 0xB7A71 VA: 0xB7970
	// RVA: 0x2A7B0A0 Offset: 0x2A7B1A1 VA: 0x2A7B0A0
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x2A7B1B0 Offset: 0x2A7B2B1 VA: 0x2A7B1B0 Slot: 26
	public virtual int get_CodePage() { }

	// RVA: 0x2A7B1C0 Offset: 0x2A7B2C1 VA: 0x2A7B1C0 Slot: 27
	public virtual Decoder GetDecoder() { }

	// RVA: 0x2A7B280 Offset: 0x2A7B381 VA: 0x2A7B280
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x2A7B4C0 Offset: 0x2A7B5C1 VA: 0x2A7B4C0
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x2A79400 Offset: 0x2A79501 VA: 0x2A79400
	public static Encoding get_Default() { }

	// RVA: 0x2A7B4D0 Offset: 0x2A7B5D1 VA: 0x2A7B4D0 Slot: 28
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetMaxByteCount(int charCount) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2A7B590 Offset: 0x2A7B691 VA: 0x2A7B590 Slot: 31
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x2A7B660 Offset: 0x2A7B761 VA: 0x2A7B660 Slot: 32
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x2A794E0 Offset: 0x2A795E1 VA: 0x2A794E0
	public static Encoding get_Unicode() { }

	// RVA: 0x2A79590 Offset: 0x2A79691 VA: 0x2A79590
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x2A79640 Offset: 0x2A79741 VA: 0x2A79640
	public static Encoding get_UTF7() { }

	// RVA: 0x2A79790 Offset: 0x2A79891 VA: 0x2A79790
	public static Encoding get_UTF8() { }

	// RVA: 0x2A796E0 Offset: 0x2A797E1 VA: 0x2A796E0
	public static Encoding get_UTF32() { }

	// RVA: 0x2A7B690 Offset: 0x2A7B791 VA: 0x2A7B690 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2A7B780 Offset: 0x2A7B881 VA: 0x2A7B780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A7B7E0 Offset: 0x2A7B8E1 VA: 0x2A7B7E0 Slot: 33
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x2A7B850 Offset: 0x2A7B951 VA: 0x2A7B850 Slot: 34
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x2A7B8C0 Offset: 0x2A7B9C1 VA: 0x2A7B8C0
	internal void ThrowBytesOverflow() { }

	// RVA: 0x2A72780 Offset: 0x2A72881 VA: 0x2A72780
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x2A7B9F0 Offset: 0x2A7BAF1 VA: 0x2A7B9F0
	internal void ThrowCharsOverflow() { }

	// RVA: 0x2A72F40 Offset: 0x2A73041 VA: 0x2A72F40
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }
}

[ComVisibleAttribute] // RVA: 0xAD140 Offset: 0xAD241 VA: 0xAD140
[Serializable]
public abstract class Encoding : ICloneable // TypeDefIndex: 465
{
	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Hashtable encodings; // 0x40
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalFieldAttribute] // RVA: 0xB4520 Offset: 0xB4621 VA: 0xB4520
	private bool m_isReadOnly; // 0x21
	[OptionalFieldAttribute] // RVA: 0xB4560 Offset: 0xB4661 VA: 0xB4560
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalFieldAttribute] // RVA: 0xB45A0 Offset: 0xB46A1 VA: 0xB45A0
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual string EncodingName { get; }
	[ComVisibleAttribute] // RVA: 0xBA080 Offset: 0xBA181 VA: 0xBA080
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA0A0 Offset: 0xBA1A1 VA: 0xBA0A0
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA0C0 Offset: 0xBA1C1 VA: 0xBA0C0
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x2A77E00 Offset: 0x2A77F01 VA: 0x2A77E00
	protected void .ctor() { }

	// RVA: 0x2A70470 Offset: 0x2A70571 VA: 0x2A70470
	protected void .ctor(int codePage) { }

	// RVA: 0x2A77E70 Offset: 0x2A77F71 VA: 0x2A77E70 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x2A77FD0 Offset: 0x2A780D1 VA: 0x2A77FD0
	internal void OnDeserializing() { }

	// RVA: 0x2A78010 Offset: 0x2A78111 VA: 0x2A78010
	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0xB7820 Offset: 0xB7921 VA: 0xB7820
	// RVA: 0x2A78060 Offset: 0x2A78161 VA: 0x2A78060
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7830 Offset: 0xB7931 VA: 0xB7830
	// RVA: 0x2A780A0 Offset: 0x2A781A1 VA: 0x2A780A0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0xB7840 Offset: 0xB7941 VA: 0xB7840
	// RVA: 0x2A780F0 Offset: 0x2A781F1 VA: 0x2A780F0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x2A78100 Offset: 0x2A78201 VA: 0x2A78100
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A784B0 Offset: 0x2A785B1 VA: 0x2A784B0
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A78600 Offset: 0x2A78701 VA: 0x2A78600
	private static object get_InternalSyncObject() { }

	// RVA: 0x2A786A0 Offset: 0x2A787A1 VA: 0x2A786A0
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x2A79FC0 Offset: 0x2A7A0C1 VA: 0x2A79FC0
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x2A7A190 Offset: 0x2A7A291 VA: 0x2A7A190 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x2A7A200 Offset: 0x2A7A301 VA: 0x2A7A200 Slot: 7
	public virtual string get_EncodingName() { }

	// RVA: 0x2A7A210 Offset: 0x2A7A311 VA: 0x2A7A210
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x2A7A220 Offset: 0x2A7A321 VA: 0x2A7A220
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x2A7A310 Offset: 0x2A7A411 VA: 0x2A7A310
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x2A7A320 Offset: 0x2A7A421 VA: 0x2A7A320
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0xB7850 Offset: 0xB7951 VA: 0xB7850
	// RVA: 0x2A7A410 Offset: 0x2A7A511 VA: 0x2A7A410 Slot: 8
	public virtual object Clone() { }

	// RVA: 0x2A7A4A0 Offset: 0x2A7A5A1 VA: 0x2A7A4A0
	public bool get_IsReadOnly() { }

	// RVA: 0x2A70310 Offset: 0x2A70411 VA: 0x2A70310
	public static Encoding get_ASCII() { }

	// RVA: 0x2A79840 Offset: 0x2A79941 VA: 0x2A79840
	private static Encoding get_Latin1() { }

	// RVA: 0x2A7A520 Offset: 0x2A7A621 VA: 0x2A7A520 Slot: 9
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int GetByteCount(char[] chars, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7870 Offset: 0xB7971 VA: 0xB7870
	[ComVisibleAttribute] // RVA: 0xB7870 Offset: 0xB7971 VA: 0xB7870
	// RVA: 0x2A7A5E0 Offset: 0x2A7A6E1 VA: 0x2A7A5E0 Slot: 11
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x2A7A750 Offset: 0x2A7A851 VA: 0x2A7A750 Slot: 12
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x2A7A760 Offset: 0x2A7A861 VA: 0x2A7A760 Slot: 13
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A7A820 Offset: 0x2A7A921 VA: 0x2A7A820 Slot: 15
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x2A7A920 Offset: 0x2A7AA21 VA: 0x2A7A920 Slot: 16
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A7AA00 Offset: 0x2A7AB01 VA: 0x2A7AA00 Slot: 17
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[ComVisibleAttribute] // RVA: 0xB78B0 Offset: 0xB79B1 VA: 0xB78B0
	[CLSCompliantAttribute] // RVA: 0xB78B0 Offset: 0xB79B1 VA: 0xB78B0
	// RVA: 0x2A7AA10 Offset: 0x2A7AB11 VA: 0x2A7AA10 Slot: 18
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB78F0 Offset: 0xB79F1 VA: 0xB78F0
	[ComVisibleAttribute] // RVA: 0xB78F0 Offset: 0xB79F1 VA: 0xB78F0
	// RVA: 0x2A7AC30 Offset: 0x2A7AD31 VA: 0x2A7AC30 Slot: 20
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2A7ADA0 Offset: 0x2A7AEA1 VA: 0x2A7ADA0 Slot: 21
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x2A7ADB0 Offset: 0x2A7AEB1 VA: 0x2A7ADB0 Slot: 22
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7930 Offset: 0xB7A31 VA: 0xB7930
	[CLSCompliantAttribute] // RVA: 0xB7930 Offset: 0xB7A31 VA: 0xB7930
	// RVA: 0x2A7AE70 Offset: 0x2A7AF71 VA: 0x2A7AE70 Slot: 24
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2A7B090 Offset: 0x2A7B191 VA: 0x2A7B090 Slot: 25
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[ComVisibleAttribute] // RVA: 0xB7970 Offset: 0xB7A71 VA: 0xB7970
	[CLSCompliantAttribute] // RVA: 0xB7970 Offset: 0xB7A71 VA: 0xB7970
	// RVA: 0x2A7B0A0 Offset: 0x2A7B1A1 VA: 0x2A7B0A0
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x2A7B1B0 Offset: 0x2A7B2B1 VA: 0x2A7B1B0 Slot: 26
	public virtual int get_CodePage() { }

	// RVA: 0x2A7B1C0 Offset: 0x2A7B2C1 VA: 0x2A7B1C0 Slot: 27
	public virtual Decoder GetDecoder() { }

	// RVA: 0x2A7B280 Offset: 0x2A7B381 VA: 0x2A7B280
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x2A7B4C0 Offset: 0x2A7B5C1 VA: 0x2A7B4C0
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x2A79400 Offset: 0x2A79501 VA: 0x2A79400
	public static Encoding get_Default() { }

	// RVA: 0x2A7B4D0 Offset: 0x2A7B5D1 VA: 0x2A7B4D0 Slot: 28
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetMaxByteCount(int charCount) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2A7B590 Offset: 0x2A7B691 VA: 0x2A7B590 Slot: 31
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x2A7B660 Offset: 0x2A7B761 VA: 0x2A7B660 Slot: 32
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x2A794E0 Offset: 0x2A795E1 VA: 0x2A794E0
	public static Encoding get_Unicode() { }

	// RVA: 0x2A79590 Offset: 0x2A79691 VA: 0x2A79590
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x2A79640 Offset: 0x2A79741 VA: 0x2A79640
	public static Encoding get_UTF7() { }

	// RVA: 0x2A79790 Offset: 0x2A79891 VA: 0x2A79790
	public static Encoding get_UTF8() { }

	// RVA: 0x2A796E0 Offset: 0x2A797E1 VA: 0x2A796E0
	public static Encoding get_UTF32() { }

	// RVA: 0x2A7B690 Offset: 0x2A7B791 VA: 0x2A7B690 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2A7B780 Offset: 0x2A7B881 VA: 0x2A7B780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A7B7E0 Offset: 0x2A7B8E1 VA: 0x2A7B7E0 Slot: 33
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x2A7B850 Offset: 0x2A7B951 VA: 0x2A7B850 Slot: 34
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x2A7B8C0 Offset: 0x2A7B9C1 VA: 0x2A7B8C0
	internal void ThrowBytesOverflow() { }

	// RVA: 0x2A72780 Offset: 0x2A72881 VA: 0x2A72780
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x2A7B9F0 Offset: 0x2A7BAF1 VA: 0x2A7B9F0
	internal void ThrowCharsOverflow() { }

	// RVA: 0x2A72F40 Offset: 0x2A73041 VA: 0x2A72F40
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }
}

[ComVisibleAttribute] // RVA: 0xAD140 Offset: 0xAD241 VA: 0xAD140
[Serializable]
public abstract class Encoding : ICloneable // TypeDefIndex: 465
{
	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Hashtable encodings; // 0x40
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalFieldAttribute] // RVA: 0xB4520 Offset: 0xB4621 VA: 0xB4520
	private bool m_isReadOnly; // 0x21
	[OptionalFieldAttribute] // RVA: 0xB4560 Offset: 0xB4661 VA: 0xB4560
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalFieldAttribute] // RVA: 0xB45A0 Offset: 0xB46A1 VA: 0xB45A0
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual string EncodingName { get; }
	[ComVisibleAttribute] // RVA: 0xBA080 Offset: 0xBA181 VA: 0xBA080
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA0A0 Offset: 0xBA1A1 VA: 0xBA0A0
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA0C0 Offset: 0xBA1C1 VA: 0xBA0C0
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x2A77E00 Offset: 0x2A77F01 VA: 0x2A77E00
	protected void .ctor() { }

	// RVA: 0x2A70470 Offset: 0x2A70571 VA: 0x2A70470
	protected void .ctor(int codePage) { }

	// RVA: 0x2A77E70 Offset: 0x2A77F71 VA: 0x2A77E70 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x2A77FD0 Offset: 0x2A780D1 VA: 0x2A77FD0
	internal void OnDeserializing() { }

	// RVA: 0x2A78010 Offset: 0x2A78111 VA: 0x2A78010
	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0xB7820 Offset: 0xB7921 VA: 0xB7820
	// RVA: 0x2A78060 Offset: 0x2A78161 VA: 0x2A78060
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7830 Offset: 0xB7931 VA: 0xB7830
	// RVA: 0x2A780A0 Offset: 0x2A781A1 VA: 0x2A780A0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0xB7840 Offset: 0xB7941 VA: 0xB7840
	// RVA: 0x2A780F0 Offset: 0x2A781F1 VA: 0x2A780F0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x2A78100 Offset: 0x2A78201 VA: 0x2A78100
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A784B0 Offset: 0x2A785B1 VA: 0x2A784B0
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A78600 Offset: 0x2A78701 VA: 0x2A78600
	private static object get_InternalSyncObject() { }

	// RVA: 0x2A786A0 Offset: 0x2A787A1 VA: 0x2A786A0
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x2A79FC0 Offset: 0x2A7A0C1 VA: 0x2A79FC0
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x2A7A190 Offset: 0x2A7A291 VA: 0x2A7A190 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x2A7A200 Offset: 0x2A7A301 VA: 0x2A7A200 Slot: 7
	public virtual string get_EncodingName() { }

	// RVA: 0x2A7A210 Offset: 0x2A7A311 VA: 0x2A7A210
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x2A7A220 Offset: 0x2A7A321 VA: 0x2A7A220
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x2A7A310 Offset: 0x2A7A411 VA: 0x2A7A310
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x2A7A320 Offset: 0x2A7A421 VA: 0x2A7A320
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0xB7850 Offset: 0xB7951 VA: 0xB7850
	// RVA: 0x2A7A410 Offset: 0x2A7A511 VA: 0x2A7A410 Slot: 8
	public virtual object Clone() { }

	// RVA: 0x2A7A4A0 Offset: 0x2A7A5A1 VA: 0x2A7A4A0
	public bool get_IsReadOnly() { }

	// RVA: 0x2A70310 Offset: 0x2A70411 VA: 0x2A70310
	public static Encoding get_ASCII() { }

	// RVA: 0x2A79840 Offset: 0x2A79941 VA: 0x2A79840
	private static Encoding get_Latin1() { }

	// RVA: 0x2A7A520 Offset: 0x2A7A621 VA: 0x2A7A520 Slot: 9
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int GetByteCount(char[] chars, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7870 Offset: 0xB7971 VA: 0xB7870
	[ComVisibleAttribute] // RVA: 0xB7870 Offset: 0xB7971 VA: 0xB7870
	// RVA: 0x2A7A5E0 Offset: 0x2A7A6E1 VA: 0x2A7A5E0 Slot: 11
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x2A7A750 Offset: 0x2A7A851 VA: 0x2A7A750 Slot: 12
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x2A7A760 Offset: 0x2A7A861 VA: 0x2A7A760 Slot: 13
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A7A820 Offset: 0x2A7A921 VA: 0x2A7A820 Slot: 15
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x2A7A920 Offset: 0x2A7AA21 VA: 0x2A7A920 Slot: 16
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A7AA00 Offset: 0x2A7AB01 VA: 0x2A7AA00 Slot: 17
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[ComVisibleAttribute] // RVA: 0xB78B0 Offset: 0xB79B1 VA: 0xB78B0
	[CLSCompliantAttribute] // RVA: 0xB78B0 Offset: 0xB79B1 VA: 0xB78B0
	// RVA: 0x2A7AA10 Offset: 0x2A7AB11 VA: 0x2A7AA10 Slot: 18
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB78F0 Offset: 0xB79F1 VA: 0xB78F0
	[ComVisibleAttribute] // RVA: 0xB78F0 Offset: 0xB79F1 VA: 0xB78F0
	// RVA: 0x2A7AC30 Offset: 0x2A7AD31 VA: 0x2A7AC30 Slot: 20
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2A7ADA0 Offset: 0x2A7AEA1 VA: 0x2A7ADA0 Slot: 21
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x2A7ADB0 Offset: 0x2A7AEB1 VA: 0x2A7ADB0 Slot: 22
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7930 Offset: 0xB7A31 VA: 0xB7930
	[CLSCompliantAttribute] // RVA: 0xB7930 Offset: 0xB7A31 VA: 0xB7930
	// RVA: 0x2A7AE70 Offset: 0x2A7AF71 VA: 0x2A7AE70 Slot: 24
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2A7B090 Offset: 0x2A7B191 VA: 0x2A7B090 Slot: 25
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[ComVisibleAttribute] // RVA: 0xB7970 Offset: 0xB7A71 VA: 0xB7970
	[CLSCompliantAttribute] // RVA: 0xB7970 Offset: 0xB7A71 VA: 0xB7970
	// RVA: 0x2A7B0A0 Offset: 0x2A7B1A1 VA: 0x2A7B0A0
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x2A7B1B0 Offset: 0x2A7B2B1 VA: 0x2A7B1B0 Slot: 26
	public virtual int get_CodePage() { }

	// RVA: 0x2A7B1C0 Offset: 0x2A7B2C1 VA: 0x2A7B1C0 Slot: 27
	public virtual Decoder GetDecoder() { }

	// RVA: 0x2A7B280 Offset: 0x2A7B381 VA: 0x2A7B280
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x2A7B4C0 Offset: 0x2A7B5C1 VA: 0x2A7B4C0
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x2A79400 Offset: 0x2A79501 VA: 0x2A79400
	public static Encoding get_Default() { }

	// RVA: 0x2A7B4D0 Offset: 0x2A7B5D1 VA: 0x2A7B4D0 Slot: 28
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetMaxByteCount(int charCount) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2A7B590 Offset: 0x2A7B691 VA: 0x2A7B590 Slot: 31
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x2A7B660 Offset: 0x2A7B761 VA: 0x2A7B660 Slot: 32
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x2A794E0 Offset: 0x2A795E1 VA: 0x2A794E0
	public static Encoding get_Unicode() { }

	// RVA: 0x2A79590 Offset: 0x2A79691 VA: 0x2A79590
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x2A79640 Offset: 0x2A79741 VA: 0x2A79640
	public static Encoding get_UTF7() { }

	// RVA: 0x2A79790 Offset: 0x2A79891 VA: 0x2A79790
	public static Encoding get_UTF8() { }

	// RVA: 0x2A796E0 Offset: 0x2A797E1 VA: 0x2A796E0
	public static Encoding get_UTF32() { }

	// RVA: 0x2A7B690 Offset: 0x2A7B791 VA: 0x2A7B690 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2A7B780 Offset: 0x2A7B881 VA: 0x2A7B780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A7B7E0 Offset: 0x2A7B8E1 VA: 0x2A7B7E0 Slot: 33
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x2A7B850 Offset: 0x2A7B951 VA: 0x2A7B850 Slot: 34
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x2A7B8C0 Offset: 0x2A7B9C1 VA: 0x2A7B8C0
	internal void ThrowBytesOverflow() { }

	// RVA: 0x2A72780 Offset: 0x2A72881 VA: 0x2A72780
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x2A7B9F0 Offset: 0x2A7BAF1 VA: 0x2A7B9F0
	internal void ThrowCharsOverflow() { }

	// RVA: 0x2A72F40 Offset: 0x2A73041 VA: 0x2A72F40
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }
}

[ComVisibleAttribute] // RVA: 0xAD140 Offset: 0xAD241 VA: 0xAD140
[Serializable]
public abstract class Encoding : ICloneable // TypeDefIndex: 465
{
	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Hashtable encodings; // 0x40
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalFieldAttribute] // RVA: 0xB4520 Offset: 0xB4621 VA: 0xB4520
	private bool m_isReadOnly; // 0x21
	[OptionalFieldAttribute] // RVA: 0xB4560 Offset: 0xB4661 VA: 0xB4560
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalFieldAttribute] // RVA: 0xB45A0 Offset: 0xB46A1 VA: 0xB45A0
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual string EncodingName { get; }
	[ComVisibleAttribute] // RVA: 0xBA080 Offset: 0xBA181 VA: 0xBA080
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA0A0 Offset: 0xBA1A1 VA: 0xBA0A0
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA0C0 Offset: 0xBA1C1 VA: 0xBA0C0
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x2A77E00 Offset: 0x2A77F01 VA: 0x2A77E00
	protected void .ctor() { }

	// RVA: 0x2A70470 Offset: 0x2A70571 VA: 0x2A70470
	protected void .ctor(int codePage) { }

	// RVA: 0x2A77E70 Offset: 0x2A77F71 VA: 0x2A77E70 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x2A77FD0 Offset: 0x2A780D1 VA: 0x2A77FD0
	internal void OnDeserializing() { }

	// RVA: 0x2A78010 Offset: 0x2A78111 VA: 0x2A78010
	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0xB7820 Offset: 0xB7921 VA: 0xB7820
	// RVA: 0x2A78060 Offset: 0x2A78161 VA: 0x2A78060
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB7830 Offset: 0xB7931 VA: 0xB7830
	// RVA: 0x2A780A0 Offset: 0x2A781A1 VA: 0x2A780A0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0xB7840 Offset: 0xB7941 VA: 0xB7840
	// RVA: 0x2A780F0 Offset: 0x2A781F1 VA: 0x2A780F0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x2A78100 Offset: 0x2A78201 VA: 0x2A78100
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A784B0 Offset: 0x2A785B1 VA: 0x2A784B0
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A78600 Offset: 0x2A78701 VA: 0x2A78600
	private static object get_InternalSyncObject() { }

	// RVA: 0x2A786A0 Offset: 0x2A787A1 VA: 0x2A786A0
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x2A79FC0 Offset: 0x2A7A0C1 VA: 0x2A79FC0
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x2A7A190 Offset: 0x2A7A291 VA: 0x2A7A190 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x2A7A200 Offset: 0x2A7A301 VA: 0x2A7A200 Slot: 7
	public virtual string get_EncodingName() { }

	// RVA: 0x2A7A210 Offset: 0x2A7A311 VA: 0x2A7A210
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x2A7A220 Offset: 0x2A7A321 VA: 0x2A7A220
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x2A7A310 Offset: 0x2A7A411 VA: 0x2A7A310
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x2A7A320 Offset: 0x2A7A421 VA: 0x2A7A320
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0xB7850 Offset: 0xB7951 VA: 0xB7850
	// RVA: 0x2A7A410 Offset: 0x2A7A511 VA: 0x2A7A410 Slot: 8
	public virtual object Clone() { }

	// RVA: 0x2A7A4A0 Offset: 0x2A7A5A1 VA: 0x2A7A4A0
	public bool get_IsReadOnly() { }

	// RVA: 0x2A70310 Offset: 0x2A70411 VA: 0x2A70310
	public static Encoding get_ASCII() { }

	// RVA: 0x2A79840 Offset: 0x2A79941 VA: 0x2A79840
	private static Encoding get_Latin1() { }

	// RVA: 0x2A7A520 Offset: 0x2A7A621 VA: 0x2A7A520 Slot: 9
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int GetByteCount(char[] chars, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB7870 Offset: 0xB7971 VA: 0xB7870
	[ComVisibleAttribute] // RVA: 0xB7870 Offset: 0xB7971 VA: 0xB7870
	// RVA: 0x2A7A5E0 Offset: 0x2A7A6E1 VA: 0x2A7A5E0 Slot: 11
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x2A7A750 Offset: 0x2A7A851 VA: 0x2A7A750 Slot: 12
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x2A7A760 Offset: 0x2A7A861 VA: 0x2A7A760 Slot: 13
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A7A820 Offset: 0x2A7A921 VA: 0x2A7A820 Slot: 15
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x2A7A920 Offset: 0x2A7AA21 VA: 0x2A7A920 Slot: 16
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x2A7AA00 Offset: 0x2A7AB01 VA: 0x2A7AA00 Slot: 17
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[ComVisibleAttribute] // RVA: 0xB78B0 Offset: 0xB79B1 VA: 0xB78B0
	[CLSCompliantAttribute] // RVA: 0xB78B0 Offset: 0xB79B1 VA: 0xB78B0
	// RVA: 0x2A7AA10 Offset: 0x2A7AB11 VA: 0x2A7AA10 Slot: 18
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0xB78F0 Offset: 0xB79F1 VA: 0xB78F0
	[ComVisibleAttribute] // RVA: 0xB78F0 Offset: 0xB79F1 VA: 0xB78F0
	// RVA: 0x2A7AC30 Offset: 0x2A7AD31 VA: 0x2A7AC30 Slot: 20
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x2A7ADA0 Offset: 0x2A7AEA1 VA: 0x2A7ADA0 Slot: 21
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x2A7ADB0 Offset: 0x2A7AEB1 VA: 0x2A7ADB0 Slot: 22
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0xB7930 Offset: 0xB7A31 VA: 0xB7930
	[CLSCompliantAttribute] // RVA: 0xB7930 Offset: 0xB7A31 VA: 0xB7930
	// RVA: 0x2A7AE70 Offset: 0x2A7AF71 VA: 0x2A7AE70 Slot: 24
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x2A7B090 Offset: 0x2A7B191 VA: 0x2A7B090 Slot: 25
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[ComVisibleAttribute] // RVA: 0xB7970 Offset: 0xB7A71 VA: 0xB7970
	[CLSCompliantAttribute] // RVA: 0xB7970 Offset: 0xB7A71 VA: 0xB7970
	// RVA: 0x2A7B0A0 Offset: 0x2A7B1A1 VA: 0x2A7B0A0
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x2A7B1B0 Offset: 0x2A7B2B1 VA: 0x2A7B1B0 Slot: 26
	public virtual int get_CodePage() { }

	// RVA: 0x2A7B1C0 Offset: 0x2A7B2C1 VA: 0x2A7B1C0 Slot: 27
	public virtual Decoder GetDecoder() { }

	// RVA: 0x2A7B280 Offset: 0x2A7B381 VA: 0x2A7B280
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x2A7B4C0 Offset: 0x2A7B5C1 VA: 0x2A7B4C0
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x2A79400 Offset: 0x2A79501 VA: 0x2A79400
	public static Encoding get_Default() { }

	// RVA: 0x2A7B4D0 Offset: 0x2A7B5D1 VA: 0x2A7B4D0 Slot: 28
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetMaxByteCount(int charCount) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2A7B590 Offset: 0x2A7B691 VA: 0x2A7B590 Slot: 31
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x2A7B660 Offset: 0x2A7B761 VA: 0x2A7B660 Slot: 32
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x2A794E0 Offset: 0x2A795E1 VA: 0x2A794E0
	public static Encoding get_Unicode() { }

	// RVA: 0x2A79590 Offset: 0x2A79691 VA: 0x2A79590
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x2A79640 Offset: 0x2A79741 VA: 0x2A79640
	public static Encoding get_UTF7() { }

	// RVA: 0x2A79790 Offset: 0x2A79891 VA: 0x2A79790
	public static Encoding get_UTF8() { }

	// RVA: 0x2A796E0 Offset: 0x2A797E1 VA: 0x2A796E0
	public static Encoding get_UTF32() { }

	// RVA: 0x2A7B690 Offset: 0x2A7B791 VA: 0x2A7B690 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2A7B780 Offset: 0x2A7B881 VA: 0x2A7B780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A7B7E0 Offset: 0x2A7B8E1 VA: 0x2A7B7E0 Slot: 33
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x2A7B850 Offset: 0x2A7B951 VA: 0x2A7B850 Slot: 34
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x2A7B8C0 Offset: 0x2A7B9C1 VA: 0x2A7B8C0
	internal void ThrowBytesOverflow() { }

	// RVA: 0x2A72780 Offset: 0x2A72881 VA: 0x2A72780
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x2A7B9F0 Offset: 0x2A7BAF1 VA: 0x2A7B9F0
	internal void ThrowCharsOverflow() { }

	// RVA: 0x2A72F40 Offset: 0x2A73041 VA: 0x2A72F40
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }
}

