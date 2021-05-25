public sealed class EventSaveParameterFormatter : IMessagePackFormatter<EventSaveParameter>, IMessagePackFormatter // TypeDefIndex: 10153
{
	// Methods

	// RVA: 0x24350B0 Offset: 0x24351B1 VA: 0x24350B0
	private static ReadOnlySpan<byte> GetSpan_CurrentEventId() { }

	// RVA: 0x2435120 Offset: 0x2435221 VA: 0x2435120
	private static ReadOnlySpan<byte> GetSpan_CurrentEventStep() { }

	// RVA: 0x2435190 Offset: 0x2435291 VA: 0x2435190
	private static ReadOnlySpan<byte> GetSpan_IsTalking() { }

	// RVA: 0x2435200 Offset: 0x2435301 VA: 0x2435200
	private static ReadOnlySpan<byte> GetSpan_SelectMenuGroupId() { }

	// RVA: 0x2435270 Offset: 0x2435371 VA: 0x2435270
	private static ReadOnlySpan<byte> GetSpan_IsSelectMenu() { }

	// RVA: 0x24352E0 Offset: 0x24353E1 VA: 0x24352E0
	private static ReadOnlySpan<byte> GetSpan_TargetNpcId() { }

	// RVA: 0x2435350 Offset: 0x2435451 VA: 0x2435350
	private static ReadOnlySpan<byte> GetSpan_OrderNpcIds() { }

	// RVA: 0x24353C0 Offset: 0x24354C1 VA: 0x24353C0
	private static ReadOnlySpan<byte> GetSpan_ForceScriptName() { }

	// RVA: 0x2435430 Offset: 0x2435531 VA: 0x2435430
	private static ReadOnlySpan<byte> GetSpan_ForceEvent() { }

	// RVA: 0x24354A0 Offset: 0x24355A1 VA: 0x24354A0
	private static ReadOnlySpan<byte> GetSpan_orderOccuredId() { }

	// RVA: 0x2435510 Offset: 0x2435611 VA: 0x2435510
	private static ReadOnlySpan<byte> GetSpan_EventScheduleDatas() { }

	// RVA: 0x2435580 Offset: 0x2435681 VA: 0x2435580
	private static ReadOnlySpan<byte> GetSpan_bythewayMenuCommandNo() { }

	// RVA: 0x24355F0 Offset: 0x24356F1 VA: 0x24355F0
	private static ReadOnlySpan<byte> GetSpan_bythewayEventStep() { }

	// RVA: 0x2435660 Offset: 0x2435761 VA: 0x2435660
	private static ReadOnlySpan<byte> GetSpan_Is1stBytheWay() { }

	// RVA: 0x24356D0 Offset: 0x24357D1 VA: 0x24356D0
	private static ReadOnlySpan<byte> GetSpan_partnerMenuCommandNo() { }

	// RVA: 0x2435740 Offset: 0x2435841 VA: 0x2435740
	private static ReadOnlySpan<byte> GetSpan_partnerEventStep() { }

	// RVA: 0x24357B0 Offset: 0x24358B1 VA: 0x24357B0
	private static ReadOnlySpan<byte> GetSpan_eventValue() { }

	// RVA: 0x2435820 Offset: 0x2435921 VA: 0x2435820
	private static ReadOnlySpan<byte> GetSpan_UseRetentionEventType() { }

	// RVA: 0x2435890 Offset: 0x2435991 VA: 0x2435890
	private static ReadOnlySpan<byte> GetSpan_ReservedEventStartPoints() { }

	// RVA: 0x2435900 Offset: 0x2435A01 VA: 0x2435900
	private static ReadOnlySpan<byte> GetSpan_NowPlace() { }

	// RVA: 0x2435970 Offset: 0x2435A71 VA: 0x2435970
	private static ReadOnlySpan<byte> GetSpan_FlagTalkIndex() { }

	// RVA: 0x24359E0 Offset: 0x2435AE1 VA: 0x24359E0
	private static ReadOnlySpan<byte> GetSpan_IsSleepScriptCalled() { }

	// RVA: 0x2435A50 Offset: 0x2435B51 VA: 0x2435A50
	private static ReadOnlySpan<byte> GetSpan_IsWakeUpReserve() { }

	// RVA: 0x2435AC0 Offset: 0x2435BC1 VA: 0x2435AC0
	private static ReadOnlySpan<byte> GetSpan_EventCheckTypeFlag() { }

	// RVA: 0x2435B30 Offset: 0x2435C31 VA: 0x2435B30
	private static ReadOnlySpan<byte> GetSpan_EventCheckType() { }

	// RVA: 0x2435BA0 Offset: 0x2435CA1 VA: 0x2435BA0
	private static ReadOnlySpan<byte> GetSpan_EventCheckIds() { }

	// RVA: 0x2435C10 Offset: 0x2435D11 VA: 0x2435C10
	private static ReadOnlySpan<byte> GetSpan_NowType() { }

	// RVA: 0x2435C80 Offset: 0x2435D81 VA: 0x2435C80
	private static ReadOnlySpan<byte> GetSpan_LastYearFesVictoryNpcId() { }

	// RVA: 0x2435CF0 Offset: 0x2435DF1 VA: 0x2435CF0
	private static ReadOnlySpan<byte> GetSpan_SP4CharaOn() { }

	// RVA: 0x2435D60 Offset: 0x2435E61 VA: 0x2435D60 Slot: 4
	public void Serialize(ref MessagePackWriter writer, EventSaveParameter value, MessagePackSerializerOptions options) { }

	// RVA: 0x2437280 Offset: 0x2437381 VA: 0x2437280 Slot: 5
	public EventSaveParameter Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x2439B90 Offset: 0x2439C91 VA: 0x2439B90
	public void .ctor() { }
}

