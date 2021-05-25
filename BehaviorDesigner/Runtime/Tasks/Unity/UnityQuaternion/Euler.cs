[TaskCategoryAttribute] // RVA: 0x150BE0 Offset: 0x150CE1 VA: 0x150BE0
[TaskDescriptionAttribute] // RVA: 0x150BE0 Offset: 0x150CE1 VA: 0x150BE0
public class Euler : Action // TypeDefIndex: 11162
{
	// Fields
	[TooltipAttribute] // RVA: 0x18B170 Offset: 0x18B271 VA: 0x18B170
	public SharedVector3 eulerVector; // 0x50
	[TooltipAttribute] // RVA: 0x18B1B0 Offset: 0x18B2B1 VA: 0x18B1B0
	[RequiredFieldAttribute] // RVA: 0x18B1B0 Offset: 0x18B2B1 VA: 0x18B1B0
	public SharedQuaternion storeResult; // 0x58

	// Methods

	// RVA: 0x287FEA0 Offset: 0x287FFA1 VA: 0x287FEA0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287FF70 Offset: 0x2880071 VA: 0x287FF70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2880030 Offset: 0x2880131 VA: 0x2880030
	public void .ctor() { }
}

