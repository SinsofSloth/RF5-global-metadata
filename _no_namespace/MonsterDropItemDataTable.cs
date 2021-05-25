[Serializable]
public struct MonsterDropItemDataTable // TypeDefIndex: 7775
{
	// Fields
	[SerializeField] // RVA: 0x1697B0 Offset: 0x1698B1 VA: 0x1697B0
	public MonsterDropItemDataID DataID; // 0x0
	[SerializeField] // RVA: 0x1697C0 Offset: 0x1698C1 VA: 0x1697C0
	public List<DropItemParam> DropItemParamList; // 0x8
	[SerializeField] // RVA: 0x1697D0 Offset: 0x1698D1 VA: 0x1697D0
	public List<DropItemParam> HandcuffsDropItemParamList; // 0x10
	[SerializeField] // RVA: 0x1697E0 Offset: 0x1698E1 VA: 0x1697E0
	public List<DropItemParam> BonusDropItemParamList; // 0x18
	private static bool IsLoad; // 0x0
	private static MonsterDropItemDataTableArray _MonsterDropItemDataTableArray; // 0x8

	// Methods

	// RVA: 0x21647D0 Offset: 0x21648D1 VA: 0x21647D0
	public static MonsterDropItemDataTable GetDataTable(MonsterDropItemDataID dataID) { }

	// RVA: 0x2172B40 Offset: 0x2172C41 VA: 0x2172B40
	private static void LoadData() { }

	// RVA: 0x2172C70 Offset: 0x2172D71 VA: 0x2172C70
	private static void .cctor() { }
}

