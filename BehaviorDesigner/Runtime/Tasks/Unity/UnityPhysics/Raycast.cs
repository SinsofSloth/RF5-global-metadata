[TaskCategoryAttribute] // RVA: 0x151420 Offset: 0x151521 VA: 0x151420
[TaskDescriptionAttribute] // RVA: 0x151420 Offset: 0x151521 VA: 0x151420
public class Raycast : Action // TypeDefIndex: 11184
{
	// Fields
	[TooltipAttribute] // RVA: 0x18C360 Offset: 0x18C461 VA: 0x18C360
	public SharedGameObject originGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18C3A0 Offset: 0x18C4A1 VA: 0x18C3A0
	public SharedVector3 originPosition; // 0x58
	[TooltipAttribute] // RVA: 0x18C3E0 Offset: 0x18C4E1 VA: 0x18C3E0
	public SharedVector3 direction; // 0x60
	[TooltipAttribute] // RVA: 0x18C420 Offset: 0x18C521 VA: 0x18C420
	public SharedFloat distance; // 0x68
	[TooltipAttribute] // RVA: 0x18C460 Offset: 0x18C561 VA: 0x18C460
	public LayerMask layerMask; // 0x70
	[TooltipAttribute] // RVA: 0x18C4A0 Offset: 0x18C5A1 VA: 0x18C4A0
	public Space space; // 0x74
	[SharedRequiredAttribute] // RVA: 0x18C4E0 Offset: 0x18C5E1 VA: 0x18C4E0
	[TooltipAttribute] // RVA: 0x18C4E0 Offset: 0x18C5E1 VA: 0x18C4E0
	public SharedGameObject storeHitObject; // 0x78
	[SharedRequiredAttribute] // RVA: 0x18C530 Offset: 0x18C631 VA: 0x18C530
	[TooltipAttribute] // RVA: 0x18C530 Offset: 0x18C631 VA: 0x18C530
	public SharedVector3 storeHitPoint; // 0x80
	[SharedRequiredAttribute] // RVA: 0x18C580 Offset: 0x18C681 VA: 0x18C580
	[TooltipAttribute] // RVA: 0x18C580 Offset: 0x18C681 VA: 0x18C580
	public SharedVector3 storeHitNormal; // 0x88
	[SharedRequiredAttribute] // RVA: 0x18C5D0 Offset: 0x18C6D1 VA: 0x18C5D0
	[TooltipAttribute] // RVA: 0x18C5D0 Offset: 0x18C6D1 VA: 0x18C5D0
	public SharedFloat storeHitDistance; // 0x90

	// Methods

	// RVA: 0x287DA90 Offset: 0x287DB91 VA: 0x287DA90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287DD70 Offset: 0x287DE71 VA: 0x287DD70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287DE50 Offset: 0x287DF51 VA: 0x287DE50
	public void .ctor() { }
}

