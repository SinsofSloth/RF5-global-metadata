[Serializable]
internal class Encoding.DefaultEncoder : Encoder, ISerializable, IObjectReference // TypeDefIndex: 466
{
	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28
	internal char charLeftOver; // 0x2A

	// Methods

	// RVA: 0x2A7B550 Offset: 0x2A7B651 VA: 0x2A7B550
	public void .ctor(Encoding encoding) { }

	// RVA: 0x2A7BFC0 Offset: 0x2A7C0C1 VA: 0x2A7BFC0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A7C2C0 Offset: 0x2A7C3C1 VA: 0x2A7C2C0 Slot: 10
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x2A7C3A0 Offset: 0x2A7C4A1 VA: 0x2A7C3A0 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A7C450 Offset: 0x2A7C551 VA: 0x2A7C450 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x2A7C470 Offset: 0x2A7C571 VA: 0x2A7C470 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x2A7C490 Offset: 0x2A7C591 VA: 0x2A7C490 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x2A7C4C0 Offset: 0x2A7C5C1 VA: 0x2A7C4C0 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }
}

