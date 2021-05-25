[TaskDescriptionAttribute] // RVA: 0x14ACA0 Offset: 0x14ADA1 VA: 0x14ACA0
[TaskCategoryAttribute] // RVA: 0x14ACA0 Offset: 0x14ADA1 VA: 0x14ACA0
[TaskIconAttribute] // RVA: 0x14ACA0 Offset: 0x14ADA1 VA: 0x14ACA0
public class MonsterUpdateAroundParameter : Action // TypeDefIndex: 10911
{
	// Fields
	[TooltipAttribute] // RVA: 0x182310 Offset: 0x182411 VA: 0x182310
	public SharedVector3List AroundPositionList; // 0x50
	[TooltipAttribute] // RVA: 0x182350 Offset: 0x182451 VA: 0x182350
	public SharedVector3 ReturnMovePosition; // 0x58
	[TooltipAttribute] // RVA: 0x182390 Offset: 0x182491 VA: 0x182390
	public SharedInt Index; // 0x60
	private AIInput AIInput; // 0x68

	// Methods

	// RVA: 0x20E2C00 Offset: 0x20E2D01 VA: 0x20E2C00 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20E2CD0 Offset: 0x20E2DD1 VA: 0x20E2CD0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E2E70 Offset: 0x20E2F71 VA: 0x20E2E70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E2E80 Offset: 0x20E2F81 VA: 0x20E2E80 Slot: 17
	public override void OnDrawGizmos() { }

	// RVA: 0x20E2E90 Offset: 0x20E2F91 VA: 0x20E2E90
	public void .ctor() { }
}

