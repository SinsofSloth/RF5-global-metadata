[TaskCategoryAttribute] // RVA: 0x1513C0 Offset: 0x1514C1 VA: 0x1513C0
[TaskDescriptionAttribute] // RVA: 0x1513C0 Offset: 0x1514C1 VA: 0x1513C0
public class Linecast : Action // TypeDefIndex: 11183
{
	// Fields
	[TooltipAttribute] // RVA: 0x18C2A0 Offset: 0x18C3A1 VA: 0x18C2A0
	public SharedVector3 startPosition; // 0x50
	[TooltipAttribute] // RVA: 0x18C2E0 Offset: 0x18C3E1 VA: 0x18C2E0
	public SharedVector3 endPosition; // 0x58
	[TooltipAttribute] // RVA: 0x18C320 Offset: 0x18C421 VA: 0x18C320
	public LayerMask layerMask; // 0x60

	// Methods

	// RVA: 0x287D8C0 Offset: 0x287D9C1 VA: 0x287D8C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287D9A0 Offset: 0x287DAA1 VA: 0x287D9A0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287DA50 Offset: 0x287DB51 VA: 0x287DA50
	public void .ctor() { }
}

