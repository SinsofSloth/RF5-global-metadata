public class ObjectPooler : MonoBehaviour // TypeDefIndex: 7394
{
	// Fields
	public List<ObjectPooler.Pool> PoolList; // 0x18
	private Dictionary<string, List<GameObject>> poolDictionary; // 0x20

	// Methods

	// RVA: 0x1D8DF70 Offset: 0x1D8E071 VA: 0x1D8DF70
	public void Setup() { }

	// RVA: 0x1D8E280 Offset: 0x1D8E381 VA: 0x1D8E280
	public GameObject GetObjectFromPool(string _tag) { }

	// RVA: 0x1D8E640 Offset: 0x1D8E741 VA: 0x1D8E640
	public void ResetObject(string _tag) { }

	// RVA: 0x1D8E7E0 Offset: 0x1D8E8E1 VA: 0x1D8E7E0
	public void Clear() { }

	// RVA: 0x1D8E880 Offset: 0x1D8E981 VA: 0x1D8E880
	public void .ctor() { }
}

