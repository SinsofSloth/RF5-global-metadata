[TaskCategoryAttribute] // RVA: 0x145450 Offset: 0x145551 VA: 0x145450
public class PartnerNPCWeaponAttack : Action // TypeDefIndex: 6366
{
	// Fields
	public SharedPartnerNPCBehaviorController SharedPartnerBehaviorController; // 0x50
	public SharedInt WeaponComboCount; // 0x58
	public SharedGameObject Target; // 0x60
	public SharedFloat UpdateTime; // 0x68
	public float Timer; // 0x70
	public bool IsAttackContinue; // 0x74
	private int CurrentComboCount; // 0x78
	private TaskStatus CurrentTaskStatus; // 0x7C

	// Properties
	private HumanController HumanController { get; }

	// Methods

	// RVA: 0x1FDE5E0 Offset: 0x1FDE6E1 VA: 0x1FDE5E0
	private HumanController get_HumanController() { }

	// RVA: 0x1FDE640 Offset: 0x1FDE741 VA: 0x1FDE640 Slot: 5
	public override void OnStart() { }

	// RVA: 0x1FDE950 Offset: 0x1FDEA51 VA: 0x1FDE950 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x1FDE9E0 Offset: 0x1FDEAE1 VA: 0x1FDE9E0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x1FDEA20 Offset: 0x1FDEB21 VA: 0x1FDEA20
	private void UpdateTaskStatus() { }

	// RVA: 0x1FDECF0 Offset: 0x1FDEDF1 VA: 0x1FDECF0
	private bool IsContinueAttack() { }

	// RVA: 0x1FDEE40 Offset: 0x1FDEF41 VA: 0x1FDEE40
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19ACC0 Offset: 0x19ADC1 VA: 0x19ACC0
	// RVA: 0x1FDEE50 Offset: 0x1FDEF51 VA: 0x1FDEE50
	private bool <OnStart>b__10_0() { }
}

