[Serializable]
public class NPCBehaviorDataTable // TypeDefIndex: 7018
{
	// Fields
	[SerializeField] // RVA: 0x1627B0 Offset: 0x1628B1 VA: 0x1627B0
	public ActorID ActorID; // 0x10
	[SerializeField] // RVA: 0x1627C0 Offset: 0x1628C1 VA: 0x1627C0
	public float BehaviorCoolTime; // 0x14
	[SerializeField] // RVA: 0x1627D0 Offset: 0x1628D1 VA: 0x1627D0
	public List<NPCActionData> ActionDataList; // 0x18
	private static NPCBehaviorDataTableArray _MonsterBehaviorDataTableArray; // 0x0

	// Methods

	// RVA: 0x1FB2980 Offset: 0x1FB2A81 VA: 0x1FB2980
	public static NPCBehaviorDataTable GetDataTable(ActorID actorID) { }

	// RVA: 0x1FB4CB0 Offset: 0x1FB4DB1 VA: 0x1FB4CB0
	public void .ctor() { }
}

