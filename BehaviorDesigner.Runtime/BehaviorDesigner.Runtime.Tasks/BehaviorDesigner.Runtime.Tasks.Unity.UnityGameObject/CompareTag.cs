[TaskCategoryAttribute] // RVA: 0x153B80 Offset: 0x153C81 VA: 0x153B80
[TaskDescriptionAttribute] // RVA: 0x153B80 Offset: 0x153C81 VA: 0x153B80
public class CompareTag : Conditional // TypeDefIndex: 11294
{
	// Fields
	[TooltipAttribute] // RVA: 0x18FCB0 Offset: 0x18FDB1 VA: 0x18FCB0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18FCF0 Offset: 0x18FDF1 VA: 0x18FCF0
	public SharedString tag; // 0x58

	// Methods

	// RVA: 0x27A0E10 Offset: 0x27A0F11 VA: 0x27A0E10 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A0EC0 Offset: 0x27A0FC1 VA: 0x27A0EC0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A0F30 Offset: 0x27A1031 VA: 0x27A0F30
	public void .ctor() { }
}

