[TaskCategoryAttribute] // RVA: 0x14E910 Offset: 0x14EA11 VA: 0x14E910
[TaskDescriptionAttribute] // RVA: 0x14E910 Offset: 0x14EA11 VA: 0x14E910
public class CompareSharedString : Conditional // TypeDefIndex: 11070
{
	// Fields
	[TooltipAttribute] // RVA: 0x187F80 Offset: 0x188081 VA: 0x187F80
	public SharedString variable; // 0x50
	[TooltipAttribute] // RVA: 0x187FC0 Offset: 0x1880C1 VA: 0x187FC0
	public SharedString compareTo; // 0x58

	// Methods

	// RVA: 0x20EE140 Offset: 0x20EE241 VA: 0x20EE140 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20EE1E0 Offset: 0x20EE2E1 VA: 0x20EE1E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20EE360 Offset: 0x20EE461 VA: 0x20EE360
	public void .ctor() { }
}

