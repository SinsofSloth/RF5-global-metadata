public sealed class SortedDictionaryFormatter<TKey, TValue> : DictionaryFormatterBase<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary.Enumerator<TKey, TValue>, SortedDictionary<TKey, TValue>> // TypeDefIndex: 5398
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override void Add(SortedDictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285E740 Offset: 0x285E841 VA: 0x285E740
	|-SortedDictionaryFormatter<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override SortedDictionary<TKey, TValue> Complete(SortedDictionary<TKey, TValue> intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285E780 Offset: 0x285E881 VA: 0x285E780
	|-SortedDictionaryFormatter<object, object>.Complete
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected override SortedDictionary<TKey, TValue> Create(int count, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285E790 Offset: 0x285E891 VA: 0x285E790
	|-SortedDictionaryFormatter<object, object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override SortedDictionary.Enumerator<TKey, TValue> GetSourceEnumerator(SortedDictionary<TKey, TValue> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285E7F0 Offset: 0x285E8F1 VA: 0x285E7F0
	|-SortedDictionaryFormatter<object, object>.GetSourceEnumerator
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x285E850 Offset: 0x285E951 VA: 0x285E850
	|-SortedDictionaryFormatter<object, object>..ctor
	*/
}

