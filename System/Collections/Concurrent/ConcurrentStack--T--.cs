[DebuggerTypeProxyAttribute] // RVA: 0xB3760 Offset: 0xB3861 VA: 0xB3760
[DebuggerDisplayAttribute] // RVA: 0xB3760 Offset: 0xB3861 VA: 0xB3760
[Serializable]
public class ConcurrentStack<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 1411
{
	// Fields
	private ConcurrentStack.Node<T> _head; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5C300 Offset: 0x2B5C401 VA: 0x2B5C300
	|-ConcurrentStack<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5C320 Offset: 0x2B5C421 VA: 0x2B5C320
	|-ConcurrentStack<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitializeFromCollection(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5C3E0 Offset: 0x2B5C4E1 VA: 0x2B5C3E0
	|-ConcurrentStack<object>.InitializeFromCollection
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5C710 Offset: 0x2B5C811 VA: 0x2B5C710
	|-ConcurrentStack<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5C750 Offset: 0x2B5C851 VA: 0x2B5C750
	|-ConcurrentStack<object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	private List<T> ToList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5C880 Offset: 0x2B5C981 VA: 0x2B5C880
	|-ConcurrentStack<object>.ToList
	*/

	// RVA: -1 Offset: -1
	private List<T> ToList(ConcurrentStack.Node<T> curr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5C8D0 Offset: 0x2B5C9D1 VA: 0x2B5C8D0
	|-ConcurrentStack<object>.ToList
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5C970 Offset: 0x2B5CA71 VA: 0x2B5C970
	|-ConcurrentStack<object>.GetEnumerator
	*/

	[IteratorStateMachineAttribute] // RVA: 0xB9C50 Offset: 0xB9D51 VA: 0xB9C50
	// RVA: -1 Offset: -1
	private IEnumerator<T> GetEnumerator(ConcurrentStack.Node<T> head) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5C9C0 Offset: 0x2B5CAC1 VA: 0x2B5C9C0
	|-ConcurrentStack<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5CA50 Offset: 0x2B5CB51 VA: 0x2B5CA50
	|-ConcurrentStack<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

