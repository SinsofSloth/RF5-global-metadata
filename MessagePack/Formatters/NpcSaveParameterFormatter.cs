public sealed class NpcSaveParameterFormatter : IMessagePackFormatter<NpcSaveParameter>, IMessagePackFormatter // TypeDefIndex: 10164
{
	// Methods

	// RVA: 0x2349D00 Offset: 0x2349E01 VA: 0x2349D00
	private static ReadOnlySpan<byte> GetSpan_SavePosition() { }

	// RVA: 0x2349D70 Offset: 0x2349E71 VA: 0x2349D70
	private static ReadOnlySpan<byte> GetSpan_SaveRotation() { }

	// RVA: 0x2349DE0 Offset: 0x2349EE1 VA: 0x2349DE0
	private static ReadOnlySpan<byte> GetSpan_forceDisabled() { }

	// RVA: 0x2349E50 Offset: 0x2349F51 VA: 0x2349E50
	private static ReadOnlySpan<byte> GetSpan_isShortPlay() { }

	// RVA: 0x2349EC0 Offset: 0x2349FC1 VA: 0x2349EC0
	private static ReadOnlySpan<byte> GetSpan_AnimationState() { }

	// RVA: 0x2349F30 Offset: 0x234A031 VA: 0x2349F30
	private static ReadOnlySpan<byte> GetSpan_AnimationSitting() { }

	// RVA: 0x2349FA0 Offset: 0x234A0A1 VA: 0x2349FA0
	private static ReadOnlySpan<byte> GetSpan_NpcGroupId() { }

	// RVA: 0x234A010 Offset: 0x234A111 VA: 0x234A010
	private static ReadOnlySpan<byte> GetSpan_CurrentFieldPlaceId() { }

	// RVA: 0x234A080 Offset: 0x234A181 VA: 0x234A080
	private static ReadOnlySpan<byte> GetSpan_CurrentLifecycleState() { }

	// RVA: 0x234A0F0 Offset: 0x234A1F1 VA: 0x234A0F0
	private static ReadOnlySpan<byte> GetSpan_CurrentPlace() { }

	// RVA: 0x234A160 Offset: 0x234A261 VA: 0x234A160
	private static ReadOnlySpan<byte> GetSpan_RotatePatternNumber() { }

	// RVA: 0x234A1D0 Offset: 0x234A2D1 VA: 0x234A1D0
	private static ReadOnlySpan<byte> GetSpan_IsTalking() { }

	// RVA: 0x234A240 Offset: 0x234A341 VA: 0x234A240
	private static ReadOnlySpan<byte> GetSpan_TodayTalkCount() { }

	// RVA: 0x234A2B0 Offset: 0x234A3B1 VA: 0x234A2B0
	private static ReadOnlySpan<byte> GetSpan_NowEventId() { }

	// RVA: 0x234A320 Offset: 0x234A421 VA: 0x234A320
	private static ReadOnlySpan<byte> GetSpan_Home() { }

	// RVA: 0x234A390 Offset: 0x234A491 VA: 0x234A390
	private static ReadOnlySpan<byte> GetSpan_Job() { }

	// RVA: 0x234A400 Offset: 0x234A501 VA: 0x234A400
	private static ReadOnlySpan<byte> GetSpan_IsPartner() { }

	// RVA: 0x234A470 Offset: 0x234A571 VA: 0x234A470
	private static ReadOnlySpan<byte> GetSpan_IsSpouses() { }

	// RVA: 0x234A4E0 Offset: 0x234A5E1 VA: 0x234A4E0
	private static ReadOnlySpan<byte> GetSpan_IsLover() { }

	// RVA: 0x234A550 Offset: 0x234A651 VA: 0x234A550
	private static ReadOnlySpan<byte> GetSpan_IsRefused() { }

	// RVA: 0x234A5C0 Offset: 0x234A6C1 VA: 0x234A5C0
	private static ReadOnlySpan<byte> GetSpan_IsJealousy() { }

	// RVA: 0x234A630 Offset: 0x234A731 VA: 0x234A630
	private static ReadOnlySpan<byte> GetSpan_IsDateRefrain() { }

	// RVA: 0x234A6A0 Offset: 0x234A7A1 VA: 0x234A6A0
	private static ReadOnlySpan<byte> GetSpan_IsExclamation() { }

	// RVA: 0x234A710 Offset: 0x234A811 VA: 0x234A710
	private static ReadOnlySpan<byte> GetSpan_AngryStep() { }

	// RVA: 0x234A780 Offset: 0x234A881 VA: 0x234A780
	private static ReadOnlySpan<byte> GetSpan_LovePoint() { }

	// RVA: 0x234A7F0 Offset: 0x234A8F1 VA: 0x234A7F0
	private static ReadOnlySpan<byte> GetSpan_DatingNum() { }

	// RVA: 0x234A860 Offset: 0x234A961 VA: 0x234A860
	private static ReadOnlySpan<byte> GetSpan_PresentCount() { }

	// RVA: 0x234A8D0 Offset: 0x234A9D1 VA: 0x234A8D0
	private static ReadOnlySpan<byte> GetSpan_NickNameToPlayerId() { }

	// RVA: 0x234A940 Offset: 0x234AA41 VA: 0x234A940
	private static ReadOnlySpan<byte> GetSpan_NickNameFromPlayerId() { }

	// RVA: 0x234A9B0 Offset: 0x234AAB1 VA: 0x234A9B0
	private static ReadOnlySpan<byte> GetSpan_WeddingAnniversary() { }

	// RVA: 0x234AA20 Offset: 0x234AB21 VA: 0x234AA20
	private static ReadOnlySpan<byte> GetSpan_PresentItemTypes() { }

	// RVA: 0x234AA90 Offset: 0x234AB91 VA: 0x234AA90
	private static ReadOnlySpan<byte> GetSpan_IsVoiceSleepPlayed() { }

	// RVA: 0x234AB00 Offset: 0x234AC01 VA: 0x234AB00
	private static ReadOnlySpan<byte> GetSpan_IsVoiceGreeted() { }

	// RVA: 0x234AB70 Offset: 0x234AC71 VA: 0x234AB70
	private static ReadOnlySpan<byte> GetSpan_TalkedTime() { }

	// RVA: 0x234ABE0 Offset: 0x234ACE1 VA: 0x234ABE0
	private static ReadOnlySpan<byte> GetSpan_FriendlyMilestoneTalk() { }

	// RVA: 0x234AC50 Offset: 0x234AD51 VA: 0x234AC50
	private static ReadOnlySpan<byte> GetSpan_ChatTalkLv() { }

	// RVA: 0x234ACC0 Offset: 0x234ADC1 VA: 0x234ACC0
	private static ReadOnlySpan<byte> GetSpan_ChatTalkCount() { }

	// RVA: 0x234AD30 Offset: 0x234AE31 VA: 0x234AD30
	private static ReadOnlySpan<byte> GetSpan_ChatTalkLotteryType() { }

	// RVA: 0x234ADA0 Offset: 0x234AEA1 VA: 0x234ADA0
	private static ReadOnlySpan<byte> GetSpan_ChatTalkLotteryID() { }

	// RVA: 0x234AE10 Offset: 0x234AF11 VA: 0x234AE10
	private static ReadOnlySpan<byte> GetSpan_HomeTalkedLv() { }

	// RVA: 0x234AE80 Offset: 0x234AF81 VA: 0x234AE80
	private static ReadOnlySpan<byte> GetSpan_ModelType() { }

	// RVA: 0x234AEF0 Offset: 0x234AFF1 VA: 0x234AEF0
	private static ReadOnlySpan<byte> GetSpan_LoveStroyState() { }

	// RVA: 0x234AF60 Offset: 0x234B061 VA: 0x234AF60
	private static ReadOnlySpan<byte> GetSpan_FlowerFesDateNum() { }

	// RVA: 0x234AFD0 Offset: 0x234B0D1 VA: 0x234AFD0
	private static ReadOnlySpan<byte> GetSpan_IsDateReserved() { }

	// RVA: 0x234B040 Offset: 0x234B141 VA: 0x234B040
	private static ReadOnlySpan<byte> GetSpan_dateDay() { }

	// RVA: 0x234B0B0 Offset: 0x234B1B1 VA: 0x234B0B0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, NpcSaveParameter value, MessagePackSerializerOptions options) { }

	// RVA: 0x234CF50 Offset: 0x234D051 VA: 0x234CF50 Slot: 5
	public NpcSaveParameter Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x234FF10 Offset: 0x2350011 VA: 0x234FF10
	public void .ctor() { }
}

