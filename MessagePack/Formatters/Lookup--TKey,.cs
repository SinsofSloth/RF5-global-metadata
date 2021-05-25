[DefaultMemberAttribute] // RVA: 0x139400 Offset: 0x139501 VA: 0x139400
internal class Lookup<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 5373
{
	// Fields
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> groupings; // 0x0

	// Properties
	public IEnumerable<TElement> Item { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<TKey, IGrouping<TKey, TElement>> groupings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDF6B0 Offset: 0x2CDF7B1 VA: 0x2CDF6B0
	|-Lookup<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerable<TElement> get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDF6F0 Offset: 0x2CDF7F1 VA: 0x2CDF6F0
	|-Lookup<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDF720 Offset: 0x2CDF821 VA: 0x2CDF720
	|-Lookup<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDF750 Offset: 0x2CDF851 VA: 0x2CDF750
	|-Lookup<object, object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDF780 Offset: 0x2CDF881 VA: 0x2CDF780
	|-Lookup<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDF820 Offset: 0x2CDF921 VA: 0x2CDF820
	|-Lookup<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

