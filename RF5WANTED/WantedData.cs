public class WantedData // TypeDefIndex: 9802
{
	// Fields
	public int RandomDataNo; // 0x10
	public MonsterDataID monsterDataID; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x17F330 Offset: 0x17F431 VA: 0x17F330
	private WantedID <WantedID>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17F340 Offset: 0x17F441 VA: 0x17F340
	private WantedDataTable.Data <Data>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17F350 Offset: 0x17F451 VA: 0x17F350
	private WantedDataTable.Reward <Reward>k__BackingField; // 0x28
	public int FieldId; // 0x30
	public WantedFieldType FieldType; // 0x34
	private static bool Completed; // 0x0
	private static List<PoliceBatchId> BatchIdGet; // 0x8
	private static bool RankupReady; // 0x10
	private static int AdvBatchId; // 0x14
	private static List<WantedData> wantedDatas; // 0x18
	private static readonly int[] BaseScore; // 0x20

	// Properties
	public WantedID WantedID { get; set; }
	public WantedDataTable.Data Data { get; set; }
	public WantedDataTable.Reward Reward { get; set; }
	public static bool isAccepted { get; }
	public static bool isFinished { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD020 Offset: 0x1AD121 VA: 0x1AD020
	// RVA: 0x1DA45E0 Offset: 0x1DA46E1 VA: 0x1DA45E0
	public WantedID get_WantedID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD030 Offset: 0x1AD131 VA: 0x1AD030
	// RVA: 0x1DA45F0 Offset: 0x1DA46F1 VA: 0x1DA45F0
	private void set_WantedID(WantedID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD040 Offset: 0x1AD141 VA: 0x1AD040
	// RVA: 0x1DA4600 Offset: 0x1DA4701 VA: 0x1DA4600
	public WantedDataTable.Data get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD050 Offset: 0x1AD151 VA: 0x1AD050
	// RVA: 0x1DA4610 Offset: 0x1DA4711 VA: 0x1DA4610
	private void set_Data(WantedDataTable.Data value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD060 Offset: 0x1AD161 VA: 0x1AD060
	// RVA: 0x1DA4620 Offset: 0x1DA4721 VA: 0x1DA4620
	public WantedDataTable.Reward get_Reward() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD070 Offset: 0x1AD171 VA: 0x1AD070
	// RVA: 0x1DA4630 Offset: 0x1DA4731 VA: 0x1DA4630
	private void set_Reward(WantedDataTable.Reward value) { }

	// RVA: 0x1DA4640 Offset: 0x1DA4741 VA: 0x1DA4640
	public void .ctor(WantedDataTable.Data _wantedData, WantedDataTable.Reward _rewardData, WantedID id) { }

	// RVA: 0x1DA46D0 Offset: 0x1DA47D1 VA: 0x1DA46D0
	public void Init(WantedDataTable.Data _wantedData, WantedDataTable.Reward _rewardData, WantedID id) { }

	// RVA: 0x1DA4740 Offset: 0x1DA4841 VA: 0x1DA4740
	public bool CheckShowFinished() { }

	// RVA: 0x1DA4800 Offset: 0x1DA4901 VA: 0x1DA4800
	public bool CheckCanAccept() { }

	// RVA: 0x1DA48D0 Offset: 0x1DA49D1 VA: 0x1DA48D0
	private void GetCompleted(ref int completed, ref int max) { }

	// RVA: 0x1DA4AF0 Offset: 0x1DA4BF1 VA: 0x1DA4AF0
	public bool isCompleted() { }

	// RVA: 0x1DA4B30 Offset: 0x1DA4C31 VA: 0x1DA4B30
	public string CompletedStr() { }

	// RVA: 0x1DA4BE0 Offset: 0x1DA4CE1 VA: 0x1DA4BE0
	public string GroupStr() { }

	// RVA: 0x1DA4E90 Offset: 0x1DA4F91 VA: 0x1DA4E90
	public string AcceptStr() { }

	// RVA: 0x1DA5340 Offset: 0x1DA5441 VA: 0x1DA5340
	public string RewardStr() { }

	// RVA: 0x1DA5550 Offset: 0x1DA5651 VA: 0x1DA5550
	public void Accept() { }

	// RVA: 0x1DA5620 Offset: 0x1DA5721 VA: 0x1DA5620
	public static void MonsterDestroyFailCheck() { }

	// RVA: 0x1DA5670 Offset: 0x1DA5771 VA: 0x1DA5670
	public static void Cancel() { }

	// RVA: 0x1DA56C0 Offset: 0x1DA57C1 VA: 0x1DA56C0
	public static bool UpdateData() { }

	// RVA: 0x1DA5850 Offset: 0x1DA5951 VA: 0x1DA5850
	public static WantedData GetAcceptedData() { }

	// RVA: 0x1DA6190 Offset: 0x1DA6291 VA: 0x1DA6190
	public static bool get_isAccepted() { }

	// RVA: 0x1DA61C0 Offset: 0x1DA62C1 VA: 0x1DA61C0
	public static bool get_isFinished() { }

	// RVA: 0x1DA61F0 Offset: 0x1DA62F1 VA: 0x1DA61F0
	public static string GetUITargetMonsterText() { }

	// RVA: 0x1DA50D0 Offset: 0x1DA51D1 VA: 0x1DA50D0
	private static string GetUIPlaceText(WantedFieldType wantedFieldType, int fieldId) { }

	// RVA: 0x1DA6320 Offset: 0x1DA6421 VA: 0x1DA6320
	public static string GetUITargetPlaceText() { }

	// RVA: 0x1DA63A0 Offset: 0x1DA64A1 VA: 0x1DA63A0
	public static string GetAdvTargetPlaceText() { }

	// RVA: 0x1DA6620 Offset: 0x1DA6721 VA: 0x1DA6620
	public static void DoFinish(MonsterControllerBase monsterController) { }

	// RVA: 0x1DA6850 Offset: 0x1DA6951 VA: 0x1DA6850
	public static bool CheckMonster(MonsterDataID monsterDataID) { }

	// RVA: 0x1DA6910 Offset: 0x1DA6A11 VA: 0x1DA6910
	public static bool CheckFinished() { }

	// RVA: 0x1DA69E0 Offset: 0x1DA6AE1 VA: 0x1DA69E0
	public static void UnlockBatch(PoliceBatchId id) { }

	// RVA: 0x1DA6B40 Offset: 0x1DA6C41 VA: 0x1DA6B40
	public static bool GetReward() { }

	// RVA: 0x1DA5990 Offset: 0x1DA5A91 VA: 0x1DA5990
	public static List<WantedData> GetDatas(bool RefreshData = False) { }

	// RVA: 0x1DA7460 Offset: 0x1DA7561 VA: 0x1DA7460
	public static PoliceBatchId DoGetBatch() { }

	// RVA: 0x1DA7570 Offset: 0x1DA7671 VA: 0x1DA7570
	public static void CheckNextStep() { }

	// RVA: 0x1DA7710 Offset: 0x1DA7811 VA: 0x1DA7710
	public static string GetCompletedRewardText() { }

	// RVA: 0x1DA7AA0 Offset: 0x1DA7BA1 VA: 0x1DA7AA0
	public static int GetNewBatchIdForScript() { }

	// RVA: 0x1DA7B10 Offset: 0x1DA7C11 VA: 0x1DA7B10
	public static bool isRankup() { }

	// RVA: 0x1DA7B80 Offset: 0x1DA7C81 VA: 0x1DA7B80
	public static bool isGetBatch() { }

	// RVA: 0x1DA7C00 Offset: 0x1DA7D01 VA: 0x1DA7C00
	public static void Init() { }

	// RVA: 0x1DA7DB0 Offset: 0x1DA7EB1 VA: 0x1DA7DB0
	private static void .cctor() { }
}

public class WantedData // TypeDefIndex: 9802
{
	// Fields
	public int RandomDataNo; // 0x10
	public MonsterDataID monsterDataID; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x17F330 Offset: 0x17F431 VA: 0x17F330
	private WantedID <WantedID>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17F340 Offset: 0x17F441 VA: 0x17F340
	private WantedDataTable.Data <Data>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17F350 Offset: 0x17F451 VA: 0x17F350
	private WantedDataTable.Reward <Reward>k__BackingField; // 0x28
	public int FieldId; // 0x30
	public WantedFieldType FieldType; // 0x34
	private static bool Completed; // 0x0
	private static List<PoliceBatchId> BatchIdGet; // 0x8
	private static bool RankupReady; // 0x10
	private static int AdvBatchId; // 0x14
	private static List<WantedData> wantedDatas; // 0x18
	private static readonly int[] BaseScore; // 0x20

	// Properties
	public WantedID WantedID { get; set; }
	public WantedDataTable.Data Data { get; set; }
	public WantedDataTable.Reward Reward { get; set; }
	public static bool isAccepted { get; }
	public static bool isFinished { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD020 Offset: 0x1AD121 VA: 0x1AD020
	// RVA: 0x1DA45E0 Offset: 0x1DA46E1 VA: 0x1DA45E0
	public WantedID get_WantedID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD030 Offset: 0x1AD131 VA: 0x1AD030
	// RVA: 0x1DA45F0 Offset: 0x1DA46F1 VA: 0x1DA45F0
	private void set_WantedID(WantedID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD040 Offset: 0x1AD141 VA: 0x1AD040
	// RVA: 0x1DA4600 Offset: 0x1DA4701 VA: 0x1DA4600
	public WantedDataTable.Data get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD050 Offset: 0x1AD151 VA: 0x1AD050
	// RVA: 0x1DA4610 Offset: 0x1DA4711 VA: 0x1DA4610
	private void set_Data(WantedDataTable.Data value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD060 Offset: 0x1AD161 VA: 0x1AD060
	// RVA: 0x1DA4620 Offset: 0x1DA4721 VA: 0x1DA4620
	public WantedDataTable.Reward get_Reward() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD070 Offset: 0x1AD171 VA: 0x1AD070
	// RVA: 0x1DA4630 Offset: 0x1DA4731 VA: 0x1DA4630
	private void set_Reward(WantedDataTable.Reward value) { }

	// RVA: 0x1DA4640 Offset: 0x1DA4741 VA: 0x1DA4640
	public void .ctor(WantedDataTable.Data _wantedData, WantedDataTable.Reward _rewardData, WantedID id) { }

	// RVA: 0x1DA46D0 Offset: 0x1DA47D1 VA: 0x1DA46D0
	public void Init(WantedDataTable.Data _wantedData, WantedDataTable.Reward _rewardData, WantedID id) { }

	// RVA: 0x1DA4740 Offset: 0x1DA4841 VA: 0x1DA4740
	public bool CheckShowFinished() { }

	// RVA: 0x1DA4800 Offset: 0x1DA4901 VA: 0x1DA4800
	public bool CheckCanAccept() { }

	// RVA: 0x1DA48D0 Offset: 0x1DA49D1 VA: 0x1DA48D0
	private void GetCompleted(ref int completed, ref int max) { }

	// RVA: 0x1DA4AF0 Offset: 0x1DA4BF1 VA: 0x1DA4AF0
	public bool isCompleted() { }

	// RVA: 0x1DA4B30 Offset: 0x1DA4C31 VA: 0x1DA4B30
	public string CompletedStr() { }

	// RVA: 0x1DA4BE0 Offset: 0x1DA4CE1 VA: 0x1DA4BE0
	public string GroupStr() { }

	// RVA: 0x1DA4E90 Offset: 0x1DA4F91 VA: 0x1DA4E90
	public string AcceptStr() { }

	// RVA: 0x1DA5340 Offset: 0x1DA5441 VA: 0x1DA5340
	public string RewardStr() { }

	// RVA: 0x1DA5550 Offset: 0x1DA5651 VA: 0x1DA5550
	public void Accept() { }

	// RVA: 0x1DA5620 Offset: 0x1DA5721 VA: 0x1DA5620
	public static void MonsterDestroyFailCheck() { }

	// RVA: 0x1DA5670 Offset: 0x1DA5771 VA: 0x1DA5670
	public static void Cancel() { }

	// RVA: 0x1DA56C0 Offset: 0x1DA57C1 VA: 0x1DA56C0
	public static bool UpdateData() { }

	// RVA: 0x1DA5850 Offset: 0x1DA5951 VA: 0x1DA5850
	public static WantedData GetAcceptedData() { }

	// RVA: 0x1DA6190 Offset: 0x1DA6291 VA: 0x1DA6190
	public static bool get_isAccepted() { }

	// RVA: 0x1DA61C0 Offset: 0x1DA62C1 VA: 0x1DA61C0
	public static bool get_isFinished() { }

	// RVA: 0x1DA61F0 Offset: 0x1DA62F1 VA: 0x1DA61F0
	public static string GetUITargetMonsterText() { }

	// RVA: 0x1DA50D0 Offset: 0x1DA51D1 VA: 0x1DA50D0
	private static string GetUIPlaceText(WantedFieldType wantedFieldType, int fieldId) { }

	// RVA: 0x1DA6320 Offset: 0x1DA6421 VA: 0x1DA6320
	public static string GetUITargetPlaceText() { }

	// RVA: 0x1DA63A0 Offset: 0x1DA64A1 VA: 0x1DA63A0
	public static string GetAdvTargetPlaceText() { }

	// RVA: 0x1DA6620 Offset: 0x1DA6721 VA: 0x1DA6620
	public static void DoFinish(MonsterControllerBase monsterController) { }

	// RVA: 0x1DA6850 Offset: 0x1DA6951 VA: 0x1DA6850
	public static bool CheckMonster(MonsterDataID monsterDataID) { }

	// RVA: 0x1DA6910 Offset: 0x1DA6A11 VA: 0x1DA6910
	public static bool CheckFinished() { }

	// RVA: 0x1DA69E0 Offset: 0x1DA6AE1 VA: 0x1DA69E0
	public static void UnlockBatch(PoliceBatchId id) { }

	// RVA: 0x1DA6B40 Offset: 0x1DA6C41 VA: 0x1DA6B40
	public static bool GetReward() { }

	// RVA: 0x1DA5990 Offset: 0x1DA5A91 VA: 0x1DA5990
	public static List<WantedData> GetDatas(bool RefreshData = False) { }

	// RVA: 0x1DA7460 Offset: 0x1DA7561 VA: 0x1DA7460
	public static PoliceBatchId DoGetBatch() { }

	// RVA: 0x1DA7570 Offset: 0x1DA7671 VA: 0x1DA7570
	public static void CheckNextStep() { }

	// RVA: 0x1DA7710 Offset: 0x1DA7811 VA: 0x1DA7710
	public static string GetCompletedRewardText() { }

	// RVA: 0x1DA7AA0 Offset: 0x1DA7BA1 VA: 0x1DA7AA0
	public static int GetNewBatchIdForScript() { }

	// RVA: 0x1DA7B10 Offset: 0x1DA7C11 VA: 0x1DA7B10
	public static bool isRankup() { }

	// RVA: 0x1DA7B80 Offset: 0x1DA7C81 VA: 0x1DA7B80
	public static bool isGetBatch() { }

	// RVA: 0x1DA7C00 Offset: 0x1DA7D01 VA: 0x1DA7C00
	public static void Init() { }

	// RVA: 0x1DA7DB0 Offset: 0x1DA7EB1 VA: 0x1DA7DB0
	private static void .cctor() { }
}

public class WantedData // TypeDefIndex: 9802
{
	// Fields
	public int RandomDataNo; // 0x10
	public MonsterDataID monsterDataID; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x17F330 Offset: 0x17F431 VA: 0x17F330
	private WantedID <WantedID>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17F340 Offset: 0x17F441 VA: 0x17F340
	private WantedDataTable.Data <Data>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17F350 Offset: 0x17F451 VA: 0x17F350
	private WantedDataTable.Reward <Reward>k__BackingField; // 0x28
	public int FieldId; // 0x30
	public WantedFieldType FieldType; // 0x34
	private static bool Completed; // 0x0
	private static List<PoliceBatchId> BatchIdGet; // 0x8
	private static bool RankupReady; // 0x10
	private static int AdvBatchId; // 0x14
	private static List<WantedData> wantedDatas; // 0x18
	private static readonly int[] BaseScore; // 0x20

	// Properties
	public WantedID WantedID { get; set; }
	public WantedDataTable.Data Data { get; set; }
	public WantedDataTable.Reward Reward { get; set; }
	public static bool isAccepted { get; }
	public static bool isFinished { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD020 Offset: 0x1AD121 VA: 0x1AD020
	// RVA: 0x1DA45E0 Offset: 0x1DA46E1 VA: 0x1DA45E0
	public WantedID get_WantedID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD030 Offset: 0x1AD131 VA: 0x1AD030
	// RVA: 0x1DA45F0 Offset: 0x1DA46F1 VA: 0x1DA45F0
	private void set_WantedID(WantedID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD040 Offset: 0x1AD141 VA: 0x1AD040
	// RVA: 0x1DA4600 Offset: 0x1DA4701 VA: 0x1DA4600
	public WantedDataTable.Data get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD050 Offset: 0x1AD151 VA: 0x1AD050
	// RVA: 0x1DA4610 Offset: 0x1DA4711 VA: 0x1DA4610
	private void set_Data(WantedDataTable.Data value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD060 Offset: 0x1AD161 VA: 0x1AD060
	// RVA: 0x1DA4620 Offset: 0x1DA4721 VA: 0x1DA4620
	public WantedDataTable.Reward get_Reward() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD070 Offset: 0x1AD171 VA: 0x1AD070
	// RVA: 0x1DA4630 Offset: 0x1DA4731 VA: 0x1DA4630
	private void set_Reward(WantedDataTable.Reward value) { }

	// RVA: 0x1DA4640 Offset: 0x1DA4741 VA: 0x1DA4640
	public void .ctor(WantedDataTable.Data _wantedData, WantedDataTable.Reward _rewardData, WantedID id) { }

	// RVA: 0x1DA46D0 Offset: 0x1DA47D1 VA: 0x1DA46D0
	public void Init(WantedDataTable.Data _wantedData, WantedDataTable.Reward _rewardData, WantedID id) { }

	// RVA: 0x1DA4740 Offset: 0x1DA4841 VA: 0x1DA4740
	public bool CheckShowFinished() { }

	// RVA: 0x1DA4800 Offset: 0x1DA4901 VA: 0x1DA4800
	public bool CheckCanAccept() { }

	// RVA: 0x1DA48D0 Offset: 0x1DA49D1 VA: 0x1DA48D0
	private void GetCompleted(ref int completed, ref int max) { }

	// RVA: 0x1DA4AF0 Offset: 0x1DA4BF1 VA: 0x1DA4AF0
	public bool isCompleted() { }

	// RVA: 0x1DA4B30 Offset: 0x1DA4C31 VA: 0x1DA4B30
	public string CompletedStr() { }

	// RVA: 0x1DA4BE0 Offset: 0x1DA4CE1 VA: 0x1DA4BE0
	public string GroupStr() { }

	// RVA: 0x1DA4E90 Offset: 0x1DA4F91 VA: 0x1DA4E90
	public string AcceptStr() { }

	// RVA: 0x1DA5340 Offset: 0x1DA5441 VA: 0x1DA5340
	public string RewardStr() { }

	// RVA: 0x1DA5550 Offset: 0x1DA5651 VA: 0x1DA5550
	public void Accept() { }

	// RVA: 0x1DA5620 Offset: 0x1DA5721 VA: 0x1DA5620
	public static void MonsterDestroyFailCheck() { }

	// RVA: 0x1DA5670 Offset: 0x1DA5771 VA: 0x1DA5670
	public static void Cancel() { }

	// RVA: 0x1DA56C0 Offset: 0x1DA57C1 VA: 0x1DA56C0
	public static bool UpdateData() { }

	// RVA: 0x1DA5850 Offset: 0x1DA5951 VA: 0x1DA5850
	public static WantedData GetAcceptedData() { }

	// RVA: 0x1DA6190 Offset: 0x1DA6291 VA: 0x1DA6190
	public static bool get_isAccepted() { }

	// RVA: 0x1DA61C0 Offset: 0x1DA62C1 VA: 0x1DA61C0
	public static bool get_isFinished() { }

	// RVA: 0x1DA61F0 Offset: 0x1DA62F1 VA: 0x1DA61F0
	public static string GetUITargetMonsterText() { }

	// RVA: 0x1DA50D0 Offset: 0x1DA51D1 VA: 0x1DA50D0
	private static string GetUIPlaceText(WantedFieldType wantedFieldType, int fieldId) { }

	// RVA: 0x1DA6320 Offset: 0x1DA6421 VA: 0x1DA6320
	public static string GetUITargetPlaceText() { }

	// RVA: 0x1DA63A0 Offset: 0x1DA64A1 VA: 0x1DA63A0
	public static string GetAdvTargetPlaceText() { }

	// RVA: 0x1DA6620 Offset: 0x1DA6721 VA: 0x1DA6620
	public static void DoFinish(MonsterControllerBase monsterController) { }

	// RVA: 0x1DA6850 Offset: 0x1DA6951 VA: 0x1DA6850
	public static bool CheckMonster(MonsterDataID monsterDataID) { }

	// RVA: 0x1DA6910 Offset: 0x1DA6A11 VA: 0x1DA6910
	public static bool CheckFinished() { }

	// RVA: 0x1DA69E0 Offset: 0x1DA6AE1 VA: 0x1DA69E0
	public static void UnlockBatch(PoliceBatchId id) { }

	// RVA: 0x1DA6B40 Offset: 0x1DA6C41 VA: 0x1DA6B40
	public static bool GetReward() { }

	// RVA: 0x1DA5990 Offset: 0x1DA5A91 VA: 0x1DA5990
	public static List<WantedData> GetDatas(bool RefreshData = False) { }

	// RVA: 0x1DA7460 Offset: 0x1DA7561 VA: 0x1DA7460
	public static PoliceBatchId DoGetBatch() { }

	// RVA: 0x1DA7570 Offset: 0x1DA7671 VA: 0x1DA7570
	public static void CheckNextStep() { }

	// RVA: 0x1DA7710 Offset: 0x1DA7811 VA: 0x1DA7710
	public static string GetCompletedRewardText() { }

	// RVA: 0x1DA7AA0 Offset: 0x1DA7BA1 VA: 0x1DA7AA0
	public static int GetNewBatchIdForScript() { }

	// RVA: 0x1DA7B10 Offset: 0x1DA7C11 VA: 0x1DA7B10
	public static bool isRankup() { }

	// RVA: 0x1DA7B80 Offset: 0x1DA7C81 VA: 0x1DA7B80
	public static bool isGetBatch() { }

	// RVA: 0x1DA7C00 Offset: 0x1DA7D01 VA: 0x1DA7C00
	public static void Init() { }

	// RVA: 0x1DA7DB0 Offset: 0x1DA7EB1 VA: 0x1DA7DB0
	private static void .cctor() { }
}

public class WantedData // TypeDefIndex: 9802
{
	// Fields
	public int RandomDataNo; // 0x10
	public MonsterDataID monsterDataID; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x17F330 Offset: 0x17F431 VA: 0x17F330
	private WantedID <WantedID>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17F340 Offset: 0x17F441 VA: 0x17F340
	private WantedDataTable.Data <Data>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17F350 Offset: 0x17F451 VA: 0x17F350
	private WantedDataTable.Reward <Reward>k__BackingField; // 0x28
	public int FieldId; // 0x30
	public WantedFieldType FieldType; // 0x34
	private static bool Completed; // 0x0
	private static List<PoliceBatchId> BatchIdGet; // 0x8
	private static bool RankupReady; // 0x10
	private static int AdvBatchId; // 0x14
	private static List<WantedData> wantedDatas; // 0x18
	private static readonly int[] BaseScore; // 0x20

	// Properties
	public WantedID WantedID { get; set; }
	public WantedDataTable.Data Data { get; set; }
	public WantedDataTable.Reward Reward { get; set; }
	public static bool isAccepted { get; }
	public static bool isFinished { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD020 Offset: 0x1AD121 VA: 0x1AD020
	// RVA: 0x1DA45E0 Offset: 0x1DA46E1 VA: 0x1DA45E0
	public WantedID get_WantedID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD030 Offset: 0x1AD131 VA: 0x1AD030
	// RVA: 0x1DA45F0 Offset: 0x1DA46F1 VA: 0x1DA45F0
	private void set_WantedID(WantedID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD040 Offset: 0x1AD141 VA: 0x1AD040
	// RVA: 0x1DA4600 Offset: 0x1DA4701 VA: 0x1DA4600
	public WantedDataTable.Data get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD050 Offset: 0x1AD151 VA: 0x1AD050
	// RVA: 0x1DA4610 Offset: 0x1DA4711 VA: 0x1DA4610
	private void set_Data(WantedDataTable.Data value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD060 Offset: 0x1AD161 VA: 0x1AD060
	// RVA: 0x1DA4620 Offset: 0x1DA4721 VA: 0x1DA4620
	public WantedDataTable.Reward get_Reward() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD070 Offset: 0x1AD171 VA: 0x1AD070
	// RVA: 0x1DA4630 Offset: 0x1DA4731 VA: 0x1DA4630
	private void set_Reward(WantedDataTable.Reward value) { }

	// RVA: 0x1DA4640 Offset: 0x1DA4741 VA: 0x1DA4640
	public void .ctor(WantedDataTable.Data _wantedData, WantedDataTable.Reward _rewardData, WantedID id) { }

	// RVA: 0x1DA46D0 Offset: 0x1DA47D1 VA: 0x1DA46D0
	public void Init(WantedDataTable.Data _wantedData, WantedDataTable.Reward _rewardData, WantedID id) { }

	// RVA: 0x1DA4740 Offset: 0x1DA4841 VA: 0x1DA4740
	public bool CheckShowFinished() { }

	// RVA: 0x1DA4800 Offset: 0x1DA4901 VA: 0x1DA4800
	public bool CheckCanAccept() { }

	// RVA: 0x1DA48D0 Offset: 0x1DA49D1 VA: 0x1DA48D0
	private void GetCompleted(ref int completed, ref int max) { }

	// RVA: 0x1DA4AF0 Offset: 0x1DA4BF1 VA: 0x1DA4AF0
	public bool isCompleted() { }

	// RVA: 0x1DA4B30 Offset: 0x1DA4C31 VA: 0x1DA4B30
	public string CompletedStr() { }

	// RVA: 0x1DA4BE0 Offset: 0x1DA4CE1 VA: 0x1DA4BE0
	public string GroupStr() { }

	// RVA: 0x1DA4E90 Offset: 0x1DA4F91 VA: 0x1DA4E90
	public string AcceptStr() { }

	// RVA: 0x1DA5340 Offset: 0x1DA5441 VA: 0x1DA5340
	public string RewardStr() { }

	// RVA: 0x1DA5550 Offset: 0x1DA5651 VA: 0x1DA5550
	public void Accept() { }

	// RVA: 0x1DA5620 Offset: 0x1DA5721 VA: 0x1DA5620
	public static void MonsterDestroyFailCheck() { }

	// RVA: 0x1DA5670 Offset: 0x1DA5771 VA: 0x1DA5670
	public static void Cancel() { }

	// RVA: 0x1DA56C0 Offset: 0x1DA57C1 VA: 0x1DA56C0
	public static bool UpdateData() { }

	// RVA: 0x1DA5850 Offset: 0x1DA5951 VA: 0x1DA5850
	public static WantedData GetAcceptedData() { }

	// RVA: 0x1DA6190 Offset: 0x1DA6291 VA: 0x1DA6190
	public static bool get_isAccepted() { }

	// RVA: 0x1DA61C0 Offset: 0x1DA62C1 VA: 0x1DA61C0
	public static bool get_isFinished() { }

	// RVA: 0x1DA61F0 Offset: 0x1DA62F1 VA: 0x1DA61F0
	public static string GetUITargetMonsterText() { }

	// RVA: 0x1DA50D0 Offset: 0x1DA51D1 VA: 0x1DA50D0
	private static string GetUIPlaceText(WantedFieldType wantedFieldType, int fieldId) { }

	// RVA: 0x1DA6320 Offset: 0x1DA6421 VA: 0x1DA6320
	public static string GetUITargetPlaceText() { }

	// RVA: 0x1DA63A0 Offset: 0x1DA64A1 VA: 0x1DA63A0
	public static string GetAdvTargetPlaceText() { }

	// RVA: 0x1DA6620 Offset: 0x1DA6721 VA: 0x1DA6620
	public static void DoFinish(MonsterControllerBase monsterController) { }

	// RVA: 0x1DA6850 Offset: 0x1DA6951 VA: 0x1DA6850
	public static bool CheckMonster(MonsterDataID monsterDataID) { }

	// RVA: 0x1DA6910 Offset: 0x1DA6A11 VA: 0x1DA6910
	public static bool CheckFinished() { }

	// RVA: 0x1DA69E0 Offset: 0x1DA6AE1 VA: 0x1DA69E0
	public static void UnlockBatch(PoliceBatchId id) { }

	// RVA: 0x1DA6B40 Offset: 0x1DA6C41 VA: 0x1DA6B40
	public static bool GetReward() { }

	// RVA: 0x1DA5990 Offset: 0x1DA5A91 VA: 0x1DA5990
	public static List<WantedData> GetDatas(bool RefreshData = False) { }

	// RVA: 0x1DA7460 Offset: 0x1DA7561 VA: 0x1DA7460
	public static PoliceBatchId DoGetBatch() { }

	// RVA: 0x1DA7570 Offset: 0x1DA7671 VA: 0x1DA7570
	public static void CheckNextStep() { }

	// RVA: 0x1DA7710 Offset: 0x1DA7811 VA: 0x1DA7710
	public static string GetCompletedRewardText() { }

	// RVA: 0x1DA7AA0 Offset: 0x1DA7BA1 VA: 0x1DA7AA0
	public static int GetNewBatchIdForScript() { }

	// RVA: 0x1DA7B10 Offset: 0x1DA7C11 VA: 0x1DA7B10
	public static bool isRankup() { }

	// RVA: 0x1DA7B80 Offset: 0x1DA7C81 VA: 0x1DA7B80
	public static bool isGetBatch() { }

	// RVA: 0x1DA7C00 Offset: 0x1DA7D01 VA: 0x1DA7C00
	public static void Init() { }

	// RVA: 0x1DA7DB0 Offset: 0x1DA7EB1 VA: 0x1DA7DB0
	private static void .cctor() { }
}

public class WantedData // TypeDefIndex: 9802
{
	// Fields
	public int RandomDataNo; // 0x10
	public MonsterDataID monsterDataID; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x17F330 Offset: 0x17F431 VA: 0x17F330
	private WantedID <WantedID>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17F340 Offset: 0x17F441 VA: 0x17F340
	private WantedDataTable.Data <Data>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17F350 Offset: 0x17F451 VA: 0x17F350
	private WantedDataTable.Reward <Reward>k__BackingField; // 0x28
	public int FieldId; // 0x30
	public WantedFieldType FieldType; // 0x34
	private static bool Completed; // 0x0
	private static List<PoliceBatchId> BatchIdGet; // 0x8
	private static bool RankupReady; // 0x10
	private static int AdvBatchId; // 0x14
	private static List<WantedData> wantedDatas; // 0x18
	private static readonly int[] BaseScore; // 0x20

	// Properties
	public WantedID WantedID { get; set; }
	public WantedDataTable.Data Data { get; set; }
	public WantedDataTable.Reward Reward { get; set; }
	public static bool isAccepted { get; }
	public static bool isFinished { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD020 Offset: 0x1AD121 VA: 0x1AD020
	// RVA: 0x1DA45E0 Offset: 0x1DA46E1 VA: 0x1DA45E0
	public WantedID get_WantedID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD030 Offset: 0x1AD131 VA: 0x1AD030
	// RVA: 0x1DA45F0 Offset: 0x1DA46F1 VA: 0x1DA45F0
	private void set_WantedID(WantedID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD040 Offset: 0x1AD141 VA: 0x1AD040
	// RVA: 0x1DA4600 Offset: 0x1DA4701 VA: 0x1DA4600
	public WantedDataTable.Data get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD050 Offset: 0x1AD151 VA: 0x1AD050
	// RVA: 0x1DA4610 Offset: 0x1DA4711 VA: 0x1DA4610
	private void set_Data(WantedDataTable.Data value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD060 Offset: 0x1AD161 VA: 0x1AD060
	// RVA: 0x1DA4620 Offset: 0x1DA4721 VA: 0x1DA4620
	public WantedDataTable.Reward get_Reward() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD070 Offset: 0x1AD171 VA: 0x1AD070
	// RVA: 0x1DA4630 Offset: 0x1DA4731 VA: 0x1DA4630
	private void set_Reward(WantedDataTable.Reward value) { }

	// RVA: 0x1DA4640 Offset: 0x1DA4741 VA: 0x1DA4640
	public void .ctor(WantedDataTable.Data _wantedData, WantedDataTable.Reward _rewardData, WantedID id) { }

	// RVA: 0x1DA46D0 Offset: 0x1DA47D1 VA: 0x1DA46D0
	public void Init(WantedDataTable.Data _wantedData, WantedDataTable.Reward _rewardData, WantedID id) { }

	// RVA: 0x1DA4740 Offset: 0x1DA4841 VA: 0x1DA4740
	public bool CheckShowFinished() { }

	// RVA: 0x1DA4800 Offset: 0x1DA4901 VA: 0x1DA4800
	public bool CheckCanAccept() { }

	// RVA: 0x1DA48D0 Offset: 0x1DA49D1 VA: 0x1DA48D0
	private void GetCompleted(ref int completed, ref int max) { }

	// RVA: 0x1DA4AF0 Offset: 0x1DA4BF1 VA: 0x1DA4AF0
	public bool isCompleted() { }

	// RVA: 0x1DA4B30 Offset: 0x1DA4C31 VA: 0x1DA4B30
	public string CompletedStr() { }

	// RVA: 0x1DA4BE0 Offset: 0x1DA4CE1 VA: 0x1DA4BE0
	public string GroupStr() { }

	// RVA: 0x1DA4E90 Offset: 0x1DA4F91 VA: 0x1DA4E90
	public string AcceptStr() { }

	// RVA: 0x1DA5340 Offset: 0x1DA5441 VA: 0x1DA5340
	public string RewardStr() { }

	// RVA: 0x1DA5550 Offset: 0x1DA5651 VA: 0x1DA5550
	public void Accept() { }

	// RVA: 0x1DA5620 Offset: 0x1DA5721 VA: 0x1DA5620
	public static void MonsterDestroyFailCheck() { }

	// RVA: 0x1DA5670 Offset: 0x1DA5771 VA: 0x1DA5670
	public static void Cancel() { }

	// RVA: 0x1DA56C0 Offset: 0x1DA57C1 VA: 0x1DA56C0
	public static bool UpdateData() { }

	// RVA: 0x1DA5850 Offset: 0x1DA5951 VA: 0x1DA5850
	public static WantedData GetAcceptedData() { }

	// RVA: 0x1DA6190 Offset: 0x1DA6291 VA: 0x1DA6190
	public static bool get_isAccepted() { }

	// RVA: 0x1DA61C0 Offset: 0x1DA62C1 VA: 0x1DA61C0
	public static bool get_isFinished() { }

	// RVA: 0x1DA61F0 Offset: 0x1DA62F1 VA: 0x1DA61F0
	public static string GetUITargetMonsterText() { }

	// RVA: 0x1DA50D0 Offset: 0x1DA51D1 VA: 0x1DA50D0
	private static string GetUIPlaceText(WantedFieldType wantedFieldType, int fieldId) { }

	// RVA: 0x1DA6320 Offset: 0x1DA6421 VA: 0x1DA6320
	public static string GetUITargetPlaceText() { }

	// RVA: 0x1DA63A0 Offset: 0x1DA64A1 VA: 0x1DA63A0
	public static string GetAdvTargetPlaceText() { }

	// RVA: 0x1DA6620 Offset: 0x1DA6721 VA: 0x1DA6620
	public static void DoFinish(MonsterControllerBase monsterController) { }

	// RVA: 0x1DA6850 Offset: 0x1DA6951 VA: 0x1DA6850
	public static bool CheckMonster(MonsterDataID monsterDataID) { }

	// RVA: 0x1DA6910 Offset: 0x1DA6A11 VA: 0x1DA6910
	public static bool CheckFinished() { }

	// RVA: 0x1DA69E0 Offset: 0x1DA6AE1 VA: 0x1DA69E0
	public static void UnlockBatch(PoliceBatchId id) { }

	// RVA: 0x1DA6B40 Offset: 0x1DA6C41 VA: 0x1DA6B40
	public static bool GetReward() { }

	// RVA: 0x1DA5990 Offset: 0x1DA5A91 VA: 0x1DA5990
	public static List<WantedData> GetDatas(bool RefreshData = False) { }

	// RVA: 0x1DA7460 Offset: 0x1DA7561 VA: 0x1DA7460
	public static PoliceBatchId DoGetBatch() { }

	// RVA: 0x1DA7570 Offset: 0x1DA7671 VA: 0x1DA7570
	public static void CheckNextStep() { }

	// RVA: 0x1DA7710 Offset: 0x1DA7811 VA: 0x1DA7710
	public static string GetCompletedRewardText() { }

	// RVA: 0x1DA7AA0 Offset: 0x1DA7BA1 VA: 0x1DA7AA0
	public static int GetNewBatchIdForScript() { }

	// RVA: 0x1DA7B10 Offset: 0x1DA7C11 VA: 0x1DA7B10
	public static bool isRankup() { }

	// RVA: 0x1DA7B80 Offset: 0x1DA7C81 VA: 0x1DA7B80
	public static bool isGetBatch() { }

	// RVA: 0x1DA7C00 Offset: 0x1DA7D01 VA: 0x1DA7C00
	public static void Init() { }

	// RVA: 0x1DA7DB0 Offset: 0x1DA7EB1 VA: 0x1DA7DB0
	private static void .cctor() { }
}

