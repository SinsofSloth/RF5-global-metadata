[Serializable]
public class KerningTable // TypeDefIndex: 5788
{
	// Fields
	public List<KerningPair> kerningPairs; // 0x10

	// Methods

	// RVA: 0x154AEA0 Offset: 0x154AFA1 VA: 0x154AEA0
	public void .ctor() { }

	// RVA: 0x154AF20 Offset: 0x154B021 VA: 0x154AF20
	public void AddKerningPair() { }

	// RVA: 0x154B050 Offset: 0x154B151 VA: 0x154B050
	public int AddKerningPair(uint first, uint second, float offset) { }

	// RVA: 0x154B1A0 Offset: 0x154B2A1 VA: 0x154B1A0
	public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) { }

	// RVA: 0x154B330 Offset: 0x154B431 VA: 0x154B330
	public void RemoveKerningPair(int left, int right) { }

	// RVA: 0x154B440 Offset: 0x154B541 VA: 0x154B440
	public void RemoveKerningPair(int index) { }

	// RVA: 0x154B4B0 Offset: 0x154B5B1 VA: 0x154B4B0
	public void SortKerningPairs() { }
}

