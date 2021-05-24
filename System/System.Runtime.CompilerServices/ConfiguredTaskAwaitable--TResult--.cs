public struct ConfiguredTaskAwaitable<TResult> // TypeDefIndex: 1267
{
	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35BA10 Offset: 0x35BB11 VA: 0x35BA10
	|-ConfiguredTaskAwaitable<bool>..ctor
	|
	|-RVA: 0x35BAB0 Offset: 0x35BBB1 VA: 0x35BAB0
	|-ConfiguredTaskAwaitable<int>..ctor
	|
	|-RVA: 0x35BB50 Offset: 0x35BC51 VA: 0x35BB50
	|-ConfiguredTaskAwaitable<long>..ctor
	|
	|-RVA: 0x35BBF0 Offset: 0x35BCF1 VA: 0x35BBF0
	|-ConfiguredTaskAwaitable<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x35BC90 Offset: 0x35BD91 VA: 0x35BC90
	|-ConfiguredTaskAwaitable<Nullable<int>>..ctor
	|
	|-RVA: 0x35BD30 Offset: 0x35BE31 VA: 0x35BD30
	|-ConfiguredTaskAwaitable<object>..ctor
	|
	|-RVA: 0x35BDD0 Offset: 0x35BED1 VA: 0x35BDD0
	|-ConfiguredTaskAwaitable<VoidTaskResult>..ctor
	|
	|-RVA: 0x35BE70 Offset: 0x35BF71 VA: 0x35BE70
	|-ConfiguredTaskAwaitable<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35BDC0 Offset: 0x35BEC1 VA: 0x35BDC0
	|-ConfiguredTaskAwaitable<AsyncProtocolResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<object>.GetAwaiter
	|-ConfiguredTaskAwaitable<Task>.GetAwaiter
	|
	|-RVA: 0x35BD20 Offset: 0x35BE21 VA: 0x35BD20
	|-ConfiguredTaskAwaitable<Nullable<int>>.GetAwaiter
	|
	|-RVA: 0x35BAA0 Offset: 0x35BBA1 VA: 0x35BAA0
	|-ConfiguredTaskAwaitable<bool>.GetAwaiter
	|
	|-RVA: 0x35BB40 Offset: 0x35BC41 VA: 0x35BB40
	|-ConfiguredTaskAwaitable<int>.GetAwaiter
	|
	|-RVA: 0x35BBE0 Offset: 0x35BCE1 VA: 0x35BBE0
	|-ConfiguredTaskAwaitable<long>.GetAwaiter
	|
	|-RVA: 0x35BC80 Offset: 0x35BD81 VA: 0x35BC80
	|-ConfiguredTaskAwaitable<Nullable<ReadOnlySequence<byte>>>.GetAwaiter
	|
	|-RVA: 0x35BE60 Offset: 0x35BF61 VA: 0x35BE60
	|-ConfiguredTaskAwaitable<VoidTaskResult>.GetAwaiter
	|
	|-RVA: 0x35BEF0 Offset: 0x35BFF1 VA: 0x35BEF0
	|-ConfiguredTaskAwaitable<SceneInstance>.GetAwaiter
	*/
}

