internal class IOSelectorJob : IThreadPoolWorkItem // TypeDefIndex: 1761
{
	// Fields
	private IOOperation operation; // 0x10
	private IOAsyncCallback callback; // 0x18
	private IOAsyncResult state; // 0x20

	// Methods

	// RVA: 0x28EF2A0 Offset: 0x28EF3A1 VA: 0x28EF2A0
	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x28EF300 Offset: 0x28EF401 VA: 0x28EF300 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x28EF320 Offset: 0x28EF421 VA: 0x28EF320 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x28EF330 Offset: 0x28EF431 VA: 0x28EF330
	public void MarkDisposed() { }
}

