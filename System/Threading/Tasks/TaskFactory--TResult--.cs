public class TaskFactory<TResult> // TypeDefIndex: 845
{
	// Fields
	private CancellationToken m_defaultCancellationToken; // 0x0
	private TaskScheduler m_defaultScheduler; // 0x0
	private TaskCreationOptions m_defaultCreationOptions; // 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B84DA0 Offset: 0x2B84EA1 VA: 0x2B84DA0
	|-TaskFactory<bool>..ctor
	|
	|-RVA: 0x2B84E70 Offset: 0x2B84F71 VA: 0x2B84E70
	|-TaskFactory<int>..ctor
	|
	|-RVA: 0x2B84F40 Offset: 0x2B85041 VA: 0x2B84F40
	|-TaskFactory<long>..ctor
	|
	|-RVA: 0x2B85010 Offset: 0x2B85111 VA: 0x2B85010
	|-TaskFactory<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x2B850E0 Offset: 0x2B851E1 VA: 0x2B850E0
	|-TaskFactory<Nullable<int>>..ctor
	|
	|-RVA: 0x2B851B0 Offset: 0x2B852B1 VA: 0x2B851B0
	|-TaskFactory<object>..ctor
	|
	|-RVA: 0x2B85280 Offset: 0x2B85381 VA: 0x2B85280
	|-TaskFactory<VoidTaskResult>..ctor
	|
	|-RVA: 0x2B85350 Offset: 0x2B85451 VA: 0x2B85350
	|-TaskFactory<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B84DE0 Offset: 0x2B84EE1 VA: 0x2B84DE0
	|-TaskFactory<bool>..ctor
	|
	|-RVA: 0x2B84EB0 Offset: 0x2B84FB1 VA: 0x2B84EB0
	|-TaskFactory<int>..ctor
	|
	|-RVA: 0x2B84F80 Offset: 0x2B85081 VA: 0x2B84F80
	|-TaskFactory<long>..ctor
	|
	|-RVA: 0x2B85050 Offset: 0x2B85151 VA: 0x2B85050
	|-TaskFactory<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x2B85120 Offset: 0x2B85221 VA: 0x2B85120
	|-TaskFactory<Nullable<int>>..ctor
	|
	|-RVA: 0x2B851F0 Offset: 0x2B852F1 VA: 0x2B851F0
	|-TaskFactory<object>..ctor
	|
	|-RVA: 0x2B852C0 Offset: 0x2B853C1 VA: 0x2B852C0
	|-TaskFactory<VoidTaskResult>..ctor
	|
	|-RVA: 0x2B85390 Offset: 0x2B85491 VA: 0x2B85390
	|-TaskFactory<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CD370 Offset: 0x21CD471 VA: 0x21CD370
	|-TaskFactory<int>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	|-TaskFactory<int>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x21CD590 Offset: 0x21CD691 VA: 0x21CD590
	|-TaskFactory<object>.FromAsyncTrim<object, object>
	|
	|-RVA: 0x21CD7B0 Offset: 0x21CD8B1 VA: 0x21CD7B0
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	*/
}

