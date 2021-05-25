[ComVisibleAttribute] // RVA: 0xAF080 Offset: 0xAF181 VA: 0xAF080
[DebuggerDisplayAttribute] // RVA: 0xAF080 Offset: 0xAF181 VA: 0xAF080
public class SemaphoreSlim : IDisposable // TypeDefIndex: 762
{
	// Fields
	private int m_currentCount; // 0x10
	private readonly int m_maxCount; // 0x14
	private int m_waitCount; // 0x18
	private object m_lockObj; // 0x20
	private ManualResetEvent m_waitHandle; // 0x28
	private SemaphoreSlim.TaskNode m_asyncHead; // 0x30
	private SemaphoreSlim.TaskNode m_asyncTail; // 0x38
	private static readonly Task<bool> s_trueTask; // 0x0
	private static Action<object> s_cancellationTokenCanceledEventHandler; // 0x8

	// Methods

	// RVA: 0x1576820 Offset: 0x1576921 VA: 0x1576820
	public void .ctor(int initialCount, int maxCount) { }

	// RVA: 0x15769E0 Offset: 0x1576AE1 VA: 0x15769E0
	public void Wait() { }

	// RVA: 0x15769F0 Offset: 0x1576AF1 VA: 0x15769F0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1577420 Offset: 0x1577521 VA: 0x1577420
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	// RVA: 0x1577540 Offset: 0x1577641 VA: 0x1577540
	public Task WaitAsync() { }

	// RVA: 0x1577120 Offset: 0x1577221 VA: 0x1577120
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1577550 Offset: 0x1577651 VA: 0x1577550
	private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter() { }

	// RVA: 0x1577880 Offset: 0x1577981 VA: 0x1577880
	private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task) { }

	[AsyncStateMachineAttribute] // RVA: 0xB8930 Offset: 0xB8A31 VA: 0xB8930
	// RVA: 0x1577670 Offset: 0x1577771 VA: 0x1577670
	private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1577990 Offset: 0x1577A91 VA: 0x1577990
	public int Release() { }

	// RVA: 0x15779A0 Offset: 0x1577AA1 VA: 0x15779A0
	public int Release(int releaseCount) { }

	// RVA: 0x1577D70 Offset: 0x1577E71 VA: 0x1577D70
	private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask) { }

	// RVA: 0x1577E80 Offset: 0x1577F81 VA: 0x1577E80 Slot: 4
	public void Dispose() { }

	// RVA: 0x1577F00 Offset: 0x1578001 VA: 0x1577F00 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1577FB0 Offset: 0x15780B1 VA: 0x1577FB0
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	// RVA: 0x1576F00 Offset: 0x1577001 VA: 0x1576F00
	private void CheckDispose() { }

	// RVA: 0x15769D0 Offset: 0x1576AD1 VA: 0x15769D0
	private static string GetResourceString(string str) { }

	// RVA: 0x15780C0 Offset: 0x15781C1 VA: 0x15780C0
	private static void .cctor() { }
}

