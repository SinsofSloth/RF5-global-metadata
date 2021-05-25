internal class Grouping<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable // TypeDefIndex: 5372
{
	// Fields
	private readonly TKey key; // 0x0
	private readonly IEnumerable<TElement> elements; // 0x0

	// Properties
	public TKey Key { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TKey key, IEnumerable<TElement> elements) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E19A0 Offset: 0x27E1AA1 VA: 0x27E19A0
	|-Grouping<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E1A00 Offset: 0x27E1B01 VA: 0x27E1A00
	|-Grouping<object, object>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E1A10 Offset: 0x27E1B11 VA: 0x27E1A10
	|-Grouping<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E1AB0 Offset: 0x27E1BB1 VA: 0x27E1AB0
	|-Grouping<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

