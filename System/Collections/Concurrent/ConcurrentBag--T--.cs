[DebuggerTypeProxyAttribute] // RVA: 0xBCAE0 Offset: 0xBCBE1 VA: 0xBCAE0
[DebuggerDisplayAttribute] // RVA: 0xBCAE0 Offset: 0xBCBE1 VA: 0xBCAE0
[Serializable]
public class ConcurrentBag<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 2106
{
	// Fields
	private ThreadLocal<ConcurrentBag.WorkStealingQueue<T>> _locals; // 0x0
	private ConcurrentBag.WorkStealingQueue<T> _workStealingQueues; // 0x0

	// Properties
	public int Count { get; }
	private int DangerousCount { get; }
	private object GlobalQueuesLock { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54290 Offset: 0x2B54391 VA: 0x2B54290
	|-ConcurrentBag<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54310 Offset: 0x2B54411 VA: 0x2B54310
	|-ConcurrentBag<object>.Add
	*/

	// RVA: -1 Offset: -1
	private ConcurrentBag.WorkStealingQueue<T> GetCurrentThreadWorkStealingQueue(bool forceCreate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54370 Offset: 0x2B54471 VA: 0x2B54370
	|-ConcurrentBag<object>.GetCurrentThreadWorkStealingQueue
	*/

	// RVA: -1 Offset: -1
	private ConcurrentBag.WorkStealingQueue<T> CreateWorkStealingQueueForCurrentThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B543F0 Offset: 0x2B544F1 VA: 0x2B543F0
	|-ConcurrentBag<object>.CreateWorkStealingQueueForCurrentThread
	*/

	// RVA: -1 Offset: -1
	private ConcurrentBag.WorkStealingQueue<T> GetUnownedWorkStealingQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B545A0 Offset: 0x2B546A1 VA: 0x2B545A0
	|-ConcurrentBag<object>.GetUnownedWorkStealingQueue
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B545F0 Offset: 0x2B546F1 VA: 0x2B545F0
	|-ConcurrentBag<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private int CopyFromEachQueueToArray(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B548D0 Offset: 0x2B549D1 VA: 0x2B548D0
	|-ConcurrentBag<object>.CopyFromEachQueueToArray
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54950 Offset: 0x2B54A51 VA: 0x2B54950
	|-ConcurrentBag<object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54A90 Offset: 0x2B54B91 VA: 0x2B54A90
	|-ConcurrentBag<object>.ToArray
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54C30 Offset: 0x2B54D31 VA: 0x2B54C30
	|-ConcurrentBag<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54CC0 Offset: 0x2B54DC1 VA: 0x2B54CC0
	|-ConcurrentBag<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54CF0 Offset: 0x2B54DF1 VA: 0x2B54CF0
	|-ConcurrentBag<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	private int get_DangerousCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54DD0 Offset: 0x2B54ED1 VA: 0x2B54DD0
	|-ConcurrentBag<object>.get_DangerousCount
	*/

	// RVA: -1 Offset: -1
	private object get_GlobalQueuesLock() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54E70 Offset: 0x2B54F71 VA: 0x2B54E70
	|-ConcurrentBag<object>.get_GlobalQueuesLock
	*/

	// RVA: -1 Offset: -1
	private void FreezeBag(ref bool lockTaken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54E80 Offset: 0x2B54F81 VA: 0x2B54E80
	|-ConcurrentBag<object>.FreezeBag
	*/

	// RVA: -1 Offset: -1
	private void UnfreezeBag(bool lockTaken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B54F50 Offset: 0x2B55051 VA: 0x2B54F50
	|-ConcurrentBag<object>.UnfreezeBag
	*/
}

