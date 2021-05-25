internal sealed class UTF7Encoding.DecoderUTF7FallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 483
{
	// Fields
	private char cFallback; // 0x20
	private int iCount; // 0x24
	private int iSize; // 0x28

	// Methods

	// RVA: 0x1A018A0 Offset: 0x1A019A1 VA: 0x1A018A0
	public void .ctor(UTF7Encoding.DecoderUTF7Fallback fallback) { }

	// RVA: 0x1A01940 Offset: 0x1A01A41 VA: 0x1A01940 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x1A01990 Offset: 0x1A01A91 VA: 0x1A01990 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x1A019B0 Offset: 0x1A01AB1 VA: 0x1A019B0 Slot: 6
	public override void Reset() { }

	// RVA: 0x1A019C0 Offset: 0x1A01AC1 VA: 0x1A019C0 Slot: 8
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }
}

