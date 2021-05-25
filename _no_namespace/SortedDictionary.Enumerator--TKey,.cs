public struct SortedDictionary.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 2081
{
	// Fields
	private SortedSet.Enumerator<KeyValuePair<TKey, TValue>> _treeEnum; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	internal bool NotStartedOrEnded { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3849B0 Offset: 0x384AB1 VA: 0x3849B0
	|-SortedDictionary.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3849C0 Offset: 0x384AC1 VA: 0x3849C0
	|-SortedDictionary.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384A00 Offset: 0x384B01 VA: 0x384A00
	|-SortedDictionary.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384A20 Offset: 0x384B21 VA: 0x384A20
	|-SortedDictionary.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_NotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384AD0 Offset: 0x384BD1 VA: 0x384AD0
	|-SortedDictionary.Enumerator<object, object>.get_NotStartedOrEnded
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384B10 Offset: 0x384C11 VA: 0x384B10
	|-SortedDictionary.Enumerator<object, object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384B50 Offset: 0x384C51 VA: 0x384B50
	|-SortedDictionary.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384B90 Offset: 0x384C91 VA: 0x384B90
	|-SortedDictionary.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384BA0 Offset: 0x384CA1 VA: 0x384BA0
	|-SortedDictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384BB0 Offset: 0x384CB1 VA: 0x384BB0
	|-SortedDictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384BC0 Offset: 0x384CC1 VA: 0x384BC0
	|-SortedDictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	*/
}

