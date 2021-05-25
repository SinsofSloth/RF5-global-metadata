[TaskCategoryAttribute] // RVA: 0x153B20 Offset: 0x153C21 VA: 0x153B20
[TaskDescriptionAttribute] // RVA: 0x153B20 Offset: 0x153C21 VA: 0x153B20
public class CompareLayerMask : Conditional // TypeDefIndex: 11293
{
	// Fields
	[TooltipAttribute] // RVA: 0x18FC30 Offset: 0x18FD31 VA: 0x18FC30
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18FC70 Offset: 0x18FD71 VA: 0x18FC70
	public LayerMask layermask; // 0x58

	// Methods

	// RVA: 0x27A0D50 Offset: 0x27A0E51 VA: 0x27A0D50 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A0DF0 Offset: 0x27A0EF1 VA: 0x27A0DF0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A0E00 Offset: 0x27A0F01 VA: 0x27A0E00
	public void .ctor() { }
}

