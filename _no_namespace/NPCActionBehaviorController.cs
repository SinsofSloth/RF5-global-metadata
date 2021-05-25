public class NPCActionBehaviorController : ActionBehaviorController // TypeDefIndex: 6146
{
	// Fields
	public PartnerNPCBehaviorController NPCOwner; // 0x18
	public List<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter> ExecuteNPCActionBehaviorList; // 0x20
	public NPCActionBehaviorDataID CurrentSelectActionBehaviorDataID; // 0x28
	public int CurrentSelectBehaviorParameterIndex; // 0x2C
	private Dictionary<NPCActionBehaviorDataID, List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam>> ActionBehaviorCodeDic; // 0x30
	private NPCActionData NotSelectData; // 0x38
	private List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam> NotSelectCode; // 0x70
	public List<ActionBehaviorCommandBase> CurrentActionBehaviorCommandList; // 0x78
	public List<PartnerNPCActionBehaviorType> CurrentActionBehaviorTypeList; // 0x80
	private int MaxOrder; // 0x88
	public SharedGameObject Target; // 0x90
	private SharedFloat BehaviorWaitTime; // 0x98
	public Character TargetCharacter; // 0xA0
	public Character LatestDamagedTarget; // 0xA8

	// Methods

	// RVA: 0x1FB10F0 Offset: 0x1FB11F1 VA: 0x1FB10F0
	public void .ctor(PartnerNPCBehaviorController owner) { }

	// RVA: 0x1FB11D0 Offset: 0x1FB12D1 VA: 0x1FB11D0
	private NPCActionBehaviorController.PartnerNPCActionBehaviorParam CreatePartnerNPCActionBehaviorParam(ActionBehaviorCommandInformation command) { }

	// RVA: 0x1FB1670 Offset: 0x1FB1771 VA: 0x1FB1670
	private List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam> CreateNPCActionBehaviorCommandParameterList(NPCActionBehaviorDataID id, BehaviorTree behaviorTree) { }

	// RVA: 0x1FB1990 Offset: 0x1FB1A91 VA: 0x1FB1990
	public Func<Character, bool> CreateFindTargetFunc(NPCFindTargetDataID dataID) { }

	// RVA: 0x1FB21E0 Offset: 0x1FB22E1 VA: 0x1FB21E0
	private List<NPCActionData> GetDataList() { }

	// RVA: 0x1FB2550 Offset: 0x1FB2651 VA: 0x1FB2550
	public void Setup(BehaviorTree behaviorTree) { }

	// RVA: 0x1FB2B70 Offset: 0x1FB2C71 VA: 0x1FB2B70
	private Character GetRandomTaget(List<Character> targetList) { }

	// RVA: 0x1FB2C10 Offset: 0x1FB2D11 VA: 0x1FB2C10
	private bool CanActionFindTarget(NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter param) { }

	// RVA: 0x1FB2E90 Offset: 0x1FB2F91 VA: 0x1FB2E90
	private Character FindTarget(NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter param) { }

	// RVA: 0x1FB30D0 Offset: 0x1FB31D1 VA: 0x1FB30D0
	public NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter SelectNPCOrderAction(List<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter> paramList, bool ignoreCoolCount = False) { }

	// RVA: 0x1FB3580 Offset: 0x1FB3681 VA: 0x1FB3580
	public void SelectNPCAction() { }

	// RVA: 0x1FB3FD0 Offset: 0x1FB40D1 VA: 0x1FB3FD0
	public List<PartnerNPCActionBehaviorType> GetActionList() { }

	// RVA: 0x1FB3FE0 Offset: 0x1FB40E1 VA: 0x1FB3FE0
	public void Execute(int index) { }
}

