[Serializable]
public struct MiningDataTable // TypeDefIndex: 7463
{
	// Fields
	[SerializeField] // RVA: 0x166890 Offset: 0x166991 VA: 0x166890
	public int MiningPointID; // 0x0
	[SerializeField] // RVA: 0x1668A0 Offset: 0x1669A1 VA: 0x1668A0
	public List<MiningPair> MiningList; // 0x8
	private static MiningDataTableArray _miningDataTableArray; // 0x0

	// Methods

	// RVA: 0x235B480 Offset: 0x235B581 VA: 0x235B480
	public static MiningDataTable GetDataTable(MiningID miningId) { }

	// RVA: 0x235B5C0 Offset: 0x235B6C1 VA: 0x235B5C0
	public static List<MiningPair> GetDataTable4List(MiningID miningId) { }

	// RVA: 0x235B6E0 Offset: 0x235B7E1 VA: 0x235B6E0
	public static int GetDataTableCount() { }
}

