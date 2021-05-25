public class TeleportDragonRope : PlayerTeleportButton // TypeDefIndex: 7515
{
	// Fields
	public bool IsRopeField; // 0x99
	public bool IsRopeFarm; // 0x9A
	public int FieldPlaceId; // 0x9C
	public int FarmPlaceId; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x166D10 Offset: 0x166E11 VA: 0x166D10
	private bool <IsEnable>k__BackingField; // 0xA4
	public Transform RopeMoveRoot; // 0xA8
	private FieldSceneData.Data SceneData; // 0xB0

	// Properties
	public bool IsEnable { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A1970 Offset: 0x1A1A71 VA: 0x1A1970
	// RVA: 0x20A5F60 Offset: 0x20A6061 VA: 0x20A5F60
	public bool get_IsEnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1980 Offset: 0x1A1A81 VA: 0x1A1980
	// RVA: 0x20A5F70 Offset: 0x20A6071 VA: 0x20A5F70
	private void set_IsEnable(bool value) { }

	// RVA: 0x20A5F80 Offset: 0x20A6081 VA: 0x20A5F80
	private void OnDestroy() { }

	// RVA: 0x20A6040 Offset: 0x20A6141 VA: 0x20A6040
	public void DoInteraction(HumanController character) { }

	// RVA: 0x20A6120 Offset: 0x20A6221 VA: 0x20A6120 Slot: 21
	protected override void Awake() { }

	// RVA: 0x20A6070 Offset: 0x20A6171 VA: 0x20A6070
	private bool CheckRopeEnable() { }

	// RVA: 0x20A6490 Offset: 0x20A6591 VA: 0x20A6490 Slot: 20
	protected override void OnTriggerEnter(Collider collision) { }

	// RVA: 0x20A6530 Offset: 0x20A6631 VA: 0x20A6530 Slot: 23
	protected override void TeleportScene() { }

	// RVA: 0x20A6330 Offset: 0x20A6431 VA: 0x20A6330
	public void UpdateTeleportPoint() { }

	// RVA: 0x20A6540 Offset: 0x20A6641 VA: 0x20A6540
	public void .ctor() { }
}

