[Serializable]
public struct MonsterBehaviorDataTable // TypeDefIndex: 7767
{
	// Fields
	[SerializeField] // RVA: 0x169290 Offset: 0x169391 VA: 0x169290
	public MonsterSearchRangeData SearchRangeData; // 0x0
	[SerializeField] // RVA: 0x1692A0 Offset: 0x1693A1 VA: 0x1692A0
	public MonsterDamageInfoIdPairsData DamageInfoIdPairs; // 0x8
	[SerializeField] // RVA: 0x1692B0 Offset: 0x1693B1 VA: 0x1692B0
	public MonsterActionData ActionData; // 0x10
	private static bool IsLoad; // 0x0
	private static MonsterBehaviorDataTableArray _MonsterBehaviorDataTableArray; // 0x8

	// Methods

	// RVA: 0x2E2B90 Offset: 0x2E2C91 VA: 0x2E2B90
	public void OnAfterDeserialize() { }

	// RVA: 0x2161900 Offset: 0x2161A01 VA: 0x2161900
	public static MonsterBehaviorDataTable GetDataTable(MonsterBehaviorDataID monsterBehaviorDataID) { }

	// RVA: 0x2161AD0 Offset: 0x2161BD1 VA: 0x2161AD0
	public static void LoadData() { }

	// RVA: 0x2161C00 Offset: 0x2161D01 VA: 0x2161C00
	private static void .cctor() { }
}

