public class LinkedListNodeCache<T> // TypeDefIndex: 4471
{
	// Fields
	private int m_NodesCreated; // 0x0
	private LinkedList<T> m_NodeCache; // 0x0

	// Properties
	internal int CreatedNodeCount { get; }
	internal int CachedNodeCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public LinkedListNode<T> Acquire(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA86E0 Offset: 0x2AA87E1 VA: 0x2AA86E0
	|-LinkedListNodeCache<object>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void Release(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA87C0 Offset: 0x2AA88C1 VA: 0x2AA87C0
	|-LinkedListNodeCache<object>.Release
	*/

	// RVA: -1 Offset: -1
	internal int get_CreatedNodeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA8880 Offset: 0x2AA8981 VA: 0x2AA8880
	|-LinkedListNodeCache<object>.get_CreatedNodeCount
	*/

	// RVA: -1 Offset: -1
	internal int get_CachedNodeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA8890 Offset: 0x2AA8991 VA: 0x2AA8890
	|-LinkedListNodeCache<object>.get_CachedNodeCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA88B0 Offset: 0x2AA89B1 VA: 0x2AA88B0
	|-LinkedListNodeCache<object>..ctor
	*/
}

