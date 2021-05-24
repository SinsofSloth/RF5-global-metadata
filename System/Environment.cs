[ComVisibleAttribute] // RVA: 0xACCC0 Offset: 0xACDC1 VA: 0xACCC0
public static class Environment // TypeDefIndex: 350
{
	// Fields
	private const int mono_corlib_version = 1051100001;
	private static string nl; // 0x0
	private static OperatingSystem os; // 0x8

	// Properties
	public static int CurrentManagedThreadId { get; }
	public static bool HasShutdownStarted { get; }
	public static string MachineName { get; }
	public static string NewLine { get; }
	internal static PlatformID Platform { get; }
	public static OperatingSystem OSVersion { get; }
	public static string StackTrace { get; }
	public static int TickCount { get; }
	public static string UserDomainName { get; }
	public static string UserName { get; }
	public static bool Is64BitProcess { get; }
	public static int ProcessorCount { get; }
	internal static bool IsRunningOnWindows { get; }

	// Methods

	// RVA: 0x1796D60 Offset: 0x1796E61 VA: 0x1796D60
	internal static string GetResourceString(string key) { }

	// RVA: 0x179A960 Offset: 0x179AA61 VA: 0x179A960
	internal static string GetResourceString(string key, object[] values) { }

	// RVA: 0x179BC60 Offset: 0x179BD61 VA: 0x179BC60
	internal static string GetResourceStringEncodingName(int codePage) { }

	// RVA: 0x179BE50 Offset: 0x179BF51 VA: 0x179BE50
	public static int get_CurrentManagedThreadId() { }

	// RVA: 0x179BE80 Offset: 0x179BF81 VA: 0x179BE80
	public static bool get_HasShutdownStarted() { }

	// RVA: 0x179BE90 Offset: 0x179BF91 VA: 0x179BE90
	public static string get_MachineName() { }

	// RVA: 0x179BEA0 Offset: 0x179BFA1 VA: 0x179BEA0
	private static string GetNewLine() { }

	// RVA: 0x179BEB0 Offset: 0x179BFB1 VA: 0x179BEB0
	public static string get_NewLine() { }

	[CompilerGeneratedAttribute] // RVA: 0xB7160 Offset: 0xB7261 VA: 0xB7160
	// RVA: 0x179BF40 Offset: 0x179C041 VA: 0x179BF40
	internal static PlatformID get_Platform() { }

	// RVA: 0x179BF50 Offset: 0x179C051 VA: 0x179BF50
	internal static string GetOSVersionString() { }

	// RVA: 0x179BF60 Offset: 0x179C061 VA: 0x179BF60
	public static OperatingSystem get_OSVersion() { }

	// RVA: 0x179C030 Offset: 0x179C131 VA: 0x179C030
	internal static Version CreateVersionFromString(string info) { }

	// RVA: 0x179C280 Offset: 0x179C381 VA: 0x179C280
	public static string get_StackTrace() { }

	// RVA: 0x179C300 Offset: 0x179C401 VA: 0x179C300
	public static int get_TickCount() { }

	// RVA: 0x179C310 Offset: 0x179C411 VA: 0x179C310
	public static string get_UserDomainName() { }

	// RVA: 0x179C320 Offset: 0x179C421 VA: 0x179C320
	public static string get_UserName() { }

	// RVA: 0x179C330 Offset: 0x179C431 VA: 0x179C330
	public static void Exit(int exitCode) { }

	// RVA: 0x179C340 Offset: 0x179C441 VA: 0x179C340
	public static string ExpandEnvironmentVariables(string name) { }

	// RVA: 0x179C770 Offset: 0x179C871 VA: 0x179C770
	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	// RVA: 0x179C780 Offset: 0x179C881 VA: 0x179C780
	internal static string internalGetEnvironmentVariable(string variable) { }

	// RVA: 0x179C620 Offset: 0x179C721 VA: 0x179C620
	public static string GetEnvironmentVariable(string variable) { }

	// RVA: 0x179C650 Offset: 0x179C751 VA: 0x179C650
	private static Hashtable GetEnvironmentVariablesNoCase() { }

	// RVA: 0x179C840 Offset: 0x179C941 VA: 0x179C840
	public static string GetFolderPath(Environment.SpecialFolder folder) { }

	// RVA: 0x179C8E0 Offset: 0x179C9E1 VA: 0x179C8E0
	private static string GetWindowsFolderPath(int folder) { }

	// RVA: 0x179C890 Offset: 0x179C991 VA: 0x179C890
	public static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x179CD00 Offset: 0x179CE01 VA: 0x179CD00
	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	// RVA: 0x179C8F0 Offset: 0x179C9F1 VA: 0x179C8F0
	internal static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x179D230 Offset: 0x179D331 VA: 0x179D230
	public static void FailFast(string message) { }

	// RVA: 0x179D290 Offset: 0x179D391 VA: 0x179D290
	public static void FailFast(string message, Exception exception) { }

	// RVA: 0x179D330 Offset: 0x179D431 VA: 0x179D330
	public static bool get_Is64BitProcess() { }

	// RVA: 0x179D350 Offset: 0x179D451 VA: 0x179D350
	public static int get_ProcessorCount() { }

	// RVA: 0x179C630 Offset: 0x179C731 VA: 0x179C630
	internal static bool get_IsRunningOnWindows() { }

	// RVA: 0x179C830 Offset: 0x179C931 VA: 0x179C830
	private static string[] GetEnvironmentVariableNames() { }

	// RVA: 0x179D360 Offset: 0x179D461 VA: 0x179D360
	internal static string GetMachineConfigPath() { }

	// RVA: 0x179D220 Offset: 0x179D321 VA: 0x179D220
	internal static string internalGetHome() { }

	// RVA: 0x179D370 Offset: 0x179D471 VA: 0x179D370
	internal static int GetPageSize() { }

	// RVA: 0x179D380 Offset: 0x179D481 VA: 0x179D380
	internal static string GetStackTrace(Exception e, bool needFileInfo) { }
}

