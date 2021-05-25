private class ThreadLocal.IdManager<T> // TypeDefIndex: 773
{
	// Fields
	private int m_nextIdToTry; // 0x0
	private List<bool> m_freeIds; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal int GetId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B92480 Offset: 0x2B92581 VA: 0x2B92480
	|-ThreadLocal.IdManager<object>.GetId
	*/

	// RVA: -1 Offset: -1
	internal void ReturnId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B92620 Offset: 0x2B92721 VA: 0x2B92620
	|-ThreadLocal.IdManager<object>.ReturnId
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B92730 Offset: 0x2B92831 VA: 0x2B92730
	|-ThreadLocal.IdManager<object>..ctor
	*/
}

