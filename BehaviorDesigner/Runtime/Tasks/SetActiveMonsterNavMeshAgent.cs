[TaskDescriptionAttribute] // RVA: 0x14AD30 Offset: 0x14AE31 VA: 0x14AD30
[TaskCategoryAttribute] // RVA: 0x14AD30 Offset: 0x14AE31 VA: 0x14AD30
[TaskIconAttribute] // RVA: 0x14AD30 Offset: 0x14AE31 VA: 0x14AD30
public class SetActiveMonsterNavMeshAgent : Action // TypeDefIndex: 10912
{
	// Fields
	public MonsterBehaviorController _MonsterBehaviorController; // 0x50
	public SharedBool UseNavMeshAgent; // 0x58
	public SharedBool IsActive; // 0x60

	// Properties
	public MonsterBehaviorController MonsterBehaviorController { get; }

	// Methods

	// RVA: 0x20E7870 Offset: 0x20E7971 VA: 0x20E7870
	public MonsterBehaviorController get_MonsterBehaviorController() { }

	// RVA: 0x20E7930 Offset: 0x20E7A31 VA: 0x20E7930 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E7B30 Offset: 0x20E7C31 VA: 0x20E7B30
	public void .ctor() { }
}

