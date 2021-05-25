public class InstanceProvider : IInstanceProvider // TypeDefIndex: 4490
{
	// Fields
	private Dictionary<GameObject, AsyncOperationHandle<GameObject>> m_InstanceObjectToPrefabHandle; // 0x10

	// Methods

	// RVA: 0x19E0670 Offset: 0x19E0771 VA: 0x19E0670 Slot: 4
	public GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters) { }

	// RVA: 0x19E0740 Offset: 0x19E0841 VA: 0x19E0740 Slot: 5
	public void ReleaseInstance(ResourceManager resourceManager, GameObject instance) { }

	// RVA: 0x19E0950 Offset: 0x19E0A51 VA: 0x19E0950
	public void .ctor() { }
}

