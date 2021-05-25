[TaskCategoryAttribute] // RVA: 0x14AFE0 Offset: 0x14B0E1 VA: 0x14AFE0
public class PartnerLeaveMovement : Action // TypeDefIndex: 10918
{
	// Fields
	[TooltipAttribute] // RVA: 0x1827D0 Offset: 0x1828D1 VA: 0x1827D0
	public SharedMovementBehaviorType SharedMovementBehaviorType; // 0x50
	[TooltipAttribute] // RVA: 0x182810 Offset: 0x182911 VA: 0x182810
	public SharedVector3 MovePosition; // 0x58
	[TooltipAttribute] // RVA: 0x182850 Offset: 0x182951 VA: 0x182850
	public SharedFloat MoveSpeed; // 0x60
	private AIInput AIInput; // 0x68

	// Properties
	private PartnerMovementController PartnerMovementController { get; }

	// Methods

	// RVA: 0x20E4D80 Offset: 0x20E4E81 VA: 0x20E4D80
	private PartnerMovementController get_PartnerMovementController() { }

	// RVA: 0x20E4E70 Offset: 0x20E4F71 VA: 0x20E4E70 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20E4F40 Offset: 0x20E5041 VA: 0x20E4F40 Slot: 5
	public override void OnStart() { }

	// RVA: 0x20E5080 Offset: 0x20E5181 VA: 0x20E5080 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E5210 Offset: 0x20E5311 VA: 0x20E5210
	public void .ctor() { }
}

