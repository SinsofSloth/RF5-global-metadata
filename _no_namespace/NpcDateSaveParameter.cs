[MessagePackObjectAttribute] // RVA: 0x1460F0 Offset: 0x1461F1 VA: 0x1460F0
public class NpcDateSaveParameter // TypeDefIndex: 7139
{
	// Fields
	[KeyAttribute] // RVA: 0x1630E0 Offset: 0x1631E1 VA: 0x1630E0
	public DatProgressType ProgressType; // 0x10
	[KeyAttribute] // RVA: 0x163120 Offset: 0x163221 VA: 0x163120
	public DateType dateType; // 0x14
	[KeyAttribute] // RVA: 0x163160 Offset: 0x163261 VA: 0x163160
	public DateSpotID dateSpotID; // 0x18
	[KeyAttribute] // RVA: 0x1631A0 Offset: 0x1632A1 VA: 0x1631A0
	public int NpcId; // 0x1C
	[KeyAttribute] // RVA: 0x1631E0 Offset: 0x1632E1 VA: 0x1631E0
	public int dateStartTime; // 0x20
	[KeyAttribute] // RVA: 0x163220 Offset: 0x163321 VA: 0x163220
	public int meetingLimitTime; // 0x24
	[KeyAttribute] // RVA: 0x163260 Offset: 0x163361 VA: 0x163260
	public int meetingEventPointOnFlag; // 0x28
	[KeyAttribute] // RVA: 0x1632A0 Offset: 0x1633A1 VA: 0x1632A0
	public bool doSuppo; // 0x2C
	private static string[] SpotNameIdTable; // 0x0
	private static bool isSpotNameInitialized; // 0x8

	// Methods

	// RVA: 0x1D7D010 Offset: 0x1D7D111 VA: 0x1D7D010
	public void .ctor() { }

	// RVA: 0x1D7D7B0 Offset: 0x1D7D8B1 VA: 0x1D7D7B0
	public void Init() { }

	// RVA: 0x1D7D7D0 Offset: 0x1D7D8D1 VA: 0x1D7D7D0
	public string GetDateMeetingPlace() { }

	// RVA: 0x1D7DC90 Offset: 0x1D7DD91 VA: 0x1D7DC90
	public string GetDateSpotName() { }

	// RVA: 0x1D7E640 Offset: 0x1D7E741 VA: 0x1D7E640
	public void ReserveDate(int _npcId, DateType _type, DateSpotID _spot, int _startTime, int _limitTime, GameFlagData _flag, bool _doSuppo) { }

	// RVA: 0x1D7E830 Offset: 0x1D7E931 VA: 0x1D7E830
	public void ClearReserveDate() { }

	// RVA: 0x1D7E970 Offset: 0x1D7EA71 VA: 0x1D7E970
	private static void .cctor() { }
}

