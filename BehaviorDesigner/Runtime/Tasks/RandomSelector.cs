[TaskDescriptionAttribute] // RVA: 0x14B8F0 Offset: 0x14B9F1 VA: 0x14B8F0
[TaskIconAttribute] // RVA: 0x14B8F0 Offset: 0x14B9F1 VA: 0x14B8F0
public class RandomSelector : Composite // TypeDefIndex: 10940
{
	// Fields
	[TooltipAttribute] // RVA: 0x1836A0 Offset: 0x1837A1 VA: 0x1836A0
	public int seed; // 0x5C
	[TooltipAttribute] // RVA: 0x1836E0 Offset: 0x1837E1 VA: 0x1836E0
	public bool useSeed; // 0x60
	private List<int> childIndexList; // 0x68
	private Stack<int> childrenExecutionOrder; // 0x70
	private TaskStatus executionStatus; // 0x78

	// Methods

	// RVA: 0x20E5EC0 Offset: 0x20E5FC1 VA: 0x20E5EC0 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20E5F80 Offset: 0x20E6081 VA: 0x20E5F80 Slot: 5
	public override void OnStart() { }

	// RVA: 0x20E60D0 Offset: 0x20E61D1 VA: 0x20E60D0 Slot: 32
	public override int CurrentChildIndex() { }

	// RVA: 0x20E6130 Offset: 0x20E6231 VA: 0x20E6130 Slot: 33
	public override bool CanExecute() { }

	// RVA: 0x20E61B0 Offset: 0x20E62B1 VA: 0x20E61B0 Slot: 36
	public override void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x20E6230 Offset: 0x20E6331 VA: 0x20E6230 Slot: 42
	public override void OnConditionalAbort(int childIndex) { }

	// RVA: 0x20E62A0 Offset: 0x20E63A1 VA: 0x20E62A0 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E6300 Offset: 0x20E6401 VA: 0x20E6300 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E5F90 Offset: 0x20E6091 VA: 0x20E5F90
	private void ShuffleChilden() { }

	// RVA: 0x20E6310 Offset: 0x20E6411 VA: 0x20E6310
	public void .ctor() { }
}

