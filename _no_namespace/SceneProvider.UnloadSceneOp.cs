private class SceneProvider.UnloadSceneOp : AsyncOperationBase<SceneInstance> // TypeDefIndex: 4499
{
	// Fields
	private SceneInstance m_Instance; // 0x88
	private AsyncOperationHandle<SceneInstance> m_sceneLoadHandle; // 0x98

	// Properties
	protected override float Progress { get; }

	// Methods

	// RVA: 0x19E24F0 Offset: 0x19E25F1 VA: 0x19E24F0
	public void Init(AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	// RVA: 0x19E3170 Offset: 0x19E3271 VA: 0x19E3170 Slot: 27
	protected override void Execute() { }

	// RVA: 0x19E3300 Offset: 0x19E3401 VA: 0x19E3300
	private void UnloadSceneCompleted(AsyncOperation obj) { }

	// RVA: 0x19E33A0 Offset: 0x19E34A1 VA: 0x19E33A0 Slot: 29
	protected override float get_Progress() { }

	// RVA: 0x19E24A0 Offset: 0x19E25A1 VA: 0x19E24A0
	public void .ctor() { }
}

