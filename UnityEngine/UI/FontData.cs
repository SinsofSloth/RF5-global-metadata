[Serializable]
public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 3926
{
	// Fields
	[SerializeField] // RVA: 0x11B330 Offset: 0x11B431 VA: 0x11B330
	[FormerlySerializedAsAttribute] // RVA: 0x11B330 Offset: 0x11B431 VA: 0x11B330
	private Font m_Font; // 0x10
	[SerializeField] // RVA: 0x11B380 Offset: 0x11B481 VA: 0x11B380
	[FormerlySerializedAsAttribute] // RVA: 0x11B380 Offset: 0x11B481 VA: 0x11B380
	private int m_FontSize; // 0x18
	[SerializeField] // RVA: 0x11B3D0 Offset: 0x11B4D1 VA: 0x11B3D0
	[FormerlySerializedAsAttribute] // RVA: 0x11B3D0 Offset: 0x11B4D1 VA: 0x11B3D0
	private FontStyle m_FontStyle; // 0x1C
	[SerializeField] // RVA: 0x11B420 Offset: 0x11B521 VA: 0x11B420
	private bool m_BestFit; // 0x20
	[SerializeField] // RVA: 0x11B430 Offset: 0x11B531 VA: 0x11B430
	private int m_MinSize; // 0x24
	[SerializeField] // RVA: 0x11B440 Offset: 0x11B541 VA: 0x11B440
	private int m_MaxSize; // 0x28
	[SerializeField] // RVA: 0x11B450 Offset: 0x11B551 VA: 0x11B450
	[FormerlySerializedAsAttribute] // RVA: 0x11B450 Offset: 0x11B551 VA: 0x11B450
	private TextAnchor m_Alignment; // 0x2C
	[SerializeField] // RVA: 0x11B4A0 Offset: 0x11B5A1 VA: 0x11B4A0
	private bool m_AlignByGeometry; // 0x30
	[SerializeField] // RVA: 0x11B4B0 Offset: 0x11B5B1 VA: 0x11B4B0
	[FormerlySerializedAsAttribute] // RVA: 0x11B4B0 Offset: 0x11B5B1 VA: 0x11B4B0
	private bool m_RichText; // 0x31
	[SerializeField] // RVA: 0x11B500 Offset: 0x11B601 VA: 0x11B500
	private HorizontalWrapMode m_HorizontalOverflow; // 0x34
	[SerializeField] // RVA: 0x11B510 Offset: 0x11B611 VA: 0x11B510
	private VerticalWrapMode m_VerticalOverflow; // 0x38
	[SerializeField] // RVA: 0x11B520 Offset: 0x11B621 VA: 0x11B520
	private float m_LineSpacing; // 0x3C

	// Properties
	public static FontData defaultFontData { get; }
	public Font font { get; set; }
	public int fontSize { get; set; }
	public FontStyle fontStyle { get; set; }
	public bool bestFit { get; set; }
	public int minSize { get; set; }
	public int maxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public bool richText { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }

	// Methods

	// RVA: 0x1863E10 Offset: 0x1863F11 VA: 0x1863E10
	public static FontData get_defaultFontData() { }

	// RVA: 0x1863EC0 Offset: 0x1863FC1 VA: 0x1863EC0
	public Font get_font() { }

	// RVA: 0x1863ED0 Offset: 0x1863FD1 VA: 0x1863ED0
	public void set_font(Font value) { }

	// RVA: 0x1863EE0 Offset: 0x1863FE1 VA: 0x1863EE0
	public int get_fontSize() { }

	// RVA: 0x1863EF0 Offset: 0x1863FF1 VA: 0x1863EF0
	public void set_fontSize(int value) { }

	// RVA: 0x1863F00 Offset: 0x1864001 VA: 0x1863F00
	public FontStyle get_fontStyle() { }

	// RVA: 0x1863F10 Offset: 0x1864011 VA: 0x1863F10
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x1863F20 Offset: 0x1864021 VA: 0x1863F20
	public bool get_bestFit() { }

	// RVA: 0x1863F30 Offset: 0x1864031 VA: 0x1863F30
	public void set_bestFit(bool value) { }

	// RVA: 0x1863F40 Offset: 0x1864041 VA: 0x1863F40
	public int get_minSize() { }

	// RVA: 0x1863F50 Offset: 0x1864051 VA: 0x1863F50
	public void set_minSize(int value) { }

	// RVA: 0x1863F60 Offset: 0x1864061 VA: 0x1863F60
	public int get_maxSize() { }

	// RVA: 0x1863F70 Offset: 0x1864071 VA: 0x1863F70
	public void set_maxSize(int value) { }

	// RVA: 0x1863F80 Offset: 0x1864081 VA: 0x1863F80
	public TextAnchor get_alignment() { }

	// RVA: 0x1863F90 Offset: 0x1864091 VA: 0x1863F90
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1863FA0 Offset: 0x18640A1 VA: 0x1863FA0
	public bool get_alignByGeometry() { }

	// RVA: 0x1863FB0 Offset: 0x18640B1 VA: 0x1863FB0
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x1863FC0 Offset: 0x18640C1 VA: 0x1863FC0
	public bool get_richText() { }

	// RVA: 0x1863FD0 Offset: 0x18640D1 VA: 0x1863FD0
	public void set_richText(bool value) { }

	// RVA: 0x1863FE0 Offset: 0x18640E1 VA: 0x1863FE0
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x1863FF0 Offset: 0x18640F1 VA: 0x1863FF0
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x1864000 Offset: 0x1864101 VA: 0x1864000
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x1864010 Offset: 0x1864111 VA: 0x1864010
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x1864020 Offset: 0x1864121 VA: 0x1864020
	public float get_lineSpacing() { }

	// RVA: 0x1864030 Offset: 0x1864131 VA: 0x1864030
	public void set_lineSpacing(float value) { }

	// RVA: 0x1864040 Offset: 0x1864141 VA: 0x1864040 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1864050 Offset: 0x1864151 VA: 0x1864050 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x1863EB0 Offset: 0x1863FB1 VA: 0x1863EB0
	public void .ctor() { }
}

