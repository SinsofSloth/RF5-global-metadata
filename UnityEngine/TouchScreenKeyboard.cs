[NativeHeaderAttribute] // RVA: 0xC7270 Offset: 0xC7371 VA: 0xC7270
[NativeHeaderAttribute] // RVA: 0xC7270 Offset: 0xC7371 VA: 0xC7270
[NativeConditionalAttribute] // RVA: 0xC7270 Offset: 0xC7371 VA: 0xC7270
public class TouchScreenKeyboard // TypeDefIndex: 3062
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public static bool isSupported { get; }
	public static bool isInPlaceEditingAllowed { get; }
	public string text { get; set; }
	public static bool hideInput { set; }
	public bool active { get; set; }
	public TouchScreenKeyboard.Status status { get; }
	public int characterLimit { set; }
	public bool canGetSelection { get; }
	public bool canSetSelection { get; }
	public RangeInt selection { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xD8120 Offset: 0xD8221 VA: 0xD8120
	// RVA: 0x2A361B0 Offset: 0x2A362B1 VA: 0x2A361B0
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x2A36200 Offset: 0x2A36301 VA: 0x2A36200
	private void Destroy() { }

	// RVA: 0x2A362C0 Offset: 0x2A363C1 VA: 0x2A362C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2A36330 Offset: 0x2A36431 VA: 0x2A36330
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunctionAttribute] // RVA: 0xD8170 Offset: 0xD8271 VA: 0xD8170
	// RVA: 0x2A36490 Offset: 0x2A36591 VA: 0x2A36490
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x2A364F0 Offset: 0x2A365F1 VA: 0x2A364F0
	public static bool get_isSupported() { }

	// RVA: 0x2A36570 Offset: 0x2A36671 VA: 0x2A36570
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x2A36580 Offset: 0x2A36681 VA: 0x2A36580
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD81B0 Offset: 0xD82B1 VA: 0xD81B0
	// RVA: 0x2A36640 Offset: 0x2A36741 VA: 0x2A36640
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeNameAttribute] // RVA: 0xD81C0 Offset: 0xD82C1 VA: 0xD81C0
	// RVA: 0x2A36720 Offset: 0x2A36821 VA: 0x2A36720
	public string get_text() { }

	[NativeNameAttribute] // RVA: 0xD8200 Offset: 0xD8301 VA: 0xD8200
	// RVA: 0x2A36770 Offset: 0x2A36871 VA: 0x2A36770
	public void set_text(string value) { }

	[NativeNameAttribute] // RVA: 0xD8240 Offset: 0xD8341 VA: 0xD8240
	// RVA: 0x2A367C0 Offset: 0x2A368C1 VA: 0x2A367C0
	public static void set_hideInput(bool value) { }

	[NativeNameAttribute] // RVA: 0xD8280 Offset: 0xD8381 VA: 0xD8280
	// RVA: 0x2A36810 Offset: 0x2A36911 VA: 0x2A36810
	public bool get_active() { }

	[NativeNameAttribute] // RVA: 0xD82C0 Offset: 0xD83C1 VA: 0xD82C0
	// RVA: 0x2A36860 Offset: 0x2A36961 VA: 0x2A36860
	public void set_active(bool value) { }

	[NativeNameAttribute] // RVA: 0xD8300 Offset: 0xD8401 VA: 0xD8300
	// RVA: 0x2A368B0 Offset: 0x2A369B1 VA: 0x2A368B0
	public TouchScreenKeyboard.Status get_status() { }

	[NativeNameAttribute] // RVA: 0xD8340 Offset: 0xD8441 VA: 0xD8340
	// RVA: 0x2A36900 Offset: 0x2A36A01 VA: 0x2A36900
	public void set_characterLimit(int value) { }

	[NativeNameAttribute] // RVA: 0xD8380 Offset: 0xD8481 VA: 0xD8380
	// RVA: 0x2A36950 Offset: 0x2A36A51 VA: 0x2A36950
	public bool get_canGetSelection() { }

	[NativeNameAttribute] // RVA: 0xD83C0 Offset: 0xD84C1 VA: 0xD83C0
	// RVA: 0x2A369A0 Offset: 0x2A36AA1 VA: 0x2A369A0
	public bool get_canSetSelection() { }

	// RVA: 0x2A369F0 Offset: 0x2A36AF1 VA: 0x2A369F0
	public RangeInt get_selection() { }

	// RVA: 0x2A36AA0 Offset: 0x2A36BA1 VA: 0x2A36AA0
	public void set_selection(RangeInt value) { }

	// RVA: 0x2A36A50 Offset: 0x2A36B51 VA: 0x2A36A50
	private static void GetSelection(out int start, out int length) { }

	// RVA: 0x2A36BB0 Offset: 0x2A36CB1 VA: 0x2A36BB0
	private static void SetSelection(int start, int length) { }
}

