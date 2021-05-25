[Serializable]
public class MonsterActionData // TypeDefIndex: 7748
{
	// Fields
	[HeaderAttribute] // RVA: 0x169050 Offset: 0x169151 VA: 0x169050
	public string ActionCodeArrayDataTableName; // 0x10
	[SerializeField] // RVA: 0x169090 Offset: 0x169191 VA: 0x169090
	public MonsterActionInformation[] ActionInformationArray; // 0x18
	[SerializeField] // RVA: 0x1690A0 Offset: 0x1691A1 VA: 0x1690A0
	public MonsterActionInformationBase[] ActionInformationBaseArray; // 0x20
	[SerializeField] // RVA: 0x1690B0 Offset: 0x1691B1 VA: 0x1690B0
	public MonsterActionInformation B_Button_Information; // 0x28
	[SerializeField] // RVA: 0x1690C0 Offset: 0x1691C1 VA: 0x1690C0
	public MonsterActionInformation X_Button_Information; // 0x30
	[SerializeField] // RVA: 0x1690D0 Offset: 0x1691D1 VA: 0x1690D0
	public MonsterActionInformation Y_Button_Information; // 0x38
	[SerializeField] // RVA: 0x1690E0 Offset: 0x1691E1 VA: 0x1690E0
	public List<MonsterActionBehaviorData> ActionBehaviorDataList; // 0x40
	public Dictionary<int, MonsterActionInformation> ActionInformationDic; // 0x48
	public Dictionary<int, MonsterActionInformationBase> ActionInformationBaseDic; // 0x50

	// Methods

	// RVA: 0x1CC6130 Offset: 0x1CC6231 VA: 0x1CC6130
	public void OnAfterDeserialize() { }

	// RVA: 0x1CC5C60 Offset: 0x1CC5D61 VA: 0x1CC5C60
	public MonsterActionInformation GetActionInformation(int actionTypeNo) { }

	// RVA: 0x1CC62F0 Offset: 0x1CC63F1 VA: 0x1CC62F0
	public MonsterActionInformationBase GetActionInformationBase(int actionTypeNo) { }

	// RVA: 0x1CC6360 Offset: 0x1CC6461 VA: 0x1CC6360
	public MonsterActionInformationBase GetFarmActionInformationBase() { }

	// RVA: 0x1CC63C0 Offset: 0x1CC64C1 VA: 0x1CC63C0
	public Master GetActionCodeArrayDataID() { }

	// RVA: 0x1CC6470 Offset: 0x1CC6571 VA: 0x1CC6470
	private static Master StringToID(string idName) { }

	// RVA: 0x1CC6520 Offset: 0x1CC6621 VA: 0x1CC6520
	public void .ctor() { }
}

