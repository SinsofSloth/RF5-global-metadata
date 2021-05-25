[IsReadOnlyAttribute] // RVA: 0x1295E0 Offset: 0x1296E1 VA: 0x1295E0
public struct ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4439
{
	// Fields
	private readonly ValueTask _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x267F0 Offset: 0x268F1 VA: 0x267F0
	internal void .ctor(ValueTask value) { }

	// RVA: 0x26800 Offset: 0x26901 VA: 0x26800
	public bool get_IsCompleted() { }

	[StackTraceHiddenAttribute] // RVA: 0x1296B0 Offset: 0x1297B1 VA: 0x1296B0
	// RVA: 0x26920 Offset: 0x26A21 VA: 0x26920
	public void GetResult() { }

	// RVA: 0x26930 Offset: 0x26A31 VA: 0x26930 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x26940 Offset: 0x26A41 VA: 0x26940 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
}

