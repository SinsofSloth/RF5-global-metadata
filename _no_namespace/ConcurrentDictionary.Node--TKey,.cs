[Serializable]
private sealed class ConcurrentDictionary.Node<TKey, TValue> // TypeDefIndex: 1402
{
	// Fields
	internal readonly TKey _key; // 0x0
	internal TValue _value; // 0x0
	internal ConcurrentDictionary.Node<TKey, TValue> _next; // 0x0
	internal readonly int _hashcode; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(TKey key, TValue value, int hashcode, ConcurrentDictionary.Node<TKey, TValue> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55780 Offset: 0x2B55881 VA: 0x2B55780
	|-ConcurrentDictionary.Node<object, object>..ctor
	*/
}

