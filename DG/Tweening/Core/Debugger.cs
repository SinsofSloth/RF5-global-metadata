public static class Debugger // TypeDefIndex: 5064
{
	// Fields
	private static int _logPriority; // 0x0
	private const string _LogPrefix = "<color=#0099bc><b>DOTWEEN ► </b></color>";

	// Properties
	public static int logPriority { get; }

	// Methods

	// RVA: 0x1988930 Offset: 0x1988A31 VA: 0x1988930
	public static int get_logPriority() { }

	// RVA: 0x1988980 Offset: 0x1988A81 VA: 0x1988980
	public static void Log(object message) { }

	// RVA: 0x19857F0 Offset: 0x19858F1 VA: 0x19857F0
	public static void LogWarning(object message, Tween t) { }

	// RVA: 0x1985D70 Offset: 0x1985E71 VA: 0x1985D70
	public static void LogError(object message) { }

	// RVA: 0x1987170 Offset: 0x1987271 VA: 0x1987170
	public static void LogReport(object message) { }

	// RVA: 0x19872C0 Offset: 0x19873C1 VA: 0x19872C0
	public static void LogSafeModeReport(object message) { }

	// RVA: 0x1988AC0 Offset: 0x1988BC1 VA: 0x1988AC0
	public static void LogInvalidTween(Tween t) { }

	// RVA: 0x1988B10 Offset: 0x1988C11 VA: 0x1988B10
	public static void LogNestedTween(Tween t) { }

	// RVA: 0x1988B60 Offset: 0x1988C61 VA: 0x1988B60
	public static void LogNullTween(Tween t) { }

	// RVA: 0x1988BB0 Offset: 0x1988CB1 VA: 0x1988BB0
	public static void LogNonPathTween(Tween t) { }

	// RVA: 0x1988C00 Offset: 0x1988D01 VA: 0x1988C00
	public static void LogMissingMaterialProperty(string propertyName) { }

	// RVA: 0x1988C60 Offset: 0x1988D61 VA: 0x1988C60
	public static void LogMissingMaterialProperty(int propertyId) { }

	// RVA: 0x1988CE0 Offset: 0x1988DE1 VA: 0x1988CE0
	public static void LogRemoveActiveTweenError(string errorInfo, Tween t) { }

	// RVA: 0x1988D50 Offset: 0x1988E51 VA: 0x1988D50
	public static void LogAddActiveTweenError(string errorInfo, Tween t) { }

	// RVA: 0x1988DC0 Offset: 0x1988EC1 VA: 0x1988DC0
	public static void SetLogPriority(LogBehaviour logBehaviour) { }
}

