[NativeHeaderAttribute] // RVA: 0xC79E0 Offset: 0xC7AE1 VA: 0xC79E0
[RequiredByNativeCodeAttribute] // RVA: 0xC79E0 Offset: 0xC7AE1 VA: 0xC79E0
public class SceneManager // TypeDefIndex: 3122
{
	// Fields
	internal static bool s_AllowLoadScene; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0xCB280 Offset: 0xCB381 VA: 0xCB280
	[CompilerGeneratedAttribute] // RVA: 0xCB280 Offset: 0xCB381 VA: 0xCB280
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0xCB2C0 Offset: 0xCB3C1 VA: 0xCB2C0
	[DebuggerBrowsableAttribute] // RVA: 0xCB2C0 Offset: 0xCB3C1 VA: 0xCB2C0
	private static UnityAction<Scene> sceneUnloaded; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xCB300 Offset: 0xCB401 VA: 0xCB300
	[DebuggerBrowsableAttribute] // RVA: 0xCB300 Offset: 0xCB401 VA: 0xCB300
	private static UnityAction<Scene, Scene> activeSceneChanged; // 0x18

	// Properties
	public static int sceneCount { get; }
	public static int sceneCountInBuildSettings { get; }

	// Methods

	[NativeHeaderAttribute] // RVA: 0xD95B0 Offset: 0xD96B1 VA: 0xD95B0
	[StaticAccessorAttribute] // RVA: 0xD95B0 Offset: 0xD96B1 VA: 0xD95B0
	[NativeMethodAttribute] // RVA: 0xD95B0 Offset: 0xD96B1 VA: 0xD95B0
	// RVA: 0x2A24C60 Offset: 0x2A24D61 VA: 0x2A24C60
	public static int get_sceneCount() { }

	[NativeMethodAttribute] // RVA: 0xD9640 Offset: 0xD9741 VA: 0xD9640
	[StaticAccessorAttribute] // RVA: 0xD9640 Offset: 0xD9741 VA: 0xD9640
	// RVA: 0x2A24CA0 Offset: 0x2A24DA1 VA: 0x2A24CA0
	public static int get_sceneCountInBuildSettings() { }

	[StaticAccessorAttribute] // RVA: 0xD96B0 Offset: 0xD97B1 VA: 0xD96B0
	// RVA: 0x2A24CE0 Offset: 0x2A24DE1 VA: 0x2A24CE0
	public static Scene GetActiveScene() { }

	[NativeThrowsAttribute] // RVA: 0xD96F0 Offset: 0xD97F1 VA: 0xD96F0
	[StaticAccessorAttribute] // RVA: 0xD96F0 Offset: 0xD97F1 VA: 0xD96F0
	// RVA: 0x2A24DD0 Offset: 0x2A24ED1 VA: 0x2A24DD0
	public static bool SetActiveScene(Scene scene) { }

	[StaticAccessorAttribute] // RVA: 0xD9740 Offset: 0xD9841 VA: 0xD9740
	// RVA: 0x2A24EC0 Offset: 0x2A24FC1 VA: 0x2A24EC0
	public static Scene GetSceneByName(string name) { }

	[NativeThrowsAttribute] // RVA: 0xD9780 Offset: 0xD9881 VA: 0xD9780
	[StaticAccessorAttribute] // RVA: 0xD9780 Offset: 0xD9881 VA: 0xD9780
	// RVA: 0x2A24FC0 Offset: 0x2A250C1 VA: 0x2A24FC0
	public static Scene GetSceneAt(int index) { }

	[StaticAccessorAttribute] // RVA: 0xD97D0 Offset: 0xD98D1 VA: 0xD97D0
	[NativeThrowsAttribute] // RVA: 0xD97D0 Offset: 0xD98D1 VA: 0xD97D0
	// RVA: 0x2A250C0 Offset: 0x2A251C1 VA: 0x2A250C0
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	// RVA: 0x2A251C0 Offset: 0x2A252C1 VA: 0x2A251C0
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x2A25310 Offset: 0x2A25411 VA: 0x2A25310
	private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

	[NativeThrowsAttribute] // RVA: 0xD9820 Offset: 0xD9921 VA: 0xD9820
	[StaticAccessorAttribute] // RVA: 0xD9820 Offset: 0xD9921 VA: 0xD9820
	// RVA: 0x2A25470 Offset: 0x2A25571 VA: 0x2A25470
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	[CompilerGeneratedAttribute] // RVA: 0xD9870 Offset: 0xD9971 VA: 0xD9870
	// RVA: 0x2A25570 Offset: 0x2A25671 VA: 0x2A25570
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD9880 Offset: 0xD9981 VA: 0xD9880
	// RVA: 0x2A25660 Offset: 0x2A25761 VA: 0x2A25660
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD9890 Offset: 0xD9991 VA: 0xD9890
	// RVA: 0x2A25750 Offset: 0x2A25851 VA: 0x2A25750
	public static void add_sceneUnloaded(UnityAction<Scene> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD98A0 Offset: 0xD99A1 VA: 0xD98A0
	// RVA: 0x2A25840 Offset: 0x2A25941 VA: 0x2A25840
	public static void remove_sceneUnloaded(UnityAction<Scene> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD98B0 Offset: 0xD99B1 VA: 0xD98B0
	// RVA: 0x2A25930 Offset: 0x2A25A31 VA: 0x2A25930
	public static void add_activeSceneChanged(UnityAction<Scene, Scene> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD98C0 Offset: 0xD99C1 VA: 0xD98C0
	// RVA: 0x2A25A20 Offset: 0x2A25B21 VA: 0x2A25A20
	public static void remove_activeSceneChanged(UnityAction<Scene, Scene> value) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD98D0 Offset: 0xD99D1 VA: 0xD98D0
	// RVA: 0x2A25B10 Offset: 0x2A25C11 VA: 0x2A25B10
	public static void LoadScene(string sceneName) { }

	// RVA: 0x2A25B80 Offset: 0x2A25C81 VA: 0x2A25B80
	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD98E0 Offset: 0xD99E1 VA: 0xD98E0
	// RVA: 0x2A25D50 Offset: 0x2A25E51 VA: 0x2A25D50
	public static void LoadScene(int sceneBuildIndex) { }

	// RVA: 0x2A25DC0 Offset: 0x2A25EC1 VA: 0x2A25DC0
	public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters) { }

	// RVA: 0x2A25F90 Offset: 0x2A26091 VA: 0x2A25F90
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	// RVA: 0x2A26010 Offset: 0x2A26111 VA: 0x2A26010
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x2A26130 Offset: 0x2A26231 VA: 0x2A26130
	public static AsyncOperation UnloadSceneAsync(string sceneName) { }

	// RVA: 0x2A26260 Offset: 0x2A26361 VA: 0x2A26260
	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD98F0 Offset: 0xD99F1 VA: 0xD98F0
	// RVA: 0x2A26360 Offset: 0x2A26461 VA: 0x2A26360
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9900 Offset: 0xD9A01 VA: 0xD9900
	// RVA: 0x2A26440 Offset: 0x2A26541 VA: 0x2A26440
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9910 Offset: 0xD9A11 VA: 0xD9910
	// RVA: 0x2A26510 Offset: 0x2A26611 VA: 0x2A26510
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x2A265F0 Offset: 0x2A266F1 VA: 0x2A265F0
	private static void .cctor() { }

	// RVA: 0x2A24D80 Offset: 0x2A24E81 VA: 0x2A24D80
	private static void GetActiveScene_Injected(out Scene ret) { }

	// RVA: 0x2A24E70 Offset: 0x2A24F71 VA: 0x2A24E70
	private static bool SetActiveScene_Injected(ref Scene scene) { }

	// RVA: 0x2A24F70 Offset: 0x2A25071 VA: 0x2A24F70
	private static void GetSceneByName_Injected(string name, out Scene ret) { }

	// RVA: 0x2A25070 Offset: 0x2A25171 VA: 0x2A25070
	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	// RVA: 0x2A25170 Offset: 0x2A25271 VA: 0x2A25170
	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	// RVA: 0x2A25520 Offset: 0x2A25621 VA: 0x2A25520
	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) { }
}

