[TaskCategoryAttribute] // RVA: 0x1512A0 Offset: 0x1513A1 VA: 0x1512A0
[TaskDescriptionAttribute] // RVA: 0x1512A0 Offset: 0x1513A1 VA: 0x1512A0
public class Circlecast : Action // TypeDefIndex: 11180
{
	// Fields
	[TooltipAttribute] // RVA: 0x18BC20 Offset: 0x18BD21 VA: 0x18BC20
	public SharedGameObject originGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18BC60 Offset: 0x18BD61 VA: 0x18BC60
	public SharedVector2 originPosition; // 0x58
	[TooltipAttribute] // RVA: 0x18BCA0 Offset: 0x18BDA1 VA: 0x18BCA0
	public SharedFloat radius; // 0x60
	[TooltipAttribute] // RVA: 0x18BCE0 Offset: 0x18BDE1 VA: 0x18BCE0
	public SharedVector2 direction; // 0x68
	[TooltipAttribute] // RVA: 0x18BD20 Offset: 0x18BE21 VA: 0x18BD20
	public SharedFloat distance; // 0x70
	[TooltipAttribute] // RVA: 0x18BD60 Offset: 0x18BE61 VA: 0x18BD60
	public LayerMask layerMask; // 0x78
	[TooltipAttribute] // RVA: 0x18BDA0 Offset: 0x18BEA1 VA: 0x18BDA0
	public Space space; // 0x7C
	[SharedRequiredAttribute] // RVA: 0x18BDE0 Offset: 0x18BEE1 VA: 0x18BDE0
	[TooltipAttribute] // RVA: 0x18BDE0 Offset: 0x18BEE1 VA: 0x18BDE0
	public SharedGameObject storeHitObject; // 0x80
	[SharedRequiredAttribute] // RVA: 0x18BE30 Offset: 0x18BF31 VA: 0x18BE30
	[TooltipAttribute] // RVA: 0x18BE30 Offset: 0x18BF31 VA: 0x18BE30
	public SharedVector2 storeHitPoint; // 0x88
	[SharedRequiredAttribute] // RVA: 0x18BE80 Offset: 0x18BF81 VA: 0x18BE80
	[TooltipAttribute] // RVA: 0x18BE80 Offset: 0x18BF81 VA: 0x18BE80
	public SharedVector2 storeHitNormal; // 0x90
	[SharedRequiredAttribute] // RVA: 0x18BED0 Offset: 0x18BFD1 VA: 0x18BED0
	[TooltipAttribute] // RVA: 0x18BED0 Offset: 0x18BFD1 VA: 0x18BED0
	public SharedFloat storeHitDistance; // 0x98

	// Methods

	// RVA: 0x287E310 Offset: 0x287E411 VA: 0x287E310 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287E6E0 Offset: 0x287E7E1 VA: 0x287E6E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287E7E0 Offset: 0x287E8E1 VA: 0x287E7E0
	public void .ctor() { }
}

