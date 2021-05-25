[TaskCategoryAttribute] // RVA: 0x152B60 Offset: 0x152C61 VA: 0x152B60
[TaskDescriptionAttribute] // RVA: 0x152B60 Offset: 0x152C61 VA: 0x152B60
public class LerpAngle : Action // TypeDefIndex: 11251
{
	// Fields
	[TooltipAttribute] // RVA: 0x18E6F0 Offset: 0x18E7F1 VA: 0x18E6F0
	public SharedFloat fromValue; // 0x50
	[TooltipAttribute] // RVA: 0x18E730 Offset: 0x18E831 VA: 0x18E730
	public SharedFloat toValue; // 0x58
	[TooltipAttribute] // RVA: 0x18E770 Offset: 0x18E871 VA: 0x18E770
	public SharedFloat lerpAmount; // 0x60
	[TooltipAttribute] // RVA: 0x18E7B0 Offset: 0x18E8B1 VA: 0x18E7B0
	[RequiredFieldAttribute] // RVA: 0x18E7B0 Offset: 0x18E8B1 VA: 0x18E7B0
	public SharedFloat storeResult; // 0x68

	// Methods

	// RVA: 0x20EC000 Offset: 0x20EC101 VA: 0x20EC000 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20EC100 Offset: 0x20EC201 VA: 0x20EC100 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20EC350 Offset: 0x20EC451 VA: 0x20EC350
	public void .ctor() { }
}

