[Serializable]
public struct MineTypeDataTable // TypeDefIndex: 7461
{
	// Fields
	[SerializeField] // RVA: 0x1667C0 Offset: 0x1668C1 VA: 0x1667C0
	public string Name; // 0x0
	[SerializeField] // RVA: 0x1667D0 Offset: 0x1668D1 VA: 0x1667D0
	public string PrefabName; // 0x8
	[SerializeField] // RVA: 0x1667E0 Offset: 0x1668E1 VA: 0x1667E0
	public int HP; // 0x10
	[SerializeField] // RVA: 0x1667F0 Offset: 0x1668F1 VA: 0x1667F0
	public int Type; // 0x14
	[SerializeField] // RVA: 0x166800 Offset: 0x166901 VA: 0x166800
	public int BreakRate; // 0x18
	[SerializeField] // RVA: 0x166810 Offset: 0x166911 VA: 0x166810
	public int ScrapRate; // 0x1C
	[SerializeField] // RVA: 0x166820 Offset: 0x166921 VA: 0x166820
	public int Rate1; // 0x20
	[SerializeField] // RVA: 0x166830 Offset: 0x166931 VA: 0x166830
	public ItemID DropItem1; // 0x24
	[SerializeField] // RVA: 0x166840 Offset: 0x166941 VA: 0x166840
	public int Rate2; // 0x28
	[SerializeField] // RVA: 0x166850 Offset: 0x166951 VA: 0x166850
	public ItemID DropItem2; // 0x2C
	[SerializeField] // RVA: 0x166860 Offset: 0x166961 VA: 0x166860
	public int Rate3; // 0x30
	[SerializeField] // RVA: 0x166870 Offset: 0x166971 VA: 0x166870
	public ItemID DropItem3; // 0x34
	[SerializeField] // RVA: 0x166880 Offset: 0x166981 VA: 0x166880
	public ItemID DropItemHighRare; // 0x38
	private static MineTypeDataTableArray _MineTypeDataTableArray; // 0x0

	// Methods

	// RVA: 0x235A490 Offset: 0x235A591 VA: 0x235A490
	public static MineTypeDataTable GetDataTable(MineTypeID MineTypeId) { }
}

