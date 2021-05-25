[TaskDescriptionAttribute] // RVA: 0x14B5C0 Offset: 0x14B6C1 VA: 0x14B5C0
[HelpURLAttribute] // RVA: 0x14B5C0 Offset: 0x14B6C1 VA: 0x14B5C0
[TaskIconAttribute] // RVA: 0x14B5C0 Offset: 0x14B6C1 VA: 0x14B5C0
public class SendEvent : Action // TypeDefIndex: 10932
{
	// Fields
	[TooltipAttribute] // RVA: 0x183230 Offset: 0x183331 VA: 0x183230
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x183270 Offset: 0x183371 VA: 0x183270
	public SharedString eventName; // 0x58
	[TooltipAttribute] // RVA: 0x1832B0 Offset: 0x1833B1 VA: 0x1832B0
	public SharedInt group; // 0x60
	[TooltipAttribute] // RVA: 0x1832F0 Offset: 0x1833F1 VA: 0x1832F0
	[SharedRequiredAttribute] // RVA: 0x1832F0 Offset: 0x1833F1 VA: 0x1832F0
	public SharedVariable argument1; // 0x68
	[TooltipAttribute] // RVA: 0x183340 Offset: 0x183441 VA: 0x183340
	[SharedRequiredAttribute] // RVA: 0x183340 Offset: 0x183441 VA: 0x183340
	public SharedVariable argument2; // 0x70
	[TooltipAttribute] // RVA: 0x183390 Offset: 0x183491 VA: 0x183390
	[SharedRequiredAttribute] // RVA: 0x183390 Offset: 0x183491 VA: 0x183390
	public SharedVariable argument3; // 0x78
	private BehaviorTree behaviorTree; // 0x80

	// Methods

	// RVA: 0x20E72D0 Offset: 0x20E73D1 VA: 0x20E72D0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x20E7470 Offset: 0x20E7571 VA: 0x20E7470 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E7690 Offset: 0x20E7791 VA: 0x20E7690 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E7790 Offset: 0x20E7891 VA: 0x20E7790
	public void .ctor() { }
}

