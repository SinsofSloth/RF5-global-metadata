[TaskDescriptionAttribute] // RVA: 0x14B230 Offset: 0x14B331 VA: 0x14B230
[TaskIconAttribute] // RVA: 0x14B230 Offset: 0x14B331 VA: 0x14B230
public class PerformInterruption : Action // TypeDefIndex: 10925
{
	// Fields
	[TooltipAttribute] // RVA: 0x182B10 Offset: 0x182C11 VA: 0x182B10
	public Interrupt[] interruptTasks; // 0x50
	[TooltipAttribute] // RVA: 0x182B50 Offset: 0x182C51 VA: 0x182B50
	public SharedBool interruptSuccess; // 0x58

	// Methods

	// RVA: 0x20E55D0 Offset: 0x20E56D1 VA: 0x20E55D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E5710 Offset: 0x20E5811 VA: 0x20E5710 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E57D0 Offset: 0x20E58D1 VA: 0x20E57D0
	public void .ctor() { }
}

