[TaskCategoryAttribute] // RVA: 0x14C810 Offset: 0x14C911 VA: 0x14C810
[TaskDescriptionAttribute] // RVA: 0x14C810 Offset: 0x14C911 VA: 0x14C810
public class MoveTowards : Action // TypeDefIndex: 10980
{
	// Fields
	[TooltipAttribute] // RVA: 0x1849D0 Offset: 0x184AD1 VA: 0x1849D0
	public SharedVector3 currentPosition; // 0x50
	[TooltipAttribute] // RVA: 0x184A10 Offset: 0x184B11 VA: 0x184A10
	public SharedVector3 targetPosition; // 0x58
	[TooltipAttribute] // RVA: 0x184A50 Offset: 0x184B51 VA: 0x184A50
	public SharedFloat speed; // 0x60
	[TooltipAttribute] // RVA: 0x184A90 Offset: 0x184B91 VA: 0x184A90
	[RequiredFieldAttribute] // RVA: 0x184A90 Offset: 0x184B91 VA: 0x184A90
	public SharedVector3 storeResult; // 0x68

	// Methods

	// RVA: 0x22D9600 Offset: 0x22D9701 VA: 0x22D9600 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x22D9740 Offset: 0x22D9841 VA: 0x22D9740 Slot: 16
	public override void OnReset() { }

	// RVA: 0x22D9820 Offset: 0x22D9921 VA: 0x22D9820
	public void .ctor() { }
}

