public class AIInput : CharacterInput // TypeDefIndex: 6675
{
	// Fields
	private const float MaxNavMeshSamplePositionDistance = 10;
	private const float SubNavMeshSamplePositionDistance = 1;
	[CompilerGeneratedAttribute] // RVA: 0x15EB40 Offset: 0x15EC41 VA: 0x15EB40
	private Vector3 <LatestEnableNavimeshPosition>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15EB50 Offset: 0x15EC51 VA: 0x15EB50
	private SearchCharacterController <SearchCharacterController>k__BackingField; // 0x30
	[SerializeField] // RVA: 0x15EB60 Offset: 0x15EC61 VA: 0x15EB60
	protected BehaviorTree BehaviorTree; // 0x38
	private bool IsEndFirstLoadBehavior; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x15EB70 Offset: 0x15EC71 VA: 0x15EB70
	private SharedBool <IsStopBehavior>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x15EB80 Offset: 0x15EC81 VA: 0x15EB80
	private SharedFloat <AngularSpeed>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x15EB90 Offset: 0x15EC91 VA: 0x15EB90
	private SharedFloat <RotationDelta>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x15EBA0 Offset: 0x15ECA1 VA: 0x15EBA0
	private SharedFloat <ArriveDistance>k__BackingField; // 0x60
	public bool IsSetup; // 0x68
	protected int LockStopBehaviorCounter; // 0x6C
	private List<SharedVariable> SharedVariableList; // 0x70

	// Properties
	public NavMeshAgent NavMeshAgent { get; }
	public Vector3 LatestEnableNavimeshPosition { get; set; }
	public virtual SearchCharacterController SearchCharacterController { get; set; }
	public SharedBool IsStopBehavior { get; set; }
	public SharedFloat AngularSpeed { get; set; }
	public SharedFloat RotationDelta { get; set; }
	public SharedFloat ArriveDistance { get; set; }
	public Character ControllCharacter { get; }
	protected bool IsLockStopBehavior { get; }

	// Methods

	// RVA: 0x1E62EB0 Offset: 0x1E62FB1 VA: 0x1E62EB0
	public NavMeshAgent get_NavMeshAgent() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C790 Offset: 0x19C891 VA: 0x19C790
	// RVA: 0x1E62ED0 Offset: 0x1E62FD1 VA: 0x1E62ED0
	public Vector3 get_LatestEnableNavimeshPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C7A0 Offset: 0x19C8A1 VA: 0x19C7A0
	// RVA: 0x1E62EE0 Offset: 0x1E62FE1 VA: 0x1E62EE0
	protected void set_LatestEnableNavimeshPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C7B0 Offset: 0x19C8B1 VA: 0x19C7B0
	// RVA: 0x1E62EF0 Offset: 0x1E62FF1 VA: 0x1E62EF0 Slot: 7
	public virtual SearchCharacterController get_SearchCharacterController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C7C0 Offset: 0x19C8C1 VA: 0x19C7C0
	// RVA: 0x1E62F00 Offset: 0x1E63001 VA: 0x1E62F00 Slot: 8
	protected virtual void set_SearchCharacterController(SearchCharacterController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C7D0 Offset: 0x19C8D1 VA: 0x19C7D0
	// RVA: 0x1E62F10 Offset: 0x1E63011 VA: 0x1E62F10
	public SharedBool get_IsStopBehavior() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C7E0 Offset: 0x19C8E1 VA: 0x19C7E0
	// RVA: 0x1E62F20 Offset: 0x1E63021 VA: 0x1E62F20
	protected void set_IsStopBehavior(SharedBool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C7F0 Offset: 0x19C8F1 VA: 0x19C7F0
	// RVA: 0x1E62F30 Offset: 0x1E63031 VA: 0x1E62F30
	public SharedFloat get_AngularSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C800 Offset: 0x19C901 VA: 0x19C800
	// RVA: 0x1E62F40 Offset: 0x1E63041 VA: 0x1E62F40
	protected void set_AngularSpeed(SharedFloat value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C810 Offset: 0x19C911 VA: 0x19C810
	// RVA: 0x1E62F50 Offset: 0x1E63051 VA: 0x1E62F50
	public SharedFloat get_RotationDelta() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C820 Offset: 0x19C921 VA: 0x19C820
	// RVA: 0x1E62F60 Offset: 0x1E63061 VA: 0x1E62F60
	protected void set_RotationDelta(SharedFloat value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C830 Offset: 0x19C931 VA: 0x19C830
	// RVA: 0x1E62F70 Offset: 0x1E63071 VA: 0x1E62F70
	public SharedFloat get_ArriveDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C840 Offset: 0x19C941 VA: 0x19C840
	// RVA: 0x1E62F80 Offset: 0x1E63081 VA: 0x1E62F80
	protected void set_ArriveDistance(SharedFloat value) { }

	// RVA: 0x1E62F90 Offset: 0x1E63091 VA: 0x1E62F90
	public Character get_ControllCharacter() { }

	// RVA: 0x1E62FA0 Offset: 0x1E630A1 VA: 0x1E62FA0
	protected bool get_IsLockStopBehavior() { }

	// RVA: 0x1E62FB0 Offset: 0x1E630B1 VA: 0x1E62FB0 Slot: 9
	protected virtual void Update() { }

	// RVA: 0x1E63010 Offset: 0x1E63111 VA: 0x1E63010
	public void Setup() { }

	// RVA: 0x1E63380 Offset: 0x1E63481 VA: 0x1E63380 Slot: 10
	protected virtual void OnSetup() { }

	// RVA: 0x1E63390 Offset: 0x1E63491 VA: 0x1E63390
	public void Relese() { }

	// RVA: 0x1E634C0 Offset: 0x1E635C1 VA: 0x1E634C0 Slot: 11
	protected virtual void OnRelese() { }

	// RVA: 0x1E634D0 Offset: 0x1E635D1 VA: 0x1E634D0 Slot: 6
	public override void SetCharacter(Character character) { }

	// RVA: 0x1E634E0 Offset: 0x1E635E1 VA: 0x1E634E0 Slot: 12
	public virtual void SetupNavMeshAgent(Vector3 createPosition) { }

	// RVA: 0x1E637E0 Offset: 0x1E638E1 VA: 0x1E637E0 Slot: 13
	public virtual void OnNotReturnNavMesh() { }

	// RVA: 0x1E637F0 Offset: 0x1E638F1 VA: 0x1E637F0
	public void SetEnableNavMesh(bool isEnable) { }

	// RVA: 0x1E639D0 Offset: 0x1E63AD1 VA: 0x1E639D0 Slot: 14
	public virtual float GetMoveSpeedScale(AIMoveSpeedType moveType) { }

	// RVA: 0x1E639F0 Offset: 0x1E63AF1 VA: 0x1E639F0 Slot: 15
	public virtual void SetupSearchCharacterController() { }

	// RVA: 0x1E63460 Offset: 0x1E63561 VA: 0x1E63460
	public void ClearSearchCharacterController() { }

	// RVA: 0x1E63B20 Offset: 0x1E63C21 VA: 0x1E63B20 Slot: 16
	protected virtual void OnSetupSearchCharacterController() { }

	// RVA: 0x1E63B30 Offset: 0x1E63C31 VA: 0x1E63B30 Slot: 17
	public virtual void ResetSearchCharacterController() { }

	// RVA: 0x1E63B90 Offset: 0x1E63C91 VA: 0x1E63B90
	private void OnStartInitBehaviorFirst(Behavior behavior) { }

	// RVA: 0x1E63C50 Offset: 0x1E63D51 VA: 0x1E63C50
	public void SetupBehavior(ExternalBehavior behavior, Action<BehaviorTree> callBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x19C850 Offset: 0x19C951 VA: 0x19C850
	// RVA: 0x1E63C80 Offset: 0x1E63D81 VA: 0x1E63C80
	public IEnumerator SetupAsyncBehavior(ExternalBehavior behavior, Action<BehaviorTree> callBack) { }

	// RVA: 0x1E63D60 Offset: 0x1E63E61 VA: 0x1E63D60
	private void OnStartBehaviorFirst(Behavior behavior) { }

	// RVA: 0x1E63E00 Offset: 0x1E63F01 VA: 0x1E63E00 Slot: 18
	public virtual void ClearBehavior() { }

	// RVA: 0x1E63EC0 Offset: 0x1E63FC1 VA: 0x1E63EC0
	private void SetupVariableBehaviorParameter() { }

	// RVA: 0x1E63F00 Offset: 0x1E64001 VA: 0x1E63F00
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x1E63090 Offset: 0x1E63191 VA: 0x1E63090
	protected void GetVariableBehaviorParameter() { }

	// RVA: 0x1E63FC0 Offset: 0x1E640C1 VA: 0x1E63FC0 Slot: 19
	protected virtual void OnGetVariableBehaviorParameter() { }

	// RVA: 0x1E63FD0 Offset: 0x1E640D1 VA: 0x1E63FD0
	public void IncrementLockStopBehavior() { }

	// RVA: 0x1E63FE0 Offset: 0x1E640E1 VA: 0x1E63FE0
	public void DecrementLockStopBehavior() { }

	// RVA: 0x1E63FF0 Offset: 0x1E640F1 VA: 0x1E63FF0 Slot: 20
	public virtual void SetStopBehavior(bool isStopBehavior) { }

	// RVA: 0x1E63310 Offset: 0x1E63411 VA: 0x1E63310
	public void ResetBehavior(bool isEnable = True) { }

	// RVA: 0x1E640F0 Offset: 0x1E641F1 VA: 0x1E640F0
	public void RestartBehavior() { }

	// RVA: 0x1E641F0 Offset: 0x1E642F1 VA: 0x1E641F0
	private void EnableBehavior(bool isEnable = True) { }

	// RVA: 0x1E64220 Offset: 0x1E64321 VA: 0x1E64220
	public void SetBehaviorExecutionStatus(TaskStatus status) { }

	// RVA: 0x1E64250 Offset: 0x1E64351 VA: 0x1E64250 Slot: 21
	protected virtual void OnDrawGizmosSelected() { }

	// RVA: 0x1E64260 Offset: 0x1E64361 VA: 0x1E64260
	public void .ctor() { }
}

