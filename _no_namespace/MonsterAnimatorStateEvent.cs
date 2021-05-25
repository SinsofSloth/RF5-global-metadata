public class MonsterAnimatorStateEvent : StateMachineBehaviour // TypeDefIndex: 6339
{
	// Fields
	[SerializeField] // RVA: 0x15C3C0 Offset: 0x15C4C1 VA: 0x15C3C0
	public MonsterAnimatorStateType MonsterAnimatorStateType; // 0x18
	private List<MonsterAnimatorStateEvent.NormalizeTimeEvent> NormalizeTimeEventList; // 0x20
	private MonsterControllerBase MonsterControllerBase; // 0x28
	private bool CanInvoke; // 0x30

	// Methods

	// RVA: 0x1CC86D0 Offset: 0x1CC87D1 VA: 0x1CC86D0
	public void SetOwner(MonsterControllerBase monsterControllerBase) { }

	// RVA: 0x1CC86E0 Offset: 0x1CC87E1 VA: 0x1CC86E0
	public void AddEvent(float normalizeTime, Action action) { }

	// RVA: 0x1CC87B0 Offset: 0x1CC88B1 VA: 0x1CC87B0
	private void InvokeNormalizeTimeEvent(MonsterAnimatorStateEvent.NormalizeTimeEvent normalizeTimeEvent) { }

	// RVA: 0x1CC8860 Offset: 0x1CC8961 VA: 0x1CC8860 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1CC89B0 Offset: 0x1CC8AB1 VA: 0x1CC89B0 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1CC8B00 Offset: 0x1CC8C01 VA: 0x1CC8B00 Slot: 6
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1CC8B10 Offset: 0x1CC8C11 VA: 0x1CC8B10
	public void .ctor() { }
}

