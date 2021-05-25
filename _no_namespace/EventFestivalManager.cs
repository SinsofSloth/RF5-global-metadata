public class EventFestivalManager // TypeDefIndex: 7153
{
	// Fields
	public FesNpcScoreTable FesNpcScoreDatas; // 0x10
	public bool IsAcceptEventItem; // 0x18
	private string myItemName; // 0x20
	public int[] Ranker; // 0x28
	public bool IsHandMadeEventItem; // 0x30
	public bool IsNotEatEventItem; // 0x31
	public bool IsArrangeEventItem; // 0x32
	public float TasteLevel; // 0x34
	public float NutritionLevel; // 0x38
	public float EvaluationLevel; // 0x3C
	public int IsLikeFood; // 0x40
	public bool IsPumpkinFood; // 0x44
	public bool IsSeasonFood; // 0x45
	public float GrowLevel; // 0x48
	public float QualityLevel; // 0x4C
	public float AppealLevel; // 0x50
	public float MaterialLevel; // 0x54
	public float ComprehensiveLevel; // 0x58
	public float DifficultyLevel; // 0x5C
	public bool IsHotarubiDateSelect; // 0x60
	public int HotarubiDateCanselNo; // 0x64
	public int HotarubiNpcId; // 0x68
	public float MiniGameScoreF; // 0x6C
	public List<ActorID> MiniGamePetRanking; // 0x70
	public List<FesNpcScore> FesMemorialNpcScoreList; // 0x78
	public List<ActorID> FesMemorialJoinActorList; // 0x80
	public List<ActorID> FesMemorialVisitorActorList; // 0x88
	public float myScore; // 0x90
	private int[,,] ScoreTableAppear; // 0x98
	private int[,,] ScoreTable; // 0xA0
	private int[,,] WinnerScoreTable; // 0xA8
	private string[,,] FesTimeTable; // 0xB0
	private ItemID[,] FlowerPresentTable; // 0xB8
	private int[] MinigamePointTable; // 0xC0

	// Properties
	public bool HasFishingRod { get; }

	// Methods

	// RVA: 0x203B6B0 Offset: 0x203B7B1 VA: 0x203B6B0
	public void SetMyScore(float value) { }

	// RVA: 0x203B6C0 Offset: 0x203B7C1 VA: 0x203B6C0
	public string GetMyScoreResult() { }

	// RVA: 0x203B860 Offset: 0x203B961 VA: 0x203B860
	public void Start() { }

	// RVA: 0x203B920 Offset: 0x203BA21 VA: 0x203B920
	public bool get_HasFishingRod() { }

	// RVA: 0x203BB20 Offset: 0x203BC21 VA: 0x203BB20
	private bool IsFishongRod(ItemID itemID) { }

	// RVA: 0x203BB30 Offset: 0x203BC31 VA: 0x203BB30
	public bool IsSendFesPresent(ActorID actorID) { }

	// RVA: 0x203BBA0 Offset: 0x203BCA1 VA: 0x203BBA0
	public bool IsRecvFesPresent(ActorID actorID) { }

	// RVA: 0x203BC10 Offset: 0x203BD11 VA: 0x203BC10
	public void AddPresentSendActor(ActorID actorID) { }

	// RVA: 0x203BC80 Offset: 0x203BD81 VA: 0x203BC80
	public void AddPresentRecvActor(ActorID actorID) { }

	// RVA: 0x203BE10 Offset: 0x203BF11 VA: 0x203BE10
	private ItemID GetPresentFlowerId(ActorID actorID) { }

	// RVA: 0x203C020 Offset: 0x203C121 VA: 0x203C020
	public string GetPresentFlowerName() { }

	// RVA: 0x203C100 Offset: 0x203C201 VA: 0x203C100
	public void Reset(int FesId) { }

	// RVA: 0x203C3E0 Offset: 0x203C4E1 VA: 0x203C3E0
	public bool IsContestFes(Event FesId) { }

	// RVA: 0x203C410 Offset: 0x203C511 VA: 0x203C410
	public bool AcceptEventItem(Event FesId, HumanController causer, int npcId) { }

	// RVA: 0x203D4F0 Offset: 0x203D5F1 VA: 0x203D4F0
	private bool IsVeryFavoriteItem(NpcStatusData statusData, int itemId) { }

	// RVA: 0x203D560 Offset: 0x203D661 VA: 0x203D560
	private bool IsFavoriteItem(NpcStatusData statusData, int itemId) { }

	// RVA: 0x203D5D0 Offset: 0x203D6D1 VA: 0x203D5D0
	private bool IsNotFavoriteBadlyItem(NpcStatusData statusData, int itemId) { }

	// RVA: 0x203D640 Offset: 0x203D741 VA: 0x203D640
	private bool IsNotFavoriteItem(NpcStatusData statusData, int itemId) { }

	// RVA: 0x203D010 Offset: 0x203D111 VA: 0x203D010
	private void CalcFesScore_Sweets(int JudgeChildId, ItemData itemData) { }

	// RVA: 0x203D6B0 Offset: 0x203D7B1 VA: 0x203D6B0
	private bool IsSweets(ItemID itemID) { }

	// RVA: 0x203CB00 Offset: 0x203CC01 VA: 0x203CB00
	private void CalcFesScore_Cook(ItemData itemData, bool is_sweets = False) { }

	// RVA: 0x203CE60 Offset: 0x203CF61 VA: 0x203CE60
	public float CalacVegetableContest(HumanController causer) { }

	// RVA: 0x203D790 Offset: 0x203D891 VA: 0x203D790
	private bool IsVegetablesContest(int FesId) { }

	// RVA: 0x203D7D0 Offset: 0x203D8D1 VA: 0x203D7D0
	private bool IsChild(int npcId) { }

	// RVA: 0x203D7E0 Offset: 0x203D8E1 VA: 0x203D7E0
	public bool CalcFesScore() { }

	// RVA: 0x203FCA0 Offset: 0x203FDA1 VA: 0x203FCA0
	public void CompareRivalScore(int FesId, float myScore) { }

	// RVA: 0x203B800 Offset: 0x203B901 VA: 0x203B800
	public Event GetTodayFesEventId() { }

	// RVA: 0x20407B0 Offset: 0x20408B1 VA: 0x20407B0
	public int GetPlayerRank() { }

	// RVA: 0x2040880 Offset: 0x2040981 VA: 0x2040880
	public string GetFesSeason() { }

	// RVA: 0x20409C0 Offset: 0x2040AC1 VA: 0x20409C0
	public string GetFesName() { }

	// RVA: 0x2040BA0 Offset: 0x2040CA1 VA: 0x2040BA0
	public string GetFesReceptionTime(int type) { }

	// RVA: 0x2040E10 Offset: 0x2040F11 VA: 0x2040E10
	public string GetFesPlayerItem() { }

	// RVA: 0x2040E20 Offset: 0x2040F21 VA: 0x2040E20
	public string GetFesRank1Name() { }

	// RVA: 0x20413B0 Offset: 0x20414B1 VA: 0x20413B0
	public string GetFesRank2Name() { }

	// RVA: 0x20417C0 Offset: 0x20418C1 VA: 0x20417C0
	public string GetFesRank3Name() { }

	// RVA: 0x2041BD0 Offset: 0x2041CD1 VA: 0x2041BD0
	public string GetFesRank1Score() { }

	// RVA: 0x2041E30 Offset: 0x2041F31 VA: 0x2041E30
	public string GetFesRank2Score() { }

	// RVA: 0x20420E0 Offset: 0x20421E1 VA: 0x20420E0
	public string GetFesRank3Score() { }

	// RVA: 0x20423A0 Offset: 0x20424A1 VA: 0x20423A0
	public string GetFesUnit() { }

	// RVA: 0x203F990 Offset: 0x203FA91 VA: 0x203F990
	public int GetScoreIdx(int FesId) { }

	// RVA: 0x2042590 Offset: 0x2042691 VA: 0x2042590
	public void AddAppealScore(int score) { }

	// RVA: 0x20425B0 Offset: 0x20426B1 VA: 0x20425B0
	public void SelectHotarubiDate() { }

	// RVA: 0x2042C10 Offset: 0x2042D11 VA: 0x2042C10
	public int GetHotarubiNpc(int idx) { }

	// RVA: 0x2042D50 Offset: 0x2042E51 VA: 0x2042D50
	public void CheckHotarubiDate() { }

	// RVA: 0x2042F80 Offset: 0x2043081 VA: 0x2042F80
	public void AddFishCount(int fishType, bool isIka) { }

	// RVA: 0x20430B0 Offset: 0x20431B1 VA: 0x20430B0
	public void JudgeChildMsg() { }

	// RVA: 0x20432B0 Offset: 0x20433B1 VA: 0x20432B0
	public bool FesNearCandidate() { }

	// RVA: 0x2043430 Offset: 0x2043531 VA: 0x2043430
	public bool IsFesInNo3() { }

	// RVA: 0x20434A0 Offset: 0x20435A1 VA: 0x20434A0
	public void ReturnFesItem(Vector3 pos) { }

	// RVA: 0x2043540 Offset: 0x2043641 VA: 0x2043540
	public void SpawnFestivalTreasureBox() { }

	// RVA: 0x2043B50 Offset: 0x2043C51 VA: 0x2043B50
	public void RemoveFestivalTreasureBox() { }

	// RVA: 0x203FA70 Offset: 0x203FB71 VA: 0x203FA70
	public bool CanJoinFestival(int npcId) { }

	// RVA: 0x2043BD0 Offset: 0x2043CD1 VA: 0x2043BD0
	public void CalcFesMemorialScore(Event eventId) { }

	// RVA: 0x203F7F0 Offset: 0x203F8F1 VA: 0x203F7F0
	public bool IsImportantNpcOuting(int fesId) { }

	// RVA: 0x2044840 Offset: 0x2044941 VA: 0x2044840
	public void .ctor() { }
}

