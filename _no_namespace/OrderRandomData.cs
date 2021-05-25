public class OrderRandomData // TypeDefIndex: 7215
{
	// Fields
	public Dictionary<int, Dictionary<int, List<OrderMasterData>>> OrderRandomDatas; // 0x10
	public List<OrderData> LotteryDatas; // 0x18
	private List<int> keysList; // 0x20
	private List<int> keysList2; // 0x28
	private int OfferMax; // 0x30
	private PublicationPlace PublicationType; // 0x34

	// Methods

	// RVA: 0x1F2B5E0 Offset: 0x1F2B6E1 VA: 0x1F2B5E0
	public void .ctor(PublicationPlace place, int offerMax = 1) { }

	// RVA: 0x1F29920 Offset: 0x1F29A21 VA: 0x1F29920
	public void InitializeLottery() { }

	// RVA: 0x1F22730 Offset: 0x1F22831 VA: 0x1F22730
	public void AddOrderData(OrderMasterData data) { }

	// RVA: 0x1F2C1B0 Offset: 0x1F2C2B1 VA: 0x1F2C1B0
	public void ApplyLotteryData(OrderMasterData master) { }

	// RVA: 0x1F2C240 Offset: 0x1F2C341 VA: 0x1F2C240
	public void ApplyLotteryData(OrderData data) { }

	// RVA: 0x1F24230 Offset: 0x1F24331 VA: 0x1F24230
	public void LotteryOnDay(List<OrderData> accDatas, List<OrderData> lotteryOrder) { }

	// RVA: 0x1F2CAF0 Offset: 0x1F2CBF1 VA: 0x1F2CAF0
	private void LotteryBoard() { }

	// RVA: 0x1F2C820 Offset: 0x1F2C921 VA: 0x1F2C820
	private void LotteryTantei(List<OrderData> lotteryOrder) { }

	// RVA: 0x1F2C3A0 Offset: 0x1F2C4A1 VA: 0x1F2C3A0
	private void LotteryNpc() { }

	// RVA: 0x1F2CB80 Offset: 0x1F2CC81 VA: 0x1F2CB80
	public OrderData LotteryData() { }

	// RVA: 0x1F2D7E0 Offset: 0x1F2D8E1 VA: 0x1F2D7E0
	public bool IsOrderRandamID(int npcId, int randomType) { }

	// RVA: 0x1F2D1A0 Offset: 0x1F2D2A1 VA: 0x1F2D1A0
	public OrderData LotteryData(int npcId, int randomType) { }

	// RVA: 0x1F24060 Offset: 0x1F24161 VA: 0x1F24060
	public OrderMasterData GetMasterData_Board(int orderId, int npcId = -1, int orderType = 0) { }

	// RVA: 0x1F25D00 Offset: 0x1F25E01 VA: 0x1F25D00
	public OrderMasterData GetMasterData_Npc(int orderId, int npcId = -1, int randomId = 0) { }

	// RVA: 0x1F2CB90 Offset: 0x1F2CC91 VA: 0x1F2CB90
	private OrderMasterData GetMasterData(int orderId, int npcId = -1, int type = 0) { }

	// RVA: 0x1F2D8A0 Offset: 0x1F2D9A1 VA: 0x1F2D8A0
	public OrderData GetLotteryDatasByIndex(int index) { }

	// RVA: 0x1F2D950 Offset: 0x1F2DA51 VA: 0x1F2D950
	public OrderData GetLotteryDatasById(int id) { }
}

