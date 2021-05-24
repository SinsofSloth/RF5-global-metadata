[DefaultExecutionOrder] // RVA: 0x14A4B0 Offset: 0x14A5B1 VA: 0x14A4B0
public class AssetManager : MonoBehaviour // TypeDefIndex: 10222
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x180890 Offset: 0x180991 VA: 0x180890
	private static bool <UnloadDone>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1808A0 Offset: 0x1809A1 VA: 0x1808A0
	private static bool <IsReady>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x1808B0 Offset: 0x1809B1 VA: 0x1808B0
	private static SystemLanguage <Language>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x1808C0 Offset: 0x1809C1 VA: 0x1808C0
	private static bool <IsLoading>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x1808D0 Offset: 0x1809D1 VA: 0x1808D0
	private static bool <LoadingOn>k__BackingField; // 0x9
	[CompilerGeneratedAttribute] // RVA: 0x1808E0 Offset: 0x1809E1 VA: 0x1808E0
	private static int <LoadingCount>k__BackingField; // 0xC
	[SerializeField] // RVA: 0x1808F0 Offset: 0x1809F1 VA: 0x1808F0
	private AssetReference AssetTableReference; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x180900 Offset: 0x180A01 VA: 0x180900
	private static AssetDataTable <AssetKeys>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x180910 Offset: 0x180A11 VA: 0x180910
	private static AssetManager <Instance>k__BackingField; // 0x18
	private List<AssetHandle> LoadList; // 0x20
	private List<int> LoadCountList; // 0x28
	private List<AssetHandle> EntryList; // 0x30
	private List<AssetHandle> RemoveList; // 0x38
	private List<AssetHandle> CompList; // 0x40
	[SerializeField] // RVA: 0x180920 Offset: 0x180A21 VA: 0x180920
	[HeaderAttribute] // RVA: 0x180920 Offset: 0x180A21 VA: 0x180920
	private int UPDATE_LOADING_MAX; // 0x48
	private int LoadMax; // 0x4C
	private int LoadCount; // 0x50
	[SerializeField] // RVA: 0x180970 Offset: 0x180A71 VA: 0x180970
	[HeaderAttribute] // RVA: 0x180970 Offset: 0x180A71 VA: 0x180970
	private int PLAYABLE_LOADING_MAX; // 0x54

	// Properties
	public static bool UnloadDone { get; set; }
	public static bool IsReady { get; set; }
	public static SystemLanguage Language { get; set; }
	public static bool IsLoading { get; set; }
	public static bool LoadingOn { get; set; }
	public static int LoadingMax { get; }
	public static int LoadingCount { get; set; }
	public static AssetDataTable AssetKeys { get; set; }
	public static AssetManager Instance { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD880 Offset: 0x1AD981 VA: 0x1AD880
	// RVA: 0x2191310 Offset: 0x2191411 VA: 0x2191310
	public static bool get_UnloadDone() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD890 Offset: 0x1AD991 VA: 0x1AD890
	// RVA: 0x2191380 Offset: 0x2191481 VA: 0x2191380
	private static void set_UnloadDone(bool value) { }

	// RVA: 0x21913F0 Offset: 0x21914F1 VA: 0x21913F0
	public static void CleanUp() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD8A0 Offset: 0x1AD9A1 VA: 0x1AD8A0
	// RVA: 0x21915D0 Offset: 0x21916D1 VA: 0x21915D0
	private IEnumerator UnloadOperation() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD910 Offset: 0x1ADA11 VA: 0x1AD910
	// RVA: 0x2191630 Offset: 0x2191731 VA: 0x2191630
	public static bool get_IsReady() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD920 Offset: 0x1ADA21 VA: 0x1AD920
	// RVA: 0x21916A0 Offset: 0x21917A1 VA: 0x21916A0
	private static void set_IsReady(bool value) { }

	// RVA: 0x2190AF0 Offset: 0x2190BF1 VA: 0x2190AF0
	public static string Key(int id, SystemLanguage lang) { }

	// RVA: -1 Offset: -1
	public static void Entry<T>(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority = 0, bool scene_only = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1400 Offset: 0x21D1501 VA: 0x21D1400
	|-AssetManager.Entry<object>
	*/

	// RVA: -1 Offset: -1
	public static void Entry<T>(int id, UnityAction<AssetHandle<T>> callback, int priority = 0, bool scene_only = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D12D0 Offset: 0x21D13D1 VA: 0x21D12D0
	|-AssetManager.Entry<ExternalBehavior>
	|-AssetManager.Entry<NPCCallingNameTextData>
	|-AssetManager.Entry<NpcLifeCycleData>
	|-AssetManager.Entry<PlayerCallingNameTextData>
	|-AssetManager.Entry<object>
	|-AssetManager.Entry<TimelineMsgData>
	|-AssetManager.Entry<TutorialDataTableArray>
	|-AssetManager.Entry<UISystemTextData>
	|-AssetManager.Entry<AudioClip>
	|-AssetManager.Entry<Font>
	|-AssetManager.Entry<GameObject>
	|-AssetManager.Entry<ScriptableObject>
	|-AssetManager.Entry<Sprite>
	|-AssetManager.Entry<TextAsset>
	|-AssetManager.Entry<Texture>
	|-AssetManager.Entry<SpriteAtlas>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<T> Entry<T>(string key, UnityAction<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FB460 Offset: 0x34FB561 VA: 0x34FB460
	|-AssetManager.Entry<object>
	*/

	// RVA: 0x218B6C0 Offset: 0x218B7C1 VA: 0x218B6C0
	public static void Remove(int id) { }

	// RVA: -1 Offset: -1
	public static void Remove<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1790 Offset: 0x21D1891 VA: 0x21D1790
	|-AssetManager.Remove<NpcLifeCycleData>
	|-AssetManager.Remove<object>
	|-AssetManager.Remove<TutorialDataTableArray>
	|-AssetManager.Remove<GameObject>
	|-AssetManager.Remove<Sprite>
	|-AssetManager.Remove<TextAsset>
	|-AssetManager.Remove<Texture>
	|-AssetManager.Remove<SpriteAtlas>
	*/

	// RVA: 0x21917D0 Offset: 0x21918D1 VA: 0x21917D0
	public static void RemoveAll() { }

	// RVA: -1 Offset: -1
	public static T GetResult<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C1570 Offset: 0x23C1671 VA: 0x23C1570
	|-AssetManager.GetResult<object>
	|-AssetManager.GetResult<GameObject>
	|-AssetManager.GetResult<TextAsset>
	|-AssetManager.GetResult<SpriteAtlas>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD930 Offset: 0x1ADA31 VA: 0x1AD930
	// RVA: 0x2191A50 Offset: 0x2191B51 VA: 0x2191A50
	public static SystemLanguage get_Language() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD940 Offset: 0x1ADA41 VA: 0x1AD940
	// RVA: 0x2191AC0 Offset: 0x2191BC1 VA: 0x2191AC0
	public static void set_Language(SystemLanguage value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD950 Offset: 0x1ADA51 VA: 0x1AD950
	// RVA: 0x2191B30 Offset: 0x2191C31 VA: 0x2191B30
	public static bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD960 Offset: 0x1ADA61 VA: 0x1AD960
	// RVA: 0x2191BA0 Offset: 0x2191CA1 VA: 0x2191BA0
	protected static void set_IsLoading(bool value) { }

	// RVA: 0x2191C10 Offset: 0x2191D11 VA: 0x2191C10
	public static void AddScene(string key, UnityAction<bool, SceneInstance> complete) { }

	// RVA: 0x2191D40 Offset: 0x2191E41 VA: 0x2191D40
	public static void RemoveScene(SceneInstance scene) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD970 Offset: 0x1ADA71 VA: 0x1AD970
	// RVA: 0x2191E90 Offset: 0x2191F91 VA: 0x2191E90
	private static IEnumerator UnloadSceneAsync(SceneInstance scene) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD9E0 Offset: 0x1ADAE1 VA: 0x1AD9E0
	// RVA: 0x2191F20 Offset: 0x2192021 VA: 0x2191F20
	public static bool get_LoadingOn() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD9F0 Offset: 0x1ADAF1 VA: 0x1AD9F0
	// RVA: 0x2191F90 Offset: 0x2192091 VA: 0x2191F90
	private static void set_LoadingOn(bool value) { }

	// RVA: 0x2192000 Offset: 0x2192101 VA: 0x2192000
	public static void LoadingStart() { }

	// RVA: 0x21921B0 Offset: 0x21922B1 VA: 0x21921B0
	public static void LoadingEnd() { }

	// RVA: 0x2192350 Offset: 0x2192451 VA: 0x2192350
	public static int get_LoadingMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA00 Offset: 0x1ADB01 VA: 0x1ADA00
	// RVA: 0x2192440 Offset: 0x2192541 VA: 0x2192440
	public static int get_LoadingCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA10 Offset: 0x1ADB11 VA: 0x1ADA10
	// RVA: 0x21924B0 Offset: 0x21925B1 VA: 0x21924B0
	protected static void set_LoadingCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA20 Offset: 0x1ADB21 VA: 0x1ADA20
	// RVA: 0x2192520 Offset: 0x2192621 VA: 0x2192520
	public static AssetDataTable get_AssetKeys() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA30 Offset: 0x1ADB31 VA: 0x1ADA30
	// RVA: 0x2192590 Offset: 0x2192691 VA: 0x2192590
	private static void set_AssetKeys(AssetDataTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA40 Offset: 0x1ADB41 VA: 0x1ADA40
	// RVA: 0x2192600 Offset: 0x2192701 VA: 0x2192600
	public static AssetManager get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA50 Offset: 0x1ADB51 VA: 0x1ADA50
	// RVA: 0x2192670 Offset: 0x2192771 VA: 0x2192670
	private static void set_Instance(AssetManager value) { }

	// RVA: -1 Offset: -1
	private void LoadEntry<T>(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1660 Offset: 0x21D1761 VA: 0x21D1660
	|-AssetManager.LoadEntry<object>
	*/

	// RVA: -1 Offset: -1
	private void LoadEntry<T>(int id, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1530 Offset: 0x21D1631 VA: 0x21D1530
	|-AssetManager.LoadEntry<object>
	*/

	// RVA: 0x2191710 Offset: 0x2191811 VA: 0x2191710
	private void RemoveEntry(int id) { }

	// RVA: -1 Offset: -1
	private void RemoveEntry<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1950 Offset: 0x21D1A51 VA: 0x21D1950
	|-AssetManager.RemoveEntry<object>
	*/

	// RVA: 0x2191970 Offset: 0x2191A71 VA: 0x2191970
	private void RemoveAllAssets() { }

	// RVA: 0x21926E0 Offset: 0x21927E1 VA: 0x21926E0
	private int GetLoadingCount() { }

	// RVA: 0x2192790 Offset: 0x2192891 VA: 0x2192790
	private void Awake() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ADA60 Offset: 0x1ADB61 VA: 0x1ADA60
	// RVA: 0x2192A10 Offset: 0x2192B11 VA: 0x2192A10
	private IEnumerator Start() { }

	// RVA: 0x2192A90 Offset: 0x2192B91 VA: 0x2192A90
	private void OnDestroy() { }

	// RVA: 0x2192C10 Offset: 0x2192D11 VA: 0x2192C10
	private void Update() { }

	// RVA: 0x2193660 Offset: 0x2193761 VA: 0x2193660
	public void .ctor() { }

	// RVA: 0x21937A0 Offset: 0x21938A1 VA: 0x21937A0
	private static void .cctor() { }
}

[DefaultExecutionOrder] // RVA: 0x14A4B0 Offset: 0x14A5B1 VA: 0x14A4B0
public class AssetManager : MonoBehaviour // TypeDefIndex: 10222
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x180890 Offset: 0x180991 VA: 0x180890
	private static bool <UnloadDone>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1808A0 Offset: 0x1809A1 VA: 0x1808A0
	private static bool <IsReady>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x1808B0 Offset: 0x1809B1 VA: 0x1808B0
	private static SystemLanguage <Language>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x1808C0 Offset: 0x1809C1 VA: 0x1808C0
	private static bool <IsLoading>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x1808D0 Offset: 0x1809D1 VA: 0x1808D0
	private static bool <LoadingOn>k__BackingField; // 0x9
	[CompilerGeneratedAttribute] // RVA: 0x1808E0 Offset: 0x1809E1 VA: 0x1808E0
	private static int <LoadingCount>k__BackingField; // 0xC
	[SerializeField] // RVA: 0x1808F0 Offset: 0x1809F1 VA: 0x1808F0
	private AssetReference AssetTableReference; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x180900 Offset: 0x180A01 VA: 0x180900
	private static AssetDataTable <AssetKeys>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x180910 Offset: 0x180A11 VA: 0x180910
	private static AssetManager <Instance>k__BackingField; // 0x18
	private List<AssetHandle> LoadList; // 0x20
	private List<int> LoadCountList; // 0x28
	private List<AssetHandle> EntryList; // 0x30
	private List<AssetHandle> RemoveList; // 0x38
	private List<AssetHandle> CompList; // 0x40
	[SerializeField] // RVA: 0x180920 Offset: 0x180A21 VA: 0x180920
	[HeaderAttribute] // RVA: 0x180920 Offset: 0x180A21 VA: 0x180920
	private int UPDATE_LOADING_MAX; // 0x48
	private int LoadMax; // 0x4C
	private int LoadCount; // 0x50
	[SerializeField] // RVA: 0x180970 Offset: 0x180A71 VA: 0x180970
	[HeaderAttribute] // RVA: 0x180970 Offset: 0x180A71 VA: 0x180970
	private int PLAYABLE_LOADING_MAX; // 0x54

	// Properties
	public static bool UnloadDone { get; set; }
	public static bool IsReady { get; set; }
	public static SystemLanguage Language { get; set; }
	public static bool IsLoading { get; set; }
	public static bool LoadingOn { get; set; }
	public static int LoadingMax { get; }
	public static int LoadingCount { get; set; }
	public static AssetDataTable AssetKeys { get; set; }
	public static AssetManager Instance { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD880 Offset: 0x1AD981 VA: 0x1AD880
	// RVA: 0x2191310 Offset: 0x2191411 VA: 0x2191310
	public static bool get_UnloadDone() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD890 Offset: 0x1AD991 VA: 0x1AD890
	// RVA: 0x2191380 Offset: 0x2191481 VA: 0x2191380
	private static void set_UnloadDone(bool value) { }

	// RVA: 0x21913F0 Offset: 0x21914F1 VA: 0x21913F0
	public static void CleanUp() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD8A0 Offset: 0x1AD9A1 VA: 0x1AD8A0
	// RVA: 0x21915D0 Offset: 0x21916D1 VA: 0x21915D0
	private IEnumerator UnloadOperation() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD910 Offset: 0x1ADA11 VA: 0x1AD910
	// RVA: 0x2191630 Offset: 0x2191731 VA: 0x2191630
	public static bool get_IsReady() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD920 Offset: 0x1ADA21 VA: 0x1AD920
	// RVA: 0x21916A0 Offset: 0x21917A1 VA: 0x21916A0
	private static void set_IsReady(bool value) { }

	// RVA: 0x2190AF0 Offset: 0x2190BF1 VA: 0x2190AF0
	public static string Key(int id, SystemLanguage lang) { }

	// RVA: -1 Offset: -1
	public static void Entry<T>(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority = 0, bool scene_only = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1400 Offset: 0x21D1501 VA: 0x21D1400
	|-AssetManager.Entry<object>
	*/

	// RVA: -1 Offset: -1
	public static void Entry<T>(int id, UnityAction<AssetHandle<T>> callback, int priority = 0, bool scene_only = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D12D0 Offset: 0x21D13D1 VA: 0x21D12D0
	|-AssetManager.Entry<ExternalBehavior>
	|-AssetManager.Entry<NPCCallingNameTextData>
	|-AssetManager.Entry<NpcLifeCycleData>
	|-AssetManager.Entry<PlayerCallingNameTextData>
	|-AssetManager.Entry<object>
	|-AssetManager.Entry<TimelineMsgData>
	|-AssetManager.Entry<TutorialDataTableArray>
	|-AssetManager.Entry<UISystemTextData>
	|-AssetManager.Entry<AudioClip>
	|-AssetManager.Entry<Font>
	|-AssetManager.Entry<GameObject>
	|-AssetManager.Entry<ScriptableObject>
	|-AssetManager.Entry<Sprite>
	|-AssetManager.Entry<TextAsset>
	|-AssetManager.Entry<Texture>
	|-AssetManager.Entry<SpriteAtlas>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<T> Entry<T>(string key, UnityAction<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FB460 Offset: 0x34FB561 VA: 0x34FB460
	|-AssetManager.Entry<object>
	*/

	// RVA: 0x218B6C0 Offset: 0x218B7C1 VA: 0x218B6C0
	public static void Remove(int id) { }

	// RVA: -1 Offset: -1
	public static void Remove<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1790 Offset: 0x21D1891 VA: 0x21D1790
	|-AssetManager.Remove<NpcLifeCycleData>
	|-AssetManager.Remove<object>
	|-AssetManager.Remove<TutorialDataTableArray>
	|-AssetManager.Remove<GameObject>
	|-AssetManager.Remove<Sprite>
	|-AssetManager.Remove<TextAsset>
	|-AssetManager.Remove<Texture>
	|-AssetManager.Remove<SpriteAtlas>
	*/

	// RVA: 0x21917D0 Offset: 0x21918D1 VA: 0x21917D0
	public static void RemoveAll() { }

	// RVA: -1 Offset: -1
	public static T GetResult<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C1570 Offset: 0x23C1671 VA: 0x23C1570
	|-AssetManager.GetResult<object>
	|-AssetManager.GetResult<GameObject>
	|-AssetManager.GetResult<TextAsset>
	|-AssetManager.GetResult<SpriteAtlas>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD930 Offset: 0x1ADA31 VA: 0x1AD930
	// RVA: 0x2191A50 Offset: 0x2191B51 VA: 0x2191A50
	public static SystemLanguage get_Language() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD940 Offset: 0x1ADA41 VA: 0x1AD940
	// RVA: 0x2191AC0 Offset: 0x2191BC1 VA: 0x2191AC0
	public static void set_Language(SystemLanguage value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD950 Offset: 0x1ADA51 VA: 0x1AD950
	// RVA: 0x2191B30 Offset: 0x2191C31 VA: 0x2191B30
	public static bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD960 Offset: 0x1ADA61 VA: 0x1AD960
	// RVA: 0x2191BA0 Offset: 0x2191CA1 VA: 0x2191BA0
	protected static void set_IsLoading(bool value) { }

	// RVA: 0x2191C10 Offset: 0x2191D11 VA: 0x2191C10
	public static void AddScene(string key, UnityAction<bool, SceneInstance> complete) { }

	// RVA: 0x2191D40 Offset: 0x2191E41 VA: 0x2191D40
	public static void RemoveScene(SceneInstance scene) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD970 Offset: 0x1ADA71 VA: 0x1AD970
	// RVA: 0x2191E90 Offset: 0x2191F91 VA: 0x2191E90
	private static IEnumerator UnloadSceneAsync(SceneInstance scene) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD9E0 Offset: 0x1ADAE1 VA: 0x1AD9E0
	// RVA: 0x2191F20 Offset: 0x2192021 VA: 0x2191F20
	public static bool get_LoadingOn() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD9F0 Offset: 0x1ADAF1 VA: 0x1AD9F0
	// RVA: 0x2191F90 Offset: 0x2192091 VA: 0x2191F90
	private static void set_LoadingOn(bool value) { }

	// RVA: 0x2192000 Offset: 0x2192101 VA: 0x2192000
	public static void LoadingStart() { }

	// RVA: 0x21921B0 Offset: 0x21922B1 VA: 0x21921B0
	public static void LoadingEnd() { }

	// RVA: 0x2192350 Offset: 0x2192451 VA: 0x2192350
	public static int get_LoadingMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA00 Offset: 0x1ADB01 VA: 0x1ADA00
	// RVA: 0x2192440 Offset: 0x2192541 VA: 0x2192440
	public static int get_LoadingCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA10 Offset: 0x1ADB11 VA: 0x1ADA10
	// RVA: 0x21924B0 Offset: 0x21925B1 VA: 0x21924B0
	protected static void set_LoadingCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA20 Offset: 0x1ADB21 VA: 0x1ADA20
	// RVA: 0x2192520 Offset: 0x2192621 VA: 0x2192520
	public static AssetDataTable get_AssetKeys() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA30 Offset: 0x1ADB31 VA: 0x1ADA30
	// RVA: 0x2192590 Offset: 0x2192691 VA: 0x2192590
	private static void set_AssetKeys(AssetDataTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA40 Offset: 0x1ADB41 VA: 0x1ADA40
	// RVA: 0x2192600 Offset: 0x2192701 VA: 0x2192600
	public static AssetManager get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA50 Offset: 0x1ADB51 VA: 0x1ADA50
	// RVA: 0x2192670 Offset: 0x2192771 VA: 0x2192670
	private static void set_Instance(AssetManager value) { }

	// RVA: -1 Offset: -1
	private void LoadEntry<T>(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1660 Offset: 0x21D1761 VA: 0x21D1660
	|-AssetManager.LoadEntry<object>
	*/

	// RVA: -1 Offset: -1
	private void LoadEntry<T>(int id, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1530 Offset: 0x21D1631 VA: 0x21D1530
	|-AssetManager.LoadEntry<object>
	*/

	// RVA: 0x2191710 Offset: 0x2191811 VA: 0x2191710
	private void RemoveEntry(int id) { }

	// RVA: -1 Offset: -1
	private void RemoveEntry<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1950 Offset: 0x21D1A51 VA: 0x21D1950
	|-AssetManager.RemoveEntry<object>
	*/

	// RVA: 0x2191970 Offset: 0x2191A71 VA: 0x2191970
	private void RemoveAllAssets() { }

	// RVA: 0x21926E0 Offset: 0x21927E1 VA: 0x21926E0
	private int GetLoadingCount() { }

	// RVA: 0x2192790 Offset: 0x2192891 VA: 0x2192790
	private void Awake() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ADA60 Offset: 0x1ADB61 VA: 0x1ADA60
	// RVA: 0x2192A10 Offset: 0x2192B11 VA: 0x2192A10
	private IEnumerator Start() { }

	// RVA: 0x2192A90 Offset: 0x2192B91 VA: 0x2192A90
	private void OnDestroy() { }

	// RVA: 0x2192C10 Offset: 0x2192D11 VA: 0x2192C10
	private void Update() { }

	// RVA: 0x2193660 Offset: 0x2193761 VA: 0x2193660
	public void .ctor() { }

	// RVA: 0x21937A0 Offset: 0x21938A1 VA: 0x21937A0
	private static void .cctor() { }
}

[DefaultExecutionOrder] // RVA: 0x14A4B0 Offset: 0x14A5B1 VA: 0x14A4B0
public class AssetManager : MonoBehaviour // TypeDefIndex: 10222
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x180890 Offset: 0x180991 VA: 0x180890
	private static bool <UnloadDone>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1808A0 Offset: 0x1809A1 VA: 0x1808A0
	private static bool <IsReady>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x1808B0 Offset: 0x1809B1 VA: 0x1808B0
	private static SystemLanguage <Language>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x1808C0 Offset: 0x1809C1 VA: 0x1808C0
	private static bool <IsLoading>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x1808D0 Offset: 0x1809D1 VA: 0x1808D0
	private static bool <LoadingOn>k__BackingField; // 0x9
	[CompilerGeneratedAttribute] // RVA: 0x1808E0 Offset: 0x1809E1 VA: 0x1808E0
	private static int <LoadingCount>k__BackingField; // 0xC
	[SerializeField] // RVA: 0x1808F0 Offset: 0x1809F1 VA: 0x1808F0
	private AssetReference AssetTableReference; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x180900 Offset: 0x180A01 VA: 0x180900
	private static AssetDataTable <AssetKeys>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x180910 Offset: 0x180A11 VA: 0x180910
	private static AssetManager <Instance>k__BackingField; // 0x18
	private List<AssetHandle> LoadList; // 0x20
	private List<int> LoadCountList; // 0x28
	private List<AssetHandle> EntryList; // 0x30
	private List<AssetHandle> RemoveList; // 0x38
	private List<AssetHandle> CompList; // 0x40
	[SerializeField] // RVA: 0x180920 Offset: 0x180A21 VA: 0x180920
	[HeaderAttribute] // RVA: 0x180920 Offset: 0x180A21 VA: 0x180920
	private int UPDATE_LOADING_MAX; // 0x48
	private int LoadMax; // 0x4C
	private int LoadCount; // 0x50
	[SerializeField] // RVA: 0x180970 Offset: 0x180A71 VA: 0x180970
	[HeaderAttribute] // RVA: 0x180970 Offset: 0x180A71 VA: 0x180970
	private int PLAYABLE_LOADING_MAX; // 0x54

	// Properties
	public static bool UnloadDone { get; set; }
	public static bool IsReady { get; set; }
	public static SystemLanguage Language { get; set; }
	public static bool IsLoading { get; set; }
	public static bool LoadingOn { get; set; }
	public static int LoadingMax { get; }
	public static int LoadingCount { get; set; }
	public static AssetDataTable AssetKeys { get; set; }
	public static AssetManager Instance { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD880 Offset: 0x1AD981 VA: 0x1AD880
	// RVA: 0x2191310 Offset: 0x2191411 VA: 0x2191310
	public static bool get_UnloadDone() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD890 Offset: 0x1AD991 VA: 0x1AD890
	// RVA: 0x2191380 Offset: 0x2191481 VA: 0x2191380
	private static void set_UnloadDone(bool value) { }

	// RVA: 0x21913F0 Offset: 0x21914F1 VA: 0x21913F0
	public static void CleanUp() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD8A0 Offset: 0x1AD9A1 VA: 0x1AD8A0
	// RVA: 0x21915D0 Offset: 0x21916D1 VA: 0x21915D0
	private IEnumerator UnloadOperation() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD910 Offset: 0x1ADA11 VA: 0x1AD910
	// RVA: 0x2191630 Offset: 0x2191731 VA: 0x2191630
	public static bool get_IsReady() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD920 Offset: 0x1ADA21 VA: 0x1AD920
	// RVA: 0x21916A0 Offset: 0x21917A1 VA: 0x21916A0
	private static void set_IsReady(bool value) { }

	// RVA: 0x2190AF0 Offset: 0x2190BF1 VA: 0x2190AF0
	public static string Key(int id, SystemLanguage lang) { }

	// RVA: -1 Offset: -1
	public static void Entry<T>(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority = 0, bool scene_only = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1400 Offset: 0x21D1501 VA: 0x21D1400
	|-AssetManager.Entry<object>
	*/

	// RVA: -1 Offset: -1
	public static void Entry<T>(int id, UnityAction<AssetHandle<T>> callback, int priority = 0, bool scene_only = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D12D0 Offset: 0x21D13D1 VA: 0x21D12D0
	|-AssetManager.Entry<ExternalBehavior>
	|-AssetManager.Entry<NPCCallingNameTextData>
	|-AssetManager.Entry<NpcLifeCycleData>
	|-AssetManager.Entry<PlayerCallingNameTextData>
	|-AssetManager.Entry<object>
	|-AssetManager.Entry<TimelineMsgData>
	|-AssetManager.Entry<TutorialDataTableArray>
	|-AssetManager.Entry<UISystemTextData>
	|-AssetManager.Entry<AudioClip>
	|-AssetManager.Entry<Font>
	|-AssetManager.Entry<GameObject>
	|-AssetManager.Entry<ScriptableObject>
	|-AssetManager.Entry<Sprite>
	|-AssetManager.Entry<TextAsset>
	|-AssetManager.Entry<Texture>
	|-AssetManager.Entry<SpriteAtlas>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<T> Entry<T>(string key, UnityAction<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FB460 Offset: 0x34FB561 VA: 0x34FB460
	|-AssetManager.Entry<object>
	*/

	// RVA: 0x218B6C0 Offset: 0x218B7C1 VA: 0x218B6C0
	public static void Remove(int id) { }

	// RVA: -1 Offset: -1
	public static void Remove<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1790 Offset: 0x21D1891 VA: 0x21D1790
	|-AssetManager.Remove<NpcLifeCycleData>
	|-AssetManager.Remove<object>
	|-AssetManager.Remove<TutorialDataTableArray>
	|-AssetManager.Remove<GameObject>
	|-AssetManager.Remove<Sprite>
	|-AssetManager.Remove<TextAsset>
	|-AssetManager.Remove<Texture>
	|-AssetManager.Remove<SpriteAtlas>
	*/

	// RVA: 0x21917D0 Offset: 0x21918D1 VA: 0x21917D0
	public static void RemoveAll() { }

	// RVA: -1 Offset: -1
	public static T GetResult<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C1570 Offset: 0x23C1671 VA: 0x23C1570
	|-AssetManager.GetResult<object>
	|-AssetManager.GetResult<GameObject>
	|-AssetManager.GetResult<TextAsset>
	|-AssetManager.GetResult<SpriteAtlas>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD930 Offset: 0x1ADA31 VA: 0x1AD930
	// RVA: 0x2191A50 Offset: 0x2191B51 VA: 0x2191A50
	public static SystemLanguage get_Language() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD940 Offset: 0x1ADA41 VA: 0x1AD940
	// RVA: 0x2191AC0 Offset: 0x2191BC1 VA: 0x2191AC0
	public static void set_Language(SystemLanguage value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD950 Offset: 0x1ADA51 VA: 0x1AD950
	// RVA: 0x2191B30 Offset: 0x2191C31 VA: 0x2191B30
	public static bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD960 Offset: 0x1ADA61 VA: 0x1AD960
	// RVA: 0x2191BA0 Offset: 0x2191CA1 VA: 0x2191BA0
	protected static void set_IsLoading(bool value) { }

	// RVA: 0x2191C10 Offset: 0x2191D11 VA: 0x2191C10
	public static void AddScene(string key, UnityAction<bool, SceneInstance> complete) { }

	// RVA: 0x2191D40 Offset: 0x2191E41 VA: 0x2191D40
	public static void RemoveScene(SceneInstance scene) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD970 Offset: 0x1ADA71 VA: 0x1AD970
	// RVA: 0x2191E90 Offset: 0x2191F91 VA: 0x2191E90
	private static IEnumerator UnloadSceneAsync(SceneInstance scene) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD9E0 Offset: 0x1ADAE1 VA: 0x1AD9E0
	// RVA: 0x2191F20 Offset: 0x2192021 VA: 0x2191F20
	public static bool get_LoadingOn() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD9F0 Offset: 0x1ADAF1 VA: 0x1AD9F0
	// RVA: 0x2191F90 Offset: 0x2192091 VA: 0x2191F90
	private static void set_LoadingOn(bool value) { }

	// RVA: 0x2192000 Offset: 0x2192101 VA: 0x2192000
	public static void LoadingStart() { }

	// RVA: 0x21921B0 Offset: 0x21922B1 VA: 0x21921B0
	public static void LoadingEnd() { }

	// RVA: 0x2192350 Offset: 0x2192451 VA: 0x2192350
	public static int get_LoadingMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA00 Offset: 0x1ADB01 VA: 0x1ADA00
	// RVA: 0x2192440 Offset: 0x2192541 VA: 0x2192440
	public static int get_LoadingCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA10 Offset: 0x1ADB11 VA: 0x1ADA10
	// RVA: 0x21924B0 Offset: 0x21925B1 VA: 0x21924B0
	protected static void set_LoadingCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA20 Offset: 0x1ADB21 VA: 0x1ADA20
	// RVA: 0x2192520 Offset: 0x2192621 VA: 0x2192520
	public static AssetDataTable get_AssetKeys() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA30 Offset: 0x1ADB31 VA: 0x1ADA30
	// RVA: 0x2192590 Offset: 0x2192691 VA: 0x2192590
	private static void set_AssetKeys(AssetDataTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA40 Offset: 0x1ADB41 VA: 0x1ADA40
	// RVA: 0x2192600 Offset: 0x2192701 VA: 0x2192600
	public static AssetManager get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA50 Offset: 0x1ADB51 VA: 0x1ADA50
	// RVA: 0x2192670 Offset: 0x2192771 VA: 0x2192670
	private static void set_Instance(AssetManager value) { }

	// RVA: -1 Offset: -1
	private void LoadEntry<T>(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1660 Offset: 0x21D1761 VA: 0x21D1660
	|-AssetManager.LoadEntry<object>
	*/

	// RVA: -1 Offset: -1
	private void LoadEntry<T>(int id, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1530 Offset: 0x21D1631 VA: 0x21D1530
	|-AssetManager.LoadEntry<object>
	*/

	// RVA: 0x2191710 Offset: 0x2191811 VA: 0x2191710
	private void RemoveEntry(int id) { }

	// RVA: -1 Offset: -1
	private void RemoveEntry<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1950 Offset: 0x21D1A51 VA: 0x21D1950
	|-AssetManager.RemoveEntry<object>
	*/

	// RVA: 0x2191970 Offset: 0x2191A71 VA: 0x2191970
	private void RemoveAllAssets() { }

	// RVA: 0x21926E0 Offset: 0x21927E1 VA: 0x21926E0
	private int GetLoadingCount() { }

	// RVA: 0x2192790 Offset: 0x2192891 VA: 0x2192790
	private void Awake() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ADA60 Offset: 0x1ADB61 VA: 0x1ADA60
	// RVA: 0x2192A10 Offset: 0x2192B11 VA: 0x2192A10
	private IEnumerator Start() { }

	// RVA: 0x2192A90 Offset: 0x2192B91 VA: 0x2192A90
	private void OnDestroy() { }

	// RVA: 0x2192C10 Offset: 0x2192D11 VA: 0x2192C10
	private void Update() { }

	// RVA: 0x2193660 Offset: 0x2193761 VA: 0x2193660
	public void .ctor() { }

	// RVA: 0x21937A0 Offset: 0x21938A1 VA: 0x21937A0
	private static void .cctor() { }
}

[DefaultExecutionOrder] // RVA: 0x14A4B0 Offset: 0x14A5B1 VA: 0x14A4B0
public class AssetManager : MonoBehaviour // TypeDefIndex: 10222
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x180890 Offset: 0x180991 VA: 0x180890
	private static bool <UnloadDone>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1808A0 Offset: 0x1809A1 VA: 0x1808A0
	private static bool <IsReady>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x1808B0 Offset: 0x1809B1 VA: 0x1808B0
	private static SystemLanguage <Language>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x1808C0 Offset: 0x1809C1 VA: 0x1808C0
	private static bool <IsLoading>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x1808D0 Offset: 0x1809D1 VA: 0x1808D0
	private static bool <LoadingOn>k__BackingField; // 0x9
	[CompilerGeneratedAttribute] // RVA: 0x1808E0 Offset: 0x1809E1 VA: 0x1808E0
	private static int <LoadingCount>k__BackingField; // 0xC
	[SerializeField] // RVA: 0x1808F0 Offset: 0x1809F1 VA: 0x1808F0
	private AssetReference AssetTableReference; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x180900 Offset: 0x180A01 VA: 0x180900
	private static AssetDataTable <AssetKeys>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x180910 Offset: 0x180A11 VA: 0x180910
	private static AssetManager <Instance>k__BackingField; // 0x18
	private List<AssetHandle> LoadList; // 0x20
	private List<int> LoadCountList; // 0x28
	private List<AssetHandle> EntryList; // 0x30
	private List<AssetHandle> RemoveList; // 0x38
	private List<AssetHandle> CompList; // 0x40
	[SerializeField] // RVA: 0x180920 Offset: 0x180A21 VA: 0x180920
	[HeaderAttribute] // RVA: 0x180920 Offset: 0x180A21 VA: 0x180920
	private int UPDATE_LOADING_MAX; // 0x48
	private int LoadMax; // 0x4C
	private int LoadCount; // 0x50
	[SerializeField] // RVA: 0x180970 Offset: 0x180A71 VA: 0x180970
	[HeaderAttribute] // RVA: 0x180970 Offset: 0x180A71 VA: 0x180970
	private int PLAYABLE_LOADING_MAX; // 0x54

	// Properties
	public static bool UnloadDone { get; set; }
	public static bool IsReady { get; set; }
	public static SystemLanguage Language { get; set; }
	public static bool IsLoading { get; set; }
	public static bool LoadingOn { get; set; }
	public static int LoadingMax { get; }
	public static int LoadingCount { get; set; }
	public static AssetDataTable AssetKeys { get; set; }
	public static AssetManager Instance { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD880 Offset: 0x1AD981 VA: 0x1AD880
	// RVA: 0x2191310 Offset: 0x2191411 VA: 0x2191310
	public static bool get_UnloadDone() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD890 Offset: 0x1AD991 VA: 0x1AD890
	// RVA: 0x2191380 Offset: 0x2191481 VA: 0x2191380
	private static void set_UnloadDone(bool value) { }

	// RVA: 0x21913F0 Offset: 0x21914F1 VA: 0x21913F0
	public static void CleanUp() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD8A0 Offset: 0x1AD9A1 VA: 0x1AD8A0
	// RVA: 0x21915D0 Offset: 0x21916D1 VA: 0x21915D0
	private IEnumerator UnloadOperation() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD910 Offset: 0x1ADA11 VA: 0x1AD910
	// RVA: 0x2191630 Offset: 0x2191731 VA: 0x2191630
	public static bool get_IsReady() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD920 Offset: 0x1ADA21 VA: 0x1AD920
	// RVA: 0x21916A0 Offset: 0x21917A1 VA: 0x21916A0
	private static void set_IsReady(bool value) { }

	// RVA: 0x2190AF0 Offset: 0x2190BF1 VA: 0x2190AF0
	public static string Key(int id, SystemLanguage lang) { }

	// RVA: -1 Offset: -1
	public static void Entry<T>(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority = 0, bool scene_only = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1400 Offset: 0x21D1501 VA: 0x21D1400
	|-AssetManager.Entry<object>
	*/

	// RVA: -1 Offset: -1
	public static void Entry<T>(int id, UnityAction<AssetHandle<T>> callback, int priority = 0, bool scene_only = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D12D0 Offset: 0x21D13D1 VA: 0x21D12D0
	|-AssetManager.Entry<ExternalBehavior>
	|-AssetManager.Entry<NPCCallingNameTextData>
	|-AssetManager.Entry<NpcLifeCycleData>
	|-AssetManager.Entry<PlayerCallingNameTextData>
	|-AssetManager.Entry<object>
	|-AssetManager.Entry<TimelineMsgData>
	|-AssetManager.Entry<TutorialDataTableArray>
	|-AssetManager.Entry<UISystemTextData>
	|-AssetManager.Entry<AudioClip>
	|-AssetManager.Entry<Font>
	|-AssetManager.Entry<GameObject>
	|-AssetManager.Entry<ScriptableObject>
	|-AssetManager.Entry<Sprite>
	|-AssetManager.Entry<TextAsset>
	|-AssetManager.Entry<Texture>
	|-AssetManager.Entry<SpriteAtlas>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<T> Entry<T>(string key, UnityAction<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FB460 Offset: 0x34FB561 VA: 0x34FB460
	|-AssetManager.Entry<object>
	*/

	// RVA: 0x218B6C0 Offset: 0x218B7C1 VA: 0x218B6C0
	public static void Remove(int id) { }

	// RVA: -1 Offset: -1
	public static void Remove<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1790 Offset: 0x21D1891 VA: 0x21D1790
	|-AssetManager.Remove<NpcLifeCycleData>
	|-AssetManager.Remove<object>
	|-AssetManager.Remove<TutorialDataTableArray>
	|-AssetManager.Remove<GameObject>
	|-AssetManager.Remove<Sprite>
	|-AssetManager.Remove<TextAsset>
	|-AssetManager.Remove<Texture>
	|-AssetManager.Remove<SpriteAtlas>
	*/

	// RVA: 0x21917D0 Offset: 0x21918D1 VA: 0x21917D0
	public static void RemoveAll() { }

	// RVA: -1 Offset: -1
	public static T GetResult<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C1570 Offset: 0x23C1671 VA: 0x23C1570
	|-AssetManager.GetResult<object>
	|-AssetManager.GetResult<GameObject>
	|-AssetManager.GetResult<TextAsset>
	|-AssetManager.GetResult<SpriteAtlas>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD930 Offset: 0x1ADA31 VA: 0x1AD930
	// RVA: 0x2191A50 Offset: 0x2191B51 VA: 0x2191A50
	public static SystemLanguage get_Language() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD940 Offset: 0x1ADA41 VA: 0x1AD940
	// RVA: 0x2191AC0 Offset: 0x2191BC1 VA: 0x2191AC0
	public static void set_Language(SystemLanguage value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD950 Offset: 0x1ADA51 VA: 0x1AD950
	// RVA: 0x2191B30 Offset: 0x2191C31 VA: 0x2191B30
	public static bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD960 Offset: 0x1ADA61 VA: 0x1AD960
	// RVA: 0x2191BA0 Offset: 0x2191CA1 VA: 0x2191BA0
	protected static void set_IsLoading(bool value) { }

	// RVA: 0x2191C10 Offset: 0x2191D11 VA: 0x2191C10
	public static void AddScene(string key, UnityAction<bool, SceneInstance> complete) { }

	// RVA: 0x2191D40 Offset: 0x2191E41 VA: 0x2191D40
	public static void RemoveScene(SceneInstance scene) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD970 Offset: 0x1ADA71 VA: 0x1AD970
	// RVA: 0x2191E90 Offset: 0x2191F91 VA: 0x2191E90
	private static IEnumerator UnloadSceneAsync(SceneInstance scene) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD9E0 Offset: 0x1ADAE1 VA: 0x1AD9E0
	// RVA: 0x2191F20 Offset: 0x2192021 VA: 0x2191F20
	public static bool get_LoadingOn() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD9F0 Offset: 0x1ADAF1 VA: 0x1AD9F0
	// RVA: 0x2191F90 Offset: 0x2192091 VA: 0x2191F90
	private static void set_LoadingOn(bool value) { }

	// RVA: 0x2192000 Offset: 0x2192101 VA: 0x2192000
	public static void LoadingStart() { }

	// RVA: 0x21921B0 Offset: 0x21922B1 VA: 0x21921B0
	public static void LoadingEnd() { }

	// RVA: 0x2192350 Offset: 0x2192451 VA: 0x2192350
	public static int get_LoadingMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA00 Offset: 0x1ADB01 VA: 0x1ADA00
	// RVA: 0x2192440 Offset: 0x2192541 VA: 0x2192440
	public static int get_LoadingCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA10 Offset: 0x1ADB11 VA: 0x1ADA10
	// RVA: 0x21924B0 Offset: 0x21925B1 VA: 0x21924B0
	protected static void set_LoadingCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA20 Offset: 0x1ADB21 VA: 0x1ADA20
	// RVA: 0x2192520 Offset: 0x2192621 VA: 0x2192520
	public static AssetDataTable get_AssetKeys() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA30 Offset: 0x1ADB31 VA: 0x1ADA30
	// RVA: 0x2192590 Offset: 0x2192691 VA: 0x2192590
	private static void set_AssetKeys(AssetDataTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA40 Offset: 0x1ADB41 VA: 0x1ADA40
	// RVA: 0x2192600 Offset: 0x2192701 VA: 0x2192600
	public static AssetManager get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA50 Offset: 0x1ADB51 VA: 0x1ADA50
	// RVA: 0x2192670 Offset: 0x2192771 VA: 0x2192670
	private static void set_Instance(AssetManager value) { }

	// RVA: -1 Offset: -1
	private void LoadEntry<T>(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1660 Offset: 0x21D1761 VA: 0x21D1660
	|-AssetManager.LoadEntry<object>
	*/

	// RVA: -1 Offset: -1
	private void LoadEntry<T>(int id, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1530 Offset: 0x21D1631 VA: 0x21D1530
	|-AssetManager.LoadEntry<object>
	*/

	// RVA: 0x2191710 Offset: 0x2191811 VA: 0x2191710
	private void RemoveEntry(int id) { }

	// RVA: -1 Offset: -1
	private void RemoveEntry<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1950 Offset: 0x21D1A51 VA: 0x21D1950
	|-AssetManager.RemoveEntry<object>
	*/

	// RVA: 0x2191970 Offset: 0x2191A71 VA: 0x2191970
	private void RemoveAllAssets() { }

	// RVA: 0x21926E0 Offset: 0x21927E1 VA: 0x21926E0
	private int GetLoadingCount() { }

	// RVA: 0x2192790 Offset: 0x2192891 VA: 0x2192790
	private void Awake() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ADA60 Offset: 0x1ADB61 VA: 0x1ADA60
	// RVA: 0x2192A10 Offset: 0x2192B11 VA: 0x2192A10
	private IEnumerator Start() { }

	// RVA: 0x2192A90 Offset: 0x2192B91 VA: 0x2192A90
	private void OnDestroy() { }

	// RVA: 0x2192C10 Offset: 0x2192D11 VA: 0x2192C10
	private void Update() { }

	// RVA: 0x2193660 Offset: 0x2193761 VA: 0x2193660
	public void .ctor() { }

	// RVA: 0x21937A0 Offset: 0x21938A1 VA: 0x21937A0
	private static void .cctor() { }
}

[DefaultExecutionOrder] // RVA: 0x14A4B0 Offset: 0x14A5B1 VA: 0x14A4B0
public class AssetManager : MonoBehaviour // TypeDefIndex: 10222
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x180890 Offset: 0x180991 VA: 0x180890
	private static bool <UnloadDone>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1808A0 Offset: 0x1809A1 VA: 0x1808A0
	private static bool <IsReady>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x1808B0 Offset: 0x1809B1 VA: 0x1808B0
	private static SystemLanguage <Language>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x1808C0 Offset: 0x1809C1 VA: 0x1808C0
	private static bool <IsLoading>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x1808D0 Offset: 0x1809D1 VA: 0x1808D0
	private static bool <LoadingOn>k__BackingField; // 0x9
	[CompilerGeneratedAttribute] // RVA: 0x1808E0 Offset: 0x1809E1 VA: 0x1808E0
	private static int <LoadingCount>k__BackingField; // 0xC
	[SerializeField] // RVA: 0x1808F0 Offset: 0x1809F1 VA: 0x1808F0
	private AssetReference AssetTableReference; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x180900 Offset: 0x180A01 VA: 0x180900
	private static AssetDataTable <AssetKeys>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x180910 Offset: 0x180A11 VA: 0x180910
	private static AssetManager <Instance>k__BackingField; // 0x18
	private List<AssetHandle> LoadList; // 0x20
	private List<int> LoadCountList; // 0x28
	private List<AssetHandle> EntryList; // 0x30
	private List<AssetHandle> RemoveList; // 0x38
	private List<AssetHandle> CompList; // 0x40
	[SerializeField] // RVA: 0x180920 Offset: 0x180A21 VA: 0x180920
	[HeaderAttribute] // RVA: 0x180920 Offset: 0x180A21 VA: 0x180920
	private int UPDATE_LOADING_MAX; // 0x48
	private int LoadMax; // 0x4C
	private int LoadCount; // 0x50
	[SerializeField] // RVA: 0x180970 Offset: 0x180A71 VA: 0x180970
	[HeaderAttribute] // RVA: 0x180970 Offset: 0x180A71 VA: 0x180970
	private int PLAYABLE_LOADING_MAX; // 0x54

	// Properties
	public static bool UnloadDone { get; set; }
	public static bool IsReady { get; set; }
	public static SystemLanguage Language { get; set; }
	public static bool IsLoading { get; set; }
	public static bool LoadingOn { get; set; }
	public static int LoadingMax { get; }
	public static int LoadingCount { get; set; }
	public static AssetDataTable AssetKeys { get; set; }
	public static AssetManager Instance { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD880 Offset: 0x1AD981 VA: 0x1AD880
	// RVA: 0x2191310 Offset: 0x2191411 VA: 0x2191310
	public static bool get_UnloadDone() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD890 Offset: 0x1AD991 VA: 0x1AD890
	// RVA: 0x2191380 Offset: 0x2191481 VA: 0x2191380
	private static void set_UnloadDone(bool value) { }

	// RVA: 0x21913F0 Offset: 0x21914F1 VA: 0x21913F0
	public static void CleanUp() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD8A0 Offset: 0x1AD9A1 VA: 0x1AD8A0
	// RVA: 0x21915D0 Offset: 0x21916D1 VA: 0x21915D0
	private IEnumerator UnloadOperation() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD910 Offset: 0x1ADA11 VA: 0x1AD910
	// RVA: 0x2191630 Offset: 0x2191731 VA: 0x2191630
	public static bool get_IsReady() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD920 Offset: 0x1ADA21 VA: 0x1AD920
	// RVA: 0x21916A0 Offset: 0x21917A1 VA: 0x21916A0
	private static void set_IsReady(bool value) { }

	// RVA: 0x2190AF0 Offset: 0x2190BF1 VA: 0x2190AF0
	public static string Key(int id, SystemLanguage lang) { }

	// RVA: -1 Offset: -1
	public static void Entry<T>(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority = 0, bool scene_only = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1400 Offset: 0x21D1501 VA: 0x21D1400
	|-AssetManager.Entry<object>
	*/

	// RVA: -1 Offset: -1
	public static void Entry<T>(int id, UnityAction<AssetHandle<T>> callback, int priority = 0, bool scene_only = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D12D0 Offset: 0x21D13D1 VA: 0x21D12D0
	|-AssetManager.Entry<ExternalBehavior>
	|-AssetManager.Entry<NPCCallingNameTextData>
	|-AssetManager.Entry<NpcLifeCycleData>
	|-AssetManager.Entry<PlayerCallingNameTextData>
	|-AssetManager.Entry<object>
	|-AssetManager.Entry<TimelineMsgData>
	|-AssetManager.Entry<TutorialDataTableArray>
	|-AssetManager.Entry<UISystemTextData>
	|-AssetManager.Entry<AudioClip>
	|-AssetManager.Entry<Font>
	|-AssetManager.Entry<GameObject>
	|-AssetManager.Entry<ScriptableObject>
	|-AssetManager.Entry<Sprite>
	|-AssetManager.Entry<TextAsset>
	|-AssetManager.Entry<Texture>
	|-AssetManager.Entry<SpriteAtlas>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<T> Entry<T>(string key, UnityAction<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FB460 Offset: 0x34FB561 VA: 0x34FB460
	|-AssetManager.Entry<object>
	*/

	// RVA: 0x218B6C0 Offset: 0x218B7C1 VA: 0x218B6C0
	public static void Remove(int id) { }

	// RVA: -1 Offset: -1
	public static void Remove<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1790 Offset: 0x21D1891 VA: 0x21D1790
	|-AssetManager.Remove<NpcLifeCycleData>
	|-AssetManager.Remove<object>
	|-AssetManager.Remove<TutorialDataTableArray>
	|-AssetManager.Remove<GameObject>
	|-AssetManager.Remove<Sprite>
	|-AssetManager.Remove<TextAsset>
	|-AssetManager.Remove<Texture>
	|-AssetManager.Remove<SpriteAtlas>
	*/

	// RVA: 0x21917D0 Offset: 0x21918D1 VA: 0x21917D0
	public static void RemoveAll() { }

	// RVA: -1 Offset: -1
	public static T GetResult<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C1570 Offset: 0x23C1671 VA: 0x23C1570
	|-AssetManager.GetResult<object>
	|-AssetManager.GetResult<GameObject>
	|-AssetManager.GetResult<TextAsset>
	|-AssetManager.GetResult<SpriteAtlas>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD930 Offset: 0x1ADA31 VA: 0x1AD930
	// RVA: 0x2191A50 Offset: 0x2191B51 VA: 0x2191A50
	public static SystemLanguage get_Language() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD940 Offset: 0x1ADA41 VA: 0x1AD940
	// RVA: 0x2191AC0 Offset: 0x2191BC1 VA: 0x2191AC0
	public static void set_Language(SystemLanguage value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD950 Offset: 0x1ADA51 VA: 0x1AD950
	// RVA: 0x2191B30 Offset: 0x2191C31 VA: 0x2191B30
	public static bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD960 Offset: 0x1ADA61 VA: 0x1AD960
	// RVA: 0x2191BA0 Offset: 0x2191CA1 VA: 0x2191BA0
	protected static void set_IsLoading(bool value) { }

	// RVA: 0x2191C10 Offset: 0x2191D11 VA: 0x2191C10
	public static void AddScene(string key, UnityAction<bool, SceneInstance> complete) { }

	// RVA: 0x2191D40 Offset: 0x2191E41 VA: 0x2191D40
	public static void RemoveScene(SceneInstance scene) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD970 Offset: 0x1ADA71 VA: 0x1AD970
	// RVA: 0x2191E90 Offset: 0x2191F91 VA: 0x2191E90
	private static IEnumerator UnloadSceneAsync(SceneInstance scene) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD9E0 Offset: 0x1ADAE1 VA: 0x1AD9E0
	// RVA: 0x2191F20 Offset: 0x2192021 VA: 0x2191F20
	public static bool get_LoadingOn() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD9F0 Offset: 0x1ADAF1 VA: 0x1AD9F0
	// RVA: 0x2191F90 Offset: 0x2192091 VA: 0x2191F90
	private static void set_LoadingOn(bool value) { }

	// RVA: 0x2192000 Offset: 0x2192101 VA: 0x2192000
	public static void LoadingStart() { }

	// RVA: 0x21921B0 Offset: 0x21922B1 VA: 0x21921B0
	public static void LoadingEnd() { }

	// RVA: 0x2192350 Offset: 0x2192451 VA: 0x2192350
	public static int get_LoadingMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA00 Offset: 0x1ADB01 VA: 0x1ADA00
	// RVA: 0x2192440 Offset: 0x2192541 VA: 0x2192440
	public static int get_LoadingCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA10 Offset: 0x1ADB11 VA: 0x1ADA10
	// RVA: 0x21924B0 Offset: 0x21925B1 VA: 0x21924B0
	protected static void set_LoadingCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA20 Offset: 0x1ADB21 VA: 0x1ADA20
	// RVA: 0x2192520 Offset: 0x2192621 VA: 0x2192520
	public static AssetDataTable get_AssetKeys() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA30 Offset: 0x1ADB31 VA: 0x1ADA30
	// RVA: 0x2192590 Offset: 0x2192691 VA: 0x2192590
	private static void set_AssetKeys(AssetDataTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA40 Offset: 0x1ADB41 VA: 0x1ADA40
	// RVA: 0x2192600 Offset: 0x2192701 VA: 0x2192600
	public static AssetManager get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADA50 Offset: 0x1ADB51 VA: 0x1ADA50
	// RVA: 0x2192670 Offset: 0x2192771 VA: 0x2192670
	private static void set_Instance(AssetManager value) { }

	// RVA: -1 Offset: -1
	private void LoadEntry<T>(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1660 Offset: 0x21D1761 VA: 0x21D1660
	|-AssetManager.LoadEntry<object>
	*/

	// RVA: -1 Offset: -1
	private void LoadEntry<T>(int id, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1530 Offset: 0x21D1631 VA: 0x21D1530
	|-AssetManager.LoadEntry<object>
	*/

	// RVA: 0x2191710 Offset: 0x2191811 VA: 0x2191710
	private void RemoveEntry(int id) { }

	// RVA: -1 Offset: -1
	private void RemoveEntry<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1950 Offset: 0x21D1A51 VA: 0x21D1950
	|-AssetManager.RemoveEntry<object>
	*/

	// RVA: 0x2191970 Offset: 0x2191A71 VA: 0x2191970
	private void RemoveAllAssets() { }

	// RVA: 0x21926E0 Offset: 0x21927E1 VA: 0x21926E0
	private int GetLoadingCount() { }

	// RVA: 0x2192790 Offset: 0x2192891 VA: 0x2192790
	private void Awake() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ADA60 Offset: 0x1ADB61 VA: 0x1ADA60
	// RVA: 0x2192A10 Offset: 0x2192B11 VA: 0x2192A10
	private IEnumerator Start() { }

	// RVA: 0x2192A90 Offset: 0x2192B91 VA: 0x2192A90
	private void OnDestroy() { }

	// RVA: 0x2192C10 Offset: 0x2192D11 VA: 0x2192C10
	private void Update() { }

	// RVA: 0x2193660 Offset: 0x2193761 VA: 0x2193660
	public void .ctor() { }

	// RVA: 0x21937A0 Offset: 0x21938A1 VA: 0x21937A0
	private static void .cctor() { }
}

