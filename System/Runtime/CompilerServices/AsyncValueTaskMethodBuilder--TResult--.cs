public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 4437
{
	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0

	// Properties
	public ValueTask<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EA480 Offset: 0x26EA581 VA: 0x26EA480
	|-AsyncValueTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x26EA670 Offset: 0x26EA771 VA: 0x26EA670
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.Create
	|
	|-RVA: 0x26EA960 Offset: 0x26EAA61 VA: 0x26EA960
	|-AsyncValueTaskMethodBuilder<object>.Create
	*/

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302650 Offset: 0x302751 VA: 0x302650
	|-AsyncValueTaskMethodBuilder<int>.Start<StreamPolyfillExtensions.<<ReadAsync>g__FinishReadAsync|1_0>d>
	|
	|-RVA: 0x302680 Offset: 0x302781 VA: 0x302680
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.Start<MessagePackStreamReader.<ReadAsync>d__10>
	|
	|-RVA: 0x3026F0 Offset: 0x3027F1 VA: 0x3026F0
	|-AsyncValueTaskMethodBuilder<object>.Start<MessagePackSerializer.<DeserializeAsync>d__45<object>>
	|
	|-RVA: 0x302700 Offset: 0x302801 VA: 0x302700
	|-AsyncValueTaskMethodBuilder<object>.Start<MessagePackSerializer.<DeserializeObjectAsync>d__24<object>>
	|
	|-RVA: 0x302710 Offset: 0x302811 VA: 0x302710
	|-AsyncValueTaskMethodBuilder<object>.Start<object>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3694F0 Offset: 0x3695F1 VA: 0x3694F0
	|-AsyncValueTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x369600 Offset: 0x369701 VA: 0x369600
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetStateMachine
	|
	|-RVA: 0x369780 Offset: 0x369881 VA: 0x369780
	|-AsyncValueTaskMethodBuilder<object>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x369530 Offset: 0x369631 VA: 0x369530
	|-AsyncValueTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x369640 Offset: 0x369741 VA: 0x369640
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetResult
	|
	|-RVA: 0x3697C0 Offset: 0x3698C1 VA: 0x3697C0
	|-AsyncValueTaskMethodBuilder<object>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3695A0 Offset: 0x3696A1 VA: 0x3695A0
	|-AsyncValueTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x369720 Offset: 0x369821 VA: 0x369720
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetException
	|
	|-RVA: 0x369840 Offset: 0x369941 VA: 0x369840
	|-AsyncValueTaskMethodBuilder<object>.SetException
	*/

	// RVA: -1 Offset: -1
	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3695F0 Offset: 0x3696F1 VA: 0x3695F0
	|-AsyncValueTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x369770 Offset: 0x369871 VA: 0x369770
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.get_Task
	|
	|-RVA: 0x369890 Offset: 0x369991 VA: 0x369890
	|-AsyncValueTaskMethodBuilder<object>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302630 Offset: 0x302731 VA: 0x302630
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamPolyfillExtensions.<<ReadAsync>g__FinishReadAsync|1_0>d>
	|
	|-RVA: 0x302660 Offset: 0x302761 VA: 0x302660
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, MessagePackStreamReader.<ReadAsync>d__10>
	|
	|-RVA: 0x302690 Offset: 0x302791 VA: 0x302690
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x3026B0 Offset: 0x3027B1 VA: 0x3026B0
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, MessagePackSerializer.<DeserializeAsync>d__45<object>>
	|
	|-RVA: 0x3026D0 Offset: 0x3027D1 VA: 0x3026D0
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>, MessagePackSerializer.<DeserializeObjectAsync>d__24<object>>
	*/
}

public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 4437
{
	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0

	// Properties
	public ValueTask<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EA480 Offset: 0x26EA581 VA: 0x26EA480
	|-AsyncValueTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x26EA670 Offset: 0x26EA771 VA: 0x26EA670
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.Create
	|
	|-RVA: 0x26EA960 Offset: 0x26EAA61 VA: 0x26EA960
	|-AsyncValueTaskMethodBuilder<object>.Create
	*/

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302650 Offset: 0x302751 VA: 0x302650
	|-AsyncValueTaskMethodBuilder<int>.Start<StreamPolyfillExtensions.<<ReadAsync>g__FinishReadAsync|1_0>d>
	|
	|-RVA: 0x302680 Offset: 0x302781 VA: 0x302680
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.Start<MessagePackStreamReader.<ReadAsync>d__10>
	|
	|-RVA: 0x3026F0 Offset: 0x3027F1 VA: 0x3026F0
	|-AsyncValueTaskMethodBuilder<object>.Start<MessagePackSerializer.<DeserializeAsync>d__45<object>>
	|
	|-RVA: 0x302700 Offset: 0x302801 VA: 0x302700
	|-AsyncValueTaskMethodBuilder<object>.Start<MessagePackSerializer.<DeserializeObjectAsync>d__24<object>>
	|
	|-RVA: 0x302710 Offset: 0x302811 VA: 0x302710
	|-AsyncValueTaskMethodBuilder<object>.Start<object>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3694F0 Offset: 0x3695F1 VA: 0x3694F0
	|-AsyncValueTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x369600 Offset: 0x369701 VA: 0x369600
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetStateMachine
	|
	|-RVA: 0x369780 Offset: 0x369881 VA: 0x369780
	|-AsyncValueTaskMethodBuilder<object>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x369530 Offset: 0x369631 VA: 0x369530
	|-AsyncValueTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x369640 Offset: 0x369741 VA: 0x369640
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetResult
	|
	|-RVA: 0x3697C0 Offset: 0x3698C1 VA: 0x3697C0
	|-AsyncValueTaskMethodBuilder<object>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3695A0 Offset: 0x3696A1 VA: 0x3695A0
	|-AsyncValueTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x369720 Offset: 0x369821 VA: 0x369720
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetException
	|
	|-RVA: 0x369840 Offset: 0x369941 VA: 0x369840
	|-AsyncValueTaskMethodBuilder<object>.SetException
	*/

	// RVA: -1 Offset: -1
	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3695F0 Offset: 0x3696F1 VA: 0x3695F0
	|-AsyncValueTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x369770 Offset: 0x369871 VA: 0x369770
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.get_Task
	|
	|-RVA: 0x369890 Offset: 0x369991 VA: 0x369890
	|-AsyncValueTaskMethodBuilder<object>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302630 Offset: 0x302731 VA: 0x302630
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamPolyfillExtensions.<<ReadAsync>g__FinishReadAsync|1_0>d>
	|
	|-RVA: 0x302660 Offset: 0x302761 VA: 0x302660
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, MessagePackStreamReader.<ReadAsync>d__10>
	|
	|-RVA: 0x302690 Offset: 0x302791 VA: 0x302690
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x3026B0 Offset: 0x3027B1 VA: 0x3026B0
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, MessagePackSerializer.<DeserializeAsync>d__45<object>>
	|
	|-RVA: 0x3026D0 Offset: 0x3027D1 VA: 0x3026D0
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>, MessagePackSerializer.<DeserializeObjectAsync>d__24<object>>
	*/
}

public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 4437
{
	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0

	// Properties
	public ValueTask<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EA480 Offset: 0x26EA581 VA: 0x26EA480
	|-AsyncValueTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x26EA670 Offset: 0x26EA771 VA: 0x26EA670
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.Create
	|
	|-RVA: 0x26EA960 Offset: 0x26EAA61 VA: 0x26EA960
	|-AsyncValueTaskMethodBuilder<object>.Create
	*/

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302650 Offset: 0x302751 VA: 0x302650
	|-AsyncValueTaskMethodBuilder<int>.Start<StreamPolyfillExtensions.<<ReadAsync>g__FinishReadAsync|1_0>d>
	|
	|-RVA: 0x302680 Offset: 0x302781 VA: 0x302680
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.Start<MessagePackStreamReader.<ReadAsync>d__10>
	|
	|-RVA: 0x3026F0 Offset: 0x3027F1 VA: 0x3026F0
	|-AsyncValueTaskMethodBuilder<object>.Start<MessagePackSerializer.<DeserializeAsync>d__45<object>>
	|
	|-RVA: 0x302700 Offset: 0x302801 VA: 0x302700
	|-AsyncValueTaskMethodBuilder<object>.Start<MessagePackSerializer.<DeserializeObjectAsync>d__24<object>>
	|
	|-RVA: 0x302710 Offset: 0x302811 VA: 0x302710
	|-AsyncValueTaskMethodBuilder<object>.Start<object>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3694F0 Offset: 0x3695F1 VA: 0x3694F0
	|-AsyncValueTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x369600 Offset: 0x369701 VA: 0x369600
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetStateMachine
	|
	|-RVA: 0x369780 Offset: 0x369881 VA: 0x369780
	|-AsyncValueTaskMethodBuilder<object>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x369530 Offset: 0x369631 VA: 0x369530
	|-AsyncValueTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x369640 Offset: 0x369741 VA: 0x369640
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetResult
	|
	|-RVA: 0x3697C0 Offset: 0x3698C1 VA: 0x3697C0
	|-AsyncValueTaskMethodBuilder<object>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3695A0 Offset: 0x3696A1 VA: 0x3695A0
	|-AsyncValueTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x369720 Offset: 0x369821 VA: 0x369720
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetException
	|
	|-RVA: 0x369840 Offset: 0x369941 VA: 0x369840
	|-AsyncValueTaskMethodBuilder<object>.SetException
	*/

	// RVA: -1 Offset: -1
	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3695F0 Offset: 0x3696F1 VA: 0x3695F0
	|-AsyncValueTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x369770 Offset: 0x369871 VA: 0x369770
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.get_Task
	|
	|-RVA: 0x369890 Offset: 0x369991 VA: 0x369890
	|-AsyncValueTaskMethodBuilder<object>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302630 Offset: 0x302731 VA: 0x302630
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamPolyfillExtensions.<<ReadAsync>g__FinishReadAsync|1_0>d>
	|
	|-RVA: 0x302660 Offset: 0x302761 VA: 0x302660
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, MessagePackStreamReader.<ReadAsync>d__10>
	|
	|-RVA: 0x302690 Offset: 0x302791 VA: 0x302690
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x3026B0 Offset: 0x3027B1 VA: 0x3026B0
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, MessagePackSerializer.<DeserializeAsync>d__45<object>>
	|
	|-RVA: 0x3026D0 Offset: 0x3027D1 VA: 0x3026D0
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>, MessagePackSerializer.<DeserializeObjectAsync>d__24<object>>
	*/
}

public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 4437
{
	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0

	// Properties
	public ValueTask<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EA480 Offset: 0x26EA581 VA: 0x26EA480
	|-AsyncValueTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x26EA670 Offset: 0x26EA771 VA: 0x26EA670
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.Create
	|
	|-RVA: 0x26EA960 Offset: 0x26EAA61 VA: 0x26EA960
	|-AsyncValueTaskMethodBuilder<object>.Create
	*/

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302650 Offset: 0x302751 VA: 0x302650
	|-AsyncValueTaskMethodBuilder<int>.Start<StreamPolyfillExtensions.<<ReadAsync>g__FinishReadAsync|1_0>d>
	|
	|-RVA: 0x302680 Offset: 0x302781 VA: 0x302680
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.Start<MessagePackStreamReader.<ReadAsync>d__10>
	|
	|-RVA: 0x3026F0 Offset: 0x3027F1 VA: 0x3026F0
	|-AsyncValueTaskMethodBuilder<object>.Start<MessagePackSerializer.<DeserializeAsync>d__45<object>>
	|
	|-RVA: 0x302700 Offset: 0x302801 VA: 0x302700
	|-AsyncValueTaskMethodBuilder<object>.Start<MessagePackSerializer.<DeserializeObjectAsync>d__24<object>>
	|
	|-RVA: 0x302710 Offset: 0x302811 VA: 0x302710
	|-AsyncValueTaskMethodBuilder<object>.Start<object>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3694F0 Offset: 0x3695F1 VA: 0x3694F0
	|-AsyncValueTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x369600 Offset: 0x369701 VA: 0x369600
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetStateMachine
	|
	|-RVA: 0x369780 Offset: 0x369881 VA: 0x369780
	|-AsyncValueTaskMethodBuilder<object>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x369530 Offset: 0x369631 VA: 0x369530
	|-AsyncValueTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x369640 Offset: 0x369741 VA: 0x369640
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetResult
	|
	|-RVA: 0x3697C0 Offset: 0x3698C1 VA: 0x3697C0
	|-AsyncValueTaskMethodBuilder<object>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3695A0 Offset: 0x3696A1 VA: 0x3695A0
	|-AsyncValueTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x369720 Offset: 0x369821 VA: 0x369720
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetException
	|
	|-RVA: 0x369840 Offset: 0x369941 VA: 0x369840
	|-AsyncValueTaskMethodBuilder<object>.SetException
	*/

	// RVA: -1 Offset: -1
	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3695F0 Offset: 0x3696F1 VA: 0x3695F0
	|-AsyncValueTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x369770 Offset: 0x369871 VA: 0x369770
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.get_Task
	|
	|-RVA: 0x369890 Offset: 0x369991 VA: 0x369890
	|-AsyncValueTaskMethodBuilder<object>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302630 Offset: 0x302731 VA: 0x302630
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamPolyfillExtensions.<<ReadAsync>g__FinishReadAsync|1_0>d>
	|
	|-RVA: 0x302660 Offset: 0x302761 VA: 0x302660
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, MessagePackStreamReader.<ReadAsync>d__10>
	|
	|-RVA: 0x302690 Offset: 0x302791 VA: 0x302690
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x3026B0 Offset: 0x3027B1 VA: 0x3026B0
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, MessagePackSerializer.<DeserializeAsync>d__45<object>>
	|
	|-RVA: 0x3026D0 Offset: 0x3027D1 VA: 0x3026D0
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>, MessagePackSerializer.<DeserializeObjectAsync>d__24<object>>
	*/
}

public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 4437
{
	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0

	// Properties
	public ValueTask<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EA480 Offset: 0x26EA581 VA: 0x26EA480
	|-AsyncValueTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x26EA670 Offset: 0x26EA771 VA: 0x26EA670
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.Create
	|
	|-RVA: 0x26EA960 Offset: 0x26EAA61 VA: 0x26EA960
	|-AsyncValueTaskMethodBuilder<object>.Create
	*/

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302650 Offset: 0x302751 VA: 0x302650
	|-AsyncValueTaskMethodBuilder<int>.Start<StreamPolyfillExtensions.<<ReadAsync>g__FinishReadAsync|1_0>d>
	|
	|-RVA: 0x302680 Offset: 0x302781 VA: 0x302680
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.Start<MessagePackStreamReader.<ReadAsync>d__10>
	|
	|-RVA: 0x3026F0 Offset: 0x3027F1 VA: 0x3026F0
	|-AsyncValueTaskMethodBuilder<object>.Start<MessagePackSerializer.<DeserializeAsync>d__45<object>>
	|
	|-RVA: 0x302700 Offset: 0x302801 VA: 0x302700
	|-AsyncValueTaskMethodBuilder<object>.Start<MessagePackSerializer.<DeserializeObjectAsync>d__24<object>>
	|
	|-RVA: 0x302710 Offset: 0x302811 VA: 0x302710
	|-AsyncValueTaskMethodBuilder<object>.Start<object>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3694F0 Offset: 0x3695F1 VA: 0x3694F0
	|-AsyncValueTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x369600 Offset: 0x369701 VA: 0x369600
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetStateMachine
	|
	|-RVA: 0x369780 Offset: 0x369881 VA: 0x369780
	|-AsyncValueTaskMethodBuilder<object>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x369530 Offset: 0x369631 VA: 0x369530
	|-AsyncValueTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x369640 Offset: 0x369741 VA: 0x369640
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetResult
	|
	|-RVA: 0x3697C0 Offset: 0x3698C1 VA: 0x3697C0
	|-AsyncValueTaskMethodBuilder<object>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3695A0 Offset: 0x3696A1 VA: 0x3695A0
	|-AsyncValueTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x369720 Offset: 0x369821 VA: 0x369720
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.SetException
	|
	|-RVA: 0x369840 Offset: 0x369941 VA: 0x369840
	|-AsyncValueTaskMethodBuilder<object>.SetException
	*/

	// RVA: -1 Offset: -1
	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3695F0 Offset: 0x3696F1 VA: 0x3695F0
	|-AsyncValueTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x369770 Offset: 0x369871 VA: 0x369770
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.get_Task
	|
	|-RVA: 0x369890 Offset: 0x369991 VA: 0x369890
	|-AsyncValueTaskMethodBuilder<object>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302630 Offset: 0x302731 VA: 0x302630
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamPolyfillExtensions.<<ReadAsync>g__FinishReadAsync|1_0>d>
	|
	|-RVA: 0x302660 Offset: 0x302761 VA: 0x302660
	|-AsyncValueTaskMethodBuilder<Nullable<ReadOnlySequence<byte>>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, MessagePackStreamReader.<ReadAsync>d__10>
	|
	|-RVA: 0x302690 Offset: 0x302791 VA: 0x302690
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x3026B0 Offset: 0x3027B1 VA: 0x3026B0
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, MessagePackSerializer.<DeserializeAsync>d__45<object>>
	|
	|-RVA: 0x3026D0 Offset: 0x3027D1 VA: 0x3026D0
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>, MessagePackSerializer.<DeserializeObjectAsync>d__24<object>>
	*/
}

