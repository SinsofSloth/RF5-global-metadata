private class Sequence.SequenceSegment<T> : ReadOnlySequenceSegment<T> // TypeDefIndex: 5107
{
	// Fields
	private static readonly bool MayContainReferences; // 0x0
	private T[] array; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x139A70 Offset: 0x139B71 VA: 0x139A70
	private int <Start>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x139A80 Offset: 0x139B81 VA: 0x139A80
	private int <End>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x139A90 Offset: 0x139B91 VA: 0x139A90
	private IMemoryOwner<T> <MemoryOwner>k__BackingField; // 0x0

	// Properties
	internal int Start { get; set; }
	internal int End { get; set; }
	internal Memory<T> RemainingMemory { get; }
	internal Span<T> RemainingSpan { get; }
	internal IMemoryOwner<T> MemoryOwner { get; set; }
	internal Memory<T> AvailableMemory { get; }
	internal int Length { get; }
	internal int WritableBytes { get; }
	internal Sequence.SequenceSegment<T> Next { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x13AAD0 Offset: 0x13ABD1 VA: 0x13AAD0
	// RVA: -1 Offset: -1
	internal int get_Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD4B0 Offset: 0x2ADD5B1 VA: 0x2ADD4B0
	|-Sequence.SequenceSegment<byte>.get_Start
	|
	|-RVA: 0x2ADE470 Offset: 0x2ADE571 VA: 0x2ADE470
	|-Sequence.SequenceSegment<object>.get_Start
	*/

	[CompilerGeneratedAttribute] // RVA: 0x13AAE0 Offset: 0x13ABE1 VA: 0x13AAE0
	// RVA: -1 Offset: -1
	private void set_Start(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD4C0 Offset: 0x2ADD5C1 VA: 0x2ADD4C0
	|-Sequence.SequenceSegment<byte>.set_Start
	|
	|-RVA: 0x2ADE480 Offset: 0x2ADE581 VA: 0x2ADE480
	|-Sequence.SequenceSegment<object>.set_Start
	*/

	[CompilerGeneratedAttribute] // RVA: 0x13AAF0 Offset: 0x13ABF1 VA: 0x13AAF0
	// RVA: -1 Offset: -1
	internal int get_End() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD4D0 Offset: 0x2ADD5D1 VA: 0x2ADD4D0
	|-Sequence.SequenceSegment<byte>.get_End
	|
	|-RVA: 0x2ADE490 Offset: 0x2ADE591 VA: 0x2ADE490
	|-Sequence.SequenceSegment<object>.get_End
	*/

	[CompilerGeneratedAttribute] // RVA: 0x13AB00 Offset: 0x13AC01 VA: 0x13AB00
	// RVA: -1 Offset: -1
	private void set_End(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD4E0 Offset: 0x2ADD5E1 VA: 0x2ADD4E0
	|-Sequence.SequenceSegment<byte>.set_End
	|
	|-RVA: 0x2ADE4A0 Offset: 0x2ADE5A1 VA: 0x2ADE4A0
	|-Sequence.SequenceSegment<object>.set_End
	*/

	// RVA: -1 Offset: -1
	internal Memory<T> get_RemainingMemory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD4F0 Offset: 0x2ADD5F1 VA: 0x2ADD4F0
	|-Sequence.SequenceSegment<byte>.get_RemainingMemory
	|
	|-RVA: 0x2ADE4B0 Offset: 0x2ADE5B1 VA: 0x2ADE4B0
	|-Sequence.SequenceSegment<object>.get_RemainingMemory
	*/

	// RVA: -1 Offset: -1
	internal Span<T> get_RemainingSpan() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD5D0 Offset: 0x2ADD6D1 VA: 0x2ADD5D0
	|-Sequence.SequenceSegment<byte>.get_RemainingSpan
	|
	|-RVA: 0x2ADE590 Offset: 0x2ADE691 VA: 0x2ADE590
	|-Sequence.SequenceSegment<object>.get_RemainingSpan
	*/

	[CompilerGeneratedAttribute] // RVA: 0x13AB10 Offset: 0x13AC11 VA: 0x13AB10
	// RVA: -1 Offset: -1
	internal IMemoryOwner<T> get_MemoryOwner() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD750 Offset: 0x2ADD851 VA: 0x2ADD750
	|-Sequence.SequenceSegment<byte>.get_MemoryOwner
	|
	|-RVA: 0x2ADE710 Offset: 0x2ADE811 VA: 0x2ADE710
	|-Sequence.SequenceSegment<object>.get_MemoryOwner
	*/

	[CompilerGeneratedAttribute] // RVA: 0x13AB20 Offset: 0x13AC21 VA: 0x13AB20
	// RVA: -1 Offset: -1
	private void set_MemoryOwner(IMemoryOwner<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD760 Offset: 0x2ADD861 VA: 0x2ADD760
	|-Sequence.SequenceSegment<byte>.set_MemoryOwner
	|
	|-RVA: 0x2ADE720 Offset: 0x2ADE821 VA: 0x2ADE720
	|-Sequence.SequenceSegment<object>.set_MemoryOwner
	*/

	// RVA: -1 Offset: -1
	internal Memory<T> get_AvailableMemory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD770 Offset: 0x2ADD871 VA: 0x2ADD770
	|-Sequence.SequenceSegment<byte>.get_AvailableMemory
	|
	|-RVA: 0x2ADE730 Offset: 0x2ADE831 VA: 0x2ADE730
	|-Sequence.SequenceSegment<object>.get_AvailableMemory
	*/

	// RVA: -1 Offset: -1
	internal int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD860 Offset: 0x2ADD961 VA: 0x2ADD860
	|-Sequence.SequenceSegment<byte>.get_Length
	|
	|-RVA: 0x2ADE820 Offset: 0x2ADE921 VA: 0x2ADE820
	|-Sequence.SequenceSegment<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	internal int get_WritableBytes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD8D0 Offset: 0x2ADD9D1 VA: 0x2ADD8D0
	|-Sequence.SequenceSegment<byte>.get_WritableBytes
	|
	|-RVA: 0x2ADE890 Offset: 0x2ADE991 VA: 0x2ADE890
	|-Sequence.SequenceSegment<object>.get_WritableBytes
	*/

	// RVA: -1 Offset: -1
	internal Sequence.SequenceSegment<T> get_Next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD960 Offset: 0x2ADDA61 VA: 0x2ADD960
	|-Sequence.SequenceSegment<byte>.get_Next
	|
	|-RVA: 0x2ADE920 Offset: 0x2ADEA21 VA: 0x2ADE920
	|-Sequence.SequenceSegment<object>.get_Next
	*/

	// RVA: -1 Offset: -1
	internal void set_Next(Sequence.SequenceSegment<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADD9F0 Offset: 0x2ADDAF1 VA: 0x2ADD9F0
	|-Sequence.SequenceSegment<byte>.set_Next
	|
	|-RVA: 0x2ADE9B0 Offset: 0x2ADEAB1 VA: 0x2ADE9B0
	|-Sequence.SequenceSegment<object>.set_Next
	*/

	// RVA: -1 Offset: -1
	internal void Assign(IMemoryOwner<T> memoryOwner) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADDA20 Offset: 0x2ADDB21 VA: 0x2ADDA20
	|-Sequence.SequenceSegment<byte>.Assign
	|
	|-RVA: 0x2ADE9E0 Offset: 0x2ADEAE1 VA: 0x2ADE9E0
	|-Sequence.SequenceSegment<object>.Assign
	*/

	// RVA: -1 Offset: -1
	internal void Assign(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADDB20 Offset: 0x2ADDC21 VA: 0x2ADDB20
	|-Sequence.SequenceSegment<byte>.Assign
	|
	|-RVA: 0x2ADEAE0 Offset: 0x2ADEBE1 VA: 0x2ADEAE0
	|-Sequence.SequenceSegment<object>.Assign
	*/

	// RVA: -1 Offset: -1
	internal void ResetMemory(ArrayPool<T> arrayPool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADDBA0 Offset: 0x2ADDCA1 VA: 0x2ADDBA0
	|-Sequence.SequenceSegment<byte>.ResetMemory
	|
	|-RVA: 0x2ADEB60 Offset: 0x2ADEC61 VA: 0x2ADEB60
	|-Sequence.SequenceSegment<object>.ResetMemory
	*/

	// RVA: -1 Offset: -1
	internal void SetNext(Sequence.SequenceSegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADDDC0 Offset: 0x2ADDEC1 VA: 0x2ADDDC0
	|-Sequence.SequenceSegment<byte>.SetNext
	|
	|-RVA: 0x2ADED80 Offset: 0x2ADEE81 VA: 0x2ADED80
	|-Sequence.SequenceSegment<object>.SetNext
	*/

	// RVA: -1 Offset: -1
	internal void Advance(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADDF80 Offset: 0x2ADE081 VA: 0x2ADDF80
	|-Sequence.SequenceSegment<byte>.Advance
	|
	|-RVA: 0x2ADEF40 Offset: 0x2ADF041 VA: 0x2ADEF40
	|-Sequence.SequenceSegment<object>.Advance
	*/

	// RVA: -1 Offset: -1
	internal void AdvanceTo(int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADE0B0 Offset: 0x2ADE1B1 VA: 0x2ADE0B0
	|-Sequence.SequenceSegment<byte>.AdvanceTo
	|
	|-RVA: 0x2ADF070 Offset: 0x2ADF171 VA: 0x2ADF070
	|-Sequence.SequenceSegment<object>.AdvanceTo
	*/

	// RVA: -1 Offset: -1
	private void ClearReferences(int startIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADE150 Offset: 0x2ADE251 VA: 0x2ADE150
	|-Sequence.SequenceSegment<byte>.ClearReferences
	|
	|-RVA: 0x2ADF110 Offset: 0x2ADF211 VA: 0x2ADF110
	|-Sequence.SequenceSegment<object>.ClearReferences
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADE360 Offset: 0x2ADE461 VA: 0x2ADE360
	|-Sequence.SequenceSegment<byte>..ctor
	|
	|-RVA: 0x2ADF320 Offset: 0x2ADF421 VA: 0x2ADF320
	|-Sequence.SequenceSegment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2ADE390 Offset: 0x2ADE491 VA: 0x2ADE390
	|-Sequence.SequenceSegment<byte>..cctor
	|
	|-RVA: 0x2ADF350 Offset: 0x2ADF451 VA: 0x2ADF350
	|-Sequence.SequenceSegment<object>..cctor
	*/
}

