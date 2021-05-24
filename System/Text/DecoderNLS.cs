[Serializable]
internal class DecoderNLS : Decoder, ISerializable // TypeDefIndex: 451
{
	// Fields
	protected Encoding m_encoding; // 0x20
	protected bool m_mustFlush; // 0x28
	internal bool m_throwOnOverflow; // 0x29
	internal int m_bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x2A74890 Offset: 0x2A74991 VA: 0x2A74890
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A74970 Offset: 0x2A74A71 VA: 0x2A74970 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A73290 Offset: 0x2A73391 VA: 0x2A73290
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x2A74A80 Offset: 0x2A74B81 VA: 0x2A74A80
	internal void .ctor() { }

	// RVA: 0x2A74AC0 Offset: 0x2A74BC1 VA: 0x2A74AC0 Slot: 4
	public override void Reset() { }

	// RVA: 0x2A74AE0 Offset: 0x2A74BE1 VA: 0x2A74AE0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2A74AF0 Offset: 0x2A74BF1 VA: 0x2A74AF0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x2A74CD0 Offset: 0x2A74DD1 VA: 0x2A74CD0 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x2A74E10 Offset: 0x2A74F11 VA: 0x2A74E10 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2A74E20 Offset: 0x2A74F21 VA: 0x2A74E20 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x2A750C0 Offset: 0x2A751C1 VA: 0x2A750C0 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x2A75240 Offset: 0x2A75341 VA: 0x2A75240
	public bool get_MustFlush() { }

	// RVA: 0x2A75250 Offset: 0x2A75351 VA: 0x2A75250 Slot: 12
	internal virtual bool get_HasState() { }

	// RVA: 0x2A75260 Offset: 0x2A75361 VA: 0x2A75260
	internal void ClearMustFlush() { }
}

[Serializable]
internal class DecoderNLS : Decoder, ISerializable // TypeDefIndex: 451
{
	// Fields
	protected Encoding m_encoding; // 0x20
	protected bool m_mustFlush; // 0x28
	internal bool m_throwOnOverflow; // 0x29
	internal int m_bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x2A74890 Offset: 0x2A74991 VA: 0x2A74890
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A74970 Offset: 0x2A74A71 VA: 0x2A74970 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A73290 Offset: 0x2A73391 VA: 0x2A73290
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x2A74A80 Offset: 0x2A74B81 VA: 0x2A74A80
	internal void .ctor() { }

	// RVA: 0x2A74AC0 Offset: 0x2A74BC1 VA: 0x2A74AC0 Slot: 4
	public override void Reset() { }

	// RVA: 0x2A74AE0 Offset: 0x2A74BE1 VA: 0x2A74AE0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2A74AF0 Offset: 0x2A74BF1 VA: 0x2A74AF0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x2A74CD0 Offset: 0x2A74DD1 VA: 0x2A74CD0 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x2A74E10 Offset: 0x2A74F11 VA: 0x2A74E10 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2A74E20 Offset: 0x2A74F21 VA: 0x2A74E20 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x2A750C0 Offset: 0x2A751C1 VA: 0x2A750C0 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x2A75240 Offset: 0x2A75341 VA: 0x2A75240
	public bool get_MustFlush() { }

	// RVA: 0x2A75250 Offset: 0x2A75351 VA: 0x2A75250 Slot: 12
	internal virtual bool get_HasState() { }

	// RVA: 0x2A75260 Offset: 0x2A75361 VA: 0x2A75260
	internal void ClearMustFlush() { }
}

[Serializable]
internal class DecoderNLS : Decoder, ISerializable // TypeDefIndex: 451
{
	// Fields
	protected Encoding m_encoding; // 0x20
	protected bool m_mustFlush; // 0x28
	internal bool m_throwOnOverflow; // 0x29
	internal int m_bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x2A74890 Offset: 0x2A74991 VA: 0x2A74890
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A74970 Offset: 0x2A74A71 VA: 0x2A74970 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A73290 Offset: 0x2A73391 VA: 0x2A73290
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x2A74A80 Offset: 0x2A74B81 VA: 0x2A74A80
	internal void .ctor() { }

	// RVA: 0x2A74AC0 Offset: 0x2A74BC1 VA: 0x2A74AC0 Slot: 4
	public override void Reset() { }

	// RVA: 0x2A74AE0 Offset: 0x2A74BE1 VA: 0x2A74AE0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2A74AF0 Offset: 0x2A74BF1 VA: 0x2A74AF0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x2A74CD0 Offset: 0x2A74DD1 VA: 0x2A74CD0 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x2A74E10 Offset: 0x2A74F11 VA: 0x2A74E10 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2A74E20 Offset: 0x2A74F21 VA: 0x2A74E20 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x2A750C0 Offset: 0x2A751C1 VA: 0x2A750C0 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x2A75240 Offset: 0x2A75341 VA: 0x2A75240
	public bool get_MustFlush() { }

	// RVA: 0x2A75250 Offset: 0x2A75351 VA: 0x2A75250 Slot: 12
	internal virtual bool get_HasState() { }

	// RVA: 0x2A75260 Offset: 0x2A75361 VA: 0x2A75260
	internal void ClearMustFlush() { }
}

[Serializable]
internal class DecoderNLS : Decoder, ISerializable // TypeDefIndex: 451
{
	// Fields
	protected Encoding m_encoding; // 0x20
	protected bool m_mustFlush; // 0x28
	internal bool m_throwOnOverflow; // 0x29
	internal int m_bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x2A74890 Offset: 0x2A74991 VA: 0x2A74890
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A74970 Offset: 0x2A74A71 VA: 0x2A74970 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A73290 Offset: 0x2A73391 VA: 0x2A73290
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x2A74A80 Offset: 0x2A74B81 VA: 0x2A74A80
	internal void .ctor() { }

	// RVA: 0x2A74AC0 Offset: 0x2A74BC1 VA: 0x2A74AC0 Slot: 4
	public override void Reset() { }

	// RVA: 0x2A74AE0 Offset: 0x2A74BE1 VA: 0x2A74AE0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2A74AF0 Offset: 0x2A74BF1 VA: 0x2A74AF0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x2A74CD0 Offset: 0x2A74DD1 VA: 0x2A74CD0 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x2A74E10 Offset: 0x2A74F11 VA: 0x2A74E10 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2A74E20 Offset: 0x2A74F21 VA: 0x2A74E20 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x2A750C0 Offset: 0x2A751C1 VA: 0x2A750C0 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x2A75240 Offset: 0x2A75341 VA: 0x2A75240
	public bool get_MustFlush() { }

	// RVA: 0x2A75250 Offset: 0x2A75351 VA: 0x2A75250 Slot: 12
	internal virtual bool get_HasState() { }

	// RVA: 0x2A75260 Offset: 0x2A75361 VA: 0x2A75260
	internal void ClearMustFlush() { }
}

[Serializable]
internal class DecoderNLS : Decoder, ISerializable // TypeDefIndex: 451
{
	// Fields
	protected Encoding m_encoding; // 0x20
	protected bool m_mustFlush; // 0x28
	internal bool m_throwOnOverflow; // 0x29
	internal int m_bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x2A74890 Offset: 0x2A74991 VA: 0x2A74890
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A74970 Offset: 0x2A74A71 VA: 0x2A74970 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A73290 Offset: 0x2A73391 VA: 0x2A73290
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x2A74A80 Offset: 0x2A74B81 VA: 0x2A74A80
	internal void .ctor() { }

	// RVA: 0x2A74AC0 Offset: 0x2A74BC1 VA: 0x2A74AC0 Slot: 4
	public override void Reset() { }

	// RVA: 0x2A74AE0 Offset: 0x2A74BE1 VA: 0x2A74AE0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2A74AF0 Offset: 0x2A74BF1 VA: 0x2A74AF0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x2A74CD0 Offset: 0x2A74DD1 VA: 0x2A74CD0 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x2A74E10 Offset: 0x2A74F11 VA: 0x2A74E10 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2A74E20 Offset: 0x2A74F21 VA: 0x2A74E20 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x2A750C0 Offset: 0x2A751C1 VA: 0x2A750C0 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x2A75240 Offset: 0x2A75341 VA: 0x2A75240
	public bool get_MustFlush() { }

	// RVA: 0x2A75250 Offset: 0x2A75351 VA: 0x2A75250 Slot: 12
	internal virtual bool get_HasState() { }

	// RVA: 0x2A75260 Offset: 0x2A75361 VA: 0x2A75260
	internal void ClearMustFlush() { }
}

[Serializable]
internal class DecoderNLS : Decoder, ISerializable // TypeDefIndex: 451
{
	// Fields
	protected Encoding m_encoding; // 0x20
	protected bool m_mustFlush; // 0x28
	internal bool m_throwOnOverflow; // 0x29
	internal int m_bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x2A74890 Offset: 0x2A74991 VA: 0x2A74890
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A74970 Offset: 0x2A74A71 VA: 0x2A74970 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A73290 Offset: 0x2A73391 VA: 0x2A73290
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x2A74A80 Offset: 0x2A74B81 VA: 0x2A74A80
	internal void .ctor() { }

	// RVA: 0x2A74AC0 Offset: 0x2A74BC1 VA: 0x2A74AC0 Slot: 4
	public override void Reset() { }

	// RVA: 0x2A74AE0 Offset: 0x2A74BE1 VA: 0x2A74AE0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2A74AF0 Offset: 0x2A74BF1 VA: 0x2A74AF0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x2A74CD0 Offset: 0x2A74DD1 VA: 0x2A74CD0 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x2A74E10 Offset: 0x2A74F11 VA: 0x2A74E10 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2A74E20 Offset: 0x2A74F21 VA: 0x2A74E20 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x2A750C0 Offset: 0x2A751C1 VA: 0x2A750C0 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x2A75240 Offset: 0x2A75341 VA: 0x2A75240
	public bool get_MustFlush() { }

	// RVA: 0x2A75250 Offset: 0x2A75351 VA: 0x2A75250 Slot: 12
	internal virtual bool get_HasState() { }

	// RVA: 0x2A75260 Offset: 0x2A75361 VA: 0x2A75260
	internal void ClearMustFlush() { }
}

