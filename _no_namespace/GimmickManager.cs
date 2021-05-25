public class GimmickManager : SingletonMonoBehaviour<GimmickManager> // TypeDefIndex: 7441
{
	// Fields
	private GimmickLayoutDataTableArray _GimmickLayoutDataTableArray; // 0x18
	private HashSet<GimmickLayoutID> _ExistGimmickLayoutIDs; // 0x20
	private Dictionary<GimmickLayoutID, HashSet<GimmickBase>> GimmickBaseDictonary; // 0x28
	private string TargetItemName; // 0x30

	// Properties
	public HashSet<GimmickLayoutID> ExistGimmickLayoutIDs { get; set; }

	// Methods

	// RVA: 0x1EA5720 Offset: 0x1EA5821 VA: 0x1EA5720
	public static GimmickLayoutDataTable GetGimmickLayoutDataTable(GimmickLayoutID gimmickLayoutID) { }

	// RVA: 0x1EA57A0 Offset: 0x1EA58A1 VA: 0x1EA57A0
	public HashSet<GimmickLayoutID> get_ExistGimmickLayoutIDs() { }

	// RVA: 0x1EA57B0 Offset: 0x1EA58B1 VA: 0x1EA57B0
	private void set_ExistGimmickLayoutIDs(HashSet<GimmickLayoutID> value) { }

	// RVA: 0x1EA57C0 Offset: 0x1EA58C1 VA: 0x1EA57C0
	public bool AddGimmickBase(GimmickBase gimmickBase, GimmickLayoutID gimmickLayoutID) { }

	// RVA: 0x1EA5940 Offset: 0x1EA5A41 VA: 0x1EA5940
	public bool RemoveGimmickBase(GimmickBase gimmickBase, GimmickLayoutID gimmickLayoutID) { }

	// RVA: 0x1EA5A80 Offset: 0x1EA5B81 VA: 0x1EA5A80
	public bool GimmickBaseIDExists(GimmickLayoutID gimmickLayoutID) { }

	// RVA: 0x1EA5AF0 Offset: 0x1EA5BF1 VA: 0x1EA5AF0
	public HashSet<GimmickBase> GetGimmickBases(GimmickLayoutID gimmickLayoutID) { }

	// RVA: 0x1EA5B90 Offset: 0x1EA5C91 VA: 0x1EA5B90
	public void UpdateGimmickBase(GimmickLayoutID gimmickLayoutID, bool value) { }

	// RVA: 0x1EA5D20 Offset: 0x1EA5E21 VA: 0x1EA5D20
	private void OnSceneChangeSetFlag() { }

	// RVA: 0x1EA5FF0 Offset: 0x1EA60F1 VA: 0x1EA5FF0
	public string SetTargetItemName(string targetItemName) { }

	// RVA: 0x1EA6020 Offset: 0x1EA6121 VA: 0x1EA6020
	public string GetTargetItemName() { }

	// RVA: 0x1EA6030 Offset: 0x1EA6131 VA: 0x1EA6030
	private void Start() { }

	// RVA: 0x1EA60C0 Offset: 0x1EA61C1 VA: 0x1EA60C0
	public void InitializeLoad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0E40 Offset: 0x1A0F41 VA: 0x1A0E40
	// RVA: 0x1EA6150 Offset: 0x1EA6251 VA: 0x1EA6150
	private IEnumerator LoadGimmickData() { }

	// RVA: 0x1EA6200 Offset: 0x1EA6301 VA: 0x1EA6200
	public void OnAfterGameDataLoad() { }

	// RVA: 0x1E9D7C0 Offset: 0x1E9D8C1 VA: 0x1E9D7C0
	public static void SetGimmickLayoutFlag(GimmickLayoutID id, bool value) { }

	// RVA: 0x1E9ED70 Offset: 0x1E9EE71 VA: 0x1E9ED70
	public static bool GetGimmickLayoutFlag(GimmickLayoutID id) { }

	// RVA: 0x1EA62B0 Offset: 0x1EA63B1 VA: 0x1EA62B0
	public void .ctor() { }
}

