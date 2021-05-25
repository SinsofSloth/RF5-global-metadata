public class MainScene : SingletonMonoBehaviour<MainScene> // TypeDefIndex: 7713
{
	// Fields
	private MainScene.MODE m_mode; // 0x18
	private MainScene.SCENE m_currentScene; // 0x1C
	private MainScene.SCENE m_nextScene; // 0x20
	[SerializeField] // RVA: 0x168C80 Offset: 0x168D81 VA: 0x168C80
	private Camera m_Camera; // 0x28
	[SerializeField] // RVA: 0x168C90 Offset: 0x168D91 VA: 0x168C90
	private AudioListener m_AudioListener; // 0x30
	[SerializeField] // RVA: 0x168CA0 Offset: 0x168DA1 VA: 0x168CA0
	public string[] m_SceneNames; // 0x38
	private GameObject m_FadeCanvas_GameObject; // 0x40
	private AsyncOperationHandle<SceneInstance> m_aoHandle; // 0x48
	private Scene m_activeScene; // 0x60
	private bool UnloadDone; // 0x64
	private GameObject m_LogoPrefab; // 0x68
	private bool m_IsLogoWait; // 0x70
	private const int LogoLoadPriority = 100;
	private const int SYSTEM_PAUSE_TARGET_FRAME_RATE = 60;
	private const int PLAYABLE_TARGET_FRAME_RATE = 30;
	private const int SYSTEM_PAUSE_VSYNC_COUNT = 1;
	private const int PLAYABLE_VSYNC_COUNT = 2;
	private const ThreadPriority SYSTEM_PAUSE_BACKGROUND_LOADING_PRIORITY = 4;
	private const ThreadPriority GAME_PAUSE_BACKGROUND_LOADING_PRIORITY = 2;
	private const ThreadPriority PLAYABLE_BACKGROUND_LOADING_PRIORITY = 2;
	private ThreadPriority BackgroundLoadingPriority; // 0x74
	private int TargetFrameRate; // 0x78
	private int VSyncCount; // 0x7C
	private static bool oldSystemPause; // 0x0
	private static bool oldGamePause; // 0x1

	// Methods

	// RVA: 0x1E109C0 Offset: 0x1E10AC1 VA: 0x1E109C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E10B50 Offset: 0x1E10C51 VA: 0x1E10B50
	private void Start() { }

	// RVA: 0x1E10C00 Offset: 0x1E10D01 VA: 0x1E10C00
	private void OnDestroy() { }

	// RVA: 0x1E10C10 Offset: 0x1E10D11 VA: 0x1E10C10
	public void AllDestroy() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A2940 Offset: 0x1A2A41 VA: 0x1A2940
	// RVA: 0x1E10C20 Offset: 0x1E10D21 VA: 0x1E10C20
	private IEnumerator UnloadOperation() { }

	// RVA: 0x1E10CD0 Offset: 0x1E10DD1 VA: 0x1E10CD0
	private void Update() { }

	// RVA: 0x1E115C0 Offset: 0x1E116C1 VA: 0x1E115C0
	public static void LoadScene(MainScene.SCENE nextScene) { }

	// RVA: 0x1E11630 Offset: 0x1E11731 VA: 0x1E11630
	private void InstanceLoadScene(MainScene.SCENE nextScene) { }

	// RVA: 0x1E11640 Offset: 0x1E11741 VA: 0x1E11640
	public static void SetEnableCamera(bool value) { }

	// RVA: 0x1E116B0 Offset: 0x1E117B1 VA: 0x1E116B0
	public static void SetEnableAudioListener(bool value) { }

	// RVA: 0x1E10AE0 Offset: 0x1E10BE1 VA: 0x1E10AE0
	private static void SetApplicationPreferenceToSystemPause() { }

	// RVA: 0x1E11830 Offset: 0x1E11931 VA: 0x1E11830
	private static void SetApplicationPreferenceToGamePause() { }

	// RVA: 0x1E118A0 Offset: 0x1E119A1 VA: 0x1E118A0
	private static void SetApplicationPreferenceToPlayable() { }

	// RVA: 0x1E11720 Offset: 0x1E11821 VA: 0x1E11720
	private static void SetApplicationPreference(ThreadPriority priority, int frameRate, int vsyncCount) { }

	// RVA: 0x1E11910 Offset: 0x1E11A11 VA: 0x1E11910
	public static void UpdateApplicationPreference() { }

	// RVA: 0x1E11C80 Offset: 0x1E11D81 VA: 0x1E11C80
	public void .ctor() { }

	// RVA: 0x1E11CF0 Offset: 0x1E11DF1 VA: 0x1E11CF0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A29B0 Offset: 0x1A2AB1 VA: 0x1A29B0
	// RVA: 0x1E11D00 Offset: 0x1E11E01 VA: 0x1E11D00
	private void <Update>b__30_0(AssetHandle<GameObject> handle) { }
}

