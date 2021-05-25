[NativeHeaderAttribute] // RVA: 0xF48B0 Offset: 0xF49B1 VA: 0xF48B0
[NativeHeaderAttribute] // RVA: 0xF48B0 Offset: 0xF49B1 VA: 0xF48B0
public class GUI // TypeDefIndex: 3588
{
	// Fields
	private static int s_ScrollControlId; // 0x0
	private static int s_HotTextField; // 0x4
	private static readonly int s_BoxHash; // 0x8
	private static readonly int s_ButonHash; // 0xC
	private static readonly int s_RepeatButtonHash; // 0x10
	private static readonly int s_ToggleHash; // 0x14
	private static readonly int s_ButtonGridHash; // 0x18
	private static readonly int s_SliderHash; // 0x1C
	private static readonly int s_BeginGroupHash; // 0x20
	private static readonly int s_ScrollviewHash; // 0x24
	[DebuggerBrowsableAttribute] // RVA: 0xF5590 Offset: 0xF5691 VA: 0xF5590
	[CompilerGeneratedAttribute] // RVA: 0xF5590 Offset: 0xF5691 VA: 0xF5590
	private static int <scrollTroughSide>k__BackingField; // 0x28
	[DebuggerBrowsableAttribute] // RVA: 0xF55D0 Offset: 0xF56D1 VA: 0xF55D0
	[CompilerGeneratedAttribute] // RVA: 0xF55D0 Offset: 0xF56D1 VA: 0xF55D0
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x30
	private static GUISkin s_Skin; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xF5610 Offset: 0xF5711 VA: 0xF5610
	[DebuggerBrowsableAttribute] // RVA: 0xF5610 Offset: 0xF5711 VA: 0xF5610
	private static GenericStack <scrollViewStates>k__BackingField; // 0x40

	// Properties
	public static Color color { get; set; }
	public static Color backgroundColor { get; set; }
	public static Color contentColor { get; set; }
	public static bool changed { get; set; }
	public static bool enabled { get; set; }
	public static int depth { set; }
	internal static bool usePageScrollbars { get; }
	internal static Material blendMaterial { get; }
	internal static Material blitMaterial { get; }
	internal static Material roundedRectMaterial { get; }
	internal static Material roundedRectWithColorPerBorderMaterial { get; }
	internal static int scrollTroughSide { get; set; }
	internal static DateTime nextScrollStepTime { get; set; }
	public static GUISkin skin { get; set; }
	public static Matrix4x4 matrix { get; set; }
	internal static GenericStack scrollViewStates { get; }

	// Methods

	// RVA: 0x2D02B70 Offset: 0x2D02C71 VA: 0x2D02B70
	public static Color get_color() { }

	// RVA: 0x2D02C70 Offset: 0x2D02D71 VA: 0x2D02C70
	public static void set_color(Color value) { }

	// RVA: 0x2D02D70 Offset: 0x2D02E71 VA: 0x2D02D70
	public static Color get_backgroundColor() { }

	// RVA: 0x2D02E70 Offset: 0x2D02F71 VA: 0x2D02E70
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x2D02F70 Offset: 0x2D03071 VA: 0x2D02F70
	public static Color get_contentColor() { }

	// RVA: 0x2D03070 Offset: 0x2D03171 VA: 0x2D03070
	public static void set_contentColor(Color value) { }

	// RVA: 0x2D03170 Offset: 0x2D03271 VA: 0x2D03170
	public static bool get_changed() { }

	// RVA: 0x2D031B0 Offset: 0x2D032B1 VA: 0x2D031B0
	public static void set_changed(bool value) { }

	// RVA: 0x2D03200 Offset: 0x2D03301 VA: 0x2D03200
	public static bool get_enabled() { }

	// RVA: 0x2D03240 Offset: 0x2D03341 VA: 0x2D03240
	public static void set_enabled(bool value) { }

	// RVA: 0x2D03290 Offset: 0x2D03391 VA: 0x2D03290
	public static void set_depth(int value) { }

	// RVA: 0x2D032E0 Offset: 0x2D033E1 VA: 0x2D032E0
	internal static bool get_usePageScrollbars() { }

	[FreeFunctionAttribute] // RVA: 0xF62E0 Offset: 0xF63E1 VA: 0xF62E0
	// RVA: 0x2D03320 Offset: 0x2D03421 VA: 0x2D03320
	internal static Material get_blendMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xF6320 Offset: 0xF6421 VA: 0xF6320
	// RVA: 0x2D03360 Offset: 0x2D03461 VA: 0x2D03360
	internal static Material get_blitMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xF6360 Offset: 0xF6461 VA: 0xF6360
	// RVA: 0x2D033A0 Offset: 0x2D034A1 VA: 0x2D033A0
	internal static Material get_roundedRectMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xF63A0 Offset: 0xF64A1 VA: 0xF63A0
	// RVA: 0x2D033E0 Offset: 0x2D034E1 VA: 0x2D033E0
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x2D03420 Offset: 0x2D03521 VA: 0x2D03420
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x2D03470 Offset: 0x2D03571 VA: 0x2D03470
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x2D034C0 Offset: 0x2D035C1 VA: 0x2D034C0
	internal static void ReleaseMouseControl() { }

	[FreeFunctionAttribute] // RVA: 0xF63E0 Offset: 0xF64E1 VA: 0xF63E0
	// RVA: 0x2D03500 Offset: 0x2D03601 VA: 0x2D03500
	public static void SetNextControlName(string name) { }

	// RVA: 0x2D03550 Offset: 0x2D03651 VA: 0x2D03550
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x2D03590 Offset: 0x2D03691 VA: 0x2D03590
	private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) { }

	// RVA: 0x2D03740 Offset: 0x2D03841 VA: 0x2D03740
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0xF6420 Offset: 0xF6521 VA: 0xF6420
	// RVA: 0x2D039A0 Offset: 0x2D03AA1 VA: 0x2D039A0
	internal static int get_scrollTroughSide() { }

	[CompilerGeneratedAttribute] // RVA: 0xF6430 Offset: 0xF6531 VA: 0xF6430
	// RVA: 0x2D03A10 Offset: 0x2D03B11 VA: 0x2D03A10
	internal static void set_scrollTroughSide(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF6440 Offset: 0xF6541 VA: 0xF6440
	// RVA: 0x2D03A80 Offset: 0x2D03B81 VA: 0x2D03A80
	internal static DateTime get_nextScrollStepTime() { }

	[CompilerGeneratedAttribute] // RVA: 0xF6450 Offset: 0xF6551 VA: 0xF6450
	// RVA: 0x2D03AF0 Offset: 0x2D03BF1 VA: 0x2D03AF0
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x2D03B60 Offset: 0x2D03C61 VA: 0x2D03B60
	public static void set_skin(GUISkin value) { }

	// RVA: 0x2D03CB0 Offset: 0x2D03DB1 VA: 0x2D03CB0
	public static GUISkin get_skin() { }

	// RVA: 0x2D03BE0 Offset: 0x2D03CE1 VA: 0x2D03BE0
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x2D03E00 Offset: 0x2D03F01 VA: 0x2D03E00
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x2D03F30 Offset: 0x2D04031 VA: 0x2D03F30
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x2D03FF0 Offset: 0x2D040F1 VA: 0x2D03FF0
	public static void Label(Rect position, string text) { }

	// RVA: 0x2D042A0 Offset: 0x2D043A1 VA: 0x2D042A0
	public static void Label(Rect position, GUIContent content) { }

	// RVA: 0x2D043A0 Offset: 0x2D044A1 VA: 0x2D043A0
	public static void Label(Rect position, string text, GUIStyle style) { }

	// RVA: 0x2D041F0 Offset: 0x2D042F1 VA: 0x2D041F0
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D047A0 Offset: 0x2D048A1 VA: 0x2D047A0
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x2D04840 Offset: 0x2D04941 VA: 0x2D04840
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x2D04940 Offset: 0x2D04A41 VA: 0x2D04940
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x2D049F0 Offset: 0x2D04AF1 VA: 0x2D049F0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x2D04B70 Offset: 0x2D04C71 VA: 0x2D04B70
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x2D04CB0 Offset: 0x2D04DB1 VA: 0x2D04CB0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x2D04E10 Offset: 0x2D04F11 VA: 0x2D04E10
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x2D04FB0 Offset: 0x2D050B1 VA: 0x2D04FB0
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x2D05130 Offset: 0x2D05231 VA: 0x2D05130
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x2D05860 Offset: 0x2D05961 VA: 0x2D05860
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	// RVA: 0x2D05AD0 Offset: 0x2D05BD1 VA: 0x2D05AD0
	public static void Box(Rect position, string text) { }

	// RVA: 0x2D05DB0 Offset: 0x2D05EB1 VA: 0x2D05DB0
	public static void Box(Rect position, GUIContent content) { }

	// RVA: 0x2D05BC0 Offset: 0x2D05CC1 VA: 0x2D05BC0
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D05F80 Offset: 0x2D06081 VA: 0x2D05F80
	public static bool Button(Rect position, string text) { }

	// RVA: 0x2D06070 Offset: 0x2D06171 VA: 0x2D06070
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D06190 Offset: 0x2D06291 VA: 0x2D06190
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D063B0 Offset: 0x2D064B1 VA: 0x2D063B0
	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	// RVA: 0x2D067A0 Offset: 0x2D068A1 VA: 0x2D067A0
	internal static string PasswordFieldGetStrToShow(string password, char maskChar) { }

	// RVA: 0x2D06920 Offset: 0x2D06A21 VA: 0x2D06920
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x2D06A40 Offset: 0x2D06B41 VA: 0x2D06A40
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x2D06B20 Offset: 0x2D06C21 VA: 0x2D06B20
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar) { }

	// RVA: 0x2D06E30 Offset: 0x2D06F31 VA: 0x2D06E30
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor) { }

	// RVA: 0x2D07320 Offset: 0x2D07421 VA: 0x2D07320
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x2D07E20 Offset: 0x2D07F21 VA: 0x2D07E20
	public static bool Toggle(Rect position, bool value, string text) { }

	// RVA: 0x2D07F90 Offset: 0x2D08091 VA: 0x2D07F90
	public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D081D0 Offset: 0x2D082D1 VA: 0x2D081D0
	public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style) { }

	// RVA: 0x2D092D0 Offset: 0x2D093D1 VA: 0x2D092D0
	internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle) { }

	// RVA: 0x2D099F0 Offset: 0x2D09AF1 VA: 0x2D099F0
	private static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D044D0 Offset: 0x2D045D1 VA: 0x2D044D0
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D08070 Offset: 0x2D08171 VA: 0x2D08070
	internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D06250 Offset: 0x2D06351 VA: 0x2D06250
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D082F0 Offset: 0x2D083F1 VA: 0x2D082F0
	private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, string[] controlNames, int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled) { }

	// RVA: 0x2D0A110 Offset: 0x2D0A211 VA: 0x2D0A110
	private static Rect[] CalcMouseRects(Rect position, GUIContent[] contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, bool addBorders, GUI.ToolbarButtonSize buttonSize) { }

	// RVA: 0x2D0A830 Offset: 0x2D0A931 VA: 0x2D0A830
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x2D0A910 Offset: 0x2D0AA11 VA: 0x2D0A910
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x2D0AAA0 Offset: 0x2D0ABA1 VA: 0x2D0AAA0
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	// RVA: 0x2D0B960 Offset: 0x2D0BA61 VA: 0x2D0B960
	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	// RVA: 0x2D0BCD0 Offset: 0x2D0BDD1 VA: 0x2D0BCD0
	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { }

	// RVA: 0x2D0B230 Offset: 0x2D0B331 VA: 0x2D0B230
	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	// RVA: 0x2D0C040 Offset: 0x2D0C141 VA: 0x2D0C040
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D0C130 Offset: 0x2D0C231 VA: 0x2D0C130
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x2D0C730 Offset: 0x2D0C831 VA: 0x2D0C730
	public static void EndGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0xF6460 Offset: 0xF6561 VA: 0xF6460
	// RVA: 0x2D0C7C0 Offset: 0x2D0C8C1 VA: 0x2D0C7C0
	internal static GenericStack get_scrollViewStates() { }

	// RVA: 0x2D0C830 Offset: 0x2D0C931 VA: 0x2D0C830
	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0x2D0DD30 Offset: 0x2D0DE31 VA: 0x2D0DD30
	public static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x2D0E310 Offset: 0x2D0E411 VA: 0x2D0E310
	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style) { }

	// RVA: 0x2D0E4A0 Offset: 0x2D0E5A1 VA: 0x2D0E4A0
	private static Rect DoWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF6470 Offset: 0xF6571 VA: 0xF6470
	// RVA: 0x2D0E590 Offset: 0x2D0E691 VA: 0x2D0E590
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x2D02C20 Offset: 0x2D02D21 VA: 0x2D02C20
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x2D02D20 Offset: 0x2D02E21 VA: 0x2D02D20
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x2D02E20 Offset: 0x2D02F21 VA: 0x2D02E20
	private static void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x2D02F20 Offset: 0x2D03021 VA: 0x2D02F20
	private static void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x2D03020 Offset: 0x2D03121 VA: 0x2D03020
	private static void get_contentColor_Injected(out Color ret) { }

	// RVA: 0x2D03120 Offset: 0x2D03221 VA: 0x2D03120
	private static void set_contentColor_Injected(ref Color value) { }

	// RVA: 0x2D036A0 Offset: 0x2D037A1 VA: 0x2D036A0
	private static void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret) { }
}

