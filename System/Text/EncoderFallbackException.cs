[Serializable]
public sealed class EncoderFallbackException : ArgumentException // TypeDefIndex: 459
{
	// Fields
	private char charUnknown; // 0x90
	private char charUnknownHigh; // 0x92
	private char charUnknownLow; // 0x94
	private int index; // 0x98

	// Methods

	// RVA: 0x2A76AE0 Offset: 0x2A76BE1 VA: 0x2A76AE0
	public void .ctor() { }

	// RVA: 0x2A76B60 Offset: 0x2A76C61 VA: 0x2A76B60
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2A75E60 Offset: 0x2A75F61 VA: 0x2A75E60
	internal void .ctor(string message, char charUnknown, int index) { }

	// RVA: 0x2A76220 Offset: 0x2A76321 VA: 0x2A76220
	internal void .ctor(string message, char charUnknownHigh, char charUnknownLow, int index) { }
}

