[Serializable]
public struct AdvScriptDefCountParam // TypeDefIndex: 8478
{
	// Fields
	[SerializeField] // RVA: 0x16FFE0 Offset: 0x1700E1 VA: 0x16FFE0
	public int NpcId; // 0x0
	[SerializeField] // RVA: 0x16FFF0 Offset: 0x1700F1 VA: 0x16FFF0
	public int[] RAND_NUM; // 0x8
	private static AdvScriptDefCountData _AdvScriptDefCountDataTable; // 0x0

	// Properties
	public static bool IsLoaded { get; }

	// Methods

	// RVA: 0x2F1F80 Offset: 0x2F2081 VA: 0x2F1F80
	public void Init() { }

	// RVA: 0x22760D0 Offset: 0x22761D1 VA: 0x22760D0
	private static AdvScriptDefCountData GetDataTable() { }

	// RVA: 0x22761F0 Offset: 0x22762F1 VA: 0x22761F0
	private static AdvScriptDefCountParam GetDataParam(int npcid) { }

	// RVA: 0x2276250 Offset: 0x2276351 VA: 0x2276250
	public static int GetRandNum(int npcid, int lv) { }

	// RVA: 0x22763E0 Offset: 0x22764E1 VA: 0x22763E0
	public static ValueTuple<int, int> GetDailyTalk_TypeAndID(int npcid, int lv, int rand) { }

	// RVA: 0x2276360 Offset: 0x2276461 VA: 0x2276360
	public static AdvScriptDefCountData.AdvScriptDefScriptType GetUseScriptTypes(int lv) { }

	// RVA: 0x2276550 Offset: 0x2276651 VA: 0x2276550
	public static void LoadData() { }

	// RVA: 0x2276680 Offset: 0x2276781 VA: 0x2276680
	public static bool get_IsLoaded() { }
}

