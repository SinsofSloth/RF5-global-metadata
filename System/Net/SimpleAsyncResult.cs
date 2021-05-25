internal class SimpleAsyncResult : IAsyncResult // TypeDefIndex: 1991
{
	// Fields
	private ManualResetEvent handle; // 0x10
	private bool synch; // 0x18
	private bool isCompleted; // 0x19
	private readonly SimpleAsyncCallback cb; // 0x20
	private object state; // 0x28
	private bool callbackDone; // 0x30
	private Exception exc; // 0x38
	private object locker; // 0x40
	private Nullable<bool> user_read_synch; // 0x48

	// Properties
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	internal bool CompletedSynchronouslyPeek { get; }
	public bool IsCompleted { get; }
	internal bool GotException { get; }
	internal Exception Exception { get; }

	// Methods

	// RVA: 0x16CF790 Offset: 0x16CF891 VA: 0x16CF790
	private void .ctor(SimpleAsyncCallback cb) { }

	// RVA: 0x16CF820 Offset: 0x16CF921 VA: 0x16CF820
	protected void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x16CF950 Offset: 0x16CFA51 VA: 0x16CF950
	public static void Run(Func<SimpleAsyncResult, bool> func, SimpleAsyncCallback callback) { }

	// RVA: 0x16CFBE0 Offset: 0x16CFCE1 VA: 0x16CFBE0
	public static void RunWithLock(object locker, Func<SimpleAsyncResult, bool> func, SimpleAsyncCallback callback) { }

	// RVA: 0x16CFD10 Offset: 0x16CFE11 VA: 0x16CFD10
	protected void Reset_internal() { }

	// RVA: 0x16CFB90 Offset: 0x16CFC91 VA: 0x16CFB90
	internal void SetCompleted(bool synch, Exception e) { }

	// RVA: 0x16CFB40 Offset: 0x16CFC41 VA: 0x16CFB40
	internal void SetCompleted(bool synch) { }

	// RVA: 0x16CFDE0 Offset: 0x16CFEE1 VA: 0x16CFDE0
	private void SetCompleted_internal(bool synch, Exception e) { }

	// RVA: 0x16CFEF0 Offset: 0x16CFFF1 VA: 0x16CFEF0
	protected void SetCompleted_internal(bool synch) { }

	// RVA: 0x16CFEC0 Offset: 0x16CFFC1 VA: 0x16CFEC0
	private void DoCallback_private() { }

	// RVA: 0x16CFF00 Offset: 0x16D0001 VA: 0x16CFF00
	protected void DoCallback_internal() { }

	// RVA: 0x16CFF30 Offset: 0x16D0031 VA: 0x16CFF30
	internal void WaitUntilComplete() { }

	// RVA: 0x16D01A0 Offset: 0x16D02A1 VA: 0x16D01A0
	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	// RVA: 0x16D0290 Offset: 0x16D0391 VA: 0x16D0290 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x16D0090 Offset: 0x16D0191 VA: 0x16D0090 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x16D02A0 Offset: 0x16D03A1 VA: 0x16D02A0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x16D0350 Offset: 0x16D0451 VA: 0x16D0350
	internal bool get_CompletedSynchronouslyPeek() { }

	// RVA: 0x16CFFF0 Offset: 0x16D00F1 VA: 0x16CFFF0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x16D0360 Offset: 0x16D0461 VA: 0x16D0360
	internal bool get_GotException() { }

	// RVA: 0x16D0370 Offset: 0x16D0471 VA: 0x16D0370
	internal Exception get_Exception() { }
}

