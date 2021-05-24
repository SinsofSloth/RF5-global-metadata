[Serializable]
public class TMP_FontFeatureTable // TypeDefIndex: 5795
{
	// Fields
	[SerializeField] // RVA: 0x13F6A0 Offset: 0x13F7A1 VA: 0x13F6A0
	internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
	internal Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18

	// Properties
	public List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }

	// Methods

	// RVA: 0x155E270 Offset: 0x155E371 VA: 0x155E270
	public List<TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x155E280 Offset: 0x155E381 VA: 0x155E280
	public void set_glyphPairAdjustmentRecords(List<TMP_GlyphPairAdjustmentRecord> value) { }

	// RVA: 0x155E290 Offset: 0x155E391 VA: 0x155E290
	public void .ctor() { }

	// RVA: 0x155E340 Offset: 0x155E441 VA: 0x155E340
	public void SortGlyphPairAdjustmentRecords() { }
}

