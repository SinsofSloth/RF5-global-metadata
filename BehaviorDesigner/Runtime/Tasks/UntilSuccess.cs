[TaskDescriptionAttribute] // RVA: 0x14C2F0 Offset: 0x14C3F1 VA: 0x14C2F0
[TaskIconAttribute] // RVA: 0x14C2F0 Offset: 0x14C3F1 VA: 0x14C2F0
public class UntilSuccess : Decorator // TypeDefIndex: 10966
{
	// Fields
	private TaskStatus executionStatus; // 0x58

	// Methods

	// RVA: 0x22DA470 Offset: 0x22DA571 VA: 0x22DA470 Slot: 33
	public override bool CanExecute() { }

	// RVA: 0x22DA480 Offset: 0x22DA581 VA: 0x22DA480 Slot: 36
	public override void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x22DA490 Offset: 0x22DA591 VA: 0x22DA490 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x22DA4A0 Offset: 0x22DA5A1 VA: 0x22DA4A0
	public void .ctor() { }
}

