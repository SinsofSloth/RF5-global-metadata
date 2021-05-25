[Serializable]
public class Area : MonoBehaviour // TypeDefIndex: 8234
{
	// Fields
	[SerializeField] // RVA: 0x16DB20 Offset: 0x16DC21 VA: 0x16DB20
	public NpcPatrolPoint[] JobPatrolPoints; // 0x18
	[SerializeField] // RVA: 0x16DB30 Offset: 0x16DC31 VA: 0x16DB30
	public NpcPatrolPoint[] WaitJobPatrolPoints; // 0x20
	[SerializeField] // RVA: 0x16DB40 Offset: 0x16DC41 VA: 0x16DB40
	public NpcPatrolPoint[] SeatPatrolPoints; // 0x28
	[SerializeField] // RVA: 0x16DB50 Offset: 0x16DC51 VA: 0x16DB50
	public NpcPatrolPoint[] EatPatrolPoints; // 0x30
	[SerializeField] // RVA: 0x16DB60 Offset: 0x16DC61 VA: 0x16DB60
	public NpcPatrolPoint[] FishingPatrolPoints; // 0x38
	[SerializeField] // RVA: 0x16DB70 Offset: 0x16DC71 VA: 0x16DB70
	public NpcPatrolPoint[] DatePatrolPoints; // 0x40
	[SerializeField] // RVA: 0x16DB80 Offset: 0x16DC81 VA: 0x16DB80
	public NpcPatrolPoint[] WaitSeatPatrolPoints; // 0x48
	[SerializeField] // RVA: 0x16DB90 Offset: 0x16DC91 VA: 0x16DB90
	public NpcPatrolPoint[] BedPatrolPoints; // 0x50
	[SerializeField] // RVA: 0x16DBA0 Offset: 0x16DCA1 VA: 0x16DBA0
	public NpcPatrolPoint[] DoorPatrolPoints; // 0x58
	[SerializeField] // RVA: 0x16DBB0 Offset: 0x16DCB1 VA: 0x16DBB0
	public NpcPatrolPoint[] RotatePatrolPoints; // 0x60
	[SerializeField] // RVA: 0x16DBC0 Offset: 0x16DCC1 VA: 0x16DBC0
	public int RotateRoutePercent; // 0x68
	[SerializeField] // RVA: 0x16DBD0 Offset: 0x16DCD1 VA: 0x16DBD0
	private int Capaticy; // 0x6C
	public Place PlaceName; // 0x70

	// Methods

	// RVA: 0x227F990 Offset: 0x227FA91 VA: 0x227F990
	private void Awake() { }

	// RVA: 0x227F9B0 Offset: 0x227FAB1 VA: 0x227F9B0
	public int GetCapacity() { }

	// RVA: 0x227F9C0 Offset: 0x227FAC1 VA: 0x227F9C0
	public void FreeAllPoints() { }

	// RVA: 0x227FE10 Offset: 0x227FF11 VA: 0x227FE10
	public NpcPatrolPoint GetFreeOnlyNpcPoint(NpcPatrolPoint[] CheckPatrolPoints, int NpcId) { }

	// RVA: 0x2280190 Offset: 0x2280291 VA: 0x2280190
	public NpcPatrolPoint GetFreePoint(NpcPatrolPoint[] CheckPatrolPoints, int NpcId = 0) { }

	// RVA: 0x227FE20 Offset: 0x227FF21 VA: 0x227FE20
	private NpcPatrolPoint GetNpcPoint(NpcPatrolPoint[] CheckPatrolPoints, int NpcId = 0) { }

	// RVA: 0x2280370 Offset: 0x2280471 VA: 0x2280370
	public NpcPatrolPoint GetBedPatrolPoint(int NpcId) { }

	// RVA: 0x2280570 Offset: 0x2280671 VA: 0x2280570
	public void ClearBedPatrolPoint(NpcPatrolPoint pp) { }

	// RVA: 0x2280600 Offset: 0x2280701 VA: 0x2280600
	public NpcPatrolPoint GetJobPatrolPoint(int NpcId) { }

	// RVA: 0x22806C0 Offset: 0x22807C1 VA: 0x22806C0
	public NpcPatrolPoint GetWaitJobPatrolPoint(int NpcId) { }

	// RVA: 0x22808C0 Offset: 0x22809C1 VA: 0x22808C0
	public void ClearJobPatrolPoint(NpcPatrolPoint pp) { }

	// RVA: 0x2280950 Offset: 0x2280A51 VA: 0x2280950
	public NpcPatrolPoint GetEatPatrolPoint(int NpcId) { }

	// RVA: 0x2280B60 Offset: 0x2280C61 VA: 0x2280B60
	public NpcPatrolPoint GetFishingPatrolPoint(int NpcId) { }

	// RVA: 0x2280C50 Offset: 0x2280D51 VA: 0x2280C50
	public NpcPatrolPoint GetSeatPatrolPoint(int NpcId) { }

	// RVA: 0x2280E30 Offset: 0x2280F31 VA: 0x2280E30
	public NpcPatrolPoint GetSeatPatrolPointOnlyNpc(int NpcId) { }

	// RVA: 0x2280D30 Offset: 0x2280E31 VA: 0x2280D30
	public NpcPatrolPoint GetBathPatrolPoint(Gender gender) { }

	// RVA: 0x2280E40 Offset: 0x2280F41 VA: 0x2280E40
	public NpcPatrolPoint GetWaitSeatPatrolPoint(int NpcId) { }

	// RVA: 0x2281050 Offset: 0x2281151 VA: 0x2281050
	public NpcPatrolPoint GetRotatePatrolPointEnd(int RotatePatternNumber, int NpcId = 0) { }

	// RVA: 0x22812B0 Offset: 0x22813B1 VA: 0x22812B0
	public NpcPatrolPoint ReadRotatePatrolPointEnd(int RotatePatternNumber) { }

	// RVA: 0x2281420 Offset: 0x2281521 VA: 0x2281420
	public NpcPatrolPoint GetDoorPoint(DoorType doortype) { }

	// RVA: 0x2281510 Offset: 0x2281611 VA: 0x2281510
	public NpcPatrolPoint GetRelayPatrolPoint(NpcData npcData) { }

	// RVA: 0x22816A0 Offset: 0x22817A1 VA: 0x22816A0
	public void ClearSeatPatrolPoint(NpcPatrolPoint pp) { }

	// RVA: 0x2281730 Offset: 0x2281831 VA: 0x2281730
	public bool IsAvailable() { }

	// RVA: 0x2281820 Offset: 0x2281921 VA: 0x2281820
	public AreaData GetCopyData() { }

	// RVA: 0x2280250 Offset: 0x2280351 VA: 0x2280250
	private bool RepelPatrolPoint(int npcId, int hour, int minutes) { }

	// RVA: 0x2281D70 Offset: 0x2281E71 VA: 0x2281D70
	public void .ctor() { }
}

