[Serializable]
public abstract class EncoderFallback // TypeDefIndex: 460
{
	// Fields
	internal bool bIsMicrosoftBestFitFallback; // 0x10
	private static EncoderFallback replacementFallback; // 0x0
	private static EncoderFallback exceptionFallback; // 0x8
	private static object s_InternalSyncObject; // 0x10

	// Properties
	private static object InternalSyncObject { get; }
	public static EncoderFallback ReplacementFallback { get; }
	public static EncoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x2A764F0 Offset: 0x2A765F1 VA: 0x2A764F0
	private static object get_InternalSyncObject() { }

	// RVA: 0x2A70560 Offset: 0x2A70661 VA: 0x2A70560
	public static EncoderFallback get_ReplacementFallback() { }

	// RVA: 0x2A765E0 Offset: 0x2A766E1 VA: 0x2A765E0
	public static EncoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount() { }

	// RVA: 0x2A75C10 Offset: 0x2A75D11 VA: 0x2A75C10
	protected void .ctor() { }
}

