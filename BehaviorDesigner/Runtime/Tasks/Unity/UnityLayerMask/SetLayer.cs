[TaskCategoryAttribute] // RVA: 0x153520 Offset: 0x153621 VA: 0x153520
[TaskDescriptionAttribute] // RVA: 0x153520 Offset: 0x153621 VA: 0x153520
public class SetLayer : Action // TypeDefIndex: 11277
{
	// Fields
	[TooltipAttribute] // RVA: 0x18F5C0 Offset: 0x18F6C1 VA: 0x18F5C0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18F600 Offset: 0x18F701 VA: 0x18F600
	public SharedString layerName; // 0x58

	// Methods

	// RVA: 0x27A2BC0 Offset: 0x27A2CC1 VA: 0x27A2BC0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A2C70 Offset: 0x27A2D71 VA: 0x27A2C70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A2CE0 Offset: 0x27A2DE1 VA: 0x27A2CE0
	public void .ctor() { }
}

