[DefaultMemberAttribute] // RVA: 0xB3BC0 Offset: 0xB3CC1 VA: 0xB3BC0
public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 1459
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<object, object>.TryGetValue
	*/
}

