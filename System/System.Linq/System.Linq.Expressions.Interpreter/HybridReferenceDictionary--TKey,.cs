[DefaultMemberAttribute] // RVA: 0xBEF50 Offset: 0xBF051 VA: 0xBEF50
internal class HybridReferenceDictionary<TKey, TValue> // TypeDefIndex: 2713
{
	// Fields
	private KeyValuePair<TKey, TValue>[] _keysAndValues; // 0x0
	private Dictionary<TKey, TValue> _dict; // 0x0

	// Properties
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A65270 Offset: 0x2A65371 VA: 0x2A65270
	|-HybridReferenceDictionary<LabelTarget, LabelInfo>.TryGetValue
	|-HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope>.TryGetValue
	|-HybridReferenceDictionary<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public void Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A65320 Offset: 0x2A65421 VA: 0x2A65320
	|-HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope>.Remove
	|-HybridReferenceDictionary<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A653A0 Offset: 0x2A654A1 VA: 0x2A653A0
	|-HybridReferenceDictionary<LabelTarget, LabelInfo>.ContainsKey
	|-HybridReferenceDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A65430 Offset: 0x2A65531 VA: 0x2A65430
	|-HybridReferenceDictionary<LabelTarget, LabelInfo>.GetEnumerator
	|-HybridReferenceDictionary<object, object>.GetEnumerator
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC0E70 Offset: 0xC0F71 VA: 0xC0E70
	// RVA: -1 Offset: -1
	private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A654E0 Offset: 0x2A655E1 VA: 0x2A654E0
	|-HybridReferenceDictionary<object, object>.GetEnumeratorWorker
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A65570 Offset: 0x2A65671 VA: 0x2A65570
	|-HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope>.get_Item
	|-HybridReferenceDictionary<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A65630 Offset: 0x2A65731 VA: 0x2A65630
	|-HybridReferenceDictionary<LabelTarget, LabelInfo>.set_Item
	|-HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope>.set_Item
	|-HybridReferenceDictionary<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A658C0 Offset: 0x2A659C1 VA: 0x2A658C0
	|-HybridReferenceDictionary<LabelTarget, LabelInfo>..ctor
	|-HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope>..ctor
	|-HybridReferenceDictionary<object, object>..ctor
	*/
}

