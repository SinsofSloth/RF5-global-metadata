[TaskCategoryAttribute] // RVA: 0x1511E0 Offset: 0x1512E1 VA: 0x1511E0
[TaskDescriptionAttribute] // RVA: 0x1511E0 Offset: 0x1512E1 VA: 0x1511E0
public class SetInt : Action // TypeDefIndex: 11178
{
	// Fields
	[TooltipAttribute] // RVA: 0x18BB20 Offset: 0x18BC21 VA: 0x18BB20
	public SharedString key; // 0x50
	[TooltipAttribute] // RVA: 0x18BB60 Offset: 0x18BC61 VA: 0x18BB60
	public SharedInt value; // 0x58

	// Methods

	// RVA: 0x287F6C0 Offset: 0x287F7C1 VA: 0x287F6C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287F750 Offset: 0x287F851 VA: 0x287F750 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287F7D0 Offset: 0x287F8D1 VA: 0x287F7D0
	public void .ctor() { }
}

