public interface IValueTaskSource<TResult> // TypeDefIndex: 4434
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<object>.GetStatus
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TResult GetResult(short token) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<object>.GetResult
	*/
}

