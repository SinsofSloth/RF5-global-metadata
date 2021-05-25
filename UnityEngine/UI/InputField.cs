[AddComponentMenu] // RVA: 0x119ED0 Offset: 0x119FD1 VA: 0x119ED0
public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 3944
{
	// Fields
	protected TouchScreenKeyboard m_Keyboard; // 0xF8
	private static readonly char[] kSeparators; // 0x0
	[SerializeField] // RVA: 0x11B770 Offset: 0x11B871 VA: 0x11B770
	[FormerlySerializedAsAttribute] // RVA: 0x11B770 Offset: 0x11B871 VA: 0x11B770
	protected Text m_TextComponent; // 0x100
	[SerializeField] // RVA: 0x11B7C0 Offset: 0x11B8C1 VA: 0x11B7C0
	protected Graphic m_Placeholder; // 0x108
	[SerializeField] // RVA: 0x11B7D0 Offset: 0x11B8D1 VA: 0x11B7D0
	private InputField.ContentType m_ContentType; // 0x110
	[FormerlySerializedAsAttribute] // RVA: 0x11B7E0 Offset: 0x11B8E1 VA: 0x11B7E0
	[SerializeField] // RVA: 0x11B7E0 Offset: 0x11B8E1 VA: 0x11B7E0
	private InputField.InputType m_InputType; // 0x114
	[FormerlySerializedAsAttribute] // RVA: 0x11B830 Offset: 0x11B931 VA: 0x11B830
	[SerializeField] // RVA: 0x11B830 Offset: 0x11B931 VA: 0x11B830
	private char m_AsteriskChar; // 0x118
	[FormerlySerializedAsAttribute] // RVA: 0x11B880 Offset: 0x11B981 VA: 0x11B880
	[SerializeField] // RVA: 0x11B880 Offset: 0x11B981 VA: 0x11B880
	private TouchScreenKeyboardType m_KeyboardType; // 0x11C
	[SerializeField] // RVA: 0x11B8D0 Offset: 0x11B9D1 VA: 0x11B8D0
	private InputField.LineType m_LineType; // 0x120
	[FormerlySerializedAsAttribute] // RVA: 0x11B8E0 Offset: 0x11B9E1 VA: 0x11B8E0
	[SerializeField] // RVA: 0x11B8E0 Offset: 0x11B9E1 VA: 0x11B8E0
	private bool m_HideMobileInput; // 0x124
	[FormerlySerializedAsAttribute] // RVA: 0x11B930 Offset: 0x11BA31 VA: 0x11B930
	[SerializeField] // RVA: 0x11B930 Offset: 0x11BA31 VA: 0x11B930
	private InputField.CharacterValidation m_CharacterValidation; // 0x128
	[FormerlySerializedAsAttribute] // RVA: 0x11B980 Offset: 0x11BA81 VA: 0x11B980
	[SerializeField] // RVA: 0x11B980 Offset: 0x11BA81 VA: 0x11B980
	private int m_CharacterLimit; // 0x12C
	[FormerlySerializedAsAttribute] // RVA: 0x11B9D0 Offset: 0x11BAD1 VA: 0x11B9D0
	[FormerlySerializedAsAttribute] // RVA: 0x11B9D0 Offset: 0x11BAD1 VA: 0x11B9D0
	[FormerlySerializedAsAttribute] // RVA: 0x11B9D0 Offset: 0x11BAD1 VA: 0x11B9D0
	[SerializeField] // RVA: 0x11B9D0 Offset: 0x11BAD1 VA: 0x11B9D0
	private InputField.SubmitEvent m_OnEndEdit; // 0x130
	[FormerlySerializedAsAttribute] // RVA: 0x11BA70 Offset: 0x11BB71 VA: 0x11BA70
	[FormerlySerializedAsAttribute] // RVA: 0x11BA70 Offset: 0x11BB71 VA: 0x11BA70
	[SerializeField] // RVA: 0x11BA70 Offset: 0x11BB71 VA: 0x11BA70
	private InputField.OnChangeEvent m_OnValueChanged; // 0x138
	[FormerlySerializedAsAttribute] // RVA: 0x11BAE0 Offset: 0x11BBE1 VA: 0x11BAE0
	[SerializeField] // RVA: 0x11BAE0 Offset: 0x11BBE1 VA: 0x11BAE0
	private InputField.OnValidateInput m_OnValidateInput; // 0x140
	[FormerlySerializedAsAttribute] // RVA: 0x11BB30 Offset: 0x11BC31 VA: 0x11BB30
	[SerializeField] // RVA: 0x11BB30 Offset: 0x11BC31 VA: 0x11BB30
	private Color m_CaretColor; // 0x148
	[SerializeField] // RVA: 0x11BB80 Offset: 0x11BC81 VA: 0x11BB80
	private bool m_CustomCaretColor; // 0x158
	[SerializeField] // RVA: 0x11BB90 Offset: 0x11BC91 VA: 0x11BB90
	private Color m_SelectionColor; // 0x15C
	[SerializeField] // RVA: 0x11BBA0 Offset: 0x11BCA1 VA: 0x11BBA0
	[FormerlySerializedAsAttribute] // RVA: 0x11BBA0 Offset: 0x11BCA1 VA: 0x11BBA0
	protected string m_Text; // 0x170
	[SerializeField] // RVA: 0x11BBF0 Offset: 0x11BCF1 VA: 0x11BBF0
	[RangeAttribute] // RVA: 0x11BBF0 Offset: 0x11BCF1 VA: 0x11BBF0
	private float m_CaretBlinkRate; // 0x178
	[SerializeField] // RVA: 0x11BC30 Offset: 0x11BD31 VA: 0x11BC30
	[RangeAttribute] // RVA: 0x11BC30 Offset: 0x11BD31 VA: 0x11BC30
	private int m_CaretWidth; // 0x17C
	[SerializeField] // RVA: 0x11BC70 Offset: 0x11BD71 VA: 0x11BC70
	private bool m_ReadOnly; // 0x180
	protected int m_CaretPosition; // 0x184
	protected int m_CaretSelectPosition; // 0x188
	private RectTransform caretRectTrans; // 0x190
	protected UIVertex[] m_CursorVerts; // 0x198
	private TextGenerator m_InputTextCache; // 0x1A0
	private CanvasRenderer m_CachedInputRenderer; // 0x1A8
	private bool m_PreventFontCallback; // 0x1B0
	protected Mesh m_Mesh; // 0x1B8
	private bool m_AllowInput; // 0x1C0
	private bool m_ShouldActivateNextUpdate; // 0x1C1
	private bool m_UpdateDrag; // 0x1C2
	private bool m_DragPositionOutOfBounds; // 0x1C3
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
	protected bool m_CaretVisible; // 0x1C4
	private Coroutine m_BlinkCoroutine; // 0x1C8
	private float m_BlinkStartTime; // 0x1D0
	protected int m_DrawStart; // 0x1D4
	protected int m_DrawEnd; // 0x1D8
	private Coroutine m_DragCoroutine; // 0x1E0
	private string m_OriginalText; // 0x1E8
	private bool m_WasCanceled; // 0x1F0
	private bool m_HasDoneFocusTransition; // 0x1F1
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x1F8
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x200
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private Event m_ProcessingEvent; // 0x208
	private const int k_MaxTextLength = 16382;

	// Properties
	private BaseInput input { get; }
	private string compositionString { get; }
	protected Mesh mesh { get; }
	protected TextGenerator cachedInputTextGenerator { get; }
	public bool shouldHideMobileInput { get; set; }
	private bool shouldActivateOnSelect { get; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public InputField.SubmitEvent onEndEdit { get; set; }
	[ObsoleteAttribute] // RVA: 0x11DA00 Offset: 0x11DB01 VA: 0x11DA00
	public InputField.OnChangeEvent onValueChange { get; set; }
	public InputField.OnChangeEvent onValueChanged { get; set; }
	public InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public InputField.ContentType contentType { get; set; }
	public InputField.LineType lineType { get; set; }
	public InputField.InputType inputType { get; set; }
	public TouchScreenKeyboard touchScreenKeyboard { get; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public InputField.CharacterValidation characterValidation { get; set; }
	public bool readOnly { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1875930 Offset: 0x1875A31 VA: 0x1875930
	private BaseInput get_input() { }

	// RVA: 0x1875A90 Offset: 0x1875B91 VA: 0x1875A90
	private string get_compositionString() { }

	// RVA: 0x1875B30 Offset: 0x1875C31 VA: 0x1875B30
	protected void .ctor() { }

	// RVA: 0x1875DD0 Offset: 0x1875ED1 VA: 0x1875DD0
	protected Mesh get_mesh() { }

	// RVA: 0x1875E80 Offset: 0x1875F81 VA: 0x1875E80
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x1875F10 Offset: 0x1876011 VA: 0x1875F10
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x1875F70 Offset: 0x1876071 VA: 0x1875F70
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x1875FD0 Offset: 0x18760D1 VA: 0x1875FD0
	private bool get_shouldActivateOnSelect() { }

	// RVA: 0x1875FF0 Offset: 0x18760F1 VA: 0x1875FF0
	public string get_text() { }

	// RVA: 0x1876000 Offset: 0x1876101 VA: 0x1876000
	public void set_text(string value) { }

	// RVA: 0x1876380 Offset: 0x1876481 VA: 0x1876380
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x1876010 Offset: 0x1876111 VA: 0x1876010
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0x1876A00 Offset: 0x1876B01 VA: 0x1876A00
	public bool get_isFocused() { }

	// RVA: 0x1876A10 Offset: 0x1876B11 VA: 0x1876A10
	public float get_caretBlinkRate() { }

	// RVA: 0x1876A20 Offset: 0x1876B21 VA: 0x1876A20
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x1876BA0 Offset: 0x1876CA1 VA: 0x1876BA0
	public int get_caretWidth() { }

	// RVA: 0x1876BB0 Offset: 0x1876CB1 VA: 0x1876BB0
	public void set_caretWidth(int value) { }

	// RVA: 0x1876CF0 Offset: 0x1876DF1 VA: 0x1876CF0
	public Text get_textComponent() { }

	// RVA: 0x1876D00 Offset: 0x1876E01 VA: 0x1876D00
	public void set_textComponent(Text value) { }

	// RVA: 0x1877140 Offset: 0x1877241 VA: 0x1877140
	public Graphic get_placeholder() { }

	// RVA: 0x1877150 Offset: 0x1877251 VA: 0x1877150
	public void set_placeholder(Graphic value) { }

	// RVA: 0x18771B0 Offset: 0x18772B1 VA: 0x18771B0
	public Color get_caretColor() { }

	// RVA: 0x1877200 Offset: 0x1877301 VA: 0x1877200
	public void set_caretColor(Color value) { }

	// RVA: 0x1877290 Offset: 0x1877391 VA: 0x1877290
	public bool get_customCaretColor() { }

	// RVA: 0x18772A0 Offset: 0x18773A1 VA: 0x18772A0
	public void set_customCaretColor(bool value) { }

	// RVA: 0x1877330 Offset: 0x1877431 VA: 0x1877330
	public Color get_selectionColor() { }

	// RVA: 0x1877350 Offset: 0x1877451 VA: 0x1877350
	public void set_selectionColor(Color value) { }

	// RVA: 0x18773E0 Offset: 0x18774E1 VA: 0x18773E0
	public InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0x18773F0 Offset: 0x18774F1 VA: 0x18773F0
	public void set_onEndEdit(InputField.SubmitEvent value) { }

	// RVA: 0x1877450 Offset: 0x1877551 VA: 0x1877450
	public InputField.OnChangeEvent get_onValueChange() { }

	// RVA: 0x1877460 Offset: 0x1877561 VA: 0x1877460
	public void set_onValueChange(InputField.OnChangeEvent value) { }

	// RVA: 0x1877520 Offset: 0x1877621 VA: 0x1877520
	public InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x18774C0 Offset: 0x18775C1 VA: 0x18774C0
	public void set_onValueChanged(InputField.OnChangeEvent value) { }

	// RVA: 0x1877530 Offset: 0x1877631 VA: 0x1877530
	public InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x1877540 Offset: 0x1877641 VA: 0x1877540
	public void set_onValidateInput(InputField.OnValidateInput value) { }

	// RVA: 0x18775A0 Offset: 0x18776A1 VA: 0x18775A0
	public int get_characterLimit() { }

	// RVA: 0x18775B0 Offset: 0x18776B1 VA: 0x18775B0
	public void set_characterLimit(int value) { }

	// RVA: 0x1877680 Offset: 0x1877781 VA: 0x1877680
	public InputField.ContentType get_contentType() { }

	// RVA: 0x1877690 Offset: 0x1877791 VA: 0x1877690
	public void set_contentType(InputField.ContentType value) { }

	// RVA: 0x1877890 Offset: 0x1877991 VA: 0x1877890
	public InputField.LineType get_lineType() { }

	// RVA: 0x18778A0 Offset: 0x18779A1 VA: 0x18778A0
	public void set_lineType(InputField.LineType value) { }

	// RVA: 0x1877A10 Offset: 0x1877B11 VA: 0x1877A10
	public InputField.InputType get_inputType() { }

	// RVA: 0x1877A20 Offset: 0x1877B21 VA: 0x1877A20
	public void set_inputType(InputField.InputType value) { }

	// RVA: 0x1877AD0 Offset: 0x1877BD1 VA: 0x1877AD0
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x1877AE0 Offset: 0x1877BE1 VA: 0x1877AE0
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x1877AF0 Offset: 0x1877BF1 VA: 0x1877AF0
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x1877B80 Offset: 0x1877C81 VA: 0x1877B80
	public InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x1877B90 Offset: 0x1877C91 VA: 0x1877B90
	public void set_characterValidation(InputField.CharacterValidation value) { }

	// RVA: 0x1877C20 Offset: 0x1877D21 VA: 0x1877C20
	public bool get_readOnly() { }

	// RVA: 0x1877C30 Offset: 0x1877D31 VA: 0x1877C30
	public void set_readOnly(bool value) { }

	// RVA: 0x1877C40 Offset: 0x1877D41 VA: 0x1877C40
	public bool get_multiLine() { }

	// RVA: 0x1877C60 Offset: 0x1877D61 VA: 0x1877C60
	public char get_asteriskChar() { }

	// RVA: 0x1877C70 Offset: 0x1877D71 VA: 0x1877C70
	public void set_asteriskChar(char value) { }

	// RVA: 0x1877CF0 Offset: 0x1877DF1 VA: 0x1877CF0
	public bool get_wasCanceled() { }

	// RVA: 0x1877D00 Offset: 0x1877E01 VA: 0x1877D00
	protected void ClampPos(ref int pos) { }

	// RVA: 0x1877D40 Offset: 0x1877E41 VA: 0x1877D40
	protected int get_caretPositionInternal() { }

	// RVA: 0x1877D70 Offset: 0x1877E71 VA: 0x1877D70
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x1877DB0 Offset: 0x1877EB1 VA: 0x1877DB0
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x1877DE0 Offset: 0x1877EE1 VA: 0x1877DE0
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x1877E20 Offset: 0x1877F21 VA: 0x1877E20
	private bool get_hasSelection() { }

	// RVA: 0x1877E80 Offset: 0x1877F81 VA: 0x1877E80
	public int get_caretPosition() { }

	// RVA: 0x1877EB0 Offset: 0x1877FB1 VA: 0x1877EB0
	public void set_caretPosition(int value) { }

	// RVA: 0x1878050 Offset: 0x1878151 VA: 0x1878050
	public int get_selectionAnchorPosition() { }

	// RVA: 0x1877F70 Offset: 0x1878071 VA: 0x1877F70
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x1878080 Offset: 0x1878181 VA: 0x1878080
	public int get_selectionFocusPosition() { }

	// RVA: 0x1877FE0 Offset: 0x18780E1 VA: 0x1877FE0
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x18780B0 Offset: 0x18781B1 VA: 0x18780B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x18783F0 Offset: 0x18784F1 VA: 0x18783F0 Slot: 7
	protected override void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0x11CF70 Offset: 0x11D071 VA: 0x11CF70
	// RVA: 0x1878970 Offset: 0x1878A71 VA: 0x1878970
	private IEnumerator CaretBlink() { }

	// RVA: 0x18789F0 Offset: 0x1878AF1 VA: 0x18789F0
	private void SetCaretVisible() { }

	// RVA: 0x1876AB0 Offset: 0x1876BB1 VA: 0x1876AB0
	private void SetCaretActive() { }

	// RVA: 0x1878A30 Offset: 0x1878B31 VA: 0x1878A30
	private void UpdateCaretMaterial() { }

	// RVA: 0x1878B60 Offset: 0x1878C61 VA: 0x1878B60
	protected void OnFocus() { }

	// RVA: 0x1878BB0 Offset: 0x1878CB1 VA: 0x1878BB0
	protected void SelectAll() { }

	// RVA: 0x1878C00 Offset: 0x1878D01 VA: 0x1878C00
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x1878CE0 Offset: 0x1878DE1 VA: 0x1878CE0
	public void MoveTextStart(bool shift) { }

	// RVA: 0x1878DA0 Offset: 0x1878EA1 VA: 0x1878DA0
	private static string get_clipboard() { }

	// RVA: 0x1878DB0 Offset: 0x1878EB1 VA: 0x1878DB0
	private static void set_clipboard(string value) { }

	// RVA: 0x1878DC0 Offset: 0x1878EC1 VA: 0x1878DC0
	private bool InPlaceEditing() { }

	// RVA: 0x1878E10 Offset: 0x1878F11 VA: 0x1878E10
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x1878F40 Offset: 0x1879041 VA: 0x1878F40 Slot: 59
	protected virtual void LateUpdate() { }

	[ObsoleteAttribute] // RVA: 0x11CFE0 Offset: 0x11D0E1 VA: 0x11CFE0
	// RVA: 0x187AA50 Offset: 0x187AB51 VA: 0x187AA50
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x187AD90 Offset: 0x187AE91 VA: 0x187AD90
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x187AFD0 Offset: 0x187B0D1 VA: 0x187AFD0
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x187B470 Offset: 0x187B571 VA: 0x187B470
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x187B5D0 Offset: 0x187B6D1 VA: 0x187B5D0 Slot: 60
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x187B600 Offset: 0x187B701 VA: 0x187B600 Slot: 61
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x11D020 Offset: 0x11D121 VA: 0x11D020
	// RVA: 0x187B960 Offset: 0x187BA61 VA: 0x187B960
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x187BA00 Offset: 0x187BB01 VA: 0x187BA00 Slot: 62
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x187BA30 Offset: 0x187BB31 VA: 0x187BA30 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x187BCA0 Offset: 0x187BDA1 VA: 0x187BCA0
	protected InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x187CD10 Offset: 0x187CE11 VA: 0x187CD10
	private bool IsValidChar(char c) { }

	// RVA: 0x187CD90 Offset: 0x187CE91 VA: 0x187CD90
	public void ProcessEvent(Event e) { }

	// RVA: 0x187CDA0 Offset: 0x187CEA1 VA: 0x187CDA0 Slot: 63
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x187C5D0 Offset: 0x187C6D1 VA: 0x187C5D0
	private string GetSelectedString() { }

	// RVA: 0x187CF10 Offset: 0x187D011 VA: 0x187CF10
	private int FindtNextWordBegin() { }

	// RVA: 0x187CB30 Offset: 0x187CC31 VA: 0x187CB30
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x187D010 Offset: 0x187D111 VA: 0x187D010
	private int FindtPrevWordBegin() { }

	// RVA: 0x187C970 Offset: 0x187CA71 VA: 0x187C970
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x187D0F0 Offset: 0x187D1F1 VA: 0x187D0F0
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x187D210 Offset: 0x187D311 VA: 0x187D210
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x187D7B0 Offset: 0x187D8B1 VA: 0x187D7B0
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x187CD00 Offset: 0x187CE01 VA: 0x187CD00
	private void MoveDown(bool shift) { }

	// RVA: 0x187DCE0 Offset: 0x187DDE1 VA: 0x187DCE0
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x187CCF0 Offset: 0x187CDF1 VA: 0x187CCF0
	private void MoveUp(bool shift) { }

	// RVA: 0x187DEB0 Offset: 0x187DFB1 VA: 0x187DEB0
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x187C6B0 Offset: 0x187C7B1 VA: 0x187C6B0
	private void Delete() { }

	// RVA: 0x187C3F0 Offset: 0x187C4F1 VA: 0x187C3F0
	private void ForwardSpace() { }

	// RVA: 0x187C1A0 Offset: 0x187C2A1 VA: 0x187C1A0
	private void Backspace() { }

	// RVA: 0x187E080 Offset: 0x187E181 VA: 0x187E080
	private void Insert(char c) { }

	// RVA: 0x187C910 Offset: 0x187CA11 VA: 0x187C910
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x187A9D0 Offset: 0x187AAD1 VA: 0x187A9D0
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x1876390 Offset: 0x1876491 VA: 0x1876390
	private void SendOnValueChanged() { }

	// RVA: 0x187E220 Offset: 0x187E321 VA: 0x187E220
	protected void SendOnSubmit() { }

	// RVA: 0x187E2A0 Offset: 0x187E3A1 VA: 0x187E2A0 Slot: 64
	protected virtual void Append(string input) { }

	// RVA: 0x187E360 Offset: 0x187E461 VA: 0x187E360 Slot: 65
	protected virtual void Append(char input) { }

	// RVA: 0x1876410 Offset: 0x1876511 VA: 0x1876410
	protected void UpdateLabel() { }

	// RVA: 0x187F590 Offset: 0x187F691 VA: 0x187F590
	private bool IsSelectionVisible() { }

	// RVA: 0x187F650 Offset: 0x187F751 VA: 0x187F650
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x187B2C0 Offset: 0x187B3C1 VA: 0x187B2C0
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x187E4F0 Offset: 0x187E5F1 VA: 0x187E4F0
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x187F7E0 Offset: 0x187F8E1 VA: 0x187F7E0
	public void ForceLabelUpdate() { }

	// RVA: 0x1876C80 Offset: 0x1876D81 VA: 0x1876C80
	private void MarkGeometryAsDirty() { }

	// RVA: 0x187F7F0 Offset: 0x187F8F1 VA: 0x187F7F0 Slot: 66
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x187FC20 Offset: 0x187FD21 VA: 0x187FC20 Slot: 67
	public virtual void LayoutComplete() { }

	// RVA: 0x187FC30 Offset: 0x187FD31 VA: 0x187FC30 Slot: 68
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x187F800 Offset: 0x187F901 VA: 0x187F800
	private void UpdateGeometry() { }

	// RVA: 0x1879790 Offset: 0x1879891 VA: 0x1879790
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x187FC40 Offset: 0x187FD41 VA: 0x187FC40
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x187FE90 Offset: 0x187FF91 VA: 0x187FE90
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x18812A0 Offset: 0x18813A1 VA: 0x18812A0
	private void CreateCursorVerts() { }

	// RVA: 0x1880850 Offset: 0x1880951 VA: 0x1880850
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x187A2B0 Offset: 0x187A3B1 VA: 0x187A2B0
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x1881450 Offset: 0x1881551 VA: 0x1881450
	public void ActivateInputField() { }

	// RVA: 0x18793F0 Offset: 0x18794F1 VA: 0x18793F0
	private void ActivateInputFieldInternal() { }

	// RVA: 0x1881590 Offset: 0x1881691 VA: 0x1881590 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18815E0 Offset: 0x18816E1 VA: 0x18815E0 Slot: 69
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1878720 Offset: 0x1878821 VA: 0x1878720
	public void DeactivateInputField() { }

	// RVA: 0x1881600 Offset: 0x1881701 VA: 0x1881600 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1881630 Offset: 0x1881731 VA: 0x1881630 Slot: 70
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x18777D0 Offset: 0x18778D1 VA: 0x18777D0
	private void EnforceContentType() { }

	// RVA: 0x1875D10 Offset: 0x1875E11 VA: 0x1875D10
	private void EnforceTextHOverflow() { }

	// RVA: 0x18779A0 Offset: 0x1877AA1 VA: 0x18779A0
	private void SetToCustomIfContentTypeIsNot(InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x1877AB0 Offset: 0x1877BB1 VA: 0x1877AB0
	private void SetToCustom() { }

	// RVA: 0x1881690 Offset: 0x1881791 VA: 0x1881690 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x18816D0 Offset: 0x18817D1 VA: 0x18816D0 Slot: 71
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18816E0 Offset: 0x18817E1 VA: 0x18816E0 Slot: 72
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18816F0 Offset: 0x18817F1 VA: 0x18816F0 Slot: 73
	public virtual float get_minWidth() { }

	// RVA: 0x1881700 Offset: 0x1881801 VA: 0x1881700 Slot: 74
	public virtual float get_preferredWidth() { }

	// RVA: 0x18818C0 Offset: 0x18819C1 VA: 0x18818C0 Slot: 75
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18818D0 Offset: 0x18819D1 VA: 0x18818D0 Slot: 76
	public virtual float get_minHeight() { }

	// RVA: 0x18818E0 Offset: 0x18819E1 VA: 0x18818E0 Slot: 77
	public virtual float get_preferredHeight() { }

	// RVA: 0x1881B10 Offset: 0x1881C11 VA: 0x1881B10 Slot: 78
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1881B20 Offset: 0x1881C21 VA: 0x1881B20 Slot: 79
	public virtual int get_layoutPriority() { }

	// RVA: 0x1881B30 Offset: 0x1881C31 VA: 0x1881B30
	private static void .cctor() { }

	// RVA: 0x1881BB0 Offset: 0x1881CB1 VA: 0x1881BB0 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

