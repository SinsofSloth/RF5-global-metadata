public sealed class InterfaceReadOnlyDictionaryFormatter<TKey, TValue> : DictionaryFormatterBase<TKey, TValue, Dictionary<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>> // TypeDefIndex: 5400
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override void Add(Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCC8F0 Offset: 0x2CCC9F1 VA: 0x2CCC8F0
	|-InterfaceReadOnlyDictionaryFormatter<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override IReadOnlyDictionary<TKey, TValue> Complete(Dictionary<TKey, TValue> intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCC930 Offset: 0x2CCCA31 VA: 0x2CCC930
	|-InterfaceReadOnlyDictionaryFormatter<object, object>.Complete
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected override Dictionary<TKey, TValue> Create(int count, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCC940 Offset: 0x2CCCA41 VA: 0x2CCC940
	|-InterfaceReadOnlyDictionaryFormatter<object, object>.Create
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CCC9E0 Offset: 0x2CCCAE1 VA: 0x2CCC9E0
	|-InterfaceReadOnlyDictionaryFormatter<object, object>..ctor
	*/
}

