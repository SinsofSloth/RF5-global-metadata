[TaskCategoryAttribute] // RVA: 0x145510 Offset: 0x145611 VA: 0x145510
public class PartnerNPCMagicRAAttack : Action // TypeDefIndex: 6369
{
	// Fields
	private PartnerNPCBehaviorController PartnerNPCBehaviorController; // 0x50
	public PlayerCharacterController.Action Action; // 0x58
	private MagicController MagicController; // 0x60
	private TaskStatus CurrentTaskStatus; // 0x68
	private PartnerNPCMagicRAAttack.State CurrentState; // 0x6C

	// Properties
	private HumanEquipment HumanEquipment { get; }

	// Methods

	// RVA: 0x1FDDA50 Offset: 0x1FDDB51 VA: 0x1FDDA50
	private HumanEquipment get_HumanEquipment() { }

	// RVA: 0x1FDDA80 Offset: 0x1FDDB81 VA: 0x1FDDA80 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x1FDDB40 Offset: 0x1FDDC41 VA: 0x1FDDB40 Slot: 5
	public override void OnStart() { }

	// RVA: 0x1FDDDD0 Offset: 0x1FDDED1 VA: 0x1FDDDD0 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x1FDDDF0 Offset: 0x1FDDEF1 VA: 0x1FDDDF0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x1FDDC70 Offset: 0x1FDDD71 VA: 0x1FDDC70
	public bool CheckTarget() { }

	// RVA: 0x1FDDF30 Offset: 0x1FDE031 VA: 0x1FDDF30
	public void .ctor() { }
}

