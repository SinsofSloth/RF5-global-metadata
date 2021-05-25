[MessagePackObjectAttribute] // RVA: 0x146BC0 Offset: 0x146CC1 VA: 0x146BC0
public class FriendMonsterStatusData : StatusDataBase // TypeDefIndex: 8226
{
	// Fields
	[KeyAttribute] // RVA: 0x16C910 Offset: 0x16CA11 VA: 0x16C910
	public uint DataID; // 0x10C
	[KeyAttribute] // RVA: 0x16C930 Offset: 0x16CA31 VA: 0x16C930
	public string Name; // 0x110
	[KeyAttribute] // RVA: 0x16C950 Offset: 0x16CA51 VA: 0x16C950
	public MonsterDataID MonsterDataID; // 0x118
	[KeyAttribute] // RVA: 0x16C970 Offset: 0x16CA71 VA: 0x16C970
	public MonsterLovePoint LovePoint; // 0x120
	[KeyAttribute] // RVA: 0x16C990 Offset: 0x16CA91 VA: 0x16C990
	public int TimeStamp; // 0x128
	[KeyAttribute] // RVA: 0x16C9B0 Offset: 0x16CAB1 VA: 0x16C9B0
	public FarmManager.FARM_ID FarmId; // 0x12C
	[KeyAttribute] // RVA: 0x16C9D0 Offset: 0x16CAD1 VA: 0x16C9D0
	public int HouseId; // 0x130
	[KeyAttribute] // RVA: 0x16C9F0 Offset: 0x16CAF1 VA: 0x16C9F0
	public int RoomId; // 0x134
	[KeyAttribute] // RVA: 0x16CA10 Offset: 0x16CB11 VA: 0x16CA10
	public int PartyNo; // 0x138
	[KeyAttribute] // RVA: 0x16CA30 Offset: 0x16CB31 VA: 0x16CA30
	public PartnerMovementOrderType PartnerMovementOrderType; // 0x13C
	[KeyAttribute] // RVA: 0x16CA50 Offset: 0x16CB51 VA: 0x16CA50
	public FarmMonsterOrder FarmMonsterOrder; // 0x140
	[KeyAttribute] // RVA: 0x16CA70 Offset: 0x16CB71 VA: 0x16CA70
	public FarmFieldWorkArea FarmFieldWorkArea; // 0x144
	[KeyAttribute] // RVA: 0x16CA90 Offset: 0x16CB91 VA: 0x16CA90
	public bool IsBrushed; // 0x148
	[KeyAttribute] // RVA: 0x16CAB0 Offset: 0x16CBB1 VA: 0x16CAB0
	public bool IsPresent; // 0x149
	[KeyAttribute] // RVA: 0x16CAD0 Offset: 0x16CBD1 VA: 0x16CAD0
	public bool EsaGet; // 0x14A
	[KeyAttribute] // RVA: 0x16CAF0 Offset: 0x16CBF1 VA: 0x16CAF0
	public bool IsWorkedToday; // 0x14B
	[KeyAttribute] // RVA: 0x16CB10 Offset: 0x16CC11 VA: 0x16CB10
	public bool IsSeededToday; // 0x14C
	[KeyAttribute] // RVA: 0x16CB30 Offset: 0x16CC31 VA: 0x16CB30
	public bool IsYieldToday; // 0x14D
	[KeyAttribute] // RVA: 0x16CB50 Offset: 0x16CC51 VA: 0x16CB50
	public int Bonus_HP; // 0x150
	[KeyAttribute] // RVA: 0x16CB70 Offset: 0x16CC71 VA: 0x16CB70
	public int Bonus_STR; // 0x154
	[KeyAttribute] // RVA: 0x16CB90 Offset: 0x16CC91 VA: 0x16CB90
	public int Bonus_INT; // 0x158
	[KeyAttribute] // RVA: 0x16CBB0 Offset: 0x16CCB1 VA: 0x16CBB0
	public int Bonus_VIT; // 0x15C

	// Methods

	[SerializationConstructorAttribute] // RVA: 0x1A6600 Offset: 0x1A6701 VA: 0x1A6600
	// RVA: 0x22AA9D0 Offset: 0x22AAAD1 VA: 0x22AA9D0
	public void .ctor() { }

	// RVA: 0x22AA9E0 Offset: 0x22AAAE1 VA: 0x22AA9E0
	public void Create(uint dataId, string name, EnemyStatusData enemyStatusData) { }
}

