[Serializable]
public class NpcPatrolPoint : MonoBehaviour // TypeDefIndex: 8241
{
	// Fields
	[KeyAttribute] // RVA: 0x16DD40 Offset: 0x16DE41 VA: 0x16DD40
	[SerializeField] // RVA: 0x16DD40 Offset: 0x16DE41 VA: 0x16DD40
	private NpcController npc; // 0x18
	[KeyAttribute] // RVA: 0x16DD90 Offset: 0x16DE91 VA: 0x16DD90
	[SerializeField] // RVA: 0x16DD90 Offset: 0x16DE91 VA: 0x16DD90
	public NpcPatrolRoute[] NpcPatrolRoutes; // 0x20
	[KeyAttribute] // RVA: 0x16DDE0 Offset: 0x16DEE1 VA: 0x16DDE0
	[SerializeField] // RVA: 0x16DDE0 Offset: 0x16DEE1 VA: 0x16DDE0
	public float PatrolSpeed; // 0x28
	[KeyAttribute] // RVA: 0x16DE30 Offset: 0x16DF31 VA: 0x16DE30
	[SerializeField] // RVA: 0x16DE30 Offset: 0x16DF31 VA: 0x16DE30
	public float WaitMinutes; // 0x2C
	[KeyAttribute] // RVA: 0x16DE80 Offset: 0x16DF81 VA: 0x16DE80
	[SerializeField] // RVA: 0x16DE80 Offset: 0x16DF81 VA: 0x16DE80
	public string doorName; // 0x30
	[KeyAttribute] // RVA: 0x16DED0 Offset: 0x16DFD1 VA: 0x16DED0
	[SerializeField] // RVA: 0x16DED0 Offset: 0x16DFD1 VA: 0x16DED0
	public DoorType DoorType; // 0x38
	[KeyAttribute] // RVA: 0x16DF20 Offset: 0x16E021 VA: 0x16DF20
	[SerializeField] // RVA: 0x16DF20 Offset: 0x16E021 VA: 0x16DF20
	public string WarpSceneName; // 0x40
	[KeyAttribute] // RVA: 0x16DF70 Offset: 0x16E071 VA: 0x16DF70
	[SerializeField] // RVA: 0x16DF70 Offset: 0x16E071 VA: 0x16DF70
	public Place WarpPlace; // 0x48
	[KeyAttribute] // RVA: 0x16DFC0 Offset: 0x16E0C1 VA: 0x16DFC0
	[SerializeField] // RVA: 0x16DFC0 Offset: 0x16E0C1 VA: 0x16DFC0
	public string WarpTagetPointName; // 0x50
	[KeyAttribute] // RVA: 0x16E010 Offset: 0x16E111 VA: 0x16E010
	[SerializeField] // RVA: 0x16E010 Offset: 0x16E111 VA: 0x16E010
	public float arriveDistance; // 0x58
	[KeyAttribute] // RVA: 0x16E060 Offset: 0x16E161 VA: 0x16E060
	[SerializeField] // RVA: 0x16E060 Offset: 0x16E161 VA: 0x16E060
	public bool useNavMesh; // 0x5C
	[KeyAttribute] // RVA: 0x16E0B0 Offset: 0x16E1B1 VA: 0x16E0B0
	[SerializeField] // RVA: 0x16E0B0 Offset: 0x16E1B1 VA: 0x16E0B0
	public int EndPointOfRotatePatternNumber; // 0x60
	[KeyAttribute] // RVA: 0x16E100 Offset: 0x16E201 VA: 0x16E100
	public bool IsFree; // 0x64
	[KeyAttribute] // RVA: 0x16E140 Offset: 0x16E241 VA: 0x16E140
	public int IsFreeCnt; // 0x68
	[KeyAttribute] // RVA: 0x16E180 Offset: 0x16E281 VA: 0x16E180
	public Gender Gender; // 0x6C
	[KeyAttribute] // RVA: 0x16E1C0 Offset: 0x16E2C1 VA: 0x16E1C0
	[SerializeField] // RVA: 0x16E1C0 Offset: 0x16E2C1 VA: 0x16E1C0
	public bool IsSeat; // 0x70
	[KeyAttribute] // RVA: 0x16E210 Offset: 0x16E311 VA: 0x16E210
	[SerializeField] // RVA: 0x16E210 Offset: 0x16E311 VA: 0x16E210
	public bool Destination; // 0x71
	[KeyAttribute] // RVA: 0x16E260 Offset: 0x16E361 VA: 0x16E260
	[SerializeField] // RVA: 0x16E260 Offset: 0x16E361 VA: 0x16E260
	public List<NPCID> OnlyNpcIds; // 0x78
	[KeyAttribute] // RVA: 0x16E2B0 Offset: 0x16E3B1 VA: 0x16E2B0
	[SerializeField] // RVA: 0x16E2B0 Offset: 0x16E3B1 VA: 0x16E2B0
	public int GroupId; // 0x80
	[KeyAttribute] // RVA: 0x16E300 Offset: 0x16E401 VA: 0x16E300
	[SerializeField] // RVA: 0x16E300 Offset: 0x16E401 VA: 0x16E300
	public int stayingNpcId; // 0x84
	[KeyAttribute] // RVA: 0x16E350 Offset: 0x16E451 VA: 0x16E350
	[SerializeField] // RVA: 0x16E350 Offset: 0x16E451 VA: 0x16E350
	public NpcPatrolPoint[] lookAtPoints; // 0x88
	[KeyAttribute] // RVA: 0x16E3A0 Offset: 0x16E4A1 VA: 0x16E3A0
	[SerializeField] // RVA: 0x16E3A0 Offset: 0x16E4A1 VA: 0x16E3A0
	public bool NotLookatPlayer; // 0x90
	[KeyAttribute] // RVA: 0x16E3F0 Offset: 0x16E4F1 VA: 0x16E3F0
	[SerializeField] // RVA: 0x16E3F0 Offset: 0x16E4F1 VA: 0x16E3F0
	public int NotLookatPlayerTime; // 0x94
	[KeyAttribute] // RVA: 0x16E440 Offset: 0x16E541 VA: 0x16E440
	[SerializeField] // RVA: 0x16E440 Offset: 0x16E541 VA: 0x16E440
	public bool ChangeSwimWear; // 0x98
	[KeyAttribute] // RVA: 0x16E490 Offset: 0x16E591 VA: 0x16E490
	[SerializeField] // RVA: 0x16E490 Offset: 0x16E591 VA: 0x16E490
	public bool ChangePajama; // 0x99

	// Methods

	// RVA: 0x1D8A870 Offset: 0x1D8A971 VA: 0x1D8A870
	public bool IsOnlyNpcPoint() { }

	// RVA: 0x1D8A8E0 Offset: 0x1D8A9E1 VA: 0x1D8A8E0
	private void Awake() { }

	// RVA: 0x1D8A8F0 Offset: 0x1D8A9F1 VA: 0x1D8A8F0
	private void Start() { }

	// RVA: 0x1D8A9A0 Offset: 0x1D8AAA1 VA: 0x1D8A9A0
	public bool IsRotateEndPoint() { }

	// RVA: 0x1D8A9B0 Offset: 0x1D8AAB1 VA: 0x1D8A9B0
	public NpcPatrolPointData GetCopyData() { }

	// RVA: 0x1D8AB80 Offset: 0x1D8AC81 VA: 0x1D8AB80
	private void OnDrawGizmos() { }

	// RVA: 0x1D8ABC0 Offset: 0x1D8ACC1 VA: 0x1D8ABC0
	public void .ctor() { }
}

