[Serializable]
public sealed class DecoderReplacementFallback : DecoderFallback // TypeDefIndex: 452
{
	// Fields
	private string strDefault; // 0x18

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x2A73FB0 Offset: 0x2A740B1 VA: 0x2A73FB0
	public void .ctor() { }

	// RVA: 0x2A75270 Offset: 0x2A75371 VA: 0x2A75270
	public void .ctor(string replacement) { }

	// RVA: 0x2A75460 Offset: 0x2A75561 VA: 0x2A75460
	public string get_DefaultString() { }

	// RVA: 0x2A75470 Offset: 0x2A75571 VA: 0x2A75470 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x2A75540 Offset: 0x2A75641 VA: 0x2A75540 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x2A75560 Offset: 0x2A75661 VA: 0x2A75560 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2A75600 Offset: 0x2A75701 VA: 0x2A75600 Slot: 2
	public override int GetHashCode() { }
}

