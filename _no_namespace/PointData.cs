[Serializable]
public class PointData // TypeDefIndex: 7532
{
	// Fields
	[SerializeField] // RVA: 0x166E80 Offset: 0x166F81 VA: 0x166E80
	public string Id; // 0x10
	[SerializeField] // RVA: 0x166E90 Offset: 0x166F91 VA: 0x166E90
	public ItemID FishId; // 0x18
	[SerializeField] // RVA: 0x166EA0 Offset: 0x166FA1 VA: 0x166EA0
	public int Rank; // 0x1C
	[SerializeField] // RVA: 0x166EB0 Offset: 0x166FB1 VA: 0x166EB0
	public int Rate; // 0x20
	[SerializeField] // RVA: 0x166EC0 Offset: 0x166FC1 VA: 0x166EC0
	public int Spring0; // 0x24
	[SerializeField] // RVA: 0x166ED0 Offset: 0x166FD1 VA: 0x166ED0
	public int Spring1; // 0x28
	[SerializeField] // RVA: 0x166EE0 Offset: 0x166FE1 VA: 0x166EE0
	public int Summer0; // 0x2C
	[SerializeField] // RVA: 0x166EF0 Offset: 0x166FF1 VA: 0x166EF0
	public int Summer1; // 0x30
	[SerializeField] // RVA: 0x166F00 Offset: 0x167001 VA: 0x166F00
	public int Autumn0; // 0x34
	[SerializeField] // RVA: 0x166F10 Offset: 0x167011 VA: 0x166F10
	public int Autumn1; // 0x38
	[SerializeField] // RVA: 0x166F20 Offset: 0x167021 VA: 0x166F20
	public int Winter0; // 0x3C
	[SerializeField] // RVA: 0x166F30 Offset: 0x167031 VA: 0x166F30
	public int Winter1; // 0x40
	private static bool IsLoad; // 0x0
	private static PointDataTableArray _PointDataTableArray; // 0x8
	private static List<RandomData> list_; // 0x10
	private static List<UpPointData> UpPointList; // 0x18

	// Methods

	// RVA: 0x220A4E0 Offset: 0x220A5E1 VA: 0x220A4E0
	public void .ctor(string id, ItemID fish_id, int rank, int rate, int spring0, int spring1, int summer0, int summer1, int autumn0, int autumn1, int winter0, int winter1) { }

	// RVA: 0x220A590 Offset: 0x220A691 VA: 0x220A590 Slot: 3
	public override string ToString() { }

	// RVA: 0x220ACE0 Offset: 0x220ADE1 VA: 0x220ACE0
	public static ItemID GetFish(string id, int rank, int season, ItemData itemData, bool IkaTaikai = False) { }

	// RVA: 0x220BAC0 Offset: 0x220BBC1 VA: 0x220BAC0
	public static void LoadData() { }

	// RVA: 0x220BBF0 Offset: 0x220BCF1 VA: 0x220BBF0
	private static void .cctor() { }
}

