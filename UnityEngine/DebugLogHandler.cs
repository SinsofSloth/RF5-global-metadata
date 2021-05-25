[NativeHeaderAttribute] // RVA: 0xC45C0 Offset: 0xC46C1 VA: 0xC45C0
internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 2853
{
	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0xCDC10 Offset: 0xCDD11 VA: 0xCDC10
	// RVA: 0x2B066A0 Offset: 0x2B067A1 VA: 0x2B066A0
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0xCDC20 Offset: 0xCDD21 VA: 0xCDC20
	// RVA: 0x2B06710 Offset: 0x2B06811 VA: 0x2B06710
	internal static void Internal_LogException(Exception exception, Object obj) { }

	// RVA: 0x2B06760 Offset: 0x2B06861 VA: 0x2B06760 Slot: 4
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x2B067D0 Offset: 0x2B068D1 VA: 0x2B067D0 Slot: 5
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x2B06690 Offset: 0x2B06791 VA: 0x2B06690
	public void .ctor() { }
}

