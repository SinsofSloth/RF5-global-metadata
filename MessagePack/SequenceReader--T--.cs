[IsByRefLikeAttribute] // RVA: 0x1392B0 Offset: 0x1393B1 VA: 0x1392B0
[ObsoleteAttribute] // RVA: 0x1392B0 Offset: 0x1393B1 VA: 0x1392B0
internal struct SequenceReader<T> // TypeDefIndex: 5172
{
	// Fields
	private bool usingSequence; // 0x0
	private ReadOnlySequence<T> sequence; // 0x0
	private SequencePosition currentPosition; // 0x0
	private SequencePosition nextPosition; // 0x0
	private ReadOnlyMemory<T> memory; // 0x0
	private bool moreData; // 0x0
	private long length; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1399E0 Offset: 0x139AE1 VA: 0x1399E0
	private ReadOnlySpan<T> <CurrentSpan>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1399F0 Offset: 0x139AF1 VA: 0x1399F0
	private int <CurrentSpanIndex>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x139A00 Offset: 0x139B01 VA: 0x139A00
	private long <Consumed>k__BackingField; // 0x0

	// Properties
	public bool End { get; }
	public ReadOnlySequence<T> Sequence { get; }
	public SequencePosition Position { get; }
	public ReadOnlySpan<T> CurrentSpan { get; set; }
	public int CurrentSpanIndex { get; set; }
	public ReadOnlySpan<T> UnreadSpan { get; }
	public long Consumed { get; set; }
	public long Remaining { get; }
	public long Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(in ReadOnlySequence<T> sequence) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3790C0 Offset: 0x3791C1 VA: 0x3790C0
	|-SequenceReader<byte>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ReadOnlyMemory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3790D0 Offset: 0x3791D1 VA: 0x3790D0
	|-SequenceReader<byte>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_End() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3790E0 Offset: 0x3791E1 VA: 0x3790E0
	|-SequenceReader<byte>.get_End
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySequence<T> get_Sequence() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3790F0 Offset: 0x3791F1 VA: 0x3790F0
	|-SequenceReader<byte>.get_Sequence
	*/

	// RVA: -1 Offset: -1
	public SequencePosition get_Position() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379100 Offset: 0x379201 VA: 0x379100
	|-SequenceReader<byte>.get_Position
	*/

	[CompilerGeneratedAttribute] // RVA: 0x13A3B0 Offset: 0x13A4B1 VA: 0x13A3B0
	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> get_CurrentSpan() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379110 Offset: 0x379211 VA: 0x379110
	|-SequenceReader<byte>.get_CurrentSpan
	*/

	[CompilerGeneratedAttribute] // RVA: 0x13A3C0 Offset: 0x13A4C1 VA: 0x13A3C0
	// RVA: -1 Offset: -1
	private void set_CurrentSpan(ReadOnlySpan<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379130 Offset: 0x379231 VA: 0x379130
	|-SequenceReader<byte>.set_CurrentSpan
	*/

	[CompilerGeneratedAttribute] // RVA: 0x13A3D0 Offset: 0x13A4D1 VA: 0x13A3D0
	// RVA: -1 Offset: -1
	public int get_CurrentSpanIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379150 Offset: 0x379251 VA: 0x379150
	|-SequenceReader<byte>.get_CurrentSpanIndex
	*/

	[CompilerGeneratedAttribute] // RVA: 0x13A3E0 Offset: 0x13A4E1 VA: 0x13A3E0
	// RVA: -1 Offset: -1
	private void set_CurrentSpanIndex(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379160 Offset: 0x379261 VA: 0x379160
	|-SequenceReader<byte>.set_CurrentSpanIndex
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> get_UnreadSpan() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379170 Offset: 0x379271 VA: 0x379170
	|-SequenceReader<byte>.get_UnreadSpan
	*/

	[CompilerGeneratedAttribute] // RVA: 0x13A3F0 Offset: 0x13A4F1 VA: 0x13A3F0
	// RVA: -1 Offset: -1
	public long get_Consumed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379180 Offset: 0x379281 VA: 0x379180
	|-SequenceReader<byte>.get_Consumed
	*/

	[CompilerGeneratedAttribute] // RVA: 0x13A400 Offset: 0x13A501 VA: 0x13A400
	// RVA: -1 Offset: -1
	private void set_Consumed(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379190 Offset: 0x379291 VA: 0x379190
	|-SequenceReader<byte>.set_Consumed
	*/

	// RVA: -1 Offset: -1
	public long get_Remaining() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3791A0 Offset: 0x3792A1 VA: 0x3791A0
	|-SequenceReader<byte>.get_Remaining
	*/

	// RVA: -1 Offset: -1
	public long get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3791B0 Offset: 0x3792B1 VA: 0x3791B0
	|-SequenceReader<byte>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool TryPeek(out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379260 Offset: 0x379361 VA: 0x379260
	|-SequenceReader<byte>.TryPeek
	*/

	// RVA: -1 Offset: -1
	public bool TryRead(out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379320 Offset: 0x379421 VA: 0x379320
	|-SequenceReader<byte>.TryRead
	*/

	// RVA: -1 Offset: -1
	public void Rewind(long count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379330 Offset: 0x379431 VA: 0x379330
	|-SequenceReader<byte>.Rewind
	*/

	// RVA: -1 Offset: -1
	private void RetreatToPreviousSpan(long consumed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379340 Offset: 0x379441 VA: 0x379340
	|-SequenceReader<byte>.RetreatToPreviousSpan
	*/

	// RVA: -1 Offset: -1
	private void ResetReader() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379350 Offset: 0x379451 VA: 0x379350
	|-SequenceReader<byte>.ResetReader
	*/

	// RVA: -1 Offset: -1
	private void GetNextSpan() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379360 Offset: 0x379461 VA: 0x379360
	|-SequenceReader<byte>.GetNextSpan
	*/

	// RVA: -1 Offset: -1
	public void Advance(long count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379370 Offset: 0x379471 VA: 0x379370
	|-SequenceReader<byte>.Advance
	*/

	// RVA: -1 Offset: -1
	internal void AdvanceCurrentSpan(long count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379380 Offset: 0x379481 VA: 0x379380
	|-SequenceReader<byte>.AdvanceCurrentSpan
	*/

	// RVA: -1 Offset: -1
	internal void AdvanceWithinSpan(long count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379390 Offset: 0x379491 VA: 0x379390
	|-SequenceReader<byte>.AdvanceWithinSpan
	*/

	// RVA: -1 Offset: -1
	internal bool TryAdvance(long count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379440 Offset: 0x379541 VA: 0x379440
	|-SequenceReader<byte>.TryAdvance
	*/

	// RVA: -1 Offset: -1
	private void AdvanceToNextSpan(long count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3794E0 Offset: 0x3795E1 VA: 0x3794E0
	|-SequenceReader<byte>.AdvanceToNextSpan
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3794F0 Offset: 0x3795F1 VA: 0x3794F0
	|-SequenceReader<byte>.TryCopyTo
	*/

	// RVA: -1 Offset: -1
	internal bool TryCopyMultisegment(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379530 Offset: 0x379631 VA: 0x379530
	|-SequenceReader<byte>.TryCopyMultisegment
	*/
}

