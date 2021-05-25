[TaskCategoryAttribute] // RVA: 0x14EC10 Offset: 0x14ED11 VA: 0x14EC10
[TaskDescriptionAttribute] // RVA: 0x14EC10 Offset: 0x14ED11 VA: 0x14EC10
public class SetSharedFloat : Action // TypeDefIndex: 11078
{
	// Fields
	[TooltipAttribute] // RVA: 0x1883A0 Offset: 0x1884A1 VA: 0x1883A0
	public SharedFloat targetValue; // 0x50
	[RequiredFieldAttribute] // RVA: 0x1883E0 Offset: 0x1884E1 VA: 0x1883E0
	[TooltipAttribute] // RVA: 0x1883E0 Offset: 0x1884E1 VA: 0x1883E0
	public SharedFloat targetVariable; // 0x58

	// Methods

	// RVA: 0x20EF270 Offset: 0x20EF371 VA: 0x20EF270 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20EF2F0 Offset: 0x20EF3F1 VA: 0x20EF2F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20EF440 Offset: 0x20EF541 VA: 0x20EF440
	public void .ctor() { }
}

