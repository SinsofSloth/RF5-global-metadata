[TaskCategoryAttribute] // RVA: 0x14CFF0 Offset: 0x14D0F1 VA: 0x14CFF0
[TaskDescriptionAttribute] // RVA: 0x14CFF0 Offset: 0x14D0F1 VA: 0x14CFF0
public class SetValue : Action // TypeDefIndex: 11003
{
	// Fields
	[TooltipAttribute] // RVA: 0x185A30 Offset: 0x185B31 VA: 0x185A30
	public SharedVector2 vector2Value; // 0x50
	[TooltipAttribute] // RVA: 0x185A70 Offset: 0x185B71 VA: 0x185A70
	public SharedVector2 vector2Variable; // 0x58

	// Methods

	// RVA: 0x22D8040 Offset: 0x22D8141 VA: 0x22D8040 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x22D80C0 Offset: 0x22D81C1 VA: 0x22D80C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x22D8160 Offset: 0x22D8261 VA: 0x22D8160
	public void .ctor() { }
}

