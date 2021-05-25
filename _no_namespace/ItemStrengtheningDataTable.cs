[Serializable]
public class ItemStrengtheningDataTable // TypeDefIndex: 6990
{
	// Fields
	[SerializeField] // RVA: 0x1624C0 Offset: 0x1625C1 VA: 0x1624C0
	public int Difficulty; // 0x10
	[SerializeField] // RVA: 0x1624D0 Offset: 0x1625D1 VA: 0x1624D0
	public Parameter Parameter; // 0x14
	[SerializeField] // RVA: 0x1624E0 Offset: 0x1625E1 VA: 0x1624E0
	public MagicID MagicID1; // 0xD0
	[SerializeField] // RVA: 0x1624F0 Offset: 0x1625F1 VA: 0x1624F0
	public MagicID MagicID2; // 0xD4
	[SerializeField] // RVA: 0x162500 Offset: 0x162601 VA: 0x162500
	public MagicID MagicID3; // 0xD8
	[SerializeField] // RVA: 0x162510 Offset: 0x162611 VA: 0x162510
	public EquipSubAttribute[] EquipSubAttribute; // 0xE0
	[SerializeField] // RVA: 0x162520 Offset: 0x162621 VA: 0x162520
	public bool IsGomi; // 0xE8
	[SerializeField] // RVA: 0x162530 Offset: 0x162631 VA: 0x162530
	public UseParameter UseParameter; // 0xF0
	private static ItemStrengtheningDataTableArray _ItemStrengtheningDataTableArray; // 0x0

	// Methods

	// RVA: 0x2091460 Offset: 0x2091561 VA: 0x2091460
	public static ItemStrengtheningDataTable GetDataTable(ItemID itemID) { }

	// RVA: 0x2091600 Offset: 0x2091701 VA: 0x2091600
	public static SerializedStrengtheningDataTable[] GetDataTables() { }

	// RVA: 0x2091720 Offset: 0x2091821 VA: 0x2091720
	public static bool HasDataTable(ItemID itemID) { }

	// RVA: 0x20915F0 Offset: 0x20916F1 VA: 0x20915F0
	public void .ctor() { }
}

