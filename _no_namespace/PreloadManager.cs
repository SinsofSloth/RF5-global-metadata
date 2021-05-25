public static class PreloadManager // TypeDefIndex: 7694
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x168AA0 Offset: 0x168BA1 VA: 0x168AA0
	private static List<PreloadHandle> <HandleList>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x168AB0 Offset: 0x168BB1 VA: 0x168AB0
	private static List<PreloadHandle> <RemoveList>k__BackingField; // 0x8

	// Properties
	public static bool IsBusy { get; }
	public static List<PreloadHandle> HandleList { get; set; }
	public static List<PreloadHandle> RemoveList { get; set; }

	// Methods

	// RVA: 0x2775980 Offset: 0x2775A81 VA: 0x2775980
	public static bool get_IsBusy() { }

	// RVA: 0x2775A70 Offset: 0x2775B71 VA: 0x2775A70
	public static void Create() { }

	// RVA: 0x2775D60 Offset: 0x2775E61 VA: 0x2775D60
	public static void Destroy() { }

	// RVA: 0x27760C0 Offset: 0x27761C1 VA: 0x27760C0
	public static void CleanUp() { }

	// RVA: 0x2776320 Offset: 0x2776421 VA: 0x2776320
	public static int Update(bool load = True) { }

	// RVA: 0x2775430 Offset: 0x2775531 VA: 0x2775430
	public static PreloadSceneHandle AddScene(string key, UnityAction<PreloadSceneHandle> complete, int priority = 0) { }

	// RVA: 0x2775750 Offset: 0x2775851 VA: 0x2775750
	public static void RemoveScene(PreloadSceneHandle handle) { }

	// RVA: 0x2776B30 Offset: 0x2776C31 VA: 0x2776B30
	public static void RemoveScene(PreloadSceneHandle[] handles) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2720 Offset: 0x1A2821 VA: 0x1A2720
	// RVA: 0x2776C90 Offset: 0x2776D91 VA: 0x2776C90
	public static List<PreloadHandle> get_HandleList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2730 Offset: 0x1A2831 VA: 0x1A2730
	// RVA: 0x2776D00 Offset: 0x2776E01 VA: 0x2776D00
	private static void set_HandleList(List<PreloadHandle> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2740 Offset: 0x1A2841 VA: 0x1A2740
	// RVA: 0x2776D70 Offset: 0x2776E71 VA: 0x2776D70
	public static List<PreloadHandle> get_RemoveList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2750 Offset: 0x1A2851 VA: 0x1A2750
	// RVA: 0x2776DE0 Offset: 0x2776EE1 VA: 0x2776DE0
	private static void set_RemoveList(List<PreloadHandle> value) { }

	// RVA: 0x2776E50 Offset: 0x2776F51 VA: 0x2776E50
	private static void .cctor() { }
}

