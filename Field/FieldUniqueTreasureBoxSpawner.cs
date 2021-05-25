public class FieldUniqueTreasureBoxSpawner : FieldTreasureBoxSpawner // TypeDefIndex: 10529
{
	// Fields
	[SerializeField] // RVA: 0x181DA0 Offset: 0x181EA1 VA: 0x181DA0
	private FieldUniqueTreasureBoxSpawnID _UniqueBoxSpawnID; // 0x3C
	private FieldTreasureBox TreasureBox; // 0x40
	public GateController GateController; // 0x48
	private bool isAddSpawnEvent; // 0x50

	// Properties
	public FieldUniqueTreasureBoxSpawnID UniqueBoxSpawnID { get; set; }

	// Methods

	// RVA: 0x1E33C80 Offset: 0x1E33D81 VA: 0x1E33C80
	public FieldUniqueTreasureBoxSpawnID get_UniqueBoxSpawnID() { }

	// RVA: 0x1E33C90 Offset: 0x1E33D91 VA: 0x1E33C90
	private void set_UniqueBoxSpawnID(FieldUniqueTreasureBoxSpawnID value) { }

	// RVA: 0x1E33CA0 Offset: 0x1E33DA1 VA: 0x1E33CA0
	private void OnDestroy() { }

	// RVA: 0x1E33E20 Offset: 0x1E33F21 VA: 0x1E33E20 Slot: 4
	protected override void Start() { }

	// RVA: 0x1E2B9B0 Offset: 0x1E2BAB1 VA: 0x1E2B9B0 Slot: 6
	public override void Spawn() { }

	// RVA: 0x1E32920 Offset: 0x1E32A21 VA: 0x1E32920
	public void SetGateController(GateController gate) { }

	// RVA: 0x1E33EF0 Offset: 0x1E33FF1 VA: 0x1E33EF0
	private void OnGateEnamyDead(GateController monster) { }

	// RVA: 0x1E340B0 Offset: 0x1E341B1 VA: 0x1E340B0
	private void TreasureBoxSpawn(Vector3 position, Quaternion rotation, Vector3 offset) { }

	// RVA: 0x1E30BA0 Offset: 0x1E30CA1 VA: 0x1E30BA0
	public void OnChangeHideDetectFlag(bool visible) { }

	// RVA: 0x1E2BEB0 Offset: 0x1E2BFB1 VA: 0x1E2BEB0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AFCB0 Offset: 0x1AFDB1 VA: 0x1AFCB0
	// RVA: 0x1E34270 Offset: 0x1E34371 VA: 0x1E34270
	private void <TreasureBoxSpawn>b__12_0() { }
}

