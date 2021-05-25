public sealed class EventTimerFormatter : IMessagePackFormatter<EventTimer>, IMessagePackFormatter // TypeDefIndex: 10156
{
	// Methods

	// RVA: 0x243C140 Offset: 0x243C241 VA: 0x243C140
	private static ReadOnlySpan<byte> GetSpan_Year() { }

	// RVA: 0x243C1B0 Offset: 0x243C2B1 VA: 0x243C1B0
	private static ReadOnlySpan<byte> GetSpan_Season() { }

	// RVA: 0x243C220 Offset: 0x243C321 VA: 0x243C220
	private static ReadOnlySpan<byte> GetSpan_Week() { }

	// RVA: 0x243C290 Offset: 0x243C391 VA: 0x243C290
	private static ReadOnlySpan<byte> GetSpan_Day() { }

	// RVA: 0x243C300 Offset: 0x243C401 VA: 0x243C300
	private static ReadOnlySpan<byte> GetSpan_Hour() { }

	// RVA: 0x243C370 Offset: 0x243C471 VA: 0x243C370
	private static ReadOnlySpan<byte> GetSpan_Minutes() { }

	// RVA: 0x243C3E0 Offset: 0x243C4E1 VA: 0x243C3E0
	private static ReadOnlySpan<byte> GetSpan_TimeZone() { }

	// RVA: 0x243C450 Offset: 0x243C551 VA: 0x243C450
	private static ReadOnlySpan<byte> GetSpan_Weather() { }

	// RVA: 0x243C4C0 Offset: 0x243C5C1 VA: 0x243C4C0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, EventTimer value, MessagePackSerializerOptions options) { }

	// RVA: 0x243CB20 Offset: 0x243CC21 VA: 0x243CB20 Slot: 5
	public EventTimer Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x243D160 Offset: 0x243D261 VA: 0x243D160
	public void .ctor() { }
}

