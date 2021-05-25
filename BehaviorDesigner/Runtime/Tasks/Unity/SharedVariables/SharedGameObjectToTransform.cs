[TaskCategoryAttribute] // RVA: 0x14F150 Offset: 0x14F251 VA: 0x14F150
[TaskDescriptionAttribute] // RVA: 0x14F150 Offset: 0x14F251 VA: 0x14F150
public class SharedGameObjectToTransform : Action // TypeDefIndex: 11092
{
	// Fields
	[TooltipAttribute] // RVA: 0x188BC0 Offset: 0x188CC1 VA: 0x188BC0
	public SharedGameObject sharedGameObject; // 0x50
	[RequiredFieldAttribute] // RVA: 0x188C00 Offset: 0x188D01 VA: 0x188C00
	[TooltipAttribute] // RVA: 0x188C00 Offset: 0x188D01 VA: 0x188C00
	public SharedTransform sharedTransform; // 0x58

	// Methods

	// RVA: 0x278CFE0 Offset: 0x278D0E1 VA: 0x278CFE0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278D0E0 Offset: 0x278D1E1 VA: 0x278D0E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278D120 Offset: 0x278D221 VA: 0x278D120
	public void .ctor() { }
}

