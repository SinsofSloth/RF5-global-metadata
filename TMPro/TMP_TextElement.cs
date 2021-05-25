[Serializable]
public class TMP_TextElement // TypeDefIndex: 5871
{
	// Fields
	[SerializeField] // RVA: 0x1402B0 Offset: 0x1403B1 VA: 0x1402B0
	protected TextElementType m_ElementType; // 0x10
	[SerializeField] // RVA: 0x1402C0 Offset: 0x1403C1 VA: 0x1402C0
	internal uint m_Unicode; // 0x14
	internal TMP_Asset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	[SerializeField] // RVA: 0x1402D0 Offset: 0x1403D1 VA: 0x1402D0
	internal uint m_GlyphIndex; // 0x28
	[SerializeField] // RVA: 0x1402E0 Offset: 0x1403E1 VA: 0x1402E0
	internal float m_Scale; // 0x2C

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public TMP_Asset textAsset { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x159C640 Offset: 0x159C741 VA: 0x159C640
	public TextElementType get_elementType() { }

	// RVA: 0x159C650 Offset: 0x159C751 VA: 0x159C650
	public uint get_unicode() { }

	// RVA: 0x159C660 Offset: 0x159C761 VA: 0x159C660
	public void set_unicode(uint value) { }

	// RVA: 0x159C670 Offset: 0x159C771 VA: 0x159C670
	public TMP_Asset get_textAsset() { }

	// RVA: 0x159C680 Offset: 0x159C781 VA: 0x159C680
	public void set_textAsset(TMP_Asset value) { }

	// RVA: 0x159C690 Offset: 0x159C791 VA: 0x159C690
	public Glyph get_glyph() { }

	// RVA: 0x159C6A0 Offset: 0x159C7A1 VA: 0x159C6A0
	public void set_glyph(Glyph value) { }

	// RVA: 0x159C6B0 Offset: 0x159C7B1 VA: 0x159C6B0
	public uint get_glyphIndex() { }

	// RVA: 0x159C6C0 Offset: 0x159C7C1 VA: 0x159C6C0
	public void set_glyphIndex(uint value) { }

	// RVA: 0x159C6D0 Offset: 0x159C7D1 VA: 0x159C6D0
	public float get_scale() { }

	// RVA: 0x159C6E0 Offset: 0x159C7E1 VA: 0x159C6E0
	public void set_scale(float value) { }

	// RVA: 0x159C6F0 Offset: 0x159C7F1 VA: 0x159C6F0
	public void .ctor() { }
}

