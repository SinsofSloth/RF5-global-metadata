[CreateAssetMenuAttribute] // RVA: 0x1460B0 Offset: 0x1461B1 VA: 0x1460B0
public class NPCActionBehaviorDataTable : ActionBehaviorDataTable // TypeDefIndex: 7016
{
	// Fields
	[SerializeField] // RVA: 0x1627A0 Offset: 0x1628A1 VA: 0x1627A0
	public List<NPCActionBehaviorDataTable.NPCActionBehaviorCodeData> DataList; // 0x48
	public List<List<ActionBehaviorCommandInformation>> InformationList2D; // 0x50

	// Methods

	// RVA: 0x1FB4B90 Offset: 0x1FB4C91 VA: 0x1FB4B90
	public void Setup() { }

	// RVA: 0x1FB1910 Offset: 0x1FB1A11 VA: 0x1FB1910
	public List<ActionBehaviorCommandInformation> GetActionBehaviorCommandInformationList(NPCActionBehaviorDataID npcActionBehaviorDataID) { }

	// RVA: 0x1FB4C90 Offset: 0x1FB4D91 VA: 0x1FB4C90
	public void .ctor() { }
}

