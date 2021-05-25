private class SceneProvider.SceneOp : AsyncOperationBase<SceneInstance>, IUpdateReceiver // TypeDefIndex: 4498
{
	// Fields
	private bool m_ActivateOnLoad; // 0x88
	private SceneInstance m_Inst; // 0x90
	private IResourceLocation m_Location; // 0xA0
	private LoadSceneMode m_LoadMode; // 0xA8
	private int m_Priority; // 0xAC
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xB0
	private ResourceManager m_ResourceManager; // 0xC8

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x19E2180 Offset: 0x19E2281 VA: 0x19E2180
	public void .ctor(ResourceManager rm) { }

	// RVA: 0x19E25C0 Offset: 0x19E26C1 VA: 0x19E25C0 Slot: 33
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x19E21F0 Offset: 0x19E22F1 VA: 0x19E21F0
	public void Init(IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }

	// RVA: 0x19E2680 Offset: 0x19E2781 VA: 0x19E2680 Slot: 31
	protected override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x19E2750 Offset: 0x19E2851 VA: 0x19E2750 Slot: 30
	protected override string get_DebugName() { }

	// RVA: 0x19E27F0 Offset: 0x19E28F1 VA: 0x19E27F0 Slot: 27
	protected override void Execute() { }

	// RVA: 0x19E2D70 Offset: 0x19E2E71 VA: 0x19E2D70
	internal SceneInstance InternalLoadScene(IResourceLocation location, bool loadingFromBundle, LoadSceneMode loadMode, bool activateOnLoad, int priority) { }

	// RVA: 0x19E2ED0 Offset: 0x19E2FD1 VA: 0x19E2ED0
	private AsyncOperation InternalLoad(string path, bool loadingFromBundle, LoadSceneMode mode) { }

	// RVA: 0x19E2F70 Offset: 0x19E3071 VA: 0x19E2F70 Slot: 28
	protected override void Destroy() { }

	// RVA: 0x19E2FF0 Offset: 0x19E30F1 VA: 0x19E2FF0 Slot: 29
	protected override float get_Progress() { }

	// RVA: 0x19E30B0 Offset: 0x19E31B1 VA: 0x19E30B0 Slot: 34
	private void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime) { }
}

