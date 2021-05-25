[DebuggerDisplayAttribute] // RVA: 0xAF840 Offset: 0xAF941 VA: 0xAF840
[DebuggerTypeProxyAttribute] // RVA: 0xAF840 Offset: 0xAF941 VA: 0xAF840
public abstract class TaskScheduler // TypeDefIndex: 876
{
	// Fields
	private static ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers; // 0x0
	private static readonly TaskScheduler s_defaultTaskScheduler; // 0x8
	internal static int s_taskSchedulerIdCounter; // 0x10
	private int m_taskSchedulerId; // 0x10
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; // 0x18
	private static readonly object _unobservedTaskExceptionLockObject; // 0x20

	// Properties
	internal virtual bool RequiresAtomicStartTransition { get; }
	public static TaskScheduler Default { get; }
	public static TaskScheduler Current { get; }
	internal static TaskScheduler InternalCurrent { get; }
	public int Id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected internal abstract void QueueTask(Task task) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x1583350 Offset: 0x1583451 VA: 0x1583350
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x1587800 Offset: 0x1587901 VA: 0x1587800 Slot: 6
	protected internal virtual bool TryDequeue(Task task) { }

	// RVA: 0x1587810 Offset: 0x1587911 VA: 0x1587810 Slot: 7
	internal virtual void NotifyWorkItemProgress() { }

	// RVA: 0x1587820 Offset: 0x1587921 VA: 0x1587820 Slot: 8
	internal virtual bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x157FCA0 Offset: 0x157FDA1 VA: 0x157FCA0
	internal void InternalQueueTask(Task task) { }

	// RVA: 0x1587830 Offset: 0x1587931 VA: 0x1587830
	protected void .ctor() { }

	// RVA: 0x15878D0 Offset: 0x15879D1 VA: 0x15878D0
	private void AddToActiveTaskSchedulers() { }

	// RVA: 0x15879D0 Offset: 0x1587AD1 VA: 0x15879D0
	public static TaskScheduler get_Default() { }

	// RVA: 0x1583DB0 Offset: 0x1583EB1 VA: 0x1583DB0
	public static TaskScheduler get_Current() { }

	// RVA: 0x157B3E0 Offset: 0x157B4E1 VA: 0x157B3E0
	internal static TaskScheduler get_InternalCurrent() { }

	// RVA: 0x1587A40 Offset: 0x1587B41 VA: 0x1587A40
	public int get_Id() { }

	// RVA: 0x1586590 Offset: 0x1586691 VA: 0x1586590
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	// RVA: 0x1587B00 Offset: 0x1587C01 VA: 0x1587B00
	private static void .cctor() { }
}

