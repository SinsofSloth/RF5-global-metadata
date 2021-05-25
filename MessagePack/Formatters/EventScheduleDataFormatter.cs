public sealed class EventScheduleDataFormatter : IMessagePackFormatter<EventScheduleData>, IMessagePackFormatter // TypeDefIndex: 10154
{
	// Methods

	// RVA: 0x2439BA0 Offset: 0x2439CA1 VA: 0x2439BA0
	private static ReadOnlySpan<byte> GetSpan_EventId() { }

	// RVA: 0x2439C10 Offset: 0x2439D11 VA: 0x2439C10
	private static ReadOnlySpan<byte> GetSpan_EventStep() { }

	// RVA: 0x2439C80 Offset: 0x2439D81 VA: 0x2439C80
	private static ReadOnlySpan<byte> GetSpan_StartTime() { }

	// RVA: 0x2439CF0 Offset: 0x2439DF1 VA: 0x2439CF0
	private static ReadOnlySpan<byte> GetSpan_EndTime() { }

	// RVA: 0x2439D60 Offset: 0x2439E61 VA: 0x2439D60
	private static ReadOnlySpan<byte> GetSpan_JoinNpcNumMin() { }

	// RVA: 0x2439DD0 Offset: 0x2439ED1 VA: 0x2439DD0
	private static ReadOnlySpan<byte> GetSpan_JoinNpcNumMax() { }

	// RVA: 0x2439E40 Offset: 0x2439F41 VA: 0x2439E40
	private static ReadOnlySpan<byte> GetSpan_JoinNpcs() { }

	// RVA: 0x2439EB0 Offset: 0x2439FB1 VA: 0x2439EB0
	private static ReadOnlySpan<byte> GetSpan_JoinRateNpcs() { }

	// RVA: 0x2439F20 Offset: 0x243A021 VA: 0x2439F20
	private static ReadOnlySpan<byte> GetSpan_DecideJoinNpcs() { }

	// RVA: 0x2439F90 Offset: 0x243A091 VA: 0x2439F90
	private static ReadOnlySpan<byte> GetSpan_NpcScoreResults() { }

	// RVA: 0x243A000 Offset: 0x243A101 VA: 0x243A000
	private static ReadOnlySpan<byte> GetSpan_NpcEventDatas() { }

	// RVA: 0x243A070 Offset: 0x243A171 VA: 0x243A070 Slot: 4
	public void Serialize(ref MessagePackWriter writer, EventScheduleData value, MessagePackSerializerOptions options) { }

	// RVA: 0x243AA40 Offset: 0x243AB41 VA: 0x243AA40 Slot: 5
	public EventScheduleData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x243B9D0 Offset: 0x243BAD1 VA: 0x243B9D0
	public void .ctor() { }
}

