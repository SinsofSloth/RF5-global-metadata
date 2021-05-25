[TaskCategoryAttribute] // RVA: 0x151360 Offset: 0x151461 VA: 0x151360
[TaskDescriptionAttribute] // RVA: 0x151360 Offset: 0x151461 VA: 0x151360
public class Raycast : Action // TypeDefIndex: 11182
{
	// Fields
	[TooltipAttribute] // RVA: 0x18BFE0 Offset: 0x18C0E1 VA: 0x18BFE0
	public SharedGameObject originGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18C020 Offset: 0x18C121 VA: 0x18C020
	public SharedVector2 originPosition; // 0x58
	[TooltipAttribute] // RVA: 0x18C060 Offset: 0x18C161 VA: 0x18C060
	public SharedVector2 direction; // 0x60
	[TooltipAttribute] // RVA: 0x18C0A0 Offset: 0x18C1A1 VA: 0x18C0A0
	public SharedFloat distance; // 0x68
	[TooltipAttribute] // RVA: 0x18C0E0 Offset: 0x18C1E1 VA: 0x18C0E0
	public LayerMask layerMask; // 0x70
	[TooltipAttribute] // RVA: 0x18C120 Offset: 0x18C221 VA: 0x18C120
	public Space space; // 0x74
	[SharedRequiredAttribute] // RVA: 0x18C160 Offset: 0x18C261 VA: 0x18C160
	[TooltipAttribute] // RVA: 0x18C160 Offset: 0x18C261 VA: 0x18C160
	public SharedGameObject storeHitObject; // 0x78
	[SharedRequiredAttribute] // RVA: 0x18C1B0 Offset: 0x18C2B1 VA: 0x18C1B0
	[TooltipAttribute] // RVA: 0x18C1B0 Offset: 0x18C2B1 VA: 0x18C1B0
	public SharedVector2 storeHitPoint; // 0x80
	[SharedRequiredAttribute] // RVA: 0x18C200 Offset: 0x18C301 VA: 0x18C200
	[TooltipAttribute] // RVA: 0x18C200 Offset: 0x18C301 VA: 0x18C200
	public SharedVector2 storeHitNormal; // 0x88
	[SharedRequiredAttribute] // RVA: 0x18C250 Offset: 0x18C351 VA: 0x18C250
	[TooltipAttribute] // RVA: 0x18C250 Offset: 0x18C351 VA: 0x18C250
	public SharedFloat storeHitDistance; // 0x90

	// Methods

	// RVA: 0x287EA50 Offset: 0x287EB51 VA: 0x287EA50 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287EE00 Offset: 0x287EF01 VA: 0x287EE00 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287EEE0 Offset: 0x287EFE1 VA: 0x287EEE0
	public void .ctor() { }
}

