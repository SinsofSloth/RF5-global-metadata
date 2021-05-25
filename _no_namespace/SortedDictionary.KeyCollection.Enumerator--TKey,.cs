public struct SortedDictionary.KeyCollection.Enumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator // TypeDefIndex: 2083
{
	// Fields
	private SortedDictionary.Enumerator<TKey, TValue> _dictEnum; // 0x0

	// Properties
	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384BD0 Offset: 0x384CD1 VA: 0x384BD0
	|-SortedDictionary.KeyCollection.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384C90 Offset: 0x384D91 VA: 0x384C90
	|-SortedDictionary.KeyCollection.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384CE0 Offset: 0x384DE1 VA: 0x384CE0
	|-SortedDictionary.KeyCollection.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384D40 Offset: 0x384E41 VA: 0x384D40
	|-SortedDictionary.KeyCollection.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384D50 Offset: 0x384E51 VA: 0x384D50
	|-SortedDictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384D60 Offset: 0x384E61 VA: 0x384D60
	|-SortedDictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	*/
}

