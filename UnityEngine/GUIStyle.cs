[NativeHeaderAttribute] // RVA: 0xF4CD0 Offset: 0xF4DD1 VA: 0xF4CD0
[NativeHeaderAttribute] // RVA: 0xF4CD0 Offset: 0xF4DD1 VA: 0xF4CD0
[RequiredByNativeCodeAttribute] // RVA: 0xF4CD0 Offset: 0xF4DD1 VA: 0xF4CD0
[Serializable]
public sealed class GUIStyle // TypeDefIndex: 3607
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private GUIStyleState m_Normal; // 0x18
	private GUIStyleState m_Hover; // 0x20
	private GUIStyleState m_Active; // 0x28
	private GUIStyleState m_Focused; // 0x30
	private GUIStyleState m_OnNormal; // 0x38
	private GUIStyleState m_OnHover; // 0x40
	private GUIStyleState m_OnActive; // 0x48
	private GUIStyleState m_OnFocused; // 0x50
	private RectOffset m_Border; // 0x58
	private RectOffset m_Padding; // 0x60
	private RectOffset m_Margin; // 0x68
	private RectOffset m_Overflow; // 0x70
	private string m_Name; // 0x78
	internal static bool showKeyboardFocus; // 0x0
	private static GUIStyle s_None; // 0x8

	// Properties
	[NativePropertyAttribute] // RVA: 0xF8240 Offset: 0xF8341 VA: 0xF8240
	internal string rawName { get; set; }
	[NativePropertyAttribute] // RVA: 0xF8280 Offset: 0xF8381 VA: 0xF8280
	public Font font { get; }
	[NativePropertyAttribute] // RVA: 0xF82C0 Offset: 0xF83C1 VA: 0xF82C0
	public ImagePosition imagePosition { get; }
	[NativePropertyAttribute] // RVA: 0xF8300 Offset: 0xF8401 VA: 0xF8300
	public bool wordWrap { get; }
	[NativePropertyAttribute] // RVA: 0xF8340 Offset: 0xF8441 VA: 0xF8340
	public Vector2 contentOffset { get; set; }
	[NativePropertyAttribute] // RVA: 0xF8380 Offset: 0xF8481 VA: 0xF8380
	public float fixedWidth { get; }
	[NativePropertyAttribute] // RVA: 0xF83C0 Offset: 0xF84C1 VA: 0xF83C0
	public float fixedHeight { get; }
	[NativePropertyAttribute] // RVA: 0xF8400 Offset: 0xF8501 VA: 0xF8400
	public bool stretchWidth { get; set; }
	[NativePropertyAttribute] // RVA: 0xF8440 Offset: 0xF8541 VA: 0xF8440
	public bool stretchHeight { get; set; }
	[NativePropertyAttribute] // RVA: 0xF8480 Offset: 0xF8581 VA: 0xF8480
	internal Vector2 Internal_clipOffset { set; }
	public string name { get; set; }
	public GUIStyleState normal { get; }
	public RectOffset margin { get; }
	public RectOffset padding { get; }
	public float lineHeight { get; }
	public static GUIStyle none { get; }
	public bool isHeightDependantOnWidth { get; }

	// Methods

	// RVA: 0x2D1F630 Offset: 0x2D1F731 VA: 0x2D1F630
	internal string get_rawName() { }

	// RVA: 0x2D1F680 Offset: 0x2D1F781 VA: 0x2D1F680
	internal void set_rawName(string value) { }

	// RVA: 0x2D07DC0 Offset: 0x2D07EC1 VA: 0x2D07DC0
	public Font get_font() { }

	// RVA: 0x2D1F6D0 Offset: 0x2D1F7D1 VA: 0x2D1F6D0
	public ImagePosition get_imagePosition() { }

	// RVA: 0x2D1F720 Offset: 0x2D1F821 VA: 0x2D1F720
	public bool get_wordWrap() { }

	// RVA: 0x2D1F770 Offset: 0x2D1F871 VA: 0x2D1F770
	public Vector2 get_contentOffset() { }

	// RVA: 0x2D1F820 Offset: 0x2D1F921 VA: 0x2D1F820
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x2D0A070 Offset: 0x2D0A171 VA: 0x2D0A070
	public float get_fixedWidth() { }

	// RVA: 0x2D0A0C0 Offset: 0x2D0A1C1 VA: 0x2D0A0C0
	public float get_fixedHeight() { }

	// RVA: 0x2D156E0 Offset: 0x2D157E1 VA: 0x2D156E0
	public bool get_stretchWidth() { }

	// RVA: 0x2D1B260 Offset: 0x2D1B361 VA: 0x2D1B260
	public void set_stretchWidth(bool value) { }

	// RVA: 0x2D15730 Offset: 0x2D15831 VA: 0x2D15730
	public bool get_stretchHeight() { }

	// RVA: 0x2D1EF40 Offset: 0x2D1F041 VA: 0x2D1EF40
	public void set_stretchHeight(bool value) { }

	// RVA: 0x2D1F8D0 Offset: 0x2D1F9D1 VA: 0x2D1F8D0
	internal void set_Internal_clipOffset(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xF6CB0 Offset: 0xF6DB1 VA: 0xF6CB0
	// RVA: 0x2D1F980 Offset: 0x2D1FA81 VA: 0x2D1F980
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunctionAttribute] // RVA: 0xF6D00 Offset: 0xF6E01 VA: 0xF6D00
	// RVA: 0x2D1F9D0 Offset: 0x2D1FAD1 VA: 0x2D1F9D0
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunctionAttribute] // RVA: 0xF6D50 Offset: 0xF6E51 VA: 0xF6D50
	// RVA: 0x2D1FA20 Offset: 0x2D1FB21 VA: 0x2D1FA20
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xF6DB0 Offset: 0xF6EB1 VA: 0xF6DB0
	// RVA: 0x2D1FA70 Offset: 0x2D1FB71 VA: 0x2D1FA70
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0xF6E00 Offset: 0xF6F01 VA: 0xF6E00
	// RVA: 0x2D1FAC0 Offset: 0x2D1FBC1 VA: 0x2D1FAC0
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunctionAttribute] // RVA: 0xF6E50 Offset: 0xF6F51 VA: 0xF6E50
	// RVA: 0x2D1FB10 Offset: 0x2D1FC11 VA: 0x2D1FB10
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunctionAttribute] // RVA: 0xF6EA0 Offset: 0xF6FA1 VA: 0xF6EA0
	// RVA: 0x2D1FC40 Offset: 0x2D1FD41 VA: 0x2D1FC40
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunctionAttribute] // RVA: 0xF6EF0 Offset: 0xF6FF1 VA: 0xF6EF0
	// RVA: 0x2D1FD30 Offset: 0x2D1FE31 VA: 0x2D1FD30
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	[FreeFunctionAttribute] // RVA: 0xF6F40 Offset: 0xF7041 VA: 0xF6F40
	// RVA: 0x2D1FE20 Offset: 0x2D1FF21 VA: 0x2D1FE20
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	[FreeFunctionAttribute] // RVA: 0xF6F90 Offset: 0xF7091 VA: 0xF6F90
	// RVA: 0x2D1FFC0 Offset: 0x2D200C1 VA: 0x2D1FFC0
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunctionAttribute] // RVA: 0xF6FE0 Offset: 0xF70E1 VA: 0xF6FE0
	// RVA: 0x2D200B0 Offset: 0x2D201B1 VA: 0x2D200B0
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunctionAttribute] // RVA: 0xF7030 Offset: 0xF7131 VA: 0xF7030
	// RVA: 0x2D20190 Offset: 0x2D20291 VA: 0x2D20190
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunctionAttribute] // RVA: 0xF7080 Offset: 0xF7181 VA: 0xF7080
	// RVA: 0x2D20280 Offset: 0x2D20381 VA: 0x2D20280
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xF70D0 Offset: 0xF71D1 VA: 0xF70D0
	// RVA: 0x2D20340 Offset: 0x2D20441 VA: 0x2D20340
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunctionAttribute] // RVA: 0xF7120 Offset: 0xF7221 VA: 0xF7120
	// RVA: 0x2D20420 Offset: 0x2D20521 VA: 0x2D20420
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunctionAttribute] // RVA: 0xF7170 Offset: 0xF7271 VA: 0xF7170
	// RVA: 0x2D20480 Offset: 0x2D20581 VA: 0x2D20480
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0xF71C0 Offset: 0xF72C1 VA: 0xF71C0
	// RVA: 0x2D09FC0 Offset: 0x2D0A0C1 VA: 0x2D09FC0
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunctionAttribute] // RVA: 0xF7210 Offset: 0xF7311 VA: 0xF7210
	// RVA: 0x2D20590 Offset: 0x2D20691 VA: 0x2D20590
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunctionAttribute] // RVA: 0xF7260 Offset: 0xF7361 VA: 0xF7260
	// RVA: 0x2D1C0C0 Offset: 0x2D1C1C1 VA: 0x2D1C0C0
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x2D1B1B0 Offset: 0x2D1B2B1 VA: 0x2D1B1B0
	public void .ctor() { }

	// RVA: 0x2D205D0 Offset: 0x2D206D1 VA: 0x2D205D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2D0AE10 Offset: 0x2D0AF11 VA: 0x2D0AE10
	public string get_name() { }

	// RVA: 0x2D1D1B0 Offset: 0x2D1D2B1 VA: 0x2D1D1B0
	public void set_name(string value) { }

	// RVA: 0x2D1EF90 Offset: 0x2D1F091 VA: 0x2D1EF90
	public GUIStyleState get_normal() { }

	// RVA: 0x2D09930 Offset: 0x2D09A31 VA: 0x2D09930
	public RectOffset get_margin() { }

	// RVA: 0x2D17340 Offset: 0x2D17441 VA: 0x2D17340
	public RectOffset get_padding() { }

	// RVA: 0x2D20760 Offset: 0x2D20861 VA: 0x2D20760
	public float get_lineHeight() { }

	// RVA: 0x2D0DC20 Offset: 0x2D0DD21 VA: 0x2D0DC20
	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x2D09EB0 Offset: 0x2D09FB1 VA: 0x2D09EB0
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x2D0C5F0 Offset: 0x2D0C6F1 VA: 0x2D0C5F0
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x2D07CB0 Offset: 0x2D07DB1 VA: 0x2D07CB0
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x2D05E60 Offset: 0x2D05F61 VA: 0x2D05E60
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x2D208C0 Offset: 0x2D209C1 VA: 0x2D208C0
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x2D209B0 Offset: 0x2D20AB1 VA: 0x2D209B0
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x2D20CE0 Offset: 0x2D20DE1 VA: 0x2D20CE0
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x2D21070 Offset: 0x2D21171 VA: 0x2D21070
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x2D21230 Offset: 0x2D21331 VA: 0x2D21230
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x2D21240 Offset: 0x2D21341 VA: 0x2D21240
	public static GUIStyle op_Implicit(string str) { }

	// RVA: 0x2D0C4B0 Offset: 0x2D0C5B1 VA: 0x2D0C4B0
	public static GUIStyle get_none() { }

	// RVA: 0x2D21330 Offset: 0x2D21431 VA: 0x2D21330
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x2D213B0 Offset: 0x2D214B1 VA: 0x2D213B0
	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x2D0A7D0 Offset: 0x2D0A8D1 VA: 0x2D0A7D0
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x2D1AD20 Offset: 0x2D1AE21 VA: 0x2D1AD20
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x2D21420 Offset: 0x2D21521 VA: 0x2D21420
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x2D1AC30 Offset: 0x2D1AD31 VA: 0x2D1AC30
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x2D21480 Offset: 0x2D21581 VA: 0x2D21480
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x2D21500 Offset: 0x2D21601 VA: 0x2D21500 Slot: 3
	public override string ToString() { }

	// RVA: 0x2D21610 Offset: 0x2D21711 VA: 0x2D21610
	private static void .cctor() { }

	// RVA: 0x2D1F7D0 Offset: 0x2D1F8D1 VA: 0x2D1F7D0
	private void get_contentOffset_Injected(out Vector2 ret) { }

	// RVA: 0x2D1F880 Offset: 0x2D1F981 VA: 0x2D1F880
	private void set_contentOffset_Injected(ref Vector2 value) { }

	// RVA: 0x2D1F930 Offset: 0x2D1FA31 VA: 0x2D1F930
	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	// RVA: 0x2D1FBB0 Offset: 0x2D1FCB1 VA: 0x2D1FBB0
	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x2D1FCC0 Offset: 0x2D1FDC1 VA: 0x2D1FCC0
	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x2D1FDB0 Offset: 0x2D1FEB1 VA: 0x2D1FDB0
	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	// RVA: 0x2D1FF00 Offset: 0x2D20001 VA: 0x2D1FF00
	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	// RVA: 0x2D20040 Offset: 0x2D20141 VA: 0x2D20040
	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	// RVA: 0x2D20120 Offset: 0x2D20221 VA: 0x2D20120
	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	// RVA: 0x2D20210 Offset: 0x2D20311 VA: 0x2D20210
	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x2D202E0 Offset: 0x2D203E1 VA: 0x2D202E0
	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x2D203B0 Offset: 0x2D204B1 VA: 0x2D203B0
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x2D204E0 Offset: 0x2D205E1 VA: 0x2D204E0
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x2D20540 Offset: 0x2D20641 VA: 0x2D20540
	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }
}

