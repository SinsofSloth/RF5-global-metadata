[DefaultMemberAttribute] // RVA: 0xB3AA0 Offset: 0xB3BA1 VA: 0xB3AA0
public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 1453
{
	// Properties
	public abstract TValue Item { get; }
	public abstract ICollection<TKey> Keys { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.TryGetValue
	*/
}

