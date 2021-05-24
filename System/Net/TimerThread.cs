internal static class TimerThread // TypeDefIndex: 1918
{
	// Fields
	private static LinkedList<WeakReference> s_Queues; // 0x0
	private static LinkedList<WeakReference> s_NewQueues; // 0x8
	private static int s_ThreadState; // 0x10
	private static AutoResetEvent s_ThreadReadyEvent; // 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
	private static WaitHandle[] s_ThreadEvents; // 0x28
	private static Hashtable s_QueuesCache; // 0x30

	// Methods

	// RVA: 0x16DE5F0 Offset: 0x16DE6F1 VA: 0x16DE5F0
	private static void .cctor() { }

	// RVA: 0x16DE850 Offset: 0x16DE951 VA: 0x16DE850
	internal static TimerThread.Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x16DEB50 Offset: 0x16DEC51 VA: 0x16DEB50
	private static void StopTimerThread() { }

	// RVA: 0x16DEBE0 Offset: 0x16DECE1 VA: 0x16DEBE0
	private static void OnDomainUnload(object sender, EventArgs e) { }
}

