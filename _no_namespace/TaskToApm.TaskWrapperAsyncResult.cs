private sealed class TaskToApm.TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 881
{
	// Fields
	internal readonly Task Task; // 0x10
	private readonly object m_state; // 0x18
	private readonly bool m_completedSynchronously; // 0x20

	// Properties
	private object System.IAsyncResult.AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	private bool System.IAsyncResult.IsCompleted { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }

	// Methods

	// RVA: 0x1588410 Offset: 0x1588511 VA: 0x1588410
	internal void .ctor(Task task, object state, bool completedSynchronously) { }

	// RVA: 0x1588690 Offset: 0x1588791 VA: 0x1588690 Slot: 6
	private object System.IAsyncResult.get_AsyncState() { }

	// RVA: 0x15886A0 Offset: 0x15887A1 VA: 0x15886A0 Slot: 7
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x15886B0 Offset: 0x15887B1 VA: 0x15886B0 Slot: 4
	private bool System.IAsyncResult.get_IsCompleted() { }

	// RVA: 0x1588730 Offset: 0x1588831 VA: 0x1588730 Slot: 5
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }
}

