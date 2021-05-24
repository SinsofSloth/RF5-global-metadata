public class Logger : ILogger, ILogHandler // TypeDefIndex: 2956
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xCA230 Offset: 0xCA331 VA: 0xCA230
	[DebuggerBrowsableAttribute] // RVA: 0xCA230 Offset: 0xCA331 VA: 0xCA230
	private ILogHandler <logHandler>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xCA270 Offset: 0xCA371 VA: 0xCA270
	[DebuggerBrowsableAttribute] // RVA: 0xCA270 Offset: 0xCA371 VA: 0xCA270
	private bool <logEnabled>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xCA2B0 Offset: 0xCA3B1 VA: 0xCA2B0
	[DebuggerBrowsableAttribute] // RVA: 0xCA2B0 Offset: 0xCA3B1 VA: 0xCA2B0
	private LogType <filterLogType>k__BackingField; // 0x1C

	// Properties
	public ILogHandler logHandler { get; set; }
	public bool logEnabled { get; set; }
	public LogType filterLogType { get; set; }

	// Methods

	// RVA: 0x1A30A20 Offset: 0x1A30B21 VA: 0x1A30A20
	public void .ctor(ILogHandler logHandler) { }

	[CompilerGeneratedAttribute] // RVA: 0xD4B80 Offset: 0xD4C81 VA: 0xD4B80
	// RVA: 0x1A30A70 Offset: 0x1A30B71 VA: 0x1A30A70 Slot: 4
	public ILogHandler get_logHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0xD4B90 Offset: 0xD4C91 VA: 0xD4B90
	// RVA: 0x1A30A80 Offset: 0x1A30B81 VA: 0x1A30A80 Slot: 10
	public void set_logHandler(ILogHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD4BA0 Offset: 0xD4CA1 VA: 0xD4BA0
	// RVA: 0x1A30A90 Offset: 0x1A30B91 VA: 0x1A30A90 Slot: 11
	public bool get_logEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0xD4BB0 Offset: 0xD4CB1 VA: 0xD4BB0
	// RVA: 0x1A30AA0 Offset: 0x1A30BA1 VA: 0x1A30AA0 Slot: 12
	public void set_logEnabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD4BC0 Offset: 0xD4CC1 VA: 0xD4BC0
	// RVA: 0x1A30AB0 Offset: 0x1A30BB1 VA: 0x1A30AB0 Slot: 13
	public LogType get_filterLogType() { }

	[CompilerGeneratedAttribute] // RVA: 0xD4BD0 Offset: 0xD4CD1 VA: 0xD4BD0
	// RVA: 0x1A30AC0 Offset: 0x1A30BC1 VA: 0x1A30AC0 Slot: 14
	public void set_filterLogType(LogType value) { }

	// RVA: 0x1A30AD0 Offset: 0x1A30BD1 VA: 0x1A30AD0 Slot: 15
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x1A30B10 Offset: 0x1A30C11 VA: 0x1A30B10
	private static string GetString(object message) { }

	// RVA: 0x1A30C40 Offset: 0x1A30D41 VA: 0x1A30C40 Slot: 5
	public void Log(LogType logType, object message) { }

	// RVA: 0x1A30DC0 Offset: 0x1A30EC1 VA: 0x1A30DC0 Slot: 6
	public void Log(LogType logType, object message, Object context) { }

	// RVA: 0x1A30F50 Offset: 0x1A31051 VA: 0x1A30F50 Slot: 7
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x1A31070 Offset: 0x1A31171 VA: 0x1A31070 Slot: 8
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x1A31190 Offset: 0x1A31291 VA: 0x1A31190 Slot: 9
	public void LogException(Exception exception, Object context) { }
}

