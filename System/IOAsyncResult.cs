internal abstract class IOAsyncResult : IAsyncResult // TypeDefIndex: 1760
{
	// Fields
	private AsyncCallback async_callback; // 0x10
	private object async_state; // 0x18
	private ManualResetEvent wait_handle; // 0x20
	private bool completed_synchronously; // 0x28
	private bool completed; // 0x29

	// Properties
	public AsyncCallback AsyncCallback { get; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; set; }
	public bool IsCompleted { get; set; }

	// Methods

	// RVA: 0x28EF000 Offset: 0x28EF101 VA: 0x28EF000
	protected void .ctor(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x28EF050 Offset: 0x28EF151 VA: 0x28EF050
	public AsyncCallback get_AsyncCallback() { }

	// RVA: 0x28EF060 Offset: 0x28EF161 VA: 0x28EF060 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x28EF070 Offset: 0x28EF171 VA: 0x28EF070 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x28EF190 Offset: 0x28EF291 VA: 0x28EF190 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x28EF1A0 Offset: 0x28EF2A1 VA: 0x28EF1A0
	protected void set_CompletedSynchronously(bool value) { }

	// RVA: 0x28EF1B0 Offset: 0x28EF2B1 VA: 0x28EF1B0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x28EF1C0 Offset: 0x28EF2C1 VA: 0x28EF1C0
	protected void set_IsCompleted(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void CompleteDisposed() { }
}

