[DebuggerTypeProxyAttribute] // RVA: 0xBC830 Offset: 0xBC931 VA: 0xBC830
[DebuggerDisplayAttribute] // RVA: 0xBC830 Offset: 0xBC931 VA: 0xBC830
[DefaultMemberAttribute] // RVA: 0xBC830 Offset: 0xBC931 VA: 0xBC830
[Serializable]
public class SortedList<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 2089
{
	// Fields
	private TKey[] keys; // 0x0
	private TValue[] values; // 0x0
	private int _size; // 0x0
	private int version; // 0x0
	private IComparer<TKey> comparer; // 0x0
	private SortedList.KeyList<TKey, TValue> keyList; // 0x0

	// Properties
	public int Capacity { set; }
	public int Count { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	public TValue Item { get; set; }
	private object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2E70 Offset: 0x2BB2F71 VA: 0x2BB2E70
	|-SortedList<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2F10 Offset: 0x2BB3011 VA: 0x2BB2F10
	|-SortedList<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB3080 Offset: 0x2BB3181 VA: 0x2BB3080
	|-SortedList<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB31D0 Offset: 0x2BB32D1 VA: 0x2BB31D0
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB3200 Offset: 0x2BB3301 VA: 0x2BB3200
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB32C0 Offset: 0x2BB33C1 VA: 0x2BB32C0
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB33B0 Offset: 0x2BB34B1 VA: 0x2BB33B0
	|-SortedList<object, object>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB35B0 Offset: 0x2BB36B1 VA: 0x2BB35B0
	|-SortedList<object, object>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB3860 Offset: 0x2BB3961 VA: 0x2BB3860
	|-SortedList<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB3870 Offset: 0x2BB3971 VA: 0x2BB3870
	|-SortedList<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB38A0 Offset: 0x2BB39A1 VA: 0x2BB38A0
	|-SortedList<object, object>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1
	private SortedList.KeyList<TKey, TValue> GetKeyListHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB38D0 Offset: 0x2BB39D1 VA: 0x2BB38D0
	|-SortedList<object, object>.GetKeyListHelper
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB3970 Offset: 0x2BB3A71 VA: 0x2BB3970
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB3980 Offset: 0x2BB3A81 VA: 0x2BB3980
	|-SortedList<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB39D0 Offset: 0x2BB3AD1 VA: 0x2BB39D0
	|-SortedList<object, object>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB3AB0 Offset: 0x2BB3BB1 VA: 0x2BB3AB0
	|-SortedList<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB3AF0 Offset: 0x2BB3BF1 VA: 0x2BB3AF0
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB3D60 Offset: 0x2BB3E61 VA: 0x2BB3D60
	|-SortedList<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB42F0 Offset: 0x2BB43F1 VA: 0x2BB42F0
	|-SortedList<object, object>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4340 Offset: 0x2BB4441 VA: 0x2BB4340
	|-SortedList<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB43E0 Offset: 0x2BB44E1 VA: 0x2BB43E0
	|-SortedList<object, object>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4480 Offset: 0x2BB4581 VA: 0x2BB4480
	|-SortedList<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private TKey GetKey(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4520 Offset: 0x2BB4621 VA: 0x2BB4520
	|-SortedList<object, object>.GetKey
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4610 Offset: 0x2BB4711 VA: 0x2BB4610
	|-SortedList<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB46E0 Offset: 0x2BB47E1 VA: 0x2BB46E0
	|-SortedList<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4820 Offset: 0x2BB4921 VA: 0x2BB4820
	|-SortedList<object, object>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4910 Offset: 0x2BB4A11 VA: 0x2BB4910
	|-SortedList<object, object>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1
	public int IndexOfKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4B80 Offset: 0x2BB4C81 VA: 0x2BB4B80
	|-SortedList<object, object>.IndexOfKey
	*/

	// RVA: -1 Offset: -1
	private void Insert(int index, TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4C40 Offset: 0x2BB4D41 VA: 0x2BB4C40
	|-SortedList<object, object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4D80 Offset: 0x2BB4E81 VA: 0x2BB4D80
	|-SortedList<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4E10 Offset: 0x2BB4F11 VA: 0x2BB4E10
	|-SortedList<object, object>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB4F90 Offset: 0x2BB5091 VA: 0x2BB4F90
	|-SortedList<object, object>.IsCompatibleKey
	*/
}

