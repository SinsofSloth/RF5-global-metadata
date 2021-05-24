internal struct AsyncMethodBuilderCore // TypeDefIndex: 1250
{
	// Fields
	internal IAsyncStateMachine m_stateMachine; // 0x0
	internal Action m_defaultContextAction; // 0x8

	// Methods

	// RVA: 0xAED0 Offset: 0xAFD1 VA: 0xAED0
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0xAEE0 Offset: 0xAFE1 VA: 0xAEE0
	internal Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize) { }

	// RVA: 0xAEF0 Offset: 0xAFF1 VA: 0xAEF0
	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	// RVA: 0xAF00 Offset: 0xB001 VA: 0xAF00
	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask) { }

	// RVA: 0x1801460 Offset: 0x1801561 VA: 0x1801460
	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	// RVA: 0x18011F0 Offset: 0x18012F1 VA: 0x18011F0
	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0x1801960 Offset: 0x1801A61 VA: 0x1801960
	internal static Task TryGetContinuationTask(Action action) { }
}

