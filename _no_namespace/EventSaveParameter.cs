[MessagePackObjectAttribute] // RVA: 0x146190 Offset: 0x146291 VA: 0x146190
public class EventSaveParameter // TypeDefIndex: 7149
{
	// Fields
	[KeyAttribute] // RVA: 0x163660 Offset: 0x163761 VA: 0x163660
	public int CurrentEventId; // 0x10
	[KeyAttribute] // RVA: 0x1636A0 Offset: 0x1637A1 VA: 0x1636A0
	public int CurrentEventStep; // 0x14
	[KeyAttribute] // RVA: 0x1636E0 Offset: 0x1637E1 VA: 0x1636E0
	public bool IsTalking; // 0x18
	[KeyAttribute] // RVA: 0x163720 Offset: 0x163821 VA: 0x163720
	public int SelectMenuGroupId; // 0x1C
	[KeyAttribute] // RVA: 0x163760 Offset: 0x163861 VA: 0x163760
	public bool IsSelectMenu; // 0x20
	[KeyAttribute] // RVA: 0x1637A0 Offset: 0x1638A1 VA: 0x1637A0
	public int TargetNpcId; // 0x24
	[KeyAttribute] // RVA: 0x1637E0 Offset: 0x1638E1 VA: 0x1637E0
	public int[] OrderNpcIds; // 0x28
	[KeyAttribute] // RVA: 0x163820 Offset: 0x163921 VA: 0x163820
	public string ForceScriptName; // 0x30
	[KeyAttribute] // RVA: 0x163860 Offset: 0x163961 VA: 0x163860
	public bool ForceEvent; // 0x38
	[KeyAttribute] // RVA: 0x1638A0 Offset: 0x1639A1 VA: 0x1638A0
	public int orderOccuredId; // 0x3C
	[KeyAttribute] // RVA: 0x1638E0 Offset: 0x1639E1 VA: 0x1638E0
	public EventScheduleData[] EventScheduleDatas; // 0x40
	[KeyAttribute] // RVA: 0x163920 Offset: 0x163A21 VA: 0x163920
	public int bythewayMenuCommandNo; // 0x48
	[KeyAttribute] // RVA: 0x163960 Offset: 0x163A61 VA: 0x163960
	public int bythewayEventStep; // 0x4C
	[KeyAttribute] // RVA: 0x1639A0 Offset: 0x163AA1 VA: 0x1639A0
	public bool Is1stBytheWay; // 0x50
	[KeyAttribute] // RVA: 0x1639E0 Offset: 0x163AE1 VA: 0x1639E0
	public int partnerMenuCommandNo; // 0x54
	[KeyAttribute] // RVA: 0x163A20 Offset: 0x163B21 VA: 0x163A20
	public int partnerEventStep; // 0x58
	[KeyAttribute] // RVA: 0x163A60 Offset: 0x163B61 VA: 0x163A60
	public int eventValue; // 0x5C
	[KeyAttribute] // RVA: 0x163AA0 Offset: 0x163BA1 VA: 0x163AA0
	public bool UseRetentionEventType; // 0x60
	[KeyAttribute] // RVA: 0x163AE0 Offset: 0x163BE1 VA: 0x163AE0
	public List<EventUnlockFlagData> ReservedEventStartPoints; // 0x68
	[KeyAttribute] // RVA: 0x163B20 Offset: 0x163C21 VA: 0x163B20
	public Place NowPlace; // 0x70
	[KeyAttribute] // RVA: 0x163B60 Offset: 0x163C61 VA: 0x163B60
	public int FlagTalkIndex; // 0x74
	[KeyAttribute] // RVA: 0x163BA0 Offset: 0x163CA1 VA: 0x163BA0
	public bool IsSleepScriptCalled; // 0x78
	[KeyAttribute] // RVA: 0x163BE0 Offset: 0x163CE1 VA: 0x163BE0
	public bool IsWakeUpReserve; // 0x79
	[KeyAttribute] // RVA: 0x163C20 Offset: 0x163D21 VA: 0x163C20
	public bool[] EventCheckTypeFlag; // 0x80
	[KeyAttribute] // RVA: 0x163C60 Offset: 0x163D61 VA: 0x163C60
	public int[] EventCheckType; // 0x88
	[KeyAttribute] // RVA: 0x163CA0 Offset: 0x163DA1 VA: 0x163CA0
	public List<EventCheckId> EventCheckIds; // 0x90
	[KeyAttribute] // RVA: 0x163CE0 Offset: 0x163DE1 VA: 0x163CE0
	public NpcEventType NowType; // 0x98
	[KeyAttribute] // RVA: 0x163D20 Offset: 0x163E21 VA: 0x163D20
	public int[] LastYearFesVictoryNpcId; // 0xA0
	[KeyAttribute] // RVA: 0x163D60 Offset: 0x163E61 VA: 0x163D60
	public bool SP4CharaOn; // 0xA8

	// Methods

	// RVA: 0x2072F30 Offset: 0x2073031 VA: 0x2072F30
	public void Initialize() { }

	// RVA: 0x20734B0 Offset: 0x20735B1 VA: 0x20734B0
	public void .ctor() { }
}

