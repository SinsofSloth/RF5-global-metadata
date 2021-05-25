public class HumanFootSteps : CharaFootSteps<HumanController> // TypeDefIndex: 6337
{
	// Fields
	[SerializeField] // RVA: 0x15C3B0 Offset: 0x15C4B1 VA: 0x15C3B0
	private HumanBodyBones[] m_TargetBones; // 0x60

	// Properties
	protected override FootStepType FootStepType { get; }

	// Methods

	// RVA: 0x1E94EF0 Offset: 0x1E94FF1 VA: 0x1E94EF0 Slot: 4
	protected override FootStepType get_FootStepType() { }

	// RVA: 0x1E94F00 Offset: 0x1E95001 VA: 0x1E94F00 Slot: 7
	protected override void Awake() { }

	// RVA: 0x1E873D0 Offset: 0x1E874D1 VA: 0x1E873D0
	public void ResetTransform(Animator animator) { }

	// RVA: 0x1E94F80 Offset: 0x1E95081 VA: 0x1E94F80 Slot: 9
	public override SoundID GetStepSoundID(GroundType groundType) { }

	// RVA: 0x1E95070 Offset: 0x1E95171 VA: 0x1E95070 Slot: 10
	public override SoundID GetLandingSoundID(GroundType groundType) { }

	// RVA: 0x1E95160 Offset: 0x1E95261 VA: 0x1E95160 Slot: 11
	public override void OnFootSteps(GroundType groundType, Collider hitCollider) { }

	// RVA: 0x1E95560 Offset: 0x1E95661 VA: 0x1E95560 Slot: 12
	public override void OnLanding(GroundType groundType, Collider hitCollider) { }

	// RVA: 0x1E95400 Offset: 0x1E95501 VA: 0x1E95400
	private void DoPlow(CellController cell) { }

	// RVA: 0x1E952B0 Offset: 0x1E953B1 VA: 0x1E952B0
	private void DoSlash(CellController cell) { }

	// RVA: 0x1E95570 Offset: 0x1E95671 VA: 0x1E95570
	public void .ctor() { }
}

