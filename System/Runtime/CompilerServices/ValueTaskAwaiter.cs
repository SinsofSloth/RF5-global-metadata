[IsReadOnlyAttribute] // RVA: 0x129610 Offset: 0x129711 VA: 0x129610
public struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4442
{
	// Fields
	internal static readonly Action<object> s_invokeActionDelegate; // 0x0
	private readonly ValueTask _value; // 0x0

	// Methods

	// RVA: 0x269A0 Offset: 0x26AA1 VA: 0x269A0 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x269B0 Offset: 0x26AB1 VA: 0x269B0 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x1BD9F20 Offset: 0x1BDA021 VA: 0x1BD9F20
	private static void .cctor() { }
}

