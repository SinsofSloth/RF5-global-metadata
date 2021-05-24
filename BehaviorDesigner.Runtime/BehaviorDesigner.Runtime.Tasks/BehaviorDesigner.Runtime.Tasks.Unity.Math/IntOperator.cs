[TaskCategoryAttribute] // RVA: 0x1529E0 Offset: 0x152AE1 VA: 0x1529E0
[TaskDescriptionAttribute] // RVA: 0x1529E0 Offset: 0x152AE1 VA: 0x1529E0
public class IntOperator : Action // TypeDefIndex: 11246
{
	// Fields
	[TooltipAttribute] // RVA: 0x18E450 Offset: 0x18E551 VA: 0x18E450
	public IntOperator.Operation operation; // 0x4C
	[TooltipAttribute] // RVA: 0x18E490 Offset: 0x18E591 VA: 0x18E490
	public SharedInt integer1; // 0x50
	[TooltipAttribute] // RVA: 0x18E4D0 Offset: 0x18E5D1 VA: 0x18E4D0
	public SharedInt integer2; // 0x58
	[RequiredFieldAttribute] // RVA: 0x18E510 Offset: 0x18E611 VA: 0x18E510
	[TooltipAttribute] // RVA: 0x18E510 Offset: 0x18E611 VA: 0x18E510
	public SharedInt storeResult; // 0x60

	// Methods

	// RVA: 0x20EB5E0 Offset: 0x20EB6E1 VA: 0x20EB5E0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20EB880 Offset: 0x20EB981 VA: 0x20EB880 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20EBA20 Offset: 0x20EBB21 VA: 0x20EBA20
	public void .ctor() { }
}

