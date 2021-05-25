[Serializable]
public class NpcStatusData // TypeDefIndex: 8151
{
	// Fields
	public ActorID ActorId; // 0x10
	public string FocusName; // 0x18
	public Gender Gender; // 0x20
	public int Age; // 0x24
	public Place Home; // 0x28
	public Place Job; // 0x2C
	public string BedPatrolPointName; // 0x30
	public PersonalityType[] Personality; // 0x38
	public int[] FavoriteNpcId; // 0x40
	public Season FavoriteSeason; // 0x48
	public int[] FavoriteItem; // 0x50
	public int[] VeryFavoriteItem; // 0x58
	public int[] NotFavoriteItem; // 0x60
	public int[] NotFavoriteBadlyItem; // 0x68
	public string[] NickNameToPlayerTable; // 0x70
	public string[] NickNameFromPlayerTable; // 0x78
	public int LatenessTime; // 0x80
	public bool ScaredThunder; // 0x84
	public float WalkIndividualSpeed; // 0x88
	public string PartnerPersonality; // 0x90
	public string PartnerInitialWeapon; // 0x98
	public string PartnerSpecialSkill; // 0xA0
	public string[] PartnerFavoriteWeapon; // 0xA8
	public SoundID GreetingVoice; // 0xB0
	public SoundID SleepingVoice; // 0xB4
	public ItemID BirthdayPresent; // 0xB8
	public string ReturnGoodsType; // 0xC0
	public ItemID[] EveryDayPresentAfterMarriage; // 0xC8
	public ItemID PresentBath; // 0xD0
	public bool MarriageCandidate; // 0xD4
	public SoundID OmedetouVoice; // 0xD8
	public Place[] FavoritePlace; // 0xE0
	public Place[] HolidayFavoritePlace; // 0xE8
	public SkillID[] ExRandomSkillID; // 0xF0
	public SkillID ExSkillID_A; // 0xF8
	public SkillID ExSkillID_B; // 0xFC
	public ItemID ExRecipeID; // 0x100
	public ItemID[] FesFlowerItem; // 0x108
	public SkillID[] HomeSkillID_A; // 0x110
	public SkillID HomeSkillID_B; // 0x118
	public SkillID HomeSkillID_C; // 0x11C
	public SkillID HomeSkillID_D; // 0x120
	public SkillID HomeSkillID_E; // 0x124
	public SkillID HomeSkillID_F; // 0x128
	public float OffsetSittingPosY; // 0x12C
	public float OffsetSleepingPosY; // 0x130
	public SoundID ChillingVoice; // 0x134
	public SoundID ChillingVoice_Anxiety; // 0x138
	public SoundID[] BathVoice; // 0x140

	// Methods

	// RVA: 0x1D8C5E0 Offset: 0x1D8C6E1 VA: 0x1D8C5E0
	public Gender GetGender() { }

	// RVA: 0x1D8C660 Offset: 0x1D8C761 VA: 0x1D8C660
	public void ExpandItemType() { }

	// RVA: 0x1D8C6A0 Offset: 0x1D8C7A1 VA: 0x1D8C6A0
	private void ExpandItemType(ref int[] itemIds) { }

	// RVA: 0x1D8BBB0 Offset: 0x1D8BCB1 VA: 0x1D8BBB0
	public SoundID GetBathVoice() { }

	// RVA: 0x1D8C8D0 Offset: 0x1D8C9D1 VA: 0x1D8C8D0
	public void .ctor() { }
}

