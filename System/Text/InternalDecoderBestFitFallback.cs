[Serializable]
internal sealed class InternalDecoderBestFitFallback : DecoderFallback // TypeDefIndex: 444
{
	// Fields
	internal Encoding encoding; // 0x18
	internal char[] arrayBestFit; // 0x20
	internal char cReplacement; // 0x28

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x2A77F80 Offset: 0x2A78081 VA: 0x2A77F80
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x2A7E7A0 Offset: 0x2A7E8A1 VA: 0x2A7E7A0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x2A7E9C0 Offset: 0x2A7EAC1 VA: 0x2A7E9C0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x2A7E9D0 Offset: 0x2A7EAD1 VA: 0x2A7E9D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2A7EAB0 Offset: 0x2A7EBB1 VA: 0x2A7EAB0 Slot: 2
	public override int GetHashCode() { }
}

