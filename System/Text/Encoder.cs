[ComVisibleAttribute] // RVA: 0xAD120 Offset: 0xAD221 VA: 0xAD120
[Serializable]
public abstract class Encoder // TypeDefIndex: 454
{
	// Fields
	internal EncoderFallback m_fallback; // 0x10
	internal EncoderFallbackBuffer m_fallbackBuffer; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA040 Offset: 0xBA141 VA: 0xBA040
	public EncoderFallback Fallback { get; }
	[ComVisibleAttribute] // RVA: 0xBA060 Offset: 0xBA161 VA: 0xBA060
	public EncoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x2A756F0 Offset: 0x2A757F1 VA: 0x2A756F0
	internal void SerializeEncoder(SerializationInfo info) { }

	// RVA: 0x2A75760 Offset: 0x2A75861 VA: 0x2A75760
	protected void .ctor() { }

	// RVA: 0x2A75770 Offset: 0x2A75871 VA: 0x2A75770
	public EncoderFallback get_Fallback() { }

	// RVA: 0x2A72070 Offset: 0x2A72171 VA: 0x2A72070
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x2A72060 Offset: 0x2A72161 VA: 0x2A72060
	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0xB7780 Offset: 0xB7881 VA: 0xB7780
	// RVA: 0x2A75780 Offset: 0x2A75881 VA: 0x2A75780 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush) { }

	[CLSCompliantAttribute] // RVA: 0xB77A0 Offset: 0xB78A1 VA: 0xB77A0
	[ComVisibleAttribute] // RVA: 0xB77A0 Offset: 0xB78A1 VA: 0xB77A0
	// RVA: 0x2A75850 Offset: 0x2A75951 VA: 0x2A75850 Slot: 6
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	[ComVisibleAttribute] // RVA: 0xB77E0 Offset: 0xB78E1 VA: 0xB77E0
	[CLSCompliantAttribute] // RVA: 0xB77E0 Offset: 0xB78E1 VA: 0xB77E0
	// RVA: 0x2A759D0 Offset: 0x2A75AD1 VA: 0x2A759D0 Slot: 8
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }
}

