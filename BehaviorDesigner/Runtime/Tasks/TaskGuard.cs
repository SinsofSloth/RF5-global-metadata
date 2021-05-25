[TaskDescriptionAttribute] // RVA: 0x14C230 Offset: 0x14C331 VA: 0x14C230
[TaskIconAttribute] // RVA: 0x14C230 Offset: 0x14C331 VA: 0x14C230
public class TaskGuard : Decorator // TypeDefIndex: 10964
{
	// Fields
	[TooltipAttribute] // RVA: 0x1840E0 Offset: 0x1841E1 VA: 0x1840E0
	public SharedInt maxTaskAccessCount; // 0x58
	[TooltipAttribute] // RVA: 0x184120 Offset: 0x184221 VA: 0x184120
	[LinkedTaskAttribute] // RVA: 0x184120 Offset: 0x184221 VA: 0x184120
	public TaskGuard[] linkedTaskGuards; // 0x60
	[TooltipAttribute] // RVA: 0x184170 Offset: 0x184271 VA: 0x184170
	public SharedBool waitUntilTaskAvailable; // 0x68
	private int executingTasks; // 0x70
	private bool executing; // 0x74

	// Methods

	// RVA: 0x20E9690 Offset: 0x20E9791 VA: 0x20E9690 Slot: 33
	public override bool CanExecute() { }

	// RVA: 0x20E9720 Offset: 0x20E9821 VA: 0x20E9720 Slot: 38
	public override void OnChildStarted() { }

	// RVA: 0x20E97D0 Offset: 0x20E98D1 VA: 0x20E97D0 Slot: 40
	public override TaskStatus OverrideStatus(TaskStatus status) { }

	// RVA: 0x20E97A0 Offset: 0x20E98A1 VA: 0x20E97A0
	public void taskExecuting(bool increase) { }

	// RVA: 0x20E9860 Offset: 0x20E9961 VA: 0x20E9860 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E98E0 Offset: 0x20E99E1 VA: 0x20E98E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E99B0 Offset: 0x20E9AB1 VA: 0x20E99B0
	public void .ctor() { }
}

