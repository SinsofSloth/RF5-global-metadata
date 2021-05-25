[Serializable]
public abstract class AnimatorStateEvent<T> : StateMachineBehaviour // TypeDefIndex: 6325
{
	// Fields
	[SerializeField] // RVA: 0x15C1F0 Offset: 0x15C2F1 VA: 0x15C1F0
	public T AnimatorStateType; // 0x0
	private List<AnimatorStateEvent.NormalizeTimeEvent<T>> NormalizeTimeEventList; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void AddEvent(float normalizeTime, UnityAction action) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract bool IsNone(T value) { }

	// RVA: -1 Offset: -1
	private void EachNormalizeTimeEvent(Action<AnimatorStateEvent.NormalizeTimeEvent<T>> action) { }

	// RVA: -1 Offset: -1
	private void CreateHash() { }

	// RVA: -1 Offset: -1 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: -1 Offset: -1 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: -1 Offset: -1 Slot: 6
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: -1 Offset: -1
	protected void .ctor() { }
}

