internal struct MutableDecimal // TypeDefIndex: 4391
{
	// Fields
	public uint Flags; // 0x0
	public uint High; // 0x4
	public uint Low; // 0x8
	public uint Mid; // 0xC

	// Properties
	public bool IsNegative { get; set; }
	public int Scale { get; set; }

	// Methods

	// RVA: 0x20620 Offset: 0x20721 VA: 0x20620
	public bool get_IsNegative() { }

	// RVA: 0x20630 Offset: 0x20731 VA: 0x20630
	public void set_IsNegative(bool value) { }

	// RVA: 0x20650 Offset: 0x20751 VA: 0x20650
	public int get_Scale() { }

	// RVA: 0x20660 Offset: 0x20761 VA: 0x20660
	public void set_Scale(int value) { }
}

