[DebuggerDisplayAttribute] // RVA: 0x138FE0 Offset: 0x1390E1 VA: 0x138FE0
internal class Sequence<T> : IBufferWriter<T>, IDisposable // TypeDefIndex: 5106
{
	// Fields
	private static readonly int DefaultLengthFromArrayPool; // 0x0
	private readonly Stack<Sequence.SequenceSegment<T>> segmentPool; // 0x0
	private readonly MemoryPool<T> memoryPool; // 0x0
	private readonly ArrayPool<T> arrayPool; // 0x0
	private Sequence.SequenceSegment<T> first; // 0x0
	private Sequence.SequenceSegment<T> last; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1397D0 Offset: 0x1398D1 VA: 0x1397D0
	private int <MinimumSpanLength>k__BackingField; // 0x0

	// Properties
	public int MinimumSpanLength { get; set; }
	public ReadOnlySequence<T> AsReadOnlySequence { get; }
	public long Length { get; }
	private string DebuggerDisplay { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADF430 Offset: 0x2ADF531 VA: 0x2ADF430
	|-Sequence<byte>..ctor
	|
	|-RVA: 0x2C96BA0 Offset: 0x2C96CA1 VA: 0x2C96BA0
	|-Sequence<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(MemoryPool<T> memoryPool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADF490 Offset: 0x2ADF591 VA: 0x2ADF490
	|-Sequence<byte>..ctor
	|
	|-RVA: 0x2C96C00 Offset: 0x2C96D01 VA: 0x2C96C00
	|-Sequence<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ArrayPool<T> arrayPool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADF570 Offset: 0x2ADF671 VA: 0x2ADF570
	|-Sequence<byte>..ctor
	|
	|-RVA: 0x2C96CE0 Offset: 0x2C96DE1 VA: 0x2C96CE0
	|-Sequence<object>..ctor
	*/

	[CompilerGeneratedAttribute] // RVA: 0x139BE0 Offset: 0x139CE1 VA: 0x139BE0
	// RVA: -1 Offset: -1
	public int get_MinimumSpanLength() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADF650 Offset: 0x2ADF751 VA: 0x2ADF650
	|-Sequence<byte>.get_MinimumSpanLength
	|
	|-RVA: 0x2C96DC0 Offset: 0x2C96EC1 VA: 0x2C96DC0
	|-Sequence<object>.get_MinimumSpanLength
	*/

	[CompilerGeneratedAttribute] // RVA: 0x139BF0 Offset: 0x139CF1 VA: 0x139BF0
	// RVA: -1 Offset: -1
	public void set_MinimumSpanLength(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADF660 Offset: 0x2ADF761 VA: 0x2ADF660
	|-Sequence<byte>.set_MinimumSpanLength
	|
	|-RVA: 0x2C96DD0 Offset: 0x2C96ED1 VA: 0x2C96DD0
	|-Sequence<object>.set_MinimumSpanLength
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySequence<T> get_AsReadOnlySequence() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADF670 Offset: 0x2ADF771 VA: 0x2ADF670
	|-Sequence<byte>.get_AsReadOnlySequence
	|
	|-RVA: 0x2C96DE0 Offset: 0x2C96EE1 VA: 0x2C96DE0
	|-Sequence<object>.get_AsReadOnlySequence
	*/

	// RVA: -1 Offset: -1
	public long get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADF740 Offset: 0x2ADF841 VA: 0x2ADF740
	|-Sequence<byte>.get_Length
	|
	|-RVA: 0x2C96EB0 Offset: 0x2C96FB1 VA: 0x2C96EB0
	|-Sequence<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	private string get_DebuggerDisplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADF7B0 Offset: 0x2ADF8B1 VA: 0x2ADF7B0
	|-Sequence<byte>.get_DebuggerDisplay
	|
	|-RVA: 0x2C96F20 Offset: 0x2C97021 VA: 0x2C96F20
	|-Sequence<object>.get_DebuggerDisplay
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySequence<T> op_Implicit(Sequence<T> sequence) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADF890 Offset: 0x2ADF991 VA: 0x2ADF890
	|-Sequence<byte>.op_Implicit
	|
	|-RVA: 0x2C97000 Offset: 0x2C97101 VA: 0x2C97000
	|-Sequence<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void AdvanceTo(SequencePosition position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADFAF0 Offset: 0x2ADFBF1 VA: 0x2ADFAF0
	|-Sequence<byte>.AdvanceTo
	|
	|-RVA: 0x2C97260 Offset: 0x2C97361 VA: 0x2C97260
	|-Sequence<object>.AdvanceTo
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Advance(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADFD20 Offset: 0x2ADFE21 VA: 0x2ADFD20
	|-Sequence<byte>.Advance
	|
	|-RVA: 0x2C97490 Offset: 0x2C97591 VA: 0x2C97490
	|-Sequence<object>.Advance
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public Memory<T> GetMemory(int sizeHint) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADFDB0 Offset: 0x2ADFEB1 VA: 0x2ADFDB0
	|-Sequence<byte>.GetMemory
	|
	|-RVA: 0x2C97520 Offset: 0x2C97621 VA: 0x2C97520
	|-Sequence<object>.GetMemory
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public Span<T> GetSpan(int sizeHint) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADFE00 Offset: 0x2ADFF01 VA: 0x2ADFE00
	|-Sequence<byte>.GetSpan
	|
	|-RVA: 0x2C97570 Offset: 0x2C97671 VA: 0x2C97570
	|-Sequence<object>.GetSpan
	*/

	[EditorBrowsableAttribute] // RVA: 0x139C00 Offset: 0x139D01 VA: 0x139C00
	// RVA: -1 Offset: -1 Slot: 7
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADFE70 Offset: 0x2ADFF71 VA: 0x2ADFE70
	|-Sequence<byte>.Dispose
	|
	|-RVA: 0x2C975E0 Offset: 0x2C976E1 VA: 0x2C975E0
	|-Sequence<object>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADFEA0 Offset: 0x2ADFFA1 VA: 0x2ADFEA0
	|-Sequence<byte>.Reset
	|
	|-RVA: 0x2C97610 Offset: 0x2C97711 VA: 0x2C97610
	|-Sequence<object>.Reset
	*/

	// RVA: -1 Offset: -1
	private Sequence.SequenceSegment<T> GetSegment(int sizeHint) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADFF10 Offset: 0x2AE0011 VA: 0x2ADFF10
	|-Sequence<byte>.GetSegment
	|
	|-RVA: 0x2C97680 Offset: 0x2C97781 VA: 0x2C97680
	|-Sequence<object>.GetSegment
	*/

	// RVA: -1 Offset: -1
	private void Append(Sequence.SequenceSegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AE0250 Offset: 0x2AE0351 VA: 0x2AE0250
	|-Sequence<byte>.Append
	|
	|-RVA: 0x2C979C0 Offset: 0x2C97AC1 VA: 0x2C979C0
	|-Sequence<object>.Append
	*/

	// RVA: -1 Offset: -1
	private Sequence.SequenceSegment<T> RecycleAndGetNext(Sequence.SequenceSegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AE03A0 Offset: 0x2AE04A1 VA: 0x2AE03A0
	|-Sequence<byte>.RecycleAndGetNext
	|
	|-RVA: 0x2C97B10 Offset: 0x2C97C11 VA: 0x2C97B10
	|-Sequence<object>.RecycleAndGetNext
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AE0430 Offset: 0x2AE0531 VA: 0x2AE0430
	|-Sequence<byte>..cctor
	|
	|-RVA: 0x2C97BA0 Offset: 0x2C97CA1 VA: 0x2C97BA0
	|-Sequence<object>..cctor
	*/
}

