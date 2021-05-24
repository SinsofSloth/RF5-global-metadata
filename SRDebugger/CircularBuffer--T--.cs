[DefaultMemberAttribute] // RVA: 0x13B1C0 Offset: 0x13B2C1 VA: 0x13B1C0
public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T> // TypeDefIndex: 5525
{
	// Fields
	private readonly T[] _buffer; // 0x0
	private int _end; // 0x0
	private int _count; // 0x0
	private int _start; // 0x0

	// Properties
	public int Capacity { get; }
	public bool IsFull { get; }
	public bool IsEmpty { get; }
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7780 Offset: 0x2CA7881 VA: 0x2CA7780
	|-CircularBuffer<ConsoleEntry>..ctor
	|-CircularBuffer<object>..ctor
	|
	|-RVA: 0x2CA6770 Offset: 0x2CA6871 VA: 0x2CA6770
	|-CircularBuffer<ProfilerFrame>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA67F0 Offset: 0x2CA68F1 VA: 0x2CA67F0
	|-CircularBuffer<ProfilerFrame>..ctor
	|
	|-RVA: 0x2CA7800 Offset: 0x2CA7901 VA: 0x2CA7800
	|-CircularBuffer<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6980 Offset: 0x2CA6A81 VA: 0x2CA6980
	|-CircularBuffer<ProfilerFrame>.get_Capacity
	|
	|-RVA: 0x2CA7990 Offset: 0x2CA7A91 VA: 0x2CA7990
	|-CircularBuffer<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public bool get_IsFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA79B0 Offset: 0x2CA7AB1 VA: 0x2CA79B0
	|-CircularBuffer<ConsoleEntry>.get_IsFull
	|-CircularBuffer<object>.get_IsFull
	|
	|-RVA: 0x2CA69A0 Offset: 0x2CA6AA1 VA: 0x2CA69A0
	|-CircularBuffer<ProfilerFrame>.get_IsFull
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6A10 Offset: 0x2CA6B11 VA: 0x2CA6A10
	|-CircularBuffer<ProfilerFrame>.get_IsEmpty
	|
	|-RVA: 0x2CA7A20 Offset: 0x2CA7B21 VA: 0x2CA7A20
	|-CircularBuffer<object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7A60 Offset: 0x2CA7B61 VA: 0x2CA7A60
	|-CircularBuffer<ConsoleEntry>.get_Count
	|-CircularBuffer<object>.get_Count
	|
	|-RVA: 0x2CA6A50 Offset: 0x2CA6B51 VA: 0x2CA6A50
	|-CircularBuffer<ProfilerFrame>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7A70 Offset: 0x2CA7B71 VA: 0x2CA7A70
	|-CircularBuffer<ConsoleEntry>.get_Item
	|-CircularBuffer<object>.get_Item
	|
	|-RVA: 0x2CA6A60 Offset: 0x2CA6B61 VA: 0x2CA6A60
	|-CircularBuffer<ProfilerFrame>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6BF0 Offset: 0x2CA6CF1 VA: 0x2CA6BF0
	|-CircularBuffer<ProfilerFrame>.set_Item
	|
	|-RVA: 0x2CA7C00 Offset: 0x2CA7D01 VA: 0x2CA7C00
	|-CircularBuffer<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7DA0 Offset: 0x2CA7EA1 VA: 0x2CA7DA0
	|-CircularBuffer<ConsoleEntry>.Clear
	|-CircularBuffer<object>.Clear
	|
	|-RVA: 0x2CA6DA0 Offset: 0x2CA6EA1 VA: 0x2CA6DA0
	|-CircularBuffer<ProfilerFrame>.Clear
	*/

	[IteratorStateMachineAttribute] // RVA: 0x13CCA0 Offset: 0x13CDA1 VA: 0x13CCA0
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6DB0 Offset: 0x2CA6EB1 VA: 0x2CA6DB0
	|-CircularBuffer<ProfilerFrame>.GetEnumerator
	|
	|-RVA: 0x2CA7DB0 Offset: 0x2CA7EB1 VA: 0x2CA7DB0
	|-CircularBuffer<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6E40 Offset: 0x2CA6F41 VA: 0x2CA6E40
	|-CircularBuffer<ProfilerFrame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CA7E40 Offset: 0x2CA7F41 VA: 0x2CA7E40
	|-CircularBuffer<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Front() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7E70 Offset: 0x2CA7F71 VA: 0x2CA7E70
	|-CircularBuffer<ConsoleEntry>.Front
	|-CircularBuffer<object>.Front
	|
	|-RVA: 0x2CA6E70 Offset: 0x2CA6F71 VA: 0x2CA6E70
	|-CircularBuffer<ProfilerFrame>.Front
	*/

	// RVA: -1 Offset: -1
	public T Back() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6F20 Offset: 0x2CA7021 VA: 0x2CA6F20
	|-CircularBuffer<ProfilerFrame>.Back
	|
	|-RVA: 0x2CA7F20 Offset: 0x2CA8021 VA: 0x2CA7F20
	|-CircularBuffer<object>.Back
	*/

	// RVA: -1 Offset: -1
	public void PushBack(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7FD0 Offset: 0x2CA80D1 VA: 0x2CA7FD0
	|-CircularBuffer<ConsoleEntry>.PushBack
	|-CircularBuffer<object>.PushBack
	|
	|-RVA: 0x2CA6FE0 Offset: 0x2CA70E1 VA: 0x2CA6FE0
	|-CircularBuffer<ProfilerFrame>.PushBack
	*/

	// RVA: -1 Offset: -1
	public void PushFront(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA70B0 Offset: 0x2CA71B1 VA: 0x2CA70B0
	|-CircularBuffer<ProfilerFrame>.PushFront
	|
	|-RVA: 0x2CA80A0 Offset: 0x2CA81A1 VA: 0x2CA80A0
	|-CircularBuffer<object>.PushFront
	*/

	// RVA: -1 Offset: -1
	public void PopBack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA71A0 Offset: 0x2CA72A1 VA: 0x2CA71A0
	|-CircularBuffer<ProfilerFrame>.PopBack
	|
	|-RVA: 0x2CA8190 Offset: 0x2CA8291 VA: 0x2CA8190
	|-CircularBuffer<object>.PopBack
	*/

	// RVA: -1 Offset: -1
	public void PopFront() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA8270 Offset: 0x2CA8371 VA: 0x2CA8270
	|-CircularBuffer<ConsoleEntry>.PopFront
	|-CircularBuffer<object>.PopFront
	|
	|-RVA: 0x2CA7270 Offset: 0x2CA7371 VA: 0x2CA7270
	|-CircularBuffer<ProfilerFrame>.PopFront
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7340 Offset: 0x2CA7441 VA: 0x2CA7340
	|-CircularBuffer<ProfilerFrame>.ToArray
	|
	|-RVA: 0x2CA8350 Offset: 0x2CA8451 VA: 0x2CA8350
	|-CircularBuffer<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfEmpty(string message = "Cannot access an empty buffer.") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA74D0 Offset: 0x2CA75D1 VA: 0x2CA74D0
	|-CircularBuffer<ProfilerFrame>.ThrowIfEmpty
	|
	|-RVA: 0x2CA84E0 Offset: 0x2CA85E1 VA: 0x2CA84E0
	|-CircularBuffer<object>.ThrowIfEmpty
	*/

	// RVA: -1 Offset: -1
	private void Increment(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7580 Offset: 0x2CA7681 VA: 0x2CA7580
	|-CircularBuffer<ProfilerFrame>.Increment
	|
	|-RVA: 0x2CA8590 Offset: 0x2CA8691 VA: 0x2CA8590
	|-CircularBuffer<object>.Increment
	*/

	// RVA: -1 Offset: -1
	private void Decrement(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA75D0 Offset: 0x2CA76D1 VA: 0x2CA75D0
	|-CircularBuffer<ProfilerFrame>.Decrement
	|
	|-RVA: 0x2CA85E0 Offset: 0x2CA86E1 VA: 0x2CA85E0
	|-CircularBuffer<object>.Decrement
	*/

	// RVA: -1 Offset: -1
	private int InternalIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7620 Offset: 0x2CA7721 VA: 0x2CA7620
	|-CircularBuffer<ProfilerFrame>.InternalIndex
	|
	|-RVA: 0x2CA8630 Offset: 0x2CA8731 VA: 0x2CA8630
	|-CircularBuffer<object>.InternalIndex
	*/

	// RVA: -1 Offset: -1
	private ArraySegment<T> ArrayOne() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA76A0 Offset: 0x2CA77A1 VA: 0x2CA76A0
	|-CircularBuffer<ProfilerFrame>.ArrayOne
	|
	|-RVA: 0x2CA86B0 Offset: 0x2CA87B1 VA: 0x2CA86B0
	|-CircularBuffer<object>.ArrayOne
	*/

	// RVA: -1 Offset: -1
	private ArraySegment<T> ArrayTwo() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7710 Offset: 0x2CA7811 VA: 0x2CA7710
	|-CircularBuffer<ProfilerFrame>.ArrayTwo
	|
	|-RVA: 0x2CA8720 Offset: 0x2CA8821 VA: 0x2CA8720
	|-CircularBuffer<object>.ArrayTwo
	*/
}

[DefaultMemberAttribute] // RVA: 0x13B1C0 Offset: 0x13B2C1 VA: 0x13B1C0
public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T> // TypeDefIndex: 5525
{
	// Fields
	private readonly T[] _buffer; // 0x0
	private int _end; // 0x0
	private int _count; // 0x0
	private int _start; // 0x0

	// Properties
	public int Capacity { get; }
	public bool IsFull { get; }
	public bool IsEmpty { get; }
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7780 Offset: 0x2CA7881 VA: 0x2CA7780
	|-CircularBuffer<ConsoleEntry>..ctor
	|-CircularBuffer<object>..ctor
	|
	|-RVA: 0x2CA6770 Offset: 0x2CA6871 VA: 0x2CA6770
	|-CircularBuffer<ProfilerFrame>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA67F0 Offset: 0x2CA68F1 VA: 0x2CA67F0
	|-CircularBuffer<ProfilerFrame>..ctor
	|
	|-RVA: 0x2CA7800 Offset: 0x2CA7901 VA: 0x2CA7800
	|-CircularBuffer<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6980 Offset: 0x2CA6A81 VA: 0x2CA6980
	|-CircularBuffer<ProfilerFrame>.get_Capacity
	|
	|-RVA: 0x2CA7990 Offset: 0x2CA7A91 VA: 0x2CA7990
	|-CircularBuffer<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public bool get_IsFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA79B0 Offset: 0x2CA7AB1 VA: 0x2CA79B0
	|-CircularBuffer<ConsoleEntry>.get_IsFull
	|-CircularBuffer<object>.get_IsFull
	|
	|-RVA: 0x2CA69A0 Offset: 0x2CA6AA1 VA: 0x2CA69A0
	|-CircularBuffer<ProfilerFrame>.get_IsFull
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6A10 Offset: 0x2CA6B11 VA: 0x2CA6A10
	|-CircularBuffer<ProfilerFrame>.get_IsEmpty
	|
	|-RVA: 0x2CA7A20 Offset: 0x2CA7B21 VA: 0x2CA7A20
	|-CircularBuffer<object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7A60 Offset: 0x2CA7B61 VA: 0x2CA7A60
	|-CircularBuffer<ConsoleEntry>.get_Count
	|-CircularBuffer<object>.get_Count
	|
	|-RVA: 0x2CA6A50 Offset: 0x2CA6B51 VA: 0x2CA6A50
	|-CircularBuffer<ProfilerFrame>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7A70 Offset: 0x2CA7B71 VA: 0x2CA7A70
	|-CircularBuffer<ConsoleEntry>.get_Item
	|-CircularBuffer<object>.get_Item
	|
	|-RVA: 0x2CA6A60 Offset: 0x2CA6B61 VA: 0x2CA6A60
	|-CircularBuffer<ProfilerFrame>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6BF0 Offset: 0x2CA6CF1 VA: 0x2CA6BF0
	|-CircularBuffer<ProfilerFrame>.set_Item
	|
	|-RVA: 0x2CA7C00 Offset: 0x2CA7D01 VA: 0x2CA7C00
	|-CircularBuffer<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7DA0 Offset: 0x2CA7EA1 VA: 0x2CA7DA0
	|-CircularBuffer<ConsoleEntry>.Clear
	|-CircularBuffer<object>.Clear
	|
	|-RVA: 0x2CA6DA0 Offset: 0x2CA6EA1 VA: 0x2CA6DA0
	|-CircularBuffer<ProfilerFrame>.Clear
	*/

	[IteratorStateMachineAttribute] // RVA: 0x13CCA0 Offset: 0x13CDA1 VA: 0x13CCA0
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6DB0 Offset: 0x2CA6EB1 VA: 0x2CA6DB0
	|-CircularBuffer<ProfilerFrame>.GetEnumerator
	|
	|-RVA: 0x2CA7DB0 Offset: 0x2CA7EB1 VA: 0x2CA7DB0
	|-CircularBuffer<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6E40 Offset: 0x2CA6F41 VA: 0x2CA6E40
	|-CircularBuffer<ProfilerFrame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CA7E40 Offset: 0x2CA7F41 VA: 0x2CA7E40
	|-CircularBuffer<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Front() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7E70 Offset: 0x2CA7F71 VA: 0x2CA7E70
	|-CircularBuffer<ConsoleEntry>.Front
	|-CircularBuffer<object>.Front
	|
	|-RVA: 0x2CA6E70 Offset: 0x2CA6F71 VA: 0x2CA6E70
	|-CircularBuffer<ProfilerFrame>.Front
	*/

	// RVA: -1 Offset: -1
	public T Back() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6F20 Offset: 0x2CA7021 VA: 0x2CA6F20
	|-CircularBuffer<ProfilerFrame>.Back
	|
	|-RVA: 0x2CA7F20 Offset: 0x2CA8021 VA: 0x2CA7F20
	|-CircularBuffer<object>.Back
	*/

	// RVA: -1 Offset: -1
	public void PushBack(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7FD0 Offset: 0x2CA80D1 VA: 0x2CA7FD0
	|-CircularBuffer<ConsoleEntry>.PushBack
	|-CircularBuffer<object>.PushBack
	|
	|-RVA: 0x2CA6FE0 Offset: 0x2CA70E1 VA: 0x2CA6FE0
	|-CircularBuffer<ProfilerFrame>.PushBack
	*/

	// RVA: -1 Offset: -1
	public void PushFront(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA70B0 Offset: 0x2CA71B1 VA: 0x2CA70B0
	|-CircularBuffer<ProfilerFrame>.PushFront
	|
	|-RVA: 0x2CA80A0 Offset: 0x2CA81A1 VA: 0x2CA80A0
	|-CircularBuffer<object>.PushFront
	*/

	// RVA: -1 Offset: -1
	public void PopBack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA71A0 Offset: 0x2CA72A1 VA: 0x2CA71A0
	|-CircularBuffer<ProfilerFrame>.PopBack
	|
	|-RVA: 0x2CA8190 Offset: 0x2CA8291 VA: 0x2CA8190
	|-CircularBuffer<object>.PopBack
	*/

	// RVA: -1 Offset: -1
	public void PopFront() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA8270 Offset: 0x2CA8371 VA: 0x2CA8270
	|-CircularBuffer<ConsoleEntry>.PopFront
	|-CircularBuffer<object>.PopFront
	|
	|-RVA: 0x2CA7270 Offset: 0x2CA7371 VA: 0x2CA7270
	|-CircularBuffer<ProfilerFrame>.PopFront
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7340 Offset: 0x2CA7441 VA: 0x2CA7340
	|-CircularBuffer<ProfilerFrame>.ToArray
	|
	|-RVA: 0x2CA8350 Offset: 0x2CA8451 VA: 0x2CA8350
	|-CircularBuffer<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfEmpty(string message = "Cannot access an empty buffer.") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA74D0 Offset: 0x2CA75D1 VA: 0x2CA74D0
	|-CircularBuffer<ProfilerFrame>.ThrowIfEmpty
	|
	|-RVA: 0x2CA84E0 Offset: 0x2CA85E1 VA: 0x2CA84E0
	|-CircularBuffer<object>.ThrowIfEmpty
	*/

	// RVA: -1 Offset: -1
	private void Increment(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7580 Offset: 0x2CA7681 VA: 0x2CA7580
	|-CircularBuffer<ProfilerFrame>.Increment
	|
	|-RVA: 0x2CA8590 Offset: 0x2CA8691 VA: 0x2CA8590
	|-CircularBuffer<object>.Increment
	*/

	// RVA: -1 Offset: -1
	private void Decrement(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA75D0 Offset: 0x2CA76D1 VA: 0x2CA75D0
	|-CircularBuffer<ProfilerFrame>.Decrement
	|
	|-RVA: 0x2CA85E0 Offset: 0x2CA86E1 VA: 0x2CA85E0
	|-CircularBuffer<object>.Decrement
	*/

	// RVA: -1 Offset: -1
	private int InternalIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7620 Offset: 0x2CA7721 VA: 0x2CA7620
	|-CircularBuffer<ProfilerFrame>.InternalIndex
	|
	|-RVA: 0x2CA8630 Offset: 0x2CA8731 VA: 0x2CA8630
	|-CircularBuffer<object>.InternalIndex
	*/

	// RVA: -1 Offset: -1
	private ArraySegment<T> ArrayOne() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA76A0 Offset: 0x2CA77A1 VA: 0x2CA76A0
	|-CircularBuffer<ProfilerFrame>.ArrayOne
	|
	|-RVA: 0x2CA86B0 Offset: 0x2CA87B1 VA: 0x2CA86B0
	|-CircularBuffer<object>.ArrayOne
	*/

	// RVA: -1 Offset: -1
	private ArraySegment<T> ArrayTwo() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7710 Offset: 0x2CA7811 VA: 0x2CA7710
	|-CircularBuffer<ProfilerFrame>.ArrayTwo
	|
	|-RVA: 0x2CA8720 Offset: 0x2CA8821 VA: 0x2CA8720
	|-CircularBuffer<object>.ArrayTwo
	*/
}

[DefaultMemberAttribute] // RVA: 0x13B1C0 Offset: 0x13B2C1 VA: 0x13B1C0
public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T> // TypeDefIndex: 5525
{
	// Fields
	private readonly T[] _buffer; // 0x0
	private int _end; // 0x0
	private int _count; // 0x0
	private int _start; // 0x0

	// Properties
	public int Capacity { get; }
	public bool IsFull { get; }
	public bool IsEmpty { get; }
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7780 Offset: 0x2CA7881 VA: 0x2CA7780
	|-CircularBuffer<ConsoleEntry>..ctor
	|-CircularBuffer<object>..ctor
	|
	|-RVA: 0x2CA6770 Offset: 0x2CA6871 VA: 0x2CA6770
	|-CircularBuffer<ProfilerFrame>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA67F0 Offset: 0x2CA68F1 VA: 0x2CA67F0
	|-CircularBuffer<ProfilerFrame>..ctor
	|
	|-RVA: 0x2CA7800 Offset: 0x2CA7901 VA: 0x2CA7800
	|-CircularBuffer<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6980 Offset: 0x2CA6A81 VA: 0x2CA6980
	|-CircularBuffer<ProfilerFrame>.get_Capacity
	|
	|-RVA: 0x2CA7990 Offset: 0x2CA7A91 VA: 0x2CA7990
	|-CircularBuffer<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public bool get_IsFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA79B0 Offset: 0x2CA7AB1 VA: 0x2CA79B0
	|-CircularBuffer<ConsoleEntry>.get_IsFull
	|-CircularBuffer<object>.get_IsFull
	|
	|-RVA: 0x2CA69A0 Offset: 0x2CA6AA1 VA: 0x2CA69A0
	|-CircularBuffer<ProfilerFrame>.get_IsFull
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6A10 Offset: 0x2CA6B11 VA: 0x2CA6A10
	|-CircularBuffer<ProfilerFrame>.get_IsEmpty
	|
	|-RVA: 0x2CA7A20 Offset: 0x2CA7B21 VA: 0x2CA7A20
	|-CircularBuffer<object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7A60 Offset: 0x2CA7B61 VA: 0x2CA7A60
	|-CircularBuffer<ConsoleEntry>.get_Count
	|-CircularBuffer<object>.get_Count
	|
	|-RVA: 0x2CA6A50 Offset: 0x2CA6B51 VA: 0x2CA6A50
	|-CircularBuffer<ProfilerFrame>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7A70 Offset: 0x2CA7B71 VA: 0x2CA7A70
	|-CircularBuffer<ConsoleEntry>.get_Item
	|-CircularBuffer<object>.get_Item
	|
	|-RVA: 0x2CA6A60 Offset: 0x2CA6B61 VA: 0x2CA6A60
	|-CircularBuffer<ProfilerFrame>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6BF0 Offset: 0x2CA6CF1 VA: 0x2CA6BF0
	|-CircularBuffer<ProfilerFrame>.set_Item
	|
	|-RVA: 0x2CA7C00 Offset: 0x2CA7D01 VA: 0x2CA7C00
	|-CircularBuffer<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7DA0 Offset: 0x2CA7EA1 VA: 0x2CA7DA0
	|-CircularBuffer<ConsoleEntry>.Clear
	|-CircularBuffer<object>.Clear
	|
	|-RVA: 0x2CA6DA0 Offset: 0x2CA6EA1 VA: 0x2CA6DA0
	|-CircularBuffer<ProfilerFrame>.Clear
	*/

	[IteratorStateMachineAttribute] // RVA: 0x13CCA0 Offset: 0x13CDA1 VA: 0x13CCA0
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6DB0 Offset: 0x2CA6EB1 VA: 0x2CA6DB0
	|-CircularBuffer<ProfilerFrame>.GetEnumerator
	|
	|-RVA: 0x2CA7DB0 Offset: 0x2CA7EB1 VA: 0x2CA7DB0
	|-CircularBuffer<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6E40 Offset: 0x2CA6F41 VA: 0x2CA6E40
	|-CircularBuffer<ProfilerFrame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CA7E40 Offset: 0x2CA7F41 VA: 0x2CA7E40
	|-CircularBuffer<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Front() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7E70 Offset: 0x2CA7F71 VA: 0x2CA7E70
	|-CircularBuffer<ConsoleEntry>.Front
	|-CircularBuffer<object>.Front
	|
	|-RVA: 0x2CA6E70 Offset: 0x2CA6F71 VA: 0x2CA6E70
	|-CircularBuffer<ProfilerFrame>.Front
	*/

	// RVA: -1 Offset: -1
	public T Back() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6F20 Offset: 0x2CA7021 VA: 0x2CA6F20
	|-CircularBuffer<ProfilerFrame>.Back
	|
	|-RVA: 0x2CA7F20 Offset: 0x2CA8021 VA: 0x2CA7F20
	|-CircularBuffer<object>.Back
	*/

	// RVA: -1 Offset: -1
	public void PushBack(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7FD0 Offset: 0x2CA80D1 VA: 0x2CA7FD0
	|-CircularBuffer<ConsoleEntry>.PushBack
	|-CircularBuffer<object>.PushBack
	|
	|-RVA: 0x2CA6FE0 Offset: 0x2CA70E1 VA: 0x2CA6FE0
	|-CircularBuffer<ProfilerFrame>.PushBack
	*/

	// RVA: -1 Offset: -1
	public void PushFront(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA70B0 Offset: 0x2CA71B1 VA: 0x2CA70B0
	|-CircularBuffer<ProfilerFrame>.PushFront
	|
	|-RVA: 0x2CA80A0 Offset: 0x2CA81A1 VA: 0x2CA80A0
	|-CircularBuffer<object>.PushFront
	*/

	// RVA: -1 Offset: -1
	public void PopBack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA71A0 Offset: 0x2CA72A1 VA: 0x2CA71A0
	|-CircularBuffer<ProfilerFrame>.PopBack
	|
	|-RVA: 0x2CA8190 Offset: 0x2CA8291 VA: 0x2CA8190
	|-CircularBuffer<object>.PopBack
	*/

	// RVA: -1 Offset: -1
	public void PopFront() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA8270 Offset: 0x2CA8371 VA: 0x2CA8270
	|-CircularBuffer<ConsoleEntry>.PopFront
	|-CircularBuffer<object>.PopFront
	|
	|-RVA: 0x2CA7270 Offset: 0x2CA7371 VA: 0x2CA7270
	|-CircularBuffer<ProfilerFrame>.PopFront
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7340 Offset: 0x2CA7441 VA: 0x2CA7340
	|-CircularBuffer<ProfilerFrame>.ToArray
	|
	|-RVA: 0x2CA8350 Offset: 0x2CA8451 VA: 0x2CA8350
	|-CircularBuffer<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfEmpty(string message = "Cannot access an empty buffer.") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA74D0 Offset: 0x2CA75D1 VA: 0x2CA74D0
	|-CircularBuffer<ProfilerFrame>.ThrowIfEmpty
	|
	|-RVA: 0x2CA84E0 Offset: 0x2CA85E1 VA: 0x2CA84E0
	|-CircularBuffer<object>.ThrowIfEmpty
	*/

	// RVA: -1 Offset: -1
	private void Increment(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7580 Offset: 0x2CA7681 VA: 0x2CA7580
	|-CircularBuffer<ProfilerFrame>.Increment
	|
	|-RVA: 0x2CA8590 Offset: 0x2CA8691 VA: 0x2CA8590
	|-CircularBuffer<object>.Increment
	*/

	// RVA: -1 Offset: -1
	private void Decrement(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA75D0 Offset: 0x2CA76D1 VA: 0x2CA75D0
	|-CircularBuffer<ProfilerFrame>.Decrement
	|
	|-RVA: 0x2CA85E0 Offset: 0x2CA86E1 VA: 0x2CA85E0
	|-CircularBuffer<object>.Decrement
	*/

	// RVA: -1 Offset: -1
	private int InternalIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7620 Offset: 0x2CA7721 VA: 0x2CA7620
	|-CircularBuffer<ProfilerFrame>.InternalIndex
	|
	|-RVA: 0x2CA8630 Offset: 0x2CA8731 VA: 0x2CA8630
	|-CircularBuffer<object>.InternalIndex
	*/

	// RVA: -1 Offset: -1
	private ArraySegment<T> ArrayOne() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA76A0 Offset: 0x2CA77A1 VA: 0x2CA76A0
	|-CircularBuffer<ProfilerFrame>.ArrayOne
	|
	|-RVA: 0x2CA86B0 Offset: 0x2CA87B1 VA: 0x2CA86B0
	|-CircularBuffer<object>.ArrayOne
	*/

	// RVA: -1 Offset: -1
	private ArraySegment<T> ArrayTwo() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7710 Offset: 0x2CA7811 VA: 0x2CA7710
	|-CircularBuffer<ProfilerFrame>.ArrayTwo
	|
	|-RVA: 0x2CA8720 Offset: 0x2CA8821 VA: 0x2CA8720
	|-CircularBuffer<object>.ArrayTwo
	*/
}

[DefaultMemberAttribute] // RVA: 0x13B1C0 Offset: 0x13B2C1 VA: 0x13B1C0
public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T> // TypeDefIndex: 5525
{
	// Fields
	private readonly T[] _buffer; // 0x0
	private int _end; // 0x0
	private int _count; // 0x0
	private int _start; // 0x0

	// Properties
	public int Capacity { get; }
	public bool IsFull { get; }
	public bool IsEmpty { get; }
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7780 Offset: 0x2CA7881 VA: 0x2CA7780
	|-CircularBuffer<ConsoleEntry>..ctor
	|-CircularBuffer<object>..ctor
	|
	|-RVA: 0x2CA6770 Offset: 0x2CA6871 VA: 0x2CA6770
	|-CircularBuffer<ProfilerFrame>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA67F0 Offset: 0x2CA68F1 VA: 0x2CA67F0
	|-CircularBuffer<ProfilerFrame>..ctor
	|
	|-RVA: 0x2CA7800 Offset: 0x2CA7901 VA: 0x2CA7800
	|-CircularBuffer<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6980 Offset: 0x2CA6A81 VA: 0x2CA6980
	|-CircularBuffer<ProfilerFrame>.get_Capacity
	|
	|-RVA: 0x2CA7990 Offset: 0x2CA7A91 VA: 0x2CA7990
	|-CircularBuffer<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public bool get_IsFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA79B0 Offset: 0x2CA7AB1 VA: 0x2CA79B0
	|-CircularBuffer<ConsoleEntry>.get_IsFull
	|-CircularBuffer<object>.get_IsFull
	|
	|-RVA: 0x2CA69A0 Offset: 0x2CA6AA1 VA: 0x2CA69A0
	|-CircularBuffer<ProfilerFrame>.get_IsFull
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6A10 Offset: 0x2CA6B11 VA: 0x2CA6A10
	|-CircularBuffer<ProfilerFrame>.get_IsEmpty
	|
	|-RVA: 0x2CA7A20 Offset: 0x2CA7B21 VA: 0x2CA7A20
	|-CircularBuffer<object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7A60 Offset: 0x2CA7B61 VA: 0x2CA7A60
	|-CircularBuffer<ConsoleEntry>.get_Count
	|-CircularBuffer<object>.get_Count
	|
	|-RVA: 0x2CA6A50 Offset: 0x2CA6B51 VA: 0x2CA6A50
	|-CircularBuffer<ProfilerFrame>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7A70 Offset: 0x2CA7B71 VA: 0x2CA7A70
	|-CircularBuffer<ConsoleEntry>.get_Item
	|-CircularBuffer<object>.get_Item
	|
	|-RVA: 0x2CA6A60 Offset: 0x2CA6B61 VA: 0x2CA6A60
	|-CircularBuffer<ProfilerFrame>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6BF0 Offset: 0x2CA6CF1 VA: 0x2CA6BF0
	|-CircularBuffer<ProfilerFrame>.set_Item
	|
	|-RVA: 0x2CA7C00 Offset: 0x2CA7D01 VA: 0x2CA7C00
	|-CircularBuffer<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7DA0 Offset: 0x2CA7EA1 VA: 0x2CA7DA0
	|-CircularBuffer<ConsoleEntry>.Clear
	|-CircularBuffer<object>.Clear
	|
	|-RVA: 0x2CA6DA0 Offset: 0x2CA6EA1 VA: 0x2CA6DA0
	|-CircularBuffer<ProfilerFrame>.Clear
	*/

	[IteratorStateMachineAttribute] // RVA: 0x13CCA0 Offset: 0x13CDA1 VA: 0x13CCA0
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6DB0 Offset: 0x2CA6EB1 VA: 0x2CA6DB0
	|-CircularBuffer<ProfilerFrame>.GetEnumerator
	|
	|-RVA: 0x2CA7DB0 Offset: 0x2CA7EB1 VA: 0x2CA7DB0
	|-CircularBuffer<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6E40 Offset: 0x2CA6F41 VA: 0x2CA6E40
	|-CircularBuffer<ProfilerFrame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CA7E40 Offset: 0x2CA7F41 VA: 0x2CA7E40
	|-CircularBuffer<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Front() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7E70 Offset: 0x2CA7F71 VA: 0x2CA7E70
	|-CircularBuffer<ConsoleEntry>.Front
	|-CircularBuffer<object>.Front
	|
	|-RVA: 0x2CA6E70 Offset: 0x2CA6F71 VA: 0x2CA6E70
	|-CircularBuffer<ProfilerFrame>.Front
	*/

	// RVA: -1 Offset: -1
	public T Back() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6F20 Offset: 0x2CA7021 VA: 0x2CA6F20
	|-CircularBuffer<ProfilerFrame>.Back
	|
	|-RVA: 0x2CA7F20 Offset: 0x2CA8021 VA: 0x2CA7F20
	|-CircularBuffer<object>.Back
	*/

	// RVA: -1 Offset: -1
	public void PushBack(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7FD0 Offset: 0x2CA80D1 VA: 0x2CA7FD0
	|-CircularBuffer<ConsoleEntry>.PushBack
	|-CircularBuffer<object>.PushBack
	|
	|-RVA: 0x2CA6FE0 Offset: 0x2CA70E1 VA: 0x2CA6FE0
	|-CircularBuffer<ProfilerFrame>.PushBack
	*/

	// RVA: -1 Offset: -1
	public void PushFront(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA70B0 Offset: 0x2CA71B1 VA: 0x2CA70B0
	|-CircularBuffer<ProfilerFrame>.PushFront
	|
	|-RVA: 0x2CA80A0 Offset: 0x2CA81A1 VA: 0x2CA80A0
	|-CircularBuffer<object>.PushFront
	*/

	// RVA: -1 Offset: -1
	public void PopBack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA71A0 Offset: 0x2CA72A1 VA: 0x2CA71A0
	|-CircularBuffer<ProfilerFrame>.PopBack
	|
	|-RVA: 0x2CA8190 Offset: 0x2CA8291 VA: 0x2CA8190
	|-CircularBuffer<object>.PopBack
	*/

	// RVA: -1 Offset: -1
	public void PopFront() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA8270 Offset: 0x2CA8371 VA: 0x2CA8270
	|-CircularBuffer<ConsoleEntry>.PopFront
	|-CircularBuffer<object>.PopFront
	|
	|-RVA: 0x2CA7270 Offset: 0x2CA7371 VA: 0x2CA7270
	|-CircularBuffer<ProfilerFrame>.PopFront
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7340 Offset: 0x2CA7441 VA: 0x2CA7340
	|-CircularBuffer<ProfilerFrame>.ToArray
	|
	|-RVA: 0x2CA8350 Offset: 0x2CA8451 VA: 0x2CA8350
	|-CircularBuffer<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfEmpty(string message = "Cannot access an empty buffer.") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA74D0 Offset: 0x2CA75D1 VA: 0x2CA74D0
	|-CircularBuffer<ProfilerFrame>.ThrowIfEmpty
	|
	|-RVA: 0x2CA84E0 Offset: 0x2CA85E1 VA: 0x2CA84E0
	|-CircularBuffer<object>.ThrowIfEmpty
	*/

	// RVA: -1 Offset: -1
	private void Increment(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7580 Offset: 0x2CA7681 VA: 0x2CA7580
	|-CircularBuffer<ProfilerFrame>.Increment
	|
	|-RVA: 0x2CA8590 Offset: 0x2CA8691 VA: 0x2CA8590
	|-CircularBuffer<object>.Increment
	*/

	// RVA: -1 Offset: -1
	private void Decrement(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA75D0 Offset: 0x2CA76D1 VA: 0x2CA75D0
	|-CircularBuffer<ProfilerFrame>.Decrement
	|
	|-RVA: 0x2CA85E0 Offset: 0x2CA86E1 VA: 0x2CA85E0
	|-CircularBuffer<object>.Decrement
	*/

	// RVA: -1 Offset: -1
	private int InternalIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7620 Offset: 0x2CA7721 VA: 0x2CA7620
	|-CircularBuffer<ProfilerFrame>.InternalIndex
	|
	|-RVA: 0x2CA8630 Offset: 0x2CA8731 VA: 0x2CA8630
	|-CircularBuffer<object>.InternalIndex
	*/

	// RVA: -1 Offset: -1
	private ArraySegment<T> ArrayOne() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA76A0 Offset: 0x2CA77A1 VA: 0x2CA76A0
	|-CircularBuffer<ProfilerFrame>.ArrayOne
	|
	|-RVA: 0x2CA86B0 Offset: 0x2CA87B1 VA: 0x2CA86B0
	|-CircularBuffer<object>.ArrayOne
	*/

	// RVA: -1 Offset: -1
	private ArraySegment<T> ArrayTwo() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7710 Offset: 0x2CA7811 VA: 0x2CA7710
	|-CircularBuffer<ProfilerFrame>.ArrayTwo
	|
	|-RVA: 0x2CA8720 Offset: 0x2CA8821 VA: 0x2CA8720
	|-CircularBuffer<object>.ArrayTwo
	*/
}

[DefaultMemberAttribute] // RVA: 0x13B1C0 Offset: 0x13B2C1 VA: 0x13B1C0
public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T> // TypeDefIndex: 5525
{
	// Fields
	private readonly T[] _buffer; // 0x0
	private int _end; // 0x0
	private int _count; // 0x0
	private int _start; // 0x0

	// Properties
	public int Capacity { get; }
	public bool IsFull { get; }
	public bool IsEmpty { get; }
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7780 Offset: 0x2CA7881 VA: 0x2CA7780
	|-CircularBuffer<ConsoleEntry>..ctor
	|-CircularBuffer<object>..ctor
	|
	|-RVA: 0x2CA6770 Offset: 0x2CA6871 VA: 0x2CA6770
	|-CircularBuffer<ProfilerFrame>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA67F0 Offset: 0x2CA68F1 VA: 0x2CA67F0
	|-CircularBuffer<ProfilerFrame>..ctor
	|
	|-RVA: 0x2CA7800 Offset: 0x2CA7901 VA: 0x2CA7800
	|-CircularBuffer<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6980 Offset: 0x2CA6A81 VA: 0x2CA6980
	|-CircularBuffer<ProfilerFrame>.get_Capacity
	|
	|-RVA: 0x2CA7990 Offset: 0x2CA7A91 VA: 0x2CA7990
	|-CircularBuffer<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public bool get_IsFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA79B0 Offset: 0x2CA7AB1 VA: 0x2CA79B0
	|-CircularBuffer<ConsoleEntry>.get_IsFull
	|-CircularBuffer<object>.get_IsFull
	|
	|-RVA: 0x2CA69A0 Offset: 0x2CA6AA1 VA: 0x2CA69A0
	|-CircularBuffer<ProfilerFrame>.get_IsFull
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6A10 Offset: 0x2CA6B11 VA: 0x2CA6A10
	|-CircularBuffer<ProfilerFrame>.get_IsEmpty
	|
	|-RVA: 0x2CA7A20 Offset: 0x2CA7B21 VA: 0x2CA7A20
	|-CircularBuffer<object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7A60 Offset: 0x2CA7B61 VA: 0x2CA7A60
	|-CircularBuffer<ConsoleEntry>.get_Count
	|-CircularBuffer<object>.get_Count
	|
	|-RVA: 0x2CA6A50 Offset: 0x2CA6B51 VA: 0x2CA6A50
	|-CircularBuffer<ProfilerFrame>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7A70 Offset: 0x2CA7B71 VA: 0x2CA7A70
	|-CircularBuffer<ConsoleEntry>.get_Item
	|-CircularBuffer<object>.get_Item
	|
	|-RVA: 0x2CA6A60 Offset: 0x2CA6B61 VA: 0x2CA6A60
	|-CircularBuffer<ProfilerFrame>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6BF0 Offset: 0x2CA6CF1 VA: 0x2CA6BF0
	|-CircularBuffer<ProfilerFrame>.set_Item
	|
	|-RVA: 0x2CA7C00 Offset: 0x2CA7D01 VA: 0x2CA7C00
	|-CircularBuffer<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7DA0 Offset: 0x2CA7EA1 VA: 0x2CA7DA0
	|-CircularBuffer<ConsoleEntry>.Clear
	|-CircularBuffer<object>.Clear
	|
	|-RVA: 0x2CA6DA0 Offset: 0x2CA6EA1 VA: 0x2CA6DA0
	|-CircularBuffer<ProfilerFrame>.Clear
	*/

	[IteratorStateMachineAttribute] // RVA: 0x13CCA0 Offset: 0x13CDA1 VA: 0x13CCA0
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6DB0 Offset: 0x2CA6EB1 VA: 0x2CA6DB0
	|-CircularBuffer<ProfilerFrame>.GetEnumerator
	|
	|-RVA: 0x2CA7DB0 Offset: 0x2CA7EB1 VA: 0x2CA7DB0
	|-CircularBuffer<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6E40 Offset: 0x2CA6F41 VA: 0x2CA6E40
	|-CircularBuffer<ProfilerFrame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CA7E40 Offset: 0x2CA7F41 VA: 0x2CA7E40
	|-CircularBuffer<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Front() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7E70 Offset: 0x2CA7F71 VA: 0x2CA7E70
	|-CircularBuffer<ConsoleEntry>.Front
	|-CircularBuffer<object>.Front
	|
	|-RVA: 0x2CA6E70 Offset: 0x2CA6F71 VA: 0x2CA6E70
	|-CircularBuffer<ProfilerFrame>.Front
	*/

	// RVA: -1 Offset: -1
	public T Back() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6F20 Offset: 0x2CA7021 VA: 0x2CA6F20
	|-CircularBuffer<ProfilerFrame>.Back
	|
	|-RVA: 0x2CA7F20 Offset: 0x2CA8021 VA: 0x2CA7F20
	|-CircularBuffer<object>.Back
	*/

	// RVA: -1 Offset: -1
	public void PushBack(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7FD0 Offset: 0x2CA80D1 VA: 0x2CA7FD0
	|-CircularBuffer<ConsoleEntry>.PushBack
	|-CircularBuffer<object>.PushBack
	|
	|-RVA: 0x2CA6FE0 Offset: 0x2CA70E1 VA: 0x2CA6FE0
	|-CircularBuffer<ProfilerFrame>.PushBack
	*/

	// RVA: -1 Offset: -1
	public void PushFront(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA70B0 Offset: 0x2CA71B1 VA: 0x2CA70B0
	|-CircularBuffer<ProfilerFrame>.PushFront
	|
	|-RVA: 0x2CA80A0 Offset: 0x2CA81A1 VA: 0x2CA80A0
	|-CircularBuffer<object>.PushFront
	*/

	// RVA: -1 Offset: -1
	public void PopBack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA71A0 Offset: 0x2CA72A1 VA: 0x2CA71A0
	|-CircularBuffer<ProfilerFrame>.PopBack
	|
	|-RVA: 0x2CA8190 Offset: 0x2CA8291 VA: 0x2CA8190
	|-CircularBuffer<object>.PopBack
	*/

	// RVA: -1 Offset: -1
	public void PopFront() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA8270 Offset: 0x2CA8371 VA: 0x2CA8270
	|-CircularBuffer<ConsoleEntry>.PopFront
	|-CircularBuffer<object>.PopFront
	|
	|-RVA: 0x2CA7270 Offset: 0x2CA7371 VA: 0x2CA7270
	|-CircularBuffer<ProfilerFrame>.PopFront
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7340 Offset: 0x2CA7441 VA: 0x2CA7340
	|-CircularBuffer<ProfilerFrame>.ToArray
	|
	|-RVA: 0x2CA8350 Offset: 0x2CA8451 VA: 0x2CA8350
	|-CircularBuffer<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfEmpty(string message = "Cannot access an empty buffer.") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA74D0 Offset: 0x2CA75D1 VA: 0x2CA74D0
	|-CircularBuffer<ProfilerFrame>.ThrowIfEmpty
	|
	|-RVA: 0x2CA84E0 Offset: 0x2CA85E1 VA: 0x2CA84E0
	|-CircularBuffer<object>.ThrowIfEmpty
	*/

	// RVA: -1 Offset: -1
	private void Increment(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7580 Offset: 0x2CA7681 VA: 0x2CA7580
	|-CircularBuffer<ProfilerFrame>.Increment
	|
	|-RVA: 0x2CA8590 Offset: 0x2CA8691 VA: 0x2CA8590
	|-CircularBuffer<object>.Increment
	*/

	// RVA: -1 Offset: -1
	private void Decrement(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA75D0 Offset: 0x2CA76D1 VA: 0x2CA75D0
	|-CircularBuffer<ProfilerFrame>.Decrement
	|
	|-RVA: 0x2CA85E0 Offset: 0x2CA86E1 VA: 0x2CA85E0
	|-CircularBuffer<object>.Decrement
	*/

	// RVA: -1 Offset: -1
	private int InternalIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7620 Offset: 0x2CA7721 VA: 0x2CA7620
	|-CircularBuffer<ProfilerFrame>.InternalIndex
	|
	|-RVA: 0x2CA8630 Offset: 0x2CA8731 VA: 0x2CA8630
	|-CircularBuffer<object>.InternalIndex
	*/

	// RVA: -1 Offset: -1
	private ArraySegment<T> ArrayOne() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA76A0 Offset: 0x2CA77A1 VA: 0x2CA76A0
	|-CircularBuffer<ProfilerFrame>.ArrayOne
	|
	|-RVA: 0x2CA86B0 Offset: 0x2CA87B1 VA: 0x2CA86B0
	|-CircularBuffer<object>.ArrayOne
	*/

	// RVA: -1 Offset: -1
	private ArraySegment<T> ArrayTwo() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA7710 Offset: 0x2CA7811 VA: 0x2CA7710
	|-CircularBuffer<ProfilerFrame>.ArrayTwo
	|
	|-RVA: 0x2CA8720 Offset: 0x2CA8821 VA: 0x2CA8720
	|-CircularBuffer<object>.ArrayTwo
	*/
}

