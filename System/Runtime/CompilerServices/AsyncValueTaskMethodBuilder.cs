public struct AsyncValueTaskMethodBuilder // TypeDefIndex: 4436
{
	// Fields
	private AsyncTaskMethodBuilder _methodBuilder; // 0x0
	private bool _haveResult; // 0x18
	private bool _useBuilder; // 0x19

	// Properties
	public ValueTask Task { get; }

	// Methods

	// RVA: 0x1BD9470 Offset: 0x1BD9571 VA: 0x1BD9470
	public static AsyncValueTaskMethodBuilder Create() { }

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302610 Offset: 0x302711 VA: 0x302610
	|-AsyncValueTaskMethodBuilder.Start<StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x302620 Offset: 0x302721 VA: 0x302620
	|-AsyncValueTaskMethodBuilder.Start<object>
	*/

	// RVA: 0x266F0 Offset: 0x267F1 VA: 0x266F0
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0x26700 Offset: 0x26801 VA: 0x26700
	public void SetResult() { }

	// RVA: 0x26720 Offset: 0x26821 VA: 0x26720
	public void SetException(Exception exception) { }

	// RVA: 0x26730 Offset: 0x26831 VA: 0x26730
	public ValueTask get_Task() { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3025D0 Offset: 0x3026D1 VA: 0x3025D0
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x3025F0 Offset: 0x3026F1 VA: 0x3025F0
	|-AsyncValueTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamPolyfillExtensions.<WriteAsync>d__3>
	*/
}

