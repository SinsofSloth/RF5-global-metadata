[UsedByNativeCodeAttribute] // RVA: 0x100BE0 Offset: 0x100CE1 VA: 0x100BE0
[DebuggerDisplayAttribute] // RVA: 0x100BE0 Offset: 0x100CE1 VA: 0x100BE0
[Serializable]
public struct GlyphPairAdjustmentRecord // TypeDefIndex: 3684
{
	// Fields
	[NativeNameAttribute] // RVA: 0x101910 Offset: 0x101A11 VA: 0x101910
	[SerializeField] // RVA: 0x101910 Offset: 0x101A11 VA: 0x101910
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x0
	[NativeNameAttribute] // RVA: 0x101960 Offset: 0x101A61 VA: 0x101960
	[SerializeField] // RVA: 0x101960 Offset: 0x101A61 VA: 0x101960
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14
	[SerializeField] // RVA: 0x1019B0 Offset: 0x101AB1 VA: 0x1019B0
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x28

	// Properties
	public GlyphAdjustmentRecord firstAdjustmentRecord { get; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }

	// Methods

	// RVA: 0x250F0 Offset: 0x251F1 VA: 0x250F0
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x25110 Offset: 0x25211 VA: 0x25110
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }
}

