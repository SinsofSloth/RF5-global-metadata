[ComVisibleAttribute] // RVA: 0xAD100 Offset: 0xAD201 VA: 0xAD100
[Serializable]
public abstract class Decoder // TypeDefIndex: 443
{
	// Fields
	internal DecoderFallback m_fallback; // 0x10
	internal DecoderFallbackBuffer m_fallbackBuffer; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA000 Offset: 0xBA101 VA: 0xBA000
	public DecoderFallback Fallback { get; }
	[ComVisibleAttribute] // RVA: 0xBA020 Offset: 0xBA121 VA: 0xBA020
	public DecoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x2A73420 Offset: 0x2A73521 VA: 0x2A73420
	internal void SerializeDecoder(SerializationInfo info) { }

	// RVA: 0x2A73490 Offset: 0x2A73591 VA: 0x2A73490
	protected void .ctor() { }

	// RVA: 0x2A734A0 Offset: 0x2A735A1 VA: 0x2A734A0
	public DecoderFallback get_Fallback() { }

	// RVA: 0x2A72A10 Offset: 0x2A72B11 VA: 0x2A72A10
	public DecoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x2A734B0 Offset: 0x2A735B1 VA: 0x2A734B0
	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0xB76C0 Offset: 0xB77C1 VA: 0xB76C0
	// RVA: 0x2A734C0 Offset: 0x2A735C1 VA: 0x2A734C0 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0xB76E0 Offset: 0xB77E1 VA: 0xB76E0
	// RVA: 0x2A73590 Offset: 0x2A73691 VA: 0x2A73590 Slot: 6
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[CLSCompliantAttribute] // RVA: 0xB7700 Offset: 0xB7801 VA: 0xB7700
	[ComVisibleAttribute] // RVA: 0xB7700 Offset: 0xB7801 VA: 0xB7700
	// RVA: 0x2A735A0 Offset: 0x2A736A1 VA: 0x2A735A0 Slot: 7
	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2A73710 Offset: 0x2A73811 VA: 0x2A73710 Slot: 9
	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[CLSCompliantAttribute] // RVA: 0xB7740 Offset: 0xB7841 VA: 0xB7740
	[ComVisibleAttribute] // RVA: 0xB7740 Offset: 0xB7841 VA: 0xB7740
	// RVA: 0x2A73720 Offset: 0x2A73821 VA: 0x2A73720 Slot: 10
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }
}

