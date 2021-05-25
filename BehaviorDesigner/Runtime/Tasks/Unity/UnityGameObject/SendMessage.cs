[TaskCategoryAttribute] // RVA: 0x153EE0 Offset: 0x153FE1 VA: 0x153EE0
[TaskDescriptionAttribute] // RVA: 0x153EE0 Offset: 0x153FE1 VA: 0x153EE0
public class SendMessage : Action // TypeDefIndex: 11303
{
	// Fields
	[TooltipAttribute] // RVA: 0x190250 Offset: 0x190351 VA: 0x190250
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x190290 Offset: 0x190391 VA: 0x190290
	public SharedString message; // 0x58
	[TooltipAttribute] // RVA: 0x1902D0 Offset: 0x1903D1 VA: 0x1902D0
	public SharedGenericVariable value; // 0x60

	// Methods

	// RVA: 0x27A1B30 Offset: 0x27A1C31 VA: 0x27A1B30 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A1C50 Offset: 0x27A1D51 VA: 0x27A1C50 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A1CC0 Offset: 0x27A1DC1 VA: 0x27A1CC0
	public void .ctor() { }
}

