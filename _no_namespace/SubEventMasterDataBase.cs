[Serializable]
public class SubEventMasterDataBase // TypeDefIndex: 7287
{
	// Fields
	[SerializeField] // RVA: 0x165490 Offset: 0x165591 VA: 0x165490
	public SubEventType EventType; // 0x10
	[SerializeField] // RVA: 0x1654A0 Offset: 0x1655A1 VA: 0x1654A0
	public int EventId; // 0x14
	[SerializeField] // RVA: 0x1654B0 Offset: 0x1655B1 VA: 0x1654B0
	public int OccurrenceRate; // 0x18
	[SerializeField] // RVA: 0x1654C0 Offset: 0x1655C1 VA: 0x1654C0
	public bool IsRepetitionOccurrence; // 0x1C
	[SerializeField] // RVA: 0x1654D0 Offset: 0x1655D1 VA: 0x1654D0
	public Gender OccurrenceGender; // 0x20
	[SerializeField] // RVA: 0x1654E0 Offset: 0x1655E1 VA: 0x1654E0
	public int OccurrenceLoveProgress; // 0x24
	[SerializeField] // RVA: 0x1654F0 Offset: 0x1655F1 VA: 0x1654F0
	public Weather OccurrenceWeather; // 0x28
	[SerializeField] // RVA: 0x165500 Offset: 0x165601 VA: 0x165500
	public int DatingNum; // 0x2C
	[SerializeField] // RVA: 0x165510 Offset: 0x165611 VA: 0x165510
	public int[] TargetNpcId; // 0x30
	[SerializeField] // RVA: 0x165520 Offset: 0x165621 VA: 0x165520
	public int[] NpcLoveLv; // 0x38
	[SerializeField] // RVA: 0x165530 Offset: 0x165631 VA: 0x165530
	public int[] OccurrenceScriptFlag; // 0x40
	[SerializeField] // RVA: 0x165540 Offset: 0x165641 VA: 0x165540
	public int[] OccurrenceSubEventCmpFlag; // 0x48
	[SerializeField] // RVA: 0x165550 Offset: 0x165651 VA: 0x165550
	public int[] OccurrenceItemId; // 0x50
	[SerializeField] // RVA: 0x165560 Offset: 0x165661 VA: 0x165560
	public int[] JoinNpcId; // 0x58
	[SerializeField] // RVA: 0x165570 Offset: 0x165671 VA: 0x165570
	public int[] NotAllowedNpcId; // 0x60

	// Methods

	// RVA: 0x1C61E90 Offset: 0x1C61F91 VA: 0x1C61E90
	public void Initialize(int num = 10) { }

	// RVA: 0x1C61FC0 Offset: 0x1C620C1 VA: 0x1C61FC0
	public bool CheckOccurrenceWeather() { }

	// RVA: 0x1C62050 Offset: 0x1C62151 VA: 0x1C62050
	public bool CheckDatingNum(int npcid) { }

	// RVA: 0x1C62130 Offset: 0x1C62231 VA: 0x1C62130
	public bool CheckOccurrenceStoryFlag() { }

	// RVA: 0x1C62140 Offset: 0x1C62241 VA: 0x1C62140
	public bool CheckOccurrenceScriptFlag() { }

	// RVA: 0x1C62230 Offset: 0x1C62331 VA: 0x1C62230
	public bool CheckScriptFlag(int eventScriptFlagID) { }

	// RVA: 0x1C622A0 Offset: 0x1C623A1 VA: 0x1C622A0
	public bool CheckOppositeGender() { }

	// RVA: 0x1C62330 Offset: 0x1C62431 VA: 0x1C62330
	public bool CheckOccurrenceLoveProgress() { }

	// RVA: 0x1C62520 Offset: 0x1C62621 VA: 0x1C62520
	public bool CheckLoveLv() { }

	// RVA: 0x1C62630 Offset: 0x1C62731 VA: 0x1C62630
	public bool CheckNotAllowedNpcId(int npcid) { }

	// RVA: 0x1C626A0 Offset: 0x1C627A1 VA: 0x1C626A0
	public bool CheckNotAllowedNpcInPartner() { }

	// RVA: 0x1C62760 Offset: 0x1C62861 VA: 0x1C62760
	public bool CheckOccurrenceItemId() { }

	// RVA: 0x1C62A10 Offset: 0x1C62B11 VA: 0x1C62A10
	public void .ctor() { }
}

