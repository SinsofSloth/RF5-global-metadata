[TaskCategoryAttribute] // RVA: 0x145410 Offset: 0x145511 VA: 0x145410
public class PartnerNPCChargeAttack : Action // TypeDefIndex: 6365
{
	// Fields
	public SharedPartnerNPCBehaviorController SharedPartnerBehaviorController; // 0x50
	public SharedGameObject Target; // 0x58
	public SharedToolChargeLevel ChargeLevel; // 0x60
	public SharedFloat MaxWeaponRange; // 0x68
	public SharedBool IsArrivedChargeRange; // 0x70
	public SharedBool SharedIsMoveChargeAttackRange; // 0x78
	private TaskStatus CurrentTaskStatus; // 0x80
	private ToolChargeLevel DoActionChargeLevel; // 0x84
	private bool IsChargeStart; // 0x88

	// Properties
	private PartnerNPCController PartnerNPCController { get; }

	// Methods

	// RVA: 0x1FDA660 Offset: 0x1FDA761 VA: 0x1FDA660
	private PartnerNPCController get_PartnerNPCController() { }

	// RVA: 0x1FDA6C0 Offset: 0x1FDA7C1 VA: 0x1FDA6C0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x1FDAE10 Offset: 0x1FDAF11 VA: 0x1FDAE10 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x1FDAE90 Offset: 0x1FDAF91 VA: 0x1FDAE90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x1FDB330 Offset: 0x1FDB431 VA: 0x1FDB330
	public bool CheckTarget() { }

	// RVA: 0x1FDACD0 Offset: 0x1FDADD1 VA: 0x1FDACD0
	public bool JudgeContinue() { }

	// RVA: 0x1FDB520 Offset: 0x1FDB621 VA: 0x1FDB520
	public void .ctor() { }
}

