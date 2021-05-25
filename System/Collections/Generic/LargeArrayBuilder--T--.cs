internal struct LargeArrayBuilder<T> // TypeDefIndex: 2739
{
	// Fields
	private readonly int _maxCapacity; // 0x0
	private T[] _first; // 0x0
	private ArrayBuilder<T[]> _buffers; // 0x0
	private T[] _current; // 0x0
	private int _index; // 0x0
	private int _count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(bool initialize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309460 Offset: 0x309561 VA: 0x309460
	|-LargeArrayBuilder<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int maxCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309470 Offset: 0x309571 VA: 0x309470
	|-LargeArrayBuilder<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309520 Offset: 0x309621 VA: 0x309520
	|-LargeArrayBuilder<object>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309530 Offset: 0x309631 VA: 0x309530
	|-LargeArrayBuilder<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public T[] GetBuffer(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309540 Offset: 0x309641 VA: 0x309540
	|-LargeArrayBuilder<object>.GetBuffer
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3095F0 Offset: 0x3096F1 VA: 0x3095F0
	|-LargeArrayBuilder<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	public bool TryMove(out T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309600 Offset: 0x309701 VA: 0x309600
	|-LargeArrayBuilder<object>.TryMove
	*/

	// RVA: -1 Offset: -1
	private void AllocateBuffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309650 Offset: 0x309751 VA: 0x309650
	|-LargeArrayBuilder<object>.AllocateBuffer
	*/
}

