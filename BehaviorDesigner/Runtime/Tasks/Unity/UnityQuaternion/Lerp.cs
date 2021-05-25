[TaskCategoryAttribute] // RVA: 0x150D60 Offset: 0x150E61 VA: 0x150D60
[TaskDescriptionAttribute] // RVA: 0x150D60 Offset: 0x150E61 VA: 0x150D60
public class Lerp : Action // TypeDefIndex: 11166
{
	// Fields
	[TooltipAttribute] // RVA: 0x18B3B0 Offset: 0x18B4B1 VA: 0x18B3B0
	public SharedQuaternion fromQuaternion; // 0x50
	[TooltipAttribute] // RVA: 0x18B3F0 Offset: 0x18B4F1 VA: 0x18B3F0
	public SharedQuaternion toQuaternion; // 0x58
	[TooltipAttribute] // RVA: 0x18B430 Offset: 0x18B531 VA: 0x18B430
	public SharedFloat amount; // 0x60
	[TooltipAttribute] // RVA: 0x18B470 Offset: 0x18B571 VA: 0x18B470
	[RequiredFieldAttribute] // RVA: 0x18B470 Offset: 0x18B571 VA: 0x18B470
	public SharedQuaternion storeResult; // 0x68

	// Methods

	// RVA: 0x28804D0 Offset: 0x28805D1 VA: 0x28804D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2880620 Offset: 0x2880721 VA: 0x2880620 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28806E0 Offset: 0x28807E1 VA: 0x28806E0
	public void .ctor() { }
}

