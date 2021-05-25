internal class CancellationCallbackInfo // TypeDefIndex: 755
{
	// Fields
	internal readonly Action<object> Callback; // 0x10
	internal readonly object StateForCallback; // 0x18
	internal readonly SynchronizationContext TargetSyncContext; // 0x20
	internal readonly ExecutionContext TargetExecutionContext; // 0x28
	internal readonly CancellationTokenSource CancellationTokenSource; // 0x30
	private static ContextCallback s_executionContextCallback; // 0x0

	// Methods

	// RVA: 0x1A0A5A0 Offset: 0x1A0A6A1 VA: 0x1A0A5A0
	internal void .ctor(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	// RVA: 0x1A0A640 Offset: 0x1A0A741 VA: 0x1A0A640
	internal void ExecuteCallback() { }

	// RVA: 0x1A0A910 Offset: 0x1A0AA11 VA: 0x1A0A910
	private static void ExecutionContextCallback(object obj) { }
}

