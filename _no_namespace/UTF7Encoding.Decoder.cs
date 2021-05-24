[Serializable]
private class UTF7Encoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 480
{
	// Fields
	internal int bits; // 0x30
	internal int bitCount; // 0x34
	internal bool firstByte; // 0x38

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1A01290 Offset: 0x1A01391 VA: 0x1A01290
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x1A01490 Offset: 0x1A01591 VA: 0x1A01490
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A016F0 Offset: 0x1A017F1 VA: 0x1A016F0 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A017F0 Offset: 0x1A018F1 VA: 0x1A017F0 Slot: 4
	public override void Reset() { }

	// RVA: 0x1A01820 Offset: 0x1A01921 VA: 0x1A01820 Slot: 12
	internal override bool get_HasState() { }
}

