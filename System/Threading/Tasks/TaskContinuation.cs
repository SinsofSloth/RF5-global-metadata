internal abstract class TaskContinuation // TypeDefIndex: 865
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask) { }

	// RVA: 0x157C830 Offset: 0x157C931 VA: 0x157C830
	protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection) { }

	// RVA: 0x157AAD0 Offset: 0x157ABD1 VA: 0x157AAD0
	protected void .ctor() { }
}

