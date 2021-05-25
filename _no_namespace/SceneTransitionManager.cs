public class SceneTransitionManager : MonoBehaviour // TypeDefIndex: 6851
{
	// Fields
	private static SceneTransitionManager _Outer; // 0x0
	private static AsyncOperationHandle<SceneInstance> NextScene; // 0x8
	private static Scene RootScene; // 0x20
	private static string NextSceneName; // 0x28
	private static List<AsyncOperationHandle<SceneInstance>> NextAddScenes; // 0x30
	private static List<AsyncOperationHandle<SceneInstance>> UnloadScenes; // 0x38
	private static bool isUsePreloadScene; // 0x40
	private static bool IsTransitionComplete; // 0x41
	[CompilerGeneratedAttribute] // RVA: 0x15FD60 Offset: 0x15FE61 VA: 0x15FD60
	private static bool <IsRemoveComplete>k__BackingField; // 0x42
	public static bool TitleStartWithShortPlay; // 0x43
	private static Stack<string> _SceneNameStack; // 0x48
	private static Stack<AsyncOperationHandle<SceneInstance>> _SceneAoHandleStack; // 0x50
	private static Stack<GameObject[]> _SceneStreamersStack; // 0x58
	private static Stack<string[]> _AddSceneNameStack; // 0x60
	private static Stack<AsyncOperationHandle<SceneInstance>[]> _AddAoHandleStack; // 0x68
	private static List<AsyncOperationHandle<SceneInstance>[]> KeepAddScenes; // 0x70
	private static List<string[]> KeepAddSceneNames; // 0x78
	private static List<SceneTransitionManager.SceneGameObjectEnabled> SceneObjectEnabledList; // 0x80
	private static Func<IEnumerator> ObjectLoadFunc; // 0x88
	private static Action LoadComplateAction; // 0x90

	// Properties
	private static SceneTransitionManager Outer { get; }
	public static bool IsUsePreloadScene { get; set; }
	public static bool IsRemoveComplete { get; set; }
	public static bool IsCreatedNaviMeshSurfaces { get; }
	public static Stack<string> SceneNameStack { get; }
	public static string CurrentSceneNameStack { get; }
	public static Stack<AsyncOperationHandle<SceneInstance>> SceneAoHandleStack { get; }
	public static AsyncOperationHandle<SceneInstance> CurrentSceneAoHandleStack { get; }
	public static Stack<GameObject[]> SceneStreamersStack { get; }
	public static Stack<string[]> AddSceneNameStack { get; }
	public static string[] CurrentAddSceneNameStack { get; }
	public static Stack<AsyncOperationHandle<SceneInstance>[]> AddAoHandleStack { get; }
	public static AsyncOperationHandle<SceneInstance>[] CurrentAddAoHandleStack { get; }

	// Methods

	// RVA: 0x20FC170 Offset: 0x20FC271 VA: 0x20FC170
	private static SceneTransitionManager get_Outer() { }

	// RVA: 0x20FC2B0 Offset: 0x20FC3B1 VA: 0x20FC2B0
	public static bool get_IsUsePreloadScene() { }

	// RVA: 0x20FC320 Offset: 0x20FC421 VA: 0x20FC320
	private static void set_IsUsePreloadScene(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19D5A0 Offset: 0x19D6A1 VA: 0x19D5A0
	// RVA: 0x20FC390 Offset: 0x20FC491 VA: 0x20FC390
	public static bool get_IsRemoveComplete() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D5B0 Offset: 0x19D6B1 VA: 0x19D5B0
	// RVA: 0x20FC400 Offset: 0x20FC501 VA: 0x20FC400
	private static void set_IsRemoveComplete(bool value) { }

	// RVA: 0x20FC470 Offset: 0x20FC571 VA: 0x20FC470
	public static bool get_IsCreatedNaviMeshSurfaces() { }

	// RVA: 0x20FC4E0 Offset: 0x20FC5E1 VA: 0x20FC4E0
	public static Stack<string> get_SceneNameStack() { }

	// RVA: 0x20FC550 Offset: 0x20FC651 VA: 0x20FC550
	public static string get_CurrentSceneNameStack() { }

	// RVA: 0x20FC650 Offset: 0x20FC751 VA: 0x20FC650
	public static Stack<AsyncOperationHandle<SceneInstance>> get_SceneAoHandleStack() { }

	// RVA: 0x20FC6C0 Offset: 0x20FC7C1 VA: 0x20FC6C0
	public static AsyncOperationHandle<SceneInstance> get_CurrentSceneAoHandleStack() { }

	// RVA: 0x20FC750 Offset: 0x20FC851 VA: 0x20FC750
	public static Stack<GameObject[]> get_SceneStreamersStack() { }

	// RVA: 0x20FC7C0 Offset: 0x20FC8C1 VA: 0x20FC7C0
	public static Stack<string[]> get_AddSceneNameStack() { }

	// RVA: 0x20FC830 Offset: 0x20FC931 VA: 0x20FC830
	public static string[] get_CurrentAddSceneNameStack() { }

	// RVA: 0x20FC900 Offset: 0x20FCA01 VA: 0x20FC900
	public static Stack<AsyncOperationHandle<SceneInstance>[]> get_AddAoHandleStack() { }

	// RVA: 0x20FC970 Offset: 0x20FCA71 VA: 0x20FC970
	public static AsyncOperationHandle<SceneInstance>[] get_CurrentAddAoHandleStack() { }

	// RVA: 0x20FCA40 Offset: 0x20FCB41 VA: 0x20FCA40
	private void Awake() { }

	// RVA: 0x20FCAC0 Offset: 0x20FCBC1 VA: 0x20FCAC0
	public static void InactiveSceneGameObject(Scene scene) { }

	// RVA: 0x20FCF60 Offset: 0x20FD061 VA: 0x20FCF60
	public static void InactiveSceneGameObject() { }

	// RVA: 0x20FD100 Offset: 0x20FD201 VA: 0x20FD100
	public static void ActiveSceneGameObject(Scene scene) { }

	// RVA: 0x20FD3E0 Offset: 0x20FD4E1 VA: 0x20FD3E0
	public static void ActiveSceneGameObject() { }

	// RVA: 0x20FD580 Offset: 0x20FD681 VA: 0x20FD580
	private static void LoadAddScenes(string[] addSceneNames) { }

	[IteratorStateMachineAttribute] // RVA: 0x19D5C0 Offset: 0x19D6C1 VA: 0x19D5C0
	// RVA: 0x20FD780 Offset: 0x20FD881 VA: 0x20FD780
	private static IEnumerator UnloadWait(bool isUnload) { }

	// RVA: 0x20FD830 Offset: 0x20FD931 VA: 0x20FD830
	private static bool RemoveKeepAddScene() { }

	// RVA: 0x20FDBE0 Offset: 0x20FDCE1 VA: 0x20FDBE0
	public static void TransitionScene(string sceneName, Action action, string[] addSceneNames, Func<IEnumerator> objectLoadFunc) { }

	[IteratorStateMachineAttribute] // RVA: 0x19D630 Offset: 0x19D731 VA: 0x19D630
	// RVA: 0x20FDC90 Offset: 0x20FDD91 VA: 0x20FDC90
	private static IEnumerator TransitionSceneAsync(string sceneName, Action action, string[] addSceneNames_, Func<IEnumerator> objectLoadFunc) { }

	// RVA: 0x20FDD90 Offset: 0x20FDE91 VA: 0x20FDD90
	public static string[] AddSceneNamesFieldMap(string[] addSceneNames_) { }

	// RVA: 0x20FDDA0 Offset: 0x20FDEA1 VA: 0x20FDDA0
	public static void TransitionSceneKeep(string sceneName, Action action, string[] addSceneNames, Func<IEnumerator> objectLoadFunc) { }

	[IteratorStateMachineAttribute] // RVA: 0x19D6A0 Offset: 0x19D7A1 VA: 0x19D6A0
	// RVA: 0x20FDE50 Offset: 0x20FDF51 VA: 0x20FDE50
	private static IEnumerator TransitionSceneKeepAsync(string sceneName, Action action, string[] addSceneNames_, Func<IEnumerator> objectLoadFunc) { }

	// RVA: 0x20FDF50 Offset: 0x20FE051 VA: 0x20FDF50
	private static void ActiveNext(AsyncOperationHandle<SceneInstance> op) { }

	// RVA: 0x20FDFC0 Offset: 0x20FE0C1 VA: 0x20FDFC0
	private static void ActiveNext() { }

	[IteratorStateMachineAttribute] // RVA: 0x19D710 Offset: 0x19D811 VA: 0x19D710
	// RVA: 0x20FE220 Offset: 0x20FE321 VA: 0x20FE220
	private static IEnumerator LoadSceneBgm(string sceneName) { }

	// RVA: 0x20FE2B0 Offset: 0x20FE3B1 VA: 0x20FE2B0
	private static void SetSceneBgm(string sceneName) { }

	[IteratorStateMachineAttribute] // RVA: 0x19D780 Offset: 0x19D881 VA: 0x19D780
	// RVA: 0x20FE310 Offset: 0x20FE411 VA: 0x20FE310
	private static IEnumerator WaitAsyncLoad() { }

	// RVA: 0x20FE3A0 Offset: 0x20FE4A1 VA: 0x20FE3A0
	public static void PushStackScene(string sceneName, Action action, string[] addSceneNames_, Func<IEnumerator> objectLoadFunc) { }

	[IteratorStateMachineAttribute] // RVA: 0x19D7F0 Offset: 0x19D8F1 VA: 0x19D7F0
	// RVA: 0x20FE450 Offset: 0x20FE551 VA: 0x20FE450
	private static IEnumerator PushStackSceneAsync(string sceneName, Action action, string[] addSceneNames_, Func<IEnumerator> objectLoadFunc) { }

	// RVA: 0x20FE550 Offset: 0x20FE651 VA: 0x20FE550
	public static void PopStackScene() { }

	// RVA: 0x20FEE70 Offset: 0x20FEF71 VA: 0x20FEE70
	public static void AddScene(string sceneName, Action action, string[] addSceneNames_, Func<IEnumerator> objectLoadFunc) { }

	[IteratorStateMachineAttribute] // RVA: 0x19D860 Offset: 0x19D961 VA: 0x19D860
	// RVA: 0x20FF4C0 Offset: 0x20FF5C1 VA: 0x20FF4C0
	private static IEnumerator WaitAsyncLoadAddScene() { }

	// RVA: 0x20FF550 Offset: 0x20FF651 VA: 0x20FF550
	public static bool IsTransitionCompleted(bool isCheckStreamer = True) { }

	// RVA: 0x20FF640 Offset: 0x20FF741 VA: 0x20FF640
	public static void UnloadAllScene() { }

	// RVA: 0x2100110 Offset: 0x2100211 VA: 0x2100110
	public static void BeforeSaveFieldGameData() { }

	// RVA: 0x2100120 Offset: 0x2100221 VA: 0x2100120
	public static void AfterLoadFieldGameData(bool isSceneChange) { }

	// RVA: 0x2100130 Offset: 0x2100231 VA: 0x2100130
	public static void InitializeForLoadGame() { }

	// RVA: 0x21002C0 Offset: 0x21003C1 VA: 0x21002C0
	public void .ctor() { }

	// RVA: 0x21002D0 Offset: 0x21003D1 VA: 0x21002D0
	private static void .cctor() { }
}

