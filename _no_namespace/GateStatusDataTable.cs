[Serializable]
public struct GateStatusDataTable // TypeDefIndex: 7765
{
	// Fields
	[SerializeField] // RVA: 0x1691F0 Offset: 0x1692F1 VA: 0x1691F0
	public GateStatusDataID StatusID; // 0x0
	[SerializeField] // RVA: 0x169200 Offset: 0x169301 VA: 0x169200
	public int Level; // 0x4
	[SerializeField] // RVA: 0x169210 Offset: 0x169311 VA: 0x169210
	public MonsterDataID GateMonsterId; // 0x8
	[SerializeField] // RVA: 0x169220 Offset: 0x169321 VA: 0x169220
	public bool IsIndicate; // 0xC
	[SerializeField] // RVA: 0x169230 Offset: 0x169331 VA: 0x169230
	public float CoolDownTime; // 0x10
	[SerializeField] // RVA: 0x169240 Offset: 0x169341 VA: 0x169240
	public float MoveWaitTime; // 0x14
	[SerializeField] // RVA: 0x169250 Offset: 0x169351 VA: 0x169250
	public float MoveCompleteTime; // 0x18
	[SerializeField] // RVA: 0x169260 Offset: 0x169361 VA: 0x169260
	public bool IsSpawnPosRotFixed; // 0x1C
	[SerializeField] // RVA: 0x169270 Offset: 0x169371 VA: 0x169270
	public GateTimeZoneMonsterData GateTimeZoneMonsterData; // 0x20
	private static bool IsLoad; // 0x0
	private static GateStatusDataTableArray _GateStatusDataTableArray; // 0x8

	// Methods

	// RVA: 0x1E45E00 Offset: 0x1E45F01 VA: 0x1E45E00
	public static GateStatusDataTable GetDataTable(GateStatusDataID gateDataID) { }

	// RVA: 0x1E45FE0 Offset: 0x1E460E1 VA: 0x1E45FE0
	public static void LoadData() { }

	// RVA: 0x1E46110 Offset: 0x1E46211 VA: 0x1E46110
	private static void .cctor() { }
}

