public class PreloadRoomController : PreloadController // TypeDefIndex: 7695
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x168AC0 Offset: 0x168BC1 VA: 0x168AC0
	private PreloadSceneHandle[] <Scenes>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x168AD0 Offset: 0x168BD1 VA: 0x168AD0
	private static string <CacheKey>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x168AE0 Offset: 0x168BE1 VA: 0x168AE0
	private static PreloadSceneHandle[] <CacheHandle>k__BackingField; // 0x8

	// Properties
	public PreloadSceneHandle[] Scenes { get; set; }
	public static string CacheKey { get; set; }
	public static PreloadSceneHandle[] CacheHandle { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A2760 Offset: 0x1A2861 VA: 0x1A2760
	// RVA: 0x1DE8140 Offset: 0x1DE8241 VA: 0x1DE8140
	public PreloadSceneHandle[] get_Scenes() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2770 Offset: 0x1A2871 VA: 0x1A2770
	// RVA: 0x1DE8150 Offset: 0x1DE8251 VA: 0x1DE8150
	private void set_Scenes(PreloadSceneHandle[] value) { }

	// RVA: 0x1DE8160 Offset: 0x1DE8261 VA: 0x1DE8160 Slot: 5
	protected override void OnDestroy() { }

	// RVA: 0x1DE81E0 Offset: 0x1DE82E1 VA: 0x1DE81E0 Slot: 7
	protected override void OnPreloadEnter(Collider mine, Collider other) { }

	// RVA: 0x1DE8A90 Offset: 0x1DE8B91 VA: 0x1DE8A90 Slot: 8
	protected override void OnPreloadExit(Collider mine, Collider other) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2780 Offset: 0x1A2881 VA: 0x1A2780
	// RVA: 0x1DE8E80 Offset: 0x1DE8F81 VA: 0x1DE8E80
	public static string get_CacheKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2790 Offset: 0x1A2891 VA: 0x1A2790
	// RVA: 0x1DE8EF0 Offset: 0x1DE8FF1 VA: 0x1DE8EF0
	private static void set_CacheKey(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A27A0 Offset: 0x1A28A1 VA: 0x1A27A0
	// RVA: 0x1DE8F60 Offset: 0x1DE9061 VA: 0x1DE8F60
	public static PreloadSceneHandle[] get_CacheHandle() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A27B0 Offset: 0x1A28B1 VA: 0x1A27B0
	// RVA: 0x1DE8FD0 Offset: 0x1DE90D1 VA: 0x1DE8FD0
	private static void set_CacheHandle(PreloadSceneHandle[] value) { }

	// RVA: 0x1DE8550 Offset: 0x1DE8651 VA: 0x1DE8550
	public static PreloadSceneHandle[] Add(string key, UnityAction<PreloadSceneHandle> complete) { }

	// RVA: 0x1DE8D10 Offset: 0x1DE8E11 VA: 0x1DE8D10
	public static void Remove(PreloadSceneHandle[] handles) { }

	// RVA: 0x1DE9040 Offset: 0x1DE9141 VA: 0x1DE9040
	public static void Remove() { }

	// RVA: 0x1DE92A0 Offset: 0x1DE93A1 VA: 0x1DE92A0
	public void .ctor() { }

	// RVA: 0x1DE92B0 Offset: 0x1DE93B1 VA: 0x1DE92B0
	private static void .cctor() { }
}

