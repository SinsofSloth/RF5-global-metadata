public class MonsterModel : CharacterModel // TypeDefIndex: 8094
{
	// Fields
	[SerializeField] // RVA: 0x16A410 Offset: 0x16A511 VA: 0x16A410
	protected LookAtIK LookAtIK; // 0x68
	[SerializeField] // RVA: 0x16A420 Offset: 0x16A521 VA: 0x16A420
	private Transform HeadTransform; // 0x70
	[SerializeField] // RVA: 0x16A430 Offset: 0x16A531 VA: 0x16A430
	private Transform CenterTransform; // 0x78
	[SerializeField] // RVA: 0x16A440 Offset: 0x16A541 VA: 0x16A440
	private HumanRideSaddle HumanRideSaddle; // 0x80
	public Transform[] FootStepLegTransforms; // 0x88
	public MonsterFootStepEventDataTable MonsterFootStepEventDataTable; // 0x90

	// Properties
	public override Transform LookPoint { get; }
	public Transform Center { get; }

	// Methods

	// RVA: 0x1CD2A90 Offset: 0x1CD2B91 VA: 0x1CD2A90 Slot: 4
	public override Transform get_LookPoint() { }

	// RVA: 0x1CD2AA0 Offset: 0x1CD2BA1 VA: 0x1CD2AA0
	public Transform get_Center() { }

	// RVA: 0x1CD2AB0 Offset: 0x1CD2BB1 VA: 0x1CD2AB0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x1CD2C30 Offset: 0x1CD2D31 VA: 0x1CD2C30
	public void SetupFootStepEventData(MonsterFootStepEventDataTable monsterFootStepEventDataTable) { }

	// RVA: 0x1CD2DA0 Offset: 0x1CD2EA1 VA: 0x1CD2DA0
	public void .ctor() { }
}

