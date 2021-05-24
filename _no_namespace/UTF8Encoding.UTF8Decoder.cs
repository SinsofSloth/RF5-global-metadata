[Serializable]
internal class UTF8Encoding.UTF8Decoder : DecoderNLS, ISerializable // TypeDefIndex: 486
{
	// Fields
	internal int bits; // 0x30

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1A05220 Offset: 0x1A05321 VA: 0x1A05220
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x1A056F0 Offset: 0x1A057F1 VA: 0x1A056F0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A05A10 Offset: 0x1A05B11 VA: 0x1A05A10 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A05B60 Offset: 0x1A05C61 VA: 0x1A05B60 Slot: 4
	public override void Reset() { }

	// RVA: 0x1A05B80 Offset: 0x1A05C81 VA: 0x1A05B80 Slot: 12
	internal override bool get_HasState() { }
}

