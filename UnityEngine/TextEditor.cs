public class TextEditor // TypeDefIndex: 3621
{
	// Fields
	public TouchScreenKeyboard keyboardOnScreen; // 0x10
	public int controlID; // 0x18
	public GUIStyle style; // 0x20
	public bool multiline; // 0x28
	public bool hasHorizontalCursorPos; // 0x29
	public bool isPasswordField; // 0x2A
	[VisibleToOtherModulesAttribute] // RVA: 0xF5DD0 Offset: 0xF5ED1 VA: 0xF5DD0
	internal bool m_HasFocus; // 0x2B
	public Vector2 scrollOffset; // 0x2C
	private GUIContent m_Content; // 0x38
	private Rect m_Position; // 0x40
	private int m_CursorIndex; // 0x50
	private int m_SelectIndex; // 0x54
	private bool m_RevealCursor; // 0x58
	public Vector2 graphicalCursorPos; // 0x5C
	public Vector2 graphicalSelectCursorPos; // 0x64
	private bool m_MouseDragSelectsWholeWords; // 0x6C
	private int m_DblClickInitPos; // 0x70
	private TextEditor.DblClickSnapping m_DblClickSnap; // 0x74
	private bool m_bJustSelected; // 0x75
	private int m_iAltCursorPos; // 0x78
	private string oldText; // 0x80
	private int oldPos; // 0x88
	private int oldSelectPos; // 0x8C
	private static Dictionary<Event, TextEditor.TextEditOp> s_Keyactions; // 0x0

	// Properties
	public string text { get; set; }
	public Rect position { get; set; }
	internal virtual Rect localPosition { get; }
	public int cursorIndex { get; set; }
	public int selectIndex { get; set; }
	public bool hasSelection { get; }

	// Methods

	// RVA: 0x3502140 Offset: 0x3502241 VA: 0x3502140
	public string get_text() { }

	// RVA: 0x3502160 Offset: 0x3502261 VA: 0x3502160
	public void set_text(string value) { }

	// RVA: 0x3502290 Offset: 0x3502391 VA: 0x3502290
	public Rect get_position() { }

	// RVA: 0x35022A0 Offset: 0x35023A1 VA: 0x35022A0
	public void set_position(Rect value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7D30 Offset: 0xF7E31 VA: 0xF7D30
	// RVA: 0x35027B0 Offset: 0x35028B1 VA: 0x35027B0 Slot: 4
	internal virtual Rect get_localPosition() { }

	// RVA: 0x35027C0 Offset: 0x35028C1 VA: 0x35027C0
	public int get_cursorIndex() { }

	// RVA: 0x35027D0 Offset: 0x35028D1 VA: 0x35027D0
	public void set_cursorIndex(int value) { }

	// RVA: 0x3502860 Offset: 0x3502961 VA: 0x3502860
	public int get_selectIndex() { }

	// RVA: 0x3502870 Offset: 0x3502971 VA: 0x3502870
	public void set_selectIndex(int value) { }

	// RVA: 0x35028F0 Offset: 0x35029F1 VA: 0x35028F0
	private void ClearCursorPos() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF7DC0 Offset: 0xF7EC1 VA: 0xF7DC0
	// RVA: 0x3502900 Offset: 0x3502A01 VA: 0x3502900
	public void .ctor() { }

	// RVA: 0x3502A20 Offset: 0x3502B21 VA: 0x3502A20
	public void OnFocus() { }

	// RVA: 0x3502C30 Offset: 0x3502D31 VA: 0x3502C30
	public void OnLostFocus() { }

	// RVA: 0x3502CA0 Offset: 0x3502DA1 VA: 0x3502CA0
	private void GrabGraphicalCursorPos() { }

	// RVA: 0x3502D40 Offset: 0x3502E41 VA: 0x3502D40
	public bool HandleKeyEvent(Event e) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7DD0 Offset: 0xF7ED1 VA: 0xF7DD0
	// RVA: 0x3502D50 Offset: 0x3502E51 VA: 0x3502D50
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	// RVA: 0x3504ED0 Offset: 0x3504FD1 VA: 0x3504ED0
	public bool DeleteLineBack() { }

	// RVA: 0x35052C0 Offset: 0x35053C1 VA: 0x35052C0
	public bool DeleteWordBack() { }

	// RVA: 0x3505520 Offset: 0x3505621 VA: 0x3505520
	public bool DeleteWordForward() { }

	// RVA: 0x35057B0 Offset: 0x35058B1 VA: 0x35057B0
	public bool Delete() { }

	// RVA: 0x3505980 Offset: 0x3505A81 VA: 0x3505980
	public bool Backspace() { }

	// RVA: 0x3502B20 Offset: 0x3502C21 VA: 0x3502B20
	public void SelectAll() { }

	// RVA: 0x3505BD0 Offset: 0x3505CD1 VA: 0x3505BD0
	public void SelectNone() { }

	// RVA: 0x3505070 Offset: 0x3505171 VA: 0x3505070
	public bool get_hasSelection() { }

	// RVA: 0x3505080 Offset: 0x3505181 VA: 0x3505080
	public bool DeleteSelection() { }

	// RVA: 0x3505C60 Offset: 0x3505D61 VA: 0x3505C60
	public void ReplaceSelection(string replace) { }

	// RVA: 0x3505DB0 Offset: 0x3505EB1 VA: 0x3505DB0
	public void Insert(char c) { }

	// RVA: 0x3505DF0 Offset: 0x3505EF1 VA: 0x3505DF0
	public void MoveRight() { }

	// RVA: 0x3505FA0 Offset: 0x35060A1 VA: 0x3505FA0
	public void MoveLeft() { }

	// RVA: 0x3506160 Offset: 0x3506261 VA: 0x3506160
	public void MoveUp() { }

	// RVA: 0x3506370 Offset: 0x3506471 VA: 0x3506370
	public void MoveDown() { }

	// RVA: 0x35065B0 Offset: 0x35066B1 VA: 0x35065B0
	public void MoveLineStart() { }

	// RVA: 0x3506770 Offset: 0x3506871 VA: 0x3506770
	public void MoveLineEnd() { }

	// RVA: 0x3506980 Offset: 0x3506A81 VA: 0x3506980
	public void MoveGraphicalLineStart() { }

	// RVA: 0x3506BA0 Offset: 0x3506CA1 VA: 0x3506BA0
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x3506D90 Offset: 0x3506E91 VA: 0x3506D90
	public void MoveTextStart() { }

	// RVA: 0x3506E80 Offset: 0x3506F81 VA: 0x3506E80
	public void MoveTextEnd() { }

	// RVA: 0x3506F90 Offset: 0x3507091 VA: 0x3506F90
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x3507010 Offset: 0x3507111 VA: 0x3507010
	public void MoveParagraphForward() { }

	// RVA: 0x35071C0 Offset: 0x35072C1 VA: 0x35071C0
	public void MoveParagraphBackward() { }

	// RVA: 0x35073D0 Offset: 0x35074D1 VA: 0x35073D0
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x3507430 Offset: 0x3507531 VA: 0x3507430
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x3507620 Offset: 0x3507721 VA: 0x3507620
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x3507E10 Offset: 0x3507F11 VA: 0x3507E10
	public void SelectLeft() { }

	// RVA: 0x3507F90 Offset: 0x3508091 VA: 0x3507F90
	public void SelectRight() { }

	// RVA: 0x3508110 Offset: 0x3508211 VA: 0x3508110
	public void SelectUp() { }

	// RVA: 0x35081F0 Offset: 0x35082F1 VA: 0x35081F0
	public void SelectDown() { }

	// RVA: 0x35082F0 Offset: 0x35083F1 VA: 0x35082F0
	public void SelectTextEnd() { }

	// RVA: 0x35083A0 Offset: 0x35084A1 VA: 0x35083A0
	public void SelectTextStart() { }

	// RVA: 0x3508430 Offset: 0x3508531 VA: 0x3508430
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x3508450 Offset: 0x3508551 VA: 0x3508450
	public void DblClickSnap(TextEditor.DblClickSnapping snapping) { }

	// RVA: 0x3506AA0 Offset: 0x3506BA1 VA: 0x3506AA0
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x3506CC0 Offset: 0x3506DC1 VA: 0x3506CC0
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x3508460 Offset: 0x3508561 VA: 0x3508460
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x3508640 Offset: 0x3508741 VA: 0x3508640
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x35086F0 Offset: 0x35087F1 VA: 0x35086F0
	public void MoveWordRight() { }

	// RVA: 0x3508870 Offset: 0x3508971 VA: 0x3508870
	public void MoveToStartOfNextWord() { }

	// RVA: 0x35089B0 Offset: 0x3508AB1 VA: 0x35089B0
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x3508AF0 Offset: 0x3508BF1 VA: 0x3508AF0
	public void SelectToStartOfNextWord() { }

	// RVA: 0x3508BA0 Offset: 0x3508CA1 VA: 0x3508BA0
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x3508510 Offset: 0x3508611 VA: 0x3508510
	private TextEditor.CharacterType ClassifyChar(int index) { }

	// RVA: 0x35055E0 Offset: 0x35056E1 VA: 0x35055E0
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x3505430 Offset: 0x3505531 VA: 0x3505430
	private int FindEndOfPreviousWord(int p) { }

	// RVA: 0x3508C50 Offset: 0x3508D51 VA: 0x3508C50
	public void MoveWordLeft() { }

	// RVA: 0x3508DD0 Offset: 0x3508ED1 VA: 0x3508DD0
	public void SelectWordRight() { }

	// RVA: 0x3508F50 Offset: 0x3509051 VA: 0x3508F50
	public void SelectWordLeft() { }

	// RVA: 0x35090D0 Offset: 0x35091D1 VA: 0x35090D0
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x3509250 Offset: 0x3509351 VA: 0x3509250
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x35093D0 Offset: 0x35094D1 VA: 0x35093D0
	public void SelectGraphicalLineStart() { }

	// RVA: 0x3509480 Offset: 0x3509581 VA: 0x3509480
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x3509530 Offset: 0x3509631 VA: 0x3509530
	public void SelectParagraphForward() { }

	// RVA: 0x3509690 Offset: 0x3509791 VA: 0x3509690
	public void SelectParagraphBackward() { }

	// RVA: 0x35098B0 Offset: 0x35099B1 VA: 0x35098B0
	public void SelectCurrentWord() { }

	// RVA: 0x3507C80 Offset: 0x3507D81 VA: 0x3507C80
	private int FindEndOfClassification(int p, TextEditor.Direction dir) { }

	// RVA: 0x3509A60 Offset: 0x3509B61 VA: 0x3509A60
	public void SelectCurrentParagraph() { }

	// RVA: 0x3509BC0 Offset: 0x3509CC1 VA: 0x3509BC0
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7DE0 Offset: 0xF7EE1 VA: 0xF7DE0
	// RVA: 0x35023C0 Offset: 0x35024C1 VA: 0x35023C0
	internal void UpdateScrollOffset() { }

	// RVA: 0x3509C20 Offset: 0x3509D21 VA: 0x3509C20
	public void DrawCursor(string newText) { }

	// RVA: 0x35049D0 Offset: 0x3504AD1 VA: 0x35049D0
	private bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly) { }

	// RVA: 0x350A2C0 Offset: 0x350A3C1 VA: 0x350A2C0
	public void SaveBackup() { }

	// RVA: 0x350A110 Offset: 0x350A211 VA: 0x350A110
	public bool Cut() { }

	// RVA: 0x350A150 Offset: 0x350A251 VA: 0x350A150
	public void Copy() { }

	// RVA: 0x350A310 Offset: 0x350A411 VA: 0x350A310
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x350A200 Offset: 0x350A301 VA: 0x350A200
	public bool Paste() { }

	// RVA: 0x350A3A0 Offset: 0x350A4A1 VA: 0x350A3A0
	private static void MapKey(string key, TextEditor.TextEditOp action) { }

	// RVA: 0x3502E70 Offset: 0x3502F71 VA: 0x3502E70
	private void InitKeyActions() { }

	// RVA: 0x3505F90 Offset: 0x3506091 VA: 0x3505F90
	public void DetectFocusChange() { }

	// RVA: 0x350A430 Offset: 0x350A531 VA: 0x350A430 Slot: 5
	internal virtual void OnDetectFocusChange() { }

	// RVA: 0x350A560 Offset: 0x350A661 VA: 0x350A560 Slot: 6
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x350A570 Offset: 0x350A671 VA: 0x350A570 Slot: 7
	internal virtual void OnSelectIndexChange() { }

	// RVA: 0x350A580 Offset: 0x350A681 VA: 0x350A580
	private void ClampTextIndex(ref int index) { }

	// RVA: 0x3502240 Offset: 0x3502341 VA: 0x3502240
	private void EnsureValidCodePointIndex(ref int index) { }

	// RVA: 0x350A630 Offset: 0x350A731 VA: 0x350A630
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x3505AF0 Offset: 0x3505BF1 VA: 0x3505AF0
	private int PreviousCodePointIndex(int index) { }

	// RVA: 0x3505880 Offset: 0x3505981 VA: 0x3505880
	private int NextCodePointIndex(int index) { }
}

