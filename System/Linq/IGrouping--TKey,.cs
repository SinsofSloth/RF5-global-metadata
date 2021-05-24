public interface IGrouping<TKey, TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 2188
{
	// Properties
	public abstract TKey Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGrouping<object, object>.get_Key
	*/
}

