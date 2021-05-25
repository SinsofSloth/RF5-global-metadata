public class GUILayout // TypeDefIndex: 3596
{
	// Methods

	// RVA: 0x2D11350 Offset: 0x2D11451 VA: 0x2D11350
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x2D115E0 Offset: 0x2D116E1 VA: 0x2D115E0
	public static void Label(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D11460 Offset: 0x2D11561 VA: 0x2D11460
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D116E0 Offset: 0x2D117E1 VA: 0x2D116E0
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x2D11920 Offset: 0x2D11A21 VA: 0x2D11920
	public static bool Button(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D117F0 Offset: 0x2D118F1 VA: 0x2D117F0
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D119A0 Offset: 0x2D11AA1 VA: 0x2D119A0
	public static string TextField(string text, int maxLength, GUILayoutOption[] options) { }

	// RVA: 0x2D11AB0 Offset: 0x2D11BB1 VA: 0x2D11AB0
	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D11D00 Offset: 0x2D11E01 VA: 0x2D11D00
	public static bool Toggle(bool value, string text, GUILayoutOption[] options) { }

	// RVA: 0x2D11E20 Offset: 0x2D11F21 VA: 0x2D11E20
	private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D11FD0 Offset: 0x2D120D1 VA: 0x2D11FD0
	public static int SelectionGrid(int selected, string[] texts, int xCount, GUILayoutOption[] options) { }

	// RVA: 0x2D12180 Offset: 0x2D12281 VA: 0x2D12180
	public static int SelectionGrid(int selected, GUIContent[] contents, int xCount, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D12260 Offset: 0x2D12361 VA: 0x2D12260
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x2D123E0 Offset: 0x2D124E1 VA: 0x2D123E0
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x2D125D0 Offset: 0x2D126D1 VA: 0x2D125D0
	public static void Space(float pixels) { }

	// RVA: 0x2D12C20 Offset: 0x2D12D21 VA: 0x2D12C20
	public static void FlexibleSpace() { }

	// RVA: 0x2D130C0 Offset: 0x2D131C1 VA: 0x2D130C0
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x2D13160 Offset: 0x2D13261 VA: 0x2D13160
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D13630 Offset: 0x2D13731 VA: 0x2D13630
	public static void EndHorizontal() { }

	// RVA: 0x2D138C0 Offset: 0x2D139C1 VA: 0x2D138C0
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x2D13B20 Offset: 0x2D13C21 VA: 0x2D13B20
	public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D13960 Offset: 0x2D13A61 VA: 0x2D13960
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D13BA0 Offset: 0x2D13CA1 VA: 0x2D13BA0
	public static void EndVertical() { }

	// RVA: 0x2D13C10 Offset: 0x2D13D11 VA: 0x2D13C10
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x2D13CE0 Offset: 0x2D13DE1 VA: 0x2D13CE0
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D14210 Offset: 0x2D14311 VA: 0x2D14210
	public static void EndArea() { }

	// RVA: 0x2D14400 Offset: 0x2D14501 VA: 0x2D14400
	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	// RVA: 0x2D145E0 Offset: 0x2D146E1 VA: 0x2D145E0
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	// RVA: 0x2D14890 Offset: 0x2D14991 VA: 0x2D14890
	public static void EndScrollView() { }

	// RVA: 0x2D14930 Offset: 0x2D14A31 VA: 0x2D14930
	internal static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x2D149D0 Offset: 0x2D14AD1 VA: 0x2D149D0
	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUILayoutOption[] options) { }

	// RVA: 0x2D14B40 Offset: 0x2D14C41 VA: 0x2D14B40
	private static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0ECB0 Offset: 0x2D0EDB1 VA: 0x2D0ECB0
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x2D14D90 Offset: 0x2D14E91 VA: 0x2D14D90
	public static GUILayoutOption MaxWidth(float maxWidth) { }

	// RVA: 0x2D0ED50 Offset: 0x2D0EE51 VA: 0x2D0ED50
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x2D13020 Offset: 0x2D13121 VA: 0x2D13020
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x2D12F80 Offset: 0x2D13081 VA: 0x2D12F80
	public static GUILayoutOption ExpandHeight(bool expand) { }
}

