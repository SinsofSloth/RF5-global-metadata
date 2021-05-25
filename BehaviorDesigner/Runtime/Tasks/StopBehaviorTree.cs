[TaskDescriptionAttribute] // RVA: 0x14B6B0 Offset: 0x14B7B1 VA: 0x14B6B0
[TaskIconAttribute] // RVA: 0x14B6B0 Offset: 0x14B7B1 VA: 0x14B6B0
public class StopBehaviorTree : Action // TypeDefIndex: 10934
{
	// Fields
	[TooltipAttribute] // RVA: 0x1834E0 Offset: 0x1835E1 VA: 0x1834E0
	public SharedGameObject behaviorGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x183520 Offset: 0x183621 VA: 0x183520
	public SharedInt group; // 0x58
	[TooltipAttribute] // RVA: 0x183560 Offset: 0x183661 VA: 0x183560
	public SharedBool pauseBehavior; // 0x60
	private Behavior behavior; // 0x68

	// Methods

	// RVA: 0x20E9230 Offset: 0x20E9331 VA: 0x20E9230 Slot: 5
	public override void OnStart() { }

	// RVA: 0x20E93D0 Offset: 0x20E94D1 VA: 0x20E93D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E9490 Offset: 0x20E9591 VA: 0x20E9490 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E95D0 Offset: 0x20E96D1 VA: 0x20E95D0
	public void .ctor() { }
}

