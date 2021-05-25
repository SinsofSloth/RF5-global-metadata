public class LovePointManager // TypeDefIndex: 7189
{
	// Fields
	private readonly int[] LovePointTable; // 0x10
	private readonly int[] LovePointRiseTable; // 0x18
	private readonly Dictionary<ActorID, RF5SystemData.FLAG> ActorIDToSystemFlag; // 0x20
	private readonly int[] FriendshipNpcList; // 0x28

	// Methods

	// RVA: 0x1E09A00 Offset: 0x1E09B01 VA: 0x1E09A00
	public int GetLovePointRise(LovePointManager.FluctuationType type) { }

	// RVA: 0x1E09AA0 Offset: 0x1E09BA1 VA: 0x1E09AA0
	private bool IsTradesman(int npcID) { }

	// RVA: 0x1E09B10 Offset: 0x1E09C11 VA: 0x1E09B10
	private int GetFRIENDSHIP_ON_ID(int npcID) { }

	// RVA: 0x1E09B90 Offset: 0x1E09C91 VA: 0x1E09B90
	public bool IsNpcLifCycleActive(int _npcID) { }

	// RVA: 0x1E09C30 Offset: 0x1E09D31 VA: 0x1E09C30
	public bool IsFriendActive(int _npcID) { }

	// RVA: 0x1E09D90 Offset: 0x1E09E91 VA: 0x1E09D90
	private int CheckLimit(int npcId, int lovePoint, int addPoint) { }

	// RVA: 0x1E09F40 Offset: 0x1E0A041 VA: 0x1E09F40
	private int Add(int npcId, int lovePoint, int addPoint) { }

	// RVA: 0x1E09F80 Offset: 0x1E0A081 VA: 0x1E09F80
	public bool IsBirthDay(int npcID) { }

	// RVA: 0x1E0A010 Offset: 0x1E0A111 VA: 0x1E0A010
	public bool IsBirthDayByDate(int npcID, Season _season, int _day) { }

	// RVA: 0x1E0A2A0 Offset: 0x1E0A3A1 VA: 0x1E0A2A0
	public bool CheckPresentRestriction(int npcID, int itemID) { }

	// RVA: 0x1E0A2C0 Offset: 0x1E0A3C1 VA: 0x1E0A2C0
	public LovePointManager.FavoriteType GetFavoriteType(int npcID, int itemID) { }

	// RVA: 0x1E0A530 Offset: 0x1E0A631 VA: 0x1E0A530
	public bool IsLoveDrink(int itemID) { }

	// RVA: 0x1E0A540 Offset: 0x1E0A641 VA: 0x1E0A540
	public int GetNextLvPoint(int point) { }

	// RVA: 0x1E0A590 Offset: 0x1E0A691 VA: 0x1E0A590
	public int GetLoveLvByData(NpcData npcData) { }

	// RVA: 0x1E09F10 Offset: 0x1E0A011 VA: 0x1E09F10
	public int GetLoveLvByPoint(int point) { }

	// RVA: 0x1E0A710 Offset: 0x1E0A811 VA: 0x1E0A710
	public int GetLoveLvByNpcData(NpcData npcData) { }

	// RVA: 0x1E0A720 Offset: 0x1E0A821 VA: 0x1E0A720
	public int GetNowLvPer(int actorId) { }

	// RVA: 0x1E0A580 Offset: 0x1E0A681 VA: 0x1E0A580
	public int GetLoveLvBase(int point, out int next) { }

	// RVA: 0x1E0A7C0 Offset: 0x1E0A8C1 VA: 0x1E0A7C0
	public int GetLoveLvBase2(int point, out int next, bool returnPer = False) { }

	// RVA: 0x1E0AAB0 Offset: 0x1E0ABB1 VA: 0x1E0AAB0
	public int GetLoveLv(int npcID) { }

	// RVA: 0x1E0AB50 Offset: 0x1E0AC51 VA: 0x1E0AB50
	public int GetLowestLoveLv() { }

	// RVA: 0x1E09A40 Offset: 0x1E09B41 VA: 0x1E09A40
	private int GetAddLovePoint(LovePointManager.FluctuationType type, LovePointManager.FavoriteType fType = 5) { }

	// RVA: 0x1E0ACF0 Offset: 0x1E0ADF1 VA: 0x1E0ACF0
	public int AddLovePoint(LovePointManager.FluctuationType type, int npcID, int itemID, bool isOriginal = False) { }

	// RVA: 0x1E0ADA0 Offset: 0x1E0AEA1 VA: 0x1E0ADA0
	public int AddLovePoint(LovePointManager.FluctuationType type, NpcData npcData, int itemID, bool isOriginal = False) { }

	// RVA: 0x1E0B3C0 Offset: 0x1E0B4C1 VA: 0x1E0B3C0
	public int AddLovePoint(LovePointManager.FluctuationType type, int npcID) { }

	// RVA: 0x1E0B190 Offset: 0x1E0B291 VA: 0x1E0B190
	public void SetLoveLv(int npcID, int lv) { }

	// RVA: 0x1E0B460 Offset: 0x1E0B561 VA: 0x1E0B460
	public void Debug10AddLovePoint(int npcID) { }

	// RVA: 0x1E0B500 Offset: 0x1E0B601 VA: 0x1E0B500
	public void Debug100AddLovePoint(int npcID) { }

	// RVA: 0x1E0B5A0 Offset: 0x1E0B6A1 VA: 0x1E0B5A0
	public void Debug1000AddLovePoint(int npcID) { }

	// RVA: 0x1E0B640 Offset: 0x1E0B741 VA: 0x1E0B640
	public void DebugAddLovePoint(int npcID, int addPoint) { }

	// RVA: 0x1E0B720 Offset: 0x1E0B821 VA: 0x1E0B720
	public void DebugSetLoveLv(int npcID, int lv) { }

	// RVA: 0x1E0B730 Offset: 0x1E0B831 VA: 0x1E0B730
	public void DebugLovePointView() { }

	// RVA: 0x1E0B740 Offset: 0x1E0B841 VA: 0x1E0B740
	public void .ctor() { }
}

