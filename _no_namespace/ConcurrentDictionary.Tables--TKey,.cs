private sealed class ConcurrentDictionary.Tables<TKey, TValue> // TypeDefIndex: 1401
{
	// Fields
	internal readonly ConcurrentDictionary.Node<TKey, TValue>[] _buckets; // 0x0
	internal readonly object[] _locks; // 0x0
	internal int[] _countPerLock; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentDictionary.Node<TKey, TValue>[] buckets, object[] locks, int[] countPerLock) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B55810 Offset: 0x2B55911 VA: 0x2B55810
	|-ConcurrentDictionary.Tables<object, object>..ctor
	*/
}

