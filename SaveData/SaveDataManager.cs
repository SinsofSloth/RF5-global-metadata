public class SaveDataManager : MonoBehaviour // TypeDefIndex: 9917
{
	// Fields
	private SystemSaveData SystemData; // 0x18
	private GameSaveData GameData; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17FA40 Offset: 0x17FB41 VA: 0x17FA40
	private static string <UserName>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x17FA50 Offset: 0x17FB51 VA: 0x17FA50
	private static SaveDataManager <Instance>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x17FA60 Offset: 0x17FB61 VA: 0x17FA60
	private SaveControllerBase <SaveController>k__BackingField; // 0x28
	private SaveDataManager.STATE State; // 0x30
	private float WaitTime; // 0x34
	private GameSaveData TargetDatas; // 0x38
	private Action<ErrorCode> OnComplete; // 0x40

	// Properties
	public static bool IsBusy { get; }
	public static int CurrentSlot { get; }
	public static string UserName { get; set; }
	public static ErrorCode ErrorCode { get; }
	public static string ErrorResult { get; }
	public static RF5SystemData SystemSaveData { get; }
	public static RF5OptionData OptionData { get; }
	public static RF5ThumbnailData[] ThumbnailDatas { get; }
	public static RF5SaveData GameSaveData { get; }
	public static RF5WorldData WorldData { get; }
	public static RF5PlayerData PlayerData { get; }
	public static RF5BattleData BattleData { get; }
	public static RF5ItemData ItemData { get; }
	public static RF5StatusData StatusData { get; }
	public static RF5OrderData OrderData { get; }
	public static RF5NpcData NpcData { get; }
	public static RF5PoliceBatchData PoliceBatchData { get; }
	public static RF5FarmData FarmData { get; }
	public static RF5MakingData MakingData { get; }
	public static RF5BuildData BuildData { get; }
	private static SaveDataManager Instance { get; set; }
	private SaveControllerBase SaveController { get; set; }

	// Methods

	// RVA: 0x20F7A20 Offset: 0x20F7B21 VA: 0x20F7A20
	public static bool get_IsBusy() { }

	// RVA: 0x20F7B30 Offset: 0x20F7C31 VA: 0x20F7B30
	public static int get_CurrentSlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD400 Offset: 0x1AD501 VA: 0x1AD400
	// RVA: 0x20F7C10 Offset: 0x20F7D11 VA: 0x20F7C10
	public static string get_UserName() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD410 Offset: 0x1AD511 VA: 0x1AD410
	// RVA: 0x20F7C60 Offset: 0x20F7D61 VA: 0x20F7C60
	public static void set_UserName(string value) { }

	// RVA: 0x20F7CC0 Offset: 0x20F7DC1 VA: 0x20F7CC0
	public static ErrorCode get_ErrorCode() { }

	// RVA: 0x20F7D30 Offset: 0x20F7E31 VA: 0x20F7D30
	public static string get_ErrorResult() { }

	// RVA: 0x20F7DA0 Offset: 0x20F7EA1 VA: 0x20F7DA0
	public static RF5SystemData get_SystemSaveData() { }

	// RVA: 0x20F7E10 Offset: 0x20F7F11 VA: 0x20F7E10
	public static RF5OptionData get_OptionData() { }

	// RVA: 0x20F7E80 Offset: 0x20F7F81 VA: 0x20F7E80
	public static RF5ThumbnailData[] get_ThumbnailDatas() { }

	// RVA: 0x20F7BA0 Offset: 0x20F7CA1 VA: 0x20F7BA0
	public static RF5SaveData get_GameSaveData() { }

	// RVA: 0x20F7EF0 Offset: 0x20F7FF1 VA: 0x20F7EF0
	public static RF5WorldData get_WorldData() { }

	// RVA: 0x20F7F60 Offset: 0x20F8061 VA: 0x20F7F60
	public static RF5PlayerData get_PlayerData() { }

	// RVA: 0x20F7FD0 Offset: 0x20F80D1 VA: 0x20F7FD0
	public static RF5BattleData get_BattleData() { }

	// RVA: 0x20F8040 Offset: 0x20F8141 VA: 0x20F8040
	public static RF5ItemData get_ItemData() { }

	// RVA: 0x20F80B0 Offset: 0x20F81B1 VA: 0x20F80B0
	public static RF5StatusData get_StatusData() { }

	// RVA: 0x20F8120 Offset: 0x20F8221 VA: 0x20F8120
	public static RF5OrderData get_OrderData() { }

	// RVA: 0x20F8190 Offset: 0x20F8291 VA: 0x20F8190
	public static RF5NpcData get_NpcData() { }

	// RVA: 0x20F8200 Offset: 0x20F8301 VA: 0x20F8200
	public static RF5PoliceBatchData get_PoliceBatchData() { }

	// RVA: 0x20F8270 Offset: 0x20F8371 VA: 0x20F8270
	public static RF5FarmData get_FarmData() { }

	// RVA: 0x20F82E0 Offset: 0x20F83E1 VA: 0x20F82E0
	public static RF5MakingData get_MakingData() { }

	// RVA: 0x20F8350 Offset: 0x20F8451 VA: 0x20F8350
	public static RF5BuildData get_BuildData() { }

	// RVA: 0x20F83C0 Offset: 0x20F84C1 VA: 0x20F83C0
	public static void Initialize() { }

	// RVA: 0x20F84E0 Offset: 0x20F85E1 VA: 0x20F84E0
	public static void InitializeForNewGame() { }

	// RVA: 0x20F87B0 Offset: 0x20F88B1 VA: 0x20F87B0
	public static void SystemDataInitialize() { }

	// RVA: 0x20F8920 Offset: 0x20F8A21 VA: 0x20F8920
	public static void SystemDataSave(Action<ErrorCode> onComplete) { }

	// RVA: 0x20F89E0 Offset: 0x20F8AE1 VA: 0x20F89E0
	public static void SystemDataLoad(Action<ErrorCode> onComplete) { }

	// RVA: 0x20F8AA0 Offset: 0x20F8BA1 VA: 0x20F8AA0
	public static void GameDataSalvage(Action<ErrorCode> onComplete) { }

	// RVA: 0x20F8B80 Offset: 0x20F8C81 VA: 0x20F8B80
	public static void GameDataSave(int slot, Action<ErrorCode> onComplete) { }

	// RVA: 0x20F8CA0 Offset: 0x20F8DA1 VA: 0x20F8CA0
	public static void GameDataLoad(int slot, Action<ErrorCode> onComplete) { }

	// RVA: 0x20F8E60 Offset: 0x20F8F61 VA: 0x20F8E60
	public static void SystemDataDelete() { }

	// RVA: 0x20F8EE0 Offset: 0x20F8FE1 VA: 0x20F8EE0
	public static void GameDataDelete() { }

	// RVA: 0x20F8FB0 Offset: 0x20F90B1 VA: 0x20F8FB0
	public static void GameDataDelete(int slot, Action<ErrorCode> onComplete) { }

	// RVA: 0x20F9080 Offset: 0x20F9181 VA: 0x20F9080
	public static bool IsSaveDataExisting(ulong applicationId = 72100543920185344) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD420 Offset: 0x1AD521 VA: 0x1AD420
	// RVA: 0x20F9100 Offset: 0x20F9201 VA: 0x20F9100
	private static SaveDataManager get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD430 Offset: 0x1AD531 VA: 0x1AD430
	// RVA: 0x20F9150 Offset: 0x20F9251 VA: 0x20F9150
	private static void set_Instance(SaveDataManager value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD440 Offset: 0x1AD541 VA: 0x1AD440
	// RVA: 0x20F91B0 Offset: 0x20F92B1 VA: 0x20F91B0
	private SaveControllerBase get_SaveController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD450 Offset: 0x1AD551 VA: 0x1AD450
	// RVA: 0x20F91C0 Offset: 0x20F92C1 VA: 0x20F91C0
	private void set_SaveController(SaveControllerBase value) { }

	// RVA: 0x20F91D0 Offset: 0x20F92D1 VA: 0x20F91D0
	private void Awake() { }

	// RVA: 0x20F8420 Offset: 0x20F8521 VA: 0x20F8420
	private void Create() { }

	// RVA: 0x20F9A20 Offset: 0x20F9B21 VA: 0x20F9A20
	private void OnDestroy() { }

	// RVA: 0x20F9A70 Offset: 0x20F9B71 VA: 0x20F9A70
	private void Update() { }

	// RVA: 0x20FA020 Offset: 0x20FA121 VA: 0x20FA020
	public void .ctor() { }
}

