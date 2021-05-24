[DefaultMemberAttribute] // RVA: 0xBC6C0 Offset: 0xBC7C1 VA: 0xBC6C0
[DebuggerDisplayAttribute] // RVA: 0xBC6C0 Offset: 0xBC7C1 VA: 0xBC6C0
[DebuggerTypeProxyAttribute] // RVA: 0xBC6C0 Offset: 0xBC7C1 VA: 0xBC6C0
[Serializable]
public class SortedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 2080
{
	// Fields
	private SortedDictionary.KeyCollection<TKey, TValue> _keys; // 0x0
	private TreeSet<KeyValuePair<TKey, TValue>> _set; // 0x0

	// Properties
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	public TValue Item { get; set; }
	public int Count { get; }
	public SortedDictionary.KeyCollection<TKey, TValue> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0500 Offset: 0x2BB0601 VA: 0x2BB0500
	|-SortedDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0530 Offset: 0x2BB0631 VA: 0x2BB0530
	|-SortedDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0600 Offset: 0x2BB0701 VA: 0x2BB0600
	|-SortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0630 Offset: 0x2BB0731 VA: 0x2BB0630
	|-SortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB06F0 Offset: 0x2BB07F1 VA: 0x2BB06F0
	|-SortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB07D0 Offset: 0x2BB08D1 VA: 0x2BB07D0
	|-SortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB07E0 Offset: 0x2BB08E1 VA: 0x2BB07E0
	|-SortedDictionary<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0900 Offset: 0x2BB0A01 VA: 0x2BB0900
	|-SortedDictionary<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0AB0 Offset: 0x2BB0BB1 VA: 0x2BB0AB0
	|-SortedDictionary<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0AE0 Offset: 0x2BB0BE1 VA: 0x2BB0AE0
	|-SortedDictionary<object, object>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0B80 Offset: 0x2BB0C81 VA: 0x2BB0B80
	|-SortedDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0BB0 Offset: 0x2BB0CB1 VA: 0x2BB0BB0
	|-SortedDictionary<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0CA0 Offset: 0x2BB0DA1 VA: 0x2BB0CA0
	|-SortedDictionary<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0CD0 Offset: 0x2BB0DD1 VA: 0x2BB0CD0
	|-SortedDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0DB0 Offset: 0x2BB0EB1 VA: 0x2BB0DB0
	|-SortedDictionary<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0DE0 Offset: 0x2BB0EE1 VA: 0x2BB0DE0
	|-SortedDictionary<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0E50 Offset: 0x2BB0F51 VA: 0x2BB0E50
	|-SortedDictionary<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0EE0 Offset: 0x2BB0FE1 VA: 0x2BB0EE0
	|-SortedDictionary<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB1000 Offset: 0x2BB1101 VA: 0x2BB1000
	|-SortedDictionary<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB10D0 Offset: 0x2BB11D1 VA: 0x2BB10D0
	|-SortedDictionary<object, object>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB1100 Offset: 0x2BB1201 VA: 0x2BB1100
	|-SortedDictionary<object, object>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB11E0 Offset: 0x2BB12E1 VA: 0x2BB11E0
	|-SortedDictionary<object, object>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB1570 Offset: 0x2BB1671 VA: 0x2BB1570
	|-SortedDictionary<object, object>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB1900 Offset: 0x2BB1A01 VA: 0x2BB1900
	|-SortedDictionary<object, object>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB19E0 Offset: 0x2BB1AE1 VA: 0x2BB19E0
	|-SortedDictionary<object, object>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB1AB0 Offset: 0x2BB1BB1 VA: 0x2BB1AB0
	|-SortedDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB1B40 Offset: 0x2BB1C41 VA: 0x2BB1B40
	|-SortedDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

