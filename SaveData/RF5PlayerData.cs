public class RF5PlayerData : SaveDataValueBase // TypeDefIndex: 9895
{
	// Fields
	public int PlayerGold; // 0x10
	public string PlayerName; // 0x18
	public bool IsPlayerMale; // 0x20
	public bool IsPlayerModelMale; // 0x21
	public VariationNo VariationNo; // 0x24
	public int PlayerBirthDay; // 0x28
	public NPCID MarriedNPCID; // 0x2C
	public int SeedPoint; // 0x30
	public PoliceRank PoliceRank; // 0x34
	public int Stone; // 0x38
	public int Lumber; // 0x3C
	public int Compost; // 0x40
	public int Esa; // 0x44
	public int DailyRecipePan_Bakery; // 0x48
	public int DailyRecipePan_Restaurant; // 0x4C
	public int BathroomBlocked; // 0x50
	public SkillData[] SkillDatas; // 0x58
	public ActorID DualSmithActor; // 0x60
	public ActorID DualCookActor; // 0x64
	public ActorID DualFishingActor; // 0x68

	// Methods

	// RVA: 0x1D7C740 Offset: 0x1D7C841 VA: 0x1D7C740
	public int GetPlayerBirthSeason() { }

	// RVA: 0x1D7C760 Offset: 0x1D7C861 VA: 0x1D7C760
	public int GetPlayerBirthDay() { }

	// RVA: 0x1D7C790 Offset: 0x1D7C891 VA: 0x1D7C790
	public void SetPlayerBirthDay(int day, int season) { }

	// RVA: 0x1D7C7A0 Offset: 0x1D7C8A1 VA: 0x1D7C7A0
	public void .ctor() { }

	// RVA: 0x1D7C7D0 Offset: 0x1D7C8D1 VA: 0x1D7C7D0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D7C920 Offset: 0x1D7CA21 VA: 0x1D7C920 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D7C930 Offset: 0x1D7CA31 VA: 0x1D7C930 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D7C940 Offset: 0x1D7CA41 VA: 0x1D7C940 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D7CB40 Offset: 0x1D7CC41 VA: 0x1D7CB40
	public void Reader0000(BinaryReader reader) { }
}

