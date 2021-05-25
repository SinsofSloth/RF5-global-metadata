[TaskDescriptionAttribute] // RVA: 0x14B9B0 Offset: 0x14BAB1 VA: 0x14B9B0
[TaskIconAttribute] // RVA: 0x14B9B0 Offset: 0x14BAB1 VA: 0x14B9B0
public class Selector : Composite // TypeDefIndex: 10942
{
	// Fields
	private int currentChildIndex; // 0x5C
	private TaskStatus executionStatus; // 0x60

	// Methods

	// RVA: 0x20E6F10 Offset: 0x20E7011 VA: 0x20E6F10 Slot: 32
	public override int CurrentChildIndex() { }

	// RVA: 0x20E6F20 Offset: 0x20E7021 VA: 0x20E6F20 Slot: 33
	public override bool CanExecute() { }

	// RVA: 0x20E6FA0 Offset: 0x20E70A1 VA: 0x20E6FA0 Slot: 36
	public override void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x20E6FB0 Offset: 0x20E70B1 VA: 0x20E6FB0 Slot: 42
	public override void OnConditionalAbort(int childIndex) { }

	// RVA: 0x20E6FC0 Offset: 0x20E70C1 VA: 0x20E6FC0 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E6FD0 Offset: 0x20E70D1 VA: 0x20E6FD0
	public void .ctor() { }
}

