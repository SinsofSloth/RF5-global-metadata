[Serializable]
internal class EncoderNLS : Encoder, ISerializable // TypeDefIndex: 462
{
	// Fields
	internal char charLeftOver; // 0x20
	protected Encoding m_encoding; // 0x28
	protected bool m_mustFlush; // 0x30
	internal bool m_throwOnOverflow; // 0x31
	internal int m_charsUsed; // 0x34

	// Properties
	public Encoding Encoding { get; }
	public bool MustFlush { get; }

	// Methods

	// RVA: 0x2A76B70 Offset: 0x2A76C71 VA: 0x2A76B70
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A76C50 Offset: 0x2A76D51 VA: 0x2A76C50 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A733B0 Offset: 0x2A734B1 VA: 0x2A733B0
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x2A76D70 Offset: 0x2A76E71 VA: 0x2A76D70
	internal void .ctor() { }

	// RVA: 0x2A76DB0 Offset: 0x2A76EB1 VA: 0x2A76DB0 Slot: 4
	public override void Reset() { }

	// RVA: 0x2A76DD0 Offset: 0x2A76ED1 VA: 0x2A76DD0 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x2A76FB0 Offset: 0x2A770B1 VA: 0x2A76FB0 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x2A770F0 Offset: 0x2A771F1 VA: 0x2A770F0 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x2A77390 Offset: 0x2A77491 VA: 0x2A77390 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x2A77510 Offset: 0x2A77611 VA: 0x2A77510
	public Encoding get_Encoding() { }

	// RVA: 0x2A77520 Offset: 0x2A77621 VA: 0x2A77520
	public bool get_MustFlush() { }

	// RVA: 0x2A77530 Offset: 0x2A77631 VA: 0x2A77530
	internal void ClearMustFlush() { }
}

