public class ResourceManager<T> // TypeDefIndex: 6835
{
	// Fields
	private int CacheNum; // 0x0
	private MonoBehaviour OwnerGameObject; // 0x0
	public UnityAction<T> OnLoadCommon; // 0x0
	private List<ResourceManager.ManagerInfo<T>> Resources; // 0x0
	private Dictionary<int, ResourceManager.ManagerInfo<T>> ResourcesDic; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MonoBehaviour owner, int cacheNum) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA3590 Offset: 0x2CA3691 VA: 0x2CA3590
	|-ResourceManager<object>..ctor
	|-ResourceManager<AudioClip>..ctor
	|-ResourceManager<GameObject>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Load(int id, UnityAction<int, T> callback, int priority = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA36A0 Offset: 0x2CA37A1 VA: 0x2CA36A0
	|-ResourceManager<object>.Load
	|-ResourceManager<AudioClip>.Load
	|-ResourceManager<GameObject>.Load
	*/

	// RVA: -1 Offset: -1
	public bool IsLoaded(int key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA3AE0 Offset: 0x2CA3BE1 VA: 0x2CA3AE0
	|-ResourceManager<object>.IsLoaded
	|-ResourceManager<AudioClip>.IsLoaded
	*/

	// RVA: -1 Offset: -1
	public void RemoveAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA3B80 Offset: 0x2CA3C81 VA: 0x2CA3B80
	|-ResourceManager<object>.RemoveAll
	|-ResourceManager<AudioClip>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	private void LoadAndCallback(ResourceManager.ManagerInfo<T> addData, int priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA4090 Offset: 0x2CA4191 VA: 0x2CA4090
	|-ResourceManager<object>.LoadAndCallback
	*/

	[IteratorStateMachineAttribute] // RVA: 0x19D370 Offset: 0x19D471 VA: 0x19D370
	// RVA: -1 Offset: -1
	private IEnumerator CallbackNextFrame(UnityAction<int, T> callback, int id, T tmp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA4250 Offset: 0x2CA4351 VA: 0x2CA4250
	|-ResourceManager<object>.CallbackNextFrame
	*/
}

