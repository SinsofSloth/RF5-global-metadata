[MessagePackObjectAttribute] // RVA: 0x146230 Offset: 0x146331 VA: 0x146230
[Serializable]
public class EventScheduleData // TypeDefIndex: 7175
{
	// Fields
	[KeyAttribute] // RVA: 0x164200 Offset: 0x164301 VA: 0x164200
	[SerializeField] // RVA: 0x164200 Offset: 0x164301 VA: 0x164200
	public int EventId; // 0x10
	[KeyAttribute] // RVA: 0x164250 Offset: 0x164351 VA: 0x164250
	[SerializeField] // RVA: 0x164250 Offset: 0x164351 VA: 0x164250
	public int EventStep; // 0x14
	[KeyAttribute] // RVA: 0x1642A0 Offset: 0x1643A1 VA: 0x1642A0
	[SerializeField] // RVA: 0x1642A0 Offset: 0x1643A1 VA: 0x1642A0
	public EventTimer[] StartTime; // 0x18
	[KeyAttribute] // RVA: 0x1642F0 Offset: 0x1643F1 VA: 0x1642F0
	[SerializeField] // RVA: 0x1642F0 Offset: 0x1643F1 VA: 0x1642F0
	public EventTimer[] EndTime; // 0x20
	[KeyAttribute] // RVA: 0x164340 Offset: 0x164441 VA: 0x164340
	[SerializeField] // RVA: 0x164340 Offset: 0x164441 VA: 0x164340
	public int JoinNpcNumMin; // 0x28
	[KeyAttribute] // RVA: 0x164390 Offset: 0x164491 VA: 0x164390
	[SerializeField] // RVA: 0x164390 Offset: 0x164491 VA: 0x164390
	public int JoinNpcNumMax; // 0x2C
	[KeyAttribute] // RVA: 0x1643E0 Offset: 0x1644E1 VA: 0x1643E0
	[SerializeField] // RVA: 0x1643E0 Offset: 0x1644E1 VA: 0x1643E0
	public IntArray[] JoinNpcs; // 0x30
	[KeyAttribute] // RVA: 0x164430 Offset: 0x164531 VA: 0x164430
	[SerializeField] // RVA: 0x164430 Offset: 0x164531 VA: 0x164430
	public IntArray[] JoinRateNpcs; // 0x38
	[KeyAttribute] // RVA: 0x164480 Offset: 0x164581 VA: 0x164480
	[SerializeField] // RVA: 0x164480 Offset: 0x164581 VA: 0x164480
	public List<int> DecideJoinNpcs; // 0x40
	[KeyAttribute] // RVA: 0x1644D0 Offset: 0x1645D1 VA: 0x1644D0
	[SerializeField] // RVA: 0x1644D0 Offset: 0x1645D1 VA: 0x1644D0
	public List<int> NpcScoreResults; // 0x48
	[KeyAttribute] // RVA: 0x164520 Offset: 0x164621 VA: 0x164520
	[SerializeField] // RVA: 0x164520 Offset: 0x164621 VA: 0x164520
	public EventData[] NpcEventDatas; // 0x50
	[IgnoreMemberAttribute] // RVA: 0x164570 Offset: 0x164671 VA: 0x164570
	[SerializeField] // RVA: 0x164570 Offset: 0x164671 VA: 0x164570
	public EventProceedRequirement[] EventProceedRequirement; // 0x58

	// Methods

	// RVA: 0x2073380 Offset: 0x2073481 VA: 0x2073380
	public void Initialize() { }

	// RVA: 0x2073540 Offset: 0x2073641 VA: 0x2073540
	public long[] GetEventDateSetting(int eventStep) { }

	// RVA: 0x2073970 Offset: 0x2073A71 VA: 0x2073970
	public bool IsEventOpen() { }

	// RVA: 0x2073B00 Offset: 0x2073C01 VA: 0x2073B00
	public void Proceed() { }

	// RVA: 0x2073BA0 Offset: 0x2073CA1 VA: 0x2073BA0
	public void ProceedEventStep() { }

	// RVA: 0x2074110 Offset: 0x2074211 VA: 0x2074110
	public bool IsExistNpcId(int npcId) { }

	// RVA: 0x2074240 Offset: 0x2074341 VA: 0x2074240
	public void ResetEventStep() { }

	// RVA: 0x2073C50 Offset: 0x2073D51 VA: 0x2073C50
	public void ResetNpcEventStep(long eventStep) { }

	// RVA: 0x2073C60 Offset: 0x2073D61 VA: 0x2073C60
	public void LoadEventAction(long eventStep) { }

	// RVA: 0x2073370 Offset: 0x2073471 VA: 0x2073370
	public void .ctor() { }
}

