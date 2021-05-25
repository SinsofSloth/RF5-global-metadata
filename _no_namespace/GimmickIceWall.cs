public class GimmickIceWall : GimmickBreakeObject // TypeDefIndex: 7577
{
	// Fields
	private const float BrokenDelay = 0.25;
	private const SoundID BreakSe = 711;
	[SerializeField] // RVA: 0x167890 Offset: 0x167991 VA: 0x167890
	private GameObject[] WallObjects; // 0x88
	private List<GameObject> WallObjectList; // 0x90
	private List<Collider> ColliderList; // 0x98

	// Methods

	// RVA: 0x1EA22B0 Offset: 0x1EA23B1 VA: 0x1EA22B0 Slot: 12
	protected override void Awake() { }

	// RVA: 0x1EA2560 Offset: 0x1EA2661 VA: 0x1EA2560 Slot: 6
	protected override void Start() { }

	// RVA: 0x1EA2570 Offset: 0x1EA2671 VA: 0x1EA2570 Slot: 7
	public override void SetGimmickState(bool newState) { }

	// RVA: 0x1EA2890 Offset: 0x1EA2991 VA: 0x1EA2890 Slot: 9
	public override void Init() { }

	// RVA: 0x1EA2610 Offset: 0x1EA2711 VA: 0x1EA2610
	private void SetWallActive(bool value) { }

	// RVA: 0x1EA28D0 Offset: 0x1EA29D1 VA: 0x1EA28D0 Slot: 13
	public override void SetGimmickFlag(bool setValue) { }

	// RVA: 0x1EA28E0 Offset: 0x1EA29E1 VA: 0x1EA28E0 Slot: 14
	public override void Breake(Vector3 hitPoint) { }

	// RVA: 0x1EA2960 Offset: 0x1EA2A61 VA: 0x1EA2960
	public void .ctor() { }
}

