private sealed class TaskFactory.FromAsyncTrimPromise<TResult, TInstance> : Task<TResult> // TypeDefIndex: 846
{
	// Fields
	internal static readonly AsyncCallback s_completeFromAsyncResult; // 0x0
	private TInstance m_thisRef; // 0x0
	private Func<TInstance, IAsyncResult, TResult> m_endMethod; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B83A10 Offset: 0x2B83B11 VA: 0x2B83A10
	|-TaskFactory.FromAsyncTrimPromise<int, object>..ctor
	|
	|-RVA: 0x2B84090 Offset: 0x2B84191 VA: 0x2B84090
	|-TaskFactory.FromAsyncTrimPromise<object, object>..ctor
	|
	|-RVA: 0x2B84710 Offset: 0x2B84811 VA: 0x2B84710
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B83AF0 Offset: 0x2B83BF1 VA: 0x2B83AF0
	|-TaskFactory.FromAsyncTrimPromise<int, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x2B84170 Offset: 0x2B84271 VA: 0x2B84170
	|-TaskFactory.FromAsyncTrimPromise<object, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x2B847F0 Offset: 0x2B848F1 VA: 0x2B847F0
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.CompleteFromAsyncResult
	*/

	// RVA: -1 Offset: -1
	internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B83DC0 Offset: 0x2B83EC1 VA: 0x2B83DC0
	|-TaskFactory.FromAsyncTrimPromise<int, object>.Complete
	|
	|-RVA: 0x2B84440 Offset: 0x2B84541 VA: 0x2B84440
	|-TaskFactory.FromAsyncTrimPromise<object, object>.Complete
	|
	|-RVA: 0x2B84AC0 Offset: 0x2B84BC1 VA: 0x2B84AC0
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.Complete
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B83FD0 Offset: 0x2B840D1 VA: 0x2B83FD0
	|-TaskFactory.FromAsyncTrimPromise<int, object>..cctor
	|
	|-RVA: 0x2B84650 Offset: 0x2B84751 VA: 0x2B84650
	|-TaskFactory.FromAsyncTrimPromise<object, object>..cctor
	|
	|-RVA: 0x2B84CE0 Offset: 0x2B84DE1 VA: 0x2B84CE0
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..cctor
	*/
}

