public abstract class DictionaryFormatterBase<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : IMessagePackFormatter<TDictionary>, IMessagePackFormatter // TypeDefIndex: 5391
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(ref MessagePackWriter writer, TDictionary value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D394B0 Offset: 0x2D395B1 VA: 0x2D394B0
	|-DictionaryFormatterBase<object, object, object, Dictionary.Enumerator<object, object>, object>.Serialize
	|
	|-RVA: 0x270B970 Offset: 0x270BA71 VA: 0x270B970
	|-DictionaryFormatterBase<object, object, object, SortedDictionary.Enumerator<object, object>, object>.Serialize
	|
	|-RVA: 0x270C490 Offset: 0x270C591 VA: 0x270C490
	|-DictionaryFormatterBase<object, object, object, object, object>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TDictionary Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D39BF0 Offset: 0x2D39CF1 VA: 0x2D39BF0
	|-DictionaryFormatterBase<object, object, object, Dictionary.Enumerator<object, object>, object>.Deserialize
	|
	|-RVA: 0x270C0C0 Offset: 0x270C1C1 VA: 0x270C0C0
	|-DictionaryFormatterBase<object, object, object, SortedDictionary.Enumerator<object, object>, object>.Deserialize
	|
	|-RVA: 0x270CA50 Offset: 0x270CB51 VA: 0x270CA50
	|-DictionaryFormatterBase<object, object, object, object, object>.Deserialize
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract TEnumerator GetSourceEnumerator(TDictionary source) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-DictionaryFormatterBase<object, object, object, object, object>.GetSourceEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract TIntermediate Create(int count, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-DictionaryFormatterBase<object, object, object, object, object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void Add(TIntermediate collection, int index, TKey key, TValue value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-DictionaryFormatterBase<object, object, object, object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract TDictionary Complete(TIntermediate intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-DictionaryFormatterBase<object, object, object, object, object>.Complete
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D39FA0 Offset: 0x2D3A0A1 VA: 0x2D39FA0
	|-DictionaryFormatterBase<object, object, object, Dictionary.Enumerator<object, object>, object>..ctor
	|
	|-RVA: 0x270C470 Offset: 0x270C571 VA: 0x270C470
	|-DictionaryFormatterBase<object, object, object, SortedDictionary.Enumerator<object, object>, object>..ctor
	|
	|-RVA: 0x270CE00 Offset: 0x270CF01 VA: 0x270CE00
	|-DictionaryFormatterBase<object, object, object, object, object>..ctor
	*/
}

public abstract class DictionaryFormatterBase<TKey, TValue, TIntermediate, TDictionary> : DictionaryFormatterBase<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> // TypeDefIndex: 5392
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	protected override IEnumerator<KeyValuePair<TKey, TValue>> GetSourceEnumerator(TDictionary source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D393E0 Offset: 0x2D394E1 VA: 0x2D393E0
	|-DictionaryFormatterBase<object, object, object, object>.GetSourceEnumerator
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D39480 Offset: 0x2D39581 VA: 0x2D39480
	|-DictionaryFormatterBase<object, object, object, object>..ctor
	*/
}

public abstract class DictionaryFormatterBase<TKey, TValue, TDictionary> : DictionaryFormatterBase<TKey, TValue, TDictionary, TDictionary> // TypeDefIndex: 5393
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	protected override TDictionary Complete(TDictionary intermediateCollection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D393A0 Offset: 0x2D394A1 VA: 0x2D393A0
	|-DictionaryFormatterBase<object, object, object>.Complete
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D393B0 Offset: 0x2D394B1 VA: 0x2D393B0
	|-DictionaryFormatterBase<object, object, object>..ctor
	*/
}

