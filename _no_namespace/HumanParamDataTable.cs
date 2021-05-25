[Serializable]
public class HumanParamDataTable // TypeDefIndex: 6976
{
	// Fields
	[SerializeField] // RVA: 0x1622B0 Offset: 0x1623B1 VA: 0x1622B0
	public CharaParamDataTable CharaParam; // 0x10
	[SerializeField] // RVA: 0x1622C0 Offset: 0x1623C1 VA: 0x1622C0
	public ItemID[] StartEquipItemID; // 0x18
	private static HumanPramDataTableArray _HumanPramDataTableArray; // 0x0

	// Methods

	// RVA: 0x20C16F0 Offset: 0x20C17F1 VA: 0x20C16F0
	public static HumanParamDataTable GetDataTable(ActorID id) { }

	// RVA: 0x20C1840 Offset: 0x20C1941 VA: 0x20C1840
	public static bool HasDataTable(ActorID id) { }

	// RVA: 0x20C1990 Offset: 0x20C1A91 VA: 0x20C1990
	public static SerializedHumanParamDataTable[] GetDataTables() { }

	// RVA: 0x20C1AD0 Offset: 0x20C1BD1 VA: 0x20C1AD0
	public void .ctor() { }
}

