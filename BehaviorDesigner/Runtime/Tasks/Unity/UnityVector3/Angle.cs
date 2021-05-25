[TaskCategoryAttribute] // RVA: 0x14C390 Offset: 0x14C491 VA: 0x14C390
[TaskDescriptionAttribute] // RVA: 0x14C390 Offset: 0x14C491 VA: 0x14C390
public class Angle : Action // TypeDefIndex: 10968
{
	// Fields
	[TooltipAttribute] // RVA: 0x1841B0 Offset: 0x1842B1 VA: 0x1841B0
	public SharedVector3 firstVector3; // 0x50
	[TooltipAttribute] // RVA: 0x1841F0 Offset: 0x1842F1 VA: 0x1841F0
	public SharedVector3 secondVector3; // 0x58
	[TooltipAttribute] // RVA: 0x184230 Offset: 0x184331 VA: 0x184230
	[RequiredFieldAttribute] // RVA: 0x184230 Offset: 0x184331 VA: 0x184230
	public SharedFloat storeResult; // 0x60

	// Methods

	// RVA: 0x22D8330 Offset: 0x22D8431 VA: 0x22D8330 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x22D8440 Offset: 0x22D8541 VA: 0x22D8440 Slot: 16
	public override void OnReset() { }

	// RVA: 0x22D8500 Offset: 0x22D8601 VA: 0x22D8500
	public void .ctor() { }
}

