[Serializable]
public class BGMDataTable // TypeDefIndex: 6906
{
	// Fields
	[SerializeField] // RVA: 0x15FFE0 Offset: 0x1600E1 VA: 0x15FFE0
	public Audio AudioID; // 0x10
	[SerializeField] // RVA: 0x15FFF0 Offset: 0x1600F1 VA: 0x15FFF0
	public float LoopStartPoint; // 0x14
	[SerializeField] // RVA: 0x160000 Offset: 0x160101 VA: 0x160000
	public float LoopEndPoint; // 0x18
	[SerializeField] // RVA: 0x160010 Offset: 0x160111 VA: 0x160010
	public bool IsLoop; // 0x1C
	[SerializeField] // RVA: 0x160020 Offset: 0x160121 VA: 0x160020
	public string NameKey; // 0x20
	[SerializeField] // RVA: 0x160030 Offset: 0x160131 VA: 0x160030
	public int RecordType; // 0x28
	[SerializeField] // RVA: 0x160040 Offset: 0x160141 VA: 0x160040
	public int SortOrder; // 0x2C
	private static BGMDataTableArray _BGMDataTableArray; // 0x0

	// Methods

	// RVA: 0x2155700 Offset: 0x2155801 VA: 0x2155700
	public static BGMDataTable GetDataTable(BGMID bgmID) { }

	// RVA: 0x2155850 Offset: 0x2155951 VA: 0x2155850
	public static string GetBgmTitleKey(BGMID bgmID) { }

	// RVA: 0x2155870 Offset: 0x2155971 VA: 0x2155870
	public static List<BgmList> GetBgmList(int recordType) { }

	// RVA: 0x2155BB0 Offset: 0x2155CB1 VA: 0x2155BB0
	public void .ctor() { }
}

