[TaskCategoryAttribute] // RVA: 0x150D00 Offset: 0x150E01 VA: 0x150D00
[TaskDescriptionAttribute] // RVA: 0x150D00 Offset: 0x150E01 VA: 0x150D00
public class Inverse : Action // TypeDefIndex: 11165
{
	// Fields
	[TooltipAttribute] // RVA: 0x18B320 Offset: 0x18B421 VA: 0x18B320
	public SharedQuaternion targetQuaternion; // 0x50
	[TooltipAttribute] // RVA: 0x18B360 Offset: 0x18B461 VA: 0x18B360
	[RequiredFieldAttribute] // RVA: 0x18B360 Offset: 0x18B461 VA: 0x18B360
	public SharedQuaternion storeResult; // 0x58

	// Methods

	// RVA: 0x2880350 Offset: 0x2880451 VA: 0x2880350 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2880430 Offset: 0x2880531 VA: 0x2880430 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28804C0 Offset: 0x28805C1 VA: 0x28804C0
	public void .ctor() { }
}

