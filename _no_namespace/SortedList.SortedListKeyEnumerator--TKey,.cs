[Serializable]
private sealed class SortedList.SortedListKeyEnumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator // TypeDefIndex: 2091
{
	// Fields
	private SortedList<TKey, TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TKey _currentKey; // 0x0

	// Properties
	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> sortedList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2B50 Offset: 0x2BB2C51 VA: 0x2BB2B50
	|-SortedList.SortedListKeyEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2BA0 Offset: 0x2BB2CA1 VA: 0x2BB2BA0
	|-SortedList.SortedListKeyEnumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2BB0 Offset: 0x2BB2CB1 VA: 0x2BB2BB0
	|-SortedList.SortedListKeyEnumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2D00 Offset: 0x2BB2E01 VA: 0x2BB2D00
	|-SortedList.SortedListKeyEnumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2D10 Offset: 0x2BB2E11 VA: 0x2BB2D10
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2DD0 Offset: 0x2BB2ED1 VA: 0x2BB2DD0
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.Reset
	*/
}

