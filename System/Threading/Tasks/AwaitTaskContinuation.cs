internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 871
{
	// Fields
	private readonly ExecutionContext m_capturedContext; // 0x10
	protected readonly Action m_action; // 0x18
	private static ContextCallback s_invokeActionCallback; // 0x0

	// Properties
	internal static bool IsValidLocationForInlining { get; }

	// Methods

	// RVA: 0x157AA00 Offset: 0x157AB01 VA: 0x157AA00
	internal void .ctor(Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x157AAE0 Offset: 0x157ABE1 VA: 0x157AAE0
	internal void .ctor(Action action, bool flowExecutionContext) { }

	// RVA: 0x157ABA0 Offset: 0x157ACA1 VA: 0x157ABA0
	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler) { }

	// RVA: 0x157AEC0 Offset: 0x157AFC1 VA: 0x157AEC0 Slot: 4
	internal override void Run(Task task, bool canInlineContinuationTask) { }

	// RVA: 0x157B050 Offset: 0x157B151 VA: 0x157B050
	internal static bool get_IsValidLocationForInlining() { }

	// RVA: 0x157B540 Offset: 0x157B641 VA: 0x157B540
	private void ExecuteWorkItemHelper() { }

	// RVA: 0x157B6C0 Offset: 0x157B7C1 VA: 0x157B6C0 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x157B6F0 Offset: 0x157B7F1 VA: 0x157B6F0 Slot: 6
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x157B700 Offset: 0x157B801 VA: 0x157B700
	private static void InvokeAction(object state) { }

	// RVA: 0x157B770 Offset: 0x157B871 VA: 0x157B770
	protected static ContextCallback GetInvokeActionCallback() { }

	// RVA: 0x157B1E0 Offset: 0x157B2E1 VA: 0x157B1E0
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	// RVA: 0x157B990 Offset: 0x157BA91 VA: 0x157B990
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	// RVA: 0x157BB30 Offset: 0x157BC31 VA: 0x157BB30
	internal static void UnsafeScheduleAction(Action action, Task task) { }

	// RVA: 0x157B820 Offset: 0x157B921 VA: 0x157B820
	protected static void ThrowAsyncIfNecessary(Exception exc) { }
}

