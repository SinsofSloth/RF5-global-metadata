[TaskCategoryAttribute] // RVA: 0x1456D0 Offset: 0x1457D1 VA: 0x1456D0
public class ChangeCautionSerchCharacterParameter : Action // TypeDefIndex: 6396
{
	// Fields
	public SharedInt SearchType; // 0x50
	public SharedBool IsCaution; // 0x58
	private SearchCharacterController.SearchParameter BaseParameter; // 0x60
	private MonsterBehaviorController MonsterBehaviorController; // 0x68

	// Properties
	private SearchCharacterController SearchCharacterController { get; }

	// Methods

	// RVA: 0x1D3FE60 Offset: 0x1D3FF61 VA: 0x1D3FE60
	private SearchCharacterController get_SearchCharacterController() { }

	// RVA: 0x1D3FE80 Offset: 0x1D3FF81 VA: 0x1D3FE80 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x1D3FEF0 Offset: 0x1D3FFF1 VA: 0x1D3FEF0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x1D40000 Offset: 0x1D40101 VA: 0x1D40000 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x1D40130 Offset: 0x1D40231 VA: 0x1D40130
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B030 Offset: 0x19B131 VA: 0x19B030
	// RVA: 0x1D40140 Offset: 0x1D40241 VA: 0x1D40140
	private bool <OnStart>b__7_0(MonsterSearchRangePair arrayData) { }
}

