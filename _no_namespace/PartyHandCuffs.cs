[Serializable]
public class PartyHandCuffs : PartyBase // TypeDefIndex: 6320
{
	// Fields
	private MonsterControllerBase monsterController; // 0x18
	private HandCuffsStatus handCuffsStatusData; // 0x20
	private TimeManager.JustTimerData JustTimePartyOutData; // 0x28

	// Properties
	public override PartyType PartyType { get; }
	public EnemyStatusData StatusData { get; set; }
	public MonsterControllerBase MonsterController { get; set; }
	public override CharacterStatusBase Status { get; }
	public HandCuffsStatus HandCuffsStatus { get; }

	// Methods

	// RVA: 0x1FDF690 Offset: 0x1FDF791 VA: 0x1FDF690 Slot: 4
	public override PartyType get_PartyType() { }

	// RVA: 0x1FDF6B0 Offset: 0x1FDF7B1 VA: 0x1FDF6B0
	public EnemyStatusData get_StatusData() { }

	// RVA: 0x1FDF6D0 Offset: 0x1FDF7D1 VA: 0x1FDF6D0
	public void set_StatusData(EnemyStatusData value) { }

	// RVA: 0x1FDF6F0 Offset: 0x1FDF7F1 VA: 0x1FDF6F0
	public MonsterControllerBase get_MonsterController() { }

	// RVA: 0x1FDF800 Offset: 0x1FDF901 VA: 0x1FDF800
	public void set_MonsterController(MonsterControllerBase value) { }

	// RVA: 0x1FDF810 Offset: 0x1FDF911 VA: 0x1FDF810
	public void .ctor(PartyData data) { }

	// RVA: 0x1FDF860 Offset: 0x1FDF961 VA: 0x1FDF860 Slot: 5
	public override CharacterStatusBase get_Status() { }

	// RVA: 0x1FDF910 Offset: 0x1FDFA11 VA: 0x1FDF910
	public HandCuffsStatus get_HandCuffsStatus() { }

	// RVA: 0x1FDF9B0 Offset: 0x1FDFAB1 VA: 0x1FDF9B0 Slot: 6
	public override void PartyIn() { }

	// RVA: 0x1FDFDA0 Offset: 0x1FDFEA1 VA: 0x1FDFDA0 Slot: 7
	public override void PartyOut() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AC30 Offset: 0x19AD31 VA: 0x19AC30
	// RVA: 0x1FDFEE0 Offset: 0x1FDFFE1 VA: 0x1FDFEE0
	private void <PartyIn>b__16_0(TimeManager.JustTimerData timeData) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AC40 Offset: 0x19AD41 VA: 0x19AC40
	// RVA: 0x1FDFF90 Offset: 0x1FE0091 VA: 0x1FDFF90
	private void <PartyIn>b__16_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AC50 Offset: 0x19AD51 VA: 0x19AC50
	// RVA: 0x1FE00C0 Offset: 0x1FE01C1 VA: 0x1FE00C0
	private void <PartyIn>b__16_2() { }
}

