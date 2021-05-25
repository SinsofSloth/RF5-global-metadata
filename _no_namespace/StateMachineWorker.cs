public class StateMachineWorker : MonoBehaviour // TypeDefIndex: 6877
{
	// Fields
	private IStateMachine stateMachineInterface; // 0x18
	private Action tempUpdateMethod; // 0x20
	private Action tempFixedUpdateMethod; // 0x28
	private Action tempLateUpdateMethod; // 0x30

	// Methods

	// RVA: -1 Offset: -1
	public StateMachine<T> Initialize<T>(MonoBehaviour component, Enum startState, TransitionTables[] transitionTables, Dictionary<Enum, StateElement> stateElementTables) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281C100 Offset: 0x281C201 VA: 0x281C100
	|-StateMachineWorker.Initialize<Int32Enum>
	*/

	// RVA: 0x224A8D0 Offset: 0x224A9D1 VA: 0x224A8D0
	private void OnDestroy() { }

	// RVA: -1 Offset: -1
	private void ChangedState<T>(StateMachine<T> stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D8760 Offset: 0x21D8861 VA: 0x21D8760
	|-StateMachineWorker.ChangedState<Int32Enum>
	*/

	// RVA: 0x224A8E0 Offset: 0x224A9E1 VA: 0x224A8E0
	private void ResetUpdateMethod() { }

	// RVA: 0x224AD70 Offset: 0x224AE71 VA: 0x224AD70
	public void FixedUpdateMethod() { }

	// RVA: 0x224AFC0 Offset: 0x224B0C1 VA: 0x224AFC0
	public void UpdateMethod() { }

	// RVA: 0x224B210 Offset: 0x224B311 VA: 0x224B210
	public void LateUpdateMethod() { }

	// RVA: 0x224B460 Offset: 0x224B561 VA: 0x224B460
	public static void DoNothing() { }

	// RVA: 0x224B470 Offset: 0x224B571 VA: 0x224B470
	public static IEnumerator DoNothingCoroutine() { }

	// RVA: 0x224B480 Offset: 0x224B581 VA: 0x224B480
	public static void DoNothingCollision(Collision other) { }

	// RVA: 0x224B490 Offset: 0x224B591 VA: 0x224B490
	public void .ctor() { }
}

