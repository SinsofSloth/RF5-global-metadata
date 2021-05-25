internal class Task.ContingentProperties // TypeDefIndex: 850
{
	// Fields
	internal ExecutionContext m_capturedContext; // 0x10
	internal ManualResetEventSlim m_completionEvent; // 0x18
	internal TaskExceptionHolder m_exceptionsHolder; // 0x20
	internal CancellationToken m_cancellationToken; // 0x28
	internal Shared<CancellationTokenRegistration> m_cancellationRegistration; // 0x30
	internal int m_internalCancellationRequested; // 0x38
	internal int m_completionCountdown; // 0x3C
	internal List<Task> m_exceptionalChildren; // 0x40

	// Methods

	// RVA: 0x1581110 Offset: 0x1581211 VA: 0x1581110
	internal void SetCompleted() { }

	// RVA: 0x1581150 Offset: 0x1581251 VA: 0x1581150
	internal void DeregisterCancellationCallback() { }

	// RVA: 0x157D940 Offset: 0x157DA41 VA: 0x157D940
	public void .ctor() { }
}

