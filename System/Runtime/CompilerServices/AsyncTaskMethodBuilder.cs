public struct AsyncTaskMethodBuilder // TypeDefIndex: 1247
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0x1802190 Offset: 0x1802291 VA: 0x1802190
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0xB9520 Offset: 0xB9621 VA: 0xB9520
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327A60 Offset: 0x327B61 VA: 0x327A60
	|-AsyncTaskMethodBuilder.Start<MessagePackSerializer.<SerializeAsync>d__38<object>>
	|
	|-RVA: 0x327A70 Offset: 0x327B71 VA: 0x327A70
	|-AsyncTaskMethodBuilder.Start<StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327A80 Offset: 0x327B81 VA: 0x327A80
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A90 Offset: 0x327B91 VA: 0x327A90
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327AA0 Offset: 0x327BA1 VA: 0x327AA0
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x327AB0 Offset: 0x327BB1 VA: 0x327AB0
	|-AsyncTaskMethodBuilder.Start<object>
	|
	|-RVA: 0x327AC0 Offset: 0x327BC1 VA: 0x327AC0
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: 0xAF60 Offset: 0xB061 VA: 0xAF60
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279C0 Offset: 0x327AC1 VA: 0x3279C0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x3279D0 Offset: 0x327AD1 VA: 0x3279D0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279E0 Offset: 0x327AE1 VA: 0x3279E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x3279F0 Offset: 0x327AF1 VA: 0x3279F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327A00 Offset: 0x327B01 VA: 0x327A00
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A10 Offset: 0x327B11 VA: 0x327A10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327A20 Offset: 0x327B21 VA: 0x327A20
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x327A40 Offset: 0x327B41 VA: 0x327A40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x327A30 Offset: 0x327B31 VA: 0x327A30
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A50 Offset: 0x327B51 VA: 0x327A50
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, MessagePackSerializer.<SerializeAsync>d__38<object>>
	*/

	// RVA: 0xAFC0 Offset: 0xB0C1 VA: 0xAFC0
	public Task get_Task() { }

	// RVA: 0xB010 Offset: 0xB111 VA: 0xB010
	public void SetResult() { }

	// RVA: 0xB090 Offset: 0xB191 VA: 0xB090
	public void SetException(Exception exception) { }

	// RVA: 0x1802330 Offset: 0x1802431 VA: 0x1802330
	private static void .cctor() { }
}

public struct AsyncTaskMethodBuilder // TypeDefIndex: 1247
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0x1802190 Offset: 0x1802291 VA: 0x1802190
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0xB9520 Offset: 0xB9621 VA: 0xB9520
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327A60 Offset: 0x327B61 VA: 0x327A60
	|-AsyncTaskMethodBuilder.Start<MessagePackSerializer.<SerializeAsync>d__38<object>>
	|
	|-RVA: 0x327A70 Offset: 0x327B71 VA: 0x327A70
	|-AsyncTaskMethodBuilder.Start<StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327A80 Offset: 0x327B81 VA: 0x327A80
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A90 Offset: 0x327B91 VA: 0x327A90
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327AA0 Offset: 0x327BA1 VA: 0x327AA0
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x327AB0 Offset: 0x327BB1 VA: 0x327AB0
	|-AsyncTaskMethodBuilder.Start<object>
	|
	|-RVA: 0x327AC0 Offset: 0x327BC1 VA: 0x327AC0
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: 0xAF60 Offset: 0xB061 VA: 0xAF60
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279C0 Offset: 0x327AC1 VA: 0x3279C0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x3279D0 Offset: 0x327AD1 VA: 0x3279D0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279E0 Offset: 0x327AE1 VA: 0x3279E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x3279F0 Offset: 0x327AF1 VA: 0x3279F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327A00 Offset: 0x327B01 VA: 0x327A00
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A10 Offset: 0x327B11 VA: 0x327A10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327A20 Offset: 0x327B21 VA: 0x327A20
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x327A40 Offset: 0x327B41 VA: 0x327A40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x327A30 Offset: 0x327B31 VA: 0x327A30
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A50 Offset: 0x327B51 VA: 0x327A50
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, MessagePackSerializer.<SerializeAsync>d__38<object>>
	*/

	// RVA: 0xAFC0 Offset: 0xB0C1 VA: 0xAFC0
	public Task get_Task() { }

	// RVA: 0xB010 Offset: 0xB111 VA: 0xB010
	public void SetResult() { }

	// RVA: 0xB090 Offset: 0xB191 VA: 0xB090
	public void SetException(Exception exception) { }

	// RVA: 0x1802330 Offset: 0x1802431 VA: 0x1802330
	private static void .cctor() { }
}

public struct AsyncTaskMethodBuilder // TypeDefIndex: 1247
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0x1802190 Offset: 0x1802291 VA: 0x1802190
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0xB9520 Offset: 0xB9621 VA: 0xB9520
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327A60 Offset: 0x327B61 VA: 0x327A60
	|-AsyncTaskMethodBuilder.Start<MessagePackSerializer.<SerializeAsync>d__38<object>>
	|
	|-RVA: 0x327A70 Offset: 0x327B71 VA: 0x327A70
	|-AsyncTaskMethodBuilder.Start<StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327A80 Offset: 0x327B81 VA: 0x327A80
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A90 Offset: 0x327B91 VA: 0x327A90
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327AA0 Offset: 0x327BA1 VA: 0x327AA0
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x327AB0 Offset: 0x327BB1 VA: 0x327AB0
	|-AsyncTaskMethodBuilder.Start<object>
	|
	|-RVA: 0x327AC0 Offset: 0x327BC1 VA: 0x327AC0
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: 0xAF60 Offset: 0xB061 VA: 0xAF60
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279C0 Offset: 0x327AC1 VA: 0x3279C0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x3279D0 Offset: 0x327AD1 VA: 0x3279D0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279E0 Offset: 0x327AE1 VA: 0x3279E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x3279F0 Offset: 0x327AF1 VA: 0x3279F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327A00 Offset: 0x327B01 VA: 0x327A00
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A10 Offset: 0x327B11 VA: 0x327A10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327A20 Offset: 0x327B21 VA: 0x327A20
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x327A40 Offset: 0x327B41 VA: 0x327A40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x327A30 Offset: 0x327B31 VA: 0x327A30
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A50 Offset: 0x327B51 VA: 0x327A50
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, MessagePackSerializer.<SerializeAsync>d__38<object>>
	*/

	// RVA: 0xAFC0 Offset: 0xB0C1 VA: 0xAFC0
	public Task get_Task() { }

	// RVA: 0xB010 Offset: 0xB111 VA: 0xB010
	public void SetResult() { }

	// RVA: 0xB090 Offset: 0xB191 VA: 0xB090
	public void SetException(Exception exception) { }

	// RVA: 0x1802330 Offset: 0x1802431 VA: 0x1802330
	private static void .cctor() { }
}

public struct AsyncTaskMethodBuilder // TypeDefIndex: 1247
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0x1802190 Offset: 0x1802291 VA: 0x1802190
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0xB9520 Offset: 0xB9621 VA: 0xB9520
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327A60 Offset: 0x327B61 VA: 0x327A60
	|-AsyncTaskMethodBuilder.Start<MessagePackSerializer.<SerializeAsync>d__38<object>>
	|
	|-RVA: 0x327A70 Offset: 0x327B71 VA: 0x327A70
	|-AsyncTaskMethodBuilder.Start<StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327A80 Offset: 0x327B81 VA: 0x327A80
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A90 Offset: 0x327B91 VA: 0x327A90
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327AA0 Offset: 0x327BA1 VA: 0x327AA0
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x327AB0 Offset: 0x327BB1 VA: 0x327AB0
	|-AsyncTaskMethodBuilder.Start<object>
	|
	|-RVA: 0x327AC0 Offset: 0x327BC1 VA: 0x327AC0
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: 0xAF60 Offset: 0xB061 VA: 0xAF60
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279C0 Offset: 0x327AC1 VA: 0x3279C0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x3279D0 Offset: 0x327AD1 VA: 0x3279D0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279E0 Offset: 0x327AE1 VA: 0x3279E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x3279F0 Offset: 0x327AF1 VA: 0x3279F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327A00 Offset: 0x327B01 VA: 0x327A00
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A10 Offset: 0x327B11 VA: 0x327A10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327A20 Offset: 0x327B21 VA: 0x327A20
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x327A40 Offset: 0x327B41 VA: 0x327A40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x327A30 Offset: 0x327B31 VA: 0x327A30
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A50 Offset: 0x327B51 VA: 0x327A50
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, MessagePackSerializer.<SerializeAsync>d__38<object>>
	*/

	// RVA: 0xAFC0 Offset: 0xB0C1 VA: 0xAFC0
	public Task get_Task() { }

	// RVA: 0xB010 Offset: 0xB111 VA: 0xB010
	public void SetResult() { }

	// RVA: 0xB090 Offset: 0xB191 VA: 0xB090
	public void SetException(Exception exception) { }

	// RVA: 0x1802330 Offset: 0x1802431 VA: 0x1802330
	private static void .cctor() { }
}

public struct AsyncTaskMethodBuilder // TypeDefIndex: 1247
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0x1802190 Offset: 0x1802291 VA: 0x1802190
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0xB9520 Offset: 0xB9621 VA: 0xB9520
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327A60 Offset: 0x327B61 VA: 0x327A60
	|-AsyncTaskMethodBuilder.Start<MessagePackSerializer.<SerializeAsync>d__38<object>>
	|
	|-RVA: 0x327A70 Offset: 0x327B71 VA: 0x327A70
	|-AsyncTaskMethodBuilder.Start<StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327A80 Offset: 0x327B81 VA: 0x327A80
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A90 Offset: 0x327B91 VA: 0x327A90
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327AA0 Offset: 0x327BA1 VA: 0x327AA0
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x327AB0 Offset: 0x327BB1 VA: 0x327AB0
	|-AsyncTaskMethodBuilder.Start<object>
	|
	|-RVA: 0x327AC0 Offset: 0x327BC1 VA: 0x327AC0
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: 0xAF60 Offset: 0xB061 VA: 0xAF60
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279C0 Offset: 0x327AC1 VA: 0x3279C0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x3279D0 Offset: 0x327AD1 VA: 0x3279D0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279E0 Offset: 0x327AE1 VA: 0x3279E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x3279F0 Offset: 0x327AF1 VA: 0x3279F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327A00 Offset: 0x327B01 VA: 0x327A00
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A10 Offset: 0x327B11 VA: 0x327A10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327A20 Offset: 0x327B21 VA: 0x327A20
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x327A40 Offset: 0x327B41 VA: 0x327A40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x327A30 Offset: 0x327B31 VA: 0x327A30
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A50 Offset: 0x327B51 VA: 0x327A50
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, MessagePackSerializer.<SerializeAsync>d__38<object>>
	*/

	// RVA: 0xAFC0 Offset: 0xB0C1 VA: 0xAFC0
	public Task get_Task() { }

	// RVA: 0xB010 Offset: 0xB111 VA: 0xB010
	public void SetResult() { }

	// RVA: 0xB090 Offset: 0xB191 VA: 0xB090
	public void SetException(Exception exception) { }

	// RVA: 0x1802330 Offset: 0x1802431 VA: 0x1802330
	private static void .cctor() { }
}

public struct AsyncTaskMethodBuilder // TypeDefIndex: 1247
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0x1802190 Offset: 0x1802291 VA: 0x1802190
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0xB9520 Offset: 0xB9621 VA: 0xB9520
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327A60 Offset: 0x327B61 VA: 0x327A60
	|-AsyncTaskMethodBuilder.Start<MessagePackSerializer.<SerializeAsync>d__38<object>>
	|
	|-RVA: 0x327A70 Offset: 0x327B71 VA: 0x327A70
	|-AsyncTaskMethodBuilder.Start<StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327A80 Offset: 0x327B81 VA: 0x327A80
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A90 Offset: 0x327B91 VA: 0x327A90
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327AA0 Offset: 0x327BA1 VA: 0x327AA0
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x327AB0 Offset: 0x327BB1 VA: 0x327AB0
	|-AsyncTaskMethodBuilder.Start<object>
	|
	|-RVA: 0x327AC0 Offset: 0x327BC1 VA: 0x327AC0
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: 0xAF60 Offset: 0xB061 VA: 0xAF60
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279C0 Offset: 0x327AC1 VA: 0x3279C0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x3279D0 Offset: 0x327AD1 VA: 0x3279D0
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3279E0 Offset: 0x327AE1 VA: 0x3279E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x3279F0 Offset: 0x327AF1 VA: 0x3279F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamPolyfillExtensions.<WriteAsync>d__3>
	|
	|-RVA: 0x327A00 Offset: 0x327B01 VA: 0x327A00
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A10 Offset: 0x327B11 VA: 0x327A10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x327A20 Offset: 0x327B21 VA: 0x327A20
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x327A40 Offset: 0x327B41 VA: 0x327A40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x327A30 Offset: 0x327B31 VA: 0x327A30
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x327A50 Offset: 0x327B51 VA: 0x327A50
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, MessagePackSerializer.<SerializeAsync>d__38<object>>
	*/

	// RVA: 0xAFC0 Offset: 0xB0C1 VA: 0xAFC0
	public Task get_Task() { }

	// RVA: 0xB010 Offset: 0xB111 VA: 0xB010
	public void SetResult() { }

	// RVA: 0xB090 Offset: 0xB191 VA: 0xB090
	public void SetException(Exception exception) { }

	// RVA: 0x1802330 Offset: 0x1802431 VA: 0x1802330
	private static void .cctor() { }
}

