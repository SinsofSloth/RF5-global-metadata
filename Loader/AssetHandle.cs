public abstract class AssetHandle // TypeDefIndex: 10216
{
	// Fields
	protected static Dictionary<int, AssetHandle> HandleList; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1807E0 Offset: 0x1808E1 VA: 0x1807E0
	private static bool <IsSort>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x1807F0 Offset: 0x1808F1 VA: 0x1807F0
	private AssetHandle.STATE <State>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x180800 Offset: 0x180901 VA: 0x180800
	private int <Id>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x180810 Offset: 0x180911 VA: 0x180810
	private string <Key>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x180820 Offset: 0x180921 VA: 0x180820
	private int <Priority>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x180830 Offset: 0x180931 VA: 0x180830
	private int <Reference>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x180840 Offset: 0x180941 VA: 0x180840
	private bool <SceneOnly>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x180850 Offset: 0x180951 VA: 0x180850
	private bool <IsDone>k__BackingField; // 0x29
	[CompilerGeneratedAttribute] // RVA: 0x180860 Offset: 0x180961 VA: 0x180860
	private bool <IsSuccess>k__BackingField; // 0x2A

	// Properties
	public static int Count { get; }
	public static bool IsSort { get; set; }
	public AssetHandle.STATE State { get; set; }
	public int Id { get; set; }
	public string Key { get; set; }
	public int Priority { get; set; }
	public int Reference { get; set; }
	public bool SceneOnly { get; set; }
	public bool IsDone { get; set; }
	public bool IsSuccess { get; set; }
	public bool IsLoading { get; }
	public bool IsActive { get; }

	// Methods

	// RVA: 0x218FE10 Offset: 0x218FF11 VA: 0x218FE10
	public static int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD740 Offset: 0x1AD841 VA: 0x1AD740
	// RVA: 0x218FE90 Offset: 0x218FF91 VA: 0x218FE90
	public static bool get_IsSort() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD750 Offset: 0x1AD851 VA: 0x1AD750
	// RVA: 0x218FF00 Offset: 0x2190001 VA: 0x218FF00
	protected static void set_IsSort(bool value) { }

	// RVA: 0x218FF70 Offset: 0x2190071 VA: 0x218FF70
	public static AssetHandle GetHandleList(int id) { }

	// RVA: 0x2190050 Offset: 0x2190151 VA: 0x2190050
	public static int Compare(AssetHandle a, AssetHandle b) { }

	// RVA: 0x2190080 Offset: 0x2190181 VA: 0x2190080
	public static void Update() { }

	// RVA: 0x2190150 Offset: 0x2190251 VA: 0x2190150
	public static void RemoveAll(int priority = -1) { }

	// RVA: 0x2190520 Offset: 0x2190621 VA: 0x2190520
	public static void SceneUnloadHandles(bool unload = False) { }

	// RVA: -1 Offset: -1
	public static T GetResult<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C1420 Offset: 0x23C1521 VA: 0x23C1420
	|-AssetHandle.GetResult<object>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1AD760 Offset: 0x1AD861 VA: 0x1AD760
	// RVA: 0x2190910 Offset: 0x2190A11 VA: 0x2190910
	public AssetHandle.STATE get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD770 Offset: 0x1AD871 VA: 0x1AD770
	// RVA: 0x2190920 Offset: 0x2190A21 VA: 0x2190920
	protected void set_State(AssetHandle.STATE value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD780 Offset: 0x1AD881 VA: 0x1AD780
	// RVA: 0x2190930 Offset: 0x2190A31 VA: 0x2190930
	public int get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD790 Offset: 0x1AD891 VA: 0x1AD790
	// RVA: 0x2190940 Offset: 0x2190A41 VA: 0x2190940
	protected void set_Id(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD7A0 Offset: 0x1AD8A1 VA: 0x1AD7A0
	// RVA: 0x2190950 Offset: 0x2190A51 VA: 0x2190950
	public string get_Key() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD7B0 Offset: 0x1AD8B1 VA: 0x1AD7B0
	// RVA: 0x2190960 Offset: 0x2190A61 VA: 0x2190960
	protected void set_Key(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD7C0 Offset: 0x1AD8C1 VA: 0x1AD7C0
	// RVA: 0x2190970 Offset: 0x2190A71 VA: 0x2190970
	public int get_Priority() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD7D0 Offset: 0x1AD8D1 VA: 0x1AD7D0
	// RVA: 0x2190980 Offset: 0x2190A81 VA: 0x2190980
	public void set_Priority(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD7E0 Offset: 0x1AD8E1 VA: 0x1AD7E0
	// RVA: 0x2190990 Offset: 0x2190A91 VA: 0x2190990
	public int get_Reference() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD7F0 Offset: 0x1AD8F1 VA: 0x1AD7F0
	// RVA: 0x21909A0 Offset: 0x2190AA1 VA: 0x21909A0
	protected void set_Reference(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD800 Offset: 0x1AD901 VA: 0x1AD800
	// RVA: 0x21909B0 Offset: 0x2190AB1 VA: 0x21909B0
	public bool get_SceneOnly() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD810 Offset: 0x1AD911 VA: 0x1AD810
	// RVA: 0x21909C0 Offset: 0x2190AC1 VA: 0x21909C0
	protected void set_SceneOnly(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD820 Offset: 0x1AD921 VA: 0x1AD820
	// RVA: 0x21909D0 Offset: 0x2190AD1 VA: 0x21909D0
	public bool get_IsDone() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD830 Offset: 0x1AD931 VA: 0x1AD830
	// RVA: 0x21909E0 Offset: 0x2190AE1 VA: 0x21909E0
	protected void set_IsDone(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD840 Offset: 0x1AD941 VA: 0x1AD840
	// RVA: 0x21909F0 Offset: 0x2190AF1 VA: 0x21909F0
	public bool get_IsSuccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD850 Offset: 0x1AD951 VA: 0x1AD850
	// RVA: 0x2190A00 Offset: 0x2190B01 VA: 0x2190A00
	protected void set_IsSuccess(bool value) { }

	// RVA: 0x2190A10 Offset: 0x2190B11 VA: 0x2190A10
	public bool get_IsLoading() { }

	// RVA: 0x2190A20 Offset: 0x2190B21 VA: 0x2190A20
	public bool get_IsActive() { }

	// RVA: 0x2190A30 Offset: 0x2190B31 VA: 0x2190A30
	protected void Set(int id, SystemLanguage language, int priority, bool scene_only) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Remove(bool force = False) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool LoadAsync(bool load = True) { }

	// RVA: 0x2190C80 Offset: 0x2190D81 VA: 0x2190C80
	protected void .ctor() { }

	// RVA: 0x2190C90 Offset: 0x2190D91 VA: 0x2190C90
	private static void .cctor() { }
}

