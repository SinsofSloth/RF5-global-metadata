public interface ILogger : ILogHandler // TypeDefIndex: 2954
{
	// Properties
	public abstract ILogHandler logHandler { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ILogHandler get_logHandler() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Log(LogType logType, object message) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Log(LogType logType, object message, Object context) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void LogFormat(LogType logType, string format, object[] args) { }
}

