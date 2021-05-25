[CreateAssetMenuAttribute] // RVA: 0x1460A0 Offset: 0x1461A1 VA: 0x1460A0
public class MonsterActionBehaviorDataTable : ActionBehaviorDataTable // TypeDefIndex: 7011
{
	// Fields
	[SerializeField] // RVA: 0x162720 Offset: 0x162821 VA: 0x162720
	public List<MonsterActionBehaviorDataTable.MonsterActionBehaviorCodeData> DataList; // 0x48
	public List<List<ActionBehaviorCommandInformation>> InformationList2D; // 0x50

	// Methods

	// RVA: 0x1CC5E40 Offset: 0x1CC5F41 VA: 0x1CC5E40
	public void Setup() { }

	// RVA: 0x1CC4350 Offset: 0x1CC4451 VA: 0x1CC4350
	public List<ActionBehaviorCommandInformation> GetActionBehaviorCommandInformationList(MonsterActionBehaviorDataID monsterActionBehaviorDataID) { }

	// RVA: 0x1CC5F40 Offset: 0x1CC6041 VA: 0x1CC5F40
	public void .ctor() { }
}

