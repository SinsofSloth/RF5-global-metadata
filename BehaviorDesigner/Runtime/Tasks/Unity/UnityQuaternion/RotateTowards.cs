[TaskCategoryAttribute] // RVA: 0x150E20 Offset: 0x150F21 VA: 0x150E20
[TaskDescriptionAttribute] // RVA: 0x150E20 Offset: 0x150F21 VA: 0x150E20
public class RotateTowards : Action // TypeDefIndex: 11168
{
	// Fields
	[TooltipAttribute] // RVA: 0x18B590 Offset: 0x18B691 VA: 0x18B590
	public SharedQuaternion fromQuaternion; // 0x50
	[TooltipAttribute] // RVA: 0x18B5D0 Offset: 0x18B6D1 VA: 0x18B5D0
	public SharedQuaternion toQuaternion; // 0x58
	[TooltipAttribute] // RVA: 0x18B610 Offset: 0x18B711 VA: 0x18B610
	public SharedFloat maxDeltaDegrees; // 0x60
	[TooltipAttribute] // RVA: 0x18B650 Offset: 0x18B751 VA: 0x18B650
	[RequiredFieldAttribute] // RVA: 0x18B650 Offset: 0x18B751 VA: 0x18B650
	public SharedQuaternion storeResult; // 0x68

	// Methods

	// RVA: 0x2880890 Offset: 0x2880991 VA: 0x2880890 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28809E0 Offset: 0x2880AE1 VA: 0x28809E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2880AA0 Offset: 0x2880BA1 VA: 0x2880AA0
	public void .ctor() { }
}

