public static class ThreadPool // TypeDefIndex: 819
{
	// Methods

	// RVA: 0x158A270 Offset: 0x158A371 VA: 0x158A270
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x158A5F0 Offset: 0x158A6F1 VA: 0x158A5F0
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x15761A0 Offset: 0x15762A1 VA: 0x15761A0
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x158A860 Offset: 0x158A961 VA: 0x158A860
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	// RVA: 0x158A5C0 Offset: 0x158A6C1 VA: 0x158A5C0
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x158A750 Offset: 0x158A851 VA: 0x158A750
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x1577DF0 Offset: 0x1577EF1 VA: 0x1577DF0
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	// RVA: 0x1588D80 Offset: 0x1588E81 VA: 0x1588D80
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	// RVA: 0x158AB80 Offset: 0x158AC81 VA: 0x158AB80
	internal static bool RequestWorkerThread() { }

	// RVA: 0x158A8A0 Offset: 0x158A9A1 VA: 0x158A8A0
	private static void EnsureVMInitialized() { }

	// RVA: 0x158ABA0 Offset: 0x158ACA1 VA: 0x158ABA0
	internal static bool NotifyWorkItemComplete() { }

	// RVA: 0x158ABB0 Offset: 0x158ACB1 VA: 0x158ABB0
	internal static void ReportThreadStatus(bool isWorking) { }

	// RVA: 0x1588EC0 Offset: 0x1588FC1 VA: 0x1588EC0
	internal static void NotifyWorkItemProgress() { }

	// RVA: 0x158ABC0 Offset: 0x158ACC1 VA: 0x158ABC0
	internal static void NotifyWorkItemProgressNative() { }

	// RVA: 0x158ABD0 Offset: 0x158ACD1 VA: 0x158ABD0
	internal static bool IsThreadPoolHosted() { }

	// RVA: 0x158AB90 Offset: 0x158AC91 VA: 0x158AB90
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }
}

