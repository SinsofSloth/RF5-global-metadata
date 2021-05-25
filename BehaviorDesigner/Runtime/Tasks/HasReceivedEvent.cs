[TaskDescriptionAttribute] // RVA: 0x14BB30 Offset: 0x14BC31 VA: 0x14BB30
[TaskIconAttribute] // RVA: 0x14BB30 Offset: 0x14BC31 VA: 0x14BB30
public class HasReceivedEvent : Conditional // TypeDefIndex: 10946
{
	// Fields
	[TooltipAttribute] // RVA: 0x1837A0 Offset: 0x1838A1 VA: 0x1837A0
	public SharedString eventName; // 0x50
	[TooltipAttribute] // RVA: 0x1837E0 Offset: 0x1838E1 VA: 0x1837E0
	[SharedRequiredAttribute] // RVA: 0x1837E0 Offset: 0x1838E1 VA: 0x1837E0
	public SharedVariable storedValue1; // 0x58
	[TooltipAttribute] // RVA: 0x183830 Offset: 0x183931 VA: 0x183830
	[SharedRequiredAttribute] // RVA: 0x183830 Offset: 0x183931 VA: 0x183830
	public SharedVariable storedValue2; // 0x60
	[TooltipAttribute] // RVA: 0x183880 Offset: 0x183981 VA: 0x183880
	[SharedRequiredAttribute] // RVA: 0x183880 Offset: 0x183981 VA: 0x183880
	public SharedVariable storedValue3; // 0x68
	private bool eventReceived; // 0x70
	private bool registered; // 0x71

	// Methods

	// RVA: 0x20E08D0 Offset: 0x20E09D1 VA: 0x20E08D0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x20E0AE0 Offset: 0x20E0BE1 VA: 0x20E0AE0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E0B00 Offset: 0x20E0C01 VA: 0x20E0B00 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20E0D10 Offset: 0x20E0E11 VA: 0x20E0D10
	private void ReceivedEvent() { }

	// RVA: 0x20E0D20 Offset: 0x20E0E21 VA: 0x20E0D20
	private void ReceivedEvent(object arg1) { }

	// RVA: 0x20E0D80 Offset: 0x20E0E81 VA: 0x20E0D80
	private void ReceivedEvent(object arg1, object arg2) { }

	// RVA: 0x20E0E20 Offset: 0x20E0F21 VA: 0x20E0E20
	private void ReceivedEvent(object arg1, object arg2, object arg3) { }

	// RVA: 0x20E0EF0 Offset: 0x20E0FF1 VA: 0x20E0EF0 Slot: 15
	public override void OnBehaviorComplete() { }

	// RVA: 0x20E10F0 Offset: 0x20E11F1 VA: 0x20E10F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E11E0 Offset: 0x20E12E1 VA: 0x20E11E0
	public void .ctor() { }
}

