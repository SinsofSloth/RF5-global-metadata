public class EventFlagManager // TypeDefIndex: 7156
{
	// Fields
	public EventUnlockFlag EventUnlockFlagDatas; // 0x10
	public EventPoint EventPointDatas; // 0x18
	public MainEventFlagProgress MainEventFlagProgressDatas; // 0x20
	public EventFlagProgress EventFlagProgressDatas; // 0x28
	public SubEventFlagProgress SubEventFlagProgressDatas; // 0x30
	public TutorialUnlockFlag TutorialUnlockFlagDatas; // 0x38
	public bool CheckPass; // 0x40
	public List<int> PointOnFlagList; // 0x48
	public List<int> StoryFlagList; // 0x50
	public List<int> DeleteFlagList; // 0x58
	public List<EventUnlockFlagData> activeEventStartPointList; // 0x60
	public List<EventUnlockFlagData> reserveEventPointList; // 0x68
	private List<EventFlagManager.RequestDisableEventPointData> ReqestDisableEventPointList; // 0x70
	private int BeforeCheckTime; // 0x78
	public EventStartPoint[] EventStartPoints; // 0x80
	private static readonly string EventStartPointParentName; // 0x0
	private static Dictionary<GameFlagData, NPCID> NpcOutingDic; // 0x8
	private static Dictionary<GameFlagData, NPCID> NpcAutoPartnerDic; // 0x10

	// Methods

	// RVA: 0x2046100 Offset: 0x2046201 VA: 0x2046100
	public EventPointData GetEventPointData(EventPointID EventPointId) { }

	// RVA: 0x2046220 Offset: 0x2046321 VA: 0x2046220
	public EventUnlockFlagData GetEventUnlockDataByPointOnFlag(GameFlagData pointOnFlag) { }

	// RVA: 0x2046300 Offset: 0x2046401 VA: 0x2046300
	public EventUnlockFlagData GetEventUnlockData(EventScriptID scriptId) { }

	// RVA: 0x20463E0 Offset: 0x20464E1 VA: 0x20463E0
	public EventUnlockFlagData GetNextEventUnlockData(EventScriptID scriptId) { }

	// RVA: 0x20464E0 Offset: 0x20465E1 VA: 0x20464E0
	public List<EventUnlockFlagData> GetActivePointData() { }

	// RVA: 0x20464F0 Offset: 0x20465F1 VA: 0x20464F0
	public void Start() { }

	// RVA: 0x2046BD0 Offset: 0x2046CD1 VA: 0x2046BD0
	public void FixedUpdate() { }

	// RVA: 0x2046D00 Offset: 0x2046E01 VA: 0x2046D00
	public void CheckTimeReset() { }

	// RVA: 0x2046D10 Offset: 0x2046E11 VA: 0x2046D10
	public void AllFlagReset() { }

	// RVA: 0x2046FC0 Offset: 0x20470C1 VA: 0x2046FC0
	public void SaveEventStartPoints() { }

	// RVA: 0x2047120 Offset: 0x2047221 VA: 0x2047120
	public void LoadEventStartPoints() { }

	// RVA: 0x2046CD0 Offset: 0x2046DD1 VA: 0x2046CD0
	public void UpdateActivePointData() { }

	// RVA: 0x2047600 Offset: 0x2047701 VA: 0x2047600
	private void UpdateEventPointActive() { }

	// RVA: 0x2047B80 Offset: 0x2047C81 VA: 0x2047B80
	private void EnableEventPoint(EventUnlockFlagData unlockData) { }

	// RVA: 0x2047A20 Offset: 0x2047B21 VA: 0x2047A20
	private void DisableEventPoint(EventUnlockFlagData unlockData) { }

	// RVA: 0x2047280 Offset: 0x2047381 VA: 0x2047280
	private void CheckReserveEventEventPointList() { }

	// RVA: 0x2047B50 Offset: 0x2047C51 VA: 0x2047B50
	public bool CheckEventFlag(EventUnlockFlagData data) { }

	// RVA: 0x2048060 Offset: 0x2048161 VA: 0x2048060
	public bool CheckEventFlag(EventUnlockFlagData data, out GameFlagData hitFlag) { }

	// RVA: 0x20489D0 Offset: 0x2048AD1 VA: 0x20489D0
	public bool CheckEventFlag(string scriptName) { }

	// RVA: 0x2048B70 Offset: 0x2048C71 VA: 0x2048B70
	public bool CheckEventFlagUnlock(GameFlagData flagId) { }

	// RVA: 0x20493D0 Offset: 0x20494D1 VA: 0x20493D0
	public void EventFlagOnOff(string scriptName) { }

	// RVA: 0x2049B70 Offset: 0x2049C71 VA: 0x2049B70
	private bool IsLoveStoryFlag(GameFlagData Flag) { }

	// RVA: 0x2049B80 Offset: 0x2049C81 VA: 0x2049B80
	private void SetLoveStoryProgress(GameFlagData Flag) { }

	// RVA: 0x2049E40 Offset: 0x2049F41 VA: 0x2049E40
	public void ApplyFlagSetting(bool on, GameFlagData flagId) { }

	// RVA: 0x204A3A0 Offset: 0x204A4A1 VA: 0x204A3A0
	private void NpcPartyOut(NPCID npcId) { }

	// RVA: 0x204A830 Offset: 0x204A931 VA: 0x204A830
	private void NpcPartyIn(NPCID npcId) { }

	// RVA: 0x204A8B0 Offset: 0x204A9B1 VA: 0x204A8B0
	public void EventPointOnOff(bool on, GameFlagData flagId) { }

	// RVA: 0x204A990 Offset: 0x204AA91 VA: 0x204A990
	public void EventPointOnOff_Base(bool on, GameFlagData flagId) { }

	// RVA: 0x204A580 Offset: 0x204A681 VA: 0x204A580
	private void UpdateBossEventPoint(bool isOn, GameFlagData flagId) { }

	// RVA: 0x2047D90 Offset: 0x2047E91 VA: 0x2047D90
	private void RegistActiveEventPointList(EventUnlockFlagData unlockData) { }

	// RVA: 0x204AED0 Offset: 0x204AFD1 VA: 0x204AED0
	private void RemoveEventPointData(EventUnlockFlagData data) { }

	// RVA: 0x204B110 Offset: 0x204B211 VA: 0x204B110
	public void RemoveEventPointByPointOnFlag(GameFlagData pointOnFlag) { }

	// RVA: 0x204B250 Offset: 0x204B351 VA: 0x204B250
	public bool IsSameEventPointId(EventStartPoint eventStartPoint, EventUnlockFlagData eventPoint) { }

	// RVA: 0x204B280 Offset: 0x204B381 VA: 0x204B280
	public bool IsSameScriptId(EventStartPoint eventStartPoint, EventUnlockFlagData eventPoint) { }

	// RVA: 0x204B2B0 Offset: 0x204B3B1 VA: 0x204B2B0
	public int GetEventFlagProgress(int npcid) { }

	// RVA: 0x204B330 Offset: 0x204B431 VA: 0x204B330
	public void DEBUG_SetLoveStoryState(int idx, int state) { }

	// RVA: 0x204B510 Offset: 0x204B611 VA: 0x204B510
	public void RequestDisableEventPoint(EventStartPoint eventStartPoint) { }

	// RVA: 0x204B610 Offset: 0x204B711 VA: 0x204B610
	public void ExecuteDisableEventPoint() { }

	// RVA: 0x204B930 Offset: 0x204BA31 VA: 0x204B930
	public bool IsReqestedDisabled(EventStartPoint eventStartPoint) { }

	// RVA: 0x204BA20 Offset: 0x204BB21 VA: 0x204BA20
	public bool CheckCallTutorialScript(TutorialScriptType type) { }

	// RVA: 0x204C490 Offset: 0x204C591 VA: 0x204C490
	private void SetTutorialScriptCall(TutorialScriptType type, bool npcTalk = False) { }

	// RVA: 0x204C620 Offset: 0x204C721 VA: 0x204C620
	public void LotterySubEventEventFlag() { }

	// RVA: 0x204CA90 Offset: 0x204CB91 VA: 0x204CA90
	public void SetEventFlagFromScriptDebug(string scriptName) { }

	// RVA: 0x204CB90 Offset: 0x204CC91 VA: 0x204CB90
	public void SetEventFlagFromDebug(GameFlagData SelectEventFlagId) { }

	// RVA: 0x204D3B0 Offset: 0x204D4B1 VA: 0x204D3B0
	public int GetCurrentMainScenarioProgress() { }

	// RVA: 0x204D450 Offset: 0x204D551 VA: 0x204D450
	public MainEventFlagProgressData GetCurrentMainScenarioData() { }

	// RVA: 0x2046AB0 Offset: 0x2046BB1 VA: 0x2046AB0
	public void InitEventStartPoints() { }

	// RVA: 0x2047CD0 Offset: 0x2047DD1 VA: 0x2047CD0
	public EventStartPoint GetEventStartPoint(EventPointID eventPointID) { }

	// RVA: 0x204D760 Offset: 0x204D861 VA: 0x204D760
	public EventStartPoint GetEventStartPoint(string name) { }

	// RVA: 0x2046EC0 Offset: 0x2046FC1 VA: 0x2046EC0
	public void ResetAllEventStartPoint() { }

	// RVA: 0x204D860 Offset: 0x204D961 VA: 0x204D860
	public int GetStoryFlag(string scriptName) { }

	// RVA: 0x204D9E0 Offset: 0x204DAE1 VA: 0x204D9E0
	public void .ctor() { }

	// RVA: 0x204DAD0 Offset: 0x204DBD1 VA: 0x204DAD0
	private static void .cctor() { }
}

