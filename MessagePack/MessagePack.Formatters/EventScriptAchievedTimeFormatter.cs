public sealed class EventScriptAchievedTimeFormatter : IMessagePackFormatter<EventScriptAchievedTime>, IMessagePackFormatter // TypeDefIndex: 10155
{
	// Methods

	// RVA: 0x243B9E0 Offset: 0x243BAE1 VA: 0x243B9E0
	private static ReadOnlySpan<byte> GetSpan_EventScriptAchievedType() { }

	// RVA: 0x243BA50 Offset: 0x243BB51 VA: 0x243BA50
	private static ReadOnlySpan<byte> GetSpan_AchievedTime() { }

	// RVA: 0x243BAC0 Offset: 0x243BBC1 VA: 0x243BAC0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, EventScriptAchievedTime value, MessagePackSerializerOptions options) { }

	// RVA: 0x243BC10 Offset: 0x243BD11 VA: 0x243BC10 Slot: 5
	public EventScriptAchievedTime Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x243C130 Offset: 0x243C231 VA: 0x243C130
	public void .ctor() { }
}

