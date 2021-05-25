[TaskDescriptionAttribute] // RVA: 0x14C170 Offset: 0x14C271 VA: 0x14C170
[TaskIconAttribute] // RVA: 0x14C170 Offset: 0x14C271 VA: 0x14C170
public class ReturnFailure : Decorator // TypeDefIndex: 10962
{
	// Fields
	private TaskStatus executionStatus; // 0x58

	// Methods

	// RVA: 0x20E6E50 Offset: 0x20E6F51 VA: 0x20E6E50 Slot: 33
	public override bool CanExecute() { }

	// RVA: 0x20E6E70 Offset: 0x20E6F71 VA: 0x20E6E70 Slot: 36
	public override void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x20E6E80 Offset: 0x20E6F81 VA: 0x20E6E80 Slot: 34
	public override TaskStatus Decorate(TaskStatus status) { }

	// RVA: 0x20E6E90 Offset: 0x20E6F91 VA: 0x20E6E90 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E6EA0 Offset: 0x20E6FA1 VA: 0x20E6EA0
	public void .ctor() { }
}

