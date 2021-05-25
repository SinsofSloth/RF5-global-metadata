[Serializable]
public class OrderManager : SingletonMonoBehaviour<OrderManager> // TypeDefIndex: 7211
{
	// Fields
	private PublicationPlace AccessPlace; // 0x18
	private bool Is1stLottery; // 0x1C
	private int OperationOrderID; // 0x20
	public List<OrderData> AcceptOrderDatas; // 0x28
	private List<OrderData> AcceptOrderDatasHUDBlock; // 0x30
	public const int AcceptOrderMax = 6;
	public const int DuringOrderBoardId = 0;
	public const int DuringOrderDetectiveId = 1;
	public List<OrderData> DuringOrderList; // 0x38
	public List<OrderData> DuringDetectiveList; // 0x40
	public List<OrderData> PublishedBoardOrderList; // 0x48
	public List<OrderData> PublishedDetectiveOrderList; // 0x50
	public List<OrderMasterData>[] NpcOrderDatas; // 0x58
	public OrderRandomData OrderBoardRandomDatas; // 0x60
	public OrderRandomData OrderDetectiveRandomDatas; // 0x68
	public OrderRandomData OrderNpcRandomDatas; // 0x70
	public OrderData LastClearOderData; // 0x78

	// Methods

	// RVA: 0x1F21D10 Offset: 0x1F21E11 VA: 0x1F21D10
	public void SetPublicationPlace(PublicationPlace place) { }

	// RVA: 0x1F21D20 Offset: 0x1F21E21 VA: 0x1F21D20
	public PublicationPlace GetPublicationPlace() { }

	// RVA: 0x1F21D30 Offset: 0x1F21E31 VA: 0x1F21D30
	public int AcceptOrderNum() { }

	// RVA: 0x1F21E40 Offset: 0x1F21F41 VA: 0x1F21E40
	public bool CheckAcceptOrderNum() { }

	// RVA: 0x1F21E60 Offset: 0x1F21F61 VA: 0x1F21E60 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1F21EC0 Offset: 0x1F21FC1 VA: 0x1F21EC0
	private void Start() { }

	// RVA: 0x1F23780 Offset: 0x1F23881 VA: 0x1F23780
	protected void OnDestroy() { }

	// RVA: 0x1F23880 Offset: 0x1F23981 VA: 0x1F23880
	public List<OrderData> CreatePublishedOrderList(PublicationPlace place) { }

	// RVA: 0x1F23B30 Offset: 0x1F23C31 VA: 0x1F23B30
	public int CreatePublishedPoliceOrderList() { }

	// RVA: 0x1F23D60 Offset: 0x1F23E61 VA: 0x1F23D60
	public int CreatePublishedDetectiveOrderList() { }

	// RVA: 0x1F23910 Offset: 0x1F23A11 VA: 0x1F23910
	public void LotteryOnDay(int diff) { }

	// RVA: 0x1F24530 Offset: 0x1F24631 VA: 0x1F24530
	public OrderMasterData GetMasterData(int orderId, int npcid = -1) { }

	// RVA: 0x1F208D0 Offset: 0x1F209D1 VA: 0x1F208D0
	public int GetNowDateForCompleteDate() { }

	// RVA: 0x1F24840 Offset: 0x1F24941 VA: 0x1F24840
	public bool CheckTimeOverDiff(int date, int diffDay) { }

	// RVA: 0x1F241B0 Offset: 0x1F242B1 VA: 0x1F241B0
	public bool IsRepeatOccured(OrderData orderData, OrderMasterData orderMasterData) { }

	// RVA: 0x1F24940 Offset: 0x1F24A41 VA: 0x1F24940
	public int GetCompleteNum() { }

	// RVA: 0x1F24A50 Offset: 0x1F24B51 VA: 0x1F24A50
	public bool IsOrderGotReward(int orderId, int npcId = -1) { }

	// RVA: 0x1F24BF0 Offset: 0x1F24CF1 VA: 0x1F24BF0
	private bool IsOrderOccured(OrderMasterData orderData, int npcId) { }

	// RVA: 0x1F251C0 Offset: 0x1F252C1 VA: 0x1F251C0
	public OrderMasterData GetOccuredOrder(int eventId, int npcId) { }

	// RVA: 0x1F256B0 Offset: 0x1F257B1 VA: 0x1F256B0
	public OrderMasterData GetOccuredNpcRadnomOrder(int eventId, int npcId) { }

	// RVA: 0x1F23F90 Offset: 0x1F24091 VA: 0x1F23F90
	public bool IsOccuredOrderBoard(OrderData orderData) { }

	// RVA: 0x1F24070 Offset: 0x1F24171 VA: 0x1F24070
	public bool IsOccuredOrderBoard(OrderMasterData retOrderData) { }

	// RVA: 0x1F25E60 Offset: 0x1F25F61 VA: 0x1F25E60
	public OrderData AddOrder(int questIdx) { }

	// RVA: 0x1F25560 Offset: 0x1F25661 VA: 0x1F25560
	public OrderData GetOrderData(int eventId, int npcId, int orderId) { }

	// RVA: 0x1F26050 Offset: 0x1F26151 VA: 0x1F26050
	public OrderData GetAcceptingOrderData(int npcId) { }

	// RVA: 0x1F26180 Offset: 0x1F26281 VA: 0x1F26180
	public OrderData GetAcceptOrderData(int orderId) { }

	// RVA: 0x1F262A0 Offset: 0x1F263A1 VA: 0x1F262A0
	public int GetOrderTargetCurrentAmount(int npcId, int orderId) { }

	// RVA: 0x1F263D0 Offset: 0x1F264D1 VA: 0x1F263D0
	public void CompletedAllOrder(int orderId) { }

	// RVA: 0x1F264F0 Offset: 0x1F265F1 VA: 0x1F264F0
	public bool IsSPOrderAccept(int npcId) { }

	// RVA: 0x1F26630 Offset: 0x1F26731 VA: 0x1F26630
	public bool ProceedWithOrder(OrderType orderType, int npcId, int targetId, GameObject gameObject, ItemData item) { }

	// RVA: 0x1F25FD0 Offset: 0x1F260D1 VA: 0x1F25FD0
	public bool IsExistOrderData(OrderData orderData) { }

	// RVA: 0x1F27180 Offset: 0x1F27281 VA: 0x1F27180
	public bool IsExistOrderData(OrderMasterData orderData) { }

	// RVA: 0x1F27000 Offset: 0x1F27101 VA: 0x1F27000
	public bool IsExistOrderData(int currentEventId, int orderNpcId, int orderId, int orderCompleteType, int orderTargetType, int orderTargetId) { }

	// RVA: 0x1F271B0 Offset: 0x1F272B1 VA: 0x1F271B0
	public bool CheckExistMonsterGetOrderData(int MonsterId) { }

	// RVA: 0x1F273A0 Offset: 0x1F274A1 VA: 0x1F273A0
	private int GetCurrentValue_OrderTargetCurrentAmount(OrderData orderData) { }

	// RVA: 0x1F278C0 Offset: 0x1F279C1 VA: 0x1F278C0
	public OrderData AddOrderData(OrderMasterData masterData, string completedEventStep) { }

	// RVA: 0x1F26000 Offset: 0x1F26101 VA: 0x1F26000
	public OrderData AddOrderData(OrderData data, string completedEventStep) { }

	// RVA: 0x1F27960 Offset: 0x1F27A61 VA: 0x1F27960
	private OrderData AddAcceptOrderData(OrderData data) { }

	// RVA: 0x1F28070 Offset: 0x1F28171 VA: 0x1F28070
	public void RegistBoardOrderData(int id, int orderId) { }

	// RVA: 0x1F282E0 Offset: 0x1F283E1 VA: 0x1F282E0
	public bool RegistOrderData(int npcId, int orderId, string CompletedEventStep) { }

	// RVA: 0x1F28570 Offset: 0x1F28671 VA: 0x1F28570
	public void RegistRandomOrderData(int npcId, string CompletedEventStep) { }

	// RVA: 0x1F286B0 Offset: 0x1F287B1 VA: 0x1F286B0
	public void ForceQuestReward(int orderId) { }

	// RVA: 0x1F1CFF0 Offset: 0x1F1D0F1 VA: 0x1F1CFF0
	public void GetQuestReward(int npcId, int orderId) { }

	// RVA: 0x1F28940 Offset: 0x1F28A41 VA: 0x1F28940
	private void ReceiveReward(OrderData orderData, int orderId) { }

	// RVA: 0x1F25D10 Offset: 0x1F25E11 VA: 0x1F25D10
	public OrderMasterData GetOrderMasterData(int npcId, int orderId) { }

	// RVA: 0x1F288C0 Offset: 0x1F289C1 VA: 0x1F288C0
	public OrderMasterData GetRandomOrderMasterData(int npcId, int orderId, OrderData data) { }

	// RVA: 0x1F1CEA0 Offset: 0x1F1CFA1 VA: 0x1F1CEA0
	public int GetOrderIdCanReward(int npcId) { }

	// RVA: 0x1F28FD0 Offset: 0x1F290D1 VA: 0x1F28FD0
	public bool CheckCanOrderFailure(int orderId) { }

	// RVA: 0x1F29130 Offset: 0x1F29231 VA: 0x1F29130
	public void OrderFailureByOrderId(int orderId) { }

	// RVA: 0x1F29360 Offset: 0x1F29461 VA: 0x1F29360
	public void OrderFailureByIndex(int index) { }

	// RVA: 0x1F293F0 Offset: 0x1F294F1 VA: 0x1F293F0
	public void SPOrderFailure(int npcId) { }

	// RVA: 0x1F29770 Offset: 0x1F29871 VA: 0x1F29770
	public void OrderDataInitialize() { }

	// RVA: 0x1F22910 Offset: 0x1F22A11 VA: 0x1F22910
	public void ApplyOrderSaveData() { }

	// RVA: 0x1F29980 Offset: 0x1F29A81 VA: 0x1F29980
	private OrderData GetApplyRandomOrderData(int orderId) { }

	// RVA: 0x1F29CF0 Offset: 0x1F29DF1 VA: 0x1F29CF0
	public void SaveOrderSaveData() { }

	// RVA: 0x1F2A950 Offset: 0x1F2AA51 VA: 0x1F2A950
	public string GetOrderTargetName(int npcId, int orderId) { }

	// RVA: 0x1F2A9E0 Offset: 0x1F2AAE1 VA: 0x1F2A9E0
	private string GetOrderTargetNameBase(OrderType type, int targetId) { }

	// RVA: 0x1F2ABB0 Offset: 0x1F2ACB1 VA: 0x1F2ABB0
	public string GetOrderTargetNameForOverWrite() { }

	// RVA: 0x1F2ACF0 Offset: 0x1F2ADF1 VA: 0x1F2ACF0
	public int GetOrderTargetIdForOverWrite() { }

	// RVA: 0x1F2AE20 Offset: 0x1F2AF21 VA: 0x1F2AE20
	private string GetOrderRewardNameBase(int rewardType, int rewardId) { }

	// RVA: 0x1F2B120 Offset: 0x1F2B221 VA: 0x1F2B120
	public string GetOrderRequestNpcName() { }

	// RVA: 0x1F2B1C0 Offset: 0x1F2B2C1 VA: 0x1F2B1C0
	public string GetOrderRewardNameForOverWrite(int idx = 0) { }

	// RVA: 0x1F2B2F0 Offset: 0x1F2B3F1 VA: 0x1F2B2F0
	public int GetOrderRewardNumForOverWrite(int idx = 0) { }

	// RVA: 0x1F2B3E0 Offset: 0x1F2B4E1 VA: 0x1F2B3E0
	public string Debug_AcceptOrderDatasView() { }

	// RVA: 0x1F2B430 Offset: 0x1F2B531 VA: 0x1F2B430
	public void DEBUG_Lottery() { }

	// RVA: 0x1F2B440 Offset: 0x1F2B541 VA: 0x1F2B440
	public void DEBUG_RegistOrderData(int orderId) { }

	// RVA: 0x1F2B450 Offset: 0x1F2B551 VA: 0x1F2B450
	public void DEBUG_ReleaseOrder(int orderId) { }

	// RVA: 0x1F2B460 Offset: 0x1F2B561 VA: 0x1F2B460
	public void DEBUG_ClearOrder() { }

	// RVA: 0x1F2B470 Offset: 0x1F2B571 VA: 0x1F2B470
	public int DEBUG_GetOrderIdByIndex(int index) { }

	// RVA: 0x1F2B480 Offset: 0x1F2B581 VA: 0x1F2B480
	public int DEBUG_OrderNum() { }

	// RVA: 0x1F2B490 Offset: 0x1F2B591 VA: 0x1F2B490
	public int DEBUG_GetPublishedBoardOrderIdByIndex(int index) { }

	// RVA: 0x1F2B4A0 Offset: 0x1F2B5A1 VA: 0x1F2B4A0
	public int DEBUG_PublishedBoardOrderNum() { }

	// RVA: 0x1F2B4B0 Offset: 0x1F2B5B1 VA: 0x1F2B4B0
	public int DEBUG_NPCRandomOrderIdByIndex(int index) { }

	// RVA: 0x1F2B4C0 Offset: 0x1F2B5C1 VA: 0x1F2B4C0
	public int DEBUG_NPCRandomOrderNum() { }

	// RVA: 0x1F2B4D0 Offset: 0x1F2B5D1 VA: 0x1F2B4D0
	public void DEBUG_AcceptOrdersComplete() { }

	// RVA: 0x1F2B4E0 Offset: 0x1F2B5E1 VA: 0x1F2B4E0
	public List<int> DEBUG_NpcRandomOrderIDList() { }

	// RVA: 0x1F2B4F0 Offset: 0x1F2B5F1 VA: 0x1F2B4F0
	public void DEBUG_NPCRegistRandomOrderId(int id) { }

	// RVA: 0x1F2B500 Offset: 0x1F2B601 VA: 0x1F2B500
	public void .ctor() { }
}

