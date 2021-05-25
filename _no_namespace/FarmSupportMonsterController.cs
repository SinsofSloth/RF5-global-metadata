public class FarmSupportMonsterController // TypeDefIndex: 8043
{
	// Fields
	private const float ArriveDistanceMargin = 1;
	[CompilerGeneratedAttribute] // RVA: 0x169F50 Offset: 0x16A051 VA: 0x169F50
	private FarmSupportMonsterData <FarmSupportMonsterData>k__BackingField; // 0x10
	public FriendMonsterStatus FriendMonsterStatus; // 0x18
	public CharacterMoveParam CharacterMoveParam; // 0x20
	private float ArriveDistance; // 0x28
	private bool IsEndExcuteStateBehavior; // 0x2C
	private FarmMonsterWorkState FarmMonsterWorkState; // 0x30
	private Vector3 MoveTargetPosition; // 0x34
	private float NotTaskWaitTimer; // 0x40
	private FarmSupportMonsterController.BehaviorState CurrentOutHutBehaviorState; // 0x44
	private List<MiningPointSaveData> MiningPointSaveDataList; // 0x48
	private List<FarmCropData> FarmCropDataList; // 0x50
	private Dictionary<int, Action<int>> UpdateStateDic; // 0x58
	private Dictionary<int, Action> UpdateStateBehaviorDic; // 0x60
	private FieldSceneId previousPlayerSceneId; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x169F60 Offset: 0x16A061 VA: 0x169F60
	private bool <IsEndSupport>k__BackingField; // 0x6C
	private FarmSupportMonsterController.BehaviorState WanderOutHutBehaviorState; // 0x70
	public FarmMonsterBehaviorController FarmMonsterBehaviorController; // 0x78
	public bool IsLoading; // 0x80
	public bool IsEndDestroy; // 0x81
	public bool IsDestroy; // 0x82

	// Properties
	public FarmSupportMonsterData FarmSupportMonsterData { get; set; }
	private FriendMonsterStatusData FriendMonsterStatusData { get; }
	public bool IsEndSupport { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A5640 Offset: 0x1A5741 VA: 0x1A5640
	// RVA: 0x202F060 Offset: 0x202F161 VA: 0x202F060
	public FarmSupportMonsterData get_FarmSupportMonsterData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5650 Offset: 0x1A5751 VA: 0x1A5650
	// RVA: 0x202F070 Offset: 0x202F171 VA: 0x202F070
	private void set_FarmSupportMonsterData(FarmSupportMonsterData value) { }

	// RVA: 0x202F080 Offset: 0x202F181 VA: 0x202F080
	private FriendMonsterStatusData get_FriendMonsterStatusData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5660 Offset: 0x1A5761 VA: 0x1A5660
	// RVA: 0x202F0A0 Offset: 0x202F1A1 VA: 0x202F0A0
	public bool get_IsEndSupport() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5670 Offset: 0x1A5771 VA: 0x1A5670
	// RVA: 0x202F0B0 Offset: 0x202F1B1 VA: 0x202F0B0
	private void set_IsEndSupport(bool value) { }

	// RVA: 0x202F0C0 Offset: 0x202F1C1 VA: 0x202F0C0
	public void .ctor(FarmSupportMonsterData farmSupportMonsterData) { }

	// RVA: 0x202FA00 Offset: 0x202FB01 VA: 0x202FA00
	private void CheckEndSupport() { }

	// RVA: 0x202FBB0 Offset: 0x202FCB1 VA: 0x202FBB0
	private bool StateAction_Wait() { }

	// RVA: 0x202FC50 Offset: 0x202FD51 VA: 0x202FC50
	private bool StateAction_Move(Vector3 targetPosition) { }

	// RVA: 0x202FFD0 Offset: 0x20300D1 VA: 0x202FFD0
	private bool StateAction_Action(bool isLookAtMovePosition = True) { }

	// RVA: 0x20302F0 Offset: 0x20303F1 VA: 0x20302F0
	private void StateBehavior_Room() { }

	// RVA: 0x2030390 Offset: 0x2030491 VA: 0x2030390
	private void StateBehavior_OutHut() { }

	// RVA: 0x20304D0 Offset: 0x20305D1 VA: 0x20304D0
	private void StateBehavior_InHut() { }

	// RVA: 0x2030610 Offset: 0x2030711 VA: 0x2030610
	private void StateBehavior_InRoom() { }

	// RVA: 0x2030700 Offset: 0x2030801 VA: 0x2030700
	private MiningPointSaveData GetMinigPointSaveData(int index) { }

	// RVA: 0x20307D0 Offset: 0x20308D1 VA: 0x20307D0
	private void AddLumber() { }

	// RVA: 0x20308F0 Offset: 0x20309F1 VA: 0x20308F0
	private void AddStone() { }

	// RVA: 0x2030A10 Offset: 0x2030B11 VA: 0x2030A10
	private void GetMiningPointItem(MiningManager.MINING_MONSTER_TASK task, MiningPointSaveData data) { }

	// RVA: 0x2030B70 Offset: 0x2030C71 VA: 0x2030B70
	private void StateBehavior_Clean() { }

	// RVA: 0x2030EE0 Offset: 0x2030FE1 VA: 0x2030EE0
	private bool TryGetFarmCropData(int index, out FarmCropData farmCropData) { }

	// RVA: 0x2030FA0 Offset: 0x20310A1 VA: 0x2030FA0
	private void DoFarmCropCell(FarmManager.FARM_MONSTER_TASK task, FarmCropData farmCropData) { }

	// RVA: 0x20318D0 Offset: 0x20319D1 VA: 0x20318D0
	private void UpdateFarmCropAction(FarmManager.FARM_MONSTER_TASK checkTask, FarmCropData farmCropData) { }

	// RVA: 0x2031B50 Offset: 0x2031C51 VA: 0x2031B50
	private void UpdateWanderAction() { }

	// RVA: 0x2031D80 Offset: 0x2031E81 VA: 0x2031D80
	private void FarmCropAction(FarmManager.FARM_MONSTER_TASK checkTask) { }

	// RVA: 0x2031EF0 Offset: 0x2031FF1 VA: 0x2031EF0
	private void StateBehavior_Water() { }

	// RVA: 0x2031F00 Offset: 0x2032001 VA: 0x2031F00
	private void StateBehavior_Seed() { }

	// RVA: 0x2031F10 Offset: 0x2032011 VA: 0x2031F10
	private void StateBehavior_Crop() { }

	// RVA: 0x2031F20 Offset: 0x2032021 VA: 0x2031F20
	private void ExcuteStateBehavior() { }

	// RVA: 0x202F850 Offset: 0x202F951 VA: 0x202F850
	private void ResetStateParameter(bool IsUpdateArea = True) { }

	// RVA: 0x2031FB0 Offset: 0x20320B1 VA: 0x2031FB0
	private void Update_Room(int time) { }

	// RVA: 0x2032300 Offset: 0x2032401 VA: 0x2032300
	private void Update_OutHut(int time) { }

	// RVA: 0x2032440 Offset: 0x2032541 VA: 0x2032440
	private void Update_InRoom(int time) { }

	// RVA: 0x2032590 Offset: 0x2032691 VA: 0x2032590
	private void Update_InHut(int time) { }

	// RVA: 0x2032660 Offset: 0x2032761 VA: 0x2032660
	private void Update_Clean(int time) { }

	// RVA: 0x2032830 Offset: 0x2032931 VA: 0x2032830
	private void Update_Seed(int time) { }

	// RVA: 0x2032990 Offset: 0x2032A91 VA: 0x2032990
	private void Update_Water(int time) { }

	// RVA: 0x2032A50 Offset: 0x2032B51 VA: 0x2032A50
	private void Update_Crop(int time) { }

	// RVA: 0x2032AC0 Offset: 0x2032BC1 VA: 0x2032AC0
	private void UpdateState(int time) { }

	// RVA: 0x2032D60 Offset: 0x2032E61 VA: 0x2032D60
	public void UpdateDayWork() { }

	// RVA: 0x2032F30 Offset: 0x2033031 VA: 0x2032F30
	public void UpdateFrameWork() { }

	// RVA: 0x2032D30 Offset: 0x2032E31 VA: 0x2032D30
	private bool IsMonsterHutScene(FieldSceneId fieldSceneId) { }

	// RVA: 0x2033050 Offset: 0x2033151 VA: 0x2033050
	private FarmMonsterBehaviorController GetFarmMonsterBehaviorController(ActorID actorID) { }

	// RVA: 0x2033470 Offset: 0x2033571 VA: 0x2033470
	public void OrderCreateCharacter() { }

	// RVA: 0x20332B0 Offset: 0x20333B1 VA: 0x20332B0
	private void DestroyCharacter() { }

	// RVA: 0x2033850 Offset: 0x2033951 VA: 0x2033850
	public void OrderDestroyCharacter() { }

	// RVA: 0x2033890 Offset: 0x2033991 VA: 0x2033890
	public void SetDisplayCharacter(bool isDisplay) { }

	// RVA: 0x2032C00 Offset: 0x2032D01 VA: 0x2032C00
	private FieldSceneId GetCurrentSceneId() { }

	// RVA: 0x2033460 Offset: 0x2033561 VA: 0x2033460
	private void ResetCharacterFlag() { }

	// RVA: 0x20338E0 Offset: 0x20339E1 VA: 0x20338E0
	private bool IsSameScenePlayer() { }

	// RVA: 0x2032E30 Offset: 0x2032F31 VA: 0x2032E30
	public void UpdateCharacter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5680 Offset: 0x1A5781 VA: 0x1A5680
	// RVA: 0x2033950 Offset: 0x2033A51 VA: 0x2033950
	private void <OrderCreateCharacter>b__67_1(uint id, ActorID actorId) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5690 Offset: 0x1A5791 VA: 0x1A5690
	// RVA: 0x2033980 Offset: 0x2033A81 VA: 0x2033980
	private void <OrderCreateCharacter>b__67_0(uint id, ActorID actorID) { }
}

