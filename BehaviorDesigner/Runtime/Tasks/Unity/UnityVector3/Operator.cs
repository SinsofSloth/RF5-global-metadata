[TaskCategoryAttribute] // RVA: 0x14C930 Offset: 0x14CA31 VA: 0x14C930
[TaskDescriptionAttribute] // RVA: 0x14C930 Offset: 0x14CA31 VA: 0x14C930
public class Operator : Action // TypeDefIndex: 10983
{
	// Fields
	[TooltipAttribute] // RVA: 0x184C40 Offset: 0x184D41 VA: 0x184C40
	public Operator.Operation operation; // 0x4C
	[TooltipAttribute] // RVA: 0x184C80 Offset: 0x184D81 VA: 0x184C80
	public SharedVector3 firstVector3; // 0x50
	[TooltipAttribute] // RVA: 0x184CC0 Offset: 0x184DC1 VA: 0x184CC0
	public SharedVector3 secondVector3; // 0x58
	[TooltipAttribute] // RVA: 0x184D00 Offset: 0x184E01 VA: 0x184D00
	public SharedVector3 storeResult; // 0x60

	// Methods

	// RVA: 0x22D9B70 Offset: 0x22D9C71 VA: 0x22D9B70 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x22D9DB0 Offset: 0x22D9EB1 VA: 0x22D9DB0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x22D9E70 Offset: 0x22D9F71 VA: 0x22D9E70
	public void .ctor() { }
}

