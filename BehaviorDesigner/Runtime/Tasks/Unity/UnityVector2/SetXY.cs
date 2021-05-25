[TaskCategoryAttribute] // RVA: 0x14D050 Offset: 0x14D151 VA: 0x14D050
[TaskDescriptionAttribute] // RVA: 0x14D050 Offset: 0x14D151 VA: 0x14D050
public class SetXY : Action // TypeDefIndex: 11004
{
	// Fields
	[TooltipAttribute] // RVA: 0x185AB0 Offset: 0x185BB1 VA: 0x185AB0
	public SharedVector2 vector2Variable; // 0x50
	[TooltipAttribute] // RVA: 0x185AF0 Offset: 0x185BF1 VA: 0x185AF0
	public SharedFloat xValue; // 0x58
	[TooltipAttribute] // RVA: 0x185B30 Offset: 0x185C31 VA: 0x185B30
	public SharedFloat yValue; // 0x60

	// Methods

	// RVA: 0x22D8170 Offset: 0x22D8271 VA: 0x22D8170 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x22D8260 Offset: 0x22D8361 VA: 0x22D8260 Slot: 16
	public override void OnReset() { }

	// RVA: 0x22D8320 Offset: 0x22D8421 VA: 0x22D8320
	public void .ctor() { }
}

