[TaskDescriptionAttribute] // RVA: 0x14B1D0 Offset: 0x14B2D1 VA: 0x14B1D0
[TaskIconAttribute] // RVA: 0x14B1D0 Offset: 0x14B2D1 VA: 0x14B1D0
public class Log : Action // TypeDefIndex: 10924
{
	// Fields
	[TooltipAttribute] // RVA: 0x182A50 Offset: 0x182B51 VA: 0x182A50
	public SharedString text; // 0x50
	[TooltipAttribute] // RVA: 0x182A90 Offset: 0x182B91 VA: 0x182A90
	public SharedBool logError; // 0x58
	[TooltipAttribute] // RVA: 0x182AD0 Offset: 0x182BD1 VA: 0x182AD0
	public SharedBool logTime; // 0x60

	// Methods

	// RVA: 0x20E1A60 Offset: 0x20E1B61 VA: 0x20E1A60 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E1CE0 Offset: 0x20E1DE1 VA: 0x20E1CE0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E1ED0 Offset: 0x20E1FD1 VA: 0x20E1ED0
	public void .ctor() { }
}

