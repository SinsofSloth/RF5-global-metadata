[TaskCategoryAttribute] // RVA: 0x14EB50 Offset: 0x14EC51 VA: 0x14EB50
[TaskDescriptionAttribute] // RVA: 0x14EB50 Offset: 0x14EC51 VA: 0x14EB50
public class SetSharedBool : Action // TypeDefIndex: 11076
{
	// Fields
	[TooltipAttribute] // RVA: 0x188280 Offset: 0x188381 VA: 0x188280
	public SharedBool targetValue; // 0x50
	[RequiredFieldAttribute] // RVA: 0x1882C0 Offset: 0x1883C1 VA: 0x1882C0
	[TooltipAttribute] // RVA: 0x1882C0 Offset: 0x1883C1 VA: 0x1882C0
	public SharedBool targetVariable; // 0x58

	// Methods

	// RVA: 0x20EEEB0 Offset: 0x20EEFB1 VA: 0x20EEEB0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20EEF30 Offset: 0x20EF031 VA: 0x20EEF30 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20EF060 Offset: 0x20EF161 VA: 0x20EF060
	public void .ctor() { }
}

