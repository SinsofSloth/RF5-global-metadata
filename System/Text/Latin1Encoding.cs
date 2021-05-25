[Serializable]
internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 472
{
	// Fields
	private static readonly char[] arrayCharBestFit; // 0x0

	// Methods

	// RVA: 0x2A7A4B0 Offset: 0x2A7A5B1 VA: 0x2A7A4B0
	public void .ctor() { }

	// RVA: 0x2A7F650 Offset: 0x2A7F751 VA: 0x2A7F650
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A7F6D0 Offset: 0x2A7F7D1 VA: 0x2A7F6D0 Slot: 35
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A7F7A0 Offset: 0x2A7F8A1 VA: 0x2A7F7A0 Slot: 12
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x2A7FA80 Offset: 0x2A7FB81 VA: 0x2A7FA80 Slot: 17
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x2A7FF90 Offset: 0x2A80091 VA: 0x2A7FF90 Slot: 21
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x2A7FFA0 Offset: 0x2A800A1 VA: 0x2A7FFA0 Slot: 25
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x2A80080 Offset: 0x2A80181 VA: 0x2A80080 Slot: 29
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x2A80190 Offset: 0x2A80291 VA: 0x2A80190 Slot: 30
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x2A802A0 Offset: 0x2A803A1 VA: 0x2A802A0 Slot: 33
	internal override char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x2A80310 Offset: 0x2A80411 VA: 0x2A80310
	private static void .cctor() { }
}

