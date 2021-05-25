[Serializable]
internal sealed class SortedDictionary.KeyValuePairComparer<TKey, TValue> : Comparer<KeyValuePair<TKey, TValue>> // TypeDefIndex: 2087
{
	// Fields
	internal IComparer<TKey> keyComparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TKey> keyComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB03B0 Offset: 0x2BB04B1 VA: 0x2BB03B0
	|-SortedDictionary.KeyValuePairComparer<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB0440 Offset: 0x2BB0541 VA: 0x2BB0440
	|-SortedDictionary.KeyValuePairComparer<object, object>.Compare
	*/
}

