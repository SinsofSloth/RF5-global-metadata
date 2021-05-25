[TaskDescriptionAttribute] // RVA: 0x14BFF0 Offset: 0x14C0F1 VA: 0x14BFF0
[TaskIconAttribute] // RVA: 0x14BFF0 Offset: 0x14C0F1 VA: 0x14BFF0
public class ConditionalEvaluator : Decorator // TypeDefIndex: 10958
{
	// Fields
	[TooltipAttribute] // RVA: 0x183F90 Offset: 0x184091 VA: 0x183F90
	public SharedBool reevaluate; // 0x58
	[InspectTaskAttribute] // RVA: 0x183FD0 Offset: 0x1840D1 VA: 0x183FD0
	[TooltipAttribute] // RVA: 0x183FD0 Offset: 0x1840D1 VA: 0x183FD0
	public Conditional conditionalTask; // 0x60
	private TaskStatus executionStatus; // 0x68
	private bool checkConditionalTask; // 0x6C
	private bool conditionalTaskFailed; // 0x6D

	// Methods

	// RVA: 0x20DDC40 Offset: 0x20DDD41 VA: 0x20DDC40 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20DDCC0 Offset: 0x20DDDC1 VA: 0x20DDCC0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x20DDCE0 Offset: 0x20DDDE1 VA: 0x20DDCE0 Slot: 33
	public override bool CanExecute() { }

	// RVA: 0x20DDD50 Offset: 0x20DDE51 VA: 0x20DDD50 Slot: 35
	public override bool CanReevaluate() { }

	// RVA: 0x20DDDB0 Offset: 0x20DDEB1 VA: 0x20DDDB0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DDE00 Offset: 0x20DDF01 VA: 0x20DDE00 Slot: 36
	public override void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x20DDE10 Offset: 0x20DDF11 VA: 0x20DDE10 Slot: 41
	public override TaskStatus OverrideStatus() { }

	// RVA: 0x20DDE20 Offset: 0x20DDF21 VA: 0x20DDE20 Slot: 40
	public override TaskStatus OverrideStatus(TaskStatus status) { }

	// RVA: 0x20DDE30 Offset: 0x20DDF31 VA: 0x20DDE30 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20DDE60 Offset: 0x20DDF61 VA: 0x20DDE60 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20DDE70 Offset: 0x20DDF71 VA: 0x20DDE70
	public void .ctor() { }
}

