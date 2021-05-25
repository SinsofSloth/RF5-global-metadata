[TaskCategoryAttribute] // RVA: 0x14CDB0 Offset: 0x14CEB1 VA: 0x14CDB0
[TaskDescriptionAttribute] // RVA: 0x14CDB0 Offset: 0x14CEB1 VA: 0x14CDB0
public class GetXY : Action // TypeDefIndex: 10996
{
	// Fields
	[TooltipAttribute] // RVA: 0x1854D0 Offset: 0x1855D1 VA: 0x1854D0
	public SharedVector2 vector2Variable; // 0x50
	[TooltipAttribute] // RVA: 0x185510 Offset: 0x185611 VA: 0x185510
	[RequiredFieldAttribute] // RVA: 0x185510 Offset: 0x185611 VA: 0x185510
	public SharedFloat storeX; // 0x58
	[TooltipAttribute] // RVA: 0x185560 Offset: 0x185661 VA: 0x185560
	[RequiredFieldAttribute] // RVA: 0x185560 Offset: 0x185661 VA: 0x185560
	public SharedFloat storeY; // 0x60

	// Methods

	// RVA: 0x2891C90 Offset: 0x2891D91 VA: 0x2891C90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2891D40 Offset: 0x2891E41 VA: 0x2891D40 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2891DF0 Offset: 0x2891EF1 VA: 0x2891DF0
	public void .ctor() { }
}

