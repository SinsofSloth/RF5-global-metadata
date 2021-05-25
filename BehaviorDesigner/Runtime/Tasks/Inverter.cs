[TaskDescriptionAttribute] // RVA: 0x14C0B0 Offset: 0x14C1B1 VA: 0x14C0B0
[TaskIconAttribute] // RVA: 0x14C0B0 Offset: 0x14C1B1 VA: 0x14C0B0
public class Inverter : Decorator // TypeDefIndex: 10960
{
	// Fields
	private TaskStatus executionStatus; // 0x58

	// Methods

	// RVA: 0x20E1400 Offset: 0x20E1501 VA: 0x20E1400 Slot: 33
	public override bool CanExecute() { }

	// RVA: 0x20E1420 Offset: 0x20E1521 VA: 0x20E1420 Slot: 36
	public override void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x20E1430 Offset: 0x20E1531 VA: 0x20E1430 Slot: 34
	public override TaskStatus Decorate(TaskStatus status) { }

	// RVA: 0x20E1450 Offset: 0x20E1551 VA: 0x20E1450 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E1460 Offset: 0x20E1561 VA: 0x20E1460
	public void .ctor() { }
}

