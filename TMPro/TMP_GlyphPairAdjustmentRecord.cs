[Serializable]
public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 5800
{
	// Fields
	[SerializeField] // RVA: 0x13F710 Offset: 0x13F811 VA: 0x13F710
	internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	[SerializeField] // RVA: 0x13F720 Offset: 0x13F821 VA: 0x13F720
	internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	[SerializeField] // RVA: 0x13F730 Offset: 0x13F831 VA: 0x13F730
	internal FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Properties
	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
	public FontFeatureLookupFlags featureLookupFlags { get; set; }

	// Methods

	// RVA: 0x155EE90 Offset: 0x155EF91 VA: 0x155EE90
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x155EEB0 Offset: 0x155EFB1 VA: 0x155EEB0
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x155EED0 Offset: 0x155EFD1 VA: 0x155EED0
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x155EEF0 Offset: 0x155EFF1 VA: 0x155EEF0
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x155EF10 Offset: 0x155F011 VA: 0x155EF10
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x155EF20 Offset: 0x155F021 VA: 0x155EF20
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	// RVA: 0x155EF30 Offset: 0x155F031 VA: 0x155EF30
	public void .ctor(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	// RVA: 0x155EF90 Offset: 0x155F091 VA: 0x155EF90
	internal void .ctor(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }
}

