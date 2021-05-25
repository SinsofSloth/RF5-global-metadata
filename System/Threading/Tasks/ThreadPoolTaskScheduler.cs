internal sealed class ThreadPoolTaskScheduler : TaskScheduler // TypeDefIndex: 883
{
	// Fields
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; // 0x0

	// Properties
	internal override bool RequiresAtomicStartTransition { get; }

	// Methods

	// RVA: 0x1587BA0 Offset: 0x1587CA1 VA: 0x1587BA0
	internal void .ctor() { }

	// RVA: 0x15887F0 Offset: 0x15888F1 VA: 0x15887F0
	private static void LongRunningThreadWork(object obj) { }

	// RVA: 0x1588880 Offset: 0x1588981 VA: 0x1588880 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x1588CC0 Offset: 0x1588DC1 VA: 0x1588CC0 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x1588EA0 Offset: 0x1588FA1 VA: 0x1588EA0 Slot: 6
	protected internal override bool TryDequeue(Task task) { }

	// RVA: 0x1588EB0 Offset: 0x1588FB1 VA: 0x1588EB0 Slot: 7
	internal override void NotifyWorkItemProgress() { }

	// RVA: 0x1588F80 Offset: 0x1589081 VA: 0x1588F80 Slot: 8
	internal override bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x1588F90 Offset: 0x1589091 VA: 0x1588F90
	private static void .cctor() { }
}

