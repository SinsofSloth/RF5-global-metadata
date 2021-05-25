[Serializable]
public class NpcTimeActionData // TypeDefIndex: 8135
{
	// Fields
	public string[] PatrolPoints; // 0x10
	public NpcPatrolPoint JobPatrolPoint; // 0x18
	public NpcPatrolPoint SeatPatrolPoint; // 0x20
	public NpcPatrolPoint BedPatrolPoint; // 0x28
	public string DoorPatrolPointName; // 0x30
	public string TargetDoorPatrolPointName; // 0x38
	public NpcPatrolPoint CurrentPatrolPoint; // 0x40
	public Place CurrentPlace; // 0x48
	public Place TargetPlace; // 0x4C
	public bool IsReached; // 0x50
	public LifecycleState CurrentLifecycleState; // 0x54
	public int CurrentPositionIndex; // 0x58
	public bool IsWaitNextAction; // 0x5C
	public Vector3 targetPosition; // 0x60
	public GameObject NextPatrolPoint; // 0x70
	public Vector3[] positions; // 0x78
	public string[] pointNames; // 0x80
	public Weather HomeBackWeather; // 0x88
	public int RotatePatternNumber; // 0x8C
	public bool IsOvertime; // 0x90

	// Properties
	public bool IsHomeBack { get; }

	// Methods

	// RVA: 0x1D8CC10 Offset: 0x1D8CD11 VA: 0x1D8CC10
	public bool get_IsHomeBack() { }

	// RVA: 0x1D8CC20 Offset: 0x1D8CD21 VA: 0x1D8CC20
	public NpcPatrolPoint GetTargetPoint() { }

	// RVA: 0x1D84300 Offset: 0x1D84401 VA: 0x1D84300
	public void .ctor() { }
}

