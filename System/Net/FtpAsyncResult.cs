internal class FtpAsyncResult : IAsyncResult // TypeDefIndex: 1965
{
	// Fields
	private FtpWebResponse response; // 0x10
	private ManualResetEvent waitHandle; // 0x18
	private Exception exception; // 0x20
	private AsyncCallback callback; // 0x28
	private Stream stream; // 0x30
	private object state; // 0x38
	private bool completed; // 0x40
	private bool synch; // 0x41
	private object locker; // 0x48

	// Properties
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool GotException { get; }
	internal Exception Exception { get; }
	internal FtpWebResponse Response { get; }
	internal Stream Stream { set; }

	// Methods

	// RVA: 0x1780F70 Offset: 0x1781071 VA: 0x1780F70
	public void .ctor(AsyncCallback callback, object state) { }

	// RVA: 0x1781020 Offset: 0x1781121 VA: 0x1781020 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1781030 Offset: 0x1781131 VA: 0x1781030 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1781130 Offset: 0x1781231 VA: 0x1781130 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1781140 Offset: 0x1781241 VA: 0x1781140 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x17811E0 Offset: 0x17812E1 VA: 0x17811E0
	internal bool get_GotException() { }

	// RVA: 0x17811F0 Offset: 0x17812F1 VA: 0x17811F0
	internal Exception get_Exception() { }

	// RVA: 0x1781200 Offset: 0x1781301 VA: 0x1781200
	internal FtpWebResponse get_Response() { }

	// RVA: 0x1781210 Offset: 0x1781311 VA: 0x1781210
	internal void set_Stream(Stream value) { }

	// RVA: 0x1781220 Offset: 0x1781321 VA: 0x1781220
	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	// RVA: 0x1781310 Offset: 0x1781411 VA: 0x1781310
	internal void SetCompleted(bool synch, Exception exc, FtpWebResponse response) { }

	// RVA: 0x17814D0 Offset: 0x17815D1 VA: 0x17814D0
	internal void SetCompleted(bool synch, FtpWebResponse response) { }

	// RVA: 0x17814E0 Offset: 0x17815E1 VA: 0x17814E0
	internal void SetCompleted(bool synch, Exception exc) { }

	// RVA: 0x1781400 Offset: 0x1781501 VA: 0x1781400
	internal void DoCallback() { }
}

