[Serializable]
public struct GateDataTable // TypeDefIndex: 7763
{
	// Fields
	[SerializeField] // RVA: 0x1691B0 Offset: 0x1692B1 VA: 0x1691B0
	public GateDataID GateDataTableID; // 0x0
	[SerializeField] // RVA: 0x1691C0 Offset: 0x1692C1 VA: 0x1691C0
	public int DestroyEvent; // 0x4
	[SerializeField] // RVA: 0x1691D0 Offset: 0x1692D1 VA: 0x1691D0
	public GateSeasonData GateSeasonData; // 0x8
	private static bool IsLoad; // 0x0
	private static GateDataTableArray _GateDataTableArray; // 0x8

	// Methods

	// RVA: 0x1E44580 Offset: 0x1E44681 VA: 0x1E44580
	public static GateDataTable GetDataTable(GateDataID gateDataID) { }

	// RVA: 0x1E44740 Offset: 0x1E44841 VA: 0x1E44740
	public static void LoadData() { }

	// RVA: 0x1E44870 Offset: 0x1E44971 VA: 0x1E44870
	private static void .cctor() { }
}

