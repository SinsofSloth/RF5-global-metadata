public abstract class Composite : ParentTask // TypeDefIndex: 4707
{
	// Fields
	[TooltipAttribute] // RVA: 0x12D760 Offset: 0x12D861 VA: 0x12D760
	[SerializeField] // RVA: 0x12D760 Offset: 0x12D861 VA: 0x12D760
	protected AbortType abortType; // 0x58

	// Properties
	public AbortType AbortType { get; }

	// Methods

	// RVA: 0x1B23D20 Offset: 0x1B23E21 VA: 0x1B23D20
	protected void .ctor() { }

	// RVA: 0x1B23E20 Offset: 0x1B23F21 VA: 0x1B23E20
	public AbortType get_AbortType() { }

	// RVA: 0x1B23E30 Offset: 0x1B23F31 VA: 0x1B23E30 Slot: 43
	public virtual bool OnReevaluationStarted() { }

	// RVA: 0x1B23E40 Offset: 0x1B23F41 VA: 0x1B23E40 Slot: 44
	public virtual void OnReevaluationEnded(TaskStatus status) { }
}

