[TaskDescriptionAttribute] // RVA: 0x14B770 Offset: 0x14B871 VA: 0x14B770
[TaskIconAttribute] // RVA: 0x14B770 Offset: 0x14B871 VA: 0x14B770
public class Parallel : Composite // TypeDefIndex: 10936
{
	// Fields
	private int currentChildIndex; // 0x5C
	private TaskStatus[] executionStatus; // 0x60

	// Methods

	// RVA: 0x20E44D0 Offset: 0x20E45D1 VA: 0x20E44D0 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20E4540 Offset: 0x20E4641 VA: 0x20E4540 Slot: 39
	public override void OnChildStarted(int childIndex) { }

	// RVA: 0x20E4590 Offset: 0x20E4691 VA: 0x20E4590 Slot: 31
	public override bool CanRunParallelChildren() { }

	// RVA: 0x20E45A0 Offset: 0x20E46A1 VA: 0x20E45A0 Slot: 32
	public override int CurrentChildIndex() { }

	// RVA: 0x20E45B0 Offset: 0x20E46B1 VA: 0x20E45B0 Slot: 33
	public override bool CanExecute() { }

	// RVA: 0x20E4610 Offset: 0x20E4711 VA: 0x20E4610 Slot: 37
	public override void OnChildExecuted(int childIndex, TaskStatus childStatus) { }

	// RVA: 0x20E4650 Offset: 0x20E4751 VA: 0x20E4650 Slot: 40
	public override TaskStatus OverrideStatus(TaskStatus status) { }

	// RVA: 0x20E46F0 Offset: 0x20E47F1 VA: 0x20E46F0 Slot: 42
	public override void OnConditionalAbort(int childIndex) { }

	// RVA: 0x20E4750 Offset: 0x20E4851 VA: 0x20E4750 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E47B0 Offset: 0x20E48B1 VA: 0x20E47B0
	public void .ctor() { }
}

