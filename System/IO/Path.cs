[ComVisibleAttribute] // RVA: 0xAEC80 Offset: 0xAED81 VA: 0xAEC80
public static class Path // TypeDefIndex: 693
{
	// Fields
	[ObsoleteAttribute] // RVA: 0xB4860 Offset: 0xB4961 VA: 0xB4860
	public static readonly char[] InvalidPathChars; // 0x0
	public static readonly char AltDirectorySeparatorChar; // 0x8
	public static readonly char DirectorySeparatorChar; // 0xA
	public static readonly char PathSeparator; // 0xC
	internal static readonly string DirectorySeparatorStr; // 0x10
	public static readonly char VolumeSeparatorChar; // 0x18
	internal static readonly char[] PathSeparatorChars; // 0x20
	private static readonly bool dirEqualsVolume; // 0x28
	internal static readonly char[] trimEndCharsWindows; // 0x30
	internal static readonly char[] trimEndCharsUnix; // 0x38

	// Properties
	internal static string DirectorySeparatorCharAsString { get; }
	internal static char[] TrimEndChars { get; }

	// Methods

	// RVA: 0x18ACB70 Offset: 0x18ACC71 VA: 0x18ACB70
	public static string Combine(string path1, string path2) { }

	// RVA: 0x18AD050 Offset: 0x18AD151 VA: 0x18AD050
	internal static string CleanPath(string s) { }

	// RVA: 0x18A1A70 Offset: 0x18A1B71 VA: 0x18A1A70
	public static string GetDirectoryName(string path) { }

	// RVA: 0x18A0BA0 Offset: 0x18A0CA1 VA: 0x18A0BA0
	public static string GetFileName(string path) { }

	// RVA: 0x18A0390 Offset: 0x18A0491 VA: 0x18A0390
	public static string GetFullPath(string path) { }

	// RVA: 0x18A3640 Offset: 0x18A3741 VA: 0x18A3640
	internal static string GetFullPathInternal(string path) { }

	// RVA: 0x18ADDD0 Offset: 0x18ADED1 VA: 0x18ADDD0
	private static extern int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull) { }

	// RVA: 0x18ADEB0 Offset: 0x18ADFB1 VA: 0x18ADEB0
	internal static string GetFullPathName(string path) { }

	// RVA: 0x18AE170 Offset: 0x18AE271 VA: 0x18AE170
	internal static string WindowsDriveAdjustment(string path) { }

	// RVA: 0x18A5990 Offset: 0x18A5A91 VA: 0x18A5990
	internal static string InsecureGetFullPath(string path) { }

	// RVA: 0x18AE460 Offset: 0x18AE561 VA: 0x18AE460
	internal static bool IsDirectorySeparator(char c) { }

	// RVA: 0x18AD5C0 Offset: 0x18AD6C1 VA: 0x18AD5C0
	public static string GetPathRoot(string path) { }

	// RVA: 0x18ACE10 Offset: 0x18ACF11 VA: 0x18ACE10
	public static bool IsPathRooted(string path) { }

	// RVA: 0x18AEF50 Offset: 0x18AF051 VA: 0x18AEF50
	public static char[] GetInvalidPathChars() { }

	// RVA: 0x18AEFE0 Offset: 0x18AF0E1 VA: 0x18AEFE0
	private static void .cctor() { }

	// RVA: 0x18AF230 Offset: 0x18AF331 VA: 0x18AF230
	private static string GetServerAndShare(string path) { }

	// RVA: 0x18AF4B0 Offset: 0x18AF5B1 VA: 0x18AF4B0
	private static bool SameRoot(string root, string path) { }

	// RVA: 0x18AE520 Offset: 0x18AE621 VA: 0x18AE520
	private static string CanonicalizePath(string path) { }

	// RVA: 0x18AFA40 Offset: 0x18AFB41 VA: 0x18AFA40
	public static string Combine(string[] paths) { }

	// RVA: 0x18AFD90 Offset: 0x18AFE91 VA: 0x18AFD90
	public static string Combine(string path1, string path2, string path3) { }

	// RVA: 0x189F870 Offset: 0x189F971 VA: 0x189F870
	internal static void Validate(string path) { }

	// RVA: 0x18AFF50 Offset: 0x18B0051 VA: 0x18AFF50
	internal static void Validate(string path, string parameterName) { }

	// RVA: 0x18B00A0 Offset: 0x18B01A1 VA: 0x18B00A0
	internal static string get_DirectorySeparatorCharAsString() { }

	// RVA: 0x18B0110 Offset: 0x18B0211 VA: 0x18B0110
	internal static char[] get_TrimEndChars() { }

	// RVA: 0x18B01B0 Offset: 0x18B02B1 VA: 0x18B01B0
	internal static void CheckSearchPattern(string searchPattern) { }

	// RVA: 0x18B0330 Offset: 0x18B0431 VA: 0x18B0330
	internal static void CheckInvalidPathChars(string path, bool checkAdditional = False) { }

	// RVA: 0x18B04F0 Offset: 0x18B05F1 VA: 0x18B04F0
	internal static string InternalCombine(string path1, string path2) { }
}

