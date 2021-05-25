public interface ISceneProvider // TypeDefIndex: 4489
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }
}

