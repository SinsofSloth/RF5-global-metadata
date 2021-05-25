[MessagePackObjectAttribute] // RVA: 0x146820 Offset: 0x146921 VA: 0x146820
public class NpcSaveParameter // TypeDefIndex: 8109
{
	// Fields
	[KeyAttribute] // RVA: 0x16A5B0 Offset: 0x16A6B1 VA: 0x16A5B0
	public Vector3 SavePosition; // 0x10
	[KeyAttribute] // RVA: 0x16A5F0 Offset: 0x16A6F1 VA: 0x16A5F0
	public Quaternion SaveRotation; // 0x1C
	[KeyAttribute] // RVA: 0x16A630 Offset: 0x16A731 VA: 0x16A630
	public bool forceDisabled; // 0x2C
	[KeyAttribute] // RVA: 0x16A670 Offset: 0x16A771 VA: 0x16A670
	public bool isShortPlay; // 0x2D
	[KeyAttribute] // RVA: 0x16A6B0 Offset: 0x16A7B1 VA: 0x16A6B0
	public NpcAnimState AnimationState; // 0x30
	[KeyAttribute] // RVA: 0x16A6F0 Offset: 0x16A7F1 VA: 0x16A6F0
	public bool AnimationSitting; // 0x34
	[KeyAttribute] // RVA: 0x16A730 Offset: 0x16A831 VA: 0x16A730
	public int NpcGroupId; // 0x38
	[KeyAttribute] // RVA: 0x16A770 Offset: 0x16A871 VA: 0x16A770
	public FieldPlaceId CurrentFieldPlaceId; // 0x3C
	[KeyAttribute] // RVA: 0x16A7B0 Offset: 0x16A8B1 VA: 0x16A7B0
	public LifecycleState CurrentLifecycleState; // 0x40
	[KeyAttribute] // RVA: 0x16A7F0 Offset: 0x16A8F1 VA: 0x16A7F0
	public Place CurrentPlace; // 0x44
	[KeyAttribute] // RVA: 0x16A830 Offset: 0x16A931 VA: 0x16A830
	public int RotatePatternNumber; // 0x48
	[KeyAttribute] // RVA: 0x16A870 Offset: 0x16A971 VA: 0x16A870
	public bool IsTalking; // 0x4C
	[KeyAttribute] // RVA: 0x16A8B0 Offset: 0x16A9B1 VA: 0x16A8B0
	public int TodayTalkCount; // 0x50
	[KeyAttribute] // RVA: 0x16A8F0 Offset: 0x16A9F1 VA: 0x16A8F0
	public int NowEventId; // 0x54
	[KeyAttribute] // RVA: 0x16A930 Offset: 0x16AA31 VA: 0x16A930
	public Place Home; // 0x58
	[KeyAttribute] // RVA: 0x16A970 Offset: 0x16AA71 VA: 0x16A970
	public Place Job; // 0x5C
	[KeyAttribute] // RVA: 0x16A9B0 Offset: 0x16AAB1 VA: 0x16A9B0
	public bool IsPartner; // 0x60
	[KeyAttribute] // RVA: 0x16A9F0 Offset: 0x16AAF1 VA: 0x16A9F0
	public bool IsSpouses; // 0x61
	[KeyAttribute] // RVA: 0x16AA30 Offset: 0x16AB31 VA: 0x16AA30
	public bool IsLover; // 0x62
	[KeyAttribute] // RVA: 0x16AA70 Offset: 0x16AB71 VA: 0x16AA70
	public bool IsRefused; // 0x63
	[KeyAttribute] // RVA: 0x16AAB0 Offset: 0x16ABB1 VA: 0x16AAB0
	public bool IsJealousy; // 0x64
	[KeyAttribute] // RVA: 0x16AAF0 Offset: 0x16ABF1 VA: 0x16AAF0
	public bool IsDateRefrain; // 0x65
	[KeyAttribute] // RVA: 0x16AB30 Offset: 0x16AC31 VA: 0x16AB30
	public bool IsExclamation; // 0x66
	[KeyAttribute] // RVA: 0x16AB70 Offset: 0x16AC71 VA: 0x16AB70
	public int AngryStep; // 0x68
	[KeyAttribute] // RVA: 0x16ABB0 Offset: 0x16ACB1 VA: 0x16ABB0
	public int LovePoint; // 0x6C
	[KeyAttribute] // RVA: 0x16ABF0 Offset: 0x16ACF1 VA: 0x16ABF0
	public int DatingNum; // 0x70
	[KeyAttribute] // RVA: 0x16AC30 Offset: 0x16AD31 VA: 0x16AC30
	public int PresentCount; // 0x74
	[KeyAttribute] // RVA: 0x16AC70 Offset: 0x16AD71 VA: 0x16AC70
	public int NickNameToPlayerId; // 0x78
	[KeyAttribute] // RVA: 0x16ACB0 Offset: 0x16ADB1 VA: 0x16ACB0
	public int NickNameFromPlayerId; // 0x7C
	[KeyAttribute] // RVA: 0x16ACF0 Offset: 0x16ADF1 VA: 0x16ACF0
	public int WeddingAnniversary; // 0x80
	[KeyAttribute] // RVA: 0x16AD30 Offset: 0x16AE31 VA: 0x16AD30
	public List<LovePointManager.FavoriteType> PresentItemTypes; // 0x88
	[KeyAttribute] // RVA: 0x16AD70 Offset: 0x16AE71 VA: 0x16AD70
	public bool IsVoiceSleepPlayed; // 0x90
	[KeyAttribute] // RVA: 0x16ADB0 Offset: 0x16AEB1 VA: 0x16ADB0
	public bool IsVoiceGreeted; // 0x91
	[KeyAttribute] // RVA: 0x16ADF0 Offset: 0x16AEF1 VA: 0x16ADF0
	public long[] TalkedTime; // 0x98
	[KeyAttribute] // RVA: 0x16AE30 Offset: 0x16AF31 VA: 0x16AE30
	public int FriendlyMilestoneTalk; // 0xA0
	[KeyAttribute] // RVA: 0x16AE70 Offset: 0x16AF71 VA: 0x16AE70
	public int ChatTalkLv; // 0xA4
	[KeyAttribute] // RVA: 0x16AEB0 Offset: 0x16AFB1 VA: 0x16AEB0
	public int ChatTalkCount; // 0xA8
	[KeyAttribute] // RVA: 0x16AEF0 Offset: 0x16AFF1 VA: 0x16AEF0
	public int ChatTalkLotteryType; // 0xAC
	[KeyAttribute] // RVA: 0x16AF30 Offset: 0x16B031 VA: 0x16AF30
	public int ChatTalkLotteryID; // 0xB0
	[KeyAttribute] // RVA: 0x16AF70 Offset: 0x16B071 VA: 0x16AF70
	public int HomeTalkedLv; // 0xB4
	[KeyAttribute] // RVA: 0x16AFB0 Offset: 0x16B0B1 VA: 0x16AFB0
	public VariationNo ModelType; // 0xB8
	[KeyAttribute] // RVA: 0x16AFF0 Offset: 0x16B0F1 VA: 0x16AFF0
	public int LoveStroyState; // 0xBC
	[KeyAttribute] // RVA: 0x16B030 Offset: 0x16B131 VA: 0x16B030
	public int FlowerFesDateNum; // 0xC0
	[KeyAttribute] // RVA: 0x16B070 Offset: 0x16B171 VA: 0x16B070
	public bool IsDateReserved; // 0xC4
	[KeyAttribute] // RVA: 0x16B0B0 Offset: 0x16B1B1 VA: 0x16B0B0
	public int dateDay; // 0xC8

	// Methods

	// RVA: 0x1D8B0D0 Offset: 0x1D8B1D1 VA: 0x1D8B0D0
	public void Initialize() { }

	// RVA: 0x1D8B1F0 Offset: 0x1D8B2F1 VA: 0x1D8B1F0
	public void .ctor() { }
}

