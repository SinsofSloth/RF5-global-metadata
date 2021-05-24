[DebuggerDisplayAttribute] // RVA: 0xB3600 Offset: 0xB3701 VA: 0xB3600
[DebuggerTypeProxyAttribute] // RVA: 0xB3600 Offset: 0xB3701 VA: 0xB3600
[Serializable]
public class ConcurrentQueue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 1406
{
	// Fields
	private object _crossSegmentLock; // 0x0
	private ConcurrentQueue.Segment<T> _tail; // 0x0
	private ConcurrentQueue.Segment<T> _head; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5AAB0 Offset: 0x2B5ABB1 VA: 0x2B5AAB0
	|-ConcurrentQueue<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5ABA0 Offset: 0x2B5ACA1 VA: 0x2B5ABA0
	|-ConcurrentQueue<object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5ACD0 Offset: 0x2B5ADD1 VA: 0x2B5ACD0
	|-ConcurrentQueue<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5AD70 Offset: 0x2B5AE71 VA: 0x2B5AD70
	|-ConcurrentQueue<object>.ToArray
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5B190 Offset: 0x2B5B291 VA: 0x2B5B190
	|-ConcurrentQueue<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	private static int GetCount(ConcurrentQueue.Segment<T> s, int head, int tail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5B410 Offset: 0x2B5B511 VA: 0x2B5B410
	|-ConcurrentQueue<object>.GetCount
	*/

	// RVA: -1 Offset: -1
	private static long GetCount(ConcurrentQueue.Segment<T> head, int headHead, ConcurrentQueue.Segment<T> tail, int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5B4E0 Offset: 0x2B5B5E1 VA: 0x2B5B4E0
	|-ConcurrentQueue<object>.GetCount
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5B6B0 Offset: 0x2B5B7B1 VA: 0x2B5B6B0
	|-ConcurrentQueue<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5BA30 Offset: 0x2B5BB31 VA: 0x2B5BA30
	|-ConcurrentQueue<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void SnapForObservation(out ConcurrentQueue.Segment<T> head, out int headHead, out ConcurrentQueue.Segment<T> tail, out int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5BAB0 Offset: 0x2B5BBB1 VA: 0x2B5BAB0
	|-ConcurrentQueue<object>.SnapForObservation
	*/

	// RVA: -1 Offset: -1
	private T GetItemWhenAvailable(ConcurrentQueue.Segment<T> segment, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5BC70 Offset: 0x2B5BD71 VA: 0x2B5BC70
	|-ConcurrentQueue<object>.GetItemWhenAvailable
	*/

	[IteratorStateMachineAttribute] // RVA: 0xB9B90 Offset: 0xB9C91 VA: 0xB9B90
	// RVA: -1 Offset: -1
	private IEnumerator<T> Enumerate(ConcurrentQueue.Segment<T> head, int headHead, ConcurrentQueue.Segment<T> tail, int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5BD60 Offset: 0x2B5BE61 VA: 0x2B5BD60
	|-ConcurrentQueue<object>.Enumerate
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5BE30 Offset: 0x2B5BF31 VA: 0x2B5BE30
	|-ConcurrentQueue<object>.Enqueue
	*/

	// RVA: -1 Offset: -1
	private void EnqueueSlow(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5BEC0 Offset: 0x2B5BFC1 VA: 0x2B5BEC0
	|-ConcurrentQueue<object>.EnqueueSlow
	*/
}

