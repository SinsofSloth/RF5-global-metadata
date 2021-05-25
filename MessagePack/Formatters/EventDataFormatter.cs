public sealed class EventDataFormatter : IMessagePackFormatter<EventData>, IMessagePackFormatter // TypeDefIndex: 10152
{
	// Methods

	// RVA: 0x2433540 Offset: 0x2433641 VA: 0x2433540
	private static ReadOnlySpan<byte> GetSpan_EventId() { }

	// RVA: 0x24335B0 Offset: 0x24336B1 VA: 0x24335B0
	private static ReadOnlySpan<byte> GetSpan_EventState() { }

	// RVA: 0x2433620 Offset: 0x2433721 VA: 0x2433620
	private static ReadOnlySpan<byte> GetSpan_OrderId() { }

	// RVA: 0x2433690 Offset: 0x2433791 VA: 0x2433690
	private static ReadOnlySpan<byte> GetSpan_CurrentStep() { }

	// RVA: 0x2433700 Offset: 0x2433801 VA: 0x2433700
	private static ReadOnlySpan<byte> GetSpan_CurrentReservedStep() { }

	// RVA: 0x2433770 Offset: 0x2433871 VA: 0x2433770
	private static ReadOnlySpan<byte> GetSpan_NextStep() { }

	// RVA: 0x24337E0 Offset: 0x24338E1 VA: 0x24337E0
	private static ReadOnlySpan<byte> GetSpan_CurrentNpcEventType() { }

	// RVA: 0x2433850 Offset: 0x2433951 VA: 0x2433850
	private static ReadOnlySpan<byte> GetSpan_CurrentNpcEventPath() { }

	// RVA: 0x24338C0 Offset: 0x24339C1 VA: 0x24338C0
	private static ReadOnlySpan<byte> GetSpan_CurrentTargetEventStep() { }

	// RVA: 0x2433930 Offset: 0x2433A31 VA: 0x2433930
	private static ReadOnlySpan<byte> GetSpan_SubEventSteps() { }

	// RVA: 0x24339A0 Offset: 0x2433AA1 VA: 0x24339A0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, EventData value, MessagePackSerializerOptions options) { }

	// RVA: 0x2434100 Offset: 0x2434201 VA: 0x2434100 Slot: 5
	public EventData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x24350A0 Offset: 0x24351A1 VA: 0x24350A0
	public void .ctor() { }
}

