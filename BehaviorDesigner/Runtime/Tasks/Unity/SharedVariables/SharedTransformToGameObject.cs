[TaskCategoryAttribute] // RVA: 0x14F210 Offset: 0x14F311 VA: 0x14F210
[TaskDescriptionAttribute] // RVA: 0x14F210 Offset: 0x14F311 VA: 0x14F210
public class SharedTransformToGameObject : Action // TypeDefIndex: 11094
{
	// Fields
	[TooltipAttribute] // RVA: 0x188CE0 Offset: 0x188DE1 VA: 0x188CE0
	public SharedTransform sharedTransform; // 0x50
	[RequiredFieldAttribute] // RVA: 0x188D20 Offset: 0x188E21 VA: 0x188D20
	[TooltipAttribute] // RVA: 0x188D20 Offset: 0x188E21 VA: 0x188D20
	public SharedGameObject sharedGameObject; // 0x58

	// Methods

	// RVA: 0x278D340 Offset: 0x278D441 VA: 0x278D340 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278D430 Offset: 0x278D531 VA: 0x278D430 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278D470 Offset: 0x278D571 VA: 0x278D470
	public void .ctor() { }
}

