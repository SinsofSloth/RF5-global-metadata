[TaskDescriptionAttribute] // RVA: 0x14B7D0 Offset: 0x14B8D1 VA: 0x14B7D0
[TaskIconAttribute] // RVA: 0x14B7D0 Offset: 0x14B8D1 VA: 0x14B7D0
public class ParallelComplete : Composite // TypeDefIndex: 10937
{
	// Fields
	private int currentChildIndex; // 0x5C
	private TaskStatus[] executionStatus; // 0x60

	// Methods

	// RVA: 0x20E47C0 Offset: 0x20E48C1 VA: 0x20E47C0 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20E4830 Offset: 0x20E4931 VA: 0x20E4830 Slot: 39
	public override void OnChildStarted(int childIndex) { }

	// RVA: 0x20E4880 Offset: 0x20E4981 VA: 0x20E4880 Slot: 31
	public override bool CanRunParallelChildren() { }

	// RVA: 0x20E4890 Offset: 0x20E4991 VA: 0x20E4890 Slot: 32
	public override int CurrentChildIndex() { }

	// RVA: 0x20E48A0 Offset: 0x20E49A1 VA: 0x20E48A0 Slot: 33
	public override bool CanExecute() { }

	// RVA: 0x20E4900 Offset: 0x20E4A01 VA: 0x20E4900 Slot: 37
	public override void OnChildExecuted(int childIndex, TaskStatus childStatus) { }

	// RVA: 0x20E4940 Offset: 0x20E4A41 VA: 0x20E4940 Slot: 42
	public override void OnConditionalAbort(int childIndex) { }

	// RVA: 0x20E49A0 Offset: 0x20E4AA1 VA: 0x20E49A0 Slot: 40
	public override TaskStatus OverrideStatus(TaskStatus status) { }

	// RVA: 0x20E4A20 Offset: 0x20E4B21 VA: 0x20E4A20 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E4A80 Offset: 0x20E4B81 VA: 0x20E4A80
	public void .ctor() { }
}

