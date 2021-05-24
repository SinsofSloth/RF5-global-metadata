[DebuggerTypeProxyAttribute] // RVA: 0xBC770 Offset: 0xBC871 VA: 0xBC770
[DebuggerDisplayAttribute] // RVA: 0xBC770 Offset: 0xBC871 VA: 0xBC770
[Serializable]
public sealed class SortedDictionary.KeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 2082
{
	// Fields
	private SortedDictionary<TKey, TValue> _dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SortedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAF870 Offset: 0x2BAF971 VA: 0x2BAF870
	|-SortedDictionary.KeyCollection<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAF920 Offset: 0x2BAFA21 VA: 0x2BAF920
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAFA30 Offset: 0x2BAFB31 VA: 0x2BAFA30
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TKey[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAFB40 Offset: 0x2BAFC41 VA: 0x2BAFB40
	|-SortedDictionary.KeyCollection<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BAFD70 Offset: 0x2BAFE71 VA: 0x2BAFD70
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB01F0 Offset: 0x2BB02F1 VA: 0x2BB01F0
	|-SortedDictionary.KeyCollection<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0220 Offset: 0x2BB0321 VA: 0x2BB0220
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0230 Offset: 0x2BB0331 VA: 0x2BB0230
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB02A0 Offset: 0x2BB03A1 VA: 0x2BB02A0
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0310 Offset: 0x2BB0411 VA: 0x2BB0310
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0340 Offset: 0x2BB0441 VA: 0x2BB0340
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Remove
	*/
}

