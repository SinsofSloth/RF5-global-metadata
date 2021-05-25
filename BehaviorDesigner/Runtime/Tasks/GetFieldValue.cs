[TaskDescriptionAttribute] // RVA: 0x14B290 Offset: 0x14B391 VA: 0x14B290
[TaskCategoryAttribute] // RVA: 0x14B290 Offset: 0x14B391 VA: 0x14B290
[TaskIconAttribute] // RVA: 0x14B290 Offset: 0x14B391 VA: 0x14B290
public class GetFieldValue : Action // TypeDefIndex: 10926
{
	// Fields
	[TooltipAttribute] // RVA: 0x182B90 Offset: 0x182C91 VA: 0x182B90
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x182BD0 Offset: 0x182CD1 VA: 0x182BD0
	public SharedString componentName; // 0x58
	[TooltipAttribute] // RVA: 0x182C10 Offset: 0x182D11 VA: 0x182C10
	public SharedString fieldName; // 0x60
	[TooltipAttribute] // RVA: 0x182C50 Offset: 0x182D51 VA: 0x182C50
	[RequiredFieldAttribute] // RVA: 0x182C50 Offset: 0x182D51 VA: 0x182C50
	public SharedVariable fieldValue; // 0x68

	// Methods

	// RVA: 0x20DEAD0 Offset: 0x20DEBD1 VA: 0x20DEAD0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DED50 Offset: 0x20DEE51 VA: 0x20DED50 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20DEDB0 Offset: 0x20DEEB1 VA: 0x20DEDB0
	public void .ctor() { }
}

