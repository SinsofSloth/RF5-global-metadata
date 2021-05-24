[DefaultMemberAttribute] // RVA: 0xBE1E0 Offset: 0xBE2E1 VA: 0xBE1E0
public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable, ILookup<TKey, TElement> // TypeDefIndex: 2190
{
	// Fields
	private IEqualityComparer<TKey> comparer; // 0x0
	private Lookup.Grouping<TKey, TElement>[] groupings; // 0x0
	private Lookup.Grouping<TKey, TElement> lastGrouping; // 0x0
	private int count; // 0x0

	// Properties
	public IEnumerable<TElement> Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25603E0 Offset: 0x25604E1 VA: 0x25603E0
	|-Lookup<object, KeyValuePair<object, object>>.Create<KeyValuePair<object, object>>
	|
	|-RVA: 0x2560880 Offset: 0x2560981 VA: 0x2560880
	|-Lookup<object, object>.Create<object>
	*/

	// RVA: -1 Offset: -1
	private void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67DC0 Offset: 0x2A67EC1 VA: 0x2A67DC0
	|-Lookup<object, KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2A68520 Offset: 0x2A68621 VA: 0x2A68520
	|-Lookup<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public IEnumerable<TElement> get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67E60 Offset: 0x2A67F61 VA: 0x2A67E60
	|-Lookup<object, KeyValuePair<object, object>>.get_Item
	|
	|-RVA: 0x2A685C0 Offset: 0x2A686C1 VA: 0x2A685C0
	|-Lookup<object, object>.get_Item
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC0450 Offset: 0xC0551 VA: 0xC0450
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67F40 Offset: 0x2A68041 VA: 0x2A67F40
	|-Lookup<object, KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x2A686A0 Offset: 0x2A687A1 VA: 0x2A686A0
	|-Lookup<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67FD0 Offset: 0x2A680D1 VA: 0x2A67FD0
	|-Lookup<object, KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A68730 Offset: 0x2A68831 VA: 0x2A68730
	|-Lookup<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A68000 Offset: 0x2A68101 VA: 0x2A68000
	|-Lookup<object, KeyValuePair<object, object>>.InternalGetHashCode
	|
	|-RVA: 0x2A68760 Offset: 0x2A68861 VA: 0x2A68760
	|-Lookup<object, object>.InternalGetHashCode
	*/

	// RVA: -1 Offset: -1
	internal Lookup.Grouping<TKey, TElement> GetGrouping(TKey key, bool create) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A680D0 Offset: 0x2A681D1 VA: 0x2A680D0
	|-Lookup<object, KeyValuePair<object, object>>.GetGrouping
	|
	|-RVA: 0x2A68830 Offset: 0x2A68931 VA: 0x2A68830
	|-Lookup<object, object>.GetGrouping
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A683C0 Offset: 0x2A684C1 VA: 0x2A683C0
	|-Lookup<object, KeyValuePair<object, object>>.Resize
	|
	|-RVA: 0x2A68B20 Offset: 0x2A68C21 VA: 0x2A68B20
	|-Lookup<object, object>.Resize
	*/
}

