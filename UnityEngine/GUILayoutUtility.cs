[NativeHeaderAttribute] // RVA: 0xF4AD0 Offset: 0xF4BD1 VA: 0xF4AD0
public class GUILayoutUtility // TypeDefIndex: 3600
{
	// Fields
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts; // 0x0
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows; // 0x8
	internal static GUILayoutUtility.LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18
	private static GUIStyle s_SpaceStyle; // 0x28

	// Properties
	internal static GUIStyle spaceStyle { get; }

	// Methods

	// RVA: 0x2D196E0 Offset: 0x2D197E1 VA: 0x2D196E0
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x2D197E0 Offset: 0x2D198E1 VA: 0x2D197E0
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF69C0 Offset: 0xF6AC1 VA: 0xF69C0
	// RVA: 0x2D0EB10 Offset: 0x2D0EC11 VA: 0x2D0EB10
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x2D199D0 Offset: 0x2D19AD1 VA: 0x2D199D0
	internal static void Begin(int instanceID) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF6A50 Offset: 0xF6B51 VA: 0xF6A50
	// RVA: 0x2D19C20 Offset: 0x2D19D21 VA: 0x2D19C20
	internal static void BeginContainer(GUILayoutUtility.LayoutCache cache) { }

	// RVA: 0x2D0EDF0 Offset: 0x2D0EEF1 VA: 0x2D0EDF0
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D0F3A0 Offset: 0x2D0F4A1 VA: 0x2D0F3A0
	internal static void Layout() { }

	// RVA: 0x2D1A2B0 Offset: 0x2D1A3B1 VA: 0x2D1A2B0
	internal static void LayoutFromEditorWindow() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF6AE0 Offset: 0xF6BE1 VA: 0xF6AE0
	// RVA: 0x2D1A470 Offset: 0x2D1A571 VA: 0x2D1A470
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x2D19DE0 Offset: 0x2D19EE1 VA: 0x2D19DE0
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x2D19F60 Offset: 0x2D1A061 VA: 0x2D19F60
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x2D1A600 Offset: 0x2D1A701 VA: 0x2D1A600
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x2D13320 Offset: 0x2D13421 VA: 0x2D13320
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x2D136A0 Offset: 0x2D137A1 VA: 0x2D136A0
	internal static void EndLayoutGroup() { }

	// RVA: 0x2D13F30 Offset: 0x2D14031 VA: 0x2D13F30
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x2D11660 Offset: 0x2D11761 VA: 0x2D11660
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D1A730 Offset: 0x2D1A831 VA: 0x2D1A730
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D1AD90 Offset: 0x2D1AE91 VA: 0x2D1AD90
	public static Rect GetRect(float width, float height, GUILayoutOption[] options) { }

	// RVA: 0x2D12B80 Offset: 0x2D12C81 VA: 0x2D12B80
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D1AE40 Offset: 0x2D1AF41 VA: 0x2D1AE40
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D1B090 Offset: 0x2D1B191 VA: 0x2D1B090
	public static Rect GetLastRect() { }

	// RVA: 0x2D129C0 Offset: 0x2D12AC1 VA: 0x2D129C0
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x2D1B2B0 Offset: 0x2D1B3B1 VA: 0x2D1B2B0
	private static void .cctor() { }

	// RVA: 0x2D19790 Offset: 0x2D19891 VA: 0x2D19790
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x2D19890 Offset: 0x2D19991 VA: 0x2D19890
	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }
}

