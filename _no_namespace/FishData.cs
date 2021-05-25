[Serializable]
public class FishData // TypeDefIndex: 7528
{
	// Fields
	[SerializeField] // RVA: 0x166D90 Offset: 0x166E91 VA: 0x166D90
	public ItemID ItemId; // 0x10
	[SerializeField] // RVA: 0x166DA0 Offset: 0x166EA1 VA: 0x166DA0
	public StampEnum StampEnum; // 0x14
	[SerializeField] // RVA: 0x166DB0 Offset: 0x166EB1 VA: 0x166DB0
	public int Min; // 0x18
	[SerializeField] // RVA: 0x166DC0 Offset: 0x166EC1 VA: 0x166DC0
	public int Max; // 0x1C
	[SerializeField] // RVA: 0x166DD0 Offset: 0x166ED1 VA: 0x166DD0
	public Vector3 Rotate; // 0x20
	[SerializeField] // RVA: 0x166DE0 Offset: 0x166EE1 VA: 0x166DE0
	public bool NotRotate90; // 0x2C
	[SerializeField] // RVA: 0x166DF0 Offset: 0x166EF1 VA: 0x166DF0
	public int LevelTable; // 0x30
	[SerializeField] // RVA: 0x166E00 Offset: 0x166F01 VA: 0x166E00
	public int UpPoint1; // 0x34
	[SerializeField] // RVA: 0x166E10 Offset: 0x166F11 VA: 0x166E10
	public ItemID UpFish1; // 0x38
	[SerializeField] // RVA: 0x166E20 Offset: 0x166F21 VA: 0x166E20
	public int UpPoint2; // 0x3C
	[SerializeField] // RVA: 0x166E30 Offset: 0x166F31 VA: 0x166E30
	public ItemID UpFish2; // 0x40
	[SerializeField] // RVA: 0x166E40 Offset: 0x166F41 VA: 0x166E40
	public int UpPoint3; // 0x44
	[SerializeField] // RVA: 0x166E50 Offset: 0x166F51 VA: 0x166E50
	public ItemID UpFish3; // 0x48
	[SerializeField] // RVA: 0x166E60 Offset: 0x166F61 VA: 0x166E60
	public int UpPointIka; // 0x4C
	private static bool IsLoad; // 0x0
	private static FishDataTableArray _FishDataTableArray; // 0x8
	private static FishData _dummy2; // 0x10

	// Methods

	// RVA: 0x1EF2AE0 Offset: 0x1EF2BE1 VA: 0x1EF2AE0
	public void .ctor(ItemID item_id, StampEnum stamp, int min, int max, float xr, float yr, float zr, bool not_r90, int level_tbl, int up_point1, ItemID up_fish1, int up_point2, ItemID up_fish2, int up_point3, ItemID up_fish3, int up_point_ika) { }

	// RVA: 0x1EF2BE0 Offset: 0x1EF2CE1 VA: 0x1EF2BE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EF3480 Offset: 0x1EF3581 VA: 0x1EF3480
	public static FishData GetFishData(ItemID itemID) { }

	// RVA: 0x1EF35F0 Offset: 0x1EF36F1 VA: 0x1EF35F0
	public static StampEnum GetStampEnum(ItemID itemID) { }

	// RVA: 0x1EF3730 Offset: 0x1EF3831 VA: 0x1EF3730
	public static void LoadData() { }

	// RVA: 0x1EF3860 Offset: 0x1EF3961 VA: 0x1EF3860
	private static void .cctor() { }
}

