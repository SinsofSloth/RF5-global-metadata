internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 866
{
	// Fields
	internal readonly Task m_task; // 0x10
	internal readonly TaskContinuationOptions m_options; // 0x18
	private readonly TaskScheduler m_taskScheduler; // 0x20

	// Methods

	// RVA: 0x157C2C0 Offset: 0x157C3C1 VA: 0x157C2C0
	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	// RVA: 0x157C620 Offset: 0x157C721 VA: 0x157C620 Slot: 4
	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }
}

