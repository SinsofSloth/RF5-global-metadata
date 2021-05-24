[DebuggerTypeProxyAttribute] // RVA: 0xAF690 Offset: 0xAF791 VA: 0xAF690
[DebuggerDisplayAttribute] // RVA: 0xAF690 Offset: 0xAF791 VA: 0xAF690
public class Task<TResult> : Task // TypeDefIndex: 842
{
	// Fields
	internal TResult m_result; // 0x0
	private static readonly TaskFactory<TResult> s_Factory; // 0x0
	internal static readonly Func<Task<Task>, Task<TResult>> TaskWhenAnyCast; // 0x0

	// Properties
	[DebuggerBrowsableAttribute] // RVA: 0xBA480 Offset: 0xBA581 VA: 0xBA480
	public TResult Result { get; }
	internal TResult ResultOnSuccess { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B86420 Offset: 0x2B86521 VA: 0x2B86420
	|-Task<bool>..ctor
	|
	|-RVA: 0x2B87700 Offset: 0x2B87801 VA: 0x2B87700
	|-Task<int>..ctor
	|
	|-RVA: 0x2B889C0 Offset: 0x2B88AC1 VA: 0x2B889C0
	|-Task<long>..ctor
	|
	|-RVA: 0x2B89C80 Offset: 0x2B89D81 VA: 0x2B89C80
	|-Task<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x2B8B0C0 Offset: 0x2B8B1C1 VA: 0x2B8B0C0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2B8C380 Offset: 0x2B8C481 VA: 0x2B8C380
	|-Task<object>..ctor
	|-Task<Task>..ctor
	|
	|-RVA: 0x2B8D6C0 Offset: 0x2B8D7C1 VA: 0x2B8D6C0
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2B8E980 Offset: 0x2B8EA81 VA: 0x2B8E980
	|-Task<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B86490 Offset: 0x2B86591 VA: 0x2B86490
	|-Task<bool>..ctor
	|
	|-RVA: 0x2B87770 Offset: 0x2B87871 VA: 0x2B87770
	|-Task<int>..ctor
	|
	|-RVA: 0x2B88A30 Offset: 0x2B88B31 VA: 0x2B88A30
	|-Task<long>..ctor
	|
	|-RVA: 0x2B89CF0 Offset: 0x2B89DF1 VA: 0x2B89CF0
	|-Task<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x2B8B130 Offset: 0x2B8B231 VA: 0x2B8B130
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2B8C3F0 Offset: 0x2B8C4F1 VA: 0x2B8C3F0
	|-Task<object>..ctor
	|
	|-RVA: 0x2B8D730 Offset: 0x2B8D831 VA: 0x2B8D730
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2B8E9F0 Offset: 0x2B8EAF1 VA: 0x2B8E9F0
	|-Task<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B86530 Offset: 0x2B86631 VA: 0x2B86530
	|-Task<bool>..ctor
	|
	|-RVA: 0x2B87800 Offset: 0x2B87901 VA: 0x2B87800
	|-Task<int>..ctor
	|
	|-RVA: 0x2B88AC0 Offset: 0x2B88BC1 VA: 0x2B88AC0
	|-Task<long>..ctor
	|
	|-RVA: 0x2B89DA0 Offset: 0x2B89EA1 VA: 0x2B89DA0
	|-Task<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x2B8B1C0 Offset: 0x2B8B2C1 VA: 0x2B8B1C0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2B8C490 Offset: 0x2B8C591 VA: 0x2B8C490
	|-Task<object>..ctor
	|
	|-RVA: 0x2B8D7C0 Offset: 0x2B8D8C1 VA: 0x2B8D7C0
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2B8EA90 Offset: 0x2B8EB91 VA: 0x2B8EA90
	|-Task<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B865E0 Offset: 0x2B866E1 VA: 0x2B865E0
	|-Task<bool>..ctor
	|
	|-RVA: 0x2B878B0 Offset: 0x2B879B1 VA: 0x2B878B0
	|-Task<int>..ctor
	|
	|-RVA: 0x2B88B70 Offset: 0x2B88C71 VA: 0x2B88B70
	|-Task<long>..ctor
	|
	|-RVA: 0x2B89E80 Offset: 0x2B89F81 VA: 0x2B89E80
	|-Task<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x2B8B270 Offset: 0x2B8B371 VA: 0x2B8B270
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2B8C560 Offset: 0x2B8C661 VA: 0x2B8C560
	|-Task<object>..ctor
	|
	|-RVA: 0x2B8D870 Offset: 0x2B8D971 VA: 0x2B8D870
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2B8EB70 Offset: 0x2B8EC71 VA: 0x2B8EB70
	|-Task<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B866E0 Offset: 0x2B867E1 VA: 0x2B866E0
	|-Task<bool>..ctor
	|
	|-RVA: 0x2B879B0 Offset: 0x2B87AB1 VA: 0x2B879B0
	|-Task<int>..ctor
	|
	|-RVA: 0x2B88C70 Offset: 0x2B88D71 VA: 0x2B88C70
	|-Task<long>..ctor
	|
	|-RVA: 0x2B89F80 Offset: 0x2B8A081 VA: 0x2B89F80
	|-Task<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x2B8B370 Offset: 0x2B8B471 VA: 0x2B8B370
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2B8C660 Offset: 0x2B8C761 VA: 0x2B8C660
	|-Task<object>..ctor
	|
	|-RVA: 0x2B8D970 Offset: 0x2B8DA71 VA: 0x2B8D970
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2B8EC70 Offset: 0x2B8ED71 VA: 0x2B8EC70
	|-Task<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B867D0 Offset: 0x2B868D1 VA: 0x2B867D0
	|-Task<bool>..ctor
	|
	|-RVA: 0x2B87AA0 Offset: 0x2B87BA1 VA: 0x2B87AA0
	|-Task<int>..ctor
	|
	|-RVA: 0x2B88D60 Offset: 0x2B88E61 VA: 0x2B88D60
	|-Task<long>..ctor
	|
	|-RVA: 0x2B8A070 Offset: 0x2B8A171 VA: 0x2B8A070
	|-Task<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x2B8B460 Offset: 0x2B8B561 VA: 0x2B8B460
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2B8C750 Offset: 0x2B8C851 VA: 0x2B8C750
	|-Task<object>..ctor
	|
	|-RVA: 0x2B8DA60 Offset: 0x2B8DB61 VA: 0x2B8DA60
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2B8ED60 Offset: 0x2B8EE61 VA: 0x2B8ED60
	|-Task<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<object, TResult> valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B86900 Offset: 0x2B86A01 VA: 0x2B86900
	|-Task<bool>..ctor
	|
	|-RVA: 0x2B87BD0 Offset: 0x2B87CD1 VA: 0x2B87BD0
	|-Task<int>..ctor
	|
	|-RVA: 0x2B88E90 Offset: 0x2B88F91 VA: 0x2B88E90
	|-Task<long>..ctor
	|
	|-RVA: 0x2B8A1A0 Offset: 0x2B8A2A1 VA: 0x2B8A1A0
	|-Task<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x2B8B590 Offset: 0x2B8B691 VA: 0x2B8B590
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2B8C880 Offset: 0x2B8C981 VA: 0x2B8C880
	|-Task<object>..ctor
	|
	|-RVA: 0x2B8DB90 Offset: 0x2B8DC91 VA: 0x2B8DB90
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2B8EE90 Offset: 0x2B8EF91 VA: 0x2B8EE90
	|-Task<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B86A00 Offset: 0x2B86B01 VA: 0x2B86A00
	|-Task<bool>..ctor
	|
	|-RVA: 0x2B87CD0 Offset: 0x2B87DD1 VA: 0x2B87CD0
	|-Task<int>..ctor
	|
	|-RVA: 0x2B88F90 Offset: 0x2B89091 VA: 0x2B88F90
	|-Task<long>..ctor
	|
	|-RVA: 0x2B8A2A0 Offset: 0x2B8A3A1 VA: 0x2B8A2A0
	|-Task<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x2B8B690 Offset: 0x2B8B791 VA: 0x2B8B690
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x2B8C980 Offset: 0x2B8CA81 VA: 0x2B8C980
	|-Task<object>..ctor
	|
	|-RVA: 0x2B8DC90 Offset: 0x2B8DD91 VA: 0x2B8DC90
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x2B8EF90 Offset: 0x2B8F091 VA: 0x2B8EF90
	|-Task<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B86B30 Offset: 0x2B86C31 VA: 0x2B86B30
	|-Task<bool>.StartNew
	|
	|-RVA: 0x2B87E00 Offset: 0x2B87F01 VA: 0x2B87E00
	|-Task<int>.StartNew
	|
	|-RVA: 0x2B890C0 Offset: 0x2B891C1 VA: 0x2B890C0
	|-Task<long>.StartNew
	|
	|-RVA: 0x2B8A3D0 Offset: 0x2B8A4D1 VA: 0x2B8A3D0
	|-Task<Nullable<ReadOnlySequence<byte>>>.StartNew
	|
	|-RVA: 0x2B8B7C0 Offset: 0x2B8B8C1 VA: 0x2B8B7C0
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x2B8CAB0 Offset: 0x2B8CBB1 VA: 0x2B8CAB0
	|-Task<object>.StartNew
	|
	|-RVA: 0x2B8DDC0 Offset: 0x2B8DEC1 VA: 0x2B8DDC0
	|-Task<VoidTaskResult>.StartNew
	|
	|-RVA: 0x2B8F0C0 Offset: 0x2B8F1C1 VA: 0x2B8F0C0
	|-Task<SceneInstance>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B86D40 Offset: 0x2B86E41 VA: 0x2B86D40
	|-Task<bool>.StartNew
	|
	|-RVA: 0x2B88010 Offset: 0x2B88111 VA: 0x2B88010
	|-Task<int>.StartNew
	|
	|-RVA: 0x2B892D0 Offset: 0x2B893D1 VA: 0x2B892D0
	|-Task<long>.StartNew
	|
	|-RVA: 0x2B8A5E0 Offset: 0x2B8A6E1 VA: 0x2B8A5E0
	|-Task<Nullable<ReadOnlySequence<byte>>>.StartNew
	|
	|-RVA: 0x2B8B9D0 Offset: 0x2B8BAD1 VA: 0x2B8B9D0
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x2B8CCC0 Offset: 0x2B8CDC1 VA: 0x2B8CCC0
	|-Task<object>.StartNew
	|
	|-RVA: 0x2B8DFD0 Offset: 0x2B8E0D1 VA: 0x2B8DFD0
	|-Task<VoidTaskResult>.StartNew
	|
	|-RVA: 0x2B8F2D0 Offset: 0x2B8F3D1 VA: 0x2B8F2D0
	|-Task<SceneInstance>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B86F50 Offset: 0x2B87051 VA: 0x2B86F50
	|-Task<bool>.TrySetResult
	|
	|-RVA: 0x2B88220 Offset: 0x2B88321 VA: 0x2B88220
	|-Task<int>.TrySetResult
	|
	|-RVA: 0x2B894E0 Offset: 0x2B895E1 VA: 0x2B894E0
	|-Task<long>.TrySetResult
	|
	|-RVA: 0x2B8A7F0 Offset: 0x2B8A8F1 VA: 0x2B8A7F0
	|-Task<Nullable<ReadOnlySequence<byte>>>.TrySetResult
	|
	|-RVA: 0x2B8BBE0 Offset: 0x2B8BCE1 VA: 0x2B8BBE0
	|-Task<Nullable<int>>.TrySetResult
	|
	|-RVA: 0x2B8CED0 Offset: 0x2B8CFD1 VA: 0x2B8CED0
	|-Task<object>.TrySetResult
	|-Task<Task>.TrySetResult
	|
	|-RVA: 0x2B8E1E0 Offset: 0x2B8E2E1 VA: 0x2B8E1E0
	|-Task<VoidTaskResult>.TrySetResult
	|
	|-RVA: 0x2B8F4E0 Offset: 0x2B8F5E1 VA: 0x2B8F4E0
	|-Task<SceneInstance>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	internal void DangerousSetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B87020 Offset: 0x2B87121 VA: 0x2B87020
	|-Task<bool>.DangerousSetResult
	|
	|-RVA: 0x2B882F0 Offset: 0x2B883F1 VA: 0x2B882F0
	|-Task<int>.DangerousSetResult
	|
	|-RVA: 0x2B895B0 Offset: 0x2B896B1 VA: 0x2B895B0
	|-Task<long>.DangerousSetResult
	|
	|-RVA: 0x2B8A8E0 Offset: 0x2B8A9E1 VA: 0x2B8A8E0
	|-Task<Nullable<ReadOnlySequence<byte>>>.DangerousSetResult
	|
	|-RVA: 0x2B8BCB0 Offset: 0x2B8BDB1 VA: 0x2B8BCB0
	|-Task<Nullable<int>>.DangerousSetResult
	|
	|-RVA: 0x2B8CFB0 Offset: 0x2B8D0B1 VA: 0x2B8CFB0
	|-Task<object>.DangerousSetResult
	|
	|-RVA: 0x2B8E2B0 Offset: 0x2B8E3B1 VA: 0x2B8E2B0
	|-Task<VoidTaskResult>.DangerousSetResult
	|
	|-RVA: 0x2B8F5C0 Offset: 0x2B8F6C1 VA: 0x2B8F5C0
	|-Task<SceneInstance>.DangerousSetResult
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B87090 Offset: 0x2B87191 VA: 0x2B87090
	|-Task<bool>.get_Result
	|
	|-RVA: 0x2B88350 Offset: 0x2B88451 VA: 0x2B88350
	|-Task<int>.get_Result
	|
	|-RVA: 0x2B89610 Offset: 0x2B89711 VA: 0x2B89610
	|-Task<long>.get_Result
	|
	|-RVA: 0x2B8A9A0 Offset: 0x2B8AAA1 VA: 0x2B8A9A0
	|-Task<Nullable<ReadOnlySequence<byte>>>.get_Result
	|
	|-RVA: 0x2B8BD10 Offset: 0x2B8BE11 VA: 0x2B8BD10
	|-Task<Nullable<int>>.get_Result
	|
	|-RVA: 0x2B8D020 Offset: 0x2B8D121 VA: 0x2B8D020
	|-Task<object>.get_Result
	|-Task<Task>.get_Result
	|
	|-RVA: 0x2B8E310 Offset: 0x2B8E411 VA: 0x2B8E310
	|-Task<VoidTaskResult>.get_Result
	|
	|-RVA: 0x2B8F630 Offset: 0x2B8F731 VA: 0x2B8F630
	|-Task<SceneInstance>.get_Result
	*/

	// RVA: -1 Offset: -1
	internal TResult get_ResultOnSuccess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B87110 Offset: 0x2B87211 VA: 0x2B87110
	|-Task<bool>.get_ResultOnSuccess
	|
	|-RVA: 0x2B883D0 Offset: 0x2B884D1 VA: 0x2B883D0
	|-Task<int>.get_ResultOnSuccess
	|
	|-RVA: 0x2B89690 Offset: 0x2B89791 VA: 0x2B89690
	|-Task<long>.get_ResultOnSuccess
	|
	|-RVA: 0x2B8AA50 Offset: 0x2B8AB51 VA: 0x2B8AA50
	|-Task<Nullable<ReadOnlySequence<byte>>>.get_ResultOnSuccess
	|
	|-RVA: 0x2B8BD90 Offset: 0x2B8BE91 VA: 0x2B8BD90
	|-Task<Nullable<int>>.get_ResultOnSuccess
	|
	|-RVA: 0x2B8D0A0 Offset: 0x2B8D1A1 VA: 0x2B8D0A0
	|-Task<object>.get_ResultOnSuccess
	|
	|-RVA: 0x2B8E390 Offset: 0x2B8E491 VA: 0x2B8E390
	|-Task<VoidTaskResult>.get_ResultOnSuccess
	|
	|-RVA: 0x2B8F6B0 Offset: 0x2B8F7B1 VA: 0x2B8F6B0
	|-Task<SceneInstance>.get_ResultOnSuccess
	*/

	// RVA: -1 Offset: -1
	internal TResult GetResultCore(bool waitCompletionNotification) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B87120 Offset: 0x2B87221 VA: 0x2B87120
	|-Task<bool>.GetResultCore
	|
	|-RVA: 0x2B883E0 Offset: 0x2B884E1 VA: 0x2B883E0
	|-Task<int>.GetResultCore
	|
	|-RVA: 0x2B896A0 Offset: 0x2B897A1 VA: 0x2B896A0
	|-Task<long>.GetResultCore
	|
	|-RVA: 0x2B8AA70 Offset: 0x2B8AB71 VA: 0x2B8AA70
	|-Task<Nullable<ReadOnlySequence<byte>>>.GetResultCore
	|
	|-RVA: 0x2B8BDA0 Offset: 0x2B8BEA1 VA: 0x2B8BDA0
	|-Task<Nullable<int>>.GetResultCore
	|
	|-RVA: 0x2B8D0B0 Offset: 0x2B8D1B1 VA: 0x2B8D0B0
	|-Task<object>.GetResultCore
	|
	|-RVA: 0x2B8E3A0 Offset: 0x2B8E4A1 VA: 0x2B8E3A0
	|-Task<VoidTaskResult>.GetResultCore
	|
	|-RVA: 0x2B8F6C0 Offset: 0x2B8F7C1 VA: 0x2B8F6C0
	|-Task<SceneInstance>.GetResultCore
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetException(object exceptionObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B871C0 Offset: 0x2B872C1 VA: 0x2B871C0
	|-Task<bool>.TrySetException
	|
	|-RVA: 0x2B88480 Offset: 0x2B88581 VA: 0x2B88480
	|-Task<int>.TrySetException
	|
	|-RVA: 0x2B89740 Offset: 0x2B89841 VA: 0x2B89740
	|-Task<long>.TrySetException
	|
	|-RVA: 0x2B8AB30 Offset: 0x2B8AC31 VA: 0x2B8AB30
	|-Task<Nullable<ReadOnlySequence<byte>>>.TrySetException
	|
	|-RVA: 0x2B8BE40 Offset: 0x2B8BF41 VA: 0x2B8BE40
	|-Task<Nullable<int>>.TrySetException
	|
	|-RVA: 0x2B8D150 Offset: 0x2B8D251 VA: 0x2B8D150
	|-Task<object>.TrySetException
	|
	|-RVA: 0x2B8E440 Offset: 0x2B8E541 VA: 0x2B8E440
	|-Task<VoidTaskResult>.TrySetException
	|
	|-RVA: 0x2B8F760 Offset: 0x2B8F861 VA: 0x2B8F760
	|-Task<SceneInstance>.TrySetException
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B87240 Offset: 0x2B87341 VA: 0x2B87240
	|-Task<bool>.TrySetCanceled
	|
	|-RVA: 0x2B88500 Offset: 0x2B88601 VA: 0x2B88500
	|-Task<int>.TrySetCanceled
	|
	|-RVA: 0x2B897C0 Offset: 0x2B898C1 VA: 0x2B897C0
	|-Task<long>.TrySetCanceled
	|
	|-RVA: 0x2B8ABB0 Offset: 0x2B8ACB1 VA: 0x2B8ABB0
	|-Task<Nullable<ReadOnlySequence<byte>>>.TrySetCanceled
	|
	|-RVA: 0x2B8BEC0 Offset: 0x2B8BFC1 VA: 0x2B8BEC0
	|-Task<Nullable<int>>.TrySetCanceled
	|
	|-RVA: 0x2B8D1D0 Offset: 0x2B8D2D1 VA: 0x2B8D1D0
	|-Task<object>.TrySetCanceled
	|
	|-RVA: 0x2B8E4C0 Offset: 0x2B8E5C1 VA: 0x2B8E4C0
	|-Task<VoidTaskResult>.TrySetCanceled
	|
	|-RVA: 0x2B8F7E0 Offset: 0x2B8F8E1 VA: 0x2B8F7E0
	|-Task<SceneInstance>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B87270 Offset: 0x2B87371 VA: 0x2B87270
	|-Task<bool>.TrySetCanceled
	|
	|-RVA: 0x2B88530 Offset: 0x2B88631 VA: 0x2B88530
	|-Task<int>.TrySetCanceled
	|
	|-RVA: 0x2B897F0 Offset: 0x2B898F1 VA: 0x2B897F0
	|-Task<long>.TrySetCanceled
	|
	|-RVA: 0x2B8ABE0 Offset: 0x2B8ACE1 VA: 0x2B8ABE0
	|-Task<Nullable<ReadOnlySequence<byte>>>.TrySetCanceled
	|
	|-RVA: 0x2B8BEF0 Offset: 0x2B8BFF1 VA: 0x2B8BEF0
	|-Task<Nullable<int>>.TrySetCanceled
	|
	|-RVA: 0x2B8D200 Offset: 0x2B8D301 VA: 0x2B8D200
	|-Task<object>.TrySetCanceled
	|
	|-RVA: 0x2B8E4F0 Offset: 0x2B8E5F1 VA: 0x2B8E4F0
	|-Task<VoidTaskResult>.TrySetCanceled
	|
	|-RVA: 0x2B8F810 Offset: 0x2B8F911 VA: 0x2B8F810
	|-Task<SceneInstance>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B872F0 Offset: 0x2B873F1 VA: 0x2B872F0
	|-Task<bool>.InnerInvoke
	|
	|-RVA: 0x2B885B0 Offset: 0x2B886B1 VA: 0x2B885B0
	|-Task<int>.InnerInvoke
	|
	|-RVA: 0x2B89870 Offset: 0x2B89971 VA: 0x2B89870
	|-Task<long>.InnerInvoke
	|
	|-RVA: 0x2B8AC60 Offset: 0x2B8AD61 VA: 0x2B8AC60
	|-Task<Nullable<ReadOnlySequence<byte>>>.InnerInvoke
	|
	|-RVA: 0x2B8BF70 Offset: 0x2B8C071 VA: 0x2B8BF70
	|-Task<Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x2B8D280 Offset: 0x2B8D381 VA: 0x2B8D280
	|-Task<object>.InnerInvoke
	|-Task<Task>.InnerInvoke
	|
	|-RVA: 0x2B8E570 Offset: 0x2B8E671 VA: 0x2B8E570
	|-Task<VoidTaskResult>.InnerInvoke
	|
	|-RVA: 0x2B8F890 Offset: 0x2B8F991 VA: 0x2B8F890
	|-Task<SceneInstance>.InnerInvoke
	*/

	// RVA: -1 Offset: -1
	public TaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B873B0 Offset: 0x2B874B1 VA: 0x2B873B0
	|-Task<bool>.GetAwaiter
	|
	|-RVA: 0x2B88670 Offset: 0x2B88771 VA: 0x2B88670
	|-Task<int>.GetAwaiter
	|
	|-RVA: 0x2B89930 Offset: 0x2B89A31 VA: 0x2B89930
	|-Task<long>.GetAwaiter
	|
	|-RVA: 0x2B8AD70 Offset: 0x2B8AE71 VA: 0x2B8AD70
	|-Task<Nullable<ReadOnlySequence<byte>>>.GetAwaiter
	|
	|-RVA: 0x2B8C030 Offset: 0x2B8C131 VA: 0x2B8C030
	|-Task<Nullable<int>>.GetAwaiter
	|
	|-RVA: 0x2B8D370 Offset: 0x2B8D471 VA: 0x2B8D370
	|-Task<object>.GetAwaiter
	|
	|-RVA: 0x2B8E630 Offset: 0x2B8E731 VA: 0x2B8E630
	|-Task<VoidTaskResult>.GetAwaiter
	|
	|-RVA: 0x2B8F980 Offset: 0x2B8FA81 VA: 0x2B8F980
	|-Task<SceneInstance>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B8D3A0 Offset: 0x2B8D4A1 VA: 0x2B8D3A0
	|-Task<AsyncProtocolResult>.ConfigureAwait
	|-Task<object>.ConfigureAwait
	|-Task<Task>.ConfigureAwait
	|
	|-RVA: 0x2B8C060 Offset: 0x2B8C161 VA: 0x2B8C060
	|-Task<Nullable<int>>.ConfigureAwait
	|
	|-RVA: 0x2B873E0 Offset: 0x2B874E1 VA: 0x2B873E0
	|-Task<bool>.ConfigureAwait
	|
	|-RVA: 0x2B886A0 Offset: 0x2B887A1 VA: 0x2B886A0
	|-Task<int>.ConfigureAwait
	|
	|-RVA: 0x2B89960 Offset: 0x2B89A61 VA: 0x2B89960
	|-Task<long>.ConfigureAwait
	|
	|-RVA: 0x2B8ADA0 Offset: 0x2B8AEA1 VA: 0x2B8ADA0
	|-Task<Nullable<ReadOnlySequence<byte>>>.ConfigureAwait
	|
	|-RVA: 0x2B8E660 Offset: 0x2B8E761 VA: 0x2B8E660
	|-Task<VoidTaskResult>.ConfigureAwait
	|
	|-RVA: 0x2B8F9B0 Offset: 0x2B8FAB1 VA: 0x2B8F9B0
	|-Task<SceneInstance>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B87420 Offset: 0x2B87521 VA: 0x2B87420
	|-Task<bool>..cctor
	|
	|-RVA: 0x2B886E0 Offset: 0x2B887E1 VA: 0x2B886E0
	|-Task<int>..cctor
	|
	|-RVA: 0x2B899A0 Offset: 0x2B89AA1 VA: 0x2B899A0
	|-Task<long>..cctor
	|
	|-RVA: 0x2B8ADE0 Offset: 0x2B8AEE1 VA: 0x2B8ADE0
	|-Task<Nullable<ReadOnlySequence<byte>>>..cctor
	|
	|-RVA: 0x2B8C0A0 Offset: 0x2B8C1A1 VA: 0x2B8C0A0
	|-Task<Nullable<int>>..cctor
	|
	|-RVA: 0x2B8D3E0 Offset: 0x2B8D4E1 VA: 0x2B8D3E0
	|-Task<object>..cctor
	|
	|-RVA: 0x2B8E6A0 Offset: 0x2B8E7A1 VA: 0x2B8E6A0
	|-Task<VoidTaskResult>..cctor
	|
	|-RVA: 0x2B8F9F0 Offset: 0x2B8FAF1 VA: 0x2B8F9F0
	|-Task<SceneInstance>..cctor
	*/
}

