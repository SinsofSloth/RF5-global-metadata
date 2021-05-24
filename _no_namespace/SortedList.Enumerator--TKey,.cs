[Serializable]
private struct SortedList.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 2090
{
	// Fields
	private SortedList<TKey, TValue> _sortedList; // 0x0
	private TKey _key; // 0x0
	private TValue _value; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Properties
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384DC0 Offset: 0x384EC1 VA: 0x384DC0
	|-SortedList.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384E20 Offset: 0x384F21 VA: 0x384E20
	|-SortedList.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384E30 Offset: 0x384F31 VA: 0x384E30
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384E40 Offset: 0x384F41 VA: 0x384E40
	|-SortedList.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384E50 Offset: 0x384F51 VA: 0x384E50
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384E60 Offset: 0x384F61 VA: 0x384E60
	|-SortedList.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384EC0 Offset: 0x384FC1 VA: 0x384EC0
	|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384ED0 Offset: 0x384FD1 VA: 0x384ED0
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384EE0 Offset: 0x384FE1 VA: 0x384EE0
	|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	*/
}

