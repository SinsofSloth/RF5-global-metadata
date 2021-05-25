[TaskDescriptionAttribute] // RVA: 0x14A8D0 Offset: 0x14A9D1 VA: 0x14A8D0
[TaskCategoryAttribute] // RVA: 0x14A8D0 Offset: 0x14A9D1 VA: 0x14A8D0
[TaskIconAttribute] // RVA: 0x14A8D0 Offset: 0x14A9D1 VA: 0x14A8D0
public class EnemySetPatrolParameter : Action // TypeDefIndex: 10902
{
	// Fields
	private EnemyBehaviorController Controller; // 0x50
	public SharedEnemyBehaviorTreeState SharedEnemyBehaviorTreeState; // 0x58
	public SharedMovementBehaviorType ReturnSharedMovementBehaviorType; // 0x60
	public SharedFloat ReturnMoveSpeedScale; // 0x68
	public SharedFloat ReturnMoveTime; // 0x70

	// Methods

	// RVA: 0x20DDE80 Offset: 0x20DDF81 VA: 0x20DDE80 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20DDF50 Offset: 0x20DE051 VA: 0x20DDF50 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DE070 Offset: 0x20DE171 VA: 0x20DE070 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20DE0C0 Offset: 0x20DE1C1 VA: 0x20DE0C0
	public void .ctor() { }
}

