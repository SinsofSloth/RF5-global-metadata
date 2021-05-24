public class AssetHandle<T> : AssetHandle // TypeDefIndex: 10218
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x180870 Offset: 0x180971 VA: 0x180870
	private AsyncOperationHandle<T> <AoHandle>k__BackingField; // 0x0
	private UnityAction<AssetHandle<T>> Callback; // 0x0
	private static AssetHandle.LoadAsyncVJ<T>[] loadAsyncVJ; // 0x0

	// Properties
	public AsyncOperationHandle<T> AoHandle { get; set; }
	public T Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AssetHandle<T> Create(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24D80 Offset: 0x2D24E81 VA: 0x2D24D80
	|-AssetHandle<object>.Create
	*/

	// RVA: -1 Offset: -1
	public static AssetHandle<T> GetHandle(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25010 Offset: 0x2D25111 VA: 0x2D25010
	|-AssetHandle<object>.GetHandle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD860 Offset: 0x1AD961 VA: 0x1AD860
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<T> get_AoHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25140 Offset: 0x2D25241 VA: 0x2D25140
	|-AssetHandle<object>.get_AoHandle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD870 Offset: 0x1AD971 VA: 0x1AD870
	// RVA: -1 Offset: -1
	private void set_AoHandle(AsyncOperationHandle<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25160 Offset: 0x2D25261 VA: 0x2D25160
	|-AssetHandle<object>.set_AoHandle
	*/

	// RVA: -1 Offset: -1
	private void Set(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25180 Offset: 0x2D25281 VA: 0x2D25180
	|-AssetHandle<object>.Set
	*/

	// RVA: -1 Offset: -1
	private void Add(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25300 Offset: 0x2D25401 VA: 0x2D25300
	|-AssetHandle<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Remove(bool force = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25550 Offset: 0x2D25651 VA: 0x2D25550
	|-AssetHandle<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool LoadAsync(bool load = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25600 Offset: 0x2D25701 VA: 0x2D25600
	|-AssetHandle<object>.LoadAsync
	*/

	// RVA: -1 Offset: -1
	private static bool LoadAsyncNone(AssetHandle<T> handle, bool load) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25710 Offset: 0x2D25811 VA: 0x2D25710
	|-AssetHandle<object>.LoadAsyncNone
	*/

	// RVA: -1 Offset: -1
	private static bool LoadAsyncEntry(AssetHandle<T> handle, bool load) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25720 Offset: 0x2D25821 VA: 0x2D25720
	|-AssetHandle<object>.LoadAsyncEntry
	*/

	// RVA: -1 Offset: -1
	private void Unload(bool release = True, bool remove = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25A00 Offset: 0x2D25B01 VA: 0x2D25A00
	|-AssetHandle<object>.Unload
	*/

	// RVA: -1 Offset: -1
	private void OnComplete(AsyncOperationHandle<T> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25B90 Offset: 0x2D25C91 VA: 0x2D25B90
	|-AssetHandle<object>.OnComplete
	*/

	// RVA: -1 Offset: -1
	public T get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25C80 Offset: 0x2D25D81 VA: 0x2D25C80
	|-AssetHandle<ExternalBehavior>.get_Result
	|-AssetHandle<NPCCallingNameTextData>.get_Result
	|-AssetHandle<NpcLifeCycleData>.get_Result
	|-AssetHandle<PlayerCallingNameTextData>.get_Result
	|-AssetHandle<object>.get_Result
	|-AssetHandle<TimelineMsgData>.get_Result
	|-AssetHandle<TutorialDataTableArray>.get_Result
	|-AssetHandle<UISystemTextData>.get_Result
	|-AssetHandle<AudioClip>.get_Result
	|-AssetHandle<Font>.get_Result
	|-AssetHandle<GameObject>.get_Result
	|-AssetHandle<ScriptableObject>.get_Result
	|-AssetHandle<Sprite>.get_Result
	|-AssetHandle<TextAsset>.get_Result
	|-AssetHandle<Texture>.get_Result
	|-AssetHandle<SpriteAtlas>.get_Result
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25D10 Offset: 0x2D25E11 VA: 0x2D25D10
	|-AssetHandle<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25D80 Offset: 0x2D25E81 VA: 0x2D25D80
	|-AssetHandle<object>..cctor
	*/
}

public class AssetHandle<T> : AssetHandle // TypeDefIndex: 10218
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x180870 Offset: 0x180971 VA: 0x180870
	private AsyncOperationHandle<T> <AoHandle>k__BackingField; // 0x0
	private UnityAction<AssetHandle<T>> Callback; // 0x0
	private static AssetHandle.LoadAsyncVJ<T>[] loadAsyncVJ; // 0x0

	// Properties
	public AsyncOperationHandle<T> AoHandle { get; set; }
	public T Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AssetHandle<T> Create(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24D80 Offset: 0x2D24E81 VA: 0x2D24D80
	|-AssetHandle<object>.Create
	*/

	// RVA: -1 Offset: -1
	public static AssetHandle<T> GetHandle(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25010 Offset: 0x2D25111 VA: 0x2D25010
	|-AssetHandle<object>.GetHandle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD860 Offset: 0x1AD961 VA: 0x1AD860
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<T> get_AoHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25140 Offset: 0x2D25241 VA: 0x2D25140
	|-AssetHandle<object>.get_AoHandle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD870 Offset: 0x1AD971 VA: 0x1AD870
	// RVA: -1 Offset: -1
	private void set_AoHandle(AsyncOperationHandle<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25160 Offset: 0x2D25261 VA: 0x2D25160
	|-AssetHandle<object>.set_AoHandle
	*/

	// RVA: -1 Offset: -1
	private void Set(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25180 Offset: 0x2D25281 VA: 0x2D25180
	|-AssetHandle<object>.Set
	*/

	// RVA: -1 Offset: -1
	private void Add(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25300 Offset: 0x2D25401 VA: 0x2D25300
	|-AssetHandle<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Remove(bool force = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25550 Offset: 0x2D25651 VA: 0x2D25550
	|-AssetHandle<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool LoadAsync(bool load = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25600 Offset: 0x2D25701 VA: 0x2D25600
	|-AssetHandle<object>.LoadAsync
	*/

	// RVA: -1 Offset: -1
	private static bool LoadAsyncNone(AssetHandle<T> handle, bool load) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25710 Offset: 0x2D25811 VA: 0x2D25710
	|-AssetHandle<object>.LoadAsyncNone
	*/

	// RVA: -1 Offset: -1
	private static bool LoadAsyncEntry(AssetHandle<T> handle, bool load) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25720 Offset: 0x2D25821 VA: 0x2D25720
	|-AssetHandle<object>.LoadAsyncEntry
	*/

	// RVA: -1 Offset: -1
	private void Unload(bool release = True, bool remove = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25A00 Offset: 0x2D25B01 VA: 0x2D25A00
	|-AssetHandle<object>.Unload
	*/

	// RVA: -1 Offset: -1
	private void OnComplete(AsyncOperationHandle<T> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25B90 Offset: 0x2D25C91 VA: 0x2D25B90
	|-AssetHandle<object>.OnComplete
	*/

	// RVA: -1 Offset: -1
	public T get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25C80 Offset: 0x2D25D81 VA: 0x2D25C80
	|-AssetHandle<ExternalBehavior>.get_Result
	|-AssetHandle<NPCCallingNameTextData>.get_Result
	|-AssetHandle<NpcLifeCycleData>.get_Result
	|-AssetHandle<PlayerCallingNameTextData>.get_Result
	|-AssetHandle<object>.get_Result
	|-AssetHandle<TimelineMsgData>.get_Result
	|-AssetHandle<TutorialDataTableArray>.get_Result
	|-AssetHandle<UISystemTextData>.get_Result
	|-AssetHandle<AudioClip>.get_Result
	|-AssetHandle<Font>.get_Result
	|-AssetHandle<GameObject>.get_Result
	|-AssetHandle<ScriptableObject>.get_Result
	|-AssetHandle<Sprite>.get_Result
	|-AssetHandle<TextAsset>.get_Result
	|-AssetHandle<Texture>.get_Result
	|-AssetHandle<SpriteAtlas>.get_Result
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25D10 Offset: 0x2D25E11 VA: 0x2D25D10
	|-AssetHandle<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25D80 Offset: 0x2D25E81 VA: 0x2D25D80
	|-AssetHandle<object>..cctor
	*/
}

public class AssetHandle<T> : AssetHandle // TypeDefIndex: 10218
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x180870 Offset: 0x180971 VA: 0x180870
	private AsyncOperationHandle<T> <AoHandle>k__BackingField; // 0x0
	private UnityAction<AssetHandle<T>> Callback; // 0x0
	private static AssetHandle.LoadAsyncVJ<T>[] loadAsyncVJ; // 0x0

	// Properties
	public AsyncOperationHandle<T> AoHandle { get; set; }
	public T Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AssetHandle<T> Create(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24D80 Offset: 0x2D24E81 VA: 0x2D24D80
	|-AssetHandle<object>.Create
	*/

	// RVA: -1 Offset: -1
	public static AssetHandle<T> GetHandle(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25010 Offset: 0x2D25111 VA: 0x2D25010
	|-AssetHandle<object>.GetHandle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD860 Offset: 0x1AD961 VA: 0x1AD860
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<T> get_AoHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25140 Offset: 0x2D25241 VA: 0x2D25140
	|-AssetHandle<object>.get_AoHandle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD870 Offset: 0x1AD971 VA: 0x1AD870
	// RVA: -1 Offset: -1
	private void set_AoHandle(AsyncOperationHandle<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25160 Offset: 0x2D25261 VA: 0x2D25160
	|-AssetHandle<object>.set_AoHandle
	*/

	// RVA: -1 Offset: -1
	private void Set(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25180 Offset: 0x2D25281 VA: 0x2D25180
	|-AssetHandle<object>.Set
	*/

	// RVA: -1 Offset: -1
	private void Add(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25300 Offset: 0x2D25401 VA: 0x2D25300
	|-AssetHandle<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Remove(bool force = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25550 Offset: 0x2D25651 VA: 0x2D25550
	|-AssetHandle<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool LoadAsync(bool load = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25600 Offset: 0x2D25701 VA: 0x2D25600
	|-AssetHandle<object>.LoadAsync
	*/

	// RVA: -1 Offset: -1
	private static bool LoadAsyncNone(AssetHandle<T> handle, bool load) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25710 Offset: 0x2D25811 VA: 0x2D25710
	|-AssetHandle<object>.LoadAsyncNone
	*/

	// RVA: -1 Offset: -1
	private static bool LoadAsyncEntry(AssetHandle<T> handle, bool load) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25720 Offset: 0x2D25821 VA: 0x2D25720
	|-AssetHandle<object>.LoadAsyncEntry
	*/

	// RVA: -1 Offset: -1
	private void Unload(bool release = True, bool remove = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25A00 Offset: 0x2D25B01 VA: 0x2D25A00
	|-AssetHandle<object>.Unload
	*/

	// RVA: -1 Offset: -1
	private void OnComplete(AsyncOperationHandle<T> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25B90 Offset: 0x2D25C91 VA: 0x2D25B90
	|-AssetHandle<object>.OnComplete
	*/

	// RVA: -1 Offset: -1
	public T get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25C80 Offset: 0x2D25D81 VA: 0x2D25C80
	|-AssetHandle<ExternalBehavior>.get_Result
	|-AssetHandle<NPCCallingNameTextData>.get_Result
	|-AssetHandle<NpcLifeCycleData>.get_Result
	|-AssetHandle<PlayerCallingNameTextData>.get_Result
	|-AssetHandle<object>.get_Result
	|-AssetHandle<TimelineMsgData>.get_Result
	|-AssetHandle<TutorialDataTableArray>.get_Result
	|-AssetHandle<UISystemTextData>.get_Result
	|-AssetHandle<AudioClip>.get_Result
	|-AssetHandle<Font>.get_Result
	|-AssetHandle<GameObject>.get_Result
	|-AssetHandle<ScriptableObject>.get_Result
	|-AssetHandle<Sprite>.get_Result
	|-AssetHandle<TextAsset>.get_Result
	|-AssetHandle<Texture>.get_Result
	|-AssetHandle<SpriteAtlas>.get_Result
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25D10 Offset: 0x2D25E11 VA: 0x2D25D10
	|-AssetHandle<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25D80 Offset: 0x2D25E81 VA: 0x2D25D80
	|-AssetHandle<object>..cctor
	*/
}

public class AssetHandle<T> : AssetHandle // TypeDefIndex: 10218
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x180870 Offset: 0x180971 VA: 0x180870
	private AsyncOperationHandle<T> <AoHandle>k__BackingField; // 0x0
	private UnityAction<AssetHandle<T>> Callback; // 0x0
	private static AssetHandle.LoadAsyncVJ<T>[] loadAsyncVJ; // 0x0

	// Properties
	public AsyncOperationHandle<T> AoHandle { get; set; }
	public T Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AssetHandle<T> Create(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24D80 Offset: 0x2D24E81 VA: 0x2D24D80
	|-AssetHandle<object>.Create
	*/

	// RVA: -1 Offset: -1
	public static AssetHandle<T> GetHandle(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25010 Offset: 0x2D25111 VA: 0x2D25010
	|-AssetHandle<object>.GetHandle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD860 Offset: 0x1AD961 VA: 0x1AD860
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<T> get_AoHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25140 Offset: 0x2D25241 VA: 0x2D25140
	|-AssetHandle<object>.get_AoHandle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD870 Offset: 0x1AD971 VA: 0x1AD870
	// RVA: -1 Offset: -1
	private void set_AoHandle(AsyncOperationHandle<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25160 Offset: 0x2D25261 VA: 0x2D25160
	|-AssetHandle<object>.set_AoHandle
	*/

	// RVA: -1 Offset: -1
	private void Set(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25180 Offset: 0x2D25281 VA: 0x2D25180
	|-AssetHandle<object>.Set
	*/

	// RVA: -1 Offset: -1
	private void Add(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25300 Offset: 0x2D25401 VA: 0x2D25300
	|-AssetHandle<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Remove(bool force = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25550 Offset: 0x2D25651 VA: 0x2D25550
	|-AssetHandle<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool LoadAsync(bool load = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25600 Offset: 0x2D25701 VA: 0x2D25600
	|-AssetHandle<object>.LoadAsync
	*/

	// RVA: -1 Offset: -1
	private static bool LoadAsyncNone(AssetHandle<T> handle, bool load) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25710 Offset: 0x2D25811 VA: 0x2D25710
	|-AssetHandle<object>.LoadAsyncNone
	*/

	// RVA: -1 Offset: -1
	private static bool LoadAsyncEntry(AssetHandle<T> handle, bool load) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25720 Offset: 0x2D25821 VA: 0x2D25720
	|-AssetHandle<object>.LoadAsyncEntry
	*/

	// RVA: -1 Offset: -1
	private void Unload(bool release = True, bool remove = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25A00 Offset: 0x2D25B01 VA: 0x2D25A00
	|-AssetHandle<object>.Unload
	*/

	// RVA: -1 Offset: -1
	private void OnComplete(AsyncOperationHandle<T> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25B90 Offset: 0x2D25C91 VA: 0x2D25B90
	|-AssetHandle<object>.OnComplete
	*/

	// RVA: -1 Offset: -1
	public T get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25C80 Offset: 0x2D25D81 VA: 0x2D25C80
	|-AssetHandle<ExternalBehavior>.get_Result
	|-AssetHandle<NPCCallingNameTextData>.get_Result
	|-AssetHandle<NpcLifeCycleData>.get_Result
	|-AssetHandle<PlayerCallingNameTextData>.get_Result
	|-AssetHandle<object>.get_Result
	|-AssetHandle<TimelineMsgData>.get_Result
	|-AssetHandle<TutorialDataTableArray>.get_Result
	|-AssetHandle<UISystemTextData>.get_Result
	|-AssetHandle<AudioClip>.get_Result
	|-AssetHandle<Font>.get_Result
	|-AssetHandle<GameObject>.get_Result
	|-AssetHandle<ScriptableObject>.get_Result
	|-AssetHandle<Sprite>.get_Result
	|-AssetHandle<TextAsset>.get_Result
	|-AssetHandle<Texture>.get_Result
	|-AssetHandle<SpriteAtlas>.get_Result
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25D10 Offset: 0x2D25E11 VA: 0x2D25D10
	|-AssetHandle<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25D80 Offset: 0x2D25E81 VA: 0x2D25D80
	|-AssetHandle<object>..cctor
	*/
}

public class AssetHandle<T> : AssetHandle // TypeDefIndex: 10218
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x180870 Offset: 0x180971 VA: 0x180870
	private AsyncOperationHandle<T> <AoHandle>k__BackingField; // 0x0
	private UnityAction<AssetHandle<T>> Callback; // 0x0
	private static AssetHandle.LoadAsyncVJ<T>[] loadAsyncVJ; // 0x0

	// Properties
	public AsyncOperationHandle<T> AoHandle { get; set; }
	public T Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AssetHandle<T> Create(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D24D80 Offset: 0x2D24E81 VA: 0x2D24D80
	|-AssetHandle<object>.Create
	*/

	// RVA: -1 Offset: -1
	public static AssetHandle<T> GetHandle(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25010 Offset: 0x2D25111 VA: 0x2D25010
	|-AssetHandle<object>.GetHandle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD860 Offset: 0x1AD961 VA: 0x1AD860
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<T> get_AoHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25140 Offset: 0x2D25241 VA: 0x2D25140
	|-AssetHandle<object>.get_AoHandle
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD870 Offset: 0x1AD971 VA: 0x1AD870
	// RVA: -1 Offset: -1
	private void set_AoHandle(AsyncOperationHandle<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25160 Offset: 0x2D25261 VA: 0x2D25160
	|-AssetHandle<object>.set_AoHandle
	*/

	// RVA: -1 Offset: -1
	private void Set(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25180 Offset: 0x2D25281 VA: 0x2D25180
	|-AssetHandle<object>.Set
	*/

	// RVA: -1 Offset: -1
	private void Add(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25300 Offset: 0x2D25401 VA: 0x2D25300
	|-AssetHandle<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Remove(bool force = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25550 Offset: 0x2D25651 VA: 0x2D25550
	|-AssetHandle<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool LoadAsync(bool load = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25600 Offset: 0x2D25701 VA: 0x2D25600
	|-AssetHandle<object>.LoadAsync
	*/

	// RVA: -1 Offset: -1
	private static bool LoadAsyncNone(AssetHandle<T> handle, bool load) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25710 Offset: 0x2D25811 VA: 0x2D25710
	|-AssetHandle<object>.LoadAsyncNone
	*/

	// RVA: -1 Offset: -1
	private static bool LoadAsyncEntry(AssetHandle<T> handle, bool load) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25720 Offset: 0x2D25821 VA: 0x2D25720
	|-AssetHandle<object>.LoadAsyncEntry
	*/

	// RVA: -1 Offset: -1
	private void Unload(bool release = True, bool remove = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25A00 Offset: 0x2D25B01 VA: 0x2D25A00
	|-AssetHandle<object>.Unload
	*/

	// RVA: -1 Offset: -1
	private void OnComplete(AsyncOperationHandle<T> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25B90 Offset: 0x2D25C91 VA: 0x2D25B90
	|-AssetHandle<object>.OnComplete
	*/

	// RVA: -1 Offset: -1
	public T get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25C80 Offset: 0x2D25D81 VA: 0x2D25C80
	|-AssetHandle<ExternalBehavior>.get_Result
	|-AssetHandle<NPCCallingNameTextData>.get_Result
	|-AssetHandle<NpcLifeCycleData>.get_Result
	|-AssetHandle<PlayerCallingNameTextData>.get_Result
	|-AssetHandle<object>.get_Result
	|-AssetHandle<TimelineMsgData>.get_Result
	|-AssetHandle<TutorialDataTableArray>.get_Result
	|-AssetHandle<UISystemTextData>.get_Result
	|-AssetHandle<AudioClip>.get_Result
	|-AssetHandle<Font>.get_Result
	|-AssetHandle<GameObject>.get_Result
	|-AssetHandle<ScriptableObject>.get_Result
	|-AssetHandle<Sprite>.get_Result
	|-AssetHandle<TextAsset>.get_Result
	|-AssetHandle<Texture>.get_Result
	|-AssetHandle<SpriteAtlas>.get_Result
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25D10 Offset: 0x2D25E11 VA: 0x2D25D10
	|-AssetHandle<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D25D80 Offset: 0x2D25E81 VA: 0x2D25D80
	|-AssetHandle<object>..cctor
	*/
}

