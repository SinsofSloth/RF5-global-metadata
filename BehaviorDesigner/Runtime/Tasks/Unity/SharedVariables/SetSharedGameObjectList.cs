[TaskCategoryAttribute] // RVA: 0x14ECD0 Offset: 0x14EDD1 VA: 0x14ECD0
[TaskDescriptionAttribute] // RVA: 0x14ECD0 Offset: 0x14EDD1 VA: 0x14ECD0
public class SetSharedGameObjectList : Action // TypeDefIndex: 11080
{
	// Fields
	[TooltipAttribute] // RVA: 0x188500 Offset: 0x188601 VA: 0x188500
	public SharedGameObjectList targetValue; // 0x50
	[RequiredFieldAttribute] // RVA: 0x188540 Offset: 0x188641 VA: 0x188540
	[TooltipAttribute] // RVA: 0x188540 Offset: 0x188641 VA: 0x188540
	public SharedGameObjectList targetVariable; // 0x58

	// Methods

	// RVA: 0x278C3B0 Offset: 0x278C4B1 VA: 0x278C3B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278C430 Offset: 0x278C531 VA: 0x278C430 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278C470 Offset: 0x278C571 VA: 0x278C470
	public void .ctor() { }
}

