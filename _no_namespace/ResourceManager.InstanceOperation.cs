internal class ResourceManager.InstanceOperation : AsyncOperationBase<GameObject> // TypeDefIndex: 4455
{
	// Fields
	private AsyncOperationHandle<GameObject> m_dependency; // 0x80
	private InstantiationParameters m_instantiationParams; // 0x98
	private IInstanceProvider m_instanceProvider; // 0xC8
	private GameObject m_instance; // 0xD0
	private Scene m_scene; // 0xD8

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x19DC4C0 Offset: 0x19DC5C1 VA: 0x19DC4C0
	public void Init(ResourceManager rm, IInstanceProvider instanceProvider, InstantiationParameters instantiationParams, AsyncOperationHandle<GameObject> dependency) { }

	// RVA: 0x19DD110 Offset: 0x19DD211 VA: 0x19DD110 Slot: 33
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x19DD1D0 Offset: 0x19DD2D1 VA: 0x19DD1D0 Slot: 31
	protected override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x19DD280 Offset: 0x19DD381 VA: 0x19DD280 Slot: 30
	protected override string get_DebugName() { }

	// RVA: 0x19DD370 Offset: 0x19DD471 VA: 0x19DD370
	public Scene InstanceScene() { }

	// RVA: 0x19DD380 Offset: 0x19DD481 VA: 0x19DD380 Slot: 28
	protected override void Destroy() { }

	// RVA: 0x19DD450 Offset: 0x19DD551 VA: 0x19DD450 Slot: 29
	protected override float get_Progress() { }

	// RVA: 0x19DD4A0 Offset: 0x19DD5A1 VA: 0x19DD4A0 Slot: 27
	protected override void Execute() { }

	// RVA: 0x19DD700 Offset: 0x19DD801 VA: 0x19DD700
	public void .ctor() { }
}

