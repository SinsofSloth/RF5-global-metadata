[TaskDescriptionAttribute] // RVA: 0x14B3B0 Offset: 0x14B4B1 VA: 0x14B3B0
[TaskCategoryAttribute] // RVA: 0x14B3B0 Offset: 0x14B4B1 VA: 0x14B3B0
[TaskIconAttribute] // RVA: 0x14B3B0 Offset: 0x14B4B1 VA: 0x14B3B0
public class InvokeMethod : Action // TypeDefIndex: 10928
{
	// Fields
	[TooltipAttribute] // RVA: 0x182DB0 Offset: 0x182EB1 VA: 0x182DB0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x182DF0 Offset: 0x182EF1 VA: 0x182DF0
	public SharedString componentName; // 0x58
	[TooltipAttribute] // RVA: 0x182E30 Offset: 0x182F31 VA: 0x182E30
	public SharedString methodName; // 0x60
	[TooltipAttribute] // RVA: 0x182E70 Offset: 0x182F71 VA: 0x182E70
	public SharedVariable parameter1; // 0x68
	[TooltipAttribute] // RVA: 0x182EB0 Offset: 0x182FB1 VA: 0x182EB0
	public SharedVariable parameter2; // 0x70
	[TooltipAttribute] // RVA: 0x182EF0 Offset: 0x182FF1 VA: 0x182EF0
	public SharedVariable parameter3; // 0x78
	[TooltipAttribute] // RVA: 0x182F30 Offset: 0x183031 VA: 0x182F30
	public SharedVariable parameter4; // 0x80
	[TooltipAttribute] // RVA: 0x182F70 Offset: 0x183071 VA: 0x182F70
	public SharedVariable storeResult; // 0x88

	// Methods

	// RVA: 0x20E1470 Offset: 0x20E1571 VA: 0x20E1470 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E19B0 Offset: 0x20E1AB1 VA: 0x20E19B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E1A50 Offset: 0x20E1B51 VA: 0x20E1A50
	public void .ctor() { }
}

