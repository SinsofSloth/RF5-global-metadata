[TaskDescriptionAttribute] // RVA: 0x14B560 Offset: 0x14B661 VA: 0x14B560
[TaskIconAttribute] // RVA: 0x14B560 Offset: 0x14B661 VA: 0x14B560
public class RestartBehaviorTree : Action // TypeDefIndex: 10931
{
	// Fields
	[TooltipAttribute] // RVA: 0x1831B0 Offset: 0x1832B1 VA: 0x1831B0
	public SharedGameObject behaviorGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1831F0 Offset: 0x1832F1 VA: 0x1831F0
	public SharedInt group; // 0x58
	private Behavior behavior; // 0x60

	// Methods

	// RVA: 0x20E6BE0 Offset: 0x20E6CE1 VA: 0x20E6BE0 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20E6D80 Offset: 0x20E6E81 VA: 0x20E6D80 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E6E30 Offset: 0x20E6F31 VA: 0x20E6E30 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E6E40 Offset: 0x20E6F41 VA: 0x20E6E40
	public void .ctor() { }
}

