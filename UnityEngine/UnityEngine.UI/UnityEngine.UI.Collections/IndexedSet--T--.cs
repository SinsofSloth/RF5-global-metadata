[DefaultMemberAttribute] // RVA: 0x11A9B0 Offset: 0x11AAB1 VA: 0x11A9B0
internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 4036
{
	// Fields
	private readonly List<T> m_List; // 0x0
	private Dictionary<T, int> m_Dictionary; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9C70 Offset: 0x2AA9D71 VA: 0x2AA9C70
	|-IndexedSet<object>.Add
	|-IndexedSet<Graphic>.Add
	*/

	// RVA: -1 Offset: -1
	public bool AddUnique(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9D00 Offset: 0x2AA9E01 VA: 0x2AA9D00
	|-IndexedSet<object>.AddUnique
	|-IndexedSet<Graphic>.AddUnique
	|-IndexedSet<ICanvasElement>.AddUnique
	|-IndexedSet<IClipper>.AddUnique
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9DD0 Offset: 0x2AA9ED1 VA: 0x2AA9DD0
	|-IndexedSet<object>.Remove
	|-IndexedSet<Graphic>.Remove
	|-IndexedSet<ICanvasElement>.Remove
	|-IndexedSet<IClipper>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9E60 Offset: 0x2AA9F61 VA: 0x2AA9E60
	|-IndexedSet<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9EC0 Offset: 0x2AA9FC1 VA: 0x2AA9EC0
	|-IndexedSet<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9EF0 Offset: 0x2AA9FF1 VA: 0x2AA9EF0
	|-IndexedSet<object>.Clear
	|-IndexedSet<ICanvasElement>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9F50 Offset: 0x2AAA051 VA: 0x2AA9F50
	|-IndexedSet<object>.Contains
	|-IndexedSet<ICanvasElement>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9F80 Offset: 0x2AAA081 VA: 0x2AA9F80
	|-IndexedSet<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9FB0 Offset: 0x2AAA0B1 VA: 0x2AA9FB0
	|-IndexedSet<object>.get_Count
	|-IndexedSet<Graphic>.get_Count
	|-IndexedSet<ICanvasElement>.get_Count
	|-IndexedSet<IClipper>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9FE0 Offset: 0x2AAA0E1 VA: 0x2AA9FE0
	|-IndexedSet<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA9FF0 Offset: 0x2AAA0F1 VA: 0x2AA9FF0
	|-IndexedSet<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAA040 Offset: 0x2AAA141 VA: 0x2AAA040
	|-IndexedSet<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAA0B0 Offset: 0x2AAA1B1 VA: 0x2AAA0B0
	|-IndexedSet<object>.RemoveAt
	|-IndexedSet<ICanvasElement>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAA210 Offset: 0x2AAA311 VA: 0x2AAA210
	|-IndexedSet<object>.get_Item
	|-IndexedSet<ICanvasElement>.get_Item
	|-IndexedSet<IClipper>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAA240 Offset: 0x2AAA341 VA: 0x2AAA240
	|-IndexedSet<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAA300 Offset: 0x2AAA401 VA: 0x2AAA300
	|-IndexedSet<object>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> sortLayoutFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAA430 Offset: 0x2AAA531 VA: 0x2AAA430
	|-IndexedSet<object>.Sort
	|-IndexedSet<ICanvasElement>.Sort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AAA4F0 Offset: 0x2AAA5F1 VA: 0x2AAA4F0
	|-IndexedSet<object>..ctor
	|-IndexedSet<Graphic>..ctor
	|-IndexedSet<ICanvasElement>..ctor
	|-IndexedSet<IClipper>..ctor
	*/
}

