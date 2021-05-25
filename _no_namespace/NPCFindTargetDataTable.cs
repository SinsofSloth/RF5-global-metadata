[Serializable]
public class NPCFindTargetDataTable // TypeDefIndex: 7020
{
	// Fields
	public NPCFindTargetDataID DataID; // 0x10
	public NPCActionTargetType ActionTargetType; // 0x14
	public ActorID ActorID; // 0x18
	public NPCTargetParameter TargetParameter; // 0x1C
	public ComparisonOperatorsType ComparisonOperatorsType; // 0x20
	public float ComparisonValue; // 0x24
	private static NPCFindTargetDataTableArray _MonsterBehaviorDataTableArray; // 0x0

	// Methods

	// RVA: 0x1FB2040 Offset: 0x1FB2141 VA: 0x1FB2040
	public static NPCFindTargetDataTable GetDataTable(NPCFindTargetDataID dataID) { }

	// RVA: 0x1FB4DF0 Offset: 0x1FB4EF1 VA: 0x1FB4DF0
	public void .ctor() { }
}

