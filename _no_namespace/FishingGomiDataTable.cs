[Serializable]
public class FishingGomiDataTable // TypeDefIndex: 6962
{
	// Fields
	[SerializeField] // RVA: 0x162050 Offset: 0x162151 VA: 0x162050
	public ItemID ItemID; // 0x10
	[SerializeField] // RVA: 0x162060 Offset: 0x162161 VA: 0x162060
	public int Akikan; // 0x14
	[SerializeField] // RVA: 0x162070 Offset: 0x162171 VA: 0x162070
	public int Nagagutsu; // 0x18
	[SerializeField] // RVA: 0x162080 Offset: 0x162181 VA: 0x162080
	public int Reanaakikan; // 0x1C
	private static bool IsLoad; // 0x0
	private static FishingGomiDataTableArray _FishingGomiDataTableArray; // 0x8

	// Methods

	// RVA: 0x1D4F2B0 Offset: 0x1D4F3B1 VA: 0x1D4F2B0
	public void .ctor() { }

	// RVA: 0x1D4F2C0 Offset: 0x1D4F3C1 VA: 0x1D4F2C0
	public void .ctor(ItemID item_id, int akikan, int nagagutsu, int reanaakikan) { }

	// RVA: 0x1D4F310 Offset: 0x1D4F411 VA: 0x1D4F310
	private static FishingGomiDataTable GetDataTable(ItemID Rod) { }

	// RVA: 0x1D4F4F0 Offset: 0x1D4F5F1 VA: 0x1D4F4F0
	public static ItemID ReLottery(ItemID rod) { }

	// RVA: 0x1D4F5C0 Offset: 0x1D4F6C1 VA: 0x1D4F5C0
	public static void LoadData() { }

	// RVA: 0x1D4F6F0 Offset: 0x1D4F7F1 VA: 0x1D4F6F0
	private static void .cctor() { }
}

