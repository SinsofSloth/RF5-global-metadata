private sealed class SemaphoreSlim.TaskNode : Task<bool>, IThreadPoolWorkItem // TypeDefIndex: 763
{
	// Fields
	internal SemaphoreSlim.TaskNode Prev; // 0x58
	internal SemaphoreSlim.TaskNode Next; // 0x60

	// Methods

	// RVA: 0x1577810 Offset: 0x1577911 VA: 0x1577810
	internal void .ctor() { }

	// RVA: 0x1578E60 Offset: 0x1578F61 VA: 0x1578E60 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1578EC0 Offset: 0x1578FC1 VA: 0x1578EC0 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }
}

