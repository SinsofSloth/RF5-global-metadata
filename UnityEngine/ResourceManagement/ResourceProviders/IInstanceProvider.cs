public interface IInstanceProvider // TypeDefIndex: 4484
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReleaseInstance(ResourceManager resourceManager, GameObject instance) { }
}

