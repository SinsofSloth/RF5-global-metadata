[Serializable]
internal class Encoding.DefaultDecoder : Decoder, ISerializable, IObjectReference // TypeDefIndex: 467
{
	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28

	// Methods

	// RVA: 0x2A7B240 Offset: 0x2A7B341 VA: 0x2A7B240
	public void .ctor(Encoding encoding) { }

	// RVA: 0x2A7BB20 Offset: 0x2A7BC21 VA: 0x2A7BB20
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A7BDB0 Offset: 0x2A7BEB1 VA: 0x2A7BDB0 Slot: 12
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x2A7BE30 Offset: 0x2A7BF31 VA: 0x2A7BE30 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A7BEE0 Offset: 0x2A7BFE1 VA: 0x2A7BEE0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2A7BEF0 Offset: 0x2A7BFF1 VA: 0x2A7BEF0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x2A7BF20 Offset: 0x2A7C021 VA: 0x2A7BF20 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x2A7BF50 Offset: 0x2A7C051 VA: 0x2A7BF50 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2A7BF60 Offset: 0x2A7C061 VA: 0x2A7BF60 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x2A7BF90 Offset: 0x2A7C091 VA: 0x2A7BF90 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }
}

