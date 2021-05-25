[UsedByNativeCodeAttribute] // RVA: 0x100BD0 Offset: 0x100CD1 VA: 0x100BD0
[Serializable]
public struct GlyphAdjustmentRecord // TypeDefIndex: 3683
{
	// Fields
	[SerializeField] // RVA: 0x101870 Offset: 0x101971 VA: 0x101870
	[NativeNameAttribute] // RVA: 0x101870 Offset: 0x101971 VA: 0x101870
	private uint m_GlyphIndex; // 0x0
	[NativeNameAttribute] // RVA: 0x1018C0 Offset: 0x1019C1 VA: 0x1018C0
	[SerializeField] // RVA: 0x1018C0 Offset: 0x1019C1 VA: 0x1018C0
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }

	// Methods

	// RVA: 0x250D0 Offset: 0x251D1 VA: 0x250D0
	public uint get_glyphIndex() { }

	// RVA: 0x250E0 Offset: 0x251E1 VA: 0x250E0
	public GlyphValueRecord get_glyphValueRecord() { }
}

