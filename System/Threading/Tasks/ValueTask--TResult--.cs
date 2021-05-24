[IsReadOnlyAttribute] // RVA: 0x129500 Offset: 0x129601 VA: 0x129500
[AsyncMethodBuilderAttribute] // RVA: 0x129500 Offset: 0x129601 VA: 0x129500
public struct ValueTask<TResult> : IEquatable<ValueTask<TResult>> // TypeDefIndex: 4430
{
	// Fields
	internal readonly object _obj; // 0x0
	internal readonly TResult _result; // 0x0
	internal readonly short _token; // 0x0
	internal readonly bool _continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TResult Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383420 Offset: 0x383521 VA: 0x383420
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x383680 Offset: 0x383781 VA: 0x383680
	|-ValueTask<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x3839D0 Offset: 0x383AD1 VA: 0x3839D0
	|-ValueTask<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383460 Offset: 0x383561 VA: 0x383460
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x3836E0 Offset: 0x3837E1 VA: 0x3836E0
	|-ValueTask<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x383A10 Offset: 0x383B11 VA: 0x383A10
	|-ValueTask<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(object obj, TResult result, short token, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3834C0 Offset: 0x3835C1 VA: 0x3834C0
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x383740 Offset: 0x383841 VA: 0x383740
	|-ValueTask<Nullable<ReadOnlySequence<byte>>>..ctor
	|
	|-RVA: 0x383A70 Offset: 0x383B71 VA: 0x383A70
	|-ValueTask<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383510 Offset: 0x383611 VA: 0x383510
	|-ValueTask<int>.GetHashCode
	|
	|-RVA: 0x3837D0 Offset: 0x3838D1 VA: 0x3837D0
	|-ValueTask<Nullable<ReadOnlySequence<byte>>>.GetHashCode
	|
	|-RVA: 0x383AD0 Offset: 0x383BD1 VA: 0x383AD0
	|-ValueTask<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383570 Offset: 0x383671 VA: 0x383570
	|-ValueTask<int>.Equals
	|
	|-RVA: 0x3837E0 Offset: 0x3838E1 VA: 0x3837E0
	|-ValueTask<Nullable<ReadOnlySequence<byte>>>.Equals
	|
	|-RVA: 0x383B00 Offset: 0x383C01 VA: 0x383B00
	|-ValueTask<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTask<TResult> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383580 Offset: 0x383681 VA: 0x383580
	|-ValueTask<int>.Equals
	|
	|-RVA: 0x3837F0 Offset: 0x3838F1 VA: 0x3837F0
	|-ValueTask<Nullable<ReadOnlySequence<byte>>>.Equals
	|
	|-RVA: 0x383B10 Offset: 0x383C11 VA: 0x383B10
	|-ValueTask<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383590 Offset: 0x383691 VA: 0x383590
	|-ValueTask<int>.get_IsCompleted
	|
	|-RVA: 0x383840 Offset: 0x383941 VA: 0x383840
	|-ValueTask<Nullable<ReadOnlySequence<byte>>>.get_IsCompleted
	|
	|-RVA: 0x383C10 Offset: 0x383D11 VA: 0x383C10
	|-ValueTask<object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompletedSuccessfully() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3835A0 Offset: 0x3836A1 VA: 0x3835A0
	|-ValueTask<int>.get_IsCompletedSuccessfully
	|
	|-RVA: 0x383850 Offset: 0x383951 VA: 0x383850
	|-ValueTask<Nullable<ReadOnlySequence<byte>>>.get_IsCompletedSuccessfully
	|
	|-RVA: 0x383C20 Offset: 0x383D21 VA: 0x383C20
	|-ValueTask<object>.get_IsCompletedSuccessfully
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3835B0 Offset: 0x3836B1 VA: 0x3835B0
	|-ValueTask<int>.get_Result
	|
	|-RVA: 0x383860 Offset: 0x383961 VA: 0x383860
	|-ValueTask<Nullable<ReadOnlySequence<byte>>>.get_Result
	|
	|-RVA: 0x383C30 Offset: 0x383D31 VA: 0x383C30
	|-ValueTask<object>.get_Result
	*/

	// RVA: -1 Offset: -1
	public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3835C0 Offset: 0x3836C1 VA: 0x3835C0
	|-ValueTask<int>.ConfigureAwait
	|
	|-RVA: 0x383870 Offset: 0x383971 VA: 0x383870
	|-ValueTask<Nullable<ReadOnlySequence<byte>>>.ConfigureAwait
	|
	|-RVA: 0x383C40 Offset: 0x383D41 VA: 0x383C40
	|-ValueTask<object>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383670 Offset: 0x383771 VA: 0x383670
	|-ValueTask<int>.ToString
	|
	|-RVA: 0x3839C0 Offset: 0x383AC1 VA: 0x3839C0
	|-ValueTask<Nullable<ReadOnlySequence<byte>>>.ToString
	|
	|-RVA: 0x383D20 Offset: 0x383E21 VA: 0x383D20
	|-ValueTask<object>.ToString
	*/
}

