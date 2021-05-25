[TaskCategoryAttribute] // RVA: 0x14C4B0 Offset: 0x14C5B1 VA: 0x14C4B0
[TaskDescriptionAttribute] // RVA: 0x14C4B0 Offset: 0x14C5B1 VA: 0x14C4B0
public class Dot : Action // TypeDefIndex: 10971
{
	// Fields
	[TooltipAttribute] // RVA: 0x184420 Offset: 0x184521 VA: 0x184420
	public SharedVector3 leftHandSide; // 0x50
	[TooltipAttribute] // RVA: 0x184460 Offset: 0x184561 VA: 0x184460
	public SharedVector3 rightHandSide; // 0x58
	[TooltipAttribute] // RVA: 0x1844A0 Offset: 0x1845A1 VA: 0x1844A0
	[RequiredFieldAttribute] // RVA: 0x1844A0 Offset: 0x1845A1 VA: 0x1844A0
	public SharedFloat storeResult; // 0x60

	// Methods

	// RVA: 0x22D88B0 Offset: 0x22D89B1 VA: 0x22D88B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x22D89C0 Offset: 0x22D8AC1 VA: 0x22D89C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x22D8A80 Offset: 0x22D8B81 VA: 0x22D8A80
	public void .ctor() { }
}

