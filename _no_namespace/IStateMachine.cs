public interface IStateMachine // TypeDefIndex: 6872
{
	// Properties
	public abstract MonoBehaviour Component { get; }
	public abstract StateElement CurrentState { get; }
	public abstract bool IsInTransition { get; }
	public abstract bool IsPause { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MonoBehaviour get_Component() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract StateElement get_CurrentState() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsInTransition() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsPause() { }
}

