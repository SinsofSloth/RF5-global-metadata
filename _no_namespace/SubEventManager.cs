public class SubEventManager // TypeDefIndex: 7280
{
	// Fields
	private const int GIVEBIRTH_BBY_ID_BASE = 1;
	private List<SubEventMasterDataBase> SubEventDatas; // 0x10
	private List<SubEventData> OccurrenceSubEventDatas; // 0x18
	public GiveBirthController BirthController; // 0x20
	public int LastOccurrenceTime; // 0x28
	private int LastProceedAdvEventId; // 0x2C
	private bool IsRegistOnHourCarry; // 0x30
	private bool IsRegistOnSecondCarry; // 0x31
	[CompilerGeneratedAttribute] // RVA: 0x165480 Offset: 0x165581 VA: 0x165480
	private bool <IsSelectDating>k__BackingField; // 0x32

	// Properties
	public bool IsSelectDating { get; set; }
	public bool IsOccurrenceSubEvent { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19F370 Offset: 0x19F471 VA: 0x19F370
	// RVA: 0x2251F10 Offset: 0x2252011 VA: 0x2251F10
	public bool get_IsSelectDating() { }

	[CompilerGeneratedAttribute] // RVA: 0x19F380 Offset: 0x19F481 VA: 0x19F380
	// RVA: 0x2251F20 Offset: 0x2252021 VA: 0x2251F20
	private void set_IsSelectDating(bool value) { }

	// RVA: 0x2251F30 Offset: 0x2252031 VA: 0x2251F30
	public bool get_IsOccurrenceSubEvent() { }

	// RVA: 0x2251F90 Offset: 0x2252091 VA: 0x2251F90
	public void .ctor() { }

	// RVA: 0x22520D0 Offset: 0x22521D1 VA: 0x22520D0
	private void Initialize() { }

	// RVA: 0x2252140 Offset: 0x2252241 VA: 0x2252140
	private void InitializeSaveData() { }

	// RVA: 0x2252220 Offset: 0x2252321 VA: 0x2252220
	public void UpdateSubEventSaveData() { }

	// RVA: 0x2252230 Offset: 0x2252331 VA: 0x2252230
	public void ApplySubEventSaveData() { }

	// RVA: 0x22522A0 Offset: 0x22523A1 VA: 0x22522A0
	public void SubEventDataInitializeForNewGame() { }

	// RVA: 0x2252320 Offset: 0x2252421 VA: 0x2252320
	private void RegistOnHourCarry() { }

	// RVA: 0x2252400 Offset: 0x2252501 VA: 0x2252400
	private void RegistOnSecondCarry() { }

	// RVA: 0x22524E0 Offset: 0x22525E1 VA: 0x22524E0
	private void OnHourCarry(int diffHour) { }

	// RVA: 0x2252540 Offset: 0x2252641 VA: 0x2252540
	public void WakeUpUpdateSubEventData(int diffDay) { }

	// RVA: 0x2252560 Offset: 0x2252661 VA: 0x2252560
	private void AddAcceptSubEventData() { }

	// RVA: 0x2252D40 Offset: 0x2252E41 VA: 0x2252D40
	private void AcceptSubEventData(SubEventMasterDataBase eventData) { }

	// RVA: 0x2253120 Offset: 0x2253221 VA: 0x2253120
	private void SubEventStartScript(SubEventMasterDataBase eventData, int step = 0) { }

	[IteratorStateMachineAttribute] // RVA: 0x19F390 Offset: 0x19F491 VA: 0x19F390
	// RVA: 0x2253130 Offset: 0x2253231 VA: 0x2253130
	private IEnumerator RunBirthChildScript() { }

	// RVA: 0x2252FC0 Offset: 0x22530C1 VA: 0x2252FC0
	private SubEventData CreateAddEventData(SubEventMasterDataBase masterData) { }

	// RVA: 0x22525A0 Offset: 0x22526A1 VA: 0x22525A0
	private SubEventMasterDataBase GetOccurringSubEventData() { }

	// RVA: 0x22533B0 Offset: 0x22534B1 VA: 0x22533B0
	private int OccurrenceLottely(List<SubEventMasterDataBase> datas) { }

	// RVA: 0x22535C0 Offset: 0x22536C1 VA: 0x22535C0
	private bool CheckAssistOccurrencePeriod() { }

	// RVA: 0x2253630 Offset: 0x2253731 VA: 0x2253630
	public bool CheckInviteToDating() { }

	// RVA: 0x22536A0 Offset: 0x22537A1 VA: 0x22536A0
	private bool NonOccurringPeriodByEvent() { }

	// RVA: 0x2253220 Offset: 0x2253321 VA: 0x2253220
	private bool NonOccurringPeriod() { }

	// RVA: 0x22534B0 Offset: 0x22535B1 VA: 0x22534B0
	private bool CheckForceOvvurrence() { }

	// RVA: 0x22536B0 Offset: 0x22537B1 VA: 0x22536B0
	private void ProceedSubEventStepNextDay(int diffDay) { }

	// RVA: 0x2253880 Offset: 0x2253981 VA: 0x2253880
	private void ProceedSubEventStepNextTime(int diffSec) { }

	// RVA: 0x22531B0 Offset: 0x22532B1 VA: 0x22531B0
	private bool CheckNoGenerateSubEventByMaking() { }

	// RVA: 0x2253B00 Offset: 0x2253C01 VA: 0x2253B00
	public SubEventMasterDataBase GetSubEventData(int eventId) { }

	// RVA: 0x2253C20 Offset: 0x2253D21 VA: 0x2253C20
	public SubEventData GetOccurrenceSubEventData() { }

	// RVA: 0x2253D40 Offset: 0x2253E41 VA: 0x2253D40
	public int GetOccurrenceSubEventId() { }

	// RVA: 0x2253E80 Offset: 0x2253F81 VA: 0x2253E80
	public int GetOccurrenceLoveEventId() { }

	// RVA: 0x2254010 Offset: 0x2254111 VA: 0x2254010
	public int GetNpcJoinAdvSubEventId(int npcid) { }

	// RVA: 0x22541A0 Offset: 0x22542A1 VA: 0x22541A0
	public bool CheckNpcJoinSubEvent(int npcid) { }

	// RVA: 0x2254350 Offset: 0x2254451 VA: 0x2254350
	public bool CheckNpcJoinSubEventAdv(int npcid, bool isLovEvent = False) { }

	// RVA: 0x22545F0 Offset: 0x22546F1 VA: 0x22545F0
	public int GetOccurrenceSubEventStep(int eventid, int npcid = -1) { }

	// RVA: 0x2254860 Offset: 0x2254961 VA: 0x2254860
	public void ProceedOccurrenceSubEventNpcAdvStep(int eventid, int npcid) { }

	// RVA: 0x22545D0 Offset: 0x22546D1 VA: 0x22545D0
	public bool IsLovEvent(SubEventType type) { }

	// RVA: 0x2254A50 Offset: 0x2254B51 VA: 0x2254A50
	public bool IsDatEvent(SubEventType type) { }

	// RVA: 0x2254A60 Offset: 0x2254B61 VA: 0x2254A60
	public SubEventType GetSubEventType(int eventid) { }

	// RVA: 0x2254B80 Offset: 0x2254C81 VA: 0x2254B80
	public SubEventType GetOccurrenceSubEventType(int eventid) { }

	// RVA: 0x2254CC0 Offset: 0x2254DC1 VA: 0x2254CC0
	public bool CheckNotAllowedNpcId(int npcid) { }

	// RVA: 0x2253310 Offset: 0x2253411 VA: 0x2253310
	private bool CheckOccurrenceSubEventComplete(SubEventMasterDataBase data) { }

	// RVA: 0x2254E20 Offset: 0x2254F21 VA: 0x2254E20
	public bool CheckSubEventComplete(int eventId) { }

	// RVA: 0x2254F80 Offset: 0x2255081 VA: 0x2254F80
	private bool CheckOccurrencedSubEvent(int eventid) { }

	// RVA: 0x22550B0 Offset: 0x22551B1 VA: 0x22550B0
	public bool CheckCanMarriage_ThrowRing(NpcData data) { }

	// RVA: 0x2255250 Offset: 0x2255351 VA: 0x2255250
	public bool CheckCanMarriage(NpcData data) { }

	// RVA: 0x22553C0 Offset: 0x22554C1 VA: 0x22553C0
	public bool CheckCanMarriage_Event(int npcid) { }

	// RVA: 0x2255560 Offset: 0x2255661 VA: 0x2255560
	public int GetProposalEventId(int npcid) { }

	// RVA: 0x22556F0 Offset: 0x22557F1 VA: 0x22556F0
	public int GetKokuhakuEventID(int npcId) { }

	// RVA: 0x2255710 Offset: 0x2255811 VA: 0x2255710
	public int GetProposeEventID(int npcId) { }

	// RVA: 0x2255730 Offset: 0x2255831 VA: 0x2255730
	public int GetLoveDateEventID(int npcId, int dateNum = 1) { }

	// RVA: 0x2255540 Offset: 0x2255641 VA: 0x2255540
	public int GetPreMarriageEventID(int npcId) { }

	// RVA: 0x2255770 Offset: 0x2255871 VA: 0x2255770
	public void KeepNpcEventStep(int npcid, int eventid, int step) { }

	// RVA: 0x2255960 Offset: 0x2255A61 VA: 0x2255960
	public void ReleaseNpcEventStep(int npcid, int eventid) { }

	// RVA: 0x2255970 Offset: 0x2255A71 VA: 0x2255970
	public void ChangeSubEventStep(int id, int step, int day, int time, bool config) { }

	// RVA: 0x2255C50 Offset: 0x2255D51 VA: 0x2255C50
	public void CompleteSubEvent(int id, bool complete = True) { }

	// RVA: 0x2255FB0 Offset: 0x22560B1 VA: 0x2255FB0
	private void DoCompleted(SubEventData data) { }

	// RVA: 0x2256040 Offset: 0x2256141 VA: 0x2256040
	public void NpcJoinSubEventAdv(int npcid, int eventid, int step = -1) { }

	// RVA: 0x2256230 Offset: 0x2256331 VA: 0x2256230
	public void NpcLeaveSubEventAdv(int npcid, int eventid) { }

	// RVA: 0x2256410 Offset: 0x2256511 VA: 0x2256410
	public bool CanReservationDatingEvent(int npcid, SubEventType type = 4) { }

	// RVA: 0x2256770 Offset: 0x2256871 VA: 0x2256770
	public void ReservationDatingEvent(int npcid, int eventid) { }

	// RVA: 0x22565F0 Offset: 0x22566F1 VA: 0x22565F0
	private bool CheckReserveDatingEvent(SubEventMasterDataBase data, int npcid) { }

	// RVA: 0x2256870 Offset: 0x2256971 VA: 0x2256870
	public int GetReservationDatingEventID(int npcId) { }

	// RVA: 0x2255FA0 Offset: 0x22560A1 VA: 0x2255FA0
	public void ReleaseReservationDatingEvent(int EventId) { }

	// RVA: 0x2256880 Offset: 0x2256981 VA: 0x2256880
	public ReservationEventParameter GetReservationDatingData(int npcId) { }

	// RVA: 0x2256890 Offset: 0x2256991 VA: 0x2256890
	public void SetReservationDatingProgressByNpcId(int npcId, DatProgressType type) { }

	// RVA: 0x2256030 Offset: 0x2256131 VA: 0x2256030
	public void SetReservationDatingProgressByEventId(int EventId, DatProgressType type) { }

	// RVA: 0x22568A0 Offset: 0x22569A1 VA: 0x22568A0
	public void LifeCycleLottery() { }

	// RVA: 0x2256900 Offset: 0x2256A01 VA: 0x2256900
	public void DEBUG_AddOccurrenceSubEvent(int eventid) { }

	// RVA: 0x2256D10 Offset: 0x2256E11 VA: 0x2256D10
	public void DEBUG_CompleteOccurrenceSubEvent(int eventid) { }

	// RVA: 0x2256F20 Offset: 0x2257021 VA: 0x2256F20
	public void DEBUG_ViewOccurrenceSubEventList() { }

	// RVA: 0x2256F30 Offset: 0x2257031 VA: 0x2256F30
	public void DEBUG_ViewReservationList() { }

	// RVA: 0x2256F40 Offset: 0x2257041 VA: 0x2256F40
	public void DEBUG_ClearOccurrenceSubEvent() { }

	// RVA: 0x2256FC0 Offset: 0x22570C1 VA: 0x2256FC0
	public int GetSubEventDatasCount() { }

	// RVA: 0x2257010 Offset: 0x2257111 VA: 0x2257010
	public int GetSubEventIdByIndex(int idx) { }

	// RVA: 0x22570F0 Offset: 0x22571F1 VA: 0x22570F0
	public string DEBUG_CheckOccurrenceSubEvent(int id) { }

	// RVA: 0x2257140 Offset: 0x2257241 VA: 0x2257140
	public void DebugRunBirthChildScript(int npcid = -1, int type = -1) { }

	[IteratorStateMachineAttribute] // RVA: 0x19F400 Offset: 0x19F501 VA: 0x19F400
	// RVA: 0x2257220 Offset: 0x2257321 VA: 0x2257220
	private IEnumerator _DebugRunBirthChildScript(int npcid, int type) { }
}

