public class FieldItemSpawnDataManager : SingletonMonoBehaviour<FieldItemSpawnDataManager> // TypeDefIndex: 10484
{
	// Fields
	private FieldItemSpawnDataTableArray _FieldItemSpawnDataTableArray; // 0x18
	private HashSet<FieldItemSpawnID> _ExistSpawnIDHashSet; // 0x20
	private FieldHideItemSpawnDataTableArray _FieldHideItemSpawnDataTableArray; // 0x28
	private HashSet<FieldHideItemSpawnID> _ExistHideSpawnIDHashSet; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x181BA0 Offset: 0x181CA1 VA: 0x181BA0
	private bool <IsSceneChangeCheckEnd>k__BackingField; // 0x38
	private HashSet<FieldItemSpawner> ExistItemSpawnerHashSet; // 0x40
	private HashSet<FieldHideItemSpawner> ExistHideItemSpawnerHashSet; // 0x48
	private Dictionary<int, OnGroundItem> ExistItemDictionary; // 0x50
	private Dictionary<int, OnGroundItem> ExistHideItemDictionary; // 0x58
	private bool IsInit; // 0x60
	private bool[] CanDetectParties; // 0x68
	private bool[] IsDetectParties; // 0x70

	// Properties
	public HashSet<FieldItemSpawnID> ExistSpawnIDHashSet { get; set; }
	public HashSet<FieldHideItemSpawnID> ExistHideSpawnIDHashSet { get; set; }
	public bool IsSceneChangeCheckEnd { get; set; }

	// Methods

	// RVA: 0x1E24C40 Offset: 0x1E24D41 VA: 0x1E24C40
	public HashSet<FieldItemSpawnID> get_ExistSpawnIDHashSet() { }

	// RVA: 0x1E24C50 Offset: 0x1E24D51 VA: 0x1E24C50
	private void set_ExistSpawnIDHashSet(HashSet<FieldItemSpawnID> value) { }

	// RVA: 0x1E24C60 Offset: 0x1E24D61 VA: 0x1E24C60
	public HashSet<FieldHideItemSpawnID> get_ExistHideSpawnIDHashSet() { }

	// RVA: 0x1E24C70 Offset: 0x1E24D71 VA: 0x1E24C70
	private void set_ExistHideSpawnIDHashSet(HashSet<FieldHideItemSpawnID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF7C0 Offset: 0x1AF8C1 VA: 0x1AF7C0
	// RVA: 0x1E24C80 Offset: 0x1E24D81 VA: 0x1E24C80
	public bool get_IsSceneChangeCheckEnd() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF7D0 Offset: 0x1AF8D1 VA: 0x1AF7D0
	// RVA: 0x1E24C90 Offset: 0x1E24D91 VA: 0x1E24C90
	private void set_IsSceneChangeCheckEnd(bool value) { }

	// RVA: 0x1E24CA0 Offset: 0x1E24DA1 VA: 0x1E24CA0
	public bool IsDetectHideItemParties(int index = 0) { }

	// RVA: 0x1E24CE0 Offset: 0x1E24DE1 VA: 0x1E24CE0
	public static FieldItemSpawnDataTableArray GetDataTableArray() { }

	// RVA: 0x1E24D40 Offset: 0x1E24E41 VA: 0x1E24D40
	public static FieldItemSpawnDataTable[] GetDataTables() { }

	// RVA: 0x1E24DA0 Offset: 0x1E24EA1 VA: 0x1E24DA0
	public static FieldItemSpawnDataTable GetDataTable(FieldItemSpawnID id) { }

	// RVA: 0x1E24770 Offset: 0x1E24871 VA: 0x1E24770
	public static FieldHideItemSpawnDataTable GetDataTable(FieldHideItemSpawnID id) { }

	// RVA: 0x1E24E60 Offset: 0x1E24F61 VA: 0x1E24E60
	public void InitializeLoad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF7E0 Offset: 0x1AF8E1 VA: 0x1AF7E0
	// RVA: 0x1E24EF0 Offset: 0x1E24FF1 VA: 0x1E24EF0
	public IEnumerator LoadDataTable() { }

	// RVA: 0x1E24FA0 Offset: 0x1E250A1 VA: 0x1E24FA0
	private void OnDestroy() { }

	// RVA: 0x1E25370 Offset: 0x1E25471 VA: 0x1E25370 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E25440 Offset: 0x1E25541 VA: 0x1E25440
	private void Update() { }

	// RVA: 0x1E25800 Offset: 0x1E25901 VA: 0x1E25800
	private static bool Lottery(int weight) { }

	// RVA: 0x1E25840 Offset: 0x1E25941 VA: 0x1E25840
	public void OnAfterGameDataLoad() { }

	// RVA: 0x1E259E0 Offset: 0x1E25AE1 VA: 0x1E259E0
	public static void OnDayChangeSetFieldFlag(int elapsedDay = 1) { }

	// RVA: 0x1E25AF0 Offset: 0x1E25BF1 VA: 0x1E25AF0
	public void OnSceneChangeSetFieldFlag() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF850 Offset: 0x1AF951 VA: 0x1AF850
	// RVA: 0x1E25BC0 Offset: 0x1E25CC1 VA: 0x1E25BC0
	private IEnumerator CheckSceneItem() { }

	// RVA: 0x1E25C70 Offset: 0x1E25D71 VA: 0x1E25C70
	public bool AddOnGroundItem(OnGroundItem onGroundItem, FieldItemSpawnID id) { }

	// RVA: 0x1E25D50 Offset: 0x1E25E51 VA: 0x1E25D50
	public bool RemoveOnGroundItem(OnGroundItem onGroundItem, bool setFlag = False) { }

	// RVA: 0x1E26030 Offset: 0x1E26131 VA: 0x1E26030
	public bool OnGroundItemExists(OnGroundItem onGroundItem) { }

	// RVA: 0x1E24800 Offset: 0x1E24901 VA: 0x1E24800
	public bool AddHideOnGroundItem(OnGroundItem onGroundItem, FieldHideItemSpawnID id) { }

	// RVA: 0x1E25EA0 Offset: 0x1E25FA1 VA: 0x1E25EA0
	public bool RemoveHideOnGroundItem(OnGroundItem onGroundItem, bool setFlag = False) { }

	// RVA: 0x1E261E0 Offset: 0x1E262E1 VA: 0x1E261E0
	public bool HideOnGroundItemExists(OnGroundItem onGroundItem) { }

	// RVA: 0x1E26350 Offset: 0x1E26451 VA: 0x1E26350
	public bool FieldItemSpawnIDExists(FieldItemSpawnID fieldItemSpawnID) { }

	// RVA: 0x1E24600 Offset: 0x1E24701 VA: 0x1E24600
	public bool FieldHideItemSpawnIDExists(FieldHideItemSpawnID spawnID) { }

	// RVA: 0x1E25B80 Offset: 0x1E25C81 VA: 0x1E25B80
	public static void SetFieldItemSpawnFlag(FieldItemSpawnID id, bool value) { }

	// RVA: 0x1E263D0 Offset: 0x1E264D1 VA: 0x1E263D0
	public static bool GetFieldItemSpawnFlag(FieldItemSpawnID id) { }

	// RVA: 0x1E26100 Offset: 0x1E26201 VA: 0x1E26100
	public static void SetFieldHideItemSpawnFlag(FieldHideItemSpawnID id, bool value) { }

	// RVA: 0x1E24680 Offset: 0x1E24781 VA: 0x1E24680
	public static bool GetFieldHideItemSpawnFlag(FieldHideItemSpawnID id) { }

	// RVA: 0x1E24590 Offset: 0x1E24691 VA: 0x1E24590
	public static bool IsRestrictSpawn() { }

	// RVA: 0x1E26410 Offset: 0x1E26511 VA: 0x1E26410
	public bool AddItemSpawner(FieldItemSpawner itemSpawner) { }

	// RVA: 0x1E264D0 Offset: 0x1E265D1 VA: 0x1E264D0
	public bool RemoveItemSpawner(FieldItemSpawner itemSpawner) { }

	// RVA: 0x1E24140 Offset: 0x1E24241 VA: 0x1E24140
	public bool AddHideSpawner(FieldHideItemSpawner hideItemSpawner) { }

	// RVA: 0x1E23F30 Offset: 0x1E24031 VA: 0x1E23F30
	public bool RemoveHideSpawner(FieldHideItemSpawner hideItemSpawner) { }

	// RVA: 0x1E26590 Offset: 0x1E26691 VA: 0x1E26590
	public void OnChangeHideDetectFlag(bool enable) { }

	// RVA: 0x1E266A0 Offset: 0x1E267A1 VA: 0x1E266A0
	public void .ctor() { }
}

public class FieldItemSpawnDataManager : SingletonMonoBehaviour<FieldItemSpawnDataManager> // TypeDefIndex: 10484
{
	// Fields
	private FieldItemSpawnDataTableArray _FieldItemSpawnDataTableArray; // 0x18
	private HashSet<FieldItemSpawnID> _ExistSpawnIDHashSet; // 0x20
	private FieldHideItemSpawnDataTableArray _FieldHideItemSpawnDataTableArray; // 0x28
	private HashSet<FieldHideItemSpawnID> _ExistHideSpawnIDHashSet; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x181BA0 Offset: 0x181CA1 VA: 0x181BA0
	private bool <IsSceneChangeCheckEnd>k__BackingField; // 0x38
	private HashSet<FieldItemSpawner> ExistItemSpawnerHashSet; // 0x40
	private HashSet<FieldHideItemSpawner> ExistHideItemSpawnerHashSet; // 0x48
	private Dictionary<int, OnGroundItem> ExistItemDictionary; // 0x50
	private Dictionary<int, OnGroundItem> ExistHideItemDictionary; // 0x58
	private bool IsInit; // 0x60
	private bool[] CanDetectParties; // 0x68
	private bool[] IsDetectParties; // 0x70

	// Properties
	public HashSet<FieldItemSpawnID> ExistSpawnIDHashSet { get; set; }
	public HashSet<FieldHideItemSpawnID> ExistHideSpawnIDHashSet { get; set; }
	public bool IsSceneChangeCheckEnd { get; set; }

	// Methods

	// RVA: 0x1E24C40 Offset: 0x1E24D41 VA: 0x1E24C40
	public HashSet<FieldItemSpawnID> get_ExistSpawnIDHashSet() { }

	// RVA: 0x1E24C50 Offset: 0x1E24D51 VA: 0x1E24C50
	private void set_ExistSpawnIDHashSet(HashSet<FieldItemSpawnID> value) { }

	// RVA: 0x1E24C60 Offset: 0x1E24D61 VA: 0x1E24C60
	public HashSet<FieldHideItemSpawnID> get_ExistHideSpawnIDHashSet() { }

	// RVA: 0x1E24C70 Offset: 0x1E24D71 VA: 0x1E24C70
	private void set_ExistHideSpawnIDHashSet(HashSet<FieldHideItemSpawnID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF7C0 Offset: 0x1AF8C1 VA: 0x1AF7C0
	// RVA: 0x1E24C80 Offset: 0x1E24D81 VA: 0x1E24C80
	public bool get_IsSceneChangeCheckEnd() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF7D0 Offset: 0x1AF8D1 VA: 0x1AF7D0
	// RVA: 0x1E24C90 Offset: 0x1E24D91 VA: 0x1E24C90
	private void set_IsSceneChangeCheckEnd(bool value) { }

	// RVA: 0x1E24CA0 Offset: 0x1E24DA1 VA: 0x1E24CA0
	public bool IsDetectHideItemParties(int index = 0) { }

	// RVA: 0x1E24CE0 Offset: 0x1E24DE1 VA: 0x1E24CE0
	public static FieldItemSpawnDataTableArray GetDataTableArray() { }

	// RVA: 0x1E24D40 Offset: 0x1E24E41 VA: 0x1E24D40
	public static FieldItemSpawnDataTable[] GetDataTables() { }

	// RVA: 0x1E24DA0 Offset: 0x1E24EA1 VA: 0x1E24DA0
	public static FieldItemSpawnDataTable GetDataTable(FieldItemSpawnID id) { }

	// RVA: 0x1E24770 Offset: 0x1E24871 VA: 0x1E24770
	public static FieldHideItemSpawnDataTable GetDataTable(FieldHideItemSpawnID id) { }

	// RVA: 0x1E24E60 Offset: 0x1E24F61 VA: 0x1E24E60
	public void InitializeLoad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF7E0 Offset: 0x1AF8E1 VA: 0x1AF7E0
	// RVA: 0x1E24EF0 Offset: 0x1E24FF1 VA: 0x1E24EF0
	public IEnumerator LoadDataTable() { }

	// RVA: 0x1E24FA0 Offset: 0x1E250A1 VA: 0x1E24FA0
	private void OnDestroy() { }

	// RVA: 0x1E25370 Offset: 0x1E25471 VA: 0x1E25370 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E25440 Offset: 0x1E25541 VA: 0x1E25440
	private void Update() { }

	// RVA: 0x1E25800 Offset: 0x1E25901 VA: 0x1E25800
	private static bool Lottery(int weight) { }

	// RVA: 0x1E25840 Offset: 0x1E25941 VA: 0x1E25840
	public void OnAfterGameDataLoad() { }

	// RVA: 0x1E259E0 Offset: 0x1E25AE1 VA: 0x1E259E0
	public static void OnDayChangeSetFieldFlag(int elapsedDay = 1) { }

	// RVA: 0x1E25AF0 Offset: 0x1E25BF1 VA: 0x1E25AF0
	public void OnSceneChangeSetFieldFlag() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF850 Offset: 0x1AF951 VA: 0x1AF850
	// RVA: 0x1E25BC0 Offset: 0x1E25CC1 VA: 0x1E25BC0
	private IEnumerator CheckSceneItem() { }

	// RVA: 0x1E25C70 Offset: 0x1E25D71 VA: 0x1E25C70
	public bool AddOnGroundItem(OnGroundItem onGroundItem, FieldItemSpawnID id) { }

	// RVA: 0x1E25D50 Offset: 0x1E25E51 VA: 0x1E25D50
	public bool RemoveOnGroundItem(OnGroundItem onGroundItem, bool setFlag = False) { }

	// RVA: 0x1E26030 Offset: 0x1E26131 VA: 0x1E26030
	public bool OnGroundItemExists(OnGroundItem onGroundItem) { }

	// RVA: 0x1E24800 Offset: 0x1E24901 VA: 0x1E24800
	public bool AddHideOnGroundItem(OnGroundItem onGroundItem, FieldHideItemSpawnID id) { }

	// RVA: 0x1E25EA0 Offset: 0x1E25FA1 VA: 0x1E25EA0
	public bool RemoveHideOnGroundItem(OnGroundItem onGroundItem, bool setFlag = False) { }

	// RVA: 0x1E261E0 Offset: 0x1E262E1 VA: 0x1E261E0
	public bool HideOnGroundItemExists(OnGroundItem onGroundItem) { }

	// RVA: 0x1E26350 Offset: 0x1E26451 VA: 0x1E26350
	public bool FieldItemSpawnIDExists(FieldItemSpawnID fieldItemSpawnID) { }

	// RVA: 0x1E24600 Offset: 0x1E24701 VA: 0x1E24600
	public bool FieldHideItemSpawnIDExists(FieldHideItemSpawnID spawnID) { }

	// RVA: 0x1E25B80 Offset: 0x1E25C81 VA: 0x1E25B80
	public static void SetFieldItemSpawnFlag(FieldItemSpawnID id, bool value) { }

	// RVA: 0x1E263D0 Offset: 0x1E264D1 VA: 0x1E263D0
	public static bool GetFieldItemSpawnFlag(FieldItemSpawnID id) { }

	// RVA: 0x1E26100 Offset: 0x1E26201 VA: 0x1E26100
	public static void SetFieldHideItemSpawnFlag(FieldHideItemSpawnID id, bool value) { }

	// RVA: 0x1E24680 Offset: 0x1E24781 VA: 0x1E24680
	public static bool GetFieldHideItemSpawnFlag(FieldHideItemSpawnID id) { }

	// RVA: 0x1E24590 Offset: 0x1E24691 VA: 0x1E24590
	public static bool IsRestrictSpawn() { }

	// RVA: 0x1E26410 Offset: 0x1E26511 VA: 0x1E26410
	public bool AddItemSpawner(FieldItemSpawner itemSpawner) { }

	// RVA: 0x1E264D0 Offset: 0x1E265D1 VA: 0x1E264D0
	public bool RemoveItemSpawner(FieldItemSpawner itemSpawner) { }

	// RVA: 0x1E24140 Offset: 0x1E24241 VA: 0x1E24140
	public bool AddHideSpawner(FieldHideItemSpawner hideItemSpawner) { }

	// RVA: 0x1E23F30 Offset: 0x1E24031 VA: 0x1E23F30
	public bool RemoveHideSpawner(FieldHideItemSpawner hideItemSpawner) { }

	// RVA: 0x1E26590 Offset: 0x1E26691 VA: 0x1E26590
	public void OnChangeHideDetectFlag(bool enable) { }

	// RVA: 0x1E266A0 Offset: 0x1E267A1 VA: 0x1E266A0
	public void .ctor() { }
}

public class FieldItemSpawnDataManager : SingletonMonoBehaviour<FieldItemSpawnDataManager> // TypeDefIndex: 10484
{
	// Fields
	private FieldItemSpawnDataTableArray _FieldItemSpawnDataTableArray; // 0x18
	private HashSet<FieldItemSpawnID> _ExistSpawnIDHashSet; // 0x20
	private FieldHideItemSpawnDataTableArray _FieldHideItemSpawnDataTableArray; // 0x28
	private HashSet<FieldHideItemSpawnID> _ExistHideSpawnIDHashSet; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x181BA0 Offset: 0x181CA1 VA: 0x181BA0
	private bool <IsSceneChangeCheckEnd>k__BackingField; // 0x38
	private HashSet<FieldItemSpawner> ExistItemSpawnerHashSet; // 0x40
	private HashSet<FieldHideItemSpawner> ExistHideItemSpawnerHashSet; // 0x48
	private Dictionary<int, OnGroundItem> ExistItemDictionary; // 0x50
	private Dictionary<int, OnGroundItem> ExistHideItemDictionary; // 0x58
	private bool IsInit; // 0x60
	private bool[] CanDetectParties; // 0x68
	private bool[] IsDetectParties; // 0x70

	// Properties
	public HashSet<FieldItemSpawnID> ExistSpawnIDHashSet { get; set; }
	public HashSet<FieldHideItemSpawnID> ExistHideSpawnIDHashSet { get; set; }
	public bool IsSceneChangeCheckEnd { get; set; }

	// Methods

	// RVA: 0x1E24C40 Offset: 0x1E24D41 VA: 0x1E24C40
	public HashSet<FieldItemSpawnID> get_ExistSpawnIDHashSet() { }

	// RVA: 0x1E24C50 Offset: 0x1E24D51 VA: 0x1E24C50
	private void set_ExistSpawnIDHashSet(HashSet<FieldItemSpawnID> value) { }

	// RVA: 0x1E24C60 Offset: 0x1E24D61 VA: 0x1E24C60
	public HashSet<FieldHideItemSpawnID> get_ExistHideSpawnIDHashSet() { }

	// RVA: 0x1E24C70 Offset: 0x1E24D71 VA: 0x1E24C70
	private void set_ExistHideSpawnIDHashSet(HashSet<FieldHideItemSpawnID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF7C0 Offset: 0x1AF8C1 VA: 0x1AF7C0
	// RVA: 0x1E24C80 Offset: 0x1E24D81 VA: 0x1E24C80
	public bool get_IsSceneChangeCheckEnd() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF7D0 Offset: 0x1AF8D1 VA: 0x1AF7D0
	// RVA: 0x1E24C90 Offset: 0x1E24D91 VA: 0x1E24C90
	private void set_IsSceneChangeCheckEnd(bool value) { }

	// RVA: 0x1E24CA0 Offset: 0x1E24DA1 VA: 0x1E24CA0
	public bool IsDetectHideItemParties(int index = 0) { }

	// RVA: 0x1E24CE0 Offset: 0x1E24DE1 VA: 0x1E24CE0
	public static FieldItemSpawnDataTableArray GetDataTableArray() { }

	// RVA: 0x1E24D40 Offset: 0x1E24E41 VA: 0x1E24D40
	public static FieldItemSpawnDataTable[] GetDataTables() { }

	// RVA: 0x1E24DA0 Offset: 0x1E24EA1 VA: 0x1E24DA0
	public static FieldItemSpawnDataTable GetDataTable(FieldItemSpawnID id) { }

	// RVA: 0x1E24770 Offset: 0x1E24871 VA: 0x1E24770
	public static FieldHideItemSpawnDataTable GetDataTable(FieldHideItemSpawnID id) { }

	// RVA: 0x1E24E60 Offset: 0x1E24F61 VA: 0x1E24E60
	public void InitializeLoad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF7E0 Offset: 0x1AF8E1 VA: 0x1AF7E0
	// RVA: 0x1E24EF0 Offset: 0x1E24FF1 VA: 0x1E24EF0
	public IEnumerator LoadDataTable() { }

	// RVA: 0x1E24FA0 Offset: 0x1E250A1 VA: 0x1E24FA0
	private void OnDestroy() { }

	// RVA: 0x1E25370 Offset: 0x1E25471 VA: 0x1E25370 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E25440 Offset: 0x1E25541 VA: 0x1E25440
	private void Update() { }

	// RVA: 0x1E25800 Offset: 0x1E25901 VA: 0x1E25800
	private static bool Lottery(int weight) { }

	// RVA: 0x1E25840 Offset: 0x1E25941 VA: 0x1E25840
	public void OnAfterGameDataLoad() { }

	// RVA: 0x1E259E0 Offset: 0x1E25AE1 VA: 0x1E259E0
	public static void OnDayChangeSetFieldFlag(int elapsedDay = 1) { }

	// RVA: 0x1E25AF0 Offset: 0x1E25BF1 VA: 0x1E25AF0
	public void OnSceneChangeSetFieldFlag() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF850 Offset: 0x1AF951 VA: 0x1AF850
	// RVA: 0x1E25BC0 Offset: 0x1E25CC1 VA: 0x1E25BC0
	private IEnumerator CheckSceneItem() { }

	// RVA: 0x1E25C70 Offset: 0x1E25D71 VA: 0x1E25C70
	public bool AddOnGroundItem(OnGroundItem onGroundItem, FieldItemSpawnID id) { }

	// RVA: 0x1E25D50 Offset: 0x1E25E51 VA: 0x1E25D50
	public bool RemoveOnGroundItem(OnGroundItem onGroundItem, bool setFlag = False) { }

	// RVA: 0x1E26030 Offset: 0x1E26131 VA: 0x1E26030
	public bool OnGroundItemExists(OnGroundItem onGroundItem) { }

	// RVA: 0x1E24800 Offset: 0x1E24901 VA: 0x1E24800
	public bool AddHideOnGroundItem(OnGroundItem onGroundItem, FieldHideItemSpawnID id) { }

	// RVA: 0x1E25EA0 Offset: 0x1E25FA1 VA: 0x1E25EA0
	public bool RemoveHideOnGroundItem(OnGroundItem onGroundItem, bool setFlag = False) { }

	// RVA: 0x1E261E0 Offset: 0x1E262E1 VA: 0x1E261E0
	public bool HideOnGroundItemExists(OnGroundItem onGroundItem) { }

	// RVA: 0x1E26350 Offset: 0x1E26451 VA: 0x1E26350
	public bool FieldItemSpawnIDExists(FieldItemSpawnID fieldItemSpawnID) { }

	// RVA: 0x1E24600 Offset: 0x1E24701 VA: 0x1E24600
	public bool FieldHideItemSpawnIDExists(FieldHideItemSpawnID spawnID) { }

	// RVA: 0x1E25B80 Offset: 0x1E25C81 VA: 0x1E25B80
	public static void SetFieldItemSpawnFlag(FieldItemSpawnID id, bool value) { }

	// RVA: 0x1E263D0 Offset: 0x1E264D1 VA: 0x1E263D0
	public static bool GetFieldItemSpawnFlag(FieldItemSpawnID id) { }

	// RVA: 0x1E26100 Offset: 0x1E26201 VA: 0x1E26100
	public static void SetFieldHideItemSpawnFlag(FieldHideItemSpawnID id, bool value) { }

	// RVA: 0x1E24680 Offset: 0x1E24781 VA: 0x1E24680
	public static bool GetFieldHideItemSpawnFlag(FieldHideItemSpawnID id) { }

	// RVA: 0x1E24590 Offset: 0x1E24691 VA: 0x1E24590
	public static bool IsRestrictSpawn() { }

	// RVA: 0x1E26410 Offset: 0x1E26511 VA: 0x1E26410
	public bool AddItemSpawner(FieldItemSpawner itemSpawner) { }

	// RVA: 0x1E264D0 Offset: 0x1E265D1 VA: 0x1E264D0
	public bool RemoveItemSpawner(FieldItemSpawner itemSpawner) { }

	// RVA: 0x1E24140 Offset: 0x1E24241 VA: 0x1E24140
	public bool AddHideSpawner(FieldHideItemSpawner hideItemSpawner) { }

	// RVA: 0x1E23F30 Offset: 0x1E24031 VA: 0x1E23F30
	public bool RemoveHideSpawner(FieldHideItemSpawner hideItemSpawner) { }

	// RVA: 0x1E26590 Offset: 0x1E26691 VA: 0x1E26590
	public void OnChangeHideDetectFlag(bool enable) { }

	// RVA: 0x1E266A0 Offset: 0x1E267A1 VA: 0x1E266A0
	public void .ctor() { }
}

public class FieldItemSpawnDataManager : SingletonMonoBehaviour<FieldItemSpawnDataManager> // TypeDefIndex: 10484
{
	// Fields
	private FieldItemSpawnDataTableArray _FieldItemSpawnDataTableArray; // 0x18
	private HashSet<FieldItemSpawnID> _ExistSpawnIDHashSet; // 0x20
	private FieldHideItemSpawnDataTableArray _FieldHideItemSpawnDataTableArray; // 0x28
	private HashSet<FieldHideItemSpawnID> _ExistHideSpawnIDHashSet; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x181BA0 Offset: 0x181CA1 VA: 0x181BA0
	private bool <IsSceneChangeCheckEnd>k__BackingField; // 0x38
	private HashSet<FieldItemSpawner> ExistItemSpawnerHashSet; // 0x40
	private HashSet<FieldHideItemSpawner> ExistHideItemSpawnerHashSet; // 0x48
	private Dictionary<int, OnGroundItem> ExistItemDictionary; // 0x50
	private Dictionary<int, OnGroundItem> ExistHideItemDictionary; // 0x58
	private bool IsInit; // 0x60
	private bool[] CanDetectParties; // 0x68
	private bool[] IsDetectParties; // 0x70

	// Properties
	public HashSet<FieldItemSpawnID> ExistSpawnIDHashSet { get; set; }
	public HashSet<FieldHideItemSpawnID> ExistHideSpawnIDHashSet { get; set; }
	public bool IsSceneChangeCheckEnd { get; set; }

	// Methods

	// RVA: 0x1E24C40 Offset: 0x1E24D41 VA: 0x1E24C40
	public HashSet<FieldItemSpawnID> get_ExistSpawnIDHashSet() { }

	// RVA: 0x1E24C50 Offset: 0x1E24D51 VA: 0x1E24C50
	private void set_ExistSpawnIDHashSet(HashSet<FieldItemSpawnID> value) { }

	// RVA: 0x1E24C60 Offset: 0x1E24D61 VA: 0x1E24C60
	public HashSet<FieldHideItemSpawnID> get_ExistHideSpawnIDHashSet() { }

	// RVA: 0x1E24C70 Offset: 0x1E24D71 VA: 0x1E24C70
	private void set_ExistHideSpawnIDHashSet(HashSet<FieldHideItemSpawnID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF7C0 Offset: 0x1AF8C1 VA: 0x1AF7C0
	// RVA: 0x1E24C80 Offset: 0x1E24D81 VA: 0x1E24C80
	public bool get_IsSceneChangeCheckEnd() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF7D0 Offset: 0x1AF8D1 VA: 0x1AF7D0
	// RVA: 0x1E24C90 Offset: 0x1E24D91 VA: 0x1E24C90
	private void set_IsSceneChangeCheckEnd(bool value) { }

	// RVA: 0x1E24CA0 Offset: 0x1E24DA1 VA: 0x1E24CA0
	public bool IsDetectHideItemParties(int index = 0) { }

	// RVA: 0x1E24CE0 Offset: 0x1E24DE1 VA: 0x1E24CE0
	public static FieldItemSpawnDataTableArray GetDataTableArray() { }

	// RVA: 0x1E24D40 Offset: 0x1E24E41 VA: 0x1E24D40
	public static FieldItemSpawnDataTable[] GetDataTables() { }

	// RVA: 0x1E24DA0 Offset: 0x1E24EA1 VA: 0x1E24DA0
	public static FieldItemSpawnDataTable GetDataTable(FieldItemSpawnID id) { }

	// RVA: 0x1E24770 Offset: 0x1E24871 VA: 0x1E24770
	public static FieldHideItemSpawnDataTable GetDataTable(FieldHideItemSpawnID id) { }

	// RVA: 0x1E24E60 Offset: 0x1E24F61 VA: 0x1E24E60
	public void InitializeLoad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF7E0 Offset: 0x1AF8E1 VA: 0x1AF7E0
	// RVA: 0x1E24EF0 Offset: 0x1E24FF1 VA: 0x1E24EF0
	public IEnumerator LoadDataTable() { }

	// RVA: 0x1E24FA0 Offset: 0x1E250A1 VA: 0x1E24FA0
	private void OnDestroy() { }

	// RVA: 0x1E25370 Offset: 0x1E25471 VA: 0x1E25370 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E25440 Offset: 0x1E25541 VA: 0x1E25440
	private void Update() { }

	// RVA: 0x1E25800 Offset: 0x1E25901 VA: 0x1E25800
	private static bool Lottery(int weight) { }

	// RVA: 0x1E25840 Offset: 0x1E25941 VA: 0x1E25840
	public void OnAfterGameDataLoad() { }

	// RVA: 0x1E259E0 Offset: 0x1E25AE1 VA: 0x1E259E0
	public static void OnDayChangeSetFieldFlag(int elapsedDay = 1) { }

	// RVA: 0x1E25AF0 Offset: 0x1E25BF1 VA: 0x1E25AF0
	public void OnSceneChangeSetFieldFlag() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF850 Offset: 0x1AF951 VA: 0x1AF850
	// RVA: 0x1E25BC0 Offset: 0x1E25CC1 VA: 0x1E25BC0
	private IEnumerator CheckSceneItem() { }

	// RVA: 0x1E25C70 Offset: 0x1E25D71 VA: 0x1E25C70
	public bool AddOnGroundItem(OnGroundItem onGroundItem, FieldItemSpawnID id) { }

	// RVA: 0x1E25D50 Offset: 0x1E25E51 VA: 0x1E25D50
	public bool RemoveOnGroundItem(OnGroundItem onGroundItem, bool setFlag = False) { }

	// RVA: 0x1E26030 Offset: 0x1E26131 VA: 0x1E26030
	public bool OnGroundItemExists(OnGroundItem onGroundItem) { }

	// RVA: 0x1E24800 Offset: 0x1E24901 VA: 0x1E24800
	public bool AddHideOnGroundItem(OnGroundItem onGroundItem, FieldHideItemSpawnID id) { }

	// RVA: 0x1E25EA0 Offset: 0x1E25FA1 VA: 0x1E25EA0
	public bool RemoveHideOnGroundItem(OnGroundItem onGroundItem, bool setFlag = False) { }

	// RVA: 0x1E261E0 Offset: 0x1E262E1 VA: 0x1E261E0
	public bool HideOnGroundItemExists(OnGroundItem onGroundItem) { }

	// RVA: 0x1E26350 Offset: 0x1E26451 VA: 0x1E26350
	public bool FieldItemSpawnIDExists(FieldItemSpawnID fieldItemSpawnID) { }

	// RVA: 0x1E24600 Offset: 0x1E24701 VA: 0x1E24600
	public bool FieldHideItemSpawnIDExists(FieldHideItemSpawnID spawnID) { }

	// RVA: 0x1E25B80 Offset: 0x1E25C81 VA: 0x1E25B80
	public static void SetFieldItemSpawnFlag(FieldItemSpawnID id, bool value) { }

	// RVA: 0x1E263D0 Offset: 0x1E264D1 VA: 0x1E263D0
	public static bool GetFieldItemSpawnFlag(FieldItemSpawnID id) { }

	// RVA: 0x1E26100 Offset: 0x1E26201 VA: 0x1E26100
	public static void SetFieldHideItemSpawnFlag(FieldHideItemSpawnID id, bool value) { }

	// RVA: 0x1E24680 Offset: 0x1E24781 VA: 0x1E24680
	public static bool GetFieldHideItemSpawnFlag(FieldHideItemSpawnID id) { }

	// RVA: 0x1E24590 Offset: 0x1E24691 VA: 0x1E24590
	public static bool IsRestrictSpawn() { }

	// RVA: 0x1E26410 Offset: 0x1E26511 VA: 0x1E26410
	public bool AddItemSpawner(FieldItemSpawner itemSpawner) { }

	// RVA: 0x1E264D0 Offset: 0x1E265D1 VA: 0x1E264D0
	public bool RemoveItemSpawner(FieldItemSpawner itemSpawner) { }

	// RVA: 0x1E24140 Offset: 0x1E24241 VA: 0x1E24140
	public bool AddHideSpawner(FieldHideItemSpawner hideItemSpawner) { }

	// RVA: 0x1E23F30 Offset: 0x1E24031 VA: 0x1E23F30
	public bool RemoveHideSpawner(FieldHideItemSpawner hideItemSpawner) { }

	// RVA: 0x1E26590 Offset: 0x1E26691 VA: 0x1E26590
	public void OnChangeHideDetectFlag(bool enable) { }

	// RVA: 0x1E266A0 Offset: 0x1E267A1 VA: 0x1E266A0
	public void .ctor() { }
}

public class FieldItemSpawnDataManager : SingletonMonoBehaviour<FieldItemSpawnDataManager> // TypeDefIndex: 10484
{
	// Fields
	private FieldItemSpawnDataTableArray _FieldItemSpawnDataTableArray; // 0x18
	private HashSet<FieldItemSpawnID> _ExistSpawnIDHashSet; // 0x20
	private FieldHideItemSpawnDataTableArray _FieldHideItemSpawnDataTableArray; // 0x28
	private HashSet<FieldHideItemSpawnID> _ExistHideSpawnIDHashSet; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x181BA0 Offset: 0x181CA1 VA: 0x181BA0
	private bool <IsSceneChangeCheckEnd>k__BackingField; // 0x38
	private HashSet<FieldItemSpawner> ExistItemSpawnerHashSet; // 0x40
	private HashSet<FieldHideItemSpawner> ExistHideItemSpawnerHashSet; // 0x48
	private Dictionary<int, OnGroundItem> ExistItemDictionary; // 0x50
	private Dictionary<int, OnGroundItem> ExistHideItemDictionary; // 0x58
	private bool IsInit; // 0x60
	private bool[] CanDetectParties; // 0x68
	private bool[] IsDetectParties; // 0x70

	// Properties
	public HashSet<FieldItemSpawnID> ExistSpawnIDHashSet { get; set; }
	public HashSet<FieldHideItemSpawnID> ExistHideSpawnIDHashSet { get; set; }
	public bool IsSceneChangeCheckEnd { get; set; }

	// Methods

	// RVA: 0x1E24C40 Offset: 0x1E24D41 VA: 0x1E24C40
	public HashSet<FieldItemSpawnID> get_ExistSpawnIDHashSet() { }

	// RVA: 0x1E24C50 Offset: 0x1E24D51 VA: 0x1E24C50
	private void set_ExistSpawnIDHashSet(HashSet<FieldItemSpawnID> value) { }

	// RVA: 0x1E24C60 Offset: 0x1E24D61 VA: 0x1E24C60
	public HashSet<FieldHideItemSpawnID> get_ExistHideSpawnIDHashSet() { }

	// RVA: 0x1E24C70 Offset: 0x1E24D71 VA: 0x1E24C70
	private void set_ExistHideSpawnIDHashSet(HashSet<FieldHideItemSpawnID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF7C0 Offset: 0x1AF8C1 VA: 0x1AF7C0
	// RVA: 0x1E24C80 Offset: 0x1E24D81 VA: 0x1E24C80
	public bool get_IsSceneChangeCheckEnd() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF7D0 Offset: 0x1AF8D1 VA: 0x1AF7D0
	// RVA: 0x1E24C90 Offset: 0x1E24D91 VA: 0x1E24C90
	private void set_IsSceneChangeCheckEnd(bool value) { }

	// RVA: 0x1E24CA0 Offset: 0x1E24DA1 VA: 0x1E24CA0
	public bool IsDetectHideItemParties(int index = 0) { }

	// RVA: 0x1E24CE0 Offset: 0x1E24DE1 VA: 0x1E24CE0
	public static FieldItemSpawnDataTableArray GetDataTableArray() { }

	// RVA: 0x1E24D40 Offset: 0x1E24E41 VA: 0x1E24D40
	public static FieldItemSpawnDataTable[] GetDataTables() { }

	// RVA: 0x1E24DA0 Offset: 0x1E24EA1 VA: 0x1E24DA0
	public static FieldItemSpawnDataTable GetDataTable(FieldItemSpawnID id) { }

	// RVA: 0x1E24770 Offset: 0x1E24871 VA: 0x1E24770
	public static FieldHideItemSpawnDataTable GetDataTable(FieldHideItemSpawnID id) { }

	// RVA: 0x1E24E60 Offset: 0x1E24F61 VA: 0x1E24E60
	public void InitializeLoad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF7E0 Offset: 0x1AF8E1 VA: 0x1AF7E0
	// RVA: 0x1E24EF0 Offset: 0x1E24FF1 VA: 0x1E24EF0
	public IEnumerator LoadDataTable() { }

	// RVA: 0x1E24FA0 Offset: 0x1E250A1 VA: 0x1E24FA0
	private void OnDestroy() { }

	// RVA: 0x1E25370 Offset: 0x1E25471 VA: 0x1E25370 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E25440 Offset: 0x1E25541 VA: 0x1E25440
	private void Update() { }

	// RVA: 0x1E25800 Offset: 0x1E25901 VA: 0x1E25800
	private static bool Lottery(int weight) { }

	// RVA: 0x1E25840 Offset: 0x1E25941 VA: 0x1E25840
	public void OnAfterGameDataLoad() { }

	// RVA: 0x1E259E0 Offset: 0x1E25AE1 VA: 0x1E259E0
	public static void OnDayChangeSetFieldFlag(int elapsedDay = 1) { }

	// RVA: 0x1E25AF0 Offset: 0x1E25BF1 VA: 0x1E25AF0
	public void OnSceneChangeSetFieldFlag() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF850 Offset: 0x1AF951 VA: 0x1AF850
	// RVA: 0x1E25BC0 Offset: 0x1E25CC1 VA: 0x1E25BC0
	private IEnumerator CheckSceneItem() { }

	// RVA: 0x1E25C70 Offset: 0x1E25D71 VA: 0x1E25C70
	public bool AddOnGroundItem(OnGroundItem onGroundItem, FieldItemSpawnID id) { }

	// RVA: 0x1E25D50 Offset: 0x1E25E51 VA: 0x1E25D50
	public bool RemoveOnGroundItem(OnGroundItem onGroundItem, bool setFlag = False) { }

	// RVA: 0x1E26030 Offset: 0x1E26131 VA: 0x1E26030
	public bool OnGroundItemExists(OnGroundItem onGroundItem) { }

	// RVA: 0x1E24800 Offset: 0x1E24901 VA: 0x1E24800
	public bool AddHideOnGroundItem(OnGroundItem onGroundItem, FieldHideItemSpawnID id) { }

	// RVA: 0x1E25EA0 Offset: 0x1E25FA1 VA: 0x1E25EA0
	public bool RemoveHideOnGroundItem(OnGroundItem onGroundItem, bool setFlag = False) { }

	// RVA: 0x1E261E0 Offset: 0x1E262E1 VA: 0x1E261E0
	public bool HideOnGroundItemExists(OnGroundItem onGroundItem) { }

	// RVA: 0x1E26350 Offset: 0x1E26451 VA: 0x1E26350
	public bool FieldItemSpawnIDExists(FieldItemSpawnID fieldItemSpawnID) { }

	// RVA: 0x1E24600 Offset: 0x1E24701 VA: 0x1E24600
	public bool FieldHideItemSpawnIDExists(FieldHideItemSpawnID spawnID) { }

	// RVA: 0x1E25B80 Offset: 0x1E25C81 VA: 0x1E25B80
	public static void SetFieldItemSpawnFlag(FieldItemSpawnID id, bool value) { }

	// RVA: 0x1E263D0 Offset: 0x1E264D1 VA: 0x1E263D0
	public static bool GetFieldItemSpawnFlag(FieldItemSpawnID id) { }

	// RVA: 0x1E26100 Offset: 0x1E26201 VA: 0x1E26100
	public static void SetFieldHideItemSpawnFlag(FieldHideItemSpawnID id, bool value) { }

	// RVA: 0x1E24680 Offset: 0x1E24781 VA: 0x1E24680
	public static bool GetFieldHideItemSpawnFlag(FieldHideItemSpawnID id) { }

	// RVA: 0x1E24590 Offset: 0x1E24691 VA: 0x1E24590
	public static bool IsRestrictSpawn() { }

	// RVA: 0x1E26410 Offset: 0x1E26511 VA: 0x1E26410
	public bool AddItemSpawner(FieldItemSpawner itemSpawner) { }

	// RVA: 0x1E264D0 Offset: 0x1E265D1 VA: 0x1E264D0
	public bool RemoveItemSpawner(FieldItemSpawner itemSpawner) { }

	// RVA: 0x1E24140 Offset: 0x1E24241 VA: 0x1E24140
	public bool AddHideSpawner(FieldHideItemSpawner hideItemSpawner) { }

	// RVA: 0x1E23F30 Offset: 0x1E24031 VA: 0x1E23F30
	public bool RemoveHideSpawner(FieldHideItemSpawner hideItemSpawner) { }

	// RVA: 0x1E26590 Offset: 0x1E26691 VA: 0x1E26590
	public void OnChangeHideDetectFlag(bool enable) { }

	// RVA: 0x1E266A0 Offset: 0x1E267A1 VA: 0x1E266A0
	public void .ctor() { }
}

