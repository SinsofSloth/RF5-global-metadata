public sealed class ExceptionDispatchInfo // TypeDefIndex: 1238
{
	// Fields
	private Exception m_Exception; // 0x10
	private object m_stackTrace; // 0x18

	// Properties
	internal object BinaryStackTraceArray { get; }
	public Exception SourceException { get; }

	// Methods

	// RVA: 0x1803220 Offset: 0x1803321 VA: 0x1803220
	private void .ctor(Exception exception) { }

	// RVA: 0x1803370 Offset: 0x1803471 VA: 0x1803370
	internal object get_BinaryStackTraceArray() { }

	// RVA: 0x18017B0 Offset: 0x18018B1 VA: 0x18017B0
	public static ExceptionDispatchInfo Capture(Exception source) { }

	// RVA: 0x1803380 Offset: 0x1803481 VA: 0x1803380
	public Exception get_SourceException() { }

	// RVA: 0x1801B10 Offset: 0x1801C11 VA: 0x1801B10
	public void Throw() { }

	// RVA: 0x1803390 Offset: 0x1803491 VA: 0x1803390
	public static void Throw(Exception source) { }
}

