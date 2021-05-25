[TaskCategoryAttribute] // RVA: 0x14C450 Offset: 0x14C551 VA: 0x14C450
[TaskDescriptionAttribute] // RVA: 0x14C450 Offset: 0x14C551 VA: 0x14C450
public class Distance : Action // TypeDefIndex: 10970
{
	// Fields
	[TooltipAttribute] // RVA: 0x184350 Offset: 0x184451 VA: 0x184350
	public SharedVector3 firstVector3; // 0x50
	[TooltipAttribute] // RVA: 0x184390 Offset: 0x184491 VA: 0x184390
	public SharedVector3 secondVector3; // 0x58
	[TooltipAttribute] // RVA: 0x1843D0 Offset: 0x1844D1 VA: 0x1843D0
	[RequiredFieldAttribute] // RVA: 0x1843D0 Offset: 0x1844D1 VA: 0x1843D0
	public SharedFloat storeResult; // 0x60

	// Methods

	// RVA: 0x22D86D0 Offset: 0x22D87D1 VA: 0x22D86D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x22D87E0 Offset: 0x22D88E1 VA: 0x22D87E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x22D88A0 Offset: 0x22D89A1 VA: 0x22D88A0
	public void .ctor() { }
}

