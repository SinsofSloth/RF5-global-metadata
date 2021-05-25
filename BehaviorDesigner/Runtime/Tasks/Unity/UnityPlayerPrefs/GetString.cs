[TaskCategoryAttribute] // RVA: 0x151060 Offset: 0x151161 VA: 0x151060
[TaskDescriptionAttribute] // RVA: 0x151060 Offset: 0x151161 VA: 0x151060
public class GetString : Action // TypeDefIndex: 11174
{
	// Fields
	[TooltipAttribute] // RVA: 0x18B990 Offset: 0x18BA91 VA: 0x18B990
	public SharedString key; // 0x50
	[TooltipAttribute] // RVA: 0x18B9D0 Offset: 0x18BAD1 VA: 0x18B9D0
	public SharedString defaultValue; // 0x58
	[TooltipAttribute] // RVA: 0x18BA10 Offset: 0x18BB11 VA: 0x18BA10
	[RequiredFieldAttribute] // RVA: 0x18BA10 Offset: 0x18BB11 VA: 0x18BA10
	public SharedString storeResult; // 0x60

	// Methods

	// RVA: 0x287F330 Offset: 0x287F431 VA: 0x287F330 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287F3E0 Offset: 0x287F4E1 VA: 0x287F3E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287F480 Offset: 0x287F581 VA: 0x287F480
	public void .ctor() { }
}

