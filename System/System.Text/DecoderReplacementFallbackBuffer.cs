public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 453
{
	// Fields
	private string strDefault; // 0x20
	private int fallbackCount; // 0x28
	private int fallbackIndex; // 0x2C

	// Methods

	// RVA: 0x2A754F0 Offset: 0x2A755F1 VA: 0x2A754F0
	public void .ctor(DecoderReplacementFallback fallback) { }

	// RVA: 0x2A75620 Offset: 0x2A75721 VA: 0x2A75620 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x2A75670 Offset: 0x2A75771 VA: 0x2A75670 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x2A756C0 Offset: 0x2A757C1 VA: 0x2A756C0 Slot: 6
	public override void Reset() { }

	// RVA: 0x2A756D0 Offset: 0x2A757D1 VA: 0x2A756D0 Slot: 8
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }
}

