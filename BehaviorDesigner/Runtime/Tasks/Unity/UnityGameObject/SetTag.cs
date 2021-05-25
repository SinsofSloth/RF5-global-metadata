[TaskCategoryAttribute] // RVA: 0x153FA0 Offset: 0x1540A1 VA: 0x153FA0
[TaskDescriptionAttribute] // RVA: 0x153FA0 Offset: 0x1540A1 VA: 0x153FA0
public class SetTag : Action // TypeDefIndex: 11305
{
	// Fields
	[TooltipAttribute] // RVA: 0x190390 Offset: 0x190491 VA: 0x190390
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1903D0 Offset: 0x1904D1 VA: 0x1903D0
	public SharedString tag; // 0x58

	// Methods

	// RVA: 0x27A1DD0 Offset: 0x27A1ED1 VA: 0x27A1DD0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A1E70 Offset: 0x27A1F71 VA: 0x27A1E70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A1EE0 Offset: 0x27A1FE1 VA: 0x27A1EE0
	public void .ctor() { }
}

