public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 464
{
	// Fields
	private string strDefault; // 0x30
	private int fallbackCount; // 0x38
	private int fallbackIndex; // 0x3C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x2A777D0 Offset: 0x2A778D1 VA: 0x2A777D0
	public void .ctor(EncoderReplacementFallback fallback) { }

	// RVA: 0x2A77910 Offset: 0x2A77A11 VA: 0x2A77910 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x2A77A70 Offset: 0x2A77B71 VA: 0x2A77A70 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x2A77D40 Offset: 0x2A77E41 VA: 0x2A77D40 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x2A77D90 Offset: 0x2A77E91 VA: 0x2A77D90 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x2A77DD0 Offset: 0x2A77ED1 VA: 0x2A77DD0 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x2A77DE0 Offset: 0x2A77EE1 VA: 0x2A77DE0 Slot: 9
	public override void Reset() { }
}

