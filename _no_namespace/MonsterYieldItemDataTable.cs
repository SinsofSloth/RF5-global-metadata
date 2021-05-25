public struct MonsterYieldItemDataTable // TypeDefIndex: 7781
{
	// Fields
	[SerializeField] // RVA: 0x169920 Offset: 0x169A21 VA: 0x169920
	public MonsterYieldItemDataID DataID; // 0x0
	[SerializeField] // RVA: 0x169930 Offset: 0x169A31 VA: 0x169930
	public int YieldPercent; // 0x4
	[SerializeField] // RVA: 0x169940 Offset: 0x169A41 VA: 0x169940
	private List<YieldItemParam> YieldItemParamList; // 0x8
	private static MonsterYieldItemDataTableArray _MonsterYieldItemDataTableArray; // 0x0

	// Methods

	// RVA: 0x1CD90F0 Offset: 0x1CD91F1 VA: 0x1CD90F0
	public static MonsterYieldItemDataTable GetDataTable(MonsterYieldItemDataID dataID) { }

	// RVA: 0x1CD91F0 Offset: 0x1CD92F1 VA: 0x1CD91F0
	private static void .cctor() { }
}

