[TaskCategoryAttribute] // RVA: 0x151240 Offset: 0x151341 VA: 0x151240
[TaskDescriptionAttribute] // RVA: 0x151240 Offset: 0x151341 VA: 0x151240
public class SetString : Action // TypeDefIndex: 11179
{
	// Fields
	[TooltipAttribute] // RVA: 0x18BBA0 Offset: 0x18BCA1 VA: 0x18BBA0
	public SharedString key; // 0x50
	[TooltipAttribute] // RVA: 0x18BBE0 Offset: 0x18BCE1 VA: 0x18BBE0
	public SharedString value; // 0x58

	// Methods

	// RVA: 0x287F7E0 Offset: 0x287F8E1 VA: 0x287F7E0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287F870 Offset: 0x287F971 VA: 0x287F870 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287F8F0 Offset: 0x287F9F1 VA: 0x287F8F0
	public void .ctor() { }
}

