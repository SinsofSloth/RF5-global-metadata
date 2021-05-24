[TaskCategoryAttribute] // RVA: 0x151480 Offset: 0x151581 VA: 0x151480
[TaskDescriptionAttribute] // RVA: 0x151480 Offset: 0x151581 VA: 0x151480
public class SphereCast : Action // TypeDefIndex: 11185
{
	// Fields
	[TooltipAttribute] // RVA: 0x18C620 Offset: 0x18C721 VA: 0x18C620
	public SharedGameObject originGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18C660 Offset: 0x18C761 VA: 0x18C660
	public SharedVector3 originPosition; // 0x58
	[TooltipAttribute] // RVA: 0x18C6A0 Offset: 0x18C7A1 VA: 0x18C6A0
	public SharedFloat radius; // 0x60
	[TooltipAttribute] // RVA: 0x18C6E0 Offset: 0x18C7E1 VA: 0x18C6E0
	public SharedVector3 direction; // 0x68
	[TooltipAttribute] // RVA: 0x18C720 Offset: 0x18C821 VA: 0x18C720
	public SharedFloat distance; // 0x70
	[TooltipAttribute] // RVA: 0x18C760 Offset: 0x18C861 VA: 0x18C760
	public LayerMask layerMask; // 0x78
	[TooltipAttribute] // RVA: 0x18C7A0 Offset: 0x18C8A1 VA: 0x18C7A0
	public Space space; // 0x7C
	[SharedRequiredAttribute] // RVA: 0x18C7E0 Offset: 0x18C8E1 VA: 0x18C7E0
	[TooltipAttribute] // RVA: 0x18C7E0 Offset: 0x18C8E1 VA: 0x18C7E0
	public SharedGameObject storeHitObject; // 0x80
	[SharedRequiredAttribute] // RVA: 0x18C830 Offset: 0x18C931 VA: 0x18C830
	[TooltipAttribute] // RVA: 0x18C830 Offset: 0x18C931 VA: 0x18C830
	public SharedVector3 storeHitPoint; // 0x88
	[SharedRequiredAttribute] // RVA: 0x18C880 Offset: 0x18C981 VA: 0x18C880
	[TooltipAttribute] // RVA: 0x18C880 Offset: 0x18C981 VA: 0x18C880
	public SharedVector3 storeHitNormal; // 0x90
	[SharedRequiredAttribute] // RVA: 0x18C8D0 Offset: 0x18C9D1 VA: 0x18C8D0
	[TooltipAttribute] // RVA: 0x18C8D0 Offset: 0x18C9D1 VA: 0x18C8D0
	public SharedFloat storeHitDistance; // 0x98

	// Methods

	// RVA: 0x287DEB0 Offset: 0x287DFB1 VA: 0x287DEB0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287E1B0 Offset: 0x287E2B1 VA: 0x287E1B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287E2B0 Offset: 0x287E3B1 VA: 0x287E2B0
	public void .ctor() { }
}

