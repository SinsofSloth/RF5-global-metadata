[Serializable]
public class CrystalDataTable // TypeDefIndex: 6940
{
	// Fields
	[SerializeField] // RVA: 0x161A00 Offset: 0x161B01 VA: 0x161A00
	public ItemID FragmentItemID; // 0x10
	private static CrystalDataTableArray _CrystalDataTableArray; // 0x0

	// Methods

	// RVA: 0x1FD4770 Offset: 0x1FD4871 VA: 0x1FD4770
	public static CrystalDataTable GetDataTable(ItemID CrystalID) { }

	// RVA: 0x1FD48B0 Offset: 0x1FD49B1 VA: 0x1FD48B0
	public static bool HasDataTable(ItemID CrystalID) { }

	// RVA: 0x1FD49F0 Offset: 0x1FD4AF1 VA: 0x1FD49F0
	public static IEnumerable<SerializeCrystalDataTable> GetDataTables() { }

	// RVA: 0x1FD4B10 Offset: 0x1FD4C11 VA: 0x1FD4B10
	public void .ctor() { }
}

