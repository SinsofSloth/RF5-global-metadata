[TaskDescriptionAttribute] // RVA: 0x14BA10 Offset: 0x14BB11 VA: 0x14BA10
[TaskIconAttribute] // RVA: 0x14BA10 Offset: 0x14BB11 VA: 0x14BA10
public class SelectorEvaluator : Composite // TypeDefIndex: 10943
{
	// Fields
	private int currentChildIndex; // 0x5C
	private TaskStatus executionStatus; // 0x60
	private int storedCurrentChildIndex; // 0x64
	private TaskStatus storedExecutionStatus; // 0x68

	// Methods

	// RVA: 0x20E6FE0 Offset: 0x20E70E1 VA: 0x20E6FE0 Slot: 32
	public override int CurrentChildIndex() { }

	// RVA: 0x20E6FF0 Offset: 0x20E70F1 VA: 0x20E6FF0 Slot: 39
	public override void OnChildStarted(int childIndex) { }

	// RVA: 0x20E7010 Offset: 0x20E7111 VA: 0x20E7010 Slot: 33
	public override bool CanExecute() { }

	// RVA: 0x20E70A0 Offset: 0x20E71A1 VA: 0x20E70A0 Slot: 37
	public override void OnChildExecuted(int childIndex, TaskStatus childStatus) { }

	// RVA: 0x20E7150 Offset: 0x20E7251 VA: 0x20E7150 Slot: 42
	public override void OnConditionalAbort(int childIndex) { }

	// RVA: 0x20E7160 Offset: 0x20E7261 VA: 0x20E7160 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E7170 Offset: 0x20E7271 VA: 0x20E7170 Slot: 40
	public override TaskStatus OverrideStatus(TaskStatus status) { }

	// RVA: 0x20E7180 Offset: 0x20E7281 VA: 0x20E7180 Slot: 31
	public override bool CanRunParallelChildren() { }

	// RVA: 0x20E7190 Offset: 0x20E7291 VA: 0x20E7190 Slot: 35
	public override bool CanReevaluate() { }

	// RVA: 0x20E71A0 Offset: 0x20E72A1 VA: 0x20E71A0 Slot: 43
	public override bool OnReevaluationStarted() { }

	// RVA: 0x20E71D0 Offset: 0x20E72D1 VA: 0x20E71D0 Slot: 44
	public override void OnReevaluationEnded(TaskStatus status) { }

	// RVA: 0x20E72C0 Offset: 0x20E73C1 VA: 0x20E72C0
	public void .ctor() { }
}

