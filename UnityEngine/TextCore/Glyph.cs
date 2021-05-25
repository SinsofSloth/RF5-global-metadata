[UsedByNativeCodeAttribute] // RVA: 0x100BA0 Offset: 0x100CA1 VA: 0x100BA0
[Serializable]
public class Glyph // TypeDefIndex: 3680
{
	// Fields
	[SerializeField] // RVA: 0x1015A0 Offset: 0x1016A1 VA: 0x1015A0
	[NativeNameAttribute] // RVA: 0x1015A0 Offset: 0x1016A1 VA: 0x1015A0
	private uint m_Index; // 0x10
	[SerializeField] // RVA: 0x1015F0 Offset: 0x1016F1 VA: 0x1015F0
	[NativeNameAttribute] // RVA: 0x1015F0 Offset: 0x1016F1 VA: 0x1015F0
	private GlyphMetrics m_Metrics; // 0x14
	[NativeNameAttribute] // RVA: 0x101640 Offset: 0x101741 VA: 0x101640
	[SerializeField] // RVA: 0x101640 Offset: 0x101741 VA: 0x101640
	private GlyphRect m_GlyphRect; // 0x28
	[SerializeField] // RVA: 0x101690 Offset: 0x101791 VA: 0x101690
	[NativeNameAttribute] // RVA: 0x101690 Offset: 0x101791 VA: 0x101690
	private float m_Scale; // 0x38
	[NativeNameAttribute] // RVA: 0x1016E0 Offset: 0x1017E1 VA: 0x1016E0
	[SerializeField] // RVA: 0x1016E0 Offset: 0x1017E1 VA: 0x1016E0
	private int m_AtlasIndex; // 0x3C

	// Properties
	public uint index { get; set; }
	public GlyphMetrics metrics { get; set; }
	public GlyphRect glyphRect { get; set; }
	public float scale { get; set; }
	public int atlasIndex { get; set; }

	// Methods

	// RVA: 0x1BC7690 Offset: 0x1BC7791 VA: 0x1BC7690
	public uint get_index() { }

	// RVA: 0x1BC76A0 Offset: 0x1BC77A1 VA: 0x1BC76A0
	public void set_index(uint value) { }

	// RVA: 0x1BC76B0 Offset: 0x1BC77B1 VA: 0x1BC76B0
	public GlyphMetrics get_metrics() { }

	// RVA: 0x1BC76D0 Offset: 0x1BC77D1 VA: 0x1BC76D0
	public void set_metrics(GlyphMetrics value) { }

	// RVA: 0x1BC76F0 Offset: 0x1BC77F1 VA: 0x1BC76F0
	public GlyphRect get_glyphRect() { }

	// RVA: 0x1BC7700 Offset: 0x1BC7801 VA: 0x1BC7700
	public void set_glyphRect(GlyphRect value) { }

	// RVA: 0x1BC7710 Offset: 0x1BC7811 VA: 0x1BC7710
	public float get_scale() { }

	// RVA: 0x1BC7720 Offset: 0x1BC7821 VA: 0x1BC7720
	public void set_scale(float value) { }

	// RVA: 0x1BC7730 Offset: 0x1BC7831 VA: 0x1BC7730
	public int get_atlasIndex() { }

	// RVA: 0x1BC7740 Offset: 0x1BC7841 VA: 0x1BC7740
	public void set_atlasIndex(int value) { }

	// RVA: 0x1BC7750 Offset: 0x1BC7851 VA: 0x1BC7750
	public void .ctor() { }

	// RVA: 0x1BC7790 Offset: 0x1BC7891 VA: 0x1BC7790
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x1BC7810 Offset: 0x1BC7911 VA: 0x1BC7810
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }
}

