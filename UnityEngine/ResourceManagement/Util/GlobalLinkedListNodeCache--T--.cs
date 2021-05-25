internal static class GlobalLinkedListNodeCache<T> // TypeDefIndex: 4472
{
	// Fields
	private static LinkedListNodeCache<T> m_globalCache; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static LinkedListNode<T> Acquire(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA82E0 Offset: 0x2AA83E1 VA: 0x2AA82E0
	|-GlobalLinkedListNodeCache<object>.Acquire
	*/

	// RVA: -1 Offset: -1
	public static void Release(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA84E0 Offset: 0x2AA85E1 VA: 0x2AA84E0
	|-GlobalLinkedListNodeCache<object>.Release
	*/
}

