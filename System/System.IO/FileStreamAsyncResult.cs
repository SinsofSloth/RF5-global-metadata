internal class FileStreamAsyncResult : IAsyncResult // TypeDefIndex: 688
{
	// Fields
	private object state; // 0x10
	private bool completed; // 0x18
	private ManualResetEvent wh; // 0x20
	private AsyncCallback cb; // 0x28
	private bool completedSynch; // 0x30
	public int Count; // 0x34
	public int OriginalCount; // 0x38
	public int BytesRead; // 0x3C
	private AsyncCallback realcb; // 0x40

	// Properties
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x18A8D00 Offset: 0x18A8E01 VA: 0x18A8D00
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x18AA710 Offset: 0x18AA811 VA: 0x18AA710
	private static void CBWrapper(IAsyncResult ares) { }

	// RVA: 0x18AA7B0 Offset: 0x18AA8B1 VA: 0x18AA7B0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x18AA7C0 Offset: 0x18AA8C1 VA: 0x18AA7C0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x18AA7D0 Offset: 0x18AA8D1 VA: 0x18AA7D0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x18AA7E0 Offset: 0x18AA8E1 VA: 0x18AA7E0 Slot: 4
	public bool get_IsCompleted() { }
}

