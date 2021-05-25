public class StateMachine<T> : IStateMachine // TypeDefIndex: 6873
{
	// Fields
	private Action<StateMachine<T>> Changed; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x15FE50 Offset: 0x15FF51 VA: 0x15FE50
	private StateElement <CurrentState>k__BackingField; // 0x0
	private StateElement prevState; // 0x0
	private Enum transitionCommand; // 0x0
	private Dictionary<Enum, StateElement> ElementMappings; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x15FE60 Offset: 0x15FF61 VA: 0x15FE60
	private bool <IsInTransition>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x15FE70 Offset: 0x15FF71 VA: 0x15FE70
	private StateMachineWorker <Worker>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x15FE80 Offset: 0x15FF81 VA: 0x15FE80
	private MonoBehaviour <Component>k__BackingField; // 0x0
	private IEnumerator currentTransition; // 0x0
	private IEnumerator exitRoutine; // 0x0
	private IEnumerator enterRoutine; // 0x0
	private IEnumerator queuedChange; // 0x0
	private Action Pause_Enter; // 0x0
	private Action Pause_Exit; // 0x0
	private bool _IsPause; // 0x0

	// Properties
	public StateElement CurrentState { get; set; }
	public bool IsInTransition { get; set; }
	public StateMachineWorker Worker { get; set; }
	public MonoBehaviour Component { get; set; }
	public bool IsPause { get; set; }
	public Enum PrevState { get; }
	public Enum TransitionCommand { get; }
	public Enum State { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19D940 Offset: 0x19DA41 VA: 0x19D940
	// RVA: -1 Offset: -1 Slot: 5
	public StateElement get_CurrentState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28923D0 Offset: 0x28924D1 VA: 0x28923D0
	|-StateMachine<Int32Enum>.get_CurrentState
	*/

	[CompilerGeneratedAttribute] // RVA: 0x19D950 Offset: 0x19DA51 VA: 0x19D950
	// RVA: -1 Offset: -1
	private void set_CurrentState(StateElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28923E0 Offset: 0x28924E1 VA: 0x28923E0
	|-StateMachine<Int32Enum>.set_CurrentState
	*/

	[CompilerGeneratedAttribute] // RVA: 0x19D960 Offset: 0x19DA61 VA: 0x19D960
	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsInTransition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28923F0 Offset: 0x28924F1 VA: 0x28923F0
	|-StateMachine<Int32Enum>.get_IsInTransition
	*/

	[CompilerGeneratedAttribute] // RVA: 0x19D970 Offset: 0x19DA71 VA: 0x19D970
	// RVA: -1 Offset: -1
	private void set_IsInTransition(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892400 Offset: 0x2892501 VA: 0x2892400
	|-StateMachine<Int32Enum>.set_IsInTransition
	*/

	[CompilerGeneratedAttribute] // RVA: 0x19D980 Offset: 0x19DA81 VA: 0x19D980
	// RVA: -1 Offset: -1
	public StateMachineWorker get_Worker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892410 Offset: 0x2892511 VA: 0x2892410
	|-StateMachine<Int32Enum>.get_Worker
	*/

	[CompilerGeneratedAttribute] // RVA: 0x19D990 Offset: 0x19DA91 VA: 0x19D990
	// RVA: -1 Offset: -1
	private void set_Worker(StateMachineWorker value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892420 Offset: 0x2892521 VA: 0x2892420
	|-StateMachine<Int32Enum>.set_Worker
	*/

	[CompilerGeneratedAttribute] // RVA: 0x19D9A0 Offset: 0x19DAA1 VA: 0x19D9A0
	// RVA: -1 Offset: -1 Slot: 4
	public MonoBehaviour get_Component() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892430 Offset: 0x2892531 VA: 0x2892430
	|-StateMachine<Int32Enum>.get_Component
	*/

	[CompilerGeneratedAttribute] // RVA: 0x19D9B0 Offset: 0x19DAB1 VA: 0x19D9B0
	// RVA: -1 Offset: -1
	private void set_Component(MonoBehaviour value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892440 Offset: 0x2892541 VA: 0x2892440
	|-StateMachine<Int32Enum>.set_Component
	*/

	// RVA: -1 Offset: -1
	public void set_IsPause(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892450 Offset: 0x2892551 VA: 0x2892450
	|-StateMachine<Int32Enum>.set_IsPause
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool get_IsPause() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892570 Offset: 0x2892671 VA: 0x2892570
	|-StateMachine<Int32Enum>.get_IsPause
	*/

	// RVA: -1 Offset: -1
	public void .ctor(StateMachineWorker worker, MonoBehaviour component, Enum StartState, TransitionTables[] TransitionsMapping, Action<StateMachine<T>> ChangedEvent, Dictionary<Enum, StateElement> stateElementTables) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892580 Offset: 0x2892681 VA: 0x2892580
	|-StateMachine<Int32Enum>..ctor
	*/

	// RVA: -1 Offset: -1
	private V CreateDelegate<V>(MethodInfo method, object target) { }

	// RVA: -1 Offset: -1
	public bool ChangeState(Enum Command) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28928D0 Offset: 0x28929D1 VA: 0x28928D0
	|-StateMachine<HoldItemController.HoldItemState>.ChangeState
	|-StateMachine<OnGroundItem.OnGroundItemState>.ChangeState
	|-StateMachine<Int32Enum>.ChangeState
	*/

	// RVA: -1 Offset: -1
	private void ChangeState(StateElement nextState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892AB0 Offset: 0x2892BB1 VA: 0x2892AB0
	|-StateMachine<Int32Enum>.ChangeState
	*/

	[IteratorStateMachineAttribute] // RVA: 0x19D9C0 Offset: 0x19DAC1 VA: 0x19D9C0
	// RVA: -1 Offset: -1
	private IEnumerator ChangeToNewStateRoutine(StateElement newState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892CD0 Offset: 0x2892DD1 VA: 0x2892CD0
	|-StateMachine<Int32Enum>.ChangeToNewStateRoutine
	*/

	// RVA: -1 Offset: -1
	public Enum get_PrevState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892D70 Offset: 0x2892E71 VA: 0x2892D70
	|-StateMachine<Int32Enum>.get_PrevState
	*/

	// RVA: -1 Offset: -1
	public Enum get_TransitionCommand() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892D90 Offset: 0x2892E91 VA: 0x2892D90
	|-StateMachine<Int32Enum>.get_TransitionCommand
	*/

	// RVA: -1 Offset: -1
	public Enum get_State() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892DA0 Offset: 0x2892EA1 VA: 0x2892DA0
	|-StateMachine<HoldItemController.HoldItemState>.get_State
	|-StateMachine<OnGroundItem.OnGroundItemState>.get_State
	|-StateMachine<Int32Enum>.get_State
	*/

	// RVA: -1 Offset: -1
	public static StateMachine<T> Initialize(MonoBehaviour component, Enum startState, TransitionTables[] transitionTables, Dictionary<Enum, StateElement> stateElementTables) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2892DE0 Offset: 0x2892EE1 VA: 0x2892DE0
	|-StateMachine<HoldItemController.HoldItemState>.Initialize
	|-StateMachine<OnGroundItem.OnGroundItemState>.Initialize
	|-StateMachine<Int32Enum>.Initialize
	*/
}

