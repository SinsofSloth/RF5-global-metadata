private sealed class ConcurrentBag.WorkStealingQueue<T> // TypeDefIndex: 2107
{
	// Fields
	private int _headIndex; // 0x0
	private int _tailIndex; // 0x0
	private T[] _array; // 0x0
	private int _mask; // 0x0
	private int _addTakeCount; // 0x0
	private int _stealCount; // 0x0
	internal int _currentOp; // 0x0
	internal bool _frozen; // 0x0
	internal readonly ConcurrentBag.WorkStealingQueue<T> _nextQueue; // 0x0
	internal readonly int _ownerThreadId; // 0x0

	// Properties
	internal int DangerousCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentBag.WorkStealingQueue<T> nextQueue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B53A20 Offset: 0x2B53B21 VA: 0x2B53A20
	|-ConcurrentBag.WorkStealingQueue<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void LocalPush(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B53AC0 Offset: 0x2B53BC1 VA: 0x2B53AC0
	|-ConcurrentBag.WorkStealingQueue<object>.LocalPush
	*/

	// RVA: -1 Offset: -1
	internal int DangerousCopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54170 Offset: 0x2B54271 VA: 0x2B54170
	|-ConcurrentBag.WorkStealingQueue<object>.DangerousCopyTo
	*/

	// RVA: -1 Offset: -1
	internal int get_DangerousCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54280 Offset: 0x2B54381 VA: 0x2B54280
	|-ConcurrentBag.WorkStealingQueue<object>.get_DangerousCount
	*/
}

