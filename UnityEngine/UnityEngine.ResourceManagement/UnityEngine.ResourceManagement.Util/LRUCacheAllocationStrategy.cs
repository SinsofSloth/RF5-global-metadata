public class LRUCacheAllocationStrategy : IAllocationStrategy // TypeDefIndex: 4469
{
	// Fields
	private int m_poolMaxSize; // 0x10
	private int m_poolInitialCapacity; // 0x14
	private int m_poolCacheMaxSize; // 0x18
	private List<List<object>> m_poolCache; // 0x20
	private Dictionary<int, List<object>> m_cache; // 0x28

	// Methods

	// RVA: 0x19D9350 Offset: 0x19D9451 VA: 0x19D9350
	public void .ctor(int poolMaxSize, int poolCapacity, int poolCacheMaxSize, int initialPoolCacheCapacity) { }

	// RVA: 0x19E4F60 Offset: 0x19E5061 VA: 0x19E4F60
	private List<object> GetPool() { }

	// RVA: 0x19E5020 Offset: 0x19E5121 VA: 0x19E5020
	private void ReleasePool(List<object> pool) { }

	// RVA: 0x19E50B0 Offset: 0x19E51B1 VA: 0x19E50B0 Slot: 4
	public object New(Type type, int typeHash) { }

	// RVA: 0x19E5240 Offset: 0x19E5341 VA: 0x19E5240 Slot: 5
	public void Release(int typeHash, object obj) { }
}

