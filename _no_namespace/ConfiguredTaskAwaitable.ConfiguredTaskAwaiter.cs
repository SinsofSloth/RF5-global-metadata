public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1266
{
	// Fields
	private readonly Task m_task; // 0x0
	private readonly bool m_continueOnCapturedContext; // 0x8

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0xB200 Offset: 0xB301 VA: 0xB200
	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	// RVA: 0xB240 Offset: 0xB341 VA: 0xB240
	public bool get_IsCompleted() { }

	// RVA: 0xB260 Offset: 0xB361 VA: 0xB260 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0xB280 Offset: 0xB381 VA: 0xB280 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0xB2A0 Offset: 0xB3A1 VA: 0xB2A0
	public void GetResult() { }
}

