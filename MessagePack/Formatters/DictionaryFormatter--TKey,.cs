public sealed class DictionaryFormatter<TKey, TValue> : DictionaryFormatterBase<TKey, TValue, Dictionary<TKey, TValue>, Dictionary.Enumerator<TKey, TValue>, Dictionary<TKey, TValue>> // TypeDefIndex: 5394
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override void Add(Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270CE20 Offset: 0x270CF21 VA: 0x270CE20
	|-DictionaryFormatter<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override Dictionary<TKey, TValue> Complete(Dictionary<TKey, TValue> intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270CE60 Offset: 0x270CF61 VA: 0x270CE60
	|-DictionaryFormatter<object, object>.Complete
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected override Dictionary<TKey, TValue> Create(int count, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270CE70 Offset: 0x270CF71 VA: 0x270CE70
	|-DictionaryFormatter<object, object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override Dictionary.Enumerator<TKey, TValue> GetSourceEnumerator(Dictionary<TKey, TValue> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270CF10 Offset: 0x270D011 VA: 0x270CF10
	|-DictionaryFormatter<object, object>.GetSourceEnumerator
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270CF70 Offset: 0x270D071 VA: 0x270CF70
	|-DictionaryFormatter<object, object>..ctor
	*/
}

