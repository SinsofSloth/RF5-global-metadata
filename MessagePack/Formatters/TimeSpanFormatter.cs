public sealed class TimeSpanFormatter : IMessagePackFormatter<TimeSpan>, IMessagePackFormatter // TypeDefIndex: 5425
{
	// Fields
	public static readonly IMessagePackFormatter<TimeSpan> Instance; // 0x0

	// Methods

	// RVA: 0x1662310 Offset: 0x1662411 VA: 0x1662310
	private void .ctor() { }

	// RVA: 0x1662320 Offset: 0x1662421 VA: 0x1662320 Slot: 4
	public void Serialize(ref MessagePackWriter writer, TimeSpan value, MessagePackSerializerOptions options) { }

	// RVA: 0x1662330 Offset: 0x1662431 VA: 0x1662330 Slot: 5
	public TimeSpan Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1662340 Offset: 0x1662441 VA: 0x1662340
	private static void .cctor() { }
}

