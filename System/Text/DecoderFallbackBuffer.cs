public abstract class DecoderFallbackBuffer // TypeDefIndex: 450
{
	// Fields
	internal byte* byteStart; // 0x10
	internal char* charEnd; // 0x18

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract char GetNextChar() { }

	// RVA: 0x2A741B0 Offset: 0x2A742B1 VA: 0x2A741B0 Slot: 6
	public virtual void Reset() { }

	// RVA: 0x2A72FB0 Offset: 0x2A730B1 VA: 0x2A72FB0
	internal void InternalReset() { }

	// RVA: 0x2A72A80 Offset: 0x2A72B81 VA: 0x2A72A80
	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	// RVA: 0x2A741F0 Offset: 0x2A742F1 VA: 0x2A741F0 Slot: 7
	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	// RVA: 0x2A743D0 Offset: 0x2A744D1 VA: 0x2A743D0 Slot: 8
	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x2A74590 Offset: 0x2A74691 VA: 0x2A74590
	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

	// RVA: 0x2A73F00 Offset: 0x2A74001 VA: 0x2A73F00
	protected void .ctor() { }
}

