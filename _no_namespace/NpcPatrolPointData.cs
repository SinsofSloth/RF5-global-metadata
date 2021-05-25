[Serializable]
public class NpcPatrolPointData // TypeDefIndex: 8123
{
	// Fields
	public Transform transform; // 0x10
	public string name; // 0x18
	public NpcController npc; // 0x20
	public NpcPatrolRoute[] NpcPatrolRoutes; // 0x28
	public float PatrolSpeed; // 0x30
	public float WaitMinutes; // 0x34
	public string doorName; // 0x38
	public DoorType DoorType; // 0x40
	public string WarpSceneName; // 0x48
	public string WarpTagetPointName; // 0x50
	public float arriveDistance; // 0x58
	public GameObject DoorObj; // 0x60
	public bool IsFree; // 0x68
	public Gender Gender; // 0x6C
	public bool Destination; // 0x70

	// Methods

	// RVA: 0x1D8AB10 Offset: 0x1D8AC11 VA: 0x1D8AB10
	public void .ctor() { }
}

