internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 867
{
	// Fields
	private static readonly SendOrPostCallback s_postCallback; // 0x0
	private static ContextCallback s_postActionCallback; // 0x8
	private readonly SynchronizationContext m_syncContext; // 0x20

	// Methods

	// RVA: 0x157D200 Offset: 0x157D301 VA: 0x157D200
	internal void .ctor(SynchronizationContext context, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x157D240 Offset: 0x157D341 VA: 0x157D240 Slot: 4
	internal sealed override void Run(Task task, bool canInlineContinuationTask) { }

	// RVA: 0x157D3D0 Offset: 0x157D4D1 VA: 0x157D3D0
	private static void PostAction(object state) { }

	// RVA: 0x157D480 Offset: 0x157D581 VA: 0x157D480
	private static ContextCallback GetPostActionCallback() { }

	// RVA: 0x157D570 Offset: 0x157D671 VA: 0x157D570
	private static void .cctor() { }
}

