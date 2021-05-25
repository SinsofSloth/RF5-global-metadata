public class NpcSearchCollider : MonoBehaviour // TypeDefIndex: 8149
{
	// Fields
	[TupleElementNamesAttribute] // RVA: 0x16B660 Offset: 0x16B761 VA: 0x16B660
	private List<ValueTuple<FocusInterface, Collider>> enterInteractions; // 0x18
	private NpcController owner; // 0x20
	public NavMeshObstacle NavMeshObstacle; // 0x28
	private bool ConflictCheck; // 0x30
	private int ConflictNpcId; // 0x34

	// Methods

	// RVA: 0x1D8B200 Offset: 0x1D8B301 VA: 0x1D8B200
	private void Awake() { }

	// RVA: 0x1D8B290 Offset: 0x1D8B391 VA: 0x1D8B290
	private void Start() { }

	// RVA: 0x1D8B430 Offset: 0x1D8B531 VA: 0x1D8B430
	private void OnTriggerEnter(Collider collision) { }

	// RVA: 0x1D8C080 Offset: 0x1D8C181 VA: 0x1D8C080
	private void OnTriggerExit(Collider collision) { }

	// RVA: 0x1D8C2D0 Offset: 0x1D8C3D1 VA: 0x1D8C2D0
	public void OffNpcConflict() { }

	// RVA: 0x1D8C2E0 Offset: 0x1D8C3E1 VA: 0x1D8C2E0
	private void OffCollisionEnter(Collision collision) { }

	// RVA: 0x1D8C480 Offset: 0x1D8C581 VA: 0x1D8C480
	private void OffNavMeshObstacle() { }

	// RVA: 0x1D8BF80 Offset: 0x1D8C081 VA: 0x1D8BF80
	private bool JudgTalk() { }

	// RVA: 0x1D8BC10 Offset: 0x1D8BD11 VA: 0x1D8BC10
	private SoundID RandomVoice(NpcData npcData) { }

	// RVA: 0x1D8C550 Offset: 0x1D8C651 VA: 0x1D8C550
	public void .ctor() { }
}

