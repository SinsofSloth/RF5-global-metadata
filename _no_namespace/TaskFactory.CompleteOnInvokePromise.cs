internal sealed class TaskFactory.CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction // TypeDefIndex: 875
{
	// Fields
	private IList<Task> _tasks; // 0x58
	private int m_firstTaskAlreadyCompleted; // 0x60

	// Methods

	// RVA: 0x1587440 Offset: 0x1587541 VA: 0x1587440
	public void .ctor(IList<Task> tasks) { }

	// RVA: 0x1587540 Offset: 0x1587641 VA: 0x1587540 Slot: 20
	public void Invoke(Task completingTask) { }
}

