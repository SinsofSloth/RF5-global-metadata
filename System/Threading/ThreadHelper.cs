internal class ThreadHelper // TypeDefIndex: 803
{
	// Fields
	private Delegate _start; // 0x10
	private object _startArg; // 0x18
	private ExecutionContext _executionContext; // 0x20
	internal static ContextCallback _ccb; // 0x0

	// Methods

	// RVA: 0x1589C10 Offset: 0x1589D11 VA: 0x1589C10
	private static void .cctor() { }

	// RVA: 0x1589550 Offset: 0x1589651 VA: 0x1589550
	internal void .ctor(Delegate start) { }

	// RVA: 0x1589C90 Offset: 0x1589D91 VA: 0x1589C90
	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	// RVA: 0x1589CA0 Offset: 0x1589DA1 VA: 0x1589CA0
	private static void ThreadStart_Context(object state) { }

	// RVA: 0x1589FD0 Offset: 0x158A0D1 VA: 0x1589FD0
	internal void ThreadStart(object obj) { }

	// RVA: 0x158A0E0 Offset: 0x158A1E1 VA: 0x158A0E0
	internal void ThreadStart() { }
}

