[TaskDescriptionAttribute] // RVA: 0x14BA70 Offset: 0x14BB71 VA: 0x14BA70
[TaskIconAttribute] // RVA: 0x14BA70 Offset: 0x14BB71 VA: 0x14BA70
public class Sequence : Composite // TypeDefIndex: 10944
{
	// Fields
	private int currentChildIndex; // 0x5C
	private TaskStatus executionStatus; // 0x60

	// Methods

	// RVA: 0x20E77A0 Offset: 0x20E78A1 VA: 0x20E77A0 Slot: 32
	public override int CurrentChildIndex() { }

	// RVA: 0x20E77B0 Offset: 0x20E78B1 VA: 0x20E77B0 Slot: 33
	public override bool CanExecute() { }

	// RVA: 0x20E7830 Offset: 0x20E7931 VA: 0x20E7830 Slot: 36
	public override void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x20E7840 Offset: 0x20E7941 VA: 0x20E7840 Slot: 42
	public override void OnConditionalAbort(int childIndex) { }

	// RVA: 0x20E7850 Offset: 0x20E7951 VA: 0x20E7850 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E7860 Offset: 0x20E7961 VA: 0x20E7860
	public void .ctor() { }
}

