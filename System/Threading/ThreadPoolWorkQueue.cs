internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 812
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x158AC90 Offset: 0x158AD91 VA: 0x158AC90
	public void .ctor() { }

	// RVA: 0x158ADE0 Offset: 0x158AEE1 VA: 0x158ADE0
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x158AFF0 Offset: 0x158B0F1 VA: 0x158AFF0
	internal void EnsureThreadRequested() { }

	// RVA: 0x158B0B0 Offset: 0x158B1B1 VA: 0x158B0B0
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x158A970 Offset: 0x158AA71 VA: 0x158A970
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x158AB00 Offset: 0x158AC01 VA: 0x158AB00
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x158BC50 Offset: 0x158BD51 VA: 0x158BC50
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x158C3B0 Offset: 0x158C4B1 VA: 0x158C3B0
	internal static bool Dispatch() { }

	// RVA: 0x158C9D0 Offset: 0x158CAD1 VA: 0x158C9D0
	private static void .cctor() { }
}

internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 812
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x158AC90 Offset: 0x158AD91 VA: 0x158AC90
	public void .ctor() { }

	// RVA: 0x158ADE0 Offset: 0x158AEE1 VA: 0x158ADE0
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x158AFF0 Offset: 0x158B0F1 VA: 0x158AFF0
	internal void EnsureThreadRequested() { }

	// RVA: 0x158B0B0 Offset: 0x158B1B1 VA: 0x158B0B0
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x158A970 Offset: 0x158AA71 VA: 0x158A970
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x158AB00 Offset: 0x158AC01 VA: 0x158AB00
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x158BC50 Offset: 0x158BD51 VA: 0x158BC50
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x158C3B0 Offset: 0x158C4B1 VA: 0x158C3B0
	internal static bool Dispatch() { }

	// RVA: 0x158C9D0 Offset: 0x158CAD1 VA: 0x158C9D0
	private static void .cctor() { }
}

internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 812
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x158AC90 Offset: 0x158AD91 VA: 0x158AC90
	public void .ctor() { }

	// RVA: 0x158ADE0 Offset: 0x158AEE1 VA: 0x158ADE0
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x158AFF0 Offset: 0x158B0F1 VA: 0x158AFF0
	internal void EnsureThreadRequested() { }

	// RVA: 0x158B0B0 Offset: 0x158B1B1 VA: 0x158B0B0
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x158A970 Offset: 0x158AA71 VA: 0x158A970
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x158AB00 Offset: 0x158AC01 VA: 0x158AB00
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x158BC50 Offset: 0x158BD51 VA: 0x158BC50
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x158C3B0 Offset: 0x158C4B1 VA: 0x158C3B0
	internal static bool Dispatch() { }

	// RVA: 0x158C9D0 Offset: 0x158CAD1 VA: 0x158C9D0
	private static void .cctor() { }
}

internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 812
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x158AC90 Offset: 0x158AD91 VA: 0x158AC90
	public void .ctor() { }

	// RVA: 0x158ADE0 Offset: 0x158AEE1 VA: 0x158ADE0
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x158AFF0 Offset: 0x158B0F1 VA: 0x158AFF0
	internal void EnsureThreadRequested() { }

	// RVA: 0x158B0B0 Offset: 0x158B1B1 VA: 0x158B0B0
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x158A970 Offset: 0x158AA71 VA: 0x158A970
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x158AB00 Offset: 0x158AC01 VA: 0x158AB00
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x158BC50 Offset: 0x158BD51 VA: 0x158BC50
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x158C3B0 Offset: 0x158C4B1 VA: 0x158C3B0
	internal static bool Dispatch() { }

	// RVA: 0x158C9D0 Offset: 0x158CAD1 VA: 0x158C9D0
	private static void .cctor() { }
}

internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 812
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x158AC90 Offset: 0x158AD91 VA: 0x158AC90
	public void .ctor() { }

	// RVA: 0x158ADE0 Offset: 0x158AEE1 VA: 0x158ADE0
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x158AFF0 Offset: 0x158B0F1 VA: 0x158AFF0
	internal void EnsureThreadRequested() { }

	// RVA: 0x158B0B0 Offset: 0x158B1B1 VA: 0x158B0B0
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x158A970 Offset: 0x158AA71 VA: 0x158A970
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x158AB00 Offset: 0x158AC01 VA: 0x158AB00
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x158BC50 Offset: 0x158BD51 VA: 0x158BC50
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x158C3B0 Offset: 0x158C4B1 VA: 0x158C3B0
	internal static bool Dispatch() { }

	// RVA: 0x158C9D0 Offset: 0x158CAD1 VA: 0x158C9D0
	private static void .cctor() { }
}

internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 812
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x158AC90 Offset: 0x158AD91 VA: 0x158AC90
	public void .ctor() { }

	// RVA: 0x158ADE0 Offset: 0x158AEE1 VA: 0x158ADE0
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x158AFF0 Offset: 0x158B0F1 VA: 0x158AFF0
	internal void EnsureThreadRequested() { }

	// RVA: 0x158B0B0 Offset: 0x158B1B1 VA: 0x158B0B0
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x158A970 Offset: 0x158AA71 VA: 0x158A970
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x158AB00 Offset: 0x158AC01 VA: 0x158AB00
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x158BC50 Offset: 0x158BD51 VA: 0x158BC50
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x158C3B0 Offset: 0x158C4B1 VA: 0x158C3B0
	internal static bool Dispatch() { }

	// RVA: 0x158C9D0 Offset: 0x158CAD1 VA: 0x158C9D0
	private static void .cctor() { }
}

internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 812
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x158AC90 Offset: 0x158AD91 VA: 0x158AC90
	public void .ctor() { }

	// RVA: 0x158ADE0 Offset: 0x158AEE1 VA: 0x158ADE0
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x158AFF0 Offset: 0x158B0F1 VA: 0x158AFF0
	internal void EnsureThreadRequested() { }

	// RVA: 0x158B0B0 Offset: 0x158B1B1 VA: 0x158B0B0
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x158A970 Offset: 0x158AA71 VA: 0x158A970
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x158AB00 Offset: 0x158AC01 VA: 0x158AB00
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x158BC50 Offset: 0x158BD51 VA: 0x158BC50
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x158C3B0 Offset: 0x158C4B1 VA: 0x158C3B0
	internal static bool Dispatch() { }

	// RVA: 0x158C9D0 Offset: 0x158CAD1 VA: 0x158C9D0
	private static void .cctor() { }
}

