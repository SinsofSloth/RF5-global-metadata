[HelpURLAttribute] // RVA: 0x147A80 Offset: 0x147B81 VA: 0x147A80
public class RF5Streamer : Streamer // TypeDefIndex: 9080
{
	// Fields
	private Dictionary<int, SceneInstance> loadSceneDictionary; // 0x128
	private Dictionary<int, string> loadRequest; // 0x130
	public RF5Streamer OverLapStreamer; // 0x138

	// Properties
	public bool IsInit { get; }
	public bool IsCurrentLoadEnd { get; }
	public bool IsLoadComplete { get; }

	// Methods

	// RVA: 0x1DF86C0 Offset: 0x1DF87C1 VA: 0x1DF86C0
	public bool get_IsInit() { }

	// RVA: 0x1DF3230 Offset: 0x1DF3331 VA: 0x1DF3230
	public bool get_IsCurrentLoadEnd() { }

	// RVA: 0x1DF86D0 Offset: 0x1DF87D1 VA: 0x1DF86D0
	public bool get_IsLoadComplete() { }

	// RVA: 0x1DF8750 Offset: 0x1DF8851 VA: 0x1DF8750
	private void OnDestroy() { }

	// RVA: 0x1DF8760 Offset: 0x1DF8861 VA: 0x1DF8760 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1DF8810 Offset: 0x1DF8911 VA: 0x1DF8810
	private int mod(int x, int m) { }

	// RVA: 0x1DF8830 Offset: 0x1DF8931 VA: 0x1DF8830 Slot: 5
	public override void AddSceneGO(string sceneName, GameObject sceneGO) { }

	// RVA: 0x1DF8880 Offset: 0x1DF8981 VA: 0x1DF8880
	private void SetEnabledOverLap(string sceneName, GameObject sceneGO, bool setEnabled) { }

	// RVA: 0x1DF8BF0 Offset: 0x1DF8CF1 VA: 0x1DF8BF0
	private void Update() { }

	// RVA: 0x1DF8C00 Offset: 0x1DF8D01 VA: 0x1DF8C00 Slot: 6
	protected override void LoadLevelAsyncManage() { }

	// RVA: 0x1DF8E30 Offset: 0x1DF8F31 VA: 0x1DF8E30
	protected void OnLoadCompleted(AsyncOperationHandle<SceneInstance> handle) { }

	// RVA: 0x1DF9060 Offset: 0x1DF9161 VA: 0x1DF9060 Slot: 7
	protected override void SceneLoading() { }

	// RVA: 0x1DF9A80 Offset: 0x1DF9B81 VA: 0x1DF9A80
	public void CheckSceneUnloading() { }

	// RVA: 0x1DF9C80 Offset: 0x1DF9D81 VA: 0x1DF9C80 Slot: 8
	public override void SceneUnloading() { }

	// RVA: 0x1DFA790 Offset: 0x1DFA891 VA: 0x1DFA790 Slot: 9
	public override void UnloadAllScenes() { }

	// RVA: 0x1DFAF10 Offset: 0x1DFB011 VA: 0x1DFAF10
	public void SetEnableLoadData(bool enable) { }

	// RVA: 0x1DFB110 Offset: 0x1DFB211 VA: 0x1DFB110
	public void .ctor() { }
}

