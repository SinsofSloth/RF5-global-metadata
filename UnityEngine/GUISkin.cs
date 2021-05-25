[AssetFileNameExtensionAttribute] // RVA: 0xF4BE0 Offset: 0xF4CE1 VA: 0xF4BE0
[ExecuteInEditMode] // RVA: 0xF4BE0 Offset: 0xF4CE1 VA: 0xF4BE0
[RequiredByNativeCodeAttribute] // RVA: 0xF4BE0 Offset: 0xF4CE1 VA: 0xF4BE0
[Serializable]
public sealed class GUISkin : ScriptableObject // TypeDefIndex: 3603
{
	// Fields
	[SerializeField] // RVA: 0xF57A0 Offset: 0xF58A1 VA: 0xF57A0
	private Font m_Font; // 0x18
	[SerializeField] // RVA: 0xF57B0 Offset: 0xF58B1 VA: 0xF57B0
	private GUIStyle m_box; // 0x20
	[SerializeField] // RVA: 0xF57C0 Offset: 0xF58C1 VA: 0xF57C0
	private GUIStyle m_button; // 0x28
	[SerializeField] // RVA: 0xF57D0 Offset: 0xF58D1 VA: 0xF57D0
	private GUIStyle m_toggle; // 0x30
	[SerializeField] // RVA: 0xF57E0 Offset: 0xF58E1 VA: 0xF57E0
	private GUIStyle m_label; // 0x38
	[SerializeField] // RVA: 0xF57F0 Offset: 0xF58F1 VA: 0xF57F0
	private GUIStyle m_textField; // 0x40
	[SerializeField] // RVA: 0xF5800 Offset: 0xF5901 VA: 0xF5800
	private GUIStyle m_textArea; // 0x48
	[SerializeField] // RVA: 0xF5810 Offset: 0xF5911 VA: 0xF5810
	private GUIStyle m_window; // 0x50
	[SerializeField] // RVA: 0xF5820 Offset: 0xF5921 VA: 0xF5820
	private GUIStyle m_horizontalSlider; // 0x58
	[SerializeField] // RVA: 0xF5830 Offset: 0xF5931 VA: 0xF5830
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	[SerializeField] // RVA: 0xF5840 Offset: 0xF5941 VA: 0xF5840
	private GUIStyle m_verticalSlider; // 0x70
	[SerializeField] // RVA: 0xF5850 Offset: 0xF5951 VA: 0xF5850
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	[SerializeField] // RVA: 0xF5860 Offset: 0xF5961 VA: 0xF5860
	private GUIStyle m_horizontalScrollbar; // 0x88
	[SerializeField] // RVA: 0xF5870 Offset: 0xF5971 VA: 0xF5870
	private GUIStyle m_horizontalScrollbarThumb; // 0x90
	[SerializeField] // RVA: 0xF5880 Offset: 0xF5981 VA: 0xF5880
	private GUIStyle m_horizontalScrollbarLeftButton; // 0x98
	[SerializeField] // RVA: 0xF5890 Offset: 0xF5991 VA: 0xF5890
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA0
	[SerializeField] // RVA: 0xF58A0 Offset: 0xF59A1 VA: 0xF58A0
	private GUIStyle m_verticalScrollbar; // 0xA8
	[SerializeField] // RVA: 0xF58B0 Offset: 0xF59B1 VA: 0xF58B0
	private GUIStyle m_verticalScrollbarThumb; // 0xB0
	[SerializeField] // RVA: 0xF58C0 Offset: 0xF59C1 VA: 0xF58C0
	private GUIStyle m_verticalScrollbarUpButton; // 0xB8
	[SerializeField] // RVA: 0xF58D0 Offset: 0xF59D1 VA: 0xF58D0
	private GUIStyle m_verticalScrollbarDownButton; // 0xC0
	[SerializeField] // RVA: 0xF58E0 Offset: 0xF59E1 VA: 0xF58E0
	private GUIStyle m_ScrollView; // 0xC8
	[SerializeField] // RVA: 0xF58F0 Offset: 0xF59F1 VA: 0xF58F0
	internal GUIStyle[] m_CustomStyles; // 0xD0
	[SerializeField] // RVA: 0xF5900 Offset: 0xF5A01 VA: 0xF5900
	private GUISettings m_Settings; // 0xD8
	internal static GUIStyle ms_Error; // 0x0
	private Dictionary<string, GUIStyle> m_Styles; // 0xE0
	internal static GUISkin.SkinChangedDelegate m_SkinChanged; // 0x8
	internal static GUISkin current; // 0x10

	// Properties
	public Font font { get; set; }
	public GUIStyle box { get; set; }
	public GUIStyle label { get; set; }
	public GUIStyle textField { get; set; }
	public GUIStyle textArea { get; set; }
	public GUIStyle button { get; set; }
	public GUIStyle toggle { get; set; }
	public GUIStyle window { get; set; }
	public GUIStyle horizontalSlider { get; set; }
	public GUIStyle horizontalSliderThumb { get; set; }
	internal GUIStyle horizontalSliderThumbExtent { get; set; }
	public GUIStyle verticalSlider { get; set; }
	public GUIStyle verticalSliderThumb { get; set; }
	internal GUIStyle verticalSliderThumbExtent { get; set; }
	public GUIStyle horizontalScrollbar { get; set; }
	public GUIStyle horizontalScrollbarThumb { get; set; }
	public GUIStyle horizontalScrollbarLeftButton { get; set; }
	public GUIStyle horizontalScrollbarRightButton { get; set; }
	public GUIStyle verticalScrollbar { get; set; }
	public GUIStyle verticalScrollbarThumb { get; set; }
	public GUIStyle verticalScrollbarUpButton { get; set; }
	public GUIStyle verticalScrollbarDownButton { get; set; }
	public GUIStyle scrollView { get; set; }
	public GUIStyle[] customStyles { get; set; }
	public GUISettings settings { get; }
	internal static GUIStyle error { get; }

	// Methods

	// RVA: 0x2D1BC80 Offset: 0x2D1BD81 VA: 0x2D1BC80
	public void .ctor() { }

	// RVA: 0x2D1BD90 Offset: 0x2D1BE91 VA: 0x2D1BD90
	internal void OnEnable() { }

	// RVA: 0x2D1BED0 Offset: 0x2D1BFD1 VA: 0x2D1BED0
	internal static void CleanupRoots() { }

	// RVA: 0x2D07E10 Offset: 0x2D07F11 VA: 0x2D07E10
	public Font get_font() { }

	// RVA: 0x2D1BF40 Offset: 0x2D1C041 VA: 0x2D1BF40
	public void set_font(Font value) { }

	// RVA: 0x2D05BB0 Offset: 0x2D05CB1 VA: 0x2D05BB0
	public GUIStyle get_box() { }

	// RVA: 0x2D1C110 Offset: 0x2D1C211 VA: 0x2D1C110
	public void set_box(GUIStyle value) { }

	// RVA: 0x2D041E0 Offset: 0x2D042E1 VA: 0x2D041E0
	public GUIStyle get_label() { }

	// RVA: 0x2D1C1B0 Offset: 0x2D1C2B1 VA: 0x2D1C1B0
	public void set_label(GUIStyle value) { }

	// RVA: 0x2D11AA0 Offset: 0x2D11BA1 VA: 0x2D11AA0
	public GUIStyle get_textField() { }

	// RVA: 0x2D1C250 Offset: 0x2D1C351 VA: 0x2D1C250
	public void set_textField(GUIStyle value) { }

	// RVA: 0x2D1C2F0 Offset: 0x2D1C3F1 VA: 0x2D1C2F0
	public GUIStyle get_textArea() { }

	// RVA: 0x2D1C300 Offset: 0x2D1C401 VA: 0x2D1C300
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x2D06060 Offset: 0x2D06161 VA: 0x2D06060
	public GUIStyle get_button() { }

	// RVA: 0x2D1C3A0 Offset: 0x2D1C4A1 VA: 0x2D1C3A0
	public void set_button(GUIStyle value) { }

	// RVA: 0x2D07F80 Offset: 0x2D08081 VA: 0x2D07F80
	public GUIStyle get_toggle() { }

	// RVA: 0x2D1C440 Offset: 0x2D1C541 VA: 0x2D1C440
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x2D14B30 Offset: 0x2D14C31 VA: 0x2D14B30
	public GUIStyle get_window() { }

	// RVA: 0x2D1C4E0 Offset: 0x2D1C5E1 VA: 0x2D1C4E0
	public void set_window(GUIStyle value) { }

	// RVA: 0x2D123C0 Offset: 0x2D124C1 VA: 0x2D123C0
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x2D1C580 Offset: 0x2D1C681 VA: 0x2D1C580
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x2D123D0 Offset: 0x2D124D1 VA: 0x2D123D0
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x2D1C620 Offset: 0x2D1C721 VA: 0x2D1C620
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x2D1C6C0 Offset: 0x2D1C7C1 VA: 0x2D1C6C0
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x2D1C6D0 Offset: 0x2D1C7D1 VA: 0x2D1C6D0
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x2D1C770 Offset: 0x2D1C871 VA: 0x2D1C770
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x2D1C780 Offset: 0x2D1C881 VA: 0x2D1C780
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x2D1C820 Offset: 0x2D1C921 VA: 0x2D1C820
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x2D1C830 Offset: 0x2D1C931 VA: 0x2D1C830
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x2D1C8D0 Offset: 0x2D1C9D1 VA: 0x2D1C8D0
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x2D1C8E0 Offset: 0x2D1C9E1 VA: 0x2D1C8E0
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x2D145B0 Offset: 0x2D146B1 VA: 0x2D145B0
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x2D1C980 Offset: 0x2D1CA81 VA: 0x2D1C980
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x2D1CA20 Offset: 0x2D1CB21 VA: 0x2D1CA20
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x2D1CA30 Offset: 0x2D1CB31 VA: 0x2D1CA30
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x2D1CAD0 Offset: 0x2D1CBD1 VA: 0x2D1CAD0
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x2D1CAE0 Offset: 0x2D1CBE1 VA: 0x2D1CAE0
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x2D1CB80 Offset: 0x2D1CC81 VA: 0x2D1CB80
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x2D1CB90 Offset: 0x2D1CC91 VA: 0x2D1CB90
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x2D145C0 Offset: 0x2D146C1 VA: 0x2D145C0
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x2D1CC30 Offset: 0x2D1CD31 VA: 0x2D1CC30
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x2D1CCD0 Offset: 0x2D1CDD1 VA: 0x2D1CCD0
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x2D1CCE0 Offset: 0x2D1CDE1 VA: 0x2D1CCE0
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x2D1CD80 Offset: 0x2D1CE81 VA: 0x2D1CD80
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x2D1CD90 Offset: 0x2D1CE91 VA: 0x2D1CD90
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x2D1CE30 Offset: 0x2D1CF31 VA: 0x2D1CE30
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x2D1CE40 Offset: 0x2D1CF41 VA: 0x2D1CE40
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x2D145D0 Offset: 0x2D146D1 VA: 0x2D145D0
	public GUIStyle get_scrollView() { }

	// RVA: 0x2D1CEE0 Offset: 0x2D1CFE1 VA: 0x2D1CEE0
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x2D1CF80 Offset: 0x2D1D081 VA: 0x2D1CF80
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x2D1CF90 Offset: 0x2D1D091 VA: 0x2D1CF90
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x2D07D90 Offset: 0x2D07E91 VA: 0x2D07D90
	public GUISettings get_settings() { }

	// RVA: 0x2D1D030 Offset: 0x2D1D131 VA: 0x2D1D030
	internal static GUIStyle get_error() { }

	// RVA: 0x2D1BE30 Offset: 0x2D1BF31 VA: 0x2D1BE30
	internal void Apply() { }

	// RVA: 0x2D1D210 Offset: 0x2D1D311 VA: 0x2D1D210
	private void BuildStyleCache() { }

	// RVA: 0x2D0AE80 Offset: 0x2D0AF81 VA: 0x2D0AE80
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x2D1F0C0 Offset: 0x2D1F1C1 VA: 0x2D1F0C0
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x2D03D20 Offset: 0x2D03E21 VA: 0x2D03D20
	internal void MakeCurrent() { }

	// RVA: 0x2D1F390 Offset: 0x2D1F491 VA: 0x2D1F390
	public IEnumerator GetEnumerator() { }
}

