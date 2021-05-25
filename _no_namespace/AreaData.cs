[Serializable]
public class AreaData // TypeDefIndex: 8235
{
	// Fields
	public List<NpcPatrolPointData> JobPatrolPoints; // 0x10
	public List<NpcPatrolPointData> WaitJobPatrolPoints; // 0x18
	public List<NpcPatrolPointData> SeatPatrolPoints; // 0x20
	public List<NpcPatrolPointData> WaitSeatPatrolPoints; // 0x28
	public List<NpcPatrolPointData> BedPatrolPoints; // 0x30
	public List<NpcPatrolPointData> DoorPatrolPoints; // 0x38
	public List<NpcPatrolPointData> RotatePatrolPoints; // 0x40
	public int Capaticy; // 0x48
	public Place PlaceName; // 0x4C

	// Methods

	// RVA: 0x2281D80 Offset: 0x2281E81 VA: 0x2281D80
	public int GetCapacity() { }

	// RVA: 0x2281D90 Offset: 0x2281E91 VA: 0x2281D90
	public void FreeAllPoints() { }

	// RVA: 0x2282220 Offset: 0x2282321 VA: 0x2282220
	public NpcPatrolPointData GetBedPatrolPoint() { }

	// RVA: 0x2282330 Offset: 0x2282431 VA: 0x2282330
	public void ClearBedPatrolPoint(NpcPatrolPointData pp) { }

	// RVA: 0x2282350 Offset: 0x2282451 VA: 0x2282350
	public NpcPatrolPointData GetJobPatrolPoint() { }

	// RVA: 0x2282460 Offset: 0x2282561 VA: 0x2282460
	public NpcPatrolPointData GetWaitJobPatrolPoint() { }

	// RVA: 0x2282570 Offset: 0x2282671 VA: 0x2282570
	public void ClearJobPatrolPoint(NpcPatrolPointData pp) { }

	// RVA: 0x2282590 Offset: 0x2282691 VA: 0x2282590
	public NpcPatrolPointData GetSeatPatrolPoint() { }

	// RVA: 0x22826C0 Offset: 0x22827C1 VA: 0x22826C0
	public NpcPatrolPointData GetBathPatrolPoint(Gender gender) { }

	// RVA: 0x22827F0 Offset: 0x22828F1 VA: 0x22827F0
	public NpcPatrolPointData GetWaitSeatPatrolPoint() { }

	// RVA: 0x2282900 Offset: 0x2282A01 VA: 0x2282900
	public void ClearSeatPatrolPoint(NpcPatrolPointData pp) { }

	// RVA: 0x2282920 Offset: 0x2282A21 VA: 0x2282920
	public bool IsAvailable() { }

	// RVA: 0x2281D60 Offset: 0x2281E61 VA: 0x2281D60
	public void .ctor() { }
}

