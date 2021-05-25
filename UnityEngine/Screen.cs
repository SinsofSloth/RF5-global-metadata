[StaticAccessorAttribute] // RVA: 0xC49D0 Offset: 0xC4AD1 VA: 0xC49D0
[NativeHeaderAttribute] // RVA: 0xC49D0 Offset: 0xC4AD1 VA: 0xC49D0
[NativeHeaderAttribute] // RVA: 0xC49D0 Offset: 0xC4AD1 VA: 0xC49D0
public sealed class Screen // TypeDefIndex: 2871
{
	// Properties
	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	public static ScreenOrientation orientation { get; }
	public static Resolution currentResolution { get; }
	public static bool fullScreen { get; }
	public static FullScreenMode fullScreenMode { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xCDFF0 Offset: 0xCE0F1 VA: 0xCDFF0
	// RVA: 0x2A266C0 Offset: 0x2A267C1 VA: 0x2A266C0
	public static int get_width() { }

	[NativeMethodAttribute] // RVA: 0xCE040 Offset: 0xCE141 VA: 0xCE040
	// RVA: 0x2A26700 Offset: 0x2A26801 VA: 0x2A26700
	public static int get_height() { }

	[NativeNameAttribute] // RVA: 0xCE090 Offset: 0xCE191 VA: 0xCE090
	// RVA: 0x2A26740 Offset: 0x2A26841 VA: 0x2A26740
	public static float get_dpi() { }

	// RVA: 0x2A26780 Offset: 0x2A26881 VA: 0x2A26780
	private static ScreenOrientation GetScreenOrientation() { }

	// RVA: 0x2A267C0 Offset: 0x2A268C1 VA: 0x2A267C0
	public static ScreenOrientation get_orientation() { }

	// RVA: 0x2A26800 Offset: 0x2A26901 VA: 0x2A26800
	public static Resolution get_currentResolution() { }

	[NativeNameAttribute] // RVA: 0xCE0D0 Offset: 0xCE1D1 VA: 0xCE0D0
	// RVA: 0x2A268B0 Offset: 0x2A269B1 VA: 0x2A268B0
	public static bool get_fullScreen() { }

	[NativeNameAttribute] // RVA: 0xCE110 Offset: 0xCE211 VA: 0xCE110
	// RVA: 0x2A268F0 Offset: 0x2A269F1 VA: 0x2A268F0
	public static FullScreenMode get_fullScreenMode() { }

	[NativeNameAttribute] // RVA: 0xCE150 Offset: 0xCE251 VA: 0xCE150
	// RVA: 0x2A26930 Offset: 0x2A26A31 VA: 0x2A26930
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate) { }

	// RVA: 0x2A269A0 Offset: 0x2A26AA1 VA: 0x2A269A0
	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	// RVA: 0x2A26860 Offset: 0x2A26961 VA: 0x2A26860
	private static void get_currentResolution_Injected(out Resolution ret) { }
}

