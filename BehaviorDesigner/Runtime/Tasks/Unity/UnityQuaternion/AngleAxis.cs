[TaskCategoryAttribute] // RVA: 0x150B20 Offset: 0x150C21 VA: 0x150B20
[TaskDescriptionAttribute] // RVA: 0x150B20 Offset: 0x150C21 VA: 0x150B20
public class AngleAxis : Action // TypeDefIndex: 11160
{
	// Fields
	[TooltipAttribute] // RVA: 0x18AFD0 Offset: 0x18B0D1 VA: 0x18AFD0
	public SharedFloat degrees; // 0x50
	[TooltipAttribute] // RVA: 0x18B010 Offset: 0x18B111 VA: 0x18B010
	public SharedVector3 axis; // 0x58
	[TooltipAttribute] // RVA: 0x18B050 Offset: 0x18B151 VA: 0x18B050
	[RequiredFieldAttribute] // RVA: 0x18B050 Offset: 0x18B151 VA: 0x18B050
	public SharedQuaternion storeResult; // 0x60

	// Methods

	// RVA: 0x287FAE0 Offset: 0x287FBE1 VA: 0x287FAE0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287FBD0 Offset: 0x287FCD1 VA: 0x287FBD0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287FCB0 Offset: 0x287FDB1 VA: 0x287FCB0
	public void .ctor() { }
}

