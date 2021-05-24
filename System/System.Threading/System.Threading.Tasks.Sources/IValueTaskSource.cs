public interface IValueTaskSource // TypeDefIndex: 4433
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetResult(short token) { }
}

