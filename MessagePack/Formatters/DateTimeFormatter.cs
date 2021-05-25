public sealed class DateTimeFormatter : IMessagePackFormatter<DateTime>, IMessagePackFormatter // TypeDefIndex: 5498
{
	// Fields
	public static readonly DateTimeFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1654E20 Offset: 0x1654F21 VA: 0x1654E20
	private void .ctor() { }

	// RVA: 0x1654E30 Offset: 0x1654F31 VA: 0x1654E30 Slot: 4
	public void Serialize(ref MessagePackWriter writer, DateTime value, MessagePackSerializerOptions options) { }

	// RVA: 0x1654E40 Offset: 0x1654F41 VA: 0x1654E40 Slot: 5
	public DateTime Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1654E50 Offset: 0x1654F51 VA: 0x1654E50
	private static void .cctor() { }
}

