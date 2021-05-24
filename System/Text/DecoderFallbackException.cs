[Serializable]
public sealed class DecoderFallbackException : ArgumentException // TypeDefIndex: 448
{
	// Fields
	private byte[] bytesUnknown; // 0x90
	private int index; // 0x98

	// Methods

	// RVA: 0x2A74800 Offset: 0x2A74901 VA: 0x2A74800
	public void .ctor() { }

	// RVA: 0x2A74880 Offset: 0x2A74981 VA: 0x2A74880
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A73EB0 Offset: 0x2A73FB1 VA: 0x2A73EB0
	public void .ctor(string message, byte[] bytesUnknown, int index) { }
}

