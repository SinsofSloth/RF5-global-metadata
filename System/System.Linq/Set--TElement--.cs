internal class Set<TElement> // TypeDefIndex: 2194
{
	// Fields
	private int[] buckets; // 0x0
	private Set.Slot<TElement>[] slots; // 0x0
	private int count; // 0x0
	private int freeList; // 0x0
	private IEqualityComparer<TElement> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TElement> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2447720 Offset: 0x2447821 VA: 0x2447720
	|-Set<int>..ctor
	|
	|-RVA: 0x2447D90 Offset: 0x2447E91 VA: 0x2447D90
	|-Set<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Add(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2447820 Offset: 0x2447921 VA: 0x2447820
	|-Set<int>.Add
	|
	|-RVA: 0x2447E90 Offset: 0x2447F91 VA: 0x2447E90
	|-Set<object>.Add
	*/

	// RVA: -1 Offset: -1
	private bool Find(TElement value, bool add) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2447860 Offset: 0x2447961 VA: 0x2447860
	|-Set<int>.Find
	|
	|-RVA: 0x2447ED0 Offset: 0x2447FD1 VA: 0x2447ED0
	|-Set<object>.Find
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2447B40 Offset: 0x2447C41 VA: 0x2447B40
	|-Set<int>.Resize
	|
	|-RVA: 0x24481C0 Offset: 0x24482C1 VA: 0x24481C0
	|-Set<object>.Resize
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2447CD0 Offset: 0x2447DD1 VA: 0x2447CD0
	|-Set<int>.InternalGetHashCode
	|
	|-RVA: 0x2448350 Offset: 0x2448451 VA: 0x2448350
	|-Set<object>.InternalGetHashCode
	*/
}

