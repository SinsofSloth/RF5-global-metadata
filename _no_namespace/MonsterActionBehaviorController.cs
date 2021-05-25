public class MonsterActionBehaviorController : ActionBehaviorController // TypeDefIndex: 6139
{
	// Fields
	public MonsterBehaviorController MonsterOwner; // 0x18
	public SharedMovementBehaviorType SharedMovementBehaviorType; // 0x20
	public SharedFloat MaxWaitInterval; // 0x28
	public SharedFloat MinWaitInterval; // 0x30
	public SharedFloat MoveAroundRange; // 0x38
	public SharedFloat MoveAroundAngle; // 0x40
	public SharedBool IsReleseEyes; // 0x48
	public SharedFloat LeaveRange; // 0x50
	public SharedFloat CloseRange; // 0x58
	public SharedFloat MoveSpeedScale; // 0x60
	public SharedFloat TakebehindRange; // 0x68
	public SharedFloat JumpTime; // 0x70
	public SharedVector3 JumpArrivePosition; // 0x78
	public SharedString CrossFadeAnimatorStateName; // 0x80
	public SharedBool OnlyUseMaxRange; // 0x88
	public SharedVector3 MovePosition; // 0x90
	public SharedVector3 WarpPosition; // 0x98
	private Dictionary<MonsterActionBehaviorDataID, List<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter>> ActionBehaviorCodeDic; // 0xA0
	public List<ActionBehaviorCommandBase> CurrentActionBehaviorCommandList; // 0xA8
	public List<MonsterActionBehaviorType> CurrentMonsterActionBehaviorTypeList; // 0xB0
	private List<MonsterActionBehaviorController.ExecuteMonsterActionBehaviorParameter> ExecuteMonsterActionBehaviorList; // 0xB8
	private MonsterActionBehaviorDataID CurrentActionBehaviorDataID; // 0xC0

	// Methods

	// RVA: 0x1CC3C50 Offset: 0x1CC3D51 VA: 0x1CC3C50
	private MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter CreateMonsterActionBehaviorCommandParameter(ActionBehaviorCommandInformation command) { }

	// RVA: 0x1CC40B0 Offset: 0x1CC41B1 VA: 0x1CC40B0
	private List<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter> CreateMonsterActionBehaviorCommandParameterList(MonsterActionBehaviorDataID id) { }

	// RVA: 0x1CC43D0 Offset: 0x1CC44D1 VA: 0x1CC43D0
	private Func<bool> GetCanAction(MonsterActionBehaviorData param) { }

	// RVA: 0x1CC46B0 Offset: 0x1CC47B1 VA: 0x1CC46B0
	public void .ctor(MonsterBehaviorController owner) { }

	// RVA: 0x1CC4780 Offset: 0x1CC4881 VA: 0x1CC4780
	public void Setup() { }

	// RVA: 0x1CC5210 Offset: 0x1CC5311 VA: 0x1CC5210
	public void SetExecuteFlag(bool isExecute) { }

	// RVA: 0x1CC52B0 Offset: 0x1CC53B1 VA: 0x1CC52B0
	public void SelectMonsterAction() { }

	// RVA: 0x1CC5890 Offset: 0x1CC5991 VA: 0x1CC5890
	public List<MonsterActionBehaviorType> GetMonsterBehaviorList() { }

	// RVA: 0x1CC58A0 Offset: 0x1CC59A1 VA: 0x1CC58A0
	public void Execute(int index) { }
}

