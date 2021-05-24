public struct AsyncTaskMethodBuilder<TResult> // TypeDefIndex: 1248
{
	// Fields
	internal static readonly Task<TResult> s_defaultResultTask; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x0
	private Task<TResult> m_task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E8640 Offset: 0x26E8741 VA: 0x26E8640
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.Create
	|-AsyncTaskMethodBuilder<object>.Create
	|
	|-RVA: 0x26E6EF0 Offset: 0x26E6FF1 VA: 0x26E6EF0
	|-AsyncTaskMethodBuilder<Nullable<int>>.Create
	|
	|-RVA: 0x26E28F0 Offset: 0x26E29F1 VA: 0x26E28F0
	|-AsyncTaskMethodBuilder<bool>.Create
	|
	|-RVA: 0x26E3F40 Offset: 0x26E4041 VA: 0x26E3F40
	|-AsyncTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x26E5580 Offset: 0x26E5681 VA: 0x26E5580
	|-AsyncTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.Create
	|
	|-RVA: 0x26E8E40 Offset: 0x26E8F41 VA: 0x26E8E40
	|-AsyncTaskMethodBuilder<VoidTaskResult>.Create
	*/

	[DebuggerStepThroughAttribute] // RVA: 0xB9530 Offset: 0xB9631 VA: 0xB9530
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327C70 Offset: 0x327D71 VA: 0x327C70
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0x327B00 Offset: 0x327C01 VA: 0x327B00
	|-AsyncTaskMethodBuilder<bool>.Start<MessagePackStreamReader.<TryReadMoreDataAsync>d__14>
	|
	|-RVA: 0x327B10 Offset: 0x327C11 VA: 0x327B10
	|-AsyncTaskMethodBuilder<bool>.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-RVA: 0x327B80 Offset: 0x327C81 VA: 0x327B80
	|-AsyncTaskMethodBuilder<int>.Start<StreamPolyfillExtensions.<<ReadAsync>g__FinishReadAsync|1_0>d>
	|
	|-RVA: 0x327B90 Offset: 0x327C91 VA: 0x327B90
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x327BA0 Offset: 0x327CA1 VA: 0x327BA0
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<StartOperation>d__58>
	|
	|-RVA: 0x327BB0 Offset: 0x327CB1 VA: 0x327BB0
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x327BD0 Offset: 0x327CD1 VA: 0x327BD0
	|-AsyncTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.Start<MessagePackStreamReader.<ReadAsync>d__10>
	|
	|-RVA: 0x327BF0 Offset: 0x327CF1 VA: 0x327BF0
	|-AsyncTaskMethodBuilder<Nullable<int>>.Start<AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x327C50 Offset: 0x327D51 VA: 0x327C50
	|-AsyncTaskMethodBuilder<object>.Start<MessagePackSerializer.<DeserializeAsync>d__45<object>>
	|
	|-RVA: 0x327C60 Offset: 0x327D61 VA: 0x327C60
	|-AsyncTaskMethodBuilder<object>.Start<MessagePackSerializer.<DeserializeObjectAsync>d__24<object>>
	|
	|-RVA: 0x327C80 Offset: 0x327D81 VA: 0x327C80
	|-AsyncTaskMethodBuilder<object>.Start<object>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3693B0 Offset: 0x3694B1 VA: 0x3693B0
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.SetStateMachine
	|-AsyncTaskMethodBuilder<object>.SetStateMachine
	|
	|-RVA: 0x369090 Offset: 0x369191 VA: 0x369090
	|-AsyncTaskMethodBuilder<bool>.SetStateMachine
	|
	|-RVA: 0x369130 Offset: 0x369231 VA: 0x369130
	|-AsyncTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x3691D0 Offset: 0x3692D1 VA: 0x3691D0
	|-AsyncTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetStateMachine
	|
	|-RVA: 0x369310 Offset: 0x369411 VA: 0x369310
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetStateMachine
	|
	|-RVA: 0x369450 Offset: 0x369551 VA: 0x369450
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327B20 Offset: 0x327C21 VA: 0x327B20
	|-AsyncTaskMethodBuilder<int>.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x327C00 Offset: 0x327D01 VA: 0x327C00
	|-AsyncTaskMethodBuilder<object>.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x327C90 Offset: 0x327D91 VA: 0x327C90
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x327CA0 Offset: 0x327DA1 VA: 0x327CA0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327C20 Offset: 0x327D21 VA: 0x327C20
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0x327AD0 Offset: 0x327BD1 VA: 0x327AD0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-RVA: 0x327AE0 Offset: 0x327BE1 VA: 0x327AE0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-RVA: 0x327AF0 Offset: 0x327BF1 VA: 0x327AF0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, MessagePackStreamReader.<TryReadMoreDataAsync>d__14>
	|
	|-RVA: 0x327B30 Offset: 0x327C31 VA: 0x327B30
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x327B70 Offset: 0x327C71 VA: 0x327B70
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<StartOperation>d__58>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<StartOperation>d__58>
	|
	|-RVA: 0x327B40 Offset: 0x327C41 VA: 0x327B40
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamPolyfillExtensions.<<ReadAsync>g__FinishReadAsync|1_0>d>
	|
	|-RVA: 0x327B50 Offset: 0x327C51 VA: 0x327B50
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x327B60 Offset: 0x327C61 VA: 0x327B60
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x327BC0 Offset: 0x327CC1 VA: 0x327BC0
	|-AsyncTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, MessagePackStreamReader.<ReadAsync>d__10>
	|
	|-RVA: 0x327BE0 Offset: 0x327CE1 VA: 0x327BE0
	|-AsyncTaskMethodBuilder<Nullable<int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x327C10 Offset: 0x327D11 VA: 0x327C10
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x327C30 Offset: 0x327D31 VA: 0x327C30
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, MessagePackSerializer.<DeserializeAsync>d__45<object>>
	|
	|-RVA: 0x327C40 Offset: 0x327D41 VA: 0x327C40
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>, MessagePackSerializer.<DeserializeObjectAsync>d__24<object>>
	|
	|-RVA: 0x327CB0 Offset: 0x327DB1 VA: 0x327CB0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x327CC0 Offset: 0x327DC1 VA: 0x327CC0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327CD0 Offset: 0x327DD1 VA: 0x327CD0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327CE0 Offset: 0x327DE1 VA: 0x327CE0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327CF0 Offset: 0x327DF1 VA: 0x327CF0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x3025A0 Offset: 0x3026A1 VA: 0x3025A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x3025B0 Offset: 0x3026B1 VA: 0x3025B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x3025C0 Offset: 0x3026C1 VA: 0x3025C0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, MessagePackSerializer.<SerializeAsync>d__38<object>>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3693C0 Offset: 0x3694C1 VA: 0x3693C0
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.get_Task
	|-AsyncTaskMethodBuilder<object>.get_Task
	|
	|-RVA: 0x369320 Offset: 0x369421 VA: 0x369320
	|-AsyncTaskMethodBuilder<Nullable<int>>.get_Task
	|
	|-RVA: 0x3690A0 Offset: 0x3691A1 VA: 0x3690A0
	|-AsyncTaskMethodBuilder<bool>.get_Task
	|
	|-RVA: 0x369140 Offset: 0x369241 VA: 0x369140
	|-AsyncTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x3691E0 Offset: 0x3692E1 VA: 0x3691E0
	|-AsyncTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.get_Task
	|
	|-RVA: 0x369460 Offset: 0x369561 VA: 0x369460
	|-AsyncTaskMethodBuilder<VoidTaskResult>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3693D0 Offset: 0x3694D1 VA: 0x3693D0
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.SetResult
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0x3690B0 Offset: 0x3691B1 VA: 0x3690B0
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x369150 Offset: 0x369251 VA: 0x369150
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x3691F0 Offset: 0x3692F1 VA: 0x3691F0
	|-AsyncTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetResult
	|
	|-RVA: 0x369330 Offset: 0x369431 VA: 0x369330
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x369470 Offset: 0x369571 VA: 0x369470
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	*/

	// RVA: -1 Offset: -1
	internal void SetResult(Task<TResult> completedTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3690C0 Offset: 0x3691C1 VA: 0x3690C0
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x369160 Offset: 0x369261 VA: 0x369160
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x369230 Offset: 0x369331 VA: 0x369230
	|-AsyncTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetResult
	|
	|-RVA: 0x369340 Offset: 0x369441 VA: 0x369340
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x3693E0 Offset: 0x3694E1 VA: 0x3693E0
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0x369480 Offset: 0x369581 VA: 0x369480
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x369430 Offset: 0x369531 VA: 0x369430
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.SetException
	|-AsyncTaskMethodBuilder<object>.SetException
	|
	|-RVA: 0x369110 Offset: 0x369211 VA: 0x369110
	|-AsyncTaskMethodBuilder<bool>.SetException
	|
	|-RVA: 0x3691B0 Offset: 0x3692B1 VA: 0x3691B0
	|-AsyncTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x3692C0 Offset: 0x3693C1 VA: 0x3692C0
	|-AsyncTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetException
	|
	|-RVA: 0x369390 Offset: 0x369491 VA: 0x369390
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetException
	|
	|-RVA: 0x3694D0 Offset: 0x3695D1 VA: 0x3694D0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetException
	*/

	// RVA: -1 Offset: -1
	private Task<TResult> GetTaskForResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x369120 Offset: 0x369221 VA: 0x369120
	|-AsyncTaskMethodBuilder<bool>.GetTaskForResult
	|
	|-RVA: 0x3691C0 Offset: 0x3692C1 VA: 0x3691C0
	|-AsyncTaskMethodBuilder<int>.GetTaskForResult
	|
	|-RVA: 0x3692D0 Offset: 0x3693D1 VA: 0x3692D0
	|-AsyncTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.GetTaskForResult
	|
	|-RVA: 0x3693A0 Offset: 0x3694A1 VA: 0x3693A0
	|-AsyncTaskMethodBuilder<Nullable<int>>.GetTaskForResult
	|
	|-RVA: 0x369440 Offset: 0x369541 VA: 0x369440
	|-AsyncTaskMethodBuilder<object>.GetTaskForResult
	|
	|-RVA: 0x3694E0 Offset: 0x3695E1 VA: 0x3694E0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.GetTaskForResult
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E3E40 Offset: 0x26E3F41 VA: 0x26E3E40
	|-AsyncTaskMethodBuilder<bool>..cctor
	|
	|-RVA: 0x26E5480 Offset: 0x26E5581 VA: 0x26E5480
	|-AsyncTaskMethodBuilder<int>..cctor
	|
	|-RVA: 0x26E6DC0 Offset: 0x26E6EC1 VA: 0x26E6DC0
	|-AsyncTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>..cctor
	|
	|-RVA: 0x26E8540 Offset: 0x26E8641 VA: 0x26E8540
	|-AsyncTaskMethodBuilder<Nullable<int>>..cctor
	|
	|-RVA: 0x26E8D40 Offset: 0x26E8E41 VA: 0x26E8D40
	|-AsyncTaskMethodBuilder<object>..cctor
	|
	|-RVA: 0x26EA380 Offset: 0x26EA481 VA: 0x26EA380
	|-AsyncTaskMethodBuilder<VoidTaskResult>..cctor
	*/
}

