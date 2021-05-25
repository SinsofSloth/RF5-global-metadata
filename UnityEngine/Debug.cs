[NativeHeaderAttribute] // RVA: 0xC4600 Offset: 0xC4701 VA: 0xC4600
public class Debug // TypeDefIndex: 2854
{
	// Fields
	internal static ILogger s_Logger; // 0x0

	// Properties
	public static ILogger unityLogger { get; }
	[StaticAccessorAttribute] // RVA: 0xDE1B0 Offset: 0xDE2B1 VA: 0xDE1B0
	[NativePropertyAttribute] // RVA: 0xDE1B0 Offset: 0xDE2B1 VA: 0xDE1B0
	public static bool isDebugBuild { get; }

	// Methods

	// RVA: 0x2B04DF0 Offset: 0x2B04EF1 VA: 0x2B04DF0
	public static ILogger get_unityLogger() { }

	[ExcludeFromDocsAttribute] // RVA: 0xCDC30 Offset: 0xCDD31 VA: 0xCDC30
	// RVA: 0x2B04E60 Offset: 0x2B04F61 VA: 0x2B04E60
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[FreeFunctionAttribute] // RVA: 0xCDC40 Offset: 0xCDD41 VA: 0xCDC40
	// RVA: 0x2B04F40 Offset: 0x2B05041 VA: 0x2B04F40
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[ExcludeFromDocsAttribute] // RVA: 0xCDC80 Offset: 0xCDD81 VA: 0xCDC80
	// RVA: 0x2B050A0 Offset: 0x2B051A1 VA: 0x2B050A0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	[ExcludeFromDocsAttribute] // RVA: 0xCDC90 Offset: 0xCDD91 VA: 0xCDC90
	// RVA: 0x2B052D0 Offset: 0x2B053D1 VA: 0x2B052D0
	public static void DrawRay(Vector3 start, Vector3 dir) { }

	// RVA: 0x2B05180 Offset: 0x2B05281 VA: 0x2B05180
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	// RVA: 0x2B05390 Offset: 0x2B05491 VA: 0x2B05390
	public static void Log(object message) { }

	// RVA: 0x2B054D0 Offset: 0x2B055D1 VA: 0x2B054D0
	public static void Log(object message, Object context) { }

	// RVA: 0x2B05610 Offset: 0x2B05711 VA: 0x2B05610
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x2B05750 Offset: 0x2B05851 VA: 0x2B05750
	public static void LogError(object message) { }

	// RVA: 0x2B05890 Offset: 0x2B05991 VA: 0x2B05890
	public static void LogError(object message, Object context) { }

	// RVA: 0x2B059D0 Offset: 0x2B05AD1 VA: 0x2B059D0
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x2B05B10 Offset: 0x2B05C11 VA: 0x2B05B10
	public static void LogErrorFormat(Object context, string format, object[] args) { }

	// RVA: 0x2AF67F0 Offset: 0x2AF68F1 VA: 0x2AF67F0
	public static void LogException(Exception exception) { }

	// RVA: 0x2B05C60 Offset: 0x2B05D61 VA: 0x2B05C60
	public static void LogException(Exception exception, Object context) { }

	// RVA: 0x2B01E10 Offset: 0x2B01F11 VA: 0x2B01E10
	public static void LogWarning(object message) { }

	// RVA: 0x2B05DA0 Offset: 0x2B05EA1 VA: 0x2B05DA0
	public static void LogWarning(object message, Object context) { }

	// RVA: 0x2B05EE0 Offset: 0x2B05FE1 VA: 0x2B05EE0
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x2B06020 Offset: 0x2B06121 VA: 0x2B06020
	public static void LogWarningFormat(Object context, string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0xCDCA0 Offset: 0xCDDA1 VA: 0xCDCA0
	// RVA: 0x2B06170 Offset: 0x2B06271 VA: 0x2B06170
	public static void Assert(bool condition) { }

	[ConditionalAttribute] // RVA: 0xCDCE0 Offset: 0xCDDE1 VA: 0xCDCE0
	// RVA: 0x2B062B0 Offset: 0x2B063B1 VA: 0x2B062B0
	public static void Assert(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0xCDD20 Offset: 0xCDE21 VA: 0xCDD20
	// RVA: 0x2AF6F20 Offset: 0x2AF7021 VA: 0x2AF6F20
	public static void LogAssertion(object message) { }

	// RVA: 0x2B063F0 Offset: 0x2B064F1 VA: 0x2B063F0
	public static bool get_isDebugBuild() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCDD60 Offset: 0xCDE61 VA: 0xCDD60
	// RVA: 0x2B06430 Offset: 0x2B06531 VA: 0x2B06430
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	// RVA: 0x2B06600 Offset: 0x2B06701 VA: 0x2B06600
	private static void .cctor() { }

	// RVA: 0x2B05020 Offset: 0x2B05121 VA: 0x2B05020
	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }
}

