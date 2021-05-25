[TaskCategoryAttribute] // RVA: 0x153D60 Offset: 0x153E61 VA: 0x153D60
[TaskDescriptionAttribute] // RVA: 0x153D60 Offset: 0x153E61 VA: 0x153D60
public class FindWithTag : Action // TypeDefIndex: 11299
{
	// Fields
	[TooltipAttribute] // RVA: 0x18FF10 Offset: 0x190011 VA: 0x18FF10
	public SharedString tag; // 0x50
	[TooltipAttribute] // RVA: 0x18FF50 Offset: 0x190051 VA: 0x18FF50
	public SharedBool random; // 0x58
	[TooltipAttribute] // RVA: 0x18FF90 Offset: 0x190091 VA: 0x18FF90
	[RequiredFieldAttribute] // RVA: 0x18FF90 Offset: 0x190091 VA: 0x18FF90
	public SharedGameObject storeValue; // 0x60

	// Methods

	// RVA: 0x27A13D0 Offset: 0x27A14D1 VA: 0x27A13D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A1550 Offset: 0x27A1651 VA: 0x27A1550 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A15D0 Offset: 0x27A16D1 VA: 0x27A15D0
	public void .ctor() { }
}

