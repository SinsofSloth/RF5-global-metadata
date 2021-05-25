[Serializable]
private class UnicodeEncoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 476
{
	// Fields
	internal int lastByte; // 0x30
	internal char lastChar; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1A09750 Offset: 0x1A09851 VA: 0x1A09750
	public void .ctor(UnicodeEncoding encoding) { }

	// RVA: 0x1A09D10 Offset: 0x1A09E11 VA: 0x1A09D10
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A0A170 Offset: 0x1A0A271 VA: 0x1A0A170 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A0A2D0 Offset: 0x1A0A3D1 VA: 0x1A0A2D0 Slot: 4
	public override void Reset() { }

	// RVA: 0x1A0A300 Offset: 0x1A0A401 VA: 0x1A0A300 Slot: 12
	internal override bool get_HasState() { }
}

