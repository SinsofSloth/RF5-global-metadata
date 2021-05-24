[AddComponentMenu] // RVA: 0x11A720 Offset: 0x11A821 VA: 0x11A720
public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 4013
{
	// Fields
	[SerializeField] // RVA: 0x11C930 Offset: 0x11CA31 VA: 0x11C930
	private FontData m_FontData; // 0xC0
	[TextAreaAttribute] // RVA: 0x11C940 Offset: 0x11CA41 VA: 0x11C940
	[SerializeField] // RVA: 0x11C940 Offset: 0x11CA41 VA: 0x11C940
	protected string m_Text; // 0xC8
	private TextGenerator m_TextCache; // 0xD0
	private TextGenerator m_TextCacheForLayout; // 0xD8
	protected static Material s_DefaultText; // 0x0
	protected bool m_DisableFontTextureRebuiltCallback; // 0xE0
	private readonly UIVertex[] m_TempVerts; // 0xE8

	// Properties
	public TextGenerator cachedTextGenerator { get; }
	public TextGenerator cachedTextGeneratorForLayout { get; }
	public override Texture mainTexture { get; }
	public Font font { get; set; }
	public virtual string text { get; set; }
	public bool supportRichText { get; set; }
	public bool resizeTextForBestFit { get; set; }
	public int resizeTextMinSize { get; set; }
	public int resizeTextMaxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public int fontSize { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }
	public FontStyle fontStyle { get; set; }
	public float pixelsPerUnit { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1B80F00 Offset: 0x1B81001 VA: 0x1B80F00
	protected void .ctor() { }

	// RVA: 0x1B80FB0 Offset: 0x1B810B1 VA: 0x1B80FB0
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x1B81060 Offset: 0x1B81161 VA: 0x1B81060
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x1B810F0 Offset: 0x1B811F1 VA: 0x1B810F0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x1B81300 Offset: 0x1B81401 VA: 0x1B81300
	public void FontTextureChanged() { }

	// RVA: 0x1B812E0 Offset: 0x1B813E1 VA: 0x1B812E0
	public Font get_font() { }

	// RVA: 0x1B81440 Offset: 0x1B81541 VA: 0x1B81440
	public void set_font(Font value) { }

	// RVA: 0x1B81540 Offset: 0x1B81641 VA: 0x1B81540 Slot: 74
	public virtual string get_text() { }

	// RVA: 0x1B81550 Offset: 0x1B81651 VA: 0x1B81550 Slot: 75
	public virtual void set_text(string value) { }

	// RVA: 0x1B81640 Offset: 0x1B81741 VA: 0x1B81640
	public bool get_supportRichText() { }

	// RVA: 0x1B81660 Offset: 0x1B81761 VA: 0x1B81660
	public void set_supportRichText(bool value) { }

	// RVA: 0x1B816D0 Offset: 0x1B817D1 VA: 0x1B816D0
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x1B816F0 Offset: 0x1B817F1 VA: 0x1B816F0
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x1B81760 Offset: 0x1B81861 VA: 0x1B81760
	public int get_resizeTextMinSize() { }

	// RVA: 0x1B81780 Offset: 0x1B81881 VA: 0x1B81780
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x1B817F0 Offset: 0x1B818F1 VA: 0x1B817F0
	public int get_resizeTextMaxSize() { }

	// RVA: 0x1B81810 Offset: 0x1B81911 VA: 0x1B81810
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x1B81880 Offset: 0x1B81981 VA: 0x1B81880
	public TextAnchor get_alignment() { }

	// RVA: 0x1B818A0 Offset: 0x1B819A1 VA: 0x1B818A0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1B81910 Offset: 0x1B81A11 VA: 0x1B81910
	public bool get_alignByGeometry() { }

	// RVA: 0x1B81930 Offset: 0x1B81A31 VA: 0x1B81930
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x1B81980 Offset: 0x1B81A81 VA: 0x1B81980
	public int get_fontSize() { }

	// RVA: 0x1B819A0 Offset: 0x1B81AA1 VA: 0x1B819A0
	public void set_fontSize(int value) { }

	// RVA: 0x1B81A10 Offset: 0x1B81B11 VA: 0x1B81A10
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x1B81A30 Offset: 0x1B81B31 VA: 0x1B81A30
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x1B81AA0 Offset: 0x1B81BA1 VA: 0x1B81AA0
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x1B81AC0 Offset: 0x1B81BC1 VA: 0x1B81AC0
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x1B81B30 Offset: 0x1B81C31 VA: 0x1B81B30
	public float get_lineSpacing() { }

	// RVA: 0x1B81B50 Offset: 0x1B81C51 VA: 0x1B81B50
	public void set_lineSpacing(float value) { }

	// RVA: 0x1B81BC0 Offset: 0x1B81CC1 VA: 0x1B81BC0
	public FontStyle get_fontStyle() { }

	// RVA: 0x1B81BE0 Offset: 0x1B81CE1 VA: 0x1B81BE0
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x1B81C50 Offset: 0x1B81D51 VA: 0x1B81C50
	public float get_pixelsPerUnit() { }

	// RVA: 0x1B81DD0 Offset: 0x1B81ED1 VA: 0x1B81DD0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1B81E60 Offset: 0x1B81F61 VA: 0x1B81E60 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1B81EE0 Offset: 0x1B81FE1 VA: 0x1B81EE0 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x1B81F80 Offset: 0x1B82081 VA: 0x1B81F80
	internal void AssignDefaultFont() { }

	// RVA: 0x1B81FF0 Offset: 0x1B820F1 VA: 0x1B81FF0
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x1B821E0 Offset: 0x1B822E1 VA: 0x1B821E0
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x1B82310 Offset: 0x1B82411 VA: 0x1B82310 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x1B82D80 Offset: 0x1B82E81 VA: 0x1B82D80 Slot: 76
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1B82D90 Offset: 0x1B82E91 VA: 0x1B82D90 Slot: 77
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1B82DA0 Offset: 0x1B82EA1 VA: 0x1B82DA0 Slot: 78
	public virtual float get_minWidth() { }

	// RVA: 0x1B82DB0 Offset: 0x1B82EB1 VA: 0x1B82DB0 Slot: 79
	public virtual float get_preferredWidth() { }

	// RVA: 0x1B82F40 Offset: 0x1B83041 VA: 0x1B82F40 Slot: 80
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1B82F50 Offset: 0x1B83051 VA: 0x1B82F50 Slot: 81
	public virtual float get_minHeight() { }

	// RVA: 0x1B82F60 Offset: 0x1B83061 VA: 0x1B82F60 Slot: 82
	public virtual float get_preferredHeight() { }

	// RVA: 0x1B830E0 Offset: 0x1B831E1 VA: 0x1B830E0 Slot: 83
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1B830F0 Offset: 0x1B831F1 VA: 0x1B830F0 Slot: 84
	public virtual int get_layoutPriority() { }

	// RVA: 0x1B83100 Offset: 0x1B83201 VA: 0x1B83100
	private static void .cctor() { }
}

