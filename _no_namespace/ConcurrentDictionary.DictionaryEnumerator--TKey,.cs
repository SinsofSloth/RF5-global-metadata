[Serializable]
private sealed class ConcurrentDictionary.DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 1403
{
	// Fields
	private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55260 Offset: 0x2B55361 VA: 0x2B55260
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B552D0 Offset: 0x2B553D1 VA: 0x2B552D0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55430 Offset: 0x2B55531 VA: 0x2B55430
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B554D0 Offset: 0x2B555D1 VA: 0x2B554D0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55580 Offset: 0x2B55681 VA: 0x2B55580
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55610 Offset: 0x2B55711 VA: 0x2B55610
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B556C0 Offset: 0x2B557C1 VA: 0x2B556C0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.Reset
	*/
}

