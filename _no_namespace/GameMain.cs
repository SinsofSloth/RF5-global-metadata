public class GameMain : SingletonMonoBehaviour<GameMain> // TypeDefIndex: 7710
{
	// Fields
	[SerializeField] // RVA: 0x168C50 Offset: 0x168D51 VA: 0x168C50
	private GameObject[] AwakeOnScenes; // 0x18
	[SerializeField] // RVA: 0x168C60 Offset: 0x168D61 VA: 0x168C60
	private Transform ObjectRootTransform; // 0x20
	public const string SceneName = "GameMain";
	[CompilerGeneratedAttribute] // RVA: 0x168C70 Offset: 0x168D71 VA: 0x168C70
	private string <CurrentSceneName>k__BackingField; // 0x28
	private GameMain.MODE m_mode; // 0x30
	private Scene m_activeScene; // 0x34
	private bool m_IsSetPosition; // 0x38
	private GameMain.SCENE m_currentScene; // 0x3C
	private GameMain.SCENE m_nextScene; // 0x40

	// Properties
	public static bool IsInit { get; }
	public static Scene Scene { get; }
	public string CurrentSceneName { get; set; }
	public static Transform ObjectRoot { get; }

	// Methods

	// RVA: 0x22A2F50 Offset: 0x22A3051 VA: 0x22A2F50
	public static bool get_IsInit() { }

	// RVA: 0x22A3000 Offset: 0x22A3101 VA: 0x22A3000
	public static Scene get_Scene() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2920 Offset: 0x1A2A21 VA: 0x1A2920
	// RVA: 0x22A3080 Offset: 0x22A3181 VA: 0x22A3080
	public string get_CurrentSceneName() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2930 Offset: 0x1A2A31 VA: 0x1A2930
	// RVA: 0x22A3090 Offset: 0x22A3191 VA: 0x22A3090
	private void set_CurrentSceneName(string value) { }

	// RVA: 0x22A30A0 Offset: 0x22A31A1 VA: 0x22A30A0
	public static Transform get_ObjectRoot() { }

	// RVA: 0x22A3100 Offset: 0x22A3201 VA: 0x22A3100
	private void InitializeGameMain() { }

	// RVA: 0x22A3500 Offset: 0x22A3601 VA: 0x22A3500
	private bool IsInitializeManager() { }

	// RVA: 0x22A3770 Offset: 0x22A3871 VA: 0x22A3770
	private void InitializeAfterSceneLoaded() { }

	// RVA: 0x22A3B30 Offset: 0x22A3C31 VA: 0x22A3B30
	private bool IsOpenScene() { }

	// RVA: 0x22A3C00 Offset: 0x22A3D01 VA: 0x22A3C00 Slot: 4
	protected override void Awake() { }

	// RVA: 0x22A3D10 Offset: 0x22A3E11 VA: 0x22A3D10
	private void Start() { }

	// RVA: 0x22A3D80 Offset: 0x22A3E81 VA: 0x22A3D80
	private void OnDestroy() { }

	// RVA: 0x22A3DA0 Offset: 0x22A3EA1 VA: 0x22A3DA0
	public static void EndScene() { }

	// RVA: 0x22A3D90 Offset: 0x22A3E91 VA: 0x22A3D90
	public void AllDestroy() { }

	// RVA: 0x22A3EA0 Offset: 0x22A3FA1 VA: 0x22A3EA0
	private void FieldLoadStart() { }

	// RVA: 0x22A4050 Offset: 0x22A4151 VA: 0x22A4050
	private void Update() { }

	// RVA: 0x22A45F0 Offset: 0x22A46F1 VA: 0x22A45F0
	public void .ctor() { }
}

