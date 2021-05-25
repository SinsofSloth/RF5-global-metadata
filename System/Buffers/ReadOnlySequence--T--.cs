[DebuggerTypeProxyAttribute] // RVA: 0x128B20 Offset: 0x128C21 VA: 0x128B20
[DebuggerDisplayAttribute] // RVA: 0x128B20 Offset: 0x128C21 VA: 0x128B20
[IsReadOnlyAttribute] // RVA: 0x128B20 Offset: 0x128C21 VA: 0x128B20
public struct ReadOnlySequence<T> // TypeDefIndex: 4401
{
	// Fields
	private readonly SequencePosition _sequenceStart; // 0x0
	private readonly SequencePosition _sequenceEnd; // 0x0
	public static readonly ReadOnlySequence<T> Empty; // 0x0

	// Properties
	public long Length { get; }
	public bool IsEmpty { get; }
	public bool IsSingleSegment { get; }
	public ReadOnlyMemory<T> First { get; }
	public SequencePosition Start { get; }
	public SequencePosition End { get; }

	// Methods

	// RVA: -1 Offset: -1
	public long get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D6A0 Offset: 0x37D7A1 VA: 0x37D6A0
	|-ReadOnlySequence<byte>.get_Length
	|
	|-RVA: 0x37DE20 Offset: 0x37DF21 VA: 0x37DE20
	|-ReadOnlySequence<char>.get_Length
	|
	|-RVA: 0x37E5A0 Offset: 0x37E6A1 VA: 0x37E5A0
	|-ReadOnlySequence<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D6E0 Offset: 0x37D7E1 VA: 0x37D6E0
	|-ReadOnlySequence<byte>.get_IsEmpty
	|
	|-RVA: 0x37DE60 Offset: 0x37DF61 VA: 0x37DE60
	|-ReadOnlySequence<char>.get_IsEmpty
	|
	|-RVA: 0x37E5E0 Offset: 0x37E6E1 VA: 0x37E5E0
	|-ReadOnlySequence<object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public bool get_IsSingleSegment() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D750 Offset: 0x37D851 VA: 0x37D750
	|-ReadOnlySequence<byte>.get_IsSingleSegment
	|
	|-RVA: 0x37DED0 Offset: 0x37DFD1 VA: 0x37DED0
	|-ReadOnlySequence<char>.get_IsSingleSegment
	|
	|-RVA: 0x37E650 Offset: 0x37E751 VA: 0x37E650
	|-ReadOnlySequence<object>.get_IsSingleSegment
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyMemory<T> get_First() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D770 Offset: 0x37D871 VA: 0x37D770
	|-ReadOnlySequence<byte>.get_First
	|
	|-RVA: 0x37DEF0 Offset: 0x37DFF1 VA: 0x37DEF0
	|-ReadOnlySequence<char>.get_First
	|
	|-RVA: 0x37E670 Offset: 0x37E771 VA: 0x37E670
	|-ReadOnlySequence<object>.get_First
	*/

	// RVA: -1 Offset: -1
	public SequencePosition get_Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D7B0 Offset: 0x37D8B1 VA: 0x37D7B0
	|-ReadOnlySequence<byte>.get_Start
	|
	|-RVA: 0x37DF30 Offset: 0x37E031 VA: 0x37DF30
	|-ReadOnlySequence<char>.get_Start
	|
	|-RVA: 0x37E6B0 Offset: 0x37E7B1 VA: 0x37E6B0
	|-ReadOnlySequence<object>.get_Start
	*/

	// RVA: -1 Offset: -1
	public SequencePosition get_End() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D7C0 Offset: 0x37D8C1 VA: 0x37D7C0
	|-ReadOnlySequence<byte>.get_End
	|
	|-RVA: 0x37DF40 Offset: 0x37E041 VA: 0x37DF40
	|-ReadOnlySequence<char>.get_End
	|
	|-RVA: 0x37E6C0 Offset: 0x37E7C1 VA: 0x37E6C0
	|-ReadOnlySequence<object>.get_End
	*/

	// RVA: -1 Offset: -1
	private void .ctor(object startSegment, int startIndexAndFlags, object endSegment, int endIndexAndFlags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D7D0 Offset: 0x37D8D1 VA: 0x37D7D0
	|-ReadOnlySequence<byte>..ctor
	|
	|-RVA: 0x37DF50 Offset: 0x37E051 VA: 0x37DF50
	|-ReadOnlySequence<char>..ctor
	|
	|-RVA: 0x37E6D0 Offset: 0x37E7D1 VA: 0x37E6D0
	|-ReadOnlySequence<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ReadOnlySequenceSegment<T> startSegment, int startIndex, ReadOnlySequenceSegment<T> endSegment, int endIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D860 Offset: 0x37D961 VA: 0x37D860
	|-ReadOnlySequence<byte>..ctor
	|
	|-RVA: 0x37DFE0 Offset: 0x37E0E1 VA: 0x37DFE0
	|-ReadOnlySequence<char>..ctor
	|
	|-RVA: 0x37E760 Offset: 0x37E861 VA: 0x37E760
	|-ReadOnlySequence<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D870 Offset: 0x37D971 VA: 0x37D870
	|-ReadOnlySequence<byte>..ctor
	|
	|-RVA: 0x37DFF0 Offset: 0x37E0F1 VA: 0x37DFF0
	|-ReadOnlySequence<char>..ctor
	|
	|-RVA: 0x37E770 Offset: 0x37E871 VA: 0x37E770
	|-ReadOnlySequence<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ReadOnlyMemory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D880 Offset: 0x37D981 VA: 0x37D880
	|-ReadOnlySequence<byte>..ctor
	|
	|-RVA: 0x37E000 Offset: 0x37E101 VA: 0x37E000
	|-ReadOnlySequence<char>..ctor
	|
	|-RVA: 0x37E780 Offset: 0x37E881 VA: 0x37E780
	|-ReadOnlySequence<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySequence<T> Slice(long start, SequencePosition end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D890 Offset: 0x37D991 VA: 0x37D890
	|-ReadOnlySequence<byte>.Slice
	|
	|-RVA: 0x37E010 Offset: 0x37E111 VA: 0x37E010
	|-ReadOnlySequence<char>.Slice
	|
	|-RVA: 0x37E790 Offset: 0x37E891 VA: 0x37E790
	|-ReadOnlySequence<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySequence<T> Slice(SequencePosition start, long length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D8A0 Offset: 0x37D9A1 VA: 0x37D8A0
	|-ReadOnlySequence<byte>.Slice
	|
	|-RVA: 0x37E020 Offset: 0x37E121 VA: 0x37E020
	|-ReadOnlySequence<char>.Slice
	|
	|-RVA: 0x37E7A0 Offset: 0x37E8A1 VA: 0x37E7A0
	|-ReadOnlySequence<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySequence<T> Slice(int start, SequencePosition end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D8B0 Offset: 0x37D9B1 VA: 0x37D8B0
	|-ReadOnlySequence<byte>.Slice
	|
	|-RVA: 0x37E030 Offset: 0x37E131 VA: 0x37E030
	|-ReadOnlySequence<char>.Slice
	|
	|-RVA: 0x37E7B0 Offset: 0x37E8B1 VA: 0x37E7B0
	|-ReadOnlySequence<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySequence<T> Slice(SequencePosition start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D940 Offset: 0x37DA41 VA: 0x37D940
	|-ReadOnlySequence<byte>.Slice
	|
	|-RVA: 0x37E0C0 Offset: 0x37E1C1 VA: 0x37E0C0
	|-ReadOnlySequence<char>.Slice
	|
	|-RVA: 0x37E840 Offset: 0x37E941 VA: 0x37E840
	|-ReadOnlySequence<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySequence<T> Slice(SequencePosition start, SequencePosition end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D9D0 Offset: 0x37DAD1 VA: 0x37D9D0
	|-ReadOnlySequence<byte>.Slice
	|
	|-RVA: 0x37E150 Offset: 0x37E251 VA: 0x37E150
	|-ReadOnlySequence<char>.Slice
	|
	|-RVA: 0x37E8D0 Offset: 0x37E9D1 VA: 0x37E8D0
	|-ReadOnlySequence<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySequence<T> Slice(SequencePosition start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D9E0 Offset: 0x37DAE1 VA: 0x37D9E0
	|-ReadOnlySequence<byte>.Slice
	|
	|-RVA: 0x37E160 Offset: 0x37E261 VA: 0x37E160
	|-ReadOnlySequence<char>.Slice
	|
	|-RVA: 0x37E8E0 Offset: 0x37E9E1 VA: 0x37E8E0
	|-ReadOnlySequence<object>.Slice
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DA90 Offset: 0x37DB91 VA: 0x37DA90
	|-ReadOnlySequence<byte>.ToString
	|
	|-RVA: 0x37E210 Offset: 0x37E311 VA: 0x37E210
	|-ReadOnlySequence<char>.ToString
	|
	|-RVA: 0x37E990 Offset: 0x37EA91 VA: 0x37E990
	|-ReadOnlySequence<object>.ToString
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySequence.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DAA0 Offset: 0x37DBA1 VA: 0x37DAA0
	|-ReadOnlySequence<byte>.GetEnumerator
	|
	|-RVA: 0x37E220 Offset: 0x37E321 VA: 0x37E220
	|-ReadOnlySequence<char>.GetEnumerator
	|
	|-RVA: 0x37E9A0 Offset: 0x37EAA1 VA: 0x37E9A0
	|-ReadOnlySequence<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public SequencePosition GetPosition(long offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DB70 Offset: 0x37DC71 VA: 0x37DB70
	|-ReadOnlySequence<byte>.GetPosition
	|
	|-RVA: 0x37E2F0 Offset: 0x37E3F1 VA: 0x37E2F0
	|-ReadOnlySequence<char>.GetPosition
	|
	|-RVA: 0x37EA70 Offset: 0x37EB71 VA: 0x37EA70
	|-ReadOnlySequence<object>.GetPosition
	*/

	// RVA: -1 Offset: -1
	public SequencePosition GetPosition(long offset, SequencePosition origin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DC40 Offset: 0x37DD41 VA: 0x37DC40
	|-ReadOnlySequence<byte>.GetPosition
	|
	|-RVA: 0x37E3C0 Offset: 0x37E4C1 VA: 0x37E3C0
	|-ReadOnlySequence<char>.GetPosition
	|
	|-RVA: 0x37EB40 Offset: 0x37EC41 VA: 0x37EB40
	|-ReadOnlySequence<object>.GetPosition
	*/

	// RVA: -1 Offset: -1
	public bool TryGet(ref SequencePosition position, out ReadOnlyMemory<T> memory, bool advance = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DCE0 Offset: 0x37DDE1 VA: 0x37DCE0
	|-ReadOnlySequence<byte>.TryGet
	|
	|-RVA: 0x37E460 Offset: 0x37E561 VA: 0x37E460
	|-ReadOnlySequence<char>.TryGet
	|
	|-RVA: 0x37EBE0 Offset: 0x37ECE1 VA: 0x37EBE0
	|-ReadOnlySequence<object>.TryGet
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetBuffer(in SequencePosition position, out ReadOnlyMemory<T> memory, out SequencePosition next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DD80 Offset: 0x37DE81 VA: 0x37DD80
	|-ReadOnlySequence<byte>.TryGetBuffer
	|
	|-RVA: 0x37E500 Offset: 0x37E601 VA: 0x37E500
	|-ReadOnlySequence<char>.TryGetBuffer
	|
	|-RVA: 0x37EC80 Offset: 0x37ED81 VA: 0x37EC80
	|-ReadOnlySequence<object>.TryGetBuffer
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyMemory<T> GetFirstBuffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DD90 Offset: 0x37DE91 VA: 0x37DD90
	|-ReadOnlySequence<byte>.GetFirstBuffer
	|
	|-RVA: 0x37E510 Offset: 0x37E611 VA: 0x37E510
	|-ReadOnlySequence<char>.GetFirstBuffer
	|
	|-RVA: 0x37EC90 Offset: 0x37ED91 VA: 0x37EC90
	|-ReadOnlySequence<object>.GetFirstBuffer
	*/

	// RVA: -1 Offset: -1
	private SequencePosition Seek(in SequencePosition start, in SequencePosition end, long offset, ExceptionArgument argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DDA0 Offset: 0x37DEA1 VA: 0x37DDA0
	|-ReadOnlySequence<byte>.Seek
	|
	|-RVA: 0x37E520 Offset: 0x37E621 VA: 0x37E520
	|-ReadOnlySequence<char>.Seek
	|
	|-RVA: 0x37ECA0 Offset: 0x37EDA1 VA: 0x37ECA0
	|-ReadOnlySequence<object>.Seek
	*/

	// RVA: -1 Offset: -1
	private static SequencePosition SeekMultiSegment(ReadOnlySequenceSegment<T> currentSegment, object endObject, int endIndex, long offset, ExceptionArgument argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46EC0 Offset: 0x2B46FC1 VA: 0x2B46EC0
	|-ReadOnlySequence<byte>.SeekMultiSegment
	|
	|-RVA: 0x2B4C600 Offset: 0x2B4C701 VA: 0x2B4C600
	|-ReadOnlySequence<char>.SeekMultiSegment
	|
	|-RVA: 0x2B51D40 Offset: 0x2B51E41 VA: 0x2B51D40
	|-ReadOnlySequence<object>.SeekMultiSegment
	*/

	// RVA: -1 Offset: -1
	private void BoundsCheck(in SequencePosition position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DDB0 Offset: 0x37DEB1 VA: 0x37DDB0
	|-ReadOnlySequence<byte>.BoundsCheck
	|
	|-RVA: 0x37E530 Offset: 0x37E631 VA: 0x37E530
	|-ReadOnlySequence<char>.BoundsCheck
	|
	|-RVA: 0x37ECB0 Offset: 0x37EDB1 VA: 0x37ECB0
	|-ReadOnlySequence<object>.BoundsCheck
	*/

	// RVA: -1 Offset: -1
	private void BoundsCheck(uint sliceStartIndex, object sliceStartObject, uint sliceEndIndex, object sliceEndObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DDC0 Offset: 0x37DEC1 VA: 0x37DDC0
	|-ReadOnlySequence<byte>.BoundsCheck
	|
	|-RVA: 0x37E540 Offset: 0x37E641 VA: 0x37E540
	|-ReadOnlySequence<char>.BoundsCheck
	|
	|-RVA: 0x37ECC0 Offset: 0x37EDC1 VA: 0x37ECC0
	|-ReadOnlySequence<object>.BoundsCheck
	*/

	// RVA: -1 Offset: -1
	private ReadOnlySequence.SequenceType<T> GetSequenceType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DDD0 Offset: 0x37DED1 VA: 0x37DDD0
	|-ReadOnlySequence<byte>.GetSequenceType
	|
	|-RVA: 0x37E550 Offset: 0x37E651 VA: 0x37E550
	|-ReadOnlySequence<char>.GetSequenceType
	|
	|-RVA: 0x37ECD0 Offset: 0x37EDD1 VA: 0x37ECD0
	|-ReadOnlySequence<object>.GetSequenceType
	*/

	// RVA: -1 Offset: -1
	private static int GetIndex(in SequencePosition position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B47F20 Offset: 0x2B48021 VA: 0x2B47F20
	|-ReadOnlySequence<byte>.GetIndex
	|
	|-RVA: 0x2B4D660 Offset: 0x2B4D761 VA: 0x2B4D660
	|-ReadOnlySequence<char>.GetIndex
	|
	|-RVA: 0x2B52DA0 Offset: 0x2B52EA1 VA: 0x2B52DA0
	|-ReadOnlySequence<object>.GetIndex
	*/

	// RVA: -1 Offset: -1
	private ReadOnlySequence<T> SliceImpl(in SequencePosition start, in SequencePosition end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DDF0 Offset: 0x37DEF1 VA: 0x37DDF0
	|-ReadOnlySequence<byte>.SliceImpl
	|
	|-RVA: 0x37E570 Offset: 0x37E671 VA: 0x37E570
	|-ReadOnlySequence<char>.SliceImpl
	|
	|-RVA: 0x37ECF0 Offset: 0x37EDF1 VA: 0x37ECF0
	|-ReadOnlySequence<object>.SliceImpl
	*/

	// RVA: -1 Offset: -1
	private long GetLength() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DE00 Offset: 0x37DF01 VA: 0x37DE00
	|-ReadOnlySequence<byte>.GetLength
	|
	|-RVA: 0x37E580 Offset: 0x37E681 VA: 0x37E580
	|-ReadOnlySequence<char>.GetLength
	|
	|-RVA: 0x37ED00 Offset: 0x37EE01 VA: 0x37ED00
	|-ReadOnlySequence<object>.GetLength
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetString(out string text, out int start, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37DE10 Offset: 0x37DF11 VA: 0x37DE10
	|-ReadOnlySequence<byte>.TryGetString
	|
	|-RVA: 0x37E590 Offset: 0x37E691 VA: 0x37E590
	|-ReadOnlySequence<char>.TryGetString
	|
	|-RVA: 0x37ED10 Offset: 0x37EE11 VA: 0x37ED10
	|-ReadOnlySequence<object>.TryGetString
	*/

	// RVA: -1 Offset: -1
	private static bool InRange(uint value, uint start, uint end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B48810 Offset: 0x2B48911 VA: 0x2B48810
	|-ReadOnlySequence<byte>.InRange
	|
	|-RVA: 0x2B4DF50 Offset: 0x2B4E051 VA: 0x2B4DF50
	|-ReadOnlySequence<char>.InRange
	|
	|-RVA: 0x2B53690 Offset: 0x2B53791 VA: 0x2B53690
	|-ReadOnlySequence<object>.InRange
	*/

	// RVA: -1 Offset: -1
	private static bool InRange(ulong value, ulong start, ulong end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B48830 Offset: 0x2B48931 VA: 0x2B48830
	|-ReadOnlySequence<byte>.InRange
	|
	|-RVA: 0x2B4DF70 Offset: 0x2B4E071 VA: 0x2B4DF70
	|-ReadOnlySequence<char>.InRange
	|
	|-RVA: 0x2B536B0 Offset: 0x2B537B1 VA: 0x2B536B0
	|-ReadOnlySequence<object>.InRange
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B48850 Offset: 0x2B48951 VA: 0x2B48850
	|-ReadOnlySequence<byte>..cctor
	|
	|-RVA: 0x2B4DF90 Offset: 0x2B4E091 VA: 0x2B4DF90
	|-ReadOnlySequence<char>..cctor
	|
	|-RVA: 0x2B536D0 Offset: 0x2B537D1 VA: 0x2B536D0
	|-ReadOnlySequence<object>..cctor
	*/
}

