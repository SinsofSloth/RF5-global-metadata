public class MonsterBehaviorController.BehaviorStateMachine // TypeDefIndex: 8074
{
	// Fields
	private int NextStateType; // 0x10
	private MonsterBehaviorController.BehaviorStateMachine.BehaviorState CurrentState; // 0x18
	private Dictionary<int, MonsterBehaviorController.BehaviorStateMachine.BehaviorState> States; // 0x20

	// Methods

	// RVA: 0x21614D0 Offset: 0x21615D1 VA: 0x21614D0
	public int StateCount() { }

	// RVA: 0x2161530 Offset: 0x2161631 VA: 0x2161530
	public void Init() { }

	// RVA: 0x2161550 Offset: 0x2161651 VA: 0x2161550
	public TaskStatus Update() { }

	// RVA: 0x21615D0 Offset: 0x21616D1 VA: 0x21615D0
	public void End() { }

	// RVA: 0x21615F0 Offset: 0x21616F1 VA: 0x21615F0
	public void AddState(int type, Action init, Func<TaskStatus> update, Action end) { }

	// RVA: 0x2161780 Offset: 0x2161881 VA: 0x2161780
	public void SetNextStateType(int type) { }

	// RVA: 0x2161790 Offset: 0x2161891 VA: 0x2161790
	public void ChangeState() { }

	// RVA: 0x2161860 Offset: 0x2161961 VA: 0x2161860
	public void .ctor() { }
}

