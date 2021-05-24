[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
[NativeHeaderAttribute] // RVA: 0xC4070 Offset: 0xC4171 VA: 0xC4070
public class Application // TypeDefIndex: 2833
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xC9860 Offset: 0xC9961 VA: 0xC9860
	[DebuggerBrowsableAttribute] // RVA: 0xC9860 Offset: 0xC9961 VA: 0xC9860
	private static Application.LowMemoryCallback lowMemory; // 0x0
	private static Application.LogCallback s_LogCallbackHandler; // 0x8
	private static Application.LogCallback s_LogCallbackHandlerThreaded; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0xC98A0 Offset: 0xC99A1 VA: 0xC98A0
	[CompilerGeneratedAttribute] // RVA: 0xC98A0 Offset: 0xC99A1 VA: 0xC98A0
	private static Action<bool> focusChanged; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xC98E0 Offset: 0xC99E1 VA: 0xC98E0
	[DebuggerBrowsableAttribute] // RVA: 0xC98E0 Offset: 0xC99E1 VA: 0xC98E0
	private static Action<string> deepLinkActivated; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0xC9920 Offset: 0xC9A21 VA: 0xC9920
	[CompilerGeneratedAttribute] // RVA: 0xC9920 Offset: 0xC9A21 VA: 0xC9920
	private static Func<bool> wantsToQuit; // 0x28
	[DebuggerBrowsableAttribute] // RVA: 0xC9960 Offset: 0xC9A61 VA: 0xC9960
	[CompilerGeneratedAttribute] // RVA: 0xC9960 Offset: 0xC9A61 VA: 0xC9960
	private static Action quitting; // 0x30

	// Properties
	public static bool isPlaying { get; }
	public static bool runInBackground { set; }
	public static string dataPath { get; }
	public static string streamingAssetsPath { get; }
	[SecurityCriticalAttribute] // RVA: 0xDDC60 Offset: 0xDDD61 VA: 0xDDC60
	public static string persistentDataPath { get; }
	public static string unityVersion { get; }
	public static string version { get; }
	public static int targetFrameRate { get; set; }
	public static ThreadPriority backgroundLoadingPriority { set; }
	public static bool genuine { get; }
	public static bool genuineCheckAvailable { get; }
	public static RuntimePlatform platform { get; }
	public static bool isMobilePlatform { get; }
	public static SystemLanguage systemLanguage { get; }
	public static NetworkReachability internetReachability { get; }
	public static bool isEditor { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xCC7E0 Offset: 0xCC8E1 VA: 0xCC7E0
	// RVA: 0x2AF56D0 Offset: 0x2AF57D1 VA: 0x2AF56D0
	public static void Quit(int exitCode) { }

	// RVA: 0x2AF5720 Offset: 0x2AF5821 VA: 0x2AF5720
	public static void Quit() { }

	[FreeFunctionAttribute] // RVA: 0xCC820 Offset: 0xCC921 VA: 0xCC820
	// RVA: 0x2AF5770 Offset: 0x2AF5871 VA: 0x2AF5770
	public static bool get_isPlaying() { }

	[FreeFunctionAttribute] // RVA: 0xCC860 Offset: 0xCC961 VA: 0xCC860
	// RVA: 0x2AF57B0 Offset: 0x2AF58B1 VA: 0x2AF57B0
	public static void set_runInBackground(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCC8A0 Offset: 0xCC9A1 VA: 0xCC8A0
	// RVA: 0x2AF5800 Offset: 0x2AF5901 VA: 0x2AF5800
	public static bool HasProLicense() { }

	[FreeFunctionAttribute] // RVA: 0xCC8E0 Offset: 0xCC9E1 VA: 0xCC8E0
	// RVA: 0x2AF5840 Offset: 0x2AF5941 VA: 0x2AF5840
	public static string get_dataPath() { }

	[FreeFunctionAttribute] // RVA: 0xCC920 Offset: 0xCCA21 VA: 0xCC920
	// RVA: 0x2AF5880 Offset: 0x2AF5981 VA: 0x2AF5880
	public static string get_streamingAssetsPath() { }

	[FreeFunctionAttribute] // RVA: 0xCC970 Offset: 0xCCA71 VA: 0xCC970
	// RVA: 0x2AF58C0 Offset: 0x2AF59C1 VA: 0x2AF58C0
	public static string get_persistentDataPath() { }

	[FreeFunctionAttribute] // RVA: 0xCC9B0 Offset: 0xCCAB1 VA: 0xCC9B0
	// RVA: 0x2AF5900 Offset: 0x2AF5A01 VA: 0x2AF5900
	public static string get_unityVersion() { }

	[FreeFunctionAttribute] // RVA: 0xCCA00 Offset: 0xCCB01 VA: 0xCCA00
	// RVA: 0x2AF5940 Offset: 0x2AF5A41 VA: 0x2AF5940
	public static string get_version() { }

	[FreeFunctionAttribute] // RVA: 0xCCA40 Offset: 0xCCB41 VA: 0xCCA40
	// RVA: 0x2AF5980 Offset: 0x2AF5A81 VA: 0x2AF5980
	public static void OpenURL(string url) { }

	[FreeFunctionAttribute] // RVA: 0xCCA80 Offset: 0xCCB81 VA: 0xCCA80
	// RVA: 0x2AF59D0 Offset: 0x2AF5AD1 VA: 0x2AF59D0
	public static int get_targetFrameRate() { }

	[FreeFunctionAttribute] // RVA: 0xCCAC0 Offset: 0xCCBC1 VA: 0xCCAC0
	// RVA: 0x2AF5A10 Offset: 0x2AF5B11 VA: 0x2AF5A10
	public static void set_targetFrameRate(int value) { }

	[FreeFunctionAttribute] // RVA: 0xCCB00 Offset: 0xCCC01 VA: 0xCCB00
	// RVA: 0x2AF5A60 Offset: 0x2AF5B61 VA: 0x2AF5A60
	private static void SetLogCallbackDefined(bool defined) { }

	[FreeFunctionAttribute] // RVA: 0xCCB40 Offset: 0xCCC41 VA: 0xCCB40
	// RVA: 0x2AF5AB0 Offset: 0x2AF5BB1 VA: 0x2AF5AB0
	public static void set_backgroundLoadingPriority(ThreadPriority value) { }

	[FreeFunctionAttribute] // RVA: 0xCCB80 Offset: 0xCCC81 VA: 0xCCB80
	// RVA: 0x2AF5B00 Offset: 0x2AF5C01 VA: 0x2AF5B00
	public static bool get_genuine() { }

	[FreeFunctionAttribute] // RVA: 0xCCBC0 Offset: 0xCCCC1 VA: 0xCCBC0
	// RVA: 0x2AF5B40 Offset: 0x2AF5C41 VA: 0x2AF5B40
	public static bool get_genuineCheckAvailable() { }

	[FreeFunctionAttribute] // RVA: 0xCCC00 Offset: 0xCCD01 VA: 0xCCC00
	// RVA: 0x2AF5B80 Offset: 0x2AF5C81 VA: 0x2AF5B80
	public static RuntimePlatform get_platform() { }

	// RVA: 0x2AF5BC0 Offset: 0x2AF5CC1 VA: 0x2AF5BC0
	public static bool get_isMobilePlatform() { }

	[FreeFunctionAttribute] // RVA: 0xCCC50 Offset: 0xCCD51 VA: 0xCCC50
	// RVA: 0x2AF5C60 Offset: 0x2AF5D61 VA: 0x2AF5C60
	public static SystemLanguage get_systemLanguage() { }

	[FreeFunctionAttribute] // RVA: 0xCCC90 Offset: 0xCCD91 VA: 0xCCC90
	// RVA: 0x2AF5CA0 Offset: 0x2AF5DA1 VA: 0x2AF5CA0
	public static NetworkReachability get_internetReachability() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCCCD0 Offset: 0xCCDD1 VA: 0xCCCD0
	// RVA: 0x2AF5CE0 Offset: 0x2AF5DE1 VA: 0x2AF5CE0
	internal static void CallLowMemory() { }

	// RVA: 0x2AF5F80 Offset: 0x2AF6081 VA: 0x2AF5F80
	public static void add_logMessageReceivedThreaded(Application.LogCallback value) { }

	// RVA: 0x2AF6050 Offset: 0x2AF6151 VA: 0x2AF6050
	public static void remove_logMessageReceivedThreaded(Application.LogCallback value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCCCE0 Offset: 0xCCDE1 VA: 0xCCCE0
	// RVA: 0x2AF60F0 Offset: 0x2AF61F1 VA: 0x2AF60F0
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCCCF0 Offset: 0xCCDF1 VA: 0xCCCF0
	// RVA: 0x2AF6600 Offset: 0x2AF6701 VA: 0x2AF6600
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCCD00 Offset: 0xCCE01 VA: 0xCCD00
	// RVA: 0x2AF6930 Offset: 0x2AF6A31 VA: 0x2AF6930
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCCD10 Offset: 0xCCE11 VA: 0xCCD10
	// RVA: 0x2AF69A0 Offset: 0x2AF6AA1 VA: 0x2AF69A0
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCCD20 Offset: 0xCCE21 VA: 0xCCD20
	// RVA: 0x2AF6BD0 Offset: 0x2AF6CD1 VA: 0x2AF6BD0
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCCD30 Offset: 0xCCE31 VA: 0xCCD30
	// RVA: 0x2AF6C50 Offset: 0x2AF6D51 VA: 0x2AF6C50
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x2AF6CD0 Offset: 0x2AF6DD1 VA: 0x2AF6CD0
	public static bool get_isEditor() { }
}

