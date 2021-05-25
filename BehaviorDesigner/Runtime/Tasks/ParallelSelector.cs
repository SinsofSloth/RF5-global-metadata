[TaskDescriptionAttribute] // RVA: 0x14B830 Offset: 0x14B931 VA: 0x14B830
[TaskIconAttribute] // RVA: 0x14B830 Offset: 0x14B931 VA: 0x14B830
public class ParallelSelector : Composite // TypeDefIndex: 10938
{
	// Fields
	private int currentChildIndex; // 0x5C
	private TaskStatus[] executionStatus; // 0x60

	// Methods

	// RVA: 0x20E4A90 Offset: 0x20E4B91 VA: 0x20E4A90 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20E4B00 Offset: 0x20E4C01 VA: 0x20E4B00 Slot: 39
	public override void OnChildStarted(int childIndex) { }

	// RVA: 0x20E4B50 Offset: 0x20E4C51 VA: 0x20E4B50 Slot: 31
	public override bool CanRunParallelChildren() { }

	// RVA: 0x20E4B60 Offset: 0x20E4C61 VA: 0x20E4B60 Slot: 32
	public override int CurrentChildIndex() { }

	// RVA: 0x20E4B70 Offset: 0x20E4C71 VA: 0x20E4B70 Slot: 33
	public override bool CanExecute() { }

	// RVA: 0x20E4BD0 Offset: 0x20E4CD1 VA: 0x20E4BD0 Slot: 37
	public override void OnChildExecuted(int childIndex, TaskStatus childStatus) { }

	// RVA: 0x20E4C10 Offset: 0x20E4D11 VA: 0x20E4C10 Slot: 42
	public override void OnConditionalAbort(int childIndex) { }

	// RVA: 0x20E4C70 Offset: 0x20E4D71 VA: 0x20E4C70 Slot: 40
	public override TaskStatus OverrideStatus(TaskStatus status) { }

	// RVA: 0x20E4D10 Offset: 0x20E4E11 VA: 0x20E4D10 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E4D70 Offset: 0x20E4E71 VA: 0x20E4D70
	public void .ctor() { }
}

