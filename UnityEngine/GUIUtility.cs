[NativeHeaderAttribute] // RVA: 0xF4D60 Offset: 0xF4E61 VA: 0xF4D60
[NativeHeaderAttribute] // RVA: 0xF4D60 Offset: 0xF4E61 VA: 0xF4D60
[NativeHeaderAttribute] // RVA: 0xF4D60 Offset: 0xF4E61 VA: 0xF4D60
[NativeHeaderAttribute] // RVA: 0xF4D60 Offset: 0xF4E61 VA: 0xF4D60
[NativeHeaderAttribute] // RVA: 0xF4D60 Offset: 0xF4E61 VA: 0xF4D60
[NativeHeaderAttribute] // RVA: 0xF4D60 Offset: 0xF4E61 VA: 0xF4D60
public class GUIUtility // TypeDefIndex: 3610
{
	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0xF5910 Offset: 0xF5A11 VA: 0xF5910
	internal static int s_SkinMode; // 0x0
	[VisibleToOtherModulesAttribute] // RVA: 0xF59A0 Offset: 0xF5AA1 VA: 0xF59A0
	internal static int s_OriginalID; // 0x4
	[VisibleToOtherModulesAttribute] // RVA: 0xF5A30 Offset: 0xF5B31 VA: 0xF5A30
	internal static Action takeCapture; // 0x8
	[VisibleToOtherModulesAttribute] // RVA: 0xF5AC0 Offset: 0xF5BC1 VA: 0xF5AC0
	internal static Action releaseCapture; // 0x10
	[VisibleToOtherModulesAttribute] // RVA: 0xF5B50 Offset: 0xF5C51 VA: 0xF5B50
	internal static Func<int, IntPtr, bool> processEvent; // 0x18
	[VisibleToOtherModulesAttribute] // RVA: 0xF5BE0 Offset: 0xF5CE1 VA: 0xF5BE0
	internal static Action cleanupRoots; // 0x20
	[VisibleToOtherModulesAttribute] // RVA: 0xF5C70 Offset: 0xF5D71 VA: 0xF5C70
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x28
	[VisibleToOtherModulesAttribute] // RVA: 0xF5D00 Offset: 0xF5E01 VA: 0xF5D00
	internal static Action guiChanged; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0xF5D90 Offset: 0xF5E91 VA: 0xF5D90
	[CompilerGeneratedAttribute] // RVA: 0xF5D90 Offset: 0xF5E91 VA: 0xF5D90
	private static bool <guiIsExiting>k__BackingField; // 0x38
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x40

	// Properties
	[NativePropertyAttribute] // RVA: 0xF84C0 Offset: 0xF85C1 VA: 0xF84C0
	internal static float pixelsPerPoint { get; }
	[NativePropertyAttribute] // RVA: 0xF8500 Offset: 0xF8601 VA: 0xF8500
	internal static int guiDepth { get; }
	[NativePropertyAttribute] // RVA: 0xF8540 Offset: 0xF8641 VA: 0xF8540
	internal static bool mouseUsed { set; }
	[StaticAccessorAttribute] // RVA: 0xF8580 Offset: 0xF8681 VA: 0xF8580
	internal static bool textFieldInput { set; }
	public static string systemCopyBuffer { get; set; }
	[StaticAccessorAttribute] // RVA: 0xF85C0 Offset: 0xF86C1 VA: 0xF85C0
	internal static string compositionString { get; }
	[StaticAccessorAttribute] // RVA: 0xF8600 Offset: 0xF8701 VA: 0xF8600
	internal static Vector2 compositionCursorPos { set; }
	internal static bool guiIsExiting { set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; set; }

	// Methods

	[VisibleToOtherModulesAttribute] // RVA: 0xF72C0 Offset: 0xF73C1 VA: 0xF72C0
	// RVA: 0x34FE3E0 Offset: 0x34FE4E1 VA: 0x34FE3E0
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7350 Offset: 0xF7451 VA: 0xF7350
	// RVA: 0x34FE420 Offset: 0x34FE521 VA: 0x34FE420
	internal static int get_guiDepth() { }

	// RVA: 0x34FE460 Offset: 0x34FE561 VA: 0x34FE460
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x34FE4B0 Offset: 0x34FE5B1 VA: 0x34FE4B0
	internal static void set_textFieldInput(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xF73E0 Offset: 0xF74E1 VA: 0xF73E0
	// RVA: 0x34FE500 Offset: 0x34FE601 VA: 0x34FE500
	public static string get_systemCopyBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xF7420 Offset: 0xF7521 VA: 0xF7420
	// RVA: 0x34FE540 Offset: 0x34FE641 VA: 0x34FE540
	public static void set_systemCopyBuffer(string value) { }

	[StaticAccessorAttribute] // RVA: 0xF7460 Offset: 0xF7561 VA: 0xF7460
	// RVA: 0x34FE590 Offset: 0x34FE691 VA: 0x34FE590
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF74A0 Offset: 0xF75A1 VA: 0xF74A0
	// RVA: 0x34FE660 Offset: 0x34FE761 VA: 0x34FE660
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7530 Offset: 0xF7631 VA: 0xF7530
	// RVA: 0x34FE6B0 Offset: 0x34FE7B1 VA: 0x34FE6B0
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethodAttribute] // RVA: 0xF75C0 Offset: 0xF76C1 VA: 0xF75C0
	// RVA: 0x34FE700 Offset: 0x34FE801 VA: 0x34FE700
	internal static void Internal_EndContainer() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7600 Offset: 0xF7701 VA: 0xF7600
	// RVA: 0x34FE740 Offset: 0x34FE841 VA: 0x34FE740
	internal static int CheckForTabEvent(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7690 Offset: 0xF7791 VA: 0xF7690
	// RVA: 0x34FE790 Offset: 0x34FE891 VA: 0x34FE790
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7720 Offset: 0xF7821 VA: 0xF7720
	// RVA: 0x34FE7D0 Offset: 0x34FE8D1 VA: 0x34FE7D0
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF77B0 Offset: 0xF78B1 VA: 0xF77B0
	// RVA: 0x34FE810 Offset: 0x34FE911 VA: 0x34FE810
	internal static bool HasFocusableControls() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7840 Offset: 0xF7941 VA: 0xF7840
	// RVA: 0x34FE850 Offset: 0x34FE951 VA: 0x34FE850
	internal static bool OwnsId(int id) { }

	// RVA: 0x34FE8A0 Offset: 0x34FE9A1 VA: 0x34FE8A0
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF78D0 Offset: 0xF79D1 VA: 0xF78D0
	// RVA: 0x34FE990 Offset: 0x34FEA91 VA: 0x34FE990
	internal static string get_compositionString() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7960 Offset: 0xF7A61 VA: 0xF7960
	// RVA: 0x34FE9D0 Offset: 0x34FEAD1 VA: 0x34FE9D0
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x34FEA70 Offset: 0x34FEB71 VA: 0x34FEA70
	private static int Internal_GetHotControl() { }

	// RVA: 0x34FEAB0 Offset: 0x34FEBB1 VA: 0x34FEAB0
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x34FEAF0 Offset: 0x34FEBF1 VA: 0x34FEAF0
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x34FEB40 Offset: 0x34FEC41 VA: 0x34FEB40
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x34FEB90 Offset: 0x34FEC91 VA: 0x34FEB90
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x34FEBE0 Offset: 0x34FECE1 VA: 0x34FEBE0
	private static void Internal_ExitGUI() { }

	// RVA: 0x34FEC20 Offset: 0x34FED21 VA: 0x34FEC20
	private static Vector2 InternalScreenToWindowPoint(Vector2 screenPoint) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF79F0 Offset: 0xF7AF1 VA: 0xF79F0
	// RVA: 0x34FECD0 Offset: 0x34FEDD1 VA: 0x34FECD0
	private static void MarkGUIChanged() { }

	// RVA: 0x34FED40 Offset: 0x34FEE41 VA: 0x34FED40
	public static int GetControlID(FocusType focus) { }

	// RVA: 0x34FEDB0 Offset: 0x34FEEB1 VA: 0x34FEDB0
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x34FEE20 Offset: 0x34FEF21 VA: 0x34FEE20
	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGeneratedAttribute] // RVA: 0xF7A00 Offset: 0xF7B01 VA: 0xF7A00
	// RVA: 0x34FEEA0 Offset: 0x34FEFA1 VA: 0x34FEEA0
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x34FEF00 Offset: 0x34FF001 VA: 0x34FEF00
	public static int get_hotControl() { }

	// RVA: 0x34FEF40 Offset: 0x34FF041 VA: 0x34FEF40
	public static void set_hotControl(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF7A10 Offset: 0xF7B11 VA: 0xF7A10
	// RVA: 0x34FEF90 Offset: 0x34FF091 VA: 0x34FEF90
	internal static void TakeCapture() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF7A20 Offset: 0xF7B21 VA: 0xF7A20
	// RVA: 0x34FF000 Offset: 0x34FF101 VA: 0x34FF000
	internal static void RemoveCapture() { }

	// RVA: 0x34FF070 Offset: 0x34FF171 VA: 0x34FF070
	public static int get_keyboardControl() { }

	// RVA: 0x34FF0B0 Offset: 0x34FF1B1 VA: 0x34FF0B0
	public static void set_keyboardControl(int value) { }

	// RVA: 0x34FF100 Offset: 0x34FF201 VA: 0x34FF100
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x34FF1D0 Offset: 0x34FF2D1 VA: 0x34FF1D0
	public static void ExitGUI() { }

	// RVA: 0x34FF230 Offset: 0x34FF331 VA: 0x34FF230
	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF7A30 Offset: 0xF7B31 VA: 0xF7A30
	// RVA: 0x34FF2E0 Offset: 0x34FF3E1 VA: 0x34FF2E0
	internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7A40 Offset: 0xF7B41 VA: 0xF7A40
	// RVA: 0x34FF370 Offset: 0x34FF471 VA: 0x34FF370
	internal static void EndContainer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF7AD0 Offset: 0xF7BD1 VA: 0xF7AD0
	// RVA: 0x34FF3E0 Offset: 0x34FF4E1 VA: 0x34FF3E0
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF7AE0 Offset: 0xF7BE1 VA: 0xF7AE0
	// RVA: 0x34FF5C0 Offset: 0x34FF6C1 VA: 0x34FF5C0
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF7AF0 Offset: 0xF7BF1 VA: 0xF7AF0
	// RVA: 0x34FF770 Offset: 0x34FF871 VA: 0x34FF770
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF7B00 Offset: 0xF7C01 VA: 0xF7B00
	// RVA: 0x34FF8D0 Offset: 0x34FF9D1 VA: 0x34FF8D0
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7B10 Offset: 0xF7C11 VA: 0xF7B10
	// RVA: 0x34FF490 Offset: 0x34FF591 VA: 0x34FF490
	internal static void ResetGlobalState() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7BA0 Offset: 0xF7CA1 VA: 0xF7BA0
	// RVA: 0x34FF950 Offset: 0x34FFA51 VA: 0x34FF950
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF7C30 Offset: 0xF7D31 VA: 0xF7C30
	// RVA: 0x34FF840 Offset: 0x34FF941 VA: 0x34FF840
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x34FF9E0 Offset: 0x34FFAE1 VA: 0x34FF9E0
	internal static void CheckOnGUI() { }

	// RVA: 0x34FFAA0 Offset: 0x34FFBA1 VA: 0x34FFAA0
	public static Vector2 ScreenToGUIPoint(Vector2 screenPoint) { }

	// RVA: 0x34FFB00 Offset: 0x34FFC01 VA: 0x34FFB00
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x34FFB70 Offset: 0x34FFC71 VA: 0x34FFB70
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x34FFC20 Offset: 0x34FFD21 VA: 0x34FFC20
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x34FFD30 Offset: 0x34FFE31 VA: 0x34FFD30
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x34FE600 Offset: 0x34FE701 VA: 0x34FE600
	private static int GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	// RVA: 0x34FE920 Offset: 0x34FEA21 VA: 0x34FE920
	private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	// RVA: 0x34FEA20 Offset: 0x34FEB21 VA: 0x34FEA20
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

	// RVA: 0x34FEC80 Offset: 0x34FED81 VA: 0x34FEC80
	private static void InternalScreenToWindowPoint_Injected(ref Vector2 screenPoint, out Vector2 ret) { }
}

