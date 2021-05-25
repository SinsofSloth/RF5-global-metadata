internal sealed class AsyncMethodBuilderCore.MoveNextRunner // TypeDefIndex: 1251
{
	// Fields
	private readonly ExecutionContext m_context; // 0x10
	internal IAsyncStateMachine m_stateMachine; // 0x18
	private static ContextCallback s_invokeMoveNext; // 0x0

	// Methods

	// RVA: 0x1801040 Offset: 0x1801141 VA: 0x1801040
	internal void .ctor(ExecutionContext context, IAsyncStateMachine stateMachine) { }

	// RVA: 0x1801C60 Offset: 0x1801D61 VA: 0x1801C60
	internal void Run() { }

	// RVA: 0x1801E40 Offset: 0x1801F41 VA: 0x1801E40
	private static void InvokeMoveNext(object stateMachine) { }
}

