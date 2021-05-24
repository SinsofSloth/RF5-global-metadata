[Serializable]
public class AssetReference : IKeyEvaluator // TypeDefIndex: 5707
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x13DD30 Offset: 0x13DE31 VA: 0x13DD30
	[SerializeField] // RVA: 0x13DD30 Offset: 0x13DE31 VA: 0x13DD30
	private string m_AssetGUID; // 0x10
	[SerializeField] // RVA: 0x13DD80 Offset: 0x13DE81 VA: 0x13DD80
	private string m_SubObjectName; // 0x18
	[SerializeField] // RVA: 0x13DD90 Offset: 0x13DE91 VA: 0x13DD90
	private string m_SubObjectType; // 0x20
	private AsyncOperationHandle m_Operation; // 0x28

	// Properties
	public AsyncOperationHandle OperationHandle { get; }
	public virtual object RuntimeKey { get; }
	public virtual string AssetGUID { get; }
	public virtual string SubObjectName { get; set; }
	internal virtual Type SubOjbectType { get; }
	public bool IsDone { get; }
	public virtual Object Asset { get; }

	// Methods

	// RVA: 0x15E3880 Offset: 0x15E3981 VA: 0x15E3880
	public AsyncOperationHandle get_OperationHandle() { }

	// RVA: 0x15E38A0 Offset: 0x15E39A1 VA: 0x15E38A0 Slot: 6
	public virtual object get_RuntimeKey() { }

	// RVA: 0x15E3940 Offset: 0x15E3A41 VA: 0x15E3940 Slot: 7
	public virtual string get_AssetGUID() { }

	// RVA: 0x15E3950 Offset: 0x15E3A51 VA: 0x15E3950 Slot: 8
	public virtual string get_SubObjectName() { }

	// RVA: 0x15E3960 Offset: 0x15E3A61 VA: 0x15E3960 Slot: 9
	public virtual void set_SubObjectName(string value) { }

	// RVA: 0x15E3970 Offset: 0x15E3A71 VA: 0x15E3970 Slot: 10
	internal virtual Type get_SubOjbectType() { }

	// RVA: 0x15E3A30 Offset: 0x15E3B31 VA: 0x15E3A30
	public bool IsValid() { }

	// RVA: 0x15E3A40 Offset: 0x15E3B41 VA: 0x15E3A40
	public bool get_IsDone() { }

	// RVA: 0x15E3A50 Offset: 0x15E3B51 VA: 0x15E3A50
	public void .ctor() { }

	// RVA: 0x15E3AB0 Offset: 0x15E3BB1 VA: 0x15E3AB0
	public void .ctor(string guid) { }

	// RVA: 0x15E3B30 Offset: 0x15E3C31 VA: 0x15E3B30 Slot: 11
	public virtual Object get_Asset() { }

	// RVA: 0x15E3BE0 Offset: 0x15E3CE1 VA: 0x15E3BE0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static AsyncOperationHandle<T> CreateFailedOperation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FB5C0 Offset: 0x34FB6C1 VA: 0x34FB5C0
	|-AssetReference.CreateFailedOperation<object>
	*/

	[ObsoleteAttribute] // RVA: 0x13E980 Offset: 0x13EA81 VA: 0x13E980
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAsset<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FC7F0 Offset: 0x34FC8F1 VA: 0x34FC7F0
	|-AssetReference.LoadAsset<object>
	*/

	[ObsoleteAttribute] // RVA: 0x13E990 Offset: 0x13EA91 VA: 0x13E990
	// RVA: 0x15E3C40 Offset: 0x15E3D41 VA: 0x15E3C40
	public AsyncOperationHandle<SceneInstance> LoadScene() { }

	[ObsoleteAttribute] // RVA: 0x13E9A0 Offset: 0x13EAA1 VA: 0x13E9A0
	// RVA: 0x15E3C60 Offset: 0x15E3D61 VA: 0x15E3C60
	public AsyncOperationHandle<GameObject> Instantiate(Vector3 position, Quaternion rotation, Transform parent) { }

	[ObsoleteAttribute] // RVA: 0x13E9B0 Offset: 0x13EAB1 VA: 0x13E9B0
	// RVA: 0x15E3C70 Offset: 0x15E3D71 VA: 0x15E3C70
	public AsyncOperationHandle<GameObject> Instantiate(Transform parent, bool instantiateInWorldSpace = False) { }

	// RVA: -1 Offset: -1 Slot: 12
	public virtual AsyncOperationHandle<TObject> LoadAssetAsync<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FC860 Offset: 0x34FC961 VA: 0x34FC860
	|-AssetReference.LoadAssetAsync<object>
	*/

	// RVA: 0x15E3C90 Offset: 0x15E3D91 VA: 0x15E3C90 Slot: 13
	public virtual AsyncOperationHandle<SceneInstance> LoadSceneAsync(LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x15E3E00 Offset: 0x15E3F01 VA: 0x15E3E00 Slot: 14
	public virtual AsyncOperationHandle<SceneInstance> UnLoadScene() { }

	// RVA: 0x15E3EB0 Offset: 0x15E3FB1 VA: 0x15E3EB0 Slot: 15
	public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x15E3FA0 Offset: 0x15E40A1 VA: 0x15E3FA0 Slot: 16
	public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Transform parent, bool instantiateInWorldSpace = False) { }

	// RVA: 0x15E4050 Offset: 0x15E4151 VA: 0x15E4050 Slot: 17
	public virtual bool RuntimeKeyIsValid() { }

	// RVA: 0x15E4130 Offset: 0x15E4231 VA: 0x15E4130 Slot: 18
	public virtual void ReleaseAsset() { }

	// RVA: 0x15E4220 Offset: 0x15E4321 VA: 0x15E4220 Slot: 19
	public virtual void ReleaseInstance(GameObject obj) { }

	// RVA: 0x15E42A0 Offset: 0x15E43A1 VA: 0x15E42A0 Slot: 20
	public virtual bool ValidateAsset(Object obj) { }

	// RVA: 0x15E42B0 Offset: 0x15E43B1 VA: 0x15E42B0 Slot: 21
	public virtual bool ValidateAsset(string path) { }
}

