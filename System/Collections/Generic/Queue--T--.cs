[DebuggerDisplayAttribute] // RVA: 0xBC630 Offset: 0xBC731 VA: 0xBC630
[DebuggerTypeProxyAttribute] // RVA: 0xBC630 Offset: 0xBC731 VA: 0xBC630
[Serializable]
public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 2077
{
	// Fields
	private T[] _array; // 0x0
	private int _head; // 0x0
	private int _tail; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private const int MinimumGrow = 4;
	private const int GrowFactor = 200;

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB970 Offset: 0x2BABA71 VA: 0x2BAB970
	|-Queue<DamageTextInfo>..ctor
	|
	|-RVA: 0x2BAD110 Offset: 0x2BAD211 VA: 0x2BAD110
	|-Queue<BaseSpriteItemData>..ctor
	|-Queue<ItemData>..ctor
	|-Queue<CFNetwork.GetProxyData>..ctor
	|-Queue<object>..ctor
	|-Queue<Fracturer.SpaceTreeNode>..ctor
	|-Queue<MeshData>..ctor
	|-Queue<WebRequestQueueOperation>..ctor
	|
	|-RVA: 0x2BAC5A0 Offset: 0x2BAC6A1 VA: 0x2BAC5A0
	|-Queue<int>..ctor
	|
	|-RVA: 0x2BADCF0 Offset: 0x2BADDF1 VA: 0x2BADCF0
	|-Queue<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAB9C0 Offset: 0x2BABAC1 VA: 0x2BAB9C0
	|-Queue<DamageTextInfo>..ctor
	|
	|-RVA: 0x2BAC5F0 Offset: 0x2BAC6F1 VA: 0x2BAC5F0
	|-Queue<int>..ctor
	|
	|-RVA: 0x2BAD160 Offset: 0x2BAD261 VA: 0x2BAD160
	|-Queue<object>..ctor
	|-Queue<Transform>..ctor
	|
	|-RVA: 0x2BADD40 Offset: 0x2BADE41 VA: 0x2BADD40
	|-Queue<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BABAD0 Offset: 0x2BABBD1 VA: 0x2BABAD0
	|-Queue<DamageTextInfo>..ctor
	|
	|-RVA: 0x2BAC700 Offset: 0x2BAC801 VA: 0x2BAC700
	|-Queue<int>..ctor
	|
	|-RVA: 0x2BAD270 Offset: 0x2BAD371 VA: 0x2BAD270
	|-Queue<object>..ctor
	|-Queue<string>..ctor
	|
	|-RVA: 0x2BADE50 Offset: 0x2BADF51 VA: 0x2BADE50
	|-Queue<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BABBC0 Offset: 0x2BABCC1 VA: 0x2BABBC0
	|-Queue<DamageTextInfo>.get_Count
	|
	|-RVA: 0x2BAD360 Offset: 0x2BAD461 VA: 0x2BAD360
	|-Queue<BaseSpriteItemData>.get_Count
	|-Queue<ItemData>.get_Count
	|-Queue<CFNetwork.GetProxyData>.get_Count
	|-Queue<object>.get_Count
	|-Queue<string>.get_Count
	|-Queue<Fracturer.SpaceTreeNode>.get_Count
	|-Queue<MeshData>.get_Count
	|-Queue<WebRequestQueueOperation>.get_Count
	|-Queue<Transform>.get_Count
	|
	|-RVA: 0x2BAC7F0 Offset: 0x2BAC8F1 VA: 0x2BAC7F0
	|-Queue<int>.get_Count
	|
	|-RVA: 0x2BADF40 Offset: 0x2BAE041 VA: 0x2BADF40
	|-Queue<EventDispatcher.EventRecord>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BABBD0 Offset: 0x2BABCD1 VA: 0x2BABBD0
	|-Queue<DamageTextInfo>.Clear
	|
	|-RVA: 0x2BAD370 Offset: 0x2BAD471 VA: 0x2BAD370
	|-Queue<ItemData>.Clear
	|-Queue<object>.Clear
	|-Queue<Transform>.Clear
	|
	|-RVA: 0x2BAC800 Offset: 0x2BAC901 VA: 0x2BAC800
	|-Queue<int>.Clear
	|
	|-RVA: 0x2BADF50 Offset: 0x2BAE051 VA: 0x2BADF50
	|-Queue<EventDispatcher.EventRecord>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BABBF0 Offset: 0x2BABCF1 VA: 0x2BABBF0
	|-Queue<DamageTextInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2BAC820 Offset: 0x2BAC921 VA: 0x2BAC820
	|-Queue<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2BAD3F0 Offset: 0x2BAD4F1 VA: 0x2BAD3F0
	|-Queue<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2BADFD0 Offset: 0x2BAE0D1 VA: 0x2BADFD0
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BABEF0 Offset: 0x2BABFF1 VA: 0x2BABEF0
	|-Queue<DamageTextInfo>.Enqueue
	|
	|-RVA: 0x2BAD6F0 Offset: 0x2BAD7F1 VA: 0x2BAD6F0
	|-Queue<BaseSpriteItemData>.Enqueue
	|-Queue<ItemData>.Enqueue
	|-Queue<CFNetwork.GetProxyData>.Enqueue
	|-Queue<object>.Enqueue
	|-Queue<Fracturer.SpaceTreeNode>.Enqueue
	|-Queue<MeshData>.Enqueue
	|-Queue<WebRequestQueueOperation>.Enqueue
	|-Queue<Transform>.Enqueue
	|
	|-RVA: 0x2BACB20 Offset: 0x2BACC21 VA: 0x2BACB20
	|-Queue<int>.Enqueue
	|
	|-RVA: 0x2BAE2D0 Offset: 0x2BAE3D1 VA: 0x2BAE2D0
	|-Queue<EventDispatcher.EventRecord>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public Queue.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAC000 Offset: 0x2BAC101 VA: 0x2BAC000
	|-Queue<DamageTextInfo>.GetEnumerator
	|
	|-RVA: 0x2BACBF0 Offset: 0x2BACCF1 VA: 0x2BACBF0
	|-Queue<int>.GetEnumerator
	|
	|-RVA: 0x2BAD7D0 Offset: 0x2BAD8D1 VA: 0x2BAD7D0
	|-Queue<object>.GetEnumerator
	|
	|-RVA: 0x2BAE3C0 Offset: 0x2BAE4C1 VA: 0x2BAE3C0
	|-Queue<EventDispatcher.EventRecord>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAC070 Offset: 0x2BAC171 VA: 0x2BAC070
	|-Queue<DamageTextInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BACC60 Offset: 0x2BACD61 VA: 0x2BACC60
	|-Queue<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BAD830 Offset: 0x2BAD931 VA: 0x2BAD830
	|-Queue<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BAE420 Offset: 0x2BAE521 VA: 0x2BAE420
	|-Queue<EventDispatcher.EventRecord>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAC120 Offset: 0x2BAC221 VA: 0x2BAC120
	|-Queue<DamageTextInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BACCF0 Offset: 0x2BACDF1 VA: 0x2BACCF0
	|-Queue<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BAD8C0 Offset: 0x2BAD9C1 VA: 0x2BAD8C0
	|-Queue<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BAE4B0 Offset: 0x2BAE5B1 VA: 0x2BAE4B0
	|-Queue<EventDispatcher.EventRecord>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAC1D0 Offset: 0x2BAC2D1 VA: 0x2BAC1D0
	|-Queue<DamageTextInfo>.Dequeue
	|
	|-RVA: 0x2BAD950 Offset: 0x2BADA51 VA: 0x2BAD950
	|-Queue<BaseSpriteItemData>.Dequeue
	|-Queue<ItemData>.Dequeue
	|-Queue<string>.Dequeue
	|-Queue<Fracturer.SpaceTreeNode>.Dequeue
	|-Queue<MeshData>.Dequeue
	|-Queue<WebRequestQueueOperation>.Dequeue
	|-Queue<Transform>.Dequeue
	|-Queue<CFNetwork.GetProxyData>.Dequeue
	|-Queue<object>.Dequeue
	|
	|-RVA: 0x2BACD80 Offset: 0x2BACE81 VA: 0x2BACD80
	|-Queue<int>.Dequeue
	|
	|-RVA: 0x2BAE540 Offset: 0x2BAE641 VA: 0x2BAE540
	|-Queue<EventDispatcher.EventRecord>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BADA10 Offset: 0x2BADB11 VA: 0x2BADA10
	|-Queue<string>.Peek
	|-Queue<object>.Peek
	|
	|-RVA: 0x2BAC2B0 Offset: 0x2BAC3B1 VA: 0x2BAC2B0
	|-Queue<DamageTextInfo>.Peek
	|
	|-RVA: 0x2BACE30 Offset: 0x2BACF31 VA: 0x2BACE30
	|-Queue<int>.Peek
	|
	|-RVA: 0x2BAE610 Offset: 0x2BAE711 VA: 0x2BAE610
	|-Queue<EventDispatcher.EventRecord>.Peek
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BADA80 Offset: 0x2BADB81 VA: 0x2BADA80
	|-Queue<MeshData>.ToArray
	|-Queue<object>.ToArray
	|
	|-RVA: 0x2BAC330 Offset: 0x2BAC431 VA: 0x2BAC330
	|-Queue<DamageTextInfo>.ToArray
	|
	|-RVA: 0x2BACEA0 Offset: 0x2BACFA1 VA: 0x2BACEA0
	|-Queue<int>.ToArray
	|
	|-RVA: 0x2BAE680 Offset: 0x2BAE781 VA: 0x2BAE680
	|-Queue<EventDispatcher.EventRecord>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAC410 Offset: 0x2BAC511 VA: 0x2BAC410
	|-Queue<DamageTextInfo>.SetCapacity
	|
	|-RVA: 0x2BACF80 Offset: 0x2BAD081 VA: 0x2BACF80
	|-Queue<int>.SetCapacity
	|
	|-RVA: 0x2BADB60 Offset: 0x2BADC61 VA: 0x2BADB60
	|-Queue<object>.SetCapacity
	|
	|-RVA: 0x2BAE760 Offset: 0x2BAE861 VA: 0x2BAE760
	|-Queue<EventDispatcher.EventRecord>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	private void MoveNext(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAC500 Offset: 0x2BAC601 VA: 0x2BAC500
	|-Queue<DamageTextInfo>.MoveNext
	|
	|-RVA: 0x2BAD070 Offset: 0x2BAD171 VA: 0x2BAD070
	|-Queue<int>.MoveNext
	|
	|-RVA: 0x2BADC50 Offset: 0x2BADD51 VA: 0x2BADC50
	|-Queue<object>.MoveNext
	|
	|-RVA: 0x2BAE850 Offset: 0x2BAE951 VA: 0x2BAE850
	|-Queue<EventDispatcher.EventRecord>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void ThrowForEmptyQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAC530 Offset: 0x2BAC631 VA: 0x2BAC530
	|-Queue<DamageTextInfo>.ThrowForEmptyQueue
	|
	|-RVA: 0x2BAD0A0 Offset: 0x2BAD1A1 VA: 0x2BAD0A0
	|-Queue<int>.ThrowForEmptyQueue
	|
	|-RVA: 0x2BADC80 Offset: 0x2BADD81 VA: 0x2BADC80
	|-Queue<object>.ThrowForEmptyQueue
	|
	|-RVA: 0x2BAE880 Offset: 0x2BAE981 VA: 0x2BAE880
	|-Queue<EventDispatcher.EventRecord>.ThrowForEmptyQueue
	*/
}

