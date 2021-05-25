[AddComponentMenu] // RVA: 0x13ED40 Offset: 0x13EE41 VA: 0x13ED40
public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 5802
{
	// Fields
	protected TouchScreenKeyboard m_SoftKeyboard; // 0xF8
	private static readonly char[] kSeparators; // 0x0
	protected RectTransform m_RectTransform; // 0x100
	[SerializeField] // RVA: 0x13F740 Offset: 0x13F841 VA: 0x13F740
	protected RectTransform m_TextViewport; // 0x108
	protected RectMask2D m_TextComponentRectMask; // 0x110
	protected RectMask2D m_TextViewportRectMask; // 0x118
	private Rect m_CachedViewportRect; // 0x120
	[SerializeField] // RVA: 0x13F750 Offset: 0x13F851 VA: 0x13F750
	protected TMP_Text m_TextComponent; // 0x130
	protected RectTransform m_TextComponentRectTransform; // 0x138
	[SerializeField] // RVA: 0x13F760 Offset: 0x13F861 VA: 0x13F760
	protected Graphic m_Placeholder; // 0x140
	[SerializeField] // RVA: 0x13F770 Offset: 0x13F871 VA: 0x13F770
	protected Scrollbar m_VerticalScrollbar; // 0x148
	[SerializeField] // RVA: 0x13F780 Offset: 0x13F881 VA: 0x13F780
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x150
	private bool m_IsDrivenByLayoutComponents; // 0x158
	[SerializeField] // RVA: 0x13F790 Offset: 0x13F891 VA: 0x13F790
	private LayoutGroup m_LayoutGroup; // 0x160
	private float m_ScrollPosition; // 0x168
	[SerializeField] // RVA: 0x13F7A0 Offset: 0x13F8A1 VA: 0x13F7A0
	protected float m_ScrollSensitivity; // 0x16C
	[SerializeField] // RVA: 0x13F7B0 Offset: 0x13F8B1 VA: 0x13F7B0
	private TMP_InputField.ContentType m_ContentType; // 0x170
	[SerializeField] // RVA: 0x13F7C0 Offset: 0x13F8C1 VA: 0x13F7C0
	private TMP_InputField.InputType m_InputType; // 0x174
	[SerializeField] // RVA: 0x13F7D0 Offset: 0x13F8D1 VA: 0x13F7D0
	private char m_AsteriskChar; // 0x178
	[SerializeField] // RVA: 0x13F7E0 Offset: 0x13F8E1 VA: 0x13F7E0
	private TouchScreenKeyboardType m_KeyboardType; // 0x17C
	[SerializeField] // RVA: 0x13F7F0 Offset: 0x13F8F1 VA: 0x13F7F0
	private TMP_InputField.LineType m_LineType; // 0x180
	[SerializeField] // RVA: 0x13F800 Offset: 0x13F901 VA: 0x13F800
	private bool m_HideMobileInput; // 0x184
	[SerializeField] // RVA: 0x13F810 Offset: 0x13F911 VA: 0x13F810
	private bool m_HideSoftKeyboard; // 0x185
	[SerializeField] // RVA: 0x13F820 Offset: 0x13F921 VA: 0x13F820
	private TMP_InputField.CharacterValidation m_CharacterValidation; // 0x188
	[SerializeField] // RVA: 0x13F830 Offset: 0x13F931 VA: 0x13F830
	private string m_RegexValue; // 0x190
	[SerializeField] // RVA: 0x13F840 Offset: 0x13F941 VA: 0x13F840
	private float m_GlobalPointSize; // 0x198
	[SerializeField] // RVA: 0x13F850 Offset: 0x13F951 VA: 0x13F850
	private int m_CharacterLimit; // 0x19C
	[SerializeField] // RVA: 0x13F860 Offset: 0x13F961 VA: 0x13F860
	private TMP_InputField.SubmitEvent m_OnEndEdit; // 0x1A0
	[SerializeField] // RVA: 0x13F870 Offset: 0x13F971 VA: 0x13F870
	private TMP_InputField.SubmitEvent m_OnSubmit; // 0x1A8
	[SerializeField] // RVA: 0x13F880 Offset: 0x13F981 VA: 0x13F880
	private TMP_InputField.SelectionEvent m_OnSelect; // 0x1B0
	[SerializeField] // RVA: 0x13F890 Offset: 0x13F991 VA: 0x13F890
	private TMP_InputField.SelectionEvent m_OnDeselect; // 0x1B8
	[SerializeField] // RVA: 0x13F8A0 Offset: 0x13F9A1 VA: 0x13F8A0
	private TMP_InputField.TextSelectionEvent m_OnTextSelection; // 0x1C0
	[SerializeField] // RVA: 0x13F8B0 Offset: 0x13F9B1 VA: 0x13F8B0
	private TMP_InputField.TextSelectionEvent m_OnEndTextSelection; // 0x1C8
	[SerializeField] // RVA: 0x13F8C0 Offset: 0x13F9C1 VA: 0x13F8C0
	private TMP_InputField.OnChangeEvent m_OnValueChanged; // 0x1D0
	[SerializeField] // RVA: 0x13F8D0 Offset: 0x13F9D1 VA: 0x13F8D0
	private TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x1D8
	[SerializeField] // RVA: 0x13F8E0 Offset: 0x13F9E1 VA: 0x13F8E0
	private TMP_InputField.OnValidateInput m_OnValidateInput; // 0x1E0
	[SerializeField] // RVA: 0x13F8F0 Offset: 0x13F9F1 VA: 0x13F8F0
	private Color m_CaretColor; // 0x1E8
	[SerializeField] // RVA: 0x13F900 Offset: 0x13FA01 VA: 0x13F900
	private bool m_CustomCaretColor; // 0x1F8
	[SerializeField] // RVA: 0x13F910 Offset: 0x13FA11 VA: 0x13F910
	private Color m_SelectionColor; // 0x1FC
	[SerializeField] // RVA: 0x13F920 Offset: 0x13FA21 VA: 0x13F920
	[TextAreaAttribute] // RVA: 0x13F920 Offset: 0x13FA21 VA: 0x13F920
	protected string m_Text; // 0x210
	[SerializeField] // RVA: 0x13F960 Offset: 0x13FA61 VA: 0x13F960
	[RangeAttribute] // RVA: 0x13F960 Offset: 0x13FA61 VA: 0x13F960
	private float m_CaretBlinkRate; // 0x218
	[SerializeField] // RVA: 0x13F9A0 Offset: 0x13FAA1 VA: 0x13F9A0
	[RangeAttribute] // RVA: 0x13F9A0 Offset: 0x13FAA1 VA: 0x13F9A0
	private int m_CaretWidth; // 0x21C
	[SerializeField] // RVA: 0x13F9E0 Offset: 0x13FAE1 VA: 0x13F9E0
	private bool m_ReadOnly; // 0x220
	[SerializeField] // RVA: 0x13F9F0 Offset: 0x13FAF1 VA: 0x13F9F0
	private bool m_RichText; // 0x221
	protected int m_StringPosition; // 0x224
	protected int m_StringSelectPosition; // 0x228
	protected int m_CaretPosition; // 0x22C
	protected int m_CaretSelectPosition; // 0x230
	private RectTransform caretRectTrans; // 0x238
	protected UIVertex[] m_CursorVerts; // 0x240
	private CanvasRenderer m_CachedInputRenderer; // 0x248
	private Vector2 m_LastPosition; // 0x250
	protected Mesh m_Mesh; // 0x258
	private bool m_AllowInput; // 0x260
	private bool m_ShouldActivateNextUpdate; // 0x261
	private bool m_UpdateDrag; // 0x262
	private bool m_DragPositionOutOfBounds; // 0x263
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
	protected bool m_CaretVisible; // 0x264
	private Coroutine m_BlinkCoroutine; // 0x268
	private float m_BlinkStartTime; // 0x270
	private Coroutine m_DragCoroutine; // 0x278
	private string m_OriginalText; // 0x280
	private bool m_WasCanceled; // 0x288
	private bool m_HasDoneFocusTransition; // 0x289
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x290
	private bool m_PreventCallback; // 0x298
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x299
	private bool m_IsTextComponentUpdateRequired; // 0x29A
	private bool m_IsScrollbarUpdateRequired; // 0x29B
	private bool m_IsUpdatingScrollbarValues; // 0x29C
	private bool m_isLastKeyBackspace; // 0x29D
	private float m_PointerDownClickStartTime; // 0x2A0
	private float m_KeyDownStartTime; // 0x2A4
	private float m_DoubleClickDelay; // 0x2A8
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private bool m_IsCompositionActive; // 0x2AC
	private bool m_ShouldUpdateIMEWindowPosition; // 0x2AD
	private int m_PreviousIMEInsertionLine; // 0x2B0
	[SerializeField] // RVA: 0x13FA00 Offset: 0x13FB01 VA: 0x13FA00
	protected TMP_FontAsset m_GlobalFontAsset; // 0x2B8
	[SerializeField] // RVA: 0x13FA10 Offset: 0x13FB11 VA: 0x13FA10
	protected bool m_OnFocusSelectAll; // 0x2C0
	protected bool m_isSelectAll; // 0x2C1
	[SerializeField] // RVA: 0x13FA20 Offset: 0x13FB21 VA: 0x13FA20
	protected bool m_ResetOnDeActivation; // 0x2C2
	private bool m_SelectionStillActive; // 0x2C3
	private bool m_ReleaseSelection; // 0x2C4
	private GameObject m_PreviouslySelectedObject; // 0x2C8
	[SerializeField] // RVA: 0x13FA30 Offset: 0x13FB31 VA: 0x13FA30
	private bool m_RestoreOriginalTextOnEscape; // 0x2D0
	[SerializeField] // RVA: 0x13FA40 Offset: 0x13FB41 VA: 0x13FA40
	protected bool m_isRichTextEditingAllowed; // 0x2D1
	[SerializeField] // RVA: 0x13FA50 Offset: 0x13FB51 VA: 0x13FA50
	protected int m_LineLimit; // 0x2D4
	[SerializeField] // RVA: 0x13FA60 Offset: 0x13FB61 VA: 0x13FA60
	protected TMP_InputValidator m_InputValidator; // 0x2D8
	private bool m_isSelected; // 0x2E0
	private bool m_IsStringPositionDirty; // 0x2E1
	private bool m_IsCaretPositionDirty; // 0x2E2
	private bool m_forceRectTransformAdjustment; // 0x2E3
	private Event m_ProcessingEvent; // 0x2E8

	// Properties
	private BaseInput inputSystem { get; }
	private string compositionString { get; }
	private int compositionLength { get; }
	protected Mesh mesh { get; }
	public bool shouldHideMobileInput { get; set; }
	public bool shouldHideSoftKeyboard { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public RectTransform textViewport { get; set; }
	public TMP_Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public float scrollSensitivity { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public TMP_InputField.SubmitEvent onEndEdit { get; set; }
	public TMP_InputField.SubmitEvent onSubmit { get; set; }
	public TMP_InputField.SelectionEvent onSelect { get; set; }
	public TMP_InputField.SelectionEvent onDeselect { get; set; }
	public TMP_InputField.TextSelectionEvent onTextSelection { get; set; }
	public TMP_InputField.TextSelectionEvent onEndTextSelection { get; set; }
	public TMP_InputField.OnChangeEvent onValueChanged { get; set; }
	public TMP_InputField.TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; }
	public TMP_InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public float pointSize { get; set; }
	public TMP_FontAsset fontAsset { get; set; }
	public bool onFocusSelectAll { get; set; }
	public bool resetOnDeActivation { get; set; }
	public bool restoreOriginalTextOnEscape { get; set; }
	public bool isRichTextEditingAllowed { get; set; }
	public TMP_InputField.ContentType contentType { get; set; }
	public TMP_InputField.LineType lineType { get; set; }
	public int lineLimit { get; set; }
	public TMP_InputField.InputType inputType { get; set; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public TMP_InputField.CharacterValidation characterValidation { get; set; }
	public TMP_InputValidator inputValidator { get; set; }
	public bool readOnly { get; set; }
	public bool richText { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int stringPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	protected int stringSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	public int stringPosition { get; set; }
	public int selectionStringAnchorPosition { get; set; }
	public int selectionStringFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x155F1F0 Offset: 0x155F2F1 VA: 0x155F1F0
	private BaseInput get_inputSystem() { }

	// RVA: 0x155F350 Offset: 0x155F451 VA: 0x155F350
	private string get_compositionString() { }

	// RVA: 0x155F3F0 Offset: 0x155F4F1 VA: 0x155F3F0
	private int get_compositionLength() { }

	// RVA: 0x155F430 Offset: 0x155F531 VA: 0x155F430
	protected void .ctor() { }

	// RVA: 0x155FAF0 Offset: 0x155FBF1 VA: 0x155FAF0
	protected Mesh get_mesh() { }

	// RVA: 0x155FBA0 Offset: 0x155FCA1 VA: 0x155FBA0
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x155FC00 Offset: 0x155FD01 VA: 0x155FC00
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x155FCA0 Offset: 0x155FDA1 VA: 0x155FCA0
	public bool get_shouldHideSoftKeyboard() { }

	// RVA: 0x155FD30 Offset: 0x155FE31 VA: 0x155FD30
	public void set_shouldHideSoftKeyboard(bool value) { }

	// RVA: 0x155FE60 Offset: 0x155FF61 VA: 0x155FE60
	private bool isKeyboardUsingEvents() { }

	// RVA: 0x155FEA0 Offset: 0x155FFA1 VA: 0x155FEA0
	public string get_text() { }

	// RVA: 0x155FEB0 Offset: 0x155FFB1 VA: 0x155FEB0
	public void set_text(string value) { }

	// RVA: 0x1560040 Offset: 0x1560141 VA: 0x1560040
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x155FEC0 Offset: 0x155FFC1 VA: 0x155FEC0
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0x1560800 Offset: 0x1560901 VA: 0x1560800
	public bool get_isFocused() { }

	// RVA: 0x1560810 Offset: 0x1560911 VA: 0x1560810
	public float get_caretBlinkRate() { }

	// RVA: 0x1560820 Offset: 0x1560921 VA: 0x1560820
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x15609A0 Offset: 0x1560AA1 VA: 0x15609A0
	public int get_caretWidth() { }

	// RVA: 0x15609B0 Offset: 0x1560AB1 VA: 0x15609B0
	public void set_caretWidth(int value) { }

	// RVA: 0x1560AF0 Offset: 0x1560BF1 VA: 0x1560AF0
	public RectTransform get_textViewport() { }

	// RVA: 0x1560B00 Offset: 0x1560C01 VA: 0x1560B00
	public void set_textViewport(RectTransform value) { }

	// RVA: 0x1560B60 Offset: 0x1560C61 VA: 0x1560B60
	public TMP_Text get_textComponent() { }

	// RVA: 0x1560B70 Offset: 0x1560C71 VA: 0x1560B70
	public void set_textComponent(TMP_Text value) { }

	// RVA: 0x1560BF0 Offset: 0x1560CF1 VA: 0x1560BF0
	public Graphic get_placeholder() { }

	// RVA: 0x1560C00 Offset: 0x1560D01 VA: 0x1560C00
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1560C60 Offset: 0x1560D61 VA: 0x1560C60
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x1560C70 Offset: 0x1560D71 VA: 0x1560C70
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x1560E20 Offset: 0x1560F21 VA: 0x1560E20
	public float get_scrollSensitivity() { }

	// RVA: 0x1560E30 Offset: 0x1560F31 VA: 0x1560E30
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x1560F00 Offset: 0x1561001 VA: 0x1560F00
	public Color get_caretColor() { }

	// RVA: 0x1560F50 Offset: 0x1561051 VA: 0x1560F50
	public void set_caretColor(Color value) { }

	// RVA: 0x1560FE0 Offset: 0x15610E1 VA: 0x1560FE0
	public bool get_customCaretColor() { }

	// RVA: 0x1560FF0 Offset: 0x15610F1 VA: 0x1560FF0
	public void set_customCaretColor(bool value) { }

	// RVA: 0x1561080 Offset: 0x1561181 VA: 0x1561080
	public Color get_selectionColor() { }

	// RVA: 0x15610A0 Offset: 0x15611A1 VA: 0x15610A0
	public void set_selectionColor(Color value) { }

	// RVA: 0x1561130 Offset: 0x1561231 VA: 0x1561130
	public TMP_InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0x1561140 Offset: 0x1561241 VA: 0x1561140
	public void set_onEndEdit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x15611A0 Offset: 0x15612A1 VA: 0x15611A0
	public TMP_InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0x15611B0 Offset: 0x15612B1 VA: 0x15611B0
	public void set_onSubmit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x1561210 Offset: 0x1561311 VA: 0x1561210
	public TMP_InputField.SelectionEvent get_onSelect() { }

	// RVA: 0x1561220 Offset: 0x1561321 VA: 0x1561220
	public void set_onSelect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x1561280 Offset: 0x1561381 VA: 0x1561280
	public TMP_InputField.SelectionEvent get_onDeselect() { }

	// RVA: 0x1561290 Offset: 0x1561391 VA: 0x1561290
	public void set_onDeselect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x15612F0 Offset: 0x15613F1 VA: 0x15612F0
	public TMP_InputField.TextSelectionEvent get_onTextSelection() { }

	// RVA: 0x1561300 Offset: 0x1561401 VA: 0x1561300
	public void set_onTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0x1561360 Offset: 0x1561461 VA: 0x1561360
	public TMP_InputField.TextSelectionEvent get_onEndTextSelection() { }

	// RVA: 0x1561370 Offset: 0x1561471 VA: 0x1561370
	public void set_onEndTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0x15613D0 Offset: 0x15614D1 VA: 0x15613D0
	public TMP_InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x15613E0 Offset: 0x15614E1 VA: 0x15613E0
	public void set_onValueChanged(TMP_InputField.OnChangeEvent value) { }

	// RVA: 0x1561440 Offset: 0x1561541 VA: 0x1561440
	public TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	// RVA: 0x1561450 Offset: 0x1561551 VA: 0x1561450
	public void set_onTouchScreenKeyboardStatusChanged(TMP_InputField.TouchScreenKeyboardEvent value) { }

	// RVA: 0x15614B0 Offset: 0x15615B1 VA: 0x15614B0
	public TMP_InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x15614C0 Offset: 0x15615C1 VA: 0x15614C0
	public void set_onValidateInput(TMP_InputField.OnValidateInput value) { }

	// RVA: 0x1561520 Offset: 0x1561621 VA: 0x1561520
	public int get_characterLimit() { }

	// RVA: 0x1561530 Offset: 0x1561631 VA: 0x1561530
	public void set_characterLimit(int value) { }

	// RVA: 0x1561600 Offset: 0x1561701 VA: 0x1561600
	public float get_pointSize() { }

	// RVA: 0x1561610 Offset: 0x1561711 VA: 0x1561610
	public void set_pointSize(float value) { }

	// RVA: 0x15617C0 Offset: 0x15618C1 VA: 0x15617C0
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x15617D0 Offset: 0x15618D1 VA: 0x15617D0
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x1561950 Offset: 0x1561A51 VA: 0x1561950
	public bool get_onFocusSelectAll() { }

	// RVA: 0x1561960 Offset: 0x1561A61 VA: 0x1561960
	public void set_onFocusSelectAll(bool value) { }

	// RVA: 0x1561970 Offset: 0x1561A71 VA: 0x1561970
	public bool get_resetOnDeActivation() { }

	// RVA: 0x1561980 Offset: 0x1561A81 VA: 0x1561980
	public void set_resetOnDeActivation(bool value) { }

	// RVA: 0x1561990 Offset: 0x1561A91 VA: 0x1561990
	public bool get_restoreOriginalTextOnEscape() { }

	// RVA: 0x15619A0 Offset: 0x1561AA1 VA: 0x15619A0
	public void set_restoreOriginalTextOnEscape(bool value) { }

	// RVA: 0x15619B0 Offset: 0x1561AB1 VA: 0x15619B0
	public bool get_isRichTextEditingAllowed() { }

	// RVA: 0x15619C0 Offset: 0x1561AC1 VA: 0x15619C0
	public void set_isRichTextEditingAllowed(bool value) { }

	// RVA: 0x15619D0 Offset: 0x1561AD1 VA: 0x15619D0
	public TMP_InputField.ContentType get_contentType() { }

	// RVA: 0x15619E0 Offset: 0x1561AE1 VA: 0x15619E0
	public void set_contentType(TMP_InputField.ContentType value) { }

	// RVA: 0x1561BE0 Offset: 0x1561CE1 VA: 0x1561BE0
	public TMP_InputField.LineType get_lineType() { }

	// RVA: 0x1561BF0 Offset: 0x1561CF1 VA: 0x1561BF0
	public void set_lineType(TMP_InputField.LineType value) { }

	// RVA: 0x1561D60 Offset: 0x1561E61 VA: 0x1561D60
	public int get_lineLimit() { }

	// RVA: 0x1561D70 Offset: 0x1561E71 VA: 0x1561D70
	public void set_lineLimit(int value) { }

	// RVA: 0x1561DF0 Offset: 0x1561EF1 VA: 0x1561DF0
	public TMP_InputField.InputType get_inputType() { }

	// RVA: 0x1561E00 Offset: 0x1561F01 VA: 0x1561E00
	public void set_inputType(TMP_InputField.InputType value) { }

	// RVA: 0x1561EB0 Offset: 0x1561FB1 VA: 0x1561EB0
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x1561EC0 Offset: 0x1561FC1 VA: 0x1561EC0
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x1561F50 Offset: 0x1562051 VA: 0x1561F50
	public TMP_InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x1561F60 Offset: 0x1562061 VA: 0x1561F60
	public void set_characterValidation(TMP_InputField.CharacterValidation value) { }

	// RVA: 0x1561FF0 Offset: 0x15620F1 VA: 0x1561FF0
	public TMP_InputValidator get_inputValidator() { }

	// RVA: 0x1562000 Offset: 0x1562101 VA: 0x1562000
	public void set_inputValidator(TMP_InputValidator value) { }

	// RVA: 0x15620B0 Offset: 0x15621B1 VA: 0x15620B0
	public bool get_readOnly() { }

	// RVA: 0x15620C0 Offset: 0x15621C1 VA: 0x15620C0
	public void set_readOnly(bool value) { }

	// RVA: 0x15620D0 Offset: 0x15621D1 VA: 0x15620D0
	public bool get_richText() { }

	// RVA: 0x15620E0 Offset: 0x15621E1 VA: 0x15620E0
	public void set_richText(bool value) { }

	// RVA: 0x1562220 Offset: 0x1562321 VA: 0x1562220
	public bool get_multiLine() { }

	// RVA: 0x1562240 Offset: 0x1562341 VA: 0x1562240
	public char get_asteriskChar() { }

	// RVA: 0x1562250 Offset: 0x1562351 VA: 0x1562250
	public void set_asteriskChar(char value) { }

	// RVA: 0x15622D0 Offset: 0x15623D1 VA: 0x15622D0
	public bool get_wasCanceled() { }

	// RVA: 0x15622E0 Offset: 0x15623E1 VA: 0x15622E0
	protected void ClampStringPos(ref int pos) { }

	// RVA: 0x1562320 Offset: 0x1562421 VA: 0x1562320
	protected void ClampCaretPos(ref int pos) { }

	// RVA: 0x1562370 Offset: 0x1562471 VA: 0x1562370
	protected int get_caretPositionInternal() { }

	// RVA: 0x15623C0 Offset: 0x15624C1 VA: 0x15623C0
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x1562410 Offset: 0x1562511 VA: 0x1562410
	protected int get_stringPositionInternal() { }

	// RVA: 0x1562460 Offset: 0x1562561 VA: 0x1562460
	protected void set_stringPositionInternal(int value) { }

	// RVA: 0x15624A0 Offset: 0x15625A1 VA: 0x15624A0
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x15624F0 Offset: 0x15625F1 VA: 0x15624F0
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x1562540 Offset: 0x1562641 VA: 0x1562540
	protected int get_stringSelectPositionInternal() { }

	// RVA: 0x1562590 Offset: 0x1562691 VA: 0x1562590
	protected void set_stringSelectPositionInternal(int value) { }

	// RVA: 0x15625D0 Offset: 0x15626D1 VA: 0x15625D0
	private bool get_hasSelection() { }

	// RVA: 0x1562650 Offset: 0x1562751 VA: 0x1562650
	public int get_caretPosition() { }

	// RVA: 0x15626A0 Offset: 0x15627A1 VA: 0x15626A0
	public void set_caretPosition(int value) { }

	// RVA: 0x15628A0 Offset: 0x15629A1 VA: 0x15628A0
	public int get_selectionAnchorPosition() { }

	// RVA: 0x1562780 Offset: 0x1562881 VA: 0x1562780
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x15628F0 Offset: 0x15629F1 VA: 0x15628F0
	public int get_selectionFocusPosition() { }

	// RVA: 0x1562810 Offset: 0x1562911 VA: 0x1562810
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x1562940 Offset: 0x1562A41 VA: 0x1562940
	public int get_stringPosition() { }

	// RVA: 0x1562990 Offset: 0x1562A91 VA: 0x1562990
	public void set_stringPosition(int value) { }

	// RVA: 0x1562B60 Offset: 0x1562C61 VA: 0x1562B60
	public int get_selectionStringAnchorPosition() { }

	// RVA: 0x1562A60 Offset: 0x1562B61 VA: 0x1562A60
	public void set_selectionStringAnchorPosition(int value) { }

	// RVA: 0x1562BB0 Offset: 0x1562CB1 VA: 0x1562BB0
	public int get_selectionStringFocusPosition() { }

	// RVA: 0x1562AE0 Offset: 0x1562BE1 VA: 0x1562AE0
	public void set_selectionStringFocusPosition(int value) { }

	// RVA: 0x1562C00 Offset: 0x1562D01 VA: 0x1562C00 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15638B0 Offset: 0x15639B1 VA: 0x15638B0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1563E00 Offset: 0x1563F01 VA: 0x1563E00
	private void ON_TEXT_CHANGED(Object obj) { }

	[IteratorStateMachineAttribute] // RVA: 0x140520 Offset: 0x140621 VA: 0x140520
	// RVA: 0x15640E0 Offset: 0x15641E1 VA: 0x15640E0
	private IEnumerator CaretBlink() { }

	// RVA: 0x1564190 Offset: 0x1564291 VA: 0x1564190
	private void SetCaretVisible() { }

	// RVA: 0x15608B0 Offset: 0x15609B1 VA: 0x15608B0
	private void SetCaretActive() { }

	// RVA: 0x15641D0 Offset: 0x15642D1 VA: 0x15641D0
	protected void OnFocus() { }

	// RVA: 0x1564230 Offset: 0x1564331 VA: 0x1564230
	protected void SelectAll() { }

	// RVA: 0x1564290 Offset: 0x1564391 VA: 0x1564290
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x1564520 Offset: 0x1564621 VA: 0x1564520
	public void MoveTextStart(bool shift) { }

	// RVA: 0x15646E0 Offset: 0x15647E1 VA: 0x15646E0
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	// RVA: 0x1564910 Offset: 0x1564A11 VA: 0x1564910
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	// RVA: 0x1564B50 Offset: 0x1564C51 VA: 0x1564B50
	private static string get_clipboard() { }

	// RVA: 0x1564B60 Offset: 0x1564C61 VA: 0x1564B60
	private static void set_clipboard(string value) { }

	// RVA: 0x1564B70 Offset: 0x1564C71 VA: 0x1564B70
	private bool InPlaceEditing() { }

	// RVA: 0x1564CD0 Offset: 0x1564DD1 VA: 0x1564CD0
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0x1564FB0 Offset: 0x15650B1 VA: 0x1564FB0 Slot: 60
	protected virtual void LateUpdate() { }

	// RVA: 0x1566C80 Offset: 0x1566D81 VA: 0x1566C80
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1566E70 Offset: 0x1566F71 VA: 0x1566E70 Slot: 61
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1566EA0 Offset: 0x1566FA1 VA: 0x1566EA0 Slot: 62
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x140590 Offset: 0x140691 VA: 0x140590
	// RVA: 0x1567320 Offset: 0x1567421 VA: 0x1567320
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x15673F0 Offset: 0x15674F1 VA: 0x15673F0 Slot: 63
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1567420 Offset: 0x1567521 VA: 0x1567420 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1567DF0 Offset: 0x1567EF1 VA: 0x1567DF0
	protected TMP_InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x156A0B0 Offset: 0x156A1B1 VA: 0x156A0B0 Slot: 64
	protected virtual bool IsValidChar(char c) { }

	// RVA: 0x156A0D0 Offset: 0x156A1D1 VA: 0x156A0D0
	public void ProcessEvent(Event e) { }

	// RVA: 0x156A0E0 Offset: 0x156A1E1 VA: 0x156A0E0 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x156A390 Offset: 0x156A491 VA: 0x156A390 Slot: 66
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x1568DF0 Offset: 0x1568EF1 VA: 0x1568DF0
	private string GetSelectedString() { }

	// RVA: 0x156A520 Offset: 0x156A621 VA: 0x156A520
	private int FindNextWordBegin() { }

	// RVA: 0x1569920 Offset: 0x1569A21 VA: 0x1569920
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x156A640 Offset: 0x156A741 VA: 0x156A640
	private int FindPrevWordBegin() { }

	// RVA: 0x15691A0 Offset: 0x15692A1 VA: 0x15691A0
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x156A750 Offset: 0x156A851 VA: 0x156A750
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x156A960 Offset: 0x156AA61 VA: 0x156A960
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x156AB70 Offset: 0x156AC71 VA: 0x156AB70
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x156AE20 Offset: 0x156AF21 VA: 0x156AE20
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x156A080 Offset: 0x156A181 VA: 0x156A080
	private void MoveDown(bool shift) { }

	// RVA: 0x156B0D0 Offset: 0x156B1D1 VA: 0x156B0D0
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x156A070 Offset: 0x156A171 VA: 0x156A070
	private void MoveUp(bool shift) { }

	// RVA: 0x156B440 Offset: 0x156B541 VA: 0x156B440
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x156A090 Offset: 0x156A191 VA: 0x156A090
	private void MovePageUp(bool shift) { }

	// RVA: 0x156B7A0 Offset: 0x156B8A1 VA: 0x156B7A0
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x156A0A0 Offset: 0x156A1A1 VA: 0x156A0A0
	private void MovePageDown(bool shift) { }

	// RVA: 0x156BCA0 Offset: 0x156BDA1 VA: 0x156BCA0
	private void MovePageDown(bool shift, bool goToLastChar) { }

	// RVA: 0x1568F30 Offset: 0x1569031 VA: 0x1568F30
	private void Delete() { }

	// RVA: 0x15689E0 Offset: 0x1568AE1 VA: 0x15689E0
	private void DeleteKey() { }

	// RVA: 0x15682F0 Offset: 0x15683F1 VA: 0x15682F0
	private void Backspace() { }

	// RVA: 0x156C1B0 Offset: 0x156C2B1 VA: 0x156C1B0 Slot: 67
	protected virtual void Append(string input) { }

	// RVA: 0x156C270 Offset: 0x156C371 VA: 0x156C270 Slot: 68
	protected virtual void Append(char input) { }

	// RVA: 0x156C400 Offset: 0x156C501 VA: 0x156C400
	private void Insert(char c) { }

	// RVA: 0x1569150 Offset: 0x1569251 VA: 0x1569150
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x1566C10 Offset: 0x1566D11 VA: 0x1566C10
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x1560790 Offset: 0x1560891 VA: 0x1560790
	private void SendOnValueChanged() { }

	// RVA: 0x156C580 Offset: 0x156C681 VA: 0x156C580
	protected void SendOnEndEdit() { }

	// RVA: 0x156A320 Offset: 0x156A421 VA: 0x156A320
	protected void SendOnSubmit() { }

	// RVA: 0x156C5F0 Offset: 0x156C6F1 VA: 0x156C5F0
	protected void SendOnFocus() { }

	// RVA: 0x156C660 Offset: 0x156C761 VA: 0x156C660
	protected void SendOnFocusLost() { }

	// RVA: 0x156C6D0 Offset: 0x156C7D1 VA: 0x156C6D0
	protected void SendOnTextSelection() { }

	// RVA: 0x156C7B0 Offset: 0x156C8B1 VA: 0x156C7B0
	protected void SendOnEndTextSelection() { }

	// RVA: 0x1565FF0 Offset: 0x15660F1 VA: 0x1565FF0
	protected void SendTouchScreenKeyboardStatusChanged() { }

	// RVA: 0x15601C0 Offset: 0x15602C1 VA: 0x15601C0
	protected void UpdateLabel() { }

	// RVA: 0x1565DA0 Offset: 0x1565EA1 VA: 0x1565DA0
	private void UpdateScrollbar() { }

	// RVA: 0x156C890 Offset: 0x156C991 VA: 0x156C890
	private void OnScrollbarValueChange(float value) { }

	// RVA: 0x15638A0 Offset: 0x15639A1 VA: 0x15638A0
	private void UpdateMaskRegions() { }

	// RVA: 0x1560050 Offset: 0x1560151 VA: 0x1560050
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	// RVA: 0x1564060 Offset: 0x1564161 VA: 0x1564060
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x156C900 Offset: 0x156CA01 VA: 0x156C900
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x156C990 Offset: 0x156CA91 VA: 0x156C990
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x15644A0 Offset: 0x15645A1 VA: 0x15644A0
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	// RVA: 0x156CA10 Offset: 0x156CB11 VA: 0x156CA10
	public void ForceLabelUpdate() { }

	// RVA: 0x1560A80 Offset: 0x1560B81 VA: 0x1560A80
	private void MarkGeometryAsDirty() { }

	// RVA: 0x156CA20 Offset: 0x156CB21 VA: 0x156CA20 Slot: 69
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x156CB00 Offset: 0x156CC01 VA: 0x156CB00 Slot: 70
	public virtual void LayoutComplete() { }

	// RVA: 0x156CB10 Offset: 0x156CC11 VA: 0x156CB10 Slot: 71
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x156CA30 Offset: 0x156CB31 VA: 0x156CA30
	private void UpdateGeometry() { }

	// RVA: 0x1563250 Offset: 0x1563351 VA: 0x1563250
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x156CB20 Offset: 0x156CC21 VA: 0x156CB20
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x156D030 Offset: 0x156D131 VA: 0x156D030
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x156E0D0 Offset: 0x156E1D1 VA: 0x156E0D0
	private void CreateCursorVerts() { }

	// RVA: 0x156D7E0 Offset: 0x156D8E1 VA: 0x156D7E0
	private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x156E280 Offset: 0x156E381 VA: 0x156E280
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	// RVA: 0x15664F0 Offset: 0x15665F1 VA: 0x15664F0
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x156E960 Offset: 0x156EA61 VA: 0x156E960
	public void ActivateInputField() { }

	// RVA: 0x1565760 Offset: 0x1565861 VA: 0x1565760
	private void ActivateInputFieldInternal() { }

	// RVA: 0x156EAA0 Offset: 0x156EBA1 VA: 0x156EAA0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x156EB10 Offset: 0x156EC11 VA: 0x156EB10 Slot: 72
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x156EB30 Offset: 0x156EC31 VA: 0x156EB30
	public void OnControlClick() { }

	// RVA: 0x1565F20 Offset: 0x1566021 VA: 0x1565F20
	public void ReleaseSelection() { }

	// RVA: 0x1563BC0 Offset: 0x1563CC1 VA: 0x1563BC0
	public void DeactivateInputField(bool clearSelection = False) { }

	// RVA: 0x156EB40 Offset: 0x156EC41 VA: 0x156EB40 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x156EBC0 Offset: 0x156ECC1 VA: 0x156EBC0 Slot: 73
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1561B20 Offset: 0x1561C21 VA: 0x1561B20
	private void EnforceContentType() { }

	// RVA: 0x155FA30 Offset: 0x155FB31 VA: 0x155FA30
	private void SetTextComponentWrapMode() { }

	// RVA: 0x1562180 Offset: 0x1562281 VA: 0x1562180
	private void SetTextComponentRichTextMode() { }

	// RVA: 0x1561CF0 Offset: 0x1561DF1 VA: 0x1561CF0
	private void SetToCustomIfContentTypeIsNot(TMP_InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x1561E90 Offset: 0x1561F91 VA: 0x1561E90
	private void SetToCustom() { }

	// RVA: 0x1562090 Offset: 0x1562191 VA: 0x1562090
	private void SetToCustom(TMP_InputField.CharacterValidation characterValidation) { }

	// RVA: 0x156EC70 Offset: 0x156ED71 VA: 0x156EC70 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x156ECB0 Offset: 0x156EDB1 VA: 0x156ECB0 Slot: 74
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x156ECC0 Offset: 0x156EDC1 VA: 0x156ECC0 Slot: 75
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x156ECD0 Offset: 0x156EDD1 VA: 0x156ECD0 Slot: 76
	public virtual float get_minWidth() { }

	// RVA: 0x156ECE0 Offset: 0x156EDE1 VA: 0x156ECE0 Slot: 77
	public virtual float get_preferredWidth() { }

	// RVA: 0x156EE50 Offset: 0x156EF51 VA: 0x156EE50 Slot: 78
	public virtual float get_flexibleWidth() { }

	// RVA: 0x156EE60 Offset: 0x156EF61 VA: 0x156EE60 Slot: 79
	public virtual float get_minHeight() { }

	// RVA: 0x156EE70 Offset: 0x156EF71 VA: 0x156EE70 Slot: 80
	public virtual float get_preferredHeight() { }

	// RVA: 0x156EFE0 Offset: 0x156F0E1 VA: 0x156EFE0 Slot: 81
	public virtual float get_flexibleHeight() { }

	// RVA: 0x156EFF0 Offset: 0x156F0F1 VA: 0x156EFF0 Slot: 82
	public virtual int get_layoutPriority() { }

	// RVA: 0x15616D0 Offset: 0x15617D1 VA: 0x15616D0
	public void SetGlobalPointSize(float pointSize) { }

	// RVA: 0x1561860 Offset: 0x1561961 VA: 0x1561860
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x156F000 Offset: 0x156F101 VA: 0x156F000
	private static void .cctor() { }

	// RVA: 0x156F080 Offset: 0x156F181 VA: 0x156F080 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

