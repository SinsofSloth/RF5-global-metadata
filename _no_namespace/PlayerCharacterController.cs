[DefaultExecutionOrder] // RVA: 0x145F30 Offset: 0x146031 VA: 0x145F30
public class PlayerCharacterController : HumanController, ItemInteractionInterface, FocusInterface // TypeDefIndex: 6778
{
	// Fields
	private Vector3 InputVector; // 0x238
	private int CurrentWalkSkillCount; // 0x244

	// Properties
	protected override bool UseGravityOnNavMeshEnabled { get; }
	public float HandcuffsCoolTime { get; }
	public float HandcuffsCoolTimePer { get; }
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1FEB380 Offset: 0x1FEB481 VA: 0x1FEB380 Slot: 39
	protected override bool get_UseGravityOnNavMeshEnabled() { }

	// RVA: 0x1FEB390 Offset: 0x1FEB491 VA: 0x1FEB390
	public float get_HandcuffsCoolTime() { }

	// RVA: 0x1FEB460 Offset: 0x1FEB561 VA: 0x1FEB460
	public float get_HandcuffsCoolTimePer() { }

	// RVA: 0x1FEB530 Offset: 0x1FEB631 VA: 0x1FEB530 Slot: 101
	public bool get_Focusable() { }

	// RVA: 0x1FEB540 Offset: 0x1FEB641 VA: 0x1FEB540 Slot: 104
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1FEB550 Offset: 0x1FEB651 VA: 0x1FEB550 Slot: 105
	public int get_FocusPriority() { }

	// RVA: 0x1FEB560 Offset: 0x1FEB661 VA: 0x1FEB560 Slot: 106
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1FEB570 Offset: 0x1FEB671 VA: 0x1FEB570
	public void HandcuffsStart() { }

	// RVA: 0x1FEB650 Offset: 0x1FEB751 VA: 0x1FEB650
	public void HandcuffsEnd() { }

	// RVA: 0x1FEB740 Offset: 0x1FEB841 VA: 0x1FEB740 Slot: 18
	public override void OnSwitchActorBase(bool on) { }

	// RVA: 0x1FEBA30 Offset: 0x1FEBB31 VA: 0x1FEBA30
	public void SpcToPlayerResetMovement() { }

	// RVA: 0x1FEBA40 Offset: 0x1FEBB41 VA: 0x1FEBA40 Slot: 50
	protected override void ResetMovement() { }

	// RVA: 0x1FEBB40 Offset: 0x1FEBC41 VA: 0x1FEBB40 Slot: 11
	protected override void Awake() { }

	// RVA: 0x1FEBBE0 Offset: 0x1FEBCE1 VA: 0x1FEBBE0 Slot: 12
	protected override void Start() { }

	// RVA: 0x1FEBD20 Offset: 0x1FEBE21 VA: 0x1FEBD20 Slot: 40
	protected override void Update() { }

	// RVA: 0x1FEBDA0 Offset: 0x1FEBEA1 VA: 0x1FEBDA0
	private void DoAction_WalkSkill(GroundType groundType) { }

	// RVA: 0x1FEBED0 Offset: 0x1FEBFD1 VA: 0x1FEBED0 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x1FEC1C0 Offset: 0x1FEC2C1 VA: 0x1FEC1C0 Slot: 96
	public override void AddDamagedPost(DamageInfo damageInfo, DamageResult result, ItemData itemData) { }

	// RVA: 0x1FEC2F0 Offset: 0x1FEC3F1 VA: 0x1FEC2F0 Slot: 97
	public void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x1FEC3B0 Offset: 0x1FEC4B1 VA: 0x1FEC3B0 Slot: 98
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x1FEC4A0 Offset: 0x1FEC5A1 VA: 0x1FEC4A0 Slot: 99
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData) { }

	// RVA: 0x1FEC4B0 Offset: 0x1FEC5B1 VA: 0x1FEC4B0 Slot: 100
	public string GetFocusName() { }

	// RVA: 0x1FEC500 Offset: 0x1FEC601 VA: 0x1FEC500 Slot: 102
	public void OnFocus() { }

	// RVA: 0x1FEC510 Offset: 0x1FEC611 VA: 0x1FEC510 Slot: 103
	public void OffFocus() { }

	// RVA: 0x1FEC520 Offset: 0x1FEC621 VA: 0x1FEC520 Slot: 107
	public ushort GetInteractionType() { }

	// RVA: 0x1FEC530 Offset: 0x1FEC631 VA: 0x1FEC530 Slot: 49
	public override bool InputMove(Vector3 vector) { }

	// RVA: 0x1FEC590 Offset: 0x1FEC691 VA: 0x1FEC590 Slot: 95
	public override void Avoid() { }

	// RVA: 0x1FEC850 Offset: 0x1FEC951 VA: 0x1FEC850
	public void .ctor() { }

	// RVA: 0x1FEC8D0 Offset: 0x1FEC9D1 VA: 0x1FEC8D0 Slot: 108
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1FEC8E0 Offset: 0x1FEC9E1 VA: 0x1FEC8E0 Slot: 109
	private Transform FocusInterface.get_transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CF00 Offset: 0x19D001 VA: 0x19CF00
	// RVA: 0x1FEC8F0 Offset: 0x1FEC9F1 VA: 0x1FEC8F0
	private bool <Awake>b__21_0() { }
}

