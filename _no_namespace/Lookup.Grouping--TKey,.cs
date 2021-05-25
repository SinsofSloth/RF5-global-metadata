internal class Lookup.Grouping<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement> // TypeDefIndex: 2191
{
	// Fields
	internal TKey key; // 0x0
	internal int hashCode; // 0x0
	internal TElement[] elements; // 0x0
	internal int count; // 0x0
	internal Lookup.Grouping<TKey, TElement> hashNext; // 0x0
	internal Lookup.Grouping<TKey, TElement> next; // 0x0

	// Properties
	public TKey Key { get; }
	private int System.Collections.Generic.ICollection<TElement>.Count { get; }
	private bool System.Collections.Generic.ICollection<TElement>.IsReadOnly { get; }
	private TElement System.Collections.Generic.IList<TElement>.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void Add(TElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67370 Offset: 0x2A67471 VA: 0x2A67370
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.Add
	|
	|-RVA: 0x2A678A0 Offset: 0x2A679A1 VA: 0x2A678A0
	|-Lookup.Grouping<object, object>.Add
	*/

	[IteratorStateMachineAttribute] // RVA: 0xC04C0 Offset: 0xC05C1 VA: 0xC04C0
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67470 Offset: 0x2A67571 VA: 0x2A67470
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x2A67990 Offset: 0x2A67A91 VA: 0x2A67990
	|-Lookup.Grouping<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67500 Offset: 0x2A67601 VA: 0x2A67500
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A67A20 Offset: 0x2A67B21 VA: 0x2A67A20
	|-Lookup.Grouping<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67530 Offset: 0x2A67631 VA: 0x2A67530
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.get_Key
	|
	|-RVA: 0x2A67A50 Offset: 0x2A67B51 VA: 0x2A67A50
	|-Lookup.Grouping<object, object>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Collections.Generic.ICollection<TElement>.get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67540 Offset: 0x2A67641 VA: 0x2A67540
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.Generic.ICollection<TElement>.get_Count
	|
	|-RVA: 0x2A67A60 Offset: 0x2A67B61 VA: 0x2A67A60
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<TElement>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67550 Offset: 0x2A67651 VA: 0x2A67550
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	|
	|-RVA: 0x2A67A70 Offset: 0x2A67B71 VA: 0x2A67A70
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67560 Offset: 0x2A67661 VA: 0x2A67560
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.Generic.ICollection<TElement>.Add
	|
	|-RVA: 0x2A67A80 Offset: 0x2A67B81 VA: 0x2A67A80
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.Generic.ICollection<TElement>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A675B0 Offset: 0x2A676B1 VA: 0x2A675B0
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.Generic.ICollection<TElement>.Clear
	|
	|-RVA: 0x2A67AD0 Offset: 0x2A67BD1 VA: 0x2A67AD0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67600 Offset: 0x2A67701 VA: 0x2A67600
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.Generic.ICollection<TElement>.Contains
	|
	|-RVA: 0x2A67B20 Offset: 0x2A67C21 VA: 0x2A67B20
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67640 Offset: 0x2A67741 VA: 0x2A67640
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.Generic.ICollection<TElement>.CopyTo
	|
	|-RVA: 0x2A67B60 Offset: 0x2A67C61 VA: 0x2A67B60
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67660 Offset: 0x2A67761 VA: 0x2A67660
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.Generic.ICollection<TElement>.Remove
	|
	|-RVA: 0x2A67B80 Offset: 0x2A67C81 VA: 0x2A67B80
	|-Lookup.Grouping<object, object>.System.Collections.Generic.ICollection<TElement>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A676B0 Offset: 0x2A677B1 VA: 0x2A676B0
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.Generic.IList<TElement>.IndexOf
	|
	|-RVA: 0x2A67BD0 Offset: 0x2A67CD1 VA: 0x2A67BD0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A676E0 Offset: 0x2A677E1 VA: 0x2A676E0
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.Generic.IList<TElement>.Insert
	|
	|-RVA: 0x2A67C00 Offset: 0x2A67D01 VA: 0x2A67C00
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67730 Offset: 0x2A67831 VA: 0x2A67730
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.Generic.IList<TElement>.RemoveAt
	|
	|-RVA: 0x2A67C50 Offset: 0x2A67D51 VA: 0x2A67C50
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67780 Offset: 0x2A67881 VA: 0x2A67780
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.Generic.IList<TElement>.get_Item
	|
	|-RVA: 0x2A67CA0 Offset: 0x2A67DA1 VA: 0x2A67CA0
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67830 Offset: 0x2A67931 VA: 0x2A67830
	|-Lookup.Grouping<object, KeyValuePair<object, object>>.System.Collections.Generic.IList<TElement>.set_Item
	|
	|-RVA: 0x2A67D50 Offset: 0x2A67E51 VA: 0x2A67D50
	|-Lookup.Grouping<object, object>.System.Collections.Generic.IList<TElement>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A67880 Offset: 0x2A67981 VA: 0x2A67880
	|-Lookup.Grouping<object, KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2A67DA0 Offset: 0x2A67EA1 VA: 0x2A67DA0
	|-Lookup.Grouping<object, object>..ctor
	*/
}

