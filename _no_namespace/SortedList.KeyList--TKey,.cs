[DebuggerTypeProxyAttribute] // RVA: 0xBC8E0 Offset: 0xBC9E1 VA: 0xBC8E0
[DebuggerDisplayAttribute] // RVA: 0xBC8E0 Offset: 0xBC9E1 VA: 0xBC8E0
[DefaultMemberAttribute] // RVA: 0xBC8E0 Offset: 0xBC9E1 VA: 0xBC8E0
[Serializable]
private sealed class SortedList.KeyList<TKey, TValue> : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection // TypeDefIndex: 2092
{
	// Fields
	private SortedList<TKey, TValue> _dict; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public TKey Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2400 Offset: 0x2BB2501 VA: 0x2BB2400
	|-SortedList.KeyList<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2440 Offset: 0x2BB2541 VA: 0x2BB2440
	|-SortedList.KeyList<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2460 Offset: 0x2BB2561 VA: 0x2BB2460
	|-SortedList.KeyList<object, object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2470 Offset: 0x2BB2571 VA: 0x2BB2470
	|-SortedList.KeyList<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB24E0 Offset: 0x2BB25E1 VA: 0x2BB24E0
	|-SortedList.KeyList<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2550 Offset: 0x2BB2651 VA: 0x2BB2550
	|-SortedList.KeyList<object, object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TKey[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2580 Offset: 0x2BB2681 VA: 0x2BB2580
	|-SortedList.KeyList<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB25F0 Offset: 0x2BB26F1 VA: 0x2BB25F0
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2790 Offset: 0x2BB2891 VA: 0x2BB2790
	|-SortedList.KeyList<object, object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2800 Offset: 0x2BB2901 VA: 0x2BB2800
	|-SortedList.KeyList<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2830 Offset: 0x2BB2931 VA: 0x2BB2830
	|-SortedList.KeyList<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TKey> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB28A0 Offset: 0x2BB29A1 VA: 0x2BB28A0
	|-SortedList.KeyList<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2910 Offset: 0x2BB2A11 VA: 0x2BB2910
	|-SortedList.KeyList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2980 Offset: 0x2BB2A81 VA: 0x2BB2980
	|-SortedList.KeyList<object, object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2A70 Offset: 0x2BB2B71 VA: 0x2BB2A70
	|-SortedList.KeyList<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2AE0 Offset: 0x2BB2BE1 VA: 0x2BB2AE0
	|-SortedList.KeyList<object, object>.RemoveAt
	*/
}

