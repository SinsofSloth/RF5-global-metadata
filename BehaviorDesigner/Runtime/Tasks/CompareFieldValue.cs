[TaskDescriptionAttribute] // RVA: 0x14BED0 Offset: 0x14BFD1 VA: 0x14BED0
[TaskCategoryAttribute] // RVA: 0x14BED0 Offset: 0x14BFD1 VA: 0x14BED0
[TaskIconAttribute] // RVA: 0x14BED0 Offset: 0x14BFD1 VA: 0x14BED0
public class CompareFieldValue : Conditional // TypeDefIndex: 10956
{
	// Fields
	[TooltipAttribute] // RVA: 0x183D90 Offset: 0x183E91 VA: 0x183D90
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x183DD0 Offset: 0x183ED1 VA: 0x183DD0
	public SharedString componentName; // 0x58
	[TooltipAttribute] // RVA: 0x183E10 Offset: 0x183F11 VA: 0x183E10
	public SharedString fieldName; // 0x60
	[TooltipAttribute] // RVA: 0x183E50 Offset: 0x183F51 VA: 0x183E50
	public SharedVariable compareValue; // 0x68

	// Methods

	// RVA: 0x20DD4A0 Offset: 0x20DD5A1 VA: 0x20DD4A0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DD770 Offset: 0x20DD871 VA: 0x20DD770 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20DD7D0 Offset: 0x20DD8D1 VA: 0x20DD7D0
	public void .ctor() { }
}

