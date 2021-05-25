[TaskCategoryAttribute] // RVA: 0x150B80 Offset: 0x150C81 VA: 0x150B80
[TaskDescriptionAttribute] // RVA: 0x150B80 Offset: 0x150C81 VA: 0x150B80
public class Dot : Action // TypeDefIndex: 11161
{
	// Fields
	[TooltipAttribute] // RVA: 0x18B0A0 Offset: 0x18B1A1 VA: 0x18B0A0
	public SharedQuaternion leftRotation; // 0x50
	[TooltipAttribute] // RVA: 0x18B0E0 Offset: 0x18B1E1 VA: 0x18B0E0
	public SharedQuaternion rightRotation; // 0x58
	[TooltipAttribute] // RVA: 0x18B120 Offset: 0x18B221 VA: 0x18B120
	[RequiredFieldAttribute] // RVA: 0x18B120 Offset: 0x18B221 VA: 0x18B120
	public SharedFloat storeResult; // 0x60

	// Methods

	// RVA: 0x287FCC0 Offset: 0x287FDC1 VA: 0x287FCC0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287FDE0 Offset: 0x287FEE1 VA: 0x287FDE0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287FE90 Offset: 0x287FF91 VA: 0x287FE90
	public void .ctor() { }
}

