internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 456
{
	// Fields
	private char cBestFit; // 0x30
	private InternalEncoderBestFitFallback oFallback; // 0x38
	private int iCount; // 0x40
	private int iSize; // 0x44
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x2A7F140 Offset: 0x2A7F241 VA: 0x2A7F140
	private static object get_InternalSyncObject() { }

	// RVA: 0x2A7EE30 Offset: 0x2A7EF31 VA: 0x2A7EE30
	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	// RVA: 0x2A7F1E0 Offset: 0x2A7F2E1 VA: 0x2A7F1E0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x2A7F310 Offset: 0x2A7F411 VA: 0x2A7F310 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x2A7F5A0 Offset: 0x2A7F6A1 VA: 0x2A7F5A0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x2A7F5E0 Offset: 0x2A7F6E1 VA: 0x2A7F5E0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x2A7F620 Offset: 0x2A7F721 VA: 0x2A7F620 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x2A7F630 Offset: 0x2A7F731 VA: 0x2A7F630 Slot: 9
	public override void Reset() { }

	// RVA: 0x2A7F220 Offset: 0x2A7F321 VA: 0x2A7F220
	private char TryBestFit(char cUnknown) { }
}

